// LevelsListElementButton
using System;
using System.Collections;
using System.IO;
using System.Linq;
using AudioVisualizer;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsListElementButton : MonoBehaviour
{
	public Image bgImage;

	public GameObject listMessage;

	public GameObject highscoresElement;

	public int launchLevelMode;

	public FullMapData fullLevelData;

	public GameObject infoCanvas;

	public GameObject rateCanvas;

	public GameObject leaderboardsCanvas;

	public GameObject lockedCanvas;

	public GameObject highscoresScrollRectContent;

	public GameObject loaderPanel;

	public GameObject rateButton;

	public GameObject ratedUpButton;

	public GameObject ratedDownButton;

	public GameObject favButton;

	public GameObject delButton;

	public GameObject moreInfoButton;

	public GameObject workshopButton;

	public AudioSource audioSource;

	public bool isSelected;

	public void JMNJAJNMIKP()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.ELNHNLCKKEC(0, fullLevelData.workshopId));
	}

	private IEnumerator AIJKGAHBBAO(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator PGPHLFGHGDF(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	private IEnumerator JHCBBBJIOKO(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	public void OLLODDJNDNP()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(FCGGOCIFBGJ());
		}
		if (fullLevelData.source == (FullMapData.MapSource)6)
		{
			StartCoroutine(BNDIBFHNLHL());
		}
	}

	private IEnumerator HPFCCEJODMB(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void GFMKNEGNNJI()
	{
		if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) == 1)
		{
			rateButton.SetActive(false);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
		}
	}

	public void ToggleRate()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(false);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void PFKOBNHHNIJ()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(1, fullLevelData.workshopId));
	}

	public void FNCDAPDOBBI()
	{
		OMMHCNMIIBJ();
		StartCoroutine(LLDAMHKJPJO());
		StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(base.gameObject, false, null, false, 245f));
	}

	public void OnRateClick()
	{
	}

	public void FOMDICJKGFK(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(-61);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(fullLevelData.workshopId)] = (NHLFMIIGBEB ? 1 : (-1));
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB);
		GFMKNEGNNJI();
		LMGOCLHHDJE();
		rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB ? 1 : (-1));
		}
	}

	public void OLIGPHDCCFK()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("StartButton"))
		{
			return;
		}
		isSelected = true;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("DPADHOR"))
			{
				GameObject.Find("GenerationMenu").GetComponent<AudioSampler>().isMuted = false;
			}
		}
		catch (Exception)
		{
		}
	}

	private IEnumerator OMBKMAKDOJF()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void NBGIMIDICKE()
	{
		GJILIJALJLE();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(base.gameObject, true, null, true, 859f, false));
	}

	private IEnumerator LBBDMDFOCIB(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void LDJHKLEOKHI()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void LLFLMHAJEEE()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(0, fullLevelData.workshopId));
	}

	private IEnumerator JEKGBBCOHLB(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator NOLIEIKFMAM(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private void EJBNPKIIHBO()
	{
		rateCanvas.transform.Find("CameraFilterPack_Blizzard1").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 || true;
		rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(fullLevelData.workshopId)) != -1 || true;
	}

	public void JNEAIMPPCIL()
	{
	}

	private IEnumerator HJCOEFEPNFH()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void NDPAAEIPFPJ()
	{
		if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) == 1)
		{
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
		}
	}

	private void LMGOCLHHDJE()
	{
		rateCanvas.transform.Find("_ForegroundBlurExtrude").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 1;
		rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) != -1;
	}

	public void HCOBFENJGAH()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1, fullLevelData.workshopId));
	}

	private IEnumerator LLDAMHKJPJO()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	private IEnumerator KHKCPKKMGHI()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	private IEnumerator KIGJJAGAJDP(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void OnItemRated(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(28);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(fullLevelData.workshopId)] = (NHLFMIIGBEB ? 1 : (-1));
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB);
		InitRateButton();
		PICNOPDLFBE();
		rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB ? 1 : (-1));
		}
	}

	private IEnumerator IJIEEOOPJOF()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true));
		audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSource.loop = true;
		audioSource.Play();
	}

	private IEnumerator EPAAPOAIIDH()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	private IEnumerator EDMLNOJLPIB(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void EMNHHKNHBHP(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("SupportLogger OnCreatedRoom(", 1);
		}
		SceneManager.LoadScene(".sav");
	}

	public void ODKLCECLCJI()
	{
		StartCoroutine(JEKGBBCOHLB(fullLevelData.mapperSteamID));
	}

	private IEnumerator NHFBEPDELCN(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void Start()
	{
		LoadMapperNickname();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true));
	}

	private IEnumerator MFEGJEEIJJP()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	private IEnumerator PLMNMDBEFIL(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void CAPDBMHNNAI()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void Update()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic"))
		{
			audioSource.volume = Mathf.Lerp(audioSource.volume, isSelected ? 1 : 0, Time.deltaTime * 10f);
		}
	}

	public void KPFNEJOCCGH()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void ToggleLeaderboards()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, fullLevelData.workshopId));
	}

	private void IBDHFBMDMCI()
	{
		rateCanvas.transform.Find(" - LOCAL").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == 1;
		rateCanvas.transform.Find("maps.").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) != -1 || true;
	}

	private IEnumerator BCLACJOIGHN(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void OnMouseEnter()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic") && fullLevelData.isUnlocked())
		{
			if (audioSource.clip == null)
			{
				StartCoroutine(JINABPAAGGF());
			}
			if (!audioSource.isPlaying)
			{
				audioSource.UnPause();
			}
			isSelected = true;
			if ((bool)GameObject.Find("AudioSampler"))
			{
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = true;
			}
		}
	}

	public void KAGMODFAFHP()
	{
		if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(true);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
		}
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

	public void InitRateButton()
	{
		if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 1)
		{
			rateButton.SetActive(false);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
		}
	}

	private IEnumerator GGCDOOOFLOO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void MAABEAPENIB()
	{
		infoCanvas.SetActive(infoCanvas.activeSelf);
		leaderboardsCanvas.SetActive(true);
		rateCanvas.SetActive(true);
	}

	public void MCHENMKMHJP(int JMMILEFMACB = 0)
	{
		string nBEBMKFPBEP = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nBEBMKFPBEP = fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 0)
		{
			nBEBMKFPBEP = "#no" + fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nBEBMKFPBEP, false);
	}

	public void LLPJNILPBBI()
	{
		if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
		}
	}

	public void GetMoreInfo(int JMMILEFMACB = 0)
	{
		string nBEBMKFPBEP = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nBEBMKFPBEP = fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 1)
		{
			nBEBMKFPBEP = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.OpenURL(nBEBMKFPBEP);
	}

	public void OnFavoriteClick(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.AddToFavorite(fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(fullLevelData);
			}
		}
	}

	public void LoadMapperNickname()
	{
		StartCoroutine(KFEJNLGMENE(fullLevelData.mapperSteamID));
	}

	private IEnumerator NGFEBAMIKGB(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void JPJKCAGJOBJ()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(0, fullLevelData.workshopId));
	}

	private IEnumerator JINABPAAGGF()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true));
		audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSource.loop = true;
		audioSource.Play();
	}

	public void DKHHJKMLHCE(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.BNIFKLGDHAB(fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(fullLevelData);
			}
		}
	}

	private IEnumerator PJGECKOENBF(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	private void MDMIDBOPEHG()
	{
		rateCanvas.transform.Find("5;6;7;8;11;12;18;19;20;22x6;44x1").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 1 && false;
		rateCanvas.transform.Find("Done!").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) != -1 || true;
	}

	public void OMMHCNMIIBJ()
	{
		StartCoroutine(AIJKGAHBBAO(fullLevelData.mapperSteamID));
	}

	private IEnumerator AEPCHPNAOCK()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	public void KLKGNPNONKE()
	{
		if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) == 0)
		{
			rateButton.SetActive(true);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == -1)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
		}
	}

	private IEnumerator FCGGOCIFBGJ()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	private IEnumerator HDFCPEOPJPE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void ADMLEIMBMEC(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.ECEOJLNJMHN(ulong.Parse(fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.AddToFavorite(fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(fullLevelData);
			}
		}
	}

	public void OnDeleteButton()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(POMLILLIBOI());
		}
		if (fullLevelData.source == FullMapData.MapSource.Workshop)
		{
			StartCoroutine(HJCOEFEPNFH());
		}
	}

	private IEnumerator IGJHCGJDLAI(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void OnMouseExit()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic"))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("AudioSampler"))
			{
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
			}
		}
		catch (Exception)
		{
		}
	}

	private IEnumerator GJGPECEMPOC()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void LHNMAOKJDMN()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(false);
		PICNOPDLFBE();
		KLKGNPNONKE();
	}

	public void PCJKNJMNOFI()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void NNDFGJPHOED()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	private void PICNOPDLFBE()
	{
		rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 1;
		rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == -1;
	}

	public void OnClick()
	{
		if (fullLevelData.isUnlocked())
		{
			Singleton<MapsListSelector>.Instance.Close(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
		}
	}

	public void OnLoaderPanelCansel()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void DGDOCOMJOEA()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(true);
		leaderboardsCanvas.SetActive(false);
		IBDHFBMDMCI();
		NDPAAEIPFPJ();
	}

	private IEnumerator DLIAPJONLNP(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator ADCEBLGIFGO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void PJLLNMAGOKD()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX"))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("_Value"))
			{
				GameObject.Find("_MainTex2").GetComponent<AudioSampler>().isMuted = false;
			}
		}
		catch (Exception)
		{
		}
	}

	public void CGOIDOPBBME()
	{
		StartCoroutine(JHCBBBJIOKO(fullLevelData.mapperSteamID));
	}

	public void KCLANECLPEB()
	{
	}

	public void DJPKDIGGEIM()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.LPJDKNPGGJN(0, fullLevelData.workshopId));
	}

	private IEnumerator LFMKJHBDJCE()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
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

	private IEnumerator BJMHHLGICPI()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true));
		audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSource.loop = true;
		audioSource.Play();
	}

	public void ToggleInfo()
	{
		infoCanvas.SetActive(!infoCanvas.activeSelf);
		leaderboardsCanvas.SetActive(false);
		rateCanvas.SetActive(false);
	}

	public void EGIEPENLHNG()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(1, fullLevelData.workshopId));
	}

	public void POKAEGMGDIO()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(KHKCPKKMGHI());
		}
		if (fullLevelData.source == (FullMapData.MapSource)6)
		{
			StartCoroutine(EIELMKBMEED());
		}
	}

	private IEnumerator CPDKINHDKOD()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void HJPCJGOEKMF()
	{
		ODKLCECLCJI();
		StartCoroutine(MFEGJEEIJJP());
		StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(base.gameObject, true, null, false, 476f));
	}

	public void FKODENGGPKG()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(true);
		MCFOJLKAACB();
		GFMKNEGNNJI();
	}

	public void GJILIJALJLE()
	{
		StartCoroutine(DLIAPJONLNP(fullLevelData.mapperSteamID));
	}

	public void NEMDLABDKDL(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Value4", 0);
		}
		SceneManager.LoadScene("Exit to Windows");
	}

	public void FKOMHOMCJBF()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(true);
		PICNOPDLFBE();
		NDPAAEIPFPJ();
	}

	public void NPGOHMPPPIE()
	{
	}

	public void MINEGHNIGCA(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.BNIFKLGDHAB(fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.ACIIHJJKNNC(fullLevelData);
			}
		}
	}

	public void LoaderPanelOnButton(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.resetlevelcheckpoint", 1);
		}
		SceneManager.LoadScene("GameScene");
	}

	public void DOJDNFEMCFE()
	{
		StartCoroutine(DLIAPJONLNP(fullLevelData.mapperSteamID));
	}

	public void BEOEODBNOIF()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(KHKCPKKMGHI());
		}
		if (fullLevelData.source == (FullMapData.MapSource)5)
		{
			StartCoroutine(EIELMKBMEED());
		}
	}

	public void MMCFPCEMPOA()
	{
		infoCanvas.SetActive(infoCanvas.activeSelf);
		leaderboardsCanvas.SetActive(false);
		rateCanvas.SetActive(true);
	}

	public void NBMHPDNDBLK(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(-89);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(fullLevelData.workshopId)] = ((!NHLFMIIGBEB) ? (-1) : 0);
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB);
		KAGMODFAFHP();
		EJBNPKIIHBO();
		rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB ? 1 : (-1));
		}
	}

	private IEnumerator BNDIBFHNLHL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void JILOMOBDPIA()
	{
		OMMHCNMIIBJ();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(base.gameObject, false, null, false, 1331f));
	}

	private IEnumerator BIBPGDOMNEC()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	public void CLJLAEIHJDG()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("challenges/"))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("_Vignetting2"))
			{
				GameObject.Find("\nCreated by Oxy949").GetComponent<AudioSampler>().isMuted = true;
			}
		}
		catch (Exception)
		{
		}
	}

	public void IOPHOLIFJEJ(int JMMILEFMACB = 0)
	{
		string nBEBMKFPBEP = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nBEBMKFPBEP = fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 1)
		{
			nBEBMKFPBEP = "Please attach component to a Graphical UI component" + fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.IEEHOAELCGE(nBEBMKFPBEP);
	}

	private IEnumerator POMLILLIBOI()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
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

	public void JMELOADCNNA()
	{
	}

	public void JKBMKPDGCHG()
	{
		DOJDNFEMCFE();
		StartCoroutine(LLDAMHKJPJO());
		StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(base.gameObject, false, null, true, 1067f));
	}

	private IEnumerator KNODHMNPLFA()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	public void AJCAPKJICFL()
	{
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("CameraFilterPack_Glasses_On2") && fullLevelData.MLDFFCPMHHF())
		{
			if (audioSource.clip == null)
			{
				StartCoroutine(IJIEEOOPJOF());
			}
			if (!audioSource.isPlaying)
			{
				audioSource.UnPause();
			}
			isSelected = true;
			if ((bool)GameObject.Find("maps."))
			{
				GameObject.Find("EventMenu").GetComponent<AudioSampler>().isMuted = false;
			}
		}
	}

	private IEnumerator CNFDOCLAIFD(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void HDMDKOKOOJC()
	{
		DOJDNFEMCFE();
		StartCoroutine(BIBPGDOMNEC());
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(base.gameObject, false, null, false, 1688f));
	}

	private IEnumerator AIEFPPMPFDN(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void GMBNFAHDCMA()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(true);
		LMGOCLHHDJE();
		KAGMODFAFHP();
	}

	public void KBAEFDAIHON()
	{
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("colorC") && fullLevelData.OKMHKMIOAOL())
		{
			if (audioSource.clip == null)
			{
				StartCoroutine(IJIEEOOPJOF());
			}
			if (!audioSource.isPlaying)
			{
				audioSource.UnPause();
			}
			isSelected = true;
			if ((bool)GameObject.Find("_Value2"))
			{
				GameObject.Find("RPC: 'OnAwakeRPC' PhotonView: ").GetComponent<AudioSampler>().isMuted = false;
			}
		}
	}

	private IEnumerator OBICOFEAIAJ()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	private IEnumerator EIELMKBMEED()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).OnExitButton();
				((GameScene)Singleton<Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
	}

	public void IMJKKFLAEFF()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(true);
		leaderboardsCanvas.SetActive(false);
		MCFOJLKAACB();
		InitRateButton();
	}

	private void MCFOJLKAACB()
	{
		rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 || true;
		rateCanvas.transform.Find("_Value").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(fullLevelData.workshopId)) != -1 || true;
	}

	public void JMEOGJHCONJ()
	{
		LoadMapperNickname();
		StartCoroutine(MFEGJEEIJJP());
		StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(base.gameObject, false, null, false, 1621f, false));
	}

	public void MDKEGDLADCD()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(GJGPECEMPOC());
		}
		if (fullLevelData.source == (FullMapData.MapSource)8)
		{
			StartCoroutine(EIELMKBMEED());
		}
	}
}
