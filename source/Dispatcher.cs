// Dispatcher
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class Dispatcher : Singleton<Dispatcher>
{
	[CompilerGenerated]
	private sealed class CJALPJDILJH
	{
		internal Action LHCIHJOHGEJ;

		internal bool GIPNPIABCOM;

		internal void FJDBPPKABJE()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void FCAGEDLBBHD()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void BKNHHGBPLGH()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void JDELIMPGFDJ()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void FFEGPHJKMFK()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void EKHOOPGPPGE()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void HBJFIOJFBHC()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void DKGPCPBNDPK()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void OFLDIMDDLHM()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void LHHFJBIAHCN()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void OLIGLEMPFOP()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void BMAOCLKPNNC()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void JKEDCEOCPJO()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void KGKMOLCPDIH()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void LNDGINDKPFA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void DNIMHEKGJHB()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void KFNBKFELFLH()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void LOEAMHGMMPK()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void BFEABMIFIEE()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void PIJAOCFAPKC()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void LJDLIIIPIIJ()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void EGKGJJGAPMN()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void DBFPGFHEGKA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void GBKBDKHPLKG()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void OFHCGKJFGDI()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void FHFECFLBHMA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void BDGDIDPDBHG()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void MEMPOPNAEDN()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void AGJKEBOPIOC()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void BJMAIJDIKCN()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void FHIJCPPECHA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void MGENGAEDACG()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void PBCAHKDLFPE()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void LLNDDFGPOPL()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void FDAIFOAGDLA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}

		internal void FIPCLHEKKCA()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void IGFOBPKFCDJ()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		}

		internal void AEINPAGJFME()
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		}
	}

	private static bool EEHBMEEHKBM;

	private static Thread CEIHDHEOFJE;

	private static object BMHFFLILJHN = new object();

	private static readonly Queue<Action> GACAEIAGHDK = new Queue<Action>();

	public static bool isMainThread => Thread.CurrentThread == CEIHDHEOFJE;

	[SpecialName]
	public static bool HEFMMMEHCBN()
	{
		return Thread.CurrentThread == CEIHDHEOFJE;
	}

	public static void HBPBILKHFFL(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("player.greenlifering");
			return;
		}
		if (HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void BPMKNOLLAMJ(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("/");
			return;
		}
		if (DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public new void EIFCCFBJKOO()
	{
		base.Awake();
		EEHBMEEHKBM = true;
	}

	[SpecialName]
	public static bool DIMMLNKANPD()
	{
		return Thread.CurrentThread == CEIHDHEOFJE;
	}

	public static void InvokeAsync(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		if (isMainThread)
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void DLEEDNEHHIK(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError(" not exist");
			return;
		}
		bool GIPNPIABCOM = false;
		NKLACLFGOJM(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	public static void OAOOGDBIHEG(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		bool GIPNPIABCOM = true;
		POMPIODNGFL(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	public new void HHJBBHEBJCJ()
	{
		base.Awake();
		EEHBMEEHKBM = true;
	}

	public new void PPCGJBIIFAO()
	{
		base.Awake();
		EEHBMEEHKBM = true;
	}

	public static void FCOFEKKCCMH(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("CameraFilterPack/3D_Computer");
			return;
		}
		if (HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void NKLACLFGOJM(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("HitInRelaxMusicToggle");
			return;
		}
		if (DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void Invoke(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		bool GIPNPIABCOM = false;
		InvokeAsync(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(5);
		}
	}

	public static void JMBEAJDDBAD(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("https://steamcommunity.com/sharedfiles/filedetails/?id=");
			return;
		}
		if (DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void ONIMJKEFHFA(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("VoteUpToggle");
			return;
		}
		bool GIPNPIABCOM = false;
		NKLACLFGOJM(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	public static void APCBFNEKBKD(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("System.Int32");
			return;
		}
		bool GIPNPIABCOM = false;
		POMPIODNGFL(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(1);
		}
	}

	public static void HCOCMDGGJOJ(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("ItemsStoreButton");
			return;
		}
		if (isMainThread)
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void JHODNDBLLFH(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("/theme");
			return;
		}
		bool GIPNPIABCOM = false;
		JPAIOEFLIFM(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	public static void NKMAIFNJMCE(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("0,7,true,0");
			return;
		}
		if (isMainThread)
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	private void CFIAKIJAILI()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 1)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	public static void EKMGLJOFIEI(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_ScreenResolution");
			return;
		}
		bool GIPNPIABCOM = false;
		HBPBILKHFFL(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	public static void ICCEOOEHNLE(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_PositionY");
			return;
		}
		bool GIPNPIABCOM = false;
		POMPIODNGFL(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(7);
		}
	}

	public new void Awake()
	{
		base.Awake();
		EEHBMEEHKBM = true;
	}

	public static void POMPIODNGFL(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_Value5");
			return;
		}
		if (DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	private void BMODOIJGIOO()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 1)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	private void BGFJOEPFOPM()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 0)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	public static void BHJADCPCCGH(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("Can not SetMasterClient(). Not in room or in offlineMode.");
			return;
		}
		bool GIPNPIABCOM = false;
		JMBEAJDDBAD(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	public static void CKMJFCANPCM(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_ScreenResolution");
			return;
		}
		bool GIPNPIABCOM = false;
		NKLACLFGOJM(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(5);
		}
	}

	public static void AMPAADDDPLF(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_NeutralTonemapperParams2");
			return;
		}
		bool GIPNPIABCOM = true;
		NKLACLFGOJM(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	private void FOMNCPKKCFN()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 1)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	private void JAAJECBCCFM()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 1)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	public static void KONCBGHMBCP(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("0.000");
			return;
		}
		bool GIPNPIABCOM = false;
		FCOFEKKCCMH(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = false;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(4);
		}
	}

	public static void FEBNEGOMFNL(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_Distortion");
			return;
		}
		bool GIPNPIABCOM = false;
		BPMKNOLLAMJ(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	private void ONMGIPAILOH()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 0)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	public new void AJIKPEIGACI()
	{
		base.Awake();
		EEHBMEEHKBM = false;
	}

	private void Update()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 0)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}

	public static void JPAIOEFLIFM(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("Case-Sensitive");
			return;
		}
		if (HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
			return;
		}
		lock (BMHFFLILJHN)
		{
			GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
		}
	}

	public static void IDGNACKDHEA(Action LHCIHJOHGEJ)
	{
		if (!EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		bool GIPNPIABCOM = true;
		FCOFEKKCCMH(delegate
		{
			LHCIHJOHGEJ();
			GIPNPIABCOM = true;
		});
		while (!GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	private void HLDFOJMHKNL()
	{
		lock (BMHFFLILJHN)
		{
			while (GACAEIAGHDK.Count > 1)
			{
				GACAEIAGHDK.Dequeue()();
			}
		}
	}
}
