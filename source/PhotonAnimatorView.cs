// PhotonAnimatorView
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Animator))]
[AddComponentMenu("Photon Networking/Photon Animator View")]
public class PhotonAnimatorView : MonoBehaviour, IPunObservable
{
	public enum ParameterType
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	public enum SynchronizeType
	{
		Disabled,
		Discrete,
		Continuous
	}

	[Serializable]
	public class SynchronizedParameter
	{
		public ParameterType Type;

		public SynchronizeType SynchronizeType;

		public string Name;
	}

	[Serializable]
	public class SynchronizedLayer
	{
		public SynchronizeType SynchronizeType;

		public int LayerIndex;
	}

	[CompilerGenerated]
	private sealed class GEJGKCEDKJF
	{
		internal int PKFOGBFGICJ;

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FJDBPPKABJE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KFNBKFELFLH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class KCINJFMOMBP
	{
		internal string EBEHBBDKDFJ;

		internal bool FDAIFOAGDLA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool INHOEMCLAAP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BEBAENEJFLD(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JBAJEMGOPDL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FMIHBNPKEEO(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FJDBPPKABJE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LNDGINDKPFA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EFAPFFFGOOA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PIJAOCFAPKC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEIFJLBBKBP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PKAPLCFHDOC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FHFECFLBHMA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FHIJCPPECHA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BJMAIJDIKCN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OMBHIBNMFNB(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BMAOCLKPNNC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LJDLIIIPIIJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EDGAPOPEIJF(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JBCHBMKPDAJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool MGENGAEDACG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	[CompilerGenerated]
	private sealed class EJEGDAFJHIM
	{
		internal int PKFOGBFGICJ;

		internal bool PIJAOCFAPKC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHIJCPPECHA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KFNBKFELFLH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FDAIFOAGDLA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FJDBPPKABJE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BMAOCLKPNNC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class NMHDILBGNEE
	{
		internal string EBEHBBDKDFJ;

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LNDGINDKPFA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	[CompilerGenerated]
	private sealed class OMKKJMMOLMJ
	{
		internal int PKFOGBFGICJ;

		internal bool JDELIMPGFDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LJDLIIIPIIJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BMAOCLKPNNC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHIJCPPECHA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MGENGAEDACG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PIJAOCFAPKC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHFECFLBHMA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FDAIFOAGDLA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KFNBKFELFLH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BJMAIJDIKCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FJDBPPKABJE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class NJGHCFAPGMB
	{
		internal string EBEHBBDKDFJ;

		internal bool LNDGINDKPFA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	private Animator PGKLKGGALMP;

	private PhotonStreamQueue GAMOKOLALHP;

	[SerializeField]
	[HideInInspector]
	private bool ShowLayerWeightsInspector = true;

	[SerializeField]
	[HideInInspector]
	private bool ShowParameterInspector = true;

	[HideInInspector]
	[SerializeField]
	private List<SynchronizedParameter> m_SynchronizeParameters = new List<SynchronizedParameter>();

	[SerializeField]
	[HideInInspector]
	private List<SynchronizedLayer> m_SynchronizeLayers = new List<SynchronizedLayer>();

	private Vector3 DNCIIEPNCPD;

	private float HOAEICIPNOF;

	private bool MENGIFKONIP = true;

	private PhotonView GDIAJCAHCEC;

	private List<string> JNMGDECFIMB = new List<string>();

	private void NKLIHNJCHOG()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.EGPGEMJNPFD() <= 1)
		{
			GAMOKOLALHP.KNNOEGLLDAN();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			CDPNDOMBEFA();
			CacheDiscreteTriggers();
		}
		else
		{
			JDIONMKAPGA();
		}
	}

	private void CDPNDOMBEFA()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)3)
			{
				GAMOKOLALHP.DDHLHOGOGNP(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.FIDPDKNOIFH(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-33):
					GAMOKOLALHP.ILHKKFBHAIC(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	public void MHAAMGJIMDB(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = false;
		}
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			m_SynchronizeLayers.Add(new SynchronizedLayer
			{
				LayerIndex = PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	public bool MFNDNGCIAFF(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) == -1;
	}

	private void IIFCIDDJHPM()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.EGPGEMJNPFD() <= 0)
		{
			GAMOKOLALHP.Reset();
		}
		else if (GDIAJCAHCEC.BGJKMGJBPFA())
		{
			DEOGPJBPEPP();
			OHHBFDOOOFH();
		}
		else
		{
			NOHDKANLKGD();
		}
	}

	public bool DODEDMFEKGM(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public SynchronizeType DGDDJHGKCCN(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	private void ICLOBEBBKHD(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = (byte[])HCIJEDFCNOP.ReceiveNext();
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			m_SynchronizeLayers[i].SynchronizeType = (SynchronizeType)array[i];
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			m_SynchronizeParameters[j].SynchronizeType = (SynchronizeType)array[m_SynchronizeLayers.Count + j];
		}
	}

	public void BNKBEEPOHMG(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = true;
		}
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			m_SynchronizeParameters.Add(new SynchronizedParameter
			{
				Name = EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	private void NOHDKANLKGD()
	{
		if (!GAMOKOLALHP.POPNINEGMHF())
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)7)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.IKEKLFCNONN());
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)3)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.IKEKLFCNONN());
					break;
				case ParameterType.Float:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.ReceiveNext());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.LHDLFDPJLEA());
					break;
				case (ParameterType)88:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.IKEKLFCNONN());
					break;
				}
			}
		}
	}

	private void CPALFOIHHAE(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = new byte[m_SynchronizeLayers.Count + m_SynchronizeParameters.Count];
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			array[i] = (byte)m_SynchronizeLayers[i].SynchronizeType;
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			array[m_SynchronizeLayers.Count + j] = (byte)m_SynchronizeParameters[j].SynchronizeType;
		}
		HCIJEDFCNOP.SendNext(array);
	}

	public SynchronizeType GetLayerSynchronizeType(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	public bool CELPIAIHAIO(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	public bool JGHBPPLDJPP(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public SynchronizeType PFEAKIPNMLO(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}

	private void NINPKPDJAME(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case ParameterType.Trigger:
					HCIJEDFCNOP.SendNext(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
	}

	public bool DNFINIMAEJA(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) == -1;
	}

	private void MODNODMLGBK(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.ReceiveNext());
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType != 0)
			{
				continue;
			}
			switch (synchronizedParameter.Type)
			{
			case ParameterType.Bool:
				if (!(HCIJEDFCNOP.AOKDKJCKNCI() is bool))
				{
					return;
				}
				PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.NLPFEFOCGBC());
				break;
			case ParameterType.Float:
				if (!(HCIJEDFCNOP.IDCPJJPFEJJ() is float))
				{
					return;
				}
				PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.IDKHBJIHKEB());
				break;
			case ParameterType.Int:
				if (!(HCIJEDFCNOP.AOKDKJCKNCI() is int))
				{
					return;
				}
				PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.FIBMOBNIALK());
				break;
			case (ParameterType)(-128):
				if (!(HCIJEDFCNOP.KDNNJPIKFIC() is bool))
				{
					return;
				}
				if ((bool)HCIJEDFCNOP.NLPFEFOCGBC())
				{
					PGKLKGGALMP.SetTrigger(synchronizedParameter.Name);
				}
				break;
			}
		}
	}

	private void Awake()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		GAMOKOLALHP = new PhotonStreamQueue(120);
		PGKLKGGALMP = GetComponent<Animator>();
	}

	public void MFJNOJKGGDK(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = false;
		}
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			m_SynchronizeLayers.Add(new SynchronizedLayer
			{
				LayerIndex = PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	public List<SynchronizedParameter> GetSynchronizedParameters()
	{
		return m_SynchronizeParameters;
	}

	private void NENDODGHIDJ()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Continuous)
			{
				GAMOKOLALHP.SendNext(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Continuous)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case ParameterType.Trigger:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	public void OHHBFDOOOFH()
	{
		for (int i = 1; i < m_SynchronizeParameters.Count; i++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete && synchronizedParameter.Type == (ParameterType)(-73) && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)(-93))
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	public void MCGGIDPEPAN(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = true;
		}
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			m_SynchronizeLayers.Add(new SynchronizedLayer
			{
				LayerIndex = PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	public bool DEGDKLFMCAP(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) == -1;
	}

	public void CacheDiscreteTriggers()
	{
		for (int i = 0; i < m_SynchronizeParameters.Count; i++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete && synchronizedParameter.Type == ParameterType.Trigger && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == ParameterType.Trigger)
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	private void DOCHFABJBJG(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.ReceiveNext());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType != SynchronizeType.Discrete)
			{
				continue;
			}
			switch (synchronizedParameter.Type)
			{
			case ParameterType.Bool:
				if (!(HCIJEDFCNOP.PeekNext() is bool))
				{
					return;
				}
				PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.ReceiveNext());
				break;
			case ParameterType.Float:
				if (!(HCIJEDFCNOP.PeekNext() is float))
				{
					return;
				}
				PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.ReceiveNext());
				break;
			case ParameterType.Int:
				if (!(HCIJEDFCNOP.PeekNext() is int))
				{
					return;
				}
				PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.ReceiveNext());
				break;
			case ParameterType.Trigger:
				if (!(HCIJEDFCNOP.PeekNext() is bool))
				{
					return;
				}
				if ((bool)HCIJEDFCNOP.ReceiveNext())
				{
					PGKLKGGALMP.SetTrigger(synchronizedParameter.Name);
				}
				break;
			}
		}
	}

	public List<SynchronizedParameter> GGDKJACBGGP()
	{
		return m_SynchronizeParameters;
	}

	public bool DoesLayerSynchronizeTypeExist(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	public void SetLayerSynchronized(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = true;
		}
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			m_SynchronizeLayers.Add(new SynchronizedLayer
			{
				LayerIndex = PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	public SynchronizeType EBDKNHAEFEI(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	private void JDIONMKAPGA()
	{
		if (!GAMOKOLALHP.FGIECEGOCGK())
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.IDKHBJIHKEB());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Int:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.IDKHBJIHKEB());
					break;
				case (ParameterType)0:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.IKEKLFCNONN());
					break;
				case (ParameterType)2:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.IKEKLFCNONN());
					break;
				case (ParameterType)(-16):
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.LHDLFDPJLEA());
					break;
				}
			}
		}
	}

	public bool DoesParameterSynchronizeTypeExist(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public SynchronizeType BAKMDMLOMPA(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Discrete;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	private void LCJHDLKJEOM()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.BGJKMGJBPFA() && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.DHOGHIOACME() <= 1)
		{
			GAMOKOLALHP.Reset();
		}
		else if (GDIAJCAHCEC.DOLKFPIABDD())
		{
			CDPNDOMBEFA();
			OHHBFDOOOFH();
		}
		else
		{
			JDIONMKAPGA();
		}
	}

	public bool JCLNMPFEIFK(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	public SynchronizeType KODBNLBNMBB(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}

	private void FLFBBNEIAAB()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)7)
			{
				GAMOKOLALHP.HPCOFADNBPA(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.FIDPDKNOIFH(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)45:
					GAMOKOLALHP.HPCOFADNBPA(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	private void MHOKCLFCMDH(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Int:
					HCIJEDFCNOP.CPIBABMPJLE(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case (ParameterType)0:
					HCIJEDFCNOP.CPIBABMPJLE(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case (ParameterType)2:
					HCIJEDFCNOP.PNAPNHJHBMN(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-22):
					HCIJEDFCNOP.OLACNHHHOEL(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
	}

	private void FAODPBIIFDF()
	{
		if (!GAMOKOLALHP.HasQueuedObjects())
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Continuous)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.ReceiveNext());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Continuous)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.ReceiveNext());
					break;
				case ParameterType.Float:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.ReceiveNext());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.ReceiveNext());
					break;
				case ParameterType.Trigger:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.ReceiveNext());
					break;
				}
			}
		}
	}

	public List<SynchronizedLayer> LKFLOHIMJMJ()
	{
		return m_SynchronizeLayers;
	}

	public List<SynchronizedParameter> NGDLFDKJEKH()
	{
		return m_SynchronizeParameters;
	}

	public void JEPABGBLOFE(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = true;
		}
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			m_SynchronizeParameters.Add(new SynchronizedParameter
			{
				Name = EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	private void DEOGPJBPEPP()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)3)
			{
				GAMOKOLALHP.MJLPEADKIMK(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Continuous)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.HPCOFADNBPA(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.MJLPEADKIMK(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-93):
					GAMOKOLALHP.DDHLHOGOGNP(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	public bool EGPEPEJDGCJ(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			if (MENGIFKONIP)
			{
				GAMOKOLALHP.Reset();
				CPALFOIHHAE(HCIJEDFCNOP);
				MENGIFKONIP = false;
			}
			GAMOKOLALHP.Serialize(HCIJEDFCNOP);
			NINPKPDJAME(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.PeekNext() is byte[])
			{
				ICLOBEBBKHD(HCIJEDFCNOP);
			}
			GAMOKOLALHP.Deserialize(HCIJEDFCNOP);
			DOCHFABJBJG(HCIJEDFCNOP);
		}
	}

	private void AJIKPEIGACI()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		GAMOKOLALHP = new PhotonStreamQueue(-5);
		PGKLKGGALMP = GetComponent<Animator>();
	}

	public void SetParameterSynchronized(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = true;
		}
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			m_SynchronizeParameters.Add(new SynchronizedParameter
			{
				Name = EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	private void DGANFOLNABB(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.FADAIFFMBEL(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					HCIJEDFCNOP.IBCLJIACBKG(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					HCIJEDFCNOP.PBECMJMDHBI(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					HCIJEDFCNOP.OLACNHHHOEL(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)99:
					HCIJEDFCNOP.IBCLJIACBKG(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
	}

	public List<SynchronizedLayer> GetSynchronizedLayers()
	{
		return m_SynchronizeLayers;
	}

	public void ACPDDODDGLE(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = false;
		}
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			m_SynchronizeLayers.Add(new SynchronizedLayer
			{
				LayerIndex = PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	private void Update()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = false;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			GAMOKOLALHP.Reset();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			NENDODGHIDJ();
			CacheDiscreteTriggers();
		}
		else
		{
			FAODPBIIFDF();
		}
	}

	public SynchronizeType GetParameterSynchronizeType(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}
}
