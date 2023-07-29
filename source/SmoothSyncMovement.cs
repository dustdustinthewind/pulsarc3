// SmoothSyncMovement
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class SmoothSyncMovement : Photon.MonoBehaviour, IPunObservable
{
	public float SmoothingDelay = 5f;

	private Vector3 OKGJMEKOLIM = Vector3.zero;

	private Quaternion ANHDBFEBADJ = Quaternion.identity;

	public void IEMEHGCFAPD()
	{
		if (!ACPGHFHDCIP().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void LEAHIBJDMBI()
	{
		if (!GBHNDHLAJLI().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void APKNAPHOFHC()
	{
		if (!EOOCGIFFKBG().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void NDAJBJFJGCF()
	{
		if (!AAMNKPHHHCI().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void AFIHOEBJPCG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	public void GLGOLEOAFOD()
	{
		bool flag = true;
		foreach (Component observedComponent in ACPGHFHDCIP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "CameraFilterPack/Blend2Camera_Saturation"));
		}
	}

	public void NEKCPLGFOFD()
	{
		if (!GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void PEMPABLNJHL()
	{
		bool flag = true;
		foreach (Component observedComponent in IBKCMBIGOEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, " Also make sure to disable sprite packing for this sprite."));
		}
	}

	public void IIFCIDDJHPM()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void NPFDCLNGGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	public void EJFJENFKLND()
	{
		if (!JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	public void CCDNJPNLGBN()
	{
		bool flag = true;
		foreach (Component observedComponent in BLMHOKPIMOD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Distortion"));
		}
	}

	public void OCMKCBBCEFG()
	{
		if (!base.photonView.DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void JDGFCEPDKAJ()
	{
		if (!GBMJAPGLMGB().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MAOCOEGAFND()
	{
		if (!IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void Update()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void JOBBGDGHJMB()
	{
		bool flag = false;
		foreach (Component observedComponent in GBHNDHLAJLI().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "RB"));
		}
	}

	public void JJGHNKLDANI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	public void JAAJECBCCFM()
	{
		if (!GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void Awake()
	{
		bool flag = false;
		foreach (Component observedComponent in base.photonView.ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, " is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used."));
		}
	}

	public void CNDGDDLEFJF()
	{
		bool flag = true;
		foreach (Component observedComponent in GBHNDHLAJLI().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "settings.fps"));
		}
	}

	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	public void AAPKBNDHBLI()
	{
		if (!OELHGNKAMEG().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void HMNLHMLILKD()
	{
		if (!IBKCMBIGOEJ().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void FJHFOBHJEHL()
	{
		if (!OELHGNKAMEG().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void PIIMBOLGHOE()
	{
		bool flag = false;
		foreach (Component observedComponent in OELHGNKAMEG().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "IconImage"));
		}
	}

	public void EGEGNHLODAA()
	{
		if (!AAMNKPHHHCI().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void CFIAKIJAILI()
	{
		if (!BLMHOKPIMOD().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void JIBGLHBMGPP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	public void PMBIKIBOHOF()
	{
		bool flag = true;
		foreach (Component observedComponent in CIACEFBNDDJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Value2"));
		}
	}

	public void PNLAIDLOIDE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	public void FIABIKEIEKH()
	{
		bool flag = false;
		foreach (Component observedComponent in BLMHOKPIMOD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "EventMenu"));
		}
	}

	public void HCCMANDFEPL()
	{
		bool flag = true;
		foreach (Component observedComponent in GMAHNPNHMFK().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "#yes"));
		}
	}

	public void OHJHFPNGLEF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	public void AIJGAJIOJDJ()
	{
		if (!OELHGNKAMEG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void CGBHOELMAOC()
	{
		if (!GMAHNPNHMFK().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DAHIMKKFNPH()
	{
		bool flag = true;
		foreach (Component observedComponent in JAEJDHHCJJO().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "settings_bindings_sec_"));
		}
	}

	public void HODGFKONIFC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.position);
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	public void GOBHPAJFFDB()
	{
		bool flag = false;
		foreach (Component observedComponent in ACPGHFHDCIP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Triangle"));
		}
	}

	public void AEEGKLABFLN()
	{
		if (!base.photonView.BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void KMEONPMCNJG()
	{
		if (!GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void JOACBIEHHCE()
	{
		if (!JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void GCHBGCGBMCK()
	{
		if (!FFIPLLNKGEN().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void GEGFJJBCHPE()
	{
		bool flag = true;
		foreach (Component observedComponent in BLMHOKPIMOD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "14"));
		}
	}

	public void FBMDHDBELEK()
	{
		if (!AAMNKPHHHCI().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void KGMCGGIEPDE()
	{
		bool flag = true;
		foreach (Component observedComponent in OELHGNKAMEG().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "offsets"));
		}
	}

	public void DPIPGGDNGHN()
	{
		if (!GBHNDHLAJLI().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void PNLKFANNOKO()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DEJEBOGKMJO()
	{
		bool flag = true;
		foreach (Component observedComponent in ACPGHFHDCIP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "buttons"));
		}
	}

	public void COGBDFKOHKK()
	{
		if (!GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MDOBONJMBKF()
	{
		bool flag = true;
		foreach (Component observedComponent in BLMHOKPIMOD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Value3"));
		}
	}

	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	public void FABKIGNFECE()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MFMIODIAKNI()
	{
		if (!IBKCMBIGOEJ().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void HBPLJMJAAHK()
	{
		bool flag = true;
		foreach (Component observedComponent in OELHGNKAMEG().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "[LevelEditorScene] Error: Timeout :S"));
		}
	}

	public void JNIPABEGJND()
	{
		bool flag = true;
		foreach (Component observedComponent in base.photonView.ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "CameraFilterPack/Distortion_Twist"));
		}
	}

	public void CJHMHIMKILB()
	{
		bool flag = true;
		foreach (Component observedComponent in AAMNKPHHHCI().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Please specify either t or f."));
		}
	}

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	public void CNMIIGDELGE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	public void GPFJMKCGHGB()
	{
		if (!GMAHNPNHMFK().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	public void JHPOIOELNCG()
	{
		if (!ACPGHFHDCIP().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void KPOIJEKDFBE()
	{
		bool flag = false;
		foreach (Component observedComponent in IBKCMBIGOEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "PlayMusic"));
		}
	}

	public void GMELGGJOPBB()
	{
		if (!GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void EJPAMJBIAGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.FADAIFFMBEL(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	public void OJACCGOHBGH()
	{
		bool flag = false;
		foreach (Component observedComponent in FFIPLLNKGEN().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "float,0"));
		}
	}

	public void NEEIFNDHDOG()
	{
		bool flag = false;
		foreach (Component observedComponent in CIACEFBNDDJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "colorD"));
		}
	}

	public void POJFHDFJOPE()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void JBCNIPJDPJB()
	{
		if (!base.photonView.BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void FABMDEHEDNO()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void NCBGPIKDFIA()
	{
		bool flag = true;
		foreach (Component observedComponent in IBKCMBIGOEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Value3"));
		}
	}

	public void PCFHKFCIFHF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	public void EIFCCFBJKOO()
	{
		bool flag = true;
		foreach (Component observedComponent in base.photonView.ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Params"));
		}
	}

	public void LPMINJJPDCH()
	{
		if (!EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void FODIJCCIION(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	public void AGMJDGHLBMN()
	{
		if (!BLMHOKPIMOD().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void KEGNPKFMPDG()
	{
		bool flag = true;
		foreach (Component observedComponent in BLMHOKPIMOD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "{0} hours ago"));
		}
	}

	public void GKDNDDEAAED(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	public void LBIOIEANMGI()
	{
		if (!IBKCMBIGOEJ().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void FMAFBLKAJDF()
	{
		bool flag = true;
		foreach (Component observedComponent in GBHNDHLAJLI().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "#no"));
		}
	}

	public void POIMNOBDBBN()
	{
		if (!EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MBCDCBCLMCI()
	{
		bool flag = true;
		foreach (Component observedComponent in FFIPLLNKGEN().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Error: Timeout :S"));
		}
	}

	public void OEENOOGEEHD()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MJNPIDGNJMK()
	{
		if (!OELHGNKAMEG().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void LBOBAIGNOML()
	{
		bool flag = false;
		foreach (Component observedComponent in ACPGHFHDCIP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Set particles gravity"));
		}
	}

	public void DGCGGKMNPLD()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void LLJLDLLNFBH()
	{
		if (!JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void BGFCMMDKCOI()
	{
		bool flag = false;
		foreach (Component observedComponent in ACPGHFHDCIP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "RenderTextureUtilityTempTexture"));
		}
	}

	public void OIBMHPIFAKK()
	{
		if (!AAMNKPHHHCI().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void POEEMFJIMIP()
	{
		bool flag = true;
		foreach (Component observedComponent in IBKCMBIGOEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, ": "));
		}
	}

	public void GCDNONIKKLI()
	{
		bool flag = true;
		foreach (Component observedComponent in EOOCGIFFKBG().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "IconImage"));
		}
	}
}
