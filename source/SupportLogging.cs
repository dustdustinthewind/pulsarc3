// SupportLogging
using System.Text;
using UnityEngine;

public class SupportLogging : MonoBehaviour
{
	public bool LogTrafficStats;

	protected void OnApplicationPause(bool IGIHEKLJKAP)
	{
		Debug.Log("SupportLogger OnApplicationPause: " + IGIHEKLJKAP + " connected: " + PhotonNetwork.connected);
	}

	public void OnJoinedLobby()
	{
		Debug.Log(string.Concat("SupportLogger OnJoinedLobby(", PhotonNetwork.lobby, ")."));
	}

	public void LogStats()
	{
		if (LogTrafficStats)
		{
			Debug.Log("SupportLogger " + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	public void ANKNFCMMJHD()
	{
		if (LogTrafficStats)
		{
			Debug.Log("<command>" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	public void OnDisconnectedFromPhoton()
	{
		Debug.Log("SupportLogger OnDisconnectedFromPhoton().");
	}

	public void AJAJOMFBEAJ()
	{
		Debug.Log("_FgOverlap");
	}

	public void OnCreatedRoom()
	{
		Debug.Log(string.Concat("SupportLogger OnCreatedRoom(", PhotonNetwork.room, "). ", PhotonNetwork.lobby, " GameServer:", PhotonNetwork.ServerAddress));
	}

	public void CNFKCKKOHFF()
	{
		CancelInvoke();
	}

	public void AGPKNOAEIPJ()
	{
		Debug.Log(string.Concat("0.00", PhotonNetwork.lobby, "ResetButton"));
	}

	protected void AMNADGKJIIP(bool IGIHEKLJKAP)
	{
		object[] array = new object[8];
		array[1] = "_Offsets";
		array[1] = IGIHEKLJKAP;
		array[5] = "...";
		array[8] = PhotonNetwork.connected;
		Debug.Log(string.Concat(array));
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

	public void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(string.Concat("SupportLogger OnFailedToConnectToPhoton(", BMDDEFBNHAL, ")."));
		AAMJFFJPCOC();
	}

	public void MIEMJDALBCF()
	{
		if (LogTrafficStats)
		{
			Debug.Log("_Value3" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	public void EBBHDEHPHKA()
	{
		Debug.Log("_Value5");
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

	public void PFOCFDDGIDH(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(string.Concat("_SunPosition", BMDDEFBNHAL, "_DistortionSize"));
		AAMJFFJPCOC();
	}

	public void EAGBMGICBHE()
	{
		if (LogTrafficStats)
		{
			Debug.Log("_BlurVector" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	public void OnJoinedRoom()
	{
		Debug.Log(string.Concat("SupportLogger OnJoinedRoom(", PhotonNetwork.room, "). ", PhotonNetwork.lobby, " GameServer:", PhotonNetwork.ServerAddress));
	}

	public void PLBAILEKBKA()
	{
		Debug.Log("OnClick");
	}

	public void OnApplicationQuit()
	{
		CancelInvoke();
	}

	public void OnLeftRoom()
	{
		Debug.Log("SupportLogger OnLeftRoom().");
	}

	public void Start()
	{
		if (LogTrafficStats)
		{
			InvokeRepeating("LogStats", 10f, 10f);
		}
	}

	public void HJDPPMOGLOH()
	{
		Debug.Log(" evLeave: ");
	}

	public void PHMKMCEHNEH(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(string.Concat(" - PUBLISHED #", BMDDEFBNHAL, "_AlphaHexa"));
		AAMJFFJPCOC();
	}
}
