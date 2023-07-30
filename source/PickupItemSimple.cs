// PickupItemSimple
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class PickupItemSimple : Photon.MonoBehaviour
{
	public float SecondsBeforeRespawn = 2f;

	public bool PickupOnCollide;

	public bool SentPickup;

	public void HKDMLCPEGNH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void DBFNHNNANML()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void JCKLEENLKAF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server." + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GLOHDPKDFEL();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1430f)
		{
			base.gameObject.SetActive(true);
			Invoke(".", num2);
		}
	}

	public void FMDELCJMOIE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Keypad" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PEIJAJACPJA();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1810f)
		{
			base.gameObject.SetActive(false);
			Invoke("_Value4", num2);
		}
	}

	public void KHABHFJDHBD(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			CNDGCMNOCAI();
		}
	}

	public void NKKGFHPEHPN(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_TimeX" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LMOKJNDOFMH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 419f)
		{
			base.gameObject.SetActive(true);
			Invoke("inventory.selected.", num2);
		}
	}

	public void NJOLEFIKLPL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			NFMFALFHMMH();
		}
	}

	public void IMFJAHEFDLN(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("CameraFilterPack/Light_Rainbow2" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1730f)
		{
			base.gameObject.SetActive(true);
			Invoke(".g", num2);
		}
	}

	public void GOKCDLOELKD()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void JOFOFJNDNLN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			AAJKHJGLNLO();
		}
	}

	[PunRPC]
	public void PunPickupSimple(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Ignored PU RPC, cause item is inactive. " + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 0f)
		{
			base.gameObject.SetActive(false);
			Invoke("RespawnAfter", num2);
		}
	}

	public void HAHJFAPKPMG()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void JANFCBPHGJA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("CameraFilterPack/Glitch_Mozaic" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 769f)
		{
			base.gameObject.SetActive(true);
			Invoke(".b", num2);
		}
	}

	public void IMBHFDJHNAK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Value3" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.NCCGEFNHKGP();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 154f)
		{
			base.gameObject.SetActive(true);
			Invoke("FinishMap", num2);
		}
	}

	public void MHPGIEELJIM()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			NABDKNPNEMM().RPC("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", (PhotonTargets)7);
		}
	}

	public void EGMJECGOFKO(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			CNDGCMNOCAI();
		}
	}

	public void NBBLCJKLAHH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_ScreenResolution" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 616f)
		{
			base.gameObject.SetActive(false);
			Invoke("SpawnObj", num2);
		}
	}

	public void AAJKHJGLNLO()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			FFIPLLNKGEN().RPC("_ScreenResolution", PhotonTargets.AllBuffered);
		}
	}

	public void FHKOFEFFPJB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("SetSunColors" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HPJGEPFOBFH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 670f)
		{
			base.gameObject.SetActive(true);
			Invoke("_Far", num2);
		}
	}

	public void KHOGKNEBBOI()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void KILHCBLJMFC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void MJKGDMJHDIN()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void JDOMNBNJLLF()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void JKJKPDFPJAE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("[LevelEditorScene] Error: You're not logged into Steam!" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1382f)
		{
			base.gameObject.SetActive(false);
			Invoke("settings.fps", num2);
		}
	}

	public void DHPDCHHMJNL()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			IBKCMBIGOEJ().RPC("_DiffuseColor", PhotonTargets.AllBuffered);
		}
	}

	public void LLEJLALFCPH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void LKKOKEBPMPC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void OnTriggerEnter(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			Pickup();
		}
	}

	public void NGPIGBJGKBF()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void OCEHOBNBDJF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("LeaderboardsButton" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1576f)
		{
			base.gameObject.SetActive(true);
			Invoke("BitsData", num2);
		}
	}

	public void FKFMAMBMGKF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("LivesSlider" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1973f)
		{
			base.gameObject.SetActive(false);
			Invoke("Map id for", num2);
		}
	}

	public void JGIGJDGJBEE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("[ItemsHandler] Inventory has changed" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GLOHDPKDFEL();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1446f)
		{
			base.gameObject.SetActive(true);
			Invoke("[Down]", num2);
		}
	}

	public void NIHDAODOKDK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("DifficultyBG" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 142f)
		{
			base.gameObject.SetActive(true);
			Invoke("Editor/", num2);
		}
	}

	public void ILCDCJCHOEP()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void PCHAENACONO()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void GDBHANMKCFA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			GLBMAGNIFDC();
		}
	}

	public void LEMBMJCAAKF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log(" = " + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GLOHDPKDFEL();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1179f)
		{
			base.gameObject.SetActive(false);
			Invoke("ItemNameText", num2);
		}
	}

	public void APOHOCPBGEB(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			GBNLCIMEHGA();
		}
	}

	public void NHEELJPDCMB(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			DHPDCHHMJNL();
		}
	}

	public void NNAJCNEPGNF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Clears the console and prints the logs in the specified range" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HPJGEPFOBFH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 224f)
		{
			base.gameObject.SetActive(true);
			Invoke("AvatarImage", num2);
		}
	}

	public void HMOLMNEJEHK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void DPLCKHCDLDM(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			LKFHBGMJLCF();
		}
	}

	public void KLJHODOACJL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			IJJJIPFGKCK();
		}
	}

	public void GGMHFHPCBGA()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			IFENGKHOKPC().RPC("achievements.26.progress", PhotonTargets.Others);
		}
	}

	public void HKIDGHLHILD(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			DDEHFGHPHOG();
		}
	}

	public void ECBAINLOAMA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			Pickup();
		}
	}

	public void KFOHAOLFIJD(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Editor/" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 203f)
		{
			base.gameObject.SetActive(false);
			Invoke("powerup.1", num2);
		}
	}

	public void GBNLCIMEHGA()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			OELHGNKAMEG().RPC("setstring", PhotonTargets.Others, new object[1]);
		}
	}

	public void MAEIKHBEGAP()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void LIAJOODKKBN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			CNDGCMNOCAI();
		}
	}

	public void LPDJMAOOFMB(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			NFMFALFHMMH();
		}
	}

	public void EIKHFGPJGHP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Bullet_4" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LMOKJNDOFMH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1984f)
		{
			base.gameObject.SetActive(true);
			Invoke("[LevelEditorScene] Error: You're not logged into Steam!", num2);
		}
	}

	public void NNKAJBFAPOM(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("settings.enablehitsoundsinnormal" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 61f)
		{
			base.gameObject.SetActive(true);
			Invoke("powerup.0", num2);
		}
	}

	public void ECJIJKGNOCL()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void GFOJNJOIIGC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void PIKPPDGBIMO()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void HECLGMPEBBI(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			GLBMAGNIFDC();
		}
	}

	public void MBIBMGDHAOF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Particles/Additive" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 197f)
		{
			base.gameObject.SetActive(true);
			Invoke("offsets", num2);
		}
	}

	public void DKGOBMMGLAE(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			NFMFALFHMMH();
		}
	}

	public void EKDEEPCOMGG()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void NLLKIOMOJAI(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("downloading" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PEIJAJACPJA();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 614f)
		{
			base.gameObject.SetActive(true);
			Invoke("_ScreenResolution", num2);
		}
	}

	public void GMIBFLFFEOM(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Stream did not contain properly formatted byte array" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GLOHDPKDFEL();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1639f)
		{
			base.gameObject.SetActive(false);
			Invoke("CameraFilterPack/Blend2Camera_Darken", num2);
		}
	}

	public void PODEGIOGJBK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void LENGHMGDJMK(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			KONGOAOIBMK();
		}
	}

	public void KEKNCBOELMB(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			DHPDCHHMJNL();
		}
	}

	public void MDCGLAGAMFH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void BNLFAIFCGFM(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			MHPGIEELJIM();
		}
	}

	public void EJBMIIEIKGP(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			AHJGIFKOFJB();
		}
	}

	public void EONIBDGGCDK(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			KONGOAOIBMK();
		}
	}

	public void FCEIPFIDOIH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void RespawnAfter()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void CLADFLFGHCE()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void KBAEHDBACEF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Horizontal" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 904f)
		{
			base.gameObject.SetActive(true);
			Invoke("\" error: ", num2);
		}
	}

	public void EMCPFLDIJDB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("#no" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PEIJAJACPJA();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 859f)
		{
			base.gameObject.SetActive(false);
			Invoke("_SearchTex", num2);
		}
	}

	public void JOLNEGLLODD(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			FGGBDHPDDIA();
		}
	}

	public void BAPCLMHABJH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Glitch" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.DEDMDLGOBBG();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 168f)
		{
			base.gameObject.SetActive(true);
			Invoke("challenges.", num2);
		}
	}

	public void ONNBGFOAHGA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			IJJJIPFGKCK();
		}
	}

	public void AHJGIFKOFJB()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			JDBCGCJJIAF().RPC("_Value", (PhotonTargets)7, new object[1]);
		}
	}

	public void PBJIFKEHMFB(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			DDEHFGHPHOG();
		}
	}

	public void AACFPHMDIEH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			AHJGIFKOFJB();
		}
	}

	public void NFMFALFHMMH()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			ACPGHFHDCIP().RPC("_Value2", PhotonTargets.AllBuffered);
		}
	}

	public void IDLDKAELLNN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			CNDGCMNOCAI();
		}
	}

	public void CNDGCMNOCAI()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JDBCGCJJIAF().RPC(" but this PhotonView does not exist! Was remote PV.", PhotonTargets.All);
		}
	}

	public void HHCAGPCFOAE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("CameraFilterPack/Noise_TV_3" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1162f)
		{
			base.gameObject.SetActive(true);
			Invoke("/", num2);
		}
	}

	public void LKFHBGMJLCF()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			PHCBHAFMDEJ().RPC("_Value5", (PhotonTargets)8);
		}
	}

	public void Pickup()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			base.photonView.RPC("PunPickupSimple", PhotonTargets.AllViaServer);
		}
	}

	public void NNEPGDNHNGJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_PColor" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 382f)
		{
			base.gameObject.SetActive(true);
			Invoke("[NetworkManager] Connected to ", num2);
		}
	}

	public void MGELKDOBMFH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void AFLEMPFGNGH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			Pickup();
		}
	}

	public void FGGBDHPDDIA()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			FFIPLLNKGEN().RPC("settings.shaders", PhotonTargets.OthersBuffered, new object[1]);
		}
	}

	public void GLBMAGNIFDC()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JAEJDHHCJJO().RPC("CameraFilterPack/FX_ZebraColor", PhotonTargets.OthersBuffered);
		}
	}

	public void FDHFMFNONDK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void IKJJLPLFOKC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void DDEHFGHPHOG()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			AAMNKPHHHCI().RPC("Editor", PhotonTargets.AllBuffered);
		}
	}

	public void FOBBEEOLOLN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			KONGOAOIBMK();
		}
	}

	public void BNKLDCOOMHD(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			DHPDCHHMJNL();
		}
	}

	public void IJJJIPFGKCK()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			NABDKNPNEMM().RPC("[RanksSystem] Ranks: no need to update", PhotonTargets.AllBufferedViaServer, new object[1]);
		}
	}

	public void PKGCONFMNHJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("CameraFilterPack/Vision_Rainbow" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 708f)
		{
			base.gameObject.SetActive(false);
			Invoke("Mouse Y", num2);
		}
	}

	public void OPILEEGBKDE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Scene" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 954f)
		{
			base.gameObject.SetActive(false);
			Invoke("_FixDistance", num2);
		}
	}

	public void CKGEGBCDMMH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			GBNLCIMEHGA();
		}
	}

	public void FLKILBNAJFO(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Default UI Material" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.NCCGEFNHKGP();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1025f)
		{
			base.gameObject.SetActive(true);
			Invoke("/", num2);
		}
	}

	public void MFKHNCCEMKM()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void HIIBBACGGDM()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JIOCGDBKGIL().RPC("PLEASE WAIT", PhotonTargets.MasterClient);
		}
	}

	public void MEFCEBCEKNL(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Value" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.DEDMDLGOBBG();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1880f)
		{
			base.gameObject.SetActive(false);
			Invoke("Joystick1Button1", num2);
		}
	}

	public void OMIGHBLLGPE()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void CJBFAPFHAMK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log(".lastCheckpoint.perfectHits" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PEIJAJACPJA();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1873f)
		{
			base.gameObject.SetActive(false);
			Invoke("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", num2);
		}
	}

	public void LOPKINFOENO(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("RateButton" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LMOKJNDOFMH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 997f)
		{
			base.gameObject.SetActive(true);
			Invoke("Set satellite audio input", num2);
		}
	}

	public void KONGOAOIBMK()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JIOCGDBKGIL().RPC("_Value3", PhotonTargets.AllBufferedViaServer, new object[1]);
		}
	}

	public void JALPDPGCACE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_TimeX" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 242f)
		{
			base.gameObject.SetActive(false);
			Invoke("[LevelEditorScene] Updated", num2);
		}
	}

	public void HMIHBAJANKG(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			IJJJIPFGKCK();
		}
	}

	public void NOCKLMHDMFN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			AHJGIFKOFJB();
		}
	}

	public void JJMJBEKHENB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("#exitmapeditor" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HPJGEPFOBFH();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 319f)
		{
			base.gameObject.SetActive(true);
			Invoke("ShowSprite", num2);
		}
	}
}
