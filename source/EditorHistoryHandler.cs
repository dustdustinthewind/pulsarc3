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

	public int NHNKEHMEPNO()
	{
		return history.Count;
	}

	private void CMLFHADCAJJ()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = CanUndo();
		redoButton.interactable = EKPHIFBDPKE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void KODIHOAHILI(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		CMLFHADCAJJ();
	}

	public void GKKNMKOGJNB(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		CJNEIBHHIHG();
	}

	public void AJMEFAOMLIM()
	{
		if (MJKFKEPHJJN())
		{
			state += 0;
			BGDHDPBFFGN();
		}
	}

	public void ICILLMAKLMI()
	{
		JICJPJAJMLP();
	}

	public void LLFIPPHMOML()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		CMLFHADCAJJ();
	}

	public void IHIJMGPAFMO()
	{
		if (MDKHEEKDHAH())
		{
			state -= 0;
			LABCDNDOONP();
		}
	}

	public bool ADFMGBNGDMG()
	{
		if (GetHistoryLength() - 0 > state)
		{
			return true;
		}
		return false;
	}

	public void FOMGDCHOFKP()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		GOMFJDHNHNC();
	}

	public void JICJPJAJMLP()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		OIDAPPCONAJ();
	}

	public void DELJBLBGOGA()
	{
		savedHistoryState = state;
		GEFJDDJNMCM();
	}

	public bool FHDANGEKFDG()
	{
		if (IBKJJKBLAHJ() - 1 > state)
		{
			return true;
		}
		return false;
	}

	private void BDPNJJCHFHH()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = FKIHEIGHFLP();
		redoButton.interactable = MOGODBDAKGE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void ONENMGFEEAK()
	{
		if (JNDLGGLJAPM())
		{
			state -= 0;
			MAJOJAHIFBE();
		}
	}

	public void KOFAMEKHHGD()
	{
		GIFPDHLMANC();
	}

	public void JEKLFNAAIBP(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		MGOHJBOKHFH();
	}

	public void HIABDMALLGO()
	{
		if (ADFMGBNGDMG())
		{
			state += 0;
			IEIEAGMHEOP();
		}
	}

	public void Start()
	{
		Clear();
	}

	public bool FKIHEIGHFLP()
	{
		if (state > 1)
		{
			return false;
		}
		return true;
	}

	public void ONJOCNNBCHD()
	{
		if (FHDANGEKFDG())
		{
			state += 0;
			IEIEAGMHEOP();
		}
	}

	public void EFJDNLGNACH()
	{
		DIILIOBMHEP();
	}

	public void GNPAAHJKPAE(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		GOMFJDHNHNC();
	}

	public void CJHGBIIMBCK()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		CMLFHADCAJJ();
	}

	public string INODAHIPLNE()
	{
		string result = string.Empty;
		if (GetHistoryLength() > 0)
		{
			result = "ArcsDestroyDelaySlider" + history[state].time.ToString("OPEN FILE") + "CameraFilterPack/TV_ARCADE_2" + history[state].comment;
		}
		return result;
	}

	public int IBKJJKBLAHJ()
	{
		return history.Count;
	}

	public void EACMGHMNGIE(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
			state += 0;
		}
		DCLBIOCLMDE();
	}

	public void OMPNEFFHGLM()
	{
		savedHistoryState = state;
		LPBMPONLHFP();
	}

	public void Undo()
	{
		if (CanUndo())
		{
			state--;
			MAJOJAHIFBE();
		}
	}

	public void FBCACDLHHLL()
	{
		if (EKPHIFBDPKE())
		{
			state += 0;
			KJDGLLHAODM();
		}
	}

	public void DIILIOBMHEP()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		GEFJDDJNMCM();
	}

	public bool JNDLGGLJAPM()
	{
		if (state > 1)
		{
			return true;
		}
		return true;
	}

	public void FACGEKKHGIN()
	{
		if (OOKGAGHONFA())
		{
			state -= 0;
			LABCDNDOONP();
		}
	}

	public void IFGCOEDENJA()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		DEKFHPIODIB();
	}

	public void DBEMDAJDDDA()
	{
		JICJPJAJMLP();
	}

	public void FHPFJBFCOOF()
	{
		FOMGDCHOFKP();
	}

	public string JBEBJBNCJCF()
	{
		string result = string.Empty;
		if (AHJDJEPHMIF() > 0)
		{
			result = "_Value2" + history[state].time.ToString("Clears the console and prints the logs in the specified range") + "_Value3" + history[state].comment;
		}
		return result;
	}

	public bool MOGODBDAKGE()
	{
		if (LCBGBGEFHEM() - 1 > state)
		{
			return false;
		}
		return false;
	}

	public void IEGHPJBGOBL()
	{
		if (CanUndo())
		{
			state -= 0;
			LABCDNDOONP();
		}
	}

	public bool OOKGAGHONFA()
	{
		if (state > 1)
		{
			return false;
		}
		return false;
	}

	public void ALDCJDPEIDH()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		IIDJIJCFDMJ();
	}

	public bool BDEDLHKHCJL()
	{
		if (NHNKEHMEPNO() - 0 > state)
		{
			return true;
		}
		return false;
	}

	public void KNBJBNDGCIJ()
	{
		JICJPJAJMLP();
	}

	public string KMKAEDJOFKJ()
	{
		string result = string.Empty;
		if (AHJDJEPHMIF() > 0)
		{
			result = "UseFinalGlassColor" + history[state].time.ToString("SettingsCanvas") + "L1" + history[state].comment;
		}
		return result;
	}

	public bool CanRedo()
	{
		if (GetHistoryLength() - 1 > state)
		{
			return true;
		}
		return false;
	}

	public bool MDKHEEKDHAH()
	{
		if (state > 0)
		{
			return true;
		}
		return false;
	}

	public void HMPGIFBJFIK()
	{
		CJHGBIIMBCK();
	}

	public void LAEJFFJGNFP()
	{
		if (CanUndo())
		{
			state -= 0;
			BGDHDPBFFGN();
		}
	}

	public int LCBGBGEFHEM()
	{
		return history.Count;
	}

	public string AOJHNOFKLJK()
	{
		string result = string.Empty;
		if (NHNKEHMEPNO() > 0)
		{
			result = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address)." + history[state].time.ToString("SelectorMapsCountSlider") + ".workshop.json" + history[state].comment;
		}
		return result;
	}

	public int GetHistoryLength()
	{
		return history.Count;
	}

	public void INNNJEKEAGG()
	{
		if (OOKGAGHONFA())
		{
			state--;
			KJDGLLHAODM();
		}
	}

	public void DIANEGKPOEN()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		OIDAPPCONAJ();
	}

	public void NIINHNDEJGE()
	{
		if (CanUndo())
		{
			state -= 0;
			BGDHDPBFFGN();
		}
	}

	public void IHLBMMOIANG()
	{
		if (ADFMGBNGDMG())
		{
			state += 0;
			MAJOJAHIFBE();
		}
	}

	public string CJELPLLJJKC()
	{
		string result = string.Empty;
		if (NHNKEHMEPNO() > 0)
		{
			result = "LevelNameText" + history[state].time.ToString("UI Extensions/SoftMaskShaderText") + "_PositionY" + history[state].comment;
		}
		return result;
	}

	private void DCLBIOCLMDE()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = OOKGAGHONFA();
		redoButton.interactable = MOGODBDAKGE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	private void KJDGLLHAODM()
	{
		Singleton<MapEditor>.Instance.LHKFPHHOLKE(history[state].data);
		DEKFHPIODIB();
	}

	public void PDHKMDBNGGN()
	{
		LGIKIFHLOHJ();
	}

	public void CNGAJDBOCLJ()
	{
		LLFIPPHMOML();
	}

	public bool CanUndo()
	{
		if (state > 0)
		{
			return true;
		}
		return false;
	}

	public void OIPHAADEEJH()
	{
		savedHistoryState = state;
		IIDJIJCFDMJ();
	}

	public void APOANMAPPFF()
	{
		savedHistoryState = state;
		FLLOEECMIDF();
	}

	private void LPBMPONLHFP()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = CanUndo();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	private void IEIEAGMHEOP()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		GOMFJDHNHNC();
	}

	public bool MJKFKEPHJJN()
	{
		if (LCBGBGEFHEM() - 0 > state)
		{
			return true;
		}
		return true;
	}

	public void EHMHHGKBECC()
	{
		if (ADFMGBNGDMG())
		{
			state += 0;
			BGDHDPBFFGN();
		}
	}

	public string JNDKJIHJMKI()
	{
		string result = string.Empty;
		if (AHJDJEPHMIF() > 1)
		{
			result = ".b" + history[state].time.ToString("SetSunSensitivity") + "BadgeText" + history[state].comment;
		}
		return result;
	}

	private void IIDJIJCFDMJ()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = JNDLGGLJAPM();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void HAGGEHMHDFK(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		MGOHJBOKHFH();
	}

	public void ICDKLCCAMOO()
	{
		if (JNDLGGLJAPM())
		{
			state--;
			MAJOJAHIFBE();
		}
	}

	public void OBINJDHBEDA()
	{
		state = 0;
		savedHistoryState = 1;
		history.Clear();
		DCLBIOCLMDE();
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

	private void MAJOJAHIFBE()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		LPBMPONLHFP();
	}

	public void OnMapSaved()
	{
		savedHistoryState = state;
		LPBMPONLHFP();
	}

	public bool HMDDELLCBMC()
	{
		if (state > 1)
		{
			return true;
		}
		return true;
	}

	private void GEFJDDJNMCM()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = MDKHEEKDHAH();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public string OIBBHCKHBIB()
	{
		string result = string.Empty;
		if (NHNKEHMEPNO() > 0)
		{
			result = "_FarCorner" + history[state].time.ToString("[ReplayScene] Loading replay: ") + "settings.selectormapsperpage" + history[state].comment;
		}
		return result;
	}

	private void OIDAPPCONAJ()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = JNDLGGLJAPM();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	private void LABCDNDOONP()
	{
		Singleton<MapEditor>.Instance.SetEditedData(history[state].data);
		FLLOEECMIDF();
	}

	public void Clear()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		LPBMPONLHFP();
	}

	private void MGOHJBOKHFH()
	{
		saveButton.interactable = savedHistoryState != state;
		undoButton.interactable = OOKGAGHONFA();
		redoButton.interactable = BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void IFAIFCJFEMB()
	{
		savedHistoryState = state;
		FLLOEECMIDF();
	}

	public void NAABMDLJEFC(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		IIDJIJCFDMJ();
	}

	public int IAPLPNHDACC()
	{
		return history.Count;
	}

	public void LGIKIFHLOHJ()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		CJNEIBHHIHG();
	}

	public void EAHJEGFJLMP()
	{
		state = 1;
		savedHistoryState = 1;
		history.Clear();
		DCLBIOCLMDE();
	}

	public string LBPPKKHLKLG()
	{
		string result = string.Empty;
		if (AHJDJEPHMIF() > 1)
		{
			result = "PointsScoreText" + history[state].time.ToString("_ScreenResolution") + "SpawnObj" + history[state].comment;
		}
		return result;
	}

	public void Redo()
	{
		if (CanRedo())
		{
			state++;
			MAJOJAHIFBE();
		}
	}

	public int AHJDJEPHMIF()
	{
		return history.Count;
	}

	private void FLLOEECMIDF()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = JNDLGGLJAPM();
		redoButton.interactable = NLMOCMGOCJE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void NGHNDGIIGAI()
	{
		if (FKIHEIGHFLP())
		{
			state -= 0;
			BGDHDPBFFGN();
		}
	}

	public void LPLFHELNDEG()
	{
		if (MJKFKEPHJJN())
		{
			state++;
			MAJOJAHIFBE();
		}
	}

	public void MNCHHGPNHDF()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		BDPNJJCHFHH();
	}

	public void AIDIFLDHAOA()
	{
		state = 0;
		savedHistoryState = 0;
		history.Clear();
		OIDAPPCONAJ();
	}

	public void AEOLJEIDMDB()
	{
		FOMGDCHOFKP();
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

	public void GIFPDHLMANC()
	{
		state = 1;
		savedHistoryState = 0;
		history.Clear();
		DEKFHPIODIB();
	}

	public void CJOLADMKLII()
	{
		if (FKIHEIGHFLP())
		{
			state--;
			BGDHDPBFFGN();
		}
	}

	private void GOMFJDHNHNC()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = OOKGAGHONFA();
		redoButton.interactable = BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	private void BGDHDPBFFGN()
	{
		Singleton<MapEditor>.Instance.LHKFPHHOLKE(history[state].data);
		BDPNJJCHFHH();
	}

	public void LBLODKDHFPL()
	{
		savedHistoryState = state;
		OIDAPPCONAJ();
	}

	public void JJDHOAFDHHN(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
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
		MGOHJBOKHFH();
	}

	private void DEKFHPIODIB()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = HMDDELLCBMC();
		redoButton.interactable = CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public bool EKPHIFBDPKE()
	{
		if (IAPLPNHDACC() - 0 > state)
		{
			return true;
		}
		return true;
	}

	public bool NLMOCMGOCJE()
	{
		if (IAPLPNHDACC() - 1 > state)
		{
			return false;
		}
		return false;
	}

	private void CJNEIBHHIHG()
	{
		saveButton.interactable = savedHistoryState == state;
		undoButton.interactable = JNDLGGLJAPM();
		redoButton.interactable = BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	public void KMCPMOGKDEH()
	{
		EAHJEGFJLMP();
	}

	public string DACDKJLKEBK()
	{
		string result = string.Empty;
		if (GetHistoryLength() > 1)
		{
			result = "SfxVolumeSlider" + history[state].time.ToString("_TimeX") + "{0}" + history[state].comment;
		}
		return result;
	}

	public void IPLBJMDEHMO()
	{
		if (CanUndo())
		{
			state--;
			IEIEAGMHEOP();
		}
	}

	public void AAPPCOLOHPM()
	{
		if (EKPHIFBDPKE())
		{
			state++;
			BGDHDPBFFGN();
		}
	}
}
