// PickupItemSimple
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class PickupItemSimple : Photon.MonoBehaviour
{
	public float SecondsBeforeRespawn = 2f;

	public bool PickupOnCollide;

	public bool SentPickup;

	public void JFIKFFBMPNK()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			IBKCMBIGOEJ().MIAHMDGOOPJ("CameraFilterPack/Color_GrayScale", (PhotonTargets)7, new object[0]);
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
			Debug.Log("ViewMenu" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.CMHMBFHAKOE();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 607f)
		{
			base.gameObject.SetActive(true);
			Invoke("_MainTex2", num2);
		}
	}

	public void HMOLMNEJEHK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void CNHPLAONDNB()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			IBKCMBIGOEJ().MIAHMDGOOPJ("DPADHOR", PhotonTargets.OthersBuffered, new object[1]);
		}
	}

	public void ECBAINLOAMA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			AHJGIFKOFJB();
		}
	}

	public void ONHEDAINMAF()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			FFIPLLNKGEN().RPC("_SceneFogMode", (PhotonTargets)7, new object[1]);
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

	public void GFKEGEMFJJE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("id" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 250f)
		{
			base.gameObject.SetActive(true);
			Invoke("EventTimeInputField", num2);
		}
	}

	public void OMEDCHKGMND(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_ClutTex" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1638f)
		{
			base.gameObject.SetActive(false);
			Invoke("mapselector.orderby", num2);
		}
	}

	public void NEGODKBGGKO(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.isMine)
		{
			AHJGIFKOFJB();
		}
	}

	public void HOLAHMOGJGK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void GJIAHMCOIMM()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GBHNDHLAJLI().PBMFBOOALKA("CameraFilterPack/Distortion_Wave_Horizontal", PhotonTargets.All, new object[1]);
		}
	}

	public void KKJLFIMOBAH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Value5" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.MAOGNACLFAA();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 586f)
		{
			base.gameObject.SetActive(false);
			Invoke("CameraFilterPack_RainFX_Anm2", num2);
		}
	}

	public void GJJLCODONCE()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			EOOCGIFFKBG().MIAHMDGOOPJ("settings.enablerankingnotifications", PhotonTargets.MasterClient, new object[0]);
		}
	}

	public void AHJGIFKOFJB()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			JAEJDHHCJJO().MIAHMDGOOPJ("Set sun min/max size", PhotonTargets.AllBufferedViaServer, new object[0]);
		}
	}

	public void NGPIGBJGKBF()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void AHFONDPGGHC()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			ACPGHFHDCIP().KEKKFNNMLMG("_SunPosition", (PhotonTargets)8, new object[1]);
		}
	}

	public void NHJONLFALMB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_FgOverlap" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GJDFJLLPCEC();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 811f)
		{
			base.gameObject.SetActive(false);
			Invoke("_MainTex2", num2);
		}
	}

	public void LLEJLALFCPH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void EFLMEDBKOAF()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GMAHNPNHMFK().KEKKFNNMLMG("Tab2Content", PhotonTargets.AllBufferedViaServer, new object[0]);
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
			Debug.Log("_CameraClipInfo" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KDGEAANCGLG();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1791f)
		{
			base.gameObject.SetActive(true);
			Invoke("id", num2);
		}
	}

	public void RespawnAfter()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void KLJHODOACJL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			AHFONDPGGHC();
		}
	}

	public void NJOLEFIKLPL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			ONHEDAINMAF();
		}
	}

	public void HKHGPJDAJKA()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			AAMNKPHHHCI().MIAHMDGOOPJ("_Value3", PhotonTargets.OthersBuffered, new object[1]);
		}
	}

	public void LJEPIJMPBHH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			GJJLCODONCE();
		}
	}

	public void LKKOKEBPMPC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void GLBMAGNIFDC()
	{
		if (!SentPickup)
		{
			SentPickup = false;
			GBHNDHLAJLI().PBMFBOOALKA("value", (PhotonTargets)8, new object[1]);
		}
	}

	public void CDEMOBDDOBE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log(".lastCheckpoint.penaltyScore" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1328f)
		{
			base.gameObject.SetActive(true);
			Invoke("_Value2", num2);
		}
	}

	public void MCODMMGCDLM()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			OELHGNKAMEG().RPC("_Value2", PhotonTargets.Others);
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

	public void JDKADFHCGML(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			ONHEDAINMAF();
		}
	}

	public void GHNNBBKDPJL(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Using Stopwatch as precision timer for PUN." + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 1072f)
		{
			base.gameObject.SetActive(true);
			Invoke("_ScreenResolution", num2);
		}
	}

	public void GHBMODAKDHJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("offsets" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.ALPEKJJGCGG();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 339f)
		{
			base.gameObject.SetActive(true);
			Invoke("SetParticlesParticleSpeed", num2);
		}
	}

	public void PJPNDBBNFBN()
	{
		if (!SentPickup)
		{
			SentPickup = true;
			GBMJAPGLMGB().RPC("maps.", PhotonTargets.AllViaServer, new object[1]);
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
			Debug.Log("CameraFilterPack/Blend2Camera_Hue" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HLOHLMIDPEE();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 108f)
		{
			base.gameObject.SetActive(false);
			Invoke("SupportLogger OnFailedToConnectToPhoton(", num2);
		}
	}

	public void BAGDABNNIFI(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_ScreenResolution" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
		float num2 = SecondsBeforeRespawn - (float)num;
		if (num2 > 656f)
		{
			base.gameObject.SetActive(true);
			Invoke("achievements.21.progress", num2);
		}
	}

	public void KHOGKNEBBOI()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void HPHCKKOKBOA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			CNHPLAONDNB();
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
}
