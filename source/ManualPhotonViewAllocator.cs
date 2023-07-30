// ManualPhotonViewAllocator
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class ManualPhotonViewAllocator : MonoBehaviour
{
	public GameObject Prefab;

	public void AHINONNHLKK(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(444f, 1984f, 609f), Quaternion.identity);
		gameObject.GetPhotonView().MFAHOENKMGJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void BEECAKMHDBH(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1174f, 1838f, 1387f), Quaternion.identity);
		gameObject.GetPhotonView().MFAHOENKMGJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void DNPDKDOCCMN(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(788f, 1355f, 1165f), Quaternion.identity);
		gameObject.GetPhotonView().MFAHOENKMGJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void GNIELEFPHHB(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(35f, 939f, 358f), Quaternion.identity);
		gameObject.GetPhotonView().GDDHHBELCDH(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void FKNNOELEIAP(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(653f, 164f, 1732f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void CDFEHEHHJGP()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Can't start OFFLINE mode while connected!");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("_Bullet_3", (PhotonTargets)7, array);
	}

	[PunRPC]
	public void InstantiateRpc(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void HCGEFLJKFEB()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[ItemsHandler] Found ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("???", (PhotonTargets)7, array);
	}

	public void OJADEOOANDA(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(611f, 660f, 430f), Quaternion.identity);
		gameObject.GetPhotonView().GDDHHBELCDH(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void ALADKDEIEBE()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError(" not exist");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("Joystick1Button12", PhotonTargets.MasterClient, num);
	}

	public void EFDEFLCEOBA(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(4f, 1611f, 1378f), Quaternion.identity);
		gameObject.GetPhotonView().MFAHOENKMGJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void OECHDJJKJPJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("checkpoint");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("maps.", PhotonTargets.MasterClient, array);
	}

	public void PJNNJMKGNCC(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(586f, 923f, 27f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void OPMMMFJMEJM(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(1092f, 1208f, 235f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void HOGDNALKMDN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("There is already a virtual button named ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.RPC("Image", (PhotonTargets)8, array);
	}

	public void JBIEHBLKALE(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(24f, 1541f, 38f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void OEPJDLNAGBK(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(167f, 342f, 925f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	public void PIHJPHOGAHM()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("AddEnvironmentObject");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", PhotonTargets.MasterClient, array);
	}

	public void LEOMJGLFAIJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("checkpoint");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[1] = num;
		photonView.RPC("mapselector.filter.rateduponly", PhotonTargets.MasterClient, array);
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

	public void FIKAPCKGFBF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("DPADVER");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[1];
		array[1] = num;
		photonView.RPC("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", (PhotonTargets)7, array);
	}

	public void PBOJOOJBBAG()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Reload Steam Inventory");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("_Amount", PhotonTargets.AllBufferedViaServer, array);
	}

	public void MGACFHNMAPC(int NADLIACHBNO)
	{
		GameObject gameObject = Object.Instantiate(Prefab, InputToEvent.inputHitPos + new Vector3(765f, 1860f, 1954f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	public void KJKIEKIDNAN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[Down]");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		object[] array = new object[0];
		array[0] = num;
		photonView.RPC("_ScreenResolution", (PhotonTargets)7, array);
	}

	public void FELIMAHNPME()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_TimeX");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("Parent object ID. Case-Sensitive", PhotonTargets.AllViaServer, num);
	}
}
