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

		internal bool KFNBKFELFLH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LNDGINDKPFA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool OLIGLEMPFOP(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool DBFPGFHEGKA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool MEMPOPNAEDN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LLNDDFGPOPL(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool GBKBDKHPLKG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool JKEDCEOCPJO(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LOEAMHGMMPK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BFEABMIFIEE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool PBCAHKDLFPE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BKNHHGBPLGH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool AEINPAGJFME(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BDGDIDPDBHG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}
	}

	[CompilerGenerated]
	private sealed class LEMIJMHKLLM
	{
		internal int EGMPIBBOEMH;

		internal ItemsHandler ADPIKBBAKHP;

		internal bool BMAOCLKPNNC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool IGFOBPKFCDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool EKHOOPGPPGE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool FIPCLHEKKCA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
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

		internal bool AGJKEBOPIOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LHHFJBIAHCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool OLIGLEMPFOP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool OFHCGKJFGDI(InventoryItemData IACGDFHKCAE)
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

		internal bool FFEGPHJKMFK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool JDELIMPGFDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool PIJAOCFAPKC(InventoryItemData IACGDFHKCAE)
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

		internal bool EGKGJJGAPMN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool DNIMHEKGJHB(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool FJDBPPKABJE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool HBJFIOJFBHC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool DKGPCPBNDPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool BFEABMIFIEE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool FCAGEDLBBHD(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool KGKMOLCPDIH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}
	}

	[CompilerGenerated]
	private sealed class MOKFDBBHABE
	{
		internal string JMMILEFMACB;

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
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

		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}
	}

	[CompilerGenerated]
	private sealed class MOCPGDGNNCN
	{
		internal InventoryItemType CJEIKDHCCOI;

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}
	}

	[CompilerGenerated]
	private sealed class FPDJBMKIHEE
	{
		internal ulong MOANAJGGPLK;

		internal bool BBIADFAPKDL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DNIMHEKGJHB(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FMIHBNPKEEO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool GLHKGBNIHFH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MAGEPMCPGOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MPGGBMMPNDH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FCAGEDLBBHD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AGFDCBCBAGI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FDAIFOAGDLA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AEIFJLBBKBP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PIJAOCFAPKC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JBCHBMKPDAJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PKAPLCFHDOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EFAPFFFGOOA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OMBHIBNMFNB(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AKDOOLPMPMG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EDGAPOPEIJF(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BJMAIJDIKCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LJDLIIIPIIJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MGENGAEDACG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JBAJEMGOPDL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BEBAENEJFLD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool INHOEMCLAAP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PCDFLCEIHFF(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OFLDIMDDLHM(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FHIJCPPECHA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FHFECFLBHMA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}
	}

	[CompilerGenerated]
	private sealed class FNJCOMEGJBM
	{
		internal InventoryItemData DBIMJHMKHNK;

		internal bool JKEDCEOCPJO(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LHHFJBIAHCN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BKNHHGBPLGH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FHFECFLBHMA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool IGFOBPKFCDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FCAGEDLBBHD(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LJDLIIIPIIJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool PIJAOCFAPKC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LOEAMHGMMPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BJMAIJDIKCN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool MGENGAEDACG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool HBJFIOJFBHC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool PBCAHKDLFPE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DKGPCPBNDPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LNDGINDKPFA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool KGKMOLCPDIH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool JBAJEMGOPDL(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FFEGPHJKMFK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FDAIFOAGDLA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool JDELIMPGFDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FIPCLHEKKCA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool AEINPAGJFME(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FHIJCPPECHA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BDGDIDPDBHG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool MEMPOPNAEDN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool AEIFJLBBKBP(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool EKHOOPGPPGE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FJDBPPKABJE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool EGKGJJGAPMN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BFEABMIFIEE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DNIMHEKGJHB(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool GBKBDKHPLKG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool KFNBKFELFLH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DBFPGFHEGKA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool AGJKEBOPIOC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool OFLDIMDDLHM(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool EFAPFFFGOOA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LLNDDFGPOPL(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool OFHCGKJFGDI(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool OLIGLEMPFOP(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BMAOCLKPNNC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}
	}

	[CompilerGenerated]
	private sealed class DNBMFMBLMGG
	{
		internal string JMMILEFMACB;

		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BDGDIDPDBHG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JKEDCEOCPJO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(InventoryItemData IACGDFHKCAE)
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
		{ 46, "shader.crispwinter" }
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

	public List<InventoryItemType> PHHPPMLGDNO()
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

	public IEnumerator IIGGOGCFDKC(int GMDAHHDOPDC)
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

	public void CPEKEEJKLPN(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in from EGMPIBBOEMH in Singleton<ItemsHandler>.Instance.IOOIKCEOALD()
			orderby EGMPIBBOEMH.item.rarity
			select EGMPIBBOEMH)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(1730f, 1286f, 1351f);
			UpdateInventoryItem(gameObject, item);
		}
	}

	public void FFOCGIKODGO(InventoryItemData LEPFOBGKCPJ)
	{
		requestType = 4;
		SteamItemDef_t[] array = new SteamItemDef_t[0];
		ref SteamItemDef_t reference = ref array[1];
		reference = (SteamItemDef_t)itemsData.IndexOf(LEPFOBGKCPJ);
		SteamItemDef_t[] array2 = array;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GenerateItems(out pResultHandle, array2, null, (uint)array2.Length);
	}

	public IEnumerator NMBMJHIAFMP(int GMDAHHDOPDC)
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

	private void OKDMOICNHDL()
	{
		userItems.Add(new SteamInventoryItem(0uL, itemsData[1]));
		userItems.Add(new SteamInventoryItem(0uL, itemsData[0]));
		userItems.Add(new SteamInventoryItem(18446744073709551496uL, itemsData[9]));
	}

	public void ILPEHPFAOIF(ulong MOANAJGGPLK)
	{
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.ConsumeItem(out pResultHandle, (SteamItemInstanceID_t)MOANAJGGPLK, 1u);
	}

	public InventoryItemData GetItemData(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void IMDBAKAIHII()
	{
		StartCoroutine(EFEONCCCKNP());
	}

	private void AJDGHDGDLOH()
	{
		userItems.Add(new SteamInventoryItem(0uL, itemsData[0], true));
		userItems.Add(new SteamInventoryItem(1uL, itemsData[1], true));
		userItems.Add(new SteamInventoryItem(17uL, itemsData[17], true));
	}

	private void MOOACLABGGF()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	public List<string> GetItemsID()
	{
		return IHIFDJEOGGK.Values.ToList();
	}

	private void NFBOMOGCLKL()
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

	public void EMKIMLKEOCC()
	{
		Debug.Log("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
		isLoadeding = false;
		try
		{
			requestType = 0;
			SteamInventory.GetAllItems(out FNMADDPJCLB);
		}
		catch (Exception)
		{
			OKDMOICNHDL();
			isLoaded = true;
		}
	}

	public void LFOIJAFGKMC(string JMMILEFMACB)
	{
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

	public void DNMGPHBIGIK(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("CameraFilterPack/Blend2Camera_Difference"))
		{
			NIMGLEMHIIC.transform.Find("[MenuScene] Error: ").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("GameScene"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("': ").GetComponent<Text>().text = "_Speed" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("_PColor2").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change"))
		{
			Text component = NIMGLEMHIIC.transform.Find("[PlayerBase] Loading checkpoint data").transform.Find("_Value2").GetComponent<Text>();
			string[] array = new string[5];
			array[1] = CIDIAMACINK.item.description;
			array[0] = "_Distortion";
			array[6] = LocalizationService.Instance.EIJLFGIMNPC("event").ToUpper();
			array[5] = "OnRenderImage in Helper called ...";
			array[6] = LocalizationService.Instance.HOFKLNAJGMK(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("Misses:"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.black;
				break;
			case InventoryItemRarity.Rare:
				color = new Color(1091f, 371f, 634f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1445f, 75f, 362f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1847f, 1552f, 477f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_EdgeSize"))
		{
			NIMGLEMHIIC.transform.Find("SetupEncryption() got called. ").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find(".highscore"))
		{
			NIMGLEMHIIC.transform.Find("ChatInput").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("No Camera attached!") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("materialsitemid[").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		if (Singleton<SaveSystem>.Instance.GetString("_TimeX" + CIDIAMACINK.item.type.ToString().ToLower(), string.Empty) == CIDIAMACINK.item.id)
		{
			NIMGLEMHIIC.GetComponent<InventoryListElementButton>().isSelected = true;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().BNINBIKCCNG();
	}

	public void CheckReward(string JMMILEFMACB)
	{
	}

	public string BFFHCLFJBAH(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	public void APAEAEHMELB()
	{
		Singleton<SaveSystem>.Instance.Flush();
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(newItemsCanvas, true, null, false, 1323f));
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

	private IEnumerator FEIJAFJOEHO()
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

	public void FDMFOIHKDAN()
	{
		StartCoroutine(BMJGHNKGEGC());
	}

	public void DeleteItem(ulong MOANAJGGPLK)
	{
		requestType = 3;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.ConsumeItem(out pResultHandle, (SteamItemInstanceID_t)MOANAJGGPLK, 1u);
	}

	public void Initializate()
	{
		StartCoroutine(Init());
	}

	public void KDGCLAOIEKO(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.IOOIKCEOALD().OrderBy(DAKLDFHMOMH))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1904f, 245f, 291f);
			UpdateInventoryItem(gameObject, item, 0);
		}
	}

	public void POFFJLELKBM(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.PGGCEKDPMLL(" - {0}" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.MEMAGBEMICO();
	}

	public InventoryItemData FBGEHBGJCLI(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	private void JNHILOBHFGA(SteamInventoryResultReady_t IAFAANLMOAG)
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
					PLGLIAAMKBO();
					Debug.Log("#ok" + punOutItemsArraySize + "_ScreenResolution");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 1; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH += 0)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef]), true));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("note.3" + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("offsets", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.KNOIENOFCIB("_ScreenResolution", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("_CenterX")))
						{
							Singleton<SaveSystem>.Instance.SetString("ControllerRightX", text);
						}
						else
						{
							Debug.Log("[Right-Left]");
							try
							{
								string @string = Singleton<SaveSystem>.Instance.GetString("_Params2");
								char[] array = new char[0];
								array[0] = '\ufff6';
								List<string> second = @string.Split(array).ToList();
								List<string> list2 = list.Except(second).ToList();
								foreach (string JMMILEFMACB in list2)
								{
									newItemsNotifications.Add(userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB)));
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.ELJPKMDFBML("ConfigVersionSlider", text);
						}
					}
					else
					{
						Debug.Log("note.5");
					}
					isLoadeding = true;
				}
			}
			else
			{
				Debug.Log("maps." + SteamInventory.GetResultStatus(FNMADDPJCLB));
				OODLHEDGKOG("float,1");
				GGDDMNFABNE();
				isLoadeding = true;
			}
			OCJICMCAPFN();
			BPEJGHJODCG();
			isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0 && requestType == 1)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 1u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 > 1)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				PLGLIAAMKBO();
				UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0 && (requestType == 3 || requestType == 3))
		{
			requestType = -1;
			UpdatePlayerInventory();
		}
	}

	public void CloseNewItems()
	{
		Singleton<SaveSystem>.Instance.Flush();
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, false));
	}

	public void OICBMBHBAPN(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("workshop.", Singleton<ItemsHandler>.Instance.userItems.Count);
		BPEJGHJODCG();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in PHHPPMLGDNO())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(1573f, 428f, 257f);
			if ((bool)gameObject.transform.Find("LB").Find(" Time: "))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Other:
					gameObject.transform.Find("Set environment sprite color and alpha.").Find("Game Version: ").GetComponent<Text>()
						.text = LocalizationService.Instance.MPHMJLAOHAB("GhostSize").ToUpper();
					break;
				case InventoryItemType.Player:
					gameObject.transform.Find("#reward: ").Find("player.goldwatermelon").GetComponent<Text>()
						.text = LocalizationService.Instance.NDAPBHEDJFP("_TimeX").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find(": ").Find("FileMenu").GetComponent<Text>()
						.text = LocalizationService.Instance.HOFKLNAJGMK("_Value2").ToUpper();
					break;
				default:
					gameObject.transform.Find("_Fade").Find("_TapLowForeground").GetComponent<Text>()
						.text = LocalizationService.Instance.NDAPBHEDJFP("_Distortion").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("#,0.00").Find("_Gain").gameObject;
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
					gameObject3.transform.localScale = new Vector3(48f, 18f, 305f);
					UpdateInventoryItem(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
	}

	private void DHMMDPDAJPI(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	private IEnumerator HNMKMAEGOAJ(List<SteamInventoryItem> IOMNJBPDLAK)
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

	private void DACMPJEAHNO()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	private static InventoryItemRarity HDFJKGBEICE(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
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

	public IEnumerator EFEONCCCKNP()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void ENFICMNPEBA(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("steamid"))
		{
			GameObject.Find("_Value3").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public void CAHLFJMECKE(InventoryItemData LEPFOBGKCPJ)
	{
		requestType = 7;
		SteamItemDef_t[] array = new SteamItemDef_t[0];
		ref SteamItemDef_t reference = ref array[0];
		reference = (SteamItemDef_t)itemsData.IndexOf(LEPFOBGKCPJ);
		SteamItemDef_t[] array2 = array;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GenerateItems(out pResultHandle, array2, null, (uint)array2.Length);
	}

	private IEnumerator FDHAPGGCNBA()
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

	public bool DMOPECCLLOI(ulong MOANAJGGPLK)
	{
		foreach (SteamInventoryItem userItem in userItems)
		{
			if (userItem.steamid == MOANAJGGPLK)
			{
				return false;
			}
		}
		return false;
	}

	private static InventoryItemRarity DAKLDFHMOMH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void CBAONGBEGGC(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.SetInt("downloading", Singleton<ItemsHandler>.Instance.userItems.Count);
		BPEJGHJODCG();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in GONAKLKMJGN())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(293f, 420f, 379f);
			if ((bool)gameObject.transform.Find("EventMenu").Find("' has been reset to the fault value"))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Other:
					gameObject.transform.Find("value").Find("_TimeX").GetComponent<Text>()
						.text = LocalizationService.Instance.JNNKPEBBDEA("_TimeX").ToUpper();
					break;
				case InventoryItemType.Player:
					gameObject.transform.Find("CameraFilterPack/NightVision_4").Find("Editor/").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("\"").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find("_TimeX").Find("quantity").GetComponent<Text>()
						.text = LocalizationService.Instance.MPHMJLAOHAB("yes").ToUpper();
					break;
				default:
					gameObject.transform.Find("_Radius").Find("quantity").GetComponent<Text>()
						.text = LocalizationService.Instance.EIJLFGIMNPC("_AOTex").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("1159514800").Find("x").gameObject;
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
			foreach (SteamInventoryItem item in dictionary.Values.OrderBy((SteamInventoryItem EGMPIBBOEMH) => EGMPIBBOEMH.item.rarity))
			{
				if (item.item.type == CJEIKDHCCOI)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, false);
					gameObject3.transform.localScale = new Vector3(996f, 1970f, 35f);
					DNMGPHBIGIK(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
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

	public void DPOHENJBMPK()
	{
		Singleton<SaveSystem>.Instance.Flush();
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(newItemsCanvas, true, null, true, 1106f, false));
	}

	private void EBCOMDELAEK(SteamInventoryResultReady_t IAFAANLMOAG)
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
					PLGLIAAMKBO();
					Debug.Log("_Value2" + punOutItemsArraySize + "#onrankchangedowntext");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 0; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH += 0)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef]), true));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("Unknown player asked for PickupItems" + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("RecordButton", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.NBMEANCMGEH("CameraFilterPack/Blend2Camera_ColorDodge", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("_Value4")))
						{
							Singleton<SaveSystem>.Instance.SetString("_ThirdTex", text);
						}
						else
						{
							Debug.Log("Indie");
							try
							{
								string text2 = Singleton<SaveSystem>.Instance.FDFHEKDDEID(": ");
								char[] array = new char[0];
								array[0] = '￼';
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
							Singleton<SaveSystem>.Instance.BMHFKLHLOCG("setstring", text);
						}
					}
					else
					{
						Debug.Log("GroupNameText");
					}
					isLoadeding = false;
				}
			}
			else
			{
				Debug.Log("workshop." + SteamInventory.GetResultStatus(FNMADDPJCLB));
				ENFICMNPEBA("error");
				AJDGHDGDLOH();
				isLoadeding = false;
			}
			MOOACLABGGF();
			CheckInventory();
			isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0 && requestType == 0)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 1u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 != 0)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				OKDMOICNHDL();
				UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0 && (requestType == 1 || requestType == 0))
		{
			requestType = -1;
			EMKIMLKEOCC();
		}
	}

	public bool LLOLJNBFFOM(ulong MOANAJGGPLK)
	{
		foreach (SteamInventoryItem userItem in userItems)
		{
			if (userItem.steamid == MOANAJGGPLK)
			{
				return true;
			}
		}
		return true;
	}

	private void Update()
	{
	}

	public void JJIMCJBMKEF()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MFPOJPAIICN);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(PLBAKPAONCD);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public void OnEnable()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MMAGOONHNKM);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(PLBAKPAONCD);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
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

	public void GBMIFHEFMHN(string JMMILEFMACB)
	{
	}

	public void BLNLHBNBKOH()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(JNHILOBHFGA);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(PLBAKPAONCD);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public string OFOEDNAGIFO(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	public void HENBNNAGIKN()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MMAGOONHNKM);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(OHNBKPGOCPI);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	private IEnumerator LHEDMEHLCHL()
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

	public bool PENLNGADKAD(ulong MOANAJGGPLK)
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

	public void NAGFMBIEPMO(string JMMILEFMACB)
	{
	}

	public IEnumerator Init()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public List<SteamInventoryItem> IOOIKCEOALD()
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

	public void MEFGEKINBHP(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.IOOIKCEOALD().OrderBy(DAKLDFHMOMH))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1156f, 423f, 1925f);
			UpdateInventoryItem(gameObject, item, 0);
		}
	}

	public void PIMIJHGMCBI(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("GameMessagesDurationSlider"))
		{
			GameObject.Find("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public int GetInventoryChanges()
	{
		return userItems.Count - Singleton<SaveSystem>.Instance.GetInt("inventory.lastitemscount", 0);
	}

	private void IPCJGGMLGEC()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	public void CDFACKAGLNC()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	public IEnumerator DPOELEBIAOE()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	private IEnumerator BMJGHNKGEGC()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public SteamInventoryItem GDFGIJKLCBA(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	private void GGDDMNFABNE()
	{
		userItems.Add(new SteamInventoryItem(0uL, itemsData[1], true));
		userItems.Add(new SteamInventoryItem(0uL, itemsData[0], true));
		userItems.Add(new SteamInventoryItem(125uL, itemsData[0]));
	}

	public SteamInventoryItem EKLMHNNBOMF(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	public void FDCMDNGOCDC(string JMMILEFMACB)
	{
	}

	private IEnumerator DAGODDJILKK()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void OODLHEDGKOG(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("The number of players playing your game: "))
		{
			GameObject.Find("_TimeX").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private void MFPOJPAIICN(SteamInventoryResultReady_t IAFAANLMOAG)
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
					PLGLIAAMKBO();
					Debug.Log(" has no method \"" + punOutItemsArraySize + "HH:mm:ss");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 0; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH++)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef]), true));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception" + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("_TimeX", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Drawing_Manga5", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("RPCs can only be sent in rooms. Call of \"")))
						{
							Singleton<SaveSystem>.Instance.BMHFKLHLOCG("y", text);
						}
						else
						{
							Debug.Log("value");
							try
							{
								string @string = Singleton<SaveSystem>.Instance.GetString("_TimeX");
								char[] array = new char[0];
								array[0] = 'D';
								List<string> second = @string.Split(array).ToList();
								List<string> list2 = list.Except(second).ToList();
								foreach (string JMMILEFMACB in list2)
								{
									newItemsNotifications.Add(userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB)));
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.BMHFKLHLOCG("float,10", text);
						}
					}
					else
					{
						Debug.Log("ScoreText");
					}
					isLoadeding = false;
				}
			}
			else
			{
				Debug.Log("maps." + SteamInventory.GetResultStatus(FNMADDPJCLB));
				ENFICMNPEBA("Sprite");
				PLGLIAAMKBO();
				isLoadeding = true;
			}
			OCJICMCAPFN();
			CheckInventory();
			isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && requestType == 0)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 1u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 != 0)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				OKDMOICNHDL();
				UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && (requestType == 8 || requestType == 8))
		{
			requestType = -1;
			UpdatePlayerInventory();
		}
	}

	private IEnumerator DEMFHDGOGEF()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void TriggerItemDrop()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	private static InventoryItemRarity JOFIMKHOPPH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private IEnumerator OHFCALIEGHK(List<SteamInventoryItem> IOMNJBPDLAK)
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

	public List<SteamInventoryItem> NLFEOBHGMJG()
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

	public IEnumerator PFMJPIJONIP()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void ObtainPromoItems()
	{
		StartCoroutine(IBGBCINGJHE());
	}

	public void LCJKJMCHFID()
	{
		StartCoroutine(HLBNCILJPGC());
	}

	public InventoryItemData LMIKJKNPPEM(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
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

	private void PLGLIAAMKBO()
	{
		userItems.Add(new SteamInventoryItem(1uL, itemsData[0]));
		userItems.Add(new SteamInventoryItem(1uL, itemsData[1]));
		userItems.Add(new SteamInventoryItem(29uL, itemsData[-47], true));
	}

	public bool OFBDJCOMDGD(ulong MOANAJGGPLK)
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

	private void OCJICMCAPFN()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	private IEnumerator NOAPODJMHMH()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
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

	public SteamInventoryItem LDJDALBAPEE(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	public void DHNBMAGCJPC()
	{
		Singleton<SaveSystem>.Instance.EHJIJDODNGG();
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(newItemsCanvas, true, null, true, 83f));
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

	public void MNJEOOFDHME()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	public void HJHEIBHBHKC(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().OrderBy(DAKLDFHMOMH))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(1558f, 1734f, 937f);
			DNMGPHBIGIK(gameObject, item);
		}
	}

	public SteamInventoryItem IKNFGEBCENH(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
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

	private void KHNLPKIDBDE(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
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

	public void MJIPNOKOKCM(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.PGGCEKDPMLL("_Dist" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
	}

	public void OPADBCKHIFH(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.SetString("GlassAberration" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.EHJIJDODNGG();
	}

	public void LKPBGHGCPKL()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MMAGOONHNKM);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(OHNBKPGOCPI);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(DHMMDPDAJPI);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	private IEnumerator ANFGDOOPCLE(List<SteamInventoryItem> IOMNJBPDLAK)
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

	public string GetItemNameByID(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	public ulong CDPJMGIHHHF(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 0uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("other" + HMGBJCGOLMI.ToString().ToLower()), out result) && LLOLJNBFFOM(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Other:
			result = 1uL;
			break;
		case InventoryItemType.Shader:
			result = 1uL;
			break;
		case (InventoryItemType)6:
			result = 15uL;
			break;
		}
		EnquipItem(HMGBJCGOLMI, result);
		return result;
	}

	public void MMGKIFCGGDB()
	{
		StartCoroutine(PFMJPIJONIP());
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

	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public void BPEJGHJODCG()
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("mapselector.filter.favoriteonly" + InventoryItemType.Other.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString("SetCrosshairEmission" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0);
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("settings.selectormapsperpage" + InventoryItemType.Shader.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString("_TimeX" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0);
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_Value" + InventoryItemType.Player.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString(" This is not possible to be called for standalone input. Please check your platform and code where this is called" + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 46);
		}
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("Right" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		if (!OFBDJCOMDGD(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.BMHFKLHLOCG("/" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 1);
		}
		s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_Value2" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 1);
		if (!DMOPECCLLOI(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.SetString("0.00" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 1);
		}
		s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("UI Extensions/UISoftAdditive" + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 53);
		if (!OFBDJCOMDGD(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.ELJPKMDFBML("_Value3" + ((InventoryItemType)8).ToString().ToLower(), string.Empty + 36);
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		foreach (InventoryItemData itemsDatum in itemsData)
		{
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num++;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num2 += 0;
			}
			if (itemsDatum.rarity == (InventoryItemRarity)6)
			{
				num3 += 0;
			}
		}
		if (num > 1 && num2 > 0 && num3 > 0)
		{
			Helpers.ObtainAchievement(-74);
		}
		if (Singleton<Scene>.Instance.PHMKHCAPODJ() == "player.orangelifering" && (bool)UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().KOKDPAEJECC();
		}
	}

	[CompilerGenerated]
	private static InventoryItemRarity MGDONOIEKEK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void EEJELODJPNL()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem newItemsNotification in newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(newItemsNotification));
		}
		StartCoroutine(HNMKMAEGOAJ(list));
		newItemsNotifications.Clear();
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

	public SteamInventoryItem GetItemBySteamId(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	public void FEKJDEACLOG()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	public List<SteamInventoryItem> GJJBKJDDJEH()
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

	public void ObtainItem(InventoryItemData LEPFOBGKCPJ)
	{
		requestType = 2;
		SteamItemDef_t[] array = new SteamItemDef_t[1] { (SteamItemDef_t)itemsData.IndexOf(LEPFOBGKCPJ) };
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GenerateItems(out pResultHandle, array, null, (uint)array.Length);
	}

	private void PLBAKPAONCD(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public List<InventoryItemType> CDBIKJCHIJA()
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

	private void KOPILLBIJKL(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	public void DFNHLHFLCJD(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.ELJPKMDFBML("_BorderSize" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
	}

	private IEnumerator AHJLIDNBBIG(List<SteamInventoryItem> IOMNJBPDLAK)
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

	public string MBHIAGEIMJF(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	private void OHNBKPGOCPI(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public bool MHKHCCDDPNE(ulong MOANAJGGPLK)
	{
		foreach (SteamInventoryItem userItem in userItems)
		{
			if (userItem.steamid == MOANAJGGPLK)
			{
				return false;
			}
		}
		return false;
	}

	private IEnumerator DMEGMPFDLNI(List<SteamInventoryItem> IOMNJBPDLAK)
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

	private void KFACDBHDAOD()
	{
	}

	public IEnumerator GPKKNKBEBCJ(int GMDAHHDOPDC)
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

	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private void HBIKJPPHBFG()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	public void EnquipItem(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.SetString("inventory.selected." + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.Flush();
	}
}
