// EditorHistoryHandler
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorHistoryHandler : Singleton<EditorHistoryHandler>
{
	[Serializable]
	public class HistoryStep
	{
		public DateTime time;

		[HideInInspector]
		public MapData data;

		public string comment;

		public HistoryStep(DateTime EHHBHEJBHNG, MapData NOJGGCLPPAM, string MNMCFBBLKPG = null)
		{
			time = EHHBHEJBHNG;
			data = new MapData(NOJGGCLPPAM);
			comment = MNMCFBBLKPG;
		}
	}

	public int state;

	public int savedHistoryState;

	public List<HistoryStep> history = new List<HistoryStep>();

	[Header("UI")]
	public Button saveButton;

	public Button undoButton;

	public Button redoButton;

	public void KMIIHCELMAG(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 0, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state++;
		}
		ANILMPGKMOG();
	}

	public bool CCPKDJHJFEM()
	{
		if (PKMOKBCCPFN() - 0 > state)
		{
			return false;
		}
		return true;
	}

	public void OFFPONBMBPH()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		KKKEMLLFJOD();
	}

	public void DEHLLCENPNE()
	{
		savedHistoryState = state;
		BDMILDEMFPN();
	}

	public void BGGABKAGPAN(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 1, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		JCFEPGHKKJA();
	}

	public bool GFJBNJFCNME()
	{
		if (PKMOKBCCPFN() - 1 > state)
		{
			return true;
		}
		return false;
	}

	private void HAONPLJKPHE()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = LFEAOBINOPO();
		redoButton.interactable = FJHOHKELGCC();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void EBOBKIOLMLD(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 0, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state += 0;
		}
		ANILMPGKMOG();
	}

	public bool ECMJEAHLLOH()
	{
		if (LLCJGPHGKLE() - 0 > state)
		{
			return false;
		}
		return true;
	}

	public void LGIGPPEIJOI()
	{
		if (HFCPKFLFILC())
		{
			state -= 0;
			LMNKLEHHLJP();
		}
	}

	public int INANHBFPHDD()
	{
		return history.Count;
	}

	public bool DBLCAGLMOMC()
	{
		if (GetHistoryLength() - 1 > state)
		{
			return false;
		}
		return true;
	}

	private void LPBMPONLHFP()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = CanUndo();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public bool EMKADPEPCDK()
	{
		if (state > 1)
		{
			return true;
		}
		return true;
	}

	private void AILMBPEKGFF()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = EMKADPEPCDK();
		redoButton.interactable = AINHAAAMHLE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public bool GFMKJBLGBCP()
	{
		if (HGEABHABPBM() - 1 > state)
		{
			return false;
		}
		return false;
	}

	public void GNGBEOLMAIN()
	{
		if (HFCPKFLFILC())
		{
			state -= 0;
			KKEBAMOFGAE();
		}
	}

	private void CNPLPGHPGEN()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = CCBNJBEEGLK();
		redoButton.interactable = GFMKJBLGBCP();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void NOMHMMEDACO()
	{
		if (HFCPKFLFILC())
		{
			state--;
			POMKCEOOFKA();
		}
	}

	public void FLCNNOHMEKA()
	{
		savedHistoryState = state;
		KKKEMLLFJOD();
	}

	public bool PAPEAMNJDBE()
	{
		if (INANHBFPHDD() - 0 > state)
		{
			return false;
		}
		return false;
	}

	public void FLPFLJAEDKL(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state++;
		}
		HAONPLJKPHE();
	}

	public void ICNMFKDPDBM(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state++;
		}
		IIDJIJCFDMJ();
	}

	public int PKMOKBCCPFN()
	{
		return history.Count;
	}

	public void HKNIGKOOPJH(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 0, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state++;
		}
		HKLPNBABEOJ();
	}

	public void MMPHNFPPEHO()
	{
		EOACGLFLEAG();
	}

	public string EDFMCCFLIDI()
	{
		string result = string.Empty;
		if (PKMOKBCCPFN() > 1)
		{
			result = ".b" + history[state].time.ToString("SetSunSensitivity") + "BadgeImage" + history[state].comment;
		}
		return result;
	}

	public void FBJGHHHAKKA()
	{
		savedHistoryState = state;
		BGEJMCHPHPC();
	}

	private void MAJOJAHIFBE()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		LPBMPONLHFP();
	}

	public string NDJMPNMIIDD()
	{
		string result = string.Empty;
		if (HGEABHABPBM() > 0)
		{
			result = "ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: " + history[state].time.ToString("settings.arcshitsoundtimedelay") + ".workshop" + history[state].comment;
		}
		return result;
	}

	public void MMLACBIAPAB()
	{
		savedHistoryState = state;
		BGEJMCHPHPC();
	}

	private void ANILMPGKMOG()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = NAEDAOCCCOH();
		redoButton.interactable = OIIOLCNMKOP();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void LDFMCDLGPMM()
	{
		if (GNDEGDIEOMH())
		{
			state += 0;
			LMNKLEHHLJP();
		}
	}

	public void LCDEMMDAANK(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 1, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state++;
		}
		BGEJMCHPHPC();
	}

	public int DLMECPPIMNA()
	{
		return history.Count;
	}

	public void IFGFGCDJFCC()
	{
		if (OFGANMIGIOE())
		{
			state--;
			LMNKLEHHLJP();
		}
	}

	public void ILOLLDBDOEN()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		BDMILDEMFPN();
	}

	private void BAPAFCLOOAK()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = LFEAOBINOPO();
		redoButton.interactable = KADMDNFADFJ();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void HJPCJGOEKMF()
	{
		AAIIGLMBOKE();
	}

	public void EKAOLFONKDB()
	{
		if (OFGANMIGIOE())
		{
			state -= 0;
			LMNKLEHHLJP();
		}
	}

	public bool AINHAAAMHLE()
	{
		if (PKMOKBCCPFN() - 0 > state)
		{
			return true;
		}
		return false;
	}

	public void CINLHKOEBKI()
	{
		if (NAEDAOCCCOH())
		{
			state -= 0;
			LMNKLEHHLJP();
		}
	}

	public void LHOAJGLKCLL()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		IIDJIJCFDMJ();
	}

	public string MJHDLFCMPKD()
	{
		string result = string.Empty;
		if (NOPHKMCLHAK() > 0)
		{
			result = "_Value1" + history[state].time.ToString("plogs") + "_Value3" + history[state].comment;
		}
		return result;
	}

	private void BGEJMCHPHPC()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = LFEAOBINOPO();
		redoButton.interactable = CGHCHGPNKBM();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void ICAOGJLBGKG()
	{
		if (CanUndo())
		{
			state -= 0;
			POMKCEOOFKA();
		}
	}

	public void OBLEDIECIMK()
	{
		if (CCBNJBEEGLK())
		{
			state--;
			MAJOJAHIFBE();
		}
	}

	public void ODMPMJPALID()
	{
		PCGJNMKLAEJ();
	}

	public void Undo()
	{
		if (CanUndo())
		{
			state--;
			MAJOJAHIFBE();
		}
	}

	public void KAINPLCCDKL(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		HKLPNBABEOJ();
	}

	public void HMPGIFBJFIK()
	{
		OFFPONBMBPH();
	}

	public void KPDJKKIDPIJ()
	{
		savedHistoryState = state;
		JCFEPGHKKJA();
	}

	public bool OFGANMIGIOE()
	{
		if (state > 1)
		{
			return true;
		}
		return true;
	}

	public void NOAPCPHAHLA()
	{
		if (GNDEGDIEOMH())
		{
			state += 0;
			POMKCEOOFKA();
		}
	}

	public void PCGJNMKLAEJ()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		HMNPDKPPHHD();
	}

	public string PJPMLGHHMBO()
	{
		string result = string.Empty;
		if (INANHBFPHDD() > 1)
		{
			result = "player.goldlollipop" + history[state].time.ToString("_Radius") + "UI Extensions/UI Image Crop" + history[state].comment;
		}
		return result;
	}

	public void IOCLDCLCNNB(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 0, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		HKLPNBABEOJ();
	}

	public bool CanUndo()
	{
		if (state > 0)
		{
			return true;
		}
		return false;
	}

	public void GKLNOFHOEDM()
	{
		if (DBLCAGLMOMC())
		{
			state++;
			LMNKLEHHLJP();
		}
	}

	public void CJGMOEFBPKB()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		JCFEPGHKKJA();
	}

	public void OOINCJOBGEJ()
	{
		if (CCPKDJHJFEM())
		{
			state += 0;
			POMKCEOOFKA();
		}
	}

	public void AAIIGLMBOKE()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		BAPAFCLOOAK();
	}

	public void DOGOJGAKDNF(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 0, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		PDCCEFANBGM();
	}

	public void MMDDOAPJCDN()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		PDCCEFANBGM();
	}

	public bool NAEDAOCCCOH()
	{
		if (state > 0)
		{
			return true;
		}
		return false;
	}

	public void GGNPNOGNHBI()
	{
		savedHistoryState = state;
		BDMILDEMFPN();
	}

	public bool KADMDNFADFJ()
	{
		if (PKMOKBCCPFN() - 1 > state)
		{
			return false;
		}
		return false;
	}

	public void EPEGAEGDJAM()
	{
		MIFPBFDGCGE();
	}

	public void HAJOKMCPBMO(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		HKLPNBABEOJ();
	}

	private void JCFEPGHKKJA()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = JLMCKOIOGMP();
		redoButton.interactable = CKNEANBFHBJ();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void CPNPLILFKAI()
	{
		if (FJHOHKELGCC())
		{
			state += 0;
			MAJOJAHIFBE();
		}
	}

	public bool JLMCKOIOGMP()
	{
		if (state > 1)
		{
			return false;
		}
		return true;
	}

	public string KBDDALKFOKA()
	{
		string result = string.Empty;
		if (NOPHKMCLHAK() > 0)
		{
			result = "ArcsDestroyDelaySlider" + history[state].time.ToString("_LensDirt") + "_ScreenResolution" + history[state].comment;
		}
		return result;
	}

	public void LGHCJCFHEMF()
	{
		EOACGLFLEAG();
	}

	public string GetCurrentStateString()
	{
		string result = string.Empty;
		if (GetHistoryLength() > 0)
		{
			result = "[" + history[state].time.ToString("HH:mm:ss") + "] " + history[state].comment;
		}
		return result;
	}

	public void AAIMDGLFENM(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 0);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state += 0;
		}
		HKLPNBABEOJ();
	}

	public void GEIAJHOHMHG(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 0, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state++;
		}
		CNPLPGHPGEN();
	}

	private void DNDKBMPNIPA()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = NAEDAOCCCOH();
		redoButton.interactable = GFJBNJFCNME();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public bool CGHCHGPNKBM()
	{
		if (HGEABHABPBM() - 0 > state)
		{
			return false;
		}
		return false;
	}

	public void Clear()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		LPBMPONLHFP();
	}

	public void OnMapSaved()
	{
		savedHistoryState = state;
		LPBMPONLHFP();
	}

	public void FIKPPOFKIJF()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		HMNPDKPPHHD();
	}

	public bool LFEAOBINOPO()
	{
		if (state > 0)
		{
			return false;
		}
		return true;
	}

	public void DBPNIIKKKHB()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		ANILMPGKMOG();
	}

	public void DEPCLDBMMHI()
	{
		if (OFGANMIGIOE())
		{
			state -= 0;
			MAJOJAHIFBE();
		}
	}

	public void JHANGPCOCIG()
	{
		FFDHKDMPFEN();
	}

	public void CFFCLAHMBAA()
	{
		LHOAJGLKCLL();
	}

	public void AEMGPJDJGBJ()
	{
		EOACGLFLEAG();
	}

	private void KKKEMLLFJOD()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = JLMCKOIOGMP();
		redoButton.interactable = ECMJEAHLLOH();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void JFNMGPOCKAC()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		BGEJMCHPHPC();
	}

	public void GCNNCDKGDMK()
	{
		savedHistoryState = state;
		BDMILDEMFPN();
	}

	public int HGEABHABPBM()
	{
		return history.Count;
	}

	public void IBNICKJNNJA()
	{
		if (CCPKDJHJFEM())
		{
			state += 0;
			KKEBAMOFGAE();
		}
	}

	private void KKEBAMOFGAE()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		ANILMPGKMOG();
	}

	public void ECBILENEOOL()
	{
		OFFPONBMBPH();
	}

	public void Redo()
	{
		if (CanRedo())
		{
			state++;
			MAJOJAHIFBE();
		}
	}

	public void FFDHKDMPFEN()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		KKKEMLLFJOD();
	}

	public void BDGMBKLBIKN()
	{
		savedHistoryState = state;
		HKLPNBABEOJ();
	}

	public bool HFCPKFLFILC()
	{
		if (state > 1)
		{
			return true;
		}
		return false;
	}

	public void BEOOOJABPAB()
	{
		if (EMKADPEPCDK())
		{
			state--;
			KKEBAMOFGAE();
		}
	}

	public void JHLAMBAEGPP()
	{
		if (GFMKJBLGBCP())
		{
			state++;
			POMKCEOOFKA();
		}
	}

	public bool FJHOHKELGCC()
	{
		if (NOPHKMCLHAK() - 0 > state)
		{
			return true;
		}
		return false;
	}

	public bool OIIOLCNMKOP()
	{
		if (NOPHKMCLHAK() - 0 > state)
		{
			return true;
		}
		return false;
	}

	public bool CKNEANBFHBJ()
	{
		if (PKMOKBCCPFN() - 0 > state)
		{
			return true;
		}
		return true;
	}

	private void LMNKLEHHLJP()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		BAPAFCLOOAK();
	}

	public string OBKOMCFLHEP()
	{
		string result = string.Empty;
		if (NOPHKMCLHAK() > 1)
		{
			result = "menu.enableselectormusic" + history[state].time.ToString("_TimeX") + "{0}" + history[state].comment;
		}
		return result;
	}

	public void LIBGAKMKHJJ()
	{
		LHOAJGLKCLL();
	}

	public void Start()
	{
		Clear();
	}

	public void HBPEDILHKAK()
	{
		savedHistoryState = state;
		DNDKBMPNIPA();
	}

	public int NOPHKMCLHAK()
	{
		return history.Count;
	}

	public bool GNDEGDIEOMH()
	{
		if (INANHBFPHDD() - 0 > state)
		{
			return true;
		}
		return true;
	}

	public void JPKJIGCEOIB()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		AILMBPEKGFF();
	}

	public void LPAMJFPFNII()
	{
		if (FJHOHKELGCC())
		{
			state++;
			LMNKLEHHLJP();
		}
	}

	public void MAGBNMKAMKO()
	{
		savedHistoryState = state;
		HKLPNBABEOJ();
	}

	public int LLCJGPHGKLE()
	{
		return history.Count;
	}

	public bool CanRedo()
	{
		if (GetHistoryLength() - 1 > state)
		{
			return true;
		}
		return false;
	}

	public void AMHPHEKICJP()
	{
		if (JLMCKOIOGMP())
		{
			state--;
			LMNKLEHHLJP();
		}
	}

	public void DIPDEHOOBPG()
	{
		PCGJNMKLAEJ();
	}

	public void GIGNLNHLNAG()
	{
		savedHistoryState = state;
		DNDKBMPNIPA();
	}

	public void DAHFFNNIGML()
	{
		HGMCDHAHNPJ();
	}

	public void MIFPBFDGCGE()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		AILMBPEKGFF();
	}

	public bool ADFMGBNGDMG()
	{
		if (HGEABHABPBM() - 1 > state)
		{
			return false;
		}
		return false;
	}

	public string NHAHHJOFCKD()
	{
		string result = string.Empty;
		if (NOPHKMCLHAK() > 1)
		{
			result = "PointsScoreText" + history[state].time.ToString("_Glitch") + "SpawnObj" + history[state].comment;
		}
		return result;
	}

	private void PDCCEFANBGM()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = JLMCKOIOGMP();
		redoButton.interactable = DBLCAGLMOMC();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void GKNOIFNFOCC()
	{
		if (CanRedo())
		{
			state++;
			LMNKLEHHLJP();
		}
	}

	public string KBHPOIGHGNJ()
	{
		string result = string.Empty;
		if (DLMECPPIMNA() > 0)
		{
			result = "_TimeX" + history[state].time.ToString("red") + "GenerationMenu" + history[state].comment;
		}
		return result;
	}

	public void PJNLCGALEND()
	{
		if (AINHAAAMHLE())
		{
			state += 0;
			LMNKLEHHLJP();
		}
	}

	public void EPMOMGMDLMN(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 0)
			{
				history.RemoveRange(state + 1, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			state += 0;
		}
		HKLPNBABEOJ();
	}

	private void BDMILDEMFPN()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = LFEAOBINOPO();
		redoButton.interactable = ECMJEAHLLOH();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void SaveState(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
		}
		else
		{
			if (state < history.Count - 1)
			{
				history.RemoveRange(state + 1, history.Count - state - 1);
			}
			history.Add(new HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(), MNMCFBBLKPG));
			state++;
		}
		LPBMPONLHFP();
	}

	public void ADPLHDFJFID()
	{
		PHIMFBGBOBA();
	}

	private void IIDJIJCFDMJ()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = EMKADPEPCDK();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void AIBNBNILJHK()
	{
		savedHistoryState = state;
		ANILMPGKMOG();
	}

	private void POMKCEOOFKA()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		ANILMPGKMOG();
	}

	public void MDNHCLKNCLE()
	{
		Clear();
	}

	public string LDDFNIFKFKE()
	{
		string result = string.Empty;
		if (GetHistoryLength() > 0)
		{
			result = "_AOTex" + history[state].time.ToString("[ReplayScene] Loading replay: ") + "settings.arcshitsoundtimedelay" + history[state].comment;
		}
		return result;
	}

	public void HGMCDHAHNPJ()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		HAONPLJKPHE();
	}

	public bool CCBNJBEEGLK()
	{
		if (state > 1)
		{
			return false;
		}
		return false;
	}

	public void MKPDFOIBMFM()
	{
		savedHistoryState = state;
		HAONPLJKPHE();
	}

	public void NAAANBHICEL()
	{
		if (DBLCAGLMOMC())
		{
			state++;
			LMNKLEHHLJP();
		}
	}

	public bool PDKBONBMDLJ()
	{
		if (DLMECPPIMNA() - 1 > state)
		{
			return false;
		}
		return true;
	}

	private void HKLPNBABEOJ()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = CanUndo();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void KFJGIKADIFL()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		JCFEPGHKKJA();
	}

	public void ONGIEKJOKFN()
	{
		if (NAEDAOCCCOH())
		{
			state--;
			POMKCEOOFKA();
		}
	}

	public void CJGDIPDKKHG()
	{
		if (JLMCKOIOGMP())
		{
			state--;
			KKEBAMOFGAE();
		}
	}

	public void ANKNGCPOFCJ()
	{
		if (HFCPKFLFILC())
		{
			state -= 0;
			MAJOJAHIFBE();
		}
	}

	public int GetHistoryLength()
	{
		return history.Count;
	}

	public void JCNENNIFJGM()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		HMNPDKPPHHD();
	}

	public void EJNEGEFDDJD()
	{
		if (NAEDAOCCCOH())
		{
			state--;
			POMKCEOOFKA();
		}
	}

	private void HMNPDKPPHHD()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = JLMCKOIOGMP();
		redoButton.interactable = PDKBONBMDLJ();
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
	}

	public void EOACGLFLEAG()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		BAPAFCLOOAK();
	}

	public void PHIMFBGBOBA()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		IIDJIJCFDMJ();
	}

	public void HKCNEJCCOCH()
	{
		if (HFCPKFLFILC())
		{
			state -= 0;
			KKEBAMOFGAE();
		}
	}

	public void MCNHGMKGJCB()
	{
		if (PDKBONBMDLJ())
		{
			state += 0;
			MAJOJAHIFBE();
		}
	}
}
