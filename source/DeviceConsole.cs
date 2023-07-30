// DeviceConsole
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeviceConsole : Singleton<DeviceConsole>
{
	public class OnCommandEventArgs : EventArgs
	{
		public string[] args;

		public OnCommandEventArgs(string[] BDGDDFKKGGA)
		{
			args = BDGDDFKKGGA;
		}
	}

	public delegate void OnCommandEvent(object NFOGDAHIPNP, OnCommandEventArgs KJPAHOFPCKD);

	[SerializeField]
	private GameObject uiContainer;

	[SerializeField]
	private GameObject logContainer;

	[SerializeField]
	private InputField commandInputField;

	[SerializeField]
	private bool autoFocusInputField = true;

	[SerializeField]
	private Color headerColour;

	[SerializeField]
	private string headerText;

	[SerializeField]
	private DeviceLogUI logPrefab;

	[SerializeField]
	private DeviceLogUI warningLogPrefab;

	[SerializeField]
	private DeviceLogUI errorLogPrefab;

	[SerializeField]
	private DeviceLogUI assertLogPrefab;

	[SerializeField]
	private DeviceLogUI exceptionLogPrefab;

	[SerializeField]
	private DeviceLogUI exceptionStackTracePrefab;

	private static int CMHLBFHPJGM = 15000;

	private List<DeviceLogUI> KHDEDBLGNKF;

	private int OPFODDEHOBC;

	private int PDMKEAJOPKJ;

	private bool PBJNFMEAILK;

	private bool GNOPKLFICKN;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private OnCommandEvent ABEBDOAMONO;

	private bool OJPGAKLNDIL;

	private bool LJHHKKLPAKK;

	private bool PBJMOFPJCNG;

	private bool EAIOELPEAEG;

	private float ALHBMGMDJMF;

	private float NAGOOCHPLPK;

	private LayerMask JEJJKLPNJAG;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand BOGJGOAMCHK;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand BDPNFNJNEFM;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand MJKNAFJKDMG;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand JENGHDFDLII;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand BMJHMBNEACI;

	[CompilerGenerated]
	private static DebugCommands.DebugCommand EPENHHMDDMB;

	public event OnCommandEvent CommandEvent
	{
		add
		{
			OnCommandEvent onCommandEvent = ABEBDOAMONO;
			OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange(ref ABEBDOAMONO, (OnCommandEvent)Delegate.Combine(onCommandEvent2, value), onCommandEvent);
			}
			while ((object)onCommandEvent != onCommandEvent2);
		}
		remove
		{
			OnCommandEvent onCommandEvent = ABEBDOAMONO;
			OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange(ref ABEBDOAMONO, (OnCommandEvent)Delegate.Remove(onCommandEvent2, value), onCommandEvent);
			}
			while ((object)onCommandEvent != onCommandEvent2);
		}
	}

	private void EGMKLCFAEEB(DebugLogs.Log BAODCKEFHMK, string MOALALKJCKJ = "")
	{
		if (logContainer != null)
		{
			DeviceLogUI fKCMGBMNNKA = null;
			switch (BAODCKEFHMK.type)
			{
			case LogType.Log:
				fKCMGBMNNKA = logPrefab;
				break;
			case LogType.Warning:
				fKCMGBMNNKA = warningLogPrefab;
				break;
			case LogType.Error:
				fKCMGBMNNKA = errorLogPrefab;
				break;
			case LogType.Assert:
				fKCMGBMNNKA = assertLogPrefab;
				break;
			case LogType.Exception:
				fKCMGBMNNKA = exceptionLogPrefab;
				break;
			}
			string message = BAODCKEFHMK.message;
			message = MOALALKJCKJ + message;
			AGOFMGPFBBE(fKCMGBMNNKA, message);
			if (BAODCKEFHMK.type == LogType.Exception)
			{
				EGMKLCFAEEB(BAODCKEFHMK.stackTrace, exceptionStackTracePrefab);
			}
		}
	}

	private void CHGFNGIAOAL()
	{
		if (autoFocusInputField && commandInputField != null)
		{
			commandInputField.Select();
			commandInputField.ActivateInputField();
		}
	}

	public void NGHJAAGCOJD(bool IDNLBGOCOEK)
	{
		uiContainer.SetActive(IDNLBGOCOEK);
		if (commandInputField != null)
		{
			commandInputField.text = string.Empty;
			if (IDNLBGOCOEK)
			{
				GJOHOFOJIKC();
			}
		}
	}

	private static void PLLLLOBOKMI(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}

	private void PAAIIFPPEPP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 4)
		{
			UnityEngine.Debug.LogError("_Params1");
		}
		else if (BDGDDFKKGGA[1] == "_ScreenResolution" || BDGDDFKKGGA[0] == "88f00bdf0ad61b16b803971ebe071962")
		{
			autoFocusInputField = true;
		}
		else if (BDGDDFKKGGA[0] == "_MainTex" || BDGDDFKKGGA[1] == "Beat Detected")
		{
			autoFocusInputField = false;
		}
		else
		{
			UnityEngine.Debug.LogError("_ScreenResolution");
		}
	}

	private void FIBAPPIDMFH()
	{
		DebugLogs debugLogs = DebugLogs.AKNKBPICFGJ();
		debugLogs.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Remove(debugLogs.OnLogAdded, new Action<DebugLogs.Log>(DMJLENOCHIF));
		DebugLogs debugLogs2 = DebugLogs.FMEBOFOPHDG();
		debugLogs2.OnLogsCleared = (Action)Delegate.Remove(debugLogs2.OnLogsCleared, new Action(CBNODCKLHPJ));
		DebugCommands.BLCLCEDLJBC().FEIMDOGJGHA("ControllerLeftY");
		DebugCommands.IGMKHPPPLDD().EIEDNPBBLKL("_MainTex");
	}

	private static void LCCBKOBHEPN(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 4)
		{
			UnityEngine.Debug.LogError("LevelEditor/patterns");
			return;
		}
		int result = 1;
		if (int.TryParse(BDGDDFKKGGA[1], out result))
		{
			SceneManager.LoadScene(result);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[1]);
		}
	}

	private void IPKMPLAHIDG(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 3)
		{
			UnityEngine.Debug.Log("Need to specify a start index and end index.");
			return;
		}
		int result;
		if (!int.TryParse(BDGDDFKKGGA[1], out result))
		{
			UnityEngine.Debug.Log("Start index must in an integer.");
			return;
		}
		int result2;
		if (!int.TryParse(BDGDDFKKGGA[2], out result2))
		{
			UnityEngine.Debug.Log("End index must in an integer.");
			return;
		}
		if (result > result2)
		{
			int num = result;
			result = result2;
			result2 = num;
			return;
		}
		if (result < 0)
		{
			result = 0;
		}
		if (result2 >= DebugLogs.Instance.Logs.Count)
		{
			result2 = DebugLogs.Instance.Logs.Count - 1;
		}
		KLGELMLHDKK();
		for (int i = result; i <= result2; i++)
		{
			EGMKLCFAEEB(DebugLogs.Instance.Logs[i], i + ":");
		}
	}

	private void LEAHIBJDMBI()
	{
		if (commandInputField != null)
		{
			if (Input.GetKeyDown((KeyCode)(-27)) && PDMKEAJOPKJ > 0)
			{
				PDMKEAJOPKJ--;
				commandInputField.text = DebugCommands.HIFIEDJCOFC().HNEBFBJJKIN()[PDMKEAJOPKJ];
				commandInputField.MoveTextEnd(false);
				CHGFNGIAOAL();
			}
			else if (Input.GetKeyDown((KeyCode)70) && PDMKEAJOPKJ < DebugCommands.IGMKHPPPLDD().MLCBEKDMFHJ().Count)
			{
				PDMKEAJOPKJ++;
				if (PDMKEAJOPKJ == DebugCommands.GLEFOHOMBFC().DODLLFAMNKC().Count)
				{
					commandInputField.text = string.Empty;
					CHGFNGIAOAL();
				}
				else
				{
					commandInputField.text = DebugCommands.Instance.LLJKICBEIMI()[PDMKEAJOPKJ];
					commandInputField.MoveTextEnd(false);
					CHGFNGIAOAL();
				}
			}
		}
		if (Input.GetKeyDown((KeyCode)(-85)))
		{
			NGHJAAGCOJD(uiContainer.activeInHierarchy);
		}
		if (!PBJNFMEAILK && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			PBJNFMEAILK = false;
		}
		if (PBJNFMEAILK && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Canceled)
		{
			PBJNFMEAILK = false;
		}
		if (!GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			GNOPKLFICKN = false;
		}
		if (GNOPKLFICKN && Input.touchCount > 0 && Input.GetTouch(0).phase == (TouchPhase)7)
		{
			GNOPKLFICKN = true;
		}
		if (Input.touchCount == 5 && PBJNFMEAILK && GNOPKLFICKN && Input.GetTouch(4).phase == TouchPhase.Began)
		{
			SetVisible(uiContainer.activeInHierarchy);
		}
	}

	[SpecialName]
	public void DKAKOCGNKDE(OnCommandEvent DPNHODJHGJL)
	{
		OnCommandEvent onCommandEvent = ABEBDOAMONO;
		OnCommandEvent onCommandEvent2;
		do
		{
			onCommandEvent2 = onCommandEvent;
			onCommandEvent = Interlocked.CompareExchange(ref ABEBDOAMONO, (OnCommandEvent)Delegate.Combine(onCommandEvent2, DPNHODJHGJL), onCommandEvent);
		}
		while ((object)onCommandEvent != onCommandEvent2);
	}

	private void GJOHOFOJIKC()
	{
		if (autoFocusInputField && commandInputField != null)
		{
			commandInputField.Select();
			commandInputField.ActivateInputField();
		}
	}

	public void MFFDDFJGFLO()
	{
		if (!uiContainer.activeSelf)
		{
			return;
		}
		string text = commandInputField.text;
		int num = text.IndexOf('\uffc8');
		if (num >= 1)
		{
			text = text.Remove(num, 1);
		}
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[1];
			array[1] = 'P';
			string[] array2 = text2.Split(array);
			string text3 = array2[0];
			UnityEngine.Debug.Log(string.Format("_Value4", text));
			if (ABEBDOAMONO != null)
			{
				ABEBDOAMONO(this, new OnCommandEventArgs(array2));
			}
			if (!DebugCommands.FAGEJPPIDOL().IKLBEIGGPKL(array2))
			{
			}
			PDMKEAJOPKJ = DebugCommands.HMADOEFFOEM().LLJKICBEIMI().Count;
			commandInputField.text = string.Empty;
			CHGFNGIAOAL();
		}
	}

	private static void HCEMABBLLMP(string[] BDGDDFKKGGA)
	{
		DebugLogs.EGHNDEGBPAP().OHFJDPIDCDJ();
	}

	private string NKMNGBHKHGK(Color32 HABLFKCCKLN)
	{
		return HABLFKCCKLN.r.ToString("CameraFilterPack/Gradients_ElectricGradient") + HABLFKCCKLN.g.ToString("[LevelEditorScene] Error: I/O Failure! :(") + HABLFKCCKLN.b.ToString("CameraFilterPack/FX_EarthQuake");
	}

	private void PDOFDHLILCI()
	{
		if (autoFocusInputField && commandInputField != null)
		{
			commandInputField.Select();
			commandInputField.ActivateInputField();
		}
	}

	private void KLGELMLHDKK()
	{
		if (KHDEDBLGNKF != null)
		{
			for (int i = 0; i < KHDEDBLGNKF.Count; i++)
			{
				UnityEngine.Object.Destroy(KHDEDBLGNKF[i].gameObject);
			}
		}
		KHDEDBLGNKF.Clear();
		OPFODDEHOBC = 0;
	}

	public void GFJANEIAJGM()
	{
		if (!uiContainer.activeSelf)
		{
			return;
		}
		string text = commandInputField.text;
		int num = text.IndexOf('￩');
		if (num >= 0)
		{
			text = text.Remove(num, 0);
		}
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[1] = '\ufff4';
			string[] array2 = text2.Split(array);
			string text3 = array2[1];
			UnityEngine.Debug.Log(string.Format("Xbox Home", text));
			if (ABEBDOAMONO != null)
			{
				ABEBDOAMONO(this, new OnCommandEventArgs(array2));
			}
			if (!DebugCommands.IGMKHPPPLDD().IKLBEIGGPKL(array2))
			{
			}
			PDMKEAJOPKJ = DebugCommands.GLEFOHOMBFC().IALIPICFJDN().Count;
			commandInputField.text = string.Empty;
			CHGFNGIAOAL();
		}
	}

	private static void OAOPONPIOJH(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.Instance.Commands.Count; i++)
		{
			DebugCommands.Command command = DebugCommands.Instance.Commands[i];
			if (!command.isCheat)
			{
				string empty = string.Empty;
				empty = $"{command.name}";
				if (!string.IsNullOrEmpty(command.argsDescription))
				{
					empty += $" {command.argsDescription}";
				}
				if (!string.IsNullOrEmpty(command.description))
				{
					empty += $" - {command.description}";
				}
				if (command.isCheat)
				{
				}
				UnityEngine.Debug.Log(empty);
			}
		}
	}

	private void AIEBCGJOCOL(string[] BDGDDFKKGGA)
	{
		UnityEngine.Debug.Log("Scenes List:");
		for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
		{
			UnityEngine.Debug.Log(i + ". Name: " + SceneManager.GetSceneByBuildIndex(i).name + " Path: " + SceneManager.GetSceneByBuildIndex(i).path + " Loaded: " + SceneManager.GetSceneByBuildIndex(i).isLoaded);
		}
	}

	public void FNKIAIBCILP()
	{
		if (!uiContainer.activeSelf)
		{
			return;
		}
		string text = commandInputField.text;
		int num = text.IndexOf('￫');
		if (num >= 1)
		{
			text = text.Remove(num, 0);
		}
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = '\ufffe';
			string[] array2 = text2.Split(array);
			string text3 = array2[0];
			UnityEngine.Debug.Log(string.Format("SetPlayerDistance", text));
			if (ABEBDOAMONO != null)
			{
				ABEBDOAMONO(this, new OnCommandEventArgs(array2));
			}
			if (!DebugCommands.Instance.KEHGHMBMDEP(array2))
			{
			}
			PDMKEAJOPKJ = DebugCommands.Instance.FGMDHPFDHOK().Count;
			commandInputField.text = string.Empty;
			CHGFNGIAOAL();
		}
	}

	private void CBNODCKLHPJ()
	{
		KLGELMLHDKK();
		FIMNHBBHBKK();
	}

	private static void HIHLLCOKFLO(string[] BDGDDFKKGGA)
	{
		UnityEngine.Debug.Log($"There are {DebugLogs.Instance.Logs.Count} reported logs.");
	}

	private static void GJPJGHEKDFO(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify a map name or buildID");
			return;
		}
		int result = 0;
		if (int.TryParse(BDGDDFKKGGA[1], out result))
		{
			SceneManager.LoadScene(result);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[1]);
		}
	}

	private string EFMPOKOGAAH(Color32 HABLFKCCKLN)
	{
		return HABLFKCCKLN.r.ToString("X2") + HABLFKCCKLN.g.ToString("X2") + HABLFKCCKLN.b.ToString("X2");
	}

	private void OnDestroy()
	{
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Remove(instance.OnLogAdded, new Action<DebugLogs.Log>(JPCCMENLCMJ));
		DebugLogs instance2 = DebugLogs.Instance;
		instance2.OnLogsCleared = (Action)Delegate.Remove(instance2.OnLogsCleared, new Action(CBNODCKLHPJ));
		DebugCommands.Instance.RemoveCommand("plogs");
		DebugCommands.Instance.RemoveCommand("setAF");
	}

	private void JDMKDMIGANM()
	{
		for (int i = 0; i < DebugLogs.Instance.Logs.Count; i++)
		{
			EGMKLCFAEEB(DebugLogs.Instance.Logs[i], string.Empty);
		}
	}

	private static void COJJHBIIMOO(string[] BDGDDFKKGGA)
	{
		DebugLogs.HPFHKGAKKLL().EPHCPNILKGI();
	}

	private static void DMKKPEBIGIM(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.Instance.CommandHistory.Count; i++)
		{
			UnityEngine.Debug.Log(DebugCommands.Instance.CommandHistory[i]);
		}
	}

	private void PBCIFFIIOBA(DeviceLogUI FKCMGBMNNKA, string EAFAMAMDNEG)
	{
		DeviceLogUI deviceLogUI = UnityEngine.Object.Instantiate(FKCMGBMNNKA);
		deviceLogUI.textUI.text = EAFAMAMDNEG;
		deviceLogUI.transform.SetParent(logContainer.transform);
		deviceLogUI.transform.localScale = Vector3.one;
		OPFODDEHOBC += deviceLogUI.textUI.text.Length;
		while (OPFODDEHOBC > CMHLBFHPJGM)
		{
			OPFODDEHOBC -= KHDEDBLGNKF[0].textUI.text.Length;
			UnityEngine.Object.Destroy(KHDEDBLGNKF[1].gameObject);
			KHDEDBLGNKF.RemoveAt(1);
		}
		KHDEDBLGNKF.Add(deviceLogUI);
	}

	private void DBPDCLIPPBD()
	{
		EGMKLCFAEEB(string.Format(". The group number should be at least 1.", EFMPOKOGAAH(headerColour), headerText));
		EGMKLCFAEEB(string.Format("_TimeX", EFMPOKOGAAH(headerColour), "workshop." + Helpers.GetGameVersion()));
		EGMKLCFAEEB(string.Format("There was an error retrieving the NumberOfCurrentPlayers.", EFMPOKOGAAH(headerColour), "_TapLow"));
		EGMKLCFAEEB(string.Format("ZoomFade", NKMNGBHKHGK(headerColour), "DPADVER"));
	}

	public new void Awake()
	{
		base.Awake();
		KHDEDBLGNKF = new List<DeviceLogUI>();
		PDMKEAJOPKJ = 0;
		FIMNHBBHBKK();
		JDMKDMIGANM();
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Combine(instance.OnLogAdded, new Action<DebugLogs.Log>(JPCCMENLCMJ));
		DebugLogs instance2 = DebugLogs.Instance;
		instance2.OnLogsCleared = (Action)Delegate.Combine(instance2.OnLogsCleared, new Action(CBNODCKLHPJ));
		DebugCommands.Instance.AddCommand("help", OAOPONPIOJH, "Prints list of commands", string.Empty);
		DebugCommands.Instance.AddCommand("clear", FNKJJEMGGII, "Clears all text from the debug console", string.Empty);
		DebugCommands.Instance.AddCommand("history", DMKKPEBIGIM, "Prints list of all previous commands", string.Empty);
		DebugCommands.Instance.AddCommand("logc", HIHLLCOKFLO, "Prints the number of logs currently held by DebugLogs", string.Empty);
		DebugCommands.Instance.AddCommand("quit", EHOMIAJALOF, "Closes the app", string.Empty);
		DebugCommands.Instance.AddCommand("plogs", IPKMPLAHIDG, "Clears the console and prints the logs in the specified range", "<start_index> <end_index>");
		DebugCommands.Instance.AddCommand("setAF", FPEOFIJFNJA, "Sets the boolean value of the Auto Focus Input Field property.", "< true | false >");
		DebugCommands.Instance.AddCommand("scenes", AIEBCGJOCOL, "Print the list of scenes, avalable in game.", string.Empty, true);
		DebugCommands.Instance.AddCommand("loadscene", GJPJGHEKDFO, "Load scene by name or build id", "<scene_name> or <id>", true);
		DebugCommands.Instance.AddCommand("resetach21", HPGDNFONHBE, "Reset 21 achievement progress", string.Empty, true);
	}

	public void SetVisible(bool IDNLBGOCOEK)
	{
		uiContainer.SetActive(IDNLBGOCOEK);
		if (commandInputField != null)
		{
			commandInputField.text = string.Empty;
			if (IDNLBGOCOEK)
			{
				PDOFDHLILCI();
			}
		}
	}

	private void EGMKLCFAEEB(string EAFAMAMDNEG, DeviceLogUI FKCMGBMNNKA = null)
	{
		if (logContainer != null)
		{
			AGOFMGPFBBE((!(FKCMGBMNNKA != null)) ? logPrefab : FKCMGBMNNKA, EAFAMAMDNEG);
		}
	}

	private void DMJLENOCHIF(DebugLogs.Log BAODCKEFHMK)
	{
		EGMKLCFAEEB(BAODCKEFHMK, string.Empty);
	}

	public void OnEndEdit()
	{
		if (!uiContainer.activeSelf)
		{
			return;
		}
		string text = commandInputField.text;
		int num = text.IndexOf('\n');
		if (num >= 0)
		{
			text = text.Remove(num, 1);
		}
		if (!string.IsNullOrEmpty(text))
		{
			string[] array = text.Split(' ');
			string text2 = array[0];
			UnityEngine.Debug.Log($"$ {text}");
			if (ABEBDOAMONO != null)
			{
				ABEBDOAMONO(this, new OnCommandEventArgs(array));
			}
			if (!DebugCommands.Instance.ExecuteCommand(array))
			{
			}
			PDMKEAJOPKJ = DebugCommands.Instance.CommandHistory.Count;
			commandInputField.text = string.Empty;
			PDOFDHLILCI();
		}
	}

	private void AGOFMGPFBBE(DeviceLogUI FKCMGBMNNKA, string EAFAMAMDNEG)
	{
		DeviceLogUI deviceLogUI = UnityEngine.Object.Instantiate(FKCMGBMNNKA);
		deviceLogUI.textUI.text = EAFAMAMDNEG;
		deviceLogUI.transform.SetParent(logContainer.transform);
		deviceLogUI.transform.localScale = Vector3.one;
		OPFODDEHOBC += deviceLogUI.textUI.text.Length;
		while (OPFODDEHOBC > CMHLBFHPJGM)
		{
			OPFODDEHOBC -= KHDEDBLGNKF[0].textUI.text.Length;
			UnityEngine.Object.Destroy(KHDEDBLGNKF[0].gameObject);
			KHDEDBLGNKF.RemoveAt(0);
		}
		KHDEDBLGNKF.Add(deviceLogUI);
	}

	private static void EPDCDAEHMLD(string[] BDGDDFKKGGA)
	{
		for (int i = 1; i < DebugCommands.GLEFOHOMBFC().CommandHistory.Count; i += 0)
		{
			UnityEngine.Debug.Log(DebugCommands.GLEFOHOMBFC().IALIPICFJDN()[i]);
		}
	}

	private static void BJPFNHILEBN(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}

	private void FPEOFIJFNJA(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
		}
		else if (BDGDDFKKGGA[1] == "t" || BDGDDFKKGGA[1] == "true")
		{
			autoFocusInputField = true;
		}
		else if (BDGDDFKKGGA[1] == "f" || BDGDDFKKGGA[1] == "false")
		{
			autoFocusInputField = false;
		}
		else
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
		}
	}

	private static void GFLKEANNPJC(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 3)
		{
			UnityEngine.Debug.LogError("PublishMapButton");
			return;
		}
		int result = 1;
		if (int.TryParse(BDGDDFKKGGA[1], out result))
		{
			SceneManager.LoadScene(result);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[0]);
		}
	}

	private void Update()
	{
		if (commandInputField != null)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) && PDMKEAJOPKJ > 0)
			{
				PDMKEAJOPKJ--;
				commandInputField.text = DebugCommands.Instance.CommandHistory[PDMKEAJOPKJ];
				commandInputField.MoveTextEnd(false);
				PDOFDHLILCI();
			}
			else if (Input.GetKeyDown(KeyCode.DownArrow) && PDMKEAJOPKJ < DebugCommands.Instance.CommandHistory.Count)
			{
				PDMKEAJOPKJ++;
				if (PDMKEAJOPKJ == DebugCommands.Instance.CommandHistory.Count)
				{
					commandInputField.text = string.Empty;
					PDOFDHLILCI();
				}
				else
				{
					commandInputField.text = DebugCommands.Instance.CommandHistory[PDMKEAJOPKJ];
					commandInputField.MoveTextEnd(false);
					PDOFDHLILCI();
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.BackQuote))
		{
			SetVisible(!uiContainer.activeInHierarchy);
		}
		if (!PBJNFMEAILK && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			PBJNFMEAILK = true;
		}
		if (PBJNFMEAILK && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			PBJNFMEAILK = false;
		}
		if (!GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			GNOPKLFICKN = true;
		}
		if (GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Ended)
		{
			GNOPKLFICKN = false;
		}
		if (Input.touchCount == 3 && PBJNFMEAILK && GNOPKLFICKN && Input.GetTouch(2).phase == TouchPhase.Began)
		{
			SetVisible(!uiContainer.activeInHierarchy);
		}
	}

	private static void DLAFAIJJDIL(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.BLCLCEDLJBC().CommandHistory.Count; i++)
		{
			UnityEngine.Debug.Log(DebugCommands.HIFIEDJCOFC().HNGLGLNPILF()[i]);
		}
	}

	private void ADFMLNIJNGB()
	{
		for (int i = 1; i < DebugLogs.AKNKBPICFGJ().BMJBPNFGCHN().Count; i += 0)
		{
			EGMKLCFAEEB(DebugLogs.BJBGHMFFOML().CCIIOIDFOFF()[i], string.Empty);
		}
	}

	private static void FNKJJEMGGII(string[] BDGDDFKKGGA)
	{
		DebugLogs.Instance.ClearLogs();
	}

	private void JPCCMENLCMJ(DebugLogs.Log BAODCKEFHMK)
	{
		EGMKLCFAEEB(BAODCKEFHMK, string.Empty);
	}

	private void FIMNHBBHBKK()
	{
		EGMKLCFAEEB($"<color=#{EFMPOKOGAAH(headerColour)}>{headerText}</color>");
		EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", EFMPOKOGAAH(headerColour), "Game Version: " + Helpers.GetGameVersion()));
		EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", EFMPOKOGAAH(headerColour), "Type \"help\" for list of commands"));
		EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", EFMPOKOGAAH(headerColour), "================================"));
	}

	private void HPGDNFONHBE(string[] BDGDDFKKGGA)
	{
		List<string> list = new List<string>();
		list.Add("896296812");
		list.Add("1248864821");
		list.Add("1087340967");
		list.Add("907198288");
		list.Add("1177138211");
		list.Add("1234332714");
		list.Add("1427616858");
		list.Add("880078120");
		list.Add("1278033234");
		list.Add("1332644700");
		list.Add("1159514800");
		List<string> list2 = list;
		foreach (string item in list2)
		{
			Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed.workshop." + item, false);
		}
		Helpers.SetStat("achievements.21.progress", 0);
		SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10u);
		UnityEngine.Debug.Log("Achievement 21 progress reseted");
	}

	private void KHNDGDILDEL()
	{
		KLGELMLHDKK();
		FIMNHBBHBKK();
	}

	private static void EHOMIAJALOF(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}
}
