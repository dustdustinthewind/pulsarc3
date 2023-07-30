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

	public void AKPCPGPOKKG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void BFIOIDMHPPL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void NEEIFNDHDOG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void FMAFBLKAJDF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void DDMBAGEFNLB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void OLFNCABJBHA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void PPCGJBIIFAO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void BGFCMMDKCOI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

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
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void CCDNJPNLGBN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void IPJENEAMGBP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
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
				HCIJEDFCNOP.SendNext(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void HCNECNPPEKA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void LMOILMNEOFE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
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

	private void GEGFJJBCHPE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void JEEINPBLBDI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void JBFGBECPBDO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void MKPBBAPGGND(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void OJACCGOHBGH()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void LNDBBLLLFDA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void NLNAJMCBNDC()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void LJEFMGOBKGE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void FIABIKEIEKH()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void HHJBBHEBJCJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void JPJNECPABBG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void OBPCMAFGLON()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void KPOIJEKDFBE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void DMIKIDGJEFC()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void GEJCKOBIHFF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void AJIKPEIGACI()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void GMIOCKFLJAK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void HODGFKONIFC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void JHPKLGGMCBL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void EOBMGCKFNNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			if (m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.NICKMDDINKP(LPFEBLNEEOF.velocity);
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void GDHMJGBAGHP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void MMPPGDECEHO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void LEPNLHBAHOL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void ICPOCNHAAEK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void JNIPABEGJND()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void Awake()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void GGKPLCJNEHF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void LHMDCEDONEE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void MDOBONJMBKF()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
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
				HCIJEDFCNOP.GJDCOKMGHOG(LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (m_SynchronizeVelocity)
			{
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void FMLEIJEFMDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void LFHKGIHNONL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void PIIMBOLGHOE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void FAAJAMIGJNK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void JOBBGDGHJMB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void GDFJJBDODPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void IIPMEPPIFCK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void EIFCCFBJKOO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void CIAHIJIOFIE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void EOFAACNPFDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void BAEICBGEECA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void DAHIMKKFNPH()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void DEJEBOGKMJO()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void GGPOCCFNMDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void MADENBGHKDD()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void GEPELODHBFN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void EPCAPPLPFED()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void EMANBHKAONB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void PEMPABLNJHL()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void LOMHIIKFFEP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void PCFHKFCIFHF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void EJPAMJBIAGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void EBPAOCJEJGE()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void DAFGPDBLAMA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	public void IOIECPHCEHD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void BEPJPKCOLJH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public void JJLDJBFHCGF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void KEKNHAAEPCJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void CNMIIGDELGE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	private void EPCGHAAONLN()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	public void FOHGOGIMPJJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void MCIEAOAMOIG()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void DNFNPFAJGMG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	private void OKADMJFLMGP()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void GGHEPDCEHCK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void IOMCHHBGJEC()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	private void KACPCCMPAHA()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void JNBMKLFJCEM()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void CJHMHIMKILB()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	public void EJPKMLLGMGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void HOGEJPIBJAL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (m_SynchronizeAngularVelocity)
			{
				LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	private void HBPLJMJAAHK()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}

	private void BMAGFLLGDPJ()
	{
		LPFEBLNEEOF = GetComponent<Rigidbody>();
	}
}
