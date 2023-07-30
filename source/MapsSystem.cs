// MapsSystem
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class MapsSystem : Singleton<MapsSystem>
{
	public class MapSubscribedAndDownloadedEventArgs : EventArgs
	{
		public ulong id { get; set; }

		[SpecialName]
		public void GEBMKMGLLFF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JKGOLEMDFIP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		public MapSubscribedAndDownloadedEventArgs(ulong JMMILEFMACB)
		{
			id = JMMILEFMACB;
		}

		[SpecialName]
		public ulong PLCDNOIDALN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void NOPJILICFAH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ABLNANNLOEP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JABENKBHJGE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void BLGOAJDCMCO(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BFPEMBLEKAO(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong KCGOFGJNCME()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong MMHBNBADNNO()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void CCJLFDHPAPP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LDNLJKAEJPP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BHHEEGGLADG(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCMBNLCNBGF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong EMOAHNADEHK()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void GGMOGMDODGL(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GPMOHNDMEEH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JFHKHGILJDB()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong AHHAMAIOJEG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void IJJPNEAGAKF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBLNMJCGLDI(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JIGDBDNPGJD(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong FIMDFGLAEDI()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong GEDAFOHFDIA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void HCAKPOOEHCA(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GCMCGHFMFPH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong ALIBHGIINJN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void JIEOJEMCABN(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FPLJAMEHMMK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBFFJONGODM(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JOAAANFJKIC()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void DNIKHCAPHCA(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FKGDPHMLADH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong MMDJFDPIHLA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void PPACOCGAEDG(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong AABPHMBLMAD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HJPGIGBFCID()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void KDNAFFGAILB(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong HJCBNLFCNAM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong AHOCPHPACKE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void MMDLLCEGMII(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PCOLIEMBMHK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HNNNEJEHIKP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong CEEKAHOMGKG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void BHEEKNFFAFP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong BEEMEPJAJCD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void JMKOCDKFFAE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LHNBAEOOPDO(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JOGMMDACBIF()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong INGBCJIGOJK()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void ABNFDKBNAGF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong BCEIDEMKABE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong DGJBCIEBHHM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}
	}

	public delegate void MapSubscribedAndDownloadedEventHandler(object NFOGDAHIPNP, MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD);

	[CompilerGenerated]
	private sealed class KJJEBOMGBFO
	{
		internal FullMapData LCHEACMLFLL;

		internal bool JKEDCEOCPJO(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool HBJFIOJFBHC(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool IGFOBPKFCDJ(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool EGKGJJGAPMN(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool FCAGEDLBBHD(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BKNHHGBPLGH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool DBFPGFHEGKA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool GBKBDKHPLKG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool DNIMHEKGJHB(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool FIPCLHEKKCA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LLNDDFGPOPL(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool DKGPCPBNDPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool AGJKEBOPIOC(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool KGKMOLCPDIH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool KFNBKFELFLH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool EKHOOPGPPGE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool FFEGPHJKMFK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LOEAMHGMMPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BMAOCLKPNNC(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool PBCAHKDLFPE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool OLIGLEMPFOP(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BDGDIDPDBHG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool OFHCGKJFGDI(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LHHFJBIAHCN(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool FJDBPPKABJE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BFEABMIFIEE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool JDELIMPGFDJ(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool MEMPOPNAEDN(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool AEINPAGJFME(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool PIJAOCFAPKC(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LNDGINDKPFA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}
	}

	[CompilerGenerated]
	private sealed class NHJPHNHAOJF
	{
		internal FullMapData NOJGGCLPPAM;

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}
	}

	[CompilerGenerated]
	private sealed class AKEAHLPGOAN
	{
		internal ulong CAFHKDIIDEE;

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == CAFHKDIIDEE;
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}
	}

	[CompilerGenerated]
	private sealed class IMKOFKOKGCJ
	{
		internal SteamUGCDetails_t DAHGJANLMPI;

		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MapSubscribedAndDownloadedEventHandler BOPDFMGHFFM;

	public Dictionary<string, FullMapData> levelsData = new Dictionary<string, FullMapData>();

	[HideInInspector]
	public List<ulong> favoriteMaps = new List<ulong>();

	[HideInInspector]
	public Dictionary<ulong, int> ratedMaps = new Dictionary<ulong, int>();

	public bool isLoaded;

	public bool isDownloading;

	private Callback<ItemInstalled_t> IIODMDMKEKP;

	private Callback<DownloadItemResult_t> LICPDJCCACG;

	private CallResult<SteamUGCQueryCompleted_t> AICOBBBILIL;

	private CallResult<SteamUGCQueryCompleted_t> GNDGFIKPDCC;

	private CallResult<SteamUGCQueryCompleted_t> LIPOMMCLODL;

	private CallResult<UserFavoriteItemsListChanged_t> JEHIMKCKMEA;

	private CallResult<RemoteStorageUnsubscribePublishedFileResult_t> GGFPKFKFOPP;

	private UGCQueryHandle_t FFOJIDODGDO;

	private UGCQueryHandle_t BOKHPFLMPMO;

	private UGCQueryHandle_t FNBCFAANGJA;

	public event MapSubscribedAndDownloadedEventHandler MapSubscribedAndDownloaded
	{
		add
		{
			MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
			MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
			do
			{
				mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
				mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, value), mapSubscribedAndDownloadedEventHandler);
			}
			while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
		}
		remove
		{
			MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
			MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
			do
			{
				mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
				mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Remove(mapSubscribedAndDownloadedEventHandler2, value), mapSubscribedAndDownloadedEventHandler);
			}
			while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
		}
	}

	public IEnumerator PreloadLevel(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!levelsData.ContainsKey(text))
			{
				levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0uL));
			}
		}
		yield return true;
	}

	private void BODADHMJGGE(UserFavoriteItemsListChanged_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
	}

	private void Update()
	{
	}

	public GameObject AddDownloadedLevelItemToList(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		if (NOJGGCLPPAM != null && NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
				{
					gameObject.GetComponent<LevelsListElementButton>().InitRateButton();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(NOJGGCLPPAM.workshopId));
				}
				if (NOJGGCLPPAM.source == FullMapData.MapSource.Workshop || NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if ((bool)gameObject.transform.FindDeepChild("LevelNameText"))
				{
					gameObject.transform.FindDeepChild("LevelNameText").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("InfoCanvas"))
				{
					gameObject.transform.FindDeepChild("NameInfoText").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("InfoCanvas"))
				{
					gameObject.transform.FindDeepChild("InfoText").GetComponent<Text>().text = NOJGGCLPPAM.mapData.info;
				}
				if ((bool)gameObject.transform.FindDeepChild("DifficultyBG"))
				{
					gameObject.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(false);
					if (NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
					{
						ulong CAFHKDIIDEE = ulong.Parse(NOJGGCLPPAM.workshopId);
						bool flag = false;
						float num = -1f;
						if (RanksSystem.IsOfficial(CAFHKDIIDEE))
						{
							num = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == CAFHKDIIDEE).difficulty;
							if (num > 0f)
							{
								gameObject.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("DifficultyBG").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				int num2 = 0;
				string hFEFHOPOLIK = "maps." + GetMapID(NOJGGCLPPAM) + ".played";
				num2 = Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
				if (NOJGGCLPPAM.isLevelCompleted())
				{
					if ((bool)gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "COMPLETED";
					}
				}
				else if (num2 == 0)
				{
					if ((bool)gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "NEW";
					}
				}
				else
				{
					if ((bool)gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("BadgeImage"))
					{
						gameObject.transform.FindDeepChild("BadgeImage").gameObject.SetActive(false);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(!NOJGGCLPPAM.isUnlocked() || 1 == 0);
				if (NOJGGCLPPAM.source == FullMapData.MapSource.Workshop && (bool)gameObject.transform.FindDeepChild("LeaderboardsButton") && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId)))
				{
					gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(true);
				}
				else
				{
					gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(false);
				}
				if (!NOJGGCLPPAM.isUnlocked() && NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
				{
					if ((bool)gameObject.transform.FindDeepChild("RateButton") && GetUserVote(ulong.Parse(NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("RateButton").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("FavoriteButton") && !IsMapFavorite(ulong.Parse(NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("FavoriteButton").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (NOJGGCLPPAM.source != FullMapData.MapSource.Workshop || (NOJGGCLPPAM.source == FullMapData.MapSource.Editor && string.IsNullOrEmpty(NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(false);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	public void DeleteLevelSave(string JMMILEFMACB)
	{
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".completed");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".played");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".highscore");
		IEnumerator enumerator = Enum.GetValues(typeof(GameScene.GameMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + "." + current.ToString().ToLower() + ".highscore");
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.time");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.lives");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.correctScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.incorrectScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.powerupsScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.maxLongestCombo");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.longestComboScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.playerdistance");
		Helpers.DeleteColorKey("maps." + JMMILEFMACB + ".lastCheckpoint.bgcolor");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".sawoutdatedmessage");
	}

	public string GetMapID(FullMapData LCHEACMLFLL)
	{
		if (LCHEACMLFLL != null && levelsData.Values.Contains(LCHEACMLFLL))
		{
			return levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Value == LCHEACMLFLL).Key;
		}
		UnityEngine.Debug.LogError("Map id for" + LCHEACMLFLL.fullLevelPath + " not found");
		return null;
	}

	public void RemoveFromFavorite(FullMapData JBJGPIHJBMM)
	{
		if (favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Remove(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.RemoveItemFromFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
	}

	public GameObject AddNotDownloadedLevelItemToList(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<MapsListElement>().Init(DAHGJANLMPI, IEENFEMACND, DAHGJANLMPI.m_rgchTitle, DAHGJANLMPI.m_ulSteamIDOwner);
		if (IsMapFavorite(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(GetUserVote(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 1);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(GetUserVote(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if ((bool)gameObject.transform.FindDeepChild("LeaderboardsButton") && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(true);
		}
		else
		{
			gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(false);
		}
		string text = "workshop." + DAHGJANLMPI.m_nPublishedFileId;
		int num = 0;
		string hFEFHOPOLIK = "maps." + text + ".played";
		num = Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
		int @int = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".completed", 0);
		if (@int == 1)
		{
			gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "COMPLETED";
		}
		else if (num == 0)
		{
			if ((bool)gameObject.transform.FindDeepChild("BadgeText"))
			{
				gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "NEW";
			}
		}
		else
		{
			if ((bool)gameObject.transform.FindDeepChild("BadgeText"))
			{
				gameObject.transform.FindDeepChild("BadgeText").gameObject.SetActive(false);
			}
			if ((bool)gameObject.transform.FindDeepChild("BadgeImage"))
			{
				gameObject.transform.FindDeepChild("BadgeImage").gameObject.SetActive(false);
			}
		}
		return gameObject;
	}

	public IEnumerator ReloadLevel(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	private void MILGIHKLCHH(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		favoriteMaps.Clear();
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i++)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(FFOJIDODGDO, (uint)i, out pDetails);
			favoriteMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId);
		}
		SteamUGC.ReleaseQueryUGCRequest(FFOJIDODGDO);
	}

	private void KMKLDAJLCNM()
	{
	}

	private void KOJKLLKMELJ(DownloadItemResult_t IAFAANLMOAG)
	{
		StartCoroutine(CENINODLGMJ(IAFAANLMOAG.m_nPublishedFileId));
	}

	public IEnumerator ReloadLevelResources(FullMapData LCHEACMLFLL)
	{
		LCHEACMLFLL.resources = new Dictionary<string, UnityEngine.Object>();
		foreach (MapResource levelResource in LCHEACMLFLL.mapData.levelResources)
		{
			if (levelResource.type == "Sprite")
			{
				string fullName = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + levelResource.path).FullName;
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
				Sprite value = (Sprite)ResourcesManager.GetLoadedResource(fullName);
				LCHEACMLFLL.resources.Add(levelResource.name, value);
			}
			if (levelResource.type == "AudioClip")
			{
				string fullName2 = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + LCHEACMLFLL.mapData.musicFile).FullName;
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName2, fullName2, true));
				AudioClip value2 = (AudioClip)ResourcesManager.GetLoadedResource(fullName2);
				LCHEACMLFLL.resources.Add(levelResource.name, value2);
			}
		}
		yield return null;
	}

	public IEnumerator WaitForInit(bool GKLKDAOMNOL = false)
	{
		yield return StartCoroutine(CFDPKIGCAKA(GKLKDAOMNOL));
		if (Singleton<Scene>.Instance.name == "MenuScene")
		{
			if (Singleton<MapsListSelector>.Instance.mapSelector.activeInHierarchy)
			{
				Singleton<MapsListSelector>.Instance.ReloadPage();
			}
			if (PhotonNetwork.inRoom)
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
			}
		}
	}

	public IEnumerator LLIJHKKEBNI(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	public void NOIMEBKFCKA(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, false);
	}

	public IEnumerator IKMAFPMPLFL(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
	{
		string fullName = new FileInfo(NOJGGCLPPAM.fullLevelPath + "/" + NOJGGCLPPAM.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		NOJGGCLPPAM.icon = (Sprite)ResourcesManager.GetLoadedResource(fullName);
		if (!(AKEPNOGABIA != null))
		{
			yield break;
		}
		try
		{
			AKEPNOGABIA.sprite = NOJGGCLPPAM.icon;
			if ((bool)AKEPNOGABIA.GetComponent<AspectRatioFitter>())
			{
				AKEPNOGABIA.GetComponent<AspectRatioFitter>().aspectRatio = NOJGGCLPPAM.icon.rect.size.x / NOJGGCLPPAM.icon.rect.size.y;
			}
		}
		catch (Exception)
		{
		}
	}

	public void DownloadVotedList()
	{
		BOKHPFLMPMO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedUp, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(BOKHPFLMPMO);
		GNDGFIKPDCC.Set(hAPICall);
		FNBCFAANGJA = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, true);
		SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FNBCFAANGJA);
		LIPOMMCLODL.Set(hAPICall2);
	}

	private IEnumerator CENINODLGMJ(PublishedFileId_t IAFAANLMOAG)
	{
		ulong punSizeOnDisk;
		string pchFolder;
		uint punTimeStamp;
		if (SteamUGC.GetItemInstallInfo(IAFAANLMOAG, out punSizeOnDisk, out pchFolder, 1024u, out punTimeStamp))
		{
			yield return StartCoroutine(PreloadLevel(string.Empty + IAFAANLMOAG.m_PublishedFileId, pchFolder, FullMapData.MapSource.Workshop));
		}
		UnityEngine.Debug.Log("[MapsData] Installed: " + IAFAANLMOAG.m_PublishedFileId);
		Helpers.ObtainAchievement(11);
		if (BOPDFMGHFFM != null)
		{
			BOPDFMGHFFM(this, new MapSubscribedAndDownloadedEventArgs(IAFAANLMOAG.m_PublishedFileId));
		}
	}

	public void DIMMIBOLNGG(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("VoteDownToggle" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	private void HIIJNGBAOOL(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}

	public void SubscribeAndDownload(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, false);
	}

	public void NKNAABGIAJF(FullMapData JBJGPIHJBMM)
	{
		if (!favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Add(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.AddItemToFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
	}

	public void PreloadLevelNormal(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!levelsData.ContainsKey(text))
			{
				levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0uL));
			}
		}
	}

	private void Start()
	{
		if (!isLoaded)
		{
			Init();
		}
	}

	public void Init()
	{
		isLoaded = false;
		StartCoroutine(WaitForInit());
	}

	public void BDBKIEIIFPB()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
		GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(BBLFCINDELL);
		LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(LHMIJHBGLAJ);
		JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(BODADHMJGGE);
		GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(HIIJNGBAOOL);
		IIODMDMKEKP = Callback<ItemInstalled_t>.Create(JGFECBFNLOM);
		LICPDJCCACG = Callback<DownloadItemResult_t>.Create(KOJKLLKMELJ);
	}

	public void UnsubscribeLevel(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("[MapsData] Unsubscribe " + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	private void JGFECBFNLOM(ItemInstalled_t IAFAANLMOAG)
	{
	}

	public void OnEnable()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
		GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(BBLFCINDELL);
		LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(LHMIJHBGLAJ);
		JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(BODADHMJGGE);
		GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(HIIJNGBAOOL);
		IIODMDMKEKP = Callback<ItemInstalled_t>.Create(MKJDJPOCDCC);
		LICPDJCCACG = Callback<DownloadItemResult_t>.Create(KOJKLLKMELJ);
	}

	public void FCLFPEOCAIC(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("UseFinalGlassColor" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	public bool IsMapFavorite(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	public void DeleteLevel(string JMMILEFMACB)
	{
		FullMapData mapData = GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(GetMapData(JMMILEFMACB).fullLevelPath);
			levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	private void BBLFCINDELL(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i++)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(BOKHPFLMPMO, (uint)i, out pDetails);
			if (!ratedMaps.Keys.Contains(pDetails.m_nPublishedFileId.m_PublishedFileId))
			{
				ratedMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId, 1);
			}
			else
			{
				ratedMaps[pDetails.m_nPublishedFileId.m_PublishedFileId] = 1;
			}
		}
		SteamUGC.ReleaseQueryUGCRequest(BOKHPFLMPMO);
	}

	public IEnumerator PreloadWorkshopLevel(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("[MapsData] Preloading workshop" + JMMILEFMACB);
		FullMapData mapData = GetMapData(JMMILEFMACB);
		if (mapData == null)
		{
			yield break;
		}
		string text = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(text, true));
		if (Helpers.textResult[text] != null)
		{
			MapData mapData2 = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
			if (mapData.mapData == null || GKLKDAOMNOL)
			{
				mapData.mapData = mapData2;
				Dictionary<string, UnityEngine.Object> dictionary = (mapData.resources = new Dictionary<string, UnityEngine.Object>());
				if (mapData.source == FullMapData.MapSource.Editor)
				{
					string empty = string.Empty;
					string text2 = mapData.fullLevelPath + "/" + Helpers.workshopConfigFileName;
					yield return StartCoroutine(Helpers.LoadText(text2, true));
					empty = ((Helpers.textResult[text2] != null) ? Helpers.textResult[text2] : null);
					mapData.workshopId = empty;
				}
			}
		}
		else
		{
			UnityEngine.Debug.Log("[MapsData] Bad map: " + JMMILEFMACB);
		}
	}

	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public void HKKCNIPFIGF(FullMapData JBJGPIHJBMM)
	{
		if (favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Remove(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.RemoveItemFromFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
	}

	public void DownloadFavoriteList()
	{
		FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall);
	}

	public void AddToFavorite(FullMapData JBJGPIHJBMM)
	{
		if (!favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Add(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.AddItemToFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
	}

	public void UnloadResources()
	{
		UnityEngine.Debug.Log("[MapsSystem] Unloading maps resources...");
		foreach (KeyValuePair<string, FullMapData> levelsDatum in levelsData)
		{
			try
			{
				levelsDatum.Value.clip = null;
				levelsDatum.Value.icon = null;
				levelsDatum.Value.mapData = null;
				if (levelsDatum.Value.resources != null)
				{
					levelsDatum.Value.resources.Clear();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public void NNHBKDOLPGP()
	{
		FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, false);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall);
	}

	public int GetUserVote(ulong AHIIAEFFINI)
	{
		if (ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return ratedMaps[AHIIAEFFINI];
		}
		return 0;
	}

	private IEnumerator CFDPKIGCAKA(bool PJDIHKOBGBA = false)
	{
		if (!isLoaded || PJDIHKOBGBA)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Helpers.GetDirectory("Data/Maps/"));
			Helpers.CheckDirectory(directoryInfo.FullName);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			UnityEngine.Debug.Log("[MapsData] Found " + directories.Length + " base map(s)");
			for (int i = 0; i < directories.Length; i++)
			{
				PreloadLevelNormal(directories[i].Name, directories[i].FullName, FullMapData.MapSource.Original);
			}
			UnityEngine.Debug.Log("[MapsData] Base maps loaded");
			if (SteamAPI.IsSteamRunning())
			{
				PublishedFileId_t[] array = new PublishedFileId_t[65000];
				uint subscribedItems = SteamUGC.GetSubscribedItems(array, 65000u);
				UnityEngine.Debug.Log("[MapsData] Found " + subscribedItems + " workshop map(s)");
				if (subscribedItems != 0)
				{
					Helpers.ObtainAchievement(11);
				}
				for (uint num = 0u; num < subscribedItems; num++)
				{
					ulong punSizeOnDisk;
					string pchFolder;
					uint punTimeStamp;
					if (SteamUGC.GetItemInstallInfo(array[num], out punSizeOnDisk, out pchFolder, 1024u, out punTimeStamp))
					{
						PreloadLevelNormal(string.Empty + array[num], pchFolder, FullMapData.MapSource.Workshop);
					}
				}
			}
			UnityEngine.Debug.Log("[MapsData] Workshop maps was loaded");
			directoryInfo = new DirectoryInfo(Helpers.GetDirectory("Editor/"));
			Helpers.CheckDirectory(directoryInfo.FullName);
			directories = directoryInfo.GetDirectories();
			UnityEngine.Debug.Log("[MapsData] Found " + directories.Length + " user's map(s)");
			for (int j = 0; j < directories.Length; j++)
			{
				PreloadLevelNormal(directories[j].Name, directories[j].FullName, FullMapData.MapSource.Editor);
			}
			UnityEngine.Debug.Log("[MapsData] User's maps was loaded");
			DownloadFavoriteList();
			DownloadVotedList();
		}
		isLoaded = true;
		isDownloading = false;
		yield break;
	}

	public IEnumerator LoadIconForLevel(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
	{
		string fullName = new FileInfo(NOJGGCLPPAM.fullLevelPath + "/" + NOJGGCLPPAM.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		NOJGGCLPPAM.icon = (Sprite)ResourcesManager.GetLoadedResource(fullName);
		if (!(AKEPNOGABIA != null))
		{
			yield break;
		}
		try
		{
			AKEPNOGABIA.sprite = NOJGGCLPPAM.icon;
			if ((bool)AKEPNOGABIA.GetComponent<AspectRatioFitter>())
			{
				AKEPNOGABIA.GetComponent<AspectRatioFitter>().aspectRatio = NOJGGCLPPAM.icon.rect.size.x / NOJGGCLPPAM.icon.rect.size.y;
			}
		}
		catch (Exception)
		{
		}
	}

	private void LHMIJHBGLAJ(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i++)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(FNBCFAANGJA, (uint)i, out pDetails);
			if (!ratedMaps.Keys.Contains(pDetails.m_nPublishedFileId.m_PublishedFileId))
			{
				ratedMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId, -1);
			}
			else
			{
				ratedMaps[pDetails.m_nPublishedFileId.m_PublishedFileId] = -1;
			}
		}
		SteamUGC.ReleaseQueryUGCRequest(FNBCFAANGJA);
	}

	public void MGEFCHFAFHE(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("[NetworkManager] Join failed"))
		{
			GameObject.Find("steamid").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private void MKJDJPOCDCC(ItemInstalled_t IAFAANLMOAG)
	{
	}

	public FullMapData GetMapData(string JMMILEFMACB)
	{
		if (!string.IsNullOrEmpty(JMMILEFMACB) && levelsData.Keys.Contains(JMMILEFMACB))
		{
			return levelsData[JMMILEFMACB];
		}
		return null;
	}

	public void LoadLevel(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("[MapsData] Preloading " + JMMILEFMACB);
		FullMapData mapData = GetMapData(JMMILEFMACB);
		if (mapData == null)
		{
			return;
		}
		if (GKLKDAOMNOL)
		{
			mapData.icon = null;
			mapData.clip = null;
		}
		string hAEBGHHMEBH = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
		string text = Helpers.LoadTextString(hAEBGHHMEBH, true);
		if (text != null)
		{
			MapData mapData2 = JsonConvert.DeserializeObject<MapData>(text);
			if (mapData.mapData == null || GKLKDAOMNOL)
			{
				mapData.mapData = mapData2;
				Dictionary<string, UnityEngine.Object> dictionary = (mapData.resources = new Dictionary<string, UnityEngine.Object>());
				if (mapData.source == FullMapData.MapSource.Editor)
				{
					string empty = string.Empty;
					mapData.mapperSteamID = (ulong)SteamUser.GetSteamID();
					string hAEBGHHMEBH2 = mapData.fullLevelPath + "/" + Helpers.workshopConfigFileName;
					string text2 = Helpers.LoadTextString(hAEBGHHMEBH2, true);
					empty = ((text2 != null) ? text2 : null);
					mapData.workshopId = empty;
				}
			}
		}
		else
		{
			UnityEngine.Debug.Log("[MapsData] Bad map: " + JMMILEFMACB);
		}
	}
}
