// PhotonRigidbody2DView
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
[AddComponentMenu("Photon Networking/Photon Rigidbody 2D View")]
[RequireComponent(typeof(Rigidbody2D))]
public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	private Rigidbody2D LPFEBLNEEOF;

	private void OJACCGOHBGH()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void GBNOIKAPBBO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void GEGFJJBCHPE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void PMBIKIBOHOF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void PEMPABLNJHL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void BHCCNFJKGPD()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void FBMDDFMGFMF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void EOBMGCKFNNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	private void EBPAOCJEJGE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	private void PIIMBOLGHOE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void LHMDCEDONEE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void IOMCHHBGJEC()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void CJKDMGMPMJM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void CBIDBNCBLGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	private void IIPMEPPIFCK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	public void NLCNKMOLPNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	private void MFCCNPEIOGP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void JNENAPDBOKE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void GGPOCCFNMDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	private void OPFDGBDADMA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void IGACCOIJFGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public void JLPFFACDLJL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	private void PPCGJBIIFAO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void HIDJLJIEPHK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	private void IKGFIOIADLN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void OFFPGECPIMN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	private void FNMPIAMIKCP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void KPOIJEKDFBE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void EIGONAHJHNO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void LIFMLJFPLDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	private void HCCMANDFEPL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void EJPKMLLGMGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void PHHOMLJECOJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void IKKPINNOOLG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void LJEFMGOBKGE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void KAAHPMKNHAD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void JEEINPBLBDI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void BAEICBGEECA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	private void LFHKGIHNONL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void NPFDCLNGGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void BEPJPKCOLJH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	private void FKDHFNCOKAK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void GGKPLCJNEHF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void DHCCMDLAJIO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void FMAFBLKAJDF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void OBPCMAFGLON()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void EJPAMJBIAGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	private void JNBMKLFJCEM()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void LBDNIDJNDJK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	private void CJHMHIMKILB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void MKPBBAPGGND(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	private void MFAMHKBMBEI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void AAAGGIHAKEH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	private void EMKLCPGKNJL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void DALBCFGNLLD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	private void DHNANELONED()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void MCIEAOAMOIG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void POHMFMNEPKK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void AJIKPEIGACI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void IFHKKPEFEOM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	private void GOBHPAJFFDB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void OHJHFPNGLEF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	private void JBIFKBNPHJE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void BFIOIDMHPPL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void MBIPCKMIBFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	private void Awake()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void MADENBGHKDD()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	private void OJBFBLHIEBB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void LBLAKDBHADA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void AFIHOEBJPCG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	private void EMANBHKAONB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void KACPCCMPAHA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void GGEKDHHOOCH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public void JNCHBPPANKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}
}
