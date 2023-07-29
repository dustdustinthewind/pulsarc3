// PickupItem
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class PickupItem : Photon.MonoBehaviour, IPunObservable
{
	public float SecondsBeforeRespawn = 2f;

	public bool PickupOnTrigger;

	public bool PickupIsMine;

	public UnityEngine.MonoBehaviour OnPickedUpCall;

	public bool SentPickup;

	public double TimeOfRespawn;

	public static HashSet<PickupItem> DisabledPickupItems = new HashSet<PickupItem>();

	public int ViewID => base.photonView.viewID;

	public void ODEGIMJHPGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 1681f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		base.gameObject.transform.position = position;
	}

	[PunRPC]
	public void PunPickup(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			Debug.Log(string.Concat("Ignored PU RPC, cause item is inactive. ", base.gameObject, " SecondsBeforeRespawn: ", SecondsBeforeRespawn, " TimeOfRespawn: ", TimeOfRespawn, " respawn in future: ", TimeOfRespawn > PhotonNetwork.time));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("OnPickedUp", this);
		}
		if (SecondsBeforeRespawn <= 0f)
		{
			KNABLPOBADA(0f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 0.0)
		{
			KNABLPOBADA((float)num2);
		}
	}

	public void KFBAOGODIMM()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GBHNDHLAJLI().MIAHMDGOOPJ(" cannot be used as a 3D LUT.", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	internal void PPNPJENOMGA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 456.0;
		if (DPMFFBEDNNN > 380f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke(" | ", DPMFFBEDNNN);
		}
	}

	[SpecialName]
	public int OKNPEBGCPEA()
	{
		return JAEJDHHCJJO().EIMHMIJGMHG();
	}

	internal void JKLFFEGJCKH()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1660.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void DCMIJEPGKGP()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			AAMNKPHHHCI().KEKKFNNMLMG("speed", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	public void OMMNCHIMHBJ(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			GBHNDHLAJLI().IKIJDNPJKPM("#", PhotonTargets.Others, new object[1] { ENENGMDFKHK });
		}
	}

	internal void KNABLPOBADA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 0.0;
		if (DPMFFBEDNNN > 0f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("PunRespawn", DPMFFBEDNNN);
		}
	}

	[SpecialName]
	public int DMEACFJNMML()
	{
		return GBMJAPGLMGB().NPPEFODKHKN();
	}

	public void MOJMJPJHGBO()
	{
		if (PickupIsMine)
		{
			JAEJDHHCJJO().KEKKFNNMLMG("CameraFilterPack/TV_Chromatical2", PhotonTargets.AllBufferedViaServer, new object[0]);
		}
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 0f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.ReceiveNext();
		base.gameObject.transform.position = position;
	}

	public void NIOAANAHIIO()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			base.photonView.IKIJDNPJKPM("_ReflectionTexture3", PhotonTargets.All, new object[0]);
		}
	}

	internal void AMHOLGKGGBD(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("settings.arcsnohitsoundtimedelay");
		FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void MOLJFGIOENO()
	{
		if (PickupIsMine)
		{
			base.photonView.KEKKFNNMLMG("ViewMenu", PhotonTargets.All, new object[0]);
		}
	}

	internal void HHIKGCOAPDO()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1760.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	internal void JIMAKAHKAOB(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_ScreenResolution");
		FCEDJDBOOGD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void BOCMAJBBLOM(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = IBKCMBIGOEJ();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.MIAHMDGOOPJ("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", PhotonTargets.Others, array);
		}
	}

	public void GGMHFHPCBGA()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			EDIJKHEMPAD().MIAHMDGOOPJ("\t", PhotonTargets.All, new object[1]);
		}
	}

	public void ENOMMKAFBPN(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = GBMJAPGLMGB();
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			obj.KEKKFNNMLMG("MusicFileSelector", (PhotonTargets)8, array);
		}
	}

	public void JGACDFLHGKF()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			OELHGNKAMEG().KEKKFNNMLMG("Tab2Content", PhotonTargets.OthersBuffered, new object[0]);
		}
	}

	[SpecialName]
	public int EIKELGOOEAN()
	{
		return GBHNDHLAJLI().EIMHMIJGMHG();
	}

	internal void LLIDOADHPJD(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("MapFolderInputField");
		DGGFBMKKJFO();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void IALOOABLMLF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.KCAOJFPDEIP())
		{
			OCPHFBJHNMM();
		}
	}

	public void OAKNHHEJGKJ(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = EDIJKHEMPAD();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.RPC("...", PhotonTargets.MasterClient, array);
		}
	}

	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1574f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		base.gameObject.transform.position = position;
	}

	[SpecialName]
	public int DHBFALLCHCG()
	{
		return GBMJAPGLMGB().NPPEFODKHKN();
	}

	public void IGCDPNAHFFK(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = IBKCMBIGOEJ();
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			obj.KEKKFNNMLMG("CameraFilterPack/Blend2Camera_Color", (PhotonTargets)8, array);
		}
	}

	public void DMNNBOKGIJO(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = BLMHOKPIMOD();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.MIAHMDGOOPJ("_OcclusionTexture", PhotonTargets.All, array);
		}
	}

	[SpecialName]
	public int PKLGNLOHIHG()
	{
		return GMAHNPNHMFK().NPPEFODKHKN();
	}

	public void DIBKBFLCPHB()
	{
		if (PickupIsMine)
		{
			OELHGNKAMEG().MIAHMDGOOPJ("table", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	public void GGEKDHHOOCH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && SecondsBeforeRespawn <= 150f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		base.gameObject.transform.position = position;
	}

	public void ECHLAMLLABB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 983f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void AHPEFIMKILH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[0] = "open";
			array[1] = base.gameObject;
			array[0] = "_ScreenResolution";
			array[1] = SecondsBeforeRespawn;
			array[0] = "settings.volume.menu";
			array[1] = TimeOfRespawn;
			array[5] = "_Intervale";
			array[0] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("Drop_With_Obj", this);
		}
		if (SecondsBeforeRespawn <= 1248f)
		{
			GMMLFEEGIGI(595f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.INALDKDNCCN();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 616.0)
		{
			JJEJCCPCNOP((float)num2);
		}
	}

	internal void PFEEGCOBHAM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_ScreenResolution");
		DEGJEDLKKJK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void FABHBEHMJEJ()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 347.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void AKPCPGPOKKG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1758f)
		{
			HCIJEDFCNOP.PBECMJMDHBI(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		base.gameObject.transform.position = position;
	}

	public void HNAIGBNLACC(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[0] = "SetSunSensitivity";
			array[0] = base.gameObject;
			array[7] = "EventSystem";
			array[6] = SecondsBeforeRespawn;
			array[3] = "BitsData";
			array[8] = TimeOfRespawn;
			array[5] = "_EmissionGain";
			array[8] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_Value2", this);
		}
		if (SecondsBeforeRespawn <= 201f)
		{
			PIMDACECPMA(214f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.AMGFGPMEMCG();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1257.0)
		{
			PIMDACECPMA((float)num2);
		}
	}

	public void PPFNLJKLIIM(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = IBKCMBIGOEJ();
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			obj.PBMFBOOALKA("_TimeX", PhotonTargets.MasterClient, array);
		}
	}

	public void KFNACDLDBIP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[0] = "SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ";
			array[1] = base.gameObject;
			array[1] = "menu.selectedplaymode";
			array[5] = SecondsBeforeRespawn;
			array[5] = "Joystick";
			array[1] = TimeOfRespawn;
			array[5] = "_Value2";
			array[8] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("L2", this);
		}
		if (SecondsBeforeRespawn <= 1030f)
		{
			IDIJNCBLDBH(1552f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FKNAEDNOBGP();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1755.0)
		{
			OPHALGOIDOI((float)num2);
		}
	}

	internal void GMMLFEEGIGI(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 755.0;
		if (DPMFFBEDNNN > 921f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("[DiscordController] Join ({0})", DPMFFBEDNNN);
		}
	}

	public void OJFBDENEMMN()
	{
		if (PickupIsMine)
		{
			JAEJDHHCJJO().MIAHMDGOOPJ("_Value4", PhotonTargets.MasterClient, new object[1]);
		}
	}

	public void DOIKKHAJLEB()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			base.photonView.PBMFBOOALKA("Tab2Content", PhotonTargets.AllBuffered, new object[0]);
		}
	}

	public void BIDJKHEHBHN(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = EOOCGIFFKBG();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.KEKKFNNMLMG("/", PhotonTargets.OthersBuffered, array);
		}
	}

	public void Pickup()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			base.photonView.RPC("PunPickup", PhotonTargets.AllViaServer);
		}
	}

	internal void OLCDEGJDIBB(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 723.0;
		if (DPMFFBEDNNN > 177f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("_Distortion", DPMFFBEDNNN);
		}
	}

	internal void OPHALGOIDOI(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1031.0;
		if (DPMFFBEDNNN > 319f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("CameraFilterPack_Glasses_On6", DPMFFBEDNNN);
		}
	}

	public void AHIJEHHLCGN()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			base.photonView.KEKKFNNMLMG("_TimeX", PhotonTargets.OthersBuffered, new object[0]);
		}
	}

	[SpecialName]
	public int BIDKPFPPLDP()
	{
		return BLMHOKPIMOD().KINIHBOKFJH();
	}

	public void Drop()
	{
		if (PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer);
		}
	}

	public void GHKMNMLNOLM()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GBMJAPGLMGB().PBMFBOOALKA("Horizontal", PhotonTargets.MasterClient, new object[0]);
		}
	}

	internal void BGGFOKGOALL()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1834.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void CKBNBEPJOEE(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 960.0;
		if (DPMFFBEDNNN > 1958f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("/Segment-[Up]", DPMFFBEDNNN);
		}
	}

	internal void AMHAGFFHLMI(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_LightIntensity");
		BGGFOKGOALL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void FCEDJDBOOGD()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 521.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void JMJOAIDFIIG()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			EDIJKHEMPAD().RPC("z", PhotonTargets.Others, new object[1]);
		}
	}

	internal void APAPAJBEAII(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1994.0;
		if (DPMFFBEDNNN > 877f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("VisionBlur", DPMFFBEDNNN);
		}
	}

	internal void DGIAHICNPJG(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("LeaderboardsButton");
		OHPFGOOJJKD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void ELHLCLALKJF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.DOLKFPIABDD())
		{
			GGMHFHPCBGA();
		}
	}

	internal void KEMJCJGNPBA(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("ItemsUploader");
		JHBEIDMONOI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void MFDANMNLGMK()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 181.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void PODMNNAFPCC()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			AAMNKPHHHCI().MIAHMDGOOPJ("Spawn ark to be pressed at this time", PhotonTargets.AllBufferedViaServer, new object[0]);
		}
	}

	public void EMKIGFCHGPJ()
	{
		if (PickupIsMine)
		{
			BLMHOKPIMOD().RPC("_TimeX", PhotonTargets.OthersBuffered);
		}
	}

	public void PFGNDEDCOEB(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = AAMNKPHHHCI();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.IKIJDNPJKPM("&page=", (PhotonTargets)8, array);
		}
	}

	[SpecialName]
	public int FKFHMBGPFHF()
	{
		return IBKCMBIGOEJ().viewID;
	}

	internal void OMIAIKLABKM()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1979.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void DGGFBMKKJFO()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 461.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void OKGCHKJODHF()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			CIACEFBNDDJ().PBMFBOOALKA("Bad parameters for setbool! Use <key> <value>", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	[SpecialName]
	public int FEOKOFDBLGL()
	{
		return BLMHOKPIMOD().viewID;
	}

	public void EBDKPAOGEGI(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = EOOCGIFFKBG();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.PBMFBOOALKA("_Value2", PhotonTargets.All, array);
		}
	}

	public void OnTriggerEnter(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			Pickup();
		}
	}

	public void JCABMIOMNPF(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = CIACEFBNDDJ();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.KEKKFNNMLMG("hand", PhotonTargets.All, array);
		}
	}

	[SpecialName]
	public int DNEBJBBNLDD()
	{
		return EDIJKHEMPAD().viewID;
	}

	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 698f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
		base.gameObject.transform.position = position;
	}

	public void FNIOFFCNCEG(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[6];
			array[0] = " on effect ";
			array[1] = base.gameObject;
			array[2] = "inventory.selected.";
			array[8] = SecondsBeforeRespawn;
			array[7] = "setbool";
			array[1] = TimeOfRespawn;
			array[3] = "_AccumulationTex";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_Value2", this);
		}
		if (SecondsBeforeRespawn <= 975f)
		{
			OAOIJGBDKAL(1398f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HBPFFECIHKL();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1107.0)
		{
			IDIJNCBLDBH((float)num2);
		}
	}

	public void MBIPCKMIBFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 873f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		base.gameObject.transform.position = position;
	}

	internal void KNAJGGKNLDK(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("The given 2D texture ");
		AMCALMOAOMP();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void ONAMLBMDHJC(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = OELHGNKAMEG();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.MIAHMDGOOPJ("failed", PhotonTargets.AllViaServer, array);
		}
	}

	public void LDDKKPNINLC(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[4];
			array[0] = "InventoryButton";
			array[1] = base.gameObject;
			array[4] = "image";
			array[7] = SecondsBeforeRespawn;
			array[1] = " not exist";
			array[0] = TimeOfRespawn;
			array[0] = "CameraFilterPack/Blur_Regular";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("RoomNameText", this);
		}
		if (SecondsBeforeRespawn <= 1196f)
		{
			OLCDEGJDIBB(1457f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GJDFJLLPCEC();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 518.0)
		{
			CKBNBEPJOEE((float)num2);
		}
	}

	public void PCMFEAOHBNO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 844f)
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void GEJCKOBIHFF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 668f)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		base.gameObject.transform.position = position;
	}

	internal void PIMDACECPMA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 906.0;
		if (DPMFFBEDNNN > 1341f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("fetch", DPMFFBEDNNN);
		}
	}

	internal void JHLABNLLMOI(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("#");
		MFDANMNLGMK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void NFCNNHIDOHJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[0];
			array[0] = "settings.arcsdestroydelay";
			array[1] = base.gameObject;
			array[6] = " not exist";
			array[6] = SecondsBeforeRespawn;
			array[1] = "Scene";
			array[3] = TimeOfRespawn;
			array[4] = "_Value4";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("CameraFilterPack_3D_Computer1", this);
		}
		if (SecondsBeforeRespawn <= 1f)
		{
			JJEJCCPCNOP(1015f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.MFAFNILAGDF();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 133.0)
		{
			OPHALGOIDOI((float)num2);
		}
	}

	public void Drop(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer, ENENGMDFKHK);
		}
	}

	public void ENLOGLEEBBP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "ViewID {0} {1}{2}";
			array[1] = base.gameObject;
			array[4] = "/";
			array[3] = SecondsBeforeRespawn;
			array[3] = "/Saved Games/";
			array[0] = TimeOfRespawn;
			array[5] = "GlassesColor";
			array[6] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("settings.enablehitsoundsinrelax", this);
		}
		if (SecondsBeforeRespawn <= 604f)
		{
			OPHALGOIDOI(257f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LKENLCMIPPL();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1565.0)
		{
			APAPAJBEAII((float)num2);
		}
	}

	public void BMCDOLNMNDN()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			GBHNDHLAJLI().RPC("No Name", (PhotonTargets)8);
		}
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && SecondsBeforeRespawn <= 1475f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
		base.gameObject.transform.position = position;
	}

	internal void PPLLHBOPGLA()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 654.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void ELFDFMKPNDP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[7];
			array[0] = "SpawnObj";
			array[0] = base.gameObject;
			array[0] = "MessageText";
			array[7] = SecondsBeforeRespawn;
			array[6] = " methods \"";
			array[5] = TimeOfRespawn;
			array[7] = "isVisible";
			array[3] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_BorderSize", this);
		}
		if (SecondsBeforeRespawn <= 893f)
		{
			GANGFBPADGO(285f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 792.0)
		{
			PIMDACECPMA((float)num2);
		}
	}

	[SpecialName]
	public int KHEHPCAFJBC()
	{
		return JAEJDHHCJJO().KINIHBOKFJH();
	}

	[PunRPC]
	internal void PunRespawn()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 0.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void IGACCOIJFGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && SecondsBeforeRespawn <= 1146f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		base.gameObject.transform.position = position;
	}

	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN() && SecondsBeforeRespawn <= 326f)
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		base.gameObject.transform.position = position;
	}

	public void MGLOIIDCIGF()
	{
		if (PickupIsMine)
		{
			GMAHNPNHMFK().GNFNHDCJOFC("history", (PhotonTargets)8, new object[0]);
		}
	}

	internal void BOACAPEAOPM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Fade");
		OMIAIKLABKM();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void LEMHJPBAPEG()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 711.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	internal void PGJJJJIPOIC()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1607.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void BKKOLPAFIMG(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = AAMNKPHHHCI();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.IKIJDNPJKPM("_TimeX", (PhotonTargets)8, array);
		}
	}

	public void OAGDLBBJIDO(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			Pickup();
		}
	}

	internal void ABHKELHLNAN()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 663.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void OIDHIONJPJJ(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			GMAHNPNHMFK().PBMFBOOALKA("_Value6", PhotonTargets.MasterClient, new object[1] { ENENGMDFKHK });
		}
	}

	internal void OAOIJGBDKAL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1242.0;
		if (DPMFFBEDNNN > 401f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke(" AuthMode ", DPMFFBEDNNN);
		}
	}

	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN() && SecondsBeforeRespawn <= 1833f)
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void LJLLLFOAJDB()
	{
		if (PickupIsMine)
		{
			EDIJKHEMPAD().IKIJDNPJKPM("settings.disablestoryboard", PhotonTargets.AllViaServer, new object[0]);
		}
	}

	public void FBFALABOJHF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			PODMNNAFPCC();
		}
	}

	public void HBBLLHAOBLE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && SecondsBeforeRespawn <= 1250f)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		base.gameObject.transform.position = position;
	}

	[SpecialName]
	public int EENIOALHGGL()
	{
		return GMAHNPNHMFK().KINIHBOKFJH();
	}

	internal void FDDMFDFLDOD()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1325.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void NMPLLMFCILA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "_Distortion";
			array[0] = base.gameObject;
			array[2] = "CameraFilterPack/Blend2Camera_Hue";
			array[2] = SecondsBeforeRespawn;
			array[5] = "_Value";
			array[6] = TimeOfRespawn;
			array[0] = "_Value4";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("sounds/hit_wrong", this);
		}
		if (SecondsBeforeRespawn <= 1488f)
		{
			OAOIJGBDKAL(1413f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.AMGFGPMEMCG();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 384.0)
		{
			PIMDACECPMA((float)num2);
		}
	}

	internal void PHLGBHBGCNC(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 595.0;
		if (DPMFFBEDNNN > 1690f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("offsets", DPMFFBEDNNN);
		}
	}

	internal void LLFOEKCLLGA()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 171.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void LENGHMGDJMK(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.DOLKFPIABDD())
		{
			GHKMNMLNOLM();
		}
	}

	internal void KPJPJAKNGKK()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 998.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void FGDHFOECMDH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[0] = ".status";
			array[0] = base.gameObject;
			array[5] = "settings.enablehitsoundsinrelax";
			array[8] = SecondsBeforeRespawn;
			array[2] = "_ToneCurve";
			array[2] = TimeOfRespawn;
			array[0] = " not exist";
			array[7] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_Value", this);
		}
		if (SecondsBeforeRespawn <= 1829f)
		{
			CKBNBEPJOEE(40f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.IDIKAMCFMKA();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1486.0)
		{
			APAPAJBEAII((float)num2);
		}
	}

	public void IMAMGDIKKKE(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			EOOCGIFFKBG().GNFNHDCJOFC("Turn", (PhotonTargets)7, new object[1] { ENENGMDFKHK });
		}
	}

	public void ADJPLCCJDLK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[0] = "\" that takes ";
			array[1] = base.gameObject;
			array[1] = "ServerSettings: ";
			array[6] = SecondsBeforeRespawn;
			array[2] = "MenuScene";
			array[5] = TimeOfRespawn;
			array[6] = "_Size";
			array[8] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("A", this);
		}
		if (SecondsBeforeRespawn <= 81f)
		{
			IDIJNCBLDBH(478f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.MBLGLJKHMGJ();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 105.0)
		{
			GMMLFEEGIGI((float)num2);
		}
	}

	public void AKAHFHCMGEJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "Unable to get a reward! Try again?";
			array[1] = base.gameObject;
			array[8] = "UI Extensions/UIAdditive";
			array[7] = SecondsBeforeRespawn;
			array[6] = "#close";
			array[1] = TimeOfRespawn;
			array[5] = "CameraFilterPack/Blend2Camera_Divide";
			array[3] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage(". ActorNr: ", this);
		}
		if (SecondsBeforeRespawn <= 874f)
		{
			EHNKFNNOLIK(766f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 890.0)
		{
			GMMLFEEGIGI((float)num2);
		}
	}

	[PunRPC]
	internal void PunRespawn(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("PunRespawn with Position.");
		PunRespawn();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void JJEJCCPCNOP(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1369.0;
		if (DPMFFBEDNNN > 170f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("set id", DPMFFBEDNNN);
		}
	}

	public void GFDCFGHODJB()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JAEJDHHCJJO().MIAHMDGOOPJ(":", PhotonTargets.OthersBuffered, new object[1]);
		}
	}

	[SpecialName]
	public int EALIJNCNNKC()
	{
		return GMAHNPNHMFK().EIMHMIJGMHG();
	}

	public void BFAMLJLHFJN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			OCPHFBJHNMM();
		}
	}

	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 293f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
		base.gameObject.transform.position = position;
	}

	internal void IKHMFPMBEMJ(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Error0");
		GOHOOCEHHHB();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void PIGEEBCJDEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 389f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
		base.gameObject.transform.position = position;
	}

	public void MFOMKJDLDAM(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = ACPGHFHDCIP();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.IKIJDNPJKPM("_MainTex2", PhotonTargets.All, array);
		}
	}

	internal void JHBEIDMONOI()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1102.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void OAMFGNKCDJE(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			PODMNNAFPCC();
		}
	}

	public void DCNNAEFJCNK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[1] = "CameraFilterPack/TV_BrokenGlass2";
			array[1] = base.gameObject;
			array[3] = "player.greenlollipop";
			array[5] = SecondsBeforeRespawn;
			array[3] = "true";
			array[5] = TimeOfRespawn;
			array[3] = "CameraFilterPack/Vision_Rainbow";
			array[6] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("Other", this);
		}
		if (SecondsBeforeRespawn <= 550f)
		{
			EHNKFNNOLIK(1611f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KCECPOJOIPC();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1872.0)
		{
			EHNKFNNOLIK((float)num2);
		}
	}

	public void KLFPBMHEBCL()
	{
		if (PickupIsMine)
		{
			FFIPLLNKGEN().MIAHMDGOOPJ("maps.", PhotonTargets.AllBufferedViaServer, new object[1]);
		}
	}

	public void OGPBENNLBCC()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GBMJAPGLMGB().MIAHMDGOOPJ("skin.hit_normal", (PhotonTargets)7, new object[1]);
		}
	}

	internal void DFJENGLLLBE(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("sfxVolume");
		MFDANMNLGMK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void HODPGNGKANI(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = BLMHOKPIMOD();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.PBMFBOOALKA("MascotChallenge2019", PhotonTargets.All, array);
		}
	}

	public void LJEPIJMPBHH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			JGACDFLHGKF();
		}
	}

	public void LKECONBPBGN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			BMCDOLNMNDN();
		}
	}

	public void KFNJJDIAJDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1616f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
		base.gameObject.transform.position = position;
	}

	public void FEFIONGBKIJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[0] = "Overlay";
			array[0] = base.gameObject;
			array[8] = "settings_bindings_controller_type";
			array[5] = SecondsBeforeRespawn;
			array[0] = "_ScreenResolution";
			array[3] = TimeOfRespawn;
			array[4] = "settings.shaders.bloomintencity";
			array[1] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_Value", this);
		}
		if (SecondsBeforeRespawn <= 710f)
		{
			HBPMLCNJHIL(1470f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 400.0)
		{
			CKBNBEPJOEE((float)num2);
		}
	}

	public void IKDOFOAOFFJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[7];
			array[1] = "Hidden/DepthOfField/MedianFilter";
			array[0] = base.gameObject;
			array[4] = "#newhighscore";
			array[2] = SecondsBeforeRespawn;
			array[5] = "_History4LumaTex";
			array[4] = TimeOfRespawn;
			array[6] = "OpenButton";
			array[5] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("Set Satellite Emission", this);
		}
		if (SecondsBeforeRespawn <= 576f)
		{
			PIMDACECPMA(1973f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 306.0)
		{
			CKBNBEPJOEE((float)num2);
		}
	}

	public void OHBLOLAFMLL()
	{
		if (PickupIsMine)
		{
			ACPGHFHDCIP().RPC("_Value4", (PhotonTargets)7, new object[1]);
		}
	}

	internal void GANGFBPADGO(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 327.0;
		if (DPMFFBEDNNN > 48f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("Tab2Content", DPMFFBEDNNN);
		}
	}

	internal void AMCALMOAOMP()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 471.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void EFADICPMHAN(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("BitsData");
		JHBEIDMONOI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void NEHMOHADDIM()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1109.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	internal void OHPFGOOJJKD()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 146.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void EHNKFNNOLIK(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1596.0;
		if (DPMFFBEDNNN > 210f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("_PosY", DPMFFBEDNNN);
		}
	}

	internal void IDIJNCBLDBH(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 973.0;
		if (DPMFFBEDNNN > 1941f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("a", DPMFFBEDNNN);
		}
	}

	internal void DEGJEDLKKJK()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 111.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void HBPMLCNJHIL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1335.0;
		if (DPMFFBEDNNN > 1734f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("/", DPMFFBEDNNN);
		}
	}

	internal void GOHOOCEHHHB()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1287.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void KMCNCLKFLKF(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("ScoreText");
		FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void FHLBHMIHIDE(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("id");
		FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void OCPHFBJHNMM()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			EOOCGIFFKBG().IKIJDNPJKPM("settings.arcsdestroydelay", PhotonTargets.All, new object[0]);
		}
	}

	internal void GDANOGMCNEF()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 786.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}
}
