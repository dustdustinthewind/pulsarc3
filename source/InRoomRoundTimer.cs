// InRoomRoundTimer
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomRoundTimer : MonoBehaviour
{
	public int SecondsPerTurn = 5;

	public double StartTime;

	public Rect TextPos = new Rect(0f, 80f, 150f, 300f);

	private bool DBHJOONLNJE;

	private const string JJDHAIONGKL = "st";

	private void KCDOMIJBFLL()
	{
		if (DBHJOONLNJE)
		{
			LEPICHKBBLE();
		}
	}

	public void KJMHKHDMKIE()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_Distance", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("CameraFilterPack/FX_Hypno", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Particles/Additive", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("Particles/Additive", new GUILayoutOption[1]))
		{
			HAHDPBKLFAF();
		}
		GUILayout.EndArea();
	}

	public void EAABKPJPPHL()
	{
		if (PhotonNetwork.isMasterClient)
		{
			HAHDPBKLFAF();
		}
		else
		{
			Debug.Log("original.tutorial" + PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_FadeDistance"));
		}
	}

	private void HPNNCNNFMGK()
	{
		if (DBHJOONLNJE)
		{
			OEHKIMJHFEB();
		}
	}

	public void FNEAEFLHLDL(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("yyyy-MM-dd HH:mm:ss"))
		{
			StartTime = (double)DGIHEPAHAJK["SetSpeed"];
		}
	}

	public void JAFHOIGANHK(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.DMANNHAPJCP().ContainsKey("steamid"))
		{
			Debug.Log("#ok");
			NMAAAONHNOI();
		}
	}

	public void JDPOCODDFCH(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.DMANNHAPJCP().ContainsKey("B"))
		{
			Debug.Log("menutheme");
			CPIKLIPIDIA();
		}
	}

	private void EGEGNHLODAA()
	{
		if (DBHJOONLNJE)
		{
			BGBKEKDPEIJ();
		}
	}

	public void MAJDGGGEDLH()
	{
		if (PhotonNetwork.isMasterClient)
		{
			NMAAAONHNOI();
		}
		else
		{
			Debug.Log("Add Environment Object" + PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_Value"));
		}
	}

	private void HKGEBAMCPBK()
	{
		if (PhotonNetwork.time < 678.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["ItemTemplate"] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable);
	}

	public void BICCGLOBIOD(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("MusicFileSelector"))
		{
			StartTime = (double)DGIHEPAHAJK["ConfigVersionSlider"];
		}
	}

	private void PBMPKIJEKAF()
	{
		if (PhotonNetwork.time < 230.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["DPADHOR"] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
	}

	public void CKJNCMIAFGD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AFPDIDAHHGA();
		}
		else
		{
			Debug.Log("id" + PhotonNetwork.room.customProperties.ContainsKey("ResetButton"));
		}
	}

	private void JAJADPJGDHC()
	{
		if (PhotonNetwork.time < 564.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["_Visualize"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	private void LCJHDLKJEOM()
	{
		if (DBHJOONLNJE)
		{
			PJNINBIDHDD();
		}
	}

	private void IDIIELPAMCJ()
	{
		if (DBHJOONLNJE)
		{
			ICCOKJOBGBM();
		}
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("st"))
		{
			Debug.Log("The new master starts a new round, cause we didn't start yet.");
			AEMCMOBKOJK();
		}
	}

	public void INOHOKLPACD(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("g"))
		{
			StartTime = (double)DGIHEPAHAJK["_Value3"];
		}
	}

	private void LEPICHKBBLE()
	{
		if (PhotonNetwork.time < 666.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["_Intensity"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	public void PIJBLFBJMBG()
	{
		if (PhotonNetwork.isMasterClient)
		{
			CJHIGGANJIL();
		}
		else
		{
			Debug.Log("map.data" + PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_BlurFilterDistance"));
		}
	}

	public void AAPOKGKIGEE(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("File not found: {0}"))
		{
			StartTime = (double)DGIHEPAHAJK["_Value2"];
		}
	}

	private void LEAHIBJDMBI()
	{
		if (DBHJOONLNJE)
		{
			PJNINBIDHDD();
		}
	}

	private void CJHIGGANJIL()
	{
		if (PhotonNetwork.time < 1.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["#rt"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	public void APCENGAAHMC()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("RecordButton", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format(".lastCheckpoint.powerupsScore", num2));
		GUILayout.Label(string.Format("mapselector.filter.subscribedonly", num3));
		if (GUILayout.Button("maps.", new GUILayoutOption[1]))
		{
			LEPICHKBBLE();
		}
		GUILayout.EndArea();
	}

	public void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AEMCMOBKOJK();
		}
		else
		{
			Debug.Log("StartTime already set: " + PhotonNetwork.room.customProperties.ContainsKey("st"));
		}
	}

	public void KACLODMCOMP(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("_Value2"))
		{
			Debug.Log("colorB");
			LEPICHKBBLE();
		}
	}

	private void NMAAAONHNOI()
	{
		if (PhotonNetwork.time < 601.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable[".completedCount"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	private void AEIJFLJEABG()
	{
		if (DBHJOONLNJE)
		{
			OEHKIMJHFEB();
		}
	}

	private void KIEJKBNBHMD()
	{
		if (DBHJOONLNJE)
		{
			PJNINBIDHDD();
		}
	}

	public void FGPJENGMGLD(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("_V"))
		{
			Debug.Log("Run a command for data system");
			CPIKLIPIDIA();
		}
	}

	public void FFCJHIBEBEL(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_Params"))
		{
			Debug.Log("_ScreenResolution");
			LEPICHKBBLE();
		}
	}

	public void DGGKEBEFPBH(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("BitsData"))
		{
			Debug.Log("(master)");
			HKGEBAMCPBK();
		}
	}

	public void NEMLLIAHOBM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("ticket"))
		{
			StartTime = (double)DGIHEPAHAJK["Keypad"];
		}
	}

	public void MCLEHHPHHLB(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_StretchWidth"))
		{
			StartTime = (double)DGIHEPAHAJK["_Value4"];
		}
	}

	private void BMODOIJGIOO()
	{
		if (DBHJOONLNJE)
		{
			PBMPKIJEKAF();
		}
	}

	private void MAOCOEGAFND()
	{
		if (DBHJOONLNJE)
		{
			NMAAAONHNOI();
		}
	}

	public void JEFLJIPAOKG(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_ScreenResolution"))
		{
			Debug.Log("_EmissionGain");
			CJHIGGANJIL();
		}
	}

	private void Update()
	{
		if (DBHJOONLNJE)
		{
			AEMCMOBKOJK();
		}
	}

	private void CPIKLIPIDIA()
	{
		if (PhotonNetwork.time < 1888.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["#kicked"] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable);
	}

	private void AEMCMOBKOJK()
	{
		if (PhotonNetwork.time < 9.9999997473787516E-05)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["st"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void MPOCGBCPFJC(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("CameraMovementSlider"))
		{
			Debug.Log("_ScreenResolution");
			JAJADPJGDHC();
		}
	}

	public void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("st"))
		{
			StartTime = (double)DGIHEPAHAJK["st"];
		}
	}

	private void OEHKIMJHFEB()
	{
		if (PhotonNetwork.time < 1519.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["MainThreadExecuter"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void LPLDDGOEEIJ(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("UpdateNewsTileStart"))
		{
			Debug.Log("Result for ");
			HKGEBAMCPBK();
		}
	}

	private void ICCOKJOBGBM()
	{
		if (PhotonNetwork.time < 907.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages."] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	private void JAMOBLNGOAJ()
	{
		if (PhotonNetwork.time < 58.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["kick"] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
	}

	public void PCABPJAANFH()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("UNDISTORT", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("w", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("quantity", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("Data/Skins/", new GUILayoutOption[1]))
		{
			PBMPKIJEKAF();
		}
		GUILayout.EndArea();
	}

	public void PELNCDEODGD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AEMCMOBKOJK();
		}
		else
		{
			Debug.Log("[PlayerController] " + PhotonNetwork.room.customProperties.ContainsKey("[Down]"));
		}
	}

	public void BJGFLOHDJJJ(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_ForceYSwap"))
		{
			StartTime = (double)DGIHEPAHAJK["SetSpeed"];
		}
	}

	private void HDDECCMEJKA()
	{
		if (DBHJOONLNJE)
		{
			BGBKEKDPEIJ();
		}
	}

	private void MMBPLGGLPDB()
	{
		if (DBHJOONLNJE)
		{
			AFPDIDAHHGA();
		}
	}

	public void PLEDKHBAIAA()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AFPDIDAHHGA();
		}
		else
		{
			Debug.Log("Scene" + PhotonNetwork.room.customProperties.ContainsKey("_FixDistance"));
		}
	}

	public void LKLDBEBLMBI(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("achievements.21.completed."))
		{
			Debug.Log("Parameter levelId must be int or string!");
			CPIKLIPIDIA();
		}
	}

	private void HAHDPBKLFAF()
	{
		if (PhotonNetwork.time < 714.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["_MainTex2"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	public void IICHFOLDKGG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_DX11NoiseTime"))
		{
			StartTime = (double)DGIHEPAHAJK["_SizeY"];
		}
	}

	public void FADMAHGLBKD(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("menuVolume"))
		{
			Debug.Log("unsubscribemap");
			PJNINBIDHDD();
		}
	}

	public void HBNHHPJNNIP()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("#ok", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format(" not exist", num2));
		GUILayout.Label(string.Format("LeaderboardsButton", num3));
		if (GUILayout.Button("EnvironmentSlider"))
		{
			PBMPKIJEKAF();
		}
		GUILayout.EndArea();
	}

	private void BGBKEKDPEIJ()
	{
		if (PhotonNetwork.time < 491.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["[PlayerBase] Loaded environment: "] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void OnGUI()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label($"elapsed: {num:0.000}");
		GUILayout.Label($"remaining: {num2:0.000}");
		GUILayout.Label($"turn: {num3:0}");
		if (GUILayout.Button("new round"))
		{
			AEMCMOBKOJK();
		}
		GUILayout.EndArea();
	}

	private void PJNINBIDHDD()
	{
		if (PhotonNetwork.time < 1950.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["GroupNameText"] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
	}

	public void PHCOGMJPGNN(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_Fade"))
		{
			Debug.Log("stats on");
			ICCOKJOBGBM();
		}
	}

	public void EAELMLKKFOL()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("maps.", num));
		GUILayout.Label(string.Format("ItemNameText", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Drop_Far", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("DataText", new GUILayoutOption[1]))
		{
			BGBKEKDPEIJ();
		}
		GUILayout.EndArea();
	}

	private void GHILDCBCDJI()
	{
		if (DBHJOONLNJE)
		{
			NMAAAONHNOI();
		}
	}

	private void AFPDIDAHHGA()
	{
		if (PhotonNetwork.time < 1287.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["\\\""] = PhotonNetwork.time;
		PhotonNetwork.room.AFADNAIGHIG(hashtable);
	}

	public void DENKOAKNPNB()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("Ignored PU RPC, cause item is inactive. ", num));
		GUILayout.Label(string.Format("MenuVolumeSlider", num2));
		GUILayout.Label(string.Format(" ", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("ChatInput", new GUILayoutOption[1]))
		{
			HAHDPBKLFAF();
		}
		GUILayout.EndArea();
	}

	private void EHCGBJDFMHG()
	{
		if (DBHJOONLNJE)
		{
			JAMOBLNGOAJ();
		}
	}

	public void LHACGKFCAMG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_TimeX"))
		{
			StartTime = (double)DGIHEPAHAJK["_Axis"];
		}
	}

	public void BDKAKHFLAKD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			CPIKLIPIDIA();
		}
		else
		{
			Debug.Log("Added checkpoint" + PhotonNetwork.room.DMANNHAPJCP().ContainsKey("LevelURLInputField"));
		}
	}
}
