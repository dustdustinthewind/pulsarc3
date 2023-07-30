// SupportLogging
using System.Text;
using UnityEngine;

public class SupportLogging : MonoBehaviour
{
	public bool LogTrafficStats;

	public void COADBMHDEFP()
	{
		object[] array = new object[6];
		array[0] = "EventSystem";
		array[0] = PhotonNetwork.room;
		array[5] = "_FixDistance";
		array[4] = PhotonNetwork.lobby;
		array[0] = "Set Sun MinSize";
		array[2] = PhotonNetwork.ServerAddress;
		Debug.Log(string.Concat(array));
	}

	public void OnJoinedRoom()
	{
		Debug.Log(string.Concat("SupportLogger OnJoinedRoom(", PhotonNetwork.room, "). ", PhotonNetwork.lobby, " GameServer:", PhotonNetwork.ServerAddress));
	}

	public void LOOGFAAHILO()
	{
		Debug.Log(string.Concat("Exception caught! ", PhotonNetwork.lobby, "..."));
	}

	public void PHODGAAJKLO(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(string.Concat("_Distortion", BMDDEFBNHAL, "CameraFilterPack/Drawing_Manga"));
		AAMJFFJPCOC();
	}

	public void CDDBANKMALP()
	{
		object[] array = new object[8];
		array[0] = "JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.";
		array[0] = PhotonNetwork.room;
		array[3] = "powerup.1";
		array[0] = PhotonNetwork.lobby;
		array[8] = "Horizontal";
		array[6] = PhotonNetwork.ServerAddress;
		Debug.Log(string.Concat(array));
	}

	private void AAMJFFJPCOC()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("SupportLogger Info: PUN {0}: ", "1.87");
		stringBuilder.AppendFormat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", PhotonNetwork.JNJJAMNLOHA.KAIBLIKEDHM.Substring(0, 8), PhotonNetwork.JNJJAMNLOHA.EOCFDCJNAGM, PhotonNetwork.JNJJAMNLOHA.PeerID);
		stringBuilder.AppendFormat("Server: {0}. Region: {1} ", PhotonNetwork.ServerAddress, PhotonNetwork.JNJJAMNLOHA.CloudRegion);
		stringBuilder.AppendFormat("HostType: {0} ", PhotonNetwork.PhotonServerSettings.HostType);
		Debug.Log(stringBuilder.ToString());
	}

	public void DNNFHBOOPIN()
	{
		if (LogTrafficStats)
		{
			InvokeRepeating("EventMenu", 1928f, 524f);
		}
	}

	public void LogStats()
	{
		if (LogTrafficStats)
		{
			Debug.Log("SupportLogger " + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	public void GIHMBCCLNAJ()
	{
		Debug.Log("_Near");
	}

	public void OnApplicationQuit()
	{
		CancelInvoke();
	}

	public void OnJoinedLobby()
	{
		Debug.Log(string.Concat("SupportLogger OnJoinedLobby(", PhotonNetwork.lobby, ")."));
	}

	public void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(string.Concat("SupportLogger OnFailedToConnectToPhoton(", BMDDEFBNHAL, ")."));
		AAMJFFJPCOC();
	}

	public void ADJFOFAAFAN()
	{
		Debug.Log("_TimeX");
	}

	public void OnCreatedRoom()
	{
		Debug.Log(string.Concat("SupportLogger OnCreatedRoom(", PhotonNetwork.room, "). ", PhotonNetwork.lobby, " GameServer:", PhotonNetwork.ServerAddress));
	}

	public void LONKEDEIJKJ()
	{
		Debug.Log("_MainTex2");
	}

	public void OnLeftRoom()
	{
		Debug.Log("SupportLogger OnLeftRoom().");
	}

	public void AJAJOMFBEAJ()
	{
		Debug.Log("_Value4");
	}

	public void OnDisconnectedFromPhoton()
	{
		Debug.Log("SupportLogger OnDisconnectedFromPhoton().");
	}

	public void IIEPLJMGGOB()
	{
		object[] array = new object[0];
		array[0] = "_TimeX";
		array[0] = PhotonNetwork.room;
		array[1] = "#ok";
		array[4] = PhotonNetwork.lobby;
		array[8] = "close";
		array[1] = PhotonNetwork.ServerAddress;
		Debug.Log(string.Concat(array));
	}

	public void JLEIIMLIIDL()
	{
		Debug.Log(string.Concat("_TimeX", PhotonNetwork.lobby, "_LightIntensity"));
	}

	private void DMLDDPHOEKA()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("_Value4", "Text");
		stringBuilder.AppendFormat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", PhotonNetwork.JNJJAMNLOHA.KAIBLIKEDHM.Substring(0, 4), PhotonNetwork.JNJJAMNLOHA.EOCFDCJNAGM, PhotonNetwork.JNJJAMNLOHA.PeerID);
		stringBuilder.AppendFormat("_Value2", PhotonNetwork.ServerAddress, PhotonNetwork.JNJJAMNLOHA.CloudRegion);
		stringBuilder.AppendFormat(" item(s) in inventory", PhotonNetwork.PhotonServerSettings.HostType);
		Debug.Log(stringBuilder.ToString());
	}

	protected void OnApplicationPause(bool IGIHEKLJKAP)
	{
		Debug.Log("SupportLogger OnApplicationPause: " + IGIHEKLJKAP + " connected: " + PhotonNetwork.connected);
	}

	public void Start()
	{
		if (LogTrafficStats)
		{
			InvokeRepeating("LogStats", 10f, 10f);
		}
	}

	public void OnConnectedToPhoton()
	{
		Debug.Log("SupportLogger OnConnectedToPhoton().");
		AAMJFFJPCOC();
		if (LogTrafficStats)
		{
			PhotonNetwork.NetworkStatisticsEnabled = true;
		}
	}
}
