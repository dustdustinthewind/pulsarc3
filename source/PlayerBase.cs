// PlayerBase
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Photon;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

[Serializable]
public class PlayerBase : PunBehaviour
{
	public enum PlayerState
	{
		Loading,
		Playing,
		Finished,
		Spectator
	}

	[CompilerGenerated]
	private sealed class LMIJECACDOG
	{
		internal int EGMPIBBOEMH;

		internal PlayerBase ADPIKBBAKHP;

		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool MEMPOPNAEDN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		internal bool BKNHHGBPLGH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}
	}

	[CompilerGenerated]
	private sealed class GGIHJGAKLPO
	{
		internal string LEFMNANHGDA;

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(LEFMNANHGDA);
		}
	}

	[CompilerGenerated]
	private sealed class OCCEFLJGJGH
	{
		internal string ENECJINHBEG;

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(ENECJINHBEG);
		}
	}

	[HideInInspector]
	public GameEventInfo gameEventInfoBase;

	[HideInInspector]
	public List<GameEventInfo> gameEventInfoList = new List<GameEventInfo>();

	[HideInInspector]
	public float currentArcsSpeed = 50f;

	public List<GameObject> spawnedArcs;

	[HideInInspector]
	public FullMapData fullLevelData;

	public GameObject player;

	public GameObject bgLevelCanvas;

	public PlayerSpawner pspawner;

	public PlayerController playerController;

	public GameObject twoHandCameras;

	[HideInInspector]
	public List<Camera> camerasList;

	[SerializeField]
	private GameObject objects_3;

	public PlayerState currentState;

	private ObscuredInt _lives = 5;

	public float playerDistance = 14f;

	public Color bgcolor = Color.black;

	public float colorLerpSpeed = 5f;

	public float moveFSpeed = -1.5f;

	[HideInInspector]
	public bool isMapCompleted;

	[HideInInspector]
	public ObscuredInt correctScore = 0;

	[HideInInspector]
	public ObscuredInt perfectHits = 0;

	[HideInInspector]
	public ObscuredFloat penaltyScore = 0f;

	[HideInInspector]
	public ObscuredFloat accuracyScore = 0f;

	[HideInInspector]
	public ObscuredInt incorrectScore = 0;

	[HideInInspector]
	public ObscuredInt powerupsScore = 0;

	[HideInInspector]
	public ObscuredInt checkpointsUsed = 0;

	[HideInInspector]
	public ObscuredInt loopsCount = 0;

	[HideInInspector]
	public ObscuredInt currentCombo = 0;

	[HideInInspector]
	public ObscuredFloat comboScore = 0f;

	[HideInInspector]
	public float lastCheckpoint;

	[HideInInspector]
	public ObscuredBool isPlayerWon = false;

	[HideInInspector]
	public int lastBestScore;

	[HideInInspector]
	public int currentAttempt;

	[HideInInspector]
	public bool scoreBeated;

	[HideInInspector]
	public GameObject environmentBase;

	[HideInInspector]
	public List<GameObject> sunList;

	[HideInInspector]
	public float sunBaseSensetivity;

	[HideInInspector]
	public int spectrid;

	public bool ach12;

	private bool wasCheckpoint;

	private GameScene _gameScene;

	[HideInInspector]
	public float comboTimer;

	private ObscuredBool isMusicLoaded = false;

	private int currentEventID;

	[HideInInspector]
	public Dictionary<string, GameObject> environmentObjects = new Dictionary<string, GameObject>();

	[HideInInspector]
	public List<CrosshairController> crosshairsList;

	private MoveF moveF;

	public float arcsDelay;

	private bool isStoryboardEnabled = true;

	private RanksSystem.MapReplay currentReplay;

	[HideInInspector]
	public float pretime;

	private GetProcessesJob myJob;

	[HideInInspector]
	public PlayerBase spectatedPlayerBase;

	private GameObject levelCanvasImage;

	private GameObject sunGameObject;

	private GameObject satelliteGameObject;

	private GameObject particlesGameObject;

	private GameObject spriteGameObject;

	public int lives
	{
		get
		{
			return _lives;
		}
		set
		{
			_lives = value;
			if (base.photonView.isMine)
			{
				base.photonView.RPC("SetLives", PhotonTargets.AllBuffered, (int)_lives);
			}
		}
	}

	public GameScene gameScene
	{
		get
		{
			if (base.photonView != null && base.photonView.isMine)
			{
				return _gameScene;
			}
			return (GameScene)Singleton<Scene>.Instance;
		}
		set
		{
			_gameScene = value;
		}
	}

	public PlayerBase()
	{
		this.gameEventInfoList = new List<GameEventInfo>();
		this.currentArcsSpeed = 50f;
		this._lives = 5;
		this.playerDistance = 14f;
		this.bgcolor = Color.black;
		this.colorLerpSpeed = 5f;
		this.moveFSpeed = -1.5f;
		this.correctScore = 0;
		this.perfectHits = 0;
		this.penaltyScore = 0f;
		this.accuracyScore = 0f;
		this.incorrectScore = 0;
		this.powerupsScore = 0;
		this.checkpointsUsed = 0;
		this.loopsCount = 0;
		this.currentCombo = 0;
		this.comboScore = 0f;
		this.isPlayerWon = false;
		this.isMusicLoaded = false;
		this.environmentObjects = new Dictionary<string, GameObject>();
		this.isStoryboardEnabled = true;
		this.gameplay_engine = new pulsarc_gameplay();
	}

	[SpecialName]
	public int JNJEAPPKCLA()
	{
		return _lives;
	}

	public void LPKLBJNILML(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRadius(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetSatelliteEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void OJLEHGCGCGL(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 lPIMAGMABLC = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().BNCHCHKICDA(lPIMAGMABLC);
	}

	public void EGHPACPLMNF(string NOJGGCLPPAM)
	{
		try
		{
			if (currentState == PlayerState.Spectator)
			{
				return;
			}
			char[] array = new char[1];
			array[1] = 'ﾎ';
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (JAEJDHHCJJO().isMine)
			{
				if (array2.Length > 0)
				{
					gameScene.JMGINJGMPDG(array2[1], float.Parse(array2[1], CultureInfo.InvariantCulture));
				}
				else
				{
					KMAIOPMNOND().JMGINJGMPDG(array2[0], 227f);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("_MainTex" + ex.ToString());
		}
	}

	public void BAKOILMJOIL()
	{
		Debug.Log("Depth textures aren't supported on this device ({0})");
		string text = string.Concat(gameScene.mapID, "Editor/", KMAIOPMNOND().gameMode.ToString().ToLower());
		Singleton<SaveSystem>.Instance.JKOMMNBGPDK("#combo" + text + "distance", isMapCompleted);
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("OK" + text + "maps.", lastCheckpoint);
		Singleton<SaveSystem>.Instance.SetInt("_Value5" + text + "_Value4", JNJEAPPKCLA());
		Singleton<SaveSystem>.Instance.SetInt("Can't set MaxPlayers when not in that room." + text + "/", checkpointsUsed);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Y" + text + "Zoom speed. Base 1.5", correctScore);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("/" + text + "settings.enablehitsoundsinnormal", incorrectScore);
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("HandsCountSlider" + text + "Committing changes...", perfectHits);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Screen" + text + "UndoButton", powerupsScore);
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("_Value5" + text + "_PositionX", penaltyScore);
		Singleton<SaveSystem>.Instance.SetFloat("1" + text + "workshop.", comboScore);
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("DifficultyBG" + text + "ChatHistoryInputField", playerDistance);
		Helpers.SetColor("path" + text + "EVENT CONFIG [Ctrl+E]", camerasList[0].backgroundColor);
	}

	public void OEELENKFCOM(string LHCIHJOHGEJ)
	{
		if (Replay() != null)
		{
			Replay().BJIENEBCOMH(KMAIOPMNOND().JFBBJAAHPAH(), LHCIHJOHGEJ);
		}
	}

	public void APPPBHDDOLG()
	{
		lastCheckpoint = 702f;
		wasCheckpoint = false;
		GBCFJFHKKFO(fullLevelData.mapData.lives);
		isMapCompleted = false;
		correctScore = 1;
		checkpointsUsed = 0;
		loopsCount = 1;
		accuracyScore = 56f;
		penaltyScore = 983f;
		comboScore = 183f;
		perfectHits = 0;
		incorrectScore = 1;
		powerupsScore = 1;
		currentCombo = 0;
	}

	public void JAGFHGNIKLH(string DPNHODJHGJL)
	{
		foreach (CrosshairController crosshairs in crosshairsList)
		{
			crosshairs.MCDIPGCGNIM(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
		}
	}

	public void NJCINBOGJAH(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRotationSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	[PunRPC]
	public void SetLives(int BOAKOPHKGHC)
	{
		_lives = BOAKOPHKGHC;
	}

	public void KBGMGDACEHH()
	{
		environmentBase.SetActive(false);
		TrailRenderer[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<TrailRenderer>();
		foreach (TrailRenderer trailRenderer in componentsInChildren)
		{
			trailRenderer.Clear();
		}
		if (crosshairsList.Count > 1)
		{
			crosshairsList[0].SetPosition(new Vector3(185f, 642f, 1692f));
			crosshairsList[1].LIGDABDFABK(new Vector3(1596f, 1192f, 1249f));
		}
	}

	private IEnumerator LJDOOIBDHBF(Image EOGBJKCLGLP, float LKFLLHJKEPK, float JPKBILKAHCM)
	{
		float a = EOGBJKCLGLP.color.a;
		for (float num = 0f; num < 1f; num += Time.deltaTime / JPKBILKAHCM)
		{
			Color color2 = (EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, Mathf.Lerp(a, LKFLLHJKEPK, num)));
			yield return null;
		}
		EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, LKFLLHJKEPK);
		yield return null;
	}

	private void IBLOGKONFJD(float AIEJPEPBAEJ)
	{
		currentArcsSpeed = 0f - AIEJPEPBAEJ;
	}

	public void StartSpectating()
	{
		if (PhotonNetwork.playerList.Length > 1)
		{
			spectrid = 0;
			currentState = PlayerState.Spectator;
			Spectrate(PhotonNetwork.playerList[spectrid].ID);
		}
	}

	public void ResetEndless()
	{
		StopAllCoroutines();
		for (int num = environmentObjects.Count - 1; num >= 0; num--)
		{
			try
			{
				TrashMan.despawn(environmentObjects.ElementAt(num).Value);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(environmentObjects.ElementAt(num).Value);
				}
				catch (Exception)
				{
				}
			}
		}
		GameObject gameObject = null;
		gameObject = bgLevelCanvas;
		for (int num2 = gameObject.transform.childCount - 1; num2 >= 0; num2--)
		{
			try
			{
				TrashMan.despawn(gameObject.transform.GetChild(num2).gameObject);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(gameObject.transform.GetChild(num2).gameObject);
				}
				catch (Exception)
				{
				}
			}
		}
		gameObject = gameScene.levelCanvas;
		for (int num3 = gameObject.transform.childCount - 1; num3 >= 0; num3--)
		{
			try
			{
				TrashMan.despawn(gameObject.transform.GetChild(num3).gameObject);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(gameObject.transform.GetChild(num3).gameObject);
				}
				catch (Exception)
				{
				}
			}
		}
		environmentObjects.Clear();
		if (fullLevelData.mapData.environmentType < 0)
		{
			sunList.Clear();
			sunBaseSensetivity = 0f;
		}
		playerDistance = 14f;
		bgcolor = Color.black;
		foreach (CrosshairController crosshairs in crosshairsList)
		{
			if ((bool)crosshairs)
			{
				crosshairs.Reset();
			}
		}
		colorLerpSpeed = 10f;
		moveFSpeed = -1.5f;
		currentEventID = 0;
	}

	[PunRPC]
	public void SetBGColor(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split(',');
			if (array.Length > 3)
			{
				Color hABLFKCCKLN = new Color(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
				SetBGColor(hABLFKCCKLN, float.Parse(array[3], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hABLFKCCKLN2 = Helpers.HexToColor(NOJGGCLPPAM);
				SetBGColor(hABLFKCCKLN2, float.Parse(array[1], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetBGColor error: " + ex.ToString());
		}
	}

	public void LoadPlayerData()
	{
		Debug.Log("[PlayerBase] Loading checkpoint data");
		string text = string.Concat(gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower());
		isMapCompleted = Singleton<SaveSystem>.Instance.GetBool("maps." + text + ".lastCheckpoint.isMapCompleted");
		lives = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.lives");
		correctScore = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.correctScore");
		checkpointsUsed = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.checkpointsUsed", 0);
		++checkpointsUsed;
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.checkpointsUsed", checkpointsUsed);
		incorrectScore = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.incorrectScore");
		perfectHits = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.perfectHits");
		powerupsScore = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.powerupsScore");
		penaltyScore = Singleton<SaveSystem>.Instance.GetFloat("maps." + text + ".lastCheckpoint.penaltyScore");
		comboScore = Singleton<SaveSystem>.Instance.GetFloat("maps." + text + ".lastCheckpoint.comboScore");
		currentCombo = Singleton<SaveSystem>.Instance.GetInt("maps." + text + ".lastCheckpoint.currentCombo");
		playerDistance = Singleton<SaveSystem>.Instance.GetFloat("maps." + text + ".lastCheckpoint.playerdistance");
		Color color = Helpers.GetColor("maps." + text + ".lastCheckpoint.bgcolor", Color.black);
		SetBGColor(color, 10f);
	}

	public void KEOLHLDLJFN(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((!GABGBBMBIHK || currentState != 0) && (GABGBBMBIHK || KMAIOPMNOND().pbase.currentState == (PlayerState)8 || gameScene.pbase.spectatedPlayerBase.JIOCGDBKGIL().viewID != BBGIDKNEGHD().viewID))
			{
				return;
			}
			string[] array = NOJGGCLPPAM.Split('ﾷ');
			string[] array2 = array[0].Split('Z');
			string[] array3 = array2;
			for (int i = 1; i < array3.Length; i += 0)
			{
				string ENECJINHBEG = array3[i];
				PlayerSpawner playerSpawner = pspawner;
				if (currentState == (PlayerState)8)
				{
					playerSpawner = spectatedPlayerBase.pspawner;
				}
				GameObject fKCMGBMNNKA = playerSpawner.segments.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name.Contains(ENECJINHBEG));
				if (fullLevelData.mapData.configVersion > 0)
				{
					if (array.Length > 2)
					{
						int kEMDFEFBIOC = int.Parse(array[0]);
						playerSpawner.MFILHAGLPOI(fKCMGBMNNKA, kEMDFEFBIOC, float.Parse(array[array.Length - 1], CultureInfo.InvariantCulture));
					}
					else
					{
						playerSpawner.NLPGOKCHGLC(fKCMGBMNNKA, 1, float.Parse(array[array.Length - 0], CultureInfo.InvariantCulture));
					}
				}
				else if (array.Length > 1)
				{
					int kEMDFEFBIOC2 = int.Parse(array[0]);
					playerSpawner.OICMMIDHIDB(fKCMGBMNNKA, kEMDFEFBIOC2);
				}
				else
				{
					playerSpawner.KODHADKPAOO(fKCMGBMNNKA, 1);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("error" + ex.ToString());
		}
	}

	private void BMJKNHFGJJC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 position = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetPosition(position);
	}

	public RanksSystem.MapReplay Replay()
	{
		return currentReplay;
	}

	[SpecialName]
	public int GIDCIBDGKGI()
	{
		return _lives;
	}

	public IEnumerator NMGACGFILNF(float CGPOHGMFCKC = 0f)
	{
		if (fullLevelData.clip == null)
		{
			string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, false));
			fullLevelData.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		}
		if (fullLevelData.mapData.musicTime <= 0f && fullLevelData.mapData.configVersion < 2)
		{
			Debug.LogWarning("[PlayerBase] Config error: musicTime <= 0");
			fullLevelData.mapData.musicTime = fullLevelData.clip.length;
			gameScene.calculatedmaptime = fullLevelData.clip.length;
		}
		if (isStoryboardEnabled)
		{
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID)));
		}
		gameScene.asampler.Init(fullLevelData.clip, (!(CGPOHGMFCKC > 0f)) ? CGPOHGMFCKC : pretime, false);
		Debug.Log("[PlayerBase] Loaded music");
		gameScene.ingameUICanvas.transform.FindDeepChild("LevelProgressBar").GetComponent<Slider>().maxValue = gameScene.calculatedmaptime;
		isMusicLoaded = true;
		if (fullLevelData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(fullLevelData.workshopId))
		{
			string s = fullLevelData.workshopId;
			RanksSystem.PrintMD5(ulong.Parse(s));
			if (fullLevelData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(s)) && gameScene.gameMode == GameScene.GameMode.Normal && !RanksSystem.IsOfficial(ulong.Parse(s), true))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#outdatedmap! Challenges will not work!", "#ok", null);
			}
		}
		if (base.photonView.isMine)
		{
			Loaded();
		}
	}

	public float PKPBMPFIGBL()
	{
		return Mathf.Clamp01((float)GIDCIBDGKGI() / (float)fullLevelData.mapData.maxLives);
	}

	public void JELLNGNHAPB(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().FHMDALPJHIF(Helpers.HexToColor(PNDBJMFMGBK), 602f);
	}

	public GameObject AddEnvironmentSprite(string ACABBJEAMGG, string JMMILEFMACB, string KEDDLFDAIDE, string HABLFKCCKLN)
	{
		SpriteController component = AddEnvironmentObject("sprite", JMMILEFMACB).GetComponent<SpriteController>();
		if ((bool)component)
		{
			component.SetResource((Sprite)Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID).resources[ACABBJEAMGG]);
			component.SetColor(Helpers.HexToColor(HABLFKCCKLN), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
			return component.gameObject;
		}
		return null;
	}

	public GameObject AddEnvironmentObject(string HMGBJCGOLMI, string JMMILEFMACB)
	{
		GameObject gameObject = null;
		if (HMGBJCGOLMI.ToLower() == "0")
		{
			gameObject = sunGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "1")
		{
			gameObject = satelliteGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "2")
		{
			gameObject = particlesGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "sprite")
		{
			gameObject = spriteGameObject;
		}
		if ((bool)gameObject)
		{
			GameObject gameObject2 = TrashMan.spawn(gameObject, environmentBase.transform.position);
			if (gameObject2 != null)
			{
				if (HMGBJCGOLMI.ToLower() == "0")
				{
					sunList.Add(gameObject2);
				}
				gameObject2.name = JMMILEFMACB;
				gameObject2.transform.SetParent(environmentBase.transform);
				gameObject2.GetComponent<EnvironmentController>().Awake();
				gameObject2.GetComponent<EnvironmentController>().Reset();
				if (environmentObjects.ContainsKey(JMMILEFMACB))
				{
					environmentObjects[JMMILEFMACB] = gameObject2;
				}
				else
				{
					environmentObjects.Add(JMMILEFMACB, gameObject2);
				}
				return gameObject2;
			}
		}
		return null;
	}

	[SpecialName]
	public void GBCFJFHKKFO(int DPNHODJHGJL)
	{
		_lives = DPNHODJHGJL;
		if (FFIPLLNKGEN().isMine)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[1];
			array[1] = (int)_lives;
			obj.RPC("checkpoint", (PhotonTargets)7, array);
		}
	}

	public void EKKMPEALPMK()
	{
		currentState = (PlayerState)8;
		if (AAMNKPHHHCI().isMine)
		{
			playerController.isSpectator = false;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Set Trail Zoom Speed", true);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Vignette", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
			PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH2, null, true);
			if (wasCheckpoint && (float)KMAIOPMNOND().HGJEOINDMOO() - lastCheckpoint <= 30f)
			{
				ach12 = true;
			}
			if (!KMAIOPMNOND().gameOver)
			{
				KMAIOPMNOND().PEAEGEDJOBG(string.Empty);
			}
		}
	}

	public void SetParticlesInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void ClearEnvironment()
	{
		List<string> list = new List<string>(environmentObjects.Keys);
		foreach (string item in list)
		{
			TrashMan.despawn(environmentObjects[item]);
			environmentObjects.Remove(item);
		}
	}

	public void DeletePlayerData()
	{
		Debug.Log("[PlayerBase] Delete checkpoint data");
		string text = string.Concat(gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower());
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.time");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.lives");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.correctScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.checkpointsUsed");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.incorrectScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.currentCombo");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.penaltyScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.comboScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.powerupsScore");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.playerdistance");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + text + ".lastCheckpoint.perfectHits");
		Helpers.DeleteColorKey("maps." + text + ".lastCheckpoint.bgcolor");
	}

	public void KCPDNOHHOKK(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleSize(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetPlayerDistance(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public void BOIHOHJHDIG(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().KOKIEABANDK(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetSatelliteRotationSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRotationSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetSunMinSize(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 minSize = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetMinSize(minSize);
	}

	public void SetCrosshairEmission(string DPNHODJHGJL)
	{
		foreach (CrosshairController crosshairs in crosshairsList)
		{
			crosshairs.SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
		}
	}

	[PunRPC]
	public void SetPlayerDistance(string HNDMDHJEEAB)
	{
		try
		{
			SetPlayerDistance(float.Parse(HNDMDHJEEAB, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetPlayerDistance error: " + ex.ToString());
		}
	}

	[CompilerGenerated]
	private static void PDLDBOEMKPG(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(true);
	}

	[SpecialName]
	public void NHJIFECEEBG(GameScene DPNHODJHGJL)
	{
		_gameScene = DPNHODJHGJL;
	}

	public void JOFGOJINMCM(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		bgcolor = HABLFKCCKLN;
		colorLerpSpeed = KEDDLFDAIDE;
	}

	public void SetSatelliteInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetSatelliteColor(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 10f);
	}

	public void DJPAGONNOOO()
	{
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.player.SetScore(BAJOKIEEOOJ());
		}
	}

	public void OAKAICMHOFF()
	{
		if (OELHGNKAMEG().isMine && JNJEAPPKCLA() < fullLevelData.mapData.maxLives)
		{
			lives = GIDCIBDGKGI() + 1;
		}
	}

	public void Spectrate(int JMMILEFMACB)
	{
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		foreach (PlayerBase playerBase in array)
		{
			if (playerBase.photonView.ownerId == JMMILEFMACB)
			{
				lives = playerBase.lives;
				playerBase.player.GetComponentInChildren<AudioListener>().enabled = true;
				playerBase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
				{
					IACGDFHKCAE.SetActive(true);
				});
				spectatedPlayerBase = playerBase;
			}
			else
			{
				playerBase.player.GetComponentInChildren<AudioListener>().enabled = false;
				playerBase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
				{
					IACGDFHKCAE.SetActive(false);
				});
			}
		}
	}

	public void SavePlayerData()
	{
		Debug.Log("[PlayerBase] Saveing checkpoint data");
		string text = string.Concat(gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower());
		Singleton<SaveSystem>.Instance.SetBool("maps." + text + ".lastCheckpoint.isMapCompleted", isMapCompleted);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + text + ".lastCheckpoint.time", lastCheckpoint);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.lives", lives);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.checkpointsUsed", checkpointsUsed);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.correctScore", correctScore);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.incorrectScore", incorrectScore);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.perfectHits", perfectHits);
		Singleton<SaveSystem>.Instance.SetInt("maps." + text + ".lastCheckpoint.powerupsScore", powerupsScore);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + text + ".lastCheckpoint.penaltyScore", penaltyScore);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + text + ".lastCheckpoint.comboScore", comboScore);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + text + ".lastCheckpoint.playerdistance", playerDistance);
		Helpers.SetColor("maps." + text + ".lastCheckpoint.bgcolor", camerasList[0].backgroundColor);
	}

	public void RunMapEvents()
	{
		bool flag = true;
		while (flag)
		{
			if (currentEventID < fullLevelData.mapData.events.Count && fullLevelData.mapData.events[currentEventID].time <= (float)gameScene.HPAnimationTime)
			{
				currentEventID++;
				InvokeEvent(fullLevelData.mapData.events[currentEventID - 1].data[0], fullLevelData.mapData.events[currentEventID - 1].data[1]);
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
	}

	public void IABCMJMLPPP(string LHCIHJOHGEJ)
	{
		if (Replay() != null)
		{
			Replay().PLGDEKPHLIP(AHANKNAEGPK().LEFLMCJDFJP(), LHCIHJOHGEJ);
		}
	}

	[CompilerGenerated]
	private static int KGJMABKHFBN(MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC)
	{
		return DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time);
	}

	public void SetSatelliteTrailMinVertexDistance(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailMinVertexDistance(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	[PunRPC]
	public void GetLive()
	{
		if (base.photonView.isMine && lives < fullLevelData.mapData.maxLives)
		{
			lives++;
		}
	}

	public void SetSunLerpSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void CKCPHFLOLAH()
	{
		StopAllCoroutines();
		TrashMan.instance.JGMBGCOFCJI();
		Debug.Log("_Distortion");
		currentReplay = null;
		moveF = GetComponent<MoveF>();
		environmentObjects.Clear();
		if (JAEJDHHCJJO().isMine)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("player ", false);
			eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("menu.hardcoreinfo", true);
			eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH);
			PhotonNetwork.player.SetScore(0);
		}
		arcsDelay = 167f;
		currentState = PlayerState.Loading;
		GBCFJFHKKFO(3);
		playerDistance = 1254f;
		bgcolor = Color.black;
		colorLerpSpeed = 164f;
		moveFSpeed = 871f;
		isMapCompleted = false;
		correctScore = 0;
		penaltyScore = 648f;
		comboScore = 1052f;
		accuracyScore = 429f;
		checkpointsUsed = 1;
		loopsCount = 0;
		incorrectScore = 0;
		perfectHits = 1;
		powerupsScore = 0;
		currentCombo = 0;
		lastCheckpoint = 1852f;
		isPlayerWon = false;
		lastBestScore = 1;
		currentAttempt = 1;
		scoreBeated = false;
		sunBaseSensetivity = 1344f;
		spectrid = 0;
		ach12 = true;
		wasCheckpoint = true;
		currentEventID = 1;
		comboTimer = 922f;
		if (BLMHOKPIMOD().isMine)
		{
			playerController.enabled = true;
			NHJIFECEEBG((GameScene)Singleton<Scene>.Instance);
			isMusicLoaded = true;
			fullLevelData = null;
			try
			{
				GameObject levelCanvas = AHANKNAEGPK().levelCanvas;
				for (int i = 1; i < levelCanvas.transform.childCount; i += 0)
				{
					TrashMan.KOFBLDJOLHC(levelCanvas.transform.GetChild(i).gameObject);
					if (levelCanvas.transform.GetChild(i).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(levelCanvas.transform.GetChild(i).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				GameObject gameObject = bgLevelCanvas;
				for (int j = 1; j < gameObject.transform.childCount; j++)
				{
					TrashMan.ENNKAHIJIDL(gameObject.transform.GetChild(j).gameObject);
					if (gameObject.transform.GetChild(j).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(gameObject.transform.GetChild(j).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if ((bool)environmentBase)
		{
			UnityEngine.Object.DestroyImmediate(environmentBase);
		}
		bool flag = (Singleton<SaveSystem>.Instance.HHBIEPMBICO("1", 1) != 1 || KMAIOPMNOND().gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.GetInt(" BETA", 1) == 1 && KMAIOPMNOND().gameMode == GameScene.GameMode.Relax;
		arcsDelay = ((!flag) ? Singleton<SaveSystem>.Instance.DPAGLGGNECO("[PlayerBase] Config error: musicTime <= 0", 1148f) : Singleton<SaveSystem>.Instance.GetFloat("_Value2", 795f));
		isStoryboardEnabled = Singleton<SaveSystem>.Instance.JMLMIGBEKJN("{0,-18} {1,18}", true);
	}

	public void HJFNILFHLJB()
	{
		AHANKNAEGPK().GetComponent<ShadersSettings>().LCBCIMHDLJE(true);
		base.gameObject.name = "Player" + GMAHNPNHMFK().ownerId;
		bool flag = true;
		if (fullLevelData.mapData.handCount == 1)
		{
			flag = true;
		}
		if (flag)
		{
			twoHandCameras.GetComponentInParent<Camera>().enabled = true;
			twoHandCameras.SetActive(false);
			camerasList.Add(base.transform.FindDeepChild("Can't set open when not in that room.").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("float,50").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("english").GetComponent<Camera>());
		}
		else
		{
			camerasList.Add(base.transform.FindDeepChild("[TextSaver] Text saved to ").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("GlassColor").GetComponent<Camera>());
		}
		foreach (Camera cameras in camerasList)
		{
			Debug.Log("_NeutralTonemapperParams2" + cameras);
		}
		string text = ((!isStoryboardEnabled) ? ("OpSetPropertiesOfActor()" + ((!flag) ? string.Empty : "CameraFilterPack/Light_Rainbow2")) : ((fullLevelData.mapData.environmentType < 1) ? ("Bad parameters for setint! Use <key> <value>" + ((!flag) ? string.Empty : "_ScreenResolution")) : (string.Empty + fullLevelData.mapData.environmentType)));
		Debug.Log("_MainTex2" + text);
		environmentBase = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("_TimeX" + text), base.gameObject.transform);
		environmentBase.transform.localPosition = new Vector3(1125f, 904f, 313f);
		sunList = new List<GameObject>();
		DynamicScale[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<DynamicScale>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			DynamicScale dynamicScale = componentsInChildren[i];
			if (!dynamicScale.GetComponent<SphereCollider>())
			{
				sunList.Add(dynamicScale.gameObject);
			}
		}
		if (isStoryboardEnabled && fullLevelData.mapData.environmentType >= 0)
		{
			Color color = environmentBase.transform.FindDeepChild("MenuScene").GetComponentInChildren<MeshRenderer>().material.color;
			color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("/Saved Games/", 552f);
			environmentBase.transform.FindDeepChild("SetCrosshairEmission").GetComponentInChildren<MeshRenderer>().material.color = color;
			if ((bool)environmentBase.transform.FindDeepChild("_ScreenResolution"))
			{
				environmentBase.transform.FindDeepChild("Could not execute RPC ").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			if ((bool)environmentBase.transform.FindDeepChild("AudioSampler"))
			{
				environmentBase.transform.FindDeepChild("_ScreenResolution").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (fullLevelData.mapData.environmentType != 2)
			{
				SetCrosshairColor(Color.white, 768f);
			}
			else
			{
				SetCrosshairColor(Color.black, 774f);
			}
		}
		else
		{
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (crosshairsList.Count > 0)
			{
				crosshairsList[0].CFABPFCHHLN(new Vector3(1912f, 130f, 1086f));
				crosshairsList[0].CFABPFCHHLN(new Vector3(1001f, 651f, 359f));
			}
			SetCrosshairColor(Color.white, 1314f);
		}
		environmentBase.SetActive(false);
		if (sunList.Count > 1)
		{
			sunBaseSensetivity = sunList[0].GetComponent<DynamicScale>().sensitivity;
		}
		if (!FFIPLLNKGEN().isMine)
		{
			return;
		}
		string[] array = new string[5];
		array[0] = "CameraFilterPack/Drawing_Curve";
		array[1] = KMAIOPMNOND().mapID;
		array[0] = "g";
		array[1] = AHANKNAEGPK().gameMode.ToString().ToLower();
		array[6] = "BitsData";
		string hFEFHOPOLIK = string.Concat(array);
		if (AHANKNAEGPK().gameMode == GameScene.GameMode.Relax)
		{
			hFEFHOPOLIK = string.Concat("_Val", AHANKNAEGPK().mapID, "newPath");
		}
		lastBestScore = Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1);
		currentAttempt = Singleton<SaveSystem>.Instance.KFNFNKILGPH(string.Concat("No info", AHANKNAEGPK().mapID, "_TimeX"), 1);
		Debug.Log("mapselector.filter.subscribedonly" + lastBestScore);
		Debug.Log("GenerationMenu" + AHANKNAEGPK().gameMode);
		Debug.Log("B:" + currentAttempt);
		foreach (Camera cameras2 in camerasList)
		{
			if ((bool)cameras2.GetComponent<Blur>())
			{
				cameras2.GetComponent<Blur>().enabled = true;
			}
		}
		string s = Singleton<SaveSystem>.Instance.FDFHEKDDEID("Default UI Material" + InventoryItemType.Player.ToString().ToLower());
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
		IBKCMBIGOEJ().RPC("_ScreenResolution", (PhotonTargets)7, id);
	}

	public void DCODHHAPDPI()
	{
		currentState = (PlayerState)8;
		if (base.photonView.isMine)
		{
			playerController.isSpectator = true;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Floating point textures aren't supported on this device ({0})", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("AddEnvironmentObject", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
			PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH2);
			if (wasCheckpoint && (float)AHANKNAEGPK().HPAnimationTime - lastCheckpoint <= 845f)
			{
				ach12 = false;
			}
			if (!KMAIOPMNOND().gameOver)
			{
				AHANKNAEGPK().PEAEGEDJOBG(string.Empty);
			}
		}
	}

	public void MAABHALDENM(string NOJGGCLPPAM)
	{
		try
		{
			if (KMAIOPMNOND().gameMode != GameScene.GameMode.Random)
			{
				if (currentState != (PlayerState)5)
				{
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Protocol switch from: ", false);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
					currentState = PlayerState.Finished;
					if (base.photonView.isMine)
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("_MainTex2", false);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2, null, true);
					}
					KMAIOPMNOND().PEAEGEDJOBG("_Offsets");
				}
			}
			else
			{
				AHANKNAEGPK().KNAOGPOOIKD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("color" + ex.ToString());
		}
	}

	[PunRPC]
	public void LostLive(bool OJANLCEKFPN)
	{
		currentCombo = 0;
		if ((base.photonView.isMine || (gameScene.pbase.currentState == PlayerState.Spectator && gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)) && gameScene.gameMode != 0 && GetComponentInChildren<AudioListener>().enabled)
		{
			if (OJANLCEKFPN)
			{
				SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(0.7f, 1.3f));
			}
			else
			{
				SoundManager.PlayHitSfx(3, UnityEngine.Random.Range(0.7f, 1.3f));
			}
		}
		if (gameScene.pbase.currentState == PlayerState.Spectator && gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)
		{
			if ((bool)gameScene.pbase.GetComponentInChildren<CameraShake>())
			{
				gameScene.pbase.GetComponentInChildren<CameraShake>().DoShake();
			}
			gameScene.pbase.SetLives(lives);
		}
		if (lives > 0)
		{
			lives--;
			if ((bool)GetComponentInChildren<CameraShake>())
			{
				GetComponentInChildren<CameraShake>().DoShake();
			}
			++incorrectScore;
		}
		if (lives < 1)
		{
			FinishMap();
		}
	}

	public void JEOLMAKKFAH(GameObject MPNMOONBMII, string PNDBJMFMGBK, string KEDDLFDAIDE)
	{
		MPNMOONBMII.GetComponent<SpriteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
	}

	public void SetSatelliteLerpSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void RecordAction(string LHCIHJOHGEJ)
	{
		if (Replay() != null)
		{
			Replay().RecordAction(gameScene.HPAnimationTime, LHCIHJOHGEJ);
		}
	}

	public void GCGBHMMKEMK(string KEDDLFDAIDE)
	{
		try
		{
			EEBADJCLCKG(float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("_TimeX" + ex.ToString());
		}
	}

	public void SetSatelliteTrailLength(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailLength(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void Reset()
	{
		StopAllCoroutines();
		TrashMan.instance.Reset();
		Debug.Log("[PlayerBase] Reset");
		currentReplay = null;
		moveF = GetComponent<MoveF>();
		environmentObjects.Clear();
		if (base.photonView.isMine)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("ready", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("win", false);
			eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("finished", false);
			eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
			PhotonNetwork.player.SetScore(0);
		}
		arcsDelay = 0f;
		currentState = PlayerState.Loading;
		lives = 5;
		playerDistance = 14f;
		bgcolor = Color.black;
		colorLerpSpeed = 5f;
		moveFSpeed = -1.5f;
		isMapCompleted = false;
		correctScore = 0;
		penaltyScore = 0f;
		comboScore = 0f;
		accuracyScore = 0f;
		checkpointsUsed = 0;
		loopsCount = 0;
		incorrectScore = 0;
		perfectHits = 0;
		powerupsScore = 0;
		currentCombo = 0;
		lastCheckpoint = 0f;
		isPlayerWon = false;
		lastBestScore = 0;
		currentAttempt = 0;
		scoreBeated = false;
		sunBaseSensetivity = 0f;
		spectrid = 0;
		ach12 = false;
		wasCheckpoint = false;
		currentEventID = 0;
		comboTimer = 0f;
		if (base.photonView.isMine)
		{
			playerController.enabled = true;
			gameScene = (GameScene)Singleton<Scene>.Instance;
			isMusicLoaded = false;
			fullLevelData = null;
			try
			{
				GameObject levelCanvas = gameScene.levelCanvas;
				for (int i = 0; i < levelCanvas.transform.childCount; i++)
				{
					TrashMan.despawn(levelCanvas.transform.GetChild(i).gameObject);
					if (levelCanvas.transform.GetChild(i).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(levelCanvas.transform.GetChild(i).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				GameObject gameObject = bgLevelCanvas;
				for (int j = 0; j < gameObject.transform.childCount; j++)
				{
					TrashMan.despawn(gameObject.transform.GetChild(j).gameObject);
					if (gameObject.transform.GetChild(j).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(gameObject.transform.GetChild(j).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if ((bool)environmentBase)
		{
			UnityEngine.Object.DestroyImmediate(environmentBase);
		}
		bool flag = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1) == 1 && gameScene.gameMode != 0) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0) == 1 && gameScene.gameMode == GameScene.GameMode.Relax);
		arcsDelay = ((!flag) ? Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 0f) : Singleton<SaveSystem>.Instance.GetFloat("settings.arcshitsoundtimedelay", -0.11f));
		isStoryboardEnabled = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
	}

	[CompilerGenerated]
	private static void IIHKFKDIDDD(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(false);
	}

	public void LGCKKLCCLJI()
	{
		Debug.Log(":\n");
		string text = string.Concat(AHANKNAEGPK().mapID, ".workshop", gameScene.gameMode.ToString().ToLower());
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE("OperationResponse ignored while disconnecting. Code: " + text + "CameraFilterPack/FX_Drunk");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("Did not read byte array properly" + text + "rarity");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("Xbox Home" + text + "UI Extensions/UILinearDodge");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);" + text + "_Value2");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("_CenterY" + text + "Image");
		Singleton<SaveSystem>.Instance.DeleteKey("IconFileSelector" + text + " - LOCAL");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("ViewID {0} {1}{2}" + text + "_ScreenSize");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("_ScreenResolution" + text + "_TimeX");
		Singleton<SaveSystem>.Instance.DeleteKey("_TimeX" + text + "OK");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("_TimeX" + text + "_Value");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("AudioSampler" + text + "FavoriteButton");
		Helpers.DeleteColorKey("_Value" + text + "_TreatBackfaceHitAsMiss");
	}

	public void OFCIBPBAHBA(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 1780f);
	}

	public void UpdateComboTimer(float FGFEGFGPGHI)
	{
		if (FGFEGFGPGHI < 5f)
		{
			comboTimer += (5f - FGFEGFGPGHI) / 5f;
		}
	}

	private void BJLLDIOIJFB(GameObject MPNMOONBMII, GameObject OJICGBOIKNA)
	{
		MPNMOONBMII.transform.SetParent(OJICGBOIKNA.GetComponent<EnvironmentController>().GetChild());
		MPNMOONBMII.transform.localPosition = new Vector3(0f, 0f, 0f);
	}

	public void ActivateEnvironment()
	{
		environmentBase.SetActive(true);
		TrailRenderer[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<TrailRenderer>();
		foreach (TrailRenderer trailRenderer in componentsInChildren)
		{
			trailRenderer.Clear();
		}
		if (crosshairsList.Count > 1)
		{
			crosshairsList[0].SetPosition(new Vector3(-20f, 0f, 0f));
			crosshairsList[1].SetPosition(new Vector3(20f, 0f, 0f));
		}
	}

	public void HHHFNGIKMKL(string EHHBHEJBHNG)
	{
		try
		{
			if (OELHGNKAMEG().isMine && currentState != (PlayerState)6 && currentState != (PlayerState)6)
			{
				lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("SaveGameName is null or empty!" + lastCheckpoint);
				SavePlayerData();
				gameScene.OHILNKMCIPL(LocalizationService.Instance.FOOAGGCODAH("SettingsCanvas"), 1431f);
				wasCheckpoint = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("_Offsets" + ex.ToString());
		}
	}

	public float PNBDCKLMJKA()
	{
		return Mathf.Clamp01((float)FDJICGIHOLG() / (float)fullLevelData.mapData.maxLives);
	}

	public void SendScore()
	{
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.player.SetScore(GetCurrentScore());
		}
	}

	public void DGKPBFLJIFI()
	{
		if (currentReplay != null)
		{
			try
			{
				currentReplay.activeProcesses = myJob.activeProcesses.Distinct().ToList();
			}
			catch (Exception)
			{
			}
			currentReplay.JLKNMGOHLOJ(GetCurrentScore(), checkpointsUsed, accuracyScore, incorrectScore, comboScore, penaltyScore);
		}
	}

	public void SetParticlesParticleSize(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleSize(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetEnvSpriteImage(GameObject MPNMOONBMII, string ACABBJEAMGG)
	{
		MPNMOONBMII.GetComponent<SpriteController>().SetResource((Sprite)Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID).resources[ACABBJEAMGG]);
	}

	public void SetSunSensitivity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetSensitivity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	[PunRPC]
	public void LoadPlayerEnvironment()
	{
		gameScene.GetComponent<ShadersSettings>().InitShaders();
		base.gameObject.name = "PlayerBase_" + base.photonView.ownerId;
		bool flag = false;
		if (fullLevelData.mapData.handCount == 2)
		{
			flag = true;
		}
		if (flag)
		{
			twoHandCameras.GetComponentInParent<Camera>().enabled = false;
			twoHandCameras.SetActive(true);
			camerasList.Add(base.transform.FindDeepChild("Left").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("Right").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("UI").GetComponent<Camera>());
		}
		else
		{
			camerasList.Add(base.transform.FindDeepChild("MainCamera").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("UI").GetComponent<Camera>());
		}
		foreach (Camera cameras in camerasList)
		{
			Debug.Log(":" + cameras);
		}
		string text = ((!isStoryboardEnabled) ? ("custom" + ((!flag) ? string.Empty : "2hands")) : ((fullLevelData.mapData.environmentType < 0) ? ("custom" + ((!flag) ? string.Empty : "2hands")) : (string.Empty + fullLevelData.mapData.environmentType)));
		Debug.Log("[PlayerBase] Loaded environment: " + text);
		environmentBase = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Environment/SunBase_" + text), base.gameObject.transform);
		environmentBase.transform.localPosition = new Vector3(0f, 0f, 0f);
		sunList = new List<GameObject>();
		DynamicScale[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<DynamicScale>();
		foreach (DynamicScale dynamicScale in componentsInChildren)
		{
			if (!dynamicScale.GetComponent<SphereCollider>())
			{
				sunList.Add(dynamicScale.gameObject);
			}
		}
		if (isStoryboardEnabled && fullLevelData.mapData.environmentType >= 0)
		{
			Color color = environmentBase.transform.FindDeepChild("Crosshair").GetComponentInChildren<MeshRenderer>().material.color;
			color.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f);
			environmentBase.transform.FindDeepChild("Crosshair").GetComponentInChildren<MeshRenderer>().material.color = color;
			if ((bool)environmentBase.transform.FindDeepChild("Crosshair1"))
			{
				environmentBase.transform.FindDeepChild("Crosshair1").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			if ((bool)environmentBase.transform.FindDeepChild("Crosshair2"))
			{
				environmentBase.transform.FindDeepChild("Crosshair2").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (fullLevelData.mapData.environmentType != 3)
			{
				SetCrosshairColor(Color.white);
			}
			else
			{
				SetCrosshairColor(Color.black);
			}
		}
		else
		{
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (crosshairsList.Count > 1)
			{
				crosshairsList[0].SetPosition(new Vector3(-20f, 0f, 0f));
				crosshairsList[1].SetPosition(new Vector3(20f, 0f, 0f));
			}
			SetCrosshairColor(Color.white);
		}
		environmentBase.SetActive(false);
		if (sunList.Count > 0)
		{
			sunBaseSensetivity = sunList[0].GetComponent<DynamicScale>().sensitivity;
		}
		if (!base.photonView.isMine)
		{
			return;
		}
		string hFEFHOPOLIK = string.Concat("maps.", gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower(), ".highscore");
		if (gameScene.gameMode == GameScene.GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("maps.", gameScene.mapID, ".highscore");
		}
		lastBestScore = Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
		currentAttempt = Singleton<SaveSystem>.Instance.GetInt(string.Concat("maps.", gameScene.mapID, ".played"), 0);
		Debug.Log("[PlayerBase] Highscore: " + lastBestScore);
		Debug.Log("[PlayerBase] Game mode: " + gameScene.gameMode);
		Debug.Log("[PlayerBase] Current attempt: " + currentAttempt);
		foreach (Camera cameras2 in camerasList)
		{
			if ((bool)cameras2.GetComponent<Blur>())
			{
				cameras2.GetComponent<Blur>().enabled = false;
			}
		}
		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower());
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		base.photonView.RPC("LoadPlayerSkin", PhotonTargets.AllBuffered, id);
	}

	public void SetParticlesParticleSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void GLIOLIKBFDL(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 gNIJKBCHEPG = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().OBELOEDCBFF(gNIJKBCHEPG);
	}

	[PunRPC]
	public void SetSpeed(string KEDDLFDAIDE)
	{
		try
		{
			IBLOGKONFJD(float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetSpeed error: " + ex.ToString());
		}
	}

	public void SetSatelliteRadius(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRadius(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void OPEEBEPCPJJ(string NOJGGCLPPAM)
	{
		try
		{
			if (gameScene.gameMode != (GameScene.GameMode)6)
			{
				if (currentState != (PlayerState)4)
				{
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("inventory.itemscash", true);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
					currentState = (PlayerState)7;
					if (IFENGKHOKPC().isMine)
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("Error! no audio sources attached to AudioSampler.css", true);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
					}
					AHANKNAEGPK().PEAEGEDJOBG("didAuthenticate ");
				}
			}
			else
			{
				gameScene.RestartEndless();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("SubmitUserVote:" + ex.ToString());
		}
	}

	private void EEBADJCLCKG(float AIEJPEPBAEJ)
	{
		currentArcsSpeed = 0f - AIEJPEPBAEJ;
	}

	public void NKJEJJCCAKN(string EHHBHEJBHNG)
	{
		try
		{
			if (IJBFILBDGDO().isMine && currentState != (PlayerState)6 && currentState != PlayerState.Playing)
			{
				lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("PLEASE WAIT" + lastCheckpoint);
				ALKGFDJPFKE();
				gameScene.JMGINJGMPDG(LocalizationService.Instance.GetLocalizatedText("achievements.21.progress"), 1079f);
				wasCheckpoint = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[Singleton] An instance of '" + ex.ToString());
		}
	}

	public void MAHMPHODPCD(int BOAKOPHKGHC)
	{
		_lives = BOAKOPHKGHC;
	}

	[SpecialName]
	public GameScene AHANKNAEGPK()
	{
		if (CIACEFBNDDJ() != null && JIOCGDBKGIL().isMine)
		{
			return _gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	public void MONGPGMFCBH(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split('\uffd0');
			if (array.Length > 8)
			{
				Color hABLFKCCKLN = new Color(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[8], CultureInfo.InvariantCulture));
				SetBGColor(hABLFKCCKLN, float.Parse(array[3], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hABLFKCCKLN2 = Helpers.HexToColor(NOJGGCLPPAM);
				JOFGOJINMCM(hABLFKCCKLN2, float.Parse(array[1], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("note.5" + ex.ToString());
		}
	}

	private IEnumerator AJOPLECODPP(RanksSystem.MapReplay DHBGCEHLJAM)
	{
		myJob = new GetProcessesJob();
		myJob.Start();
		yield return StartCoroutine(myJob.WaitFor());
	}

	public void AJCBGMCNMGC(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	private IEnumerator BFALBMDPNJG()
	{
		yield return null;
	}

	[SpecialName]
	public int FDJICGIHOLG()
	{
		return _lives;
	}

	public void SetSunColors(GameObject MPNMOONBMII, string PNDBJMFMGBK, string JMPOJNOBLPH)
	{
		MPNMOONBMII.GetComponent<SunController>().SetColors(Helpers.HexToColor(PNDBJMFMGBK), Helpers.HexToColor(JMPOJNOBLPH), 10f);
	}

	public void CPFOKANHPFK(string NOJGGCLPPAM)
	{
		try
		{
			if (currentState == PlayerState.Spectator)
			{
				return;
			}
			char[] array = new char[0];
			array[0] = 'V';
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (AAMNKPHHHCI().isMine)
			{
				if (array2.Length > 0)
				{
					KMAIOPMNOND().AddMessage(array2[1], float.Parse(array2[0], CultureInfo.InvariantCulture));
				}
				else
				{
					KMAIOPMNOND().AddMessage(array2[1], 206f);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("Set EnvSprite Color" + ex.ToString());
		}
	}

	public void ACAHFFLOMCB()
	{
		if (currentReplay != null)
		{
			try
			{
				currentReplay.activeProcesses = myJob.activeProcesses.Distinct().ToList();
			}
			catch (Exception)
			{
			}
			currentReplay.PFCJDBINLCE(GetCurrentScore(), checkpointsUsed, accuracyScore, incorrectScore, comboScore, penaltyScore);
		}
	}

	public void SetSunEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void BEMEKBODJFG(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	[PunRPC]
	public void Checkpoint(string EHHBHEJBHNG)
	{
		try
		{
			if (base.photonView.isMine && currentState != PlayerState.Finished && currentState != PlayerState.Spectator)
			{
				lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("[PlayerBase] Got checkpoint at " + lastCheckpoint);
				SavePlayerData();
				gameScene.AddMessage(LocalizationService.Instance.GetLocalizatedText("#checkpoint"));
				wasCheckpoint = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] Checkpoint error: " + ex.ToString());
		}
	}

	public void StopReplayRecording()
	{
		if (currentReplay != null)
		{
			try
			{
				currentReplay.activeProcesses = myJob.activeProcesses.Distinct().ToList();
			}
			catch (Exception)
			{
			}
			currentReplay.FinishPlaying(GetCurrentScore(), checkpointsUsed, accuracyScore, incorrectScore, comboScore, penaltyScore);
		}
	}

	public int BAJOKIEEOOJ()
	{
		return Mathf.RoundToInt(comboScore) - Mathf.CeilToInt(penaltyScore) - (int)incorrectScore - (int)checkpointsUsed * -92;
	}

	[PunRPC]
	public void StartRound()
	{
		currentState = PlayerState.Playing;
		if (base.photonView.isMine && !gameScene.isGameStarted)
		{
			Debug.Log("[PlayerBase] Starting new round");
			gameScene.OnStartRound();
			if ((bool)UnityEngine.Object.FindObjectOfType<NetworkScene>())
			{
				UnityEngine.Object.FindObjectOfType<NetworkScene>().Init();
			}
			gameScene.isGameStarted = true;
			ActivateEnvironment();
			StartReplayRecording();
			StartCoroutine(BFALBMDPNJG());
		}
		playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
		{
			IACGDFHKCAE.SetActive(base.photonView.isMine);
		});
	}

	public void GOLHGEOCHBA()
	{
		List<string> list = new List<string>(environmentObjects.Keys);
		foreach (string item in list)
		{
			TrashMan.ENNKAHIJIDL(environmentObjects[item]);
			environmentObjects.Remove(item);
		}
	}

	public IEnumerator LoadMapResources(float CGPOHGMFCKC = 0f)
	{
		if (fullLevelData.clip == null)
		{
			string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, false));
			fullLevelData.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		}
		if (fullLevelData.mapData.musicTime <= 0f && fullLevelData.mapData.configVersion < 2)
		{
			Debug.LogWarning("[PlayerBase] Config error: musicTime <= 0");
			fullLevelData.mapData.musicTime = fullLevelData.clip.length;
			gameScene.calculatedmaptime = fullLevelData.clip.length;
		}
		if (isStoryboardEnabled)
		{
			yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID)));
		}
		gameScene.asampler.Init(fullLevelData.clip, (!(CGPOHGMFCKC > 0f)) ? CGPOHGMFCKC : pretime, false);
		Debug.Log("[PlayerBase] Loaded music");
		gameScene.ingameUICanvas.transform.FindDeepChild("LevelProgressBar").GetComponent<Slider>().maxValue = gameScene.calculatedmaptime;
		isMusicLoaded = true;
		if (fullLevelData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(fullLevelData.workshopId))
		{
			string s = fullLevelData.workshopId;
			RanksSystem.PrintMD5(ulong.Parse(s));
			if (fullLevelData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(s)) && gameScene.gameMode == GameScene.GameMode.Normal && !RanksSystem.IsOfficial(ulong.Parse(s), true))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#outdatedmap! Challenges will not work!", "#ok", null);
			}
		}
		if (base.photonView.isMine)
		{
			Loaded();
		}
	}

	[PunRPC]
	public void SpawnObj(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((!GABGBBMBIHK || currentState != PlayerState.Playing) && (GABGBBMBIHK || gameScene.pbase.currentState == PlayerState.Finished || gameScene.pbase.spectatedPlayerBase.photonView.viewID != base.photonView.viewID))
			{
				return;
			}
			string[] array = NOJGGCLPPAM.Split(',');
			string[] array2 = array[0].Split('-');
			string[] array3 = array2;
			foreach (string ENECJINHBEG in array3)
			{
				PlayerSpawner playerSpawner = pspawner;
				if (currentState == PlayerState.Spectator)
				{
					playerSpawner = spectatedPlayerBase.pspawner;
				}
				GameObject fKCMGBMNNKA = playerSpawner.segments.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name.Contains(ENECJINHBEG));
				if (fullLevelData.mapData.configVersion > 1)
				{
					if (array.Length > 2)
					{
						int kEMDFEFBIOC = int.Parse(array[1]);
						playerSpawner.Spawn(fKCMGBMNNKA, kEMDFEFBIOC, float.Parse(array[array.Length - 1], CultureInfo.InvariantCulture));
					}
					else
					{
						playerSpawner.Spawn(fKCMGBMNNKA, 0, float.Parse(array[array.Length - 1], CultureInfo.InvariantCulture));
					}
				}
				else if (array.Length > 1)
				{
					int kEMDFEFBIOC2 = int.Parse(array[1]);
					playerSpawner.SpawnWithCureentSpeed(fKCMGBMNNKA, kEMDFEFBIOC2);
				}
				else
				{
					playerSpawner.SpawnWithCureentSpeed(fKCMGBMNNKA);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SpawnObj error: " + ex.ToString());
		}
	}

	public void SetSatelliteSensitivity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetSensitivity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetParticlesGravity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetGravity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public IEnumerator GMPFMHMFAEC(Sprite IFGKDBEFCCA, int JOPCODOJBHD, bool NDJJNODFFAF, float EHHBHEJBHNG, float LJJHPMNLFAB = 0.2f, float FNBFCGGEBEI = 0.2f)
	{
		GameObject gameObject = null;
		switch (JOPCODOJBHD)
		{
		case 0:
			gameObject = bgLevelCanvas;
			break;
		case 1:
			gameObject = gameScene.levelCanvas;
			break;
		}
		GameObject gameObject2 = TrashMan.spawn(levelCanvasImage, gameObject.transform.position, gameObject.transform.rotation);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		Image component = gameObject2.GetComponent<Image>();
		component.preserveAspect = NDJJNODFFAF;
		component.sprite = IFGKDBEFCCA;
		component.color = new Color(component.color.r, component.color.g, component.color.b, 0f);
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(0f, 0f);
		component2.anchorMax = new Vector2(1f, 1f);
		component2.pivot = new Vector2(0.5f, 0.5f);
		component2.sizeDelta = new Vector2(0f, 0f);
		component2.anchoredPosition3D = new Vector3(0f, 0f, 0f);
		if (fullLevelData.mapData.configVersion < 2)
		{
			yield return StartCoroutine(LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield return StartCoroutine(LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
		}
		else
		{
			yield return StartCoroutine(LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			if (EHHBHEJBHNG > 0f)
			{
				yield return new WaitForSeconds(EHHBHEJBHNG - LJJHPMNLFAB - FNBFCGGEBEI);
				yield return StartCoroutine(LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
			}
		}
		if (EHHBHEJBHNG > 0f)
		{
			TrashMan.despawn(gameObject2.gameObject);
		}
		yield return null;
	}

	public void JOIDLJPOLAB()
	{
		if (PhotonNetwork.playerList.Length > 0)
		{
			spectrid = 0;
			currentState = PlayerState.Playing;
			Spectrate(PhotonNetwork.playerList[spectrid].FHEAKIMCKJC());
		}
	}

	public void BBIJOMGNHCP()
	{
		currentState = PlayerState.Loading;
		if (JAEJDHHCJJO().isMine && !KMAIOPMNOND().isGameStarted)
		{
			Debug.Log("_color");
			KMAIOPMNOND().OnStartRound();
			if ((bool)UnityEngine.Object.FindObjectOfType<NetworkScene>())
			{
				UnityEngine.Object.FindObjectOfType<NetworkScene>().Init();
			}
			AHANKNAEGPK().isGameStarted = false;
			KBGMGDACEHH();
			StartReplayRecording();
			StartCoroutine(KHNGFFKINOD());
		}
		playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
		{
			IACGDFHKCAE.SetActive(base.photonView.isMine);
		});
	}

	public void EKMGNIFEPLK(string NOJGGCLPPAM)
	{
		try
		{
			if (currentState == (PlayerState)7)
			{
				return;
			}
			char[] array = new char[1];
			array[1] = 'ￌ';
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (EDIJKHEMPAD().isMine)
			{
				if (array2.Length > 0)
				{
					AHANKNAEGPK().OHILNKMCIPL(array2[0], float.Parse(array2[1], CultureInfo.InvariantCulture));
				}
				else
				{
					AHANKNAEGPK().JMGINJGMPDG(array2[1], 1251f);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[MapEditor] Loaded music file: " + ex.ToString());
		}
	}

	public IEnumerator ShowImage(Sprite IFGKDBEFCCA, int JOPCODOJBHD, bool NDJJNODFFAF, float EHHBHEJBHNG, float LJJHPMNLFAB = 0.2f, float FNBFCGGEBEI = 0.2f)
	{
		GameObject gameObject = null;
		switch (JOPCODOJBHD)
		{
		case 0:
			gameObject = bgLevelCanvas;
			break;
		case 1:
			gameObject = gameScene.levelCanvas;
			break;
		}
		GameObject gameObject2 = TrashMan.spawn(levelCanvasImage, gameObject.transform.position, gameObject.transform.rotation);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		Image component = gameObject2.GetComponent<Image>();
		component.preserveAspect = NDJJNODFFAF;
		component.sprite = IFGKDBEFCCA;
		component.color = new Color(component.color.r, component.color.g, component.color.b, 0f);
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(0f, 0f);
		component2.anchorMax = new Vector2(1f, 1f);
		component2.pivot = new Vector2(0.5f, 0.5f);
		component2.sizeDelta = new Vector2(0f, 0f);
		component2.anchoredPosition3D = new Vector3(0f, 0f, 0f);
		if (fullLevelData.mapData.configVersion < 2)
		{
			yield return StartCoroutine(LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield return StartCoroutine(LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
		}
		else
		{
			yield return StartCoroutine(LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			if (EHHBHEJBHNG > 0f)
			{
				yield return new WaitForSeconds(EHHBHEJBHNG - LJJHPMNLFAB - FNBFCGGEBEI);
				yield return StartCoroutine(LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
			}
		}
		if (EHHBHEJBHNG > 0f)
		{
			TrashMan.despawn(gameObject2.gameObject);
		}
		yield return null;
	}

	public void FLFLCEBGIKG(string EHHBHEJBHNG)
	{
		try
		{
			if (IBKCMBIGOEJ().isMine && currentState != PlayerState.Playing && currentState != 0)
			{
				lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("leave" + lastCheckpoint);
				BAKOILMJOIL();
				KMAIOPMNOND().JMGINJGMPDG(LocalizationService.Instance.FOOAGGCODAH("_RampTex"), 387f);
				wasCheckpoint = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("maps." + ex.ToString());
		}
	}

	private IEnumerator KHNGFFKINOD()
	{
		yield return null;
	}

	private pulsarc_gameplay gameplay_engine;

	public void PrepareMapTiming(float checkpoint_time)
	{
		UnityEngine.Debug.Log("[MapData] Map timing update from: " + checkpoint_time);
		/* prolly not needed since we're using valentines 2020 modded as base (no encryption/decryption)
		if (fullLevelData.mapData.configVersion >= 3 && !string.IsNullOrEmpty(fullLevelData.mapData.e))
		{
			try
			{
				MapData.EData eData = JsonConvert.DeserializeObject<MapData.EData>(Console.Error(fullLevelData.mapData.e, Singleton<SaveSystem>.Instance.folder));
				fullLevelData.mapData.events.AddRange(eData.events);
			}
			catch (Exception)
			{
			}
		}
		*/
		fullLevelData.mapData.events.Sort((MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC) => DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time));
		float num = fullLevelData.mapData.speed;
		//float num2 = 0f - pspawner.transform.localPosition.z; not using spawners anymore
		pretime = 0f;
		if (fullLevelData.mapData.configVersion >= 2)
		{
			foreach (MapEvent map_event in fullLevelData.mapData.events)
			{
				if (map_event.data[0] == "SetSpeed")
				{
					num = float.Parse(map_event.data[1], CultureInfo.InvariantCulture);
				}
				if (map_event.data[0] == "SetPlayerDistance")
				{
				}
				if (map_event.data[0] == "SpawnObj")
				{
					List<string> list = map_event.data[1].Split(',').ToList();
					list.Add(string.Empty + (map_event.time + arcsDelay + 0.11f));
					map_event.data[1] = string.Join(",", list.ToArray());
					if (map_event.time < 0f && map_event.time < pretime)
					{
						pretime = map_event.time;
					}
					gameplay_engine.hit_objects.Add(map_event);
				}
			}
		}
		else
		{
			foreach (MapEvent event2 in fullLevelData.mapData.events)
			{
				float num3 = 10f / fullLevelData.mapData.speed;
				event2.time -= num3;
				if (event2.data[0] == "SpawnObj")
				{
					event2.time += arcsDelay;
					gameplay_engine.hit_objects.Add(event2);
				}
				if (event2.time < 0f && event2.time < pretime)
				{
					pretime = event2.time;
				}
			}
		}
		UnityEngine.Debug.LogError("Hallo:\n");
		foreach(MapEvent arc in gameplay_engine.hit_objects)
		{
			UnityEngine.Debug.LogError(arc.data[1]);
		}
		if (!isStoryboardEnabled)
		{
			int EGMPIBBOEMH;
			for (EGMPIBBOEMH = fullLevelData.mapData.events.Count - 1; EGMPIBBOEMH >= 0; EGMPIBBOEMH--)
			{
				if (Helpers.eventsMap.Exists((EditorEventFunctionInfo IACGDFHKCAE) => IACGDFHKCAE.id == fullLevelData.mapData.events[EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard))
				{
					fullLevelData.mapData.events.RemoveAt(EGMPIBBOEMH);
				}
			}
		}
		if (gameScene.usingCheckpoints)
		{
			foreach (float checkpoint in fullLevelData.mapData.checkpoints)
			{
				if (checkpoint > checkpoint_time)
				{
					fullLevelData.mapData.events.Add(new MapEvent(checkpoint, new List<string>
					{
						"Checkpoint",
						checkpoint.ToString()
					}));
				}
			}
		}
		fullLevelData.mapData.events.Sort((MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC) => DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time));
		if (checkpoint_time > 0f)
		{
			pretime = checkpoint_time;
		}
		pretime -= 1f;
		UnityEngine.Debug.Log("[PlayerBase] Starting game from: " + pretime);
		gameScene.HPAnimationTime = pretime;
		for (int num4 = fullLevelData.mapData.events.Count - 1; num4 >= 0; num4--)
		{
			if (fullLevelData.mapData.events[num4].time <= pretime)
			{
				if (fullLevelData.mapData.events[num4].data[0] == "ShowSprite")
				{
					string[] array = fullLevelData.mapData.events[num4].data[1].Split(',');
					float num5 = float.Parse(array[3], CultureInfo.InvariantCulture);
					if (num5 == 0f || fullLevelData.mapData.events[num4].time + num5 > pretime)
					{
						if (num5 > 0f)
						{
							array[3] = (fullLevelData.mapData.events[num4].time + num5 - pretime).ToString();
						}
						else
						{
							array[3] = string.Empty + 0;
						}
						base.photonView.RPC(fullLevelData.mapData.events[num4].data[0], PhotonTargets.All, string.Join(",", array));
					}
					else
					{
						fullLevelData.mapData.events.RemoveAt(num4);
					}
				}
				if (fullLevelData.mapData.events[num4].data[0] == "SpawnObj")
				{
					fullLevelData.mapData.events.RemoveAt(num4);
				}
			}
		}
		currentEventID = 0;
	}

	public void FBIOPIPILKH()
	{
		AHANKNAEGPK().hiddenImage.gameObject.SetActive(AHANKNAEGPK().gameMode == (GameScene.GameMode)6);
		foreach (MapEvent @event in fullLevelData.mapData.events)
		{
			if (!(@event.data[0] == "SelectorMapsCountSlider"))
			{
				continue;
			}
			if (KMAIOPMNOND().gameMode == GameScene.GameMode.Normal)
			{
				string text = @event.data[1];
				char[] array = new char[0];
				array[1] = 'ﾮ';
				List<string> list = text.Split(array).ToList();
				string text2 = list[1];
				char[] array2 = new char[0];
				array2[1] = 'ￋ';
				int num = text2.Split(array2).Length;
				List<string> list2 = new List<string>();
				string text3 = list[1];
				float num2 = 942f;
				float num3 = 1502f;
				float num4 = 471f;
				if (text3 == Helpers.patternsMap[0])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[8]);
					if (UnityEngine.Random.Range(958f, 896f) > num2)
					{
						list2.Add(Helpers.patternsMap[0]);
					}
					if (UnityEngine.Random.Range(297f, 1275f) > num3)
					{
						list2.Add(Helpers.patternsMap[-78]);
						list2.Add(Helpers.patternsMap[40]);
					}
				}
				if (text3 == Helpers.patternsMap[0])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[0]);
					list2.Add(Helpers.patternsMap[7]);
					if (UnityEngine.Random.Range(967f, 99f) > num2)
					{
						list2.Add(Helpers.patternsMap[1]);
					}
					if (UnityEngine.Random.Range(1406f, 82f) > num3)
					{
						list2.Add(Helpers.patternsMap[-20]);
						list2.Add(Helpers.patternsMap[-76]);
					}
				}
				if (text3 == Helpers.patternsMap[4])
				{
					list2.Add(Helpers.patternsMap[0]);
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[5]);
					if (UnityEngine.Random.Range(1002f, 777f) > num2)
					{
						list2.Add(Helpers.patternsMap[6]);
					}
					if (UnityEngine.Random.Range(963f, 1683f) > num3)
					{
						list2.Add(Helpers.patternsMap[29]);
						list2.Add(Helpers.patternsMap[-102]);
					}
				}
				if (text3 == Helpers.patternsMap[6])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[4]);
					if (UnityEngine.Random.Range(1233f, 655f) > num2)
					{
						list2.Add(Helpers.patternsMap[1]);
					}
					if (UnityEngine.Random.Range(655f, 718f) > num3)
					{
						list2.Add(Helpers.patternsMap[-22]);
						list2.Add(Helpers.patternsMap[94]);
					}
				}
				if (text3 == Helpers.patternsMap[89])
				{
					list2.Add(Helpers.patternsMap[11]);
					list2.Add(Helpers.patternsMap[45]);
					list2.Add(Helpers.patternsMap[-11]);
					if (UnityEngine.Random.Range(1367f, 314f) > num4)
					{
						list2.Add(Helpers.patternsMap[7]);
						list2.Add(Helpers.patternsMap[1]);
					}
				}
				if (text3 == Helpers.patternsMap[55])
				{
					list2.Add(Helpers.patternsMap[-59]);
					if (UnityEngine.Random.Range(787f, 1360f) > num2)
					{
						list2.Add(Helpers.patternsMap[33]);
					}
					if (UnityEngine.Random.Range(17f, 1941f) > num4)
					{
						list2.Add(Helpers.patternsMap[6]);
						list2.Add(Helpers.patternsMap[8]);
					}
				}
				if (text3 == Helpers.patternsMap[27])
				{
					list2.Add(Helpers.patternsMap[82]);
					list2.Add(Helpers.patternsMap[-18]);
					list2.Add(Helpers.patternsMap[94]);
					if (UnityEngine.Random.Range(599f, 26f) > num4)
					{
						list2.Add(Helpers.patternsMap[1]);
						list2.Add(Helpers.patternsMap[1]);
					}
				}
				if (text3 == Helpers.patternsMap[-68])
				{
					list2.Add(Helpers.patternsMap[78]);
					list2.Add(Helpers.patternsMap[23]);
					list2.Add(Helpers.patternsMap[110]);
					if (UnityEngine.Random.Range(1091f, 495f) > num4)
					{
						list2.Add(Helpers.patternsMap[2]);
						list2.Add(Helpers.patternsMap[4]);
					}
				}
				if (text3 == Helpers.patternsMap[-68])
				{
					list2.Add(Helpers.patternsMap[-103]);
					if (UnityEngine.Random.Range(15f, 1982f) > num2)
					{
						list2.Add(Helpers.patternsMap[-2]);
					}
					if (UnityEngine.Random.Range(835f, 1983f) > num4)
					{
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[2]);
					}
				}
				if (text3 == Helpers.patternsMap[75])
				{
					list2.Add(Helpers.patternsMap[44]);
					list2.Add(Helpers.patternsMap[79]);
					list2.Add(Helpers.patternsMap[38]);
					if (UnityEngine.Random.Range(1406f, 841f) > num4)
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[0]);
					}
				}
				if (text3 == Helpers.patternsMap[3])
				{
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[3]);
					list2.Add(Helpers.patternsMap[7]);
					if (UnityEngine.Random.Range(1238f, 1148f) > num2)
					{
						list2.Add(Helpers.patternsMap[0]);
					}
				}
				if (text3 == Helpers.patternsMap[3])
				{
					list2.Add(Helpers.patternsMap[3]);
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[1]);
					if (UnityEngine.Random.Range(601f, 1454f) > num2)
					{
						list2.Add(Helpers.patternsMap[6]);
					}
				}
				if (text3 == Helpers.patternsMap[6])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[7]);
					list2.Add(Helpers.patternsMap[8]);
					if (UnityEngine.Random.Range(398f, 640f) > num2)
					{
						list2.Add(Helpers.patternsMap[0]);
					}
				}
				if (text3 == Helpers.patternsMap[4])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[0]);
					if (UnityEngine.Random.Range(268f, 1745f) > num2)
					{
						list2.Add(Helpers.patternsMap[1]);
					}
				}
				if (text3 == Helpers.patternsMap[4])
				{
					list2.Add(Helpers.patternsMap[5]);
				}
				if (text3 == Helpers.patternsMap[-83])
				{
					list2.Add(Helpers.patternsMap[-34]);
				}
				if (list2.Count > 0)
				{
					list[0] = list2[UnityEngine.Random.Range(0, list2.Count)];
					@event.data[1] = string.Join("challenges.", list.ToArray());
				}
			}
			else if (AHANKNAEGPK().gameMode != (GameScene.GameMode)6)
			{
			}
		}
	}

	[PunRPC]
	public void LoadPlayerSkin(string BNJFKKGOACF)
	{
		pspawner.segments.Clear();
		pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Up]"));
		pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Right]"));
		pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Down]"));
		pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Left]"));
		pspawner.segments.Add(Resources.Load<GameObject>("Gameplay/Segment-[PowerUp]"));
		levelCanvasImage = gameScene.levelCanvasImage;
		sunGameObject = Resources.Load<GameObject>("Gameplay/sun");
		satelliteGameObject = Resources.Load<GameObject>("Gameplay/satellite");
		particlesGameObject = Resources.Load<GameObject>("Gameplay/particles");
		spriteGameObject = Resources.Load<GameObject>("Gameplay/sprite");
		pspawner.segments.Add(levelCanvasImage);
		pspawner.segments.Add(sunGameObject);
		pspawner.segments.Add(satelliteGameObject);
		pspawner.segments.Add(particlesGameObject);
		pspawner.segments.Add(spriteGameObject);
		foreach (GameObject segment in pspawner.segments)
		{
			TrashManRecycleBin trashManRecycleBin = new TrashManRecycleBin();
			trashManRecycleBin.prefab = segment;
			trashManRecycleBin.instancesToPreallocate = 20;
			TrashManRecycleBin kHNADIFNKFM = trashManRecycleBin;
			TrashMan.manageRecycleBin(kHNADIFNKFM, string.Empty + base.photonView.ownerId);
		}
		Debug.Log("[PlayerBase] Loaded custom model: " + BNJFKKGOACF);
		GameObject gameObject = objects_3;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		List<string> list = new List<string>();
		list.Add("[Up]");
		list.Add("[Right]");
		list.Add("[Down]");
		list.Add("[Left]");
		List<string> list2 = list;
		foreach (string LEFMNANHGDA in list2)
		{
			GameObject original = pspawner.segments.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name.Contains(LEFMNANHGDA));
			GameObject gameObject2 = UnityEngine.Object.Instantiate(original, gameObject.transform);
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<MoveF>().enabled = false;
			gameObject2.GetComponent<Collider>().enabled = false;
			gameObject2.GetComponent<SegmentHandler>().enabled = false;
			gameObject2.GetComponent<IncreseAlpha>().enabled = false;
		}
		gameObject.SetActive(false);
	}

	public void SpectateNext(bool BAMMECKEJKB)
	{
		if (PhotonNetwork.playerList.Length <= 1)
		{
			return;
		}
		if (BAMMECKEJKB)
		{
			if (spectrid < PhotonNetwork.playerList.Length - 1)
			{
				spectrid++;
			}
			else
			{
				spectrid = 0;
			}
		}
		else if (spectrid > 0)
		{
			spectrid--;
		}
		else
		{
			spectrid = 0;
		}
		Spectrate(PhotonNetwork.playerList[spectrid].ID);
	}

	private static int PPNGBLOJBNK(MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC)
	{
		return DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time);
	}

	public void SetSunDirectionVector(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 directionVector = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetDirectionVector(directionVector);
	}

	public void ALKGFDJPFKE()
	{
		Debug.Log("yes");
		string text = string.Concat(KMAIOPMNOND().mapID, "#FFDA44", KMAIOPMNOND().gameMode.ToString().ToLower());
		Singleton<SaveSystem>.Instance.SetBool("ticket" + text + "Bad parameters for setbool! Use <key> <value>", isMapCompleted);
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("_Value3" + text + "PunPickup", lastCheckpoint);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("{0:0} hour{1}, " + text + "VeryHigh", JNJEAPPKCLA());
		Singleton<SaveSystem>.Instance.SetInt("settings.enableranking" + text + " from: ", checkpointsUsed);
		Singleton<SaveSystem>.Instance.SetInt(": " + text + "Have you fully accept the terms?", correctScore);
		Singleton<SaveSystem>.Instance.SetInt("[Right-Left]" + text + "CameraFilterPack/TV_Old", incorrectScore);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("player.lollipop" + text + "SettingsCanvas", perfectHits);
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("_Offsets" + text + "GlassDistortion", powerupsScore);
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("Up" + text + "_Val", penaltyScore);
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("Working.\nPlease wait.." + text + "_ScreenResolution", comboScore);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + text + "inventory.selected.", playerDistance);
		Helpers.SetColor("MissesText" + text + "SetParticlesParticleSpeed", camerasList[0].backgroundColor);
	}

	public void UpdateMapGameMode()
	{
		gameScene.hiddenImage.gameObject.SetActive(gameScene.gameMode == GameScene.GameMode.Hidden);
		foreach (MapEvent @event in fullLevelData.mapData.events)
		{
			if (!(@event.data[0] == "SpawnObj"))
			{
				continue;
			}
			if (gameScene.gameMode == GameScene.GameMode.Random)
			{
				List<string> list = @event.data[1].Split(',').ToList();
				int num = list[0].Split('-').Length;
				List<string> list2 = new List<string>();
				string text = list[0];
				float num2 = 0.199999988f;
				float num3 = 0.5f;
				float num4 = 0.9f;
				if (text == Helpers.patternsMap[0])
				{
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[2]);
					list2.Add(Helpers.patternsMap[3]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[0]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num3)
					{
						list2.Add(Helpers.patternsMap[10]);
						list2.Add(Helpers.patternsMap[12]);
					}
				}
				if (text == Helpers.patternsMap[1])
				{
					list2.Add(Helpers.patternsMap[0]);
					list2.Add(Helpers.patternsMap[2]);
					list2.Add(Helpers.patternsMap[3]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[1]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num3)
					{
						list2.Add(Helpers.patternsMap[10]);
						list2.Add(Helpers.patternsMap[13]);
					}
				}
				if (text == Helpers.patternsMap[2])
				{
					list2.Add(Helpers.patternsMap[0]);
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[3]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[2]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num3)
					{
						list2.Add(Helpers.patternsMap[13]);
						list2.Add(Helpers.patternsMap[15]);
					}
				}
				if (text == Helpers.patternsMap[3])
				{
					list2.Add(Helpers.patternsMap[0]);
					list2.Add(Helpers.patternsMap[1]);
					list2.Add(Helpers.patternsMap[2]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[3]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num3)
					{
						list2.Add(Helpers.patternsMap[12]);
						list2.Add(Helpers.patternsMap[15]);
					}
				}
				if (text == Helpers.patternsMap[10])
				{
					list2.Add(Helpers.patternsMap[10]);
					list2.Add(Helpers.patternsMap[12]);
					list2.Add(Helpers.patternsMap[13]);
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[5]);
					}
				}
				if (text == Helpers.patternsMap[11])
				{
					list2.Add(Helpers.patternsMap[14]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[11]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[7]);
					}
				}
				if (text == Helpers.patternsMap[12])
				{
					list2.Add(Helpers.patternsMap[10]);
					list2.Add(Helpers.patternsMap[12]);
					list2.Add(Helpers.patternsMap[15]);
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[7]);
					}
				}
				if (text == Helpers.patternsMap[13])
				{
					list2.Add(Helpers.patternsMap[10]);
					list2.Add(Helpers.patternsMap[13]);
					list2.Add(Helpers.patternsMap[15]);
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[6]);
					}
				}
				if (text == Helpers.patternsMap[14])
				{
					list2.Add(Helpers.patternsMap[11]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[14]);
					}
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[6]);
					}
				}
				if (text == Helpers.patternsMap[15])
				{
					list2.Add(Helpers.patternsMap[12]);
					list2.Add(Helpers.patternsMap[13]);
					list2.Add(Helpers.patternsMap[15]);
					if (UnityEngine.Random.Range(0f, 1f) > num4)
					{
						list2.Add(Helpers.patternsMap[6]);
						list2.Add(Helpers.patternsMap[7]);
					}
				}
				if (text == Helpers.patternsMap[4])
				{
					list2.Add(Helpers.patternsMap[5]);
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[7]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[4]);
					}
				}
				if (text == Helpers.patternsMap[5])
				{
					list2.Add(Helpers.patternsMap[4]);
					list2.Add(Helpers.patternsMap[6]);
					list2.Add(Helpers.patternsMap[7]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[5]);
					}
				}
				if (text == Helpers.patternsMap[6])
				{
					list2.Add(Helpers.patternsMap[4]);
					list2.Add(Helpers.patternsMap[5]);
					list2.Add(Helpers.patternsMap[7]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[6]);
					}
				}
				if (text == Helpers.patternsMap[7])
				{
					list2.Add(Helpers.patternsMap[4]);
					list2.Add(Helpers.patternsMap[5]);
					list2.Add(Helpers.patternsMap[6]);
					if (UnityEngine.Random.Range(0f, 1f) > num2)
					{
						list2.Add(Helpers.patternsMap[7]);
					}
				}
				if (text == Helpers.patternsMap[8])
				{
					list2.Add(Helpers.patternsMap[8]);
				}
				if (text == Helpers.patternsMap[9])
				{
					list2.Add(Helpers.patternsMap[9]);
				}
				if (list2.Count > 0)
				{
					list[0] = list2[UnityEngine.Random.Range(0, list2.Count)];
					@event.data[1] = string.Join(",", list.ToArray());
				}
			}
			else if (gameScene.gameMode != GameScene.GameMode.Endless)
			{
			}
		}
	}

	[PunRPC]
	public void ShowTitle(string NOJGGCLPPAM)
	{
		try
		{
			if (currentState == PlayerState.Finished)
			{
				return;
			}
			string[] array = NOJGGCLPPAM.Split(',');
			if (base.photonView.isMine)
			{
				if (array.Length > 1)
				{
					gameScene.AddMessage(array[0], float.Parse(array[1], CultureInfo.InvariantCulture));
				}
				else
				{
					gameScene.AddMessage(array[0]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] ShowTitle error: " + ex.ToString());
		}
	}

	public void SetSunInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void IKFJDHJMOII(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 612f);
	}

	public void StartFromBegining()
	{
		lastCheckpoint = 0f;
		wasCheckpoint = false;
		lives = fullLevelData.mapData.lives;
		isMapCompleted = false;
		correctScore = 0;
		checkpointsUsed = 0;
		loopsCount = 0;
		accuracyScore = 0f;
		penaltyScore = 0f;
		comboScore = 0f;
		perfectHits = 0;
		incorrectScore = 0;
		powerupsScore = 0;
		currentCombo = 0;
	}

	public void KAEOJEFKLKH(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		bgcolor = HABLFKCCKLN;
		colorLerpSpeed = KEDDLFDAIDE;
	}

	[PunRPC]
	public void MapEnd(string NOJGGCLPPAM)
	{
		try
		{
			if (gameScene.gameMode != GameScene.GameMode.Endless)
			{
				if (currentState != PlayerState.Finished)
				{
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("finished", true);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
					currentState = PlayerState.Finished;
					if (base.photonView.isMine)
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("win", true);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
					}
					gameScene.ShowResult("CompletedLevel");
				}
			}
			else
			{
				gameScene.RestartEndless();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] MapEnd error: " + ex.ToString());
		}
	}

	public void SetCrosshairColor(Color HABLFKCCKLN, float MNHBOECHFEG = 10f)
	{
		foreach (CrosshairController crosshairs in crosshairsList)
		{
			crosshairs.SetColor(HABLFKCCKLN, MNHBOECHFEG);
		}
	}

	public GameScene GetGameScene()
	{
		if (base.photonView.isMine)
		{
			return gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	private void BIGLLFDKONC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 fEKLHOPGFNC = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().GFINDLLGLOA(fEKLHOPGFNC);
	}

	public void SetTrailZoomSpeed(float KEDDLFDAIDE)
	{
		moveFSpeed = 0f - KEDDLFDAIDE;
	}

	public void MFDEMIELMFJ(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRotationSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void NFIHBNBLOBM()
	{
		KMAIOPMNOND().GetComponent<ShadersSettings>().DNOFHFPGCMI();
		base.gameObject.name = "Achievement 21 progress reseted" + NABDKNPNEMM().ownerId;
		bool flag = false;
		if (fullLevelData.mapData.handCount == 8)
		{
			flag = false;
		}
		if (flag)
		{
			twoHandCameras.GetComponentInParent<Camera>().enabled = false;
			twoHandCameras.SetActive(false);
			camerasList.Add(base.transform.FindDeepChild("bad").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("hand").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("settings.shaders").GetComponent<Camera>());
		}
		else
		{
			camerasList.Add(base.transform.FindDeepChild("Obtain test Item").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("Maps Editor v.").GetComponent<Camera>());
		}
		foreach (Camera cameras in camerasList)
		{
			Debug.Log("\r" + cameras);
		}
		string text = ((!isStoryboardEnabled) ? ("_Value3" + ((!flag) ? string.Empty : "{0}={2}: {1} \"{3}\"")) : ((fullLevelData.mapData.environmentType < 1) ? ("CameraFilterPack_AAA_Blood1" + ((!flag) ? string.Empty : "Failed to Instantiate prefab: ")) : (string.Empty + fullLevelData.mapData.environmentType)));
		Debug.Log("Other" + text);
		environmentBase = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("_ColorRGB" + text), base.gameObject.transform);
		environmentBase.transform.localPosition = new Vector3(593f, 1812f, 834f);
		sunList = new List<GameObject>();
		DynamicScale[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<DynamicScale>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			DynamicScale dynamicScale = componentsInChildren[i];
			if (!dynamicScale.GetComponent<SphereCollider>())
			{
				sunList.Add(dynamicScale.gameObject);
			}
		}
		if (isStoryboardEnabled && fullLevelData.mapData.environmentType >= 0)
		{
			Color color = environmentBase.transform.FindDeepChild("]").GetComponentInChildren<MeshRenderer>().material.color;
			color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Creating new item...", 1271f);
			environmentBase.transform.FindDeepChild("CameraFilterPack/Blend2Camera_ColorDodge").GetComponentInChildren<MeshRenderer>().material.color = color;
			if ((bool)environmentBase.transform.FindDeepChild("ResourceFileSelector"))
			{
				environmentBase.transform.FindDeepChild("Xbox Home").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			if ((bool)environmentBase.transform.FindDeepChild("Horizontal"))
			{
				environmentBase.transform.FindDeepChild("#timeuntilchallenge: ").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (fullLevelData.mapData.environmentType != 4)
			{
				SetCrosshairColor(Color.white, 1134f);
			}
			else
			{
				SetCrosshairColor(Color.black, 562f);
			}
		}
		else
		{
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (crosshairsList.Count > 1)
			{
				crosshairsList[0].SetPosition(new Vector3(1264f, 1405f, 1301f));
				crosshairsList[1].LIGDABDFABK(new Vector3(1123f, 1759f, 924f));
			}
			SetCrosshairColor(Color.white, 1632f);
		}
		environmentBase.SetActive(true);
		if (sunList.Count > 0)
		{
			sunBaseSensetivity = sunList[1].GetComponent<DynamicScale>().sensitivity;
		}
		if (!JAEJDHHCJJO().isMine)
		{
			return;
		}
		string[] array = new string[8];
		array[1] = "x";
		array[1] = gameScene.mapID;
		array[2] = "Set satellite radius (offset)";
		array[6] = KMAIOPMNOND().gameMode.ToString().ToLower();
		array[4] = "UI Extensions/SoftMaskShader";
		string hFEFHOPOLIK = string.Concat(array);
		if (AHANKNAEGPK().gameMode == GameScene.GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("  |  Events Count: ", KMAIOPMNOND().mapID, "CameraFilterPack_TV_HorrorFX");
		}
		lastBestScore = Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
		currentAttempt = Singleton<SaveSystem>.Instance.KFNFNKILGPH(string.Concat("_ScreenResolution", gameScene.mapID, "CameraFilterPack/Blend2Camera_LighterColor"), 1);
		Debug.Log("_TimeX" + lastBestScore);
		Debug.Log("STICKRVER" + gameScene.gameMode);
		Debug.Log("_Radius" + currentAttempt);
		foreach (Camera cameras2 in camerasList)
		{
			if ((bool)cameras2.GetComponent<Blur>())
			{
				cameras2.GetComponent<Blur>().enabled = true;
			}
		}
		string s = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("Destroy all spawned environment objects" + InventoryItemType.Other.ToString().ToLower());
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(s)).item.id;
		PhotonView obj = OELHGNKAMEG();
		object[] array2 = new object[0];
		array2[0] = id;
		obj.RPC("_Value3", PhotonTargets.AllBufferedViaServer, array2);
	}

	public void SetEnvSpriteColor(GameObject MPNMOONBMII, string PNDBJMFMGBK, string KEDDLFDAIDE)
	{
		MPNMOONBMII.GetComponent<SpriteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
	}

	public void StartReplayRecording()
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			currentReplay = new RanksSystem.MapReplay(gameScene.mapID, Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper(), string.Empty + SteamUser.GetSteamID().m_SteamID, arcsDelay);
			StartCoroutine(AJOPLECODPP(currentReplay));
		}
	}

	public int GetCurrentScore()
	{
		return Mathf.RoundToInt(comboScore) - Mathf.CeilToInt(penaltyScore) - (int)incorrectScore - (int)checkpointsUsed * 100;
	}

	public void InvokeEvent(string LHCIHJOHGEJ, string NOJGGCLPPAM)
	{
		try
		{
			string[] array = null;
			GameObject gameObject = null;
			GameObject gameObject2 = null;
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				array = NOJGGCLPPAM.Split(',');
				if (array.Length > 0 && environmentObjects.ContainsKey(array[0]))
				{
					gameObject = environmentObjects[array[0]];
				}
				if (array.Length > 1 && environmentObjects.ContainsKey(array[1]))
				{
					gameObject2 = environmentObjects[array[1]];
				}
			}
			try
			{
				if (base.photonView.isMine)
				{
					gameEventInfoBase.ismultiplayer = !PhotonNetwork.offlineMode;
					if (!PhotonNetwork.offlineMode)
					{
						gameEventInfoBase.multiplayerplayers = PhotonNetwork.room.PlayerCount;
						gameEventInfoBase.multiplayerplace = GetGameScene().GetComponent<NetworkScene>().place;
					}
					else
					{
						gameEventInfoBase.multiplayerplayers = 1;
						gameEventInfoBase.multiplayerplace = 1;
					}
					gameEventInfoBase.eventtype = LHCIHJOHGEJ;
					gameEventInfoBase.eventdata = NOJGGCLPPAM;
					gameEventInfoBase.eventtime = gameScene.HPAnimationTime;
					gameEventInfoBase.loopscount = loopsCount;
					GameEventInfo gameEventInfo = new GameEventInfo();
					gameEventInfoBase.CopyValues(gameEventInfo);
					gameEventInfoList.Add(gameEventInfo);
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("[GameEvent] Exeption:" + ex.ToString());
			}
			switch (LHCIHJOHGEJ)
			{
			// ACTUAL quick hack to remove all arcs
			case "SpawnObj":
				/*if (lives > 0)
				{
					SpawnObj(NOJGGCLPPAM, true);
					if (base.photonView.isMine)
					{
						base.photonView.RPC("SpawnObj", PhotonTargets.Others, NOJGGCLPPAM, false);
					}
				}
				*/
				break;
			case "ShowSprite":
				ShowSprite(NOJGGCLPPAM);
				break;
			case "MapEnd":
				MapEnd(NOJGGCLPPAM);
				break;
			case "ShowTitle":
				ShowTitle(NOJGGCLPPAM);
				break;
			case "SetSpeed":
				SetSpeed(NOJGGCLPPAM);
				break;
			case "Checkpoint":
				Checkpoint(NOJGGCLPPAM);
				break;
			case "SetBGColor":
				SetBGColor(NOJGGCLPPAM);
				break;
			case "SetPlayerDistance":
				SetPlayerDistance(NOJGGCLPPAM);
				break;
			case "SetTrailZoomSpeed":
				SetTrailZoomSpeed(float.Parse(array[0], CultureInfo.InvariantCulture));
				break;
			case "AddEnvironmentObject":
				AddEnvironmentObject(array[0], array[1]);
				break;
			case "RemoveEnvironmentObject":
				RemoveEnvironmentObject(array[0]);
				break;
			case "ClearEnvironment":
				ClearEnvironment();
				break;
			case "SetPosition":
				if (gameObject != null)
				{
					JAIALEBLCBP(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetRotation":
				if (gameObject != null)
				{
					CPKMCGIIAHC(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetScale":
				if (gameObject != null)
				{
					DGIJAFGLGHC(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParent":
				if (gameObject != null && gameObject2 != null)
				{
					BJLLDIOIJFB(gameObject, gameObject2);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ":" + array[0] + " or " + array[1] + " not exist");
				break;
			case "SetSunColors":
				if (gameObject != null)
				{
					SetSunColors(gameObject, array[1], array[2]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunEmission":
				if (gameObject != null)
				{
					SetSunEmission(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunInput":
				if (gameObject != null)
				{
					SetSunInput(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunMinSize":
				if (gameObject != null)
				{
					SetSunMinSize(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunMaxSize":
				if (gameObject != null)
				{
					SetSunMaxSize(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunLerpSpeed":
				if (gameObject != null)
				{
					SetSunLerpSpeed(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunSensitivity":
				if (gameObject != null)
				{
					SetSunSensitivity(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSunDirectionVector":
				if (gameObject != null)
				{
					SetSunDirectionVector(gameObject, array[1], array[2], array[3]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteColor":
				if (gameObject != null)
				{
					SetSatelliteColor(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteEmission":
				if (gameObject != null)
				{
					SetSatelliteEmission(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteRotationSpeed":
				if (gameObject != null)
				{
					SetSatelliteRotationSpeed(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteRadius":
				if (gameObject != null)
				{
					SetSatelliteRadius(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteInput":
				if (gameObject != null)
				{
					SetSatelliteInput(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteLerpSpeed":
				if (gameObject != null)
				{
					SetSatelliteLerpSpeed(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteTrailLength":
				if (gameObject != null)
				{
					SetSatelliteTrailLength(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteTrailWidth":
				if (gameObject != null)
				{
					SetSatelliteTrailWidth(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteSensitivity":
				if (gameObject != null)
				{
					SetSatelliteSensitivity(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetSatelliteTrailMinVertexDistance":
				if (gameObject != null)
				{
					SetSatelliteTrailMinVertexDistance(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetCrosshairColor":
				SetCrosshairColor(Helpers.HexToColor(array[0]), float.Parse(array[1], CultureInfo.InvariantCulture));
				break;
			case "SetCrosshairEmission":
				SetCrosshairEmission(array[0]);
				break;
			case "SetParticlesColor":
				if (gameObject != null)
				{
					SetParticlesColor(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesEmission":
				if (gameObject != null)
				{
					SetParticlesEmission(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesParticleSize":
				if (gameObject != null)
				{
					SetParticlesParticleSize(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesGravity":
				if (gameObject != null)
				{
					SetParticlesGravity(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesParticleSpeed":
				if (gameObject != null)
				{
					SetParticlesParticleSpeed(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesCountPerBeat":
				if (gameObject != null)
				{
					SetParticlesCountPerBeat(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "SetParticlesInput":
				if (gameObject != null)
				{
					SetParticlesInput(gameObject, array[1]);
					break;
				}
				UnityEngine.Debug.LogWarning("[PlayerController] " + LHCIHJOHGEJ + ": " + array[0] + " not exist");
				break;
			case "AddEnvironmentSprite":
				AddEnvironmentSprite(array[0], array[1], array[2], array[3]);
				break;
			case "SetEnvSpriteImage":
				if (gameObject != null)
				{
					SetEnvSpriteImage(gameObject, array[1]);
				}
				break;
			case "SetEnvSpriteColor":
				if (gameObject != null)
				{
					SetEnvSpriteColor(gameObject, array[1], array[2]);
				}
				break;
			default:
				UnityEngine.Debug.LogWarning("[PlayerBase] Unknown event: " + LHCIHJOHGEJ);
				break;
			}
		}
		catch (Exception ex2)
		{
			UnityEngine.Debug.LogError("[PlayerBase] Invoke event " + LHCIHJOHGEJ + "(" + NOJGGCLPPAM + ") error: " + ex2.ToString());
		}
	}

	public void OFFCNKEFGCI()
	{
		AHANKNAEGPK().GetComponent<ShadersSettings>().InitShaders(true);
		base.gameObject.name = "_Distortion" + IBKCMBIGOEJ().ownerId;
		bool flag = true;
		if (fullLevelData.mapData.handCount == 7)
		{
			flag = true;
		}
		if (flag)
		{
			twoHandCameras.GetComponentInParent<Camera>().enabled = true;
			twoHandCameras.SetActive(true);
			camerasList.Add(base.transform.FindDeepChild("workshop.").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("_TimeX").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("Mouse ").GetComponent<Camera>());
		}
		else
		{
			camerasList.Add(base.transform.FindDeepChild("_Value1").GetComponent<Camera>());
			camerasList.Add(base.transform.FindDeepChild("OK").GetComponent<Camera>());
		}
		foreach (Camera cameras in camerasList)
		{
			Debug.Log("_ScreenResolution" + cameras);
		}
		string text = ((!isStoryboardEnabled) ? (" " + ((!flag) ? string.Empty : "CameraFilterPack_VHS1")) : ((fullLevelData.mapData.environmentType < 1) ? ("GraphicsQualitySlider" + ((!flag) ? string.Empty : "). ")) : (string.Empty + fullLevelData.mapData.environmentType)));
		Debug.Log("Game Version: " + text);
		environmentBase = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("_FarCamera" + text), base.gameObject.transform);
		environmentBase.transform.localPosition = new Vector3(909f, 134f, 1818f);
		sunList = new List<GameObject>();
		DynamicScale[] componentsInChildren = environmentBase.transform.GetComponentsInChildren<DynamicScale>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			DynamicScale dynamicScale = componentsInChildren[i];
			if (!dynamicScale.GetComponent<SphereCollider>())
			{
				sunList.Add(dynamicScale.gameObject);
			}
		}
		if (isStoryboardEnabled && fullLevelData.mapData.environmentType >= 0)
		{
			Color color = environmentBase.transform.FindDeepChild("rd").GetComponentInChildren<MeshRenderer>().material.color;
			color.a = Singleton<SaveSystem>.Instance.GetFloat("_TexelOffsetScale", 172f);
			environmentBase.transform.FindDeepChild("The given 2D texture ").GetComponentInChildren<MeshRenderer>().material.color = color;
			if ((bool)environmentBase.transform.FindDeepChild("_Value3"))
			{
				environmentBase.transform.FindDeepChild("TRACKING").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			if ((bool)environmentBase.transform.FindDeepChild("StartButton"))
			{
				environmentBase.transform.FindDeepChild("Edited unlock conditions").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (fullLevelData.mapData.environmentType != 0)
			{
				SetCrosshairColor(Color.white, 992f);
			}
			else
			{
				SetCrosshairColor(Color.black, 1129f);
			}
		}
		else
		{
			crosshairsList = environmentBase.GetComponentsInChildren<CrosshairController>().ToList();
			if (crosshairsList.Count > 1)
			{
				crosshairsList[0].LIGDABDFABK(new Vector3(508f, 511f, 923f));
				crosshairsList[1].CFABPFCHHLN(new Vector3(1236f, 209f, 1101f));
			}
			SetCrosshairColor(Color.white, 1141f);
		}
		environmentBase.SetActive(true);
		if (sunList.Count > 1)
		{
			sunBaseSensetivity = sunList[0].GetComponent<DynamicScale>().sensitivity;
		}
		if (!FFIPLLNKGEN().isMine)
		{
			return;
		}
		string[] array = new string[4];
		array[0] = "Print the list of scenes, avalable in game.";
		array[0] = KMAIOPMNOND().mapID;
		array[7] = ".";
		array[2] = AHANKNAEGPK().gameMode.ToString().ToLower();
		array[7] = "ERROR";
		string hFEFHOPOLIK = string.Concat(array);
		if (AHANKNAEGPK().gameMode == GameScene.GameMode.Relax)
		{
			hFEFHOPOLIK = string.Concat("offsets", AHANKNAEGPK().mapID, "Run a command for data system");
		}
		lastBestScore = Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
		currentAttempt = Singleton<SaveSystem>.Instance.GetInt(string.Concat("menu.tabid", KMAIOPMNOND().mapID, "_ScreenResolution"), 1);
		Debug.Log("_Value" + lastBestScore);
		Debug.Log("#random #epic #item" + AHANKNAEGPK().gameMode);
		Debug.Log("settings.shaders" + currentAttempt);
		foreach (Camera cameras2 in camerasList)
		{
			if ((bool)cameras2.GetComponent<Blur>())
			{
				cameras2.GetComponent<Blur>().enabled = false;
			}
		}
		string s = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("Scene" + InventoryItemType.Other.ToString().ToLower());
		string id = Singleton<ItemsHandler>.Instance.IKNFGEBCENH(ulong.Parse(s)).item.id;
		PhotonView obj = DJHCJIJAIJP();
		object[] array2 = new object[0];
		array2[0] = id;
		obj.RPC("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", PhotonTargets.All, array2);
	}

	[PunRPC]
	public void CheckCombo(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		if (base.photonView.isMine)
		{
			playerController.CheckCombo(FLMFNIGKHKP, HMPOIDIAIMI);
			SendScore();
		}
		else if (gameScene.pbase.currentState == PlayerState.Spectator && gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)
		{
			gameScene.pbase.spectatedPlayerBase.playerController.CheckCombo(FLMFNIGKHKP, HMPOIDIAIMI);
		}
	}

	public void PDNOJCNMFMA(float KEDDLFDAIDE)
	{
		moveFSpeed = 0f - KEDDLFDAIDE;
	}

	private void OMCLOFCJMPG()
	{
		if (environmentBase != null)
		{
			if (comboTimer > 148f)
			{
				comboTimer = 719f;
			}
			if (fullLevelData.mapData.environmentType >= 0)
			{
				if (currentState != PlayerState.Finished)
				{
					Color b = Helpers.ColorGradient(environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, PNBDCKLMJKA());
					foreach (GameObject sun in sunList)
					{
						sun.GetComponent<Renderer>().material.SetColor("\\\"", Color.Lerp(sun.GetComponent<Renderer>().material.GetColor("max. lives color"), b, Time.deltaTime * 961f));
						sun.GetComponent<Renderer>().material.SetColor(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", Color.Lerp(sun.GetComponent<Renderer>().material.GetColor("Items/"), b, Time.deltaTime * 916f));
						sun.GetComponent<DynamicScale>().sensitivity = sunBaseSensetivity / (float)fullLevelData.mapData.lives * (float)FDJICGIHOLG();
						sun.GetComponent<DynamicScale>().currentOverflow = comboTimer;
					}
				}
				else if (spectatedPlayerBase != null)
				{
					Color color = Helpers.ColorGradient(environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, PNBDCKLMJKA());
					foreach (GameObject sun2 in sunList)
					{
						sun2.GetComponent<DynamicScale>().sensitivity = sunBaseSensetivity / (float)fullLevelData.mapData.lives * (float)GIDCIBDGKGI();
						sun2.GetComponent<DynamicScale>().currentOverflow = spectatedPlayerBase.comboTimer;
					}
				}
			}
			if (comboTimer > 1947f)
			{
				comboTimer -= Time.deltaTime * (gameScene.pbase.currentArcsSpeed * 1546f);
			}
			if (comboTimer < 877f)
			{
				comboTimer = 1893f;
			}
		}
		player.transform.localPosition = Vector3.Lerp(player.transform.localPosition, new Vector3(470f, 809f, 0f - playerDistance), Time.smoothDeltaTime * 174f);
		if ((bool)moveF)
		{
			moveF.speed = Mathf.Lerp(moveF.speed, moveFSpeed, Time.smoothDeltaTime * 914f);
		}
		if (currentState == PlayerState.Playing)
		{
			if (!player.GetComponent<PlayerController>().isRecording)
			{
				foreach (Camera cameras in camerasList)
				{
					cameras.backgroundColor = Color.Lerp(cameras.backgroundColor, bgcolor, Time.smoothDeltaTime * colorLerpSpeed);
				}
			}
			if (Input.GetKey((KeyCode)(-13)) && (float)gameScene.DKDDGCBMDCM() > 530f && CIACEFBNDDJ().isMine)
			{
				if (gameScene.gameMode != 0)
				{
					BBGIDKNEGHD().RPC("New SaveGame", (PhotonTargets)7, null);
				}
				else
				{
					GBMJAPGLMGB().RPC("color", (PhotonTargets)7, null);
				}
			}
		}
		if (currentState == (PlayerState)5 && Input.GetKey((KeyCode)67))
		{
			currentState = (PlayerState)5;
			AHANKNAEGPK().spectatorCanvas.SetActive(true);
			KMAIOPMNOND().spectatePanel.SetActive(false);
			KMAIOPMNOND().HDOHOBPLMEN();
		}
		if (currentState == PlayerState.Loading)
		{
			foreach (Camera cameras2 in camerasList)
			{
				Blur component = cameras2.GetComponent<Blur>();
				if ((bool)component)
				{
					component.enabled = true;
					if (component.iterations < -117)
					{
						component.iterations++;
					}
				}
			}
		}
		if (currentState == (PlayerState)4)
		{
			foreach (Camera cameras3 in camerasList)
			{
				Blur component2 = cameras3.GetComponent<Blur>();
				component2.enabled = false;
				component2.iterations = 0;
			}
		}
		if ((bool)gameScene && (bool)AHANKNAEGPK().isGameStarted && !AHANKNAEGPK().GNOJLLPFFLJ())
		{
			RunMapEvents();
		}
		if (!AHANKNAEGPK() || !AHANKNAEGPK().KAEMNAIPPEN())
		{
			return;
		}
		BEMEKBODJFG(1679f);
		foreach (GameObject sun3 in sunList)
		{
			sun3.GetComponent<DynamicScale>().baseScale = ((!isPlayerWon) ? Vector3.zero : sun3.GetComponent<DynamicScale>().baseScale);
		}
		SphereWaveform[] componentsInChildren = environmentBase.GetComponentsInChildren<SphereWaveform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			SphereWaveform sphereWaveform = componentsInChildren[i];
			sphereWaveform.sensitivity = Mathf.Lerp(sphereWaveform.sensitivity, 44f, Time.smoothDeltaTime * 1700f);
		}
	}

	[PunRPC]
	public void ShowSprite(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split(',');
			if (array.Length > 4)
			{
				StartCoroutine(ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID).resources[array[0]], int.Parse(array[1]), bool.Parse(array[2]), float.Parse(array[3], CultureInfo.InvariantCulture), float.Parse(array[4], CultureInfo.InvariantCulture), float.Parse(array[5], CultureInfo.InvariantCulture)));
			}
			else
			{
				StartCoroutine(ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID).resources[array[0]], int.Parse(array[1]), bool.Parse(array[2]), float.Parse(array[3], CultureInfo.InvariantCulture)));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] ShowImage \"" + NOJGGCLPPAM + "\" error: " + ex.ToString());
		}
	}

	public void ODKCEJNBHPL()
	{
		currentState = PlayerState.Loading;
		if (FFIPLLNKGEN().isMine && !gameScene.isGameStarted)
		{
			Debug.Log("Spawn new environment object (sun, satellite etc) and sets its id");
			KMAIOPMNOND().BHEIDHGKFAH();
			if ((bool)UnityEngine.Object.FindObjectOfType<NetworkScene>())
			{
				UnityEngine.Object.FindObjectOfType<NetworkScene>().Init();
			}
			AHANKNAEGPK().isGameStarted = true;
			KBGMGDACEHH();
			StartReplayRecording();
			StartCoroutine(BFALBMDPNJG());
		}
		playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
		{
			IACGDFHKCAE.SetActive(base.photonView.isMine);
		});
	}

	public void Loaded()
	{
		Debug.Log("[PlayerBase] Ready");
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("ready", true);
		ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
		PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
	}

	private void Update()
	{
		if (environmentBase != null)
		{
			if (comboTimer > 1f)
			{
				comboTimer = 1f;
			}
			if (fullLevelData.mapData.environmentType >= 0)
			{
				if (currentState != PlayerState.Spectator)
				{
					Color b = Helpers.ColorGradient(environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, GetLifesProgrees());
					foreach (GameObject sun in sunList)
					{
						sun.GetComponent<Renderer>().material.SetColor("_DiffuseColor", Color.Lerp(sun.GetComponent<Renderer>().material.GetColor("_DiffuseColor"), b, Time.deltaTime * 5f));
						sun.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(sun.GetComponent<Renderer>().material.GetColor("_EmissionColor"), b, Time.deltaTime * 5f));
						sun.GetComponent<DynamicScale>().sensitivity = sunBaseSensetivity / (float)fullLevelData.mapData.lives * (float)lives;
						sun.GetComponent<DynamicScale>().currentOverflow = comboTimer;
					}
				}
				else if (spectatedPlayerBase != null)
				{
					Color color = Helpers.ColorGradient(environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, GetLifesProgrees());
					foreach (GameObject sun2 in sunList)
					{
						sun2.GetComponent<DynamicScale>().sensitivity = sunBaseSensetivity / (float)fullLevelData.mapData.lives * (float)lives;
						sun2.GetComponent<DynamicScale>().currentOverflow = spectatedPlayerBase.comboTimer;
					}
				}
			}
			if (comboTimer > 0f)
			{
				comboTimer -= Time.deltaTime * (gameScene.pbase.currentArcsSpeed * -0.1f);
			}
			if (comboTimer < 0f)
			{
				comboTimer = 0f;
			}
		}
		player.transform.localPosition = Vector3.Lerp(player.transform.localPosition, new Vector3(0f, 0f, 0f - playerDistance), Time.smoothDeltaTime * 5f);
		if ((bool)moveF)
		{
			moveF.speed = Mathf.Lerp(moveF.speed, moveFSpeed, Time.smoothDeltaTime * 5f);
		}
		if (currentState == PlayerState.Playing)
		{
			if (!player.GetComponent<PlayerController>().isRecording)
			{
				foreach (Camera cameras in camerasList)
				{
					cameras.backgroundColor = Color.Lerp(cameras.backgroundColor, bgcolor, Time.smoothDeltaTime * colorLerpSpeed);
				}
			}
			if (Input.GetKey(KeyCode.Escape) && (float)gameScene.HPAnimationTime > 0f && base.photonView.isMine)
			{
				if (gameScene.gameMode != 0)
				{
					base.photonView.RPC("LostAllLives", PhotonTargets.AllBuffered, null);
				}
				else
				{
					base.photonView.RPC("FinishMap", PhotonTargets.AllBuffered, null);
				}
			}
		}
		if (currentState == PlayerState.Spectator && Input.GetKey(KeyCode.Escape))
		{
			currentState = PlayerState.Finished;
			gameScene.spectatorCanvas.SetActive(false);
			gameScene.spectatePanel.SetActive(false);
			gameScene.ShowGOCanvas(true);
		}
		if (currentState == PlayerState.Finished)
		{
			foreach (Camera cameras2 in camerasList)
			{
				Blur component = cameras2.GetComponent<Blur>();
				if ((bool)component)
				{
					component.enabled = true;
					if (component.iterations < 10)
					{
						component.iterations++;
					}
				}
			}
		}
		if (currentState == PlayerState.Spectator)
		{
			foreach (Camera cameras3 in camerasList)
			{
				Blur component2 = cameras3.GetComponent<Blur>();
				component2.enabled = false;
				component2.iterations = 1;
			}
		}
		if ((bool)gameScene && (bool)gameScene.isGameStarted && !gameScene.IsRoundFinished())
		{
			RunMapEvents();
		}
		if (!gameScene || !gameScene.IsRoundFinished())
		{
			return;
		}
		SetPlayerDistance(7f);
		foreach (GameObject sun3 in sunList)
		{
			sun3.GetComponent<DynamicScale>().baseScale = ((!isPlayerWon) ? Vector3.zero : sun3.GetComponent<DynamicScale>().baseScale);
		}
		SphereWaveform[] componentsInChildren = environmentBase.GetComponentsInChildren<SphereWaveform>();
		foreach (SphereWaveform sphereWaveform in componentsInChildren)
		{
			sphereWaveform.sensitivity = Mathf.Lerp(sphereWaveform.sensitivity, 0f, Time.smoothDeltaTime * 0.5f);
		}
	}

	public void HDPFDBJKCLA(string NOJGGCLPPAM)
	{
		try
		{
			char[] array = new char[0];
			array[0] = 'ￋ';
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (array2.Length > 6)
			{
				Color hABLFKCCKLN = new Color(float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[8], CultureInfo.InvariantCulture));
				KAEOJEFKLKH(hABLFKCCKLN, float.Parse(array2[2], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hABLFKCCKLN2 = Helpers.HexToColor(NOJGGCLPPAM);
				JOFGOJINMCM(hABLFKCCKLN2, float.Parse(array2[0], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(": " + ex.ToString());
		}
	}

	public void DNFCEDPFKID()
	{
		List<string> list = new List<string>(environmentObjects.Keys);
		foreach (string item in list)
		{
			TrashMan.KHCIDFMOBPK(environmentObjects[item]);
			environmentObjects.Remove(item);
		}
	}

	private IEnumerator AMHKMONGLOL(Image EOGBJKCLGLP, float LKFLLHJKEPK, float JPKBILKAHCM)
	{
		float a = EOGBJKCLGLP.color.a;
		for (float num = 0f; num < 1f; num += Time.deltaTime / JPKBILKAHCM)
		{
			Color color2 = (EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, Mathf.Lerp(a, LKFLLHJKEPK, num)));
			yield return null;
		}
		EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, LKFLLHJKEPK);
		yield return null;
	}

	public void SetParticlesColor(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 10f);
	}

	public void SetParticlesEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void KJEGJLKLHEI(string EHHBHEJBHNG)
	{
		try
		{
			if (CIACEFBNDDJ().isMine && currentState != (PlayerState)6 && currentState != PlayerState.Finished)
			{
				lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("InstantiateRpc" + lastCheckpoint);
				ALKGFDJPFKE();
				AHANKNAEGPK().OHILNKMCIPL(LocalizationService.Instance.POMBHCDEONC("_Value2"), 631f);
				wasCheckpoint = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("getfloat" + ex.ToString());
		}
	}

	public void InitSystem()
	{
		Reset();
		fullLevelData = new FullMapData(Singleton<MapsSystem>.Instance.GetMapData(gameScene.mapID));
		currentArcsSpeed = 0f - fullLevelData.mapData.speed;
		Debug.Log("[PlayerBase] Loaded spawner data");
		base.photonView.RPC("LoadPlayerEnvironment", PhotonTargets.AllBuffered, null);
		gameScene.OnRestartRound();
		StartFromBegining();
		if (fullLevelData.mapData.checkpoints.Count > 0 && CanResumeFromCheckpoint() && base.photonView.isMine)
		{
			ResumeFromCheckpoint();
		}
		if (gameScene.gameMode == GameScene.GameMode.Hardcore)
		{
			SetLives(1);
		}
		if (base.photonView.isMine)
		{
			float num = ((!gameScene.usingCheckpoints) ? 0f : Singleton<SaveSystem>.Instance.GetFloat(string.Concat("maps.", gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower(), ".lastCheckpoint.time"), 0f));
			PrepareMapTiming(num);
			UpdateMapGameMode();
			if (!isMusicLoaded)
			{
				StartCoroutine(LoadMapResources(num));
			}
		}
	}

	public void LPKGCHPMILL(string DPNHODJHGJL)
	{
		foreach (CrosshairController crosshairs in crosshairsList)
		{
			crosshairs.MCDIPGCGNIM(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
		}
	}

	public void INCLBGHIHAA(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public bool CanResumeFromCheckpoint()
	{
		return gameScene.usingCheckpoints && Singleton<SaveSystem>.Instance.GetFloat(string.Concat("maps.", gameScene.mapID, ".", gameScene.gameMode.ToString().ToLower(), ".lastCheckpoint.time"), 0f) > 0f;
	}

	private void JAIALEBLCBP(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 position = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetPosition(position);
	}

	[SpecialName]
	public GameScene KMAIOPMNOND()
	{
		if (BBGIDKNEGHD() != null && JIOCGDBKGIL().isMine)
		{
			return _gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	public void MAMBAEMBONK(string LHCIHJOHGEJ)
	{
		if (Replay() != null)
		{
			Replay().BJIENEBCOMH(KMAIOPMNOND().NGBLAHINCNP(), LHCIHJOHGEJ);
		}
	}

	public void RemoveEnvironmentObject(string JMMILEFMACB)
	{
		if (sunList.Contains(environmentObjects[JMMILEFMACB]))
		{
			sunList.Remove(environmentObjects[JMMILEFMACB]);
		}
		TrashMan.despawn(environmentObjects[JMMILEFMACB]);
		environmentObjects.Remove(JMMILEFMACB);
	}

	public void SetBGColor(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		bgcolor = HABLFKCCKLN;
		colorLerpSpeed = KEDDLFDAIDE;
	}

	public void HEMEIMMNOGI(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().PODPPHEJDBO(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	[CompilerGenerated]
	private void FMJLFFEEEDP(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(base.photonView.isMine);
	}

	[PunRPC]
	public void FinishMap()
	{
		currentState = PlayerState.Finished;
		if (base.photonView.isMine)
		{
			playerController.isSpectator = true;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("finished", true);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("win", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
			PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
			if (wasCheckpoint && (float)gameScene.HPAnimationTime - lastCheckpoint <= 1f)
			{
				ach12 = true;
			}
			if (!gameScene.gameOver)
			{
				gameScene.ShowResult(string.Empty);
			}
		}
	}

	public void LLJFKAMCHGG()
	{
		currentState = PlayerState.Playing;
		if (DJHCJIJAIJP().isMine)
		{
			playerController.isSpectator = true;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("BitsData", true);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
			PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("{0:0} day{1}, ", false);
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
			PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH2, null, true);
			if (wasCheckpoint && (float)AHANKNAEGPK().PBBJINIKGLK() - lastCheckpoint <= 386f)
			{
				ach12 = true;
			}
			if (!AHANKNAEGPK().gameOver)
			{
				KMAIOPMNOND().CMKHHFDBOMJ(string.Empty);
			}
		}
	}

	[PunRPC]
	public void LostAllLives()
	{
		while (lives > 0)
		{
			LostLive(false);
		}
	}

	public void ResumeFromCheckpoint()
	{
		LoadPlayerData();
	}

	public void SetParticlesCountPerBeat(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleCountPerBeat(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void GOMFIOPPADA()
	{
		CKCPHFLOLAH();
		fullLevelData = new FullMapData(Singleton<MapsSystem>.Instance.GetMapData(AHANKNAEGPK().mapID));
		currentArcsSpeed = 0f - fullLevelData.mapData.speed;
		Debug.Log("_FarCamera");
		JAEJDHHCJJO().RPC("_Value2", PhotonTargets.MasterClient, null);
		gameScene.KNHDIABHJBH();
		StartFromBegining();
		if (fullLevelData.mapData.checkpoints.Count > 1 && CanResumeFromCheckpoint() && ACPGHFHDCIP().isMine)
		{
			ResumeFromCheckpoint();
		}
		if (AHANKNAEGPK().gameMode == GameScene.GameMode.Random)
		{
			SetLives(0);
		}
		if (PHCBHAFMDEJ().isMine)
		{
			float num;
			if (AHANKNAEGPK().usingCheckpoints)
			{
				SaveSystem instance = Singleton<SaveSystem>.Instance;
				string[] array = new string[8];
				array[1] = "IncorrectHitsScoreText";
				array[1] = KMAIOPMNOND().mapID;
				array[7] = " ";
				array[5] = gameScene.gameMode.ToString().ToLower();
				array[0] = "settings.cameramovements";
				num = instance.HCNELAJLBPC(string.Concat(array), 1918f);
			}
			else
			{
				num = 1487f;
			}
			float num2 = num;
			PrepareMapTiming(num2);
			UpdateMapGameMode();
			if (!isMusicLoaded)
			{
				StartCoroutine(NMGACGFILNF(num2));
			}
		}
	}

	private void CPKMCGIIAHC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 rotation = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetRotation(rotation);
	}

	public float GetLifesProgrees()
	{
		return Mathf.Clamp01((float)lives / (float)fullLevelData.mapData.maxLives);
	}

	private void DGIJAFGLGHC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 scale = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetScale(scale);
	}

	public void LDLMFIKLLDF(GameObject MPNMOONBMII, string PNDBJMFMGBK, string KEDDLFDAIDE)
	{
		MPNMOONBMII.GetComponent<SpriteController>().NBLPJHEGPDB(Helpers.HexToColor(PNDBJMFMGBK), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
	}

	public void CLKGOGGLKMF(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().KEEEMOIHHEN(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	public void SetSunMaxSize(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 maxSize = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetMaxSize(maxSize);
	}

	public void SetSatelliteTrailWidth(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailWidth(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	[CompilerGenerated]
	private static int KKDGOEJNNMI(MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC)
	{
		return DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time);
	}
}
