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

	public void LEKLBNCDIHM()
	{
		if (PickupIsMine)
		{
			JAEJDHHCJJO().RPC("No Dispatcher exists in the scene. Actions will not be invoked!", PhotonTargets.All, new object[1]);
		}
	}

	public void LAAJGBNMLOF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[0] = "TRACKING";
			array[0] = base.gameObject;
			array[5] = "_Bullet_6";
			array[3] = SecondsBeforeRespawn;
			array[2] = "ShadersToggle";
			array[7] = TimeOfRespawn;
			array[6] = "/icon";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_TimeX", this);
		}
		if (SecondsBeforeRespawn <= 223f)
		{
			IANOIPLBAMB(330f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 662.0)
		{
			PLMNJNKLBNN((float)num2);
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

	internal void AIONFBLHGGM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("[Down-Left]");
		EOAKPALFLAO();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void HBPAONMLOOK()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1788.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1368f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
		base.gameObject.transform.position = position;
	}

	public void ANIGCEBNCFN(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			NABDKNPNEMM().RPC("/files/mods_terms.pdf", PhotonTargets.All, ENENGMDFKHK);
		}
	}

	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA() && SecondsBeforeRespawn <= 410f)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void ECDGGCMLOMB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[1] = "note.0";
			array[0] = base.gameObject;
			array[0] = ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
			array[5] = SecondsBeforeRespawn;
			array[7] = "_PosX";
			array[7] = TimeOfRespawn;
			array[8] = "CameraFilterPack/Blend2Camera_ColorBurn";
			array[4] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("[MapsData] Bad map: ", this);
		}
		if (SecondsBeforeRespawn <= 690f)
		{
			IANOIPLBAMB(1895f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1327.0)
		{
			OBOFLKKMOLO((float)num2);
		}
	}

	public void CBIDBNCBLGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA() && SecondsBeforeRespawn <= 782f)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
		base.gameObject.transform.position = position;
	}

	public void IBFGBHLEJFP(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = AAMNKPHHHCI();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.RPC("workshop.", PhotonTargets.AllBufferedViaServer, array);
		}
	}

	internal void JIFLNLLDANL()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 898.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void EICNKJNLIED(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			GBHNDHLAJLI().RPC("_SampleScale", PhotonTargets.AllViaServer, ENENGMDFKHK);
		}
	}

	internal void JHLABNLLMOI()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1192.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void DCFLEIFLLMM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_ScreenResolution");
		BGGFOKGOALL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void PGJCONPAANJ(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_Value4");
		JIFLNLLDANL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void AAJJEKJMNLL(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = CIACEFBNDDJ();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.RPC("CameraFilterPack/FX_Funk", PhotonTargets.OthersBuffered, array);
		}
	}

	public void APLPGHEJDME()
	{
		if (PickupIsMine)
		{
			GBHNDHLAJLI().RPC("GlassDistortion", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	public void NPFDCLNGGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1964f)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	internal void EOAKPALFLAO()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 6.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	internal void DGIAHICNPJG(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("GameVolumeSlider");
		PunRespawn();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void JDNFFHOLKJB(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = JDBCGCJJIAF();
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			obj.RPC("HPText", (PhotonTargets)7, array);
		}
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

	internal void PFBDDGKAKDI()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 1870.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	internal void AHKENHIJMCL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 637.0;
		if (DPMFFBEDNNN > 891f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("L1", DPMFFBEDNNN);
		}
	}

	public void MPGJDLCANPA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA() && SecondsBeforeRespawn <= 38f)
		{
			HCIJEDFCNOP.GJDCOKMGHOG(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void MIIEFMBHODF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[1];
			array[1] = " registered.";
			array[0] = base.gameObject;
			array[5] = "solo";
			array[3] = SecondsBeforeRespawn;
			array[3] = "ServerSettings: ";
			array[2] = TimeOfRespawn;
			array[0] = "shader.ghost";
			array[2] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("-", this);
		}
		if (SecondsBeforeRespawn <= 1485f)
		{
			OBOFLKKMOLO(1511f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HPJGEPFOBFH();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1247.0)
		{
			FCJIMDOEDDN((float)num2);
		}
	}

	[SpecialName]
	public int LDCNHGLLBMB()
	{
		return JAEJDHHCJJO().PLMCHLCIABC();
	}

	public void GBNDJBNLKLI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.MLCGKMDJIMA() && SecondsBeforeRespawn <= 77f)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
		base.gameObject.transform.position = position;
	}

	public void NOFJJHPOCBJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[6];
			array[1] = "ArcsDestroyDelaySlider";
			array[1] = base.gameObject;
			array[0] = "ready";
			array[8] = SecondsBeforeRespawn;
			array[8] = ": ";
			array[5] = TimeOfRespawn;
			array[3] = " #";
			array[0] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_VignetteCenter", this);
		}
		if (SecondsBeforeRespawn <= 1528f)
		{
			AHKENHIJMCL(1231f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 206.0)
		{
			BHCDHJDCMEF((float)num2);
		}
	}

	public void ALNIKGLFKAO()
	{
		if (PickupIsMine)
		{
			AAMNKPHHHCI().RPC(" - {0}", PhotonTargets.MasterClient);
		}
	}

	public void KCEOILDOCKP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[2];
			array[1] = "Set particles gravity";
			array[0] = base.gameObject;
			array[4] = "offsets";
			array[8] = SecondsBeforeRespawn;
			array[5] = "CameraFilterPack/Atmosphere_Fog";
			array[1] = TimeOfRespawn;
			array[8] = "menu.selectedlevelid";
			array[5] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("Editor", this);
		}
		if (SecondsBeforeRespawn <= 1200f)
		{
			AHKENHIJMCL(722f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1887.0)
		{
			IANOIPLBAMB((float)num2);
		}
	}

	internal void EELIINFLNNP(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1661.0;
		if (DPMFFBEDNNN > 1001f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("_Size", DPMFFBEDNNN);
		}
	}

	public void OAMFGNKCDJE(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			PPGEEDDMBNH();
		}
	}

	public void GCBLPOMNHNC(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = BLMHOKPIMOD();
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			obj.RPC("Right Stick Click", PhotonTargets.All, array);
		}
	}

	[SpecialName]
	public int KHJPDLIPFDA()
	{
		return NABDKNPNEMM().viewID;
	}

	[SpecialName]
	public int KJBLLMBPDCA()
	{
		return BBGIDKNEGHD().PLMCHLCIABC();
	}

	public void NHDNCPBBDDC(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			PPFHDNOHEOP();
		}
	}

	public void ALGMKDLPJLM()
	{
		if (PickupIsMine)
		{
			IFENGKHOKPC().RPC("checkpoint", PhotonTargets.Others);
		}
	}

	public void JECGGNMMIHD(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = IFENGKHOKPC();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.RPC("maps.", (PhotonTargets)7, array);
		}
	}

	internal void CNGKBDIOIEL(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("UseScanLineSize");
		OCAKDLAGPJG();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	[SpecialName]
	public int DCFELMKGHIG()
	{
		return IFENGKHOKPC().PLMCHLCIABC();
	}

	public void Drop(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer, ENENGMDFKHK);
		}
	}

	internal void AEPFEMLAJKJ(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1877.0;
		if (DPMFFBEDNNN > 1399f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("Cant send PickupItem spawn times to unknown targetPlayer.", DPMFFBEDNNN);
		}
	}

	[SpecialName]
	public int JJDKJLBBJPM()
	{
		return NABDKNPNEMM().viewID;
	}

	public void EMKIGFCHGPJ(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = JIOCGDBKGIL();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.RPC("settings.enablehitsoundsinnormal", (PhotonTargets)7, array);
		}
	}

	internal void PPNPJENOMGA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1382.0;
		if (DPMFFBEDNNN > 57f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("/music", DPMFFBEDNNN);
		}
	}

	public void JLNPPGGPDHF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 355f)
		{
			HCIJEDFCNOP.NICKMDDINKP(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
		base.gameObject.transform.position = position;
	}

	public void DHFGDPAEEFC()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			EDIJKHEMPAD().RPC("CountEventsGoal", PhotonTargets.MasterClient);
		}
	}

	internal void GBGCHONJKJI(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Mouse Wheel Down");
		JIFLNLLDANL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void OCAKDLAGPJG()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 54.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	internal void KBCALOHBEBH(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("settings_bindings_sec_");
		JIFLNLLDANL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void IOJANBBKIME(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_Speed");
		DFJENGLLLBE();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void NIFFDEHKHDG(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			MCODMMGCDLM();
		}
	}

	public void BFCDFGFMKHA(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = EOOCGIFFKBG();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.RPC(" ", PhotonTargets.AllBufferedViaServer, array);
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

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && SecondsBeforeRespawn <= 1392f)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(base.gameObject.transform.position);
			return;
		}
		Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		base.gameObject.transform.position = position;
	}

	public void JOLNEGLLODD(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			Pickup();
		}
	}

	internal void PLMNJNKLBNN(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 650.0;
		if (DPMFFBEDNNN > 1356f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("Right", DPMFFBEDNNN);
		}
	}

	internal void LLIDOADHPJD(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("ControllerLeftY");
		PFBDDGKAKDI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	internal void DAGLKCBLNCL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 952.0;
		if (DPMFFBEDNNN > 924f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("z", DPMFFBEDNNN);
		}
	}

	internal void MFDANMNLGMK(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Parameter levelId can't be null!");
		JHLABNLLMOI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void KDGGABLIEJG(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[6];
			array[0] = "Alternative";
			array[0] = base.gameObject;
			array[6] = "_Value";
			array[4] = SecondsBeforeRespawn;
			array[0] = "float,0";
			array[1] = TimeOfRespawn;
			array[1] = "CameraFilterPack/TV_Rgb";
			array[0] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("Crosshair1", this);
		}
		if (SecondsBeforeRespawn <= 520f)
		{
			PLMNJNKLBNN(1217f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 288.0)
		{
			PLMNJNKLBNN((float)num2);
		}
	}

	internal void KGKFMKEHGOP()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 382.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void MCODMMGCDLM()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			JIOCGDBKGIL().RPC("\n\n#", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	public void OJFBDENEMMN(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			IJBFILBDGDO().RPC("event", PhotonTargets.AllViaServer, ENENGMDFKHK);
		}
	}

	internal void BOACAPEAOPM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("id");
		BGGFOKGOALL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	public void HFPLDAGNNPJ()
	{
		if (PickupIsMine)
		{
			OELHGNKAMEG().RPC(". Calling ConnectToRegionMaster() is: ", (PhotonTargets)8, new object[1]);
		}
	}

	public void MHNKJCICBOH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[1];
			array[1] = "_Value";
			array[1] = base.gameObject;
			array[3] = "_Value3";
			array[5] = SecondsBeforeRespawn;
			array[5] = ".lastCheckpoint.perfectHits";
			array[8] = TimeOfRespawn;
			array[0] = "SetSatelliteTrailWidth";
			array[4] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_ScreenResolution", this);
		}
		if (SecondsBeforeRespawn <= 67f)
		{
			EELIINFLNNP(867f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.DEDMDLGOBBG();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1285.0)
		{
			EELIINFLNNP((float)num2);
		}
	}

	public void NKICMGLNHGO()
	{
		if (PickupIsMine)
		{
			CIACEFBNDDJ().RPC("GlassDistortion", PhotonTargets.AllViaServer);
		}
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

	public void PPFHDNOHEOP()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			base.photonView.RPC("_Skybox", PhotonTargets.MasterClient);
		}
	}

	public void DADAILNBDFJ(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			DHFGDPAEEFC();
		}
	}

	public void DPNJOGPDFMC(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			MCODMMGCDLM();
		}
	}

	public void PPGEEDDMBNH()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			EOOCGIFFKBG().RPC(".GoalProgress", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	[SpecialName]
	public int HNMFOPFNIAF()
	{
		return EDIJKHEMPAD().viewID;
	}

	public void OHPBBCMDLOD(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[2];
			array[1] = "note.5";
			array[0] = base.gameObject;
			array[0] = "_Value4";
			array[2] = SecondsBeforeRespawn;
			array[1] = "RecordButton";
			array[8] = TimeOfRespawn;
			array[8] = "CameraFilterPack/Noise_TV";
			array[4] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("_Value", this);
		}
		if (SecondsBeforeRespawn <= 138f)
		{
			EELIINFLNNP(531f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.FEHJOGAONOJ();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 836.0)
		{
			EELIINFLNNP((float)num2);
		}
	}

	internal void IANOIPLBAMB(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1630.0;
		if (DPMFFBEDNNN > 737f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("maps.", DPMFFBEDNNN);
		}
	}

	public void GKLOFJNLBIN()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			BLMHOKPIMOD().RPC("_Value", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	public void NDDICLMFJJN(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[1] = "Set Satellite Trail MinVertexDistance";
			array[1] = base.gameObject;
			array[3] = "Working commands:\nreset <challengeid>\nresetall";
			array[5] = SecondsBeforeRespawn;
			array[5] = "{0} months ago";
			array[4] = TimeOfRespawn;
			array[3] = "_Value2";
			array[1] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("PLEASE WAIT", this);
		}
		if (SecondsBeforeRespawn <= 1371f)
		{
			EELIINFLNNP(1339f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.DEDMDLGOBBG();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 648.0)
		{
			EELIINFLNNP((float)num2);
		}
	}

	internal void OBOFLKKMOLO(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 993.0;
		if (DPMFFBEDNNN > 1435f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", DPMFFBEDNNN);
		}
	}

	public void NHKAFODJNEK(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = BBGIDKNEGHD();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.RPC("_TimeX", PhotonTargets.AllBuffered, array);
		}
	}

	public void MPNNECAIPDD(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[1] = "0 - default, 1 - left, 2 - right";
			array[0] = base.gameObject;
			array[0] = "_TimeX";
			array[4] = SecondsBeforeRespawn;
			array[6] = " not exist";
			array[4] = TimeOfRespawn;
			array[4] = "/icon";
			array[3] = TimeOfRespawn > PhotonNetwork.time;
			Debug.Log(string.Concat(array));
			return;
		}
		PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (OnPickedUpCall != null)
		{
			OnPickedUpCall.SendMessage("OpSettings()", this);
		}
		if (SecondsBeforeRespawn <= 738f)
		{
			KNABLPOBADA(1994f);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PEIJAJACPJA();
		double num2 = (double)SecondsBeforeRespawn - num;
		if (num2 > 1639.0)
		{
			AEPFEMLAJKJ((float)num2);
		}
	}

	[SpecialName]
	public int LHHOIJOPCNN()
	{
		return EOOCGIFFKBG().viewID;
	}

	internal void FCJIMDOEDDN(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1088.0;
		if (DPMFFBEDNNN > 1831f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("RPCs can only be sent in rooms. Call of \"", DPMFFBEDNNN);
		}
	}

	public void IMAMGDIKKKE(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = NABDKNPNEMM();
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			obj.RPC("No Description", PhotonTargets.Others, array);
		}
	}

	internal void BGGFOKGOALL()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 982.0;
		PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void HPHCKKOKBOA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			DHFGDPAEEFC();
		}
	}

	public void Drop()
	{
		if (PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer);
		}
	}

	[PunRPC]
	internal void PunRespawn(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("PunRespawn with Position.");
		PunRespawn();
		base.gameObject.transform.position = HMDKPLLDBEA;
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
	public int LHOFMFIBHCH()
	{
		return ACPGHFHDCIP().PLMCHLCIABC();
	}

	public void HODPGNGKANI()
	{
		if (PickupIsMine)
		{
			GBHNDHLAJLI().RPC("IntraSig", PhotonTargets.Others, new object[1]);
		}
	}

	public void AAFIDAMBPBG(Vector3 ENENGMDFKHK)
	{
		if (PickupIsMine)
		{
			PhotonView obj = GMAHNPNHMFK();
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			obj.RPC("_ScreenResolution", PhotonTargets.OthersBuffered, array);
		}
	}

	internal void BHCDHJDCMEF(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		DisabledPickupItems.Add(this);
		TimeOfRespawn = 1715.0;
		if (DPMFFBEDNNN > 636f)
		{
			TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			Invoke("Called GetNumberOfCurrentPlayers()", DPMFFBEDNNN);
		}
	}

	internal void DFJENGLLLBE()
	{
		DisabledPickupItems.Remove(this);
		TimeOfRespawn = 978.0;
		PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void CFHHBKBHEBE(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnTrigger && component != null && component.isMine)
		{
			PPFHDNOHEOP();
		}
	}
}
