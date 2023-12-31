// DebugLogs
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugLogs : ScriptableObject
{
	[Serializable]
	public class Log
	{
		public LogType type;

		public string message;

		public string stackTrace;
	}

	private static DebugLogs instance;

	public Action<Log> OnLogAdded;

	public Action OnLogsCleared;

	private List<Log> logs = new List<Log>();

	public static DebugLogs Instance
	{
		get
		{
			if (instance == null)
			{
				instance = ScriptableObject.CreateInstance<DebugLogs>();
			}
			return instance;
		}
	}

	public List<Log> Logs => logs;

	public void DHILJLCAJOH(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void BONGPCHPKGM(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		CGPBBDHGEHL(log);
	}

	[SpecialName]
	public List<Log> NHOFNFPMPIJ()
	{
		return logs;
	}

	private void FIHFNOKPLOE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMBKCMAIGDE(log);
	}

	private void AJBHOEBKGDO()
	{
		Application.logMessageReceived += BFHBLOLBLEB;
	}

	public void CFOEEAKEICA(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public static DebugLogs AAICPABFPMH()
	{
		return PJGGFINJIEG();
	}

	public void PEPAOAGLKBE(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void EPHCPNILKGI()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public void EGMANOEGILB()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void FDPACFIMNBC(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		CFOEEAKEICA(log);
	}

	public void PBAOOLHNKGI(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void DPGHJILBPCE()
	{
		Application.logMessageReceived += BONGPCHPKGM;
	}

	public void FMEAEDJNAJE(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void DEPPMIPBPAL()
	{
		Application.logMessageReceived -= KJONBKLMPDB;
	}

	public void NFDOJABJEAJ(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	[SpecialName]
	public List<Log> JAPENNOMMPB()
	{
		return logs;
	}

	public static DebugLogs APPNBEHBAAN()
	{
		return PJGGFINJIEG();
	}

	[SpecialName]
	public List<Log> DAIMPCOMEOC()
	{
		return logs;
	}

	public static DebugLogs LIGMMLFHBCO()
	{
		return BJBGHMFFOML();
	}

	public void KJIKIKAEMEH(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void GMBKCMAIGDE(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void LOLHKNKBNPF()
	{
		Application.logMessageReceived += KPFDEHBDLOI;
	}

	private void INMDNNOLNDH(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		AddLog(log);
	}

	public void BIOMHEFCNGG(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public static DebugLogs OCJEOJGNDKM()
	{
		return FNBAADLJGFH();
	}

	public void MGEPCIPHOCL()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void BNOOOFEECFN(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMBKCMAIGDE(log);
	}

	private void DMANIBGNIMK()
	{
		Application.logMessageReceived -= BNOOOFEECFN;
	}

	[SpecialName]
	public static DebugLogs PLNLDAHBDBB()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public void LJKHJBKGCJK(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void LOGBIMAOOAB(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public static DebugLogs NEEAJCHBMNL()
	{
		return Instance;
	}

	[SpecialName]
	public static DebugLogs KDECGCBBEDI()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void PELDLDIDGFO()
	{
		Application.logMessageReceived -= MJCINHPBLMB;
	}

	[SpecialName]
	public static DebugLogs GNOGMOMHIGL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void MNFAKFGGHNK(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		CFOEEAKEICA(log);
	}

	public static DebugLogs HGIFFBJPMDN()
	{
		return MNNNKLODJPJ();
	}

	private void OnDestroy()
	{
		Application.logMessageReceived -= INMDNNOLNDH;
	}

	private void JNJMGIFMNBF()
	{
		Application.logMessageReceived -= FDPACFIMNBC;
	}

	[SpecialName]
	public List<Log> DFCCGNACJGL()
	{
		return logs;
	}

	private void LICOLMAOHKI()
	{
		Application.logMessageReceived += IMNCPCLALJJ;
	}

	[SpecialName]
	public static DebugLogs JEGPKFIGPFP()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public void GIODPNEBBID(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void DONICBHGIMP(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMNAJNIKMAO(log);
	}

	public void NCGIKMIMIAA()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	[SpecialName]
	public static DebugLogs GLEFOHOMBFC()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public void CGPBBDHGEHL(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void FIMPKAEMBDE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GIODPNEBBID(log);
	}

	public void IELAGEFHCEH(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void OJIHBHNJFBB()
	{
		Application.logMessageReceived -= EPECEAPDMKI;
	}

	[SpecialName]
	public static DebugLogs MNNNKLODJPJ()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void EPECEAPDMKI(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		AddLog(log);
	}

	private void PAHNKEGFGHB()
	{
		Application.logMessageReceived += KPFDEHBDLOI;
	}

	private void FJGNDJGLBEN()
	{
		Application.logMessageReceived -= BNOOOFEECFN;
	}

	public void DGEHKEOGNPN(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	[SpecialName]
	public static DebugLogs FMEBOFOPHDG()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public List<Log> JMBMGJLGOGJ()
	{
		return logs;
	}

	private void IMNCPCLALJJ(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMNAJNIKMAO(log);
	}

	[SpecialName]
	public static DebugLogs EGHNDEGBPAP()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public List<Log> MLICHFLLIKF()
	{
		return logs;
	}

	[SpecialName]
	public static DebugLogs BEPGMCOJFKL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void HOLDCFBBHHP()
	{
		Application.logMessageReceived += DONICBHGIMP;
	}

	public void JNDMIAKMHCG()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public static DebugLogs GBDGMMKNGFC()
	{
		return GNOGMOMHIGL();
	}

	public void ClearLogs()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public void DCIFPNIDJKI()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public static DebugLogs AFDBDFJHMBN()
	{
		return JEGPKFIGPFP();
	}

	public void DCLMNOJMHEJ(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	[SpecialName]
	public static DebugLogs PJGGFINJIEG()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public List<Log> FEAOKBPNJKL()
	{
		return logs;
	}

	public void CHNPAIEBNDA()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void BKAJKNPDEAP()
	{
		Application.logMessageReceived -= JNEHFGLHCBD;
	}

	public void JCNCIGNAGFF(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void KIBKHEAHMND(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void NHOFNIIBMDH()
	{
		Application.logMessageReceived -= BFHBLOLBLEB;
	}

	[SpecialName]
	public List<Log> IDLDNGCDICL()
	{
		return logs;
	}

	private void JOLKPPEBILA()
	{
		Application.logMessageReceived += INMDNNOLNDH;
	}

	public void JHGPIIIFDNN()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public void AddLog(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void KAHMPKPOEBD()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void IBFHEDHJDLH()
	{
		Application.logMessageReceived += FDPACFIMNBC;
	}

	[SpecialName]
	public static DebugLogs NBPGOMDMGHB()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void KPFDEHBDLOI(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		DHILJLCAJOH(log);
	}

	[SpecialName]
	public List<Log> MLNJPDGONOE()
	{
		return logs;
	}

	public void NIKKCCMKEBB(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	[SpecialName]
	public static DebugLogs NIFMFBHNMJH()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public static DebugLogs BJBGHMFFOML()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public static DebugLogs FLFBBNOFAOL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public void GMNAJNIKMAO(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	private void LHGFCBDACBM()
	{
		Application.logMessageReceived += KJONBKLMPDB;
	}

	public static DebugLogs JNBJGLMJNPB()
	{
		return NIFMFBHNMJH();
	}

	[SpecialName]
	public List<Log> IEMPPMBDECN()
	{
		return logs;
	}

	private void AONJNAGNLIH()
	{
		Application.logMessageReceived += INMDNNOLNDH;
	}

	[SpecialName]
	public List<Log> KFEKJKLOJKC()
	{
		return logs;
	}

	public void BFAKEAFBGHN(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	public void OHFJDPIDCDJ()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void BFHBLOLBLEB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		KJIKIKAEMEH(log);
	}

	private void BFKGLMLLIHK()
	{
		Application.logMessageReceived -= FDPACFIMNBC;
	}

	[SpecialName]
	public List<Log> BMJBPNFGCHN()
	{
		return logs;
	}

	public void DBELJBLKLHE(Log BAODCKEFHMK)
	{
		logs.Add(BAODCKEFHMK);
		if (OnLogAdded != null)
		{
			OnLogAdded(BAODCKEFHMK);
		}
	}

	[SpecialName]
	public static DebugLogs AKNKBPICFGJ()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public static DebugLogs PFOGFJMFFGA()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public List<Log> BGLJPEENCAI()
	{
		return logs;
	}

	[SpecialName]
	public static DebugLogs GFIEMBPCNEC()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public static DebugLogs FNBAADLJGFH()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public List<Log> CCIIOIDFOFF()
	{
		return logs;
	}

	private void OnEnable()
	{
		Application.logMessageReceived += INMDNNOLNDH;
	}

	private void HEKKABCJLKN()
	{
		Application.logMessageReceived -= KPFDEHBDLOI;
	}

	[SpecialName]
	public static DebugLogs FAGEJPPIDOL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	private void GHLCFKGNNAI()
	{
		Application.logMessageReceived -= JNEHFGLHCBD;
	}

	[SpecialName]
	public static DebugLogs ECIBPJGCNNF()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	[SpecialName]
	public static DebugLogs LDCGDCPIJMK()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public static DebugLogs Touch()
	{
		return Instance;
	}

	public void JDIKJHILCJA()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	[SpecialName]
	public List<Log> MNAHAGOGMJN()
	{
		return logs;
	}

	private void KEBNPDKADDF()
	{
		Application.logMessageReceived -= EPECEAPDMKI;
	}

	private void ICPOEGIAFBL()
	{
		Application.logMessageReceived += EPECEAPDMKI;
	}

	private void MECBHGPGCFL()
	{
		Application.logMessageReceived -= KJONBKLMPDB;
	}

	private void DLHJMLDBDOK()
	{
		Application.logMessageReceived -= INMDNNOLNDH;
	}

	public void CAAMGHOOPJA()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public static DebugLogs MEKCLHGCIPJ()
	{
		return GLEFOHOMBFC();
	}

	private void JOPGLJAEBAE()
	{
		Application.logMessageReceived -= KJONBKLMPDB;
	}

	private void FHNLBKCJDEE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMBKCMAIGDE(log);
	}

	[SpecialName]
	public static DebugLogs HPFHKGAKKLL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return instance;
	}

	public void INDDCOEIDLB()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void NFADJOKFCDL()
	{
		Application.logMessageReceived -= MNFAKFGGHNK;
	}

	private void KJONBKLMPDB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		BFAKEAFBGHN(log);
	}

	private void MDMDGKHDPKP()
	{
		Application.logMessageReceived += FHNLBKCJDEE;
	}

	private void MJCINHPBLMB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		GMNAJNIKMAO(log);
	}

	public void BFKIFIEPLJH()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	public void ONBGLBDBPJG()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void IFBKMAEMKNN()
	{
		Application.logMessageReceived += BFHBLOLBLEB;
	}

	public static DebugLogs DMMOGDCBFIB()
	{
		return PJGGFINJIEG();
	}

	private void OBPIMJPMGFA()
	{
		Application.logMessageReceived -= MNFAKFGGHNK;
	}

	public static DebugLogs HMJBKJDNJIC()
	{
		return FAGEJPPIDOL();
	}

	private void LEFFPPCFNKD()
	{
		Application.logMessageReceived += EPECEAPDMKI;
	}

	public static DebugLogs NFEDJIAPJGM()
	{
		return NIFMFBHNMJH();
	}

	public void KFOHDCNGILO()
	{
		logs.Clear();
		if (OnLogsCleared != null)
		{
			OnLogsCleared();
		}
	}

	private void NKOIECGDEOJ()
	{
		Application.logMessageReceived += KJONBKLMPDB;
	}

	private void KMMOLADBHEA()
	{
		Application.logMessageReceived += BONGPCHPKGM;
	}

	private void GMLJCGAEMKL()
	{
		Application.logMessageReceived += KPFDEHBDLOI;
	}

	private void JNEHFGLHCBD(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		Log log = new Log();
		log.type = ELCFJBCLFBP;
		log.message = LGFIJEHLGHP;
		log.stackTrace = HAEHALPHBJK;
		CGPBBDHGEHL(log);
	}

	private void BLNLHBNBKOH()
	{
		Application.logMessageReceived += KPFDEHBDLOI;
	}
}
