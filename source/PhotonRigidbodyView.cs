// PhotonRigidbodyView
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon Rigidbody View")]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PhotonView))]
public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	private Rigidbody LPFEBLNEEOF;

	private void LOMHIIKFFEP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void IIPMEPPIFCK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void FAAJAMIGJNK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void DCKLCCMEGAA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	public void KAAHPMKNHAD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public void HBBLLHAOBLE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void JEEINPBLBDI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void FMAFBLKAJDF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	private void BODPLDJLFCF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void HPGOHBHACKF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	private void BMAGFLLGDPJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void BAEICBGEECA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	private void Awake()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void KLFPENLPMJP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void CBIDBNCBLGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}
}
