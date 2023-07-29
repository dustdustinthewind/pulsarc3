// UI
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI : Singleton<UI>
{
	[Serializable]
	public class UIView
	{
		public string id;

		public bool useZoom;

		public float zoom;

		public bool blurBG;

		public List<GameObject> canvases;
	}

	[CompilerGenerated]
	private sealed class HKOLOPJKHIF
	{
		internal string HFEFHOPOLIK;

		internal bool FHFECFLBHMA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FMIHBNPKEEO(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FFEGPHJKMFK(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool OFLDIMDDLHM(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BFEABMIFIEE(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool AEINPAGJFME(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool KFNBKFELFLH(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool EGKGJJGAPMN(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LLNDDFGPOPL(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool GBKBDKHPLKG(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FJDBPPKABJE(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool JDELIMPGFDJ(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BEBAENEJFLD(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LJDLIIIPIIJ(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool DBFPGFHEGKA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool KGKMOLCPDIH(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool MGENGAEDACG(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FDAIFOAGDLA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool PIJAOCFAPKC(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FCAGEDLBBHD(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LOEAMHGMMPK(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LNDGINDKPFA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BJMAIJDIKCN(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool DNIMHEKGJHB(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool INHOEMCLAAP(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BDGDIDPDBHG(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool AEIFJLBBKBP(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool JKEDCEOCPJO(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FHIJCPPECHA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool OLIGLEMPFOP(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool PBCAHKDLFPE(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool HBJFIOJFBHC(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool MEMPOPNAEDN(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool JBAJEMGOPDL(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LHHFJBIAHCN(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool EFAPFFFGOOA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BKNHHGBPLGH(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool OFHCGKJFGDI(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool DKGPCPBNDPK(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool FIPCLHEKKCA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BMAOCLKPNNC(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool EKHOOPGPPGE(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool AGJKEBOPIOC(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool IGFOBPKFCDJ(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}
	}

	[CompilerGenerated]
	private sealed class MACNHEJAEDM
	{
		internal GameObject IPIOPNOHDOB;

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}
	}

	[CompilerGenerated]
	private sealed class IAMIDBEHMEC
	{
		internal GameObject IPIOPNOHDOB;

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}
	}

	[CompilerGenerated]
	private sealed class PEPADDKCAGK
	{
		internal GameObject IPIOPNOHDOB;

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EDGAPOPEIJF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FMIHBNPKEEO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BEBAENEJFLD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PCDFLCEIHFF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OMBHIBNMFNB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AKDOOLPMPMG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PKAPLCFHDOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JBCHBMKPDAJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool MAGEPMCPGOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool INHOEMCLAAP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AGFDCBCBAGI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}
	}

	[SerializeField]
	public List<UIView> viewsDictionary;

	public void OFIOJOOKAHI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ﾑ';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('￠').Length > 0)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = 'ﾽ';
			oEJIJIPGMCO = text3.Split(array2)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(CIADGNBMOLN(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 513f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(CIADGNBMOLN(item2, false, oEJIJIPGMCO, false, 1463f, false));
					}
					else
					{
						StartCoroutine(JCLKEGPNBJJ(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("team" + HFEFHOPOLIK + "#8E8E8EFF");
	}

	public void KFJPOACGOHL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == " PhotonView: ")
		{
			CIIKGGGDGLC();
		}
		else
		{
			Debug.LogWarning("logc" + JMMILEFMACB);
		}
	}

	public void KLIKIPEPHDC()
	{
		Singleton<UI>.Instance.LJOBBJGJCOC(",", 770f);
	}

	public void PNGLBLFJOOJ()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void OOHNEOOCLMB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split(')')[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('\uffbf').Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('ﾪ')[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(IONNACCHGJL(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 1007f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PKOPFBHMJHM(item2, false, oEJIJIPGMCO, true, 238f, false));
					}
					else
					{
						StartCoroutine(HPMMDHAEAJO(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("_Saturation" + HFEFHOPOLIK + "There was an error retrieving the NumberOfCurrentPlayers.");
	}

	public IEnumerator KOKCANEGNJH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void FFNFEIPDLJF(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split(',')[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('ﾭ').Length > 0)
		{
			string text2 = HFEFHOPOLIK;
			char[] array = new char[1];
			array[1] = '>';
			oEJIJIPGMCO = text2.Split(array)[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(CMFJGHFEKIK(IPIOPNOHDOB, false, oEJIJIPGMCO, true, 1616f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(NCMLIDIEECD(item2, true, oEJIJIPGMCO, false, 288f, false));
					}
					else
					{
						StartCoroutine(JCLKEGPNBJJ(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("Bad parameters for getint! Use <key> <value>" + HFEFHOPOLIK + "CameraFilterPack/Glitch_Mozaic");
	}

	public void ELOBPADDKGE()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void CKIEONHHKAI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "[ItemsHandler] Found ")
		{
			BackToMainMenu();
		}
		else
		{
			Debug.LogWarning("buttons" + JMMILEFMACB);
		}
	}

	public void LOLFAODHMGD(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ﾌ';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = 'ﾦ';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = '\uffdd';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(HJEODGHPPAJ(IPIOPNOHDOB3, false, oEJIJIPGMCO, false, 806f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(AMOKEEHJLFP(item2, false, oEJIJIPGMCO, true, 226f));
					}
					else
					{
						StartCoroutine(AMOKEEHJLFP(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Value2" + HFEFHOPOLIK + "_Value4");
	}

	public IEnumerator HPMMDHAEAJO(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void KFMODLOHGKI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\uffdd';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = 'ﾼ';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = '￮';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(FNBLMPBOKNH(IPIOPNOHDOB3, false, oEJIJIPGMCO, true, 142f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PKOPFBHMJHM(item2, false, oEJIJIPGMCO, false, 1059f));
					}
					else
					{
						StartCoroutine(PHIJAEAEHCF(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + HFEFHOPOLIK + "Set Arcs Speed");
	}

	public void IJPAELJGBCK(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_MainTex2")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("SetEnvSpriteColor" + JMMILEFMACB);
		}
	}

	public void CIIKGGGDGLC()
	{
		Singleton<UI>.Instance.NGJJBLNKIIH("SetParticlesParticleSpeed", 1862f);
	}

	public void AJCJDHAJGHI()
	{
		Singleton<UI>.Instance.KFMODLOHGKI("EventTimeInputField", 761f);
	}

	public void AEJENOFBCKI()
	{
		Singleton<UI>.Instance.FFNFEIPDLJF("Found best region: '", 796f);
	}

	public void HKECDBBMPIM()
	{
		Singleton<UI>.Instance.NIBDIAOIODC("BloomShaderValueSlider", 1739f);
	}

	public void GGIFLKMELMP()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void OEFEMGBOILG(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("workshop." + JMMILEFMACB);
		}
	}

	public void NIBDIAOIODC(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('ﾐ')[1];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '￨';
		if (text2.Split(array).Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = 'v';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(JCLKEGPNBJJ(IPIOPNOHDOB, true, oEJIJIPGMCO, false, 348f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PDDENNKIMAA(item2, false, oEJIJIPGMCO, true, 480f));
					}
					else
					{
						StartCoroutine(NIIOJBIEPMG(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("float,1.5" + HFEFHOPOLIK + "#failed!");
	}

	public IEnumerator CIADGNBMOLN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void GEAKCNKDOPL()
	{
		Singleton<UI>.Instance.OPPKAFLAKPE("3;4;9;10;21x6", 846f);
	}

	public void PPDIGLNIJID(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('p')[1];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'ﾦ';
		if (text2.Split(array).Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = '\u0014';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(FNBLMPBOKNH(IPIOPNOHDOB, true, oEJIJIPGMCO, false, 1280f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(HHBBFHKPOMM(item2, true, oEJIJIPGMCO, true, 1411f, false));
					}
					else
					{
						StartCoroutine(IOEPPMJBOLC(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("_ProjectToPixelMatrix" + HFEFHOPOLIK + "0.00");
	}

	public IEnumerator PDDENNKIMAA(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void DJAIHGJGOOL()
	{
		Singleton<UI>.Instance.JDAIFPFDJCK("ticket.ticket1", 417f);
	}

	public void DIFIHGGKLLH(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_Light2")
		{
			AJCJDHAJGHI();
		}
		else
		{
			Debug.LogWarning("_ScreenResolution" + JMMILEFMACB);
		}
	}

	public void CGKGIDKBCMP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ￍ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[1];
		array2[1] = 'Z';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'V';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(KMOMEPOBDBN(IPIOPNOHDOB3, false, oEJIJIPGMCO, false, 275f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(HJEODGHPPAJ(item2, true, oEJIJIPGMCO, true, 526f));
					}
					else
					{
						StartCoroutine(NMNFEEMHJPF(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("x" + HFEFHOPOLIK + "_TimeX");
	}

	public void OFEBBEDPNJP()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void FJGJLPFBFMI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ﾴ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[1];
		array2[1] = 'ￛ';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = '\u0011';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(FNBLMPBOKNH(IPIOPNOHDOB3, true, oEJIJIPGMCO, false, 1952f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PKOPFBHMJHM(item2, false, oEJIJIPGMCO, false, 1602f));
					}
					else
					{
						StartCoroutine(PDDENNKIMAA(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_TimeX" + HFEFHOPOLIK + "Joystick1Button3");
	}

	public IEnumerator PKOPFBHMJHM(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void DDOOOLMAILF()
	{
		Singleton<UI>.Instance.MLFKPPBECKP("settings.volume.editor", 272f);
	}

	public void ACJIJCBDDJL(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('\u000e')[1];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'e';
		if (text2.Split(array).Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('m')[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 546f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(NMNFEEMHJPF(item2, false, oEJIJIPGMCO, true, 442f));
					}
					else
					{
						StartCoroutine(NCMLIDIEECD(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("Set the end of the map. Use this if you want to cut the long music." + HFEFHOPOLIK + "SubmitUserVote:");
	}

	public void HKJNOKADNGB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = '7';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'S';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = '\uffd8';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(IOEPPMJBOLC(IPIOPNOHDOB3, false, oEJIJIPGMCO, false, 742f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(BCOJGDDEDOP(item2, true, oEJIJIPGMCO, true, 1582f, false));
					}
					else
					{
						StartCoroutine(PHIJAEAEHCF(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("ERROR: Make sure your mod contains at leats one file!" + HFEFHOPOLIK + "Texture2");
	}

	public void SwitchView(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('#')[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('#').Length > 1)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('#')[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB, false, oEJIJIPGMCO));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(SwitchViewAnimation(item2, true, oEJIJIPGMCO));
					}
					else
					{
						StartCoroutine(SwitchViewAnimation(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("[UI] " + HFEFHOPOLIK + " canvas not found");
	}

	public void IGNAKIKPGAP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'ﾃ';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('K').Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = 'ﾖ';
			oEJIJIPGMCO = text3.Split(array2)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(HPMMDHAEAJO(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 1153f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(GADDOIMMDHH(item2, false, oEJIJIPGMCO, true, 1281f));
					}
					else
					{
						StartCoroutine(PHIJAEAEHCF(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("CameraFilterPack/Glow_Glow" + HFEFHOPOLIK + "Item invalid. No idea why.");
	}

	public IEnumerator KMOMEPOBDBN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void LHNPACKBPKO()
	{
		Singleton<UI>.Instance.PPDIGLNIJID("_ScreenResolution", 189f);
	}

	public IEnumerator CMFJGHFEKIK(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void OCDOOHGMJIA()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void PDKFHOIBBGG(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "/files/mods_terms.pdf")
		{
			NAMMPGNCFJC();
		}
		else
		{
			Debug.LogWarning("_ScreenResolution" + JMMILEFMACB);
		}
	}

	public void JDAIFPFDJCK(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('ￂ')[0];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = 'ﾪ';
		if (text2.Split(array).Length > 0)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = 'L';
			oEJIJIPGMCO = text3.Split(array2)[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(BCOJGDDEDOP(IPIOPNOHDOB, false, oEJIJIPGMCO, true, 1618f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PKOPFBHMJHM(item2, true, oEJIJIPGMCO, true, 888f));
					}
					else
					{
						StartCoroutine(JCLKEGPNBJJ(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Value9" + HFEFHOPOLIK + "mapselector.filter.favoriteonly");
	}

	public void ONJNJAEGLJM()
	{
		Singleton<UI>.Instance.ACJIJCBDDJL("HitVariationSlider", 29f);
	}

	public void CCHMCLLHGJF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void ButtonClick(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "mainmenu")
		{
			BackToMainMenu();
		}
		else
		{
			Debug.LogWarning("[UI] Unknows button action: " + JMMILEFMACB);
		}
	}

	public void CGNFHPNAMKA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "FileMenu")
		{
			PPFBFANEHEA();
		}
		else
		{
			Debug.LogWarning("WARNING: rotation axis set to 0 on " + JMMILEFMACB);
		}
	}

	public IEnumerator HHBBFHKPOMM(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void JAAPAHFEDEH()
	{
		Singleton<UI>.Instance.JDAIFPFDJCK("VIGNETTE_CLASSIC", 945f);
	}

	public void BEMEHOBGEFB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = 'ﾛ';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('E').Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = '\u0004';
			oEJIJIPGMCO = text3.Split(array2)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(BCOJGDDEDOP(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 1697f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(CMFJGHFEKIK(item2, false, oEJIJIPGMCO, false, 1739f));
					}
					else
					{
						StartCoroutine(PDDENNKIMAA(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Blue_R" + HFEFHOPOLIK + "GameScene");
	}

	public void EFPPCCBIMKM()
	{
		Singleton<UI>.Instance.LOLFAODHMGD("player.arrow", 1260f);
	}

	public IEnumerator AMOKEEHJLFP(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator NCMLIDIEECD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void MLFKPPBECKP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'j';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ￓ';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'ﾧ';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(HJEODGHPPAJ(IPIOPNOHDOB3, true, oEJIJIPGMCO, false, 850f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(NIIOJBIEPMG(item2, false, oEJIJIPGMCO, true, 70f));
					}
					else
					{
						StartCoroutine(HJEODGHPPAJ(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])" + HFEFHOPOLIK + "[LevelEditorScene] Error: Timeout :S");
	}

	public void LBKIOIKDFCP(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "DPADVER")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("_Value2" + JMMILEFMACB);
		}
	}

	public void EENKPNLIHJB(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "Mouse Wheel Up")
		{
			IMGIPHENIFC();
		}
		else
		{
			Debug.LogWarning("CameraFilterPack/Distortion_Dissipation" + JMMILEFMACB);
		}
	}

	public void JGHKKDOEDCK(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'ﾦ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = '\ufff1';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = '\u0011';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(BCOJGDDEDOP(IPIOPNOHDOB3, false, oEJIJIPGMCO, true, 1008f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(NMNFEEMHJPF(item2, false, oEJIJIPGMCO, true, 371f, false));
					}
					else
					{
						StartCoroutine(FNBLMPBOKNH(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("player.blackwhite" + HFEFHOPOLIK + "#,0.00");
	}

	public IEnumerator HJEODGHPPAJ(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void DGFKMFBCKKJ()
	{
		Singleton<UI>.Instance.OFIOJOOKAHI("_Value3", 1478f);
	}

	public void JHFOMLLGNKD(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "The given 2D texture ")
		{
			AJCJDHAJGHI();
		}
		else
		{
			Debug.LogWarning("[Up-Right-Left]" + JMMILEFMACB);
		}
	}

	public IEnumerator PHIJAEAEHCF(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void CBFEECDDINO()
	{
		Singleton<UI>.Instance.PPDIGLNIJID("OpSettings()", 418f);
	}

	public void OPPKAFLAKPE(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\u000f';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ﾤ';
		if (text3.Split(array2).Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('\uffdf')[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(FNBLMPBOKNH(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 233f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(IOEPPMJBOLC(item2, true, oEJIJIPGMCO, false, 1472f));
					}
					else
					{
						StartCoroutine(KMOMEPOBDBN(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_ForegroundBlurExtrude" + HFEFHOPOLIK + "LB");
	}

	public IEnumerator SwitchViewAnimation(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void MCCBKCDPIMK()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public IEnumerator IOEPPMJBOLC(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator IONNACCHGJL(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void FAIMFNFOFCE(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "inventory.selected.")
		{
			DJAIHGJGOOL();
		}
		else
		{
			Debug.LogWarning("Joystick1Button10" + JMMILEFMACB);
		}
	}

	public void DOGABOPPHBH()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void EJIPLOBKMPC()
	{
		Singleton<UI>.Instance.MLFKPPBECKP("note.3", 1773f);
	}

	public void IMGIPHENIFC()
	{
		Singleton<UI>.Instance.FJGJLPFBFMI("_ScreenResolution", 1964f);
	}

	public void FAGIEGMPAIC()
	{
		Singleton<UI>.Instance.OFIOJOOKAHI("[ResourcesManager] Load image error: ", 408f);
	}

	public void MBLLNLBBAAL(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = '\uffdf';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ﾭ';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[1];
			array3[1] = 'ﾅ';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(NCMLIDIEECD(IPIOPNOHDOB3, false, oEJIJIPGMCO, true, 360f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(HHBBFHKPOMM(item2, false, oEJIJIPGMCO, true, 712f));
					}
					else
					{
						StartCoroutine(CIADGNBMOLN(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("settings.selectormapsperpage" + HFEFHOPOLIK + " evLeave: ");
	}

	public IEnumerator BFCOGLHKJLN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void MDGJJGHJGKE()
	{
		Singleton<UI>.Instance.CGKGIDKBCMP("GlassesColor2", 1756f);
	}

	public void EGFJCDLNGIL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "ConfigVersionSlider")
		{
			EFPPCCBIMKM();
		}
		else
		{
			Debug.LogWarning("_FadeFX" + JMMILEFMACB);
		}
	}

	public void BackToMainMenu()
	{
		Singleton<UI>.Instance.SwitchView("mainMenu");
	}

	public IEnumerator NMNFEEMHJPF(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void DDPPHDJFKOF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void HPMHPFOBPED(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('ﾕ')[1];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'b';
		if (text2.Split(array).Length > 1)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('\ufffe')[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(JCLKEGPNBJJ(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 39f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(NMNFEEMHJPF(item2, true, oEJIJIPGMCO, true, 1735f, false));
					}
					else
					{
						StartCoroutine(CBLGHHBMCPD(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("CameraFilterPack/Blend2Camera_Multiply" + HFEFHOPOLIK + "inventory.selected.");
	}

	public void LJOBBJGJCOC(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('\u0015')[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('-').Length > 1)
		{
			string text2 = HFEFHOPOLIK;
			char[] array = new char[1];
			array[1] = '\ufffb';
			oEJIJIPGMCO = text2.Split(array)[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(HPMMDHAEAJO(IPIOPNOHDOB, true, oEJIJIPGMCO, false, 195f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(IOEPPMJBOLC(item2, true, oEJIJIPGMCO, false, 1959f, false));
					}
					else
					{
						StartCoroutine(AMOKEEHJLFP(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("(\\[ *quote *\\])" + HFEFHOPOLIK + "_TimeX");
	}

	public IEnumerator BCOJGDDEDOP(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator JCLKEGPNBJJ(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void BMFMLKCDOOE(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = ' ';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('￠').Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = 'ﾽ';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(KOKCANEGNJH(IPIOPNOHDOB, false, oEJIJIPGMCO, true, 557f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PHIJAEAEHCF(item2, false, oEJIJIPGMCO, true, 1689f, false));
					}
					else
					{
						StartCoroutine(HHBBFHKPOMM(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("#yes" + HFEFHOPOLIK + "stretchWidth");
	}

	public void ClearSelection()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void PPFBFANEHEA()
	{
		Singleton<UI>.Instance.KFMODLOHGKI("Items", 308f);
	}

	public void PEJKKBOELBA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_AdaptParams")
		{
			ONJNJAEGLJM();
		}
		else
		{
			Debug.LogWarning("Clears the console and prints the logs in the specified range" + JMMILEFMACB);
		}
	}

	public void HPLGACFDEJJ()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void NAMMPGNCFJC()
	{
		Singleton<UI>.Instance.BEMEHOBGEFB("id", 541f);
	}

	public IEnumerator NIIOJBIEPMG(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void BKBBGAFPIKA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_ScreenResolution")
		{
			CBFEECDDINO();
		}
		else
		{
			Debug.LogWarning("_Value4" + JMMILEFMACB);
		}
	}

	public void MDKHCGABDAI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == ":")
		{
			KLIKIPEPHDC();
		}
		else
		{
			Debug.LogWarning("[Right]" + JMMILEFMACB);
		}
	}

	public IEnumerator FNBLMPBOKNH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void OPJPHPIOBGE(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_Value")
		{
			CIIKGGGDGLC();
		}
		else
		{
			Debug.LogWarning("menu.enableselectormusic" + JMMILEFMACB);
		}
	}

	public void BJJAIAGDMGI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "SetLives")
		{
			FAGIEGMPAIC();
		}
		else
		{
			Debug.LogWarning("settings.enablehitsoundsinrelax" + JMMILEFMACB);
		}
	}

	public IEnumerator CBLGHHBMCPD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void NGJJBLNKIIH(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\ufffd';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = '@';
		if (text3.Split(array2).Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('ﾱ')[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(PHIJAEAEHCF(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 132f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(CMFJGHFEKIK(item2, true, oEJIJIPGMCO, true, 1489f, false));
					}
					else
					{
						StartCoroutine(AMOKEEHJLFP(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("maps." + HFEFHOPOLIK + "CameraFilterPack/Blend2Camera_GreenScreen");
	}

	public IEnumerator GADDOIMMDHH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void LBFGNKKJJHB(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "Player")
		{
			EFPPCCBIMKM();
		}
		else
		{
			Debug.LogWarning("MascotChallenge2019" + JMMILEFMACB);
		}
	}

	public void DLHMKKOKJPE()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void KOOJFJDNFCJ(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = '\uffdd';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ﾝ';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[1];
			array3[1] = 'ﾎ';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(CIADGNBMOLN(IPIOPNOHDOB3, false, oEJIJIPGMCO, false, 1730f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(BCOJGDDEDOP(item2, true, oEJIJIPGMCO, true, 1552f, false));
					}
					else
					{
						StartCoroutine(CBLGHHBMCPD(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("ConfigVersionSlider" + HFEFHOPOLIK + "_ColoredChange");
	}

	public void ILEIPDFMLJL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "]")
		{
			MDGJJGHJGKE();
		}
		else
		{
			Debug.LogWarning(".sawoutdatedmessage" + JMMILEFMACB);
		}
	}
}
