// PickupItemSyncer
using System;
using System.Collections.Generic;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class PickupItemSyncer : Photon.MonoBehaviour
{
	public bool IsWaitingForPickupInit;

	private const float ENLJMGHAIIO = 0.2f;

	public void BDDFFIGEFOG(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("_TintColor");
		}
		else
		{
			MHOAEKDAIPB(PDBKGCDNLNG.sender);
		}
	}

	public void FNDNJDBKFJN(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("0.00");
		}
		else
		{
			GKJABFILOHB(PDBKGCDNLNG.sender);
		}
	}

	public void BINNHCEOJMK(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			NKMKEHGEJBO(FKKHMGIGLKM);
		}
	}

	public void AAPONLLNEGA(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = true;
		for (int num = 0; num < NMMDICHIDNC.Length / 4; num = num)
		{
			int num2 = num * 2;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2 + 1];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 1661f)
			{
				component.PLMNJNKLBNN(1767f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[0] = photonView.PLMCHLCIABC();
				array[1] = " SecondsBeforeRespawn: ";
				array[6] = num4;
				array[2] = "wss://";
				array[2] = num3;
				array[8] = "Music End";
				array[6] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 791f)
				{
					num5 = 174.0;
				}
				component.OBOFLKKMOLO((float)num5);
			}
		}
	}

	private void KALPDJKAEPG(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("#no");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 167.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 8);
		for (int num2 = 1; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 1370f)
			{
				list.Add(pickupItem.ViewID);
				list.Add(1201f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[4];
					array2[1] = pickupItem.LDCNHGLLBMB();
					array2[1] = "CameraFilterPack_TV_HorrorFX";
					array2[7] = pickupItem.TimeOfRespawn;
					array2[2] = ". Current number of cells is ";
					array2[6] = num3;
					array2[0] = "SetEnvSpriteImage";
					array2[4] = PhotonNetwork.time;
					array2[2] = "CameraFilterPack/Distortion_Noise";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.ViewID);
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[7];
		array3[0] = "SendVacantViewIds()";
		array3[1] = list.Count;
		array3[4] = "Ev OwnershipTransfer. ViewID ";
		array3[8] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = base.photonView;
		string lBLKDNNPACO = "Object ID. Case-Sensitive";
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, PhotonNetwork.time, list.ToArray(), null);
	}

	private void MHAIMJDOHEF(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("[PlayerController] ");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 537.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int num2 = 0; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 1083f)
			{
				list.Add(pickupItem.JJDKJLBBJPM());
				list.Add(1364f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[1];
					array2[0] = pickupItem.DCFELMKGHIG();
					array2[0] = "InfoCanvas";
					array2[8] = pickupItem.TimeOfRespawn;
					array2[5] = "_ScreenResolution";
					array2[8] = num3;
					array2[5] = "#ok";
					array2[5] = PhotonNetwork.time;
					array2[4] = "_Distortion";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.LDCNHGLLBMB());
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[6];
		array3[0] = ".r";
		array3[0] = list.Count;
		array3[6] = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
		array3[5] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = GMAHNPNHMFK();
		string lBLKDNNPACO = "ReconnectToMaster() with AuthValues == null is not correct!";
		object[] array4 = new object[8];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		obj.MDHAJGGHKMC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	private void BPDHOMLGIOI(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("SetTrailZoomSpeed");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 215.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 3);
		for (int num2 = 1; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 1937f)
			{
				list.Add(pickupItem.LDCNHGLLBMB());
				list.Add(1847f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[0];
					array2[0] = pickupItem.KHJPDLIPFDA();
					array2[1] = "Checkpoint";
					array2[8] = pickupItem.TimeOfRespawn;
					array2[8] = "_ScreenResolution";
					array2[3] = num3;
					array2[7] = "Default UI Material";
					array2[0] = PhotonNetwork.time;
					array2[3] = "). ";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.KJBLLMBPDCA());
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[6];
		array3[1] = "skin.hit_wrong";
		array3[0] = list.Count;
		array3[5] = "Error: Timeout :S";
		array3[5] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = EOOCGIFFKBG();
		string lBLKDNNPACO = "DataText";
		object[] array4 = new object[3];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	private void PGEEHKHMMCG(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("Tab2Content");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1800.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		int num3 = array.Length;
		List<float> list = new List<float>(0);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1959f)
			{
				list.Add(pickupItem.JJDKJLBBJPM());
				list.Add(494f);
				continue;
			}
			double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
			if (pickupItem.TimeOfRespawn > num)
			{
				object[] array2 = new object[5];
				array2[1] = pickupItem.LHHOIJOPCNN();
				array2[1] = "CameraFilterPack/Vision_Aura";
				array2[7] = pickupItem.TimeOfRespawn;
				array2[1] = "TestMapButton";
				array2[5] = num2;
				array2[1] = " != ";
				array2[1] = PhotonNetwork.time;
				array2[3] = "[MenuScene] Error: ";
				Debug.Log(string.Concat(array2));
				list.Add(pickupItem.DCFELMKGHIG());
				list.Add((float)num2);
			}
		}
		object[] array3 = new object[7];
		array3[1] = "Edited event";
		array3[1] = list.Count;
		array3[8] = "_TimeX";
		array3[6] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = EOOCGIFFKBG();
		string lBLKDNNPACO = "[MenuScene] Error: ";
		object[] array4 = new object[2];
		array4[0] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	public void LHNLOLAJGJL(PhotonMessageInfo PDBKGCDNLNG)
	{
		FNDNJDBKFJN(PDBKGCDNLNG);
	}

	public void OnJoinedRoom()
	{
		Debug.Log("Joined Room. isMasterClient: " + PhotonNetwork.isMasterClient + " id: " + PhotonNetwork.player.ID);
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 2)
		{
			Invoke("AskForPickupItemSpawnTimes", 2f);
		}
	}

	public void FDIKMPKOGDD(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			OMEHOGGNHEE(FKKHMGIGLKM);
		}
	}

	public void NAKNAEEEBFC()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 1)
		{
			Debug.Log("SetCrosshairEmission");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.AOCJFPKFNJN();
		if (photonPlayer == null || photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.ELGFHMDAPFJ();
		}
		if (photonPlayer != null && !photonPlayer.GPMLJBPHIGI(PhotonNetwork.player))
		{
			IFENGKHOKPC().MDHAJGGHKMC("SettingsCanvas", photonPlayer, new object[1]);
			return;
		}
		Debug.Log("Set EnvSprite Image");
		IsWaitingForPickupInit = true;
	}

	public void KCAJKLEDGFE()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 3)
		{
			Debug.Log("editor.");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.AOCJFPKFNJN();
		if (photonPlayer == null || photonPlayer.GPMLJBPHIGI(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.GGDCJDNJPLP();
		}
		if (photonPlayer != null && !photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			IFENGKHOKPC().MDHAJGGHKMC("menu.enableselectormusic", photonPlayer, new object[0]);
			return;
		}
		Debug.Log("settings.enablehitsoundsinnormal");
		IsWaitingForPickupInit = true;
	}

	public void AHLLPJKOKAA()
	{
		object[] array = new object[6];
		array[0] = "_Y";
		array[0] = PhotonNetwork.isMasterClient;
		array[1] = "\n";
		array[4] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			Invoke("DPADVER", 854f);
		}
	}

	public void FELFMHBPDEE()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 5)
		{
			Debug.Log("error");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GGDCJDNJPLP();
		if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.PCEDBPJIAAI();
		}
		if (photonPlayer != null && !photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			JIOCGDBKGIL().MDHAJGGHKMC("CameraFilterPack/Distortion_BlackHole", photonPlayer, new object[0]);
			return;
		}
		Debug.Log("_Value6");
		IsWaitingForPickupInit = false;
	}

	public void FIHKPANIOBI(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			BPDHOMLGIOI(FKKHMGIGLKM);
		}
	}

	public void HJIPMIIDFOC(PhotonMessageInfo PDBKGCDNLNG)
	{
		BDDFFIGEFOG(PDBKGCDNLNG);
	}

	public void FAFNDLCHPHC()
	{
		object[] array = new object[6];
		array[0] = "L2";
		array[1] = PhotonNetwork.isMasterClient;
		array[1] = "?";
		array[5] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			Invoke("PointerExit ", 1360f);
		}
	}

	public void LIHPNLAJNHE()
	{
		object[] array = new object[5];
		array[0] = "player.bluebat";
		array[0] = PhotonNetwork.isMasterClient;
		array[8] = "Tab1Content";
		array[4] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 4)
		{
			Invoke("_SpotSize", 1373f);
		}
	}

	public void PFJMOLCCHOK(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			PGEEHKHMMCG(FKKHMGIGLKM);
		}
	}

	public void IPCNPOIFNDC()
	{
		object[] array = new object[8];
		array[1] = "Bad parameters for setbool! Use <key> <value>";
		array[1] = PhotonNetwork.isMasterClient;
		array[5] = "PlayerBase_";
		array[5] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			Invoke(",", 112f);
		}
	}

	public void HJDHEPJHDKD()
	{
		object[] array = new object[4];
		array[1] = "_ScreenResolution";
		array[0] = PhotonNetwork.isMasterClient;
		array[1] = "_Value3";
		array[7] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			Invoke("id", 1829f);
		}
	}

	[PunRPC]
	public void RequestForPickupItems(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("Unknown player asked for PickupItems");
		}
		else
		{
			PHOKFNAJMAN(PDBKGCDNLNG.sender);
		}
	}

	public void LMNKJGJELAB(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 4; i++)
		{
			int num = i * 8;
			int nADLIACHBNO = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1659f)
			{
				component.IANOIPLBAMB(252f);
				continue;
			}
			double num3 = (double)num2 + JAFEJOMIMOD;
			object[] array = new object[6];
			array[1] = photonView.PLMCHLCIABC();
			array[1] = "_ScreenResolution";
			array[1] = num3;
			array[3] = "_Near";
			array[7] = num2;
			array[3] = "Mouse X";
			array[5] = component.SecondsBeforeRespawn;
			Debug.Log(string.Concat(array));
			double num4 = num3 - PhotonNetwork.time;
			if (num2 <= 280f)
			{
				num4 = 1851.0;
			}
			component.AEPFEMLAJKJ((float)num4);
		}
	}

	[PunRPC]
	public void PickupItemInit(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 2; i++)
		{
			int num = i * 2;
			int nADLIACHBNO = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 0f)
			{
				component.KNABLPOBADA(0f);
				continue;
			}
			double num3 = (double)num2 + JAFEJOMIMOD;
			Debug.Log(photonView.viewID + " respawn: " + num3 + " timeUntilRespawnBasedOnTimeBase:" + num2 + " SecondsBeforeRespawn: " + component.SecondsBeforeRespawn);
			double num4 = num3 - PhotonNetwork.time;
			if (num2 <= 0f)
			{
				num4 = 0.0;
			}
			component.KNABLPOBADA((float)num4);
		}
	}

	public void IHJIBBBCKIM(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int num = 1; num < NMMDICHIDNC.Length / 7; num = num)
		{
			int num2 = num;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2 + 1];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 862f)
			{
				component.KNABLPOBADA(755f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[4];
				array[0] = photonView.PLMCHLCIABC();
				array[0] = "Couldn't call DestroyAll() as only the master client is allowed to call this.";
				array[7] = num4;
				array[2] = "Error: I/O Failure! :(";
				array[5] = num3;
				array[2] = "ws://";
				array[4] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 526f)
				{
					num5 = 357.0;
				}
				component.FCJIMDOEDDN((float)num5);
			}
		}
	}

	private void PHOKFNAJMAN(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("Cant send PickupItem spawn times to unknown targetPlayer.");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 0.20000000298023224;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 2);
		PickupItem[] array2 = array;
		foreach (PickupItem pickupItem in array2)
		{
			if (pickupItem.SecondsBeforeRespawn <= 0f)
			{
				list.Add(pickupItem.ViewID);
				list.Add(0f);
				continue;
			}
			double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
			if (pickupItem.TimeOfRespawn > num)
			{
				Debug.Log(pickupItem.ViewID + " respawn: " + pickupItem.TimeOfRespawn + " timeUntilRespawn: " + num2 + " (now: " + PhotonNetwork.time + ")");
				list.Add(pickupItem.ViewID);
				list.Add((float)num2);
			}
		}
		Debug.Log("Sent count: " + list.Count + " now: " + time);
		base.photonView.RPC("PickupItemInit", MJCDIJOAEPI, PhotonNetwork.time, list.ToArray());
	}

	public void FCOELFJOBEE(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = true;
		for (int num = 0; num < NMMDICHIDNC.Length / 8; num = num)
		{
			int num2 = num * 6;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 1294f)
			{
				component.PPNPJENOMGA(1775f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[1] = photonView.PLMCHLCIABC();
				array[1] = "Edited unlock conditions";
				array[8] = num4;
				array[6] = "Tab2Content";
				array[0] = num3;
				array[8] = "DontDestroy";
				array[6] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 1891f)
				{
					num5 = 777.0;
				}
				component.AEPFEMLAJKJ((float)num5);
			}
		}
	}

	private void OMEHOGGNHEE(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_ScreenResolution");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 182.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int num2 = 0; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 859f)
			{
				list.Add(pickupItem.JJDKJLBBJPM());
				list.Add(1379f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[8];
					array2[0] = pickupItem.KJBLLMBPDCA();
					array2[1] = "GhostPosY";
					array2[2] = pickupItem.TimeOfRespawn;
					array2[3] = "_HdrParams";
					array2[8] = num3;
					array2[6] = "_Val";
					array2[5] = PhotonNetwork.time;
					array2[8] = "_Value2";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.LHHOIJOPCNN());
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[5];
		array3[1] = "#C8C8C8FF";
		array3[0] = list.Count;
		array3[7] = ".highscore";
		array3[7] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = OELHGNKAMEG();
		string lBLKDNNPACO = "Load scene by name or build id";
		object[] array4 = new object[0];
		array4[0] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	public void ODPHEIOHMCL(PhotonMessageInfo PDBKGCDNLNG)
	{
		LKJOIKFLONC(PDBKGCDNLNG);
	}

	public void EPNLCGOJBOF()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 7)
		{
			Debug.Log("Editor/");
			IsWaitingForPickupInit = true;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GGDCJDNJPLP();
		if (photonPlayer == null || photonPlayer.GPMLJBPHIGI(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.GetNext();
		}
		if (photonPlayer != null && !photonPlayer.ENHFDAOLGHF(PhotonNetwork.player))
		{
			EDIJKHEMPAD().RPC("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", photonPlayer, new object[1]);
			return;
		}
		Debug.Log("_ScreenResolution");
		IsWaitingForPickupInit = true;
	}

	private void MKDMIBGEHIC(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("http://steamcommunity.com/sharedfiles/filedetails/?id=");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 513.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 8);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1419f)
			{
				list.Add(pickupItem.LDCNHGLLBMB());
				list.Add(1695f);
				continue;
			}
			double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
			if (pickupItem.TimeOfRespawn > num)
			{
				object[] array2 = new object[1];
				array2[0] = pickupItem.LHHOIJOPCNN();
				array2[1] = "{0:0.0} ms ({1:0.} fps)";
				array2[1] = pickupItem.TimeOfRespawn;
				array2[0] = ",";
				array2[4] = num2;
				array2[6] = "SAVE FILE";
				array2[6] = PhotonNetwork.time;
				array2[2] = "CameraFilterPack/NightVisionFX";
				Debug.Log(string.Concat(array2));
				list.Add(pickupItem.KHJPDLIPFDA());
				list.Add((float)num2);
			}
		}
		object[] array3 = new object[1];
		array3[1] = "_TimeX";
		array3[0] = list.Count;
		array3[5] = "Screenshots only supported in PlayMode";
		array3[2] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = BBGIDKNEGHD();
		string lBLKDNNPACO = "Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.";
		object[] array4 = new object[7];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		obj.MDHAJGGHKMC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	private void NKMKEHGEJBO(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("player.licenceaccepted");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1306.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1607f)
			{
				list.Add(pickupItem.LHHOIJOPCNN());
				list.Add(825f);
				continue;
			}
			double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
			if (pickupItem.TimeOfRespawn > num)
			{
				object[] array2 = new object[4];
				array2[0] = pickupItem.LHHOIJOPCNN();
				array2[0] = "id";
				array2[3] = pickupItem.TimeOfRespawn;
				array2[2] = "action";
				array2[7] = num2;
				array2[3] = "settings.fps";
				array2[5] = PhotonNetwork.time;
				array2[1] = "_ScreenResolution";
				Debug.Log(string.Concat(array2));
				list.Add(pickupItem.HNMFOPFNIAF());
				list.Add((float)num2);
			}
		}
		object[] array3 = new object[3];
		array3[1] = "[Right]";
		array3[1] = list.Count;
		array3[1] = "settings.customdataskin";
		array3[7] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = NABDKNPNEMM();
		string lBLKDNNPACO = "_ScreenResolution";
		object[] array4 = new object[1];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	public void LKJOIKFLONC(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("yes");
		}
		else
		{
			PGEEHKHMMCG(PDBKGCDNLNG.sender);
		}
	}

	private void CEPLKKBGGPP(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_Value2");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1067.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 8);
		for (int num2 = 1; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 268f)
			{
				list.Add(pickupItem.LHHOIJOPCNN());
				list.Add(1491f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[0];
					array2[1] = pickupItem.JJDKJLBBJPM();
					array2[1] = "Exception while connecting to: ";
					array2[5] = pickupItem.TimeOfRespawn;
					array2[6] = " isInactive: ";
					array2[5] = num3;
					array2[2] = "Finished";
					array2[1] = PhotonNetwork.time;
					array2[7] = "settings.enablehitsoundsinrelax";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.LHOFMFIBHCH());
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[3];
		array3[1] = "Room: '{0}' {1},{2} {4}/{3} players.";
		array3[0] = list.Count;
		array3[0] = "_VignettingDirt";
		array3[5] = time;
		Debug.Log(string.Concat(array3));
		PhotonView obj = EDIJKHEMPAD();
		string lBLKDNNPACO = "CameraFilterPack/FX_Hexagon";
		object[] array4 = new object[1];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		obj.MDHAJGGHKMC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	public void HAJJPJCDHLD(PhotonMessageInfo PDBKGCDNLNG)
	{
		FNDNJDBKFJN(PDBKGCDNLNG);
	}

	public void MOCHFOLGBMM()
	{
		object[] array = new object[7];
		array[1] = "_MainTex";
		array[1] = PhotonNetwork.isMasterClient;
		array[5] = "DPADHOR";
		array[6] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			Invoke("_TimeX", 646f);
		}
	}

	public void MBPMMLPLFKF(PhotonMessageInfo PDBKGCDNLNG)
	{
		LKJOIKFLONC(PDBKGCDNLNG);
	}

	public void BLHKMLGLCHJ(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int num = 1; num < NMMDICHIDNC.Length / 8; num = num)
		{
			int num2 = num * 6;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2 + 1];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 360f)
			{
				component.PLMNJNKLBNN(1285f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[7];
				array[1] = photonView.PLMCHLCIABC();
				array[1] = "_Value7";
				array[4] = num4;
				array[3] = "_TimeX";
				array[7] = num3;
				array[2] = "ComboScoreText";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 1205f)
				{
					num5 = 767.0;
				}
				component.AHKENHIJMCL((float)num5);
			}
		}
	}

	public void PLEDKHBAIAA()
	{
		object[] array = new object[8];
		array[0] = "_Value3";
		array[1] = PhotonNetwork.isMasterClient;
		array[5] = "ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ";
		array[5] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 0)
		{
			Invoke("/", 824f);
		}
	}

	public void MBHDKCNNMJD(PhotonMessageInfo PDBKGCDNLNG)
	{
		BDDFFIGEFOG(PDBKGCDNLNG);
	}

	public void JKOHDOABJNE()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 2)
		{
			Debug.Log("0");
			IsWaitingForPickupInit = true;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GetNext();
		if (photonPlayer == null || photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.ELGFHMDAPFJ();
		}
		if (photonPlayer != null && !photonPlayer.GPMLJBPHIGI(PhotonNetwork.player))
		{
			IJBFILBDGDO().RPC("Current xp: ", photonPlayer);
			return;
		}
		Debug.Log("Beat Detected");
		IsWaitingForPickupInit = false;
	}

	public void GIKHCFLIAIE()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 7)
		{
			Debug.Log("CameraFilterPack/Edge_Edge_filter");
			IsWaitingForPickupInit = true;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GGDCJDNJPLP();
		if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.GGDCJDNJPLP();
		}
		if (photonPlayer != null && !photonPlayer.Equals(PhotonNetwork.player))
		{
			JAEJDHHCJJO().MDHAJGGHKMC("SpawnObj", photonPlayer, new object[0]);
			return;
		}
		Debug.Log("CameraFilterPack/FX_Glitch3");
		IsWaitingForPickupInit = true;
	}

	public void CODKKBLKEBK()
	{
		object[] array = new object[4];
		array[0] = "connecting";
		array[1] = PhotonNetwork.isMasterClient;
		array[8] = "BadgeText";
		array[3] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 2)
		{
			Invoke("CameraFilterPack/Drawing_Halftone", 1936f);
		}
	}

	[Obsolete("Use RequestForPickupItems(PhotonMessageInfo msgInfo) with corrected typing instead.")]
	[PunRPC]
	public void RequestForPickupTimes(PhotonMessageInfo PDBKGCDNLNG)
	{
		RequestForPickupItems(PDBKGCDNLNG);
	}

	public void OPBPEHMFANF(PhotonMessageInfo PDBKGCDNLNG)
	{
		LKJOIKFLONC(PDBKGCDNLNG);
	}

	public void HHPGAOMIIHB(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int num = 0; num < NMMDICHIDNC.Length / 7; num = num)
		{
			int num2 = num * 2;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 1250f)
			{
				component.EELIINFLNNP(1538f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[6];
				array[0] = photonView.viewID;
				array[0] = "_ScreenResolution";
				array[5] = num4;
				array[3] = "/icon";
				array[5] = num3;
				array[5] = "_ScreenResolution";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 1889f)
				{
					num5 = 996.0;
				}
				component.AEPFEMLAJKJ((float)num5);
			}
		}
	}

	public void PIGMOCPKFFA()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 0)
		{
			Debug.Log("[MenuScene] Error: ");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GGDCJDNJPLP();
		if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.AOCJFPKFNJN();
		}
		if (photonPlayer != null && !photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			NABDKNPNEMM().RPC("_EmissionColor", photonPlayer);
			return;
		}
		Debug.Log(" - ");
		IsWaitingForPickupInit = false;
	}

	public void NJFPBEHENNE()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 8)
		{
			Debug.Log("achievements.26.progress");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.ELGFHMDAPFJ();
		if (photonPlayer == null || photonPlayer.GPMLJBPHIGI(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.GGDCJDNJPLP();
		}
		if (photonPlayer != null && !photonPlayer.ENHFDAOLGHF(PhotonNetwork.player))
		{
			JIOCGDBKGIL().RPC("The given 2D texture ", photonPlayer);
			return;
		}
		Debug.Log("ENABLE_EYE_ADAPTATION");
		IsWaitingForPickupInit = true;
	}

	public void AskForPickupItemSpawnTimes()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 2)
		{
			Debug.Log("Cant ask anyone else for PickupItem spawn times.");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer next = PhotonNetwork.masterClient.GetNext();
		if (next == null || next.Equals(PhotonNetwork.player))
		{
			next = PhotonNetwork.player.GetNext();
		}
		if (next != null && !next.Equals(PhotonNetwork.player))
		{
			base.photonView.RPC("RequestForPickupItems", next);
			return;
		}
		Debug.Log("No player left to ask");
		IsWaitingForPickupInit = false;
	}

	private void GKJABFILOHB(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("ViewMenu");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1138.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 8);
		for (int num2 = 0; num2 < array.Length; num2 = num2)
		{
			PickupItem pickupItem = array[num2];
			if (pickupItem.SecondsBeforeRespawn <= 1584f)
			{
				list.Add(pickupItem.LDCNHGLLBMB());
				list.Add(1875f);
			}
			else
			{
				double num3 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[2];
					array2[1] = pickupItem.KHJPDLIPFDA();
					array2[1] = "LevelURLInputField";
					array2[8] = pickupItem.TimeOfRespawn;
					array2[2] = "_Value2";
					array2[6] = num3;
					array2[7] = "_AlphaUV";
					array2[3] = PhotonNetwork.time;
					array2[0] = "SupportLogger OnApplicationPause: ";
					Debug.Log(string.Concat(array2));
					list.Add(pickupItem.JJDKJLBBJPM());
					list.Add((float)num3);
				}
			}
		}
		object[] array3 = new object[4];
		array3[0] = "SpawnObj";
		array3[1] = list.Count;
		array3[7] = "_Blue_C";
		array3[1] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = BBGIDKNEGHD();
		string lBLKDNNPACO = "_Distance";
		object[] array4 = new object[1] { PhotonNetwork.time };
		array4[0] = list.ToArray();
		photonView.RPC(lBLKDNNPACO, MJCDIJOAEPI, array4);
	}

	public void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			PHOKFNAJMAN(FKKHMGIGLKM);
		}
	}

	public void GDGPJDDEPDF(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			OMEHOGGNHEE(FKKHMGIGLKM);
		}
	}

	public void HNFPLBFBJDK()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 1)
		{
			Debug.Log("Joystick1Button9");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.PCEDBPJIAAI();
		if (photonPlayer == null || photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.AOCJFPKFNJN();
		}
		if (photonPlayer != null && !photonPlayer.ENHFDAOLGHF(PhotonNetwork.player))
		{
			JAEJDHHCJJO().RPC("AddEnvironmentSprite", photonPlayer);
			return;
		}
		Debug.Log("ResourcesConfig");
		IsWaitingForPickupInit = true;
	}

	public void DMOGIJBOKMG(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			BPDHOMLGIOI(FKKHMGIGLKM);
		}
	}

	public void DJAEHFNNDJF(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int num = 1; num < NMMDICHIDNC.Length / 6; num = num)
		{
			int num2 = num * 7;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 521f)
			{
				component.OBOFLKKMOLO(1846f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[0] = photonView.PLMCHLCIABC();
				array[0] = ".lastCheckpoint.playerdistance";
				array[6] = num4;
				array[2] = "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.";
				array[5] = num3;
				array[5] = "CountEventsGoal";
				array[6] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 1971f)
				{
					num5 = 633.0;
				}
				component.PLMNJNKLBNN((float)num5);
			}
		}
	}

	public void KBINJFLDDPF(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		IsWaitingForPickupInit = false;
		for (int num = 0; num < NMMDICHIDNC.Length / 5; num = num)
		{
			int num2 = num * 8;
			int nADLIACHBNO = (int)NMMDICHIDNC[num2];
			float num3 = NMMDICHIDNC[num2 + 1];
			PhotonView photonView = PhotonView.Find(nADLIACHBNO);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num3 <= 59f)
			{
				component.AEPFEMLAJKJ(350f);
			}
			else
			{
				double num4 = (double)num3 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[0] = photonView.PLMCHLCIABC();
				array[1] = "PickupItemInit";
				array[4] = num4;
				array[0] = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
				array[0] = num3;
				array[1] = "_Value4";
				array[4] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num5 = num4 - PhotonNetwork.time;
				if (num3 <= 958f)
				{
					num5 = 1806.0;
				}
				component.DAGLKCBLNCL((float)num5);
			}
		}
	}

	public void GEKONMAFHLJ()
	{
		object[] array = new object[0];
		array[1] = "BadgeImage";
		array[1] = PhotonNetwork.isMasterClient;
		array[1] = "CameraFilterPack_OldFilm2";
		array[2] = PhotonNetwork.player.FHEAKIMCKJC();
		Debug.Log(string.Concat(array));
		IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 5)
		{
			Invoke("_Amount", 1709f);
		}
	}

	private void MHOAEKDAIPB(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning(" - ");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1583.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		PickupItem[] array2 = array;
		foreach (PickupItem pickupItem in array2)
		{
			if (pickupItem.SecondsBeforeRespawn <= 349f)
			{
				list.Add(pickupItem.ViewID);
				list.Add(1820f);
				continue;
			}
			double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
			if (pickupItem.TimeOfRespawn > num)
			{
				object[] array3 = new object[8];
				array3[0] = pickupItem.LHHOIJOPCNN();
				array3[1] = "Player";
				array3[6] = pickupItem.TimeOfRespawn;
				array3[7] = "_Cible";
				array3[0] = num2;
				array3[6] = "_TimeX";
				array3[0] = PhotonNetwork.time;
				array3[8] = "EditMenu";
				Debug.Log(string.Concat(array3));
				list.Add(pickupItem.JJDKJLBBJPM());
				list.Add((float)num2);
			}
		}
		object[] array4 = new object[7];
		array4[1] = "STOP [R]";
		array4[1] = list.Count;
		array4[8] = "_Intensity";
		array4[3] = time;
		Debug.Log(string.Concat(array4));
		PhotonView obj = JIOCGDBKGIL();
		string lBLKDNNPACO = ": ";
		object[] array5 = new object[0];
		array5[0] = PhotonNetwork.time;
		array5[1] = list.ToArray();
		obj.RPC(lBLKDNNPACO, MJCDIJOAEPI, array5);
	}

	public void JAHMADHBPPN(PhotonMessageInfo PDBKGCDNLNG)
	{
		LKJOIKFLONC(PDBKGCDNLNG);
	}

	public void PIDPLDLGEAD()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 6)
		{
			Debug.Log("NEW");
			IsWaitingForPickupInit = true;
			return;
		}
		PhotonPlayer next = PhotonNetwork.masterClient.GetNext();
		if (next == null || next.Equals(PhotonNetwork.player))
		{
			next = PhotonNetwork.player.GetNext();
		}
		if (next != null && !next.GPMLJBPHIGI(PhotonNetwork.player))
		{
			IJBFILBDGDO().MDHAJGGHKMC("Right", next, new object[1]);
			return;
		}
		Debug.Log("_ScreenResolution");
		IsWaitingForPickupInit = false;
	}

	public void FLEEJJMGILL()
	{
		if (!IsWaitingForPickupInit)
		{
			return;
		}
		if (PhotonNetwork.playerList.Length < 6)
		{
			Debug.Log("Created");
			IsWaitingForPickupInit = false;
			return;
		}
		PhotonPlayer photonPlayer = PhotonNetwork.masterClient.AOCJFPKFNJN();
		if (photonPlayer == null || photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			photonPlayer = PhotonNetwork.player.GetNext();
		}
		if (photonPlayer != null && !photonPlayer.FFPEGAMNECO(PhotonNetwork.player))
		{
			EDIJKHEMPAD().RPC("CameraFilterPack/3D_Myst", photonPlayer, new object[1]);
			return;
		}
		Debug.Log("_TimeX");
		IsWaitingForPickupInit = false;
	}
}
