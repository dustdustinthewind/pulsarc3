// PhotonNetwork
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class PhotonNetwork
{
	public delegate void EventCallback(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP);

	public const string versionPUN = "1.87";

	internal static readonly PhotonHandler IBABLIBBKAG;

	internal static BNGIGHBHPEH JNJJAMNLOHA;

	public static readonly int MAX_VIEW_IDS;

	internal const string MJJENBIFDOH = "PhotonServerSettings";

	public static ServerSettings PhotonServerSettings;

	public static bool InstantiateInRoomOnly;

	public static PhotonLogLevel logLevel;

	public static float precisionForVectorSynchronization;

	public static float precisionForQuaternionSynchronization;

	public static float precisionForFloatSynchronization;

	public static bool UseRpcMonoBehaviourCache;

	public static bool UsePrefabCache;

	public static Dictionary<string, GameObject> PrefabCache;

	public static HashSet<GameObject> SendMonoMessageTargets;

	public static Type SendMonoMessageTargetType;

	public static bool StartRpcsAsCoroutine;

	private static bool DKPLFGHOICJ;

	private static Room DNGILIFEKBM;

	[Obsolete("Used for compatibility with Unity networking only.")]
	public static int maxConnections;

	private static bool KLLBMBCNMGO;

	private static bool EBIOGPLPINH;

	private static int BDPJPHDKAOM;

	private static int GMHJFCMGKCB;

	private static bool LGLLFPCCGBM;

	private static bool JLDPEKGBJGO;

	private static Stopwatch DKNFDIMGLKG;

	public static float BackgroundTimeout;

	public static EventCallback OnEventCall;

	internal static int FDMEIPEKMHC;

	internal static int JIOIILCHMJL;

	internal static List<int> JMCPHFPJEJC;

	public static string gameVersion { get; set; }

	public static string ServerAddress => (JNJJAMNLOHA == null) ? "<not connected>" : JNJJAMNLOHA.ServerAddress;

	public static CloudRegionCode CloudRegion => (JNJJAMNLOHA == null || !connected || Server == ServerConnection.NameServer) ? CloudRegionCode.none : JNJJAMNLOHA.CloudRegion;

	public static bool connected
	{
		get
		{
			if (offlineMode)
			{
				return true;
			}
			if (JNJJAMNLOHA == null)
			{
				return false;
			}
			return !JNJJAMNLOHA.IsInitialConnect && JNJJAMNLOHA.State != ClientState.PeerCreated && JNJJAMNLOHA.State != ClientState.Disconnected && JNJJAMNLOHA.State != ClientState.Disconnecting && JNJJAMNLOHA.State != ClientState.ConnectingToNameServer;
		}
	}

	public static bool connecting => JNJJAMNLOHA.IsInitialConnect && !offlineMode;

	public static bool connectedAndReady
	{
		get
		{
			if (!connected)
			{
				return false;
			}
			if (offlineMode)
			{
				return true;
			}
			switch (connectionStateDetailed)
			{
			case ClientState.PeerCreated:
			case ClientState.ConnectingToGameserver:
			case ClientState.Joining:
			case ClientState.ConnectingToMasterserver:
			case ClientState.Disconnecting:
			case ClientState.Disconnected:
			case ClientState.ConnectingToNameServer:
			case ClientState.Authenticating:
				return false;
			default:
				return true;
			}
		}
	}

	public static ConnectionState connectionState
	{
		get
		{
			if (offlineMode)
			{
				return ConnectionState.Connected;
			}
			if (JNJJAMNLOHA == null)
			{
				return ConnectionState.Disconnected;
			}
			switch (JNJJAMNLOHA.PeerState)
			{
			case PeerStateValue.Disconnected:
				return ConnectionState.Disconnected;
			case PeerStateValue.Connecting:
				return ConnectionState.Connecting;
			case PeerStateValue.Connected:
				return ConnectionState.Connected;
			case PeerStateValue.Disconnecting:
				return ConnectionState.Disconnecting;
			case PeerStateValue.InitializingApplication:
				return ConnectionState.InitializingApplication;
			default:
				return ConnectionState.Disconnected;
			}
		}
	}

	public static ClientState connectionStateDetailed
	{
		get
		{
			if (offlineMode)
			{
				return (DNGILIFEKBM == null) ? ClientState.ConnectedToMaster : ClientState.Joined;
			}
			if (JNJJAMNLOHA == null)
			{
				return ClientState.Disconnected;
			}
			return JNJJAMNLOHA.State;
		}
	}

	public static ServerConnection Server => (JNJJAMNLOHA == null) ? ServerConnection.NameServer : JNJJAMNLOHA.EHALCLFLGJF;

	public static AuthenticationValues AuthValues
	{
		get
		{
			return (JNJJAMNLOHA == null) ? null : JNJJAMNLOHA.AuthValues;
		}
		set
		{
			if (JNJJAMNLOHA != null)
			{
				JNJJAMNLOHA.AuthValues = value;
			}
		}
	}

	public static Room room
	{
		get
		{
			if (DKPLFGHOICJ)
			{
				return DNGILIFEKBM;
			}
			return JNJJAMNLOHA.CurrentRoom;
		}
	}

	public static PhotonPlayer player
	{
		get
		{
			if (JNJJAMNLOHA == null)
			{
				return null;
			}
			return JNJJAMNLOHA.LocalPlayer;
		}
	}

	public static PhotonPlayer masterClient
	{
		get
		{
			if (offlineMode)
			{
				return player;
			}
			if (JNJJAMNLOHA == null)
			{
				return null;
			}
			return JNJJAMNLOHA.ICMGDHDNIJD(JNJJAMNLOHA.mMasterClientId);
		}
	}

	public static string playerName
	{
		get
		{
			return JNJJAMNLOHA.PlayerName;
		}
		set
		{
			JNJJAMNLOHA.PlayerName = value;
		}
	}

	public static PhotonPlayer[] playerList
	{
		get
		{
			if (JNJJAMNLOHA == null)
			{
				return new PhotonPlayer[0];
			}
			return JNJJAMNLOHA.mPlayerListCopy;
		}
	}

	public static PhotonPlayer[] otherPlayers
	{
		get
		{
			if (JNJJAMNLOHA == null)
			{
				return new PhotonPlayer[0];
			}
			return JNJJAMNLOHA.mOtherPlayerListCopy;
		}
	}

	public static List<FriendInfo> Friends { get; internal set; }

	public static int FriendsListAge => (JNJJAMNLOHA != null) ? JNJJAMNLOHA.LALFOLKNJJD : 0;

	public static IPunPrefabPool PrefabPool
	{
		get
		{
			return JNJJAMNLOHA.EGNHNBODKHP;
		}
		set
		{
			JNJJAMNLOHA.EGNHNBODKHP = value;
		}
	}

	public static bool offlineMode
	{
		get
		{
			return DKPLFGHOICJ;
		}
		set
		{
			if (value == DKPLFGHOICJ)
			{
				return;
			}
			if (value && connected)
			{
				UnityEngine.Debug.LogError("Can't start OFFLINE mode while connected!");
				return;
			}
			if (JNJJAMNLOHA.PeerState != 0)
			{
				JNJJAMNLOHA.Disconnect();
			}
			DKPLFGHOICJ = value;
			if (DKPLFGHOICJ)
			{
				JNJJAMNLOHA.ChangeLocalID(-1);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToMaster);
			}
			else
			{
				DNGILIFEKBM = null;
				JNJJAMNLOHA.ChangeLocalID(-1);
			}
		}
	}

	public static bool automaticallySyncScene
	{
		get
		{
			return KLLBMBCNMGO;
		}
		set
		{
			KLLBMBCNMGO = value;
			if (KLLBMBCNMGO && room != null)
			{
				JNJJAMNLOHA.DMCKEABNFPJ();
			}
		}
	}

	public static bool autoCleanUpPlayerObjects
	{
		get
		{
			return EBIOGPLPINH;
		}
		set
		{
			if (room != null)
			{
				UnityEngine.Debug.LogError("Setting autoCleanUpPlayerObjects while in a room is not supported.");
			}
			else
			{
				EBIOGPLPINH = value;
			}
		}
	}

	public static bool autoJoinLobby
	{
		get
		{
			return PhotonServerSettings.JoinLobby;
		}
		set
		{
			PhotonServerSettings.JoinLobby = value;
		}
	}

	public static bool EnableLobbyStatistics
	{
		get
		{
			return PhotonServerSettings.EnableLobbyStatistics;
		}
		set
		{
			PhotonServerSettings.EnableLobbyStatistics = value;
		}
	}

	public static List<TypedLobbyInfo> LobbyStatistics
	{
		get
		{
			return JNJJAMNLOHA.HOBLKOKPJOE;
		}
		private set
		{
			JNJJAMNLOHA.HOBLKOKPJOE = value;
		}
	}

	public static bool insideLobby => JNJJAMNLOHA.insideLobby;

	public static TypedLobby lobby
	{
		get
		{
			return JNJJAMNLOHA.lobby;
		}
		set
		{
			JNJJAMNLOHA.lobby = value;
		}
	}

	public static int sendRate
	{
		get
		{
			return 1000 / BDPJPHDKAOM;
		}
		set
		{
			BDPJPHDKAOM = 1000 / value;
			if (IBABLIBBKAG != null)
			{
				IBABLIBBKAG.updateInterval = BDPJPHDKAOM;
			}
			if (value < sendRateOnSerialize)
			{
				sendRateOnSerialize = value;
			}
		}
	}

	public static int sendRateOnSerialize
	{
		get
		{
			return 1000 / GMHJFCMGKCB;
		}
		set
		{
			if (value > sendRate)
			{
				UnityEngine.Debug.LogError("Error: Can not set the OnSerialize rate higher than the overall SendRate.");
				value = sendRate;
			}
			GMHJFCMGKCB = 1000 / value;
			if (IBABLIBBKAG != null)
			{
				IBABLIBBKAG.updateIntervalOnSerialize = GMHJFCMGKCB;
			}
		}
	}

	public static bool isMessageQueueRunning
	{
		get
		{
			return LGLLFPCCGBM;
		}
		set
		{
			if (value)
			{
				PhotonHandler.StartFallbackSendAckThread();
			}
			JNJJAMNLOHA.IsSendingOnlyAcks = !value;
			LGLLFPCCGBM = value;
		}
	}

	public static int unreliableCommandsLimit
	{
		get
		{
			return JNJJAMNLOHA.LimitOfUnreliableCommands;
		}
		set
		{
			JNJJAMNLOHA.LimitOfUnreliableCommands = value;
		}
	}

	public static double time
	{
		get
		{
			uint serverTimestamp = (uint)ServerTimestamp;
			double num = serverTimestamp;
			return num / 1000.0;
		}
	}

	public static int ServerTimestamp
	{
		get
		{
			if (offlineMode)
			{
				if (JLDPEKGBJGO && DKNFDIMGLKG != null && DKNFDIMGLKG.IsRunning)
				{
					return (int)DKNFDIMGLKG.ElapsedMilliseconds;
				}
				return Environment.TickCount;
			}
			return JNJJAMNLOHA.ServerTimeInMilliSeconds;
		}
	}

	public static bool isMasterClient
	{
		get
		{
			if (offlineMode)
			{
				return true;
			}
			return JNJJAMNLOHA.mMasterClientId == player.ID;
		}
	}

	public static bool inRoom => connectionStateDetailed == ClientState.Joined;

	public static bool isNonMasterClientInRoom => !isMasterClient && room != null;

	public static int countOfPlayersOnMaster => JNJJAMNLOHA.PlayersOnMasterCount;

	public static int countOfPlayersInRooms => JNJJAMNLOHA.PlayersInRoomsCount;

	public static int countOfPlayers => JNJJAMNLOHA.PlayersInRoomsCount + JNJJAMNLOHA.PlayersOnMasterCount;

	public static int countOfRooms => JNJJAMNLOHA.RoomsCount;

	public static bool NetworkStatisticsEnabled
	{
		get
		{
			return JNJJAMNLOHA.TrafficStatsEnabled;
		}
		set
		{
			JNJJAMNLOHA.TrafficStatsEnabled = value;
		}
	}

	public static int ResentReliableCommands => JNJJAMNLOHA.ResentReliableCommands;

	public static bool CrcCheckEnabled
	{
		get
		{
			return JNJJAMNLOHA.CrcEnabled;
		}
		set
		{
			if (!connected && !connecting)
			{
				JNJJAMNLOHA.CrcEnabled = value;
			}
			else
			{
				UnityEngine.Debug.Log("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays " + JNJJAMNLOHA.CrcEnabled);
			}
		}
	}

	public static int PacketLossByCrcCheck => JNJJAMNLOHA.PacketLossByCrc;

	public static int MaxResendsBeforeDisconnect
	{
		get
		{
			return JNJJAMNLOHA.SentCountAllowance;
		}
		set
		{
			if (value < 3)
			{
				value = 3;
			}
			if (value > 10)
			{
				value = 10;
			}
			JNJJAMNLOHA.SentCountAllowance = value;
		}
	}

	public static int QuickResends
	{
		get
		{
			return JNJJAMNLOHA.QuickResendAttempts;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 3)
			{
				value = 3;
			}
			JNJJAMNLOHA.QuickResendAttempts = (byte)value;
		}
	}

	static PhotonNetwork()
	{
		MAX_VIEW_IDS = 1000;
		PhotonServerSettings = (ServerSettings)Resources.Load("PhotonServerSettings", typeof(ServerSettings));
		InstantiateInRoomOnly = true;
		logLevel = PhotonLogLevel.ErrorsOnly;
		precisionForVectorSynchronization = 9.9E-05f;
		precisionForQuaternionSynchronization = 1f;
		precisionForFloatSynchronization = 0.01f;
		UsePrefabCache = true;
		PrefabCache = new Dictionary<string, GameObject>();
		SendMonoMessageTargetType = typeof(MonoBehaviour);
		StartRpcsAsCoroutine = true;
		DKPLFGHOICJ = false;
		DNGILIFEKBM = null;
		KLLBMBCNMGO = false;
		EBIOGPLPINH = true;
		BDPJPHDKAOM = 50;
		GMHJFCMGKCB = 100;
		LGLLFPCCGBM = true;
		JLDPEKGBJGO = false;
		BackgroundTimeout = 60f;
		FDMEIPEKMHC = 0;
		JIOIILCHMJL = 0;
		JMCPHFPJEJC = new List<int>();
		if (PhotonServerSettings != null)
		{
			Application.runInBackground = PhotonServerSettings.RunInBackground;
		}
		GameObject gameObject = new GameObject();
		IBABLIBBKAG = gameObject.AddComponent<PhotonHandler>();
		gameObject.name = "PhotonMono";
		gameObject.hideFlags = HideFlags.HideInHierarchy;
		ConnectionProtocol protocol = PhotonServerSettings.Protocol;
		JNJJAMNLOHA = new BNGIGHBHPEH(string.Empty, protocol);
		JNJJAMNLOHA.QuickResendAttempts = 2;
		JNJJAMNLOHA.SentCountAllowance = 7;
		if (JLDPEKGBJGO)
		{
			UnityEngine.Debug.Log("Using Stopwatch as precision timer for PUN.");
			DKNFDIMGLKG = new Stopwatch();
			DKNFDIMGLKG.Start();
			JNJJAMNLOHA.LocalMsTimestampDelegate = () => (int)DKNFDIMGLKG.ElapsedMilliseconds;
		}
		GOLJCGMCKMG.FJPBNMBIOHG();
	}

	public static void SwitchToProtocol(ConnectionProtocol EMACCDOCOFM)
	{
		JNJJAMNLOHA.TransportProtocol = EMACCDOCOFM;
	}

	public static bool ConnectUsingSettings(string MHMPNKGMNMJ)
	{
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.NotSet)
		{
			UnityEngine.Debug.LogError("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().");
			return false;
		}
		if (logLevel == PhotonLogLevel.ErrorsOnly)
		{
			logLevel = PhotonServerSettings.PunLogging;
		}
		if (JNJJAMNLOHA.DebugOut == DebugLevel.ERROR)
		{
			JNJJAMNLOHA.DebugOut = PhotonServerSettings.NetworkLogging;
		}
		SwitchToProtocol(PhotonServerSettings.Protocol);
		JNJJAMNLOHA.SetApp(PhotonServerSettings.AppID, MHMPNKGMNMJ);
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			offlineMode = true;
			return true;
		}
		if (offlineMode)
		{
			UnityEngine.Debug.LogWarning("ConnectUsingSettings() disabled the offline mode. No longer offline.");
		}
		offlineMode = false;
		isMessageQueueRunning = true;
		JNJJAMNLOHA.IsInitialConnect = true;
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.SelfHosted)
		{
			JNJJAMNLOHA.IsUsingNameServer = false;
			JNJJAMNLOHA.MasterServerAddress = ((PhotonServerSettings.ServerPort != 0) ? (PhotonServerSettings.ServerAddress + ":" + PhotonServerSettings.ServerPort) : PhotonServerSettings.ServerAddress);
			return JNJJAMNLOHA.Connect(JNJJAMNLOHA.MasterServerAddress, ServerConnection.MasterServer);
		}
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion)
		{
			return ConnectToBestCloudServer(MHMPNKGMNMJ);
		}
		return JNJJAMNLOHA.ConnectToRegionMaster(PhotonServerSettings.PreferredRegion);
	}

	public static bool ConnectToMaster(string OALFNANFDLI, int EFCMLJHKDEL, string KCJNNPJCECD, string MHMPNKGMNMJ)
	{
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (offlineMode)
		{
			offlineMode = false;
			UnityEngine.Debug.LogWarning("ConnectToMaster() disabled the offline mode. No longer offline.");
		}
		if (!isMessageQueueRunning)
		{
			isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		JNJJAMNLOHA.SetApp(KCJNNPJCECD, MHMPNKGMNMJ);
		JNJJAMNLOHA.IsUsingNameServer = false;
		JNJJAMNLOHA.IsInitialConnect = true;
		JNJJAMNLOHA.MasterServerAddress = ((EFCMLJHKDEL != 0) ? (OALFNANFDLI + ":" + EFCMLJHKDEL) : OALFNANFDLI);
		return JNJJAMNLOHA.Connect(JNJJAMNLOHA.MasterServerAddress, ServerConnection.MasterServer);
	}

	public static bool Reconnect()
	{
		if (string.IsNullOrEmpty(JNJJAMNLOHA.MasterServerAddress))
		{
			UnityEngine.Debug.LogWarning("Reconnect() failed. It seems the client wasn't connected before?! Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (offlineMode)
		{
			offlineMode = false;
			UnityEngine.Debug.LogWarning("Reconnect() disabled the offline mode. No longer offline.");
		}
		if (!isMessageQueueRunning)
		{
			isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		JNJJAMNLOHA.IsUsingNameServer = false;
		JNJJAMNLOHA.IsInitialConnect = false;
		return JNJJAMNLOHA.ReconnectToMaster();
	}

	public static bool ReconnectAndRejoin()
	{
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (offlineMode)
		{
			offlineMode = false;
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() disabled the offline mode. No longer offline.");
		}
		if (string.IsNullOrEmpty(JNJJAMNLOHA.GameServerAddress))
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).");
			return false;
		}
		if (JNJJAMNLOHA.AJFMHFLGCFN == null)
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.");
			return false;
		}
		if (!isMessageQueueRunning)
		{
			isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		JNJJAMNLOHA.IsUsingNameServer = false;
		JNJJAMNLOHA.IsInitialConnect = false;
		return JNJJAMNLOHA.ReconnectAndRejoin();
	}

	public static bool ConnectToBestCloudServer(string MHMPNKGMNMJ)
	{
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			return ConnectUsingSettings(MHMPNKGMNMJ);
		}
		JNJJAMNLOHA.IsInitialConnect = true;
		JNJJAMNLOHA.SetApp(PhotonServerSettings.AppID, MHMPNKGMNMJ);
		CloudRegionCode cloudRegionCode = PhotonHandler.IFAEAEOAJDL;
		if (cloudRegionCode != CloudRegionCode.none)
		{
			UnityEngine.Debug.Log("Best region found in PlayerPrefs. Connecting to: " + cloudRegionCode);
			return JNJJAMNLOHA.ConnectToRegionMaster(cloudRegionCode);
		}
		return JNJJAMNLOHA.ConnectToNameServer();
	}

	public static bool ConnectToRegion(CloudRegionCode LPCNAHJGAFK, string MHMPNKGMNMJ)
	{
		if (JNJJAMNLOHA.PeerState != 0)
		{
			UnityEngine.Debug.LogWarning("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: " + JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			return ConnectUsingSettings(MHMPNKGMNMJ);
		}
		JNJJAMNLOHA.IsInitialConnect = true;
		JNJJAMNLOHA.SetApp(PhotonServerSettings.AppID, MHMPNKGMNMJ);
		if (LPCNAHJGAFK != CloudRegionCode.none)
		{
			UnityEngine.Debug.Log("ConnectToRegion: " + LPCNAHJGAFK);
			return JNJJAMNLOHA.ConnectToRegionMaster(LPCNAHJGAFK);
		}
		return false;
	}

	public static void OverrideBestCloudServer(CloudRegionCode LPCNAHJGAFK)
	{
		PhotonHandler.IFAEAEOAJDL = LPCNAHJGAFK;
	}

	public static void RefreshCloudServerRating()
	{
		throw new NotImplementedException("not available at the moment");
	}

	public static void NetworkStatisticsReset()
	{
		JNJJAMNLOHA.TrafficStatsReset();
	}

	public static string NetworkStatisticsToString()
	{
		if (JNJJAMNLOHA == null || offlineMode)
		{
			return "Offline or in OfflineMode. No VitalStats available.";
		}
		return JNJJAMNLOHA.VitalStatsToString(false);
	}

	[Obsolete("Used for compatibility with Unity networking only. Encryption is automatically initialized while connecting.")]
	public static void InitializeSecurity()
	{
	}

	private static bool OEOOJCDIDEM()
	{
		if (connected)
		{
			return true;
		}
		UnityEngine.Debug.LogError("Cannot send messages when not connected. Either connect to Photon OR use offline mode!");
		return false;
	}

	public static void Disconnect()
	{
		if (offlineMode)
		{
			offlineMode = false;
			DNGILIFEKBM = null;
			JNJJAMNLOHA.State = ClientState.Disconnecting;
			JNJJAMNLOHA.OnStatusChanged(StatusCode.Disconnect);
		}
		else if (JNJJAMNLOHA != null)
		{
			JNJJAMNLOHA.Disconnect();
		}
	}

	public static bool FindFriends(string[] MIMEHFLKIIG)
	{
		if (JNJJAMNLOHA == null || DKPLFGHOICJ)
		{
			return false;
		}
		return JNJJAMNLOHA.OpFindFriends(MIMEHFLKIIG);
	}

	public static bool CreateRoom(string IOJPMCOBHEJ)
	{
		return CreateRoom(IOJPMCOBHEJ, null, null, null);
	}

	public static bool CreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB)
	{
		return CreateRoom(IOJPMCOBHEJ, DPODHCMGCPF, LEPNBLFEINB, null);
	}

	public static bool CreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB, string[] MMIMLMLKCBA)
	{
		if (offlineMode)
		{
			if (DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("CreateRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			KFDFMLDBHFM(IOJPMCOBHEJ, DPODHCMGCPF, true);
			return true;
		}
		if (JNJJAMNLOHA.EHALCLFLGJF != 0 || !connectedAndReady)
		{
			UnityEngine.Debug.LogError("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		LEPNBLFEINB = LEPNBLFEINB ?? ((!JNJJAMNLOHA.insideLobby) ? null : JNJJAMNLOHA.lobby);
		AKBOPCNHFFJ aKBOPCNHFFJ = new AKBOPCNHFFJ();
		aKBOPCNHFFJ.RoomName = IOJPMCOBHEJ;
		aKBOPCNHFFJ.RoomOptions = DPODHCMGCPF;
		aKBOPCNHFFJ.Lobby = LEPNBLFEINB;
		aKBOPCNHFFJ.ExpectedUsers = MMIMLMLKCBA;
		return JNJJAMNLOHA.OpCreateGame(aKBOPCNHFFJ);
	}

	public static bool JoinRoom(string IOJPMCOBHEJ)
	{
		return JoinRoom(IOJPMCOBHEJ, null);
	}

	public static bool JoinRoom(string IOJPMCOBHEJ, string[] MMIMLMLKCBA)
	{
		if (offlineMode)
		{
			if (DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			KFDFMLDBHFM(IOJPMCOBHEJ, null, true);
			return true;
		}
		if (JNJJAMNLOHA.EHALCLFLGJF != 0 || !connectedAndReady)
		{
			UnityEngine.Debug.LogError("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		if (string.IsNullOrEmpty(IOJPMCOBHEJ))
		{
			UnityEngine.Debug.LogError("JoinRoom failed. A roomname is required. If you don't know one, how will you join?");
			return false;
		}
		AKBOPCNHFFJ aKBOPCNHFFJ = new AKBOPCNHFFJ();
		aKBOPCNHFFJ.RoomName = IOJPMCOBHEJ;
		aKBOPCNHFFJ.ExpectedUsers = MMIMLMLKCBA;
		return JNJJAMNLOHA.OpJoinRoom(aKBOPCNHFFJ);
	}

	public static bool JoinOrCreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB)
	{
		return JoinOrCreateRoom(IOJPMCOBHEJ, DPODHCMGCPF, LEPNBLFEINB, null);
	}

	public static bool JoinOrCreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB, string[] MMIMLMLKCBA)
	{
		if (offlineMode)
		{
			if (DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			KFDFMLDBHFM(IOJPMCOBHEJ, DPODHCMGCPF, true);
			return true;
		}
		if (JNJJAMNLOHA.EHALCLFLGJF != 0 || !connectedAndReady)
		{
			UnityEngine.Debug.LogError("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		if (string.IsNullOrEmpty(IOJPMCOBHEJ))
		{
			UnityEngine.Debug.LogError("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
			return false;
		}
		LEPNBLFEINB = LEPNBLFEINB ?? ((!JNJJAMNLOHA.insideLobby) ? null : JNJJAMNLOHA.lobby);
		AKBOPCNHFFJ aKBOPCNHFFJ = new AKBOPCNHFFJ();
		aKBOPCNHFFJ.RoomName = IOJPMCOBHEJ;
		aKBOPCNHFFJ.RoomOptions = DPODHCMGCPF;
		aKBOPCNHFFJ.Lobby = LEPNBLFEINB;
		aKBOPCNHFFJ.CreateIfNotExists = true;
		aKBOPCNHFFJ.PlayerProperties = player.CustomProperties;
		aKBOPCNHFFJ.ExpectedUsers = MMIMLMLKCBA;
		return JNJJAMNLOHA.OpJoinRoom(aKBOPCNHFFJ);
	}

	public static bool JoinRandomRoom()
	{
		return JoinRandomRoom(null, 0, MatchmakingMode.FillRoom, null, null);
	}

	public static bool JoinRandomRoom(Hashtable PDDOKBHKDAL, byte HJHMPEIKPKJ)
	{
		return JoinRandomRoom(PDDOKBHKDAL, HJHMPEIKPKJ, MatchmakingMode.FillRoom, null, null);
	}

	public static bool JoinRandomRoom(Hashtable PDDOKBHKDAL, byte HJHMPEIKPKJ, MatchmakingMode MBFAHJGIFBG, TypedLobby LEPNBLFEINB, string NNJFKLBJCJP, string[] MMIMLMLKCBA = null)
	{
		if (offlineMode)
		{
			if (DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			KFDFMLDBHFM("offline room", null, true);
			return true;
		}
		if (JNJJAMNLOHA.EHALCLFLGJF != 0 || !connectedAndReady)
		{
			UnityEngine.Debug.LogError("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		LEPNBLFEINB = LEPNBLFEINB ?? ((!JNJJAMNLOHA.insideLobby) ? null : JNJJAMNLOHA.lobby);
		OpJoinRandomRoomParams opJoinRandomRoomParams = new OpJoinRandomRoomParams();
		opJoinRandomRoomParams.ExpectedCustomRoomProperties = PDDOKBHKDAL;
		opJoinRandomRoomParams.ExpectedMaxPlayers = HJHMPEIKPKJ;
		opJoinRandomRoomParams.MatchingType = MBFAHJGIFBG;
		opJoinRandomRoomParams.TypedLobby = LEPNBLFEINB;
		opJoinRandomRoomParams.SqlLobbyFilter = NNJFKLBJCJP;
		opJoinRandomRoomParams.ExpectedUsers = MMIMLMLKCBA;
		return JNJJAMNLOHA.OpJoinRandomRoom(opJoinRandomRoomParams);
	}

	public static bool ReJoinRoom(string IOJPMCOBHEJ)
	{
		if (offlineMode)
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed due to offline mode.");
			return false;
		}
		if (JNJJAMNLOHA.EHALCLFLGJF != 0 || !connectedAndReady)
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		if (string.IsNullOrEmpty(IOJPMCOBHEJ))
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?");
			return false;
		}
		AKBOPCNHFFJ aKBOPCNHFFJ = new AKBOPCNHFFJ();
		aKBOPCNHFFJ.RoomName = IOJPMCOBHEJ;
		aKBOPCNHFFJ.RejoinOnly = true;
		aKBOPCNHFFJ.PlayerProperties = player.CustomProperties;
		return JNJJAMNLOHA.OpJoinRoom(aKBOPCNHFFJ);
	}

	private static void KFDFMLDBHFM(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, bool IJFFNPDGBGO)
	{
		DNGILIFEKBM = new Room(IOJPMCOBHEJ, DPODHCMGCPF);
		JNJJAMNLOHA.ChangeLocalID(1);
		DNGILIFEKBM.EJLAPIIGIMI = 1;
		if (IJFFNPDGBGO)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
		}
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom);
	}

	public static bool JoinLobby()
	{
		return JoinLobby(null);
	}

	public static bool JoinLobby(TypedLobby LEPNBLFEINB)
	{
		if (connected && Server == ServerConnection.MasterServer)
		{
			if (LEPNBLFEINB == null)
			{
				LEPNBLFEINB = TypedLobby.Default;
			}
			bool flag = JNJJAMNLOHA.OpJoinLobby(LEPNBLFEINB);
			if (flag)
			{
				JNJJAMNLOHA.lobby = LEPNBLFEINB;
			}
			return flag;
		}
		return false;
	}

	public static bool LeaveLobby()
	{
		if (connected && Server == ServerConnection.MasterServer)
		{
			return JNJJAMNLOHA.OpLeaveLobby();
		}
		return false;
	}

	public static bool LeaveRoom()
	{
		if (offlineMode)
		{
			DNGILIFEKBM = null;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom);
			return true;
		}
		if (room == null)
		{
			UnityEngine.Debug.LogWarning("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: " + connectionStateDetailed);
		}
		return JNJJAMNLOHA.OpLeave();
	}

	public static bool GetCustomRoomList(TypedLobby LEPNBLFEINB, string NNJFKLBJCJP)
	{
		return JNJJAMNLOHA.OpGetGameList(LEPNBLFEINB, NNJFKLBJCJP);
	}

	public static RoomInfo[] GetRoomList()
	{
		if (offlineMode || JNJJAMNLOHA == null)
		{
			return new RoomInfo[0];
		}
		return JNJJAMNLOHA.mGameListCopy;
	}

	public static void SetPlayerCustomProperties(Hashtable MADHFAPNGKO)
	{
		if (MADHFAPNGKO == null)
		{
			MADHFAPNGKO = new Hashtable();
			foreach (object key in player.CustomProperties.Keys)
			{
				MADHFAPNGKO[(string)key] = null;
			}
		}
		if (room != null && room.IsLocalClientInside)
		{
			player.SetCustomProperties(MADHFAPNGKO);
		}
		else
		{
			player.NPOPPIMCDMN(MADHFAPNGKO);
		}
	}

	public static void RemovePlayerCustomProperties(string[] IHEPFEODDEM)
	{
		if (IHEPFEODDEM == null || IHEPFEODDEM.Length == 0 || player.CustomProperties == null)
		{
			player.CustomProperties = new Hashtable();
			return;
		}
		foreach (string key in IHEPFEODDEM)
		{
			if (player.CustomProperties.ContainsKey(key))
			{
				player.CustomProperties.Remove(key);
			}
		}
	}

	public static bool RaiseEvent(byte IMCBEMICJFC, object PLEDNEPCFIC, bool ANMGHMBBMAO, RaiseEventOptions PCFOAMAODBD)
	{
		if (!inRoom || IMCBEMICJFC >= 200)
		{
			UnityEngine.Debug.LogWarning("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).");
			return false;
		}
		return JNJJAMNLOHA.OpRaiseEvent(IMCBEMICJFC, PLEDNEPCFIC, ANMGHMBBMAO, PCFOAMAODBD);
	}

	public static int AllocateViewID()
	{
		int num = JDMOJHLFDLL(player.ID);
		JMCPHFPJEJC.Add(num);
		return num;
	}

	public static int AllocateSceneViewID()
	{
		if (!isMasterClient)
		{
			UnityEngine.Debug.LogError("Only the Master Client can AllocateSceneViewID(). Check PhotonNetwork.isMasterClient!");
			return -1;
		}
		int num = JDMOJHLFDLL(0);
		JMCPHFPJEJC.Add(num);
		return num;
	}

	private static int JDMOJHLFDLL(int GOGMHIJOKBA)
	{
		if (GOGMHIJOKBA == 0)
		{
			int num = JIOIILCHMJL;
			int num2 = GOGMHIJOKBA * MAX_VIEW_IDS;
			for (int i = 1; i < MAX_VIEW_IDS; i++)
			{
				num = (num + 1) % MAX_VIEW_IDS;
				if (num != 0)
				{
					int num3 = num + num2;
					if (!JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(num3))
					{
						JIOIILCHMJL = num;
						return num3;
					}
				}
			}
			throw new Exception($"AllocateViewID() failed. Room (user {GOGMHIJOKBA}) is out of 'scene' viewIDs. It seems all available are in use.");
		}
		int num4 = FDMEIPEKMHC;
		int num5 = GOGMHIJOKBA * MAX_VIEW_IDS;
		for (int j = 1; j < MAX_VIEW_IDS; j++)
		{
			num4 = (num4 + 1) % MAX_VIEW_IDS;
			if (num4 != 0)
			{
				int num6 = num4 + num5;
				if (!JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(num6) && !JMCPHFPJEJC.Contains(num6))
				{
					FDMEIPEKMHC = num4;
					return num6;
				}
			}
		}
		throw new Exception($"AllocateViewID() failed. User {GOGMHIJOKBA} is out of subIds, as all viewIDs are used.");
	}

	private static int[] FHEJPNKOIJM(int NLMNICONLMF)
	{
		int[] array = new int[NLMNICONLMF];
		for (int i = 0; i < NLMNICONLMF; i++)
		{
			array[i] = JDMOJHLFDLL(0);
		}
		return array;
	}

	public static void UnAllocateViewID(int NADLIACHBNO)
	{
		JMCPHFPJEJC.Remove(NADLIACHBNO);
		if (JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(NADLIACHBNO))
		{
			UnityEngine.Debug.LogWarning($"UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {NADLIACHBNO} still found in: {JNJJAMNLOHA.HFCMPEKPBAM[NADLIACHBNO]}");
		}
	}

	public static GameObject Instantiate(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC)
	{
		return Instantiate(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, null);
	}

	public static GameObject Instantiate(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, object[] NOJGGCLPPAM)
	{
		if (!connected || (InstantiateInRoomOnly && !inRoom))
		{
			UnityEngine.Debug.LogError("Failed to Instantiate prefab: " + PPFBFGBJOHM + ". Client should be in a room. Current connectionStateDetailed: " + connectionStateDetailed);
			return null;
		}
		GameObject value;
		if (!UsePrefabCache || !PrefabCache.TryGetValue(PPFBFGBJOHM, out value))
		{
			value = (GameObject)Resources.Load(PPFBFGBJOHM, typeof(GameObject));
			if (UsePrefabCache)
			{
				PrefabCache.Add(PPFBFGBJOHM, value);
			}
		}
		if (value == null)
		{
			UnityEngine.Debug.LogError("Failed to Instantiate prefab: " + PPFBFGBJOHM + ". Verify the Prefab is in a Resources folder (and not in a subfolder)");
			return null;
		}
		if (value.GetComponent<PhotonView>() == null)
		{
			UnityEngine.Debug.LogError("Failed to Instantiate prefab:" + PPFBFGBJOHM + ". Prefab must have a PhotonView component.");
			return null;
		}
		Component[] photonViewsInChildren = value.GetPhotonViewsInChildren();
		int[] array = new int[photonViewsInChildren.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = JDMOJHLFDLL(player.ID);
		}
		Hashtable nNNJPMDHPHH = JNJJAMNLOHA.JBBJFFKDHNO(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, array, NOJGGCLPPAM, false);
		return JNJJAMNLOHA.JFOLGKKLFJP(nNNJPMDHPHH, JNJJAMNLOHA.LocalPlayer, value);
	}

	public static GameObject InstantiateSceneObject(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, object[] NOJGGCLPPAM)
	{
		if (!connected || (InstantiateInRoomOnly && !inRoom))
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". Client should be in a room. Current connectionStateDetailed: " + connectionStateDetailed);
			return null;
		}
		if (!isMasterClient)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". Client is not the MasterClient in this room.");
			return null;
		}
		GameObject value;
		if (!UsePrefabCache || !PrefabCache.TryGetValue(PPFBFGBJOHM, out value))
		{
			value = (GameObject)Resources.Load(PPFBFGBJOHM, typeof(GameObject));
			if (UsePrefabCache)
			{
				PrefabCache.Add(PPFBFGBJOHM, value);
			}
		}
		if (value == null)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". Verify the Prefab is in a Resources folder (and not in a subfolder)");
			return null;
		}
		if (value.GetComponent<PhotonView>() == null)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab:" + PPFBFGBJOHM + ". Prefab must have a PhotonView component.");
			return null;
		}
		Component[] photonViewsInChildren = value.GetPhotonViewsInChildren();
		int[] array = FHEJPNKOIJM(photonViewsInChildren.Length);
		if (array == null)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". No ViewIDs are free to use. Max is: " + MAX_VIEW_IDS);
			return null;
		}
		Hashtable nNNJPMDHPHH = JNJJAMNLOHA.JBBJFFKDHNO(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, array, NOJGGCLPPAM, true);
		return JNJJAMNLOHA.JFOLGKKLFJP(nNNJPMDHPHH, JNJJAMNLOHA.LocalPlayer, value);
	}

	public static int GetPing()
	{
		return JNJJAMNLOHA.RoundTripTime;
	}

	public static void FetchServerTimestamp()
	{
		if (JNJJAMNLOHA != null)
		{
			JNJJAMNLOHA.FetchServerTimestamp();
		}
	}

	public static void SendOutgoingCommands()
	{
		if (OEOOJCDIDEM())
		{
			while (JNJJAMNLOHA.SendOutgoingCommands())
			{
			}
		}
	}

	public static bool CloseConnection(PhotonPlayer HNKDBLECLJD)
	{
		if (!OEOOJCDIDEM())
		{
			return false;
		}
		if (!player.IsMasterClient)
		{
			UnityEngine.Debug.LogError("CloseConnection: Only the masterclient can kick another player.");
			return false;
		}
		if (HNKDBLECLJD == null)
		{
			UnityEngine.Debug.LogError("CloseConnection: No such player connected!");
			return false;
		}
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.TargetActors = new int[1] { HNKDBLECLJD.ID };
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		return JNJJAMNLOHA.OpRaiseEvent(203, null, true, bPLHAPBMGGC);
	}

	public static bool SetMasterClient(PhotonPlayer KOPLIPHDDKI)
	{
		if (!inRoom || !OEOOJCDIDEM() || offlineMode)
		{
			if (logLevel == PhotonLogLevel.Informational)
			{
				UnityEngine.Debug.Log("Can not SetMasterClient(). Not in room or in offlineMode.");
			}
			return false;
		}
		if (room.BDHOOLIDFJO)
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Add((byte)248, KOPLIPHDDKI.ID);
			Hashtable mJJMNIDHDEC = hashtable;
			hashtable = new Hashtable();
			hashtable.Add((byte)248, JNJJAMNLOHA.mMasterClientId);
			Hashtable kCJIKJDCOAL = hashtable;
			return JNJJAMNLOHA.HFECLDIOHNJ(mJJMNIDHDEC, kCJIKJDCOAL);
		}
		if (!isMasterClient)
		{
			return false;
		}
		return JNJJAMNLOHA.LGPBHHOJPCA(KOPLIPHDDKI.ID, true);
	}

	public static void Destroy(PhotonView NCLLMPGMEGK)
	{
		if (NCLLMPGMEGK != null)
		{
			JNJJAMNLOHA.EFDAOHIDIIF(NCLLMPGMEGK.gameObject, !inRoom);
		}
		else
		{
			UnityEngine.Debug.LogError("Destroy(targetPhotonView) failed, cause targetPhotonView is null.");
		}
	}

	public static void Destroy(GameObject LLLMPOLKHLI)
	{
		JNJJAMNLOHA.EFDAOHIDIIF(LLLMPOLKHLI, !inRoom);
	}

	public static void DestroyPlayerObjects(PhotonPlayer MJCDIJOAEPI)
	{
		if (player == null)
		{
			UnityEngine.Debug.LogError("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		}
		DestroyPlayerObjects(MJCDIJOAEPI.ID);
	}

	public static void DestroyPlayerObjects(int BJAGFDGPDGB)
	{
		if (OEOOJCDIDEM())
		{
			if (player.IsMasterClient || BJAGFDGPDGB == player.ID)
			{
				JNJJAMNLOHA.DestroyPlayerObjects(BJAGFDGPDGB, false);
			}
			else
			{
				UnityEngine.Debug.LogError("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: " + isMasterClient);
			}
		}
	}

	public static void DestroyAll()
	{
		if (isMasterClient)
		{
			JNJJAMNLOHA.DestroyAll(false);
		}
		else
		{
			UnityEngine.Debug.LogError("Couldn't call DestroyAll() as only the master client is allowed to call this.");
		}
	}

	public static void RemoveRPCs(PhotonPlayer MJCDIJOAEPI)
	{
		if (OEOOJCDIDEM())
		{
			if (!MJCDIJOAEPI.IsLocal && !isMasterClient)
			{
				UnityEngine.Debug.LogError("Error; Only the MasterClient can call RemoveRPCs for other players.");
			}
			else
			{
				JNJJAMNLOHA.OpCleanRpcBuffer(MJCDIJOAEPI.ID);
			}
		}
	}

	public static void RemoveRPCs(PhotonView JFOAMHPNFIL)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.CleanRpcBufferIfMine(JFOAMHPNFIL);
		}
	}

	public static void RemoveRPCsInGroup(int FJFIKHHEGKC)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.RemoveRPCsInGroup(FJFIKHHEGKC);
		}
	}

	internal static void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		if (!OEOOJCDIDEM())
		{
			return;
		}
		if (room == null)
		{
			UnityEngine.Debug.LogWarning("RPCs can only be sent in rooms. Call of \"" + LBLKDNNPACO + "\" gets executed locally only, if at all.");
		}
		else if (JNJJAMNLOHA != null)
		{
			if (room.BDHOOLIDFJO)
			{
				JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, MPNMOONBMII, null, AKFHJNFOCDP, GNNEKCBOBEG);
			}
			else if (JNJJAMNLOHA.hasSwitchedMC && MPNMOONBMII == PhotonTargets.MasterClient)
			{
				JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, PhotonTargets.Others, masterClient, AKFHJNFOCDP, GNNEKCBOBEG);
			}
			else
			{
				JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, MPNMOONBMII, null, AKFHJNFOCDP, GNNEKCBOBEG);
			}
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not execute RPC " + LBLKDNNPACO + ". Possible scene loading in progress?");
		}
	}

	internal static void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool CHFCLAACMEP, params object[] GNNEKCBOBEG)
	{
		if (!OEOOJCDIDEM())
		{
			return;
		}
		if (room == null)
		{
			UnityEngine.Debug.LogWarning("RPCs can only be sent in rooms. Call of \"" + LBLKDNNPACO + "\" gets executed locally only, if at all.");
			return;
		}
		if (player == null)
		{
			UnityEngine.Debug.LogError("RPC can't be sent to target PhotonPlayer being null! Did not send \"" + LBLKDNNPACO + "\" call.");
		}
		if (JNJJAMNLOHA != null)
		{
			JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, PhotonTargets.Others, MJCDIJOAEPI, CHFCLAACMEP, GNNEKCBOBEG);
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not execute RPC " + LBLKDNNPACO + ". Possible scene loading in progress?");
		}
	}

	public static void CacheSendMonoMessageTargets(Type HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == null)
		{
			HMGBJCGOLMI = SendMonoMessageTargetType;
		}
		SendMonoMessageTargets = FindGameObjectsWithComponent(HMGBJCGOLMI);
	}

	public static HashSet<GameObject> FindGameObjectsWithComponent(Type HMGBJCGOLMI)
	{
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		Component[] array = (Component[])UnityEngine.Object.FindObjectsOfType(HMGBJCGOLMI);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				hashSet.Add(array[i].gameObject);
			}
		}
		return hashSet;
	}

	[Obsolete("Use SetInterestGroups(byte group, bool enabled) instead.")]
	public static void SetReceivingEnabled(int PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (OEOOJCDIDEM())
		{
			SetInterestGroups((byte)PNFBEEBFMKC, CKALCHJAFBE);
		}
	}

	public static void SetInterestGroups(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (OEOOJCDIDEM())
		{
			if (CKALCHJAFBE)
			{
				byte[] oBKFHNACHIA = new byte[1] { PNFBEEBFMKC };
				JNJJAMNLOHA.SetInterestGroups(null, oBKFHNACHIA);
			}
			else
			{
				byte[] jKOIGFLNNCN = new byte[1] { PNFBEEBFMKC };
				JNJJAMNLOHA.SetInterestGroups(jKOIGFLNNCN, null);
			}
		}
	}

	[Obsolete("Use SetInterestGroups(byte[] disableGroups, byte[] enableGroups) instead. Mind the parameter order!")]
	public static void SetReceivingEnabled(int[] OBKFHNACHIA, int[] JKOIGFLNNCN)
	{
		if (OEOOJCDIDEM())
		{
			byte[] array = null;
			byte[] array2 = null;
			if (OBKFHNACHIA != null)
			{
				array2 = new byte[OBKFHNACHIA.Length];
				Array.Copy(OBKFHNACHIA, array2, OBKFHNACHIA.Length);
			}
			if (JKOIGFLNNCN != null)
			{
				array = new byte[JKOIGFLNNCN.Length];
				Array.Copy(JKOIGFLNNCN, array, JKOIGFLNNCN.Length);
			}
			JNJJAMNLOHA.SetInterestGroups(array, array2);
		}
	}

	public static void SetInterestGroups(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.SetInterestGroups(JKOIGFLNNCN, OBKFHNACHIA);
		}
	}

	[Obsolete("Use SetSendingEnabled(byte group, bool enabled). Interest Groups have a byte-typed ID. Mind the parameter order.")]
	public static void SetSendingEnabled(int PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		SetSendingEnabled((byte)PNFBEEBFMKC, CKALCHJAFBE);
	}

	public static void SetSendingEnabled(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.SetSendingEnabled(PNFBEEBFMKC, CKALCHJAFBE);
		}
	}

	[Obsolete("Use SetSendingEnabled(byte group, bool enabled). Interest Groups have a byte-typed ID. Mind the parameter order.")]
	public static void SetSendingEnabled(int[] OBKFHNACHIA, int[] JKOIGFLNNCN)
	{
		byte[] array = null;
		byte[] array2 = null;
		if (OBKFHNACHIA != null)
		{
			array2 = new byte[OBKFHNACHIA.Length];
			Array.Copy(OBKFHNACHIA, array2, OBKFHNACHIA.Length);
		}
		if (JKOIGFLNNCN != null)
		{
			array = new byte[JKOIGFLNNCN.Length];
			Array.Copy(JKOIGFLNNCN, array, JKOIGFLNNCN.Length);
		}
		SetSendingEnabled(array, array2);
	}

	public static void SetSendingEnabled(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.SetSendingEnabled(JKOIGFLNNCN, OBKFHNACHIA);
		}
	}

	public static void SetLevelPrefix(short MOALALKJCKJ)
	{
		if (OEOOJCDIDEM())
		{
			JNJJAMNLOHA.SetLevelPrefix(MOALALKJCKJ);
		}
	}

	public static void LoadLevel(int JAKFPPDJPAE)
	{
		JNJJAMNLOHA.DKACLKKBLBO(JAKFPPDJPAE);
		isMessageQueueRunning = false;
		JNJJAMNLOHA.HMIEGLIHGEM = true;
		SceneManager.LoadScene(JAKFPPDJPAE);
	}

	public static void LoadLevel(string CALNJJJGINH)
	{
		JNJJAMNLOHA.DKACLKKBLBO(CALNJJJGINH);
		isMessageQueueRunning = false;
		JNJJAMNLOHA.HMIEGLIHGEM = true;
		SceneManager.LoadScene(CALNJJJGINH);
	}

	public static bool WebRpc(string EBEHBBDKDFJ, object GNNEKCBOBEG)
	{
		return JNJJAMNLOHA.WebRpc(EBEHBBDKDFJ, GNNEKCBOBEG);
	}

	[CompilerGenerated]
	private static int DLFFNMKNFJA()
	{
		return (int)DKNFDIMGLKG.ElapsedMilliseconds;
	}
}
