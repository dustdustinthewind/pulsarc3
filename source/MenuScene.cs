// MenuScene
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using AudioVisualizer;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using UnityStandardAssets.ImageEffects;

public class MenuScene : Scene
{
	[Serializable]
	public enum Socials
	{
		Twitch,
		Discord,
		VK,
		Reddit,
		BugTracker
	}

	[CompilerGenerated]
	private sealed class MIPBPLJOKPD
	{
		internal Resolution BBGBGFFPGDN;

		internal bool BDGDIDPDBHG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BJMAIJDIKCN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LJDLIIIPIIJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FDAIFOAGDLA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool PIJAOCFAPKC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FCAGEDLBBHD(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BKNHHGBPLGH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool JBCHBMKPDAJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool JKEDCEOCPJO(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LHHFJBIAHCN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool KFNBKFELFLH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LOEAMHGMMPK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FHIJCPPECHA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AEINPAGJFME(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool DKGPCPBNDPK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BFEABMIFIEE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BMAOCLKPNNC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FMIHBNPKEEO(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool MGENGAEDACG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BEBAENEJFLD(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool HBJFIOJFBHC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool JBAJEMGOPDL(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool MEMPOPNAEDN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FFEGPHJKMFK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool DNIMHEKGJHB(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AGJKEBOPIOC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool KGKMOLCPDIH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool EFAPFFFGOOA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AEIFJLBBKBP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool OFLDIMDDLHM(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool GBKBDKHPLKG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool DBFPGFHEGKA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool EDGAPOPEIJF(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FHFECFLBHMA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FJDBPPKABJE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool OLIGLEMPFOP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool PBCAHKDLFPE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool IGFOBPKFCDJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LLNDDFGPOPL(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool EKHOOPGPPGE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool FIPCLHEKKCA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool OFHCGKJFGDI(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool PKAPLCFHDOC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool OMBHIBNMFNB(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AGFDCBCBAGI(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AKDOOLPMPMG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LNDGINDKPFA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool INHOEMCLAAP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool JDELIMPGFDJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool EGKGJJGAPMN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}
	}

	public Text challengetText;

	public GameObject sun;

	public GameObject pressAnyKeyCanvas;

	public GameObject mainMenuCanvas;

	public GameObject newsTile;

	public GameObject newItemsCanvas;

	public GameObject newItemsListContent;

	public GameObject inventoryGroupsContent;

	public GameObject inventoryGroupElement;

	public GameObject tipsListContent;

	public GameObject tipsListElement;

	public TipsListElement tip;

	public float playerDistance = 14f;

	public AudioSampler asampler;

	public UnityEvent OnLoaded;

	public UnityEvent OnPressAnyKey;

	public UnityEvent OnPressAnyKeyFirstLaunch;

	public UnityEvent OnGameCompleted;

	public ProfileInfo pInfo;

	private bool NDIBBILNLHJ;

	private bool ABLMLLLDOPO;

	private int IJPCEKICPCP = -1;

	private bool FOHPPAKJEHA;

	private List<Vector2> BNEGFAHKIAA = new List<Vector2>();

	private int KNOAFBDEBDK;

	private int EKGCLHGOFMG = 3;

	private int NIMEMPHGJCO;

	public List<GameObject> menuTiles;

	[CompilerGenerated]
	private static Func<Vector2, float> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<Challenge, bool> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Func<Challenge, bool> HCLEECLNOEA;

	[CompilerGenerated]
	private static Func<Challenge, bool> ADLAKIHINOM;

	[CompilerGenerated]
	private static Predicate<GameObject> KCAPKHIJOHL;

	[CompilerGenerated]
	private static Predicate<GameObject> DIEBHABBNGF;

	[CompilerGenerated]
	private static Predicate<GameObject> FBNFNGBBKHH;

	[CompilerGenerated]
	private static Predicate<GameObject> NFNJKONOIJD;

	[CompilerGenerated]
	private static Predicate<GameObject> LBLKOBNMMNL;

	[CompilerGenerated]
	private static Predicate<GameObject> AKLIPIAOCIA;

	[CompilerGenerated]
	private static Predicate<GameObject> EINGHFEALEJ;

	[CompilerGenerated]
	private static Predicate<GameObject> ONMBGDBHKBH;

	[CompilerGenerated]
	private static Predicate<GameObject> NPFIKAFPOOO;

	[CompilerGenerated]
	private static Predicate<GameObject> AANIPNEBEAL;

	[CompilerGenerated]
	private static Predicate<GameObject> NHFDPIFJIKB;

	[CompilerGenerated]
	private static Predicate<GameObject> OHJMJNOAGMD;

	[CompilerGenerated]
	private static Predicate<GameObject> LIDCPIMJKNB;

	[CompilerGenerated]
	private static Predicate<GameObject> OLKKCLAKBDJ;

	[CompilerGenerated]
	private static Predicate<Vector2> LCIPKAPHIPI;

	private static bool NBIBOHPOCBN(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.IFAJDLKJIDL() > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.InProgress;
	}

	public void OnDisableStoryboardToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetBool("settings.disablestoryboard", true);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetBool("settings.disablestoryboard", false);
		}
	}

	private static bool PMFJPFHKBPG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "[MenuScene] Error: ";
	}

	private static bool CFEMMOPIPHE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value";
	}

	private void MFODMAECFGP()
	{
		try
		{
			StartCoroutine(OCIPHAEEGGO());
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("[MenuScene] Error: " + ex.ToString());
		}
	}

	public void DAOELGHGILE()
	{
		Transform iNBEMGANDKE = GameObject.Find("_Value").transform;
		Singleton<SaveSystem>.Instance.LBFFJLFBOAM("]", iNBEMGANDKE.FindDeepChild("#").GetComponent<Toggle>().isOn);
	}

	public void NENLDJGMNOD()
	{
		Transform iNBEMGANDKE = GameObject.Find("CameraFilterPack/FX_InverChromiLum").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("InfoText").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("CameraFilterPack/Blend2Camera_Overlay").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().CIPIONFIKBP(iNBEMGANDKE.FindDeepChild("There is already a virtual button named ").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Toggle>().isOn);
	}

	public void WriteReview()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/recommended/recommendgame/" + SteamUtils.GetAppID());
	}

	private static bool PCIJHOHOMNH(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction";
	}

	public void OnWorkshopButton()
	{
	}

	[CompilerGenerated]
	private static bool MLJANIMOCLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	private IEnumerator PLFEGHCALDM(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	private static bool IFADPNCKPDG(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.IFAJDLKJIDL() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.InProgress;
	}

	public void OnResolutionChangeButton(int DPNHODJHGJL)
	{
		if (DPNHODJHGJL > 0)
		{
			KNOAFBDEBDK++;
		}
		else
		{
			KNOAFBDEBDK--;
		}
		if (KNOAFBDEBDK < 0)
		{
			KNOAFBDEBDK = 0;
		}
		if (KNOAFBDEBDK > BNEGFAHKIAA.Count - 1)
		{
			KNOAFBDEBDK = BNEGFAHKIAA.Count - 1;
		}
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		iNBEMGANDKE.FindDeepChild("ScreenResolutionPanel").Find("Value").GetComponent<Text>()
			.text = (int)BNEGFAHKIAA[KNOAFBDEBDK].x + " x " + (int)BNEGFAHKIAA[KNOAFBDEBDK].y;
	}

	public void SetPlayerDistance(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public void OnCameraMovementsSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.cameramovements", DPNHODJHGJL);
	}

	public void OnItemsStoreButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/itemstore/513510/");
	}

	[CompilerGenerated]
	private static bool MGLAMCMGJOB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	public void OpenSocial(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.OpenURL("https://discord.gg/intralism", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OpenURL("https://twitch.tv/intralism", false);
		}
		if (DFBMGAGGOHI == 2)
		{
			Singleton<GameManager>.Instance.OpenURL("https://vk.com/khb.soft", false);
		}
		if (DFBMGAGGOHI == 3)
		{
			Singleton<GameManager>.Instance.OpenURL("https://reddit.com/r/Intralism", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.OpenURL("https://bugs.khb-soft.ru/set_project.php?project_id=1", false);
		}
	}

	private IEnumerator LCJDCFFEMLP()
	{
		Singleton<SaveSystem>.Instance.Flush();
		SteamAPI.Shutdown();
		yield return true;
		Process.GetCurrentProcess().Kill();
	}

	[CompilerGenerated]
	private static bool BJHHLJBNOBG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
	}

	public void FPMBDJOGPNC(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("TestTicket", DPNHODJHGJL);
	}

	public void OnExitButton()
	{
		StartCoroutine(LCJDCFFEMLP());
	}

	private IEnumerator OCIPHAEEGGO()
	{
		if (GameManager.IsOffline)
		{
			newsTile.GetComponent<NewsTile>().Init(LocalizationService.Instance.GetLocalizatedText("#news"), string.Empty, null, string.Empty);
			yield break;
		}
		WWW wWW = new WWW(Helpers.newsURL);
		yield return wWW;
		AppNews.NewsRootObject newsRootObject = null;
		if (string.IsNullOrEmpty(wWW.error))
		{
			string newValue = "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/";
			string value = wWW.text.Replace("{STEAM_CLAN_IMAGE}", newValue);
			newsRootObject = JsonConvert.DeserializeObject<AppNews.NewsRootObject>(value);
			int nIMEMPHGJCO = NIMEMPHGJCO;
			Regex regex = new Regex("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", RegexOptions.IgnoreCase);
			MatchCollection matchCollection = regex.Matches(newsRootObject.appnews.newsitems[nIMEMPHGJCO].contents);
			string text = string.Empty;
			if (matchCollection.Count > 0)
			{
				int i = 0;
				text = matchCollection[i].ToString();
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(text, text.ToString()));
			}
			if (newsTile.gameObject.activeInHierarchy)
			{
				yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newsTile.GetComponent<NewsTile>().splashImage.gameObject, true, null, true, 0.5f));
			}
			newsTile.GetComponent<NewsTile>().newsIDSlider.value = NIMEMPHGJCO;
			yield return LocalizationService.Instance.inited;
			string contents = newsRootObject.appnews.newsitems[nIMEMPHGJCO].contents;
			contents = contents.Replace("\r\n", "\n");
			contents = Regex.Replace(contents, "\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", string.Empty);
			contents = Regex.Replace(contents, "(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", string.Empty);
			contents = Regex.Replace(contents, "(\\[ *\\/ *url *])", string.Empty);
			contents = Regex.Replace(contents, "(\\[ *b *\\])", "<b>");
			contents = Regex.Replace(contents, "(\\[ */ *b *\\])", "</b>");
			contents = Regex.Replace(contents, "(\\[ *h1 *\\])", "<size=24>");
			contents = Regex.Replace(contents, "(\\[ */ *h1 *\\])", "</size>");
			contents = Regex.Replace(contents, "(\\[ *i *\\])", "<i>");
			contents = Regex.Replace(contents, "(\\[ */ *i *\\])", "</i>");
			contents = Regex.Replace(contents, "(\\[ *quote *\\])", string.Empty);
			contents = Regex.Replace(contents, "(\\[ */ *quote *\\])", string.Empty);
			newsTile.GetComponent<NewsTile>().Init(newsRootObject.appnews.newsitems[nIMEMPHGJCO].title, contents, (Sprite)ResourcesManager.GetLoadedResource(text), newsRootObject.appnews.newsitems[nIMEMPHGJCO].url);
			NIMEMPHGJCO++;
			if (NIMEMPHGJCO >= EKGCLHGOFMG)
			{
				NIMEMPHGJCO = 0;
			}
		}
		if (newsTile.gameObject.activeInHierarchy)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newsTile.GetComponent<NewsTile>().splashImage.gameObject, false, null, true, 0.5f));
			yield break;
		}
		newsTile.GetComponent<NewsTile>().splashImage.GetComponent<CanvasGroup>().alpha = 0f;
		newsTile.GetComponent<NewsTile>().splashImage.gameObject.SetActive(false);
	}

	public void OnSelectorMapsCountSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.selectormapsperpage", (int)DPNHODJHGJL);
	}

	public void OnEnableRankedNotificationsToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablerankingnotifications", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablerankingnotifications", 0);
		}
	}

	private static bool OOJLOCNKHOF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RecieveChatActionMessage";
	}

	public IEnumerator RateGameQuestion()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#rategameinfo", "#rate!", WriteReview, "#no"));
		Helpers.SetStat("player.gamecompleted", 1);
	}

	public void LoadBG(CSteamID GDOHPDHLPBC)
	{
		StartCoroutine(BPFCIABIFMM(GDOHPDHLPBC));
	}

	[CompilerGenerated]
	private static bool KJJHGMHJAJP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
	}

	[CompilerGenerated]
	private static bool CKIGFOCPHJN(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
	}

	private static bool JOHKPKOKLLH(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Green_R";
	}

	public void PLCNEOAGEHA()
	{
		Singleton<GameManager>.Instance.KPCCPKIPFGC("maps.", false);
	}

	private void BPBGOKGNDJB()
	{
		if ((bool)menuTiles.Find(JOHKPKOKLLH))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton").GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = !GameManager.IMDOFCBINLC();
		}
		if ((bool)menuTiles.Find(DCAKGICPDKL))
		{
			menuTiles.Find(CFEMMOPIPHE).GetComponent<Button>().interactable = !GameManager.IELIHANIEAC();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find(IAPBHJJONIJ))
		{
			menuTiles.Find(JILHPDHFHAG).GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		if ((bool)menuTiles.Find(OOJLOCNKHOF))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton").GetComponent<Button>().interactable = GameManager.PEJIIBNCKEI();
		}
	}

	[CompilerGenerated]
	private static bool FPCPFNLIBIG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	[CompilerGenerated]
	private static bool HMPHCJBHJGG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
	}

	public void AddTipButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("?page=addtip"));
	}

	private static bool IAPBHJJONIJ(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Left";
	}

	[CompilerGenerated]
	private static bool IHHPJEAHLBO(Vector2 IACGDFHKCAE)
	{
		return IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height;
	}

	private void CJNIKGCOOAD()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		AIBBBPLLCFJ(1360f);
	}

	public void InitProfileCanvas()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		SetPlayerDistance(7f);
		StartCoroutine(Singleton<InventorySelector>.Instance.DisplayInventory(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	[CompilerGenerated]
	private static bool FNJAOABNDGP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
	}

	public void FGINPPFAMIP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("menu.selectedlevelid", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB(". Prefab must have a PhotonView component.", 1);
		}
	}

	[CompilerGenerated]
	private static bool EBINHDABFNF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
	}

	[CompilerGenerated]
	private void GEMMLOGEJON()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
	}

	public IEnumerator LoadPlayerInfo()
	{
		CSteamID steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		string bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL));
			pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
		int num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			pInfo.rank.text = string.Empty + num;
		}
		else
		{
			pInfo.rank.text = "TBD";
		}
		pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID));
		pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		LoadBG(steamID);
		pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
	}

	public void IHCFAIPPFPJ()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(true);
		SetPlayerDistance(364f);
		StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1, null, null, delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void HCNNCEPLHBE()
	{
		if (GameManager.IELIHANIEAC())
		{
			TipsListElement obj = tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.HOPMEAJKPHL("_BlurParams"));
			playerTip.id = 0uL;
			playerTip.EHPNOPLMJCC(SteamUser.GetSteamID().m_SteamID);
			obj.EFEONCCCKNP(playerTip);
		}
		else if (RanksSystem.EAGFIMBCDCP().Count > 0)
		{
			tip.EKOAKKNGGGI(RanksSystem.EAGFIMBCDCP()[UnityEngine.Random.Range(0, RanksSystem.JJEHNLHAAGC().Count)]);
		}
	}

	public void OnMultiplayerButton()
	{
		SceneManager.LoadScene("NetworkScene");
	}

	[CompilerGenerated]
	private static bool KMFLLCDHOPB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	public void OnRelaxToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HasKey("menu.relaxinfo"))
			{
				Singleton<SaveSystem>.Instance.SetInt("menu.relaxinfo", 1);
			}
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 1);
		}
	}

	public void OnGameMessagesDurationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.gamemessagesduration", DPNHODJHGJL);
	}

	public IEnumerator ELBFMNFCCAC()
	{
		CSteamID steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		string bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL));
			pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
		int num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			pInfo.rank.text = string.Empty + num;
		}
		else
		{
			pInfo.rank.text = "TBD";
		}
		pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID));
		pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		LoadBG(steamID);
		pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
	}

	private static bool FLPLKENDBBP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.ObtainedReward;
	}

	private void HPBCCKJKGBL()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(true);
		SetPlayerDistance(1838f);
	}

	public void OnEnableRankingToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enableranking", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enableranking", 0);
		}
	}

	public void DMGHHDELIIA(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_MatrixSpeed"))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("UsernameText"), ").png", null, true, true, 195f);
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("challenges/", 1);
			}
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("Map already submited. Update?", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_TimeX", 1);
		}
	}

	public void OnCrosshairOpacitySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.crosshairopacity", DPNHODJHGJL * 0.01f);
	}

	private static bool HFMDFOPHGHA(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OCNOEDGAPNL() != 0 || Helpers.isChallengeUnlocked(IACGDFHKCAE.FOFJIPLGEKL());
	}

	private IEnumerator DCEMOLIGKGC()
	{
		string text = "original.tutorial";
		SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	public void SetPlayerBlur(bool BNKMBAECHGB)
	{
		GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
		gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().enabled = BNKMBAECHGB;
	}

	private static bool IICLCPOHBEL(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.DGAKBIEHAJC() > Challenge.CurrentStatus.InProgress && IACGDFHKCAE.JMGIKADHIGM() < (Challenge.CurrentStatus)4;
	}

	public void ResetAllSettings()
	{
		Singleton<SaveSystem>.Instance.DeleteKey("settings.shaders");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.shaders.bloomintencity");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.fps");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.enableselectormusic");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.showHP");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.menu");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.game");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.editor");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.sfx");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enablehitsoundsinrelax");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.disablestoryboard");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enableselectormusic");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.hitvariation");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.cameramovements");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.crosshairopacity");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.gamemessagesduration");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcsdestroydelay");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcsnohitsoundtimedelay");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcshitsoundtimedelay");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.selectormapsperpage");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enableranking");
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enablerankingnotifications");
		hardInput.ResetAllBindings();
		VolumeSettings component = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>();
		component.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		component.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		component.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		component.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		QualitySettings.SetQualityLevel(1);
		InitSettingsCanvas();
		GetComponent<ShadersSettings>().SetShadersEnabled(iNBEMGANDKE.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn);
	}

	public void AIBBBPLLCFJ(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public void OnStartButton()
	{
	}

	private IEnumerator NKPMFEHMGNP()
	{
		GameObject gameObject = tipsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (RanksSystem.PlayerTip tips in RanksSystem.GetTipsList())
		{
			CSteamID gDOHPDHLPBC = (CSteamID)tips.steamID;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(gDOHPDHLPBC));
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tipsListElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<TipsListElement>().Init(tips);
		}
	}

	[CompilerGenerated]
	private static bool BENAPOCGKLD(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
	}

	public void EADLDFICCDH()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		HDAOEDNALLJ(1949f);
		StartCoroutine(Singleton<InventorySelector>.Instance.INLAAKKJLGH(HPBCCKJKGBL));
	}

	public void ObtainAchievement(int JMMILEFMACB)
	{
		Helpers.ObtainAchievement(JMMILEFMACB);
	}

	public void JAAOGDPKJBP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("AvatarImage", false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("steamid", true);
		}
	}

	public void OnArcsHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcshitsoundtimedelay", DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static bool AFCPIDKJDGA(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition);
	}

	private void GOGLEOJCHHG()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		AIBBBPLLCFJ(820f);
	}

	private IEnumerator BEHNMAIOPKJ(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	public void ApplyVideoSettings()
	{
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("FullscreenToggle").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("GraphicsQualitySlider").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().SetShadersEnabled(iNBEMGANDKE.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn);
	}

	[CompilerGenerated]
	private static bool DMDGONAJGND(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	private void MNCMLOEAPAH()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerDistance(561f);
		if ((bool)GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("View"))
		{
			GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SetTrailZoomSpeed").GetComponent<Button>().Select();
		}
		SetPlayerBlur(false);
	}

	public void SetGameMode(string DLGIPFOEDCF)
	{
		Singleton<SaveSystem>.Instance.SetString("menu.selectedmode", DLGIPFOEDCF);
	}

	public void OnSelectorMusicToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.enableselectormusic", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.DeleteKey("menu.enableselectormusic");
		}
	}

	public void CKKPICBGKJI(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("_TimeX", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_Radius", 1);
		}
	}

	private static bool IBGLIBJIJJL(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack/Drawing_Paper3";
	}

	private void IFPFEIBFKPO()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
	}

	public IEnumerator CGJLJNMOMLA()
	{
		CSteamID steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		string bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL));
			pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
		int num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			pInfo.rank.text = string.Empty + num;
		}
		else
		{
			pInfo.rank.text = "TBD";
		}
		pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID));
		pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		LoadBG(steamID);
		pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
	}

	public void OnLevelEditorButton()
	{
		SceneManager.LoadScene("MapEditorScene");
	}

	[CompilerGenerated]
	private static bool OBBLIPPPGPI(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
	}

	private static bool KNCKDLMHJNE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "1177138211";
	}

	public void LJBDHLFBNFC()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(true);
		SetPlayerDistance(47f);
		StartCoroutine(Singleton<InventorySelector>.Instance.PNGLEBHHKJK(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	private IEnumerator BPFCIABIFMM(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	[CompilerGenerated]
	private static bool HNBBKDMOGLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
	}

	public void OnEnableHitSoundsInNormalToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinnormal", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinnormal", 0);
		}
	}

	public void NANHJALKKLH()
	{
		Singleton<GameManager>.Instance.OpenURL("#turnoninternet", false);
	}

	public void DDMILNCEHBH()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 0)
		{
			int num = Singleton<ChallengesManager>.Instance.challengesList.Where((Challenge IACGDFHKCAE) => IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward).Count();
			if (num > 1)
			{
				string text2 = text;
				object[] array = new object[2];
				array[0] = text2;
				array[1] = ".highscore";
				array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
				array[0] = "_ScreenResolution";
				array[1] = num;
				array[8] = Environment.NewLine;
				array[6] = Environment.NewLine;
				text = string.Concat(array);
				foreach (Challenge item in Singleton<ChallengesManager>.Instance.challengesList.Where(IICLCPOHBEL))
				{
					text2 = text;
					object[] array2 = new object[0];
					array2[1] = text2;
					array2[0] = "CameraFilterPack/TV_Posterize";
					array2[7] = item.DPKBMGBGEPJ() * 1237f;
					array2[8] = "Trackpad";
					array2[8] = item.KJPHHLIPAMA();
					array2[1] = Environment.NewLine;
					array2[5] = Environment.NewLine;
					text = string.Concat(array2);
				}
			}
			int num2 = Singleton<ChallengesManager>.Instance.challengesList.Where(OFPAHEMDOFF).Count();
			if (num2 > 1)
			{
				text += Environment.NewLine;
				string text2 = text;
				object[] array3 = new object[8];
				array3[1] = text2;
				array3[1] = "_TapHigh";
				array3[6] = LocalizationService.Instance.HOPMEAJKPHL(":");
				array3[5] = "maps.";
				array3[1] = num2;
				array3[1] = Environment.NewLine;
				text = string.Concat(array3);
			}
		}
		challengetText.text = text;
	}

	[CompilerGenerated]
	private static bool DLKJHBAFDFM(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	private void MHJOOKDMIHD()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerDistance(7f);
		if ((bool)GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SingleplayerButton"))
		{
			GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SingleplayerButton").GetComponent<Button>().Select();
		}
		SetPlayerBlur(false);
	}

	private static bool DCAKGICPDKL(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Offsets";
	}

	public void UpdateChallengesTile()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 0)
		{
			int num = Singleton<ChallengesManager>.Instance.challengesList.Where((Challenge IACGDFHKCAE) => IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward).Count();
			if (num > 0)
			{
				string text2 = text;
				text = text2 + "<b>" + LocalizationService.Instance.GetLocalizatedText("#activechallenges") + ":</b> " + num + Environment.NewLine + Environment.NewLine;
				foreach (Challenge item in Singleton<ChallengesManager>.Instance.challengesList.Where((Challenge IACGDFHKCAE) => IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward))
				{
					text2 = text;
					text = text2 + "<b>[" + item.GetProgress() * 100f + "%]</b> " + item.info + Environment.NewLine + Environment.NewLine;
				}
			}
			int num2 = Singleton<ChallengesManager>.Instance.challengesList.Where((Challenge IACGDFHKCAE) => IACGDFHKCAE.PlayerStatus == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition)).Count();
			if (num2 > 0)
			{
				text += Environment.NewLine;
				string text2 = text;
				text = text2 + "<b>" + LocalizationService.Instance.GetLocalizatedText("#availablechallenges") + ":</b> " + num2 + Environment.NewLine;
			}
		}
		challengetText.text = text;
	}

	public void MBEPCNGHJHE()
	{
		if (GameManager.IsOffline)
		{
			TipsListElement obj = tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.GetLocalizatedText("GhostFade2"));
			playerTip.LJMEJHIHPGI(1uL);
			playerTip.NFAAADLGEGI(SteamUser.GetSteamID().m_SteamID);
			obj.NFKDBPGHHIJ(playerTip);
		}
		else if (RanksSystem.JJEHNLHAAGC().Count > 0)
		{
			tip.EPDCHKECMBL(RanksSystem.JJEHNLHAAGC()[UnityEngine.Random.Range(0, RanksSystem.HACOOAAIPEN().Count)]);
		}
	}

	private static bool PNOFBIFICND(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "<b>Speed</b>:";
	}

	public void PlayTutorial()
	{
		Singleton<SaveSystem>.Instance.SetBool("player.playedtutorial", true);
		StartCoroutine(DCEMOLIGKGC());
	}

	public void MLBFIPDJCII()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(694f);
		StartCoroutine(Singleton<ChallengesManagerUI>.Instance.BBBNFOHPNOE(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void OnHardcoreToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HasKey("menu.hardcoreinfo"))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("hardcoreinfo"), "OK", null);
				Singleton<SaveSystem>.Instance.SetInt("menu.hardcoreinfo", 1);
			}
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		}
	}

	private IEnumerator DBDHBBGCLNC()
	{
		string text = "original.tutorial";
		SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	private IEnumerator MGIJGHNEFKG()
	{
		string text = "original.tutorial";
		SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	public void BPBMMGDOKLA()
	{
		SceneManager.LoadScene("achievements.id");
	}

	public void OnArcsDestroyDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsdestroydelay", DPNHODJHGJL);
	}

	public void InitTipsCanvas()
	{
		StartCoroutine(NKPMFEHMGNP());
	}

	public override void Update()
	{
		base.Update();
		if (!Singleton<MapsSystem>.Instance.isLoaded && (bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Loading maps".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && (bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Loading inventory".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && (bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Connecting to server".ToUpper();
		}
		if (!NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip oJCILKFONMH = Resources.Load<AudioClip>("Items/" + Singleton<ItemsHandler>.Instance.GetItemBySteamId(Singleton<ItemsHandler>.Instance.EnquippedItem(InventoryItemType.MenuTheme)).item.id + "/theme");
			asampler.Init(oJCILKFONMH, 0f);
			NDIBBILNLHJ = true;
			IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.TriggerItemDrop();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex.ToString());
			}
			try
			{
				StartCoroutine(LoadPlayerInfo());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex2.ToString());
			}
			try
			{
				StartCoroutine(OCIPHAEEGGO());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex3.ToString());
			}
			try
			{
				UpdateChallengesTile();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex4.ToString());
			}
			try
			{
				IFPFEIBFKPO();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Loading)
			{
				IJPCEKICPCP = 0;
				pressAnyKeyCanvas.SetActive(true);
				OnLoaded.Invoke();
			}
		}
		if (IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu))
		{
			if (Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu)
			{
				OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Menu;
			IJPCEKICPCP = 1;
			Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
			OnPressAnyKey.Invoke();
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mainMenuCanvas, true));
			ShowCursor(true);
			ABLMLLLDOPO = false;
			Helpers.ObtainAchievement(0);
			Singleton<ItemsHandler>.Instance.ObtainPromoItems();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.open = true;
				GetComponent<NetworkMenu>().OnJoinedRoom();
			}
			if (Singleton<SaveSystem>.Instance.HasKey("menu.playedsolo"))
			{
				StartCoroutine(NMMJBGCEBEB());
			}
			if (!Singleton<SaveSystem>.Instance.HasKey("player.playedtutorial"))
			{
				PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<ChallengesManager>.Instance.HasProgress())
			{
				Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.DisplayRanksChanges();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("player.xp")) >= 10)
			{
				Helpers.ObtainAchievement(13);
			}
			if (Helpers.GetStat("player.gamecompleted") == 0 && Helpers.GetStat("achievements.21.progress") >= 10)
			{
				StartCoroutine(RateGameQuestion());
			}
			Singleton<GameManager>.Instance.CheckPlayerBans();
			Singleton<RanksSystem>.Instance.ReloadServerInfo();
			InvokeRepeating("MFODMAECFGP", 8f, 8f);
		}
		if (IJPCEKICPCP == 1)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(0f, 0f, 0f - playerDistance), Time.smoothDeltaTime * 5f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < 10)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations++;
			}
		}
	}

	public void JKNLFOBDGGO()
	{
		Singleton<GameManager>.Instance.NJOEGFFMEIC("<b>Time</b>:");
	}

	public void OnArcsNoHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsnohitsoundtimedelay", DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static bool FOBOODEJMAP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
	}

	public void EEOFDNELEAF(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("_DotSize", DPNHODJHGJL);
	}

	private static bool EPJDFDHLAJG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "maps.";
	}

	private static bool OPMKIILFJKL(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.NotStarted;
	}

	public void OnHitVariationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.hitvariation", DPNHODJHGJL);
	}

	public void IGNNALCKOKO()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(true);
		AIBBBPLLCFJ(490f);
		StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(0, null, null, delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void OnGetMoreLevelsButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/app/513510/workshop/");
	}

	private static float AGPPNCJKECJ(Vector2 AIEJPEPBAEJ)
	{
		return AIEJPEPBAEJ.x;
	}

	private IEnumerator HJJPNBBAJPP()
	{
		SetGameMode("solo");
		mainMenuCanvas.SetActive(false);
		SetPlayerDistance(4f);
		SetPlayerBlur(true);
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1), null, true, MHJOOKDMIHD));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", Singleton<MapsListSelector>.Instance.result);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", (int)Singleton<MapsListSelector>.Instance.resultMode);
			SceneManager.LoadScene("GameScene");
		}
	}

	public override void Start()
	{
		base.Start();
		NDIBBILNLHJ = false;
		UnityEngine.Debug.Log("[MenuScene] Inited");
		Resolution[] resolutions = Screen.resolutions;
		Resolution[] array = resolutions;
		for (int i = 0; i < array.Length; i++)
		{
			Resolution BBGBGFFPGDN = array[i];
			if (!BNEGFAHKIAA.Exists((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height))
			{
				BNEGFAHKIAA.Add(new Vector2(BBGBGFFPGDN.width, BBGBGFFPGDN.height));
			}
		}
		BNEGFAHKIAA = BNEGFAHKIAA.OrderBy((Vector2 AIEJPEPBAEJ) => AIEJPEPBAEJ.x).ToList();
		if (Singleton<GameManager>.Instance.currentState < GameManager.GameState.Menu)
		{
			Singleton<GameManager>.Instance.UpdateOnlineStatus("Loading...");
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Loading;
		}
	}

	public void OnItemsUploaderButton()
	{
		SceneManager.LoadScene("ItemsUploader");
	}

	public void KPAKNODELBK(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.IEEHOAELCGE("_TimeX", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OpenURL("#scoresubmitionfailed: ");
		}
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.IKDPMOJKILD("Hidden/DepthOfField/MedianFilter", false);
		}
		if (DFBMGAGGOHI == 6)
		{
			Singleton<GameManager>.Instance.OpenURL("<color=#", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.IEEHOAELCGE("_Offsets");
		}
	}

	public void HDAOEDNALLJ(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public void OnShowHPToggle()
	{
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		Singleton<SaveSystem>.Instance.SetBool("settings.showHP", iNBEMGANDKE.FindDeepChild("HPToggle").GetComponent<Toggle>().isOn);
	}

	[CompilerGenerated]
	private void FPEIMLDCGEG()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
	}

	public void InitRanksCanvas()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		SetPlayerDistance(7f);
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(0, null, null, delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public override void AIJGAJIOJDJ()
	{
		base.PHJJHFBLICM();
		if (!Singleton<MapsSystem>.Instance.isLoaded && (bool)GameObject.Find("z"))
		{
			GameObject.Find("Editor").GetComponent<Text>().text = "No regions available. Are you sure your appid is valid and setup?".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && (bool)GameObject.Find("/"))
		{
			GameObject.Find("_Value1").GetComponent<Text>().text = "_MainTex2".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && (bool)GameObject.Find("_Value"))
		{
			GameObject.Find("Obtain promo Item").GetComponent<Text>().text = "ns".ToUpper();
		}
		if (!NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip oJCILKFONMH = Resources.Load<AudioClip>("No player left to ask" + Singleton<ItemsHandler>.Instance.GetItemBySteamId(Singleton<ItemsHandler>.Instance.FKJFGDPFDPK(InventoryItemType.MenuTheme)).item.id + "HightScoreMaxPointsText");
			asampler.Init(oJCILKFONMH, 1569f, false);
			NDIBBILNLHJ = true;
			IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.PMIOFIMECAL();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("_Overlay" + ex.ToString());
			}
			try
			{
				StartCoroutine(CGJLJNMOMLA());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("_Intensity" + ex2.ToString());
			}
			try
			{
				StartCoroutine(OCIPHAEEGGO());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError(": " + ex3.ToString());
			}
			try
			{
				UpdateChallengesTile();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("PointsScoreText" + ex4.ToString());
			}
			try
			{
				BPBGOKGNDJB();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError(": " + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Init)
			{
				IJPCEKICPCP = 1;
				pressAnyKeyCanvas.SetActive(false);
				OnLoaded.Invoke();
			}
		}
		if (IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu))
		{
			if (Singleton<GameManager>.Instance.currentState >= (GameManager.GameState)6)
			{
				OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Loading;
			IJPCEKICPCP = 1;
			Singleton<GameManager>.Instance.IPOGIBLJDPE(".wav", null, null, null, 1);
			OnPressAnyKey.Invoke();
			StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(mainMenuCanvas, true, null, false, 1820f, false));
			GMGMPMIIMLP(true);
			ABLMLLLDOPO = false;
			Helpers.ObtainAchievement(1);
			Singleton<ItemsHandler>.Instance.NPLAKLFJEOF();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("_ScreenResolution").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.LBHJHCKLANM(false);
				GetComponent<NetworkMenu>().KPGIJJHDCJI();
			}
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Failed to InstantiateSceneObject prefab: "))
			{
				StartCoroutine(HJJPNBBAJPP());
			}
			if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_TimeX"))
			{
				PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
			}
			if (Singleton<ChallengesManager>.Instance.HKBEDHGKHLG())
			{
				Singleton<ChallengesManager>.Instance.HCJMCPGGPKH();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.KFBKMKHMAPJ();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("Object ID. Case-Sensitive")) >= 95)
			{
				Helpers.ObtainAchievement(-74);
			}
			if (Helpers.GetStat("_Intensity") == 0 && Helpers.GetStat("#close") >= -16)
			{
				StartCoroutine(RateGameQuestion());
			}
			Singleton<GameManager>.Instance.GMEFFKOFBLL();
			Singleton<RanksSystem>.Instance.DAHGNLKGIJK();
			InvokeRepeating("blue", 945f, 1315f);
		}
		if (IJPCEKICPCP == 0)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("(\\[ *i *\\])");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(1526f, 1018f, 0f - playerDistance), Time.smoothDeltaTime * 1163f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < -79)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations += 0;
			}
		}
	}

	private static bool JILHPDHFHAG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value3";
	}

	public void DBHOOLCPPKM()
	{
	}

	public void NALLEMIPMBE()
	{
		if (GameManager.PEJIIBNCKEI())
		{
			TipsListElement obj = tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.HOPMEAJKPHL("BloodAlternative3"));
			playerTip.POPAHCMKOHP(1uL);
			playerTip.HCEOMMIJOFO(SteamUser.GetSteamID().m_SteamID);
			obj.EPDCHKECMBL(playerTip);
		}
		else if (RanksSystem.HACOOAAIPEN().Count > 0)
		{
			tip.LLAHPNGMEOO(RanksSystem.HACOOAAIPEN()[UnityEngine.Random.Range(1, RanksSystem.EAGFIMBCDCP().Count)]);
		}
	}

	public void NFECGCNOGOJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("Hex value #RRGGBB", DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static float NFHPEBCJNMP(Vector2 AIEJPEPBAEJ)
	{
		return AIEJPEPBAEJ.x;
	}

	public void BCOPKOLKGDC()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("LevelEditor/patterns");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("L1");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("Object ID. Case-Sensitive");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("isVisible");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_DistortionSize");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(" GameServer:");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("]");
		Singleton<SaveSystem>.Instance.DeleteKey(",");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("SetParticlesParticleSpeed");
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("_TimeX");
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("/files/editor_manual.pdf");
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("ViewMenu");
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("CameraFilterPack/FX_ZebraColor");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(". The group number should be at least 1.");
		Singleton<SaveSystem>.Instance.DeleteKey(".workshop");
		Singleton<SaveSystem>.Instance.DeleteKey("11");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("Set satellite trail width");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("Updating...");
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("settings.enablehitsoundsinrelax");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_TimeX");
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("x");
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		hardInput.JONAFAINKKM();
		VolumeSettings component = GameObject.FindGameObjectWithTag("shader.pixel").GetComponent<VolumeSettings>();
		component.PNKIOJIKKEG(Singleton<SaveSystem>.Instance.OLHIEOKMOAK("finished", 1635f));
		component.PEMGCAIGPPP(Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_TimeX", 668f));
		component.DMLECMADHCP(Singleton<SaveSystem>.Instance.OLHIEOKMOAK("setAF", 216f));
		component.IDMPNIJDPEI(Singleton<SaveSystem>.Instance.GetFloat("Search: ", 1790f));
		Transform iNBEMGANDKE = GameObject.Find("CameraFilterPack/FX_superDot").transform;
		QualitySettings.SetQualityLevel(0);
		InitSettingsCanvas();
		GetComponent<ShadersSettings>().OHJBECDKMGN(iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("Default UI Material").GetComponent<Toggle>().isOn);
	}

	public void SaveData()
	{
		Singleton<SaveSystem>.Instance.Flush();
	}

	public void GGLLIDEFMJC()
	{
		Transform iNBEMGANDKE = GameObject.Find("_ScreenResolution").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("Parent object ID. Case-Sensitive"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("_TimeX").GetComponent<ShadersSettings>().IBFEBKLBJOL();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetParticlesParticleSize"))
		{
			iNBEMGANDKE.FindDeepChild("[Left]").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("LoadingStatusText").GetComponent<FPSSettings>().GGAAOAEKGIP();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetSatelliteTrailMinVertexDistance"))
		{
			iNBEMGANDKE.FindDeepChild("_Value3").GetComponent<Toggle>().isOn = !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Myst_Color") && false;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("PlaySound"))
		{
			iNBEMGANDKE.FindDeepChild("_Value8").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.IOLBIFOIHML("maps.", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_FadeFX"))
		{
			iNBEMGANDKE.FindDeepChild(" | ").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("In Main Menu"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value2").GetComponent<VolumeSettings>().HPGOMHIMAEL();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".lastCheckpoint.incorrectScore"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_MainTex").GetComponent<VolumeSettings>().ECDGHHKPIHL();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value"))
		{
			iNBEMGANDKE.FindDeepChild("Mouse Y").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CMAFBKOEPLP("SpawnObj", 0) != 1 || true;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/TV_ARCADE_2"))
		{
			iNBEMGANDKE.FindDeepChild("Up").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.LCHPECEJMPE("id", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("PerfectHitsScoreText"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/3D_Matrix").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("0x") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(" b."))
		{
			iNBEMGANDKE.FindDeepChild("steamid").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value3").GetComponent<VolumeSettings>().KICALMOMCBM();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("[PlayerController] "))
		{
			iNBEMGANDKE.FindDeepChild("DisableStoryboardToggle").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("/", 187f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Offsets"))
		{
			iNBEMGANDKE.FindDeepChild(" PhotonView: ").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_TimeX", 1826f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Events Moved"))
		{
			iNBEMGANDKE.FindDeepChild("{0:0} second{1}").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CorrectHitsScoreText"))
		{
			iNBEMGANDKE.FindDeepChild("inventory.selected.").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("/", 763f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Received OnSerialization for view ID "))
		{
			iNBEMGANDKE.FindDeepChild("SpawnObj").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Tab1Content", 1308f) * 606f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetParticlesParticleSize"))
		{
			iNBEMGANDKE.FindDeepChild("workshop.").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_AdaptionSpeed", 1115f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Heigh"))
		{
			iNBEMGANDKE.FindDeepChild("_MainTex2").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_ScreenResolution", 1513f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Could not find RPC with index: "))
		{
			iNBEMGANDKE.FindDeepChild("shader.crispwinter").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("(\\[ */ *quote *\\])", 1366f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Size"))
		{
			iNBEMGANDKE.FindDeepChild("UNDISTORT").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("_Value", 300f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("#close"))
		{
			iNBEMGANDKE.FindDeepChild("_BlendTex").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("#8E8E8EFF", -105);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(". Possible scene loading in progress?"))
		{
			iNBEMGANDKE.FindDeepChild("_MainTex2").Find("menu.selectedplaymode").GetComponent<Text>()
				.text = Screen.currentResolution.width + "_FadeFX" + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("bad"))
		{
			iNBEMGANDKE.FindDeepChild("_SunPosition").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("<color=#{0}>{1}</color>", 1) != 1 || true;
		}
		if (!GameManager.FCKAHHLOMIC())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
			{
				iNBEMGANDKE.FindDeepChild("00").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("\"").GetComponent<Toggle>().interactable = false;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("_Offsets"))
			{
				iNBEMGANDKE.FindDeepChild("#ok").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("HiddenToggle").GetComponent<Toggle>().interactable = true;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Fade"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetInt("Tab2Content", 0) != 1;
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height));
	}

	[CompilerGenerated]
	private void FLICOEHOIPL()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
	}

	private static bool OFPAHEMDOFF(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OCNOEDGAPNL() != 0 || Helpers.isChallengeUnlocked(IACGDFHKCAE.PNHHKLBLPEB());
	}

	public void GetRandomTip()
	{
		if (GameManager.IsOffline)
		{
			tip.Init(new RanksSystem.PlayerTip
			{
				tip = LocalizationService.Instance.GetLocalizatedText("#turnoninternet"),
				id = 0uL,
				steamID = SteamUser.GetSteamID().m_SteamID
			});
		}
		else if (RanksSystem.GetTipsList().Count > 0)
		{
			tip.Init(RanksSystem.GetTipsList()[UnityEngine.Random.Range(0, RanksSystem.GetTipsList().Count)]);
		}
	}

	private IEnumerator NMMJBGCEBEB()
	{
		SetGameMode("solo");
		mainMenuCanvas.SetActive(false);
		SetPlayerDistance(4f);
		SetPlayerBlur(true);
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1), null, true, MHJOOKDMIHD));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", Singleton<MapsListSelector>.Instance.result);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", (int)Singleton<MapsListSelector>.Instance.resultMode);
			SceneManager.LoadScene("GameScene");
		}
	}

	private static bool MMPJAOJJFON(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "<b>";
	}

	public void OnEnableHitSoundsInRelaxToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinrelax", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinrelax", 0);
		}
	}

	public void SelectMapForSingleplayer()
	{
		StartCoroutine(NMMJBGCEBEB());
	}

	public void LIOECDDFHOG()
	{
		Singleton<GameManager>.Instance.GMDIJMFPKOC(Singleton<GameManager>.Instance.CreateServerURL("DataText"));
	}

	public void InitSettingsCanvas()
	{
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("ShadersToggle"))
		{
			iNBEMGANDKE.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("Scene").GetComponent<ShadersSettings>().IsShadersEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("FPSToggle"))
		{
			iNBEMGANDKE.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("Scene").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SelectorMusicToggle"))
		{
			iNBEMGANDKE.FindDeepChild("SelectorMusicToggle").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("HPToggle"))
		{
			iNBEMGANDKE.FindDeepChild("HPToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("FullscreenToggle"))
		{
			iNBEMGANDKE.FindDeepChild("FullscreenToggle").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("MenuVolumeSlider"))
		{
			iNBEMGANDKE.FindDeepChild("MenuVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetMenuVolume();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("GameVolumeSlider"))
		{
			iNBEMGANDKE.FindDeepChild("GameVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetGameVolume();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("HitInRelaxMusicToggle"))
		{
			iNBEMGANDKE.FindDeepChild("HitInRelaxMusicToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0) == 1;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("DisableStoryboardToggle"))
		{
			iNBEMGANDKE.FindDeepChild("DisableStoryboardToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SelectorMusicToggle"))
		{
			iNBEMGANDKE.FindDeepChild("SelectorMusicToggle").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SfxVolumeSlider"))
		{
			iNBEMGANDKE.FindDeepChild("SfxVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetSfxVolume();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("HitVariationSlider"))
		{
			iNBEMGANDKE.FindDeepChild("HitVariationSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.hitvariation", 0.25f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("BloomShaderValueSlider"))
		{
			iNBEMGANDKE.FindDeepChild("BloomShaderValueSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("GraphicsQualitySlider"))
		{
			iNBEMGANDKE.FindDeepChild("GraphicsQualitySlider").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraMovementSlider"))
		{
			iNBEMGANDKE.FindDeepChild("CameraMovementSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CrosshairOpacitySlider"))
		{
			iNBEMGANDKE.FindDeepChild("CrosshairOpacitySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f) * 100f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("GameMessagesDurationSlider"))
		{
			iNBEMGANDKE.FindDeepChild("GameMessagesDurationSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ArcsDestroyDelaySlider"))
		{
			iNBEMGANDKE.FindDeepChild("ArcsDestroyDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsdestroydelay", 0.1f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ArcsNoHitsoundTimeDelaySlider"))
		{
			iNBEMGANDKE.FindDeepChild("ArcsNoHitsoundTimeDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 0f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ArcsHitsoundTimeDelaySlider"))
		{
			iNBEMGANDKE.FindDeepChild("ArcsHitsoundTimeDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcshitsoundtimedelay", -0.11f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SelectorMapsCountSlider"))
		{
			iNBEMGANDKE.FindDeepChild("SelectorMapsCountSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetInt("settings.selectormapsperpage", 21);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ScreenResolutionPanel"))
		{
			iNBEMGANDKE.FindDeepChild("ScreenResolutionPanel").Find("Value").GetComponent<Text>()
				.text = Screen.currentResolution.width + " x " + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("EnableRankingToggle"))
		{
			iNBEMGANDKE.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1) == 1;
		}
		if (!GameManager.IsOwner())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("EnableRankingToggle"))
			{
				iNBEMGANDKE.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().interactable = false;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("EnableRankedNotificationsToggle"))
			{
				iNBEMGANDKE.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().interactable = false;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("EnableRankedNotificationsToggle"))
		{
			iNBEMGANDKE.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetInt("settings.enablerankingnotifications", 1) == 1;
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height));
	}

	private void GMJNAPLLOND()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton").GetComponent<Button>().interactable = !GameManager.JLAGBKACIIC();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = GameManager.IELIHANIEAC();
		}
		if ((bool)menuTiles.Find(DCAKGICPDKL))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = !GameManager.JLAGBKACIIC();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton"))
		{
			menuTiles.Find(KNCKDLMHJNE).GetComponent<Button>().interactable = !GameManager.PEJIIBNCKEI();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton").GetComponent<Button>().interactable = GameManager.IELIHANIEAC();
		}
		if ((bool)menuTiles.Find(OOJLOCNKHOF))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton").GetComponent<Button>().interactable = GameManager.JLAGBKACIIC();
		}
	}

	public void FBIFAGDHIPA(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(",", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("Set satellite beat detection sensitivity", 0);
		}
	}

	public void InitChallengesCanvas()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		SetPlayerDistance(7f);
		StartCoroutine(Singleton<ChallengesManagerUI>.Instance.DisplayViewer(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void EGDELPMABLH()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(false);
		AIBBBPLLCFJ(241f);
		StartCoroutine(Singleton<ChallengesManagerUI>.Instance.DOHCPHEEGJJ(GOGLEOJCHHG));
	}

	public void PDCMLNAELGH(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.GMDIJMFPKOC("[MapEditor] Loaded music file: ");
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.NJOEGFFMEIC("/Segment-[Left]", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.GMDIJMFPKOC("1");
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.MKEGIDHHLIC("CameraFilterPack/Blend2Camera_ColorDodge");
		}
		if (DFBMGAGGOHI == 2)
		{
			Singleton<GameManager>.Instance.NJOEGFFMEIC("0.00");
		}
	}

	private static bool FOINDIGLLBC(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.CJNNAAGGAJI() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.NotStarted;
	}

	private IEnumerator KHHAJELAMPM()
	{
		string text = "original.tutorial";
		SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0);
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		SceneManager.LoadScene("GameScene");
		yield break;
	}
}
