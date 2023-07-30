// DebugSystem
using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugSystem : MonoBehaviour
{
	public GUISkin skin;

	private GameObject NGNILGONOOC;

	private bool AHBEBGJJIJH;

	private bool CKIEEIONLPH;

	private string JMMILEFMACB = "0";

	private void MBLDJEFBLFL()
	{
	}

	private void FGNFILLNPJK()
	{
	}

	private void DDFOMFBPFFB()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "_TimeX")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("#yes") && flag)
		{
			GUILayout.Label("menutheme.letitbe", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[1];
			array2[0] = "SetParticlesCountPerBeat";
			array2[0] = Helpers.GetStat("Message duration multiplier. Recomended 1");
			array2[6] = ".png";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("CameraFilterPack_Paper4"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("0.00"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("#tryagain", 1);
			}
			if (GUILayout.Button("' found!"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Vignetting"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -95);
			if (GUILayout.Button("_DiffuseColor"))
			{
				StartCoroutine(ODHOAKFGOHM(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Value3", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator ELMJBDEJPBA(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator KIHCNKNFBIO(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void CJFLPGBFBNL()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "[MapsData] Preloading ")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO(".sav") && flag)
		{
			GUILayout.Label("CameraFilterPack/TV_LED", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[8];
			array2[0] = "Joystick1Button3";
			array2[0] = Helpers.GetStat("_DiffuseColor");
			array2[3] = "CameraFilterPack/FX_superDot";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("red"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("0", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("menu.enableselectormusic", 1);
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("CameraFilterPack/Blur_GaussianBlur", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("LostLive", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -104);
			if (GUILayout.Button("_Value3"))
			{
				StartCoroutine(ODFMDAAPEMC(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Value4"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator HCGNLFCJELN(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void PKGJJFIFLII()
	{
	}

	private void JEFFDFINFFH()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "_Fade")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("SupportLogger Info: PUN {0}: ") && flag)
		{
			GUILayout.Label("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[7];
			array2[1] = "#timeuntilend: ";
			array2[1] = Helpers.GetStat("Incoming: \n");
			array2[8] = "BitsData";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat(".png"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("CameraFilterPack_Paper2"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("colorB", 0);
			}
			if (GUILayout.Button("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Amount"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Bloom1"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 55, new GUILayoutOption[1]);
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				StartCoroutine(ELMJBDEJPBA(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button(".b", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void LFBGJIIECLD()
	{
	}

	private void NCNPAKFAFOE()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void AEDDNDHCLNN()
	{
	}

	private void AOLABBMIEIM()
	{
	}

	private void ANKIJGCGCBF()
	{
	}

	private void HBNHHPJNNIP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "Screenshots only supported in PlayMode")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Hello World, is my item a clone? [") && flag)
		{
			GUILayout.Label("Image");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[1] = "settings.enableranking";
			array2[0] = Helpers.GetStat("Hello World, is my item a clone? [");
			array2[5] = "_ScreenResolution";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("RedoButton"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_Value8"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("#ok", 1);
			}
			if (GUILayout.Button("_Value9", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("id"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 113, new GUILayoutOption[1]);
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				StartCoroutine(GOCLGDGBINN(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("#no", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator KEGFLEHHHNI(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator NAPOEAOOPIC(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void OKLAJINHPAN()
	{
	}

	private IEnumerator HINJOOMPEPO(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void GGJKHODKNOC()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "Tab1Content")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_Value3") && flag)
		{
			GUILayout.Label("_Value", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[4];
			array2[1] = "_MainTex2";
			array2[1] = Helpers.GetStat("_Value2");
			array2[3] = "Object ID. Case-Sensitive";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("scenes"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button(": ", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("_SpawnHeuristic", 0);
			}
			if (GUILayout.Button("_PColor"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("yyyy"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 100, new GUILayoutOption[1]);
			if (GUILayout.Button("turn"))
			{
				StartCoroutine(LONMNCGAAOF(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("[PlayerBase] Highscore: "))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator OPDIFOMFBHJ(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void HPFIHLMKIPF()
	{
	}

	private void APEEJAJGNDD()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "Bass")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("PublishButton") && flag)
		{
			GUILayout.Label("_BlurRadius4", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[1] = "Despawn environment object by id";
			array2[1] = Helpers.GetStat("UseScanLine");
			array2[4] = "_LutTex";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat(".sawoutdatedmessage"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("TotalHitsScoreText", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("y", 1);
			}
			if (GUILayout.Button("EventData0DropDownList", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("settings.hideui"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: "))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 1, new GUILayoutOption[1]);
			if (GUILayout.Button("#{0:00}{1}{2}"))
			{
				StartCoroutine(MEFGIPEHEJF(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Save"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator LMCNDDCIAJM(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void OGBJNAAAEGI()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "\\\\")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX") && flag)
		{
			GUILayout.Label("_BlurDirectionPacked");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[1];
			array2[0] = "color";
			array2[1] = Helpers.GetStat("Tab2Content");
			array2[7] = "[NetworkManager] Connecting...";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value4"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("Pop"))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("FPSToggle", 0);
			}
			if (GUILayout.Button("_Value"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("settings_bindings_", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("[EditorEvent] Exception: ", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 102, new GUILayoutOption[1]);
			if (GUILayout.Button("Winter2020"))
			{
				StartCoroutine(KLBBABJEBBH(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator DKOMMJNNECN(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void PANGMDMILHF()
	{
	}

	private void PCHCFIOHIKK()
	{
	}

	private void HMKBLLMIKAB()
	{
	}

	private void FBPHNEJBDJN()
	{
	}

	private void KGNKDPBGJHC()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "_Visualize")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("settings.disablestoryboard") && flag)
		{
			GUILayout.Label(".highscore");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[1] = "_SampleDistance";
			array2[0] = Helpers.GetStat("_Red_G");
			array2[4] = "editorVolume";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("ShowSprite"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("#pleasewait"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI(".lastCheckpoint.maxLongestCombo", 0);
			}
			if (GUILayout.Button("_TimeX"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("init", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("CameraFilterPack/3D_Anomaly"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 83);
			if (GUILayout.Button("team", new GUILayoutOption[1]))
			{
				StartCoroutine(HINJOOMPEPO(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Player Connected"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void MJLAAKJHBIM()
	{
	}

	private IEnumerator DAAMDJOIGBJ(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void ALOPNDLLJFA()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "Joystick1Button12")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("UseScanLineSize") && flag)
		{
			GUILayout.Label("#combo");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[4];
			array2[0] = "#";
			array2[0] = Helpers.GetStat("_Quality");
			array2[0] = "_ScreenResolution";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("_DistortionSize"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_Value"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("_ScreenResolution", 1);
			}
			if (GUILayout.Button("_Rand", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("[Up]"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_BaseTex", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 49, new GUILayoutOption[1]);
			if (GUILayout.Button("player.goldwatermelon"))
			{
				StartCoroutine(DBFNKGCBEBB(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("float,1"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void JDKHBGDEONK()
	{
	}

	private void HLIAEEMGBHN()
	{
	}

	private void JBNPEHMDCMI()
	{
	}

	private void GPFJMKCGHGB()
	{
	}

	private void PDHKMDBNGGN()
	{
	}

	private void HNDNDPECBPL()
	{
	}

	private IEnumerator NFBBJIGIDPP(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void LMADKINICIN()
	{
	}

	private void DFFKKLAPHCC()
	{
	}

	private void GPNAOAKCMHC()
	{
	}

	private void DBLGGBCKCBA()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "_Value")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("[GameScene] Events count: ") && flag)
		{
			GUILayout.Label("CameraFilterPack/FX_DigitalMatrixDistortion", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[0];
			array2[0] = "_Value3";
			array2[1] = Helpers.GetStat("_LightIntensity");
			array2[1] = "_TexelOffsetScale";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("Set the end of the map. Use this if you want to cut the long music."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("Right", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_TimeX", 0);
			}
			if (GUILayout.Button("menu.enableselectormusic"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Value12"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("SetSunMaxSize", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -122, new GUILayoutOption[1]);
			if (GUILayout.Button("_Value9", new GUILayoutOption[1]))
			{
				StartCoroutine(EDNKGHCFNHE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void OnGUI()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "-help")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("isBunned") && flag)
		{
			GUILayout.Label("Emergency Help:");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			GUILayout.Label("Current xp: " + Helpers.GetStat("player.xp") + " | Level: " + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp")));
			if (GUILayout.Button("Reset XP"))
			{
				Singleton<SaveSystem>.Instance.SetInt("player.xp", 0);
			}
			if (GUILayout.Button("Reload Steam Inventory"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Reload Maps"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Obtain promo Item"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 25);
			if (GUILayout.Button("Obtain test Item"))
			{
				StartCoroutine(HCGNLFCJELN(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Reset All"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void EAHKLHCEDLB()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "_BlurredColor")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("history") && flag)
		{
			GUILayout.Label("ConfigVersionSlider");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[6];
			array2[1] = "RoomNameText";
			array2[0] = Helpers.GetStat("\" that takes ");
			array2[1] = "L1";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("..."));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Near", 1);
			}
			if (GUILayout.Button("source"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("\r\n", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_MainTex2", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 96, new GUILayoutOption[1]);
			if (GUILayout.Button(". No ViewIDs are free to use. Max is: ", new GUILayoutOption[1]))
			{
				StartCoroutine(NFBBJIGIDPP(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("ViewMenu"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void JFMIDILENDO()
	{
	}

	private void MLFACDCDMAL()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "_ScreenResolution")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("[SteamManager] Connecting to server") && flag)
		{
			GUILayout.Label("JoinButton");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[1] = "_Value2";
			array2[0] = Helpers.GetStat("_TimeX");
			array2[1] = "Tab2Content";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_PrefilterOffs"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("[PlayerController] "))
			{
				Singleton<SaveSystem>.Instance.SetInt("_TimeX", 1);
			}
			if (GUILayout.Button("_threshold"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("NEW_ACHIEVEMENT_1_21"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("BitsData", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 23);
			if (GUILayout.Button("FinalScoreSmallText"))
			{
				StartCoroutine(KLBBABJEBBH(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator JEFBAPOKNFH(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void ADLAFICKCFG()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "mapselector.filter.favoriteonly")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("{0:0} minute{1}, ") && flag)
		{
			GUILayout.Label("#mapalreadyexistupdate");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[5];
			array2[0] = "RoomPlayersCountText";
			array2[0] = Helpers.GetStat("_FixDistance");
			array2[2] = "#mapalreadyexistupdate";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("MenuScene"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("ConnectToRegion: ", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("#pleasewait", 0);
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_Exclusion", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("_Value5"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("CameraFilterPack/Gradients_Ansi", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 49);
			if (GUILayout.Button("settings.enableselectormusic"))
			{
				StartCoroutine(HCGNLFCJELN(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("[PlayerBase] Game mode: ", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FBDOGLBMDNG()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "_TimeX")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("Joystick1Button12") && flag)
		{
			GUILayout.Label(" not found", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[1] = "Vignette";
			array2[1] = Helpers.GetStat("_Near");
			array2[7] = " cannot be used as a 3D LUT.";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("Instantiating: "));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button(".lastCheckpoint.comboScore"))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Value2", 1);
			}
			if (GUILayout.Button("[NetworkManager] Join failed", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("L2", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("SetSunEmission"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 8, new GUILayoutOption[1]);
			if (GUILayout.Button("ItemsUploader"))
			{
				StartCoroutine(NAPOEAOOPIC(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("BitsData", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator KCFDNJJNNAP(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void JILOMOBDPIA()
	{
	}

	private IEnumerator ODFMDAAPEMC(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator IIEDBDEMGDK(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void POEMOLBJDLG()
	{
	}

	private void PKLOBJHKFEO()
	{
	}

	private void KFACDBHDAOD()
	{
	}

	private void OKEPOJNDCHO()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "y")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("[PlayerBase] Starting game from: ") && flag)
		{
			GUILayout.Label("SfxVolumeSlider");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[6];
			array2[0] = "_Value2";
			array2[1] = Helpers.GetStat("_Offsets");
			array2[5] = "_ScreenResolution";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("maps."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button(". Using max value: 255."))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("#ok", 1);
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("event"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("/icon", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -125);
			if (GUILayout.Button("Set Satellite Color", new GUILayoutOption[1]))
			{
				StartCoroutine(OHIIOFAOLHE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("File not found: {0}"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void NKFDNIAKGEO()
	{
	}

	private void KDJEJBBDILE()
	{
	}

	private IEnumerator LONMNCGAAOF(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void PNLKFANNOKO()
	{
	}

	private IEnumerator ODHOAKFGOHM(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void FHPFJBFCOOF()
	{
	}

	private void NHOKMFGLIPN()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "wss://")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("[MapsData] Preloading ") && flag)
		{
			GUILayout.Label("_ScreenResolution");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[1] = "_TimeX";
			array2[0] = Helpers.GetStat("note.5");
			array2[8] = "Fade";
			array2[1] = Helpers.GetPlayerLevel(Helpers.GetStat("mapselector.filter.subscribedonly"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button(" | Level: "))
			{
				Singleton<SaveSystem>.Instance.SetInt("OpAuthenticate()", 0);
			}
			if (GUILayout.Button(".completedMaps"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("GhostPosX"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("OK"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -38, new GUILayoutOption[1]);
			if (GUILayout.Button("RarityImage"))
			{
				StartCoroutine(OPDIFOMFBHJ(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("DPADHOR", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator OHIIOFAOLHE(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void KOCIIOKHKME()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "player.bluearc")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Map id for") && flag)
		{
			GUILayout.Label(".");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[0] = "1.87";
			array2[1] = Helpers.GetStat("settings.enableselectormusic");
			array2[4] = "_MidGrey";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("_SpotSize"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("#reward: ", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", 1);
			}
			if (GUILayout.Button("CameraFilterPack_TV_BrokenGlass_2"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -128, new GUILayoutOption[1]);
			if (GUILayout.Button("_Exposure", new GUILayoutOption[1]))
			{
				StartCoroutine(NMJIHNOFOLF(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Failed to InstantiateSceneObject prefab: "))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator DBFNKGCBEBB(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void CDLHBDMJAJI()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "Could not execute RPC ")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.itemscash") && flag)
		{
			GUILayout.Label("\t", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[7];
			array2[0] = "LevelNameInputField";
			array2[1] = Helpers.GetStat("UseFinalGlassColor");
			array2[8] = "owner: ";
			array2[1] = Helpers.GetPlayerLevel(Helpers.GetStat("_Blue_B"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("new round"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("Switch environment sprite image", 1);
			}
			if (GUILayout.Button("[DiscordController] Error {0}: {1}", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("Editor/"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_PositionY"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -69);
			if (GUILayout.Button("New resource ID. Case-Sensitive", new GUILayoutOption[1]))
			{
				StartCoroutine(IIEDBDEMGDK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("CameraFilterPack/Drawing_Manga_Flash", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator ODHGCCPLFJP(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void OIBMHPIFAKK()
	{
	}

	private void PNEKMLABFCE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "L1")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("color") && flag)
		{
			GUILayout.Label(" ; ");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[0] = "Sending vacant view IDs. Length: ";
			array2[0] = Helpers.GetStat("shaders");
			array2[7] = "yyyy-MM-dd HH:mm:ss";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_ScreenResolution"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("LevelConfigButton"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_ScreenResolution", 1);
			}
			if (GUILayout.Button("_Distortion", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("masterSteamID", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Editor", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -70);
			if (GUILayout.Button("menu.selectedlevelid"))
			{
				StartCoroutine(ANEIADKNGPH(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Value11", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void EGBNNBLCKNE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "Tab2Content")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("&search=") && flag)
		{
			GUILayout.Label("FavoriteButton", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "_Convolved_TexelSize";
			array2[1] = Helpers.GetStat("CameraFilterPack/Broken_Screen");
			array2[7] = "Keypad ";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat(" "));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("StartButton", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("End Value should be greater than the start value, values not changed", 1);
			}
			if (GUILayout.Button("settings_bindings_", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("VIGNETTE_CLASSIC", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("id"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 59);
			if (GUILayout.Button("_Value7", new GUILayoutOption[1]))
			{
				StartCoroutine(NAPOEAOOPIC(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private IEnumerator IIBMFAMNFEE(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator IKIGAFJHIIG(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator ACIHAOMNCGK(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void FABKIGNFECE()
	{
	}

	private void HIPEHGNBJMN()
	{
	}

	private void KEBFAMDNNGH()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "SetPosition")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_SpherePositionX") && flag)
		{
			GUILayout.Label("Items/", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[2];
			array2[0] = "_Bloom3";
			array2[0] = Helpers.GetStat("SaveButton");
			array2[2] = "settings.disablestoryboard";
			array2[1] = Helpers.GetPlayerLevel(Helpers.GetStat("float,0"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("Added event", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("maps.", 0);
			}
			if (GUILayout.Button("+", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("Print the list of scenes, avalable in game."))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Tab2Content", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -29);
			if (GUILayout.Button("_TapLowForeground", new GUILayoutOption[1]))
			{
				StartCoroutine(JEFBAPOKNFH(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("FileMenu"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void HIKKPDACJGI()
	{
	}

	private IEnumerator IHLBJLAJNAP(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void HPNNCNNFMGK()
	{
	}

	private void KMCPMOGKDEH()
	{
	}

	private void JFJLGJEPEAA()
	{
	}

	private void MKKJICPMPHK()
	{
	}

	private IEnumerator FEIGODHEPHD(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void IAIGNDMHFFG()
	{
	}

	private void AKGHJPACNLP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "?")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("CameraFilterPack/RainFX") && flag)
		{
			GUILayout.Label("_Value4");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[3];
			array2[0] = "HPToggle";
			array2[0] = Helpers.GetStat("value");
			array2[0] = "]";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("Dance"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_Factor", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_MainTex2", 1);
			}
			if (GUILayout.Button("Items/"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("76561198041679481"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_MainTex2", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 2);
			if (GUILayout.Button("y", new GUILayoutOption[1]))
			{
				StartCoroutine(FKLOCDKPHAG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_NoisePerChannel", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void OAGAGCMFGOM()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "DPADHOR")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("LeaderboardsButton") && flag)
		{
			GUILayout.Label(".highscore");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[7];
			array2[0] = "Joystick1Button3";
			array2[0] = Helpers.GetStat("Editor/");
			array2[8] = "_Threshhold";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat(".lastCheckpoint.comboScore"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("LivesSlider", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("\n", 0);
			}
			if (GUILayout.Button("x"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Save the map before exiting?", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("float,0"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 125);
			if (GUILayout.Button("Description goes here"))
			{
				StartCoroutine(FKLOCDKPHAG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button(" while connecting to: ", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void Update()
	{
	}

	private void FJNJIHCLODK()
	{
	}

	private IEnumerator EDNKGHCFNHE(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void PFGBMOOHMMJ()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "SettingsCanvas")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB(" not exist") && flag)
		{
			GUILayout.Label("score", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[0] = "_ScreenResolution";
			array2[0] = Helpers.GetStat("_Value");
			array2[3] = "_TimeX";
			array2[1] = Helpers.GetPlayerLevel(Helpers.GetStat("InfoCanvas"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("[Left]", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("LastHighScoreText", 1);
			}
			if (GUILayout.Button("offsets"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("seconds"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button(".mp3"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -13, new GUILayoutOption[1]);
			if (GUILayout.Button("x"))
			{
				StartCoroutine(NFBBJIGIDPP(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("menu.enableselectormusic"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void DGEABJCAOAD()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "_MainTex2")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("Load Game") && flag)
		{
			GUILayout.Label("[PlayerController] ");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[8];
			array2[0] = "keep aspect ratio";
			array2[0] = Helpers.GetStat("color");
			array2[2] = "settings.crosshairopacity";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("_Distortion"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Green_B", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("mapselector.filter.rateduponly", 1);
			}
			if (GUILayout.Button("scn", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("restrictions\n\n#until: ", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Value3"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -41, new GUILayoutOption[1]);
			if (GUILayout.Button("_NoiseTilingPerChannel"))
			{
				StartCoroutine(BGLNJKHPEFK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("settings_bindings_controller_type", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator ANEIADKNGPH(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void GKENNHBFBLA()
	{
	}

	private void GLEJGFLCLPJ()
	{
	}

	private void NNCCPEBIAKH()
	{
	}

	private void JCGMGLMADEN()
	{
	}

	private void EFNIKEMPDIF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == ".lastCheckpoint.playerdistance")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("ERROR You should never change PhotonPlayer IDs!") && flag)
		{
			GUILayout.Label("_TimeX", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[1] = "CameraFilterPack/Atmosphere_Rain_Pro_3D";
			array2[1] = Helpers.GetStat("MenuScene");
			array2[7] = "ItemsCountText";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat(".workshop.json"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("_Distortion", 0);
			}
			if (GUILayout.Button("[LevelEditorScene] Error: Timeout :S"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("CameraFilterPack/Noise_TV"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("[MapsData] Found ", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -70, new GUILayoutOption[1]);
			if (GUILayout.Button("R2", new GUILayoutOption[1]))
			{
				StartCoroutine(OHIIOFAOLHE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("skin.", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void CFFCLAHMBAA()
	{
	}

	private IEnumerator ABFNLDNOOJB(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void JOACBIEHHCE()
	{
	}

	private void PHACPKPPBJF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "MenuScene")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("#outdatedmap! Challenges will not work!") && flag)
		{
			GUILayout.Label("Join failed on GameServer. Changing back to MasterServer. Msg: ");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[7];
			array2[1] = "Instantiating: ";
			array2[0] = Helpers.GetStat("_QualitySettings");
			array2[8] = "id";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("Set satellite beat detection sensitivity"))
			{
				Singleton<SaveSystem>.Instance.SetInt("menu.selectedlevelid", 0);
			}
			if (GUILayout.Button("Set sun beat detection sensitivity", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button(",", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Scale environment object by the values", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -42);
			if (GUILayout.Button(": "))
			{
				StartCoroutine(BGLNJKHPEFK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("EventTimeInputField"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void OGJJDKENBNC()
	{
	}

	private void LGMADMDBKNE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "\n")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Missing shader for image effect {0}") && flag)
		{
			GUILayout.Label("x", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[0] = "HiddenToggle";
			array2[1] = Helpers.GetStat("Mouse Wheel Down");
			array2[2] = "_VignetteSettings";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("#ok"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("[PlayerController] ", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("settings.arcshitsoundtimedelay", 0);
			}
			if (GUILayout.Button("Jit ", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("MissesText", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Luminance", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 59, new GUILayoutOption[1]);
			if (GUILayout.Button("_Radius", new GUILayoutOption[1]))
			{
				StartCoroutine(HCGNLFCJELN(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("maps."))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void EIDNEKAJLEP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == " has no method \"")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("Moved event") && flag)
		{
			GUILayout.Label("EditMenu");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[8];
			array2[1] = "_MainTexBlurred";
			array2[1] = Helpers.GetStat("Tab1Content");
			array2[8] = "<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("Lag "));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("\"x"))
			{
				Singleton<SaveSystem>.Instance.SetInt("_TimeX", 0);
			}
			if (GUILayout.Button("shader.invert", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("colorC"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("[MapEditor] Prepairing map editor..."))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 24, new GUILayoutOption[1]);
			if (GUILayout.Button("_Luminance"))
			{
				StartCoroutine(CMBJJJBELFB(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("cancel"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void AOCIIDFPCMK()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "CameraFilterPack/Vision_Blood")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX") && flag)
		{
			GUILayout.Label("menu.playedpage");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[0];
			array2[1] = "CameraFilterPack/Blend2Camera_Subtract";
			array2[1] = Helpers.GetStat(".b");
			array2[2] = "_Distortion";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("_ScreenResolution"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("CameraFilterPack/AAA_Super_Hexagon"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("CameraFilterPack/Drawing_Manga3", 0);
			}
			if (GUILayout.Button("_Visualize"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("id"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("SetSunDirectionVector", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 65, new GUILayoutOption[1]);
			if (GUILayout.Button("offsets"))
			{
				StartCoroutine(KLBBABJEBBH(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("maps."))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FNCDAPDOBBI()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	private void ODCJJFBJJNF()
	{
	}

	private IEnumerator DFLCELEEGBL(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void Start()
	{
	}

	private void LCLNNFMLKLF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "data")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_CurveParams") && flag)
		{
			GUILayout.Label("HitInRelaxMusicToggle", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayout.Label(string.Concat("SetEnvSpriteColor", Helpers.GetStat("z"), null, "ResetSpeed", null, Helpers.GetPlayerLevel(Helpers.GetStat("HightScoreMaxPointsText")), null, null));
			if (GUILayout.Button("vignetteIntensity"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Value3", 0);
			}
			if (GUILayout.Button("_Gamma"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("[Right]", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("<b>Difficulty</b>:", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -12);
			if (GUILayout.Button("[Right-Down-Left]", new GUILayoutOption[1]))
			{
				StartCoroutine(BGLNJKHPEFK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("w", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void PJHBFAFOEEN()
	{
	}

	private void CGCEDEENFPF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "_Value4")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX") && flag)
		{
			GUILayout.Label("_BlurTex", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[7];
			array2[1] = "settings.enableranking";
			array2[0] = Helpers.GetStat("Failed to InstantiateSceneObject prefab:");
			array2[6] = "StopSounds";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("SetSunDirectionVector"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("workshop.txt"))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Value6", 1);
			}
			if (GUILayout.Button("CountEventsGoal"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("[LevelEditorScene] Print Audio Wave: Done", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Value4"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -85);
			if (GUILayout.Button("_MainTex2"))
			{
				StartCoroutine(CMBJJJBELFB(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("YES", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void CMEJNBPFGHP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "note.4")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey(",") && flag)
		{
			GUILayout.Label("FinalScoreSmallText");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[5];
			array2[1] = "HighScaleShot";
			array2[0] = Helpers.GetStat("(\\[ */ *h1 *\\])");
			array2[2] = "Currently, the limit of users is reached for this title. Try again later. Disconnecting";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("Bad parameters for getbool! Use <key> <value>"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Value5"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("ResetButton", 0);
			}
			if (GUILayout.Button("CameraFilterPack/Drawing_BluePrint"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("PS Home", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Environment/SunBase_"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 79, new GUILayoutOption[1]);
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				StartCoroutine(FKLOCDKPHAG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("PUNCloudBestRegion"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KOJKBFDNGDK()
	{
	}

	private IEnumerator BGLNJKHPEFK(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void KNKOCAKPJKF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "z")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Up") && flag)
		{
			GUILayout.Label("_LoopCount");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[4];
			array2[0] = "_CameraToWorldMatrix";
			array2[1] = Helpers.GetStat("ns");
			array2[5] = "_TimeX";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("_BilateralUpsampling"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Value3", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("status", 0);
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_DarkerColor"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("SendVacantViewIds()"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Tab2Content", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -23);
			if (GUILayout.Button("settings.enableranking"))
			{
				StartCoroutine(IHLBJLAJNAP(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("win"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void KPBKHFNLNBA()
	{
	}

	private IEnumerator GOCLGDGBINN(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void JKFDDNMPOJH()
	{
	}

	private void LKFBADCLLML()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "\"")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("menu.selectedmode") && flag)
		{
			GUILayout.Label(".lastCheckpoint.correctScore");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[2];
			array2[0] = "There is already a virtual axis named ";
			array2[1] = Helpers.GetStat("#rt");
			array2[1] = ". Using max value: 255.";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("_DotSize"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("2hands"))
			{
				Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/AAA_BloodOnScreen", 1);
			}
			if (GUILayout.Button("settings.cameramovements", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("CameraFilterPack/3D_Inverse"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("player.xp", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 110, new GUILayoutOption[1]);
			if (GUILayout.Button("Case-Sensitive"))
			{
				StartCoroutine(OPDIFOMFBHJ(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator NMJIHNOFOLF(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void IGPCNCJIEOJ()
	{
	}

	private void DKNLIFAKIKL()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "DataText")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO(".save") && flag)
		{
			GUILayout.Label("challenges.");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[2];
			array2[0] = "_Color_R";
			array2[1] = Helpers.GetStat("CameraFilterPack/NightVisionFX");
			array2[7] = " not exist";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("SpawnObj"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button(" not exist"))
			{
				Singleton<SaveSystem>.Instance.GBFBKFACPBI("_TimeX", 0);
			}
			if (GUILayout.Button("_EmissionGain"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("/"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button(": "))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 111, new GUILayoutOption[1]);
			if (GUILayout.Button("steamid"))
			{
				StartCoroutine(DAAMDJOIGBJ(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("challenges.", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void MMPHNFPPEHO()
	{
	}

	private void FAKGFMFAPDG()
	{
	}

	private IEnumerator CMBJJJBELFB(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private IEnumerator FKLOCDKPHAG(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void MKLFMPFABEG()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "MenuRecordButton")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_AdaptTex") && flag)
		{
			GUILayout.Label("_DX11NoiseTime");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "UseFinalGlassColor";
			array2[1] = Helpers.GetStat("CameraFilterPack/Blend2Camera_Difference");
			array2[8] = "[Down-Left]";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("_TimeX"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("inventory.selected.", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_MainTex2", 0);
			}
			if (GUILayout.Button("Default UI Material", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("{0}{1}{2}={3}", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Drop_Far", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -31, new GUILayoutOption[1]);
			if (GUILayout.Button("_Strength"))
			{
				StartCoroutine(KCFDNJJNNAP(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_BlurredColor", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator KLBBABJEBBH(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void FOAGAKFBIGD()
	{
	}

	private void CIPKEPDELJB()
	{
	}

	private void EFLAICJDONO()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "_TimeX")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Netw. Sim.") && flag)
		{
			GUILayout.Label("NEW_ACHIEVEMENT_1_", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[8];
			array2[1] = "_DotSize";
			array2[0] = Helpers.GetStat("Gameplay/particles");
			array2[4] = "[ERROR KEY {0}]";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("_ScreenResolution"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("MessageText", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("[Singleton] multiple instances of '", 0);
			}
			if (GUILayout.Button(".lastCheckpoint.time"))
			{
				Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
			}
			if (GUILayout.Button("MaxLivesSlider"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Bullet_10"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -79, new GUILayoutOption[1]);
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]))
			{
				StartCoroutine(BGLNJKHPEFK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Save Path: "))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private IEnumerator MEFGIPEHEJF(int JMMILEFMACB)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("key", "---");
		wWWForm.AddField("appid", "513510");
		wWWForm.AddField("steamid", "76561198041679481");
		wWWForm.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wWWForm.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		yield return new WWW(url, data);
	}

	private void CFIAKIJAILI()
	{
	}
}
