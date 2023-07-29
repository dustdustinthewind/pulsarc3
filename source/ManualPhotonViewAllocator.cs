// ManualPhotonViewAllocator
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class ManualPhotonViewAllocator : MonoBehaviour
{
	public GameObject Prefab;

	public void FELIMAHNPME()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_TimeX");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.MIAHMDGOOPJ("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", (PhotonTargets)7, array);
	}

	public void KIEKDKCDOOI(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(829f, 1863f, 951f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void BALABNBJNAM()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_Value");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.GNFNHDCJOFC("{0:0} second{1}", PhotonTargets.AllViaServer, array);
	}

	public void ENPINIGKJCA()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("DPADHOR");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.PBMFBOOALKA("{0:x2}", PhotonTargets.AllBuffered, array);
	}

	public void AllocateManualPhotonView()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Can't do manual instantiation without PhotonView component.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("InstantiateRpc", PhotonTargets.AllBuffered, num);
	}

	public void OEOBFBIKNNB(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(726f, 190f, 1085f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void OJADEOOANDA(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(903f, 496f, 124f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void ODLLHGPEIEN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("/theme");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.KEKKFNNMLMG(" not exist", PhotonTargets.AllBuffered, array);
	}

	public void CCFIGBIAOKJ(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(518f, 656f, 762f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void LEOMJGLFAIJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[1];
		array[1] = num;
		photonView.GNFNHDCJOFC("SpawnObj", PhotonTargets.AllBufferedViaServer, array);
	}

	public void GAOCIFNKIMN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("LevelEditor/icons");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[1];
		array[1] = num;
		photonView.KEKKFNNMLMG("music", PhotonTargets.OthersBuffered, array);
	}

	public void MFDEGAAIMOD()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("LoadPlayerSkin");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.IKIJDNPJKPM("_Value3", (PhotonTargets)8, array);
	}

	public void PPBNIGECGIF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Start");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.KEKKFNNMLMG("_TimeX", PhotonTargets.Others, array);
	}

	public void FIKAPCKGFBF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[Right]");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.RPC(" scene view IDs from last level.", (PhotonTargets)8, array);
	}

	public void JOAJGAFKGJB(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1404f, 610f, 1025f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void EFDEFLCEOBA(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(571f, 1288f, 282f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void PANCEPGLHOK()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("ItemNameBGImage");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.IKIJDNPJKPM(".lastCheckpoint.playerdistance", PhotonTargets.All, array);
	}

	public void HCGEFLJKFEB()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("settings.arcsnohitsoundtimedelay", (PhotonTargets)8, array);
	}

	public void PBOJOOJBBAG()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[LocalizationService] Localization: ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("_Value4", PhotonTargets.MasterClient, array);
	}

	public void OECHDJJKJPJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("NO");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG("{", PhotonTargets.MasterClient, new object[1] { num });
	}

	public void DNPDKDOCCMN(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1888f, 1346f, 1499f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void CGIHDPNNDKJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_MainTex2");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.IKIJDNPJKPM("Set particles start speed", PhotonTargets.Others, array);
	}

	public void GAGFNPBLOID(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(247f, 109f, 1024f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void NENBEPHNIGJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_Distortion");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG(".lastCheckpoint.isMapCompleted", (PhotonTargets)8, new object[1] { num });
	}

	public void DKGIABDLAPF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("\nv.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("Failed to Instantiate prefab: ", PhotonTargets.Others, num);
	}

	public void AHINONNHLKK(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(448f, 0f, 1911f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void PIHJPHOGAHM()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("</i>");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.MIAHMDGOOPJ(" - GameWebCallback] - ", PhotonTargets.AllViaServer, array);
	}

	public void FKNNOELEIAP(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1393f, 1079f, 61f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void MLCCJFMOJOC()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("HiddenToggle");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.IKIJDNPJKPM("_Value2", (PhotonTargets)7, array);
	}

	public void NJEPKEAEPBC(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1006f, 285f, 1464f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void MIMECNMKDNF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("SetSunEmission");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG(" from: ", PhotonTargets.All, new object[1] { num });
	}

	public void NNLKLBLKOHC(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1219f, 989f, 1329f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void OEFDPMAOHHP()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("GlassAberration");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.MIAHMDGOOPJ("CameraFilterPack/TV_WideScreenHorizontal", (PhotonTargets)8, array);
	}

	public void JBIEHBLKALE(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1090f, 1687f, 1565f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void OEPJDLNAGBK(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(909f, 232f, 1938f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void CCFKAEGHEJO()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Error: Can not set the OnSerialize rate higher than the overall SendRate.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.PBMFBOOALKA("UseScanLine", PhotonTargets.OthersBuffered, new object[1] { num });
	}

	public void OFEEDOGFNLA(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(701f, 1515f, 751f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	[PunRPC]
	public void InstantiateRpc(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void KFGEMGKGBDA()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("CheckResources () for ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.IKIJDNPJKPM("LevelConfigButton", PhotonTargets.AllBufferedViaServer, new object[1] { num });
	}

	public void PLKIEFBPPDJ(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1078f, 513f, 961f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}
}
