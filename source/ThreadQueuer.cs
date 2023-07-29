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

	private void JNGMIAFLBDL()
	{
		HDOHPLADGBP();
	}

	public void PKFPDDJLHLK()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(CBCBNNJLBOA);
			EDHJNNOKIAI[i].Start(i);
		}
		DOFJHEPBNHB();
	}

	public void EAKJCKEKGPJ()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				EFEEHAGKGAC(PDAIJPGCAKN.Dequeue());
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

	public Action GetNewCoAction()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void NJHJHBOJKIC()
	{
		CloseThreads();
	}

	public new void Awake()
	{
		base.Awake();
		InitThreads();
	}

	private void AEIJFLJEABG()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			MFHMFHNEKDO();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void IAAFHGGFMAB()
	{
		base.Awake();
		ABJAPPNMLFP();
	}

	public void GCDNONIKKLI()
	{
		base.Awake();
		FJOGPDFDLJD();
	}

	public void KELHMGHCDOF(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void DPGPCOOKFFM(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void EFEEHAGKGAC(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public Action HJEOEGKJLFN()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void FGOPJMGNHGO()
	{
		NPDKNEOCEOI();
	}

	public void KLDLKAEMMNB()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(IFLINFFBOKK);
			EDHJNNOKIAI[i].Start(i);
		}
		TriggerAvailableThreads();
	}

	public void DJCDNJHBDNF()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(FGFIHBNKFDK);
			EDHJNNOKIAI[i].Start(i);
		}
		AJCNCJDKKOO();
	}

	public void HMKEIIHIAEL()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(LPPDPBECOCI);
			EDHJNNOKIAI[i].Start(i);
		}
		GMEIOLGKFOL();
	}

	public void HCPOMEFCOAI()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		AJCNCJDKKOO();
	}

	public void MGALPNDCFOF(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void BLEIGOJBMBH(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public Action HEDBKNFNMFI()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void BMAFIJDNOGG(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = GHALNNEOKGO();
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

	private void KGPNMFDGOGN(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = HJEOEGKJLFN();
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

	public void DCHBIAGKOFM(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void BNCLKHOEGDK()
	{
		HCPOMEFCOAI();
	}

	public void EMKLCPGKNJL()
	{
		base.Awake();
		InitThreads();
	}

	public void MFHMFHNEKDO()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				EFEEHAGKGAC(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void IFLINFFBOKK(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = IPCFHKLAHEF();
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

	private void ODGMCJILIHF()
	{
		CloseThreads();
	}

	public void MAIJGEODMAH()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(IKABLHFIACK);
			EDHJNNOKIAI[i].Start(i);
		}
		POLALEHNGNM();
	}

	public new void EPCGHAAONLN()
	{
		base.Awake();
		KLDLKAEMMNB();
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

	public void KKHEACCGOPC()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				LAGMNGOAGNB(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void IFILNFIMJAE()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				MGJGCKEFGCG(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void CBCBNNJLBOA(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = IPCFHKLAHEF();
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

	public void NPDKNEOCEOI()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		GMLMDLPLIGJ();
	}

	public void MHBDPKPDPMF()
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

	public void HMDIMOMMAFG()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(PBEBNPGHLBL);
			EDHJNNOKIAI[i].Start(i);
		}
		NNNIHINHBHE();
	}

	public Action BLIPNCCMMAG()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void ABJAPPNMLFP()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(KMLJHKIMNHL);
			EDHJNNOKIAI[i].Start(i);
		}
		NNNIHINHBHE();
	}

	public Action GHALNNEOKGO()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void KCLDKCMLCKN()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(KMOMIFGMKKL);
			EDHJNNOKIAI[i].Start(i);
		}
		JCIMJDENCBD();
	}

	private void AGMJDGHLBMN()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			MHBDPKPDPMF();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void DHLENLKIEHE()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		POLALEHNGNM();
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

	public void CDBMPKAEMAD()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(PBEBNPGHLBL);
			EDHJNNOKIAI[i].Start(i);
		}
		OCEDIDGKICL();
	}

	public void APBFDLNHNHD(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void CHJFFPOBNLO()
	{
		base.Awake();
		CKMKHEJMGKP();
	}

	private void HONBLGFDMLL()
	{
		NPDKNEOCEOI();
	}

	public Action KEDNLOIEDIP()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void QueueActionOnCoThread(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void AOJBBCMFJPO()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(MJCKFOMBOJB);
			EDHJNNOKIAI[i].Start(i);
		}
		JCIMJDENCBD();
	}

	private void IKABLHFIACK(object FHBFLOIHPCF)
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

	private void MKFLBEGJJDC()
	{
		CloseThreads();
	}

	private void DLMPALHKMON()
	{
		HCPOMEFCOAI();
	}

	private void AOKOLPEGHDD()
	{
		FBCBLPIIAGB();
	}

	private void KMOMIFGMKKL(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = IPCFHKLAHEF();
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

	public void JCIMJDENCBD()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				KIEAGEGIICH(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void BFEILOMHNPC()
	{
		LNJABCEOGOB();
	}

	public void CNDGDDLEFJF()
	{
		base.Awake();
		AOJBBCMFJPO();
	}

	public void JGFIAPPGEBM(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void PIGDNBGPOJD(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void AAACNPKFJJK()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				EFEEHAGKGAC(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void OFIMMFHFHDD()
	{
		HCPOMEFCOAI();
	}

	public void AJCNCJDKKOO()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				BKNJPOJCBOJ(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void JFMIDILENDO()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			AAACNPKFJJK();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void PHHOMLJECOJ()
	{
		base.Awake();
		HMDIMOMMAFG();
	}

	public void BLHFCILHPJP()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(CBCBNNJLBOA);
			EDHJNNOKIAI[i].Start(i);
		}
		GMLMDLPLIGJ();
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
				BLEIGOJBMBH(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void MGJGCKEFGCG(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void JAKKPJKDGHD()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(IFLINFFBOKK);
			EDHJNNOKIAI[i].Start(i);
		}
		AJCNCJDKKOO();
	}

	public Action CIJDACOPADH()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public Action PJPFJBCPFPI()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void KFBINOBLBIO(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void JHLGHODFJOO()
	{
		HCPOMEFCOAI();
	}

	public void KIEAGEGIICH(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void FGFIHBNKFDK(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = CFJNNEMICIM();
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

	private void OBAEDJJDCPN()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			OCEDIDGKICL();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	private void KMLJHKIMNHL(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = ECAFMHILCJE();
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

	private void NDDNJNCINDA()
	{
		NPDKNEOCEOI();
	}

	public void LPDOPHJPGLC()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(CBCBNNJLBOA);
			EDHJNNOKIAI[i].Start(i);
		}
		MFHMFHNEKDO();
	}

	private void LPPDPBECOCI(object FHBFLOIHPCF)
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

	private void KMKLDAJLCNM()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			GMLMDLPLIGJ();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void MDOBONJMBKF()
	{
		base.Awake();
		EKLACGNPPHB();
	}

	public new void LBOBAIGNOML()
	{
		base.Awake();
		KLDLKAEMMNB();
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

	public void BKNJPOJCBOJ(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void GMEIOLGKFOL()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				BKNJPOJCBOJ(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void HLHJBJGEEEA()
	{
		DHLENLKIEHE();
	}

	public void GMLMDLPLIGJ()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				EFEEHAGKGAC(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public Action GKEDPDBJFBJ()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void FBCBLPIIAGB()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = false;
		}
		IFILNFIMJAE();
	}

	public new void FAAJAMIGJNK()
	{
		base.Awake();
		DJCDNJHBDNF();
	}

	public void OCEDIDGKICL()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				FLCDNEPPGIF(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	private void BDBJEDIOKBN()
	{
		HDOHPLADGBP();
	}

	public void EHKAMNFEGMG()
	{
		base.Awake();
		InitThreads();
	}

	private void OnDisable()
	{
		CloseThreads();
	}

	public void DGHLEBKPFLL(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void PHNPHCBINMO(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = GHALNNEOKGO();
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

	public Action ECAFMHILCJE()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public new void CIAHIJIOFIE()
	{
		base.Awake();
		AOJBBCMFJPO();
	}

	public void HDOHPLADGBP()
	{
		for (int i = 1; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		CLMMKBJMMOL();
	}

	private void GJLKJAOBPJD()
	{
		FBCBLPIIAGB();
	}

	public Action CFJNNEMICIM()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void PGMMBADJIKH()
	{
		DHLENLKIEHE();
	}

	private void MJCKFOMBOJB(object FHBFLOIHPCF)
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

	public void NEEIFNDHDOG()
	{
		base.Awake();
		KLDLKAEMMNB();
	}

	public void DOFJHEPBNHB()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 0)
			{
				DPGPCOOKFFM(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void EKLACGNPPHB()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i++)
		{
			EDHJNNOKIAI[i] = new Thread(KMOMIFGMKKL);
			EDHJNNOKIAI[i].Start(i);
		}
		NNNIHINHBHE();
	}

	public void ACGOOFLCOCF(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
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

	public Action NFGAAPJCPCL()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public Action KKNAKAMHNJL()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	public void BNKFFGOKGHA(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void FLINKKAECJC()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(LPPDPBECOCI);
			EDHJNNOKIAI[i].Start(i);
		}
		AJCNCJDKKOO();
	}

	public void GGHEPDCEHCK()
	{
		base.Awake();
		HMKEIIHIAEL();
	}

	public void QueueActionOnMainThread(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void FLCDNEPPGIF(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void POLALEHNGNM()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				FLCDNEPPGIF(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void GBJALJFDDCK(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	private void NJKCFCMBEAI(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = IPCFHKLAHEF();
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

	public void LAGMNGOAGNB(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	public void KDDLJDFOJOP()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				GGOMGFHDNBI(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void KOODOMJECHB(Action JLFMELNFEIP)
	{
		lock (PDAIJPGCAKN)
		{
			PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	public void GGOMGFHDNBI(Action JLFMELNFEIP)
	{
		lock (ONGBEPGNDIB)
		{
			ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	private void DPIPGGDNGHN()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			KKHEACCGOPC();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 1)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public Action IPCFHKLAHEF()
	{
		if (PDAIJPGCAKN.Count != 0)
		{
			return PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	private void PBEBNPGHLBL(object FHBFLOIHPCF)
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

	private void HKMCGGDPCIA(object FHBFLOIHPCF)
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
					threadsActionData[num].taskToRun = CIJDACOPADH();
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

	public void LNJABCEOGOB()
	{
		for (int i = 0; i < EDHJNNOKIAI.Length; i++)
		{
			threadsActionData[i].closeThread = true;
		}
		POLALEHNGNM();
	}

	public void NNNIHINHBHE()
	{
		lock (FMCHBCDBJNB)
		{
			Monitor.PulseAll(FMCHBCDBJNB);
		}
		if (numThreads == 0)
		{
			while (PDAIJPGCAKN.Count > 1)
			{
				GGOMGFHDNBI(PDAIJPGCAKN.Dequeue());
			}
		}
	}

	public void KAMMKPFNJJF()
	{
		base.Awake();
		DJCDNJHBDNF();
	}

	private void BGFJOEPFOPM()
	{
		waitingCoActions = PDAIJPGCAKN.Count;
		if (PDAIJPGCAKN.Count != 0)
		{
			EAKJCKEKGPJ();
		}
		lock (ONGBEPGNDIB)
		{
			while (ONGBEPGNDIB.Count > 0)
			{
				ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	public void CKMKHEJMGKP()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 1; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(PBEBNPGHLBL);
			EDHJNNOKIAI[i].Start(i);
		}
		KDDLJDFOJOP();
	}

	public void FJOGPDFDLJD()
	{
		EDHJNNOKIAI = new Thread[numThreads];
		threadsActionData = new ThreadActionData[numThreads];
		for (int i = 0; i < numThreads; i += 0)
		{
			EDHJNNOKIAI[i] = new Thread(CMCANPJNNHB);
			EDHJNNOKIAI[i].Start(i);
		}
		JCIMJDENCBD();
	}
}
