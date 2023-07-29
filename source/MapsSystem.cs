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
		public ulong EMOAHNADEHK()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong JOGMMDACBIF()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong AHOCPHPACKE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void PCOLIEMBMHK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong ENDOGIJIIMN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong PGNOPJPKDEA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public MapSubscribedAndDownloadedEventArgs(ulong JMMILEFMACB)
		{
			id = JMMILEFMACB;
		}

		[SpecialName]
		public void DGCCOLFGGEE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBLNMJCGLDI(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong OKFOADGNODA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void LBFFJONGODM(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IJJPNEAGAKF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IMKEMBOIAEJ(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ENBBNKECEIB(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCAKPOOEHCA(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong KBMEBAACODH()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong EKIBIEFGIJC()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong FAKJNFJPKJI()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong IKPGAGMDCLP()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong OLBLEAABNJN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void JMKOCDKFFAE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KDNAFFGAILB(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KPODABLEDLK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong IAPHLAEFPMN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong NJAFAEMEEPG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void NOPJILICFAH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong BEEMEPJAJCD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong BAOHGANDHBD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void BFPEMBLEKAO(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong PLCDNOIDALN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong INGBCJIGOJK()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void HNNNEJEHIKP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong CHDCIFPPIFI()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong MMDJFDPIHLA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong DGMNLDNBIOD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong AHHAMAIOJEG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong KCGOFGJNCME()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong ALIBHGIINJN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void LHNBAEOOPDO(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JABENKBHJGE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HJCBNLFCNAM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong DGJBCIEBHHM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CEEKAHOMGKG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HLJAGNFLKFM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}
	}

	public delegate void MapSubscribedAndDownloadedEventHandler(object NFOGDAHIPNP, MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD);

	[CompilerGenerated]
	private sealed class KJJEBOMGBFO
	{
		internal FullMapData LCHEACMLFLL;

		internal bool OLIGLEMPFOP(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BFEABMIFIEE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LLNDDFGPOPL(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LNDGINDKPFA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BKNHHGBPLGH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool EKHOOPGPPGE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool AEINPAGJFME(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool MEMPOPNAEDN(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool BDGDIDPDBHG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool FFEGPHJKMFK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool DKGPCPBNDPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool DBFPGFHEGKA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool LOEAMHGMMPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool KFNBKFELFLH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool OFHCGKJFGDI(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool JKEDCEOCPJO(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool PBCAHKDLFPE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}

		internal bool GBKBDKHPLKG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == LCHEACMLFLL;
		}
	}

	[CompilerGenerated]
	private sealed class NHJPHNHAOJF
	{
		internal FullMapData NOJGGCLPPAM;

		internal bool FHIJCPPECHA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId);
		}
	}

	[CompilerGenerated]
	private sealed class AKEAHLPGOAN
	{
		internal ulong CAFHKDIIDEE;

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == CAFHKDIIDEE;
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == CAFHKDIIDEE;
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}
	}

	[CompilerGenerated]
	private sealed class IMKOFKOKGCJ
	{
		internal SteamUGCDetails_t DAHGJANLMPI;

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FHIJCPPECHA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
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

	public IEnumerator IAFOLGHAEHH(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
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

	public void MGKDFEEBOEL(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("player.licenceaccepted"))
		{
			GameObject.Find("_ScreenResolution").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private void LMEHDOONBKH(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("settings.shaders.bloomintencity" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("LoadingStatusText" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
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

	private IEnumerator MNCNOOPPMIH(PublishedFileId_t IAFAANLMOAG)
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

	public bool ECEOJLNJMHN(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	public FullMapData GetMapData(string JMMILEFMACB)
	{
		if (!string.IsNullOrEmpty(JMMILEFMACB) && levelsData.Keys.Contains(JMMILEFMACB))
		{
			return levelsData[JMMILEFMACB];
		}
		return null;
	}

	private void LAGFIPMHCFN(ItemInstalled_t IAFAANLMOAG)
	{
	}

	public void NDBOMBCMJEL(string JMMILEFMACB)
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

	private void IDOBHGMPFAM(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 1; i < IAFAANLMOAG.m_unNumResultsReturned; i += 0)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(BOKHPFLMPMO, (uint)i, out pDetails);
			if (!ratedMaps.Keys.Contains(pDetails.m_nPublishedFileId.m_PublishedFileId))
			{
				ratedMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId, 0);
			}
			else
			{
				ratedMaps[pDetails.m_nPublishedFileId.m_PublishedFileId] = 1;
			}
		}
		SteamUGC.ReleaseQueryUGCRequest(BOKHPFLMPMO);
	}

	private void BFGFMBIKIEB(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		favoriteMaps.Clear();
		for (int i = 1; i < IAFAANLMOAG.m_unNumResultsReturned; i += 0)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(FFOJIDODGDO, (uint)i, out pDetails);
			favoriteMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId);
		}
		SteamUGC.ReleaseQueryUGCRequest(FFOJIDODGDO);
	}

	public void BNIFKLGDHAB(FullMapData JBJGPIHJBMM)
	{
		if (!favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Add(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.AddItemToFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
	}

	public void NFEFBEBEFMI(string JMMILEFMACB)
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

	public void ABKCDAHHKCF(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("/" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	public void UnsubscribeLevel(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("[MapsData] Unsubscribe " + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	private void ILOKADDCIFO(UserFavoriteItemsListChanged_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
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

	private void HIIJNGBAOOL(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}

	public GameObject GPJJCOCANMA(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(317f, 73f, 1624f);
		gameObject.GetComponent<MapsListElement>().EPDCHKECMBL(DAHGJANLMPI, IEENFEMACND, DAHGJANLMPI.m_rgchTitle, DAHGJANLMPI.m_ulSteamIDOwner);
		if (ECEOJLNJMHN(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(GBFFPCIAIAB(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 0);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(GetUserVote(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if ((bool)gameObject.transform.FindDeepChild("_NoiseTex") && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.transform.FindDeepChild("GlassesColor2").gameObject.SetActive(true);
		}
		else
		{
			gameObject.transform.FindDeepChild("GlassDistortion").gameObject.SetActive(false);
		}
		string text = "_ScreenResolution" + DAHGJANLMPI.m_nPublishedFileId;
		int num = 0;
		string hFEFHOPOLIK = "Most likely the game became empty during the switch to GameServer." + text + " Server: ";
		num = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 0);
		int num2 = Singleton<SaveSystem>.Instance.ANECPPFPKAP("[MapsData] Base maps loaded" + text + "CameraFilterPack/Gradients_ElectricGradient", 1);
		if (num2 == 1)
		{
			gameObject.transform.FindDeepChild("_Value11").GetComponent<Text>().text = "mapselector.tags.";
		}
		else if (num == 0)
		{
			if ((bool)gameObject.transform.FindDeepChild("finished"))
			{
				gameObject.transform.FindDeepChild("_Red_C").GetComponent<Text>().text = "_BlurRadius4";
			}
		}
		else
		{
			if ((bool)gameObject.transform.FindDeepChild("SpawnObj"))
			{
				gameObject.transform.FindDeepChild("_Value").gameObject.SetActive(false);
			}
			if ((bool)gameObject.transform.FindDeepChild("_TintColor"))
			{
				gameObject.transform.FindDeepChild("Deleted event").gameObject.SetActive(true);
			}
		}
		return gameObject;
	}

	private void IKIDIJLIGOH()
	{
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

	public string GetMapID(FullMapData LCHEACMLFLL)
	{
		if (LCHEACMLFLL != null && levelsData.Values.Contains(LCHEACMLFLL))
		{
			return levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Value == LCHEACMLFLL).Key;
		}
		UnityEngine.Debug.LogError("Map id for" + LCHEACMLFLL.fullLevelPath + " not found");
		return null;
	}

	private IEnumerator LBDHAAGDAFE(PublishedFileId_t IAFAANLMOAG)
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

	private void Start()
	{
		if (!isLoaded)
		{
			Init();
		}
	}

	private void COIJKMKIEAK()
	{
		if (!isLoaded)
		{
			Init();
		}
	}

	private void BODADHMJGGE(UserFavoriteItemsListChanged_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
	}

	private void KLKPKBLJIGJ(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
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

	public GameObject CHALLJOJCDJ(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		if (NOJGGCLPPAM != null && NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1228f, 1079f, 1622f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = false;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().GFMKNEGNNJI();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(false);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(NOJGGCLPPAM.workshopId));
				}
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)8 || NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(false);
				}
				if ((bool)gameObject.transform.FindDeepChild("[LevelEditorScene] Error: I/O Failure! :("))
				{
					gameObject.transform.FindDeepChild(".icon").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("_ScreenResolution"))
				{
					gameObject.transform.FindDeepChild("Mouse").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("/../"))
				{
					gameObject.transform.FindDeepChild("_TimeX").GetComponent<Text>().text = NOJGGCLPPAM.mapData.info;
				}
				if ((bool)gameObject.transform.FindDeepChild("EventMenu"))
				{
					gameObject.transform.FindDeepChild("mapselector.lastSearch").gameObject.SetActive(true);
					if (NOJGGCLPPAM.source == (FullMapData.MapSource)8)
					{
						ulong CAFHKDIIDEE = ulong.Parse(NOJGGCLPPAM.workshopId);
						bool flag = true;
						float num = 109f;
						if (RanksSystem.IsOfficial(CAFHKDIIDEE, true))
						{
							num = RanksSystem.FIENAHLCHIF().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE).IFMFDMKFJBI();
							if (num > 59f)
							{
								gameObject.transform.FindDeepChild("finished").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("float,40").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				int num2 = 1;
				string hFEFHOPOLIK = "_Blend" + GetMapID(NOJGGCLPPAM) + "y";
				num2 = Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
				if (NOJGGCLPPAM.BLDMPJOMGDN())
				{
					if ((bool)gameObject.transform.FindDeepChild("Data/Maps/"))
					{
						gameObject.transform.FindDeepChild("/").GetComponent<Text>().text = "CameraFilterPack/Blend2Camera_HardLight";
					}
				}
				else if (num2 == 0)
				{
					if ((bool)gameObject.transform.FindDeepChild("mapselector.orderby"))
					{
						gameObject.transform.FindDeepChild("DPADHOR").GetComponent<Text>().text = "_FgOverlap";
					}
				}
				else
				{
					if ((bool)gameObject.transform.FindDeepChild("_PosX"))
					{
						gameObject.transform.FindDeepChild("OneHand").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("GlassAberration"))
					{
						gameObject.transform.FindDeepChild("InfoCanvas").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!NOJGGCLPPAM.NGILJKKGOCI()) ? 0 : 0) == 1);
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)5 && (bool)gameObject.transform.FindDeepChild("\nCreated by Oxy949") && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(NOJGGCLPPAM.workshopId)))
				{
					gameObject.transform.FindDeepChild("StartButton").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("_Offsets").gameObject.SetActive(true);
				}
				if (!NOJGGCLPPAM.isUnlocked() && NOJGGCLPPAM.source == (FullMapData.MapSource)3)
				{
					if ((bool)gameObject.transform.FindDeepChild(" while connecting to: ") && DHDMCJPPACI(ulong.Parse(NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("_TimeX").gameObject.SetActive(true);
					}
					if ((bool)gameObject.transform.FindDeepChild("received</b>\n#reason: ") && !ECEOJLNJMHN(ulong.Parse(NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("Error: Someone else(").gameObject.SetActive(true);
					}
				}
				if (string.IsNullOrEmpty(NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(true);
				}
				if (NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(NOJGGCLPPAM.workshopId)))
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

	public void LIFBFDKFMMH()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MIBPFKKNOPG);
		GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(IDOBHGMPFAM);
		LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(LHMIJHBGLAJ);
		JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(BODADHMJGGE);
		GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(NBMLONPNPBP);
		IIODMDMKEKP = Callback<ItemInstalled_t>.Create(BLMEFPDNDMI);
		LICPDJCCACG = Callback<DownloadItemResult_t>.Create(KOJKLLKMELJ);
	}

	public void ENHDGEHDMCD(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("CloseConnection: No such player connected!" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		GGFPKFKFOPP.Set(hAPICall);
	}

	public void HIFPDKKBDHJ()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MIBPFKKNOPG);
		GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(HOCPEBKLECB);
		LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(KLKPKBLJIGJ);
		JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(BODADHMJGGE);
		GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(MCGBFJONNLO);
		IIODMDMKEKP = Callback<ItemInstalled_t>.Create(BLMEFPDNDMI);
		LICPDJCCACG = Callback<DownloadItemResult_t>.Create(KOJKLLKMELJ);
	}

	public void BKCKODBAIKP(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("OnDeserialize"))
		{
			GameObject.Find("ItemTemplate").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public void AOEEOKNJDCK()
	{
		isLoaded = false;
		StartCoroutine(EACGMDPBCOG());
	}

	private void CKINKMJGMHI(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i += 0)
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

	public GameObject MEGHFGEHEHM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		if (NOJGGCLPPAM != null && NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1546f, 1487f, 979f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = false;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)3)
				{
					gameObject.GetComponent<LevelsListElementButton>().LLPJNILPBBI();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(false);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(NOJGGCLPPAM.workshopId));
				}
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)8 || NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if ((bool)gameObject.transform.FindDeepChild("_Gamma"))
				{
					gameObject.transform.FindDeepChild("SupportLogger OnJoinedLobby(").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("settings.showHP"))
				{
					gameObject.transform.FindDeepChild("_Value2").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("You need to have a child LayoutGroup content set for the list: "))
				{
					gameObject.transform.FindDeepChild("isVisible").GetComponent<Text>().text = NOJGGCLPPAM.mapData.info;
				}
				if ((bool)gameObject.transform.FindDeepChild("CameraFilterPack/Blend2Camera_LinearDodge"))
				{
					gameObject.transform.FindDeepChild(" - LOCAL").gameObject.SetActive(false);
					if (NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
					{
						ulong CAFHKDIIDEE = ulong.Parse(NOJGGCLPPAM.workshopId);
						bool flag = true;
						float num = 252f;
						if (RanksSystem.IsOfficial(CAFHKDIIDEE, true))
						{
							num = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE).PJBPOLLEJFN();
							if (num > 7f)
							{
								gameObject.transform.FindDeepChild("EnableRankedNotificationsToggle").gameObject.SetActive(false);
								gameObject.transform.FindDeepChild("CameraFilterPack/Blend2Camera_Color").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				int num2 = 0;
				string hFEFHOPOLIK = "Joystick1Button3" + GetMapID(NOJGGCLPPAM) + "menu.tabid";
				num2 = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 1);
				if (NOJGGCLPPAM.MDKFJHPDIKB())
				{
					if ((bool)gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("Testing, the group has toggled [").GetComponent<Text>().text = "Misses:";
					}
				}
				else if (num2 == 0)
				{
					if ((bool)gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("SetParticlesParticleSize").GetComponent<Text>().text = "PossibleMapMaxScoreText";
					}
				}
				else
				{
					if ((bool)gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("https://www.youtube.com/watch?v=cDVXukrKo74").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("achievements.21.progress"))
					{
						gameObject.transform.FindDeepChild("player.crystal").gameObject.SetActive(false);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!NOJGGCLPPAM.MLDFFCPMHHF()) ? 1 : 1) == 1);
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)5 && (bool)gameObject.transform.FindDeepChild("_Bloom5") && RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(NOJGGCLPPAM.workshopId)))
				{
					gameObject.transform.FindDeepChild("settings.enablehitsoundsinnormal").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("player.gamecompleted").gameObject.SetActive(false);
				}
				if (!NOJGGCLPPAM.isUnlocked() && NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					if ((bool)gameObject.transform.FindDeepChild("_Intensity") && DHDMCJPPACI(ulong.Parse(NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("DPADHOR").gameObject.SetActive(true);
					}
					if ((bool)gameObject.transform.FindDeepChild("settings_bindings_") && !DBHJFMLJBJK(ulong.Parse(NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("menu.selectedlevelid").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (NOJGGCLPPAM.source != (FullMapData.MapSource)3 || (NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(true);
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

	public void KCCDEMAGBJL(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("Texture2" + JMMILEFMACB);
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
		string hAEBGHHMEBH = mapData.fullLevelPath + "_copy" + Helpers.levelConfigFileName;
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
					string hAEBGHHMEBH2 = mapData.fullLevelPath + "_Value2" + Helpers.workshopConfigFileName;
					string text2 = Helpers.LoadTextString(hAEBGHHMEBH2, true);
					empty = ((text2 != null) ? text2 : null);
					mapData.workshopId = empty;
				}
			}
		}
		else
		{
			UnityEngine.Debug.Log("#failed: " + JMMILEFMACB);
		}
	}

	private void AMDEJOONDOM(DownloadItemResult_t IAFAANLMOAG)
	{
		StartCoroutine(LBDHAAGDAFE(IAFAANLMOAG.m_nPublishedFileId));
	}

	[SpecialName]
	public void CLOPEPLNPJD(MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	public IEnumerator AKKLMLODKAG(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
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

	private void EPFCHMFIHGJ(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("_Value13" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("settings.shaders" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}

	public int PCMONCGODLC(ulong AHIIAEFFINI)
	{
		if (ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return ratedMaps[AHIIAEFFINI];
		}
		return 0;
	}

	private void MIBPFKKNOPG(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
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

	public void ACIIHJJKNNC(FullMapData JBJGPIHJBMM)
	{
		if (favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			favoriteMaps.Remove(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.RemoveItemFromFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		JEHIMKCKMEA.Set(hAPICall);
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

	public GameObject EDCJGMBHDJM(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(603f, 198f, 1772f);
		gameObject.GetComponent<MapsListElement>().EPDCHKECMBL(DAHGJANLMPI, IEENFEMACND, DAHGJANLMPI.m_rgchTitle, DAHGJANLMPI.m_ulSteamIDOwner);
		if (NACJDBPDMJI(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(false);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(GetUserVote(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 0);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(DDCMPELCOKM(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if ((bool)gameObject.transform.FindDeepChild("settings_bindings_sec_") && RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.transform.FindDeepChild("Back").gameObject.SetActive(false);
		}
		else
		{
			gameObject.transform.FindDeepChild("Could not execute RPC ").gameObject.SetActive(true);
		}
		string text = "Joystick1Button8" + DAHGJANLMPI.m_nPublishedFileId;
		int num = 0;
		string hFEFHOPOLIK = "menu.resetlevelcheckpoint" + text + "ArcsNoHitsoundTimeDelaySlider";
		num = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 0);
		int @int = Singleton<SaveSystem>.Instance.GetInt("maps." + text + "CameraFilterPack/Gradients_Tech", 1);
		if (@int == 1)
		{
			gameObject.transform.FindDeepChild("_StretchWidth").GetComponent<Text>().text = "settings_bindings_sec_";
		}
		else if (num == 0)
		{
			if ((bool)gameObject.transform.FindDeepChild("_ScreenResolution"))
			{
				gameObject.transform.FindDeepChild("PublishButton").GetComponent<Text>().text = "float,1.5";
			}
		}
		else
		{
			if ((bool)gameObject.transform.FindDeepChild("tagElement"))
			{
				gameObject.transform.FindDeepChild(".b").gameObject.SetActive(false);
			}
			if ((bool)gameObject.transform.FindDeepChild("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id."))
			{
				gameObject.transform.FindDeepChild("_Color_G").gameObject.SetActive(false);
			}
		}
		return gameObject;
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

	public IEnumerator ReloadLevel(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public IEnumerator IOPKNCBLAPI(FullMapData LCHEACMLFLL)
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

	public void OPKKBMCDOEM()
	{
		isLoaded = true;
		StartCoroutine(WaitForInit(true));
	}

	private void MCGBFJONNLO(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("\"" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("_Bloom5" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}

	public bool NACJDBPDMJI(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	public IEnumerator GOANIMFPCIJ(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
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

	private void LMADKINICIN()
	{
	}

	public void EKGELAAIOCD()
	{
		UnityEngine.Debug.Log("_SecondTex");
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

	public void FECMEIJGLJI()
	{
		isLoaded = false;
		StartCoroutine(EACGMDPBCOG(true));
	}

	public void HNKBKCBDNBG(string JMMILEFMACB)
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

	public bool PCFKDFIDAHE(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	private void LBAJLLFMMMP()
	{
		if (!isLoaded)
		{
			AOEEOKNJDCK();
		}
	}

	private void JGFECBFNLOM(ItemInstalled_t IAFAANLMOAG)
	{
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

	public void JDJNHFHCBDB(string JMMILEFMACB)
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

	private void AEPDCDLJEBE(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData(" ." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator LNLAPPCBPII(bool GKLKDAOMNOL = false)
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

	public IEnumerator EHEEDMNCKFF(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
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

	public void JPPGIKCKFJL()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
		GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(BBLFCINDELL);
		LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(LHMIJHBGLAJ);
		JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(ILOKADDCIFO);
		GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(AEPDCDLJEBE);
		IIODMDMKEKP = Callback<ItemInstalled_t>.Create(JKBFPILJHJN);
		LICPDJCCACG = Callback<DownloadItemResult_t>.Create(KOJKLLKMELJ);
	}

	public int DDCMPELCOKM(ulong AHIIAEFFINI)
	{
		if (ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	public string GPILFNKPAFH(FullMapData LCHEACMLFLL)
	{
		if (LCHEACMLFLL != null && levelsData.Values.Contains(LCHEACMLFLL))
		{
			return levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Value == LCHEACMLFLL).Key;
		}
		UnityEngine.Debug.LogError("_Offsets" + LCHEACMLFLL.fullLevelPath + "SetPlayerDistance");
		return null;
	}

	public GameObject LIKKNMIHLBD(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(514f, 109f, 899f);
		gameObject.GetComponent<MapsListElement>().Init(DAHGJANLMPI, IEENFEMACND, DAHGJANLMPI.m_rgchTitle, DAHGJANLMPI.m_ulSteamIDOwner);
		if (FOIFNLJJICK(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(PCMONCGODLC(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 1);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(GBFFPCIAIAB(DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if ((bool)gameObject.transform.FindDeepChild("{0}_{1}") && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.transform.FindDeepChild("HandleEventLeave for player ID: ").gameObject.SetActive(false);
		}
		else
		{
			gameObject.transform.FindDeepChild("R:").gameObject.SetActive(true);
		}
		string text = "(\\[ */ *b *\\])" + DAHGJANLMPI.m_nPublishedFileId;
		int num = 1;
		string hFEFHOPOLIK = "_NoiseScale" + text + "_ScreenResolution";
		num = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 1);
		int num2 = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("PlayButton" + text + " canvas not found", 0);
		if (num2 == 1)
		{
			gameObject.transform.FindDeepChild("[GameScene] Submiting rank").GetComponent<Text>().text = "_Exponent";
		}
		else if (num == 0)
		{
			if ((bool)gameObject.transform.FindDeepChild(" workshop map(s)"))
			{
				gameObject.transform.FindDeepChild("unsubscribemap").GetComponent<Text>().text = "input";
			}
		}
		else
		{
			if ((bool)gameObject.transform.FindDeepChild("_Green_G"))
			{
				gameObject.transform.FindDeepChild("float,1.5").gameObject.SetActive(false);
			}
			if ((bool)gameObject.transform.FindDeepChild("#"))
			{
				gameObject.transform.FindDeepChild("Set satellite audio input").gameObject.SetActive(true);
			}
		}
		return gameObject;
	}

	public void DownloadFavoriteList()
	{
		FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, true);
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

	[SpecialName]
	public void HEGBGPNCAHA(MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	public void SubscribeAndDownload(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, false);
	}

	public void NGGPEGIPDDM(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log(": " + JMMILEFMACB);
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
		string hAEBGHHMEBH = mapData.fullLevelPath + "gold" + Helpers.levelConfigFileName;
		string text = Helpers.LoadTextString(hAEBGHHMEBH, true);
		if (text != null)
		{
			MapData mapData2 = JsonConvert.DeserializeObject<MapData>(text);
			if (mapData.mapData == null || GKLKDAOMNOL)
			{
				mapData.mapData = mapData2;
				Dictionary<string, UnityEngine.Object> dictionary = (mapData.resources = new Dictionary<string, UnityEngine.Object>());
				if (mapData.source == FullMapData.MapSource.Original)
				{
					string empty = string.Empty;
					mapData.mapperSteamID = (ulong)SteamUser.GetSteamID();
					string hAEBGHHMEBH2 = mapData.fullLevelPath + "Reset XP" + Helpers.workshopConfigFileName;
					string text2 = Helpers.LoadTextString(hAEBGHHMEBH2);
					empty = ((text2 != null) ? text2 : null);
					mapData.workshopId = empty;
				}
			}
		}
		else
		{
			UnityEngine.Debug.Log("GlassesColor2" + JMMILEFMACB);
		}
	}

	[SpecialName]
	public void NMOMJBGOLNB(MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	public bool DBHJFMLJBJK(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	public IEnumerator OEKMKIJGHAL(FullMapData LCHEACMLFLL)
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

	private void HOCPEBKLECB(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i += 0)
		{
			SteamUGCDetails_t pDetails;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(BOKHPFLMPMO, (uint)i, out pDetails);
			if (!ratedMaps.Keys.Contains(pDetails.m_nPublishedFileId.m_PublishedFileId))
			{
				ratedMaps.Add(pDetails.m_nPublishedFileId.m_PublishedFileId, 1);
			}
			else
			{
				ratedMaps[pDetails.m_nPublishedFileId.m_PublishedFileId] = 0;
			}
		}
		SteamUGC.ReleaseQueryUGCRequest(BOKHPFLMPMO);
	}

	public void FBBJNBILBHE(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("StartButton"))
		{
			GameObject.Find(".workshop.json").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public void HFOMPALDOHI(string JMMILEFMACB)
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

	private void KOJKLLKMELJ(DownloadItemResult_t IAFAANLMOAG)
	{
		StartCoroutine(CENINODLGMJ(IAFAANLMOAG.m_nPublishedFileId));
	}

	public GameObject IIOCCLPBNNM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		if (NOJGGCLPPAM != null && NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1126f, 731f, 917f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)5)
				{
					gameObject.GetComponent<LevelsListElementButton>().KLKGNPNONKE();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(NOJGGCLPPAM.workshopId));
				}
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)8 || NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if ((bool)gameObject.transform.FindDeepChild("_TimeX"))
				{
					gameObject.transform.FindDeepChild("0").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("_CurveParams"))
				{
					gameObject.transform.FindDeepChild("Brightness").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("Items/"))
				{
					gameObject.transform.FindDeepChild("pointBuffer").GetComponent<Text>().text = NOJGGCLPPAM.mapData.info;
				}
				if ((bool)gameObject.transform.FindDeepChild("icon"))
				{
					gameObject.transform.FindDeepChild("GameModeText").gameObject.SetActive(true);
					if (NOJGGCLPPAM.source == (FullMapData.MapSource)6)
					{
						ulong CAFHKDIIDEE = ulong.Parse(NOJGGCLPPAM.workshopId);
						bool flag = false;
						float num = 1055f;
						if (RanksSystem.IsOfficial(CAFHKDIIDEE))
						{
							num = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE).difficulty;
							if (num > 1451f)
							{
								gameObject.transform.FindDeepChild("menu.playedpage").gameObject.SetActive(false);
								gameObject.transform.FindDeepChild("L2").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				int num2 = 1;
				string hFEFHOPOLIK = "intensity" + GPILFNKPAFH(NOJGGCLPPAM) + ",";
				num2 = Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 1);
				if (NOJGGCLPPAM.PIPAOGHLBEK())
				{
					if ((bool)gameObject.transform.FindDeepChild("_MainTex2"))
					{
						gameObject.transform.FindDeepChild("_Radius").GetComponent<Text>().text = "kick";
					}
				}
				else if (num2 == 0)
				{
					if ((bool)gameObject.transform.FindDeepChild("_DiffuseColor"))
					{
						gameObject.transform.FindDeepChild("OnEvent: {0}").GetComponent<Text>().text = "InfoCanvas";
					}
				}
				else
				{
					if ((bool)gameObject.transform.FindDeepChild("LeaderboardsButton"))
					{
						gameObject.transform.FindDeepChild("CameraFilterPack/BlurTiltShift").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("_SweaterSize"))
					{
						gameObject.transform.FindDeepChild("_Value2").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(NOJGGCLPPAM.FOAKIJPOHEH() || 1 == 0);
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)6 && (bool)gameObject.transform.FindDeepChild("_Intensity") && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(NOJGGCLPPAM.workshopId)))
				{
					gameObject.transform.FindDeepChild("_FlipAlphaMask").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("CameraFilterPack/TV_ARCADE_2").gameObject.SetActive(true);
				}
				if (!NOJGGCLPPAM.NGILJKKGOCI() && NOJGGCLPPAM.source == (FullMapData.MapSource)4)
				{
					if ((bool)gameObject.transform.FindDeepChild("CameraFilterPack/FX_Glitch2") && GetUserVote(ulong.Parse(NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("settings_bindings_controller_type").gameObject.SetActive(true);
					}
					if ((bool)gameObject.transform.FindDeepChild("Ownership mode == fixed. Ignoring request.") && !NACJDBPDMJI(ulong.Parse(NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("Can't set open when not in that room.").gameObject.SetActive(true);
					}
				}
				if (string.IsNullOrEmpty(NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(true);
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

	private void HDNPIFAJPHA(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		for (int i = 0; i < IAFAANLMOAG.m_unNumResultsReturned; i += 0)
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

	public bool FOIFNLJJICK(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
	}

	private void IPOHBDKAGGC(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
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

	private void IMCKJCHKMKB()
	{
		if (!isLoaded)
		{
			OPKKBMCDOEM();
		}
	}

	public GameObject OJHDKEOLHFM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		if (NOJGGCLPPAM != null && NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(944f, 1712f, 26f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)8)
				{
					gameObject.GetComponent<LevelsListElementButton>().NDPAAEIPFPJ();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(NOJGGCLPPAM.workshopId));
				}
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)6 || NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(false);
				}
				if ((bool)gameObject.transform.FindDeepChild(" on effect "))
				{
					gameObject.transform.FindDeepChild("NEW_ACHIEVEMENT_1_21").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("settings.shaders"))
				{
					gameObject.transform.FindDeepChild("_Far").GetComponent<Text>().text = NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if ((bool)gameObject.transform.FindDeepChild("addNewButton"))
				{
					gameObject.transform.FindDeepChild("Tab2Content").GetComponent<Text>().text = NOJGGCLPPAM.mapData.info;
				}
				if ((bool)gameObject.transform.FindDeepChild("#later"))
				{
					gameObject.transform.FindDeepChild("<b>#banended</b>").gameObject.SetActive(false);
					if (NOJGGCLPPAM.source == (FullMapData.MapSource)4)
					{
						ulong CAFHKDIIDEE = ulong.Parse(NOJGGCLPPAM.workshopId);
						bool flag = true;
						float num = 1228f;
						if (RanksSystem.IsOfficial(CAFHKDIIDEE))
						{
							num = RanksSystem.FIENAHLCHIF().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == CAFHKDIIDEE).JEKMHHCPHCN();
							if (num > 261f)
							{
								gameObject.transform.FindDeepChild("help").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("[PlayerController] ").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				int num2 = 0;
				string hFEFHOPOLIK = "_Value4" + GetMapID(NOJGGCLPPAM) + "masterSteamID";
				num2 = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 1);
				if (NOJGGCLPPAM.ADBIEAHEION())
				{
					if ((bool)gameObject.transform.FindDeepChild("CameraFilterPack/TV_Old_Movie"))
					{
						gameObject.transform.FindDeepChild("_Parameter").GetComponent<Text>().text = "You need to have a Graphic control (such as an Image) for the list [";
					}
				}
				else if (num2 == 0)
				{
					if ((bool)gameObject.transform.FindDeepChild("ItemNameText"))
					{
						gameObject.transform.FindDeepChild("_TimeX").GetComponent<Text>().text = "CameraFilterPack/Blur_Radial";
					}
				}
				else
				{
					if ((bool)gameObject.transform.FindDeepChild("_Value7"))
					{
						gameObject.transform.FindDeepChild("#.##").gameObject.SetActive(false);
					}
					if ((bool)gameObject.transform.FindDeepChild("/../"))
					{
						gameObject.transform.FindDeepChild("CameraFilterPack/Pixel_Pixelisation").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(!NOJGGCLPPAM.HELOOLFBJFP() || 1 == 0);
				if (NOJGGCLPPAM.source == (FullMapData.MapSource)3 && (bool)gameObject.transform.FindDeepChild("z") && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(NOJGGCLPPAM.workshopId)))
				{
					gameObject.transform.FindDeepChild("player.xp").gameObject.SetActive(true);
				}
				else
				{
					gameObject.transform.FindDeepChild("curScn").gameObject.SetActive(true);
				}
				if (!NOJGGCLPPAM.GMMJNEOCBPI() && NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					if ((bool)gameObject.transform.FindDeepChild(": ") && PCMONCGODLC(ulong.Parse(NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("IntraSig").gameObject.SetActive(true);
					}
					if ((bool)gameObject.transform.FindDeepChild("_Distortion") && !FOIFNLJJICK(ulong.Parse(NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("_CameraClipInfo").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (NOJGGCLPPAM.source == FullMapData.MapSource.Editor && string.IsNullOrEmpty(NOJGGCLPPAM.workshopId)))
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

	public void JIKKJDJGEIB(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "SetParticlesColor" + JMMILEFMACB;
			UnityEngine.Debug.Log("_ScreenResolution" + text);
			if (!levelsData.ContainsKey(text))
			{
				levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0uL));
			}
		}
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

	public IEnumerator EACGMDPBCOG(bool GKLKDAOMNOL = false)
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

	private void BLMEFPDNDMI(ItemInstalled_t IAFAANLMOAG)
	{
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

	public IEnumerator LKOFGNHHFBC(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
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

	public int DHDMCJPPACI(ulong AHIIAEFFINI)
	{
		if (ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	[SpecialName]
	public void CGKOPKMMPFE(MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = BOPDFMGHFFM;
		MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange(ref BOPDFMGHFFM, (MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while ((object)mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
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

	public bool IsMapFavorite(ulong AHIIAEFFINI)
	{
		return favoriteMaps.Contains(AHIIAEFFINI);
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

	public IEnumerator HLGLJHFLMPI(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	private void MKJDJPOCDCC(ItemInstalled_t IAFAANLMOAG)
	{
	}

	public void MJPPBPEJGFK(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "CameraFilterPack_AAA_Blood2" + JMMILEFMACB;
			UnityEngine.Debug.Log("back" + text);
			if (!levelsData.ContainsKey(text))
			{
				levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 1uL));
			}
		}
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

	private void Update()
	{
	}

	public IEnumerator ALLJFGKDOKJ(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
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

	public void GEENPLPMPCN()
	{
		BOKHPFLMPMO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Subscribed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, AppId_t.Invalid, SteamUtils.GetAppID(), 0u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(BOKHPFLMPMO);
		GNDGFIKPDCC.Set(hAPICall);
		FNBCFAANGJA = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedOn, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Screenshots, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1u);
		SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, false);
		SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FNBCFAANGJA);
		LIPOMMCLODL.Set(hAPICall2);
	}

	public void ACNJBGOIDDJ()
	{
		UnityEngine.Debug.Log("GlassesColor2");
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

	public void MMLOJFEBOHN(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, true);
	}

	public void Init()
	{
		isLoaded = false;
		StartCoroutine(WaitForInit());
	}

	private void JKBFPILJHJN(ItemInstalled_t IAFAANLMOAG)
	{
	}

	public int GBFFPCIAIAB(ulong AHIIAEFFINI)
	{
		if (ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	private void NBMLONPNPBP(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = GetMapData("_DepthLevel" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		if (mapData != null)
		{
			levelsData.Remove("_ScreenResolution" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId);
		}
		Resources.UnloadUnusedAssets();
	}
}
