// MapEditor
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MapEditor : Singleton<MapEditor>
{
	public enum EditorState
	{
		Init,
		MapLoaded,
		Busy
	}

	public enum EventType
	{
		Gameplay,
		Storyboard
	}

	[Serializable]
	public class EventsCanvas
	{
		public EventType forType;

		public Transform grid;

		public Transform bpmGrid;

		public Transform soundwave;
	}

	[CompilerGenerated]
	private sealed class CFBBHNAOKPA
	{
		internal string IEOKJCPAOHL;

		internal MapEditor ADPIKBBAKHP;
	}

	[CompilerGenerated]
	private sealed class NDFEKONPOMG
	{
		internal GameObject OBFJPHLBFOL;

		internal CFBBHNAOKPA KHCIOAJAKOO;

		internal void AKDOOLPMPMG()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("CameraFilterPack/Antialiasing_FXAA", true);
		}

		internal void BDGDIDPDBHG()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("NEW_ACHIEVEMENT_1_21");
		}

		internal void PCDFLCEIHFF()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_FlipAlphaMask");
		}

		internal void AEINPAGJFME()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("CameraFilterPack/FX_Ascii", true);
		}

		internal void EDGAPOPEIJF()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Connected to NameServer.");
		}

		internal void DNIMHEKGJHB()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Value2", true);
		}

		internal void DBFPGFHEGKA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_MainTex2", true);
		}

		internal void MPGGBMMPNDH()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("/../", true);
		}

		internal void GBKBDKHPLKG()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions");
		}

		internal void DKGPCPBNDPK()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("SetSatelliteSensitivity");
		}

		internal void BJMAIJDIKCN()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_History3ChromaTex");
		}

		internal void BMAOCLKPNNC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("settings.volume.sfx", true);
		}

		internal void AGFDCBCBAGI()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_ScreenResolution", true);
		}

		internal void MAGEPMCPGOC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_TimeX", true);
		}

		internal void OMBHIBNMFNB()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB(" to ", true);
		}

		internal void BBIADFAPKDL()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE(".played");
		}

		internal void LNDGINDKPFA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("_Red_G");
		}

		internal void FCAGEDLBBHD()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("0x", true);
		}

		internal void INHOEMCLAAP()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("IEnumerable", true);
		}

		internal void AEIFJLBBKBP()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("editorVolume", true);
		}

		internal void JKEDCEOCPJO()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("SlidingArea");
		}

		internal void FDAIFOAGDLA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Horizontal");
		}

		internal void FHIJCPPECHA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_Value", true);
		}

		internal void PIJAOCFAPKC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("{0}");
		}

		internal void IGFOBPKFCDJ()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("A");
		}

		internal void PBCAHKDLFPE()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Set satellite lerp speed", true);
		}

		internal void MGENGAEDACG()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("BitsData");
		}

		internal void JDELIMPGFDJ()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_MainTex2", true);
		}

		internal void BKNHHGBPLGH()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Joystick1Button4");
		}

		internal void FMIHBNPKEEO()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("_MatrixSize", true);
		}

		internal void AGJKEBOPIOC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Added GameObject to prefabDictionary: ", true);
		}

		internal void FFEGPHJKMFK()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("settings.crosshairopacity");
		}

		internal void OFHCGKJFGDI()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("[LevelEditorScene] Print Audio Wave: Done");
		}

		internal void BEBAENEJFLD()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Deleted event", true);
		}

		internal void LOEAMHGMMPK()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("value");
		}

		internal void EKHOOPGPPGE()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Bad parameters for setint! Use <key> <value>");
		}

		internal void GLHKGBNIHFH()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_Value2");
		}

		internal void LLNDDFGPOPL()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Tab2Content");
		}

		internal void FIPCLHEKKCA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ");
		}

		internal void EGKGJJGAPMN()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("SelectorMusicToggle");
		}

		internal void BFEABMIFIEE()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_LayerThickness");
		}

		internal void OLIGLEMPFOP()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_TimeX", true);
		}

		internal void FHFECFLBHMA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CurrentTimeLabel", true);
		}

		internal void MEMPOPNAEDN()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("logc");
		}

		internal void LHHFJBIAHCN()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_SceneFogMode", true);
		}

		internal void KFNBKFELFLH()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("Set sun min/max size");
		}

		internal void LJDLIIIPIIJ()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Convolved_TexelSize");
		}

		internal void JBCHBMKPDAJ()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Pop", true);
		}

		internal void JBAJEMGOPDL()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("mapselector.tags.", true);
		}

		internal void OFLDIMDDLHM()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Drop_Near", true);
		}

		internal void KGKMOLCPDIH()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CameraFilterPack/Distortion_Twist_Square", true);
		}

		internal void EFAPFFFGOOA()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("n/a", true);
		}

		internal void HBJFIOJFBHC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("CameraFilterPack/Blend2Camera_Screen", true);
		}

		internal void PKAPLCFHDOC()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("0,7,true,0", true);
		}

		internal void FJDBPPKABJE()
		{
			KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("addNewButton");
		}
	}

	public Text currentBPMText;

	public InputField currentBpmInputField;

	public InputField currentBpmOffsetInputField;

	public Toggle useBpmToggle;

	public float BPM = 120f;

	public bool useBPMSnap = true;

	public float BPMOffset;

	public int BPMSplit = 4;

	[Header("System")]
	public AudioSampler audioSampler;

	public EditorState currentState;

	public GameObject eventsContainer;

	public List<EventsCanvas> eventsCanvases;

	[Header("UI")]
	public GameObject volumePanel;

	public GameObject topMenuPanel;

	public Text statusBarText;

	public Text currentTimeText;

	public Slider currentTimeSlider;

	public Slider zoomSlider;

	public GameObject configCanvas;

	public GameObject tagsScrollRectContent;

	public GameObject unlockConditionContent;

	public GameObject resourcesScrollRectContent;

	public GameObject eventConfigCanvas;

	[Header("References")]
	public Sprite playImage;

	public Sprite pauseImage;

	public GameObject eventGameObject;

	public GameObject gridGameObject;

	public GameObject bpmGridGameObject;

	public GameObject caretGameObject;

	public GameObject soundWaveGameObject;

	public GameObject tagElement;

	public GameObject tagHeaderElement;

	public GameObject unlockConditionElement;

	public GameObject addNewUnlockConditionElement;

	public GameObject resourcesElement;

	[HideInInspector]
	public float currentTime;

	[HideInInspector]
	public int currentEventsCanvasId;

	[HideInInspector]
	public bool isPlaying;

	[HideInInspector]
	public bool isRecording;

	[HideInInspector]
	public GameObject editingEventGO;

	private string CAFHKDIIDEE;

	[SerializeField]
	private MapData editedMapData;

	private bool DMOOGKMALBD;

	private GameObject AEAKHCLJFDH;

	private CustomEventEditor GPNKNBLBFOD;

	private bool PAODIJKEBCA;

	private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

	protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

	protected CallResult<SubmitItemUpdateResult_t> KAPDFIOHNGL;

	[CompilerGenerated]
	private static Func<MapEvent, bool> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<MapEvent, float> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Func<MapEvent, float> HCLEECLNOEA;

	[CompilerGenerated]
	private static Func<MapEvent, float> ADLAKIHINOM;

	[CompilerGenerated]
	private static Func<float, float> KCAPKHIJOHL;

	public void OnCopyButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
		}
	}

	public void SetCustomBPM(string DPNHODJHGJL)
	{
		try
		{
			float bPM = float.Parse(DPNHODJHGJL, NumberStyles.Float);
			SetBPM(bPM);
		}
		catch (Exception)
		{
		}
	}

	public MapData GetEditedMapDataObj()
	{
		return editedMapData;
	}

	public void Reset()
	{
		Debug.Log("[MapEditor] Reset");
		Singleton<EditorHistoryHandler>.Instance.Clear();
		currentState = EditorState.Init;
		DMOOGKMALBD = false;
		CAFHKDIIDEE = null;
		editedMapData = null;
		isRecording = false;
		PAODIJKEBCA = false;
		isPlaying = false;
		currentTime = 0f;
		currentEventsCanvasId = 0;
		GPNKNBLBFOD = GetComponent<CustomEventEditor>();
		editingEventGO = null;
		AEAKHCLJFDH = null;
		DropDownList component = eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
		component.Start();
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(eventConfigCanvas, false, null, true, 0f));
		UpdateTopMenu();
		UpdateBottomBar();
		currentTimeText.text = "0.00:0.00";
	}

	public void FindNearestEvent(bool OAKJLAFMOHO = false)
	{
		editingEventGO = KIDAPPHEPBE();
		if ((bool)editingEventGO && (OAKJLAFMOHO || editingEventGO != AEAKHCLJFDH))
		{
			GPNKNBLBFOD.Load(editingEventGO.GetComponent<EditorEvent>());
			AEAKHCLJFDH = editingEventGO;
		}
	}

	public IEnumerator ShowOutdatedMapWarning()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#updateoutdatedmap", "#yes"));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>()
				.value = MapData.GetLastConfigVersion();
			yield return StartCoroutine(Save());
			IIIGPJIJHKD(CAFHKDIIDEE);
		}
		Singleton<SaveSystem>.Instance.SetBool("maps." + CAFHKDIIDEE + ".sawoutdatedmessage", true);
	}

	public void OnAboutButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("MapEditor v." + Helpers.GetGameVersion() + "\nCreated by Oxy949", "#ok", null);
	}

	public void ScrollTime(float EHHBHEJBHNG)
	{
		Singleton<UI>.Instance.ClearSelection();
		NLJJIAIEIDH(EHHBHEJBHNG);
	}

	public void AddRecordedEventGO(string NOJGGCLPPAM, int PGJECADBIOI, float NPAFFMIFMCD = -1f)
	{
		if (editedMapData.handCount < 2)
		{
			string item = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			AddNewEvent((!(NPAFFMIFMCD < 0f)) ? NPAFFMIFMCD : currentTime, new List<string> { "SpawnObj", item });
		}
		else
		{
			string text = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				text = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				text = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				text = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				text = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			AddNewEvent((!(NPAFFMIFMCD < 0f)) ? NPAFFMIFMCD : currentTime, new List<string>
			{
				"SpawnObj",
				text + "," + PGJECADBIOI
			});
		}
	}

	public IEnumerator UpdateMapAssets(string BNJFKKGOACF, string EAGJAOLHFGB, string FLMDNANCAAC, string CAFHKDIIDEE, bool MEPPNHMBCFL = false, int ACODLKJMCJF = 1)
	{
		Debug.Log("[MapEditor] Updating map assets");
		string text = BNJFKKGOACF + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			FileInfo fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, BNJFKKGOACF + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(BNJFKKGOACF + "/icon" + fileInfo.Extension, BNJFKKGOACF + "/icon" + fileInfo.Extension, true));
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(BNJFKKGOACF + "/icon" + fileInfo.Extension);
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			FileInfo fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile);
			File.Copy(FLMDNANCAAC, BNJFKKGOACF + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile = "music" + fileInfo2.Extension;
			float num = 0f;
			string fullName = new FileInfo(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile).FullName;
			yield return StartCoroutine(Helpers.GetAudioLength(fullName, true));
			num = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicTime = num;
		}
		if (!string.IsNullOrEmpty(CAFHKDIIDEE) && MEPPNHMBCFL)
		{
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.name = CAFHKDIIDEE;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.configVersion = MapData.GetLastConfigVersion();
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapperSteamID = SteamUser.GetSteamID().m_SteamID;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.handCount = ACODLKJMCJF;
		}
		string nOJGGCLPPAM = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(BNJFKKGOACF);
		yield return StartCoroutine(Helpers.SaveFile(BNJFKKGOACF + "/" + Helpers.levelConfigFileName, nOJGGCLPPAM, true));
	}

	public void UpdateBottomBar()
	{
		string text = string.Empty;
		if (!IsMapLoaded())
		{
			if ((bool)LocalizationService.Instance && LocalizationService.Instance.inited)
			{
				text = LocalizationService.Instance.GetLocalizatedText("#mapnotloaded");
			}
		}
		else
		{
			text = CAFHKDIIDEE + "  |  " + Singleton<EditorHistoryHandler>.Instance.GetCurrentStateString() + "  |  Events Count: " + editedMapData.events.Count;
		}
		statusBarText.text = text;
		if ((bool)GameObject.Find("PlayButton"))
		{
			GameObject.Find("PlayButton").GetComponent<Image>().sprite = ((!audioSampler.audioSources[1].isPlaying) ? playImage : pauseImage);
		}
		if ((bool)GameObject.Find("RecordButton"))
		{
			Button component = GameObject.Find("RecordButton").GetComponent<Button>();
			ColorBlock colors = component.colors;
			colors.normalColor = (isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("#8E8E8EFF");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("#C8C8C8FF");
			component.colors = colors;
		}
	}

	public void ToggleVolume()
	{
		DMOOGKMALBD = !DMOOGKMALBD;
		volumePanel.GetComponentInChildren<Slider>().value = GetComponent<VolumeSettings>().GetEditorVolume();
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(volumePanel, DMOOGKMALBD));
		Singleton<UI>.Instance.ClearSelection();
	}

	public void TogglePlay()
	{
		Singleton<UI>.Instance.ClearSelection();
		isPlaying = !isPlaying;
		audioSampler.audioSources[1].time = currentTime;
		if (isPlaying)
		{
			audioSampler.audioSources[1].Play();
		}
		else
		{
			audioSampler.audioSources[1].Pause();
		}
		UpdateBottomBar();
	}

	private IEnumerator GMKAIGKBLAA()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(0, -1, new List<int> { 0, 2, 3, 4 }, false));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			StartCoroutine(NODFLLCDCOH(Singleton<MapsListSelector>.Instance.result));
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
		}
	}

	public IEnumerator GPEMLDLGEHG(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath + "/" + fileInfo.Name;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			editedMapData.levelResources.Add(item);
			yield return StartCoroutine(Save(false));
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE)));
			ReloadResList();
		}
	}

	private static bool HGPHALHGDDD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "_Value2";
	}

	public void OnPublichButton()
	{
		if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
		{
			StartCoroutine(ONJIIJDEFOM());
			return;
		}
		RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#" + actveBan.bantype.ToString().ToLower() + "received</b>\n#reason: " + actveBan.reason + "\n\n#" + actveBan.bantype.ToString().ToLower() + "restrictions\n\n#until: " + ((!(actveBan.until == "-1")) ? actveBan.until : "#forever"), "#ok", null);
	}

	private void PFIPOJIIODP(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
			return;
		}
		switch (NPIKJHPJIEA.m_eResult)
		{
		case EResult.k_EResultInsufficientPrivilege:
			Debug.Log("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(");
			break;
		case EResult.k_EResultTimeout:
			Debug.Log("[LevelEditorScene] Error: Timeout :S");
			break;
		case EResult.k_EResultNotLoggedOn:
			Debug.Log("[LevelEditorScene] Error: You're not logged into Steam!");
			break;
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("[MapEditor] Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath;
			StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			StartCoroutine(KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "Created"));
		}
	}

	private void HDMEKGJCKMG(string NBGPBKCPFDN)
	{
		IIIGPJIJHKD(NBGPBKCPFDN);
	}

	private void FAGPOJDCKEC(float EHHBHEJBHNG)
	{
		if (useBPMSnap)
		{
			EHHBHEJBHNG = GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string> { "Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: " });
		GameObject gameObject = UnityEngine.Object.Instantiate(eventGameObject);
		gameObject.name = "_AdaptionSpeed";
		gameObject.transform.SetParent(eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().FMGBIHDGKBI();
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_EmissionGain", true);
		UpdateBottomBar();
		FindNearestEvent(true);
	}

	public IEnumerator ConfirmExiting()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#exitmapeditor", "#yes"));
		if (Singleton<MessageBoxPanel>.Instance.result != 1)
		{
			yield break;
		}
		if (!IsMapLoaded())
		{
			Time.timeScale = 1f;
			ResourcesManager.UnloadResources();
			SceneManager.LoadScene("MenuScene");
			yield break;
		}
		if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapchanges?", "#yes", null, "#no"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Save());
			}
		}
		Time.timeScale = 1f;
		ResourcesManager.UnloadResources();
		SceneManager.LoadScene("MenuScene");
	}

	private IEnumerator NODFLLCDCOH(string JMMILEFMACB)
	{
		string text = JMMILEFMACB + "_copy" + UnityEngine.Random.Range(1000000, 10000000);
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Singleton<MapsSystem>.Instance.GetMapData(JMMILEFMACB).fullLevelPath, Helpers.GetDirectory("Editor/" + text), true);
			string text2 = Helpers.GetDirectory("Editor/" + text) + "/" + Helpers.workshopConfigFileName;
			if (new FileInfo(text2).Exists)
			{
				File.Delete(text2);
			}
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text3 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text3);
			Debug.Log("[MapEditor] Importing map: " + text3);
			yield return StartCoroutine(UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), null, null, text3));
			IIIGPJIJHKD(text3);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null);
		}
	}

	public GameObject AddNewEvent(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (useBPMSnap)
		{
			EHHBHEJBHNG = GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate(eventGameObject);
		gameObject.name = "event";
		gameObject.transform.SetParent(eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.SaveState("Added event");
			UpdateBottomBar();
			FindNearestEvent(true);
		}
		return gameObject;
	}

	public void SetBPM(float DPNHODJHGJL)
	{
		BPM = DPNHODJHGJL;
		DPGILDLHMLM();
	}

	[CompilerGenerated]
	private static float NMNLKCNHNIN(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	public void OnDeleteButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count <= 0)
		{
			return;
		}
		foreach (GameObject selectedunit in Singleton<EditorArcsSelector>.Instance.selectedunits)
		{
			UnityEngine.Object.Destroy(selectedunit);
		}
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events");
	}

	public void OnMapResourcesButton()
	{
		currentState = EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("ResourcesConfig");
	}

	private IEnumerator DGJDBEHHFCB()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int> { 1 }, false));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
		}
	}

	[CompilerGenerated]
	private static bool IFMCPCOBNNH(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SetSpeed";
	}

	public void OnFastVideoButton()
	{
		string nBEBMKFPBEP = "https://www.youtube.com/watch?v=cDVXukrKo74";
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
	}

	public void SetBPMOffsetText(string DPNHODJHGJL)
	{
		BPMOffset = float.Parse(DPNHODJHGJL);
		DPGILDLHMLM();
	}

	public void SetEditedData(MapData NOJGGCLPPAM)
	{
		Singleton<EditorArcsSelector>.Instance.ClearSelection();
		editedMapData = new MapData(NOJGGCLPPAM);
		configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>()
			.text = editedMapData.name;
		configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>()
			.text = editedMapData.info;
		configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>()
			.text = editedMapData.moreInfoURL;
		configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>()
			.minValue = 1f;
		configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>()
			.maxValue = MapData.GetLastConfigVersion();
		configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>()
			.value = editedMapData.configVersion;
		configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>()
			.value = (int)editedMapData.speed;
		configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>()
			.value = editedMapData.lives;
		configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>()
			.value = editedMapData.maxLives;
		configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>()
			.value = editedMapData.handCount;
		configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>()
			.value = editedMapData.environmentType;
		configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>()
			.isOn = editedMapData.hidden;
		GameObject gameObject = tagsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "tagElement";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Toggle>().isOn = editedMapData.tags.Contains(specialTag);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		if (Helpers.specialTags.Count > 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagHeaderElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "tagElement";
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.GetComponentInChildren<Text>().text = " ";
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject4 = UnityEngine.Object.Instantiate(tagElement);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.name = "tagElement";
			gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject4.GetComponent<Toggle>().isOn = editedMapData.tags.Contains(tag);
			gameObject4.GetComponentInChildren<Text>().text = tag;
		}
		PLICILPAOJJ();
		ReloadResList();
		if (editedMapData.configVersion >= 3 && !string.IsNullOrEmpty(editedMapData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(editedMapData.e, Singleton<SaveSystem>.Instance.folder));
				editedMapData.events.AddRange(eData.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerator enumerator3 = eventsContainer.transform.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				Transform transform = (Transform)enumerator3.Current;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator3 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (MapEvent @event in editedMapData.events)
		{
			GameObject gameObject5 = UnityEngine.Object.Instantiate(eventGameObject);
			gameObject5.transform.SetParent(eventsContainer.transform);
			gameObject5.GetComponent<EditorEvent>().mapEvent = @event;
			gameObject5.GetComponent<EditorEvent>().UpdateEvent();
			gameObject5.name = "event";
		}
		foreach (float checkpoint in editedMapData.checkpoints)
		{
			float eHHBHEJBHNG = checkpoint;
			GameObject gameObject6 = UnityEngine.Object.Instantiate(eventGameObject);
			gameObject6.transform.SetParent(eventsContainer.transform);
			gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(eHHBHEJBHNG, new List<string> { "checkpoint" });
			gameObject6.GetComponent<EditorEvent>().UpdateEvent();
			gameObject6.name = "checkpoint";
		}
		GPNKNBLBFOD.StopEditing();
		UpdateBottomBar();
		FindNearestEvent(true);
	}

	public void SwichCanvas()
	{
		currentEventsCanvasId++;
		if (currentEventsCanvasId >= eventsCanvases.Count)
		{
			currentEventsCanvasId = 0;
		}
		if (eventConfigCanvas.activeSelf)
		{
			FindNearestEvent();
		}
	}

	public void SetBPMText(string DPNHODJHGJL)
	{
		SetBPM(float.Parse(DPNHODJHGJL));
	}

	public void ToggleRecord()
	{
		Singleton<UI>.Instance.ClearSelection();
		isRecording = !isRecording;
		UpdateBottomBar();
	}

	public void OnAddButton(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			if (eventsCanvases[currentEventsCanvasId].forType == EventType.Gameplay)
			{
				AddNewEvent(currentTime, new List<string> { "SpawnObj", "[Up]" });
			}
			else
			{
				AddNewEvent(currentTime, new List<string> { "ShowTitle", ",0" });
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			AJEFOEJANDB(currentTime);
		}
	}

	public void OnNewMapButton()
	{
		Singleton<UI>.Instance.SwitchView("MapCreationCanvas");
	}

	public string GetMapID()
	{
		return CAFHKDIIDEE;
	}

	private IEnumerator AMAENBAABIN()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int> { 1 }, false));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
		}
	}

	private IEnumerator IEJIFEMNJCJ()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(0, -1, new List<int> { 0, 2, 3, 4 }, false));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			StartCoroutine(NODFLLCDCOH(Singleton<MapsListSelector>.Instance.result));
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
		}
	}

	private void EHEAELMGGIH()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!GPNKNBLBFOD.isEditing && currentState == EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
				{
					zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 0.2f;
				}
				else
				{
					NLJJIAIEIDH((0f - Input.mouseScrollDelta.y) * Camera.main.orthographicSize * 0.2f, false);
				}
			}
			if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl) && !flag)
			{
				if (Input.GetKeyDown(KeyCode.Space))
				{
					TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.R))
				{
					ToggleRecord();
				}
				if (Input.GetKeyDown(KeyCode.Delete))
				{
					OnDeleteButton();
				}
				if (Input.GetKeyDown(KeyCode.G))
				{
					Slowmo();
				}
				if (Input.GetKeyDown(KeyCode.B))
				{
					SetBPMEnabled(!useBPMSnap);
					useBpmToggle.isOn = useBPMSnap;
				}
				if (Input.GetKeyDown(KeyCode.H))
				{
					SpeedUp();
				}
				if (Input.GetKeyDown(KeyCode.Tab))
				{
					SwichCanvas();
				}
			}
		}
		if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Singleton<EditorHistoryHandler>.Instance.Undo();
			}
			if (Input.GetKeyDown(KeyCode.Y))
			{
				Singleton<EditorHistoryHandler>.Instance.Redo();
			}
			if (currentState == EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown(KeyCode.A))
				{
					Singleton<EditorArcsSelector>.Instance.SelectAll();
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
				}
				if (Input.GetKeyDown(KeyCode.V))
				{
					Singleton<EditorArcsSelector>.Instance.PasteFromMemory(currentTime);
				}
				if (Input.GetMouseButtonDown(2))
				{
					SetZoom(5f);
				}
				if (Input.GetKeyDown(KeyCode.E))
				{
					OnEventConfigButton();
				}
			}
		}
		if (isRecording || GPNKNBLBFOD.isEditing || flag)
		{
			return;
		}
		if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				OnAddButton(0);
			}
			if (Input.GetKeyDown(KeyCode.C))
			{
				OnAddButton(1);
			}
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			NLJJIAIEIDH(-0.1f * Camera.main.orthographicSize, false);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			NLJJIAIEIDH(0.1f * Camera.main.orthographicSize, false);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow) && currentEventsCanvasId < eventsCanvases.Count - 1)
		{
			currentEventsCanvasId++;
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent();
			}
		}
		if (Input.GetKeyDown(KeyCode.DownArrow) && currentEventsCanvasId > 0)
		{
			currentEventsCanvasId--;
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent();
			}
		}
	}

	public void OnCreateNewMapButton()
	{
		StartCoroutine(OECGEKPJPCB());
	}

	public MapData GetEditedData(bool KIIAKJPJDKB = true)
	{
		editedMapData.name = configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>()
			.text;
		editedMapData.info = configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>()
			.text;
		editedMapData.moreInfoURL = configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>()
			.text;
		editedMapData.speed = (int)configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>()
			.value;
		editedMapData.configVersion = (int)configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>()
			.value;
		editedMapData.lives = (int)configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>()
			.value;
		editedMapData.maxLives = (int)configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>()
			.value;
		editedMapData.handCount = (int)configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>()
			.value;
		editedMapData.environmentType = (int)configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>()
			.value;
		editedMapData.hidden = configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>()
			.isOn;
		if (KIIAKJPJDKB)
		{
			editedMapData.musicTime = audioSampler.audioSources[1].clip.length;
		}
		editedMapData.tags = new List<string>();
		GameObject gameObject = tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		foreach (Toggle toggle in componentsInChildren)
		{
			if (toggle.isOn)
			{
				editedMapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (editedMapData.handCount == 1)
		{
			editedMapData.tags.Add("OneHand");
		}
		else if (editedMapData.handCount == 2)
		{
			editedMapData.tags.Add("TwoHands");
		}
		editedMapData.unlockConditions = new List<string>();
		gameObject = unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		foreach (InputField inputField in componentsInChildren2)
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				editedMapData.unlockConditions.Add(inputField.text);
			}
		}
		editedMapData.events.Clear();
		if (editedMapData.configVersion >= 3)
		{
			MapData.EData eData = new MapData.EData();
			eData.events = new List<MapEvent>();
			for (int k = 0; k < eventsContainer.transform.childCount; k++)
			{
				if (eventsContainer.transform.GetChild(k).name == "event")
				{
					MapEvent mapEvent = new MapEvent(eventsContainer.transform.GetChild(k).GetComponent<EditorEvent>().mapEvent);
					if (Helpers.IsStoryboardEvent(mapEvent.data[0]))
					{
						editedMapData.events.Add(mapEvent);
					}
					else
					{
						eData.events.Add(mapEvent);
					}
				}
			}
			editedMapData.events = editedMapData.events.OrderBy((MapEvent HPHENPOHOMK) => HPHENPOHOMK.time).ToList();
			eData.events = eData.events.OrderBy((MapEvent HPHENPOHOMK) => HPHENPOHOMK.time).ToList();
			editedMapData.e = Console.Log(JsonConvert.SerializeObject(eData), Singleton<SaveSystem>.Instance.folder);
		}
		else
		{
			for (int l = 0; l < eventsContainer.transform.childCount; l++)
			{
				if (eventsContainer.transform.GetChild(l).name == "event")
				{
					MapEvent item = new MapEvent(eventsContainer.transform.GetChild(l).GetComponent<EditorEvent>().mapEvent);
					editedMapData.events.Add(item);
				}
			}
			editedMapData.events = editedMapData.events.OrderBy((MapEvent HPHENPOHOMK) => HPHENPOHOMK.time).ToList();
			editedMapData.e = string.Empty;
		}
		editedMapData.checkpoints.Clear();
		for (int m = 0; m < eventsContainer.transform.childCount; m++)
		{
			if (eventsContainer.transform.GetChild(m).name == "checkpoint")
			{
				editedMapData.checkpoints.Add(new MapEvent(eventsContainer.transform.GetChild(m).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		editedMapData.checkpoints = editedMapData.checkpoints.OrderBy((float HPHENPOHOMK) => HPHENPOHOMK).ToList();
		return editedMapData;
	}

	public void Slowmo()
	{
		audioSampler.audioSources[1].pitch -= 0.25f;
		if (audioSampler.audioSources[1].pitch < 0.25f)
		{
			audioSampler.audioSources[1].pitch = 0.25f;
		}
	}

	public void OnSaveButton()
	{
		StartCoroutine(Save());
	}

	public void Update()
	{
		if (!PAODIJKEBCA && Input.GetKeyDown(KeyCode.Escape))
		{
			OnExitButton();
		}
		if (PAODIJKEBCA)
		{
			ulong punBytesProcessed;
			ulong punBytesTotal;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(FHKGDJDOKNB, out punBytesProcessed, out punBytesTotal);
			float iADPPJHIMBG = (float)punBytesProcessed / (float)punBytesTotal;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Committing changes...", "PLEASE WAIT", null, false, true, iADPPJHIMBG);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null);
				PAODIJKEBCA = false;
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading preview image", "PLEASE WAIT", null, false, true, iADPPJHIMBG);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading content", "PLEASE WAIT", null, false, true, iADPPJHIMBG);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing configuration", "PLEASE WAIT", null, false, true, iADPPJHIMBG);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing content", "PLEASE WAIT", null, false, true, iADPPJHIMBG);
				break;
			}
		}
		if (!IsMapLoaded())
		{
			currentTimeText.text = "0.00/0.00";
			return;
		}
		currentTimeText.text = currentTime.ToString("0.00") + "/" + audioSampler.audioSources[1].clip.length.ToString("0.00");
		currentTimeSlider.value = currentTime;
		if (isPlaying)
		{
			if (audioSampler.audioSources[1].isPlaying)
			{
				currentTime = audioSampler.audioSources[1].time;
				if (eventConfigCanvas.activeSelf)
				{
					FindNearestEvent();
				}
			}
			else
			{
				isPlaying = false;
				UpdateBottomBar();
			}
		}
		EHEAELMGGIH();
	}

	public void OnEventConfigButton()
	{
		bool flag = !eventConfigCanvas.activeSelf;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(eventConfigCanvas, flag));
		if (flag)
		{
			FindNearestEvent();
			return;
		}
		GPNKNBLBFOD.StopEditing();
		Singleton<UI>.Instance.ClearSelection();
	}

	[CompilerGenerated]
	private static float LPLFCLBJPEI(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	public void OnPasteButton()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.PasteFromMemory(currentTime);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events");
	}

	private IEnumerator FLFAONNOBFL()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int aCODLKJMCJF = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return StartCoroutine(UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, aCODLKJMCJF));
			IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null);
		}
	}

	public float GetSnappedBPM(float GEMDHBEGEFH)
	{
		if (useBPMSnap)
		{
			bool flag = true;
			float result = 0f;
			float num = 0f;
			for (int i = 0; (float)i <= (float)Mathf.CeilToInt(editedMapData.musicTime) * (BPM * (float)BPMSplit / 60f); i++)
			{
				float num2 = BPMOffset + (float)i * (60f / (BPM * (float)BPMSplit));
				if (flag)
				{
					result = num2;
					num = Mathf.Abs(GEMDHBEGEFH - num2);
					flag = false;
				}
				if (Mathf.Abs(GEMDHBEGEFH - num2) < num)
				{
					result = num2;
					num = Mathf.Abs(GEMDHBEGEFH - num2);
				}
			}
			return result;
		}
		return GEMDHBEGEFH;
	}

	public void SetBPMEnabled(bool DPNHODJHGJL)
	{
		useBPMSnap = DPNHODJHGJL;
		DPGILDLHMLM();
	}

	public GameObject HBLICNDEMAK(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (useBPMSnap)
		{
			EHHBHEJBHNG = GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate(eventGameObject);
		gameObject.name = "Joystick1Button7";
		gameObject.transform.SetParent(eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("#tryagain", true);
			UpdateBottomBar();
			FindNearestEvent();
		}
		return gameObject;
	}

	private void BLLONNLMMNA()
	{
		string nBEBMKFPBEP = Singleton<GameManager>.Instance.CreateServerURL("uploads/Intralism/mods_terms.pdf");
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
	}

	public void LHKFPHHOLKE(MapData NOJGGCLPPAM)
	{
		Singleton<EditorArcsSelector>.Instance.ClearSelection();
		editedMapData = new MapData(NOJGGCLPPAM);
		configCanvas.transform.Find("' found!").Find("LevelEditor/patterns").GetComponent<InputField>()
			.text = editedMapData.name;
		configCanvas.transform.Find("_Value").Find("F3").GetComponent<InputField>()
			.text = editedMapData.info;
		configCanvas.transform.Find("Set satellite audio input").Find("Error: you cannot read this stream that you are writing!").GetComponent<InputField>()
			.text = editedMapData.moreInfoURL;
		configCanvas.transform.Find("_OcclusionTexture").Find("PointsScoreText").GetComponent<Slider>()
			.minValue = 1738f;
		configCanvas.transform.Find("mapselector.filter.favoriteonly").Find("Remove Environment Object").GetComponent<Slider>()
			.maxValue = MapData.GAEEAAPAIAI();
		configCanvas.transform.Find(". MasterClient: ").Find("_TimeX").GetComponent<Slider>()
			.value = editedMapData.configVersion;
		configCanvas.transform.Find("</color>").Find("_DistortionWave").GetComponent<Slider>()
			.value = (int)editedMapData.speed;
		configCanvas.transform.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D").Find("_Blue_B").GetComponent<Slider>()
			.value = editedMapData.lives;
		configCanvas.transform.Find("Source Object: ").Find(" has been disabled as it's not supported on the current platform.").GetComponent<Slider>()
			.value = editedMapData.maxLives;
		configCanvas.transform.Find("closed").Find(" By: ").GetComponent<Slider>()
			.value = editedMapData.handCount;
		configCanvas.transform.Find("Right Stick Click").Find("/Saved Games/").GetComponent<Slider>()
			.value = editedMapData.environmentType;
		configCanvas.transform.Find("/").Find("Horizontal").GetComponent<Toggle>()
			.isOn = editedMapData.hidden;
		GameObject gameObject = tagsScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "_Blend";
			gameObject2.transform.localScale = new Vector3(1153f, 1542f, 1375f);
			gameObject2.GetComponent<Toggle>().isOn = editedMapData.tags.Contains(specialTag);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		if (Helpers.specialTags.Count > 1)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagHeaderElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "Horizontal";
			gameObject3.transform.localScale = new Vector3(815f, 289f, 206f);
			gameObject3.GetComponentInChildren<Text>().text = "GlassesColor2";
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject4 = UnityEngine.Object.Instantiate(tagElement);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.name = "VIGNETTE_DESAT";
			gameObject4.transform.localScale = new Vector3(615f, 918f, 969f);
			gameObject4.GetComponent<Toggle>().isOn = editedMapData.tags.Contains(tag);
			gameObject4.GetComponentInChildren<Text>().text = tag;
		}
		PLICILPAOJJ();
		ReloadResList();
		if (editedMapData.configVersion >= 2 && !string.IsNullOrEmpty(editedMapData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(editedMapData.e, Singleton<SaveSystem>.Instance.folder));
				editedMapData.events.AddRange(eData.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerator enumerator3 = eventsContainer.transform.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				Transform transform = (Transform)enumerator3.Current;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator3 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (MapEvent @event in editedMapData.events)
		{
			GameObject gameObject5 = UnityEngine.Object.Instantiate(eventGameObject);
			gameObject5.transform.SetParent(eventsContainer.transform);
			gameObject5.GetComponent<EditorEvent>().mapEvent = @event;
			gameObject5.GetComponent<EditorEvent>().NJDJHMPAIFE();
			gameObject5.name = "downloading";
		}
		foreach (float checkpoint in editedMapData.checkpoints)
		{
			float eHHBHEJBHNG = checkpoint;
			GameObject gameObject6 = UnityEngine.Object.Instantiate(eventGameObject);
			gameObject6.transform.SetParent(eventsContainer.transform);
			gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(eHHBHEJBHNG, new List<string> { "Object ID. Case-Sensitive" });
			gameObject6.GetComponent<EditorEvent>().UpdateEvent();
			gameObject6.name = ": ";
		}
		GPNKNBLBFOD.MABHOELCKCO();
		UpdateBottomBar();
		FindNearestEvent();
	}

	public void OnLicenceButton()
	{
		BLLONNLMMNA();
	}

	private void DPGILDLHMLM()
	{
		currentBPMText.text = LocalizationService.Instance.GetLocalizatedText("#currentbpm: ");
		currentBpmOffsetInputField.text = string.Empty + BPMOffset;
		currentBpmInputField.text = string.Empty + BPM;
		foreach (EventsCanvas eventsCanvase in eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvase.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Transform transform = (Transform)enumerator2.Current;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator2 as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (!useBPMSnap)
		{
			return;
		}
		for (int i = 0; (float)i <= (float)Mathf.CeilToInt(editedMapData.musicTime) * (BPM * (float)BPMSplit / 60f); i++)
		{
			foreach (EventsCanvas eventsCanvase2 in eventsCanvases)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(bpmGridGameObject);
				gameObject.transform.SetParent(eventsCanvase2.bpmGrid);
				gameObject.transform.localPosition = new Vector3(BPMOffset + (float)i * (60f / (BPM * (float)BPMSplit)), 0f, 0f);
				gameObject.name = "bpmgrid";
			}
		}
	}

	private IEnumerator KGCHKEGFNHI(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath;
		string hAEBGHHMEBH = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(hAEBGHHMEBH, true));
		UGCUpdateHandle_t uGCUpdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510u, JMMILEFMACB);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE);
		SteamUGC.SetItemTitle(uGCUpdateHandle_t, mapData.mapData.name);
		SteamUGC.SetItemDescription(uGCUpdateHandle_t, mapData.mapData.info);
		SteamUGC.SetItemVisibility(uGCUpdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(uGCUpdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(uGCUpdateHandle_t, fullLevelPath + "/" + mapData.mapData.iconFile);
		List<string> tags = mapData.mapData.tags;
		SteamUGC.SetItemTags(uGCUpdateHandle_t, tags);
		PAODIJKEBCA = true;
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(uGCUpdateHandle_t, GIGBCMLIKKE);
		FHKGDJDOKNB = uGCUpdateHandle_t;
		KAPDFIOHNGL.Set(hAPICall);
	}

	public void OnMapConfigButton()
	{
		currentState = EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("MapConfig");
	}

	private IEnumerator PPEKKHNBMIH()
	{
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("StartCanvas");
	}

	public void OnMapStatsButton()
	{
		MapData editedData = GetEditedData();
		int mapMaxScore = Helpers.GetMapMaxScore(editedData);
		float mapDifficulty = Helpers.GetMapDifficulty(editedData);
		if (editedData.configVersion >= 3 && !string.IsNullOrEmpty(editedData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(editedData.e, Singleton<SaveSystem>.Instance.folder));
				editedData.events.AddRange(editedData.events);
			}
			catch (Exception)
			{
			}
		}
		float num = editedData.speed;
		float num2 = editedData.speed;
		List<MapEvent> list = editedData.events.Where((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "SetSpeed").ToList();
		if (list.Count > 0)
		{
			foreach (MapEvent item in list)
			{
				float num3 = float.Parse(item.data[1], CultureInfo.InvariantCulture);
				if (num > num3)
				{
					num = num3;
				}
				if (num2 < num3)
				{
					num2 = num3;
				}
			}
		}
		string format = "{0,-18} {1,18}";
		string text = "<b><i>Map's Stats:</i></b>" + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Difficulty</b>:", mapDifficulty.ToString("0.00")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Max Score</b>:", mapMaxScore) + Environment.NewLine;
		text = text + string.Format(format, "<b>Time</b>:", editedData.musicTime.ToString("0.00")) + Environment.NewLine;
		text = text + string.Format(format, "<b>HP</b>:", editedData.lives + "/" + editedData.maxLives) + Environment.NewLine;
		text = text + string.Format(format, "<b>Speed</b>:", num.ToString("0") + "-" + num2.ToString("0")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(text, "#ok", null);
	}

	public void OnBackToEditorButton()
	{
		currentState = EditorState.MapLoaded;
		Singleton<UI>.Instance.SwitchView("Editor");
		if (eventConfigCanvas.activeSelf)
		{
			FindNearestEvent(true);
		}
	}

	private IEnumerator OECGEKPJPCB()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int aCODLKJMCJF = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return StartCoroutine(UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, aCODLKJMCJF));
			IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor");
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null);
		}
	}

	private void LCJDCFFEMLP()
	{
		StartCoroutine(ConfirmExiting());
	}

	private void PLICILPAOJJ()
	{
		GameObject gameObject = unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		foreach (string IEOKJCPAOHL in editedMapData.unlockConditions)
		{
			GameObject OBFJPHLBFOL = UnityEngine.Object.Instantiate(unlockConditionElement);
			OBFJPHLBFOL.transform.SetParent(gameObject.transform);
			OBFJPHLBFOL.transform.localScale = new Vector3(1f, 1f, 1f);
			OBFJPHLBFOL.GetComponentInChildren<InputField>().text = IEOKJCPAOHL;
			OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
			OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(delegate
			{
				editedMapData.unlockConditions.Remove(IEOKJCPAOHL);
				UnityEngine.Object.Destroy(OBFJPHLBFOL);
				Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions");
			});
			num++;
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			AddNewUnlockCondition();
		});
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	public void OnLoadMapButton()
	{
		StartCoroutine(AMAENBAABIN());
	}

	[CompilerGenerated]
	private void MOFDPGHNDMO()
	{
		AddNewUnlockCondition();
	}

	private void CKJMMGCPIHO()
	{
		currentBPMText.text = LocalizationService.Instance.HOPMEAJKPHL("Failed to InstantiateSceneObject prefab: ");
		currentBpmOffsetInputField.text = string.Empty + BPMOffset;
		currentBpmInputField.text = string.Empty + BPM;
		foreach (EventsCanvas eventsCanvase in eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvase.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Transform transform = (Transform)enumerator2.Current;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator2 as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (!useBPMSnap)
		{
			return;
		}
		for (int i = 0; (float)i <= (float)Mathf.CeilToInt(editedMapData.musicTime) * (BPM * (float)BPMSplit / 986f); i++)
		{
			foreach (EventsCanvas eventsCanvase2 in eventsCanvases)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(bpmGridGameObject);
				gameObject.transform.SetParent(eventsCanvase2.bpmGrid);
				gameObject.transform.localPosition = new Vector3(BPMOffset + (float)i * (586f / (BPM * (float)BPMSplit)), 344f, 1584f);
				gameObject.name = "Joystick1Button0";
			}
		}
	}

	public IEnumerator Save(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData = GetEditedData(KIIAKJPJDKB);
		string nOJGGCLPPAM = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nOJGGCLPPAM, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null);
		}
	}

	public void HAEIHFOMIIJ()
	{
		StartCoroutine(IEJIFEMNJCJ());
	}

	public void SetBPMSplit(float DPNHODJHGJL)
	{
		BPMSplit = (int)DPNHODJHGJL;
		DPGILDLHMLM();
	}

	private void GINAEDMALEA()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!GPNKNBLBFOD.isEditing && currentState == EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 1982f)
			{
				if (Input.GetKey((KeyCode)(-120)) || Input.GetKey((KeyCode)(-29)))
				{
					zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 1832f;
				}
				else
				{
					NLJJIAIEIDH((0f - Input.mouseScrollDelta.y) * Camera.main.orthographicSize * 679f, false);
				}
			}
			if (!Input.GetKey((KeyCode)134) && !Input.GetKey((KeyCode)(-20)) && !flag)
			{
				if (Input.GetKeyDown((KeyCode)85))
				{
					TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.LeftBracket))
				{
					ToggleRecord();
				}
				if (Input.GetKeyDown((KeyCode)25))
				{
					OnDeleteButton();
				}
				if (Input.GetKeyDown((KeyCode)(-51)))
				{
					Slowmo();
				}
				if (Input.GetKeyDown(KeyCode.Q))
				{
					SetBPMEnabled(useBPMSnap);
					useBpmToggle.isOn = useBPMSnap;
				}
				if (Input.GetKeyDown((KeyCode)(-24)))
				{
					SpeedUp();
				}
				if (Input.GetKeyDown((KeyCode)(-35)))
				{
					SwichCanvas();
				}
			}
		}
		if (Input.GetKey((KeyCode)(-42)) || Input.GetKey(KeyCode.Minus))
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				Singleton<EditorHistoryHandler>.Instance.Undo();
			}
			if (Input.GetKeyDown(KeyCode.G))
			{
				Singleton<EditorHistoryHandler>.Instance.HIABDMALLGO();
			}
			if (currentState == EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-24)))
				{
					Singleton<EditorArcsSelector>.Instance.IFEJJGEAGBM();
				}
				if (Input.GetKeyDown(KeyCode.Percent))
				{
					Singleton<EditorArcsSelector>.Instance.HONMFAMJNLD();
				}
				if (Input.GetKeyDown((KeyCode)30))
				{
					Singleton<EditorArcsSelector>.Instance.IJOGFHDIBHP(currentTime);
				}
				if (Input.GetMouseButtonDown(3))
				{
					HDBJAPODAGG(626f);
				}
				if (Input.GetKeyDown((KeyCode)(-116)))
				{
					OnEventConfigButton();
				}
			}
		}
		if (isRecording || GPNKNBLBFOD.isEditing || flag)
		{
			return;
		}
		if (!Input.GetKey((KeyCode)(-39)) && !Input.GetKey((KeyCode)(-157)))
		{
			if (Input.GetKeyDown((KeyCode)79))
			{
				OnAddButton(1);
			}
			if (Input.GetKeyDown((KeyCode)(-39)))
			{
				OnAddButton(0);
			}
		}
		if (Input.GetKey((KeyCode)(-58)))
		{
			NLJJIAIEIDH(1951f * Camera.main.orthographicSize, false);
		}
		if (Input.GetKey(KeyCode.A))
		{
			NLJJIAIEIDH(693f * Camera.main.orthographicSize);
		}
		if (Input.GetKeyDown((KeyCode)(-183)) && currentEventsCanvasId < eventsCanvases.Count - 1)
		{
			currentEventsCanvasId += 0;
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent(true);
			}
		}
		if (Input.GetKeyDown((KeyCode)(-1)) && currentEventsCanvasId > 0)
		{
			currentEventsCanvasId -= 0;
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent(true);
			}
		}
	}

	public void HDBJAPODAGG(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		Singleton<UI>.Instance.GGIFLKMELMP();
		zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	public void OnImportMapButton()
	{
		StartCoroutine(GMKAIGKBLAA());
	}

	public void SetZoom(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		Singleton<UI>.Instance.ClearSelection();
		zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	public void OnExitButton()
	{
		LCJDCFFEMLP();
	}

	private IEnumerator ONJIIJDEFOM()
	{
		if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapbeforeuploading", "#yes", null, "#no"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Save());
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE)) + ".completed", 0) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#creatingnewitem", string.Empty, null, false);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510u, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				CEJIPNKDJKJ.Set(hAPICall);
				Debug.Log("[MapsEditor] Creating new item...");
				yield break;
			}
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#mapalreadyexistupdate", "#yes", null, "#no"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("#changenote", "#submit", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					StartCoroutine(KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#mapmustbecompletebeforesubmit", "OK", null);
		}
	}

	public void OnApplyCustomEventButton(List<string> NKEHMBLLEMH)
	{
		if (editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			editingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited event");
		}
	}

	public void LIGNDDCOBJH(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			if (eventsCanvases[currentEventsCanvasId].forType == EventType.Gameplay)
			{
				AddNewEvent(currentTime, new List<string> { "z", "BitsData" }, false);
			}
			else
			{
				AddNewEvent(currentTime, new List<string> { "(master)", ".lastCheckpoint.correctScore" });
			}
		}
		if (HMGBJCGOLMI == 0)
		{
			FAGPOJDCKEC(currentTime);
		}
	}

	public void SpeedUp()
	{
		audioSampler.audioSources[1].pitch += 0.25f;
		if (audioSampler.audioSources[1].pitch > 1f)
		{
			audioSampler.audioSources[1].pitch = 1f;
		}
	}

	public void UpdateTopMenu()
	{
		Debug.Log("[MapEditor] Updating top menu");
		bool flag = IsMapLoaded();
		bool flag2 = currentState == EditorState.Busy;
		topMenuPanel.transform.Find("FileMenu").GetComponent<Button>().interactable = !flag2;
		topMenuPanel.transform.Find("FileMenu").FindDeepChild("SaveMapButton").GetComponent<Button>()
			.interactable = flag;
		topMenuPanel.transform.Find("FileMenu").FindDeepChild("PublishMapButton").GetComponent<Button>()
			.interactable = flag;
		topMenuPanel.transform.Find("FileMenu").FindDeepChild("TestMapButton").GetComponent<Button>()
			.interactable = flag;
		topMenuPanel.transform.Find("EditMenu").GetComponent<Button>().interactable = flag && !flag2;
		topMenuPanel.transform.Find("EventMenu").GetComponent<Button>().interactable = flag && !flag2;
		topMenuPanel.transform.Find("ViewMenu").GetComponent<Button>().interactable = flag && !flag2;
		topMenuPanel.transform.Find("HelpMenu").GetComponent<Button>().interactable = !flag2;
	}

	public void Start()
	{
		CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(PFIPOJIIODP);
		KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(BMDDFOKBIAK);
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Map Editor", "Creating awesome maps");
		Reset();
		StartCoroutine(PPEKKHNBMIH());
	}

	public void OnAddNewResourceButton()
	{
		string text = GameObject.Find("ResourceIDInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("ResourceFileSelector").GetComponent<FileSelector>().result;
		StartCoroutine(AddNewLevelResoure(text, result));
	}

	public void SetBPMOffset(float DPNHODJHGJL)
	{
		BPMOffset = DPNHODJHGJL;
		DPGILDLHMLM();
	}

	public string FONMIHBONDF()
	{
		return CAFHKDIIDEE;
	}

	private void BPOJHBIEMOJ()
	{
		DPGILDLHMLM();
		IEnumerator enumerator = Camera.main.gameObject.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (transform.name == "caret")
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(caretGameObject);
		gameObject.name = "caret";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 1f);
		foreach (EventsCanvas eventsCanvase in eventsCanvases)
		{
			IEnumerator enumerator3 = eventsCanvase.grid.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					Transform transform2 = (Transform)enumerator3.Current;
					UnityEngine.Object.Destroy(transform2.gameObject);
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator3 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
		}
		for (int i = 0; (float)i < editedMapData.musicTime; i++)
		{
			foreach (EventsCanvas eventsCanvase2 in eventsCanvases)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(gridGameObject);
				gameObject2.transform.SetParent(eventsCanvase2.grid);
				gameObject2.transform.localPosition = new Vector3(i, 0f, 0f);
				gameObject2.name = "grid";
			}
		}
	}

	[CompilerGenerated]
	private static float ABCOEBPCAJI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	public IEnumerator AddNewLevelResoure(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath + "/" + fileInfo.Name;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			editedMapData.levelResources.Add(item);
			yield return StartCoroutine(Save(false));
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE)));
			ReloadResList();
		}
	}

	[CompilerGenerated]
	private static float MMAGIMBKFLF(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	private void NLJJIAIEIDH(float EHHBHEJBHNG, bool BNLKFNOIDHH = true)
	{
		if (IsMapLoaded())
		{
			float num = 0f;
			num = ((!BNLKFNOIDHH) ? (currentTime + EHHBHEJBHNG) : (EHHBHEJBHNG * audioSampler.audioSources[1].clip.length));
			if (num < 0f)
			{
				num = 0f;
			}
			if (num >= audioSampler.audioSources[1].clip.length)
			{
				num = audioSampler.audioSources[1].clip.length;
			}
			currentTime = num;
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent();
			}
			if (isPlaying)
			{
				audioSampler.audioSources[1].time = currentTime;
			}
		}
	}

	private void AJEFOEJANDB(float EHHBHEJBHNG)
	{
		if (useBPMSnap)
		{
			EHHBHEJBHNG = GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string> { "checkpoint" });
		GameObject gameObject = UnityEngine.Object.Instantiate(eventGameObject);
		gameObject.name = "checkpoint";
		gameObject.transform.SetParent(eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added checkpoint");
		UpdateBottomBar();
		FindNearestEvent(true);
	}

	private void IIIGPJIJHKD(string NBGPBKCPFDN)
	{
		Reset();
		CAFHKDIIDEE = NBGPBKCPFDN;
		StartCoroutine(GOGFAHNINFB());
	}

	private GameObject KIDAPPHEPBE()
	{
		GameObject result = null;
		if (audioSampler.audioSources[1].clip != null)
		{
			float num = float.PositiveInfinity;
			for (int i = 0; i < eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = eventsContainer.transform.GetChild(i).gameObject;
				if (gameObject.name != "checkpoint")
				{
					Vector3 position = gameObject.transform.position;
					float sqrMagnitude = (position - new Vector3(currentTime, (currentEventsCanvasId != 0) ? 2 : (-2), 0f)).sqrMagnitude;
					if (sqrMagnitude <= num && (bool)gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
					{
						result = gameObject;
						num = sqrMagnitude;
					}
				}
			}
		}
		return result;
	}

	private void BDOIODEMFHC(string NBGPBKCPFDN)
	{
		Reset();
		CAFHKDIIDEE = NBGPBKCPFDN;
		StartCoroutine(GOGFAHNINFB());
	}

	public bool IsMapLoaded()
	{
		return currentState == EditorState.MapLoaded && !string.IsNullOrEmpty(CAFHKDIIDEE);
	}

	public void OnUpdateMapMainResourceButton(int HMGBJCGOLMI)
	{
		StartCoroutine(GKGAABCOKHJ(HMGBJCGOLMI));
	}

	public void SetBPMOffsetToCaret()
	{
		BPMOffset = currentTime;
		DPGILDLHMLM();
	}

	public void AddNewUnlockCondition()
	{
		editedMapData.unlockConditions.Add(string.Empty);
		PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions");
	}

	private void BMDDFOKBIAK(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult == EResult.k_EResultOK)
		{
			Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId);
			Debug.Log("[LevelEditorScene] Map submitted!");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath;
				string dDAOMDPAIEP = fullLevelPath + "/" + Helpers.levelConfigFileName;
				int mapMaxScore = Helpers.GetMapMaxScore(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
				float mapDifficulty = Helpers.GetMapDifficulty(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
				StartCoroutine(Singleton<RanksSystem>.Instance.UpdateOfficialMap(string.Empty + NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, Helpers.CalculateMD5(dDAOMDPAIEP), mapDifficulty, mapMaxScore));
			}
			FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null);
			FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		PAODIJKEBCA = false;
	}

	public void OnManualButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/files/editor_manual.pdf"));
	}

	public void ReloadResList()
	{
		GameObject gameObject = resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource levelResource in editedMapData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "resource";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ResourceListElement>().Init(levelResource.name, levelResource.path, Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).resources[levelResource.name]);
		}
	}

	private IEnumerator GKGAABCOKHJ(int HMGBJCGOLMI)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).fullLevelPath;
		if (HMGBJCGOLMI == 0)
		{
			string result = GameObject.Find("NewIconFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo = new FileInfo(result);
			File.Delete(fullLevelPath + "/" + editedMapData.iconFile);
			File.Copy(result, fullLevelPath + "/icon" + fileInfo.Extension);
			editedMapData.iconFile = "icon" + fileInfo.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile = editedMapData.iconFile;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullLevelPath + "/icon" + fileInfo.Extension, fullLevelPath + "/icon" + fileInfo.Extension, true));
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(fullLevelPath + "/icon" + fileInfo.Extension);
			yield return StartCoroutine(Save(false));
			Singleton<UI>.Instance.SwitchView("Editor");
			yield return new WaitForSeconds(0.2f);
			currentState = EditorState.MapLoaded;
		}
		if (HMGBJCGOLMI == 1)
		{
			string result2 = GameObject.Find("NewMusicFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas");
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo2 = new FileInfo(result2);
			File.Delete(fullLevelPath + "/" + editedMapData.musicFile);
			File.Copy(result2, fullLevelPath + "/music" + fileInfo2.Extension);
			editedMapData.musicFile = "music" + fileInfo2.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile = editedMapData.musicFile;
			float num = 0f;
			string fullName = new FileInfo(fullLevelPath + "/" + editedMapData.musicFile).FullName;
			yield return StartCoroutine(Helpers.GetAudioLength(fullName, true));
			num = Helpers.resultAudioLength;
			editedMapData.musicTime = num;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicTime = editedMapData.musicTime;
			currentState = EditorState.MapLoaded;
			yield return StartCoroutine(Save(false, false));
			currentState = EditorState.MapLoaded;
			IIIGPJIJHKD(CAFHKDIIDEE);
		}
	}

	private IEnumerator NLIGGKFCFNM()
	{
		TrashManRecycleBin kHNADIFNKFM = new TrashManRecycleBin
		{
			prefab = soundWaveGameObject,
			instancesToPreallocate = (int)audioSampler.audioSources[0].clip.length * 100
		};
		TrashMan.manageRecycleBin(kHNADIFNKFM, string.Empty);
		audioSampler.audioSources[0].Play();
		yield return new WaitWhile(() => !audioSampler.audioSources[0].isPlaying);
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		foreach (EventsCanvas eventsCanvase in eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvase.soundwave.transform.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Transform transform = (Transform)enumerator2.Current;
					TrashMan.despawn(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator2 as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}
		while (audioSampler.audioSources[0].isPlaying)
		{
			float num = audioSampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			foreach (EventsCanvas eventsCanvase2 in eventsCanvases)
			{
				GameObject gameObject = TrashMan.spawn(soundWaveGameObject, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(eventsCanvase2.soundwave.transform, true);
				gameObject.transform.localScale = new Vector3(1f, num * 20f, 1f);
				gameObject.transform.localPosition = new Vector3(audioSampler.audioSources[0].time, 0f, 1f);
			}
			yield return new WaitForFixedUpdate();
		}
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
	}

	private IEnumerator GOGFAHNINFB()
	{
		Singleton<UI>.Instance.SwitchView("Loading");
		yield return new WaitForSeconds(0.2f);
		Debug.Log("[MapEditor] Openning " + CAFHKDIIDEE);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE);
		Debug.Log("[MapEditor] Loading music...");
		string fullName = new FileInfo(mapData.fullLevelPath + "/" + mapData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true, false));
		AudioClip audioClip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSampler.Init(audioClip, 0f, false);
		Debug.Log("[MapEditor] Prepairing map editor...");
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE)));
		SetEditedData(mapData.mapData);
		BPOJHBIEMOJ();
		StopCoroutine(NLIGGKFCFNM());
		StartCoroutine(NLIGGKFCFNM());
		Debug.Log("[MapEditor] Loading events...");
		currentTimeSlider.minValue = 0f;
		currentTimeSlider.maxValue = audioClip.length;
		currentTimeSlider.value = 0f;
		currentState = EditorState.MapLoaded;
		UpdateTopMenu();
		UpdateBottomBar();
		FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", true);
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("Editor");
		yield return new WaitForSeconds(0.2f);
		if (editedMapData.configVersion < MapData.GetLastConfigVersion() && !Singleton<SaveSystem>.Instance.HasKey("maps." + CAFHKDIIDEE + ".sawoutdatedmessage"))
		{
			StartCoroutine(ShowOutdatedMapWarning());
		}
	}
}
