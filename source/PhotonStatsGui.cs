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

	public void MKIMDFLBFOM()
	{
		if (statsRect.x <= 705f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void IDJKNBDKHBD()
	{
		if (statsRect.x <= 932f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void FBDOGLBMDNG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, LMKOKNJIAGD, "_ScreenResolution");
		}
	}

	public void BGFJOEPFOPM()
	{
		if (Input.GetKeyDown((KeyCode)(-85)) && Input.GetKey((KeyCode)(-47)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void HLLPIPGLCMM(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -30;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, " item(s) in inventory");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_Bloom1");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_ScreenResolution");
		GUILayout.EndHorizontal();
		string text = string.Format("Save", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("MultiplayerButton", num);
		string text3 = string.Format("_Red_R", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "PLEASE WAIT", new GUILayoutOption[1]);
			if (GUILayout.Button("score"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("EventData0DropDownList");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_SampleScale", new GUILayoutOption[1]);
			text4 = "_SmoothEnd" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Health Stats" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_BaseTex", new GUILayoutOption[1]);
			object[] array = new object[80];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("Hex value #RRGGBB", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[1] = text;
			array2[0] = text2;
			array2[8] = text3;
			array2[2] = text4;
			array2[0] = text5;
			array2[5] = text6;
			string message = string.Format("Bad parameters for init! Use \"init\" or \"init <savename>\"", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1687f;
		}
		GUI.DragWindow();
	}

	public void AKHCOBHHGJP()
	{
		if (statsRect.x <= 1937f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void MJNPIDGNJMK()
	{
		if (Input.GetKeyDown((KeyCode)(-19)) && Input.GetKey((KeyCode)144))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void PBEPCAPAKLG()
	{
		if (Input.GetKeyDown((KeyCode)(-59)) && Input.GetKey((KeyCode)3))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
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
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "SlidingArea", new GUILayoutOption[1]);
		}
	}

	public void DENGAACEDJC(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 84;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "BitsData", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Tab1Content");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_TexelOffsetScale");
		GUILayout.EndHorizontal();
		string text = string.Format("TotalTimeLabel", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Bad parameters for reset! Use \"reset <challengeid>\"", num);
		string text3 = string.Format("\r", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_ScreenResolution");
			if (GUILayout.Button("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("inventory.selected.");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("CorrectHitsScoreText");
			text4 = "_Distortion" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "ClearEnvironment" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("BitsData");
			object[] array = new object[29];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Alpha2", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[8];
			array2[1] = text;
			array2[0] = text2;
			array2[6] = text3;
			array2[0] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format(" workshop map(s)", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1019f;
		}
		GUI.DragWindow();
	}

	public void EIJJHHFOFKJ(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 119;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, ". Sent by actorNr: ", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "logc", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "\n\n#", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("menu.enableselectormusic", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_EdgeThresholdMin", num);
		string text3 = string.Format("Cause: ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_V");
			if (GUILayout.Button(" b."))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Fade");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Radius", new GUILayoutOption[1]);
			text4 = "[PlayerBase] New highscore" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "#availablechallenges" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results");
			object[] array = new object[-94];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_ColorRGB", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[3];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[3] = text4;
			array2[8] = text5;
			array2[8] = text6;
			string message = string.Format("Connection error: ", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 653f;
		}
		GUI.DragWindow();
	}

	public void FBPHNEJBDJN()
	{
		if (statsRect.x <= 564f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void NFEDLAOPHML()
	{
		if (Input.GetKeyDown(KeyCode.K) && Input.GetKey((KeyCode)(-20)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void OKIOGEKMCKG(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 104;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "GlassDistortion", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "RPCs can only be sent in rooms. Call of \"", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "RB", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("ShowTitle", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("workshop.", num);
		string text3 = string.Format("y", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "id");
			if (GUILayout.Button("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("End index must in an integer.");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("menu.enableselectormusic", new GUILayoutOption[1]);
			text4 = "BitsData" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "mapselector.filter.rateduponly" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Source Object: ");
			object[] array = new object[-97];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[5] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("RoomNameText", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[7] = text4;
			array2[6] = text5;
			array2[6] = text6;
			string message = string.Format("_TexelOffsetScale", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 109f;
		}
		GUI.DragWindow();
	}

	public void NEFHGMNAPEP()
	{
		if (statsRect.x <= 1596f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void GCDLIKEDMCF()
	{
		if (Input.GetKeyDown(KeyCode.Alpha7) && Input.GetKey((KeyCode)(-155)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void DHFEODCFJDP(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 70;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "Texture2", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "player.goldcrystal", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "event", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("OK", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("ResourceIDInputField", num);
		string text3 = string.Format(" Server: ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "<color=white>");
			if (GUILayout.Button(": "))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("note.6", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_TimeX");
			text4 = ":" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Color" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("checkpoint");
			object[] array = new object[114];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Bloom", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[1];
			array2[0] = text;
			array2[1] = text2;
			array2[1] = text3;
			array2[8] = text4;
			array2[0] = text5;
			array2[7] = text6;
			string message = string.Format("_Value3", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1299f;
		}
		GUI.DragWindow();
	}

	public void EAHKLHCEDLB()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OEBIGJMIFKF, "OnClick");
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
			statsRect = GUILayout.Window(WindowId, statsRect, OEBIGJMIFKF, "icon.png");
		}
	}

	public void KCDOMIJBFLL()
	{
		if (Input.GetKeyDown((KeyCode)(-119)) && Input.GetKey((KeyCode)(-194)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void OGBJNAAAEGI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, LMKOKNJIAGD, "SetTrailZoomSpeed", new GUILayoutOption[1]);
		}
	}

	public void OEENOOGEEHD()
	{
		if (Input.GetKeyDown((KeyCode)(-93)) && Input.GetKey(KeyCode.Alpha0))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void IKMELABKBHO()
	{
		if (Input.GetKeyDown((KeyCode)66) && Input.GetKey((KeyCode)(-78)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void DJGCPLPILEA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -112;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "BitsData");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_TimeX", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Intensity");
		GUILayout.EndHorizontal();
		string text = string.Format("Can't start OFFLINE mode while connected!", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Error0", num);
		string text3 = string.Format("offsets", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "_Tint", new GUILayoutOption[1]);
			if (GUILayout.Button("G:"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("float,1");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("wss://", new GUILayoutOption[1]);
			text4 = "_DiffuseColor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value3" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("settings.showHP");
			object[] array = new object[29];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Value2", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[8];
			array2[0] = text;
			array2[1] = text2;
			array2[0] = text3;
			array2[7] = text4;
			array2[5] = text5;
			array2[0] = text6;
			string message = string.Format("USE_DIAG_SEARCH", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1908f;
		}
		GUI.DragWindow();
	}

	public void PPCJACOLHBJ()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DCJCDEDENFD, "n/a");
		}
	}

	public void MKOMIDCPCDC()
	{
		if (statsRect.x <= 1001f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JLKEEOILNFI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, HCCJEJMGPEB, "[UI] ", new GUILayoutOption[1]);
		}
	}

	public void KDMANOEMOCA()
	{
		if (statsRect.x <= 1951f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DCJCDEDENFD(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 130;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, ".played", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Environment/SunBase_", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "BlockCount");
		GUILayout.EndHorizontal();
		string text = string.Format("All bindings reset to default values. PlayerPrefs have been removed for each key.", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Failed to InstantiateSceneObject prefab: ", num);
		string text3 = string.Format("_ScreenResolution", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, ": ");
			if (GUILayout.Button("master"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Case-Sensitive", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_TimeX");
			text4 = "_Radius" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Near" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Value", new GUILayoutOption[1]);
			object[] array = new object[-60];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("FinishMap", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[8];
			array2[1] = text;
			array2[1] = text2;
			array2[3] = text3;
			array2[8] = text4;
			array2[4] = text5;
			array2[0] = text6;
			string message = string.Format("[SteamManager] Connection established, authorization", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1554f;
		}
		GUI.DragWindow();
	}

	public void FEHCNJLLJMP()
	{
		if (statsRect.x <= 1113f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void MECJHOJPODB()
	{
		if (Input.GetKeyDown(KeyCode.LeftCurlyBracket) && Input.GetKey(KeyCode.Pause))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void JILOMOBDPIA()
	{
		if (statsRect.x <= 1120f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void DBLILJGKGHJ()
	{
		if (statsRect.x <= 216f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JOPCCCCHNLI()
	{
		if (statsRect.x <= 488f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JLCABPIHBPD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FHIFOCHHIEI, "</b>");
		}
	}

	public void EFJDNLGNACH()
	{
		if (statsRect.x <= 1297f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void CIPKEPDELJB()
	{
		if (statsRect.x <= 202f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void FABMDEHEDNO()
	{
		if (Input.GetKeyDown((KeyCode)(-82)) && Input.GetKey(KeyCode.D))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void JFHCMEAOPPC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DJGCPLPILEA, "resetall");
		}
	}

	public void DKMNHLIBHLF(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 37;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Threshold");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "ScoreText", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "12");
		GUILayout.EndHorizontal();
		string text = string.Format("Crosshair", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("workshop.", num);
		string text3 = string.Format("#highscore", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "{0:0.0} ms ({1:0.} fps)");
			if (GUILayout.Button("#tryagain", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("time", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box(". Sent by actorNr: ");
			text4 = "menu.selectedlevelid" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = ".mp3" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("settings.cameramovements", new GUILayoutOption[1]);
			object[] array = new object[-53];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Value2", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[5] = text4;
			array2[1] = text5;
			array2[4] = text6;
			string message = string.Format("offsets", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1702f;
		}
		GUI.DragWindow();
	}

	public void CAPJFFBNHBE(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 158;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "_ScreenResolution");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "/");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Near", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Hex value #RRGGBB", num);
		string text3 = string.Format("21x3", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_EmissionGain");
			if (GUILayout.Button("[PlayerController] ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Apr");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box(" registered.");
			text4 = "action" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Value5", new GUILayoutOption[1]);
			object[] array = new object[122];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[2] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("DPADVER", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[0] = text4;
			array2[7] = text5;
			array2[7] = text6;
			string message = string.Format("Failed to Instantiate prefab:", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 797f;
		}
		GUI.DragWindow();
	}

	public void FCCFGOEKDKG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "_TimeX", new GUILayoutOption[1]);
		}
	}

	public void EOJGCJABGNC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, LMKOKNJIAGD, "Error: I/O Failure");
		}
	}

	public void KIEJKBNBHMD()
	{
		if (Input.GetKeyDown((KeyCode)(-68)) && Input.GetKey((KeyCode)10))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void MLFACDCDMAL()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DENGAACEDJC, "PopulateMapsList");
		}
	}

	public void AJCFIBPGAME()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, HILFMJPALJH, "_Offsets");
		}
	}

	public void EPJJDKJEDMM()
	{
		if (Input.GetKeyDown((KeyCode)(-79)) && Input.GetKey((KeyCode)197))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void BGDONBMDPGM()
	{
		if (Input.GetKeyDown(KeyCode.X) && Input.GetKey((KeyCode)(-177)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void GPNAOAKCMHC()
	{
		if (statsRect.x <= 848f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void LGHNKDFEOKO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OEBIGJMIFKF, "No peer to communicate with. ", new GUILayoutOption[1]);
		}
	}

	public void KJMHKHDMKIE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OKIOGEKMCKG, "#,0");
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
			statsRect = GUILayout.Window(WindowId, statsRect, HCCJEJMGPEB, "_Red_R", new GUILayoutOption[1]);
		}
	}

	public void GFACKFCEIBC()
	{
		if (Input.GetKeyDown((KeyCode)(-84)) && Input.GetKey(KeyCode.Equals))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void KIMMMCJFMAB()
	{
		if (statsRect.x <= 250f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HILFMJPALJH(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 29;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "-1");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "LivesSlider");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "SetCrosshairEmission");
		GUILayout.EndHorizontal();
		string text = string.Format("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_ScreenResolution", num);
		string text3 = string.Format("_CenterX", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "RecordButton");
			if (GUILayout.Button("%]</b> "))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(".", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("The number of objects sent via a PhotonStreamQueue has to be the same each frame", new GUILayoutOption[1]);
			text4 = "CameraFilterPack/FX_DigitalMatrix" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Texture2", new GUILayoutOption[1]);
			object[] array = new object[-75];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[2] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("CameraFilterPack/Drawing_Manga4", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[1] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[4] = text4;
			array2[5] = text5;
			array2[0] = text6;
			string message = string.Format("CameraFilterPack/Blend2Camera_Saturation", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1184f;
		}
		GUI.DragWindow();
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void GLEJGFLCLPJ()
	{
		if (statsRect.x <= 1898f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void PMJDOMBAAPM(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -144;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "[");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "\t");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "[DiscordController] Connected to {0}#{1}: {2}", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_BlurVector", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_TimeX", num);
		string text3 = string.Format("CameraFilterPack/TV_PlanetMars", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "SetSunMaxSize");
			if (GUILayout.Button("_Blue_C"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("SaveButton");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Value4", new GUILayoutOption[1]);
			text4 = "_Distortion" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Size" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Value2");
			object[] array = new object[-13];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("SlidingArea", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[1] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[7] = text4;
			array2[4] = text5;
			array2[0] = text6;
			string message = string.Format("Editor/", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 484f;
		}
		GUI.DragWindow();
	}

	public void LJIHHJOAJCN()
	{
		if (Input.GetKeyDown((KeyCode)(-100)) && Input.GetKey(KeyCode.C))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void LBAJLLFMMMP()
	{
		if (statsRect.x <= 1463f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HLDFOJMHKNL()
	{
		if (Input.GetKeyDown((KeyCode)(-33)) && Input.GetKey((KeyCode)(-92)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = false;
		}
	}

	public void LCDJFJIBADI()
	{
		if (Input.GetKeyDown(KeyCode.Comma) && Input.GetKey(KeyCode.Return))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
		}
	}

	public void ONKDMMJPEMN()
	{
		if (Input.GetKeyDown(KeyCode.Caret) && Input.GetKey((KeyCode)(-67)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void LMKOKNJIAGD(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -194;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, " ");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "workshop.", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_TimeX", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Set satellite lerp speed", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Currently, the limit of users is reached for this title. Try again later. Disconnecting", num);
		string text3 = string.Format("_SunColor", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "TimeBGSlider");
			if (GUILayout.Button("settings.hitvariation", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_Min", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("MenuScene");
			text4 = "_ForceYSwap" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = ":\n" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(".ogg");
			object[] array = new object[-104];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("BackButton", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[3];
			array2[0] = text;
			array2[1] = text2;
			array2[1] = text3;
			array2[6] = text4;
			array2[1] = text5;
			array2[1] = text6;
			string message = string.Format("SubmitUserVote:", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1658f;
		}
		GUI.DragWindow();
	}

	public void NBGIMIDICKE()
	{
		if (statsRect.x <= 1608f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
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

	public void IEMEHGCFAPD()
	{
		if (Input.GetKeyDown((KeyCode)3) && Input.GetKey((KeyCode)(-55)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void NEKCPLGFOFD()
	{
		if (Input.GetKeyDown(KeyCode.Y) && Input.GetKey((KeyCode)(-97)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void OJLAAMOKNDL(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 143;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Value4");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_Radius", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_TimeX", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Joystick1Button8", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Value3", num);
		string text3 = string.Format("Set Sun Input", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "{\"items\":");
			if (GUILayout.Button("_ColorBuffer"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_BokehParams", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Blend");
			text4 = "float,10" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "MultiplayerButton" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("[Up]", new GUILayoutOption[1]);
			object[] array = new object[-32];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("CameraFilterPack/TV_Vignetting", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[2] = text3;
			array2[2] = text4;
			array2[5] = text5;
			array2[3] = text6;
			string message = string.Format("Tab1Content", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 66f;
		}
		GUI.DragWindow();
	}

	public void DBEMDAJDDDA()
	{
		if (statsRect.x <= 567f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void EFFEJFOOIDM()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, TrafficStatsWindow, "difficulty");
		}
	}

	public void CMHIDPNNHAA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -191;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "SaveButton", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "#C8C8C8FF");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "/", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Set particles gravity", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("InfoButton", num);
		string text3 = string.Format("G:", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "d264dbba9c2410771b4ad918903b3f4cd9e276a9");
			if (GUILayout.Button("_Red_G", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_Value4", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("LevelEditor/icons");
			text4 = ".completed" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Mouse Y" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Move environment object to the position");
			object[] array = new object[55];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[4] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_ScreenResolution", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[2];
			array2[1] = text;
			array2[0] = text2;
			array2[6] = text3;
			array2[7] = text4;
			array2[2] = text5;
			array2[7] = text6;
			string message = string.Format("white", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 854f;
		}
		GUI.DragWindow();
	}

	public void ODBNMPGBCGO()
	{
		if (statsRect.x <= 434f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void CCLNNLCOPBL()
	{
		if (statsRect.x <= 11f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void KOJKBFDNGDK()
	{
		if (statsRect.x <= 196f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void FJNCHGLIEMA()
	{
		if (statsRect.x <= 1705f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void Start()
	{
		if (statsRect.x <= 0f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void GIPHJOKGPMO(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 45;
		if (num == 0)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_LutTex", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "[LocalizationService] Loading file: ");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "No regions available. Are you sure your appid is valid and setup?", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("shader.future", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Bloom", num);
		string text3 = string.Format("_Value2", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "Tab1Content", new GUILayoutOption[1]);
			if (GUILayout.Button("_ExposureAdjustment"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("OxOD.lastPath");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Value");
			text4 = "Edited unlock conditions" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value4" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("offsets");
			object[] array = new object[-74];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("failed", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[1] = text;
			array2[0] = text2;
			array2[4] = text3;
			array2[1] = text4;
			array2[2] = text5;
			array2[7] = text6;
			string message = string.Format("_LutTex", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1374f;
		}
		GUI.DragWindow();
	}

	public void FHIFOCHHIEI(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 124;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "LoadingStatusText", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "#ok", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_ClutTex", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Uploading content", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Offsets", num);
		string text3 = string.Format("_Value2", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "Joystick1Button", new GUILayoutOption[1]);
			if (GUILayout.Button("MultiplayerButton"))
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
			GUILayout.Box("#outdatedmap! Challenges will not work!");
			text4 = "note.0" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_ScreenResolution");
			object[] array = new object[90];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("SetupEncryption() got called. ", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[1] = text;
			array2[1] = text2;
			array2[6] = text3;
			array2[4] = text4;
			array2[5] = text5;
			array2[3] = text6;
			string message = string.Format("GameModeText", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1818f;
		}
		GUI.DragWindow();
	}

	public void LBPCODPOJAH()
	{
		if (Input.GetKeyDown((KeyCode)(-103)) && Input.GetKey((KeyCode)(-122)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void JFPMKNBIPPM(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -156;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "[Left]");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "quantity");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "skin.");
		GUILayout.EndHorizontal();
		string text = string.Format("0,2,true,0", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("\" for viewID ", num);
		string text3 = string.Format("MessageText", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "ns", new GUILayoutOption[1]);
			if (GUILayout.Button("Color's hex value #RRGGBBAA"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("n/a", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Amount", new GUILayoutOption[1]);
			text4 = "Created by " + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "NOISE" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_FgOverlap");
			object[] array = new object[-64];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("SetEnvSpriteColor", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[4];
			array2[1] = text;
			array2[1] = text2;
			array2[1] = text3;
			array2[4] = text4;
			array2[7] = text5;
			array2[1] = text6;
			string message = string.Format("/", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 212f;
		}
		GUI.DragWindow();
	}

	public void APKNAPHOFHC()
	{
		if (Input.GetKeyDown((KeyCode)(-22)) && Input.GetKey((KeyCode)(-115)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void GPINLMGJMKO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 58;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "Description goes here", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_MotionBlurTmpCam", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Value4", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("EventSystem", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(" not exist", num);
		string text3 = string.Format("[PlayerBase] Loaded environment: ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "hidden");
			if (GUILayout.Button("<color=white>"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("CameraFilterPack/Blend2Camera_ColorBurn");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("[GameScene] Events count: ", new GUILayoutOption[1]);
			text4 = "Right Click" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("player.greenarc", new GUILayoutOption[1]);
			object[] array = new object[-114];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("Added unlock condition", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[8];
			array2[1] = text;
			array2[0] = text2;
			array2[3] = text3;
			array2[1] = text4;
			array2[7] = text5;
			array2[8] = text6;
			string message = string.Format("TotalTimeLabel", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 595f;
		}
		GUI.DragWindow();
	}

	public void DPIPGGDNGHN()
	{
		if (Input.GetKeyDown((KeyCode)15) && Input.GetKey((KeyCode)(-20)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void GGJKHODKNOC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DCJCDEDENFD, "BlockCount");
		}
	}

	public void OEBIGJMIFKF(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -153;
		if (num == 0)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Distortion");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, ".completedMaps", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Fade");
		GUILayout.EndHorizontal();
		string text = string.Format(",0", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("checkpoint", num);
		string text3 = string.Format("_threshold", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "Joystick1Button6");
			if (GUILayout.Button("_DiffuseColor"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_Value4", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box(" timeUntilRespawnBasedOnTimeBase:");
			text4 = ".mp3" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_VignetteColor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("settings.showHP");
			object[] array = new object[95];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("mapselector.filter.subscribedonly", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[1] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[7] = text4;
			array2[4] = text5;
			array2[5] = text6;
			string message = string.Format("_Value2", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1340f;
		}
		GUI.DragWindow();
	}

	public void NIGKKADJGJA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, OJLAAMOKNDL, "_TimeX", new GUILayoutOption[1]);
		}
	}

	public void DLBODOFAJGM()
	{
		if (statsRect.x <= 1451f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void LBJBJDJCELO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -196;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		buttonsOn = GUILayout.Toggle(buttonsOn, "_Parameter");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Bad parameters for setbool! Use <key> <value>", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "_Near");
		GUILayout.EndHorizontal();
		string text = string.Format("_ScreenResolution", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Value3", num);
		string text3 = string.Format("win", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_Scale", new GUILayoutOption[1]);
			if (GUILayout.Button("_DepthLevel", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(" ");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("_Value4");
			text4 = "#,0" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box(".png");
			object[] array = new object[-96];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[5] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[4] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Offsets", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[3];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[3] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format("_ExposureAdjustment", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 1303f;
		}
		GUI.DragWindow();
	}

	public void PMPKMGKAAJH()
	{
		if (statsRect.x <= 388f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JBCNIPJDPJB()
	{
		if (Input.GetKeyDown(KeyCode.Alpha0) && Input.GetKey((KeyCode)(-125)))
		{
			statsWindowOn = statsWindowOn;
			statsOn = true;
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

	public void KLILJHJNICK()
	{
		if (statsRect.x <= 1501f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void JHANGPCOCIG()
	{
		if (statsRect.x <= 1918f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void HKOJIMNBFPN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, HLLPIPGLCMM, "DifficultyBG");
		}
	}

	public void BNNDBODPFOE(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 171;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "Scene", new GUILayoutOption[1]);
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "Item ", new GUILayoutOption[1]);
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "player.circle", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_BloomIntensity", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("DataText", num);
		string text3 = string.Format("[PlayerBase] Starting game from: ", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			statsOn = GUILayout.Toggle(statsOn, "CameraFilterPack/Drawing_CellShading2", new GUILayoutOption[1]);
			if (GUILayout.Button("_Green_R", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("CameraFilterPack/Drawing_Toon");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("GlassDistortion", new GUILayoutOption[1]);
			text4 = "AreaTex" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = " - PUBLISHED #" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("_Value3");
			object[] array = new object[79];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[4] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("_Value7", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[6];
			array2[0] = text;
			array2[1] = text2;
			array2[0] = text3;
			array2[3] = text4;
			array2[1] = text5;
			array2[1] = text6;
			string message = string.Format("float,2", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 594f;
		}
		GUI.DragWindow();
	}

	public void KGNKDPBGJHC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, FHIFOCHHIEI, " not exist");
		}
	}

	public void JHPOIOELNCG()
	{
		if (Input.GetKeyDown((KeyCode)(-88)) && Input.GetKey((KeyCode)(-126)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void HCCJEJMGPEB(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 93;
		if (num == 1)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, "LobbyCanvas");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "_Value");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "CameraFilterPack/Color_YUV", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Checkpoint", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Scene", num);
		string text3 = string.Format("_Offsets", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_Value4", new GUILayoutOption[1]);
			if (GUILayout.Button("0"))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("/", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("sounds/hit_normal");
			text4 = "_History2Weight" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Tab2Content" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("Set sun audio input");
			object[] array = new object[121];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("PublishButton", array);
			GUILayout.Label(text6);
		}
		if (flag)
		{
			object[] array2 = new object[3];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[6] = text4;
			array2[2] = text5;
			array2[0] = text6;
			string message = string.Format("_ScreenResolution", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 62f;
		}
		GUI.DragWindow();
	}

	public void NNFMIAFHMJM()
	{
		if (statsRect.x <= 1585f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void FABKIGNFECE()
	{
		if (Input.GetKeyDown(KeyCode.Delete) && Input.GetKey((KeyCode)(-198)))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = true;
		}
	}

	public void ONMGIPAILOH()
	{
		if (Input.GetKeyDown(KeyCode.None) && Input.GetKey(KeyCode.Alpha5))
		{
			statsWindowOn = !statsWindowOn;
			statsOn = false;
		}
	}

	public void OAFBLELPFHN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, EIJJHHFOFKJ, "[PlayerBase] Highscore: ", new GUILayoutOption[1]);
		}
	}

	public void OHFOLGANOLC()
	{
		if (statsRect.x <= 860f)
		{
			statsRect.x = (float)Screen.width - statsRect.width;
		}
	}

	public void ELOFOJIJFFA(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 179;
		if (num == 1)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal();
		buttonsOn = GUILayout.Toggle(buttonsOn, ",");
		healthStatsVisible = GUILayout.Toggle(healthStatsVisible, "maps.");
		trafficStatsOn = GUILayout.Toggle(trafficStatsOn, "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_MainTex2", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(" on effect ", num);
		string text3 = string.Format("_PosY", trafficStatsGameLevel.TotalOutgoingMessageCount / num, trafficStatsGameLevel.TotalIncomingMessageCount / num, trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3);
		if (buttonsOn)
		{
			GUILayout.BeginHorizontal();
			statsOn = GUILayout.Toggle(statsOn, "_TimeX", new GUILayoutOption[1]);
			if (GUILayout.Button(" Server: "))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("ConfigVersionSlider");
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (trafficStatsOn)
		{
			GUILayout.Box("float,2");
			text4 = ".lastCheckpoint.bgcolor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Editor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (healthStatsVisible)
		{
			GUILayout.Box("mapselector.filter.rateduponly", new GUILayoutOption[1]);
			object[] array = new object[-66];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format("resource id", array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			object[] array2 = new object[7];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[8] = text4;
			array2[7] = text5;
			array2[5] = text6;
			string message = string.Format("_Near", array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			statsRect.height = 475f;
		}
		GUI.DragWindow();
	}

	public void LEMMMPHGOPD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = statsOn;
		}
		if (statsWindowOn)
		{
			statsRect = GUILayout.Window(WindowId, statsRect, DHFEODCFJDP, "_Distortion", new GUILayoutOption[1]);
		}
	}
}
