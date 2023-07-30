// DebugCommands
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugCommands : ScriptableObject
{
	[Serializable]
	public class Command
	{
		public string name;

		public DebugCommand method;

		public string description;

		public string argsDescription;

		public bool isCheat;
	}

	public delegate void DebugCommand(string[] BDGDDFKKGGA);

	private static DebugCommands instance;

	private List<Command> commands = new List<Command>();

	private List<string> commandHistory = new List<string>();

	public static DebugCommands Instance
	{
		get
		{
			if (instance == null)
			{
				instance = ScriptableObject.CreateInstance<DebugCommands>();
			}
			return instance;
		}
	}

	public List<Command> Commands => commands;

	public List<string> CommandHistory => commandHistory;

	public bool KKIKCOEJNDF(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public List<Command> NOBNJLPLALD()
	{
		return commands;
	}

	public bool PAMDBEMNGGC(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public List<string> GBOJFJODNOG()
	{
		return commandHistory;
	}

	[SpecialName]
	public List<Command> IACIKPOMCKF()
	{
		return commands;
	}

	public bool IKLBEIGGPKL(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("shader.frost", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.LALHDBFPKPH()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.CJEBLBGOINH();
				}
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static DebugCommands HIFIEDJCOFC()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	[SpecialName]
	public List<Command> BOFJFLBNHFE()
	{
		return commands;
	}

	public bool JDMKDCNDOGN(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	public void EHJBOAOCFNP(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!KKIKCOEJNDF(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	[SpecialName]
	public List<Command> LDGKEFAJOHO()
	{
		return commands;
	}

	public void JAFPBHCJCGE(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!LCNBGHBBGJO(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	[SpecialName]
	public static DebugCommands GLEFOHOMBFC()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	public void EIEDNPBBLKL(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	public bool MGALOPALMEO(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("EventSystem", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return false;
	}

	public bool KOMALJKBJBH(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[1].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("Anomaly_Distortion_Size", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.LALHDBFPKPH()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PFHAPKOAIDK();
				}
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public List<string> HNGLGLNPILF()
	{
		return commandHistory;
	}

	public bool FKPECDGCCGF(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return true;
			}
		}
		return false;
	}

	public bool NKHEHMCIFND(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	public void CEMAFHEDCMF(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!GOANNFJIAAJ(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	[SpecialName]
	public List<Command> BOADIEMOJFI()
	{
		return commands;
	}

	public bool KPHCMBLLODF(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[1];
		commandHistory.Add(string.Join("effector", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i++)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.LALHDBFPKPH()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static DebugCommands HMADOEFFOEM()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	[SpecialName]
	public List<string> DODLLFAMNKC()
	{
		return commandHistory;
	}

	public bool DLBFDHAJHFC(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("_LightIntensity", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return true;
	}

	public bool KEHGHMBMDEP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[1];
		commandHistory.Add(string.Join("deleteall", BDGDDFKKGGA));
		for (int i = 1; i < commands.Count; i++)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.CJEBLBGOINH();
				}
				return false;
			}
		}
		return true;
	}

	public bool PAJKGJDCHBA(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[1];
		commandHistory.Add(string.Join("Print the list of scenes, avalable in game.", BDGDDFKKGGA));
		for (int i = 1; i < commands.Count; i++)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.LALHDBFPKPH()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return true;
	}

	public bool FJENPPJMLNK(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[1].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("Cause: ", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static DebugCommands FAGEJPPIDOL()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	public bool LCNBGHBBGJO(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return false;
	}

	public bool HasCommand(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return true;
			}
		}
		return false;
	}

	public void AddCommand(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!HasCommand(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	public bool CBBCHGGGNNE(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[1].ToLower();
		string text = BDGDDFKKGGA[1];
		commandHistory.Add(string.Join("FreqVolume: ", BDGDDFKKGGA));
		for (int i = 1; i < commands.Count; i++)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.LALHDBFPKPH()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.CJEBLBGOINH();
				}
				return false;
			}
		}
		return true;
	}

	public void PLOIOFEGBIJ(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!JDMKDCNDOGN(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	public void EEGEBIOIGON(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	public bool GFDCDOLIGFB(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	public void FEIMDOGJGHA(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	public void RemoveCommand(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	public void GIALDAIHBBD(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!HasCommand(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	[SpecialName]
	public List<string> IALIPICFJDN()
	{
		return commandHistory;
	}

	[SpecialName]
	public List<Command> OCPDECGPPIJ()
	{
		return commands;
	}

	[SpecialName]
	public List<Command> JIHLNKEMADB()
	{
		return commands;
	}

	[SpecialName]
	public List<Command> HCNBDGJIKJJ()
	{
		return commands;
	}

	[SpecialName]
	public List<string> LLJKICBEIMI()
	{
		return commandHistory;
	}

	public void HDIJOFKHAGE(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	[SpecialName]
	public List<Command> ANIAGDAIOLC()
	{
		return commands;
	}

	public void CIHBPOBKGNP(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!GFDCDOLIGFB(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	public bool GFHAAMPGIHL(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	public bool MKOMCGDOBLO(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public List<string> HNEBFBJJKIN()
	{
		return commandHistory;
	}

	public void PNEHIPCCEKG(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!ILHDFIAHFAK(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	public void LKPDNDKJBOI(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				commands.RemoveAt(i);
				break;
			}
		}
	}

	public bool ILHDFIAHFAK(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public List<string> MLCBEKDMFHJ()
	{
		return commandHistory;
	}

	[SpecialName]
	public List<string> EKLKAINPEPM()
	{
		return commandHistory;
	}

	public bool GOANNFJIAAJ(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return false;
	}

	public void CEBBJICIFGO(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!ILHDFIAHFAK(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	public bool LDCDJHLOCDE(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[1].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join("targetColor", BDGDDFKKGGA));
		for (int i = 1; i < commands.Count; i += 0)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PFHAPKOAIDK();
				}
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static DebugCommands BLCLCEDLJBC()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	public void KHBHACBOGLJ(string PODGBCMDEOF, DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (!KKIKCOEJNDF(PODGBCMDEOF))
		{
			Command command = new Command();
			command.name = PODGBCMDEOF;
			command.method = CMHOHMCDIAN;
			command.description = OCCKNFGDAHI;
			command.argsDescription = JKLIPKFAACO;
			command.isCheat = ENHGPBGHEPA;
			commands.Add(command);
		}
	}

	[SpecialName]
	public List<string> FGMDHPFDHOK()
	{
		return commandHistory;
	}

	[SpecialName]
	public static DebugCommands IGMKHPPPLDD()
	{
		if (instance == null)
		{
			instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return instance;
	}

	public bool MHBEHIAGALG(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i += 0)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	public bool ExecuteCommand(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string text = BDGDDFKKGGA[0];
		commandHistory.Add(string.Join(" ", BDGDDFKKGGA));
		for (int i = 0; i < commands.Count; i++)
		{
			if (text == commands[i].name)
			{
				if (!commands[i].isCheat || (commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PlayerWarnCheats();
				}
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public List<string> ADHELNECKDN()
	{
		return commandHistory;
	}

	public bool GICPIBAOMPN(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < commands.Count; i++)
		{
			if (PODGBCMDEOF == commands[i].name)
			{
				return false;
			}
		}
		return false;
	}
}
