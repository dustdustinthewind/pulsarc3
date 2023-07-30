// PhotonView
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
			bool flag = GEKLBLEBECG && viewIdField == 0;
			ownerId = value / PhotonNetwork.MAX_VIEW_IDS;
			viewIdField = value;
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			}
		}
	}

	public bool isSceneView => CreatorActorNr == 0;

	public PhotonPlayer owner => PhotonPlayer.Find(ownerId);

	public int OwnerActorNr => ownerId;

	public bool isOwnerActive => ownerId != 0 && PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);

	public int CreatorActorNr => viewIdField / PhotonNetwork.MAX_VIEW_IDS;

	public bool isMine => ownerId == PhotonNetwork.player.ID || (!isOwnerActive && PhotonNetwork.isMasterClient);

	public override string ToString()
	{
		return string.Format("View ({3}){0} on {1} {2}", viewID, (!(base.gameObject != null)) ? "GO==null" : base.gameObject.name, (!isSceneView) ? string.Empty : "(scene)", prefix);
	}

	[SpecialName]
	public void BCPHKBHMKLM(int DPNHODJHGJL)
	{
		prefixBackup = DPNHODJHGJL;
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
			case OnSerializeTransform.All:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				HCIJEDFCNOP.SendNext(transform.localRotation);
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
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
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.All:
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				break;
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.All:
				HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				break;
			case OnSerializeRigidBody.OnlyVelocity:
				HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
				break;
			}
		}
		else
		{
			Debug.LogError("Observed type is not serializable: " + GJLCNFAGNPO.GetType());
		}
	}

	protected internal void MFOIOFBPOGI(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)43).ToString(), out value))
				{
					Debug.LogError("_TimeX" + GJLCNFAGNPO.name + "path");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			if (value != null)
			{
				MethodInfo methodInfo = value;
				object[] array = new object[0];
				array[1] = HCIJEDFCNOP;
				array[0] = DAGALCAILLN;
				methodInfo.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	public static PhotonView Get(GameObject PJCLKEBEKAP)
	{
		return PJCLKEBEKAP.GetComponent<PhotonView>();
	}

	public void RPC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	protected internal void PFIJPOBKHJK(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)111).ToString(), out value))
				{
					Debug.LogError("L1" + GJLCNFAGNPO.name + "red");
					value = null;
				}
				JKIMNJDIPLG.Add(GJLCNFAGNPO, value);
			}
			value?.Invoke(GJLCNFAGNPO, new object[2] { HCIJEDFCNOP, DAGALCAILLN });
		}
	}

	[SpecialName]
	public void GDDHHBELCDH(int DPNHODJHGJL)
	{
		bool flag = !GEKLBLEBECG || viewIdField == 1;
		ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		viewIdField = DPNHODJHGJL;
		if (flag)
		{
			PhotonNetwork.JNJJAMNLOHA.NNENGIKPKII(this);
		}
	}

	public static PhotonView OPKCMFNCPBG(GameObject PJCLKEBEKAP)
	{
		return PJCLKEBEKAP.GetComponent<PhotonView>();
	}

	[SpecialName]
	public void CEOBDOGBIAG(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	public static PhotonView EFFCMNHBPME(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	protected internal void LCKEHMMIFEI()
	{
		if (!IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = true;
			if (flag && !flag2 && instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("Offline or in OfflineMode. No VitalStats available." + base.gameObject.name + " beatThreshold: ");
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

	public static PhotonView LDFAJOELLBC(GameObject PJCLKEBEKAP)
	{
		return PJCLKEBEKAP.GetComponent<PhotonView>();
	}

	public static PhotonView Get(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	[SpecialName]
	public int APFBDHMKOBB()
	{
		return ownerId;
	}

	[SpecialName]
	public PhotonPlayer GLFNAPCBIJP()
	{
		return PhotonPlayer.HKKKGOHGKHH(ownerId);
	}

	[SpecialName]
	public void CIPNPDCMAHO(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	[SpecialName]
	public int HDJPGFBJDPK()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	public void ANOBOMGHJKG()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(viewID, ownerId);
	}

	protected internal void OnDestroy()
	{
		if (!IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = false;
			if (flag && !flag2 && instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("PUN-instantiated '" + base.gameObject.name + "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
			}
		}
	}

	public void RPC(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	public void RpcSecure(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public void JOMFMMILOGC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
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
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
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
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.All:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case OnSerializeRigidBody.All:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else
		{
			Debug.LogError("Type of observed is unknown when receiving.");
		}
	}

	public void TransferOwnership(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(viewID, BJKANENNNOF);
		ownerId = BJKANENNNOF;
	}

	public void MDHAJGGHKMC(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
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

	[SpecialName]
	public void LCMAFGIMNJN(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	protected internal void OPBLADBLLDO(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = onSerializeRigidBodyOption;
			switch (onSerializeRigidBody)
			{
			case (OnSerializeRigidBody)6:
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
				return;
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				return;
			}
			if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
			{
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			switch (onSerializeRigidBodyOption)
			{
			case (OnSerializeRigidBody)5:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeRigidBody.OnlyAngularVelocity:
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
				break;
			case OnSerializeRigidBody.OnlyVelocity:
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else
		{
			Debug.LogError("_TimeX");
		}
	}

	public override string COELLBGIPPO()
	{
		object[] array = new object[6];
		array[0] = viewID;
		array[0] = ((!(base.gameObject != null)) ? "CameraFilterPack/Blend2Camera_Exclusion" : base.gameObject.name);
		array[6] = ((!isSceneView) ? string.Empty : ". Client should be in a room. Current connectionStateDetailed: ");
		array[0] = PHIDJBPAMCL();
		return string.Format("input", array);
	}

	[SpecialName]
	public void MFAHOENKMGJ(int DPNHODJHGJL)
	{
		bool flag = GEKLBLEBECG && viewIdField == 1;
		ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		viewIdField = DPNHODJHGJL;
		if (flag)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
		}
	}

	public void TransferOwnership(PhotonPlayer FPMBEPHLNMN)
	{
		TransferOwnership(FPMBEPHLNMN.ID);
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (CreatorActorNr == 0 && !OwnerShipWasTransfered && (currentMasterID == -1 || ownerId == currentMasterID))
		{
			ownerId = DELECHPDOCO.ID;
		}
		currentMasterID = DELECHPDOCO.ID;
	}

	public void LGJCOOFAPLJ(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	public static PhotonView Find(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	public void NMFAOOPKELF()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(PLMCHLCIABC(), ownerId);
	}

	[SpecialName]
	public int PLMCHLCIABC()
	{
		return viewIdField;
	}

	public void RequestOwnership()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(viewID, ownerId);
	}

	[SpecialName]
	public bool CFLOFFPCPHL()
	{
		return ownerId != 0 && PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(ownerId);
	}

	[SpecialName]
	public void LFDDHOMAOIP(object[] DPNHODJHGJL)
	{
		NJDPOGADFJN = DPNHODJHGJL;
	}

	public void RefreshRpcMonoBehaviourCache()
	{
		HFCEJMOIGDF = GetComponents<UnityEngine.MonoBehaviour>();
	}

	[SpecialName]
	public int PHIDJBPAMCL()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	public void RpcSecure(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	[SpecialName]
	public int ECLDAGMPMBN()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}

	[SpecialName]
	public int GFNDNEDMBLO()
	{
		if (prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			prefixBackup = PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return prefixBackup;
	}
}
