// PhotonStatsGui
using ExitGames.Client.Photon;
using UnityEngine;

public class PhotonStatsGui : MonoBehaviour
{
	public bool statsWindowOn = true;

	public bool statsOn = true;

	public bool healthStatsVisible;

	public bool trafficStatsOn;

	public bool buttonsOn;

	public Rect statsRect = new Rect(0f, 100f, 200f, 50f);

	public int WindowId = 100;

	public void FFBECHMKMPK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, ELOFOJIJFFA, "R2");
		}
	}

	public void Start()
	{
		if (statsRect.x <= 0f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void BKIGIIINEDH()
	{
		if (statsRect.x <= 80f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void EIMNPCMHJLJ()
	{
		if (statsRect.x <= 965f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DLCHPKAMIJK(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -66;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, ",");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Cannot send messages when not connected. Either connect to Photon OR use offline mode!", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "DISTORT", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_OcclusionTexture", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Object ID. Case-Sensitive", num);
		string text3 = string.Format("Music End", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "SetSatelliteTrailLength");
			if (GUILayout.Button("EventData0DropDownList"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_SizeX");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Value1", new GUILayoutOption[1]);
			text4 = "connect" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "curScn" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(" not exist");
			object[] array = new object[83];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("USE_DIAG_SEARCH", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[1] = text3;
			array2[0] = text4;
			array2[3] = text5;
			array2[5] = text6;
			string message = string.Format("Beat Detected", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1636f;
		}
		GUI.DragWindow();
	}

	public void PBEPCAPAKLG()
	{
		if (Input.GetKeyDown((KeyCode)(-107)) && Input.GetKey((KeyCode)(-65)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void GFACKFCEIBC()
	{
		if (Input.GetKeyDown((KeyCode)(-97)) && Input.GetKey((KeyCode)(-75)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void MKPKOEENFND(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -192;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Value2");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Chat");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Saturation", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Mouse ", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("\nCreated by Oxy949", num);
		string text3 = string.Format("[Right]", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_TimeX");
			if (GUILayout.Button("CameraFilterPack_RainFX_Anm2", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Misses:", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("duration");
			text4 = "SpawnObj" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GameVolumeSlider" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("OnAwakeRPC");
			object[] array = new object[60];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[4] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[3] = text4;
			array2[6] = text5;
			array2[6] = text6;
			string message = string.Format("workshop.", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1149f;
		}
		GUI.DragWindow();
	}

	public void JFHCMEAOPPC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MIAGFIIILHJ, "_TimeX");
		}
	}

	public void NFKGNKJPKIB(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 71;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_LutTex");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_TileMaxLoop");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "UseFinalGlassColor", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_Value5", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("maps.", num);
		string text3 = string.Format("menu.selectedplaymode", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, " not exist", new GUILayoutOption[1]);
			if (GUILayout.Button("a"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("\" on viewID ");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_VelocityScale", new GUILayoutOption[1]);
			text4 = "_GreenAmplifier" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "TBD" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("deletemap", new GUILayoutOption[1]);
			object[] array = new object[-52];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("GameScene", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[0] = text;
			array2[0] = text2;
			array2[3] = text3;
			array2[4] = text4;
			array2[1] = text5;
			array2[1] = text6;
			string message = string.Format("Cross", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1921f;
		}
		GUI.DragWindow();
	}

	public void JBCNIPJDPJB()
	{
		if (Input.GetKeyDown((KeyCode)(-52)) && Input.GetKey((KeyCode)(-108)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void IDDPLCAHDPO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FGHCDCINJFD, ":", new GUILayoutOption[1]);
		}
	}

	public void LIFJIJLOEFK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GPINLMGJMKO, "DPADHOR", new GUILayoutOption[1]);
		}
	}

	public void PPCJACOLHBJ()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, EGECCNAEECP, "_FgCocMask", new GUILayoutOption[1]);
		}
	}

	public void NOIHPECMDLI(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 177;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "offsets");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "https://steamcommunity.com/app/513510/workshop/", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "1234332714");
		GUILayout.EndHorizontal();
		string text = string.Format("menu.selectedplaymode", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Image", num);
		string text3 = string.Format("MenuScene", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_TimeX");
			if (GUILayout.Button("id"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("EventSystem");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("wss://");
			text4 = "< true | false >" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "float,2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("[PlayerBase] SpawnObj error: ");
			object[] array = new object[125];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Value7", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[2] = text4;
			array2[2] = text5;
			array2[4] = text6;
			string message = string.Format("_TimeX", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 318f;
		}
		GUI.DragWindow();
	}

	public void OKLAJINHPAN()
	{
		if (statsRect.x <= 1352f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DBEMDAJDDDA()
	{
		if (statsRect.x <= 453f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JDKHBGDEONK()
	{
		if (statsRect.x <= 660f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void KOCIIOKHKME()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, CMHIDPNNHAA, "_Value2");
		}
	}

	public void ODCJJFBJJNF()
	{
		if (Input.GetKeyDown((KeyCode)(-101)) && Input.GetKey(KeyCode.N))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void IIFCIDDJHPM()
	{
		if (Input.GetKeyDown((KeyCode)(-114)) && Input.GetKey((KeyCode)(-153)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void KKJNHIGPHJC(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -28;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_SubsampleIndices");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "y", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "https://reddit.com/r/Intralism");
		GUILayout.EndHorizontal();
		string text = string.Format("_Gain", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(". Possible scene loading in progress?", num);
		string text3 = string.Format(". Verify the Prefab is in a Resources folder (and not in a subfolder)", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "masterSteamID");
			if (GUILayout.Button("Delete events", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Image", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("x");
			text4 = "GameScene" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "ExitButton" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(" not found", new GUILayoutOption[1]);
			object[] array = new object[-80];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("SpawnObj", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[0] = text4;
			array2[2] = text5;
			array2[1] = text6;
			string message = string.Format("Anime", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 80f;
		}
		GUI.DragWindow();
	}

	public void FOLDLDLFFLM()
	{
		if (Input.GetKeyDown(KeyCode.A) && Input.GetKey((KeyCode)(-103)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void MNBPNHNAEBK()
	{
		if (statsRect.x <= 1520f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void FGHCDCINJFD(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -158;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "steamid");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "1234332714", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "[PlayerController] ", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format(",0", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Set particles size", num);
		string text3 = string.Format("_MaxRayTraceDistance", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_MainTex2");
			if (GUILayout.Button("Fade"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("notready");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("ENABLE_DITHERING");
			text4 = "settings_bindings_sec_" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "CameraFilterPack/Blur_Dithering2x2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Value2", new GUILayoutOption[1]);
			object[] array = new object[-21];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("AppID: {0}*** GameVersion: {1} PeerId: {2} ", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[3] = text4;
			array2[1] = text5;
			array2[7] = text6;
			string message = string.Format("_Contrast", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 103f;
		}
		GUI.DragWindow();
	}

	public void BEBNOKFLJPH()
	{
		if (statsRect.x <= 1300f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HHKCCIJMGAB()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GMOFOHLNBDK, "Creating new item...", new GUILayoutOption[1]);
		}
	}

	public void IEMEHGCFAPD()
	{
		if (Input.GetKeyDown((KeyCode)16) && Input.GetKey((KeyCode)(-123)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void JGMEKCFHGLE()
	{
		if (Input.GetKeyDown(KeyCode.Question) && Input.GetKey((KeyCode)(-184)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void TrafficStatsWindow(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 1000;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "buttons");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "health");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "traffic");
		GUILayout.EndHorizontal();
		string text = string.Format("Out {0,4} | In {1,4} | Sum {2,4}", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = $"{num}sec average:";
		string text3 = string.Format("Out {0,4} | In {1,4} | Sum {2,4}", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "stats on");
			if (GUILayout.Button("Reset"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("To Log");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Traffic Stats");
			text4 = "Incoming: \n" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Outgoing: \n" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Health Stats");
			text6 = string.Format("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", trafficStatsGameLevel.LongestDeltaBetweenSending, trafficStatsGameLevel.LongestDeltaBetweenDispatching, trafficStatsGameLevel.LongestEventCallback, trafficStatsGameLevel.LongestEventCallbackCode, trafficStatsGameLevel.LongestOpResponseCallback, trafficStatsGameLevel.LongestOpResponseCallbackOpCode, PhotonNetwork.JNJJAMNLOHA.RoundTripTime, PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance, PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			string message = $"{text}\n{text2}\n{text3}\n{text4}\n{text5}\n{text6}";
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 100f;
		}
		GUI.DragWindow();
	}

	public void IJFOOJMMMDA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 170;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "accuracy", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "mapselector.filter.subscribedonly", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Green_C");
		GUILayout.EndHorizontal();
		string text = string.Format("#ok", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("OnStatusChanged: {0} current State: {1}", num);
		string text3 = string.Format("_BlurCoe", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_SpherePositionY", new GUILayoutOption[1]);
			if (GUILayout.Button("/", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("maps.", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("init");
			text4 = "JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_MainTex2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Blue_R");
			object[] array = new object[-61];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("BitsData", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[5] = text4;
			array2[1] = text5;
			array2[0] = text6;
			string message = string.Format("_TimeX", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 231f;
		}
		GUI.DragWindow();
	}

	public void EHJJFJCKGAJ()
	{
		if (Input.GetKeyDown((KeyCode)70) && Input.GetKey((KeyCode)20))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void AHFNKCIBLIN(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 12;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, " not exist", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, " SecondsBeforeRespawn: ");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Tab2Content");
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("GenerationMenu", num);
		string text3 = string.Format("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "offsets");
			if (GUILayout.Button(" : "))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Red_R", new GUILayoutOption[1]);
			text4 = "CameraFilterPack/Color_Switching" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "<color=white>" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("/icon");
			object[] array = new object[98];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("mapselector.filter.subscribedonly", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[0] = text;
			array2[0] = text2;
			array2[5] = text3;
			array2[6] = text4;
			array2[7] = text5;
			array2[2] = text6;
			string message = string.Format("_ScreenResolution", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 839f;
		}
		GUI.DragWindow();
	}

	public void KIEJKBNBHMD()
	{
		if (Input.GetKeyDown((KeyCode)75) && Input.GetKey((KeyCode)(-168)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void HMNLHMLILKD()
	{
		if (Input.GetKeyDown(KeyCode.Alpha9) && Input.GetKey((KeyCode)2))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void IGPCNCJIEOJ()
	{
		if (statsRect.x <= 562f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void EAHKLHCEDLB()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, AHFNKCIBLIN, "_CurveParams", new GUILayoutOption[1]);
		}
	}

	public void FLLEIMBAAAH(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 42;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "Connection error: ", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Joystick1Button4", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "PLAY [SPACE]");
		GUILayout.EndHorizontal();
		string text = string.Format("Left", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("SlidingArea", num);
		string text3 = string.Format("[ItemsHandler] Inventory has changed", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_DotSize", new GUILayoutOption[1]);
			if (GUILayout.Button("Set satellite MinVertexDistance - how much distance should be between to points of the trail line"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("EventSystem", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Inside cells:\n");
			text4 = "settings.shaders.bloomintencity" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "CameraFilterPack/Color_YUV" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("offsets", new GUILayoutOption[1]);
			object[] array = new object[-56];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_DotSize", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[1];
			array2[0] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[7] = text4;
			array2[4] = text5;
			array2[8] = text6;
			string message = string.Format("Exception while connecting to: ", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 898f;
		}
		GUI.DragWindow();
	}

	public void AEDDNDHCLNN()
	{
		if (statsRect.x <= 521f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HLIAEEMGBHN()
	{
		if (statsRect.x <= 449f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void CNAFKDEAAGD(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -64;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "caret", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "To {0} at Index {1} \n", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "EXCEPTION:");
		GUILayout.EndHorizontal();
		string text = string.Format("Object ID. Case-Sensitive", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("]", num);
		string text3 = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "RateButton");
			if (GUILayout.Button("HightScoreMaxPointsText"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("]. Please verify you have this gameobject in a Resources folder.");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("MenuScene", new GUILayoutOption[1]);
			text4 = "menu.selectedplaymode" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_NoiseTex" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_BlurCoe");
			object[] array = new object[-85];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("#ok", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[4] = text3;
			array2[6] = text4;
			array2[3] = text5;
			array2[6] = text6;
			string message = string.Format("0", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 489f;
		}
		GUI.DragWindow();
	}

	public void JODODFGLOLD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, NNFMGBNMFFH, "mapselector.filter.subscribedonly");
		}
	}

	public void JDGFCEPDKAJ()
	{
		if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.M))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void AEMGPJDJGBJ()
	{
		if (statsRect.x <= 1261f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void LMADKINICIN()
	{
		if (Input.GetKeyDown(KeyCode.DoubleQuote) && Input.GetKey(KeyCode.Colon))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void JABMMIMOJMJ()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OKEPACMIAGF, "Edited hands count");
		}
	}

	public void AFOKJPBHIEG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "finished");
		}
	}

	public void GPINLMGJMKO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 156;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "CloseConnection: No such player connected!");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "s", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_ScreenResolution", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("}", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("isBunned", num);
		string text3 = string.Format("x", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "yyyy-MM-dd HH:mm:ss", new GUILayoutOption[1]);
			if (GUILayout.Button(" joined"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("http");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("SupportLogger OnFailedToConnectToPhoton(");
			text4 = "(\\[ */ *h1 *\\])" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "RateButton" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("OpSettings()", new GUILayoutOption[1]);
			object[] array = new object[-88];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("CameraFilterPack/Distortion_Half_Sphere", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[5] = text4;
			array2[4] = text5;
			array2[5] = text6;
			string message = string.Format("Myst", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1892f;
		}
		GUI.DragWindow();
	}

	public void KNBJBNDGCIJ()
	{
		if (statsRect.x <= 1643f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JOINFIDKFCG(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 199;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "RecordButton");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Remove Environment Object", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Tab2Content", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Added checkpoint", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(" does not exist!", num);
		string text3 = string.Format("CameraFilterPack/Glasses_On", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_Value2");
			if (GUILayout.Button("_TimeX"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("[PlayerController] ", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_VelocityTex");
			text4 = "_Value6" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "settings.shaders.bloomintencity" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("ScoreText", new GUILayoutOption[1]);
			object[] array = new object[-18];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_FixDistance", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[0] = text2;
			array2[8] = text3;
			array2[0] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format("_GlowColor", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 174f;
		}
		GUI.DragWindow();
	}

	public void OLGIPJAFKOJ(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -139;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_TimeX");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "No font defined. Found font: ", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("ENABLE_COLOR_GRADING", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("ControllerRightX", num);
		string text3 = string.Format("finished", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "ItemsCountText", new GUILayoutOption[1]);
			if (GUILayout.Button("[ResourcesManager] Load image error: ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("#");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("[MenuScene] Error: ");
			text4 = "PunPickup" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_SunPosition" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("maps.", new GUILayoutOption[1]);
			object[] array = new object[-58];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("Connection error: ", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[0] = text;
			array2[1] = text2;
			array2[4] = text3;
			array2[4] = text4;
			array2[8] = text5;
			array2[1] = text6;
			string message = string.Format("_ScreenResolution", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 846f;
		}
		GUI.DragWindow();
	}

	public void MLFACDCDMAL()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MKPKOEENFND, "Save level before uploading?", new GUILayoutOption[1]);
		}
	}

	public void DOFDGBGEDFI()
	{
		if (statsRect.x <= 1510f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void LIBGAKMKHJJ()
	{
		if (statsRect.x <= 1340f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HILFMJPALJH(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -38;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_TimeX");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "settings.crosshairopacity", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Bad parameters for setint! Use <key> <value>", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Scale environment object by the values", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("SelectorMapsCountSlider", num);
		string text3 = string.Format("\n", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_AdaptationSpeed");
			if (GUILayout.Button("#no", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Error: I/O Failure! :(", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Prints the number of logs currently held by DebugLogs", new GUILayoutOption[1]);
			text4 = "workshop." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "[NetworkManager] Joined room with " + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("GridDataArcs", new GUILayoutOption[1]);
			object[] array = new object[54];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("Checkpoint", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[7] = text3;
			array2[5] = text4;
			array2[7] = text5;
			array2[2] = text6;
			string message = string.Format("Using Stopwatch as precision timer for PUN.", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 705f;
		}
		GUI.DragWindow();
	}

	public void IFDFLGHEONF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OKEPACMIAGF, "_FgOverlap");
		}
	}

	public void FMNPFCHBLJF()
	{
		if (statsRect.x <= 426f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void GIPHJOKGPMO(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -27;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "\\\\");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Jit ", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_MainTex");
		GUILayout.EndHorizontal();
		string text = string.Format("settings_bindings_controller_type", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("event", num);
		string text3 = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, " GameServer:", new GUILayoutOption[1]);
			if (GUILayout.Button("The shader ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("float,0", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Operation ");
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "LevelProgressBar" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("MenuScene");
			object[] array = new object[-91];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("float,1.5", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[0] = text2;
			array2[1] = text3;
			array2[0] = text4;
			array2[6] = text5;
			array2[1] = text6;
			string message = string.Format("TwoHands", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 483f;
		}
		GUI.DragWindow();
	}

	public void JOPCCCCHNLI()
	{
		if (statsRect.x <= 683f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void ALJEJJCIMJN()
	{
		if (statsRect.x <= 698f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DENGAACEDJC(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 114;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "\" on viewID ");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "EndlessLoopsScoreText");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, ".completedMaps");
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_ToneCurve", num);
		string text3 = string.Format("CameraFilterPack/Colors_Adjust_PreFilters", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "CameraFilterPack/TV_Noise", new GUILayoutOption[1]);
			if (GUILayout.Button("MenuScene", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_CenterX", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Speed");
			text4 = "_ThirdTex" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "1332644700" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(" ; ");
			object[] array = new object[-95];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Distortion", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[3] = text3;
			array2[4] = text4;
			array2[3] = text5;
			array2[0] = text6;
			string message = string.Format("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1104f;
		}
		GUI.DragWindow();
	}

	public void KMKLDAJLCNM()
	{
		if (Input.GetKeyDown((KeyCode)(-69)) && Input.GetKey((KeyCode)(-144)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void OLFFIKHJIEO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GPINLMGJMKO, "PS Home", new GUILayoutOption[1]);
		}
	}

	public void EPEGAEGDJAM()
	{
		if (statsRect.x <= 342f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void AEIJFLJEABG()
	{
		if (Input.GetKeyDown((KeyCode)(-7)) && Input.GetKey((KeyCode)131))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void ELOFOJIJFFA(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -189;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, ": ");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, ".lastCheckpoint.correctScore", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "time", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("</color>", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Threshhold", num);
		string text3 = string.Format("x", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", new GUILayoutOption[1]);
			if (GUILayout.Button("maps."))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_ReflectionTexture3", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("[LobbyPlayerElement] On ready click");
			text4 = "_Offsets" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("[DiscordController] Init");
			object[] array = new object[-96];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("BitsData", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[0] = text2;
			array2[6] = text3;
			array2[3] = text4;
			array2[1] = text5;
			array2[7] = text6;
			string message = string.Format(".png", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1298f;
		}
		GUI.DragWindow();
	}

	public void CPJBNBJMJFA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, HILFMJPALJH, "_ScreenResolution");
		}
	}

	public void EHHEKBPCDOH()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "NEW", new GUILayoutOption[1]);
		}
	}

	public void IKIDIJLIGOH()
	{
		if (Input.GetKeyDown(KeyCode.T) && Input.GetKey((KeyCode)136))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void MMPHNFPPEHO()
	{
		if (statsRect.x <= 477f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DFFKKLAPHCC()
	{
		if (statsRect.x <= 1182f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void OKEPOJNDCHO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MIAGFIIILHJ, "[Down]", new GUILayoutOption[1]);
		}
	}

	public void EEPEAEEEPMK(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 80;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "menu.playedsolo");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_Radius");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_TimeX", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("menuthemes", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("%", num);
		string text3 = string.Format("_Value3", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "settings.showHP", new GUILayoutOption[1]);
			if (GUILayout.Button("LevelProgressBar", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Editor/");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("CameraFilterPack/FX_Psycho");
			text4 = "/?player=" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "SetSatelliteLerpSpeed" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("\\", new GUILayoutOption[1]);
			object[] array = new object[11];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("?", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[3];
			array2[1] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[0] = text4;
			array2[6] = text5;
			array2[6] = text6;
			string message = string.Format("G:", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1349f;
		}
		GUI.DragWindow();
	}

	public void BGDONBMDPGM()
	{
		if (Input.GetKeyDown(KeyCode.K) && Input.GetKey((KeyCode)(-166)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void MDBEPCKAJFP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "Message duration multiplier. Recomended 1");
		}
	}

	public void CDLHBDMJAJI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DENGAACEDJC, "bad");
		}
	}

	public void EJJMMCLNCKA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GMOFOHLNBDK, ".", new GUILayoutOption[1]);
		}
	}

	public void APKNAPHOFHC()
	{
		if (Input.GetKeyDown(KeyCode.Delete) && Input.GetKey(KeyCode.Alpha3))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void NGHMCPOJIOO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -174;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "CameraFilterPack/Glasses_OnX");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "settings.crosshairopacity");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "player.orangelifering");
		GUILayout.EndHorizontal();
		string text = string.Format("_Blue_B", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_ScreenResolution", num);
		string text3 = string.Format("_MainTex2", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_ScreenResolution", new GUILayoutOption[1]);
			if (GUILayout.Button("<b><i>Map's Stats:</i></b>"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("#", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("|", new GUILayoutOption[1]);
			text4 = "Fade" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Convolved_TexelSize", new GUILayoutOption[1]);
			object[] array = new object[-42];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("RarityImage", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[1] = text2;
			array2[6] = text3;
			array2[2] = text4;
			array2[8] = text5;
			array2[7] = text6;
			string message = string.Format("{\"items\":", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 365f;
		}
		GUI.DragWindow();
	}

	public void ECBILENEOOL()
	{
		if (statsRect.x <= 1090f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void MAOCOEGAFND()
	{
		if (Input.GetKeyDown((KeyCode)23) && Input.GetKey((KeyCode)84))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void LGMADMDBKNE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GMOFOHLNBDK, "_TimeX");
		}
	}

	public void LEKGHGJPIJE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MKPKOEENFND, "_VelTex");
		}
	}

	public void JECMJNFGBGC()
	{
		if (statsRect.x <= 562f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void INODCHEOKGF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DIFKPMBNIIA, "[ItemsHandler] Found ");
		}
	}

	public void NDAJBJFJGCF()
	{
		if (Input.GetKeyDown((KeyCode)(-116)) && Input.GetKey((KeyCode)(-58)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void FOMNCPKKCFN()
	{
		if (Input.GetKeyDown((KeyCode)(-88)) && Input.GetKey((KeyCode)75))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void KNKOCAKPJKF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, CMHIDPNNHAA, "#random #epic #item", new GUILayoutOption[1]);
		}
	}

	public void OnGUI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, TrafficStatsWindow, "Messages (shift+tab)");
		}
	}

	public void PLDAMMNBJFE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MKPKOEENFND, "Prints list of all previous commands", new GUILayoutOption[1]);
		}
	}

	public void CEDFFAOOPOG()
	{
		if (statsRect.x <= 1714f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void PKLOBJHKFEO()
	{
		if (statsRect.x <= 469f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void NDBPCNICGLC()
	{
		if (statsRect.x <= 1188f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HCABOHEKHKF(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -122;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Colorisation");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_TimeX", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Value");
		GUILayout.EndHorizontal();
		string text = string.Format("Alternative", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("CompletedLevel", num);
		string text3 = string.Format("settings.enablerankingnotifications", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_Value5", new GUILayoutOption[1]);
			if (GUILayout.Button("_Parameter"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_FlipAlphaMask", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_ProjInfo", new GUILayoutOption[1]);
			text4 = "_Value2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GameScene" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Near");
			object[] array = new object[91];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("settings.arcsnohitsoundtimedelay", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[1] = text2;
			array2[8] = text3;
			array2[1] = text4;
			array2[6] = text5;
			array2[2] = text6;
			string message = string.Format("_TimeX", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 732f;
		}
		GUI.DragWindow();
	}

	public void ANKIJGCGCBF()
	{
		if (Input.GetKeyDown((KeyCode)(-61)) && Input.GetKey((KeyCode)(-190)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void GMOFOHLNBDK(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 187;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_History4ChromaTex", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_EmissionColor");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("In Network lobby", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("settings.shaders.bloomintencity", num);
		string text3 = string.Format("_NoiseTex", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "CameraFilterPack/Glasses_On", new GUILayoutOption[1]);
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("music");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Needs to be attached to the Event System component in the scene");
			text4 = "map.data" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_LoopCount" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("cipherText", new GUILayoutOption[1]);
			object[] array = new object[-114];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("ENABLE_USER_LUT", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[0] = text2;
			array2[8] = text3;
			array2[5] = text4;
			array2[3] = text5;
			array2[5] = text6;
			string message = string.Format("_Fade", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1499f;
		}
		GUI.DragWindow();
	}

	public void FIKFJDFELIP()
	{
		if (statsRect.x <= 1010f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void OKEPACMIAGF(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 146;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "y");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, ".icon");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "[RanksSystem] Init");
		GUILayout.EndHorizontal();
		string text = string.Format("Ignored PU RPC, cause item is inactive. ", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("CameraFilterPack/Vision_Tunnel", num);
		string text3 = string.Format("_Speed", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "menu.playedpage");
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Object ID. Case-Sensitive", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("kick");
			text4 = "Classical" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Source" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(" has no method \"", new GUILayoutOption[1]);
			object[] array = new object[-32];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[5] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("Joystick", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[3] = text4;
			array2[0] = text5;
			array2[2] = text6;
			string message = string.Format("...", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 549f;
		}
		GUI.DragWindow();
	}

	public void HIPBNBKNICE()
	{
		if (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey((KeyCode)(-188)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void FCEAHFFGLIE(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -179;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "R1");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Hex value #RRGGBB");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "GhostFade2");
		GUILayout.EndHorizontal();
		string text = string.Format("grid", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_TimeX", num);
		string text3 = string.Format("#C8C8C8FF", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_TimeX", new GUILayoutOption[1]);
			if (GUILayout.Button("L2", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("CameraFilterPack/Vision_Rainbow", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("maps.", new GUILayoutOption[1]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Dec" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Working.\nPlease wait..");
			object[] array = new object[-111];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("JITTER", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[7] = text3;
			array2[8] = text4;
			array2[8] = text5;
			array2[7] = text6;
			string message = string.Format("_ScreenResolution", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 697f;
		}
		GUI.DragWindow();
	}

	public void ELMOEFJHMAN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FLLEIMBAAAH, "_PColor", new GUILayoutOption[1]);
		}
	}

	public void COHFJLIPGMI(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 183;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "EventData0DropDownList", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "x", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Failed to Instantiate prefab: ");
		GUILayout.EndHorizontal();
		string text = string.Format("set environment id", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("UseScanLine", num);
		string text3 = string.Format("Left Stick Click", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "settings_bindings_sec_", new GUILayoutOption[1]);
			if (GUILayout.Button("_Glitch"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_MainTex2", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("note.7");
			text4 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GhostFade" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Exponent", new GUILayoutOption[1]);
			object[] array = new object[-86];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("closed", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[0] = text;
			array2[0] = text2;
			array2[5] = text3;
			array2[0] = text4;
			array2[8] = text5;
			array2[1] = text6;
			string message = string.Format("[LevelEditorScene] Print Audio Wave: Done", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1456f;
		}
		GUI.DragWindow();
	}

	public void LGHNKDFEOKO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GMOFOHLNBDK, "settings.disablestoryboard");
		}
	}

	public void IPDCBNCBBEN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, CNAFKDEAAGD, "BloomShaderValueSlider");
		}
	}

	public void FEDMNHEFFBM(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 137;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "/files/editor_manual.pdf", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "CameraFilterPack/Glasses_On", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_CameraClipInfo", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("#.##", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("\t", num);
		string text3 = string.Format("_SizeX", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_InvRenderTargetSize");
			if (GUILayout.Button("_Near"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(" (");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("error", new GUILayoutOption[1]);
			text4 = "&" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "challengeid" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_ScreenResolution");
			object[] array = new object[-105];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Rand", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[5] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format("CameraFilterPack/TV_Vintage", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 539f;
		}
		GUI.DragWindow();
	}

	public void NNFMGBNMFFH(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -104;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "Anomaly_Distortion");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "SpectatingUserInfo", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Exit to menu?");
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("DPADVER", num);
		string text3 = string.Format("Start Color's hex value #RRGGBBAA", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "SetSpeed");
			if (GUILayout.Button("CameraFilterPack/TV_VHS_Rewind", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Fade", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("-1", new GUILayoutOption[1]);
			text4 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("#");
			object[] array = new object[19];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("KickThePlayer", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[0] = text3;
			array2[7] = text4;
			array2[3] = text5;
			array2[8] = text6;
			string message = string.Format("FinishMap", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 309f;
		}
		GUI.DragWindow();
	}

	public void JFDIAAOJJEA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MIAGFIIILHJ, "_TimeX");
		}
	}

	public void MIAGFIIILHJ(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -77;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "value", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "y", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_MaxVelocity");
		GUILayout.EndHorizontal();
		string text = string.Format("OpChangeGroups()", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(":", num);
		string text3 = string.Format("[PlayerController] ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, " = ");
			if (GUILayout.Button("_TimeX"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_TimeX");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_TimeX");
			text4 = "CameraFilterPack/Blend2Camera_LighterColor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_SizeX", new GUILayoutOption[1]);
			object[] array = new object[1];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("CameraFilterPack/Gradients_FireGradient", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[1] = text;
			array2[1] = text2;
			array2[8] = text3;
			array2[1] = text4;
			array2[4] = text5;
			array2[8] = text6;
			string message = string.Format("maps.", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1604f;
		}
		GUI.DragWindow();
	}

	public void NFEDLAOPHML()
	{
		if (Input.GetKeyDown((KeyCode)30) && Input.GetKey((KeyCode)(-75)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void DIFKPMBNIIA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -103;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, ",", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "/files/mods_terms.pdf");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, ". Client is not the MasterClient in this room.");
		GUILayout.EndHorizontal();
		string text = string.Format("_Size", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Value", num);
		string text3 = string.Format("CameraFilterPack/Vision_Rainbow", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_TimeX", new GUILayoutOption[1]);
			if (GUILayout.Button("_Distortion", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("SetPosition");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("FinalScoreText", new GUILayoutOption[1]);
			text4 = "[SoundManager] Loaded skin audio" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = ". Going to authenticate anyways." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_TimeX", new GUILayoutOption[1]);
			object[] array = new object[-58];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("CameraFilterPack/Blend2Camera_Lighten", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[5];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[2] = text4;
			array2[7] = text5;
			array2[6] = text6;
			string message = string.Format("Tab1Content", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1134f;
		}
		GUI.DragWindow();
	}

	public void OEENOOGEEHD()
	{
		if (Input.GetKeyDown((KeyCode)89) && Input.GetKey((KeyCode)(-88)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void DKOPKPBLDHH()
	{
		if (statsRect.x <= 374f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void IBHACCEEFFI()
	{
		if (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey((KeyCode)(-173)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void FBGCMIJBLJF(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -198;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "X", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "CameraFilterPack/Blend2Camera_ColorKey");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Joystick1Button0");
		GUILayout.EndHorizontal();
		string text = string.Format("Set Trail Zoom Speed", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("[RanksSystem] Init", num);
		string text3 = string.Format("CameraFilterPack/AAA_BloodOnScreen", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "CameraFilterPack/Blend2Camera_LinearLight");
			if (GUILayout.Button("CameraFilterPack/Drawing_EnhancedComics"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_Value3");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("Set Trail Zoom Speed", new GUILayoutOption[1]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "menu.selectedlevelid" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new GUILayoutOption[1]);
			object[] array = new object[-40];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_MaxRayTraceDistance", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[1] = text;
			array2[1] = text2;
			array2[3] = text3;
			array2[8] = text4;
			array2[3] = text5;
			array2[8] = text6;
			string message = string.Format("Bad parameters for getbool! Use <key> <value>", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 201f;
		}
		GUI.DragWindow();
	}

	public void EGECCNAEECP(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -127;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "z", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, " ; ");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Value2", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Anomaly_Distortion", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("STICKRHOR", num);
		string text3 = string.Format("GlassAberration", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "\"", new GUILayoutOption[1]);
			if (GUILayout.Button("_Value2"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("CameraFilterPack/Distortion_ShockWave", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("[MapEditor] Reset");
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Turn" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_TimeX");
			object[] array = new object[-32];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Value2", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[0] = text2;
			array2[4] = text3;
			array2[3] = text4;
			array2[6] = text5;
			array2[0] = text6;
			string message = string.Format("_Value3", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1724f;
		}
		GUI.DragWindow();
	}

	public void EAHGDNIEPKP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FEDMNHEFFBM, "checkpoint", new GUILayoutOption[1]);
		}
	}

	public void DHFEODCFJDP(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -16;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Value3");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "menu.selectedlevelid");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "BitsData");
		GUILayout.EndHorizontal();
		string text = string.Format("#ok", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_TimeX", num);
		string text3 = string.Format("OK", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "GlassDistortion");
			if (GUILayout.Button("Joystick1Button7", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("QuickSave", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_ScreenResolution");
			text4 = "duration" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_PositionY" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("challenges/", new GUILayoutOption[1]);
			object[] array = new object[61];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_SpotSize", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[1] = text2;
			array2[1] = text3;
			array2[2] = text4;
			array2[0] = text5;
			array2[0] = text6;
			string message = string.Format("_TintColor", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1263f;
		}
		GUI.DragWindow();
	}

	public void CMEJNBPFGHP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, KKJNHIGPHJC, "CameraFilterPack/3D_Inverse", new GUILayoutOption[1]);
		}
	}

	public void FFJMMBGFDMD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, IJFOOJMMMDA, "menu.tabid", new GUILayoutOption[1]);
		}
	}

	public void KDJEJBBDILE()
	{
		if (Input.GetKeyDown((KeyCode)(-105)) && Input.GetKey(KeyCode.K))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void CNGAJDBOCLJ()
	{
		if (statsRect.x <= 459f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void BOGBNJJMFOK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OKEPACMIAGF, "#");
		}
	}

	public void JKBMKPDGCHG()
	{
		if (statsRect.x <= 1550f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void CMHIDPNNHAA(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -111;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "LevelNameInputField", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_Colored");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "Case-Sensitive");
		GUILayout.EndHorizontal();
		string text = string.Format("settings.enableranking", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("OK", num);
		string text3 = string.Format("ResourceFileSelector", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "No connection to item server!", new GUILayoutOption[1]);
			if (GUILayout.Button("speed"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(". Calling ConnectToRegionMaster() is: ", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("lobby '{0}'[{1}]", new GUILayoutOption[1]);
			text4 = "Checkpoint" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = " not exist" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("settings_bindings_sec_", new GUILayoutOption[1]);
			object[] array = new object[-63];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("player.greenarc", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[1] = text4;
			array2[7] = text5;
			array2[3] = text6;
			string message = string.Format("owner: ", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1600f;
		}
		GUI.DragWindow();
	}

	public void AHNBAOIENOO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OLGIPJAFKOJ, "_Greenness", new GUILayoutOption[1]);
		}
	}

	public void BMIOFJFMCBG()
	{
		if (statsRect.x <= 1921f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void INLDEHPAMJC()
	{
		if (Input.GetKeyDown((KeyCode)18) && Input.GetKey((KeyCode)188))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void KOFAMEKHHGD()
	{
		if (statsRect.x <= 369f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DPIPGGDNGHN()
	{
		if (Input.GetKeyDown((KeyCode)11) && Input.GetKey((KeyCode)(-34)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void MOMHHBKAGKG()
	{
		if (Input.GetKeyDown(KeyCode.LeftBracket) && Input.GetKey((KeyCode)(-17)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void PDKFMFCMPGE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, AHFNKCIBLIN, "set", new GUILayoutOption[1]);
		}
	}

	public void NHOOMFHGIGG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, MKPKOEENFND, "_Value");
		}
	}

	public void PJCIENAGBGH()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GIPHJOKGPMO, "_MainTex2");
		}
	}

	public void ODMPMJPALID()
	{
		if (statsRect.x <= 421f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void AKGHJPACNLP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OKEPACMIAGF, "ItemNameBGImage");
		}
	}

	public void IMAPGBMIKJF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GMOFOHLNBDK, "/");
		}
	}

	public void DAHFFNNIGML()
	{
		if (statsRect.x <= 1026f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void GPNAOAKCMHC()
	{
		if (statsRect.x <= 1125f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void GKMAMPLCHPA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, GIPHJOKGPMO, "[NetworkManager] Exited", new GUILayoutOption[1]);
		}
	}

	public void CGCEDEENFPF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, EEPEAEEEPMK, "_Value11", new GUILayoutOption[1]);
		}
	}

	public void JDJNNDBHBNP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FCEAHFFGLIE, "_ScreenResolution");
		}
	}

	public void HHCCMHCELPO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OLGIPJAFKOJ, "CameraFilterPack/Blend2Camera_GreenScreen", new GUILayoutOption[1]);
		}
	}

	public void POJFHDFJOPE()
	{
		if (Input.GetKeyDown(KeyCode.Minus) && Input.GetKey(KeyCode.U))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}
}
