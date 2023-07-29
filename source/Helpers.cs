// Helpers
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using NAudio.Wave;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;

public static class Helpers
{
	[CompilerGenerated]
	private sealed class CEMBABEIJBO
	{
		internal string JMMILEFMACB;

		internal bool AHBIANHNBBC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool NBFOKGGNEOJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool LADECCOJPPL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool DIOBKCECBCH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool DGDCNDCGPCP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool JKEDCEOCPJO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool LDNDNOOCFFA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool MBOCPCMMJDI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool JBAJEMGOPDL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HNMFCOHLALO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool IMOHKBJBLBA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool ECGDAHDOPBO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool BOPKCHEPEEB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool NPLKFNFPOKC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool PEJNJBGMPKB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool GMLFBOMLINM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool OFLDIMDDLHM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool CHBEFOHEEGK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool FBECAHEMHOO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool BOJCHGIGGNK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool JIMIGOHADJG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool BFNOHOLLLHB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool BFEABMIFIEE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool PIJAOCFAPKC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HKCAPINMNFF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool FHIJCPPECHA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool FPBODMOMNPG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool NHPDJEKEOKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool KDDPLGEFPEJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool PHDFIAGENEE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool INHOEMCLAAP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool FFEGPHJKMFK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool AHHNAGGBKOO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool JPICHJKIMDH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool FKCDLJELMNN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool HBJOAAJMDDE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool PCDFLCEIHFF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool GCLCICMFCPK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool GHBIKOKGLHE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool GEPBCIIDMBC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool FJDBPPKABJE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool DBOEBFFAOFJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool JBCHBMKPDAJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HGOHMNAGGKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool OMJJLDBPEHI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool MEMPOPNAEDN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool MKLOGMNMFAF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool DNIMHEKGJHB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool OFHCGKJFGDI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool JDELIMPGFDJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool KFNPHCCAJFD(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool HMMBBDJNGGL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool CBHLHPPBCIG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool KFNBKFELFLH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool ONEPCCGOEKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool CJDNDHBDMMO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool DFPLMEODJAM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool PLINPGHDODA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool HJNKOEGPEMO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool JPGFOBNOBKN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool BDNFJBBKBOL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool JBLJIFJHDLO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool KGKMOLCPDIH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool EKHOOPGPPGE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HCFLGKJFKFE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool DPFLLMAOIHH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool HIKCHCCKLJG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool ACJAHEOLJNH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool MOJKEOEEEDF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool EFAPFFFGOOA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HKPGGBDEHAM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool NGFGLJGABCM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool IKMOFMJNEPH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool OMBHIBNMFNB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool HKHIFPLBAMM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool LGKFHOBDANE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == JMMILEFMACB;
		}

		internal bool PHGILLBNBME(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}
	}

	[CompilerGenerated]
	private sealed class GONBBDCKFPG
	{
		internal int NCCNGCFMNII;

		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}

		internal bool EGKGJJGAPMN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool MEMPOPNAEDN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool LHHFJBIAHCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}

		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool KGKMOLCPDIH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}

		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool FCAGEDLBBHD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}

		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII));
		}

		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool DNIMHEKGJHB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool FDAIFOAGDLA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool JDELIMPGFDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool BKNHHGBPLGH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool FHIJCPPECHA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII));
		}

		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII));
		}

		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII));
		}

		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII));
		}

		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}

		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool BMAOCLKPNNC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII;
		}

		internal bool HBJFIOJFBHC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII;
		}

		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < NCCNGCFMNII);
		}

		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII);
		}
	}

	public static string levelConfigFileName = "config.txt";

	public static string mapEncodedConfigFileName = "map.data";

	public static string workshopConfigFileName = "workshop.txt";

	public static string newsURL = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";

	public static string newsGIDURL = "/GetNews/pinnednewsid";

	public static List<string> specialTags = new List<string> { "Winter2020" };

	public static List<string> tags = new List<string>
	{
		"Alternative", "Anime", "Blues", "Children", "Classical", "Dance", "Electronic", "Folk", "Hip-hop", "Indie",
		"Instrumental", "Jazz", "Metal", "Pop", "Rap", "Rock", "Soundtrack", "Other"
	};

	public static List<string> patternsMap = new List<string>
	{
		"[Up]", "[Right]", "[Down]", "[Left]", "[Up-Right-Left]", "[Up-Right-Down]", "[Right-Down-Left]", "[Up-Down-Left]", "[Up-Right-Down-Left]", "[PowerUp]",
		"[Up-Right]", "[Up-Down]", "[Up-Left]", "[Right-Down]", "[Right-Left]", "[Down-Left]"
	};

	public static string eventsMapLine = "\n";

	public static List<EditorEventFunctionInfo> eventsMap = new List<EditorEventFunctionInfo>
	{
		new EditorEventFunctionInfo("SpawnObj", "Arc", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("arc", EditorEventFunctionInfo.EditorEventParametrType.ArcSelector, string.Empty),
			new EditorEventFunctionInfo.EditorEventParametr("hand", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - default, 1 - left, 2 - right", "0,2,true,0")
		}, "Spawn ark to be pressed at this time", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetSpeed", "Set Arcs Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "1,30,true,0")
		}, "Set arcs speed. Base value - 15", 2, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("MapEnd", "Music End", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Set the end of the map. Use this if you want to cut the long music.", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("ShowSprite", "Show Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty),
			new EditorEventFunctionInfo.EditorEventParametr("position", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - background, 1 - foreground", "0,1,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr(string.Empty, EditorEventFunctionInfo.EditorEventParametrType.Toggle, string.Empty, "keep aspect ratio"),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "in seconds. 0 - forever", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("fade in duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5"),
			new EditorEventFunctionInfo.EditorEventParametr("fade out duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5")
		}, "Show image from resources by id at the center of the screen at foreground or background"),
		new EditorEventFunctionInfo("ShowTitle", "Show Title", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("title", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Message duration multiplier. Recomended 1", "float,1")
		}, "Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'"),
		new EditorEventFunctionInfo("SetBGColor", "Set Background Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("red", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("green", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("blue", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set camera background color"),
		new EditorEventFunctionInfo("SetPlayerDistance", "Set Player Distance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("distance", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "4,28,true,0")
		}, "Set camera (or player) distance. Base player distance - 14", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetTrailZoomSpeed", "Set Trail Zoom Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Zoom speed. Base 1.5", "float,1.5")
		}, "Set Trail Zoom (player camera move forward effect). Base value - 1.5", 2),
		new EditorEventFunctionInfo("AddEnvironmentObject", "Add Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("type", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - sun, 1 - satellite, 2 - particles emitter", "0,2,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr("set id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive")
		}, "Spawn new environment object (sun, satellite etc) and sets its id", 2),
		new EditorEventFunctionInfo("RemoveEnvironmentObject", "Remove Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive")
		}, "Despawn environment object by id", 2),
		new EditorEventFunctionInfo("ClearEnvironment", "Clear Environment", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Destroy all spawned environment objects", 2),
		new EditorEventFunctionInfo("SetPosition", "Set Object Position", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Move environment object to the position", 2),
		new EditorEventFunctionInfo("SetRotation", "Set Object Rotation", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Rotate environment object to the rotation", 2),
		new EditorEventFunctionInfo("SetScale", "Set Object Scale", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Scale environment object by the values", 2),
		new EditorEventFunctionInfo("SetParent", "Set Parent", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("Object ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("Parent ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Parent object ID. Case-Sensitive")
		}, "Set object anchor to another object", 2),
		new EditorEventFunctionInfo("SetSunColors", "Set Sun Colors", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("max. lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB"),
			new EditorEventFunctionInfo.EditorEventParametr("no lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB")
		}, "Set sun colors", 2),
		new EditorEventFunctionInfo("SetSunEmission", "Set Sun Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun emission (glow)", 2),
		new EditorEventFunctionInfo("SetSunInput", "Set Sun Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set sun audio input", 2),
		new EditorEventFunctionInfo("SetSunLerpSpeed", "Set Sun Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun lerp speed", 2),
		new EditorEventFunctionInfo("SetSunSensitivity", "Set Sun Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set sun beat detection sensitivity", 2),
		new EditorEventFunctionInfo("SetSunMinSize", "Set Sun MinSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set sun min/max size", 2),
		new EditorEventFunctionInfo("SetSunMaxSize", "Set Sun MaxSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun min/max size", 2),
		new EditorEventFunctionInfo("SetSunDirectionVector", "Set Sun DirectionVector", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun directionVector - in which direction sun will grow on beat", 2),
		new EditorEventFunctionInfo("SetSatelliteColor", "Set Satellite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB")
		}, "Set satellite color", 2),
		new EditorEventFunctionInfo("SetSatelliteEmission", "Set Satellite Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set satellite emission (glow)", 2),
		new EditorEventFunctionInfo("SetSatelliteInput", "Set Satellite Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set satellite audio input", 2),
		new EditorEventFunctionInfo("SetSatelliteLerpSpeed", "Set Satellite Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set satellite lerp speed", 2),
		new EditorEventFunctionInfo("SetSatelliteSensitivity", "Set Satellite Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set satellite beat detection sensitivity", 2),
		new EditorEventFunctionInfo("SetSatelliteRotationSpeed", "SetSatelliteRotationSpeed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,40")
		}, "Set satellite clockwise rotattion speed", 2),
		new EditorEventFunctionInfo("SetSatelliteRadius", "Set Satellite Radius", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite radius (offset)", 2),
		new EditorEventFunctionInfo("SetSatelliteTrailLength", "Set Satellite Trail Length", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail length in seconds", 2),
		new EditorEventFunctionInfo("SetSatelliteTrailWidth", "Set Satellite Trail Width", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail width", 2),
		new EditorEventFunctionInfo("SetSatelliteTrailMinVertexDistance", "Set Satellite Trail MinVertexDistance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite MinVertexDistance - how much distance should be between to points of the trail line", 2),
		new EditorEventFunctionInfo("SetCrosshairColor", "Set Crosshair Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set crosshair color", 2),
		new EditorEventFunctionInfo("SetCrosshairEmission", "Set Crosshair Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set crosshair emission (glow)", 2),
		new EditorEventFunctionInfo("SetParticlesColor", "Set Particles Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB")
		}, "Set particles color", 2),
		new EditorEventFunctionInfo("SetParticlesEmission", "Set Particles Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set particless emission (glow)", 2),
		new EditorEventFunctionInfo("SetParticlesParticleSize", "Set Particle Size", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set particles size", 2),
		new EditorEventFunctionInfo("SetParticlesGravity", "Set Particles Gravity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles gravity", 2),
		new EditorEventFunctionInfo("SetParticlesParticleSpeed", "Set Particles Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles start speed", 2),
		new EditorEventFunctionInfo("SetParticlesCountPerBeat", "Set Particles Count Per Beat", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles count per one beat", 2),
		new EditorEventFunctionInfo("SetParticlesInput", "Set Particles Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set particles audio input", 2),
		new EditorEventFunctionInfo("AddEnvironmentSprite", "Add Environment Sprite", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "(from resources)"),
			new EditorEventFunctionInfo.EditorEventParametr("set environment id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Start Color's hex value #RRGGBBAA", "#FFFFFFFF")
		}, "Spawn new environment sprite (image) and sets its id", 3),
		new EditorEventFunctionInfo("SetEnvSpriteImage", "Set EnvSprite Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("image", EditorEventFunctionInfo.EditorEventParametrType.InputField, "New resource ID. Case-Sensitive")
		}, "Switch environment sprite image", 3),
		new EditorEventFunctionInfo("SetEnvSpriteColor", "Set EnvSprite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Color's hex value #RRGGBBAA", "#FFFFFFFF"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", "float,10")
		}, "Set environment sprite color and alpha.", 3)
	};

	public static Dictionary<string, string> textResult = new Dictionary<string, string>();

	public static Sprite resultImage = null;

	public static Dictionary<string, bool> resultLevelNotModified = new Dictionary<string, bool>();

	public static bool resultSubmitNewHash = false;

	public static AudioClip resultAudio = null;

	public static float resultAudioLength = 0f;

	[CompilerGenerated]
	private static Func<char, bool> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<double, double> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Func<MapEvent, bool> HCLEECLNOEA;

	public static string GetGameVersion()
	{
		return Application.version;
	}

	public static bool IsStoryboardEvent(string JMMILEFMACB)
	{
		if (!eventsMap.Exists((EditorEventFunctionInfo HLIOCNLOFMK) => HLIOCNLOFMK.id == JMMILEFMACB))
		{
			return true;
		}
		return eventsMap.Exists((EditorEventFunctionInfo HLIOCNLOFMK) => HLIOCNLOFMK.id == JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard);
	}

	private static double NPMILGHONMJ(int AFMLIFBPDPG)
	{
		return 0.0 - (double)(AFMLIFBPDPG * AFMLIFBPDPG) / 4.0 + (double)(1.3f * (float)AFMLIFBPDPG);
	}

	private static double EPIDEKIOIKD(double KEDDLFDAIDE)
	{
		return KEDDLFDAIDE / 14.0;
	}

	private static double AAHJGEGFLEM(double CIHKHOHGNDG)
	{
		if (CIHKHOHGNDG < 14.0)
		{
			return 14.0 / CIHKHOHGNDG;
		}
		return CIHKHOHGNDG * CIHKHOHGNDG / 196.0 - CIHKHOHGNDG / 7.0 + 2.0;
	}

	public static float GetMapDifficulty(MapData CLCBMMEKBBC)
	{
		MapData mapData = new MapData(CLCBMMEKBBC);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(eData.events);
			}
			catch (Exception)
			{
			}
		}
		double kEDDLFDAIDE = CLCBMMEKBBC.speed;
		double cIHKHOHGNDG = 14.0;
		double num = 0.0;
		double num2 = mapData.musicTime;
		bool flag = false;
		foreach (MapEvent @event in mapData.events)
		{
			if (@event.data[0] == "SpawnObj")
			{
				if (!flag)
				{
					num = @event.time;
					flag = true;
				}
				num2 = @event.time;
			}
		}
		if (!flag || num == num2)
		{
			return 0f;
		}
		double num3 = num2 - num;
		double num4 = AAHJGEGFLEM(cIHKHOHGNDG);
		double num5 = EPIDEKIOIKD(kEDDLFDAIDE);
		double num6 = 0.0;
		int num7 = 0;
		double num8 = 0.0;
		int num9 = 0;
		List<double> list = new List<double>();
		for (int i = 0; i < (int)Math.Ceiling(num2); i++)
		{
			int num10 = 0;
			double num11 = 0.0;
			foreach (MapEvent event2 in mapData.events)
			{
				if (!(event2.time >= (float)i) || !(event2.time < (float)(i + 1)))
				{
					continue;
				}
				if (event2.data[0] == "SpawnObj")
				{
					int num12 = event2.data[1].Count((char HBJIMONFKNL) => HBJIMONFKNL == '-') + 1;
					num10 += num12;
					double num13 = NPMILGHONMJ(num12);
					num11 += num13 * num4 * num5;
				}
				if (event2.data[0] == "SetPlayerDistance")
				{
					float num14 = float.Parse(event2.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
					num4 = AAHJGEGFLEM(num14);
				}
				if (event2.data[0] == "SetSpeed")
				{
					float num15 = float.Parse(event2.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
					num5 = EPIDEKIOIKD(num15);
				}
			}
			if (num10 > 0)
			{
				num9++;
			}
			if (num8 < num11)
			{
				num8 = num11;
			}
			if (num11 > 0.0)
			{
				num6 += num11;
				num7++;
				list.Add(num11);
			}
		}
		int num16 = (int)Math.Ceiling((double)num9 * 0.33);
		double num17 = 0.0;
		for (int j = 0; j < num16; j++)
		{
			double num18 = list.OrderBy((double LPGNCFKLMEH) => 0.0 - LPGNCFKLMEH).ToList()[j];
			num17 += num18;
		}
		double num19 = num17 / (double)num16;
		double num20 = Math.Log(num9, 60.0);
		double value = num20 * num19;
		return (float)Math.Round(value, 2);
	}

	public static int GetMapMaxScore(MapData CLCBMMEKBBC)
	{
		MapData mapData = new MapData(CLCBMMEKBBC);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(eData.events);
			}
			catch (Exception)
			{
			}
		}
		List<MapEvent> list = mapData.events.Where((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "SpawnObj").ToList();
		int num = 0;
		int num2 = 0;
		foreach (MapEvent item in list)
		{
			int num3 = item.data[1].Split('-').Length;
			for (int i = 0; i < num3; i++)
			{
				num2++;
				num += num2;
			}
		}
		return num;
	}

	public static Color HexToColor(string MLPCOMHPPNH)
	{
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("0x", string.Empty);
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("#", string.Empty);
		byte a = byte.MaxValue;
		byte r = byte.Parse(MLPCOMHPPNH.Substring(0, 2), NumberStyles.HexNumber);
		byte g = byte.Parse(MLPCOMHPPNH.Substring(2, 2), NumberStyles.HexNumber);
		byte b = byte.Parse(MLPCOMHPPNH.Substring(4, 2), NumberStyles.HexNumber);
		if (MLPCOMHPPNH.Length == 8)
		{
			a = byte.Parse(MLPCOMHPPNH.Substring(6, 2), NumberStyles.HexNumber);
		}
		return new Color32(r, g, b, a);
	}

	public static string ColorToHex(Color HABLFKCCKLN)
	{
		return ColorUtility.ToHtmlStringRGBA(HABLFKCCKLN);
	}

	public static int GetPlayerLevel(int EEGKDDBECBE)
	{
		int num = 0;
		int num2 = EEGKDDBECBE;
		for (int num3 = 0; num3 <= num2; num3 = num * 500)
		{
			num2 -= num3;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return num;
	}

	public static Transform FindDeepChild(this Transform INBEMGANDKE, string JNOIHECMHJJ)
	{
		Transform transform = INBEMGANDKE.Find(JNOIHECMHJJ);
		if (transform != null)
		{
			return transform;
		}
		IEnumerator enumerator = INBEMGANDKE.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform iNBEMGANDKE = (Transform)enumerator.Current;
				transform = iNBEMGANDKE.FindDeepChild(JNOIHECMHJJ);
				if (transform != null)
				{
					return transform;
				}
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
		return null;
	}

	public static float GetPlayerLevelProgress()
	{
		int num = 0;
		int num2 = GetStat("player.xp");
		int num3;
		for (num3 = 0; num3 <= num2; num3 = num * 500)
		{
			num2 -= num3;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return (float)num2 / (float)num3;
	}

	public static void ObtainAchievement(int JMMILEFMACB)
	{
		if (GameManager.IsOwner())
		{
			string text = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB;
			bool pbAchieved = false;
			if (SteamUserStats.GetAchievement(text, out pbAchieved) && !pbAchieved)
			{
				SteamUserStats.SetAchievement(text);
				SteamUserStats.StoreStats();
			}
		}
	}

	public static void ObtainAchievementProgress(int JMMILEFMACB, int IADPPJHIMBG)
	{
		if (GameManager.IsOwner())
		{
			string pchName = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB;
			bool pbAchieved = false;
			if (SteamUserStats.GetAchievement(pchName, out pbAchieved) && !pbAchieved)
			{
				SteamUserStats.SetStat("achievements.id" + JMMILEFMACB + ".progress", IADPPJHIMBG);
				SteamUserStats.StoreStats();
			}
		}
	}

	public static int GetStat(string JMMILEFMACB)
	{
		int pData = 0;
		if (SteamUserStats.GetStat(JMMILEFMACB, out pData))
		{
			return pData;
		}
		return pData;
	}

	public static float GetStatFloat(string JMMILEFMACB)
	{
		float pData = 0f;
		if (SteamUserStats.GetStat(JMMILEFMACB, out pData))
		{
			return pData;
		}
		return pData;
	}

	public static void SetStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			SteamUserStats.SetStat(JMMILEFMACB, DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	public static void AddToStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			int stat = GetStat(JMMILEFMACB);
			SteamUserStats.SetStat(JMMILEFMACB, stat + DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	public static int GetIndex(Dictionary<string, FullMapData> BNBPKEFNIFI, string HFEFHOPOLIK)
	{
		for (int i = 0; i < BNBPKEFNIFI.Count; i++)
		{
			if (BNBPKEFNIFI.Skip(i).First().Key == HFEFHOPOLIK)
			{
				return i;
			}
		}
		return -1;
	}

	public static Color StringToColor(string KLOGENNCEPK)
	{
		string[] array = KLOGENNCEPK.Split(',');
		return new Color(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
	}

	public static string ColorToString(Color HABLFKCCKLN)
	{
		return string.Empty + HABLFKCCKLN.r + "," + HABLFKCCKLN.g + "," + HABLFKCCKLN.b;
	}

	public static string CalculateMD5(string DDAOMDPAIEP)
	{
		using (MD5 mD = MD5.Create())
		{
			using (FileStream inputStream = File.OpenRead(DDAOMDPAIEP))
			{
				byte[] array = mD.ComputeHash(inputStream);
				return BitConverter.ToString(array).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
	}

	public static string Md5Sum(string FPNPDIKFPEG)
	{
		if (!string.IsNullOrEmpty(FPNPDIKFPEG))
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			byte[] bytes = uTF8Encoding.GetBytes(FPNPDIKFPEG);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
			string text = string.Empty;
			for (int i = 0; i < array.Length; i++)
			{
				text += Convert.ToString(array[i], 16).PadLeft(2, '0');
			}
			return text.PadLeft(32, '0');
		}
		return null;
	}

	public static string GetDirectory(string NBEBMKFPBEP)
	{
		NBEBMKFPBEP = Application.dataPath + "/../" + NBEBMKFPBEP;
		return NBEBMKFPBEP;
	}

	public static void DirectoryCopy(string DLJFEBLOHAE, string JODLOJBNAEH, bool BHOINKKEABD)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(DLJFEBLOHAE);
		if (!directoryInfo.Exists)
		{
			throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + DLJFEBLOHAE);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (!Directory.Exists(JODLOJBNAEH))
		{
			Directory.CreateDirectory(JODLOJBNAEH);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			string destFileName = Path.Combine(JODLOJBNAEH, fileInfo.Name);
			fileInfo.CopyTo(destFileName, false);
		}
		if (BHOINKKEABD)
		{
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				string jODLOJBNAEH = Path.Combine(JODLOJBNAEH, directoryInfo2.Name);
				DirectoryCopy(directoryInfo2.FullName, jODLOJBNAEH, BHOINKKEABD);
			}
		}
	}

	public static Color ColorGradient(Color MGHJCGBNEPL, Color NBPMHDANECK, float DPNHODJHGJL)
	{
		Gradient gradient = new Gradient();
		GradientColorKey[] array = new GradientColorKey[2];
		array[0].color = NBPMHDANECK;
		array[0].time = 0f;
		array[1].color = MGHJCGBNEPL;
		array[1].time = 1f;
		GradientAlphaKey[] array2 = new GradientAlphaKey[2];
		array2[0].alpha = 1f;
		array2[0].time = 0f;
		array2[1].alpha = 1f;
		array2[1].time = 1f;
		gradient.SetKeys(array, array2);
		return gradient.Evaluate(DPNHODJHGJL);
	}

	public static void ClearDirectory(string LFLCJFDDFAG)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(LFLCJFDDFAG);
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			fileInfo.Delete();
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			ClearDirectory(directoryInfo2.FullName);
			directoryInfo2.Delete();
		}
	}

	public static void CheckDirectory(string BOGDHCDIMHN)
	{
		if (!Directory.Exists(BOGDHCDIMHN))
		{
			Directory.CreateDirectory(BOGDHCDIMHN);
		}
	}

	public static IEnumerator LoadAudio(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		resultAudio = null;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = GetDirectory(NBEBMKFPBEP);
		}
		WWW wWW = new WWW("file://" + NBEBMKFPBEP);
		yield return wWW;
		resultAudio = wWW.GetAudioClip(false);
		yield return resultAudio;
	}

	public static IEnumerator GetAudioLength(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		resultAudioLength = 0f;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = GetDirectory(NBEBMKFPBEP);
		}
		if (new FileInfo(NBEBMKFPBEP).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + NBEBMKFPBEP);
			yield return wWW;
			resultAudioLength = wWW.GetAudioClip(false, true).length;
			yield return resultAudioLength;
		}
		else
		{
			AudioFileReader audioFileReader = new AudioFileReader(NBEBMKFPBEP);
			resultAudioLength = (float)audioFileReader.TotalTime.TotalSeconds;
		}
	}

	public static IEnumerator LoadText(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		yield return true;
		if (!textResult.ContainsKey(key))
		{
			textResult.Add(key, value);
		}
		else
		{
			textResult[key] = value;
		}
	}

	public static string LoadTextString(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string text = HAEBGHHMEBH;
		string result = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			result = File.ReadAllText(fullName);
		}
		return result;
	}

	public static void LoadMapConfig(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(GameManager.Decrypt(fullName));
		}
		if (!textResult.ContainsKey(key))
		{
			textResult.Add(key, value);
		}
		else
		{
			textResult[key] = value;
		}
	}

	public static IEnumerator SaveFile(string HAEBGHHMEBH, string NOJGGCLPPAM, bool HIIOLMMOCPN = false)
	{
		if (!HIIOLMMOCPN)
		{
			HAEBGHHMEBH = GetDirectory(HAEBGHHMEBH);
		}
		if (File.Exists(HAEBGHHMEBH))
		{
			File.Delete(HAEBGHHMEBH);
		}
		File.WriteAllText(HAEBGHHMEBH, NOJGGCLPPAM);
		yield return null;
	}

	public static void SetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a);
	}

	public static Color GetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		Color result = new Color(0f, 0f, 0f, 0f);
		result.r = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r);
		result.g = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g);
		result.b = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b);
		result.a = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a);
		return result;
	}

	public static void DeleteColorKey(string EBEHBBDKDFJ)
	{
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".r");
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".g");
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".b");
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".a");
	}

	public static Texture2D FlipTexture(Texture2D LMHCHLAIMJH)
	{
		if (LMHCHLAIMJH != null)
		{
			Texture2D texture2D = new Texture2D(LMHCHLAIMJH.width, LMHCHLAIMJH.height);
			int width = LMHCHLAIMJH.width;
			int height = LMHCHLAIMJH.height;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					texture2D.SetPixel(i, height - j - 1, LMHCHLAIMJH.GetPixel(i, j));
				}
			}
			texture2D.Apply();
			return texture2D;
		}
		return new Texture2D(2, 2);
	}

	public static Texture2D GetSteamImageAsTexture2D(int JLGNPNGBLOA)
	{
		Texture2D texture2D = null;
		uint pnWidth;
		uint pnHeight;
		if (SteamUtils.GetImageSize(JLGNPNGBLOA, out pnWidth, out pnHeight))
		{
			byte[] array = new byte[pnWidth * pnHeight * 4];
			if (SteamUtils.GetImageRGBA(JLGNPNGBLOA, array, (int)(pnWidth * pnHeight * 4)))
			{
				texture2D = new Texture2D((int)pnWidth, (int)pnHeight, TextureFormat.RGBA32, false, false);
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
		}
		return FlipTexture(texture2D);
	}

	public static float[] GetWaveform(AudioClip LDJFFDCLEFG, int FEKLGMEFABB)
	{
		FEKLGMEFABB = LDJFFDCLEFG.frequency / FEKLGMEFABB;
		float[] array = new float[LDJFFDCLEFG.samples * LDJFFDCLEFG.channels];
		float[] array2 = new float[array.Length / (FEKLGMEFABB * LDJFFDCLEFG.channels)];
		LDJFFDCLEFG.GetData(array, 0);
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = 0f;
			for (int j = 0; j < FEKLGMEFABB; j++)
			{
				array2[i] += Mathf.Abs(array[i * LDJFFDCLEFG.channels * FEKLGMEFABB + j]);
			}
			array2[i] /= FEKLGMEFABB;
		}
		return array2;
	}

	public static Texture2D PaintWaveformSpectrum(float[] IPAAACMOHAB, int PBMAGEKDPLI, Color ONHIBAJJACC, Color NCFLAHLHKPI)
	{
		Texture2D texture2D = new Texture2D(IPAAACMOHAB.Length, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		for (int i = 0; i < IPAAACMOHAB.Length; i++)
		{
			for (int j = 0; (float)j <= (float)PBMAGEKDPLI / 2f; j++)
			{
				texture2D.SetPixel(i, j, NCFLAHLHKPI);
				texture2D.SetPixel(i, -j, NCFLAHLHKPI);
			}
		}
		for (int k = 0; k < IPAAACMOHAB.Length; k++)
		{
			for (int l = 0; (float)l <= IPAAACMOHAB[k] * (float)PBMAGEKDPLI / 2f; l++)
			{
				texture2D.SetPixel(k, PBMAGEKDPLI / 2 + l, ONHIBAJJACC);
				texture2D.SetPixel(k, PBMAGEKDPLI / 2 - l, ONHIBAJJACC);
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	public static float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	public static float NormalToDb(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 0f)) ? (-80f) : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	public static string GetRelativeDateTime(DateTime MJHMIFPOJEA)
	{
		string empty = string.Empty;
		TimeSpan timeSpan = DateTime.Now.Subtract(MJHMIFPOJEA);
		if (timeSpan <= TimeSpan.FromSeconds(60.0))
		{
			return $"{timeSpan.Seconds} seconds ago";
		}
		if (timeSpan <= TimeSpan.FromMinutes(60.0))
		{
			return (timeSpan.Minutes <= 1) ? "a minute ago" : $"{timeSpan.Minutes} minutes ago";
		}
		if (timeSpan <= TimeSpan.FromHours(24.0))
		{
			return (timeSpan.Hours <= 1) ? "an hour ago" : $"{timeSpan.Hours} hours ago";
		}
		if (timeSpan <= TimeSpan.FromDays(30.0))
		{
			return (timeSpan.Days <= 1) ? "yesterday" : $"{timeSpan.Days} days ago";
		}
		if (timeSpan <= TimeSpan.FromDays(365.0))
		{
			return (timeSpan.Days <= 30) ? "a month ago" : $"{timeSpan.Days / 30} months ago";
		}
		return (timeSpan.Days <= 365) ? "a year ago" : $"{timeSpan.Days / 365} years ago";
	}

	public static string RemoveSpecialCharacters(string DPNHODJHGJL, char[] MPOJANPJEHH)
	{
		return new string(DPNHODJHGJL.Except(MPOJANPJEHH).ToArray());
	}

	public static List<EditorEventFunctionInfo> GetAvailableEditorEvents(int NCCNGCFMNII)
	{
		return eventsMap.Where((EditorEventFunctionInfo IACGDFHKCAE) => IACGDFHKCAE.minConfigVersion <= NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= NCCNGCFMNII))).ToList();
	}

	public static string FormatTime(float HHGFDGOKNMD, bool BLCMJNECOGL = false)
	{
		int num = (int)Mathf.Abs(HHGFDGOKNMD / 60f);
		int num2 = (int)(HHGFDGOKNMD % 60f);
		string text = string.Empty + (HHGFDGOKNMD % 1f).ToString("0.000").Remove(0, 1);
		return num.ToString("00") + ":" + num2.ToString("00") + (BLCMJNECOGL ? text : string.Empty);
	}

	public static string ToReadableAgeString(this TimeSpan NMCHKFGKGFJ)
	{
		return $"{(double)NMCHKFGKGFJ.Days / 365.25:0}";
	}

	public static string ToReadableString(this TimeSpan NMCHKFGKGFJ)
	{
		string empty = string.Empty;
		empty = ((NMCHKFGKGFJ.Duration().Days > 1) ? string.Format("{0}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty)) : ((NMCHKFGKGFJ.Duration().Hours > 0) ? string.Format("{0}{1}{2}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Hours <= 0) ? string.Empty : string.Format("{0:0} hour{1}, ", NMCHKFGKGFJ.Hours, (NMCHKFGKGFJ.Hours != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty)) : ((NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Format("{0}", (NMCHKFGKGFJ.Duration().Seconds < 0) ? string.Empty : string.Format("{0:0} second{1}", NMCHKFGKGFJ.Seconds, (NMCHKFGKGFJ.Seconds != 1) ? "s" : string.Empty)) : string.Format("{0}", (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty)))));
		if (empty.EndsWith(", "))
		{
			empty = empty.Substring(0, empty.Length - 2);
		}
		if (string.IsNullOrEmpty(empty))
		{
			empty = "0 seconds";
		}
		return empty;
	}

	public static bool isChallengeUnlocked(string EKFAHHJOJHE)
	{
		if (string.IsNullOrEmpty(EKFAHHJOJHE))
		{
			return true;
		}
		bool result = true;
		foreach (string item in EKFAHHJOJHE.Replace(" ", string.Empty).Split(',').ToList())
		{
			if (Singleton<SaveSystem>.Instance.GetInt("challenges." + item + ".status") < 2)
			{
				result = false;
			}
		}
		return result;
	}

	[CompilerGenerated]
	private static bool LFJDIMOEADJ(char HBJIMONFKNL)
	{
		return HBJIMONFKNL == '-';
	}

	[CompilerGenerated]
	private static double PMBAHAIECAN(double LPGNCFKLMEH)
	{
		return 0.0 - LPGNCFKLMEH;
	}

	[CompilerGenerated]
	private static bool NDFPKEBFAGM(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SpawnObj";
	}
}
