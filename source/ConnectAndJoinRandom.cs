// ConnectAndJoinRandom
using Photon;
using UnityEngine;

public class ConnectAndJoinRandom : Photon.MonoBehaviour
{
	public bool AutoConnect = true;

	public byte Version = 1;

	private bool IDBCIKHLGKL = true;

	public void CHLAEFHCKEO()
	{
		Debug.Log("_Value");
	}

	public void OnJoinedRoom()
	{
		Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
	}

	public virtual void EDCHDNKMIIC()
	{
		Debug.Log("win");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void DKOPKPBLDHH()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	public virtual void JKAKGAKGIJM(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(".lastCheckpoint.incorrectScore" + BMDDEFBNHAL);
	}

	public virtual void JEKHFJLBNGG()
	{
		Debug.Log("_Value");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void HDPJHKKEBAP()
	{
		Debug.Log("0.00");
		PhotonNetwork.JoinRandomRoom();
	}

	public void KJIFILNIJIH()
	{
		Debug.Log("[MapEditor] Exported to ");
	}

	public virtual void FOADJANPIBI()
	{
		Debug.Log("_ChangeGreen");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void Update()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();");
			IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(Version + "." + SceneManagerHelper.ActiveSceneBuildIndex);
		}
	}

	public void LGHDAPHGGKG()
	{
		Debug.Log("menu.selectedlevelid");
	}

	public void HJBBKKKMCLH()
	{
		Debug.Log("13");
	}

	public void BDKAKHFLAKD()
	{
		Debug.Log(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.");
	}

	public virtual void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("Cause: " + BMDDEFBNHAL);
	}

	public virtual void GDDGKGCDKDP()
	{
		Debug.Log(" Message: ");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void EOGBNCKOOFC()
	{
		Debug.Log("menu.copyright");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 2
		}, null);
	}

	public virtual void FDFBJFKIAHD()
	{
		Debug.Log("_TimeX");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void CHDPOPKEINF()
	{
		Debug.Log("ConfigVersionSlider");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void OnPhotonRandomJoinFailed()
	{
		Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 4
		}, null);
	}

	public void LJBIAHLMGOO()
	{
		Debug.Log("_TimeX");
	}

	public virtual void PIFDBALMCFG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("hidden" + BMDDEFBNHAL);
	}

	public virtual void AICGHDMKIPD(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(": " + BMDDEFBNHAL);
	}

	public void ONDMIDMACBE()
	{
		Debug.Log("settings.crosshairopacity");
	}

	public virtual void DPCGDHKDHME(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_EmissionGain" + BMDDEFBNHAL);
	}

	public virtual void CEKMOLLPHOC()
	{
		Debug.Log("Set satellite beat detection sensitivity");
		PhotonNetwork.JoinRandomRoom();
	}

	public void FACGFPDFHBL()
	{
		Debug.Log("Feb");
	}

	public virtual void CPPKKMBGKAP(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_Value4" + BMDDEFBNHAL);
	}

	public virtual void DODDDMCNOKJ()
	{
		Debug.Log("_Distortion");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 7
		}, null);
	}

	public virtual void MDCFIHDPLIG()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Editor/");
			IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(Version + "Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()" + SceneManagerHelper.POHFFGEDEAF());
		}
	}

	public virtual void BDFFMKGNDJE()
	{
		Debug.Log("_ProjectToPixelMatrix");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 3
		}, null);
	}

	public virtual void IIOGBEKDFAO()
	{
		Debug.Log(". The group number should be at least 1.");
		PhotonNetwork.JoinRandomRoom();
	}

	public void JAMJOIHHLMG()
	{
		Debug.Log("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ");
	}

	public virtual void ADKHHMPFPIE()
	{
		Debug.Log("GameScene");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 6
		}, null);
	}

	public virtual void OCLFNGINGPN()
	{
		Debug.Log("Fade");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void JDJLABNKBJG()
	{
		Debug.Log("player.bluearc");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void PIHNFEGIHOM(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("No Name" + BMDDEFBNHAL);
	}

	public virtual void JKFDDNMPOJH()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	public virtual void KHLMJJNOBOF()
	{
		Debug.Log("IconFileSelector");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void FHGKIOOMMOH()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	public virtual void MECJHOJPODB()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_ScreenResolution");
			IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(Version + ".completedCount" + SceneManagerHelper.AKDJMHNDCBO());
		}
	}

	public void MBBBDIIIOFC()
	{
		Debug.Log("_Value4");
	}

	public virtual void GEHACFFGLBI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_Value4" + BMDDEFBNHAL);
	}

	public virtual void GFNEMBOAHIF()
	{
		Debug.Log("MainButton");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 2
		}, null);
	}

	public virtual void KACKAMLHICO()
	{
		Debug.Log("_UserLutParams");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void BAMLNAEDCKM()
	{
		Debug.Log("_Distortion");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 4
		}, null);
	}

	public virtual void EHCGBJDFMHG()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("y");
			IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(Version + "SingleplayerButton" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	public virtual void HMFNLECAOOI()
	{
		Debug.Log("[Up-Right-Left]");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void DMPFMJNADPE()
	{
		Debug.Log("BlockCount");
		PhotonNetwork.JoinRandomRoom();
	}

	public void CDDBANKMALP()
	{
		Debug.Log(".lastCheckpoint.powerupsScore");
	}

	public void PLEDKHBAIAA()
	{
		Debug.Log("Load Game");
	}

	public virtual void BKGPGINIGNI()
	{
		Debug.Log("_Circle");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 3
		}, null);
	}

	public virtual void BJMKOOAEMKO(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("[LevelEditorScene] Exported to " + BMDDEFBNHAL);
	}

	public virtual void LEAHIBJDMBI()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_EmissionGain");
			IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(Version + "BadgeText" + SceneManagerHelper.EEGMAAFDFFB());
		}
	}

	public virtual void OECLABNKGLA()
	{
		Debug.Log("float,0");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 0
		}, null);
	}

	public virtual void KLNNHMBIBOF(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_DiffuseColor" + BMDDEFBNHAL);
	}

	public virtual void ENPAMMGKEOP()
	{
		Debug.Log("_Value2");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void KNLFHKBNBOD()
	{
		Debug.Log("SetSpeed");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void LBJNODGBDME(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("[LevelEditorScene] Error: I/O Failure! :(" + BMDDEFBNHAL);
	}

	public virtual void OnConnectedToMaster()
	{
		Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void GHKONEJJHMI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("3d text" + BMDDEFBNHAL);
	}

	public virtual void MDMLFBLLIDG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("LivesSlider" + BMDDEFBNHAL);
	}

	public void EEKBPIMIOAF()
	{
		Debug.Log("LevelEditor/CustomEventEditor-Text");
	}

	public virtual void KNIFJMBBDBC()
	{
		Debug.Log(" is muted");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void JJLCCMBFHDF()
	{
		Debug.Log("_ScreenResolution");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 1
		}, null);
	}

	public virtual void Start()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	public virtual void HDMDKOKOOJC()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	public virtual void MOBFDKFDHGN()
	{
		Debug.Log("CameraFilterPack/Drawing_Paper");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void BMODOIJGIOO()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_TimeX");
			IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(Version + "settings.showHP" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	public virtual void CJLPBOCGBLF(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("y" + BMDDEFBNHAL);
	}

	public void IMPGHNBKJAE()
	{
		Debug.Log(":\n");
	}

	public virtual void CGHHMLOOHCI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("Default UI Material" + BMDDEFBNHAL);
	}

	public virtual void PKGJJFIFLII()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_Value7");
			IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(Version + "shader.future" + SceneManagerHelper.DFNPAKFIHLA());
		}
	}

	public virtual void LFNJEGMCDOP()
	{
		Debug.Log("SUCCESS! Item submitted! :D :D :D");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void CCMEIDEFLPA()
	{
		Debug.Log("_Green_R");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void CDLHKKEOADJ()
	{
		Debug.Log("_Value5");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void FMJEFGEDCDC(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(".completed" + BMDDEFBNHAL);
	}

	public virtual void OnJoinedLobby()
	{
		Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void HIPEHGNBJMN()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	public virtual void EBPNGJOJALB()
	{
		Debug.Log("OnRelease");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void LDDKCCMHMIC()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_Value13");
			IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(Version + "DPADHOR" + SceneManagerHelper.EEGMAAFDFFB());
		}
	}

	public virtual void NPKFIAGKGAN()
	{
		Debug.Log("connect");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void AIJGAJIOJDJ()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log(" not exist");
			IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(Version + "[DiscordController] Shutdown" + SceneManagerHelper.POHFFGEDEAF());
		}
	}

	public virtual void CLOFNBEGCJO()
	{
		Debug.Log("[NetworkManager] Connection failed: ");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void BGDPIHMAACO()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	public virtual void AKAFCLCCHFG()
	{
		Debug.Log("[Left]");
		PhotonNetwork.JoinRandomRoom();
	}

	public void OLFOHNNDHMK()
	{
		Debug.Log("_Noise");
	}

	public virtual void PFCHOPCKCCL()
	{
		Debug.Log(".lastCheckpoint.checkpointsUsed");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void PKPHEOCKKJJ()
	{
		Debug.Log("MenuScene");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void OKLAJINHPAN()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	public virtual void LGHCJCFHEMF()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	public virtual void NEKBGCKIBIL()
	{
		Debug.Log("_PositionY");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void POJFHDFJOPE()
	{
		if (IDBCIKHLGKL && AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("_WorldToCameraMatrix");
			IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(Version + "float,1.5" + SceneManagerHelper.HDHPKIDODDJ());
		}
	}

	public void NAMDCKFBFFN()
	{
		Debug.Log("mapselector.filter.rateduponly");
	}

	public virtual void KBEHDPKDBBO()
	{
		Debug.Log("0 - default, 1 - left, 2 - right");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void FFJDANGJLEM()
	{
		Debug.Log(" Remote called.");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void MKHEAFHHHMC()
	{
		Debug.Log("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?");
		PhotonNetwork.JoinRandomRoom();
	}

	public virtual void AKIDKDMNEME()
	{
		Debug.Log("MapEnd");
		PhotonNetwork.JoinRandomRoom();
	}

	public void DIHHOKDGMLA()
	{
		Debug.Log("_SSAO");
	}
}
