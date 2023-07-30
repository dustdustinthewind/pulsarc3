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

	private IEnumerator LFMKJHBDJCE()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.iconFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true));
		StartCoroutine(KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
	}

	public void IMDKPJMICEN()
	{
		StartCoroutine(OELPBKBAEAL(fullLevelData.mapperSteamID));
	}

	public void GLFJKOFEAFI(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("GlassDistortion", 0);
		}
		SceneManager.LoadScene("player.goldwatermelon");
	}

	public void GAIOOLFFAFI()
	{
		if (fullLevelData.DMMJJIHALHJ())
		{
			Singleton<MapsListSelector>.Instance.GIKJIFGFMFP(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData), true);
		}
	}

	public void KIMMMCJFMAB()
	{
		GJILIJALJLE();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(base.gameObject, false, null, false, 815f));
	}

	public void LoaderPanelOnButton(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.resetlevelcheckpoint", 1);
		}
		SceneManager.LoadScene("GameScene");
	}

	public void LINJPJHADKL()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("_Value"))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find(". Prefab must have a PhotonView component."))
			{
				GameObject.Find("BloodAlternative3").GetComponent<AudioSampler>().isMuted = false;
			}
		}
		catch (Exception)
		{
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

	public void OnClick()
	{
		if (fullLevelData.isUnlocked())
		{
			Singleton<MapsListSelector>.Instance.Close(Singleton<MapsSystem>.Instance.GetMapID(fullLevelData));
		}
	}

	public void NFKCMJBAMCO()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(false);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void OnRateClick()
	{
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

	private IEnumerator BJHCAKIFFKM(Sprite EOGBJKCLGLP)
	{
		yield return StartCoroutine(DFMJJLFNBBO(bgImage, 0f, 0.1f));
		bgImage.sprite = EOGBJKCLGLP;
		if (bgImage.sprite != null && (bool)bgImage.GetComponent<AspectRatioFitter>())
		{
			bgImage.GetComponent<AspectRatioFitter>().aspectRatio = bgImage.sprite.rect.size.x / bgImage.sprite.rect.size.y;
		}
		yield return StartCoroutine(ENONILPJLCJ(bgImage, 1f, 0.1f));
	}

	public void ADMLEIMBMEC(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.AddToFavorite(fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.HKKCNIPFIGF(fullLevelData);
			}
		}
	}

	private IEnumerator HNKBKCBDNBG()
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

	private IEnumerator JINABPAAGGF()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true));
		audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSource.loop = true;
		audioSource.Play();
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

	private IEnumerator LHDMFCOEDBI()
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

	public void Update()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic"))
		{
			audioSource.volume = Mathf.Lerp(audioSource.volume, isSelected ? 1 : 0, Time.deltaTime * 10f);
		}
	}

	public void GDKEOJGALGK()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(true);
		leaderboardsCanvas.SetActive(true);
		PICNOPDLFBE();
		InitRateButton();
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

	public void GJILIJALJLE()
	{
		StartCoroutine(OELPBKBAEAL(fullLevelData.mapperSteamID));
	}

	public void ToggleInfo()
	{
		infoCanvas.SetActive(!infoCanvas.activeSelf);
		leaderboardsCanvas.SetActive(false);
		rateCanvas.SetActive(false);
	}

	public void CAAAHJLFLAA()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(true);
		leaderboardsCanvas.SetActive(true);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void PJLLNMAGOKD()
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("SpeedSlider"))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("Tab1Content"))
			{
				GameObject.Find("VIGNETTE_BLUR").GetComponent<AudioSampler>().isMuted = false;
			}
		}
		catch (Exception)
		{
		}
	}

	public void LDJHKLEOKHI()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
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

	public void LoadMapperNickname()
	{
		StartCoroutine(KFEJNLGMENE(fullLevelData.mapperSteamID));
	}

	private IEnumerator LIJGPLNBHPM(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
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

	private IEnumerator CKIALMMHMDO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void PCEDKMKCPEH(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(108);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(fullLevelData.workshopId)] = (NHLFMIIGBEB ? 1 : (-1));
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(fullLevelData.workshopId), NHLFMIIGBEB);
		InitRateButton();
		PICNOPDLFBE();
		rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(fullLevelData.workshopId), (!NHLFMIIGBEB) ? (-1) : 0);
		}
	}

	private void PICNOPDLFBE()
	{
		rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == 1;
		rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(fullLevelData.workshopId)) == -1;
	}

	public void ToggleRate()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		infoCanvas.SetActive(false);
		leaderboardsCanvas.SetActive(false);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void ToggleLeaderboards()
	{
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, fullLevelData.workshopId));
	}

	public void JPJNNKKAAMB()
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("."))
		{
			return;
		}
		isSelected = false;
		try
		{
			audioSource.Pause();
			if ((bool)GameObject.Find("_Value5"))
			{
				GameObject.Find("_TimeX").GetComponent<AudioSampler>().isMuted = true;
			}
		}
		catch (Exception)
		{
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

	private IEnumerator GODGBCHIOPF()
	{
		string fullName = new FileInfo(fullLevelData.fullLevelPath + "/" + fullLevelData.mapData.musicFile).FullName;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true));
		audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		audioSource.loop = true;
		audioSource.Play();
	}

	private IEnumerator OELPBKBAEAL(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	private IEnumerator NDLBAHDJIOC(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	private IEnumerator CCMGHILHJAB(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if ((bool)base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + empty;
		}
	}

	public void OnLoaderPanelCansel()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
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

	public void JCIOCBELAMD()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void DNNFHBOOPIN()
	{
		LoadMapperNickname();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(base.gameObject, true, null, true, 1846f, false));
	}

	public void Start()
	{
		LoadMapperNickname();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true));
	}

	public void IDIIELPAMCJ()
	{
		if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO("SetSatelliteRadius"))
		{
			audioSource.volume = Mathf.Lerp(audioSource.volume, (!isSelected) ? 0 : 0, Time.deltaTime * 1017f);
		}
	}

	public void KGFAFLHADBC()
	{
		if (Singleton<SaveSystem>.Instance.OHIBODCDDKB("mapselector.filter.favoriteonly") && fullLevelData.DMMJJIHALHJ())
		{
			if (audioSource.clip == null)
			{
				StartCoroutine(GODGBCHIOPF());
			}
			if (!audioSource.isPlaying)
			{
				audioSource.UnPause();
			}
			isSelected = true;
			if ((bool)GameObject.Find("(\\[ *quote *\\])"))
			{
				GameObject.Find("SSAARenderTargetCamera").GetComponent<AudioSampler>().isMuted = false;
			}
		}
	}

	public void POKAEGMGDIO()
	{
		if (fullLevelData.source == FullMapData.MapSource.Editor)
		{
			StartCoroutine(HNKBKCBDNBG());
		}
		if (fullLevelData.source == (FullMapData.MapSource)5)
		{
			StartCoroutine(HJCOEFEPNFH());
		}
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

	public void CNGAJDBOCLJ()
	{
		GJILIJALJLE();
		StartCoroutine(LFMKJHBDJCE());
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(base.gameObject, false, null, true, 405f, false));
	}

	private IEnumerator MOECEKHPOGO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	public void MMBPLGGLPDB()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("_AdaptationSpeed"))
		{
			audioSource.volume = Mathf.Lerp(audioSource.volume, (!isSelected) ? 0 : 0, Time.deltaTime * 1668f);
		}
	}

	private IEnumerator GAAKMNIIPDF(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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
}
