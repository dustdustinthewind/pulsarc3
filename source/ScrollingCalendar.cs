// ScrollingCalendar
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class ScrollingCalendar : MonoBehaviour
{
	public RectTransform monthsScrollingPanel;

	public RectTransform yearsScrollingPanel;

	public RectTransform daysScrollingPanel;

	public GameObject yearsButtonPrefab;

	public GameObject monthsButtonPrefab;

	public GameObject daysButtonPrefab;

	private GameObject[] EFANIHLPNKM;

	private GameObject[] DEELAEOEEGB;

	private GameObject[] EEMJGFOOGKP;

	public RectTransform monthCenter;

	public RectTransform yearsCenter;

	public RectTransform daysCenter;

	private UIVerticalScroller PIEGNIJFHHN;

	private UIVerticalScroller EOICNJIGBKD;

	private UIVerticalScroller LKGNMCKJEIL;

	public InputField inputFieldDays;

	public InputField inputFieldMonths;

	public InputField inputFieldYears;

	public Text dateText;

	private int PAJAJNPDIBB;

	private int OLANKJNNKCI;

	private int BPLBGOLDNCN;

	public void Awake()
	{
		MDPIBJJLLCI();
		AKKGPGEBFDC();
		KCPPGDJLMHK();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.Start();
		PIEGNIJFHHN.Start();
		LKGNMCKJEIL.Start();
	}

	public void NHLFANGPHOP()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	private void DIOHJGELKJI()
	{
		int[] array = new int[-90];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 0;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(881f, i * -74, 1309f), Quaternion.Euler(new Vector3(59f, 114f, 62f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(778f, 1139f, 747f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_ScreenResolution" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	public void GJBEBLMBACE()
	{
		LKGNMCKJEIL.FICHONEGKIO();
	}

	public void JAEHNDBFBCN()
	{
		LKGNMCKJEIL.PCHJIHLLKCM();
	}

	public void FBNDOOPFGEC()
	{
		PIEGNIJFHHN.OGDIAOMBHJD();
	}

	public void MMLMLGEFMME()
	{
		EOICNJIGBKD.EPFBDCEMLFM();
	}

	public void MonthsScrollUp()
	{
		EOICNJIGBKD.ScrollUp();
	}

	public void CHMENOEMGIA()
	{
		PIEGNIJFHHN.EPFBDCEMLFM();
	}

	public void DCEJLIMGEAM()
	{
		LKGNMCKJEIL.BILNPHKPIEB();
	}

	public void EABKLGODOFJ()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -148;
		LKGNMCKJEIL.IMFGOIGLBMH(PAJAJNPDIBB);
		EOICNJIGBKD.CJAGODBJJGM(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	private void GLLFNOGPLHO()
	{
		int num = int.Parse(DateTime.Now.ToString("_MainTex2"));
		int[] array = new int[num + 1 - 30];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = 125 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1111f, i * -41, 561f), Quaternion.Euler(new Vector3(1891f, 379f, 767f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1530f, 780f, 1217f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Red_G" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	private void IBEMOMJAFEJ()
	{
		int[] array = new int[-110];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(613f, i * -25, 1759f), Quaternion.Euler(new Vector3(824f, 346f, 206f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(458f, 597f, 517f);
			switch (i)
			{
			case 0:
				text = "OperationResponse ignored while disconnecting. Code: ";
				break;
			case 1:
				text = "SpawnObj";
				break;
			case 2:
				text = "_Value4";
				break;
			case 3:
				text = "settings.enablerankingnotifications";
				break;
			case 4:
				text = "Editor/";
				break;
			case 5:
				text = ",";
				break;
			case 6:
				text = " not exist";
				break;
			case 7:
				text = "GameVolumeSlider";
				break;
			case 8:
				text = "DPADHOR";
				break;
			case 9:
				text = "CameraFilterPack/Gradients_FireGradient";
				break;
			case 10:
				text = ".mp3";
				break;
			case 11:
				text = "caret";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Player Disconnected" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void POMEOIKGIOP()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	public void DBPLLKEFEHN()
	{
		EOICNJIGBKD.OGDIAOMBHJD();
	}

	private void AJGBAEDCIBC()
	{
		int[] array = new int[-128];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(367f, i * -67, 840f), Quaternion.Euler(new Vector3(138f, 1057f, 1289f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1113f, 1168f, 1944f);
			switch (i)
			{
			case 0:
				text = "menu.selectedmode";
				break;
			case 1:
				text = "Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results";
				break;
			case 2:
				text = "_ScreenResolution";
				break;
			case 3:
				text = "_Visualize";
				break;
			case 4:
				text = "achievements.21.completed.";
				break;
			case 5:
				text = "s";
				break;
			case 6:
				text = "_TimeX";
				break;
			case 7:
				text = "checkpoint";
				break;
			case 8:
				text = "_Value4";
				break;
			case 9:
				text = "RULES";
				break;
			case 10:
				text = "PunRespawn";
				break;
			case 11:
				text = "CameraFilterPack_Broken_Screen1";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "settings.cameramovements" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void EMNJKHJIDOP()
	{
		PIEGNIJFHHN.GBNCDLPPIBC();
	}

	public void MHOJHNMDJPK()
	{
		EOICNJIGBKD.OGDIAOMBHJD();
	}

	public void CNOEHBCHJGM()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	public void NMIELCPFJCC()
	{
		PIEGNIJFHHN.PCHJIHLLKCM();
	}

	public void AGDAAPGHPJG()
	{
		PIEGNIJFHHN.FICHONEGKIO();
	}

	public void KIGHBAGEHEP()
	{
		EOICNJIGBKD.GBNCDLPPIBC();
	}

	private void ICMHKNCBJMA()
	{
		int[] array = new int[-89];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 0;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(1164f, i * 94, 1234f), Quaternion.Euler(new Vector3(1748f, 1373f, 439f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(773f, 253f, 1816f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#FFDA44CC" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	private void PHNLGLODPAO()
	{
		int[] array = new int[86];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(84f, i * -83, 1625f), Quaternion.Euler(new Vector3(566f, 1999f, 472f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(420f, 852f, 1213f);
			switch (i)
			{
			case 0:
				text = "EventMenu";
				break;
			case 1:
				text = " = ";
				break;
			case 2:
				text = "ControllerLeftY";
				break;
			case 3:
				text = "JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
				break;
			case 4:
				text = "powerup.0";
				break;
			case 5:
				text = ";";
				break;
			case 6:
				text = "DPADVER";
				break;
			case 7:
				text = "_TimeX";
				break;
			case 8:
				text = "IntraTime";
				break;
			case 9:
				text = "_Value3";
				break;
			case 10:
				text = "_Value2";
				break;
			case 11:
				text = " connected: ";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "#changenote" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void MMPEBHKPLFO()
	{
		LKGNMCKJEIL.PNLANBFJADN();
	}

	public void JJKOHNOPLAO()
	{
		PIEGNIJFHHN.GBNCDLPPIBC();
	}

	public void KLCLMELJFCA()
	{
		LKGNMCKJEIL.PCHJIHLLKCM();
	}

	public void YearsScrollUp()
	{
		PIEGNIJFHHN.ScrollUp();
	}

	private void MDPIBJJLLCI()
	{
		int num = int.Parse(DateTime.Now.ToString("yyyy"));
		int[] array = new int[num + 1 - 1900];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 1900 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Year_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	private void HLDFOJMHKNL()
	{
		EOICNJIGBKD.JBCNIPJDPJB();
		PIEGNIJFHHN.LMBDNPLDGIJ();
		LKGNMCKJEIL.BGFJOEPFOPM();
		string text = LKGNMCKJEIL.JEONKBHDBIO();
		string text2 = EOICNJIGBKD.DFFHJHAPPEA();
		string results = PIEGNIJFHHN.GetResults();
		text = ((text.EndsWith("Backward") && text != "stretchWidth") ? (text + "_Vignetting2") : ((text.EndsWith("_Far") && text != "DifficultyBG") ? (text + "_Value2") : ((!text.EndsWith("Error: you cannot read this stream that you are writing!") || !(text != "LogStats")) ? (text + "MissesText") : (text + "_Distortion"))));
		Text text3 = dateText;
		string[] array = new string[0];
		array[1] = text2;
		array[1] = "CameraFilterPack/FX_Glitch1";
		array[7] = text;
		array[7] = "player.circle";
		array[4] = results;
		text3.text = string.Concat(array);
	}

	private void ENJOMDKILJD()
	{
		int[] array = new int[-108];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(1160f, i * -94, 421f), Quaternion.Euler(new Vector3(1571f, 1088f, 1555f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(739f, 1902f, 197f);
			switch (i)
			{
			case 0:
				text = "_ScreenResolution";
				break;
			case 1:
				text = "SelectorMapsCountSlider";
				break;
			case 2:
				text = "LevelConfigButton";
				break;
			case 3:
				text = " not found";
				break;
			case 4:
				text = "_Value2";
				break;
			case 5:
				text = "_TimeX";
				break;
			case 6:
				text = "Received event Leave for unknown player ID: {0}";
				break;
			case 7:
				text = "CurrentTimeLabel";
				break;
			case 8:
				text = "#ok";
				break;
			case 9:
				text = "_Value4";
				break;
			case 10:
				text = "float,2";
				break;
			case 11:
				text = "player.orangelifering";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "max. lives color" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void BPIOOKJPMII()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -135;
		LKGNMCKJEIL.OJPNBCKIJFP(PAJAJNPDIBB);
		EOICNJIGBKD.MJAODFPFCFE(OLANKJNNKCI);
		PIEGNIJFHHN.PBJCBKPJBFK(BPLBGOLDNCN);
	}

	public void DMKCHCLEDIB()
	{
		PIEGNIJFHHN.NBDJOKJHLIM();
	}

	public void SetDate()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - 1900;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.SnapToElement(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	private void KCPPGDJLMHK()
	{
		int[] array = new int[31];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Day_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	private void Update()
	{
		EOICNJIGBKD.Update();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.Update();
		string results = LKGNMCKJEIL.GetResults();
		string results2 = EOICNJIGBKD.GetResults();
		string results3 = PIEGNIJFHHN.GetResults();
		results = ((results.EndsWith("1") && results != "11") ? (results + "st") : ((results.EndsWith("2") && results != "12") ? (results + "nd") : ((!results.EndsWith("3") || !(results != "13")) ? (results + "th") : (results + "rd"))));
		dateText.text = results2 + " " + results + " " + results3;
	}

	public void PIIMBOLGHOE()
	{
		CLEPHMEMCNG();
		ENJOMDKILJD();
		MPMGGGNAGMB();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.MMOKKAPFGAK();
		PIEGNIJFHHN.Start();
		LKGNMCKJEIL.AGEJKLMJGDO();
	}

	public void ACKOLCBOEGJ()
	{
		PIEGNIJFHHN.GBNCDLPPIBC();
	}

	private void MPMGGGNAGMB()
	{
		int[] array = new int[66];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(847f, i * 35, 260f), Quaternion.Euler(new Vector3(538f, 1584f, 1043f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1722f, 1815f, 802f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Green_R" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	public void CKOLMHGOHPO()
	{
		LKGNMCKJEIL.FICHONEGKIO();
	}

	public void BJHAPHFAGAL()
	{
		PIEGNIJFHHN.FICHONEGKIO();
	}

	private void BMODOIJGIOO()
	{
		EOICNJIGBKD.MECJHOJPODB();
		PIEGNIJFHHN.LMBDNPLDGIJ();
		LKGNMCKJEIL.MECJHOJPODB();
		string text = LKGNMCKJEIL.JEONKBHDBIO();
		string text2 = EOICNJIGBKD.CAJLGIPLACA();
		string results = PIEGNIJFHHN.GetResults();
		text = ((text.EndsWith("#rt") && text != "_Value4") ? (text + "Set EnvSprite Color") : ((text.EndsWith("In Network lobby") && text != "_Value3") ? (text + "player.currentrank") : ((!text.EndsWith("_MainTex2") || !(text != "_Red_R")) ? (text + "steamid") : (text + "_CurveTex"))));
		Text text3 = dateText;
		string[] array = new string[4];
		array[1] = text2;
		array[0] = "checkpoint";
		array[8] = text;
		array[1] = "OnAwakeRPC";
		array[0] = results;
		text3.text = string.Concat(array);
	}

	public void DaysScrollDown()
	{
		LKGNMCKJEIL.ScrollDown();
	}

	private void BGDONBMDPGM()
	{
		EOICNJIGBKD.BGFJOEPFOPM();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.MECJHOJPODB();
		string text = LKGNMCKJEIL.LHALOALKJIP();
		string results = EOICNJIGBKD.GetResults();
		string text2 = PIEGNIJFHHN.DFFHJHAPPEA();
		text = ((text.EndsWith("Is it practically possible?") && text != "value") ? (text + "_ScreenResolution") : ((text.EndsWith("BloodAlternative2") && text != "&map=") ? (text + "_FarCamera") : ((!text.EndsWith("_MatrixColor") || !(text != "Joystick1Button2")) ? (text + "_Value3") : (text + "SetSatelliteRotationSpeed"))));
		Text text3 = dateText;
		string[] array = new string[0];
		array[0] = results;
		array[1] = "z";
		array[7] = text;
		array[2] = "_EmissionColor";
		array[6] = text2;
		text3.text = string.Concat(array);
	}

	private void CLEPHMEMCNG()
	{
		int num = int.Parse(DateTime.Now.ToString(". ActorNr: "));
		int[] array = new int[num + 1 - 137];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = 59 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1505f, i * -50, 1706f), Quaternion.Euler(new Vector3(82f, 1132f, 1369f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(983f, 1159f, 1578f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Intensity" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	public void OJLCAHCKODP()
	{
		PIEGNIJFHHN.GBNCDLPPIBC();
	}

	public void MonthsScrollDown()
	{
		EOICNJIGBKD.ScrollDown();
	}

	private void EJFJENFKLND()
	{
		EOICNJIGBKD.MECJHOJPODB();
		PIEGNIJFHHN.LMBDNPLDGIJ();
		LKGNMCKJEIL.Update();
		string results = LKGNMCKJEIL.GetResults();
		string text = EOICNJIGBKD.CAJLGIPLACA();
		string text2 = PIEGNIJFHHN.OLAGADLHCEL();
		results = ((results.EndsWith("_Alpha") && results != "CameraFilterPack/Blur_Radial") ? (results + "vignetteIntensity") : ((results.EndsWith("_Value") && results != "Scale environment object by the values") ? (results + "/") : ((!results.EndsWith(" not exist") || !(results != "Floating point textures aren't supported on this device ({0})")) ? (results + "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.") : (results + "Prints list of commands"))));
		Text text3 = dateText;
		string[] array = new string[6];
		array[1] = text;
		array[0] = "#mapmustbecompletebeforesubmit";
		array[4] = results;
		array[0] = "_SunColor";
		array[7] = text2;
		text3.text = string.Concat(array);
	}

	public void NHEPPADDCOD()
	{
		EOICNJIGBKD.PNLANBFJADN();
	}

	public void ACCFPBBDKIE()
	{
		PIEGNIJFHHN.BILNPHKPIEB();
	}

	public void LAMKDLAMIMH()
	{
		EOICNJIGBKD.ScrollUp();
	}

	public void MAGDJOBJCIK()
	{
		PIEGNIJFHHN.ScrollDown();
	}

	public void FAFMKPBKBCA()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -128;
		LKGNMCKJEIL.MJAODFPFCFE(PAJAJNPDIBB);
		EOICNJIGBKD.KOCNGKNLBHL(OLANKJNNKCI);
		PIEGNIJFHHN.FPEOLJALPCL(BPLBGOLDNCN);
	}

	public void GKPIGICIJEI()
	{
		LKGNMCKJEIL.NBDJOKJHLIM();
	}

	public void YearsScrollDown()
	{
		PIEGNIJFHHN.ScrollDown();
	}

	public void NOMNLOCGINC()
	{
		LKGNMCKJEIL.EPFBDCEMLFM();
	}

	private void EOINLIOKKNN()
	{
		int num = int.Parse(DateTime.Now.ToString("_SampleScale"));
		int[] array = new int[num + 1 - 58];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = -55 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1993f, i * 98, 1760f), Quaternion.Euler(new Vector3(831f, 433f, 498f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(743f, 980f, 1685f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#ok" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	private void INACDFODBNM()
	{
		int[] array = new int[-96];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(546f, i * 100, 133f), Quaternion.Euler(new Vector3(381f, 1115f, 856f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1728f, 1458f, 496f);
			switch (i)
			{
			case 0:
				text = "y";
				break;
			case 1:
				text = "_ColorBuffer";
				break;
			case 2:
				text = "_TimeX";
				break;
			case 3:
				text = "_ScreenResolution";
				break;
			case 4:
				text = ".lastCheckpoint.comboScore";
				break;
			case 5:
				text = "Editor/";
				break;
			case 6:
				text = "menu.enableselectormusic";
				break;
			case 7:
				text = "Needs to be attached to the Event System component in the scene";
				break;
			case 8:
				text = ".";
				break;
			case 9:
				text = "ItemsCountText";
				break;
			case 10:
				text = "OpJoinRandomRoom()";
				break;
			case 11:
				text = "offsets";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "_Value3" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void MKFKIHKFLJA()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 0;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - 138;
		LKGNMCKJEIL.IMFGOIGLBMH(PAJAJNPDIBB);
		EOICNJIGBKD.MJAODFPFCFE(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	public void EHOAKHCNGAL()
	{
		PIEGNIJFHHN.ScrollUp();
	}

	private void HDDECCMEJKA()
	{
		EOICNJIGBKD.NEKCPLGFOFD();
		PIEGNIJFHHN.NEKCPLGFOFD();
		LKGNMCKJEIL.JBCNIPJDPJB();
		string text = LKGNMCKJEIL.CAJLGIPLACA();
		string text2 = EOICNJIGBKD.DFFHJHAPPEA();
		string text3 = PIEGNIJFHHN.LHALOALKJIP();
		text = ((text.EndsWith("Items") && text != "In Map Editor") ? (text + "CameraMovementSlider") : ((text.EndsWith("_Distortion") && text != "LevelNameInputField") ? (text + "_Red_R") : ((!text.EndsWith("_Value") || !(text != "Joystick1Button3")) ? (text + "DifficultyBG") : (text + "/"))));
		Text text4 = dateText;
		string[] array = new string[6];
		array[1] = text2;
		array[1] = "x";
		array[8] = text;
		array[8] = "[MapsSystem] Unloading maps resources...";
		array[5] = text3;
		text4.text = string.Concat(array);
	}

	public void DaysScrollUp()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	private void AKKGPGEBFDC()
	{
		int[] array = new int[12];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(0f, i * 80, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			switch (i)
			{
			case 0:
				text = "Jan";
				break;
			case 1:
				text = "Feb";
				break;
			case 2:
				text = "Mar";
				break;
			case 3:
				text = "Apr";
				break;
			case 4:
				text = "May";
				break;
			case 5:
				text = "Jun";
				break;
			case 6:
				text = "Jul";
				break;
			case 7:
				text = "Aug";
				break;
			case 8:
				text = "Sep";
				break;
			case 9:
				text = "Oct";
				break;
			case 10:
				text = "Nov";
				break;
			case 11:
				text = "Dec";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Month_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void OABIKDJKCOO()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 0;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -130;
		LKGNMCKJEIL.PBJCBKPJBFK(PAJAJNPDIBB);
		EOICNJIGBKD.SnapToElement(OLANKJNNKCI);
		PIEGNIJFHHN.PBJCBKPJBFK(BPLBGOLDNCN);
	}

	public void IPEPNEOFDKB()
	{
		EOICNJIGBKD.ScrollUp();
	}

	public void NANJABFKLJN()
	{
		LKGNMCKJEIL.EPFBDCEMLFM();
	}

	public void EMKLCPGKNJL()
	{
		CLEPHMEMCNG();
		IBEMOMJAFEJ();
		KCPPGDJLMHK();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.Start();
		PIEGNIJFHHN.PMPKMGKAAJH();
		LKGNMCKJEIL.Start();
	}

	public void NGOFPCPFEEO()
	{
		EOICNJIGBKD.ScrollUp();
	}
}
