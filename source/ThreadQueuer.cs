// ThreadQueuer
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThreadQueuer : Singleton<ThreadQueuer>
{
	[Serializable]
	public class ThreadActionData
	{
		public Action taskToRun;

		public bool isRunningTask;

		public bool isWaiting;

		public bool closeThread;
	}

	private readonly Queue<Action> ONGBEPGNDIB = new Queue<Action>();

	private readonly Queue<Action> PDAIJPGCAKN = new Queue<Action>();

	private Thread[] EDHJNNOKIAI;

	[SerializeField]
	private ThreadActionData[] threadsActionData;

	private readonly object FMCHBCDBJNB = new object();

	public int numThreads = 8;

	[SerializeField]
	private int activeThreads;

	[SerializeField]
	private int waitingCoActions;

	private void IKGGGGLLMJI(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = GLPNIMIGCFG();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action BLIPNCCMMAG()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void DGLNCOHLPEJ(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public Action BECHLBCAMOJ()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void LBIOIEANMGI()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			TriggerAvailableThreads();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void CCBOHOEMHKO()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		BIOAAGJMEOL();
	}

	public void EPDMHOBNLIK(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void IKKPINNOOLG()
	{
		base.Awake();
		InitThreads();
	}

	public void DLCIJPAELPN(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void CHHFMFFBHFJ(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void ICDLKHFICBG()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(FMHOBECHBGE);
			EDHJNNOKIAI[i].Start(i);
		}
		DHEBLGLIFEM();
	}

	public void BANHFNDEPPO()
	{
		base.Awake();
		PPKPLGKBEJA();
	}

	public Action NFGAAPJCPCL()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void BNFCMLJAHGF()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(HKMCGGDPCIA);
			EDHJNNOKIAI[i].Start(i);
		}
		DHGGNAJPAFG();
	}

	public void NBCDJOLGECA()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		NOOEIGANPHI();
	}

	private void IBCFPLMJIBE(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = KEDNLOIEDIP();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action MJKMEHBOAJJ()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void CMCANPJNNHB(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = GetNewCoAction();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action GLPNIMIGCFG()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void KEGNPKFMPDG()
	{
		base.Awake();
		KFALKPFBGCM();
	}

	public void PKGGPBABEPK()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(EDKODDLCMCC);
			EDHJNNOKIAI[i].Start(i);
		}
		NEHCNHIOLED();
	}

	public new void Awake()
	{
		base.Awake();
		InitThreads();
	}

	public void CKNAPIAFBGH(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void MMCIBFACHLD()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = true;
		}
		TriggerAvailableThreads();
	}

	public void DBHCPJCENFO()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = false;
		}
		FFLPNJGCLOJ();
	}

	public Action COEDLJAPFLH()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void CMIBEOJGAIL()
	{
		JGJKJNNEEII();
	}

	public Action PJPFJBCPFPI()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public Action DJNIBGNEBNN()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void OJBFBLHIEBB()
	{
		base.Awake();
		InitThreads();
	}

	private void NDDNJNCINDA()
	{
		NBCDJOLGECA();
	}

	public void CGANGMGJCAP()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(CMCANPJNNHB);
			EDHJNNOKIAI[i].Start(i);
		}
		NOOEIGANPHI();
	}

	public void JGJKJNNEEII()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		BIOAAGJMEOL();
	}

	public void GOKBAGMKEDB()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(HKMCGGDPCIA);
			EDHJNNOKIAI[i].Start(i);
		}
		FFLPNJGCLOJ();
	}

	private void NCPAFCKGJEA()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			JKMBNDHLEEC();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void CLMMKBJMMOL()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				PIICIBKPIBE(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void DMOHEDGOKJO(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = BECHLBCAMOJ();
					threadsActionData[num].isRunningTask = false;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action KEDNLOIEDIP()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void PPKPLGKBEJA()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(EDKODDLCMCC);
			EDHJNNOKIAI[i].Start(i);
		}
		FFLPNJGCLOJ();
	}

	public void BDBIBNGCHFJ()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				INALBEABNLE(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void BIOAAGJMEOL()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				QueueActionOnMainThread(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public Action CMONLKCBDLB()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void NEHCNHIOLED()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				JFJMIIAIEMM(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void HMNLHMLILKD()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			TriggerAvailableThreads();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void DGHLEBKPFLL(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void IHHNCCOGLPN()
	{
		AELCLCONJPE();
	}

	private void ABEIEGDHBNO()
	{
		KGDEDHDDDPC();
	}

	public void LKIOAELAOPA()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = false;
		}
		AMEPMGHIKBD();
	}

	private void EKCKJLFFAID()
	{
		CloseThreads();
	}

	public void NOOEIGANPHI()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				CLBDNDEFPBJ(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void JKMBNDHLEEC()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				DLCIJPAELPN(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void BLEIGOJBMBH(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void JDHFFBPNLBN()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(EDKODDLCMCC);
			EDHJNNOKIAI[i].Start(i);
		}
		FFLPNJGCLOJ();
	}

	public void KPDBFHDEALL(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void JFJMIIAIEMM(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void HKMCGGDPCIA(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = GetNewCoAction();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public void HAPOHIDEJPF(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void QueueActionOnMainThread(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void LCDJFJIBADI()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			FFLPNJGCLOJ();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void InitThreads()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(CMCANPJNNHB);
			EDHJNNOKIAI[i].Start(i);
		}
		TriggerAvailableThreads();
	}

	private void IFLINFFBOKK(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = PJPFJBCPFPI();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public void DOEIBJJNOGC(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void JCDEMKMHEPH(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void OLDPNEFMHFN()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = true;
		}
		AMEPMGHIKBD();
	}

	public void MNDGCOECDDM()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(IFLINFFBOKK);
			EDHJNNOKIAI[i].Start(i);
		}
		CLMMKBJMMOL();
	}

	private void ICPCNJMINPA(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = KEDNLOIEDIP();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public void INALBEABNLE(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void LCJHDLKJEOM()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			CLMMKBJMMOL();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public Action EAKAMNKPOEC()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void DHEBLGLIFEM()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				PIICIBKPIBE(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public Action HBPOLHBHEGG()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void NKLIHNJCHOG()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			FFLPNJGCLOJ();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	private void FJHFOBHJEHL()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			NOOEIGANPHI();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void CJEDMGCKHBI()
	{
		base.Awake();
		PPKPLGKBEJA();
	}

	public void JGOFMNNEDJP(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void GLALDPKMEDN()
	{
		base.Awake();
		PKGGPBABEPK();
	}

	public void OHLCGBFGOOD()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				BLEIGOJBMBH(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void TriggerAvailableThreads()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				QueueActionOnMainThread(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void GPHPJIDGEPI()
	{
		NFADCBPIBPG();
	}

	public void PLFBDNHBPJO(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public Action GetNewCoAction()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void JMBFPNPJODF()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		OHLCGBFGOOD();
	}

	public void KPOIJEKDFBE()
	{
		base.Awake();
		DFOGFAAJIAC();
	}

	private void EAGLJEODPMI(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = EAKAMNKPOEC();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action HDMICKFMLIM()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void AELCLCONJPE()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = false;
		}
		OHLCGBFGOOD();
	}

	public void LIGELBNKDAE(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void PHHOMLJECOJ()
	{
		base.Awake();
		PPKPLGKBEJA();
	}

	public void HGJDLMBENFL()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(DMOHEDGOKJO);
			EDHJNNOKIAI[i].Start(i);
		}
		DHGGNAJPAFG();
	}

	public void OMLBDMCOPCM(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void JMJLKJCLNBH(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void OJACCGOHBGH()
	{
		base.Awake();
		KFALKPFBGCM();
	}

	public void PIICIBKPIBE(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void LCCCJKEFFAJ(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = HBPOLHBHEGG();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public Action PBFPDAJKCHP()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void KPBNAPNLNPN(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void OnDisable()
	{
		CloseThreads();
	}

	public void CHKDKKDFCNB()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = false;
		}
		TriggerAvailableThreads();
	}

	private void EDKODDLCMCC(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads++;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = NFGAAPJCPCL();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = false;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public void LABCAPNDGKN(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void DFOGFAAJIAC()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(IFLINFFBOKK);
			EDHJNNOKIAI[i].Start(i);
		}
		NEHCNHIOLED();
	}

	public void AALONHDMCKO()
	{
		base.Awake();
		MNDGCOECDDM();
	}

	public void JGFIAPPGEBM(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public new void MFAMHKBMBEI()
	{
		base.Awake();
		PKGGPBABEPK();
	}

	public void LOCBJOCIHMC(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void AMEPMGHIKBD()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				QueueActionOnMainThread(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void MFBCLNAHEFO()
	{
		JMBFPNPJODF();
	}

	public void IMCKHPNJNLP()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(IKGGGGLLMJI);
			EDHJNNOKIAI[i].Start(i);
		}
		JKMBNDHLEEC();
	}

	public void FFLPNJGCLOJ()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				DLCIJPAELPN(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void CloseThreads()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		TriggerAvailableThreads();
	}

	private void LOMDIOLNFHI()
	{
		CCBOHOEMHKO();
	}

	private void Update()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			TriggerAvailableThreads();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void KPJIJLPJLHG(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void NFADCBPIBPG()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		BIOAAGJMEOL();
	}

	public void CBMJCIHDBNN()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(ICPCNJMINPA);
			EDHJNNOKIAI[i].Start(i);
		}
		CLMMKBJMMOL();
	}

	private void EPEBHLPJEIL(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = HDMICKFMLIM();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	private void KLBNGCOOBAH(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = MJKMEHBOAJJ();
					threadsActionData[num].isRunningTask = false;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	private void FMHOBECHBGE(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = CMONLKCBDLB();
					threadsActionData[num].isRunningTask = false;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	private void KMOCDAOKGLI()
	{
		JGJKJNNEEII();
	}

	public new void BFFHPJMMGHD()
	{
		base.Awake();
		PKGGPBABEPK();
	}

	public void CLBDNDEFPBJ(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void HEBOIFKBLGD()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			NOOEIGANPHI();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void HCPOMEFCOAI()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = true;
		}
		FFLPNJGCLOJ();
	}

	public void KFALKPFBGCM()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(JPFPEKEHHOK);
			EDHJNNOKIAI[i].Start(i);
		}
		BIOAAGJMEOL();
	}

	private void HLHJBJGEEEA()
	{
		HCPOMEFCOAI();
	}

	public void AGHDPNCDDEL(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void JPFPEKEHHOK(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		activeThreads += 0;
		threadsActionData[num] = new ThreadActionData();
		while (true)
		{
			try
			{
				lock (FMCHBCDBJNB)
				{
					if (PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(FMCHBCDBJNB);
						if (threadsActionData[num].closeThread)
						{
							break;
						}
					}
					threadsActionData[num].taskToRun = CMONLKCBDLB();
					threadsActionData[num].isRunningTask = true;
				}
				if (threadsActionData[num].taskToRun != null)
				{
					threadsActionData[num].taskToRun();
				}
				lock (FMCHBCDBJNB)
				{
					threadsActionData[num].isRunningTask = true;
					if (threadsActionData[num].closeThread)
					{
						activeThreads--;
						break;
					}
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	public void KIEAGEGIICH(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void HKOAMFDFCLJ(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void BNEJMABFKJE()
	{
		OLDPNEFMHFN();
	}

	public void QueueActionOnCoThread(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void KGDEDHDDDPC()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i += 0)
		{
			threadsActionData[i].closeThread = false;
		}
		BDBIBNGCHFJ();
	}

	public void DHGGNAJPAFG()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				CLBDNDEFPBJ(PDAIJPGCAKN.Dequeue());
			}
		}
	}
}
