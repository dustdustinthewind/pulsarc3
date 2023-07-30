// LobbyPlayerElement
using System.Collections;
using Photon;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class LobbyPlayerElement : PunBehaviour
{
	public GameObject readyCanvas;

	public Text nicknameText;

	public Image bg;

	public Image icon;

	public bool isReady;

	public GameObject removeButton;

	public GameObject contributorGO;

	private void NGEGCLCPPCD()
	{
	}

	private IEnumerator OCFOOHMLPFC(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void IJCIJCDEGJE(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Size");
		BOBDANOFGAE();
	}

	public void GKOOCOGHOGJ()
	{
		isReady = ((GBHNDHLAJLI().GLFNAPCBIJP().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private void LJIHHJOAJCN()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private IEnumerator NBJAFEDELKC(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private IEnumerator FALEDPONNLJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void ENECFGPADBI(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("RecieveChatActionMessage");
		JBNINCMJAIG();
	}

	public void PEGNCEOFBNF(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-46);
		}
		GBMJAPGLMGB().MDHAJGGHKMC(".lastCheckpoint.powerupsScore", JHOEDACNNKK, new object[0]);
	}

	public void EJGJEMGLGIH()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(BLMHOKPIMOD().GLFNAPCBIJP().name));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("_Value3") + cSteamID.m_SteamID, false);
	}

	public void FBCMBGFKCAK(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(97);
		}
		CIACEFBNDDJ().MDHAJGGHKMC("RarityImage", JHOEDACNNKK, new object[0]);
	}

	public void KMLHFIHIAON()
	{
		Debug.Log("CameraFilterPack/OldFilm_Cutting2" + NABDKNPNEMM().owner.MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(BBGIDKNEGHD().GLFNAPCBIJP().MLIGBALKGCF()));
		StartCoroutine(EJILOCLBCFK(jMMILEFMACB));
		JBNINCMJAIG();
	}

	private IEnumerator IEAKJGCLENA(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void KECADMPBGMM()
	{
		isReady = EOOCGIFFKBG().owner.GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private void MMOKKAPFGAK()
	{
		if (!GMAHNPNHMFK().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(810f, 1986f, 454f);
			JJFLHFCBENC();
		}
	}

	public void OCBHIDOBBBN(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("CameraFilterPack/Distortion_FishEye");
		DBJBPPHHIOE();
	}

	private void COOHIILCOCO()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1668f, 1015f, 572f);
			NFKKPHKGIEI();
		}
	}

	private IEnumerator FLJHFPLJGFD(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void MDNHCLKNCLE()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1219f, 1139f, 1384f);
			KOKDPAEJECC();
		}
	}

	public void LEKKIMDFOIH()
	{
		isReady = ((ACPGHFHDCIP().owner.GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void EGANBKHKLBJ(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("Joystick1Button5");
		JMCLAGKENHN();
	}

	private IEnumerator IIBNEOFPKLI(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void PAGMHKDINLA()
	{
		isReady = ((AAMNKPHHHCI().owner.GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private IEnumerator BEGIHKFNLBP(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void KBKHIGFLNIA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-87);
		}
		GBHNDHLAJLI().RPC("_Value3", JHOEDACNNKK, new object[1]);
	}

	public void KFDEOJDKLKE()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(JDBCGCJJIAF().owner.MLIGBALKGCF()));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/Color_GrayScale") + cSteamID.m_SteamID, false);
	}

	public void IFMLDLNFCLC()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(BLMHOKPIMOD().owner.name));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.JJGKGCBCGGD("{0}") + cSteamID.m_SteamID, false);
	}

	public void JDAMDEHHGAG()
	{
		isReady = IBKCMBIGOEJ().owner.GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void IBLBIFMFFOP()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(PHCBHAFMDEJ().GLFNAPCBIJP().MLIGBALKGCF()));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("Item ") + cSteamID.m_SteamID);
	}

	private void KMCPMOGKDEH()
	{
		if (!IFENGKHOKPC().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(553f, 678f, 476f);
			PBBDHIFJHHC();
		}
	}

	private void PHMKCHACLEP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.JPHEAJOLIGK("_ReflectionTexture1", "_Value2", null, true, true, 948f);
		Singleton<MultiplayerSystem>.Instance.DBALDPFKNJM();
	}

	public void IFFPGCAOADA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-64);
		}
		CIACEFBNDDJ().MDHAJGGHKMC("player.xp", JHOEDACNNKK, new object[1]);
	}

	public void KOKDPAEJECC()
	{
		Debug.Log("skin.hit_wrong" + GMAHNPNHMFK().owner.MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().GLFNAPCBIJP().name));
		StartCoroutine(FEPOGFLFJBL(jMMILEFMACB));
		LEKKIMDFOIH();
	}

	private void KFMEAMBLODG()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void DGJJMFMACIF()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(EDIJKHEMPAD().owner.MLIGBALKGCF()));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.JJGKGCBCGGD("No problem found, so far") + cSteamID.m_SteamID, false);
	}

	private void IBFJAOINHMK()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private void COIJKMKIEAK()
	{
		if (!IBKCMBIGOEJ().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(778f, 716f, 607f);
			KMLHFIHIAON();
		}
	}

	public void NBIEIGBAKND()
	{
		Debug.Log("_TimeX" + OELHGNKAMEG().GLFNAPCBIJP().MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(BBGIDKNEGHD().owner.name));
		StartCoroutine(IIBNEOFPKLI(jMMILEFMACB));
		BOBDANOFGAE();
	}

	public void EOFLFKEIJCE(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_ReflectionBufferSize");
		JDAMDEHHGAG();
	}

	public void CheckIsReady()
	{
		isReady = ((base.photonView.owner.GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void DAPMMOCIFJA()
	{
		isReady = AAMNKPHHHCI().owner.GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void OCHADIJNDJK()
	{
		Debug.Log("inventory.itemscash" + IFENGKHOKPC().GLFNAPCBIJP().MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(BLMHOKPIMOD().GLFNAPCBIJP().name));
		StartCoroutine(IIDFEAGPOKJ(jMMILEFMACB));
		JDAMDEHHGAG();
	}

	public void DLFHOLAOHMK(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-125);
		}
		BLMHOKPIMOD().RPC("s", JHOEDACNNKK);
	}

	private void ADPLHDFJFID()
	{
		if (!IBKCMBIGOEJ().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1856f, 540f, 1116f);
			KOKDPAEJECC();
		}
	}

	public void AMFKMGPDBHI(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(106);
		}
		CIACEFBNDDJ().RPC("MapCreationCanvas", JHOEDACNNKK, new object[1]);
	}

	public void NFKKPHKGIEI()
	{
		Debug.Log("Object ID. Case-Sensitive" + AAMNKPHHHCI().GLFNAPCBIJP().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(JAEJDHHCJJO().GLFNAPCBIJP().name));
		StartCoroutine(IIBNEOFPKLI(jMMILEFMACB));
		JBNINCMJAIG();
	}

	public void BNLBOEAHFFO()
	{
		if (PhotonNetwork.isMasterClient)
		{
			IFFPGCAOADA(NABDKNPNEMM().GLFNAPCBIJP());
		}
	}

	public void PMPDDNPENEL(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("BitsData");
		BOBDANOFGAE();
	}

	private void DIPDEHOOBPG()
	{
		if (!IFENGKHOKPC().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1379f, 411f, 1005f);
			CKJCPBPMBFF();
		}
	}

	private void KOJKBFDNGDK()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1821f, 1772f, 327f);
			NKLNGGOHLMO();
		}
	}

	public void KHFMPFEGBNM()
	{
		if (PhotonNetwork.isMasterClient)
		{
			DNJNCKDDHDD(IFENGKHOKPC().GLFNAPCBIJP());
		}
	}

	public void EOMPBBPIFOH(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("/");
		KECADMPBGMM();
	}

	public void HNGGEDAKIGD(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(73);
		}
		IBKCMBIGOEJ().RPC("InputField", JHOEDACNNKK);
	}

	private void HPNNCNNFMGK()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private void LKJMIODJGCM()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private IEnumerator JCFPJFHBAEJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void BMOFEBKGLFI()
	{
		if (!GMAHNPNHMFK().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1107f, 1071f, 831f);
			NBIEIGBAKND();
		}
	}

	private void CGDMLHLJIDK()
	{
		if (!PHCBHAFMDEJ().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(313f, 15f, 593f);
			NBIEIGBAKND();
		}
	}

	private void OCMKCBBCEFG()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void JEPEHKGNDHA()
	{
		isReady = ((GBHNDHLAJLI().GLFNAPCBIJP().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void LJCIGNEGKOD()
	{
		Debug.Log("_BlurPass" + GMAHNPNHMFK().GLFNAPCBIJP().MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(EOOCGIFFKBG().owner.name));
		StartCoroutine(LPICKOCJNGJ(jMMILEFMACB));
		KECADMPBGMM();
	}

	private void FJDINLDLAHN()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("id").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.JJEOAFDDLHK("_TimeX", "4,28,true,0", null, true, false, 352f);
		Singleton<MultiplayerSystem>.Instance.DBALDPFKNJM();
	}

	private void GDNMGEJDGDP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("isVisible").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.HLEOBMODPLO(".workshop", "GlassesColor", null, false, false, 1084f);
		Singleton<MultiplayerSystem>.Instance.KDOGNHMDLJK();
	}

	public void JMCLAGKENHN()
	{
		isReady = NABDKNPNEMM().GLFNAPCBIJP().GetTeam() == PunTeams.Team.none && false;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void BHGCNMBOADK(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_TreatBackfaceHitAsMiss");
		KECADMPBGMM();
	}

	private void IEMEHGCFAPD()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void NFCCNACGGPI()
	{
		isReady = ((IBKCMBIGOEJ().GLFNAPCBIJP().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private void IDIIELPAMCJ()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private void FABKIGNFECE()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void PBBDHIFJHHC()
	{
		Debug.Log("HighScaleShot" + BLMHOKPIMOD().owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(IBKCMBIGOEJ().owner.name));
		StartCoroutine(BNFCNEHFMOM(jMMILEFMACB));
		LEKKIMDFOIH();
	}

	private IEnumerator FEPOGFLFJBL(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void FEGHDHBDIJD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			HGOIEPFFIBH(JDBCGCJJIAF().owner);
		}
	}

	public void NOAHPKJIFEL(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-119);
		}
		GBMJAPGLMGB().MDHAJGGHKMC("_ThirdTex", JHOEDACNNKK, new object[0]);
	}

	public void JJFLHFCBENC()
	{
		Debug.Log("CameraFilterPack_TV_Noise2" + IJBFILBDGDO().owner.MLIGBALKGCF());
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(JAEJDHHCJJO().owner.name));
		StartCoroutine(JAKPGMDDEID(jMMILEFMACB));
		JMCLAGKENHN();
	}

	public void KickPlayer()
	{
		if (PhotonNetwork.isMasterClient)
		{
			SendKickPlayer(base.photonView.owner);
		}
	}

	public void CKJCPBPMBFF()
	{
		Debug.Log(" not exist" + PHCBHAFMDEJ().owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().owner.name));
		StartCoroutine(JAKPGMDDEID(jMMILEFMACB));
		GKOOCOGHOGJ();
	}

	private void JCGPAMAFKEI()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("_ScreenResolution").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.BOKKOAKIDMK("_PColor", "Type \"help\" for list of commands", null, false, false, 800f);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	[PunRPC]
	public void OnReadyClick(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("[LobbyPlayerElement] On ready click");
		CheckIsReady();
	}

	private void LOLHKNKBNPF()
	{
	}

	private void AIJGAJIOJDJ()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void JCJNGGDMOPJ()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(BLMHOKPIMOD().owner.MLIGBALKGCF()));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/FX_Grid") + cSteamID.m_SteamID);
	}

	public void SendKickPlayer(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(23);
		}
		base.photonView.RPC("KickThePlayer", JHOEDACNNKK);
	}

	public void DNJNCKDDHDD(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-18);
		}
		ACPGHFHDCIP().RPC("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", JHOEDACNNKK, new object[1]);
	}

	private void NCPAFCKGJEA()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void JOAONIBIKNM()
	{
		isReady = ((JDBCGCJJIAF().owner.GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private void MKOMIDCPCDC()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1394f, 890f, 1846f);
			Init();
		}
	}

	private IEnumerator LPICKOCJNGJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void OnEnable()
	{
	}

	private IEnumerator IIDFEAGPOKJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void BCFPBBBKKNP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("ItemNameText").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.POHMPIDHJII("itemid", "LeaderboardsButton", null, true, true, 1336f);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void KEAMMGPCIBN(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("settings.cameramovements");
		BOBDANOFGAE();
	}

	private IEnumerator EJILOCLBCFK(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private IEnumerator DHLMJDFJEAD(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void CFMJMJOHJII()
	{
	}

	private IEnumerator HJFDEEMKFDJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void OFFPOJHKKKF()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(ACPGHFHDCIP().owner.name));
		Singleton<GameManager>.Instance.FMCBLGPDACK(Singleton<GameManager>.Instance.JJGKGCBCGGD(" has been disabled as it's not supported on the current platform.") + cSteamID.m_SteamID);
	}

	public void FOKCKLJDHOF()
	{
		if (PhotonNetwork.isMasterClient)
		{
			KBKHIGFLNIA(PHCBHAFMDEJ().GLFNAPCBIJP());
		}
	}

	private void CNHJEANKGMP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("SupportLogger OnFailedToConnectToPhoton(").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP("Horizontal", "SetParticlesCountPerBeat", null, false, true, 538f);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void CPPOPKDOILP()
	{
		Debug.Log("GlassesColor" + JDBCGCJJIAF().owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(BBGIDKNEGHD().owner.name));
		StartCoroutine(DHLMJDFJEAD(jMMILEFMACB));
		LEKKIMDFOIH();
	}

	private void JBCNIPJDPJB()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private IEnumerator EFCOMCEMBMF(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void DEAEMCDHANH()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("Tab2Content").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.DMDDLAICNDI("Tab2Content", "float,0", null, true, false, 669f);
		Singleton<MultiplayerSystem>.Instance.KDOGNHMDLJK();
	}

	public void OpenProfile()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(base.photonView.owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + cSteamID.m_SteamID);
	}

	private IEnumerator HKNGNCBAGPH(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void FHHMDEIGLKN(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(110);
		}
		EOOCGIFFKBG().RPC("_TimeX", JHOEDACNNKK);
	}

	private IEnumerator KBMDGGPOLED(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void KPNMGBDOFGL()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(EOOCGIFFKBG().owner.MLIGBALKGCF()));
		Singleton<GameManager>.Instance.HEHKJIHIBLD(Singleton<GameManager>.Instance.CreateServerURL("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ") + cSteamID.m_SteamID);
	}

	private void Start()
	{
		if (!base.photonView.isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			Init();
		}
	}

	[PunRPC]
	private void KickThePlayer()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("LobbyCanvas").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#kicked", "#ok", null);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void FOKKLBJOMCK()
	{
		if (PhotonNetwork.isMasterClient)
		{
			IFFPGCAOADA(OELHGNKAMEG().owner);
		}
	}

	public void HGOIEPFFIBH(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(93);
		}
		CIACEFBNDDJ().RPC(" not exist", JHOEDACNNKK, new object[1]);
	}

	private void KDMKDEKCELE()
	{
		if (!IJBFILBDGDO().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(351f, 771f, 1330f);
			KMLHFIHIAON();
		}
	}

	private void PAAJFOKEJBN()
	{
	}

	public void EACFDOPAEOJ()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(ACPGHFHDCIP().owner.name));
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.JJGKGCBCGGD("_ColorRGB") + cSteamID.m_SteamID);
	}

	public void JPEHBKGOBJN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			SendKickPlayer(IJBFILBDGDO().owner);
		}
	}

	public void OBKLOHLELDH(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("threshold");
		NFCCNACGGPI();
	}

	private IEnumerator BNFCNEHFMOM(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void BBLEPIHAEJJ()
	{
	}

	public void FMJLAGJDIEJ()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(NABDKNPNEMM().GLFNAPCBIJP().MLIGBALKGCF()));
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("_MainTex2") + cSteamID.m_SteamID, false);
	}

	private void GBJCPHJJFID()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find(" takes from: ").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("_ScreenResolution", "WARNING: rotation axis set to 0 on ", null, false, true, 1978f);
		Singleton<MultiplayerSystem>.Instance.KDOGNHMDLJK();
	}

	public void EIJEJHKDINK()
	{
		if (PhotonNetwork.isMasterClient)
		{
			HNGGEDAKIGD(IBKCMBIGOEJ().owner);
		}
	}

	public void JBNINCMJAIG()
	{
		isReady = ((EDIJKHEMPAD().GLFNAPCBIJP().GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void NKLNGGOHLMO()
	{
		Debug.Log("Parameter levelId must be int or string!" + GBHNDHLAJLI().owner.MLIGBALKGCF());
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().GLFNAPCBIJP().MLIGBALKGCF()));
		StartCoroutine(IEAKJGCLENA(jMMILEFMACB));
		LEKKIMDFOIH();
	}

	private void HIFPDKKBDHJ()
	{
	}

	public void AMGJINCKLHB(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(43);
		}
		IFENGKHOKPC().RPC("EditMenu", JHOEDACNNKK, new object[1]);
	}

	public void DBJBPPHHIOE()
	{
		isReady = ((BBGIDKNEGHD().GLFNAPCBIJP().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void KKIGGNBMKIL(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(55);
		}
		GMAHNPNHMFK().MDHAJGGHKMC("2", JHOEDACNNKK, new object[1]);
	}

	private void FFCCNPCMIMA()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("Beat Detected").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.CKDBDGFENAF("_Color_R", "EventData0DropDownList", null, true, false, 756f);
		Singleton<MultiplayerSystem>.Instance.DBALDPFKNJM();
	}

	public void Init()
	{
		Debug.Log("[LobbyPlayerElement] Created lpe for " + base.photonView.owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(base.photonView.owner.name));
		StartCoroutine(HJFDEEMKFDJ(jMMILEFMACB));
		CheckIsReady();
	}

	private IEnumerator JAKPGMDDEID(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private IEnumerator EMFNKMMGFDE(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	private void Update()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void AIFJPAPJEIM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("EventTimeInputField");
		JBNINCMJAIG();
	}

	private void LFBGJIIECLD()
	{
		if (!DJHCJIJAIJP().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1875f, 947f, 1343f);
			PBBDHIFJHHC();
		}
	}

	public void LHAENMGOBMM()
	{
		Debug.Log("string" + EOOCGIFFKBG().GLFNAPCBIJP().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(IJBFILBDGDO().owner.name));
		StartCoroutine(LPICKOCJNGJ(jMMILEFMACB));
		JEPEHKGNDHA();
	}

	private void LCOBDKKAGHH()
	{
	}

	private void HNNKIOHCDKG()
	{
	}

	public void BOBDANOFGAE()
	{
		isReady = ((EDIJKHEMPAD().owner.GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void ONIHOJPDODD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PEGNCEOFBNF(AAMNKPHHHCI().GLFNAPCBIJP());
		}
	}

	private IEnumerator DINCBFHEPAL(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
	}

	public void EKOAKKNGGGI()
	{
		Debug.Log("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used." + CIACEFBNDDJ().GLFNAPCBIJP().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(IJBFILBDGDO().GLFNAPCBIJP().name));
		StartCoroutine(EJILOCLBCFK(jMMILEFMACB));
		JDAMDEHHGAG();
	}

	public void KPMNAOLGHED(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(108);
		}
		OELHGNKAMEG().MDHAJGGHKMC("inventory.selected.", JHOEDACNNKK, new object[0]);
	}

	public void GGGNMENIEAE(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("CameraFilterPack_WaterDrop");
		DAPMMOCIFJA();
	}
}
