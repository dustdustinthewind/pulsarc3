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

	public void HBIGOLEEFNH()
	{
		isReady = ((IBKCMBIGOEJ().owner.GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void BDMCMMCNMLL()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(JAEJDHHCJJO().JJFEGIOPFGN().name));
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("The given 2D texture ") + cSteamID.m_SteamID, false);
	}

	public void DAJMBLIMCNM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_ScreenResolution");
		ODNIPBPNKIN();
	}

	public void OpenProfile()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(base.photonView.owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + cSteamID.m_SteamID);
	}

	public void NJDAJMNCPIA()
	{
		isReady = EOOCGIFFKBG().JFCKAGHNNCA().GetTeam() == PunTeams.Team.none && false;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().FDNCEFHNLNJ();
	}

	private void EFJDNLGNACH()
	{
		if (!GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(475f, 1090f, 300f);
			Init();
		}
	}

	private void EMKJHNGDAAP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("LeaderboardsButton").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP("SpawnObj", "[MapEditor] Importing map: ", null, true, false, 126f);
		Singleton<MultiplayerSystem>.Instance.HCIFGHPJKIB();
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

	public void EAJPNBCLAEO(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("GlassDistortion");
		ONIACAFDJNP();
	}

	private void JILOMOBDPIA()
	{
		if (!EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(478f, 1470f, 1060f);
			JLMPMMFKJID();
		}
	}

	private void Update()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void BKLCHHKOMLD()
	{
		Debug.Log("yesterday" + GBHNDHLAJLI().JFCKAGHNNCA().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(OELHGNKAMEG().JFCKAGHNNCA().name));
		StartCoroutine(BAMOGGMGKEF(jMMILEFMACB));
		HBIGOLEEFNH();
	}

	public void ODNIPBPNKIN()
	{
		isReady = ((FFIPLLNKGEN().JFCKAGHNNCA().GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void FIDKCPFLHEB()
	{
		isReady = ((EOOCGIFFKBG().JFCKAGHNNCA().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	private void JCCIIGINOIE()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("CameraFilterPack_TV_HorrorFX").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("settings.arcsdestroydelay", "#", null, true, false, 1701f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	public void DNGHDPKGDIC()
	{
		if (PhotonNetwork.isMasterClient)
		{
			IHPEKIKCFBL(IBKCMBIGOEJ().owner);
		}
	}

	public void CCPBGHOPKEK(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Intensity");
		FIDKCPFLHEB();
	}

	public void MLFFFAEIOMM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Value7");
		FIDKCPFLHEB();
	}

	public void CGLAPGFGBFL(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("SetCrosshairEmission");
		JOAONIBIKNM();
	}

	private IEnumerator PPEADOFJLAD(CSteamID JMMILEFMACB)
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

	public void AMFKMGPDBHI(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(116);
		}
		JAEJDHHCJJO().DPLELHEFMBE("_MainTex2", JHOEDACNNKK, new object[0]);
	}

	private void NBGIMIDICKE()
	{
		if (!EOOCGIFFKBG().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(543f, 447f, 1920f);
			Init();
		}
	}

	public void KickPlayer()
	{
		if (PhotonNetwork.isMasterClient)
		{
			SendKickPlayer(base.photonView.owner);
		}
	}

	public void CheckIsReady()
	{
		isReady = ((base.photonView.owner.GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void EKLHKNMCPNC()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AIIHFEFLHFE(GBHNDHLAJLI().JFCKAGHNNCA());
		}
	}

	private void GMELGGJOPBB()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private void ILCFPCIPENO()
	{
		if (!CIACEFBNDDJ().KCAOJFPDEIP())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1855f, 8f, 1133f);
			POGJLIDHDIH();
		}
	}

	public void ACLBOKCIAAD(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-93);
		}
		EOOCGIFFKBG().PLMAEOHKJPN("IncorrectHitsScoreText", JHOEDACNNKK, new object[1]);
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

	private IEnumerator BAMOGGMGKEF(CSteamID JMMILEFMACB)
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

	private void AAPMAEFHKEO()
	{
	}

	public void NKLCNJEIAFB()
	{
		Debug.Log("curScn" + IBKCMBIGOEJ().JFCKAGHNNCA().name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(EOOCGIFFKBG().JFCKAGHNNCA().name));
		StartCoroutine(EHGNFNCJCMM(jMMILEFMACB));
		CheckIsReady();
	}

	private void DKOPKPBLDHH()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1354f, 1231f, 772f);
			MDPJHKECLOF();
		}
	}

	public void IHPEKIKCFBL(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-5);
		}
		base.photonView.KACECEKIPPP("_Value2", JHOEDACNNKK, new object[0]);
	}

	public void EAEPPHAHJBP(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_TimeX");
		EPHNJNLKJLP();
	}

	private void IEMEHGCFAPD()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private void IBEAPBDAOCC()
	{
	}

	private IEnumerator DEFNIIHFKFA(CSteamID JMMILEFMACB)
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

	private void PDHKMDBNGGN()
	{
		if (!IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(213f, 514f, 327f);
			BKLCHHKOMLD();
		}
	}

	private void KLJGNMLPBIG()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("_TimeX").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM("SetParticlesCountPerBeat", "_Value6", null, true, true, 125f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	public void BPDDHMICEBP()
	{
		isReady = CIACEFBNDDJ().JJFEGIOPFGN().GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	public void ANLGHGCGAGP()
	{
		if (PhotonNetwork.isMasterClient)
		{
			IHPEKIKCFBL(base.photonView.JFCKAGHNNCA());
		}
	}

	public void JPEHBKGOBJN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AMFKMGPDBHI(CIACEFBNDDJ().owner);
		}
	}

	public void LHIEKHPLMFI()
	{
		Debug.Log("CameraFilterPack/Light_Water2" + GMAHNPNHMFK().JJFEGIOPFGN().name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(OELHGNKAMEG().JFCKAGHNNCA().name));
		StartCoroutine(EHGNFNCJCMM(jMMILEFMACB));
		ODNIPBPNKIN();
	}

	private void OKHGJFFIIBA()
	{
	}

	private void PFEKDDLJMHJ()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("maps.").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("_Value4", "_Value", null, true, true, 1959f);
		Singleton<MultiplayerSystem>.Instance.LCJPNOIOLGJ();
	}

	public void GGHCMPKGNGE()
	{
		Debug.Log("_BaseTex" + GMAHNPNHMFK().JJFEGIOPFGN().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(AAMNKPHHHCI().JFCKAGHNNCA().name));
		StartCoroutine(BAMOGGMGKEF(jMMILEFMACB));
		AMCKGGMDLDB();
	}

	private IEnumerator LAGBNPIFBPL(CSteamID JMMILEFMACB)
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

	public void GDJMBJEAPHM()
	{
		Debug.Log("_ColorRGB" + IBKCMBIGOEJ().JFCKAGHNNCA().name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(GMAHNPNHMFK().JJFEGIOPFGN().name));
		StartCoroutine(AGEDFEIDJIF(jMMILEFMACB));
		ODNIPBPNKIN();
	}

	public void JMCLAGKENHN()
	{
		isReady = ((GBMJAPGLMGB().owner.GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().FDNCEFHNLNJ();
	}

	private void HHODKHPIBLG()
	{
	}

	public void AOCOABCDFKA()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(IBKCMBIGOEJ().JFCKAGHNNCA().name));
		Singleton<GameManager>.Instance.GIBBJCCHOOJ(Singleton<GameManager>.Instance.CreateServerURL("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.") + cSteamID.m_SteamID);
	}

	public void MLIBNJPMOHK(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(105);
		}
		base.photonView.OKHNMAMFDFD("_Value", JHOEDACNNKK, new object[0]);
	}

	private void PBEPCAPAKLG()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void AIIHFEFLHFE(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(13);
		}
		BLMHOKPIMOD().PLMAEOHKJPN("_History3Weight", JHOEDACNNKK, new object[1]);
	}

	public void CPFOEFKOJGA()
	{
		Debug.Log("_CameraClipInfo" + GMAHNPNHMFK().JJFEGIOPFGN().name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().JFCKAGHNNCA().name));
		StartCoroutine(DEFNIIHFKFA(jMMILEFMACB));
		AMCKGGMDLDB();
	}

	public void ACPGLLCAEJJ(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("GlassDistortion");
		EPHNJNLKJLP();
	}

	public void KMNLLCOGHPM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("CameraFilterPack/FX_DarkMatter");
		FIDKCPFLHEB();
	}

	private void OnEnable()
	{
	}

	private void NDAJBJFJGCF()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void POGJLIDHDIH()
	{
		Debug.Log("_ScreenResolution" + CIACEFBNDDJ().owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().owner.name));
		StartCoroutine(AGEDFEIDJIF(jMMILEFMACB));
		JOAONIBIKNM();
	}

	private void PAHNKEGFGHB()
	{
	}

	public void ONIACAFDJNP()
	{
		isReady = GBMJAPGLMGB().JFCKAGHNNCA().GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	private void OAKONCDEPPI()
	{
	}

	private IEnumerator EHGNFNCJCMM(CSteamID JMMILEFMACB)
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

	private void BBKMHAFFIMD()
	{
	}

	public void PDMHGJNBOKA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(37);
		}
		ACPGHFHDCIP().OKHNMAMFDFD("_SphereSize", JHOEDACNNKK, new object[1]);
	}

	public void Init()
	{
		Debug.Log("[LobbyPlayerElement] Created lpe for " + base.photonView.owner.name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(base.photonView.owner.name));
		StartCoroutine(HJFDEEMKFDJ(jMMILEFMACB));
		CheckIsReady();
	}

	private void LNIOFCGDDKP()
	{
	}

	public void LPHFBIAFHIM(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-35);
		}
		IBKCMBIGOEJ().PLMAEOHKJPN("Instrumental", JHOEDACNNKK, new object[0]);
	}

	public void MDPJHKECLOF()
	{
		Debug.Log("_PColor" + BLMHOKPIMOD().JFCKAGHNNCA().name);
		isReady = false;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(ACPGHFHDCIP().JFCKAGHNNCA().name));
		StartCoroutine(EHGNFNCJCMM(jMMILEFMACB));
		NJDAJMNCPIA();
	}

	public void GCNKIJDNPMD()
	{
		Debug.Log("/icon" + FFIPLLNKGEN().JFCKAGHNNCA().name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(GBMJAPGLMGB().JJFEGIOPFGN().name));
		StartCoroutine(HJFDEEMKFDJ(jMMILEFMACB));
		HBIGOLEEFNH();
	}

	private void JDGFCEPDKAJ()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	private IEnumerator AGEDFEIDJIF(CSteamID JMMILEFMACB)
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

	public void LLJNCICEJCG(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log(".highscore");
		HBIGOLEEFNH();
	}

	private void PLNLNCDPPGG()
	{
	}

	private void BMODOIJGIOO()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void FFEPLLMAACJ(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("pointBuffer");
		FIDKCPFLHEB();
	}

	[PunRPC]
	public void OnReadyClick(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("[LobbyPlayerElement] On ready click");
		CheckIsReady();
	}

	public void JLMPMMFKJID()
	{
		Debug.Log("CameraFilterPack/FX_Hexagon" + EOOCGIFFKBG().owner.name);
		isReady = true;
		CSteamID jMMILEFMACB = new CSteamID(ulong.Parse(BLMHOKPIMOD().JFCKAGHNNCA().name));
		StartCoroutine(MJFFOILDAMG(jMMILEFMACB));
		ODNIPBPNKIN();
	}

	public void SendKickPlayer(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(23);
		}
		base.photonView.RPC("KickThePlayer", JHOEDACNNKK);
	}

	public void IBLBIFMFFOP()
	{
		CSteamID cSteamID = new CSteamID(ulong.Parse(EOOCGIFFKBG().owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("Set Satellite Lerp Speed") + cSteamID.m_SteamID, false);
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

	public void FPLIFINHHIN(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(76);
		}
		BLMHOKPIMOD().OILIKMGIHFL("Image", JHOEDACNNKK, new object[0]);
	}

	public void JOAONIBIKNM()
	{
		isReady = GMAHNPNHMFK().owner.GetTeam() == PunTeams.Team.none || true;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	public void DCAIMAJDBHL(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Value2");
		EPHNJNLKJLP();
	}

	private void OCHMKJKBAPI()
	{
	}

	private void DDBOODLPCAM()
	{
		readyCanvas.SetActive(isReady);
		removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	public void EPHNJNLKJLP()
	{
		isReady = ((OELHGNKAMEG().JJFEGIOPFGN().GetTeam() == PunTeams.Team.none) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	public void AMCKGGMDLDB()
	{
		isReady = ((EDIJKHEMPAD().JJFEGIOPFGN().GetTeam() != 0) ? true : false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	public void BMOFBBJDOPM()
	{
		if (PhotonNetwork.isMasterClient)
		{
			SendKickPlayer(FFIPLLNKGEN().JJFEGIOPFGN());
		}
	}

	public void HIELBNIEKIH(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("EventTimeInputField");
		AMCKGGMDLDB();
	}

	private void PKLOBJHKFEO()
	{
		if (!FFIPLLNKGEN().BGJKMGJBPFA())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1644f, 1436f, 964f);
			LHIEKHPLMFI();
		}
	}

	private IEnumerator MJFFOILDAMG(CSteamID JMMILEFMACB)
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

	private void EJDACNFJPFK()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("<scene_name> or <id>").gameObject.SetActive(true);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("id", "CameraFilterPack/RainFX", null, true, false, 1270f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	private void JBJNGOGGDMP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("B").gameObject.SetActive(false);
		Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("Share", "_TimeX", null, false, false, 244f);
		Singleton<MultiplayerSystem>.Instance.APEDOOJPKFC();
	}

	public void KOJLLDBMPJB()
	{
		if (PhotonNetwork.isMasterClient)
		{
			LPHFBIAFHIM(EDIJKHEMPAD().JJFEGIOPFGN());
		}
	}

	public void GBBBHJHBOFH()
	{
		isReady = ACPGHFHDCIP().owner.GetTeam() == PunTeams.Team.none && false;
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}
}
