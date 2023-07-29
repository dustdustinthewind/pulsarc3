// PhotonView
using System.Collections.Generic;
using System.Reflection;
using Photon;
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon View &v")]
public class PhotonView : Photon.MonoBehaviour
{
	public int ownerId;

	public byte group;

	protected internal bool PBIDCPBMFKJ;

	public bool OwnerShipWasTransfered;

	public int prefixBackup = -1;

	internal object[] NJDPOGADFJN;

	protected internal object[] EOENPICKCCO;

	protected internal object[] EMJBOOJPAII;

	public ViewSynchronization synchronization;

	public OnSerializeTransform onSerializeTransformOption = OnSerializeTransform.PositionAndRotation;

	public OnSerializeRigidBody onSerializeRigidBodyOption = OnSerializeRigidBody.All;

	public OwnershipOption ownershipTransfer;

	public List<Component> ObservedComponents;

	private Dictionary<Component, MethodInfo> JKIMNJDIPLG = new Dictionary<Component, MethodInfo>(3);

	[SerializeField]
	private int viewIdField;

	public int instantiationId;

	public int currentMasterID = -1;

	protected internal bool GEKLBLEBECG;

	[SerializeField]
	protected internal bool isRuntimeInstantiated;

	protected internal bool IHPAIFIHLAE;

	internal UnityEngine.MonoBehaviour[] HFCEJMOIGDF;

	private MethodInfo EBGDOIJCPMD;

	private bool HPHLCBGKEAG;

	public int prefix
	{
		get
		{
			if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
			{
				prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
			}
			return prefixBackup;
		}
		set
		{
			prefixBackup = value;
		}
	}

	public object[] instantiationData
	{
		get
		{
			if (!GEKLBLEBECG)
			{
				NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(instantiationId);
			}
			return NJDPOGADFJN;
		}
		set
		{
			NJDPOGADFJN = value;
		}
	}

	public int viewID
	{
		get
		{
			return viewIdField;
		}
		set
		{
			bool num = GEKLBLEBECG && viewIdField == 0;
			ownerId = value / PhotonNetwork.MAX_VIEW_IDS;
			viewIdField = value;
			if (num)
			{
				PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			}
		}
	}

	public bool isSceneView => CreatorActorNr == 0;

	public PhotonPlayer owner => PhotonPlayer.Find(ownerId);

	public int OwnerActorNr => ownerId;

	public bool isOwnerActive
	{
		get
		{
			if (ownerId != 0)
			{
				return PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);
			}
			return false;
		}
	}

	public int CreatorActorNr => viewIdField / PhotonNetwork.MAX_VIEW_IDS;

	public bool isMine
	{
		get
		{
			if (ownerId != PhotonNetwork.player.ID)
			{
				if (!isOwnerActive)
				{
					return PhotonNetwork.isMasterClient;
				}
				return false;
			}
			return true;
		}
	}

	public int LHPJFDEFJPC()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	protected internal void DOHOBEJAOED(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			if (!(GJLCNFAGNPO != null))
			{
				return;
			}
			MethodInfo value = null;
			if (!JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out value))
			{
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, PhotonNetworkingMessage.OnPhotonSerializeView.ToString(), out value))
				{
					Debug.LogError("The observed monobehaviour (" + GJLCNFAGNPO.name + ") of this PhotonView does not implement OnPhotonSerializeView()!");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			value?.Invoke(GJLCNFAGNPO, new object[2] { HCIJEDFCNOP, DAGALCAILLN });
		}
	}

	public bool FJEMLGIGOCJ()
	{
		return CreatorActorNr == 0;
	}

	public static PhotonView Get(GameObject PJCLKEBEKAP)
	{
		return PJCLKEBEKAP.GetComponent<PhotonView>();
	}

	public void OKHNMAMFDFD(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	public void KGGHPNEFFLL()
	{
		HFCEJMOIGDF = GetComponents<UnityEngine.MonoBehaviour>();
	}

	public static PhotonView BONCCOJCGAF(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public int HDJPGFBJDPK()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	public int GHNNKHPAFGD()
	{
		return ownerId;
	}

	public bool DOLKFPIABDD()
	{
		if (ownerId != PhotonNetwork.player.ID && !PFCJNOLLHNF())
		{
			return PhotonNetwork.isMasterClient;
		}
		return false;
	}

	public void CHLIDEOBECE(int DPNHODJHGJL)
	{
		bool num = GEKLBLEBECG && viewIdField == 0;
		ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		viewIdField = DPNHODJHGJL;
		if (num)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
		}
	}

	public void IAEIOEGJOBD()
	{
		HFCEJMOIGDF = GetComponents<UnityEngine.MonoBehaviour>();
	}

	protected internal void DFMDMJHNKGL(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			BGNIOHIFNAO(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
				transform.localScale = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
				break;
			case (OnSerializeRigidBody)3:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = onSerializeRigidBodyOption;
			switch (onSerializeRigidBody)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
				return;
			case (OnSerializeRigidBody)8:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
				return;
			}
			if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
			{
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
		else
		{
			Debug.LogError("DPADHOR");
		}
	}

	protected internal void BPPCEKEMNMC(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			if (!(GJLCNFAGNPO != null))
			{
				return;
			}
			MethodInfo value = null;
			if (!JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out value))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)72).ToString(), out value))
				{
					Debug.LogError(". local RequestedView.ownerId: " + GJLCNFAGNPO.name + "_Value2");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			if (value != null)
			{
				MethodBase methodBase = value;
				object[] array = new object[2] { null, HCIJEDFCNOP };
				array[0] = DAGALCAILLN;
				methodBase.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	public void LPLDDGOEEIJ(PhotonPlayer DELECHPDOCO)
	{
		if (PCLFPBHIHOD() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ID;
		}
		currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	protected internal void BGNIOHIFNAO(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			if (!(GJLCNFAGNPO != null))
			{
				return;
			}
			MethodInfo value = null;
			if (!JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out value))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-106)).ToString(), out value))
				{
					Debug.LogError("BloodAlternative1" + GJLCNFAGNPO.name + "UpdateNewsTileStart");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			value?.Invoke(GJLCNFAGNPO, new object[5] { HCIJEDFCNOP, DAGALCAILLN, null, null, null });
		}
	}

	public void GAAMDOMCJLK(PhotonPlayer DELECHPDOCO)
	{
		if (PCLFPBHIHOD() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ID;
		}
		currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	public void IAHMGNHJAKK()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(EIMHMIJGMHG(), ownerId);
	}

	public int IJHCDIHGOHJ()
	{
		return ownerId;
	}

	public virtual string EJGAGAODACL()
	{
		object[] array = new object[8];
		array[0] = viewID;
		array[0] = ((!(base.gameObject != null)) ? "JoinButton" : base.gameObject.name);
		array[4] = ((!LIDEPDFOMFC()) ? string.Empty : "achievements.21.completed.");
		array[1] = LHPJFDEFJPC();
		return string.Format("Added GameObject to prefabDictionary: ", array);
	}

	public void HANOCKILFNJ(int DPNHODJHGJL)
	{
		bool num = !GEKLBLEBECG || viewIdField == 0;
		ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		viewIdField = DPNHODJHGJL;
		if (num)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
		}
	}

	protected internal void LKGCFPHCPAP(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			DOHOBEJAOED(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.All:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.All:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else
		{
			Debug.LogError("Type of observed is unknown when receiving.");
		}
	}

	protected internal void EGBMPDLBLBM(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			if (!(GJLCNFAGNPO != null))
			{
				return;
			}
			MethodInfo value = null;
			if (!JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out value))
			{
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-16)).ToString(), out value))
				{
					Debug.LogError("_Far" + GJLCNFAGNPO.name + "High");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			if (value != null)
			{
				MethodInfo methodInfo = value;
				object[] array = new object[0];
				array[1] = HCIJEDFCNOP;
				array[1] = DAGALCAILLN;
				methodInfo.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	public void AFFCGFGOHAE(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	protected internal void PIIBOGMMNCI(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			BPPCEKEMNMC(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.CPIBABMPJLE(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.PBECMJMDHBI(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.PNAPNHJHBMN(transform.localPosition);
				HCIJEDFCNOP.BBHGPGBHMML(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.FADAIFFMBEL(transform.localPosition);
				HCIJEDFCNOP.BBHGPGBHMML(transform.localRotation);
				HCIJEDFCNOP.FADAIFFMBEL(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = onSerializeRigidBodyOption;
			switch (onSerializeRigidBody)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.OLACNHHHOEL(rigidbody.angularVelocity);
				return;
			case OnSerializeRigidBody.All:
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody.velocity);
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody.angularVelocity);
				return;
			}
			if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(rigidbody.velocity);
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.IBCLJIACBKG(rigidbody2D.velocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.FADAIFFMBEL(rigidbody2D.angularVelocity);
				break;
			case (OnSerializeRigidBody)7:
				HCIJEDFCNOP.FADAIFFMBEL(rigidbody2D.velocity);
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				break;
			}
		}
		else
		{
			Debug.LogError("_NoiseTilingPerChannel" + GJLCNFAGNPO.GetType());
		}
	}

	public PhotonPlayer JJFEGIOPFGN()
	{
		return PhotonPlayer.GJMEMHIGMGN(ownerId);
	}

	public int PHKEOGCANIG()
	{
		return ownerId;
	}

	public int HINDCAIAACA()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (CreatorActorNr == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ID;
		}
		currentMasterID = DELECHPDOCO.ID;
	}

	public void OILIKMGIHFL(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	public void HEKCAIGGGOK(PhotonPlayer DELECHPDOCO)
	{
		if (PCLFPBHIHOD() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		currentMasterID = DELECHPDOCO.ID;
	}

	protected internal void EPCGHAAONLN()
	{
		if (NPPEFODKHKN() != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(instantiationId);
		}
		GEKLBLEBECG = true;
	}

	protected internal void FHKLBHIOKKN()
	{
		if (!IHPAIFIHLAE)
		{
			bool num = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag = false;
			if (num && !flag && instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("[ItemsHandler] Found " + base.gameObject.name + ":");
			}
		}
	}

	public int PCLFPBHIHOD()
	{
		return viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	public void RPC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	public void NPCJOLMMCGB(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public void IKIJDNPJKPM(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	public static PhotonView CPHCOHILOAA(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public void RpcSecure(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public void TransferOwnership(PhotonPlayer FPMBEPHLNMN)
	{
		TransferOwnership(FPMBEPHLNMN.ID);
	}

	public void GPEJDIHFIMM()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(EIMHMIJGMHG(), ownerId);
	}

	public virtual string COELLBGIPPO()
	{
		object[] array = new object[7];
		array[1] = KINIHBOKFJH();
		array[1] = ((!(base.gameObject != null)) ? "maps." : base.gameObject.name);
		array[3] = ((!LIDEPDFOMFC()) ? string.Empty : "EventSystem");
		array[5] = LHPJFDEFJPC();
		return string.Format("CameraFilterPack/Lut_PlayWith", array);
	}

	protected internal void CGCDEFOFKJD(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			DEMHLCDNKGE(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
				transform.localScale = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case (OnSerializeRigidBody)7:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = onSerializeRigidBodyOption;
			if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
			{
				switch (onSerializeRigidBody)
				{
				case OnSerializeRigidBody.OnlyVelocity:
					rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
					break;
				case OnSerializeRigidBody.OnlyAngularVelocity:
					rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
					break;
				}
			}
			else
			{
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
		else
		{
			Debug.LogError("_BlendTex");
		}
	}

	public void SerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int i = 0; i < ObservedComponents.Count; i++)
			{
				IPOLPPFEJDL(ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	protected internal void Awake()
	{
		if (viewID != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(instantiationId);
		}
		GEKLBLEBECG = true;
	}

	public void RefreshRpcMonoBehaviourCache()
	{
		HFCEJMOIGDF = GetComponents<UnityEngine.MonoBehaviour>();
	}

	protected internal void OnDestroy()
	{
		if (!IHPAIFIHLAE)
		{
			bool num = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag = false;
			if (num && !flag && instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("PUN-instantiated '" + base.gameObject.name + "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
			}
		}
	}

	public void TransferOwnership(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(viewID, BJKANENNNOF);
		ownerId = BJKANENNNOF;
	}

	public static PhotonView HGJPAIACMIF(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	protected internal void KBMGJLMJFOE()
	{
		if (!IHPAIFIHLAE)
		{
			bool num = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag = true;
			if (num && !flag && instantiationId > 1 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("_ColorG" + base.gameObject.name + "Default UI Material");
			}
		}
	}

	public bool IIJCADFOLOO()
	{
		if (ownerId != 0)
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);
		}
		return false;
	}

	public void BDEJOHNPIFG(PhotonPlayer DELECHPDOCO)
	{
		if (FOLKNAAAEAJ() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		currentMasterID = DELECHPDOCO.ID;
	}

	public void OMADJOEHOGE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 1)
		{
			for (int i = 0; i < ObservedComponents.Count; i++)
			{
				PIIBOGMMNCI(ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	public static PhotonView JCDPMMJDLOP(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public void RPC(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	public int NPPEFODKHKN()
	{
		return viewIdField;
	}

	public bool PFCJNOLLHNF()
	{
		if (ownerId != 0)
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);
		}
		return true;
	}

	public void LIPHBCELHLO(PhotonPlayer FPMBEPHLNMN)
	{
		INKNMCPAAGF(FPMBEPHLNMN.ID);
	}

	public int LILIOIJNOGO()
	{
		return viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	public static PhotonView Get(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	public void KEKKFNNMLMG(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	public void IBGILLAEDFA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int num = 0; num < ObservedComponents.Count; num = num)
			{
				FHDECBOJGBN(ObservedComponents[num], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	public int EIMHMIJGMHG()
	{
		return viewIdField;
	}

	public void DeserializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int i = 0; i < ObservedComponents.Count; i++)
			{
				LKGCFPHCPAP(ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	public void PLMAEOHKJPN(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, true, GNNEKCBOBEG);
	}

	public bool KCAOJFPDEIP()
	{
		if (ownerId != PhotonNetwork.player.ONIKFABKELO())
		{
			if (!isOwnerActive)
			{
				return PhotonNetwork.isMasterClient;
			}
			return true;
		}
		return false;
	}

	public void MIAHMDGOOPJ(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	public void OEJDHFFNMFD(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public void GNFNHDCJOFC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	public void DPLELHEFMBE(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	public void BIMKLKFMOCB(int DPNHODJHGJL)
	{
		prefixBackup = DPNHODJHGJL;
	}

	public void PBMFBOOALKA(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	protected internal void IOMCHHBGJEC()
	{
		if (viewID != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(instantiationId);
		}
		GEKLBLEBECG = false;
	}

	public void JKICFMOKDHK(PhotonPlayer DELECHPDOCO)
	{
		if (PCLFPBHIHOD() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ID;
		}
		currentMasterID = DELECHPDOCO.ID;
	}

	public void RequestOwnership()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(viewID, ownerId);
	}

	protected internal void IPOLPPFEJDL(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			DOHOBEJAOED(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.SendNext(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				HCIJEDFCNOP.SendNext(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				HCIJEDFCNOP.SendNext(transform.localRotation);
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				break;
			case OnSerializeRigidBody.All:
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				break;
			case OnSerializeRigidBody.All:
				HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				break;
			}
		}
		else
		{
			Debug.LogError("Observed type is not serializable: " + GJLCNFAGNPO.GetType());
		}
	}

	protected internal void DEMHLCDNKGE(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			if (!(GJLCNFAGNPO != null))
			{
				return;
			}
			MethodInfo value = null;
			if (!JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out value))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-55)).ToString(), out value))
				{
					Debug.LogError("file://" + GJLCNFAGNPO.name + "_Saturation");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			if (value != null)
			{
				MethodInfo methodInfo = value;
				object[] array = new object[7];
				array[1] = HCIJEDFCNOP;
				array[1] = DAGALCAILLN;
				methodInfo.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	public void EJGGMCHNJDI(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	protected internal void FHDECBOJGBN(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			DEMHLCDNKGE(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.CPIBABMPJLE(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.OLACNHHHOEL(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.PBECMJMDHBI(transform.localPosition);
				HCIJEDFCNOP.IBCLJIACBKG(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.BBHGPGBHMML(transform.localPosition);
				HCIJEDFCNOP.PBECMJMDHBI(transform.localRotation);
				HCIJEDFCNOP.PNAPNHJHBMN(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.BBHGPGBHMML(rigidbody.velocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.IBCLJIACBKG(rigidbody.angularVelocity);
				break;
			case (OnSerializeRigidBody)4:
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.IBCLJIACBKG(rigidbody2D.velocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.PBECMJMDHBI(rigidbody2D.angularVelocity);
				break;
			case (OnSerializeRigidBody)3:
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody2D.velocity);
				HCIJEDFCNOP.OLACNHHHOEL(rigidbody2D.angularVelocity);
				break;
			}
		}
		else
		{
			Debug.LogError("SfxVolumeSlider" + GJLCNFAGNPO.GetType());
		}
	}

	protected internal void KDPJOLMNEPG()
	{
		if (!IHPAIFIHLAE)
		{
			bool num = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag = false;
			if (num && !flag && instantiationId > 1 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("Set sun min/max size" + base.gameObject.name + ">");
			}
		}
	}

	public void INKNMCPAAGF(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(EIMHMIJGMHG(), BJKANENNNOF);
		ownerId = BJKANENNNOF;
	}

	public void FOLJDOPCBNA(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	public static PhotonView PMLJACJKPLN(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public void EIGJKNOFCHH(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(KINIHBOKFJH(), BJKANENNNOF);
		ownerId = BJKANENNNOF;
	}

	public int LLHIOGOHDPK()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	public void DKGMOICLEMI(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public void IEJEHKMNLHE(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public override string ToString()
	{
		return string.Format("View ({3}){0} on {1} {2}", viewID, (!(base.gameObject != null)) ? "GO==null" : base.gameObject.name, (!isSceneView) ? string.Empty : "(scene)", prefix);
	}

	public static PhotonView IOENOELDJOF(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public void RpcSecure(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public bool BGJKMGJBPFA()
	{
		if (ownerId != PhotonNetwork.player.ONIKFABKELO())
		{
			if (!JFLEHJHLAOH())
			{
				return PhotonNetwork.isMasterClient;
			}
			return false;
		}
		return true;
	}

	public void BJKCNDBLHML(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int i = 0; i < ObservedComponents.Count; i++)
			{
				FHDECBOJGBN(ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	public void JGGMHLIHLHJ()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(EIMHMIJGMHG(), ownerId);
	}

	public void OMGPDMLNBIO()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(viewID, ownerId);
	}

	public int FOLKNAAAEAJ()
	{
		return viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	public static PhotonView Find(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public virtual string BNGOOJMFMDB()
	{
		object[] array = new object[7];
		array[0] = EIMHMIJGMHG();
		array[0] = ((!(base.gameObject != null)) ? "value" : base.gameObject.name);
		array[6] = ((!NADJFHDOFGD()) ? string.Empty : "_TimeX");
		array[1] = LHPJFDEFJPC();
		return string.Format("_ChangeGreen", array);
	}

	public static PhotonView FNNLDKMFBEB(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public int KINIHBOKFJH()
	{
		return viewIdField;
	}

	public bool NADJFHDOFGD()
	{
		return PCLFPBHIHOD() == 1;
	}

	public int HAKJLPJJEPB()
	{
		return ownerId;
	}

	public void CFNCHMDHHOG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int num = 0; num < ObservedComponents.Count; num = num)
			{
				CGCDEFOFKJD(ObservedComponents[num], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	public void ICGKDCPIOML()
	{
		HFCEJMOIGDF = GetComponents<UnityEngine.MonoBehaviour>();
	}

	public bool JFLEHJHLAOH()
	{
		if (ownerId != 0)
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);
		}
		return true;
	}

	public PhotonPlayer JFCKAGHNNCA()
	{
		return PhotonPlayer.Find(ownerId);
	}

	public void NIFBLFCCLCD(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(viewID, BJKANENNNOF);
		ownerId = BJKANENNNOF;
	}

	public void JAFHOIGANHK(PhotonPlayer DELECHPDOCO)
	{
		if (LILIOIJNOGO() == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	public bool LIDEPDFOMFC()
	{
		return PCLFPBHIHOD() == 1;
	}

	public void KACECEKIPPP(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, true, GNNEKCBOBEG);
	}

	public void OKNICNLFLFP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (ObservedComponents != null && ObservedComponents.Count > 0)
		{
			for (int i = 1; i < ObservedComponents.Count; i++)
			{
				CGCDEFOFKJD(ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}
}
