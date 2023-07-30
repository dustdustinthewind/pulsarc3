// PhotonRigidbody2DView
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon Rigidbody 2D View")]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PhotonView))]
public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	private Rigidbody2D LPFEBLNEEOF;

	public void BJHJEDJDCEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void FBMDDFMGFMF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void MPGJDLCANPA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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

	public void NMMEHKPNBCA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void MDGEJFNOJCF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void GBNDJBNLKLI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
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

	private void CCDNJPNLGBN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void DCKLCCMEGAA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
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

	public void CLNCFAJJONH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void IICACFLHBCP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void HCNECNPPEKA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void MCEKDLDCGAO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void PPCGJBIIFAO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void EPCAPPLPFED()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void LBLAKDBHADA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void IOIECPHCEHD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
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

	private void OPFDGBDADMA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void LBDNIDJNDJK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void IPJENEAMGBP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void PNLAIDLOIDE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
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

	private void DHNANELONED()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void EPCGHAAONLN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void GOBHPAJFFDB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void GGPOCCFNMDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
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
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void Awake()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void FBBMPGICGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void EIFCCFBJKOO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void FNMPIAMIKCP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void OKADMJFLMGP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void GGEKDHHOOCH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void AAAGGIHAKEH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void CEKLAECJCKG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void MMPOJCFOGJJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void GEGFJJBCHPE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void CNDGDDLEFJF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void NLCNKMOLPNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void AJIKPEIGACI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	private void MFAMHKBMBEI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}

	public void OFFPGECPIMN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LPFEBLNEEOF.velocity);
			}
			if (m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
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

	private void FAAJAMIGJNK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody2D>();
	}
}
