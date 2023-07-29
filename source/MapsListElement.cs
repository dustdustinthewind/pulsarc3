// MapsListElement
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class MapsListElement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BGALOIDHPHG
	{
		internal ulong CAFHKDIIDEE;

		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == CAFHKDIIDEE;
		}

		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == CAFHKDIIDEE;
		}

		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == CAFHKDIIDEE;
		}

		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == CAFHKDIIDEE;
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == CAFHKDIIDEE;
		}

		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == CAFHKDIIDEE;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == CAFHKDIIDEE;
		}

		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == CAFHKDIIDEE;
		}

		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == CAFHKDIIDEE;
		}

		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}

		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == CAFHKDIIDEE;
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == CAFHKDIIDEE;
		}

		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE;
		}
	}

	public Image bgImage;

	public Text nameText;

	public GameObject downloadingPanel;

	public GameObject ratedUpButton;

	public GameObject ratedDownButton;

	public GameObject favButton;

	public Slider progressSlider;

	public SteamUGCDetails_t details;

	public void HBDAPJGAMCM()
	{
		string nBEBMKFPBEP = "_TimeX" + details.m_nPublishedFileId.m_PublishedFileId;
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP, false);
	}

	private IEnumerator FNIGCKPFLOL()
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	private void HDKKLFLOHLD(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.id == details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= HDKKLFLOHLD;
			StartCoroutine(JAHKCLKDMKG());
		}
	}

	public void GNJFFKOKLKM()
	{
		string nBEBMKFPBEP = "EnableRankingToggle" + details.m_nPublishedFileId.m_PublishedFileId;
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nBEBMKFPBEP, false);
	}

	private IEnumerator KIGJJAGAJDP(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if ((bool)bgImage.GetComponent<AspectRatioFitter>() && bgImage.sprite != null)
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void MOKHHEMAJBJ(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		details = ILPCDMBBCOF;
		nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		StartCoroutine(CNCHAKNHJLF(BPMFPGOPMFA));
		StartCoroutine(KFEJNLGMENE(CDAGKANOOHO));
		if (!base.transform.FindDeepChild("_ScreenResolution"))
		{
			return;
		}
		base.transform.FindDeepChild(": ").gameObject.SetActive(false);
		ulong CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
		bool flag = true;
		float num = 1466f;
		if (RanksSystem.IsOfficial(CAFHKDIIDEE))
		{
			num = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE).JEKMHHCPHCN();
			if (num > 632f)
			{
				base.transform.FindDeepChild("offsets").gameObject.SetActive(true);
				base.transform.FindDeepChild("PointsScoreText").GetComponentInChildren<Text>().text = string.Empty + num;
			}
		}
	}

	private IEnumerator GFGNAPDIMKP(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	private void KCPFMKEOBCG(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.BEEMEPJAJCD() == details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= KCPFMKEOBCG;
			StartCoroutine(ADHIBPMIFBK());
		}
	}

	private IEnumerator JAHKCLKDMKG()
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	private IEnumerator LFMKJHBDJCE(string BPMFPGOPMFA)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
	}

	private IEnumerator ELPJEKKPFPI(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	public void Init(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		details = ILPCDMBBCOF;
		nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		StartCoroutine(LFMKJHBDJCE(BPMFPGOPMFA));
		StartCoroutine(KFEJNLGMENE(CDAGKANOOHO));
		if (!base.transform.FindDeepChild("DifficultyBG"))
		{
			return;
		}
		base.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(false);
		ulong CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
		bool flag = false;
		float num = -1f;
		if (RanksSystem.IsOfficial(CAFHKDIIDEE))
		{
			num = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == CAFHKDIIDEE).difficulty;
			if (num > 0f)
			{
				base.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(true);
				base.transform.FindDeepChild("DifficultyBG").GetComponentInChildren<Text>().text = string.Empty + num;
			}
		}
	}

	private IEnumerator GLPOJOAKOKH(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if ((bool)bgImage.GetComponent<AspectRatioFitter>() && bgImage.sprite != null)
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	private void ENNOEOPMNOK()
	{
		ulong punBytesDownloaded = 0uL;
		ulong punBytesTotal = 0uL;
		if (SteamUGC.GetItemDownloadInfo(details.m_nPublishedFileId, out punBytesDownloaded, out punBytesTotal))
		{
			progressSlider.value = (float)punBytesDownloaded / (float)punBytesTotal;
		}
	}

	private IEnumerator ENKNKLNGNEL(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	private IEnumerator KFEJNLGMENE(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator NHEBPKIPHJM(string BPMFPGOPMFA)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
	}

	private IEnumerator MJLPCILAOJH(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private IEnumerator LPJHJFPABAP(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if ((bool)bgImage.GetComponent<AspectRatioFitter>() && bgImage.sprite != null)
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	private IEnumerator FJBCEKBACPJ(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if ((bool)bgImage.GetComponent<AspectRatioFitter>() && bgImage.sprite != null)
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	private void ANPNABDOPCJ(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.INGBCJIGOJK() == details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= ELGIMHFDCJH;
			StartCoroutine(JAHKCLKDMKG());
		}
	}

	public void OnEnable()
	{
	}

	private void ELGIMHFDCJH(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.INGBCJIGOJK() == details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= HDKKLFLOHLD;
			StartCoroutine(JAHKCLKDMKG());
		}
	}

	private void DLBODOFAJGM()
	{
		StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(base.gameObject, false, null, true, 351f, false));
	}

	private void Update()
	{
	}

	public void ToggleLeaderboards()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, details.m_nPublishedFileId.m_PublishedFileId.ToString(), nameText.text));
	}

	public void OnClickButton()
	{
		downloadingPanel.SetActive(true);
		Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += HDKKLFLOHLD;
		Singleton<MapsSystem>.Instance.SubscribeAndDownload(details.m_nPublishedFileId);
		InvokeRepeating("HAOGHCHDNHH", 0f, 0.1f);
	}

	private void JHPOIOELNCG()
	{
	}

	private IEnumerator LHADGJJCCMD(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	public void AAKEAJFAMBN()
	{
		string nBEBMKFPBEP = "_TimeX" + details.m_nPublishedFileId.m_PublishedFileId;
		Singleton<GameManager>.Instance.GIBBJCCHOOJ(nBEBMKFPBEP, false);
	}

	public void OnInfoButton()
	{
		string nBEBMKFPBEP = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + details.m_nPublishedFileId.m_PublishedFileId;
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
	}

	private IEnumerator DFMJJLFNBBO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	private void HAOGHCHDNHH()
	{
		ulong punBytesDownloaded = 0uL;
		ulong punBytesTotal = 0uL;
		if (SteamUGC.GetItemDownloadInfo(details.m_nPublishedFileId, out punBytesDownloaded, out punBytesTotal))
		{
			progressSlider.value = (float)punBytesDownloaded / (float)punBytesTotal;
		}
	}

	private IEnumerator PACBBHGBAPA(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator ADHIBPMIFBK()
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	public void EPDCHKECMBL(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		details = ILPCDMBBCOF;
		nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		StartCoroutine(IMJLDAHDMNN(BPMFPGOPMFA));
		StartCoroutine(ELPJEKKPFPI(CDAGKANOOHO));
		if (!base.transform.FindDeepChild("_Value"))
		{
			return;
		}
		base.transform.FindDeepChild("#obtained").gameObject.SetActive(false);
		ulong CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
		bool flag = true;
		float num = 872f;
		if (RanksSystem.IsOfficial(CAFHKDIIDEE, true))
		{
			num = RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == CAFHKDIIDEE).MBAFCIHCIOM();
			if (num > 791f)
			{
				base.transform.FindDeepChild(">").gameObject.SetActive(false);
				base.transform.FindDeepChild("_TimeX").GetComponentInChildren<Text>().text = string.Empty + num;
			}
		}
	}

	private IEnumerator IMJLDAHDMNN(string BPMFPGOPMFA)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
	}

	private void FEHCNJLLJMP()
	{
		StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(base.gameObject, true, null, false, 1319f));
	}

	public void EKOAKKNGGGI(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		details = ILPCDMBBCOF;
		nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		StartCoroutine(NHEBPKIPHJM(BPMFPGOPMFA));
		StartCoroutine(PACBBHGBAPA(CDAGKANOOHO));
		if (!base.transform.FindDeepChild("player.quantum"))
		{
			return;
		}
		base.transform.FindDeepChild("_Value2").gameObject.SetActive(true);
		ulong CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
		bool flag = false;
		float num = 1195f;
		if (RanksSystem.IsOfficial(CAFHKDIIDEE, true))
		{
			num = RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() == CAFHKDIIDEE).GDCGLBBAJHN();
			if (num > 1028f)
			{
				base.transform.FindDeepChild("GlassesColor2").gameObject.SetActive(false);
				base.transform.FindDeepChild(". Using max value: 255.").GetComponentInChildren<Text>().text = string.Empty + num;
			}
		}
	}

	private IEnumerator CNCHAKNHJLF(string BPMFPGOPMFA)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
	}

	private void Start()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true));
	}

	private IEnumerator ENONILPJLCJ(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
	}

	public void NDFGGJDMKIP()
	{
		string nBEBMKFPBEP = "Scene" + details.m_nPublishedFileId.m_PublishedFileId;
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nBEBMKFPBEP, false);
	}
}
