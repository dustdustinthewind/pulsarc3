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

	public void LHIBCDLJNBG()
	{
		EOICNJIGBKD.BOBALPEINEB();
	}

	private void EACLJDHBPAD()
	{
		int[] array = new int[111];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(698f, i * 86, 1788f), Quaternion.Euler(new Vector3(973f, 155f, 1222f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(852f, 1300f, 411f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value3" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	public void GOAKIFEMHEE()
	{
		PIEGNIJFHHN.BOBALPEINEB();
	}

	public void PHECBKLKNOI()
	{
		EOICNJIGBKD.ScrollUp();
	}

	private void NFEFDCAPHHG()
	{
		int num = int.Parse(DateTime.Now.ToString("_TimeX"));
		int[] array = new int[num + 1 - 70];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = 148 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1913f, i * -43, 1150f), Quaternion.Euler(new Vector3(1671f, 1115f, 1124f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1728f, 86f, 1077f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#,0.00" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	public void JPJNECPABBG()
	{
		MDPIBJJLLCI();
		KIHIANNCBCE();
		KCPPGDJLMHK();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.KIMMMCJFMAB();
		PIEGNIJFHHN.KIMMMCJFMAB();
		LKGNMCKJEIL.NBGIMIDICKE();
	}

	public void BEIMJHCKIML()
	{
		PIEGNIJFHHN.BNNCONEBKNC();
	}

	public void EBNOLAPAKKF()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 0;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - 141;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.OEJEKPAOHKP(OLANKJNNKCI);
		PIEGNIJFHHN.OEJEKPAOHKP(BPLBGOLDNCN);
	}

	private void APBIGIPCJOM()
	{
		int[] array = new int[109];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(323f, i * -100, 112f), Quaternion.Euler(new Vector3(455f, 1996f, 1007f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(434f, 18f, 1756f);
			switch (i)
			{
			case 0:
				text = "0,1,true,0";
				break;
			case 1:
				text = "_NeighbourMaxTex";
				break;
			case 2:
				text = "\\\"";
				break;
			case 3:
				text = "_Value4";
				break;
			case 4:
				text = "_FixDistance";
				break;
			case 5:
				text = "_NoOuterClip";
				break;
			case 6:
				text = "_ScreenResolution";
				break;
			case 7:
				text = "Joystick1Button5";
				break;
			case 8:
				text = "player.blackcat";
				break;
			case 9:
				text = "Subscribed cells:\n";
				break;
			case 10:
				text = "masterSteamID";
				break;
			case 11:
				text = "public";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "masterSteamID" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void CGFHHDMEAKH()
	{
		PIEGNIJFHHN.ScrollDown();
	}

	public void JEEINPBLBDI()
	{
		NFEFDCAPHHG();
		AKKGPGEBFDC();
		LAECMIJGBNO();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.Start();
		PIEGNIJFHHN.Start();
		LKGNMCKJEIL.KIMMMCJFMAB();
	}

	public void NBNJJBJCICN()
	{
		PIEGNIJFHHN.ScrollUp();
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

	public void MADENBGHKDD()
	{
		BNGGHDJFHAP();
		APBIGIPCJOM();
		KCPPGDJLMHK();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.Start();
		PIEGNIJFHHN.Start();
		LKGNMCKJEIL.KIMMMCJFMAB();
	}

	public void LDLCJEELGCF()
	{
		EOICNJIGBKD.BOBALPEINEB();
	}

	private void OJLEBPNCCOC()
	{
		int[] array = new int[-29];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(1350f, i * -74, 1329f), Quaternion.Euler(new Vector3(51f, 222f, 1328f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1536f, 1139f, 345f);
			switch (i)
			{
			case 0:
				text = "maps.";
				break;
			case 1:
				text = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
				break;
			case 2:
				text = ".lastCheckpoint.perfectHits";
				break;
			case 3:
				text = "Set camera (or player) distance. Base player distance - 14";
				break;
			case 4:
				text = "LoadMapCanvas";
				break;
			case 5:
				text = "menu.selectedplaymode";
				break;
			case 6:
				text = "EventSystem";
				break;
			case 7:
				text = "_Offsets";
				break;
			case 8:
				text = "win";
				break;
			case 9:
				text = "/";
				break;
			case 10:
				text = "CameraFilterPack/NightVision_4";
				break;
			case 11:
				text = " Owner called.";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = " in SaveLoadMenu.prefabDictionary!" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	private void LAECMIJGBNO()
	{
		int[] array = new int[80];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(1901f, i * -22, 1717f), Quaternion.Euler(new Vector3(1683f, 677f, 946f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1787f, 462f, 365f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#C8C8C8FF" + array[i];
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

	public void MonthsScrollUp()
	{
		EOICNJIGBKD.ScrollUp();
	}

	public void DaysScrollUp()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	private void NGOCBEDJHMD()
	{
		int[] array = new int[88];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(682f, i * -73, 528f), Quaternion.Euler(new Vector3(89f, 1103f, 535f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(62f, 966f, 225f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "GameMessagesDurationSlider" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	public void YearsScrollDown()
	{
		PIEGNIJFHHN.ScrollDown();
	}

	private void CCKIHJDLABK()
	{
		int num = int.Parse(DateTime.Now.ToString(": "));
		int[] array = new int[num + 1 - 64];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = -127 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1388f, i * 90, 1878f), Quaternion.Euler(new Vector3(718f, 1088f, 803f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(481f, 1065f, 1584f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value2" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

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

	private void GHILDCBCDJI()
	{
		EOICNJIGBKD.NKLIHNJCHOG();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.Update();
		string results = LKGNMCKJEIL.GetResults();
		string text = EOICNJIGBKD.EEOPGLMHLLK();
		string results2 = PIEGNIJFHHN.GetResults();
		results = ((results.EndsWith("<b>") && results != "maps.") ? (results + "Item ") : ((results.EndsWith("CameraFilterPack/3D_Computer") && results != "other.dust2") ? (results + "SetParticlesCountPerBeat") : ((!results.EndsWith("BitsData") || !(results != "ChangeSelectedLevel")) ? (results + "GlassDistortion") : (results + "_ScreenResolution"))));
		Text text2 = dateText;
		string[] array = new string[3];
		array[1] = text;
		array[1] = "\t";
		array[7] = results;
		array[0] = "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)";
		array[8] = results2;
		text2.text = string.Concat(array);
	}

	public void FNNGOIEOCCH()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 0;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -129;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.DNDJKEDIKLD(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
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

	public void KKHOLABOGGI()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 1;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - 185;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.DNDJKEDIKLD(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	public void DaysScrollDown()
	{
		LKGNMCKJEIL.ScrollDown();
	}

	public void LOMHIIKFFEP()
	{
		PGKLGKFHAGE();
		AHLDDGKBPMC();
		EACLJDHBPAD();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.KIMMMCJFMAB();
		PIEGNIJFHHN.KIMMMCJFMAB();
		LKGNMCKJEIL.KIMMMCJFMAB();
	}

	public void MonthsScrollDown()
	{
		EOICNJIGBKD.ScrollDown();
	}

	public void NLPMMFGNGMK()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	public void CKGOOFEEDMJ()
	{
		PIEGNIJFHHN.ScrollDown();
	}

	public void CCIKECLCFGI()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	private void KMKLDAJLCNM()
	{
		EOICNJIGBKD.NKLIHNJCHOG();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.NKLIHNJCHOG();
		string text = LKGNMCKJEIL.EEOPGLMHLLK();
		string results = EOICNJIGBKD.GetResults();
		string results2 = PIEGNIJFHHN.GetResults();
		text = ((text.EndsWith("maps.") && text != "RoomPlayersCountText") ? (text + "_Value7") : ((text.EndsWith("CameraFilterPack/Glow_Glow_Color") && text != "[PlayerBase] Loaded music") ? (text + "player.goldlollipop") : ((!text.EndsWith(".lastCheckpoint.penaltyScore") || !(text != "float,0.5")) ? (text + "_MainTex2") : (text + "_FixDistance"))));
		Text text2 = dateText;
		string[] array = new string[0];
		array[1] = results;
		array[0] = "masterVolume";
		array[4] = text;
		array[0] = "ItemsCountText";
		array[8] = results2;
		text2.text = string.Concat(array);
	}

	private void OHODBGOBOJF()
	{
		int[] array = new int[118];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(1545f, i * -111, 127f), Quaternion.Euler(new Vector3(1425f, 543f, 20f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(345f, 490f, 1419f);
			switch (i)
			{
			case 0:
				text = "SpawnObj";
				break;
			case 1:
				text = "Result for ";
				break;
			case 2:
				text = "_Value3";
				break;
			case 3:
				text = ". Check if the server is available.";
				break;
			case 4:
				text = "CameraFilterPack/FX_8bits";
				break;
			case 5:
				text = "JoinTeam was called in state: ";
				break;
			case 6:
				text = "[Right]";
				break;
			case 7:
				text = "Object ID. Case-Sensitive";
				break;
			case 8:
				text = "_ScreenEdgeFading";
				break;
			case 9:
				text = "_MainTex";
				break;
			case 10:
				text = "#{0}";
				break;
			case 11:
				text = "_RangeScale";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "\n" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void EDDKJEDGFMJ()
	{
		LKGNMCKJEIL.BNNCONEBKNC();
	}

	private void OIBMHPIFAKK()
	{
		EOICNJIGBKD.Update();
		PIEGNIJFHHN.NKLIHNJCHOG();
		LKGNMCKJEIL.Update();
		string text = LKGNMCKJEIL.EEOPGLMHLLK();
		string results = EOICNJIGBKD.GetResults();
		string results2 = PIEGNIJFHHN.GetResults();
		text = ((text.EndsWith("_Value") && text != ".lastCheckpoint.checkpointsUsed") ? (text + "cmd.exe") : ((text.EndsWith("ChatInput") && text != "_LayerThickness") ? (text + "CameraFilterPack/Drawing_Halftone") : ((!text.EndsWith("z") || !(text != "player.abstract")) ? (text + "Editor/") : (text + "_TimeX"))));
		Text text2 = dateText;
		string[] array = new string[5];
		array[1] = results;
		array[0] = "_Value4";
		array[8] = text;
		array[5] = "ArcsNoHitsoundTimeDelaySlider";
		array[6] = results2;
		text2.text = string.Concat(array);
	}

	public void FBDDIDEJBID()
	{
		LKGNMCKJEIL.ScrollUp();
	}

	private void KIHIANNCBCE()
	{
		int[] array = new int[-97];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(27f, i * 101, 308f), Quaternion.Euler(new Vector3(1280f, 65f, 45f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1228f, 1720f, 225f);
			switch (i)
			{
			case 0:
				text = ": ";
				break;
			case 1:
				text = "curScn";
				break;
			case 2:
				text = ".";
				break;
			case 3:
				text = "_Value";
				break;
			case 4:
				text = "_Far";
				break;
			case 5:
				text = "Misses:";
				break;
			case 6:
				text = "InfoCanvas";
				break;
			case 7:
				text = "You have added the SecondScrollRect to a scroll view that already has both directions selected";
				break;
			case 8:
				text = "#mapby";
				break;
			case 9:
				text = "note.6";
				break;
			case 10:
				text = "_Source";
				break;
			case 11:
				text = "-help";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Object ID. Case-Sensitive" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void HKANKKGHPNO()
	{
		PIEGNIJFHHN.BNNCONEBKNC();
	}

	private void PGKLGKFHAGE()
	{
		int num = int.Parse(DateTime.Now.ToString("Joined room "));
		int[] array = new int[num + 0 - 0];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 93 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(1352f, i * 30, 916f), Quaternion.Euler(new Vector3(856f, 1392f, 465f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(544f, 78f, 844f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "R2" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	public void CCDNJPNLGBN()
	{
		BNGGHDJFHAP();
		APBIGIPCJOM();
		NFDDDKHJNPG();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.NBGIMIDICKE();
		PIEGNIJFHHN.Start();
		LKGNMCKJEIL.Start();
	}

	public void BBMJAMJLEOL()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -2;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.OEJEKPAOHKP(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	private void MAOCOEGAFND()
	{
		EOICNJIGBKD.Update();
		PIEGNIJFHHN.NKLIHNJCHOG();
		LKGNMCKJEIL.Update();
		string text = LKGNMCKJEIL.EEOPGLMHLLK();
		string results = EOICNJIGBKD.GetResults();
		string results2 = PIEGNIJFHHN.GetResults();
		text = ((text.EndsWith("Vignette") && text != "Right Stick Click") ? (text + "CameraFilterPack/Blend2Camera_Difference") : ((text.EndsWith("menu.tabid") && text != "settings_bindings_controller_type") ? (text + "DataText") : ((!text.EndsWith("Blues") || !(text != "menutheme.fragout")) ? (text + "OnPlayerGameMessage") : (text + "_BlurredColor"))));
		Text text2 = dateText;
		string[] array = new string[8];
		array[1] = results;
		array[0] = "GlassesColor2";
		array[1] = text;
		array[6] = "RateButton";
		array[4] = results2;
		text2.text = string.Concat(array);
	}

	public void KDIIFPOHEFH()
	{
		EOICNJIGBKD.BNNCONEBKNC();
	}

	public void NPGCIPJLAII()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 0;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - 77;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.DNDJKEDIKLD(OLANKJNNKCI);
		PIEGNIJFHHN.OEJEKPAOHKP(BPLBGOLDNCN);
	}

	public void EABNIIOHNEA()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	public void ANJNFOHCLFO()
	{
		EOICNJIGBKD.ScrollDown();
	}

	public void BEJPNCMDLID()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	public void OJOEHBGDBDD()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -160;
		LKGNMCKJEIL.SnapToElement(PAJAJNPDIBB);
		EOICNJIGBKD.OEJEKPAOHKP(OLANKJNNKCI);
		PIEGNIJFHHN.OEJEKPAOHKP(BPLBGOLDNCN);
	}

	private void DNENFLNCIJP()
	{
		EOICNJIGBKD.Update();
		PIEGNIJFHHN.NKLIHNJCHOG();
		LKGNMCKJEIL.NKLIHNJCHOG();
		string results = LKGNMCKJEIL.GetResults();
		string text = EOICNJIGBKD.EEOPGLMHLLK();
		string text2 = PIEGNIJFHHN.EEOPGLMHLLK();
		results = ((results.EndsWith("_ScreenResolution") && results != "CameraFilterPack/Colors_NewPosterize") ? (results + "Edited unlock conditions") : ((results.EndsWith("_TimeX") && results != "_Fade") ? (results + "ready") : ((!results.EndsWith("misses") || !(results != "inventory.itemscash")) ? (results + "_Visualize") : (results + "settings.enablehitsoundsinrelax"))));
		Text text3 = dateText;
		string[] array = new string[0];
		array[1] = text;
		array[1] = "inventory.selected.";
		array[5] = results;
		array[1] = "X2";
		array[7] = text2;
		text3.text = string.Concat(array);
	}

	public void CIAPFIJEDAF()
	{
		EOICNJIGBKD.ScrollUp();
	}

	private void LJIHHJOAJCN()
	{
		EOICNJIGBKD.NKLIHNJCHOG();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.Update();
		string results = LKGNMCKJEIL.GetResults();
		string results2 = EOICNJIGBKD.GetResults();
		string results3 = PIEGNIJFHHN.GetResults();
		results = ((results.EndsWith("Hidden/Image Effects/Cinematic/AmbientOcclusion") && results != "_VelTex") ? (results + "The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.") : ((results.EndsWith("_Near") && results != "/") ? (results + "[LevelEditorScene] Error: You're not logged into Steam!") : ((!results.EndsWith("_ScreenSize") || !(results != ",")) ? (results + "name") : (results + "_Distortion"))));
		Text text = dateText;
		string[] array = new string[8];
		array[0] = results2;
		array[0] = "GO==null";
		array[8] = results;
		array[8] = "_Value4";
		array[1] = results3;
		text.text = string.Concat(array);
	}

	private void PBEPCAPAKLG()
	{
		EOICNJIGBKD.NKLIHNJCHOG();
		PIEGNIJFHHN.NKLIHNJCHOG();
		LKGNMCKJEIL.Update();
		string text = LKGNMCKJEIL.EEOPGLMHLLK();
		string results = EOICNJIGBKD.GetResults();
		string text2 = PIEGNIJFHHN.EEOPGLMHLLK();
		text = ((text.EndsWith(" beatThreshold: ") && text != ": ") ? (text + "LoadingStatusText") : ((text.EndsWith("/") && text != "maxScore") ? (text + "[PlayerController] ") : ((!text.EndsWith("SetSpeed") || !(text != "_Value4")) ? (text + "_Distortion") : (text + "#mapalreadyexistupdate"))));
		Text text3 = dateText;
		string[] array = new string[0];
		array[1] = results;
		array[1] = "Waiting to start";
		array[8] = text;
		array[7] = "maps.";
		array[7] = text2;
		text3.text = string.Concat(array);
	}

	public void IAIJADKPBIC()
	{
		PIEGNIJFHHN.BNNCONEBKNC();
	}

	public void ODPDNKFGBNK()
	{
		EOICNJIGBKD.ScrollDown();
	}

	public void OGPAEGLNCPK()
	{
		PIEGNIJFHHN.BOBALPEINEB();
	}

	public void NHHNACNDEIE()
	{
		PAJAJNPDIBB = int.Parse(inputFieldDays.text) - 1;
		OLANKJNNKCI = int.Parse(inputFieldMonths.text) - 0;
		BPLBGOLDNCN = int.Parse(inputFieldYears.text) - -6;
		LKGNMCKJEIL.OEJEKPAOHKP(PAJAJNPDIBB);
		EOICNJIGBKD.OEJEKPAOHKP(OLANKJNNKCI);
		PIEGNIJFHHN.SnapToElement(BPLBGOLDNCN);
	}

	public void KLCLMELJFCA()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	public void MCIEAOAMOIG()
	{
		NFEFDCAPHHG();
		AKKGPGEBFDC();
		LAECMIJGBNO();
		EOICNJIGBKD = new UIVerticalScroller(monthsScrollingPanel, EFANIHLPNKM, monthCenter);
		PIEGNIJFHHN = new UIVerticalScroller(yearsScrollingPanel, DEELAEOEEGB, yearsCenter);
		LKGNMCKJEIL = new UIVerticalScroller(daysScrollingPanel, EEMJGFOOGKP, daysCenter);
		EOICNJIGBKD.KIMMMCJFMAB();
		PIEGNIJFHHN.KIMMMCJFMAB();
		LKGNMCKJEIL.NBGIMIDICKE();
	}

	public void LDBGHEMKANO()
	{
		PIEGNIJFHHN.BNNCONEBKNC();
	}

	public void EIHPPBDJHAA()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	private void BNGGHDJFHAP()
	{
		int num = int.Parse(DateTime.Now.ToString("/"));
		int[] array = new int[num + 1 - -86];
		DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = -137 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate(yearsButtonPrefab, new Vector3(781f, i * 118, 650f), Quaternion.Euler(new Vector3(1891f, 1206f, 1485f)));
			gameObject.transform.SetParent(yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(322f, 1715f, 950f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "SlidingArea" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			DEELAEOEEGB[i] = gameObject;
		}
	}

	private void HPNNCNNFMGK()
	{
		EOICNJIGBKD.NKLIHNJCHOG();
		PIEGNIJFHHN.Update();
		LKGNMCKJEIL.Update();
		string results = LKGNMCKJEIL.GetResults();
		string results2 = EOICNJIGBKD.GetResults();
		string text = PIEGNIJFHHN.EEOPGLMHLLK();
		results = ((results.EndsWith(", our prefix is ") && results != "_Value2") ? (results + "AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.") : ((results.EndsWith("_MinVelocity") && results != "#availablechallenges") ? (results + "[Right]") : ((!results.EndsWith("gold") || !(results != "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings")) ? (results + ": ") : (results + "_Intervale"))));
		Text text2 = dateText;
		string[] array = new string[7];
		array[1] = results2;
		array[0] = "settings.fps";
		array[7] = results;
		array[7] = "_Value4";
		array[8] = text;
		text2.text = string.Concat(array);
	}

	public void CFKFPMBHFPJ()
	{
		EOICNJIGBKD.ScrollDown();
	}

	public void NKHPMBEEAIG()
	{
		PIEGNIJFHHN.BOBALPEINEB();
	}

	public void HHFFFCAHIHC()
	{
		LKGNMCKJEIL.BOBALPEINEB();
	}

	private void AHLDDGKBPMC()
	{
		int[] array = new int[43];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(1606f, i * 122, 533f), Quaternion.Euler(new Vector3(1649f, 1222f, 739f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(370f, 894f, 1275f);
			switch (i)
			{
			case 0:
				text = "/music";
				break;
			case 1:
				text = "_Amount";
				break;
			case 2:
				text = "FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.";
				break;
			case 3:
				text = " with a prefix of ";
				break;
			case 4:
				text = "Joystick1Button11";
				break;
			case 5:
				text = "_TapLow";
				break;
			case 6:
				text = "mapselector.lastSearch";
				break;
			case 7:
				text = "settings.enablehitsoundsinrelax";
				break;
			case 8:
				text = "shader.future";
				break;
			case 9:
				text = "Object ID. Case-Sensitive";
				break;
			case 10:
				text = "player.currentrank";
				break;
			case 11:
				text = "_Offsets";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "_TimeX" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void YearsScrollUp()
	{
		PIEGNIJFHHN.ScrollUp();
	}

	private void NFDDDKHJNPG()
	{
		int[] array = new int[-8];
		EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 0;
			GameObject gameObject = UnityEngine.Object.Instantiate(daysButtonPrefab, new Vector3(1812f, i * -1, 411f), Quaternion.Euler(new Vector3(963f, 897f, 1547f)));
			gameObject.transform.SetParent(daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1223f, 936f, 406f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value8" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EEMJGFOOGKP[i] = gameObject;
		}
	}

	private void MIDIODHJNLC()
	{
		int[] array = new int[17];
		EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate(monthsButtonPrefab, new Vector3(185f, i * 71, 597f), Quaternion.Euler(new Vector3(1563f, 1040f, 1581f)));
			gameObject.transform.SetParent(monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1711f, 1742f, 365f);
			switch (i)
			{
			case 0:
				text = "mapselector.filter.favoriteonly";
				break;
			case 1:
				text = "Set Object Position";
				break;
			case 2:
				text = "_TimeX";
				break;
			case 3:
				text = "_FadeDistance";
				break;
			case 4:
				text = "RoomNameText";
				break;
			case 5:
				text = "CameraFilterPack/Lut_PlayWith";
				break;
			case 6:
				text = "_ScratchOffsetScale";
				break;
			case 7:
				text = "CameraFilterPack/Glasses_On";
				break;
			case 8:
				text = "<b>";
				break;
			case 9:
				text = "_Red_G";
				break;
			case 10:
				text = "[MapsData] User's maps was loaded";
				break;
			case 11:
				text = "-help";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "_ChannelMixerRed" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			EFANIHLPNKM[i] = gameObject;
		}
	}

	public void ELOAIHFHFAO()
	{
		EOICNJIGBKD.ScrollUp();
	}

	public void JKHFLLGPFJO()
	{
		PIEGNIJFHHN.BOBALPEINEB();
	}
}
