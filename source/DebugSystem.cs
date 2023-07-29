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

	private IEnumerator NJBKKNMCANL(int JMMILEFMACB)
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

	private void GAMPNFOIFHF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "mapselector.filter.subscribedonly")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("SpawnObj") && flag)
		{
			GUILayout.Label(".");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[3];
			array2[0] = "_Value2";
			array2[1] = Helpers.GetStat("[ItemsHandler] Inventory has changed");
			array2[0] = "CameraFilterPack/Real_VHS";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat(" not exist"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("Uploading content"))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("player.xp", 0);
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("menu.selectedplaymode", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("PLEASE WAIT"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 48);
			if (GUILayout.Button("SpawnObj", new GUILayoutOption[1]))
			{
				StartCoroutine(CDHNLLBNBFD(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Text"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void IMAPGBMIKJF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "steamid")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_ScreenResolution") && flag)
		{
			GUILayout.Label("Preparing content", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[0];
			array2[0] = "[Left]";
			array2[0] = Helpers.GetStat("Feb");
			array2[6] = "_Distance";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("CameraFilterPack/AAA_WaterDropPro"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("ws://"))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Reset 21 achievement progress", 0);
			}
			if (GUILayout.Button("_Value"))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("LoadMapCanvas", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("path"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 40, new GUILayoutOption[1]);
			if (GUILayout.Button("CheckCombo"))
			{
				StartCoroutine(IAFPILJNPJE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("<b>Speed</b>:", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator BPFDEIPEHNB(int JMMILEFMACB)
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

	private IEnumerator NCHNAJLDLBE(int JMMILEFMACB)
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

	private void EFFEJFOOIDM()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "R2")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("{0:0}") && flag)
		{
			GUILayout.Label("_Axis", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "_Value2";
			array2[0] = Helpers.GetStat("workshop.");
			array2[1] = "Reload Maps";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("{STEAM_CLAN_IMAGE}"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_DistortionSize", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Value4", 1);
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_SoftLight", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("#lives"))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("SetCrosshairColor", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 102, new GUILayoutOption[1]);
			if (GUILayout.Button("_MainTex2"))
			{
				StartCoroutine(DEOBEEFBNPF(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("settings.cameramovements", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void AJCFIBPGAME()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "workshop.")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Value") && flag)
		{
			GUILayout.Label("#no", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[5];
			array2[1] = "Failed to InstantiateSceneObject prefab:";
			array2[0] = Helpers.GetStat("player.currentrank");
			array2[6] = "_CenterX";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("Hidden/DepthOfField/BokehSplatting"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("CameraFilterPack/AAA_BloodOnScreen", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value9", 0);
			}
			if (GUILayout.Button("_RotationMatrix", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("LastHighScoreText"))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("settings.crosshairopacity"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 24, new GUILayoutOption[1]);
			if (GUILayout.Button("/"))
			{
				StartCoroutine(IKIGAFJHIIG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("workshop."))
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

	private void LKFBADCLLML()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "PUN-instantiated '")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey(".lastCheckpoint.time") && flag)
		{
			GUILayout.Label("settings_bindings_", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[0] = "_Value";
			array2[0] = Helpers.GetStat("STICKLVER");
			array2[7] = "mapselector.filter.rateduponly";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("/"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("/", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("MascotChallenge2019", 1);
			}
			if (GUILayout.Button("ConfigVersionSlider", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button(".lastCheckpoint.time", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("maxScore", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -63, new GUILayoutOption[1]);
			if (GUILayout.Button("Joystick1Button6"))
			{
				StartCoroutine(FNMOGPINAAJ(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("[LobbyPlayerElement] Created lpe for ", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void JOPCCCCHNLI()
	{
	}

	private IEnumerator OKFHFFHCDEB(int JMMILEFMACB)
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
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "_TimeX")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Near") && flag)
		{
			GUILayout.Label("/");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[1];
			array2[1] = "value";
			array2[0] = Helpers.GetStat("#currentbpm: ");
			array2[1] = "_SunPosition";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("OpJoinRandomRoom()"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Chat", 1);
			}
			if (GUILayout.Button("[PlayerController] "))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("1"))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("SpectatingUserInfo"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -66);
			if (GUILayout.Button("_Value4"))
			{
				StartCoroutine(MIGCGKLBGML(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Visualize"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KMCPMOGKDEH()
	{
	}

	private void MOIFIHHBFFF()
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
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Speed") && flag)
		{
			GUILayout.Label(" [", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[4];
			array2[0] = "CameraFilterPack/Drawing_Manga3";
			array2[0] = Helpers.GetStat("Tab2Content");
			array2[8] = "_RedAmplifier";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("[Sound Manager] Audio clip is null, cannot play music"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("_TimeX", 0);
			}
			if (GUILayout.Button("#creatingnewitem", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("CameraFilterPack/AAA_WaterDrop", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Glitch", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 20, new GUILayoutOption[1]);
			if (GUILayout.Button("MapperNameText"))
			{
				StartCoroutine(HFPELPCLPAL(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("OK", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private IEnumerator FNMOGPINAAJ(int JMMILEFMACB)
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

	private IEnumerator IAFPILJNPJE(int JMMILEFMACB)
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

	private IEnumerator JFKPFDLOFGB(int JMMILEFMACB)
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

	private void ONKDMMJPEMN()
	{
	}

	private void IPLADLICBIP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "PointsScoreText")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Set particles color") && flag)
		{
			GUILayout.Label(";", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[1] = "[NetworkManager] Exited";
			array2[0] = Helpers.GetStat("playing");
			array2[4] = "/";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("SaveButton"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("#exit", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Value3", 0);
			}
			if (GUILayout.Button("_Intensity", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Connecting"))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("x"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 46);
			if (GUILayout.Button("_Offsets", new GUILayoutOption[1]))
			{
				StartCoroutine(MIGCGKLBGML(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Hello", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void Start()
	{
	}

	private IEnumerator FGBHBIPLKDC(int JMMILEFMACB)
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

	private IEnumerator DOGJFAMOKAP(int JMMILEFMACB)
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

	private void OKEPOJNDCHO()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "Tab2Content")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("PunRespawn") && flag)
		{
			GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[0] = "Adreno";
			array2[1] = Helpers.GetStat("close");
			array2[7] = "menu.relaxinfo";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("RoomDescriptionText"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_AdaptationSpeed", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("907198288", 1);
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("Right"))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_EmissionGain", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -76);
			if (GUILayout.Button(".", new GUILayoutOption[1]))
			{
				StartCoroutine(PMEDHNBFNNG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Speed"))
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

	private void IKMELABKBHO()
	{
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

	private void BGDONBMDPGM()
	{
	}

	private void JONGNKNLLND()
	{
	}

	private void HAIAHJPCPAG()
	{
	}

	private void COIJKMKIEAK()
	{
	}

	private void JKFDDNMPOJH()
	{
	}

	private void JBCNIPJDPJB()
	{
	}

	private void GNJDKAECPKA()
	{
	}

	private IEnumerator GGDGAMFAEHI(int JMMILEFMACB)
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

	private void NNFMIAFHMJM()
	{
	}

	private void MMBPLGGLPDB()
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

	private void GNFIAMJKJIN()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "mapselector.filter.rateduponly")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("GlassDistortion") && flag)
		{
			GUILayout.Label("_Value3");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[0] = "X2";
			array2[1] = Helpers.GetStat("MenuScene");
			array2[6] = "player.mysteryitem";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("12"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("?"))
			{
				Singleton<SaveSystem>.Instance.SetInt("Freq: ", 1);
			}
			if (GUILayout.Button("HostType: {0} "))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_color"))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("maps."))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -18);
			if (GUILayout.Button("_FrustumCornersWS"))
			{
				StartCoroutine(DFLCELEEGBL(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Preparing content", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void JECMJNFGBGC()
	{
	}

	private void KLILJHJNICK()
	{
	}

	private void HMKPDNHBGDE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "SetSatelliteTrailWidth")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("The image effect ") && flag)
		{
			GUILayout.Label(".highscore");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "Image";
			array2[1] = Helpers.GetStat("finished");
			array2[4] = "_Offsets";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("Offline or in OfflineMode. No VitalStats available."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("float,1.5", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("Value", 1);
			}
			if (GUILayout.Button("_TimeX"))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("[MapsData] Caching ", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -18);
			if (GUILayout.Button("_Value"))
			{
				StartCoroutine(NFBBJIGIDPP(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("From {0} at Index {1} \n", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void PCCEPADONHK()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "Color")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("MenuPlayButton") && flag)
		{
			GUILayout.Label("_Value5", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[0] = "The given 2D texture ";
			array2[0] = Helpers.GetStat("<b>Time</b>:");
			array2[5] = "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("z"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_FixDistance", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt(") error: ", 0);
			}
			if (GUILayout.Button("Oct", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("."))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("Can't find key "))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -45, new GUILayoutOption[1]);
			if (GUILayout.Button("FToA", new GUILayoutOption[1]))
			{
				StartCoroutine(NJBKKNMCANL(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("sfxVolume"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void AHAIBKMLNAP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "VeryHigh")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Fade") && flag)
		{
			GUILayout.Label("ShowTitle", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[0] = "CameraFilterPack/Blend2Camera_Screen";
			array2[0] = Helpers.GetStat("OK");
			array2[3] = "_Near";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_LightIntensity"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_Visualize"))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("MultiplayerButton", 0);
			}
			if (GUILayout.Button("/icon", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Value3", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -47, new GUILayoutOption[1]);
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
				StartCoroutine(GGDGAMFAEHI(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Vertical", new GUILayoutOption[1]))
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

	private void PPCJACOLHBJ()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "/icon")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("DisableStoryboardToggle") && flag)
		{
			GUILayout.Label("PUN-instantiated '");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[7];
			array2[0] = "settings.volume.menu";
			array2[1] = Helpers.GetStat("shader.crispwinter");
			array2[3] = "_Value3";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("https://www.youtube.com/watch?v=cDVXukrKo74"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("[MapsStats] Max score: "))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CONTRAST", 1);
			}
			if (GUILayout.Button("set environment id"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Intensity", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Set particles audio input"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -76, new GUILayoutOption[1]);
			if (GUILayout.Button("_Value"))
			{
				StartCoroutine(NAPOEAOOPIC(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("Distortion"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void ILCFPCIPENO()
	{
	}

	private void IHLMNAGPKDA()
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

	private void OMBBIILDCCJ()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "\\")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("BloodAlternative2") && flag)
		{
			GUILayout.Label(".completedMaps", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[6];
			array2[0] = "Horizontal";
			array2[0] = Helpers.GetStat("0.00");
			array2[1] = "CameraFilterPack_AAA_Blood1";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("High"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("<not connected>", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0);
			}
			if (GUILayout.Button("CameraFilterPack/3D_Myst"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("player.ice", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("ReJoinRoom failed due to offline mode.", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -126, new GUILayoutOption[1]);
			if (GUILayout.Button(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new GUILayoutOption[1]))
			{
				StartCoroutine(EEHHMEKHAOG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void AKGHJPACNLP()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "curScn")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Tab1Content") && flag)
		{
			GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[4];
			array2[0] = "GlassAberration";
			array2[0] = Helpers.GetStat("#yes");
			array2[0] = "Set Particles Emission";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("..."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_SpotSize", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Value5", 1);
			}
			if (GUILayout.Button("StartButton"))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("0"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 71, new GUILayoutOption[1]);
			if (GUILayout.Button("_LutTex"))
			{
				StartCoroutine(GGDGAMFAEHI(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button(" base map(s)"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void CIPKEPDELJB()
	{
	}

	private void FLKEJJEGCFA()
	{
	}

	private IEnumerator OBFLOLGMFEE(int JMMILEFMACB)
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

	private void LGMADMDBKNE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "_Distortion")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("MainThreadExecuter") && flag)
		{
			GUILayout.Label("_Speed");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayout.Label("&map=" + Helpers.GetStat("1427616858") + "SetTrailZoomSpeed" + Helpers.GetPlayerLevel(Helpers.GetStat("SetCrosshairColor")) + null);
			if (GUILayout.Button("settings_bindings_"))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("mapselector.filter.rateduponly", 1);
			}
			if (GUILayout.Button("Items/", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Blue_C", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 74);
			if (GUILayout.Button("/C tasklist", new GUILayoutOption[1]))
			{
				StartCoroutine(BGLNJKHPEFK(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_FarCorner"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void AEDDNDHCLNN()
	{
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
			if (text == ".highscore")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("???") && flag)
		{
			GUILayout.Label("IconImage", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "_ScreenResolution";
			array2[0] = Helpers.GetStat("UNDISTORT");
			array2[7] = "CameraFilterPack/Blend2Camera_Luminosity";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value4"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("SearchTex"))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("SetParent", 0);
			}
			if (GUILayout.Button("_Intensity"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Circle", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button(" left", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -112);
			if (GUILayout.Button("yyyy", new GUILayoutOption[1]))
			{
				StartCoroutine(DFLCELEEGBL(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("/"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	private IEnumerator HFPELPCLPAL(int JMMILEFMACB)
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

	private void EIMNPCMHJLJ()
	{
	}

	private void LGNBNCBPMAA()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "[PlayerController] ")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("FileMenu") && flag)
		{
			GUILayout.Label("_Value5", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[5];
			array2[0] = "_Value";
			array2[1] = Helpers.GetStat("_TimeX");
			array2[5] = "Set Sun MaxSize";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("_Bullet_8"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("#close", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("STICKRVER", 1);
			}
			if (GUILayout.Button("Received RPC: "))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("Editor/", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button(" ", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 68);
			if (GUILayout.Button("_Value2", new GUILayoutOption[1]))
			{
				StartCoroutine(GGDGAMFAEHI(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Green_R"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void GGJKHODKNOC()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "ItemNameText")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".jpg") && flag)
		{
			GUILayout.Label("GlassColor", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayout.Label(string.Concat("Preparing configuration...", Helpers.GetStat("Done!"), null, "CameraFilterPack/Blend2Camera_Saturation", Helpers.GetPlayerLevel(Helpers.GetStat("_NeighborMaxTex"))), new GUILayoutOption[1]);
			if (GUILayout.Button("#lives", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0);
			}
			if (GUILayout.Button("GroupNameText", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("[ResourcesManager] Load image error: ", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("[NetworkManager] Exited"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 30, new GUILayoutOption[1]);
			if (GUILayout.Button("_TimeX"))
			{
				StartCoroutine(IAFPILJNPJE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void LBAJLLFMMMP()
	{
	}

	private void FBDOGLBMDNG()
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
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("player.xp") && flag)
		{
			GUILayout.Label("attempted to spawn go (", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[0] = "_Offsets";
			array2[0] = Helpers.GetStat("ENABLE_DITHERING");
			array2[8] = "EnvironmentSlider";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat(".lastCheckpoint.checkpointsUsed"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("GameScene", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("OnReadyClick", 1);
			}
			if (GUILayout.Button("skin."))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ChannelMixerGreen", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 25);
			if (GUILayout.Button("UI Extensions/SoftMaskShaderText", new GUILayoutOption[1]))
			{
				StartCoroutine(OBOLALMEFCE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Bloom5", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FMNPFCHBLJF()
	{
	}

	private void IBLGHLNNAHN()
	{
	}

	private IEnumerator BDHBLCMKLLM(int JMMILEFMACB)
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

	private IEnumerator PMEDHNBFNNG(int JMMILEFMACB)
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

	private void LDDKCCMHMIC()
	{
	}

	private void EFJDNLGNACH()
	{
	}

	private void JLKEEOILNFI()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "MenuScene")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("LoadMapCanvas") && flag)
		{
			GUILayout.Label("x");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[1] = "green";
			array2[1] = Helpers.GetStat("Set Sun Sensitivity");
			array2[0] = "SUCCESS! Item submitted! :D :D :D";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("CameraFilterPack/Blend2Camera_LinearBurn"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("ArcsDestroyDelaySlider"))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("BitsData", 0);
			}
			if (GUILayout.Button("_Green_C"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button(": "))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Connected to gameserver.", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 108, new GUILayoutOption[1]);
			if (GUILayout.Button("Not sending leave operation. State is not 'Joined': ", new GUILayoutOption[1]))
			{
				StartCoroutine(FGBHBIPLKDC(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("CameraFilterPack/EXTRA_Rotation"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KFACDBHDAOD()
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

	private IEnumerator HIODJDMJILF(int JMMILEFMACB)
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

	private IEnumerator EEHHMEKHAOG(int JMMILEFMACB)
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

	private void OCMKCBBCEFG()
	{
	}

	private void DLBODOFAJGM()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void LMADKINICIN()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	private void MEBPBNLBECA()
	{
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

	private void FEKECCBFGMI()
	{
	}

	private void IBHACCEEFFI()
	{
	}

	private void BGDPIHMAACO()
	{
	}

	private void NHOKMFGLIPN()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "[ResourcesManager] Load audio error: ")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_RGB") && flag)
		{
			GUILayout.Label("SupportLogger OnLeftRoom().", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[6];
			array2[1] = "HandsCountSlider";
			array2[1] = Helpers.GetStat("_Value2");
			array2[4] = "[Up]";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Skybox"))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Tab1Content", 1);
			}
			if (GUILayout.Button("ItemNameBGImage", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("IconImage", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Cross", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -5, new GUILayoutOption[1]);
			if (GUILayout.Button("skin.hit_wrong"))
			{
				StartCoroutine(DEOBEEFBNPF(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("[LocalizationService] Localization: ", new GUILayoutOption[1]))
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

	private IEnumerator DEOBEEFBNPF(int JMMILEFMACB)
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

	private void HIFLPHLGLFG()
	{
	}

	private void NKFDNIAKGEO()
	{
	}

	private void DAHFFNNIGML()
	{
	}

	private void ODCJJFBJJNF()
	{
	}

	private IEnumerator MAMOAAJKNOE(int JMMILEFMACB)
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

	private void DOKAKEMDALN()
	{
	}

	private IEnumerator CDHNLLBNBFD(int JMMILEFMACB)
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

	private void EPEGAEGDJAM()
	{
	}

	private void INODCHEOKGF()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "The given 2D texture ")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP(" BETA") && flag)
		{
			GUILayout.Label("[Singleton] Using instance of '");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[1] = "maps.";
			array2[1] = Helpers.GetStat("curScn");
			array2[3] = "s";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("Avoid using this directly. Thanks."));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. "))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA(".completedCount", 0);
			}
			if (GUILayout.Button("No info", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("pointBuffer", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button(" ", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 75);
			if (GUILayout.Button("UseScanLine", new GUILayoutOption[1]))
			{
				StartCoroutine(NCHNAJLDLBE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Value2"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void PEEJIJMKMFG()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "_ScreenResolution")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("ok") && flag)
		{
			GUILayout.Label("_TimeX", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[4];
			array2[1] = "CameraFilterPack/BlurHole";
			array2[1] = Helpers.GetStat("Music End");
			array2[1] = "': ";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("DPADVER"))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("Color's hex value #RRGGBBAA", 1);
			}
			if (GUILayout.Button("[Singleton] Using instance of '", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("You need to have a Graphic control (such as an Image) for the list [", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 26, new GUILayoutOption[1]);
			if (GUILayout.Button("PS Home"))
			{
				StartCoroutine(HCGNLFCJELN(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_DistortionSize"))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void FAGGMAKKMAE()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "CameraFilterPack/Blend2Camera_Divide")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Move environment object to the position") && flag)
		{
			GUILayout.Label("event", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[7];
			array2[1] = "Time Offset: {0}";
			array2[0] = Helpers.GetStat("settings.enablehitsoundsinnormal");
			array2[7] = "Can't set visible when not in that room.";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat(".lastCheckpoint.incorrectScore"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("#onrankchangeuptext"))
			{
				Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_WideScreenHorizontal", 0);
			}
			if (GUILayout.Button("_ScreenResolution"))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("solo", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("masterSteamID"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -122);
			if (GUILayout.Button("z"))
			{
				StartCoroutine(IAFPILJNPJE(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
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

	private void EGEPLFGKGLI()
	{
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

	private void GGPDKCHEBAG()
	{
	}

	private void GCDLIKEDMCF()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	private IEnumerator MIGCGKLBGML(int JMMILEFMACB)
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

	private void FABMDEHEDNO()
	{
	}

	private void CFFCLAHMBAA()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void OLFFIKHJIEO()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == ".completedCount")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_Value2") && flag)
		{
			GUILayout.Label("_CurTex", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[5];
			array2[0] = "[MapsStats] Length: ";
			array2[0] = Helpers.GetStat("s");
			array2[3] = "z";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_TimeX"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button(". Possible scene loading in progress?", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("[MapEditor] Item creation successful! Published Item ID: ", 0);
			}
			if (GUILayout.Button("0.00"))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("health", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("CameraFilterPack/Distortion_ShockWave", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -8);
			if (GUILayout.Button("ItemNameBGImage"))
			{
				StartCoroutine(FNMOGPINAAJ(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("X2", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void GPNAOAKCMHC()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void NJDBPAFPIAJ()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "CameraFilterPack/3D_Scan_Scene")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_OcclusionTexture") && flag)
		{
			GUILayout.Label("_TimeX");
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[2];
			array2[0] = "Failed to 'network-remove' GameObject because it's null.";
			array2[0] = Helpers.GetStat("[");
			array2[8] = "UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("Soundtrack"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_ScreenResolution", 0);
			}
			if (GUILayout.Button(" x "))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("\\\""))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_TimeX"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 82);
			if (GUILayout.Button("InfoCanvas"))
			{
				StartCoroutine(BDHBLCMKLLM(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Red_B", new GUILayoutOption[1]))
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

	private void NEKCPLGFOFD()
	{
	}

	private void DEEPMOLMGED()
	{
	}

	private void NFEDLAOPHML()
	{
	}

	private void IBFJAOINHMK()
	{
	}

	private void Update()
	{
	}

	private IEnumerator OBOLALMEFCE(int JMMILEFMACB)
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

	private void JFHCMEAOPPC()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			if (text == "No font defined. Found font: ")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Unable to get a reward! Try again?") && flag)
		{
			GUILayout.Label("_TimeX");
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[1];
			array2[0] = "\n";
			array2[1] = Helpers.GetStat("AddEnvironmentObject");
			array2[6] = ".message";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("sounds/hit_normal"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_Angle"))
			{
				Singleton<SaveSystem>.Instance.SetInt("_SpawnHeuristic", 0);
			}
			if (GUILayout.Button("Cant send PickupItem spawn times to unknown targetPlayer."))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_Green_B", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("Image effects aren't supported on this device ({0})", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -31);
			if (GUILayout.Button("Error: I/O Failure"))
			{
				StartCoroutine(MIGCGKLBGML(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KOFAMEKHHGD()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private IEnumerator CPIJNAKOLBG(int JMMILEFMACB)
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

	private void ANCKKLFPGDI()
	{
	}

	private void NEFHGMNAPEP()
	{
	}

	private void EIDKCANPHJE()
	{
	}

	private void IPDCBNCBBEN()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		foreach (string text in array)
		{
			if (text == "roomDescription")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("IntraTime") && flag)
		{
			GUILayout.Label("LevelNameText", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical();
			object[] array2 = new object[7];
			array2[0] = "Error0";
			array2[0] = Helpers.GetStat("_Value4");
			array2[1] = "GhostPosY";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("Image effects aren't supported on this device ({0})"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("Set Satellite Trail MinVertexDistance", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Radius", 1);
			}
			if (GUILayout.Button("settings.enablehitsoundsinnormal"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_BlurVector"))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("B"))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, -98);
			if (GUILayout.Button("  |  Events Count: ", new GUILayoutOption[1]))
			{
				StartCoroutine(IKIGAFJHIIG(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("SetScale"))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private IEnumerator OOPGEFDNHGH(int JMMILEFMACB)
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

	private void LKJMIODJGCM()
	{
	}

	private void DNNFHBOOPIN()
	{
	}

	private void DKEHGPPOKEA()
	{
	}

	private IEnumerator LDAAFJMJGOL(int JMMILEFMACB)
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

	private void JFJLGJEPEAA()
	{
	}

	private IEnumerator HGOOGLPNNEC(int JMMILEFMACB)
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

	private void DCJBGIFPNAN()
	{
		GUI.skin = skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			if (text == "menu.playedsolo")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("BitsData") && flag)
		{
			GUILayout.Label("StartButton", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			object[] array2 = new object[0];
			array2[1] = "_Near";
			array2[1] = Helpers.GetStat("_Value2");
			array2[8] = "_RampTex";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("FToA"));
			GUILayout.Label(string.Concat(array2));
			if (GUILayout.Button("_EmissionGain"))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("#orderby:", 0);
			}
			if (GUILayout.Button("_AdaptionSpeed"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("|", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
			}
			JMMILEFMACB = GUILayout.TextField(JMMILEFMACB, 59);
			if (GUILayout.Button("CameraFilterPack/OldFilm_Cutting2", new GUILayoutOption[1]))
			{
				StartCoroutine(BPFDEIPEHNB(int.Parse(JMMILEFMACB)));
			}
			if (GUILayout.Button("_Blue_G", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private IEnumerator GCKDIDJBLFO(int JMMILEFMACB)
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
}
