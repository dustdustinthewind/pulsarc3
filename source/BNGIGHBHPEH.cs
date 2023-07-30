// BNGIGHBHPEH
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

internal class BNGIGHBHPEH : OHGAIJCPAJB, IPhotonPeerListener
{
	protected internal string KAIBLIKEDHM;

	private string JOKLGFENMKE;

	public AuthModeOption AuthMode;

	public EncryptionMode EncryptionMode;

	public const string NameServerHost = "ns.exitgames.com";

	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	private static readonly Dictionary<ConnectionProtocol, int> AEGGDHEGGCL = new Dictionary<ConnectionProtocol, int>
	{
		{
			ConnectionProtocol.Udp,
			5058
		},
		{
			ConnectionProtocol.Tcp,
			4533
		},
		{
			ConnectionProtocol.WebSocket,
			9093
		},
		{
			ConnectionProtocol.WebSocketSecure,
			19093
		}
	};

	public bool IsInitialConnect;

	public bool insideLobby;

	protected internal List<TypedLobbyInfo> HOBLKOKPJOE = new List<TypedLobbyInfo>();

	public Dictionary<string, RoomInfo> mGameList = new Dictionary<string, RoomInfo>();

	public RoomInfo[] mGameListCopy = new RoomInfo[0];

	private string OBCEIJGMKGB = string.Empty;

	private bool BOKEGDFHBAN;

	private Room NBCIDPIDCDP;

	private JoinType ELNKFMHCMBO;

	protected internal AKBOPCNHFFJ AJFMHFLGCFN;

	private bool DMCPHGDNGDB;

	private string[] BEIPFKHGHPC;

	private int DJIOCIPPBMK;

	private bool POHIMACBDGL;

	public Dictionary<int, PhotonPlayer> mActors = new Dictionary<int, PhotonPlayer>();

	public PhotonPlayer[] mOtherPlayerListCopy = new PhotonPlayer[0];

	public PhotonPlayer[] mPlayerListCopy = new PhotonPlayer[0];

	public bool hasSwitchedMC;

	private HashSet<byte> CHIJNBAJIHE = new HashSet<byte>();

	private HashSet<byte> FFBGBLFBHOK = new HashSet<byte>();

	protected internal Dictionary<int, PhotonView> HFCMPEKPBAM = new Dictionary<int, PhotonView>();

	private readonly PhotonStream CMABENLIOGI = new PhotonStream(false, null);

	private readonly PhotonStream ALPAEKHFHPP = new PhotonStream(true, null);

	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ECMNAOLPNBO = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ABIMEMLJLPA = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	protected internal short PKCNHOKCLJH;

	protected internal bool HMIEGLIHGEM;

	protected internal const string IDPJICOIFIH = "curScn";

	public static bool UsePrefabCache = true;

	internal IPunPrefabPool EGNHNBODKHP;

	public static Dictionary<string, GameObject> PrefabCache = new Dictionary<string, GameObject>();

	private Dictionary<Type, List<MethodInfo>> MNKFMEHFNKJ = new Dictionary<Type, List<MethodInfo>>();

	private readonly Dictionary<string, int> CPLBCMDIGNB;

	private static readonly string BJJEABNGKBF = PhotonNetworkingMessage.OnPhotonInstantiate.ToString();

	private string BLNBCGLIOHP;

	private string KAOMEDGGMEM;

	private ServerConnection PKNIJKPIKAF;

	private bool IDOAHFHJJJE;

	private Dictionary<int, object[]> IDIKEJLLFFP = new Dictionary<int, object[]>();

	public static int ObjectsInOneUpdate = 10;

	private RaiseEventOptions PCFOAMAODBD = new RaiseEventOptions();

	public const int SyncViewId = 0;

	public const int SyncCompressed = 1;

	public const int SyncNullValues = 2;

	public const int SyncFirstValue = 3;

	protected internal string EOCFDCJNAGM => string.Format("{0}_{1}", PhotonNetwork.gameVersion, "1.87");

	public AuthenticationValues AuthValues { get; set; }

	private string LLJDHHLHFME
	{
		get
		{
			if (AuthMode == AuthModeOption.Auth)
			{
				return null;
			}
			return (AuthValues == null) ? null : AuthValues.Token;
		}
	}

	public bool IsUsingNameServer { get; protected internal set; }

	public string NameServerAddress => IHAJBEOILOE();

	public string MasterServerAddress { get; protected internal set; }

	public string GameServerAddress { get; protected internal set; }

	protected internal ServerConnection EHALCLFLGJF { get; private set; }

	public ClientState State { get; internal set; }

	public TypedLobby lobby { get; set; }

	private bool OGLFGPKHEHH => PhotonNetwork.EnableLobbyStatistics && EHALCLFLGJF == ServerConnection.MasterServer;

	public string PlayerName
	{
		get
		{
			return OBCEIJGMKGB;
		}
		set
		{
			if (!string.IsNullOrEmpty(value) && !value.Equals(OBCEIJGMKGB))
			{
				if (LocalPlayer != null)
				{
					LocalPlayer.NickName = value;
				}
				OBCEIJGMKGB = value;
				if (CurrentRoom != null)
				{
					PACEKOIEHKK();
				}
			}
		}
	}

	public Room CurrentRoom
	{
		get
		{
			if (NBCIDPIDCDP != null && NBCIDPIDCDP.IsLocalClientInside)
			{
				return NBCIDPIDCDP;
			}
			return null;
		}
		private set
		{
			NBCIDPIDCDP = value;
		}
	}

	public PhotonPlayer LocalPlayer { get; internal set; }

	public int PlayersOnMasterCount { get; internal set; }

	public int PlayersInRoomsCount { get; internal set; }

	public int RoomsCount { get; internal set; }

	protected internal int LALFOLKNJJD => (!POHIMACBDGL && DJIOCIPPBMK != 0) ? (Environment.TickCount - DJIOCIPPBMK) : 0;

	public bool IsAuthorizeSecretAvailable => AuthValues != null && !string.IsNullOrEmpty(AuthValues.Token);

	public List<Region> AvailableRegions { get; protected internal set; }

	public CloudRegionCode CloudRegion { get; protected internal set; }

	public int mMasterClientId
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return LocalPlayer.ID;
			}
			return (CurrentRoom != null) ? CurrentRoom.EJLAPIIGIMI : 0;
		}
		private set
		{
			if (CurrentRoom != null)
			{
				CurrentRoom.EJLAPIIGIMI = value;
			}
		}
	}

	private bool OELIGNFABAJ()
	{
		AuthenticationValues authenticationValues = AuthValues;
		if (authenticationValues == null)
		{
			AuthenticationValues authenticationValues2 = new AuthenticationValues();
			authenticationValues2.UserId = PlayerName;
			authenticationValues = authenticationValues2;
		}
		AuthenticationValues gPDFHODMOIJ = authenticationValues;
		if (AuthMode == AuthModeOption.Auth)
		{
			return OpAuthenticate(KAIBLIKEDHM, EOCFDCJNAGM, gPDFHODMOIJ, CloudRegion.ToString(), OGLFGPKHEHH);
		}
		return OpAuthenticateOnce(KAIBLIKEDHM, EOCFDCJNAGM, gPDFHODMOIJ, CloudRegion.ToString(), EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	public void NewSceneLoaded()
	{
		if (HMIEGLIHGEM)
		{
			HMIEGLIHGEM = false;
			PhotonNetwork.isMessageQueueRunning = true;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhotonView> item in HFCMPEKPBAM)
		{
			PhotonView value = item.Value;
			if (value == null)
			{
				list.Add(item.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			int key = list[i];
			HFCMPEKPBAM.Remove(key);
		}
		if (list.Count > 0 && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log("New level loaded. Removed " + list.Count + " scene view IDs from last level.");
		}
	}

	public PhotonView LDCGKJEKICK(int NADLIACHBNO)
	{
		PhotonView value = null;
		HFCMPEKPBAM.TryGetValue(NADLIACHBNO, out value);
		if (value == null)
		{
			PhotonView[] array = UnityEngine.Object.FindObjectsOfType(typeof(PhotonView)) as PhotonView[];
			for (int i = 1; i < array.Length; i++)
			{
				PhotonView photonView = array[i];
				if (photonView.viewID == NADLIACHBNO)
				{
					if (photonView.GEKLBLEBECG)
					{
						Debug.LogWarning("CameraFilterPack/Blend2Camera_Screen" + photonView);
					}
					return photonView;
				}
			}
		}
		return value;
	}

	public void OpCleanRpcBuffer(PhotonView DFIHBOEOJPI)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = DFIHBOEOJPI.viewID;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC);
	}

	protected internal PhotonPlayer ICMGDHDNIJD(int MHLPNLMDILP)
	{
		if (mActors == null)
		{
			return null;
		}
		PhotonPlayer value = null;
		mActors.TryGetValue(MHLPNLMDILP, out value);
		return value;
	}

	public bool SetMasterClient(int BONHLGFPNHF)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add((byte)248, BONHLGFPNHF);
		ExitGames.Client.Photon.Hashtable mJJMNIDHDEC = hashtable;
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add((byte)248, mMasterClientId);
		ExitGames.Client.Photon.Hashtable kCJIKJDCOAL = hashtable;
		return HFECLDIOHNJ(mJJMNIDHDEC, kCJIKJDCOAL);
	}

	[SpecialName]
	public bool LCKOOPIJBBP()
	{
		return _003CDOMFKIAEEAE_003Ek__BackingField;
	}

	internal ExitGames.Client.Photon.Hashtable HLFMLHKOOFE(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)1] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[(byte)1] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[(byte)1] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[(byte)2] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 1)
		{
			hashtable[(byte)0] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[(byte)1] = NOJGGCLPPAM;
		}
		if (PKCNHOKCLJH > 0)
		{
			hashtable[(byte)3] = PKCNHOKCLJH;
		}
		hashtable[(byte)7] = PhotonNetwork.ServerTimestamp;
		hashtable[(byte)1] = num;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = (BLOGDPLEMFH ? EventCaching.ReplaceCache : EventCaching.DoNotCache);
		ACEDLCAELNF(216, hashtable, false, raiseEventOptions);
		return hashtable;
	}

	public void RegisterPhotonView(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.viewID == 0)
		{
			Debug.Log("PhotonView register is ignored, because viewID is 0. No id assigned yet to: " + LCJKMJCFDGE);
			return;
		}
		PhotonView value = null;
		if (HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.viewID, out value))
		{
			if (!(LCJKMJCFDGE != value))
			{
				return;
			}
			Debug.LogError($"PhotonView ID duplicate found: {LCJKMJCFDGE.viewID}. New: {LCJKMJCFDGE} old: {value}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.");
			EFDAOHIDIIF(value.gameObject, true);
		}
		HFCMPEKPBAM.Add(LCJKMJCFDGE.viewID, LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Registered PhotonView: " + LCJKMJCFDGE.viewID);
		}
	}

	[SpecialName]
	protected internal void ONKFAPDCCLE(string DPNHODJHGJL)
	{
		_003CGGFFKAEDLBB_003Ek__BackingField = DPNHODJHGJL;
	}

	private void ENIDDCEBCDG()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = -1;
		JCCNCJFOMNB(196, hashtable, false, null);
	}

	private void EBNDKPFKPIJ()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = -1;
		OpRaiseEvent(207, hashtable, true, null);
	}

	private void KIKHKNNMBMN()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[244] = (byte)0;
		dictionary[247] = (byte)7;
		OpCustom(253, dictionary, true, 0);
	}

	private string IHAJBEOILOE()
	{
		ConnectionProtocol transportProtocol = base.TransportProtocol;
		int value = 0;
		AEGGDHEGGCL.TryGetValue(transportProtocol, out value);
		string arg = string.Empty;
		switch (transportProtocol)
		{
		case ConnectionProtocol.WebSocket:
			arg = "ws://";
			break;
		case ConnectionProtocol.WebSocketSecure:
			arg = "wss://";
			break;
		}
		return string.Format("{0}{1}:{2}", arg, "ns.exitgames.com", value);
	}

	public void ChangeLocalID(int LGHIPFAEONM)
	{
		if (LocalPlayer == null)
		{
			Debug.LogWarning($"LocalPlayer is null or not in mActors! LocalPlayer: {LocalPlayer} mActors==null: {mActors == null} newID: {LGHIPFAEONM}");
		}
		if (mActors.ContainsKey(LocalPlayer.ID))
		{
			mActors.Remove(LocalPlayer.ID);
		}
		LocalPlayer.GOCPHBFMIEN(LGHIPFAEONM);
		mActors[LocalPlayer.ID] = LocalPlayer;
		LEMBPMNPHCK();
	}

	private bool AKIBKCFMMHO()
	{
		IDOAHFHJJJE = true;
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		KHKMFIFGPCH(PKNIJKPIKAF);
		bool flag = base.Connect(BLNBCGLIOHP, KAOMEDGGMEM, LLJDHHLHFME);
		if (flag)
		{
			switch (PKNIJKPIKAF)
			{
			case ServerConnection.NameServer:
				State = ClientState.ConnectingToNameServer;
				break;
			case ServerConnection.MasterServer:
				State = ClientState.ConnectingToMasterserver;
				break;
			case ServerConnection.GameServer:
				State = ClientState.ConnectingToGameserver;
				break;
			}
		}
		return flag;
	}

	private void HBBIHADLDLH(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	private void ANCHCNAJLOJ(int JBHMEHIOGBE)
	{
		bool flag = mMasterClientId == JBHMEHIOGBE;
		bool flag2 = JBHMEHIOGBE > 0;
		if (flag2 && !flag)
		{
			return;
		}
		int num;
		if (mActors.Count <= 0)
		{
			num = LocalPlayer.ID;
		}
		else
		{
			num = 7;
			foreach (int key in mActors.Keys)
			{
				if (key < num && key != JBHMEHIOGBE)
				{
					num = key;
				}
			}
		}
		mMasterClientId = num;
		if (flag2)
		{
			SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby, ICMGDHDNIJD(num));
		}
	}

	[SpecialName]
	public int ABDALANPDDH()
	{
		return _003CBBNAEKGKOKM_003Ek__BackingField;
	}

	public void SetApp(string PPNEJGFIAJP, string MHMPNKGMNMJ)
	{
		KAIBLIKEDHM = PPNEJGFIAJP.Trim();
		if (!string.IsNullOrEmpty(MHMPNKGMNMJ))
		{
			PhotonNetwork.gameVersion = MHMPNKGMNMJ.Trim();
		}
	}

	internal GameObject JFOLGKKLFJP(ExitGames.Client.Photon.Hashtable NNNJPMDHPHH, PhotonPlayer OGKJFFANGMC, GameObject HHLFBCNFLAO)
	{
		string text = (string)NNNJPMDHPHH[(byte)0];
		int aMCIAILLAIB = (int)NNNJPMDHPHH[(byte)6];
		int num = (int)NNNJPMDHPHH[(byte)7];
		Vector3 vector = ((!NNNJPMDHPHH.ContainsKey((byte)1)) ? Vector3.zero : ((Vector3)NNNJPMDHPHH[(byte)1]));
		Quaternion quaternion = Quaternion.identity;
		if (NNNJPMDHPHH.ContainsKey((byte)2))
		{
			quaternion = (Quaternion)NNNJPMDHPHH[(byte)2];
		}
		byte b = 0;
		if (NNNJPMDHPHH.ContainsKey((byte)3))
		{
			b = (byte)NNNJPMDHPHH[(byte)3];
		}
		short prefix = 0;
		if (NNNJPMDHPHH.ContainsKey((byte)8))
		{
			prefix = (short)NNNJPMDHPHH[(byte)8];
		}
		int[] array = ((!NNNJPMDHPHH.ContainsKey((byte)4)) ? new int[1] { num } : ((int[])NNNJPMDHPHH[(byte)4]));
		object[] array2 = ((!NNNJPMDHPHH.ContainsKey((byte)5)) ? null : ((object[])NNNJPMDHPHH[(byte)5]));
		if (b != 0 && !CHIJNBAJIHE.Contains(b))
		{
			return null;
		}
		if (EGNHNBODKHP != null)
		{
			GameObject gameObject = EGNHNBODKHP.Instantiate(text, vector, quaternion);
			PhotonView[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
			if (photonViewsInChildren.Length != array.Length)
			{
				throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
			}
			for (int i = 0; i < photonViewsInChildren.Length; i++)
			{
				photonViewsInChildren[i].GEKLBLEBECG = false;
				photonViewsInChildren[i].viewID = 0;
				photonViewsInChildren[i].prefix = prefix;
				photonViewsInChildren[i].instantiationId = num;
				photonViewsInChildren[i].isRuntimeInstantiated = true;
				photonViewsInChildren[i].NJDPOGADFJN = array2;
				photonViewsInChildren[i].GEKLBLEBECG = true;
				photonViewsInChildren[i].viewID = array[i];
			}
			gameObject.SendMessage(BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, aMCIAILLAIB, null), SendMessageOptions.DontRequireReceiver);
			return gameObject;
		}
		if (HHLFBCNFLAO == null)
		{
			if (!UsePrefabCache || !PrefabCache.TryGetValue(text, out HHLFBCNFLAO))
			{
				HHLFBCNFLAO = (GameObject)Resources.Load(text, typeof(GameObject));
				if (UsePrefabCache)
				{
					PrefabCache.Add(text, HHLFBCNFLAO);
				}
			}
			if (HHLFBCNFLAO == null)
			{
				Debug.LogError("PhotonNetwork error: Could not Instantiate the prefab [" + text + "]. Please verify you have this gameobject in a Resources folder.");
				return null;
			}
		}
		PhotonView[] photonViewsInChildren2 = HHLFBCNFLAO.GetPhotonViewsInChildren();
		if (photonViewsInChildren2.Length != array.Length)
		{
			throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
		}
		for (int j = 0; j < array.Length; j++)
		{
			photonViewsInChildren2[j].viewID = array[j];
			photonViewsInChildren2[j].prefix = prefix;
			photonViewsInChildren2[j].instantiationId = num;
			photonViewsInChildren2[j].isRuntimeInstantiated = true;
		}
		DGEJLOAMLHI(num, array2);
		GameObject gameObject2 = UnityEngine.Object.Instantiate(HHLFBCNFLAO, vector, quaternion);
		for (int k = 0; k < array.Length; k++)
		{
			photonViewsInChildren2[k].viewID = 0;
			photonViewsInChildren2[k].prefix = -1;
			photonViewsInChildren2[k].prefixBackup = -1;
			photonViewsInChildren2[k].instantiationId = -1;
			photonViewsInChildren2[k].isRuntimeInstantiated = false;
		}
		GKNPNNKFFAL(num);
		gameObject2.SendMessage(BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, aMCIAILLAIB, null), SendMessageOptions.DontRequireReceiver);
		return gameObject2;
	}

	private static int OHKBLAANNDH(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = 84;
		for (int i = 1; i < NEJPNIGJLGP.Length; i += 0)
		{
			PhotonPlayer photonPlayer = NEJPNIGJLGP[i];
			if (photonPlayer.FHEAKIMCKJC() != AIMBEFMGEFM && photonPlayer.ID < num)
			{
				num = photonPlayer.FHEAKIMCKJC();
			}
		}
		return num;
	}

	public bool BGBLKGFPHBE()
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("In Map Editor");
			return false;
		}
		IsUsingNameServer = true;
		CloudRegion = CloudRegionCode.usw;
		if (State == (ClientState)(-18))
		{
			return true;
		}
		KHKMFIFGPCH(ServerConnection.GameServer);
		PKNIJKPIKAF = (ServerConnection)6;
		BLNBCGLIOHP = BDJGCHOLCJN();
		KAOMEDGGMEM = "menutheme.27thfloor";
		if (!base.Connect(BDJGCHOLCJN(), "_Value3", LLJDHHLHFME))
		{
			return true;
		}
		HNCIIMJABOJ((ClientState)101);
		return false;
	}

	protected internal void OMEPCMPKIJK(bool IJJEEIMFOHD)
	{
		if (IDIKEJLLFFP.Count > 0)
		{
			Debug.LogWarning("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView value in HFCMPEKPBAM.Values)
			{
				if (value.isRuntimeInstantiated)
				{
					hashSet.Add(value.gameObject);
				}
			}
			foreach (GameObject item in hashSet)
			{
				EFDAOHIDIIF(item, true);
			}
		}
		IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 0;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	private void CDNPLJILLFC(int JBHMEHIOGBE)
	{
		bool flag = mMasterClientId == JBHMEHIOGBE;
		bool flag2 = JBHMEHIOGBE > 0;
		if (flag2 && !flag)
		{
			return;
		}
		int num;
		if (mActors.Count <= 1)
		{
			num = LocalPlayer.ID;
		}
		else
		{
			num = int.MaxValue;
			foreach (int key in mActors.Keys)
			{
				if (key < num && key != JBHMEHIOGBE)
				{
					num = key;
				}
			}
		}
		mMasterClientId = num;
		if (flag2)
		{
			SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, ICMGDHDNIJD(num));
		}
	}

	[SpecialName]
	internal void HNCIIMJABOJ(ClientState DPNHODJHGJL)
	{
		_003CCKEGJBJJPEC_003Ek__BackingField = DPNHODJHGJL;
	}

	private static int BBEKGPLBBCA(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = int.MaxValue;
		foreach (PhotonPlayer photonPlayer in NEJPNIGJLGP)
		{
			if (photonPlayer.ID != AIMBEFMGEFM && photonPlayer.ID < num)
			{
				num = photonPlayer.ID;
			}
		}
		return num;
	}

	internal ExitGames.Client.Photon.Hashtable JBBJFFKDHNO(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[(byte)1] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[(byte)2] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[(byte)3] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 1)
		{
			hashtable[(byte)4] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[(byte)5] = NOJGGCLPPAM;
		}
		if (PKCNHOKCLJH > 0)
		{
			hashtable[(byte)8] = PKCNHOKCLJH;
		}
		hashtable[(byte)6] = PhotonNetwork.ServerTimestamp;
		hashtable[(byte)7] = num;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = ((!BLOGDPLEMFH) ? EventCaching.AddToRoomCache : EventCaching.AddToRoomCacheGlobal);
		OpRaiseEvent(202, hashtable, true, raiseEventOptions);
		return hashtable;
	}

	public bool ReconnectToMaster()
	{
		if (AuthValues == null)
		{
			Debug.LogWarning("ReconnectToMaster() with AuthValues == null is not correct!");
			AuthValues = new AuthenticationValues();
		}
		AuthValues.Token = JOKLGFENMKE;
		return Connect(MasterServerAddress, ServerConnection.MasterServer);
	}

	private object[] MFKHMJBJDLE(object[] BJIEGLPODKG, object[] BGJHIKDFIMP)
	{
		if (BGJHIKDFIMP == null || BJIEGLPODKG == null || BJIEGLPODKG.Length != BGJHIKDFIMP.Length)
		{
			return BGJHIKDFIMP;
		}
		if (BGJHIKDFIMP.Length <= 3)
		{
			return null;
		}
		BJIEGLPODKG[1] = false;
		int num = 0;
		Queue<int> queue = null;
		for (int i = 3; i < BGJHIKDFIMP.Length; i++)
		{
			object obj = BGJHIKDFIMP[i];
			object gOLMELKEAFO = BJIEGLPODKG[i];
			if (LFAPOBNFPPO(obj, gOLMELKEAFO))
			{
				num++;
				BJIEGLPODKG[i] = null;
				continue;
			}
			BJIEGLPODKG[i] = obj;
			if (obj == null)
			{
				if (queue == null)
				{
					queue = new Queue<int>(BGJHIKDFIMP.Length);
				}
				queue.Enqueue(i);
			}
		}
		if (num > 0)
		{
			if (num == BGJHIKDFIMP.Length - 3)
			{
				return null;
			}
			BJIEGLPODKG[1] = true;
			if (queue != null)
			{
				BJIEGLPODKG[2] = queue.ToArray();
			}
		}
		BJIEGLPODKG[0] = BGJHIKDFIMP[0];
		return BJIEGLPODKG;
	}

	protected internal void AHIEJFMHFPG(bool IJJEEIMFOHD)
	{
		if (IDIKEJLLFFP.Count > 0)
		{
			Debug.LogWarning("_Saturation");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView value in HFCMPEKPBAM.Values)
			{
				if (value.isRuntimeInstantiated)
				{
					hashSet.Add(value.gameObject);
				}
			}
			foreach (GameObject item in hashSet)
			{
				EFDAOHIDIIF(item, true);
			}
		}
		IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 1;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	public void RunViewUpdate()
	{
		if (!PhotonNetwork.connected || PhotonNetwork.offlineMode || mActors == null || mActors.Count <= 1)
		{
			return;
		}
		int num = 0;
		PCFOAMAODBD.Reset();
		List<int> list = null;
		Dictionary<int, PhotonView>.Enumerator enumerator = HFCMPEKPBAM.GetEnumerator();
		while (enumerator.MoveNext())
		{
			PhotonView value = enumerator.Current.Value;
			if (value == null)
			{
				Debug.LogError($"PhotonView with ID {enumerator.Current.Key} wasn't properly unregistered! Please report this case to developer@photonengine.com");
				if (list == null)
				{
					list = new List<int>(4);
				}
				list.Add(enumerator.Current.Key);
			}
			else
			{
				if (value.synchronization == ViewSynchronization.Off || !value.isMine || !value.gameObject.activeInHierarchy || FFBGBLFBHOK.Contains(value.group))
				{
					continue;
				}
				object[] array = OAMPHAGPLEL(value);
				if (array == null)
				{
					continue;
				}
				if (value.synchronization == ViewSynchronization.ReliableDeltaCompressed || value.PBIDCPBMFKJ)
				{
					ExitGames.Client.Photon.Hashtable value2 = null;
					if (!ECMNAOLPNBO.TryGetValue(value.group, out value2))
					{
						value2 = new ExitGames.Client.Photon.Hashtable(ObjectsInOneUpdate);
						ECMNAOLPNBO[value.group] = value2;
					}
					value2.Add((byte)(value2.Count + 10), array);
					num++;
					if (value2.Count >= ObjectsInOneUpdate)
					{
						num -= value2.Count;
						PCFOAMAODBD.InterestGroup = value.group;
						value2[(byte)0] = PhotonNetwork.ServerTimestamp;
						if (PKCNHOKCLJH >= 0)
						{
							value2[(byte)1] = PKCNHOKCLJH;
						}
						OpRaiseEvent(206, value2, true, PCFOAMAODBD);
						value2.Clear();
					}
					continue;
				}
				ExitGames.Client.Photon.Hashtable value3 = null;
				if (!ABIMEMLJLPA.TryGetValue(value.group, out value3))
				{
					value3 = new ExitGames.Client.Photon.Hashtable(ObjectsInOneUpdate);
					ABIMEMLJLPA[value.group] = value3;
				}
				value3.Add((byte)(value3.Count + 10), array);
				num++;
				if (value3.Count >= ObjectsInOneUpdate)
				{
					num -= value3.Count;
					PCFOAMAODBD.InterestGroup = value.group;
					value3[(byte)0] = PhotonNetwork.ServerTimestamp;
					if (PKCNHOKCLJH >= 0)
					{
						value3[(byte)1] = PKCNHOKCLJH;
					}
					OpRaiseEvent(201, value3, false, PCFOAMAODBD);
					value3.Clear();
				}
			}
		}
		if (list != null)
		{
			int i = 0;
			for (int count = list.Count; i < count; i++)
			{
				HFCMPEKPBAM.Remove(list[i]);
			}
		}
		if (num == 0)
		{
			return;
		}
		foreach (int key in ECMNAOLPNBO.Keys)
		{
			PCFOAMAODBD.InterestGroup = (byte)key;
			ExitGames.Client.Photon.Hashtable hashtable = ECMNAOLPNBO[key];
			if (hashtable.Count != 0)
			{
				hashtable[(byte)0] = PhotonNetwork.ServerTimestamp;
				if (PKCNHOKCLJH >= 0)
				{
					hashtable[(byte)1] = PKCNHOKCLJH;
				}
				OpRaiseEvent(206, hashtable, true, PCFOAMAODBD);
				hashtable.Clear();
			}
		}
		foreach (int key2 in ABIMEMLJLPA.Keys)
		{
			PCFOAMAODBD.InterestGroup = (byte)key2;
			ExitGames.Client.Photon.Hashtable hashtable2 = ABIMEMLJLPA[key2];
			if (hashtable2.Count != 0)
			{
				hashtable2[(byte)0] = PhotonNetwork.ServerTimestamp;
				if (PKCNHOKCLJH >= 0)
				{
					hashtable2[(byte)1] = PKCNHOKCLJH;
				}
				OpRaiseEvent(201, hashtable2, false, PCFOAMAODBD);
				hashtable2.Clear();
			}
		}
	}

	private void LLMNFGHNIND(int DIODBOKJKHM, int EJOIHHAHDLD, bool FEINGCNNFGM)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)7] = DIODBOKJKHM;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		raiseEventOptions.TargetActors = new int[1] { EJOIHHAHDLD };
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(202, hashtable, true, bPLHAPBMGGC);
		ExitGames.Client.Photon.Hashtable hashtable2 = new ExitGames.Client.Photon.Hashtable();
		hashtable2[(byte)0] = DIODBOKJKHM;
		bPLHAPBMGGC = null;
		if (!FEINGCNNFGM)
		{
			bPLHAPBMGGC = new RaiseEventOptions();
			bPLHAPBMGGC.CachingOption = EventCaching.AddToRoomCacheGlobal;
			Debug.Log("Destroying GO as global. ID: " + DIODBOKJKHM);
		}
		OpRaiseEvent(204, hashtable2, true, bPLHAPBMGGC);
	}

	private void LEMBPMNPHCK()
	{
		mPlayerListCopy = new PhotonPlayer[mActors.Count];
		mActors.Values.CopyTo(mPlayerListCopy, 0);
		List<PhotonPlayer> list = new List<PhotonPlayer>();
		for (int i = 0; i < mPlayerListCopy.Length; i++)
		{
			PhotonPlayer photonPlayer = mPlayerListCopy[i];
			if (!photonPlayer.IsLocal)
			{
				list.Add(photonPlayer);
			}
		}
		mOtherPlayerListCopy = list.ToArray();
	}

	public void SetInterestGroups(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			if (JKOIGFLNNCN.Length == 0)
			{
				CHIJNBAJIHE.Clear();
			}
			else
			{
				foreach (byte b in JKOIGFLNNCN)
				{
					if (b <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b + ". The group number should be at least 1.");
					}
					else if (CHIJNBAJIHE.Contains(b))
					{
						CHIJNBAJIHE.Remove(b);
					}
				}
			}
		}
		if (OBKFHNACHIA != null)
		{
			if (OBKFHNACHIA.Length == 0)
			{
				for (byte b2 = 0; b2 < byte.MaxValue; b2 = (byte)(b2 + 1))
				{
					CHIJNBAJIHE.Add(b2);
				}
				CHIJNBAJIHE.Add(byte.MaxValue);
			}
			else
			{
				foreach (byte b3 in OBKFHNACHIA)
				{
					if (b3 <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b3 + ". The group number should be at least 1.");
					}
					else
					{
						CHIJNBAJIHE.Add(b3);
					}
				}
			}
		}
		OpChangeGroups(JKOIGFLNNCN, OBKFHNACHIA);
	}

	private void EGJBHECFAOH(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		if (!mActors.ContainsKey(IJAEJMNLBLK))
		{
			mActors[IJAEJMNLBLK] = JHOEDACNNKK;
			LEMBPMNPHCK();
		}
		else
		{
			Debug.LogError("Adding player twice: " + IJAEJMNLBLK);
		}
	}

	protected internal bool LGPBHHOJPCA(int PHIGECOLKKN, bool PANGJAJJOLO)
	{
		if (mMasterClientId == PHIGECOLKKN || !mActors.ContainsKey(PHIGECOLKKN))
		{
			return false;
		}
		if (PANGJAJJOLO && !OpRaiseEvent(208, new ExitGames.Client.Photon.Hashtable { 
		{
			(byte)1,
			PHIGECOLKKN
		} }, true, null))
		{
			return false;
		}
		hasSwitchedMC = true;
		CurrentRoom.EJLAPIIGIMI = PHIGECOLKKN;
		SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, ICMGDHDNIJD(PHIGECOLKKN));
		return true;
	}

	public void DestroyAll(bool NOKCKEBHIFJ)
	{
		if (!NOKCKEBHIFJ)
		{
			OpRemoveCompleteCache();
			EBNDKPFKPIJ();
		}
		OMEPCMPKIJK(true);
	}

	public void OnEvent(EventData ADNNKPOCCDJ)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log($"OnEvent: {ADNNKPOCCDJ.ToString()}");
		}
		int num = -1;
		PhotonPlayer photonPlayer = null;
		if (ADNNKPOCCDJ.Parameters.ContainsKey(254))
		{
			num = (int)ADNNKPOCCDJ[254];
			photonPlayer = ICMGDHDNIJD(num);
		}
		switch (ADNNKPOCCDJ.Code)
		{
		case 209:
		{
			int[] array = (int[])ADNNKPOCCDJ.Parameters[245];
			int num2 = array[0];
			int num3 = array[1];
			PhotonView photonView = PhotonView.Find(num2);
			if (photonView == null)
			{
				Debug.LogWarning("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: " + num2);
				return;
			}
			if (PhotonNetwork.logLevel == PhotonLogLevel.Informational)
			{
				Debug.Log(string.Concat("Ev OwnershipRequest ", photonView.ownershipTransfer, ". ActorNr: ", num, " takes from: ", num3, ". local RequestedView.ownerId: ", photonView.ownerId, " isOwnerActive: ", photonView.isOwnerActive, ". MasterClient: ", mMasterClientId, ". This client's player: ", PhotonNetwork.player.ToStringFull()));
			}
			switch (photonView.ownershipTransfer)
			{
			case OwnershipOption.Fixed:
				Debug.LogWarning("Ownership mode == fixed. Ignoring request.");
				break;
			case OwnershipOption.Takeover:
				if (num3 == photonView.ownerId || (num3 == 0 && photonView.ownerId == mMasterClientId) || photonView.ownerId == 0)
				{
					photonView.OwnerShipWasTransfered = true;
					int ownerId = photonView.ownerId;
					PhotonPlayer photonPlayer2 = ICMGDHDNIJD(ownerId);
					photonView.ownerId = num;
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning(string.Concat(photonView, " ownership transfered to: ", num));
					}
					SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, photonView, photonPlayer, photonPlayer2);
				}
				break;
			case OwnershipOption.Request:
				if ((num3 == PhotonNetwork.player.ID || PhotonNetwork.player.IsMasterClient) && (photonView.ownerId == PhotonNetwork.player.ID || (PhotonNetwork.player.IsMasterClient && !photonView.isOwnerActive)))
				{
					SendMonoMessage(PhotonNetworkingMessage.OnOwnershipRequest, photonView, photonPlayer);
				}
				break;
			}
			return;
		}
		case 210:
		{
			int[] array6 = (int[])ADNNKPOCCDJ.Parameters[245];
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("Ev OwnershipTransfer. ViewID " + array6[0] + " to: " + array6[1] + " Time: " + Environment.TickCount % 1000);
			}
			int nADLIACHBNO = array6[0];
			int num5 = array6[1];
			PhotonView photonView2 = PhotonView.Find(nADLIACHBNO);
			if (photonView2 != null)
			{
				int ownerId2 = photonView2.ownerId;
				photonView2.OwnerShipWasTransfered = true;
				photonView2.ownerId = num5;
				SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, photonView2, PhotonPlayer.Find(num5), PhotonPlayer.Find(ownerId2));
			}
			return;
		}
		case 230:
		{
			mGameList = new Dictionary<string, RoomInfo>();
			ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
			foreach (object key in hashtable.Keys)
			{
				string text = (string)key;
				mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[key]);
			}
			mGameListCopy = new RoomInfo[mGameList.Count];
			mGameList.Values.CopyTo(mGameListCopy, 0);
			SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate);
			return;
		}
		case 229:
		{
			ExitGames.Client.Photon.Hashtable hashtable4 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
			foreach (object key2 in hashtable4.Keys)
			{
				string text2 = (string)key2;
				RoomInfo roomInfo = new RoomInfo(text2, (ExitGames.Client.Photon.Hashtable)hashtable4[key2]);
				if (roomInfo.removedFromList)
				{
					mGameList.Remove(text2);
				}
				else
				{
					mGameList[text2] = roomInfo;
				}
			}
			mGameListCopy = new RoomInfo[mGameList.Count];
			mGameList.Values.CopyTo(mGameListCopy, 0);
			SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate);
			return;
		}
		case 226:
			PlayersInRoomsCount = (int)ADNNKPOCCDJ[229];
			PlayersOnMasterCount = (int)ADNNKPOCCDJ[227];
			RoomsCount = (int)ADNNKPOCCDJ[228];
			return;
		case byte.MaxValue:
		{
			bool flag = false;
			ExitGames.Client.Photon.Hashtable eAOBCIPOENN = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[249];
			if (photonPlayer == null)
			{
				bool nIGBAPGIKDF = LocalPlayer.ID == num;
				EGJBHECFAOH(num, new PhotonPlayer(nIGBAPGIKDF, num, eAOBCIPOENN));
				PAOJLLAACDE();
			}
			else
			{
				flag = photonPlayer.IsInactive;
				photonPlayer.NPOPPIMCDMN(eAOBCIPOENN);
				photonPlayer.IsInactive = false;
			}
			if (num == LocalPlayer.ID)
			{
				int[] hOMAECIGJEJ = (int[])ADNNKPOCCDJ[252];
				ANEENOJMDOJ(hOMAECIGJEJ);
				if (ELNKFMHCMBO == JoinType.JoinOrCreateRoom && LocalPlayer.ID == 1)
				{
					SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
				}
				SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom);
			}
			else
			{
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerConnected, mActors[num]);
				if (flag)
				{
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, mActors[num]);
				}
			}
			return;
		}
		case 254:
			MJMAJHJLBPJ(num, ADNNKPOCCDJ);
			return;
		case 253:
		{
			int num4 = (int)ADNNKPOCCDJ[253];
			ExitGames.Client.Photon.Hashtable mJJMNIDHDEC = null;
			ExitGames.Client.Photon.Hashtable fAOLPBLCKFJ = null;
			if (num4 == 0)
			{
				mJJMNIDHDEC = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
			}
			else
			{
				fAOLPBLCKFJ = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
			}
			EDMCCPDDDCC(mJJMNIDHDEC, fAOLPBLCKFJ, num4);
			return;
		}
		case 200:
			MBCHEFNAJFH(ADNNKPOCCDJ[245] as ExitGames.Client.Photon.Hashtable, photonPlayer.ID);
			return;
		case 201:
		case 206:
		{
			ExitGames.Client.Photon.Hashtable hashtable3 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int bFELEJPLADE = (int)hashtable3[(byte)0];
			short dKCPAJGKHNI = -1;
			byte b = 10;
			int num7 = 1;
			if (hashtable3.ContainsKey((byte)1))
			{
				dKCPAJGKHNI = (short)hashtable3[(byte)1];
				num7 = 2;
			}
			byte b2 = b;
			while (b2 - b < hashtable3.Count - num7)
			{
				CKEAHPJAGOO(hashtable3[b2] as object[], photonPlayer, bFELEJPLADE, dKCPAJGKHNI);
				b2 = (byte)(b2 + 1);
			}
			return;
		}
		case 202:
			JFOLGKKLFJP((ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245], photonPlayer, null);
			return;
		case 203:
			if (photonPlayer == null || !photonPlayer.IsMasterClient)
			{
				Debug.LogError(string.Concat("Error: Someone else(", photonPlayer, ") then the masterserver requests a disconnect!"));
			}
			else
			{
				PhotonNetwork.LeaveRoom();
			}
			return;
		case 207:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num8 = (int)hashtable2[(byte)0];
			if (num8 >= 0)
			{
				DestroyPlayerObjects(num8, true);
				return;
			}
			if ((int)DebugOut >= 3)
			{
				Debug.Log("Ev DestroyAll! By PlayerId: " + num);
			}
			DestroyAll(true);
			return;
		}
		case 204:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num6 = (int)hashtable2[(byte)0];
			PhotonView value = null;
			if (HFCMPEKPBAM.TryGetValue(num6, out value))
			{
				EFDAOHIDIIF(value.gameObject, true);
			}
			else if ((int)DebugOut >= 1)
			{
				Debug.LogError("Ev Destroy Failed. Could not find PhotonView with instantiationId " + num6 + ". Sent by actorNr: " + num);
			}
			return;
		}
		case 208:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int pHIGECOLKKN = (int)hashtable2[(byte)1];
			LGPBHHOJPCA(pHIGECOLKKN, false);
			return;
		}
		case 224:
		{
			string[] array2 = ADNNKPOCCDJ[213] as string[];
			byte[] array3 = ADNNKPOCCDJ[212] as byte[];
			int[] array4 = ADNNKPOCCDJ[229] as int[];
			int[] array5 = ADNNKPOCCDJ[228] as int[];
			HOBLKOKPJOE.Clear();
			for (int i = 0; i < array2.Length; i++)
			{
				TypedLobbyInfo typedLobbyInfo = new TypedLobbyInfo();
				typedLobbyInfo.Name = array2[i];
				typedLobbyInfo.Type = (LobbyType)array3[i];
				typedLobbyInfo.PlayerCount = array4[i];
				typedLobbyInfo.RoomCount = array5[i];
				HOBLKOKPJOE.Add(typedLobbyInfo);
			}
			SendMonoMessage(PhotonNetworkingMessage.OnLobbyStatisticsUpdate);
			return;
		}
		case 251:
			if (PhotonNetwork.OnEventCall != null)
			{
				object fKODMINIAEC = ADNNKPOCCDJ[218];
				PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fKODMINIAEC, num);
			}
			else
			{
				Debug.LogWarning("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.");
			}
			return;
		case 223:
			if (AuthValues == null)
			{
				AuthValues = new AuthenticationValues();
			}
			AuthValues.Token = ADNNKPOCCDJ[221] as string;
			JOKLGFENMKE = AuthValues.Token;
			return;
		}
		if (ADNNKPOCCDJ.Code < 200)
		{
			if (PhotonNetwork.OnEventCall != null)
			{
				object fKODMINIAEC2 = ADNNKPOCCDJ[245];
				PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fKODMINIAEC2, num);
			}
			else
			{
				Debug.LogWarning(string.Concat("Warning: Unhandled event ", ADNNKPOCCDJ, ". Set PhotonNetwork.OnEventCall."));
			}
		}
	}

	private bool GDEBGIBOKCD()
	{
		AuthenticationValues authenticationValues = AuthValues;
		if (authenticationValues == null)
		{
			AuthenticationValues authenticationValues2 = new AuthenticationValues();
			authenticationValues2.PBCBCAGKCJG(PlayerName);
			authenticationValues = authenticationValues2;
		}
		AuthenticationValues gPDFHODMOIJ = authenticationValues;
		if (AuthMode == AuthModeOption.Auth)
		{
			return LBLCMEBOENM(KAIBLIKEDHM, EOCFDCJNAGM, gPDFHODMOIJ, CloudRegion.ToString(), OGLFGPKHEHH);
		}
		return OGKPIFFLGPN(KAIBLIKEDHM, EOCFDCJNAGM, gPDFHODMOIJ, CloudRegion.ToString(), EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	public override void Disconnect()
	{
		if (base.PeerState == PeerStateValue.Disconnected)
		{
			if (!PhotonHandler.MBIFDLCKGKN)
			{
				Debug.LogWarning($"Can't execute Disconnect() while not connected. Nothing changed. State: {State}");
			}
		}
		else
		{
			State = ClientState.Disconnecting;
			base.Disconnect();
		}
	}

	public override bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		if (POHIMACBDGL)
		{
			return false;
		}
		BEIPFKHGHPC = MIMEHFLKIIG;
		POHIMACBDGL = true;
		return base.OpFindFriends(MIMEHFLKIIG);
	}

	public void RemoveRPCsInGroup(int PNFBEEBFMKC)
	{
		foreach (PhotonView value in HFCMPEKPBAM.Values)
		{
			if (value.group == PNFBEEBFMKC)
			{
				CleanRpcBufferIfMine(value);
			}
		}
	}

	private void PAOJLLAACDE()
	{
		foreach (PhotonView value in HFCMPEKPBAM.Values)
		{
			value.EOENPICKCCO = null;
		}
	}

	public void FAPFPBEBONM(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.viewID == 0)
		{
			Debug.Log("_Distortion" + LCJKMJCFDGE);
			return;
		}
		PhotonView value = null;
		if (HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.PLMCHLCIABC(), out value))
		{
			if (!(LCJKMJCFDGE != value))
			{
				return;
			}
			Debug.LogError(string.Format("  |  Events Count: ", LCJKMJCFDGE.viewID, LCJKMJCFDGE, value));
			EFDAOHIDIIF(value.gameObject, false);
		}
		HFCMPEKPBAM.Add(LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)5)
		{
			Debug.Log("_Value4" + LCJKMJCFDGE.viewID);
		}
	}

	public void OpRemoveCompleteCache()
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		raiseEventOptions.Receivers = ReceiverGroup.MasterClient;
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(0, null, true, bPLHAPBMGGC);
	}

	protected internal void KHKMFIFGPCH(ServerConnection NKGHPPHEGCO)
	{
		ConnectionProtocol connectionProtocol = base.TransportProtocol;
		if (AuthMode == AuthModeOption.AuthOnceWss)
		{
			if (NKGHPPHEGCO != ServerConnection.NameServer)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): " + PhotonNetwork.PhotonServerSettings.Protocol);
				}
				connectionProtocol = PhotonNetwork.PhotonServerSettings.Protocol;
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).");
				}
				connectionProtocol = ConnectionProtocol.WebSocketSecure;
			}
		}
		Type type = null;
		type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", false);
		if (type == null)
		{
			type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", false);
		}
		if (type != null)
		{
			SocketImplementationConfig[ConnectionProtocol.WebSocket] = type;
			SocketImplementationConfig[ConnectionProtocol.WebSocketSecure] = type;
		}
		if (PhotonHandler.LEILCLLNGGH == null)
		{
			PhotonHandler.LEILCLLNGGH = typeof(PingMono);
		}
		if (base.TransportProtocol != connectionProtocol)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.LogWarning(string.Concat("Protocol switch from: ", base.TransportProtocol, " to: ", connectionProtocol, "."));
			}
			base.TransportProtocol = connectionProtocol;
		}
	}

	public void SetSendingEnabled(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			foreach (byte item in JKOIGFLNNCN)
			{
				FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			foreach (byte item2 in OBKFHNACHIA)
			{
				FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	[SpecialName]
	private void KOBHAFEHLIE(ServerConnection DPNHODJHGJL)
	{
		_003CNFFGNBHFDFM_003Ek__BackingField = DPNHODJHGJL;
	}

	private bool NGKMDAKKIOB(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return false;
		}
		for (int i = 1; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return false;
	}

	private void DGEJLOAMLHI(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	protected internal void EPGIIBMOHEG(int NADLIACHBNO, int MLBADICEKFF)
	{
		Debug.Log("RequestOwnership(): " + NADLIACHBNO + " from: " + MLBADICEKFF + " Time: " + Environment.TickCount % 1000);
		OpRaiseEvent(209, new int[2] { NADLIACHBNO, MLBADICEKFF }, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	protected internal void DKACLKKBLBO(object EPDDBAPELGI)
	{
		if (!PhotonNetwork.automaticallySyncScene || !PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (EPDDBAPELGI == null)
		{
			Debug.LogError("Parameter levelId can't be null!");
			return;
		}
		if (PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			object obj = PhotonNetwork.room.CustomProperties["curScn"];
			if ((obj is int && SceneManagerHelper.ActiveSceneBuildIndex == (int)obj) || (obj is string && SceneManagerHelper.ActiveSceneName != null && SceneManagerHelper.ActiveSceneName.Equals((string)obj)))
			{
				return;
			}
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (EPDDBAPELGI is int)
		{
			hashtable["curScn"] = (int)EPDDBAPELGI;
		}
		else if (EPDDBAPELGI is string)
		{
			hashtable["curScn"] = (string)EPDDBAPELGI;
		}
		else
		{
			Debug.LogError("Parameter levelId must be int or string!");
		}
		PhotonNetwork.room.SetCustomProperties(hashtable);
		SendOutgoingCommands();
	}

	public void DestroyPlayerObjects(int PHIGECOLKKN, bool NOKCKEBHIFJ)
	{
		if (PHIGECOLKKN <= 0)
		{
			Debug.LogError("Failed to Destroy objects of playerId: " + PHIGECOLKKN);
			return;
		}
		if (!NOKCKEBHIFJ)
		{
			NGAEPLGAGAL(PHIGECOLKKN);
			OpCleanRpcBuffer(PHIGECOLKKN);
			KCNBFALAJMD(PHIGECOLKKN);
		}
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		foreach (PhotonView value in HFCMPEKPBAM.Values)
		{
			if (value != null && value.CreatorActorNr == PHIGECOLKKN)
			{
				hashSet.Add(value.gameObject);
			}
		}
		foreach (GameObject item in hashSet)
		{
			EFDAOHIDIIF(item, true);
		}
		foreach (PhotonView value2 in HFCMPEKPBAM.Values)
		{
			if (value2.ownerId == PHIGECOLKKN)
			{
				value2.ownerId = value2.CreatorActorNr;
			}
		}
	}

	public bool CODOJHINMEH(int BONHLGFPNHF)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add((byte)78, BONHLGFPNHF);
		ExitGames.Client.Photon.Hashtable mJJMNIDHDEC = hashtable;
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add((byte)121, IMIPAHEMOCN());
		ExitGames.Client.Photon.Hashtable kCJIKJDCOAL = hashtable;
		return ENLHKMFBDMG(mJJMNIDHDEC, kCJIKJDCOAL, true);
	}

	public bool ReconnectAndRejoin()
	{
		if (AuthValues == null)
		{
			Debug.LogWarning("ReconnectAndRejoin() with AuthValues == null is not correct!");
			AuthValues = new AuthenticationValues();
		}
		AuthValues.Token = JOKLGFENMKE;
		if (!string.IsNullOrEmpty(GameServerAddress) && AJFMHFLGCFN != null)
		{
			ELNKFMHCMBO = JoinType.JoinRoom;
			AJFMHFLGCFN.RejoinOnly = true;
			return Connect(GameServerAddress, ServerConnection.GameServer);
		}
		return false;
	}

	public bool Connect(string BPMNPBDOMFO, ServerConnection HMGBJCGOLMI)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		if (State == ClientState.Disconnecting)
		{
			Debug.LogError("Connect() failed. Can't connect while disconnecting (still). Current state: " + PhotonNetwork.connectionStateDetailed);
			return false;
		}
		PKNIJKPIKAF = HMGBJCGOLMI;
		BLNBCGLIOHP = BPMNPBDOMFO;
		KAOMEDGGMEM = string.Empty;
		KHKMFIFGPCH(HMGBJCGOLMI);
		bool flag = base.Connect(BPMNPBDOMFO, string.Empty, LLJDHHLHFME);
		if (flag)
		{
			switch (HMGBJCGOLMI)
			{
			case ServerConnection.NameServer:
				State = ClientState.ConnectingToNameServer;
				break;
			case ServerConnection.MasterServer:
				State = ClientState.ConnectingToMasterserver;
				break;
			case ServerConnection.GameServer:
				State = ClientState.ConnectingToGameserver;
				break;
			}
		}
		return flag;
	}

	public void DEECBOGGANC()
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.AddToRoomCache;
		raiseEventOptions.Receivers = ReceiverGroup.All;
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		JCCNCJFOMNB(1, null, true, bPLHAPBMGGC);
	}

	private void CKEAHPJAGOO(object[] NOJGGCLPPAM, PhotonPlayer NFOGDAHIPNP, int BFELEJPLADE, short DKCPAJGKHNI)
	{
		int num = (int)NOJGGCLPPAM[0];
		PhotonView photonView = GetPhotonView(num);
		if (photonView == null)
		{
			Debug.LogWarning("Received OnSerialization for view ID " + num + ". We have no such PhotonView! Ignored this if you're leaving a room. State: " + State);
		}
		else if (photonView.prefix > 0 && DKCPAJGKHNI != photonView.prefix)
		{
			Debug.LogError("Received OnSerialization for view ID " + num + " with prefix " + DKCPAJGKHNI + ". Our prefix is " + photonView.prefix);
		}
		else
		{
			if (photonView.group != 0 && !CHIJNBAJIHE.Contains(photonView.group))
			{
				return;
			}
			if (photonView.synchronization == ViewSynchronization.ReliableDeltaCompressed)
			{
				object[] array = EFKMNFNHJBL(photonView.EMJBOOJPAII, NOJGGCLPPAM);
				if (array == null)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log("Skipping packet for " + photonView.name + " [" + photonView.viewID + "] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.");
					}
					return;
				}
				photonView.EMJBOOJPAII = array;
				NOJGGCLPPAM = array;
			}
			if (NFOGDAHIPNP.ID != photonView.ownerId && (!photonView.OwnerShipWasTransfered || photonView.ownerId == 0) && photonView.currentMasterID == -1)
			{
				photonView.ownerId = NFOGDAHIPNP.ID;
			}
			CMABENLIOGI.SetReadStream(NOJGGCLPPAM, 3);
			photonView.DeserializeView(DAGALCAILLN: new PhotonMessageInfo(NFOGDAHIPNP, BFELEJPLADE, photonView), HCIJEDFCNOP: CMABENLIOGI);
		}
	}

	private void EDMCCPDDDCC(ExitGames.Client.Photon.Hashtable MJJMNIDHDEC, ExitGames.Client.Photon.Hashtable FAOLPBLCKFJ, int AHNMANJKONI)
	{
		if (FAOLPBLCKFJ != null && FAOLPBLCKFJ.Count > 0)
		{
			if (AHNMANJKONI > 0)
			{
				PhotonPlayer photonPlayer = ICMGDHDNIJD(AHNMANJKONI);
				if (photonPlayer != null)
				{
					ExitGames.Client.Photon.Hashtable hashtable = LOCGDJDHCHJ(FAOLPBLCKFJ, AHNMANJKONI);
					photonPlayer.NPOPPIMCDMN(hashtable);
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, photonPlayer, hashtable);
				}
			}
			else
			{
				foreach (object key in FAOLPBLCKFJ.Keys)
				{
					int num = (int)key;
					ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)FAOLPBLCKFJ[key];
					string eBEHBBDKDFJ = (string)hashtable2[byte.MaxValue];
					PhotonPlayer photonPlayer2 = ICMGDHDNIJD(num);
					if (photonPlayer2 == null)
					{
						photonPlayer2 = new PhotonPlayer(false, num, eBEHBBDKDFJ);
						EGJBHECFAOH(num, photonPlayer2);
					}
					photonPlayer2.NPOPPIMCDMN(hashtable2);
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, photonPlayer2, hashtable2);
				}
			}
		}
		if (CurrentRoom != null && MJJMNIDHDEC != null)
		{
			CurrentRoom.NPOPPIMCDMN(MJJMNIDHDEC);
			SendMonoMessage(PhotonNetworkingMessage.OnPhotonCustomRoomPropertiesChanged, MJJMNIDHDEC);
			if (PhotonNetwork.automaticallySyncScene)
			{
				DMCKEABNFPJ();
			}
		}
	}

	public void OnMessage(object NBCIEBFNLGN)
	{
	}

	[SpecialName]
	public int IMIPAHEMOCN()
	{
		if (PhotonNetwork.offlineMode)
		{
			return LocalPlayer.FHEAKIMCKJC();
		}
		return (CurrentRoom == null) ? 1 : CurrentRoom.EJLAPIIGIMI;
	}

	public override bool OpJoinRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (!(HBJBKOPJDKJ.OnGameServer = EHALCLFLGJF == ServerConnection.GameServer))
		{
			AJFMHFLGCFN = HBJBKOPJDKJ;
		}
		ELNKFMHCMBO = ((!HBJBKOPJDKJ.CreateIfNotExists) ? JoinType.JoinRoom : JoinType.JoinOrCreateRoom);
		return base.OpJoinRoom(HBJBKOPJDKJ);
	}

	private object[] EFKMNFNHJBL(object[] EMJBOOJPAII, object[] JGHJOJFOGCO)
	{
		if (!(bool)JGHJOJFOGCO[1])
		{
			return JGHJOJFOGCO;
		}
		if (EMJBOOJPAII == null)
		{
			return null;
		}
		int[] array = JGHJOJFOGCO[2] as int[];
		for (int i = 3; i < JGHJOJFOGCO.Length; i++)
		{
			if ((array == null || !array.Contains(i)) && JGHJOJFOGCO[i] == null)
			{
				object obj = (JGHJOJFOGCO[i] = EMJBOOJPAII[i]);
			}
		}
		return JGHJOJFOGCO;
	}

	private void MJMAJHJLBPJ(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log("HandleEventLeave for player ID: " + IECJKEIJLCP + " evLeave: " + EKDHPAFJKFA.ToStringFull());
		}
		PhotonPlayer photonPlayer = ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError($"Received event Leave for unknown player ID: {IECJKEIJLCP}");
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(233))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[233];
			if (photonPlayer.IsInactive != isInactive)
			{
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, photonPlayer);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				Debug.LogWarning("HandleEventLeave for player ID: " + IECJKEIJLCP + " isInactive: " + photonPlayer.IsInactive + ". Stopping handling if inactive.");
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(203))
		{
			if ((int)EKDHPAFJKFA[203] != 0)
			{
				mMasterClientId = (int)EKDHPAFJKFA[203];
				ELDLAPJAPBJ();
			}
		}
		else if (!CurrentRoom.BDHOOLIDFJO)
		{
			CDNPLJILLFC(IECJKEIJLCP);
		}
		if (!photonPlayer.IsInactive || isInactive)
		{
			if (CurrentRoom != null && CurrentRoom.AutoCleanUp)
			{
				DestroyPlayerObjects(IECJKEIJLCP, true);
			}
			GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
			SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerDisconnected, photonPlayer);
		}
	}

	private bool IHAJPLJACML(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return false;
		}
		for (int i = 0; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return true;
	}

	private void NDPIAMOMGME()
	{
		switch (EHALCLFLGJF)
		{
		case ServerConnection.NameServer:
			State = ClientState.DisconnectingFromNameServer;
			base.Disconnect();
			break;
		case ServerConnection.MasterServer:
			State = ClientState.DisconnectingFromMasterserver;
			base.Disconnect();
			break;
		case ServerConnection.GameServer:
			State = ClientState.DisconnectingFromGameserver;
			base.Disconnect();
			break;
		}
	}

	private ExitGames.Client.Photon.Hashtable HHPBLGDNDOP()
	{
		if (PhotonNetwork.player != null)
		{
			return PhotonNetwork.player.AllProperties;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[byte.MaxValue] = PlayerName;
		return hashtable;
	}

	private void BOJKDNJHBNG()
	{
		bool flag = CurrentRoom != null;
		bool flag2 = ((CurrentRoom == null) ? PhotonNetwork.autoCleanUpPlayerObjects : CurrentRoom.AutoCleanUp);
		hasSwitchedMC = false;
		CurrentRoom = null;
		mActors = new Dictionary<int, PhotonPlayer>();
		mPlayerListCopy = new PhotonPlayer[0];
		mOtherPlayerListCopy = new PhotonPlayer[0];
		CHIJNBAJIHE = new HashSet<byte>();
		FFBGBLFBHOK = new HashSet<byte>();
		mGameList = new Dictionary<string, RoomInfo>();
		mGameListCopy = new RoomInfo[0];
		POHIMACBDGL = false;
		ChangeLocalID(-1);
		if (flag2)
		{
			OMEPCMPKIJK(true);
			PhotonNetwork.JMCPHFPJEJC = new List<int>();
		}
		if (flag)
		{
			SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom);
		}
	}

	[SpecialName]
	public TypedLobby BOBIFHPDAOK()
	{
		return _003CIGGEJKPFJJD_003Ek__BackingField;
	}

	private void GKNPNNKFFAL(int HOBFECDCMIL)
	{
		IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	public BNGIGHBHPEH(string OBCEIJGMKGB, ConnectionProtocol FDGOINDINNH)
		: base(FDGOINDINNH)
	{
		base.Listener = this;
		base.LimitOfUnreliableCommands = 40;
		lobby = TypedLobby.Default;
		PlayerName = OBCEIJGMKGB;
		LocalPlayer = new PhotonPlayer(true, -1, this.OBCEIJGMKGB);
		EGJBHECFAOH(LocalPlayer.ID, LocalPlayer);
		CPLBCMDIGNB = new Dictionary<string, int>(PhotonNetwork.PhotonServerSettings.RpcList.Count);
		for (int i = 0; i < PhotonNetwork.PhotonServerSettings.RpcList.Count; i++)
		{
			string key = PhotonNetwork.PhotonServerSettings.RpcList[i];
			CPLBCMDIGNB[key] = i;
		}
		State = ClientState.PeerCreated;
	}

	internal void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, PhotonPlayer JHOEDACNNKK, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		if (FFBGBLFBHOK.Contains(DFIHBOEOJPI.group))
		{
			return;
		}
		if (DFIHBOEOJPI.viewID < 1)
		{
			Debug.LogError("Illegal view ID:" + DFIHBOEOJPI.viewID + " method: " + LBLKDNNPACO + " GO:" + DFIHBOEOJPI.gameObject.name);
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log(string.Concat("Sending RPC \"", LBLKDNNPACO, "\" to target: ", MPNMOONBMII, " or player:", JHOEDACNNKK, "."));
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = DFIHBOEOJPI.viewID;
		if (DFIHBOEOJPI.prefix > 0)
		{
			hashtable[(byte)1] = (short)DFIHBOEOJPI.prefix;
		}
		hashtable[(byte)2] = PhotonNetwork.ServerTimestamp;
		int value = 0;
		if (CPLBCMDIGNB.TryGetValue(LBLKDNNPACO, out value))
		{
			hashtable[(byte)5] = (byte)value;
		}
		else
		{
			hashtable[(byte)3] = LBLKDNNPACO;
		}
		if (GNNEKCBOBEG != null && GNNEKCBOBEG.Length > 0)
		{
			hashtable[(byte)4] = GNNEKCBOBEG;
		}
		if (JHOEDACNNKK != null)
		{
			if (LocalPlayer.ID == JHOEDACNNKK.ID)
			{
				MBCHEFNAJFH(hashtable, JHOEDACNNKK.ID);
				return;
			}
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.TargetActors = new int[1] { JHOEDACNNKK.ID };
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC);
			return;
		}
		switch (MPNMOONBMII)
		{
		case PhotonTargets.All:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.InterestGroup = DFIHBOEOJPI.group;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC8 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC8);
			MBCHEFNAJFH(hashtable, LocalPlayer.ID);
			break;
		}
		case PhotonTargets.Others:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.InterestGroup = DFIHBOEOJPI.group;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC7 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC7);
			break;
		}
		case PhotonTargets.AllBuffered:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.CachingOption = EventCaching.AddToRoomCache;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC5 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC5);
			MBCHEFNAJFH(hashtable, LocalPlayer.ID);
			break;
		}
		case PhotonTargets.OthersBuffered:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.CachingOption = EventCaching.AddToRoomCache;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC3 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC3);
			break;
		}
		case PhotonTargets.MasterClient:
		{
			if (mMasterClientId == LocalPlayer.ID)
			{
				MBCHEFNAJFH(hashtable, LocalPlayer.ID);
				break;
			}
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.Receivers = ReceiverGroup.MasterClient;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC6 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC6);
			break;
		}
		case PhotonTargets.AllViaServer:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.InterestGroup = DFIHBOEOJPI.group;
			raiseEventOptions.Receivers = ReceiverGroup.All;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC4 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC4);
			if (PhotonNetwork.offlineMode)
			{
				MBCHEFNAJFH(hashtable, LocalPlayer.ID);
			}
			break;
		}
		case PhotonTargets.AllBufferedViaServer:
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.InterestGroup = DFIHBOEOJPI.group;
			raiseEventOptions.Receivers = ReceiverGroup.All;
			raiseEventOptions.CachingOption = EventCaching.AddToRoomCache;
			raiseEventOptions.Encrypt = AKFHJNFOCDP;
			RaiseEventOptions bPLHAPBMGGC2 = raiseEventOptions;
			OpRaiseEvent(200, hashtable, true, bPLHAPBMGGC2);
			if (PhotonNetwork.offlineMode)
			{
				MBCHEFNAJFH(hashtable, LocalPlayer.ID);
			}
			break;
		}
		default:
			Debug.LogError("Unsupported target enum: " + MPNMOONBMII);
			break;
		}
	}

	public override bool GPJCOHMKODA(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		AJFMHFLGCFN = new AKBOPCNHFFJ();
		AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		ELNKFMHCMBO = (JoinType)4;
		return base.IDCMLGBBFMG(IFIMMPPLLHI);
	}

	private void GPODJOPLJPD(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		mActors.Remove(IJAEJMNLBLK);
		if (!JHOEDACNNKK.IsLocal)
		{
			LEMBPMNPHCK();
		}
	}

	public void DebugReturn(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		switch (DCMIEONIJMA)
		{
		case DebugLevel.ERROR:
			Debug.LogError(JKPJCEMPAGH);
			return;
		case DebugLevel.WARNING:
			Debug.LogWarning(JKPJCEMPAGH);
			return;
		case DebugLevel.INFO:
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(JKPJCEMPAGH);
				return;
			}
			break;
		}
		if (DCMIEONIJMA == DebugLevel.ALL && PhotonNetwork.logLevel == PhotonLogLevel.Full)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	protected internal void MBCHEFNAJFH(ExitGames.Client.Photon.Hashtable LKGFKFMABPG, int BGNEKPOLEEP = 0)
	{
		if (LKGFKFMABPG == null || !LKGFKFMABPG.ContainsKey((byte)0))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		int num = (int)LKGFKFMABPG[(byte)0];
		int num2 = 0;
		if (LKGFKFMABPG.ContainsKey((byte)1))
		{
			num2 = (short)LKGFKFMABPG[(byte)1];
		}
		string text;
		if (LKGFKFMABPG.ContainsKey((byte)5))
		{
			int num3 = (byte)LKGFKFMABPG[(byte)5];
			if (num3 > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1)
			{
				Debug.LogError("Could not find RPC with index: " + num3 + ". Going to ignore! Check PhotonServerSettings.RpcList");
				return;
			}
			text = PhotonNetwork.PhotonServerSettings.RpcList[num3];
		}
		else
		{
			text = (string)LKGFKFMABPG[(byte)3];
		}
		object[] array = null;
		if (LKGFKFMABPG.ContainsKey((byte)4))
		{
			array = (object[])LKGFKFMABPG[(byte)4];
		}
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = GetPhotonView(num);
		if (photonView == null)
		{
			int num4 = num / PhotonNetwork.MAX_VIEW_IDS;
			bool flag = num4 == LocalPlayer.ID;
			bool flag2 = num4 == BGNEKPOLEEP;
			if (flag)
			{
				Debug.LogWarning("Received RPC \"" + text + "\" for viewID " + num + " but this PhotonView does not exist! View was/is ours." + ((!flag2) ? " Remote called." : " Owner called.") + " By: " + BGNEKPOLEEP);
			}
			else
			{
				Debug.LogWarning("Received RPC \"" + text + "\" for viewID " + num + " but this PhotonView does not exist! Was remote PV." + ((!flag2) ? " Remote called." : " Owner called.") + " By: " + BGNEKPOLEEP + " Maybe GO was destroyed but RPC not cleaned up.");
			}
			return;
		}
		if (photonView.prefix != num2)
		{
			Debug.LogError("Received RPC \"" + text + "\" on viewID " + num + " with a prefix of " + num2 + ", our prefix is " + photonView.prefix + ". The RPC has been ignored.");
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Received RPC: " + text);
		}
		if (photonView.group != 0 && !CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		Type[] array2 = new Type[0];
		if (array.Length > 0)
		{
			array2 = new Type[array.Length];
			int num5 = 0;
			foreach (object obj in array)
			{
				if (obj == null)
				{
					array2[num5] = null;
				}
				else
				{
					array2[num5] = obj.GetType();
				}
				num5++;
			}
		}
		int num6 = 0;
		int num7 = 0;
		if (!PhotonNetwork.UseRpcMonoBehaviourCache || photonView.HFCEJMOIGDF == null || photonView.HFCEJMOIGDF.Length == 0)
		{
			photonView.RefreshRpcMonoBehaviourCache();
		}
		for (int j = 0; j < photonView.HFCEJMOIGDF.Length; j++)
		{
			MonoBehaviour monoBehaviour = photonView.HFCEJMOIGDF[j];
			if (monoBehaviour == null)
			{
				Debug.LogError("ERROR You have missing MonoBehaviours on your gameobjects!");
				continue;
			}
			Type type = monoBehaviour.GetType();
			List<MethodInfo> value = null;
			if (!MNKFMEHFNKJ.TryGetValue(type, out value))
			{
				List<MethodInfo> methods = SupportClass.GetMethods(type, typeof(PunRPC));
				MNKFMEHFNKJ[type] = methods;
				value = methods;
			}
			if (value == null)
			{
				continue;
			}
			for (int k = 0; k < value.Count; k++)
			{
				MethodInfo methodInfo = value[k];
				if (!methodInfo.Name.Equals(text))
				{
					continue;
				}
				num7++;
				ParameterInfo[] cachedParemeters = methodInfo.GetCachedParemeters();
				if (cachedParemeters.Length == array2.Length)
				{
					if (IHAJPLJACML(cachedParemeters, array2))
					{
						num6++;
						object obj2 = methodInfo.Invoke(monoBehaviour, array);
						if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
						{
							monoBehaviour.StartCoroutine((IEnumerator)obj2);
						}
					}
				}
				else if (cachedParemeters.Length - 1 == array2.Length)
				{
					if (IHAJPLJACML(cachedParemeters, array2) && cachedParemeters[cachedParemeters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
					{
						num6++;
						int aMCIAILLAIB = (int)LKGFKFMABPG[(byte)2];
						object[] array3 = new object[array.Length + 1];
						array.CopyTo(array3, 0);
						array3[array3.Length - 1] = new PhotonMessageInfo(ICMGDHDNIJD(BGNEKPOLEEP), aMCIAILLAIB, photonView);
						object obj3 = methodInfo.Invoke(monoBehaviour, array3);
						if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
						{
							monoBehaviour.StartCoroutine((IEnumerator)obj3);
						}
					}
				}
				else if (cachedParemeters.Length == 1 && cachedParemeters[0].ParameterType.IsArray)
				{
					num6++;
					object obj4 = methodInfo.Invoke(monoBehaviour, new object[1] { array });
					if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
					{
						monoBehaviour.StartCoroutine((IEnumerator)obj4);
					}
				}
			}
		}
		if (num6 == 1)
		{
			return;
		}
		string text2 = string.Empty;
		foreach (Type type2 in array2)
		{
			if (text2 != string.Empty)
			{
				text2 += ", ";
			}
			text2 = ((type2 != null) ? (text2 + type2.Name) : (text2 + "null"));
		}
		if (num6 == 0)
		{
			if (num7 == 0)
			{
				Debug.LogError("PhotonView with ID " + num + " has no method \"" + text + "\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: " + text2);
			}
			else
			{
				Debug.LogError("PhotonView with ID " + num + " has no method \"" + text + "\" that takes " + array2.Length + " argument(s): " + text2);
			}
		}
		else
		{
			Debug.LogError("PhotonView with ID " + num + " has " + num6 + " methods \"" + text + "\" that takes " + array2.Length + " argument(s): " + text2 + ". Should be just one?");
		}
	}

	[SpecialName]
	internal void CNMLBBFHKOD(PhotonPlayer DPNHODJHGJL)
	{
		_003CNHOFDHIGABI_003Ek__BackingField = DPNHODJHGJL;
	}

	public bool ConnectToRegionMaster(CloudRegionCode LPCNAHJGAFK)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		IsUsingNameServer = true;
		CloudRegion = LPCNAHJGAFK;
		if (State == ClientState.ConnectedToNameServer)
		{
			return OELIGNFABAJ();
		}
		PKNIJKPIKAF = ServerConnection.NameServer;
		BLNBCGLIOHP = NameServerAddress;
		KAOMEDGGMEM = "ns";
		KHKMFIFGPCH(ServerConnection.NameServer);
		if (!base.Connect(NameServerAddress, "ns", LLJDHHLHFME))
		{
			return false;
		}
		State = ClientState.ConnectingToNameServer;
		return true;
	}

	public void ADIPGEIPMBK(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		switch (DCMIEONIJMA)
		{
		case DebugLevel.OFF:
			Debug.LogError(JKPJCEMPAGH);
			return;
		case DebugLevel.ERROR:
			Debug.LogWarning(JKPJCEMPAGH);
			return;
		case DebugLevel.WARNING:
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(JKPJCEMPAGH);
				return;
			}
			break;
		}
		if (DCMIEONIJMA == (DebugLevel)6 && PhotonNetwork.logLevel == PhotonLogLevel.Full)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	public override bool Connect(string BPMNPBDOMFO, string KKBGACJIHDP)
	{
		Debug.LogError("Avoid using this directly. Thanks.");
		return false;
	}

	public bool LocalCleanPhotonView(PhotonView DFIHBOEOJPI)
	{
		DFIHBOEOJPI.IHPAIFIHLAE = true;
		return HFCMPEKPBAM.Remove(DFIHBOEOJPI.viewID);
	}

	[SpecialName]
	internal void KJEHFHLGFIM(int DPNHODJHGJL)
	{
		_003CBBNAEKGKOKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private ExitGames.Client.Photon.Hashtable LOCGDJDHCHJ(ExitGames.Client.Photon.Hashtable FPBCPOGCCBD, int KHACEEGCPEP)
	{
		if (FPBCPOGCCBD.ContainsKey(KHACEEGCPEP))
		{
			return (ExitGames.Client.Photon.Hashtable)FPBCPOGCCBD[KHACEEGCPEP];
		}
		return FPBCPOGCCBD;
	}

	public void SetLevelPrefix(short MOALALKJCKJ)
	{
		PKCNHOKCLJH = MOALALKJCKJ;
	}

	public override bool NEGBMLGHJPD(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		if (PhotonNetwork.offlineMode)
		{
			return false;
		}
		return base.KJNCENGOFBE(IMCBEMICJFC, PEIFAPIIKNJ, ANMGHMBBMAO, BPLHAPBMGGC);
	}

	private void IFPPBJINADG()
	{
		mGameList = new Dictionary<string, RoomInfo>();
		mGameListCopy = new RoomInfo[0];
		if (insideLobby)
		{
			insideLobby = false;
			SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby);
		}
	}

	private void NGAEPLGAGAL(int KHACEEGCPEP)
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		raiseEventOptions.TargetActors = new int[1] { KHACEEGCPEP };
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(202, null, true, bPLHAPBMGGC);
	}

	private void OPKEDOEIKCO(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			object[] array = new object[8];
			array[0] = "Could not find RPC with index: ";
			array[1] = IECJKEIJLCP;
			array[6] = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
			array[4] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("_HighlightSuppression", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(161))
		{
			photonPlayer.EJABLLBGMGC((bool)EKDHPAFJKFA.Parameters[36]);
			if (photonPlayer.IsInactive != isInactive)
			{
				object[] array2 = new object[0];
				array2[0] = photonPlayer;
				SendMonoMessage((PhotonNetworkingMessage)(-102), array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[7];
				array3[1] = "_Offsets";
				array3[0] = IECJKEIJLCP;
				array3[3] = "_TimeX";
				array3[7] = photonPlayer.IsInactive;
				array3[5] = "maps.";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(44))
		{
			if ((int)EKDHPAFJKFA[72] != 0)
			{
				mMasterClientId = (int)EKDHPAFJKFA[239];
				ELDLAPJAPBJ();
			}
		}
		else if (!CurrentRoom.BDHOOLIDFJO)
		{
			ANCHCNAJLOJ(IECJKEIJLCP);
		}
		if (!photonPlayer.IsInactive || isInactive)
		{
			if (CurrentRoom != null && CurrentRoom.HGADABNHIFG())
			{
				DestroyPlayerObjects(IECJKEIJLCP, false);
			}
			GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
			object[] array4 = new object[0];
			array4[1] = photonPlayer;
			SendMonoMessage(PhotonNetworkingMessage.OnWebRpcResponse, array4);
		}
	}

	public override bool OpRaiseEvent(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		if (PhotonNetwork.offlineMode)
		{
			return false;
		}
		return base.OpRaiseEvent(IMCBEMICJFC, PEIFAPIIKNJ, ANMGHMBBMAO, BPLHAPBMGGC);
	}

	public object[] FetchInstantiationData(int HOBFECDCMIL)
	{
		object[] value = null;
		if (HOBFECDCMIL == 0)
		{
			return null;
		}
		IDIKEJLLFFP.TryGetValue(HOBFECDCMIL, out value);
		return value;
	}

	private void KIAFOHLEGJO(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			object[] array = new object[3];
			array[0] = " ";
			array[1] = IECJKEIJLCP;
			array[5] = "_ClutTex";
			array[4] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("<b>Time</b>:", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(49))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[24];
			if (photonPlayer.IsInactive != isInactive)
			{
				object[] array2 = new object[1];
				array2[1] = photonPlayer;
				GHLJAECJCKF((PhotonNetworkingMessage)(-8), array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[1];
				array3[0] = "0,7,true,0";
				array3[1] = IECJKEIJLCP;
				array3[5] = ";";
				array3[6] = photonPlayer.IsInactive;
				array3[7] = "_Value";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(72))
		{
			if ((int)EKDHPAFJKFA[82] != 0)
			{
				mMasterClientId = (int)EKDHPAFJKFA[8];
				ELDLAPJAPBJ();
			}
		}
		else if (!CurrentRoom.PPODOKJKEHE())
		{
			ANCHCNAJLOJ(IECJKEIJLCP);
		}
		if (!photonPlayer.IsInactive || isInactive)
		{
			if (CurrentRoom != null && CurrentRoom.AutoCleanUp)
			{
				DestroyPlayerObjects(IECJKEIJLCP, false);
			}
			GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
			object[] array4 = new object[1];
			array4[1] = photonPlayer;
			GHLJAECJCKF((PhotonNetworkingMessage)98, array4);
		}
	}

	public void JAAICPFDENO(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	[SpecialName]
	public string BDJGCHOLCJN()
	{
		return IHAJBEOILOE();
	}

	protected internal void DLFAOFKNNHF()
	{
		if (!PhotonNetwork.automaticallySyncScene || PhotonNetwork.isMasterClient || PhotonNetwork.room == null || !PhotonNetwork.room.CustomProperties.ContainsKey("#discord{0}joinrequest"))
		{
			return;
		}
		object obj = PhotonNetwork.room.GBLNGKOOEMH()["maps."];
		if (obj is int)
		{
			if (SceneManagerHelper.AKDJMHNDCBO() != (int)obj)
			{
				PhotonNetwork.LoadLevel((int)obj);
			}
		}
		else if (obj is string && SceneManagerHelper.JFNAOCLGCFO() != (string)obj)
		{
			PhotonNetwork.LoadLevel((string)obj);
		}
	}

	public bool OpCreateGame(AKBOPCNHFFJ BDMKOAGEHPM)
	{
		bool flag = (BDMKOAGEHPM.OnGameServer = EHALCLFLGJF == ServerConnection.GameServer);
		BDMKOAGEHPM.PlayerProperties = HHPBLGDNDOP();
		if (!flag)
		{
			AJFMHFLGCFN = BDMKOAGEHPM;
		}
		ELNKFMHCMBO = JoinType.CreateRoom;
		return base.OpCreateRoom(BDMKOAGEHPM);
	}

	public void OnStatusChanged(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log($"OnStatusChanged: {FIIDDDBNCLD.ToString()} current State: {State}");
		}
		switch (FIIDDDBNCLD)
		{
		case StatusCode.Connect:
			if (State == ClientState.ConnectingToNameServer)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
				{
					Debug.Log("Connected to NameServer.");
				}
				EHALCLFLGJF = ServerConnection.NameServer;
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
			}
			if (State == ClientState.ConnectingToGameserver)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
				{
					Debug.Log("Connected to gameserver.");
				}
				EHALCLFLGJF = ServerConnection.GameServer;
				State = ClientState.ConnectedToGameserver;
			}
			if (State == ClientState.ConnectingToMasterserver)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
				{
					Debug.Log("Connected to masterserver.");
				}
				EHALCLFLGJF = ServerConnection.MasterServer;
				State = ClientState.Authenticating;
				if (IsInitialConnect)
				{
					IsInitialConnect = false;
					SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton);
				}
			}
			if (base.TransportProtocol != ConnectionProtocol.WebSocketSecure)
			{
				if (EHALCLFLGJF == ServerConnection.NameServer || AuthMode == AuthModeOption.Auth)
				{
					EstablishEncryption();
				}
				break;
			}
			if (DebugOut == DebugLevel.INFO)
			{
				Debug.Log("Skipping EstablishEncryption. Protocol is secure.");
			}
			goto case StatusCode.EncryptionEstablished;
		case StatusCode.EncryptionEstablished:
			IDOAHFHJJJE = false;
			if (EHALCLFLGJF == ServerConnection.NameServer)
			{
				State = ClientState.ConnectedToNameServer;
				if (!DMCPHGDNGDB && CloudRegion == CloudRegionCode.none)
				{
					OpGetRegions(KAIBLIKEDHM);
				}
			}
			if (EHALCLFLGJF != ServerConnection.NameServer && (AuthMode == AuthModeOption.AuthOnce || AuthMode == AuthModeOption.AuthOnceWss))
			{
				Debug.Log("didAuthenticate " + DMCPHGDNGDB + " AuthMode " + AuthMode);
			}
			else if (!DMCPHGDNGDB && (!IsUsingNameServer || CloudRegion != CloudRegionCode.none))
			{
				DMCPHGDNGDB = OELIGNFABAJ();
				if (DMCPHGDNGDB)
				{
					State = ClientState.Authenticating;
				}
			}
			break;
		case StatusCode.EncryptionFailedToEstablish:
		{
			Debug.LogError(string.Concat("Encryption wasn't established: ", FIIDDDBNCLD, ". Going to authenticate anyways."));
			AuthenticationValues authenticationValues = AuthValues;
			if (authenticationValues == null)
			{
				AuthenticationValues authenticationValues2 = new AuthenticationValues();
				authenticationValues2.UserId = PlayerName;
				authenticationValues = authenticationValues2;
			}
			AuthenticationValues gPDFHODMOIJ = authenticationValues;
			OpAuthenticate(KAIBLIKEDHM, EOCFDCJNAGM, gPDFHODMOIJ, CloudRegion.ToString(), OGLFGPKHEHH);
			break;
		}
		case StatusCode.Disconnect:
			DMCPHGDNGDB = false;
			POHIMACBDGL = false;
			if (EHALCLFLGJF == ServerConnection.GameServer)
			{
				BOJKDNJHBNG();
			}
			if (EHALCLFLGJF == ServerConnection.MasterServer)
			{
				IFPPBJINADG();
			}
			if (State == ClientState.DisconnectingFromMasterserver)
			{
				if (Connect(GameServerAddress, ServerConnection.GameServer))
				{
					State = ClientState.ConnectingToGameserver;
				}
			}
			else if (State == ClientState.DisconnectingFromGameserver || State == ClientState.DisconnectingFromNameServer)
			{
				KHKMFIFGPCH(ServerConnection.MasterServer);
				if (Connect(MasterServerAddress, ServerConnection.MasterServer))
				{
					State = ClientState.ConnectingToMasterserver;
				}
			}
			else if (!IDOAHFHJJJE)
			{
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				IsInitialConnect = false;
				State = ClientState.PeerCreated;
				SendMonoMessage(PhotonNetworkingMessage.OnDisconnectedFromPhoton);
			}
			break;
		case StatusCode.SecurityExceptionOnConnect:
		case StatusCode.ExceptionOnConnect:
		{
			IsInitialConnect = false;
			State = ClientState.PeerCreated;
			if (AuthValues != null)
			{
				AuthValues.Token = null;
			}
			DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
			SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, disconnectCause);
			break;
		}
		case StatusCode.Exception:
			if (IsInitialConnect)
			{
				Debug.LogError("Exception while connecting to: " + base.ServerAddress + ". Check if the server is available.");
				if (base.ServerAddress == null || base.ServerAddress.StartsWith("127.0.0.1"))
				{
					Debug.LogWarning("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.");
					if (base.ServerAddress == GameServerAddress)
					{
						Debug.LogWarning("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.");
					}
				}
				State = ClientState.PeerCreated;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				IsInitialConnect = false;
				SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, disconnectCause);
			}
			else
			{
				State = ClientState.PeerCreated;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, disconnectCause);
			}
			Disconnect();
			break;
		case StatusCode.TimeoutDisconnect:
			if (IsInitialConnect)
			{
				if (!IDOAHFHJJJE)
				{
					Debug.LogWarning(string.Concat(FIIDDDBNCLD, " while connecting to: ", base.ServerAddress, ". Check if the server is available."));
					IsInitialConnect = false;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, disconnectCause);
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, disconnectCause);
			}
			if (AuthValues != null)
			{
				AuthValues.Token = null;
			}
			Disconnect();
			break;
		case StatusCode.ExceptionOnReceive:
		case StatusCode.DisconnectByServer:
		case StatusCode.DisconnectByServerUserLimit:
		case StatusCode.DisconnectByServerLogic:
			if (IsInitialConnect)
			{
				Debug.LogWarning(string.Concat(FIIDDDBNCLD, " while connecting to: ", base.ServerAddress, ". Check if the server is available."));
				IsInitialConnect = false;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, disconnectCause);
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, disconnectCause);
			}
			if (AuthValues != null)
			{
				AuthValues.Token = null;
			}
			Disconnect();
			break;
		case StatusCode.SendError:
			break;
		default:
			Debug.LogError("Received unknown status code: " + FIIDDDBNCLD);
			break;
		}
	}

	public bool GetRegions()
	{
		if (EHALCLFLGJF != ServerConnection.NameServer)
		{
			return false;
		}
		bool flag = OpGetRegions(KAIBLIKEDHM);
		if (flag)
		{
			AvailableRegions = null;
		}
		return flag;
	}

	private bool LFAPOBNFPPO(object CFKDMFFFPJK, object GOLMELKEAFO)
	{
		if (CFKDMFFFPJK == null || GOLMELKEAFO == null)
		{
			return CFKDMFFFPJK == null && GOLMELKEAFO == null;
		}
		if (!CFKDMFFFPJK.Equals(GOLMELKEAFO))
		{
			if (CFKDMFFFPJK is Vector3)
			{
				Vector3 mPNMOONBMII = (Vector3)CFKDMFFFPJK;
				Vector3 bICCGCFNNLP = (Vector3)GOLMELKEAFO;
				if (mPNMOONBMII.AlmostEquals(bICCGCFNNLP, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Vector2)
			{
				Vector2 mPNMOONBMII2 = (Vector2)CFKDMFFFPJK;
				Vector2 bICCGCFNNLP2 = (Vector2)GOLMELKEAFO;
				if (mPNMOONBMII2.AlmostEquals(bICCGCFNNLP2, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Quaternion)
			{
				Quaternion mPNMOONBMII3 = (Quaternion)CFKDMFFFPJK;
				Quaternion bICCGCFNNLP3 = (Quaternion)GOLMELKEAFO;
				if (mPNMOONBMII3.AlmostEquals(bICCGCFNNLP3, PhotonNetwork.precisionForQuaternionSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is float)
			{
				float mPNMOONBMII4 = (float)CFKDMFFFPJK;
				float bICCGCFNNLP4 = (float)GOLMELKEAFO;
				if (mPNMOONBMII4.AlmostEquals(bICCGCFNNLP4, PhotonNetwork.precisionForFloatSynchronization))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	private object[] OAMPHAGPLEL(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dAGALCAILLN = new PhotonMessageInfo(LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		ALPAEKHFHPP.MKNINLEEFNI();
		ALPAEKHFHPP.SendNext(null);
		ALPAEKHFHPP.SendNext(null);
		ALPAEKHFHPP.SendNext(null);
		DFIHBOEOJPI.SerializeView(ALPAEKHFHPP, dAGALCAILLN);
		if (ALPAEKHFHPP.Count <= 3)
		{
			return null;
		}
		object[] array = ALPAEKHFHPP.ToArray();
		array[0] = DFIHBOEOJPI.viewID;
		array[1] = false;
		array[2] = null;
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Unreliable)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.UnreliableOnChange)
		{
			if (LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = true;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = MFKHMJBJDLE(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	private void PCLPOPNEABK(OperationResponse FEOMHKNGOAK)
	{
		if (FEOMHKNGOAK.ReturnCode != 0)
		{
			switch (FEOMHKNGOAK.OperationCode)
			{
			case 227:
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log("Create failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
				}
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
				break;
			case 226:
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
					if (FEOMHKNGOAK.ReturnCode == 32758)
					{
						Debug.Log("Most likely the game became empty during the switch to GameServer.");
					}
				}
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
				break;
			case 225:
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
					if (FEOMHKNGOAK.ReturnCode == 32758)
					{
						Debug.Log("Most likely the game became empty during the switch to GameServer.");
					}
				}
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
				break;
			}
			NDPIAMOMGME();
		}
		else
		{
			Room room = new Room(AJFMHFLGCFN.RoomName, null);
			room.IsLocalClientInside = true;
			CurrentRoom = room;
			State = ClientState.Joined;
			if (FEOMHKNGOAK.Parameters.ContainsKey(252))
			{
				int[] hOMAECIGJEJ = (int[])FEOMHKNGOAK.Parameters[252];
				ANEENOJMDOJ(hOMAECIGJEJ);
			}
			int lGHIPFAEONM = (int)FEOMHKNGOAK[254];
			ChangeLocalID(lGHIPFAEONM);
			ExitGames.Client.Photon.Hashtable fAOLPBLCKFJ = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
			ExitGames.Client.Photon.Hashtable mJJMNIDHDEC = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
			EDMCCPDDDCC(mJJMNIDHDEC, fAOLPBLCKFJ, 0);
			if (!CurrentRoom.BDHOOLIDFJO)
			{
				CDNPLJILLFC(-1);
			}
			if (BOKEGDFHBAN)
			{
				PACEKOIEHKK();
			}
			switch (FEOMHKNGOAK.OperationCode)
			{
			case 227:
				SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom);
				break;
			}
		}
	}

	private void BAEBFLIPKKB(Dictionary<byte, object> FNHGNHCOMBH)
	{
		if (AuthMode == AuthModeOption.Auth && DebugOut == DebugLevel.ERROR)
		{
			Debug.LogWarning("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: " + FNHGNHCOMBH.ToStringFull());
			return;
		}
		if (DebugOut == DebugLevel.INFO)
		{
			Debug.Log("SetupEncryption() got called. " + FNHGNHCOMBH.ToStringFull());
		}
		switch ((byte)FNHGNHCOMBH[0])
		{
		case 0:
		{
			byte[] secret = (byte[])FNHGNHCOMBH[1];
			InitPayloadEncryption(secret);
			break;
		}
		case 10:
		{
			byte[] encryptionSecret = (byte[])FNHGNHCOMBH[1];
			byte[] hmacSecret = (byte[])FNHGNHCOMBH[2];
			InitDatagramEncryption(encryptionSecret, hmacSecret);
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private void COOFPMNPDBH(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			object[] array = new object[2];
			array[1] = "_SpherePositionX";
			array[1] = IECJKEIJLCP;
			array[5] = "IconImage";
			array[6] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("id", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(150))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[137];
			if (photonPlayer.IsInactive != isInactive)
			{
				object[] array2 = new object[1];
				array2[1] = photonPlayer;
				SendMonoMessage((PhotonNetworkingMessage)(-72), array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[0];
				array3[1] = "_ScreenResolution";
				array3[0] = IECJKEIJLCP;
				array3[7] = "resetach21";
				array3[8] = photonPlayer.IsInactive;
				array3[7] = "UI Extensions/UIScreen";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(7))
		{
			if ((int)EKDHPAFJKFA[188] != 0)
			{
				mMasterClientId = (int)EKDHPAFJKFA[128];
				ELDLAPJAPBJ();
			}
		}
		else if (!CurrentRoom.PPODOKJKEHE())
		{
			CDNPLJILLFC(IECJKEIJLCP);
		}
		if (!photonPlayer.IsInactive || isInactive)
		{
			if (CurrentRoom != null && CurrentRoom.HGADABNHIFG())
			{
				DestroyPlayerObjects(IECJKEIJLCP, true);
			}
			GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
			object[] array4 = new object[1];
			array4[1] = photonPlayer;
			GHLJAECJCKF((PhotonNetworkingMessage)104, array4);
		}
	}

	public bool ConnectToNameServer()
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		IsUsingNameServer = true;
		CloudRegion = CloudRegionCode.none;
		if (State == ClientState.ConnectedToNameServer)
		{
			return true;
		}
		KHKMFIFGPCH(ServerConnection.NameServer);
		PKNIJKPIKAF = ServerConnection.NameServer;
		BLNBCGLIOHP = NameServerAddress;
		KAOMEDGGMEM = "ns";
		if (!base.Connect(NameServerAddress, "ns", LLJDHHLHFME))
		{
			return false;
		}
		State = ClientState.ConnectingToNameServer;
		return true;
	}

	[SpecialName]
	internal void DPOAKDGFINF(int DPNHODJHGJL)
	{
		_003CBBNAEKGKOKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void NNENGIKPKII(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.PLMCHLCIABC() == 0)
		{
			Debug.Log("help" + LCJKMJCFDGE);
			return;
		}
		PhotonView value = null;
		if (HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.PLMCHLCIABC(), out value))
		{
			if (!(LCJKMJCFDGE != value))
			{
				return;
			}
			Debug.LogError(string.Format("CameraFilterPack/3D_Mirror", LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE, value));
			EFDAOHIDIIF(value.gameObject, false);
		}
		HFCMPEKPBAM.Add(LCJKMJCFDGE.PLMCHLCIABC(), LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)8)
		{
			Debug.Log(" on effect " + LCJKMJCFDGE.viewID);
		}
	}

	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		AJFMHFLGCFN = new AKBOPCNHFFJ();
		AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		ELNKFMHCMBO = JoinType.JoinRandomRoom;
		return base.OpJoinRandomRoom(IFIMMPPLLHI);
	}

	private void MJLFCEHBMGL()
	{
		Debug.Log("SendVacantViewIds()");
		List<int> list = new List<int>();
		foreach (PhotonView value in HFCMPEKPBAM.Values)
		{
			if (!value.isOwnerActive)
			{
				list.Add(value.viewID);
			}
		}
		Debug.Log("Sending vacant view IDs. Length: " + list.Count);
		OpRaiseEvent(211, list.ToArray(), true, null);
	}

	protected internal void ANEENOJMDOJ(int[] HOMAECIGJEJ)
	{
		foreach (int num in HOMAECIGJEJ)
		{
			if (LocalPlayer.ID != num && !mActors.ContainsKey(num))
			{
				EGJBHECFAOH(num, new PhotonPlayer(false, num, string.Empty));
			}
		}
	}

	protected internal void KIHFINECBEL(ExitGames.Client.Photon.Hashtable LKGFKFMABPG, int BGNEKPOLEEP = 0)
	{
		if (LKGFKFMABPG == null || !LKGFKFMABPG.ContainsKey((byte)1))
		{
			Debug.LogError("Please attach component to a Graphical UI component" + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		int num = (int)LKGFKFMABPG[(byte)0];
		int num2 = 0;
		if (LKGFKFMABPG.ContainsKey((byte)0))
		{
			num2 = (short)LKGFKFMABPG[(byte)0];
		}
		string text;
		if (LKGFKFMABPG.ContainsKey((byte)8))
		{
			int num3 = (byte)LKGFKFMABPG[(byte)0];
			if (num3 > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1)
			{
				Debug.LogError("CameraFilterPack_eyes_vision_1" + num3 + "_Value7");
				return;
			}
			text = PhotonNetwork.PhotonServerSettings.RpcList[num3];
		}
		else
		{
			text = (string)LKGFKFMABPG[(byte)1];
		}
		object[] array = null;
		if (LKGFKFMABPG.ContainsKey((byte)0))
		{
			array = (object[])LKGFKFMABPG[(byte)1];
		}
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = LDCGKJEKICK(num);
		if (photonView == null)
		{
			int num4 = num / PhotonNetwork.MAX_VIEW_IDS;
			bool flag = num4 == LocalPlayer.FHEAKIMCKJC();
			bool flag2 = num4 == BGNEKPOLEEP;
			if (flag)
			{
				object[] array2 = new object[0];
				array2[1] = "Soundtrack";
				array2[0] = text;
				array2[3] = "Switch environment sprite image";
				array2[0] = num;
				array2[2] = "CameraFilterPack/Distortion_Twist_Square";
				array2[6] = ((!flag2) ? "#close" : "#rategameinfo");
				array2[6] = "_Value4";
				array2[2] = BGNEKPOLEEP;
				Debug.LogWarning(string.Concat(array2));
			}
			else
			{
				object[] array3 = new object[37];
				array3[1] = "_ScreenResolution";
				array3[0] = text;
				array3[3] = "\"";
				array3[8] = num;
				array3[0] = "player.playedtutorial";
				array3[5] = ((!flag2) ? "settings.arcsnohitsoundtimedelay" : "RedoButton");
				array3[5] = "_OcclusionBlurTexture";
				array3[1] = BGNEKPOLEEP;
				array3[0] = "_MainTexBlurred";
				Debug.LogWarning(string.Concat(array3));
			}
			return;
		}
		if (photonView.GFNDNEDMBLO() != num2)
		{
			object[] array4 = new object[110];
			array4[1] = "_Factor";
			array4[0] = text;
			array4[7] = "LevelEditor/CustomEventEditor-Text";
			array4[8] = num;
			array4[0] = "CameraFilterPack/3D_Computer";
			array4[2] = num2;
			array4[7] = "Item invalid. No idea why.";
			array4[7] = photonView.prefix;
			array4[1] = "Tab2Content";
			Debug.LogError(string.Concat(array4));
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_GreenScreen" + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)7)
		{
			Debug.Log("Texture2" + text);
		}
		if (photonView.group != 0 && !CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		Type[] array5 = new Type[0];
		if (array.Length > 1)
		{
			array5 = new Type[array.Length];
			int num5 = 1;
			foreach (object obj in array)
			{
				if (obj == null)
				{
					array5[num5] = null;
				}
				else
				{
					array5[num5] = obj.GetType();
				}
				num5 += 0;
			}
		}
		int num6 = 1;
		int num7 = 1;
		if (!PhotonNetwork.UseRpcMonoBehaviourCache || photonView.HFCEJMOIGDF == null || photonView.HFCEJMOIGDF.Length == 0)
		{
			photonView.RefreshRpcMonoBehaviourCache();
		}
		for (int j = 0; j < photonView.HFCEJMOIGDF.Length; j += 0)
		{
			MonoBehaviour monoBehaviour = photonView.HFCEJMOIGDF[j];
			if (monoBehaviour == null)
			{
				Debug.LogError("_Val");
				continue;
			}
			Type type = monoBehaviour.GetType();
			List<MethodInfo> value = null;
			if (!MNKFMEHFNKJ.TryGetValue(type, out value))
			{
				List<MethodInfo> methods = SupportClass.GetMethods(type, typeof(PunRPC));
				MNKFMEHFNKJ[type] = methods;
				value = methods;
			}
			if (value == null)
			{
				continue;
			}
			for (int k = 1; k < value.Count; k += 0)
			{
				MethodInfo methodInfo = value[k];
				if (!methodInfo.Name.Equals(text))
				{
					continue;
				}
				num7++;
				ParameterInfo[] cachedParemeters = methodInfo.GetCachedParemeters();
				if (cachedParemeters.Length == array5.Length)
				{
					if (IHAJPLJACML(cachedParemeters, array5))
					{
						num6 += 0;
						object obj2 = methodInfo.Invoke(monoBehaviour, array);
						if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
						{
							monoBehaviour.StartCoroutine((IEnumerator)obj2);
						}
					}
				}
				else if (cachedParemeters.Length - 0 == array5.Length)
				{
					if (NGKMDAKKIOB(cachedParemeters, array5) && cachedParemeters[cachedParemeters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
					{
						num6++;
						int aMCIAILLAIB = (int)LKGFKFMABPG[(byte)7];
						object[] array6 = new object[array.Length + 1];
						array.CopyTo(array6, 0);
						array6[array6.Length - 0] = new PhotonMessageInfo(ICMGDHDNIJD(BGNEKPOLEEP), aMCIAILLAIB, photonView);
						object obj3 = methodInfo.Invoke(monoBehaviour, array6);
						if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
						{
							monoBehaviour.StartCoroutine((IEnumerator)obj3);
						}
					}
				}
				else if (cachedParemeters.Length == 1 && cachedParemeters[1].ParameterType.IsArray)
				{
					num6 += 0;
					object[] array7 = new object[0];
					array7[0] = array;
					object obj4 = methodInfo.Invoke(monoBehaviour, array7);
					if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
					{
						monoBehaviour.StartCoroutine((IEnumerator)obj4);
					}
				}
			}
		}
		if (num6 == 0)
		{
			return;
		}
		string text2 = string.Empty;
		for (int l = 1; l < array5.Length; l += 0)
		{
			Type type2 = array5[l];
			if (text2 != string.Empty)
			{
				text2 += "/music";
			}
			text2 = ((type2 != null) ? (text2 + type2.Name) : (text2 + "CameraFilterPack/FX_Psycho"));
		}
		if (num6 == 0)
		{
			if (num7 == 0)
			{
				object[] array8 = new object[4];
				array8[0] = "CameraFilterPack/NightVisionFX";
				array8[1] = num;
				array8[8] = "ResourceIDInputField";
				array8[1] = text;
				array8[3] = "Selection Box";
				array8[7] = text2;
				Debug.LogError(string.Concat(array8));
			}
			else
			{
				object[] array9 = new object[2];
				array9[1] = "VisionBlur";
				array9[0] = num;
				array9[0] = ".b";
				array9[5] = text;
				array9[7] = "UsernameText";
				array9[6] = array5.Length;
				array9[0] = "OnMastedChangeScene";
				array9[0] = text2;
				Debug.LogError(string.Concat(array9));
			}
		}
		else
		{
			object[] array10 = new object[120];
			array10[0] = "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass";
			array10[1] = num;
			array10[3] = "value";
			array10[8] = num6;
			array10[5] = "RateButton";
			array10[6] = text;
			array10[0] = "_Fade";
			array10[5] = array5.Length;
			array10[8] = "OPEN";
			array10[30] = text2;
			array10[-94] = "colorB";
			Debug.LogError(string.Concat(array10));
		}
	}

	public void SetSendingEnabled(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	protected internal void ELDLAPJAPBJ()
	{
		SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, PhotonNetwork.masterClient);
	}

	protected internal void EFDAOHIDIIF(GameObject OBFJPHLBFOL, bool NOKCKEBHIFJ)
	{
		if (OBFJPHLBFOL == null)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because it's null.");
			return;
		}
		PhotonView[] componentsInChildren = OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
		if (componentsInChildren == null || componentsInChildren.Length <= 0)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because has no PhotonView components: " + OBFJPHLBFOL);
			return;
		}
		PhotonView photonView = componentsInChildren[0];
		int creatorActorNr = photonView.CreatorActorNr;
		int instantiationId = photonView.instantiationId;
		if (!NOKCKEBHIFJ)
		{
			if (!photonView.isMine)
			{
				Debug.LogError("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: " + photonView);
				return;
			}
			if (instantiationId < 1)
			{
				Debug.LogError(string.Concat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", photonView, ". Not Destroying GameObject or PhotonViews!"));
				return;
			}
		}
		if (!NOKCKEBHIFJ)
		{
			LLMNFGHNIND(instantiationId, creatorActorNr, photonView.isRuntimeInstantiated);
		}
		for (int num = componentsInChildren.Length - 1; num >= 0; num--)
		{
			PhotonView photonView2 = componentsInChildren[num];
			if (!(photonView2 == null))
			{
				if (photonView2.instantiationId >= 1)
				{
					LocalCleanPhotonView(photonView2);
				}
				if (!NOKCKEBHIFJ)
				{
					OpCleanRpcBuffer(photonView2);
				}
			}
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Network destroy Instantiated GO: " + OBFJPHLBFOL.name);
		}
		if (EGNHNBODKHP != null)
		{
			PhotonView[] photonViewsInChildren = OBFJPHLBFOL.GetPhotonViewsInChildren();
			for (int i = 0; i < photonViewsInChildren.Length; i++)
			{
				photonViewsInChildren[i].viewID = 0;
			}
			EGNHNBODKHP.Destroy(OBFJPHLBFOL);
		}
		else
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
	}

	[SpecialName]
	private void ONHOANHBOEC(Room DPNHODJHGJL)
	{
		NBCIDPIDCDP = DPNHODJHGJL;
	}

	public static void GHLJAECJCKF(PhotonNetworkingMessage LELHNDDCKCO, object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet = ((PhotonNetwork.SendMonoMessageTargets == null) ? PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType) : PhotonNetwork.SendMonoMessageTargets);
		string methodName = LELHNDDCKCO.ToString();
		object value = ((GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 1) ? GNNEKCBOBEG : GNNEKCBOBEG[1]);
		foreach (GameObject item in hashSet)
		{
			if (item != null)
			{
				item.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	protected internal static bool FAAKJJEMNEB(MonoBehaviour KLJMHHFGLCJ, string AOBJJJOJGGF, out MethodInfo MKLKGCPAPOC)
	{
		MKLKGCPAPOC = null;
		if (KLJMHHFGLCJ == null || string.IsNullOrEmpty(AOBJJJOJGGF))
		{
			return false;
		}
		List<MethodInfo> methods = SupportClass.GetMethods(KLJMHHFGLCJ.GetType(), null);
		for (int i = 0; i < methods.Count; i++)
		{
			MethodInfo methodInfo = methods[i];
			if (methodInfo.Name.Equals(AOBJJJOJGGF))
			{
				MKLKGCPAPOC = methodInfo;
				return true;
			}
		}
		return false;
	}

	private bool KJDCGBCHDEO()
	{
		IDOAHFHJJJE = false;
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		KHKMFIFGPCH(PKNIJKPIKAF);
		bool flag = base.Connect(BLNBCGLIOHP, KAOMEDGGMEM, LLJDHHLHFME);
		if (flag)
		{
			switch (PKNIJKPIKAF)
			{
			case (ServerConnection)8:
				HNCIIMJABOJ((ClientState)75);
				break;
			case ServerConnection.MasterServer:
				HNCIIMJABOJ((ClientState)(-49));
				break;
			case ServerConnection.GameServer:
				HNCIIMJABOJ(ClientState.JoinedLobby);
				break;
			}
		}
		return flag;
	}

	private void PACEKOIEHKK()
	{
		if (State == ClientState.Joining)
		{
			BOKEGDFHBAN = true;
		}
		else if (LocalPlayer != null)
		{
			LocalPlayer.NickName = PlayerName;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable[byte.MaxValue] = PlayerName;
			if (LocalPlayer.ID > 0)
			{
				LJEFICMOPMO(LocalPlayer.ID, hashtable);
				BOKEGDFHBAN = false;
			}
		}
	}

	public virtual bool OpLeave()
	{
		if (State != ClientState.Joined)
		{
			Debug.LogWarning("Not sending leave operation. State is not 'Joined': " + State);
			return false;
		}
		return OpCustom(254, null, true, 0);
	}

	[SpecialName]
	public string GGICLEMHOEM()
	{
		return _003CKIHCLAFJDGA_003Ek__BackingField;
	}

	public void OnOperationResponse(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.State == ClientState.Disconnecting)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("OperationResponse ignored while disconnecting. Code: " + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == -3)
		{
			Debug.LogError("Operation " + FEOMHKNGOAK.OperationCode + " could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.");
		}
		else if (FEOMHKNGOAK.ReturnCode == 32752)
		{
			Debug.LogError("Operation " + FEOMHKNGOAK.OperationCode + " failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: " + FEOMHKNGOAK.DebugMessage);
		}
		else if (FEOMHKNGOAK.ReturnCode == 32760)
		{
			Debug.LogWarning("Operation failed: " + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			Debug.LogError("Operation failed: " + FEOMHKNGOAK.ToStringFull() + " Server: " + EHALCLFLGJF);
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey(221))
		{
			if (AuthValues == null)
			{
				AuthValues = new AuthenticationValues();
			}
			AuthValues.Token = FEOMHKNGOAK[221] as string;
			JOKLGFENMKE = AuthValues.Token;
		}
		switch (FEOMHKNGOAK.OperationCode)
		{
		case 230:
		case 231:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == -2)
				{
					Debug.LogError(string.Format("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' " + base.ServerAddress));
				}
				else if (FEOMHKNGOAK.ReturnCode == short.MaxValue)
				{
					Debug.LogError($"The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
					SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, DisconnectCause.InvalidAuthentication);
				}
				else if (FEOMHKNGOAK.ReturnCode == 32755)
				{
					Debug.LogError($"Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()");
					SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationFailed, FEOMHKNGOAK.DebugMessage);
				}
				else
				{
					Debug.LogError($"Authentication failed: '{FEOMHKNGOAK.DebugMessage}' Code: {FEOMHKNGOAK.ReturnCode}");
				}
				State = ClientState.Disconnecting;
				Disconnect();
				if (FEOMHKNGOAK.ReturnCode == 32757)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning($"Currently, the limit of users is reached for this title. Try again later. Disconnecting");
					}
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonMaxCccuReached);
					SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, DisconnectCause.MaxCcuReached);
				}
				else if (FEOMHKNGOAK.ReturnCode == 32756)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError($"The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.");
					}
					SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, DisconnectCause.InvalidRegion);
				}
				else if (FEOMHKNGOAK.ReturnCode == 32753)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError($"The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.");
					}
					SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, DisconnectCause.AuthenticationTicketExpired);
				}
				break;
			}
			if (EHALCLFLGJF == ServerConnection.NameServer || EHALCLFLGJF == ServerConnection.MasterServer)
			{
				if (FEOMHKNGOAK.Parameters.ContainsKey(225))
				{
					string text4 = (string)FEOMHKNGOAK.Parameters[225];
					if (!string.IsNullOrEmpty(text4))
					{
						if (AuthValues == null)
						{
							AuthValues = new AuthenticationValues();
						}
						AuthValues.UserId = text4;
						PhotonNetwork.player.UserId = text4;
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							DebugReturn(DebugLevel.INFO, $"Received your UserID from server. Updating local value to: {text4}");
						}
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(202))
				{
					PlayerName = (string)FEOMHKNGOAK.Parameters[202];
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						DebugReturn(DebugLevel.INFO, $"Received your NickName from server. Updating local value to: {OBCEIJGMKGB}");
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(192))
				{
					BAEBFLIPKKB((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[192]);
				}
			}
			if (EHALCLFLGJF == ServerConnection.NameServer)
			{
				MasterServerAddress = FEOMHKNGOAK[230] as string;
				NDPIAMOMGME();
			}
			else if (EHALCLFLGJF == ServerConnection.MasterServer)
			{
				if (AuthMode != 0)
				{
					OpSettings(OGLFGPKHEHH);
				}
				if (PhotonNetwork.autoJoinLobby)
				{
					State = ClientState.Authenticated;
					OpJoinLobby(lobby);
				}
				else
				{
					State = ClientState.ConnectedToMaster;
					SendMonoMessage(PhotonNetworkingMessage.OnConnectedToMaster);
				}
			}
			else if (EHALCLFLGJF == ServerConnection.GameServer)
			{
				State = ClientState.Joining;
				AJFMHFLGCFN.PlayerProperties = HHPBLGDNDOP();
				AJFMHFLGCFN.OnGameServer = true;
				if (ELNKFMHCMBO == JoinType.JoinRoom || ELNKFMHCMBO == JoinType.JoinRandomRoom || ELNKFMHCMBO == JoinType.JoinOrCreateRoom)
				{
					OpJoinRoom(AJFMHFLGCFN);
				}
				else if (ELNKFMHCMBO == JoinType.CreateRoom)
				{
					OpCreateGame(AJFMHFLGCFN);
				}
			}
			if (FEOMHKNGOAK.Parameters.ContainsKey(245))
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[245];
				if (dictionary != null)
				{
					SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationResponse, dictionary);
				}
			}
			break;
		case 220:
		{
			if (FEOMHKNGOAK.ReturnCode == short.MaxValue)
			{
				Debug.LogError($"The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
				SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, DisconnectCause.InvalidAuthentication);
				State = ClientState.Disconnecting;
				Disconnect();
				break;
			}
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				Debug.LogError("GetRegions failed. Can't provide regions list. Error: " + FEOMHKNGOAK.ReturnCode + ": " + FEOMHKNGOAK.DebugMessage);
				break;
			}
			string[] array3 = FEOMHKNGOAK[210] as string[];
			string[] array4 = FEOMHKNGOAK[230] as string[];
			if (array3 == null || array4 == null || array3.Length != array4.Length)
			{
				Debug.LogError("The region arrays from Name Server are not ok. Must be non-null and same length. " + (array3 == null) + " " + (array4 == null) + "\n" + FEOMHKNGOAK.ToStringFull());
				break;
			}
			AvailableRegions = new List<Region>(array3.Length);
			for (int j = 0; j < array3.Length; j++)
			{
				string text3 = array3[j];
				if (string.IsNullOrEmpty(text3))
				{
					continue;
				}
				text3 = text3.ToLower();
				CloudRegionCode cloudRegionCode = Region.Parse(text3);
				bool flag = true;
				if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion && PhotonNetwork.PhotonServerSettings.EnabledRegions != 0)
				{
					CloudRegionFlag cloudRegionFlag = Region.JFBLMOGHMPF(cloudRegionCode);
					flag = (PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) != 0;
					if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log("Skipping region because it's not in PhotonServerSettings.EnabledRegions: " + cloudRegionCode);
					}
				}
				if (flag)
				{
					AvailableRegions.Add(new Region(cloudRegionCode, text3, array4[j]));
				}
			}
			if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion)
			{
				PhotonHandler.LLHBAPCKHAB();
			}
			break;
		}
		case 227:
			if (EHALCLFLGJF == ServerConnection.GameServer)
			{
				PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning($"CreateRoom failed, client stays on masterserver: {FEOMHKNGOAK.ToStringFull()}.");
				}
				State = ((!insideLobby) ? ClientState.ConnectedToMaster : ClientState.JoinedLobby);
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
			}
			else
			{
				string text2 = (string)FEOMHKNGOAK[byte.MaxValue];
				if (!string.IsNullOrEmpty(text2))
				{
					AJFMHFLGCFN.RoomName = text2;
				}
				GameServerAddress = (string)FEOMHKNGOAK[230];
				NDPIAMOMGME();
			}
			break;
		case 226:
			if (EHALCLFLGJF != ServerConnection.GameServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log($"JoinRoom failed (room maybe closed by now). Client stays on masterserver: {FEOMHKNGOAK.ToStringFull()}. State: {State}");
					}
					SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
				}
				else
				{
					GameServerAddress = (string)FEOMHKNGOAK[230];
					NDPIAMOMGME();
				}
			}
			else
			{
				PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 225:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 32760)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning($"JoinRandom failed: {FEOMHKNGOAK.ToStringFull()}.");
				}
				SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, FEOMHKNGOAK.ReturnCode, FEOMHKNGOAK.DebugMessage);
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[byte.MaxValue];
				AJFMHFLGCFN.RoomName = roomName;
				GameServerAddress = (string)FEOMHKNGOAK[230];
				NDPIAMOMGME();
			}
			break;
		case 217:
		{
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				DebugReturn(DebugLevel.ERROR, "GetGameList failed: " + FEOMHKNGOAK.ToStringFull());
				break;
			}
			mGameList = new Dictionary<string, RoomInfo>();
			ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[222];
			foreach (object key in hashtable.Keys)
			{
				string text = (string)key;
				mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[key]);
			}
			mGameListCopy = new RoomInfo[mGameList.Count];
			mGameList.Values.CopyTo(mGameListCopy, 0);
			SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate);
			break;
		}
		case 229:
			State = ClientState.JoinedLobby;
			insideLobby = true;
			SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby);
			break;
		case 228:
			State = ClientState.Authenticated;
			IFPPBJINADG();
			break;
		case 254:
			NDPIAMOMGME();
			break;
		case 251:
		{
			ExitGames.Client.Photon.Hashtable fAOLPBLCKFJ = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
			ExitGames.Client.Photon.Hashtable mJJMNIDHDEC = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
			EDMCCPDDDCC(mJJMNIDHDEC, fAOLPBLCKFJ, 0);
			break;
		}
		case 252:
		case 253:
			break;
		case 222:
		{
			bool[] array = FEOMHKNGOAK[1] as bool[];
			string[] array2 = FEOMHKNGOAK[2] as string[];
			if (array != null && array2 != null && BEIPFKHGHPC != null && array.Length == BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(BEIPFKHGHPC.Length);
				for (int i = 0; i < BEIPFKHGHPC.Length; i++)
				{
					FriendInfo friendInfo = new FriendInfo();
					friendInfo.Name = BEIPFKHGHPC[i];
					friendInfo.Room = array2[i];
					friendInfo.IsOnline = array[i];
					list.Insert(i, friendInfo);
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.");
			}
			BEIPFKHGHPC = null;
			POHIMACBDGL = false;
			DJIOCIPPBMK = Environment.TickCount;
			if (DJIOCIPPBMK == 0)
			{
				DJIOCIPPBMK = 1;
			}
			SendMonoMessage(PhotonNetworkingMessage.OnUpdatedFriendList);
			break;
		}
		case 219:
			SendMonoMessage(PhotonNetworkingMessage.OnWebRpcResponse, FEOMHKNGOAK);
			break;
		default:
			Debug.LogWarning($"OperationResponse unhandled: {FEOMHKNGOAK.ToString()}");
			break;
		}
	}

	[SpecialName]
	public int HODDLHHJODM()
	{
		return _003CEEDBHAJBPLC_003Ek__BackingField;
	}

	protected internal void JHCPMMIEDEE(int NADLIACHBNO, int MNFJDHDDGLC)
	{
		Debug.Log("TransferOwnership() view " + NADLIACHBNO + " to: " + MNFJDHDDGLC + " Time: " + Environment.TickCount % 1000);
		OpRaiseEvent(210, new int[2] { NADLIACHBNO, MNFJDHDDGLC }, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	public void OpCleanRpcBuffer(int CFLLNEOHNFD)
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		raiseEventOptions.TargetActors = new int[1] { CFLLNEOHNFD };
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(200, null, true, bPLHAPBMGGC);
	}

	public bool WebRpc(string MDGGHHCAHKF, object GNNEKCBOBEG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(209, MDGGHHCAHKF);
		dictionary.Add(208, GNNEKCBOBEG);
		return OpCustom(219, dictionary, true);
	}

	private bool LFAPOBNFPPO(object[] OMGHPPEONFN, object[] BGJHIKDFIMP)
	{
		if (OMGHPPEONFN == null && BGJHIKDFIMP == null)
		{
			return true;
		}
		if (OMGHPPEONFN == null || BGJHIKDFIMP == null || OMGHPPEONFN.Length != BGJHIKDFIMP.Length)
		{
			return false;
		}
		for (int i = 0; i < BGJHIKDFIMP.Length; i++)
		{
			object cFKDMFFFPJK = BGJHIKDFIMP[i];
			object gOLMELKEAFO = OMGHPPEONFN[i];
			if (!LFAPOBNFPPO(cFKDMFFFPJK, gOLMELKEAFO))
			{
				return false;
			}
		}
		return true;
	}

	private void KCNBFALAJMD(int KHACEEGCPEP)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[(byte)0] = KHACEEGCPEP;
		OpRaiseEvent(207, hashtable, true, null);
	}

	public static void SendMonoMessage(PhotonNetworkingMessage LELHNDDCKCO, params object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet = ((PhotonNetwork.SendMonoMessageTargets == null) ? PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType) : PhotonNetwork.SendMonoMessageTargets);
		string methodName = LELHNDDCKCO.ToString();
		object value = ((GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 1) ? GNNEKCBOBEG : GNNEKCBOBEG[0]);
		foreach (GameObject item in hashSet)
		{
			if (item != null)
			{
				item.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public PhotonView GetPhotonView(int NADLIACHBNO)
	{
		PhotonView value = null;
		HFCMPEKPBAM.TryGetValue(NADLIACHBNO, out value);
		if (value == null)
		{
			PhotonView[] array = UnityEngine.Object.FindObjectsOfType(typeof(PhotonView)) as PhotonView[];
			foreach (PhotonView photonView in array)
			{
				if (photonView.viewID == NADLIACHBNO)
				{
					if (photonView.GEKLBLEBECG)
					{
						Debug.LogWarning("Had to lookup view that wasn't in photonViewList: " + photonView);
					}
					return photonView;
				}
			}
		}
		return value;
	}

	public void OpRemoveCompleteCacheOfPlayer(int CFLLNEOHNFD)
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCache;
		raiseEventOptions.TargetActors = new int[1] { CFLLNEOHNFD };
		RaiseEventOptions bPLHAPBMGGC = raiseEventOptions;
		OpRaiseEvent(0, null, true, bPLHAPBMGGC);
	}

	protected internal void DMCKEABNFPJ()
	{
		if (!PhotonNetwork.automaticallySyncScene || PhotonNetwork.isMasterClient || PhotonNetwork.room == null || !PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			return;
		}
		object obj = PhotonNetwork.room.CustomProperties["curScn"];
		if (obj is int)
		{
			if (SceneManagerHelper.ActiveSceneBuildIndex != (int)obj)
			{
				PhotonNetwork.LoadLevel((int)obj);
			}
		}
		else if (obj is string && SceneManagerHelper.ActiveSceneName != (string)obj)
		{
			PhotonNetwork.LoadLevel((string)obj);
		}
	}

	public void CleanRpcBufferIfMine(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.ownerId != LocalPlayer.ID && !LocalPlayer.IsMasterClient)
		{
			Debug.LogError(string.Concat("Cannot remove cached RPCs on a PhotonView thats not ours! ", DFIHBOEOJPI.owner, " scene: ", DFIHBOEOJPI.isSceneView));
		}
		else
		{
			OpCleanRpcBuffer(DFIHBOEOJPI);
		}
	}
}
