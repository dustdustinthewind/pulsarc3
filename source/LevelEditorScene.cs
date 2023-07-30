// LevelEditorScene
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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LevelEditorScene : Scene
{
	[CompilerGenerated]
	private sealed class MIAMLCBDKHA
	{
		internal string IEOKJCPAOHL;

		internal LevelEditorScene ADPIKBBAKHP;
	}

	[CompilerGenerated]
	private sealed class OBBGBOKJGOD
	{
		internal GameObject OBFJPHLBFOL;

		internal MIAMLCBDKHA PPFPANGJGFI;

		internal void EGKGJJGAPMN()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("LB", true);
		}

		internal void DNIMHEKGJHB()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_ScreenEdgeFading");
		}

		internal void FCAGEDLBBHD()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("original.tutorial");
		}

		internal void GBKBDKHPLKG()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions");
		}

		internal void LLNDDFGPOPL()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("_Far");
		}

		internal void FDAIFOAGDLA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("Item ", true);
		}

		internal void AGJKEBOPIOC()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("SSAARenderTargetCamera", true);
		}

		internal void HBJFIOJFBHC()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL("ResetSpeed");
		}

		internal void BMAOCLKPNNC()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("CameraFilterPack_TV_Arcade1");
		}

		internal void OFLDIMDDLHM()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("InfoButton", true);
		}

		internal void FFEGPHJKMFK()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("DPADHOR");
		}

		internal void BKNHHGBPLGH()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_Source", true);
		}

		internal void JKEDCEOCPJO()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CrosshairOpacitySlider");
		}

		internal void BFEABMIFIEE()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("ControllerRightY", true);
		}

		internal void IGFOBPKFCDJ()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL("_Value");
		}

		internal void KGKMOLCPDIH()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("_SoftZDistance", true);
		}

		internal void JDELIMPGFDJ()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("maps.");
		}

		internal void DBFPGFHEGKA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("Beat Detected", true);
		}

		internal void KFNBKFELFLH()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_Value");
		}

		internal void LNDGINDKPFA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_Value6");
		}

		internal void DKGPCPBNDPK()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD(" [");
		}

		internal void MEMPOPNAEDN()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("_Offsets", true);
		}

		internal void AEINPAGJFME()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO(".png", true);
		}

		internal void PIJAOCFAPKC()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("#yes", true);
		}

		internal void FJDBPPKABJE()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("_BlurPass");
		}

		internal void LHHFJBIAHCN()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("UseFinalGlassColor", true);
		}

		internal void LOEAMHGMMPK()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("_EmissionColor", true);
		}

		internal void EKHOOPGPPGE()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("CameraFilterPack/Blend2Camera_Saturation");
		}

		internal void OFHCGKJFGDI()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_Value2", true);
		}

		internal void MGENGAEDACG()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("_PosX", true);
		}

		internal void FIPCLHEKKCA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("Set Particles Color");
		}

		internal void BDGDIDPDBHG()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("UseScanLineSize", true);
		}

		internal void OLIGLEMPFOP()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD(".lastCheckpoint.isMapCompleted", true);
		}

		internal void BJMAIJDIKCN()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("_Speed");
		}

		internal void FHIJCPPECHA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("]");
		}

		internal void FHFECFLBHMA()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("|", true);
		}

		internal void PBCAHKDLFPE()
		{
			PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("Gameplay/satellite", true);
		}
	}

	public int currentEventsCanvasId;

	public List<GameObject> soundWavesCanvas;

	public GameObject soundWaveElement;

	public bool isLevelLoaded;

	[HideInInspector]
	public string mapID;

	[HideInInspector]
	public MapData levelData;

	public GameObject bit;

	public GameObject grid;

	public GameObject caret;

	public GameObject checkpoint;

	public GameObject customevent;

	public GameObject configCanvas;

	public GameObject loadLevelCanvas;

	public GameObject loadLevelElement;

	public GameObject levelsSelectorListContent;

	public GameObject listMessageElement;

	public GameObject newLevelCanvas;

	public GameObject resourcesCanvas;

	public GameObject eventConfigCanvas;

	public GameObject zoomSlider;

	public GameObject tagsScrollRectContent;

	public GameObject tagElement;

	public GameObject tagHeaderElement;

	public GameObject resourcesScrollRectContent;

	public GameObject resourcesElement;

	public GameObject unlockConditionContent;

	public GameObject unlockConditionElement;

	public GameObject addNewUnlockConditionElement;

	public GameObject puzzleScrollRectElement;

	public GameObject addNewElement;

	public Sprite playImage;

	public Sprite pauseImage;

	public Transform canvasGO;

	public AudioSampler asampler;

	public UnityEvent OnLoaded;

	public GameObject EditingEventGO;

	private GameObject AEAKHCLJFDH;

	public bool isRecording;

	protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

	protected CallResult<SubmitItemUpdateResult_t> KAPDFIOHNGL;

	public bool isUpdating;

	private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

	private int LKJCIHOKJHC;

	private GameObject GNDCEMNKEEO;

	private Text GOFEKGAKHON;

	private Slider DLKGEPIOLDE;

	private Text HLNBBDEGLPJ;

	[CompilerGenerated]
	private static Func<MapEvent, float> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<float, float> CLCBJCKCBDD;

	private GameObject FDFNPFDMDLF()
	{
		float num = 1576f;
		GameObject result = null;
		Transform transform = GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("[MenuScene] Error: ").transform.childCount; i += 0)
		{
			GameObject gameObject = GameObject.Find("_Value2").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	private IEnumerator JINABPAAGGF()
	{
		string fullName = new FileInfo(Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath + "/" + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true));
		Singleton<MapsSystem>.Instance.GetMapData(mapID).clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		if (!Singleton<MapsSystem>.Instance.GetMapData(mapID).clip)
		{
			yield break;
		}
		Debug.Log("[MapEditor] Loaded music file: " + fullName);
		levelData.musicTime = Singleton<MapsSystem>.Instance.GetMapData(mapID).clip.length;
		if ((bool)Singleton<MapsSystem>.Instance.GetMapData(mapID).clip)
		{
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
			AudioClip clip = Singleton<MapsSystem>.Instance.GetMapData(mapID).clip;
			if (clip != null)
			{
				float length = clip.length;
				canvasGO.FindDeepChild("CurrentTimeLabel").GetComponent<Text>().text = "0.00";
				canvasGO.FindDeepChild("TotalTimeLabel").GetComponent<Text>().text = string.Empty + length.ToString("0.00");
				asampler.Init(clip, 0f, false);
				asampler.audioSources[1].loop = true;
			}
		}
	}

	public void BJBPJMFFJNK(List<string> NKEHMBLLEMH)
	{
		if (EditingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = EditingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(eventConfigCanvas.transform.Find("tagElement").GetComponent<InputField>().text, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			EditingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			EditingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			EditingEventGO.GetComponent<EditorEvent>().EDJHABOOHKN();
			eventConfigCanvas.transform.Find("_LayerThickness").GetComponent<InputField>().text = string.Empty + EditingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("CameraFilterPack/TV_Old", true);
		}
	}

	public void OnNewLevelButton(int OFBPACALHFI)
	{
		if (OFBPACALHFI == 0)
		{
			newLevelCanvas.SetActive(true);
		}
		if (OFBPACALHFI == 1)
		{
			StartCoroutine(OECGEKPJPCB());
		}
	}

	public void OpenMap(string NCHEHDPLJBP)
	{
		mapID = NCHEHDPLJBP;
		StartCoroutine(APFOMADCGBO());
	}

	public IEnumerator JACIJJCAEGL(bool DICJGPOLHPK = true)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Please wait..", string.Empty, null, false);
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData = GetEditedData();
		string nOJGGCLPPAM = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nOJGGCLPPAM, true));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevel(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)), Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath, FullMapData.MapSource.Editor));
		Debug.Log("[LevelEditorScene] Exported to " + fullLevelPath);
		LKJCIHOKJHC = Singleton<EditorHistoryHandler>.Instance.state;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null);
	}

	private GameObject PEAFDKLCODL()
	{
		float num = float.PositiveInfinity;
		GameObject result = null;
		Transform transform = GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
		{
			GameObject gameObject = GameObject.Find("BitsData").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	[CompilerGenerated]
	private bool FEFNMJJHNPI(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>().SelectedItem.ID;
	}

	public void OnEditedCustomEventFunction()
	{
		GetComponent<CustomEventEditor>().ChangeEventFunction(Helpers.GetAvailableEditorEvents(levelData.configVersion).Find((EditorEventFunctionInfo IACGDFHKCAE) => IACGDFHKCAE.id == eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>().SelectedItem.ID).id, KIDAPPHEPBE().GetComponent<EditorEvent>());
	}

	public void SetDetectorSpeed(float DPNHODJHGJL)
	{
		asampler.audioSources[0].pitch = DPNHODJHGJL;
	}

	public IEnumerator SaveBeforeUpload()
	{
		if (Singleton<EditorHistoryHandler>.Instance.state != LKJCIHOKJHC)
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save level before uploading?", "YES", null, "NO"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Save());
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)) + ".completed", 0) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Creating new item...", "OK", null, false);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510u, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				CEJIPNKDJKJ.Set(hAPICall);
				Debug.Log("[LevelEditorScene] Creating new item...");
				yield break;
			}
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Map already submited. Update?", "YES", null, "NO"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("Change Note:", "SUBMIT", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					StartCoroutine(KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("You must complete your map before submiting it to Workshop", "OK", null);
		}
	}

	public void OnManualButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/files/editor_manual.pdf"));
	}

	public MapData GetEditedData()
	{
		MapData mapData = new MapData(levelData);
		mapData.name = configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>()
			.text;
		mapData.info = configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>()
			.text;
		mapData.moreInfoURL = configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>()
			.text;
		mapData.speed = (int)configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>()
			.value;
		mapData.configVersion = (int)configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>()
			.value;
		mapData.lives = (int)configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>()
			.value;
		mapData.maxLives = (int)configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>()
			.value;
		mapData.handCount = (int)configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>()
			.value;
		mapData.environmentType = (int)configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>()
			.value;
		mapData.hidden = configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>()
			.isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(mapID).clip != null)) ? 0f : Singleton<MapsSystem>.Instance.GetMapData(mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		foreach (Toggle toggle in componentsInChildren)
		{
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 1)
		{
			mapData.tags.Add("OneHand");
		}
		else if (mapData.handCount == 2)
		{
			mapData.tags.Add("TwoHands");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		foreach (InputField inputField in componentsInChildren2)
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("BitsData").transform.childCount; k++)
		{
			if (GameObject.Find("BitsData").transform.GetChild(k).name == "event")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("BitsData").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		mapData.events = mapData.events.OrderBy((MapEvent HPHENPOHOMK) => HPHENPOHOMK.time).ToList();
		mapData.checkpoints.Clear();
		for (int l = 0; l < GameObject.Find("BitsData").transform.childCount; l++)
		{
			if (GameObject.Find("BitsData").transform.GetChild(l).name == "checkpoint")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("BitsData").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		mapData.checkpoints = mapData.checkpoints.OrderBy((float HPHENPOHOMK) => HPHENPOHOMK).ToList();
		return mapData;
	}

	public void CheckLicence()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("player.licenceaccepted") || Singleton<SaveSystem>.Instance.GetInt("player.licenceaccepted", 0) == 0)
		{
			ShowAcceptLicence();
		}
	}

	private GameObject BOODGJILFOD()
	{
		float num = 1545f;
		GameObject result = null;
		Transform transform = GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("score").transform.childCount; i++)
		{
			GameObject gameObject = GameObject.Find("#yes").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	public IEnumerator UpdateEditorLevelAssets(string NPJLPIHGLBI, string EAGJAOLHFGB, string FLMDNANCAAC, bool EAPDHEDHAAI = false, string NCHEHDPLJBP = "")
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", null, null, false);
		string text = NPJLPIHGLBI + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			FileInfo fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, NPJLPIHGLBI + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(NPJLPIHGLBI + "/icon" + fileInfo.Extension, NPJLPIHGLBI + "/icon" + fileInfo.Extension, true));
			if (Singleton<MapsSystem>.Instance.GetMapData(mapID) != null)
			{
				Singleton<MapsSystem>.Instance.GetMapData(mapID).icon = (Sprite)ResourcesManager.GetLoadedResource(NPJLPIHGLBI + "/icon" + fileInfo.Extension);
				StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(null, Singleton<MapsSystem>.Instance.GetMapData(mapID)));
			}
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			FileInfo fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicFile);
			File.Copy(FLMDNANCAAC, NPJLPIHGLBI + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicFile = "music" + fileInfo2.Extension;
			float num = 0f;
			string fullName = new FileInfo(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicFile).FullName;
			yield return StartCoroutine(Helpers.GetAudioLength(fullName, true));
			num = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicTime = num;
		}
		if (!string.IsNullOrEmpty(NCHEHDPLJBP))
		{
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.configVersion = MapData.GetLastConfigVersion();
		}
		string nOJGGCLPPAM = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(NPJLPIHGLBI);
		yield return StartCoroutine(Helpers.SaveFile(NPJLPIHGLBI + "/" + Helpers.levelConfigFileName, nOJGGCLPPAM, true));
		if (EAPDHEDHAAI)
		{
			StartCoroutine(KKDHPBOFIFH(NPJLPIHGLBI));
		}
		Singleton<MessageBoxPanel>.Instance.Close();
	}

	private static float AIHJHCJOOJL(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	public void OnExitButton()
	{
		StartCoroutine(ConfirmExiting());
	}

	private GameObject DMHACHPKFHE()
	{
		float num = 1687f;
		GameObject result = null;
		Transform transform = GNDCEMNKEEO.transform;
		for (int i = 1; i < GameObject.Find("CameraFilterPack/FX_8bits").transform.childCount; i++)
		{
			GameObject gameObject = GameObject.Find("_TimeX").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	public override void IHLMNAGPKDA()
	{
		base.HAIAHJPCPAG();
		DPGCJACMEKB(false);
		CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(PFIPOJIIODP);
		KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(BMDDFOKBIAK);
		OnLoaded.Invoke();
		Singleton<GameManager>.Instance.INLEIPHNJPF("Anomaly_Distortion_Size", "[NetworkManager] Connection failed: ", null, null, 0, 1);
		if ((bool)canvasGO.FindDeepChild("action"))
		{
			GOFEKGAKHON = canvasGO.FindDeepChild("Reconnect() failed. It seems the client wasn't connected before?! Current state: ").GetComponent<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("Done!"))
		{
			DLKGEPIOLDE = canvasGO.FindDeepChild(" ").GetComponent<Slider>();
		}
		if ((bool)canvasGO.FindDeepChild(".completedMaps"))
		{
			HLNBBDEGLPJ = canvasGO.FindDeepChild("Fill Area").GetComponentInChildren<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("_Value3"))
		{
			canvasGO.FindDeepChild("_TimeX").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_MainTex"))
		{
			canvasGO.FindDeepChild("CameraFilterPack/Blend2Camera_Difference").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EnableRankingToggle"))
		{
			canvasGO.FindDeepChild("IconImage").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ResourceIDInputField"))
		{
			canvasGO.FindDeepChild("CameraFilterPack_Glasses_On2").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("Editor/"))
		{
			canvasGO.FindDeepChild("workshop.").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("settings.enableranking"))
		{
			canvasGO.FindDeepChild("GameModeText").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("Fade"))
		{
			canvasGO.FindDeepChild("settings.shaders.bloomintencity").GetComponent<Button>().interactable = isLevelLoaded;
		}
		CheckLicence();
	}

	public void OnFastVideoButton()
	{
		string nBEBMKFPBEP = "https://www.youtube.com/watch?v=cDVXukrKo74";
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
	}

	public void DeleteNearestEvent()
	{
		UnityEngine.Object.DestroyImmediate(PEAFDKLCODL());
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted event");
	}

	public IEnumerator BJJKIJJFAEE(string NCHEHDPLJBP)
	{
		mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(mapID);
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if ((bool)eventConfigCanvas)
		{
			eventConfigCanvas.SetActive(true);
		}
		isLevelLoaded = false;
		SetEditedData(levelData);
		isLevelLoaded = true;
		if ((bool)canvasGO.FindDeepChild("EditMenu"))
		{
			canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EventMenu"))
		{
			canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ViewMenu"))
		{
			canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("SaveButton"))
		{
			canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PublishButton"))
		{
			canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
	}

	public override void Start()
	{
		base.Start();
		ShowCursor(true);
		CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(PFIPOJIIODP);
		KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(BMDDFOKBIAK);
		OnLoaded.Invoke();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Maps Editor", "Creating awesome map");
		if ((bool)canvasGO.FindDeepChild("CurrentTimeLabel"))
		{
			GOFEKGAKHON = canvasGO.FindDeepChild("CurrentTimeLabel").GetComponent<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("TimeBGSlider"))
		{
			DLKGEPIOLDE = canvasGO.FindDeepChild("TimeBGSlider").GetComponent<Slider>();
		}
		if ((bool)canvasGO.FindDeepChild("EventConfigButton"))
		{
			HLNBBDEGLPJ = canvasGO.FindDeepChild("EventConfigButton").GetComponentInChildren<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("EditMenu"))
		{
			canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EventMenu"))
		{
			canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("GenerationMenu"))
		{
			canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ViewMenu"))
		{
			canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("SaveButton"))
		{
			canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PublishButton"))
		{
			canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		CheckLicence();
	}

	public override void NNCCPEBIAKH()
	{
		base.FEHCNJLLJMP();
		BDMABAGHOOF(false);
		CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(PFIPOJIIODP);
		KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(BMDDFOKBIAK);
		OnLoaded.Invoke();
		Singleton<GameManager>.Instance.DOFMKEPFKDP("/", "_ScreenResolution", null, null, 0, 1);
		if ((bool)canvasGO.FindDeepChild("ControllerRightX"))
		{
			GOFEKGAKHON = canvasGO.FindDeepChild("Tab2Content").GetComponent<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("AudioClip"))
		{
			DLKGEPIOLDE = canvasGO.FindDeepChild("_ScreenResolution").GetComponent<Slider>();
		}
		if ((bool)canvasGO.FindDeepChild("ShowTitle"))
		{
			HLNBBDEGLPJ = canvasGO.FindDeepChild("LeaderboardsButton").GetComponentInChildren<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("OnReadyClick"))
		{
			canvasGO.FindDeepChild("TBD").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_Near"))
		{
			canvasGO.FindDeepChild("_MainTex2").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("Editor"))
		{
			canvasGO.FindDeepChild("GetGameList failed: ").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_Value"))
		{
			canvasGO.FindDeepChild("_Offsets").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_EmissionGain"))
		{
			canvasGO.FindDeepChild("_Value").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("Triangle"))
		{
			canvasGO.FindDeepChild("/../").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PhotonView register is ignored, because viewID is 0. No id assigned yet to: "))
		{
			canvasGO.FindDeepChild("CameraFilterPack/TV_Vintage").GetComponent<Button>().interactable = isLevelLoaded;
		}
		CheckLicence();
	}

	public void OnEventConfigButton()
	{
		resourcesCanvas.SetActive(false);
		configCanvas.SetActive(false);
		FindNearestEvent(true);
		eventConfigCanvas.SetActive(!eventConfigCanvas.activeSelf);
	}

	private void ONBJNLMBDPI(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(customevent);
		gameObject.transform.SetParent(GameObject.Find("BitsData").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 0f, 0f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		gameObject.GetComponent<EditorEvent>().UpdateIcon();
		gameObject.name = "event";
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added event");
	}

	private GameObject KIDAPPHEPBE()
	{
		GameObject result = null;
		if (asampler.audioSources[0].clip != null)
		{
			float num = float.PositiveInfinity;
			Transform transform = GNDCEMNKEEO.transform;
			for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
			{
				GameObject gameObject = GameObject.Find("BitsData").transform.GetChild(i).gameObject;
				Vector3 position = gameObject.transform.position;
				float sqrMagnitude = (position - transform.position).sqrMagnitude;
				if (sqrMagnitude < num && (bool)gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
				{
					result = gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	public void GBOLAOBGLIH()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.JJGKGCBCGGD(".lastCheckpoint.checkpointsUsed"));
	}

	public void HILEJPLBAFB()
	{
		asampler.audioSources[0].pitch -= 1943f;
		if (asampler.audioSources[0].pitch < 1066f)
		{
			asampler.audioSources[0].pitch = 1706f;
		}
	}

	public void PNKDOFPOIDD(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("_PositionY");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	public void OnConfigButton()
	{
		configCanvas.SetActive(!configCanvas.activeSelf);
		resourcesCanvas.SetActive(false);
	}

	[CompilerGenerated]
	private static float MMAGIMBKFLF(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	private void BMDDFOKBIAK(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Error: I/O Failure", "OK", null);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult == EResult.k_EResultOK)
		{
			Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId);
			Debug.Log("[LevelEditorScene] Map submitted!");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
				string text = fullLevelPath + "/" + Helpers.levelConfigFileName;
			}
			FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Failed!", "OK", null);
			FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		isUpdating = false;
	}

	public void RebuildGridAndCaret()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(caret);
		gameObject.name = "caret";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 1f);
		GNDCEMNKEEO = gameObject;
		Transform transform = GameObject.Find("GridDataArcs").transform;
		Transform transform2 = GameObject.Find("GridDataStoryboard").transform;
		IEnumerator enumerator = transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform3 = (Transform)enumerator.Current;
				UnityEngine.Object.Destroy(transform3.gameObject);
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
		IEnumerator enumerator2 = transform2.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Transform transform4 = (Transform)enumerator2.Current;
				UnityEngine.Object.Destroy(transform4.gameObject);
			}
		}
		finally
		{
			IDisposable disposable2;
			if ((disposable2 = enumerator2 as IDisposable) != null)
			{
				disposable2.Dispose();
			}
		}
		for (int i = 0; (float)i < levelData.musicTime; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(grid);
			gameObject2.transform.SetParent(transform);
			gameObject2.transform.localPosition = new Vector3(i, 0f, 0f);
			gameObject2.name = "grid";
			gameObject2 = UnityEngine.Object.Instantiate(grid);
			gameObject2.transform.SetParent(transform2);
			gameObject2.transform.localPosition = new Vector3(i, 0f, 0f);
			gameObject2.name = "grid";
		}
	}

	private void PLICILPAOJJ()
	{
		GameObject gameObject = unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		foreach (string IEOKJCPAOHL in levelData.unlockConditions)
		{
			GameObject OBFJPHLBFOL = UnityEngine.Object.Instantiate(unlockConditionElement);
			OBFJPHLBFOL.transform.SetParent(gameObject.transform);
			OBFJPHLBFOL.transform.localScale = new Vector3(1f, 1f, 1f);
			OBFJPHLBFOL.GetComponentInChildren<InputField>().text = IEOKJCPAOHL;
			OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
			OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(delegate
			{
				levelData.unlockConditions.Remove(IEOKJCPAOHL);
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

	private IEnumerator KGCHKEGFNHI(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		string hAEBGHHMEBH = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(hAEBGHHMEBH, true));
		Debug.Log("[LevelEditorScene] Updated");
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updated!", "OK", null);
		UGCUpdateHandle_t uGCUpdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510u, JMMILEFMACB);
		SteamUGC.SetItemTitle(uGCUpdateHandle_t, levelData.name);
		SteamUGC.SetItemDescription(uGCUpdateHandle_t, levelData.info);
		SteamUGC.SetItemVisibility(uGCUpdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(uGCUpdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(uGCUpdateHandle_t, fullLevelPath + "/" + levelData.iconFile);
		List<string> tags = levelData.tags;
		SteamUGC.SetItemTags(uGCUpdateHandle_t, tags);
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(uGCUpdateHandle_t, GIGBCMLIKKE);
		FHKGDJDOKNB = uGCUpdateHandle_t;
		isUpdating = true;
		KAPDFIOHNGL.Set(hAPICall);
	}

	public void LJJEFNLCPNC(float EFGFCMLOJJE)
	{
		SetTime(EFGFCMLOJJE);
	}

	public void ToggleRecord()
	{
		isRecording = !isRecording;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if ((bool)canvasGO.FindDeepChild("MenuRecordButton"))
		{
			canvasGO.FindDeepChild("MenuRecordButton").GetComponentInChildren<Text>().text = (isRecording ? "STOP [R]" : "RECORD [R]");
		}
		if ((bool)canvasGO.FindDeepChild("RecordButton"))
		{
			ColorBlock colors = canvasGO.FindDeepChild("RecordButton").GetComponent<Button>().colors;
			colors.normalColor = (isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("#8E8E8EFF");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("#C8C8C8FF");
			canvasGO.FindDeepChild("RecordButton").GetComponent<Button>().colors = colors;
		}
	}

	public void JLEFKKLJKFF(string NCHEHDPLJBP)
	{
		mapID = NCHEHDPLJBP;
		StartCoroutine(APFOMADCGBO());
	}

	public void CNDNOAEEGBD()
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("[SaveSystem] Init from ") || Singleton<SaveSystem>.Instance.HHBIEPMBICO("GlassesColor", 0) == 0)
		{
			HABBEJMDIMP();
		}
	}

	public void FindNearestEvent(bool OAKJLAFMOHO = false)
	{
		EditingEventGO = KIDAPPHEPBE();
		if (((bool)EditingEventGO && OAKJLAFMOHO) || EditingEventGO != AEAKHCLJFDH)
		{
			GetComponent<CustomEventEditor>().Load(EditingEventGO.GetComponent<EditorEvent>());
			AEAKHCLJFDH = EditingEventGO;
		}
	}

	public IEnumerator PopulateLevelsList()
	{
		newLevelCanvas.SetActive(false);
		loadLevelCanvas.SetActive(true);
		GameObject gameObject = levelsSelectorListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		foreach (string key in Singleton<MapsSystem>.Instance.levelsData.Keys)
		{
			FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[key];
			if (fullMapData.source != FullMapData.MapSource.Editor)
			{
				continue;
			}
			Singleton<MapsSystem>.Instance.LoadLevel(key);
			GameObject gameObject2 = UnityEngine.Object.Instantiate(loadLevelElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<LevelsSelectorListElement>().levelid = key;
			gameObject2.transform.Find("NameText").GetComponent<Text>().text = key + " [" + fullMapData.mapData.name + "]" + ((!string.IsNullOrEmpty(fullMapData.workshopId)) ? (" - PUBLISHED #" + fullMapData.workshopId) : " - LOCAL");
			if ((bool)gameObject2.transform.Find("IconImage"))
			{
				if (fullMapData.icon != null)
				{
					gameObject2.transform.Find("IconImage").GetComponent<Image>().sprite = fullMapData.icon;
				}
				else
				{
					StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(gameObject2.transform.Find("IconImage").GetComponent<Image>(), fullMapData));
				}
			}
		}
		if (num == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(listMessageElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject3.transform.SetParent(gameObject.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.transform.Find("MessageText").GetComponent<Text>().text = "MAPS NOT FOUND";
		}
		yield break;
	}

	[CompilerGenerated]
	private void MOFDPGHNDMO()
	{
		AddNewUnlockCondition();
	}

	public void Exit()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("MenuScene");
	}

	public void SetTime(float EHHBHEJBHNG)
	{
		float num = EHHBHEJBHNG * asampler.audioSources[1].clip.length;
		if (num < 0f)
		{
			num = 0f;
		}
		if (num >= asampler.audioSources[1].clip.length)
		{
			num = asampler.audioSources[1].clip.length - 0.001f;
			asampler.audioSources[1].Pause();
		}
		asampler.audioSources[1].time = num;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
	}

	public void AddNewUnlockCondition()
	{
		levelData.unlockConditions.Add(string.Empty);
		PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions");
	}

	public void OnAboutButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Maps Editor v." + Helpers.GetGameVersion() + "\nCreated by Oxy949", "OK", null);
	}

	public void OnLoadIconFile()
	{
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		StartCoroutine(UpdateEditorLevelAssets(fullLevelPath, result, null, true, string.Empty));
	}

	public override void JKFDDNMPOJH()
	{
		base.BGDPIHMAACO();
		EIKPLOCGCIK(false);
		CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(PFIPOJIIODP);
		KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(BMDDFOKBIAK);
		OnLoaded.Invoke();
		Singleton<GameManager>.Instance.PBOKFNEJIEG("0", "_Value4", null, null, 1);
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			GOFEKGAKHON = canvasGO.FindDeepChild("#tryagain").GetComponent<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("settings_bindings_sec_"))
		{
			DLKGEPIOLDE = canvasGO.FindDeepChild("shader.sunny").GetComponent<Slider>();
		}
		if ((bool)canvasGO.FindDeepChild("ShowTitle"))
		{
			HLNBBDEGLPJ = canvasGO.FindDeepChild("Joystick1Button9").GetComponentInChildren<Text>();
		}
		if ((bool)canvasGO.FindDeepChild("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data."))
		{
			canvasGO.FindDeepChild("_TimeX").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("CameraFilterPack_TV_Noise3"))
		{
			canvasGO.FindDeepChild("StartButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("CameraFilterPack/Atmosphere_Rain"))
		{
			canvasGO.FindDeepChild("_TintColor").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("NameText"))
		{
			canvasGO.FindDeepChild("LivesSlider").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("maps."))
		{
			canvasGO.FindDeepChild("MenuScene").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_Colorisation"))
		{
			canvasGO.FindDeepChild("_ColorRGB").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("_Green_B"))
		{
			canvasGO.FindDeepChild("closed").GetComponent<Button>().interactable = isLevelLoaded;
		}
		CNDNOAEEGBD();
	}

	public void SpeedUp()
	{
		asampler.audioSources[1].pitch += 0.25f;
		if (asampler.audioSources[1].pitch > 1f)
		{
			asampler.audioSources[1].pitch = 1f;
		}
	}

	public IEnumerator LCPPFGICPIP()
	{
		if (Singleton<EditorHistoryHandler>.Instance.state != LKJCIHOKJHC)
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save level before uploading?", "YES", null, "NO"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Save());
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)) + ".completed", 0) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Creating new item...", "OK", null, false);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510u, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				CEJIPNKDJKJ.Set(hAPICall);
				Debug.Log("[LevelEditorScene] Creating new item...");
				yield break;
			}
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Map already submited. Update?", "YES", null, "NO"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("Change Note:", "SUBMIT", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					StartCoroutine(KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("You must complete your map before submiting it to Workshop", "OK", null);
		}
	}

	private IEnumerator NLIGGKFCFNM()
	{
		asampler.audioSources[0].Play();
		yield return new WaitWhile(() => !asampler.audioSources[0].isPlaying);
		Time.timeScale = 3f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		foreach (GameObject soundWavesCanva in soundWavesCanvas)
		{
			IEnumerator enumerator2 = soundWavesCanva.transform.GetEnumerator();
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
		while (asampler.audioSources[0].isPlaying)
		{
			float num = asampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			foreach (GameObject soundWavesCanva2 in soundWavesCanvas)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(soundWaveElement.gameObject, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(soundWavesCanva2.transform, true);
				gameObject.transform.localScale = new Vector3(1f, num * 20f, 1f);
				gameObject.transform.localPosition = new Vector3(asampler.audioSources[0].time, 0f, 1f);
			}
			yield return new WaitForFixedUpdate();
		}
		Time.timeScale = 1f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
	}

	public void PJLMKOHFPOI()
	{
		StartCoroutine(ConfirmExiting());
	}

	public void SetZoom(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	public void LIOACCCNFHF()
	{
		asampler.audioSources[1].pitch += 1507f;
		if (asampler.audioSources[0].pitch > 1155f)
		{
			asampler.audioSources[1].pitch = 1414f;
		}
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
		if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("[LevelEditorScene] Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
			StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			StartCoroutine(KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "Created"));
		}
	}

	public void ReloadResList()
	{
		GameObject gameObject = resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource levelResource in levelData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "resource";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ResourceListElement>().Init(levelResource.name, levelResource.path, Singleton<MapsSystem>.Instance.GetMapData(mapID).resources[levelResource.name]);
		}
	}

	public void SetHandsCount(float KPPBFKFOINB)
	{
		if (configCanvas.activeSelf)
		{
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount = (int)KPPBFKFOINB;
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited hands count");
		}
	}

	public void DeleteAll(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(i).name == "event" && (bool)GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0]) && GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0] == "SpawnObj")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(i).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int j = 0; j < GameObject.Find("BitsData").transform.childCount; j++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(j).name == "event" && (bool)GameObject.Find("BitsData").transform.GetChild(j).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("BitsData").transform.GetChild(j).GetComponent<EditorEvent>().mapEvent.data[0]))
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(j).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 2)
		{
			for (int k = 0; k < GameObject.Find("BitsData").transform.childCount; k++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(k).name == "checkpoint")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(k).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 3)
		{
			DeleteAll(0);
			DeleteAll(1);
			DeleteAll(2);
		}
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted data");
	}

	public void HJODFAMBBMO()
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("settings.fps") || Singleton<SaveSystem>.Instance.HHBIEPMBICO("_TimeX", 0) == 0)
		{
			ShowAcceptLicence();
		}
	}

	private void AMABEACAHMP(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(customevent);
		gameObject.transform.SetParent(GameObject.Find("SetSatelliteInput").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 700f, 1294f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		gameObject.GetComponent<EditorEvent>().EKAGILPDBCN();
		gameObject.name = "Tab2Content";
		Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("offsets", true);
	}

	public IEnumerator AcceptLicence()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", "RULES", null, "ALREADY SEEN"));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			string nBEBMKFPBEP = Singleton<GameManager>.Instance.CreateServerURL("/files/mods_terms.pdf");
			Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
		}
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Have you fully accept the terms?", "ACCEPT", null, "NO"));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<SaveSystem>.Instance.SetInt("player.licenceaccepted", 1);
			yield break;
		}
		Singleton<SaveSystem>.Instance.SetInt("player.licenceaccepted", 0);
		Exit();
	}

	public void UploadToWorkshop()
	{
		StartCoroutine(SaveBeforeUpload());
	}

	public void RemoveEvent(EditorEvent NMMEBLCAECE)
	{
		GameObject obj = NMMEBLCAECE.gameObject;
		UnityEngine.Object.DestroyImmediate(obj);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted event");
	}

	private void JDJDHBFKFDG(float DPNHODJHGJL)
	{
		if (DPNHODJHGJL < 0f)
		{
			if (asampler.audioSources[1].time + DPNHODJHGJL >= 0f)
			{
				asampler.audioSources[1].time += DPNHODJHGJL;
			}
			else
			{
				asampler.audioSources[1].time = 0f;
			}
		}
		if (DPNHODJHGJL > 0f)
		{
			if (asampler.audioSources[1].time + DPNHODJHGJL <= asampler.audioSources[1].clip.length - 0.001f)
			{
				asampler.audioSources[1].time += DPNHODJHGJL;
				return;
			}
			asampler.audioSources[1].time = asampler.audioSources[1].clip.length - 0.001f;
			asampler.audioSources[1].Pause();
		}
	}

	public void HABBEJMDIMP()
	{
		StartCoroutine(AcceptLicence());
	}

	private IEnumerator NBJHCHNIMAA()
	{
		Debug.Log("[MapEditor] Loading map: " + mapID);
		isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(mapID);
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
		levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData);
		yield return StartCoroutine(JINABPAAGGF());
		RebuildGridAndCaret();
		if ((bool)eventConfigCanvas)
		{
			eventConfigCanvas.SetActive(true);
		}
		SetEditedData(levelData);
		StartCoroutine(NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init");
		asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		asampler.audioSources[1].Pause();
		ScrollTo(0f);
		isLevelLoaded = true;
		OnLoaded.Invoke();
		if ((bool)canvasGO.FindDeepChild("EditMenu"))
		{
			canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EventMenu"))
		{
			canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("GenerationMenu"))
		{
			canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ViewMenu"))
		{
			canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("SaveButton"))
		{
			canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PublishButton"))
		{
			canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
	}

	public void ADPACAMFOJD()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("checkpoint") || Singleton<SaveSystem>.Instance.KFNFNKILGPH("ns.exitgames.com", 1) == 0)
		{
			HABBEJMDIMP();
		}
	}

	public void MGLJNGBEIOA()
	{
		StartCoroutine(Save());
	}

	[CompilerGenerated]
	private static float ABCOEBPCAJI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	public void Slowmo()
	{
		asampler.audioSources[1].pitch -= 0.25f;
		if (asampler.audioSources[1].pitch < 0.25f)
		{
			asampler.audioSources[1].pitch = 0.25f;
		}
	}

	private IEnumerator KCAGONEMKPL(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		string hAEBGHHMEBH = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return StartCoroutine(Helpers.LoadText(hAEBGHHMEBH, true));
		Debug.Log("[LevelEditorScene] Updated");
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updated!", "OK", null);
		UGCUpdateHandle_t uGCUpdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510u, JMMILEFMACB);
		SteamUGC.SetItemTitle(uGCUpdateHandle_t, levelData.name);
		SteamUGC.SetItemDescription(uGCUpdateHandle_t, levelData.info);
		SteamUGC.SetItemVisibility(uGCUpdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(uGCUpdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(uGCUpdateHandle_t, fullLevelPath + "/" + levelData.iconFile);
		List<string> tags = levelData.tags;
		SteamUGC.SetItemTags(uGCUpdateHandle_t, tags);
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(uGCUpdateHandle_t, GIGBCMLIKKE);
		FHKGDJDOKNB = uGCUpdateHandle_t;
		isUpdating = true;
		KAPDFIOHNGL.Set(hAPICall);
	}

	public IEnumerator LoadLevel(string NCHEHDPLJBP)
	{
		mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(mapID);
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if ((bool)eventConfigCanvas)
		{
			eventConfigCanvas.SetActive(true);
		}
		isLevelLoaded = false;
		SetEditedData(levelData);
		isLevelLoaded = true;
		if ((bool)canvasGO.FindDeepChild("EditMenu"))
		{
			canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EventMenu"))
		{
			canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ViewMenu"))
		{
			canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("SaveButton"))
		{
			canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PublishButton"))
		{
			canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
	}

	public void TogglePlay()
	{
		if (asampler.audioSources[1].isPlaying)
		{
			asampler.audioSources[1].Pause();
		}
		else if (asampler.audioSources[1].time < asampler.audioSources[1].clip.length)
		{
			asampler.audioSources[1].Play();
		}
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if ((bool)canvasGO.FindDeepChild("MenuPlayButton"))
		{
			canvasGO.FindDeepChild("MenuPlayButton").GetComponentInChildren<Text>().text = ((!asampler.audioSources[1].isPlaying) ? "PLAY [SPACE]" : "PAUSE [SPACE]");
		}
		if ((bool)canvasGO.FindDeepChild("PlayButton"))
		{
			canvasGO.FindDeepChild("PlayButton").GetComponent<Image>().sprite = ((!asampler.audioSources[1].isPlaying) ? playImage : pauseImage);
		}
	}

	public void OnApplyCustomEventButton(List<string> NKEHMBLLEMH)
	{
		if (EditingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = EditingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			EditingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			EditingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			EditingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + EditingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited event");
		}
	}

	public void IEIHHHBFOKM(float EHHBHEJBHNG)
	{
		float num = EHHBHEJBHNG * asampler.audioSources[1].clip.length;
		if (num < 1415f)
		{
			num = 831f;
		}
		if (num >= asampler.audioSources[1].clip.length)
		{
			num = asampler.audioSources[1].clip.length - 229f;
			asampler.audioSources[1].Pause();
		}
		asampler.audioSources[0].time = num;
		GameObject gameObject = GameObject.Find("LoadMapCanvas");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
	}

	public override void Update()
	{
		base.Update();
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			OnExitButton();
		}
		if (isLevelLoaded)
		{
			if (Singleton<MessageBoxPanel>.Instance.finished && !newLevelCanvas.activeSelf && !loadLevelCanvas.activeSelf && !resourcesCanvas.activeSelf && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
			{
				if (Input.GetKeyDown(KeyCode.Z))
				{
					Singleton<EditorHistoryHandler>.Instance.Undo();
				}
				if (Input.GetKeyDown(KeyCode.Y))
				{
					Singleton<EditorHistoryHandler>.Instance.Redo();
				}
				if (Input.GetMouseButtonDown(2))
				{
					SetZoom(5f);
				}
			}
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				SwichCanvas();
			}
			if (Singleton<MessageBoxPanel>.Instance.finished && !configCanvas.activeSelf && !newLevelCanvas.activeSelf && !loadLevelCanvas.activeSelf && !resourcesCanvas.activeSelf && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					OnEventConfigButton();
				}
				if (!eventConfigCanvas.activeSelf)
				{
					if (Input.GetKeyDown(KeyCode.C))
					{
						GetComponent<CustomEventEditor>().CopyEvent();
					}
					if (Input.GetKeyDown(KeyCode.V))
					{
						GetComponent<CustomEventEditor>().PasteEvent();
					}
				}
			}
			if (!configCanvas.activeSelf && !newLevelCanvas.activeSelf && !loadLevelCanvas.activeSelf && !resourcesCanvas.activeSelf && Singleton<MessageBoxPanel>.Instance.finished && !GetComponent<CustomEventEditor>().isEditing)
			{
				if (Input.mouseScrollDelta.y != 0f)
				{
					if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
					{
						zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 0.2f;
					}
					else
					{
						JDJDHBFKFDG((0f - Input.mouseScrollDelta.y) * Camera.main.orthographicSize * 0.2f);
					}
				}
				if (!isRecording && !GetComponent<CustomEventEditor>().isEditing)
				{
					if (Input.GetKey(KeyCode.LeftArrow))
					{
						JDJDHBFKFDG(-0.1f * Camera.main.orthographicSize);
					}
					if (Input.GetKey(KeyCode.RightArrow))
					{
						JDJDHBFKFDG(0.1f * Camera.main.orthographicSize);
					}
					if (Input.GetKey(KeyCode.UpArrow))
					{
						currentEventsCanvasId = 1;
					}
					if (Input.GetKey(KeyCode.DownArrow))
					{
						currentEventsCanvasId = 0;
					}
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
						DeleteNearestEvent();
					}
					if (Input.GetKeyDown(KeyCode.G))
					{
						Slowmo();
					}
					if (Input.GetKeyDown(KeyCode.H))
					{
						SpeedUp();
					}
				}
			}
			if (eventConfigCanvas.activeSelf)
			{
				FindNearestEvent();
			}
			GOFEKGAKHON.GetComponent<Text>().text = asampler.audioSources[1].time.ToString("0.00");
			DLKGEPIOLDE.value = asampler.audioSources[1].time / Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.musicTime;
			HLNBBDEGLPJ.text = (configCanvas.activeSelf ? "HIDE CONFIG [Ctrl+E]" : "EVENT CONFIG [Ctrl+E]");
		}
		if (isUpdating)
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
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Submition failed", "OK", null);
				isUpdating = false;
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
	}

	public void JFDALKEOGPL(int OFBPACALHFI)
	{
		if (OFBPACALHFI == 0)
		{
			newLevelCanvas.SetActive(false);
		}
		if (OFBPACALHFI == 1)
		{
			StartCoroutine(OECGEKPJPCB());
		}
	}

	public void OnResourcesButton()
	{
		resourcesCanvas.SetActive(!resourcesCanvas.activeSelf);
		configCanvas.SetActive(false);
	}

	public void ShowAcceptLicence()
	{
		StartCoroutine(AcceptLicence());
	}

	public IEnumerator AddNewLevelResoure(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath + "/" + fileInfo.Name;
			Debug.Log("newPath" + text);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.levelResources.Add(item);
			yield return StartCoroutine(Save(false));
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
			ReloadResList();
		}
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null);
	}

	public IEnumerator Save(bool DICJGPOLHPK = true)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Please wait..", string.Empty, null, false);
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData = GetEditedData();
		string nOJGGCLPPAM = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nOJGGCLPPAM, true));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevel(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)), Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath, FullMapData.MapSource.Editor));
		Debug.Log("[LevelEditorScene] Exported to " + fullLevelPath);
		LKJCIHOKJHC = Singleton<EditorHistoryHandler>.Instance.state;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null);
	}

	public void SetEditedData(MapData DNOPDNKBIFB)
	{
		try
		{
			Debug.Log("[LevelEditorScene] Reloaded config for \"" + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(mapID)) + "\"");
			configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelNameInputField").GetComponent<InputField>()
				.text = DNOPDNKBIFB.name;
			configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelInfoInputField").GetComponent<InputField>()
				.text = levelData.info;
			configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelURLInputField").GetComponent<InputField>()
				.text = levelData.moreInfoURL;
			configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>()
				.minValue = 1f;
			configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>()
				.maxValue = MapData.GetLastConfigVersion();
			configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>()
				.value = levelData.configVersion;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("SpeedSlider").GetComponent<Slider>()
				.value = (int)levelData.speed;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("LivesSlider").GetComponent<Slider>()
				.value = levelData.lives;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("MaxLivesSlider").GetComponent<Slider>()
				.value = levelData.maxLives;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("HandsCountSlider").GetComponent<Slider>()
				.value = levelData.handCount;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("EnvironmentSlider").GetComponent<Slider>()
				.value = levelData.environmentType;
			configCanvas.transform.Find("Tab2Content").FindDeepChild("HiddenToggle").GetComponent<Toggle>()
				.isOn = levelData.hidden;
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
				gameObject2.GetComponent<Toggle>().isOn = levelData.tags.Contains(specialTag);
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
				gameObject4.GetComponent<Toggle>().isOn = levelData.tags.Contains(tag);
				gameObject4.GetComponentInChildren<Text>().text = tag;
			}
			PLICILPAOJJ();
			ReloadResList();
			IEnumerator enumerator3 = GameObject.Find("BitsData").transform.GetEnumerator();
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
			foreach (MapEvent @event in levelData.events)
			{
				GameObject gameObject5 = ((@event.data.Count >= 1) ? UnityEngine.Object.Instantiate(customevent) : UnityEngine.Object.Instantiate(bit));
				gameObject5.transform.SetParent(GameObject.Find("BitsData").transform);
				gameObject5.transform.localPosition = new Vector3(@event.time, 0f, 0f);
				gameObject5.GetComponent<EditorEvent>().mapEvent = @event;
				gameObject5.GetComponent<EditorEvent>().UpdateIcon();
				gameObject5.name = "event";
			}
			foreach (float checkpoint in levelData.checkpoints)
			{
				float num = checkpoint;
				GameObject gameObject6 = UnityEngine.Object.Instantiate(this.checkpoint);
				gameObject6.transform.SetParent(GameObject.Find("BitsData").transform);
				gameObject6.transform.localPosition = new Vector3(num, 0f, 0f);
				gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(num);
				gameObject6.GetComponent<EditorEvent>().UpdateIcon();
				gameObject6.name = "checkpoint";
			}
			Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData = new MapData(DNOPDNKBIFB);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.ToString());
		}
		if ((bool)canvasGO.FindDeepChild("UndoButton"))
		{
			canvasGO.FindDeepChild("UndoButton").GetComponent<Button>().interactable = (GetComponent<EditorHistoryHandler>().CanUndo() ? true : false);
		}
		if ((bool)canvasGO.FindDeepChild("RedoButton"))
		{
			canvasGO.FindDeepChild("RedoButton").GetComponent<Button>().interactable = (GetComponent<EditorHistoryHandler>().CanRedo() ? true : false);
		}
	}

	public MapData CKEIKLNDBAI()
	{
		MapData mapData = new MapData(levelData);
		mapData.name = configCanvas.transform.Find(" url: ").Find("#failed!").GetComponent<InputField>()
			.text;
		mapData.info = configCanvas.transform.Find(" elements").Find("LevelProgressBar").GetComponent<InputField>()
			.text;
		mapData.moreInfoURL = configCanvas.transform.Find("[Right]").Find("player.bat").GetComponent<InputField>()
			.text;
		mapData.speed = (int)configCanvas.transform.Find("CameraFilterPack/Film_ColorPerfection").Find("MenuScene").GetComponent<Slider>()
			.value;
		mapData.configVersion = (int)configCanvas.transform.Find("[Left]").FindDeepChild("[").GetComponent<Slider>()
			.value;
		mapData.lives = (int)configCanvas.transform.Find("settings.hitvariation").Find("event").GetComponent<Slider>()
			.value;
		mapData.maxLives = (int)configCanvas.transform.Find("/").Find("Right").GetComponent<Slider>()
			.value;
		mapData.handCount = (int)configCanvas.transform.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.").Find("CameraFilterPack/FX_DigitalMatrix").GetComponent<Slider>()
			.value;
		mapData.environmentType = (int)configCanvas.transform.Find("Case-Sensitive").Find("Please attach component to a Graphical UI component").GetComponent<Slider>()
			.value;
		mapData.hidden = configCanvas.transform.Find("action").Find("_NoiseTex").GetComponent<Toggle>()
			.isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(mapID).clip != null)) ? 1676f : Singleton<MapsSystem>.Instance.GetMapData(mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 1)
		{
			mapData.tags.Add("default");
		}
		else if (mapData.handCount == 0)
		{
			mapData.tags.Add(" Path: ");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			InputField inputField = componentsInChildren2[j];
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("settings.volume.editor").transform.childCount; k++)
		{
			if (GameObject.Find("ConfigVersionSlider").transform.GetChild(k).name == "_ScreenResolution")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("_Distortion").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		mapData.events = mapData.events.OrderBy((MapEvent HPHENPOHOMK) => HPHENPOHOMK.time).ToList();
		mapData.checkpoints.Clear();
		for (int l = 1; l < GameObject.Find("gamemode").transform.childCount; l++)
		{
			if (GameObject.Find("Joystick").transform.GetChild(l).name == "maps.")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("speed").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		mapData.checkpoints = mapData.checkpoints.OrderBy((float HPHENPOHOMK) => HPHENPOHOMK).ToList();
		return mapData;
	}

	private bool JKGBHDKDJEC(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == eventConfigCanvas.transform.Find("A").GetComponent<DropDownList>().SelectedItem.MMBHKENLACB();
	}

	private IEnumerator OECGEKPJPCB()
	{
		string text = canvasGO.FindDeepChild("LevelFolderInputField").GetComponent<InputField>().text;
		string result = canvasGO.FindDeepChild("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = canvasGO.FindDeepChild("MusicFileSelector").GetComponent<FileSelector>().result;
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text);
			Helpers.ObtainAchievement(10);
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			mapID = "editor." + text;
			StartCoroutine(UpdateEditorLevelAssets(Helpers.GetDirectory("Editor/" + text), result, result2, true, text));
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Already exist!", "OK", null);
		}
	}

	public void OnAddNewResourceButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Working.\nPlease wait..", string.Empty, null, false);
		string text = GameObject.Find("ResourceIDInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("ResourceFileSelector").GetComponent<FileSelector>().result;
		StartCoroutine(AddNewLevelResoure(text, result));
	}

	public void ScrollTo(float EFGFCMLOJJE)
	{
		SetTime(EFGFCMLOJJE);
	}

	private void EOPEBLJJBFM(float EHHBHEJBHNG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(checkpoint);
		gameObject.transform.SetParent(GameObject.Find("BitsData").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 0f, 0f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG);
		gameObject.name = "checkpoint";
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added checkpoint");
	}

	public void KGPEDICAGAB(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("[Up-Right-Left]");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	public IEnumerator ConfirmExiting()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Exit to menu?", "YES"));
		if (Singleton<MessageBoxPanel>.Instance.result != 1)
		{
			yield break;
		}
		if (!isLevelLoaded)
		{
			Exit();
			yield break;
		}
		if (Singleton<EditorHistoryHandler>.Instance.state != LKJCIHOKJHC)
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save the map before exiting?", "YES", null, "NO"));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return StartCoroutine(Save());
			}
		}
		Exit();
	}

	private bool ABLKMEFBDAJ(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == eventConfigCanvas.transform.Find("settings_bindings_").GetComponent<DropDownList>().SelectedItem.ID;
	}

	public void OnSaveButton()
	{
		StartCoroutine(Save());
	}

	private IEnumerator KKDHPBOFIFH(string BNJFKKGOACF)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(BNJFKKGOACF);
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(directoryInfo.Name, BNJFKKGOACF, FullMapData.MapSource.Editor));
		OnLoadLevelButton();
	}

	public void OnLoadLevelButton()
	{
		StartCoroutine(PopulateLevelsList());
	}

	public void OnAddButton(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			ONBJNLMBDPI(asampler.audioSources[1].time, new List<string> { "SetPlayerDistance", "14" });
		}
		if (HMGBJCGOLMI == 1)
		{
			EOPEBLJJBFM(asampler.audioSources[1].time);
		}
	}

	public void AddRecordedEventGO(string NOJGGCLPPAM, int PGJECADBIOI)
	{
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount < 2)
		{
			if (NOJGGCLPPAM == "[Up]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData()
				});
			}
		}
		else
		{
			if (NOJGGCLPPAM == "[Up]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				ONBJNLMBDPI(asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData() + "," + PGJECADBIOI
				});
			}
		}
	}

	public void OKIIKJBOGFK()
	{
		StartCoroutine(ConfirmExiting());
	}

	private IEnumerator APFOMADCGBO()
	{
		Debug.Log("[MapEditor] Loading map: " + mapID);
		isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(mapID);
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(mapID)));
		levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData);
		yield return StartCoroutine(JINABPAAGGF());
		RebuildGridAndCaret();
		if ((bool)eventConfigCanvas)
		{
			eventConfigCanvas.SetActive(true);
		}
		SetEditedData(levelData);
		StartCoroutine(NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init");
		asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		asampler.audioSources[1].Pause();
		ScrollTo(0f);
		isLevelLoaded = true;
		OnLoaded.Invoke();
		if ((bool)canvasGO.FindDeepChild("EditMenu"))
		{
			canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("EventMenu"))
		{
			canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("GenerationMenu"))
		{
			canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("ViewMenu"))
		{
			canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("SaveButton"))
		{
			canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("LevelConfigButton"))
		{
			canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
		if ((bool)canvasGO.FindDeepChild("PublishButton"))
		{
			canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = isLevelLoaded;
		}
	}

	public void OnLoadMusicFile()
	{
		string result = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(mapID).fullLevelPath;
		StartCoroutine(UpdateEditorLevelAssets(fullLevelPath, null, result, true, string.Empty));
	}

	private GameObject MMNDDEMPFKJ()
	{
		float num = 1555f;
		GameObject result = null;
		Transform transform = GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("' ping: ").transform.childCount; i += 0)
		{
			GameObject gameObject = GameObject.Find("USE_UV_BASED_REPROJECTION").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	public IEnumerator KOCDHCKALGO()
	{
		newLevelCanvas.SetActive(false);
		loadLevelCanvas.SetActive(true);
		GameObject gameObject = levelsSelectorListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		foreach (string key in Singleton<MapsSystem>.Instance.levelsData.Keys)
		{
			FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[key];
			if (fullMapData.source != FullMapData.MapSource.Editor)
			{
				continue;
			}
			Singleton<MapsSystem>.Instance.LoadLevel(key);
			GameObject gameObject2 = UnityEngine.Object.Instantiate(loadLevelElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<LevelsSelectorListElement>().levelid = key;
			gameObject2.transform.Find("NameText").GetComponent<Text>().text = key + " [" + fullMapData.mapData.name + "]" + ((!string.IsNullOrEmpty(fullMapData.workshopId)) ? (" - PUBLISHED #" + fullMapData.workshopId) : " - LOCAL");
			if ((bool)gameObject2.transform.Find("IconImage"))
			{
				if (fullMapData.icon != null)
				{
					gameObject2.transform.Find("IconImage").GetComponent<Image>().sprite = fullMapData.icon;
				}
				else
				{
					StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(gameObject2.transform.Find("IconImage").GetComponent<Image>(), fullMapData));
				}
			}
		}
		if (num == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(listMessageElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject3.transform.SetParent(gameObject.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.transform.Find("MessageText").GetComponent<Text>().text = "MAPS NOT FOUND";
		}
		yield break;
	}

	public void SwichCanvas()
	{
		currentEventsCanvasId = ((currentEventsCanvasId == 0) ? 1 : 0);
	}

	public void BGMCCPPBLBN()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("[PlayerBase] Ready", string.Empty, null, true, false, 1949f);
		string text = GameObject.Find("note.6").GetComponent<InputField>().text;
		string result = GameObject.Find("UI Extensions/SoftMaskShader").GetComponent<FileSelector>().result;
		StartCoroutine(AddNewLevelResoure(text, result));
	}
}
