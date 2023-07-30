// PhotonAnimatorView
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon Animator View")]
[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Animator))]
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

		internal bool JBAJEMGOPDL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LJDLIIIPIIJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEIFJLBBKBP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHIJCPPECHA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FJDBPPKABJE(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool BMAOCLKPNNC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BJMAIJDIKCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EFAPFFFGOOA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MGENGAEDACG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PIJAOCFAPKC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FDAIFOAGDLA(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool INHOEMCLAAP(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool FHFECFLBHMA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class KCINJFMOMBP
	{
		internal string EBEHBBDKDFJ;

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
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

		internal bool PIJAOCFAPKC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
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

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
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

		internal bool BMAOCLKPNNC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	[CompilerGenerated]
	private sealed class EJEGDAFJHIM
	{
		internal int PKFOGBFGICJ;

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JBAJEMGOPDL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEIFJLBBKBP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FDAIFOAGDLA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LJDLIIIPIIJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MGENGAEDACG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PIJAOCFAPKC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHFECFLBHMA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EFAPFFFGOOA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KFNBKFELFLH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FMIHBNPKEEO(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool INHOEMCLAAP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHIJCPPECHA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BEBAENEJFLD(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PKAPLCFHDOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FJDBPPKABJE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BJMAIJDIKCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class NMHDILBGNEE
	{
		internal string EBEHBBDKDFJ;

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FJDBPPKABJE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FHIJCPPECHA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BMAOCLKPNNC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LNDGINDKPFA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FCAGEDLBBHD(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PIJAOCFAPKC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool HBJFIOJFBHC(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	[CompilerGenerated]
	private sealed class OMKKJMMOLMJ
	{
		internal int PKFOGBFGICJ;

		internal bool AEIFJLBBKBP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MGENGAEDACG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHIJCPPECHA(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool GBKBDKHPLKG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool BKNHHGBPLGH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LHHFJBIAHCN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DBFPGFHEGKA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JBAJEMGOPDL(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KGKMOLCPDIH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EFAPFFFGOOA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AGJKEBOPIOC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EGKGJJGAPMN(SynchronizedLayer DBIMJHMKHNK)
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

		internal bool LNDGINDKPFA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FDAIFOAGDLA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DNIMHEKGJHB(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BFEABMIFIEE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool JDELIMPGFDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FHFECFLBHMA(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool INHOEMCLAAP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool AEINPAGJFME(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BMAOCLKPNNC(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool MEMPOPNAEDN(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OFLDIMDDLHM(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool OLIGLEMPFOP(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool KFNBKFELFLH(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool IGFOBPKFCDJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LJDLIIIPIIJ(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ;
		}
	}

	[CompilerGenerated]
	private sealed class NJGHCFAPGMB
	{
		internal string EBEHBBDKDFJ;

		internal bool LHHFJBIAHCN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool KFNBKFELFLH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FIPCLHEKKCA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool DKGPCPBNDPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool JKEDCEOCPJO(SynchronizedParameter DBIMJHMKHNK)
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

		internal bool MEMPOPNAEDN(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool PBCAHKDLFPE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool EKHOOPGPPGE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool GBKBDKHPLKG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BDGDIDPDBHG(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool FFEGPHJKMFK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BFEABMIFIEE(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool BKNHHGBPLGH(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LNDGINDKPFA(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool AEINPAGJFME(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LOEAMHGMMPK(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool OFHCGKJFGDI(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}

		internal bool LLNDDFGPOPL(SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == EBEHBBDKDFJ;
		}
	}

	private Animator PGKLKGGALMP;

	private PhotonStreamQueue GAMOKOLALHP;

	[SerializeField]
	[HideInInspector]
	private bool ShowLayerWeightsInspector = true;

	[HideInInspector]
	[SerializeField]
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

	public SynchronizeType JHBNMPGMPHO(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	public void BFJKMCADPFP()
	{
		for (int i = 0; i < m_SynchronizeParameters.Count; i += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete && synchronizedParameter.Type == (ParameterType)(-25) && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)38)
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	public bool AAPBGPFJPMM(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	private void ANDLMFGBPJB(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = (byte[])HCIJEDFCNOP.NLPFEFOCGBC();
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			m_SynchronizeLayers[i].SynchronizeType = (SynchronizeType)array[i];
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			m_SynchronizeParameters[j].SynchronizeType = (SynchronizeType)array[m_SynchronizeLayers.Count + j];
		}
	}

	public void IDBJJLDKOCH(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
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

	private void ENILNGHFMPH()
	{
		if (!GAMOKOLALHP.KPGEHIHAFPB())
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Disabled)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.GHKNEDAGFJH());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)8)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.NNKHCIOPHKO());
					break;
				case ParameterType.Float:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.BFEKAOHHEGP());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.MOIJMGCGGJA());
					break;
				case (ParameterType)103:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.JOJDLHCIGOJ());
					break;
				}
			}
		}
	}

	public List<SynchronizedParameter> GetSynchronizedParameters()
	{
		return m_SynchronizeParameters;
	}

	public SynchronizeType CDLKBCFMALF(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Discrete;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	private void FGDJMHEMDMM()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Continuous)
			{
				GAMOKOLALHP.MOBKENKFHBH(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)5)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.FPNAGFEAGPA(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.CECDMBBNNKF(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-90):
					GAMOKOLALHP.GNKDMNIMKGK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
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

	private void PFDDEODEHBD(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = new byte[m_SynchronizeLayers.Count + m_SynchronizeParameters.Count];
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			array[i] = (byte)m_SynchronizeLayers[i].SynchronizeType;
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			array[m_SynchronizeLayers.Count + j] = (byte)m_SynchronizeParameters[j].SynchronizeType;
		}
		HCIJEDFCNOP.GJDCOKMGHOG(array);
	}

	public bool JEDLHIBJIHD(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public void PILFLCLKJNH(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
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

	public bool FBILAIFGFLH(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public bool DoesLayerSynchronizeTypeExist(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	public void ONLPHJBMNJF(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = false;
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

	public List<SynchronizedParameter> CAKLCLLNOBD()
	{
		return m_SynchronizeParameters;
	}

	public void AHHBDAPBMEJ(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
	{
		if (Application.isPlaying)
		{
			MENGIFKONIP = false;
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

	private void Awake()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		GAMOKOLALHP = new PhotonStreamQueue(120);
		PGKLKGGALMP = GetComponent<Animator>();
	}

	private void IKPIBGIGHPH()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)4)
			{
				GAMOKOLALHP.DCOAKHENFCD(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)3)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.JOJFHILEPIK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.LAFCNDDOLPL(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)126:
					GAMOKOLALHP.ENCBBMBIHMK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	public List<SynchronizedParameter> FALKNECPJCL()
	{
		return m_SynchronizeParameters;
	}

	private void AFHBAKMMALF(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.ReceiveNext());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType != 0)
			{
				continue;
			}
			switch (synchronizedParameter.Type)
			{
			case ParameterType.Bool:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is bool))
				{
					return;
				}
				PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.MABPFPFGCNL());
				break;
			case ParameterType.Float:
				if (!(HCIJEDFCNOP.PeekNext() is float))
				{
					return;
				}
				PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.MABPFPFGCNL());
				break;
			case ParameterType.Int:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is int))
				{
					return;
				}
				PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.EDCDHDJNDPF());
				break;
			case (ParameterType)(-114):
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

	public void CEJJMBGHADN(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
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

	private void FJHFOBHJEHL()
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
			GKHDICFCBIE();
			ODFOJDEJENL();
		}
		else
		{
			FAODPBIIFDF();
		}
	}

	private void MBOJONCLAJK(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = (byte[])HCIJEDFCNOP.MABPFPFGCNL();
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			m_SynchronizeLayers[i].SynchronizeType = (SynchronizeType)array[i];
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			m_SynchronizeParameters[j].SynchronizeType = (SynchronizeType)array[m_SynchronizeLayers.Count + j];
		}
	}

	private void EDMCLKKDKIC()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)7)
			{
				GAMOKOLALHP.FPNAGFEAGPA(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)6)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.MOBKENKFHBH(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.JOJFHILEPIK(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.BEJMEHHBLJN(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)60:
					GAMOKOLALHP.ENCBBMBIHMK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	private void GLLOMDBMIJM()
	{
		if (!GAMOKOLALHP.BKGEFIHNDOI())
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)7)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.PKCMMBAGPBH());
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j += 0)
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
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.DJAJOANLHFP());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.KIMDMBDNICC());
					break;
				case (ParameterType)56:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.BFEKAOHHEGP());
					break;
				}
			}
		}
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

	public bool ALACEKDFEEJ(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	private void NDAJBJFJGCF()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 0)
		{
			GAMOKOLALHP.OGAMGLEAOAF();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			FJLDIAOFDDD();
			BOJDGGEONKJ();
		}
		else
		{
			LMACPAIKGJK();
		}
	}

	public SynchronizeType BKLGGEOJKHE(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}

	private void KIEJKBNBHMD()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			GAMOKOLALHP.Reset();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			EDMCLKKDKIC();
			ODFOJDEJENL();
		}
		else
		{
			ENILNGHFMPH();
		}
	}

	private void IFKJLHDLGFK()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)5)
			{
				GAMOKOLALHP.CECDMBBNNKF(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
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
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.MOBKENKFHBH(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.JFBKLHIPLMF(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)37:
					GAMOKOLALHP.JFBKLHIPLMF(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
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

	public void BOJDGGEONKJ()
	{
		for (int i = 1; i < m_SynchronizeParameters.Count; i++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete && synchronizedParameter.Type == (ParameterType)43 && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)76)
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	public void KPFDHEHMBIM()
	{
		for (int i = 1; i < m_SynchronizeParameters.Count; i++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled && synchronizedParameter.Type == (ParameterType)(-108) && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)(-97))
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	public List<SynchronizedParameter> BNDEKLOKCEB()
	{
		return m_SynchronizeParameters;
	}

	public SynchronizeType OHLEBLLLEGE(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Discrete;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
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

	public List<SynchronizedLayer> LNGMOOIPNHC()
	{
		return m_SynchronizeLayers;
	}

	public List<SynchronizedLayer> ONAHHFFKFNE()
	{
		return m_SynchronizeLayers;
	}

	private void OEENOOGEEHD()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			GAMOKOLALHP.CKCPHFLOLAH();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			NENDODGHIDJ();
			ODFOJDEJENL();
		}
		else
		{
			FAODPBIIFDF();
		}
	}

	public SynchronizeType IHLPNOLINCB(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Discrete;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}

	public void ODFOJDEJENL()
	{
		for (int i = 0; i < m_SynchronizeParameters.Count; i += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Disabled && synchronizedParameter.Type == (ParameterType)(-29) && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)(-64))
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	private void DOMBAFGKNAK(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Disabled)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Int:
					HCIJEDFCNOP.AIAIEPFCCDO(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case (ParameterType)0:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case (ParameterType)2:
					HCIJEDFCNOP.GJDCOKMGHOG(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-114):
					HCIJEDFCNOP.GJDCOKMGHOG(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
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

	private void FJLDIAOFDDD()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)8)
			{
				GAMOKOLALHP.JFBKLHIPLMF(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.ENCBBMBIHMK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.JOJFHILEPIK(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.JFBKLHIPLMF(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-17):
					GAMOKOLALHP.AIAIEPFCCDO(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	private void HDDECCMEJKA()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = false;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			GAMOKOLALHP.GGALLPMKOJI();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			FJLDIAOFDDD();
			CacheDiscreteTriggers();
		}
		else
		{
			LMACPAIKGJK();
		}
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

	public List<SynchronizedLayer> ONIIKNGDCJI()
	{
		return m_SynchronizeLayers;
	}

	private void FOMNCPKKCFN()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = false;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 0)
		{
			GAMOKOLALHP.JOPOMLLAMKE();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			FJLDIAOFDDD();
			IDEJGMIJINM();
		}
		else
		{
			FAODPBIIFDF();
		}
	}

	public bool MCHPOELNPJI(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	private void IDJMHDDGGAM(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = new byte[m_SynchronizeLayers.Count + m_SynchronizeParameters.Count];
		for (int i = 1; i < m_SynchronizeLayers.Count; i++)
		{
			array[i] = (byte)m_SynchronizeLayers[i].SynchronizeType;
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			array[m_SynchronizeLayers.Count + j] = (byte)m_SynchronizeParameters[j].SynchronizeType;
		}
		HCIJEDFCNOP.SendNext(array);
	}

	private void GKHDICFCBIE()
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)5)
			{
				GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)6)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case ParameterType.Float:
					GAMOKOLALHP.SendNext(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case ParameterType.Int:
					GAMOKOLALHP.DGJOBJMAJNJ(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-44):
					GAMOKOLALHP.JOJFHILEPIK(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	private void LMACPAIKGJK()
	{
		if (!GAMOKOLALHP.FMJBMNEKCEH())
		{
			return;
		}
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)5)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.BFEKAOHHEGP());
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (SynchronizeType)4)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.ReceiveNext());
					break;
				case ParameterType.Float:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.DFBDAGMPCJL());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.DFBDAGMPCJL());
					break;
				case (ParameterType)(-85):
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.MOIJMGCGGJA());
					break;
				}
			}
		}
	}

	public SynchronizeType DJPGHOPBIKE(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Discrete;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
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

	private void JHEKMMEBEEM(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i++)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Disabled)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.NLPFEFOCGBC());
			}
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType != 0)
			{
				continue;
			}
			switch (synchronizedParameter.Type)
			{
			case ParameterType.Int:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is bool))
				{
					return;
				}
				PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.MABPFPFGCNL());
				break;
			case (ParameterType)0:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is float))
				{
					return;
				}
				PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.ReceiveNext());
				break;
			case (ParameterType)2:
				if (!(HCIJEDFCNOP.PeekNext() is int))
				{
					return;
				}
				PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.MABPFPFGCNL());
				break;
			case (ParameterType)7:
				if (!(HCIJEDFCNOP.PeekNext() is bool))
				{
					return;
				}
				if ((bool)HCIJEDFCNOP.MABPFPFGCNL())
				{
					PGKLKGGALMP.SetTrigger(synchronizedParameter.Name);
				}
				break;
			}
		}
	}

	public bool FPPMIMICLCE(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) == -1;
	}

	public void IDEJGMIJINM()
	{
		for (int i = 1; i < m_SynchronizeParameters.Count; i++)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete && synchronizedParameter.Type == (ParameterType)(-81) && PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (ParameterType)22)
			{
				JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	public SynchronizeType JKHLNHBCFMH(int PKFOGBFGICJ)
	{
		int num = m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeLayers[num].SynchronizeType;
	}

	private void KFBDOHNCHHC(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.NICKMDDINKP(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
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
					HCIJEDFCNOP.NICKMDDINKP(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case (ParameterType)0:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case (ParameterType)2:
					HCIJEDFCNOP.SendNext(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)(-24):
					HCIJEDFCNOP.GJDCOKMGHOG(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
	}

	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			if (MENGIFKONIP)
			{
				GAMOKOLALHP.GGALLPMKOJI();
				IDJMHDDGGAM(HCIJEDFCNOP);
				MENGIFKONIP = false;
			}
			GAMOKOLALHP.IKIJABBBOKA(HCIJEDFCNOP);
			DOMBAFGKNAK(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.PeekNext() is byte[])
			{
				ICLOBEBBKHD(HCIJEDFCNOP);
			}
			GAMOKOLALHP.ECMLBANFIJF(HCIJEDFCNOP);
			DOCHFABJBJG(HCIJEDFCNOP);
		}
	}

	public void HIDJLJIEPHK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			if (MENGIFKONIP)
			{
				GAMOKOLALHP.LECPHJOIGKN();
				IDJMHDDGGAM(HCIJEDFCNOP);
				MENGIFKONIP = false;
			}
			GAMOKOLALHP.NKMPCNJPFNE(HCIJEDFCNOP);
			DOMBAFGKNAK(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.AHDBELMMFCN() is byte[])
			{
				ICLOBEBBKHD(HCIJEDFCNOP);
			}
			GAMOKOLALHP.NHJAFICCEGA(HCIJEDFCNOP);
			AFHBAKMMALF(HCIJEDFCNOP);
		}
	}

	public List<SynchronizedLayer> GetSynchronizedLayers()
	{
		return m_SynchronizeLayers;
	}

	public void NBBIBGABOBD(int PKFOGBFGICJ, SynchronizeType JBLLFKFMPNO)
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

	private void NOGBAEKPOMH(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = (byte[])HCIJEDFCNOP.MABPFPFGCNL();
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			m_SynchronizeLayers[i].SynchronizeType = (SynchronizeType)array[i];
		}
		for (int j = 0; j < m_SynchronizeParameters.Count; j += 0)
		{
			m_SynchronizeParameters[j].SynchronizeType = (SynchronizeType)array[m_SynchronizeLayers.Count + j];
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

	private void KMEONPMCNJG()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = false;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			GAMOKOLALHP.JOPOMLLAMKE();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			IKPIBGIGHPH();
			BOJDGGEONKJ();
		}
		else
		{
			FAODPBIIFDF();
		}
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

	private void KCDOMIJBFLL()
	{
		if (PGKLKGGALMP.applyRootMotion && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 0)
		{
			GAMOKOLALHP.Reset();
		}
		else if (GDIAJCAHCEC.isMine)
		{
			FGDJMHEMDMM();
			KPFDHEHMBIM();
		}
		else
		{
			GLLOMDBMIJM();
		}
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

	private void CEEPNIJALJI(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Disabled)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.NLPFEFOCGBC());
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
				if (!(HCIJEDFCNOP.PeekNext() is bool))
				{
					return;
				}
				PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.ReceiveNext());
				break;
			case ParameterType.Float:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is float))
				{
					return;
				}
				PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.MABPFPFGCNL());
				break;
			case ParameterType.Int:
				if (!(HCIJEDFCNOP.AHDBELMMFCN() is int))
				{
					return;
				}
				PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.EDCDHDJNDPF());
				break;
			case (ParameterType)(-3):
				if (!(HCIJEDFCNOP.PeekNext() is bool))
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

	public SynchronizeType GetParameterSynchronizeType(string EBEHBBDKDFJ)
	{
		int num = m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ);
		if (num == -1)
		{
			return SynchronizeType.Disabled;
		}
		return m_SynchronizeParameters[num].SynchronizeType;
	}

	public bool FPKBAJODGHN(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	public void MPGJDLCANPA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (MENGIFKONIP)
			{
				GAMOKOLALHP.CKCPHFLOLAH();
				CPALFOIHHAE(HCIJEDFCNOP);
				MENGIFKONIP = true;
			}
			GAMOKOLALHP.NKMPCNJPFNE(HCIJEDFCNOP);
			NINPKPDJAME(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.AHDBELMMFCN() is byte[])
			{
				NOGBAEKPOMH(HCIJEDFCNOP);
			}
			GAMOKOLALHP.ECMLBANFIJF(HCIJEDFCNOP);
			DOCHFABJBJG(HCIJEDFCNOP);
		}
	}

	public void AKLFJKAINHF(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
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

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			if (MENGIFKONIP)
			{
				GAMOKOLALHP.NNNCKCELBCE();
				CPALFOIHHAE(HCIJEDFCNOP);
				MENGIFKONIP = false;
			}
			GAMOKOLALHP.IKIJABBBOKA(HCIJEDFCNOP);
			NINPKPDJAME(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.AHDBELMMFCN() is byte[])
			{
				ANDLMFGBPJB(HCIJEDFCNOP);
			}
			GAMOKOLALHP.ECMLBANFIJF(HCIJEDFCNOP);
			CEEPNIJALJI(HCIJEDFCNOP);
		}
	}

	private void JKNCHEEJCML(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(PGKLKGGALMP.GetLayerWeight(m_SynchronizeLayers[i].LayerIndex));
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
					HCIJEDFCNOP.GJDCOKMGHOG(PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				case (ParameterType)0:
					HCIJEDFCNOP.NICKMDDINKP(PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				case (ParameterType)2:
					HCIJEDFCNOP.GJDCOKMGHOG(PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case (ParameterType)100:
					HCIJEDFCNOP.NICKMDDINKP(JNMGDECFIMB.Contains(synchronizedParameter.Name));
					break;
				}
			}
		}
		JNMGDECFIMB.Clear();
	}

	public bool OKMNOFAKEHC(int PKFOGBFGICJ)
	{
		return m_SynchronizeLayers.FindIndex((SynchronizedLayer DBIMJHMKHNK) => DBIMJHMKHNK.LayerIndex == PKFOGBFGICJ) != -1;
	}

	public bool DoesParameterSynchronizeTypeExist(string EBEHBBDKDFJ)
	{
		return m_SynchronizeParameters.FindIndex((SynchronizedParameter DBIMJHMKHNK) => DBIMJHMKHNK.Name == EBEHBBDKDFJ) != -1;
	}

	private void HDKOOFPGGAB()
	{
		if (!GAMOKOLALHP.LELHINBMPOP())
		{
			return;
		}
		for (int i = 1; i < m_SynchronizeLayers.Count; i += 0)
		{
			if (m_SynchronizeLayers[i].SynchronizeType == (SynchronizeType)8)
			{
				PGKLKGGALMP.SetLayerWeight(m_SynchronizeLayers[i].LayerIndex, (float)GAMOKOLALHP.BFEKAOHHEGP());
			}
		}
		for (int j = 1; j < m_SynchronizeParameters.Count; j += 0)
		{
			SynchronizedParameter synchronizedParameter = m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == SynchronizeType.Discrete)
			{
				switch (synchronizedParameter.Type)
				{
				case ParameterType.Bool:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.MOIJMGCGGJA());
					break;
				case ParameterType.Float:
					PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)GAMOKOLALHP.DJAJOANLHFP());
					break;
				case ParameterType.Int:
					PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)GAMOKOLALHP.JOJDLHCIGOJ());
					break;
				case (ParameterType)59:
					PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)GAMOKOLALHP.JOJDLHCIGOJ());
					break;
				}
			}
		}
	}

	private void BFFHPJMMGHD()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		GAMOKOLALHP = new PhotonStreamQueue(62);
		PGKLKGGALMP = GetComponent<Animator>();
	}

	public List<SynchronizedLayer> CLMLNCGNADA()
	{
		return m_SynchronizeLayers;
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

	public void BAOLNBEACMG(string EBEHBBDKDFJ, ParameterType HMGBJCGOLMI, SynchronizeType JBLLFKFMPNO)
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
}
