// SmoothSyncMovement
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class SmoothSyncMovement : Photon.MonoBehaviour, IPunObservable
{
	public float SmoothingDelay = 5f;

	private Vector3 OKGJMEKOLIM = Vector3.zero;

	private Quaternion ANHDBFEBADJ = Quaternion.identity;

	public void EMANBHKAONB()
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
			Debug.LogWarning(string.Concat(this, "21x3"));
		}
	}

	public void DLFLONFGGGG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.NICKMDDINKP(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	public void MFAMHKBMBEI()
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
			Debug.LogWarning(string.Concat(this, "FinishMap"));
		}
	}

	public void HPGOHBHACKF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.position);
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void KLFPENLPMJP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.NICKMDDINKP(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
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

	public void MDCFIHDPLIG()
	{
		if (!BBGIDKNEGHD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void CEKLAECJCKG()
	{
		bool flag = false;
		foreach (Component observedComponent in NABDKNPNEMM().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_TimeX"));
		}
	}

	public void CCDNJPNLGBN()
	{
		bool flag = false;
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
			Debug.LogWarning(string.Concat(this, "{0}"));
		}
	}

	public void OEENOOGEEHD()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void GBNDJBNLKLI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	public void IFHKKPEFEOM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void JPJNECPABBG()
	{
		bool flag = true;
		foreach (Component observedComponent in GBMJAPGLMGB().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_ScreenResolution"));
		}
	}

	public void AEEGKLABFLN()
	{
		if (!NABDKNPNEMM().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void NFEDLAOPHML()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void IBHACCEEFFI()
	{
		if (!NABDKNPNEMM().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DCKLCCMEGAA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	public void CJKDMGMPMJM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void FAAJAMIGJNK()
	{
		bool flag = true;
		foreach (Component observedComponent in GMAHNPNHMFK().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Committing changes..."));
		}
	}

	public void OBPCMAFGLON()
	{
		bool flag = false;
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
			Debug.LogWarning(string.Concat(this, "Backward"));
		}
	}

	public void GMIOCKFLJAK()
	{
		bool flag = true;
		foreach (Component observedComponent in GMAHNPNHMFK().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Value11"));
		}
	}

	public void GCHBGCGBMCK()
	{
		if (!JDBCGCJJIAF().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void BFIOIDMHPPL()
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
			Debug.LogWarning(string.Concat(this, "UI"));
		}
	}

	public void DAFGPDBLAMA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	public void FABMDEHEDNO()
	{
		if (!IFENGKHOKPC().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void IKIDIJLIGOH()
	{
		if (!IJBFILBDGDO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
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

	public void MDGEJFNOJCF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void JOACBIEHHCE()
	{
		if (!JIOCGDBKGIL().isMine)
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

	public void JIJPHEDDIHC()
	{
		bool flag = false;
		foreach (Component observedComponent in AAMNKPHHHCI().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "LevelInfoInputField"));
		}
	}

	public void IDIIELPAMCJ()
	{
		if (!BBGIDKNEGHD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DMIKIDGJEFC()
	{
		bool flag = false;
		foreach (Component observedComponent in BBGIDKNEGHD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "[Right]"));
		}
	}

	public void HOGEJPIBJAL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.NICKMDDINKP(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void JAAJECBCCFM()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void KEKNHAAEPCJ()
	{
		bool flag = true;
		foreach (Component observedComponent in PHCBHAFMDEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_FarCamera"));
		}
	}

	public void OJACCGOHBGH()
	{
		bool flag = true;
		foreach (Component observedComponent in JAEJDHHCJJO().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Visualize"));
		}
	}

	public void MBIPCKMIBFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.position);
			HCIJEDFCNOP.NICKMDDINKP(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void EGEGNHLODAA()
	{
		if (!JIOCGDBKGIL().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void PPCGJBIIFAO()
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
			Debug.LogWarning(string.Concat(this, "_ScreenResolution"));
		}
	}

	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void FMAFBLKAJDF()
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
			Debug.LogWarning(string.Concat(this, "/icon"));
		}
	}

	public void LLJLDLLNFBH()
	{
		if (!PHCBHAFMDEJ().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DEJEBOGKMJO()
	{
		bool flag = true;
		foreach (Component observedComponent in IJBFILBDGDO().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "Bad parameters for setint! Use <key> <value>"));
		}
	}

	public void EJFJENFKLND()
	{
		if (!DJHCJIJAIJP().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void ONMGIPAILOH()
	{
		if (!JIOCGDBKGIL().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void LMADKINICIN()
	{
		if (!BBGIDKNEGHD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void BGFCMMDKCOI()
	{
		bool flag = false;
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
			Debug.LogWarning(string.Concat(this, "_DotSize"));
		}
	}

	public void EHCGBJDFMHG()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void NLNAJMCBNDC()
	{
		bool flag = false;
		foreach (Component observedComponent in IFENGKHOKPC().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "LoadPlayerSkin"));
		}
	}

	public void GMELGGJOPBB()
	{
		if (!OELHGNKAMEG().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void BODPLDJLFCF()
	{
		bool flag = true;
		foreach (Component observedComponent in NABDKNPNEMM().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_Value3"));
		}
	}

	public void GDHMJGBAGHP()
	{
		bool flag = false;
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
			Debug.LogWarning(string.Concat(this, "_VelocityScale"));
		}
	}

	public void EPCAPPLPFED()
	{
		bool flag = false;
		foreach (Component observedComponent in DJHCJIJAIJP().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, ".lastCheckpoint.comboScore"));
		}
	}

	public void KFACDBHDAOD()
	{
		if (!IFENGKHOKPC().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void BFFHPJMMGHD()
	{
		bool flag = true;
		foreach (Component observedComponent in NABDKNPNEMM().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "#,0"));
		}
	}

	public void GHILDCBCDJI()
	{
		if (!EOOCGIFFKBG().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void CNDGDDLEFJF()
	{
		bool flag = false;
		foreach (Component observedComponent in IJBFILBDGDO().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "CameraFilterPack/Blizzard"));
		}
	}

	public void CFIAKIJAILI()
	{
		if (!IBKCMBIGOEJ().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void HODGFKONIFC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void LMOILMNEOFE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.position);
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void LMBDNPLDGIJ()
	{
		if (!JDBCGCJJIAF().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MJNPIDGNJMK()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void IOIECPHCEHD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.GJDCOKMGHOG(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
		}
	}

	public void KGMCGGIEPDE()
	{
		bool flag = false;
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
			Debug.LogWarning(string.Concat(this, "SetSunSensitivity"));
		}
	}

	public void JDGFCEPDKAJ()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void OPFDGBDADMA()
	{
		bool flag = true;
		foreach (Component observedComponent in NABDKNPNEMM().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "/"));
		}
	}

	public void IIFCIDDJHPM()
	{
		if (!PHCBHAFMDEJ().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void DDBOODLPCAM()
	{
		if (!GBMJAPGLMGB().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
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

	public void LCHBFNIPBHB()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void MPGJDLCANPA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA())
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.position);
			HCIJEDFCNOP.AIAIEPFCCDO(base.transform.rotation);
		}
		else
		{
			OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
		}
	}

	public void GLGOLEOAFOD()
	{
		bool flag = false;
		foreach (Component observedComponent in NABDKNPNEMM().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "ItemNameText"));
		}
	}

	public void BMAGFLLGDPJ()
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
			Debug.LogWarning(string.Concat(this, "Drop_Near"));
		}
	}

	public void IICACFLHBCP()
	{
		bool flag = true;
		foreach (Component observedComponent in EDIJKHEMPAD().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "CameraFilterPack/Colors_Adjust_FullColors"));
		}
	}

	public void IKKPINNOOLG()
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
			Debug.LogWarning(string.Concat(this, "Submit"));
		}
	}

	public void LJEFMGOBKGE()
	{
		bool flag = true;
		foreach (Component observedComponent in PHCBHAFMDEJ().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "_ScreenResolution"));
		}
	}

	public void POJFHDFJOPE()
	{
		if (!CIACEFBNDDJ().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, OKGJMEKOLIM, Time.deltaTime * SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ANHDBFEBADJ, Time.deltaTime * SmoothingDelay);
		}
	}

	public void GEPELODHBFN()
	{
		bool flag = false;
		foreach (Component observedComponent in JIOCGDBKGIL().ObservedComponents)
		{
			if (observedComponent == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(string.Concat(this, "CameraFilterPack/FX_Hexagon_Black"));
		}
	}

	public void MADENBGHKDD()
	{
		bool flag = true;
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
			Debug.LogWarning(string.Concat(this, "_PColor"));
		}
	}
}
