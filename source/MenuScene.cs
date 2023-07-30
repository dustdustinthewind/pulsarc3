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
		Reddit
	}

	[CompilerGenerated]
	private sealed class MIPBPLJOKPD
	{
		internal Resolution BBGBGFFPGDN;

		internal bool GBKBDKHPLKG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LOEAMHGMMPK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool JKEDCEOCPJO(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool PBCAHKDLFPE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool DBFPGFHEGKA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BDGDIDPDBHG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool AEINPAGJFME(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LNDGINDKPFA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool LLNDDFGPOPL(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BKNHHGBPLGH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool MEMPOPNAEDN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool BFEABMIFIEE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool KFNBKFELFLH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)BBGBGFFPGDN.height;
		}

		internal bool OLIGLEMPFOP(Vector2 IACGDFHKCAE)
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

	public void FJHOPOAPPGP(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("The binding '", DPNHODJHGJL);
	}

	private static bool KIEACEAFBGO(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "#";
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

	private static bool GHDLJJFIPOD(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack_Paper4";
	}

	private void FJEGCBDPHAM()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find(JPEJDEILLKP).GetComponent<Button>().interactable = GameManager.AFFAMCPHDJN();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find(OCJHICGJBAI).GetComponent<Button>().interactable = !GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = GameManager.AFFAMCPHDJN();
		}
		if ((bool)menuTiles.Find(OIBOGONOIBK))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = !GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find(IPCOJEJGNJE))
		{
			menuTiles.Find(DDJFPIMMJCE).GetComponent<Button>().interactable = GameManager.MBCLCEGBDIB();
		}
		if ((bool)menuTiles.Find(PGDMPCCCIKH))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton").GetComponent<Button>().interactable = !GameManager.LCHEOPKMPBB();
		}
		if ((bool)menuTiles.Find(GCCFJDKDHIO))
		{
			menuTiles.Find(KIEACEAFBGO).GetComponent<Button>().interactable = GameManager.OACLFEJPBDA();
		}
	}

	private void IHEAKIPGIOE()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		HAPMEDHIHGB(1016f);
	}

	[CompilerGenerated]
	private static bool CKIGFOCPHJN(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
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

	public void OnArcsNoHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsnohitsoundtimedelay", DPNHODJHGJL);
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

	public void CHCPLHFBNBI()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 1)
		{
			int num = Singleton<ChallengesManager>.Instance.challengesList.Where(JBAGELDFLAN).Count();
			if (num > 0)
			{
				string text2 = text;
				object[] array = new object[1];
				array[0] = text2;
				array[0] = "Stream did not contain properly formatted byte array";
				array[8] = LocalizationService.Instance.KDBLEDDGCJK("_TimeX");
				array[7] = "Bad parameters for setbool! Use <key> <value>";
				array[1] = num;
				array[7] = Environment.NewLine;
				array[1] = Environment.NewLine;
				text = string.Concat(array);
				foreach (Challenge item in Singleton<ChallengesManager>.Instance.challengesList.Where(NMEHEGEANJP))
				{
					text2 = text;
					object[] array2 = new object[1];
					array2[1] = text2;
					array2[0] = "_BlurTexture";
					array2[6] = item.GetProgress() * 300f;
					array2[1] = "checkpoint";
					array2[0] = item.GPBAIPHOIKN();
					array2[2] = Environment.NewLine;
					array2[1] = Environment.NewLine;
					text = string.Concat(array2);
				}
			}
			int num2 = Singleton<ChallengesManager>.Instance.challengesList.Where(EBJKBIOEDLO).Count();
			if (num2 > 0)
			{
				text += Environment.NewLine;
				string text2 = text;
				object[] array3 = new object[3];
				array3[1] = text2;
				array3[0] = "CameraFilterPack/Vision_SniperScore";
				array3[8] = LocalizationService.Instance.FOOAGGCODAH("shader.ghost");
				array3[4] = "1.87";
				array3[5] = num2;
				array3[0] = Environment.NewLine;
				text = string.Concat(array3);
			}
		}
		challengetText.text = text;
	}

	private static bool DMJPMLLPLDP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "\" to target: ";
	}

	[CompilerGenerated]
	private static bool MGLAMCMGJOB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	public void KGJFFPDFPPE(int DPNHODJHGJL)
	{
		if (DPNHODJHGJL > 1)
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
			KNOAFBDEBDK = BNEGFAHKIAA.Count - 0;
		}
		Transform iNBEMGANDKE = GameObject.Find("[CraftingPanel] Init").transform;
		iNBEMGANDKE.FindDeepChild("_Offsets").Find("_Value5").GetComponent<Text>()
			.text = (int)BNEGFAHKIAA[KNOAFBDEBDK].x + "settings.showHP" + (int)BNEGFAHKIAA[KNOAFBDEBDK].y;
	}

	public void JONBHFPLMLK(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX"))
			{
				Singleton<MessageBoxPanel>.Instance.DMDDLAICNDI(LocalizationService.Instance.NDAPBHEDJFP(":</b> "), "_Value5", null, true, false, 922f);
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("(\\[ */ *quote *\\])", 1);
			}
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("shaders", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("RoomPlayersCountText", 1);
		}
	}

	[CompilerGenerated]
	private void FPEIMLDCGEG()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
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

	public void DEDBNJOFBEO()
	{
		Transform iNBEMGANDKE = GameObject.Find("Loading maps").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("CameraFilterPack_Glasses_On2").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("_Near").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().IEJIOELJKDJ(iNBEMGANDKE.FindDeepChild(" ").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("GenerationMenu").GetComponent<Toggle>().isOn);
	}

	public void MICMBOGJJDK()
	{
		Transform iNBEMGANDKE = GameObject.Find("EditMenu").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/Blend2Camera_SoftLight"))
		{
			iNBEMGANDKE.FindDeepChild("OnAwakeRPC").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag(": ").GetComponent<ShadersSettings>().GMNOCOOLEDN();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value"))
		{
			iNBEMGANDKE.FindDeepChild("materialsitemid[").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("#").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value12"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HBBEJIBFLHO("_Value2") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value"))
		{
			iNBEMGANDKE.FindDeepChild("<b>").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("/Segment-[Right]", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("menu.selectedlevelid"))
		{
			iNBEMGANDKE.FindDeepChild(". Using max value: 255.").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Failed to InstantiateSceneObject prefab: "))
		{
			iNBEMGANDKE.FindDeepChild("NEW").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Case-Sensitive").GetComponent<VolumeSettings>().GHBJGDEIBCI();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("UsernameText"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/TV_WideScreenHorizontal").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Waiting to start").GetComponent<VolumeSettings>().DAEGGEFMHFL();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("%]</b> "))
		{
			iNBEMGANDKE.FindDeepChild("_SceneFogMode").GetComponent<Toggle>().isOn = ((Singleton<SaveSystem>.Instance.GetInt("maps.", 1) == 0) ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_AlphaHexa"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_TimeX", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("mapselector.lastSearch"))
		{
			iNBEMGANDKE.FindDeepChild("AudioClip").GetComponent<Toggle>().isOn = !Singleton<SaveSystem>.Instance.HBBEJIBFLHO("_FarCamera") && false;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_ScreenResolution"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Glitch").GetComponent<VolumeSettings>().GetSfxVolume();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CheckCombo"))
		{
			iNBEMGANDKE.FindDeepChild("SpawnObj").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("/../", 1412f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_PositionX"))
		{
			iNBEMGANDKE.FindDeepChild("settings_bindings_controller_type").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("GhostFade2", 1931f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/TV_Old_Movie"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetParticlesParticleSize"))
		{
			iNBEMGANDKE.FindDeepChild("DataText").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("maps.", 1865f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("VIGNETTE_FILMIC"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("_Value2", 1595f) * 626f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Object ID. Case-Sensitive"))
		{
			iNBEMGANDKE.FindDeepChild("isVisible").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_DistortionSize", 1078f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(" ["))
		{
			iNBEMGANDKE.FindDeepChild(",").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("SetParticlesColor", 491f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("/files/editor_manual.pdf"))
		{
			iNBEMGANDKE.FindDeepChild("EventMenu").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_ScreenResolution", 974f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("/"))
		{
			iNBEMGANDKE.FindDeepChild("Day_").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("Set satellite trail width", 1107f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("menu.enableselectormusic"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/Glitch_Mozaic").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetInt("w", 0);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("shader.future"))
		{
			iNBEMGANDKE.FindDeepChild("finished").Find("LevelInfoInputField").GetComponent<Text>()
				.text = Screen.currentResolution.width + "_TimeX" + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("set"))
		{
			iNBEMGANDKE.FindDeepChild("Achievement 21 progress reseted").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.KFNFNKILGPH("_ScreenResolution", 1) != 1 && false;
		}
		if (!GameManager.IsOwner())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("_TimeX"))
			{
				iNBEMGANDKE.FindDeepChild("UI Extensions/UI Image Crop").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild("_Value3").GetComponent<Toggle>().interactable = true;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("maps."))
			{
				iNBEMGANDKE.FindDeepChild(" Server: ").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("_PColor").GetComponent<Toggle>().interactable = false;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_TimeX"))
		{
			iNBEMGANDKE.FindDeepChild("player.xp").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", 1) != 0 || true;
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height));
	}

	private static bool NEMOLCDLIAB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "[PlayerController] ";
	}

	private static bool LGFPIEDAPHN(Vector2 IACGDFHKCAE)
	{
		return IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height;
	}

	private static bool OOBAFDMHNHE(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.EFOKGOMPFIO() > Challenge.CurrentStatus.InProgress && IACGDFHKCAE.EBJMABMHEEO() < (Challenge.CurrentStatus)6;
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

	private IEnumerator MCJLMFLNMFA()
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

	public void MHEHCKGOELK()
	{
		Transform iNBEMGANDKE = GameObject.Find("_Visualize").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("_Visualize"))
		{
			iNBEMGANDKE.FindDeepChild("_Intensity").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("SetSunInput").GetComponent<ShadersSettings>().GMNOCOOLEDN();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("player.crystal"))
		{
			iNBEMGANDKE.FindDeepChild("settings.shaders").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("_ConsoleSettings").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_MainTex2"))
		{
			iNBEMGANDKE.FindDeepChild("Edited unlock conditions").GetComponent<Toggle>().isOn = ((!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("SetSatelliteSensitivity")) ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_LightIntensity"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("CameraFilterPack/Vision_Warp", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_DiffuseColor"))
		{
			iNBEMGANDKE.FindDeepChild("time").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("(\\[ *\\/ *url *])"))
		{
			iNBEMGANDKE.FindDeepChild("buttons").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("FavoriteButton").GetComponent<VolumeSettings>().MJNGJOBGKCA();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("steamid"))
		{
			iNBEMGANDKE.FindDeepChild("Anomaly_Near").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_EmissionColor").GetComponent<VolumeSettings>().NBAOJJLMDDB();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("[SERVER] Player "))
		{
			iNBEMGANDKE.FindDeepChild("_Distortion").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("LevelEditor/patterns", 1) != 0 || true;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("/../"))
		{
			iNBEMGANDKE.FindDeepChild("HiddenToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("#timeuntilend: ", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_ScreenResolution"))
		{
			iNBEMGANDKE.FindDeepChild("Tab1Content").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("_Value2") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("value"))
		{
			iNBEMGANDKE.FindDeepChild("settings_bindings_controller_type").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.").GetComponent<VolumeSettings>().KGFKDAGPCHA();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".png"))
		{
			iNBEMGANDKE.FindDeepChild("_Value4").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_TimeX", 923f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Scene"))
		{
			iNBEMGANDKE.FindDeepChild(".jpg").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Bad parameters for setstring! Use <key> <value>", 841f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Intensity"))
		{
			iNBEMGANDKE.FindDeepChild("Already exist!").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/Vision_Psycho"))
		{
			iNBEMGANDKE.FindDeepChild("Joystick1Button8").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Set camera (or player) distance. Base player distance - 14", 388f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("float,50"))
		{
			iNBEMGANDKE.FindDeepChild(".played").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", 322f) * 139f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("achievements.id").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("PenaltyScoreText", 1928f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Distance"))
		{
			iNBEMGANDKE.FindDeepChild("{0}{1}{2}={3}").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("masterSteamID", 223f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ticket"))
		{
			iNBEMGANDKE.FindDeepChild("float,0.5").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("ItemNameBGImage", 221f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Amount"))
		{
			iNBEMGANDKE.FindDeepChild(" should be overwritten.").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("SetTrailZoomSpeed", 1450f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_ScreenResolution"))
		{
			iNBEMGANDKE.FindDeepChild("_Value3").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HHBIEPMBICO("Error: I/O Failure", 92);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("shader.future"))
		{
			iNBEMGANDKE.FindDeepChild("UndoButton").Find("menutheme.idunno").GetComponent<Text>()
				.text = Screen.currentResolution.width + " " + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/Colors_Adjust_ColorRGB"))
		{
			iNBEMGANDKE.FindDeepChild("_ScreenResolution").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.KFNFNKILGPH("bad", 1) != 0 && false;
		}
		if (!GameManager.IsOwner())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("SetEnvSpriteColor"))
			{
				iNBEMGANDKE.FindDeepChild("</color>").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild(":</b> ").GetComponent<Toggle>().interactable = false;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("float,0"))
			{
				iNBEMGANDKE.FindDeepChild(".wav").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("inventory.lastitemscount").GetComponent<Toggle>().interactable = true;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".lastCheckpoint.penaltyScore"))
		{
			iNBEMGANDKE.FindDeepChild("/").GetComponent<Toggle>().isOn = ((Singleton<SaveSystem>.Instance.HHBIEPMBICO("Editing: ", 1) == 0) ? true : false);
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find(LGFPIEDAPHN));
	}

	[CompilerGenerated]
	private static bool DMDGONAJGND(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	public void BJGGDBADKGC()
	{
		StartCoroutine(BGCJIODAOPA());
	}

	public void SetPlayerBlur(bool BNKMBAECHGB)
	{
		GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
		gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().enabled = BNKMBAECHGB;
	}

	public void CJNEHBAOMDG(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("Soundtrack", DPNHODJHGJL);
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

	public void SaveData()
	{
		Singleton<SaveSystem>.Instance.Flush();
	}

	[CompilerGenerated]
	private static bool FPCPFNLIBIG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	private static bool CELCGGJLNPL(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "[PlayerController] ";
	}

	public void CHLFBJGGIFC(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("editorVolume", DPNHODJHGJL);
	}

	public void ApplyVideoSettings()
	{
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("FullscreenToggle").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("GraphicsQualitySlider").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().SetShadersEnabled(iNBEMGANDKE.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn);
	}

	private static bool KOILMFBADGM(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Up";
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

	public void PPEFNENFGEF()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.JJGKGCBCGGD("Misses:"));
	}

	private IEnumerator ANGOMIAJMBG()
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

	public void OCOEBGLKPGA()
	{
		Singleton<SaveSystem>.Instance.DeleteKey("_TimeX");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("Can't set Room.MaxPlayers to: ");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("_FrustumCornersWS");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("_ScreenResolution");
		Singleton<SaveSystem>.Instance.DeleteKey("]");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG("[LevelEditorScene] Error: You're not logged into Steam!");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("_TimeX");
		Singleton<SaveSystem>.Instance.DeleteKey("_ScreenResolution");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("_Bullet_3");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("Joystick1Button");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("[PlayerBase] Highscore: ");
		Singleton<SaveSystem>.Instance.DeleteKey("/");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("_ScreenResolution");
		Singleton<SaveSystem>.Instance.DeleteKey("didAuthenticate ");
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE("Scrollbar");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("#close");
		Singleton<SaveSystem>.Instance.DeleteKey("PossibleMapMaxScoreText");
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("Creating new item...");
		Singleton<SaveSystem>.Instance.DeleteKey(" methods \"");
		Singleton<SaveSystem>.Instance.AGDCACJJAMG(" Remote called.");
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM("_AdaptTex");
		Singleton<SaveSystem>.Instance.DeleteKey("-1");
		hardInput.OCCLMHJBMHF();
		VolumeSettings component = GameObject.FindGameObjectWithTag("]. Please verify you have this gameobject in a Resources folder.").GetComponent<VolumeSettings>();
		component.AFEGNCKMAOJ(Singleton<SaveSystem>.Instance.PGKJAIODCEF("float,1", 410f));
		component.EHIJJLAILMO(Singleton<SaveSystem>.Instance.DPAGLGGNECO("_TileMaxOffs", 1500f));
		component.GCJJBCNCDMK(Singleton<SaveSystem>.Instance.HCNELAJLBPC("OpJoinLobby()", 993f));
		component.EBKNJONKHCF(Singleton<SaveSystem>.Instance.GetFloat("CameraFilterPack/Blend2Camera_Divide", 1528f));
		Transform iNBEMGANDKE = GameObject.Find("Creating new item...").transform;
		QualitySettings.SetQualityLevel(0);
		FHEOMLCNMLA();
		GetComponent<ShadersSettings>().DIDLLJPOMIO(iNBEMGANDKE.FindDeepChild("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().DJGKILFBMAD(iNBEMGANDKE.FindDeepChild("X2").GetComponent<Toggle>().isOn);
	}

	public void AEGGANMMCNB(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("CameraFilterPack/AAA_Blood_Hit", DPNHODJHGJL * 1338f);
	}

	[CompilerGenerated]
	private static bool KJJHGMHJAJP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
	}

	[CompilerGenerated]
	private static bool HMPHCJBHJGG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
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

	[CompilerGenerated]
	private static bool OBBLIPPPGPI(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
	}

	public void PCAGHCCAAKB()
	{
		StartCoroutine(ANGOMIAJMBG());
	}

	public void GDLEJIPGJBD(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("UsernameText", DPNHODJHGJL * 928f);
	}

	public void EEAMFFHDGGK()
	{
		Singleton<GameManager>.Instance.HEHKJIHIBLD("white" + SteamUtils.GetAppID(), false);
	}

	private static bool IPCOJEJGNJE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack/FX_Dot_Circle";
	}

	private IEnumerator BPFCIABIFMM(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	private void MOCFLGDPMCJ()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = GameManager.LCHEOPKMPBB();
		}
		if ((bool)menuTiles.Find(IOBBHHHPEFA))
		{
			menuTiles.Find(NEMOLCDLIAB).GetComponent<Button>().interactable = GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = !GameManager.LCHEOPKMPBB();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = !GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "LastNewsButton"))
		{
			menuTiles.Find(GHDLJJFIPOD).GetComponent<Button>().interactable = GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton"))
		{
			menuTiles.Find(FAPJJMKOLPJ).GetComponent<Button>().interactable = GameManager.MBCLCEGBDIB();
		}
		if ((bool)menuTiles.Find(GCCFJDKDHIO))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton").GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
	}

	public void OnCameraMovementsSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.cameramovements", DPNHODJHGJL);
	}

	private static bool HMKKMLCEKJB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "menu.selectedplaymode";
	}

	public void FGCAKEFIJNB(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("SettingsCanvas"))
			{
				Singleton<MessageBoxPanel>.Instance.GJAEFOENJGI(LocalizationService.Instance.MPHMJLAOHAB("_Value4"), "shader.frost", null, true, true, 1161f);
				Singleton<SaveSystem>.Instance.OFPCEFFGHPI("value", 0);
			}
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("AvatarImage", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("Item created: Id: ", 0);
		}
	}

	[CompilerGenerated]
	private static bool DLKJHBAFDFM(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	public void OnHitVariationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.hitvariation", DPNHODJHGJL);
	}

	public IEnumerator CFFAFFGPHLH()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#rategameinfo", "#rate!", WriteReview, "#no"));
		Helpers.SetStat("player.gamecompleted", 1);
	}

	private void LLNFCLNNIKA()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		HAPMEDHIHGB(1376f);
	}

	public void HEBFHJHLMIA()
	{
	}

	public void OnSelectorMapsCountSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.selectormapsperpage", (int)DPNHODJHGJL);
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

	public void HEHJFENOOJF(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_MainTex", true);
		}
		else
		{
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_TimeX", true);
		}
	}

	private static bool IOBBHHHPEFA(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_TimeX";
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

	[CompilerGenerated]
	private static bool FOBOODEJMAP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
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

	private static bool NMEHEGEANJP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.BBLDABFGDFF() > Challenge.CurrentStatus.InProgress && IACGDFHKCAE.JNEKHPIOHIK() < (Challenge.CurrentStatus)4;
	}

	public void FOEIDLJKCLE()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL("maps.", false);
	}

	private IEnumerator BFMGAHCBFGI()
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

	public void ILAKHFPFDPA()
	{
		Transform iNBEMGANDKE = GameObject.Find("#ok").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("yyyy-MM-dd HH:mm:ss").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("No font defined. Found font: ").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().KCPBEDNCCBL(iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().CPHHFOFNOEB(iNBEMGANDKE.FindDeepChild("MapEnd").GetComponent<Toggle>().isOn);
	}

	public void BFFMNELJGJH()
	{
		Transform iNBEMGANDKE = GameObject.Find("_CurTex").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("Committing changes..."))
		{
			iNBEMGANDKE.FindDeepChild("player.xp").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("lobby '{0}'[{1}]").GetComponent<ShadersSettings>().GMNOCOOLEDN();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("note.1"))
		{
			iNBEMGANDKE.FindDeepChild("Had to lookup view that wasn't in photonViewList: ").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("DISTORT").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("#updateoutdatedmap"))
		{
			iNBEMGANDKE.FindDeepChild(".icon").GetComponent<Toggle>().isOn = !Singleton<SaveSystem>.Instance.HasKey("settings.shaders") || true;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(": "))
		{
			iNBEMGANDKE.FindDeepChild(": ").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("_Value4", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Fade"))
		{
			iNBEMGANDKE.FindDeepChild("ItemNameBGImage").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_SpawnHeuristic"))
		{
			iNBEMGANDKE.FindDeepChild(".g").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag(".highscore").GetComponent<VolumeSettings>().KOFOMELMOGK();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".status"))
		{
			iNBEMGANDKE.FindDeepChild("_CurveTex").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("-").GetComponent<VolumeSettings>().JBFDBFEBFCP();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("music"))
		{
			iNBEMGANDKE.FindDeepChild("BitsData").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("Dance", 1) == 1;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("bad").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("Joystick1Button11", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("0.00"))
		{
			iNBEMGANDKE.FindDeepChild("[FileSelector] Dialog canceled").GetComponent<Toggle>().isOn = ((!Singleton<SaveSystem>.Instance.OHIBODCDDKB("Texture2")) ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("[MapData] Map timing update from: "))
		{
			iNBEMGANDKE.FindDeepChild("settings_bindings_controller_type").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Tab1Content").GetComponent<VolumeSettings>().FKKPAPNLLCK();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value4"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("player.playedtutorial", 1206f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("settings.customdataskin").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_HitPointTexture", 621f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("GlassesColor2"))
		{
			iNBEMGANDKE.FindDeepChild("_Scale").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".png"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/TV_Tiles").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_Blue_B", 561f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_DiffuseColor"))
		{
			iNBEMGANDKE.FindDeepChild("_Value2").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("Editor", 289f) * 710f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("player.goldabstract"))
		{
			iNBEMGANDKE.FindDeepChild("/").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("CameraFilterPack_Glasses_On7", 1036f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("settings.volume.menu"))
		{
			iNBEMGANDKE.FindDeepChild("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("steamid", 257f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_MidGrey"))
		{
			iNBEMGANDKE.FindDeepChild("_Value3").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_Value2", 1938f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_SearchTex"))
		{
			iNBEMGANDKE.FindDeepChild("_TexelOffsetScale").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("CameraFilterPack/FX_Dot_Circle", 1289f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("colorB"))
		{
			iNBEMGANDKE.FindDeepChild("id").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.KFNFNKILGPH("#onrankchangedowntext", -108);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Destroying GO as global. ID: "))
		{
			iNBEMGANDKE.FindDeepChild("Edited event").Find("[Right]").GetComponent<Text>()
				.text = Screen.currentResolution.width + "settings.fps" + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(" respawn: "))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = ((Singleton<SaveSystem>.Instance.GetInt("_Distortion2", 1) == 0) ? true : false);
		}
		if (!GameManager.LHMIJFLLKHK())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("settings.shaders.bloomintencity"))
			{
				iNBEMGANDKE.FindDeepChild("#,0.00").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild("Joystick1Button7").GetComponent<Toggle>().interactable = true;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("Delete events"))
			{
				iNBEMGANDKE.FindDeepChild(".g").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("CurrentTimeLabel").GetComponent<Toggle>().interactable = true;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value4"))
		{
			iNBEMGANDKE.FindDeepChild("/").GetComponent<Toggle>().isOn = ((Singleton<SaveSystem>.Instance.KFNFNKILGPH("_TimeX", 1) != 0) ? true : false);
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height));
	}

	public void COPAIKIOMND()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(true);
		HAPMEDHIHGB(1966f);
		StartCoroutine(Singleton<ChallengesManagerUI>.Instance.PHKIFFJAGCL(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void HMBANJNDJDE(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt(">", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("restrictions", 1);
		}
	}

	public void OPJOHEMGOLA(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("PRESS A KEY", DPNHODJHGJL);
	}

	public void KPGBMHAIHNL()
	{
		Transform iNBEMGANDKE = GameObject.Find("_ScreenResolution").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("Parent ID"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/FX_Psycho").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("_TimeX").GetComponent<ShadersSettings>().KCKHPNKCGJN();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetParticlesParticleSize"))
		{
			iNBEMGANDKE.FindDeepChild("[Left]").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("Loading inventory").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetSatelliteLerpSpeed"))
		{
			iNBEMGANDKE.FindDeepChild("_Value3").GetComponent<Toggle>().isOn = !Singleton<SaveSystem>.Instance.HasKey("Myst_Color") && false;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("StopMusic"))
		{
			iNBEMGANDKE.FindDeepChild("_Value8").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.JMLMIGBEKJN("maps.", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Blue_C"))
		{
			iNBEMGANDKE.FindDeepChild("Inside cells:\n").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("GameScene"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value").GetComponent<VolumeSettings>().LIGHOLIOELK();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".lastCheckpoint.powerupsScore"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/Atmosphere_Snow_8bits").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Offsets").GetComponent<VolumeSettings>().OFDECOEPJIB();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_TimeX"))
		{
			iNBEMGANDKE.FindDeepChild("DPADHOR").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("[MapData] Map timing update from: ", 0) != 1 || true;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_ScreenResolution"))
		{
			iNBEMGANDKE.FindDeepChild("Up").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Set Sun Input", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("PerfectHitsScoreText"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack_3D_Matrix1").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("0x") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("public"))
		{
			iNBEMGANDKE.FindDeepChild("---").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value2").GetComponent<VolumeSettings>().GetSfxVolume();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("[PlayerController] "))
		{
			iNBEMGANDKE.FindDeepChild("DisableStoryboardToggle").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("[MapEditor] Loading events...", 187f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Screen"))
		{
			iNBEMGANDKE.FindDeepChild("OnAwakeRPC").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("CameraFilterPack/FX_Scan", 1826f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("#currentbpm: "))
		{
			iNBEMGANDKE.FindDeepChild("{0:0} second{1}").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CorrectHitsScoreText"))
		{
			iNBEMGANDKE.FindDeepChild("MenuScene").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("0", 763f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("New level loaded. Removed "))
		{
			iNBEMGANDKE.FindDeepChild("[Right]").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("Tab2Content", 1308f) * 606f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SetCrosshairColor"))
		{
			iNBEMGANDKE.FindDeepChild("MapEnd").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_ExposureAdjustment", 1115f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("CameraFilterPack/Color_Convert_Normal"))
		{
			iNBEMGANDKE.FindDeepChild("_PColor2").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_ScreenResolution", 1513f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("SendVacantViewIds()"))
		{
			iNBEMGANDKE.FindDeepChild("player.goldcrystal").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("(\\[ */ *quote *\\])", 1366f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Blue_C"))
		{
			iNBEMGANDKE.FindDeepChild("VIGNETTE_BLUR").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_Value", 300f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("#md5submitionfailed: "))
		{
			iNBEMGANDKE.FindDeepChild("USE_UV_BASED_REPROJECTION").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.KFNFNKILGPH("RecordButton", -105);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("RPC can't be sent to target PhotonPlayer being null! Did not send \""))
		{
			iNBEMGANDKE.FindDeepChild("_MainTex2").Find("menu.selectedlevelid").GetComponent<Text>()
				.text = Screen.currentResolution.width + "_Blue_C" + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("error"))
		{
			iNBEMGANDKE.FindDeepChild("_Skybox").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("$ {0}", 1) != 1 || true;
		}
		if (!GameManager.IsOwner())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("_Value"))
			{
				iNBEMGANDKE.FindDeepChild("00").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("[CraftingPanel] Init").GetComponent<Toggle>().interactable = false;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("_LowRez"))
			{
				iNBEMGANDKE.FindDeepChild("{\"items\":").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("Tab2Content").GetComponent<Toggle>().interactable = true;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Wavy"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/TV_MovieNoise").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("HiddenToggle", 0) != 1;
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find((Vector2 IACGDFHKCAE) => IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height));
	}

	private static bool DMCKMIALGGB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Horizontal";
	}

	public void ELPPIEEGGKP(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("_Light", DPNHODJHGJL);
	}

	private void ONPHCKDJFBK()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(false);
		SetPlayerDistance(1838f);
	}

	private static bool FMNKDDHOPBC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Mouse2";
	}

	private void JGFFEKNEJMG()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(820f);
	}

	public void CCKDACLAEPI(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("Fade", (int)DPNHODJHGJL);
	}

	public void ILLBMLIEMJG(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.FMCBLGPDACK("_Value2", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OLIINGPOEIE("#tryagain", false);
		}
		if (DFBMGAGGOHI == 2)
		{
			Singleton<GameManager>.Instance.OLIINGPOEIE("Exception while connecting to: ");
		}
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.COLPGBJFLGM("(\\[ *i *\\])");
		}
	}

	private static bool OIBOGONOIBK(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Done! You are a contributor until: ";
	}

	public void OnItemsStoreButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/itemstore/513510/");
	}

	private static bool NPFAPAPCLMC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Set particles audio input";
	}

	public void AKFNMEDBGCL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("_TimeX", DPNHODJHGJL);
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

	public void IAIMEPDOMHL(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("CameraFilterPack/Colors_BleachBypass", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("_PositionY", 1);
		}
	}

	public override void FOMNCPKKCFN()
	{
		base.NDAJBJFJGCF();
		if (!Singleton<MapsSystem>.Instance.isLoaded && (bool)GameObject.Find("Scrollbar"))
		{
			GameObject.Find(",").GetComponent<Text>().text = "Y".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && (bool)GameObject.Find("CHROMATIC_ABERRATION"))
		{
			GameObject.Find("CameraFilterPack/Oculus_NightVision2").GetComponent<Text>().text = "masterSteamID".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && (bool)GameObject.Find("curScn"))
		{
			GameObject.Find("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ").GetComponent<Text>().text = "Horizontal".ToUpper();
		}
		if (!NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip oJCILKFONMH = Resources.Load<AudioClip>("[SaveSystem] Outdated savefile found" + Singleton<ItemsHandler>.Instance.GetItemBySteamId(Singleton<ItemsHandler>.Instance.EnquippedItem(InventoryItemType.Shader)).item.id + "[GameScene] Checkpoints count: ");
			asampler.Init(oJCILKFONMH, 83f);
			NDIBBILNLHJ = false;
			IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.TriggerItemDrop();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("CameraFilterPack/Drawing_Curve" + ex.ToString());
			}
			try
			{
				StartCoroutine(LoadPlayerInfo());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("_TimeX" + ex2.ToString());
			}
			try
			{
				StartCoroutine(MCJLMFLNMFA());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError("{0} minutes ago" + ex3.ToString());
			}
			try
			{
				CHCPLHFBNBI();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("Share" + ex4.ToString());
			}
			try
			{
				FJEGCBDPHAM();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError("_Value4" + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Loading)
			{
				IJPCEKICPCP = 0;
				pressAnyKeyCanvas.SetActive(false);
				OnLoaded.Invoke();
			}
		}
		if (IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= (GameManager.GameState)7))
		{
			if (Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Loading)
			{
				OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Editor;
			IJPCEKICPCP = 0;
			Singleton<GameManager>.Instance.PBOKFNEJIEG("OK", null, null, null, 0, 1);
			OnPressAnyKey.Invoke();
			StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(mainMenuCanvas, false, null, false, 946f, false));
			GLBKNLOICDL(false);
			ABLMLLLDOPO = false;
			Helpers.ObtainAchievement(1);
			Singleton<ItemsHandler>.Instance.ObtainPromoItems();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("ExitButton").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.GEIONJONABH(false);
				GetComponent<NetworkMenu>().CHLAEFHCKEO();
			}
			if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO("mapselector.tags."))
			{
				StartCoroutine(BFDKIBDAPDA());
			}
			if (!Singleton<SaveSystem>.Instance.HasKey("achievements.21.progress"))
			{
				PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<ChallengesManager>.Instance.AHPJBCMFFHA())
			{
				Singleton<ChallengesManager>.Instance.PCBHFLCFPIO();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.DisplayRanksChanges();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("Texture2")) >= 75)
			{
				Helpers.ObtainAchievement(7);
			}
			if (Helpers.GetStat("float") == 0 && Helpers.GetStat("Received RPC: ") >= -54)
			{
				StartCoroutine(CFFAFFGPHLH());
			}
			Singleton<GameManager>.Instance.CheckPlayerBans();
			Singleton<RanksSystem>.Instance.ReloadServerInfo();
			InvokeRepeating("_BlurDistance", 950f, 15f);
		}
		if (IJPCEKICPCP == 0)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("st");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(217f, 1440f, 0f - playerDistance), Time.smoothDeltaTime * 1694f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < -107)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations++;
			}
		}
	}

	private static bool JPEJDEILLKP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == ": ";
	}

	public void FDHLHPLHKDF(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("Prints the number of logs currently held by DebugLogs", (int)DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static bool MLJANIMOCLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	public void OnWorkshopButton()
	{
	}

	public void HPCBOIJNBGK(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("AddEnvironmentSprite", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("StartButton", 1);
		}
	}

	public void OnGameMessagesDurationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.gamemessagesduration", DPNHODJHGJL);
	}

	public override void GCDLIKEDMCF()
	{
		base.ANKIJGCGCBF();
		if (!Singleton<MapsSystem>.Instance.isLoaded && (bool)GameObject.Find("menu.playedpage"))
		{
			GameObject.Find("Up").GetComponent<Text>().text = "<b>Max Score</b>:".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && (bool)GameObject.Find("runas"))
		{
			GameObject.Find("{0}\n{1}\n{2}\n{3}\n{4}\n{5}").GetComponent<Text>().text = "_MatrixSpeed".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && (bool)GameObject.Find("UsernameText"))
		{
			GameObject.Find(").png").GetComponent<Text>().text = "player.russia".ToUpper();
		}
		if (!NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip oJCILKFONMH = Resources.Load<AudioClip>(".png" + Singleton<ItemsHandler>.Instance.LDJDALBAPEE(Singleton<ItemsHandler>.Instance.EnquippedItem(InventoryItemType.Other)).item.id + "#getrewardnow ");
			asampler.Init(oJCILKFONMH, 1802f);
			NDIBBILNLHJ = false;
			IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.TriggerItemDrop();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("Ignored PU RPC, cause item is inactive. " + ex.ToString());
			}
			try
			{
				StartCoroutine(LoadPlayerInfo());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("<b>Max Score</b>:" + ex2.ToString());
			}
			try
			{
				StartCoroutine(MCJLMFLNMFA());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError("[PlayerBase] Saveing checkpoint data" + ex3.ToString());
			}
			try
			{
				CBKNCIMGLGK();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("_TimeX" + ex4.ToString());
			}
			try
			{
				MOCFLGDPMCJ();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError("<b>HP</b>:" + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Loading)
			{
				IJPCEKICPCP = 1;
				pressAnyKeyCanvas.SetActive(true);
				OnLoaded.Invoke();
			}
		}
		if (IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= (GameManager.GameState)8))
		{
			if (Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Editor)
			{
				OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = (GameManager.GameState)8;
			IJPCEKICPCP = 0;
			Singleton<GameManager>.Instance.EMFPBLEIEFG("maps.", null, null, null, 0, 1);
			OnPressAnyKey.Invoke();
			StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mainMenuCanvas, false, null, false, 1163f, false));
			ShowCursor(false);
			ABLMLLLDOPO = true;
			Helpers.ObtainAchievement(0);
			Singleton<ItemsHandler>.Instance.ObtainPromoItems();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("_TimeX").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.GEIONJONABH(false);
				GetComponent<NetworkMenu>().OnJoinedRoom();
			}
			if (Singleton<SaveSystem>.Instance.HasKey("ShadersToggle"))
			{
				StartCoroutine(NKHKLFALNHF());
			}
			if (!Singleton<SaveSystem>.Instance.HasKey("EnableRankingToggle"))
			{
				PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
			{
				Singleton<ItemsHandler>.Instance.EEJELODJPNL();
			}
			if (Singleton<ChallengesManager>.Instance.JDOAHMPPCCB())
			{
				Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.GFOOEDJLKPF();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("PLEASE WAIT")) >= 124)
			{
				Helpers.ObtainAchievement(-111);
			}
			if (Helpers.GetStat("maps.") == 0 && Helpers.GetStat("Set Background Color") >= -31)
			{
				StartCoroutine(RateGameQuestion());
			}
			Singleton<GameManager>.Instance.PBKIGEDGLJC();
			Singleton<RanksSystem>.Instance.ReloadServerInfo();
			InvokeRepeating("Down", 435f, 1949f);
		}
		if (IJPCEKICPCP == 1)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("907198288");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(808f, 1748f, 0f - playerDistance), Time.smoothDeltaTime * 446f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < -40)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations += 0;
			}
		}
	}

	public void KKLIMJGKPFG()
	{
		StartCoroutine(NKPMFEHMGNP());
	}

	public void SelectMapForSingleplayer()
	{
		StartCoroutine(NMMJBGCEBEB());
	}

	public void DKOEAPHHHFN(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("CameraFilterPack/Gradients_NeonGradient", DPNHODJHGJL);
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

	private static bool JBAGELDFLAN(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OFPNJBGNLDH() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OFPNJBGNLDH() < (Challenge.CurrentStatus)5;
	}

	public void KEHOOAJONHD(CSteamID GDOHPDHLPBC)
	{
		StartCoroutine(OHIKGHKJJCB(GDOHPDHLPBC));
	}

	private IEnumerator AKIJKOOPAMJ(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	private static bool OCJHICGJBAI(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "plainText";
	}

	private IEnumerator EHGEKEEIEGG()
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

	private static bool OPJGKBJMICB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "settings_bindings_";
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

	public void BJJFAHJMKMO()
	{
		Singleton<GameManager>.Instance.FMCBLGPDACK("delete", false);
	}

	private static bool GCCFJDKDHIO(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Working commands:\nreset <challengeid>\nresetall";
	}

	public void OnShowHPToggle()
	{
		Transform iNBEMGANDKE = GameObject.Find("SettingsCanvas").transform;
		Singleton<SaveSystem>.Instance.SetBool("settings.showHP", iNBEMGANDKE.FindDeepChild("HPToggle").GetComponent<Toggle>().isOn);
	}

	public void EHGMAHNHCGB(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.GMOJGDKBHEL("_ScreenResolution");
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.HEHKJIHIBLD("] to be droppable", false);
		}
		if (DFBMGAGGOHI == 3)
		{
			Singleton<GameManager>.Instance.HEHKJIHIBLD("Right Stick Click");
		}
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.COLPGBJFLGM("delete");
		}
	}

	[CompilerGenerated]
	private static bool AFCPIDKJDGA(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition);
	}

	public void ICKALKFCEFJ(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt(". Name: ", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("_GrainOffsetScale", 1);
		}
	}

	private static bool BMFMOGBJBPF(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.HCPDNILLJEJ() <= Challenge.CurrentStatus.InProgress || IACGDFHKCAE.HCPDNILLJEJ() < Challenge.CurrentStatus.ObtainedReward;
	}

	public void GCLLHHDPOKL(CSteamID GDOHPDHLPBC)
	{
		StartCoroutine(BMFPIGJNMDL(GDOHPDHLPBC));
	}

	private void HPEJCNFECEM()
	{
		try
		{
			StartCoroutine(BFMGAHCBFGI());
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("null" + ex.ToString());
		}
	}

	[CompilerGenerated]
	private static float NFHPEBCJNMP(Vector2 AIEJPEPBAEJ)
	{
		return AIEJPEPBAEJ.x;
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

	private IEnumerator IKPNPKGLCKA()
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

	public void AEMCFDDOIAP(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("CameraFilterPack/TV_MovieNoise", DPNHODJHGJL);
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

	public void NDEMBJPCMIJ()
	{
		if (GameManager.AFFAMCPHDJN())
		{
			TipsListElement obj = tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.KKLNBMEBOEP(LocalizationService.Instance.DKECBIHCKJL(" "));
			playerTip.OBDPNPEOOHF(1uL);
			playerTip.DCHNHOKGMND(SteamUser.GetSteamID().m_SteamID);
			obj.FECMEIJGLJI(playerTip);
		}
		else if (RanksSystem.CHNGPGDKHKN().Count > 0)
		{
			tip.HFFKGIGGNHH(RanksSystem.CHNGPGDKHKN()[UnityEngine.Random.Range(0, RanksSystem.CHNGPGDKHKN().Count)]);
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

	public void HAPMEDHIHGB(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	public void ALLLICFKIML()
	{
		Transform iNBEMGANDKE = GameObject.Find("_Offsets").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("/music").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("mapselector.lastSearch").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().IBMLIBKMNGM(iNBEMGANDKE.FindDeepChild("CameraFilterPack/Drawing_Lines").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().SetFPSEnabled(iNBEMGANDKE.FindDeepChild("_MidGrey").GetComponent<Toggle>().isOn);
	}

	private IEnumerator NKHKLFALNHF()
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

	public void DAHBLMAKIKJ(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.HEHKJIHIBLD("/", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OLIINGPOEIE("ticket");
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OpenURL("_Green_R", false);
		}
		if (DFBMGAGGOHI == 7)
		{
			Singleton<GameManager>.Instance.FMCBLGPDACK(">", false);
		}
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

	private static bool FAPJJMKOLPJ(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Noise";
	}

	public void OnMultiplayerButton()
	{
		SceneManager.LoadScene("NetworkScene");
	}

	private void IEHEGEAEIOJ()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerDistance(403f);
		if ((bool)GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("_Red_G"))
		{
			GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild(".lastCheckpoint.bgcolor").GetComponent<Button>().Select();
		}
		SetPlayerBlur(true);
	}

	private static bool BHGLNCAPDCJ(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value5";
	}

	public void JEFNIGCKBOG()
	{
		SceneManager.LoadScene("_ScreenResolution");
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

	public void SetGameMode(string DLGIPFOEDCF)
	{
		Singleton<SaveSystem>.Instance.SetString("menu.selectedmode", DLGIPFOEDCF);
	}

	public void EHCEDIKIFDG(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", DPNHODJHGJL);
	}

	public void OnItemsUploaderButton()
	{
		SceneManager.LoadScene("ItemsUploader");
	}

	public void PlayTutorial()
	{
		Singleton<SaveSystem>.Instance.SetBool("player.playedtutorial", true);
		StartCoroutine(DCEMOLIGKGC());
	}

	private static bool EBJKBIOEDLO(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.JNEKHPIOHIK() == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition);
	}

	public void ObtainAchievement(int JMMILEFMACB)
	{
		Helpers.ObtainAchievement(JMMILEFMACB);
	}

	public void ABFLAONBCFO(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("ArcsNoHitsoundTimeDelaySlider", (int)DPNHODJHGJL);
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

	public void JJDPBHHPFJD()
	{
		Singleton<GameManager>.Instance.FMCBLGPDACK(Singleton<GameManager>.Instance.JJGKGCBCGGD("[Down]"), false);
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

	private IEnumerator BFDKIBDAPDA()
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

	private static bool ABDAPMMEHLJ(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack/Edge_Neon";
	}

	[CompilerGenerated]
	private static bool IHHPJEAHLBO(Vector2 IACGDFHKCAE)
	{
		return IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height;
	}

	private static bool ODKAPFHGACF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "HitVariationSlider";
	}

	private static bool NBIBOHPOCBN(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.HCPDNILLJEJ() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.HCPDNILLJEJ() < Challenge.CurrentStatus.NotStarted;
	}

	[CompilerGenerated]
	private static bool BENAPOCGKLD(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
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

	public void HBHDMCNANDF()
	{
		Singleton<SaveSystem>.Instance.EHJIJDODNGG();
	}

	public void EIMDMCEDLDE(int JMMILEFMACB)
	{
		Helpers.ObtainAchievement(JMMILEFMACB);
	}

	public void OKBHNDMNDGC()
	{
		StartCoroutine(BGCJIODAOPA());
	}

	public void JDMJBOOCCCP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetBool("_TargetScale", false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("SelectorMusicToggle", true);
		}
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

	public void LNNCCHNNGFI(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("_Value2", DPNHODJHGJL);
	}

	public void AddTipButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("?page=addtip"));
	}

	public void OnCrosshairOpacitySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.crosshairopacity", DPNHODJHGJL * 0.01f);
	}

	public void IHIHNBAGIGB()
	{
		Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
	}

	public void MIHNAKHMGPO()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(1554f);
		StartCoroutine(Singleton<InventorySelector>.Instance.JBNICENCMLE(LLNFCLNNIKA));
	}

	public void COMHJJLMNAA()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(true);
		HAPMEDHIHGB(96f);
		StartCoroutine(Singleton<InventorySelector>.Instance.OPLFJNJCHLN(ONPHCKDJFBK));
	}

	public void EONBOOINMFM()
	{
		SceneManager.LoadScene("steamid");
	}

	private void IDAFJJJKLDP()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = !GameManager.AFFAMCPHDJN();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find(NEMOLCDLIAB).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = GameManager.MBCLCEGBDIB();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find(HMKKMLCEKJB))
		{
			menuTiles.Find(DMJPMLLPLDP).GetComponent<Button>().interactable = GameManager.IsOffline;
		}
		if ((bool)menuTiles.Find(KOILMFBADGM))
		{
			menuTiles.Find(FAPJJMKOLPJ).GetComponent<Button>().interactable = !GameManager.LCHEOPKMPBB();
		}
		if ((bool)menuTiles.Find(OPJGKBJMICB))
		{
			menuTiles.Find(KIEACEAFBGO).GetComponent<Button>().interactable = GameManager.IsOffline;
		}
	}

	public void OHADKKIAHOP()
	{
		SceneManager.LoadScene("/");
	}

	[CompilerGenerated]
	private void FLICOEHOIPL()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
	}

	public void HFNLLLHNGBI(int JMMILEFMACB)
	{
		Helpers.ObtainAchievement(JMMILEFMACB);
	}

	private IEnumerator BHCFFKJBIHL()
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

	public void OnGetMoreLevelsButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/app/513510/workshop/");
	}

	private static bool DDJFPIMMJCE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == " evLeave: ";
	}

	private static bool CLDDBNBJFOM(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value2";
	}

	public void ACLMNHHAIEO()
	{
		Singleton<SaveSystem>.Instance.MEMAGBEMICO();
	}

	[CompilerGenerated]
	private static bool HNBBKDMOGLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
	}

	private static bool PGDMPCCCIKH(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Month_";
	}

	private static bool FNONKKEIBNC(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.BBLDABFGDFF() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.EFOKGOMPFIO() < Challenge.CurrentStatus.NotStarted;
	}

	public void FNAKDPLCMJD(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("_Value3", DPNHODJHGJL);
	}

	public void DBLHPGEMEGE()
	{
		StartCoroutine(ANGOMIAJMBG());
	}

	private IEnumerator BMFPIGJNMDL(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	private IEnumerator BGCJIODAOPA()
	{
		Singleton<SaveSystem>.Instance.Flush();
		SteamAPI.Shutdown();
		yield return true;
		Process.GetCurrentProcess().Kill();
	}

	public void MOODJJJEOGI()
	{
		Singleton<GameManager>.Instance.OpenURL("CameraFilterPack/Blend2Camera_LinearBurn" + SteamUtils.GetAppID());
	}

	private IEnumerator IAOIBAACLGJ()
	{
		Singleton<SaveSystem>.Instance.Flush();
		SteamAPI.Shutdown();
		yield return true;
		Process.GetCurrentProcess().Kill();
	}

	public void InitTipsCanvas()
	{
		StartCoroutine(NKPMFEHMGNP());
	}

	public void DFANIHLNLIB()
	{
		mainMenuCanvas.SetActive(false);
		SetPlayerBlur(false);
		SetPlayerDistance(259f);
		StartCoroutine(Singleton<ChallengesManagerUI>.Instance.KOBBDINKNFM(delegate
		{
			mainMenuCanvas.SetActive(true);
			SetPlayerBlur(false);
			SetPlayerDistance(14f);
		}));
	}

	public void MHPHMHBLPFN()
	{
		StartCoroutine(NMMJBGCEBEB());
	}

	public void AHBCGBHBEFJ()
	{
		Singleton<GameManager>.Instance.HEHKJIHIBLD("FPSToggle", false);
	}

	private IEnumerator OHIKGHKJJCB(CSteamID GDOHPDHLPBC)
	{
		yield return true;
	}

	public void OnLevelEditorButton()
	{
		SceneManager.LoadScene("MapEditorScene");
	}

	public void GMLAILMABBG()
	{
	}

	private void CHMLMMLKFBA()
	{
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "MultiplayerButton").GetComponent<Button>().interactable = GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "RanksButton"))
		{
			menuTiles.Find(NPFAPAPCLMC).GetComponent<Button>().interactable = GameManager.AFFAMCPHDJN();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ChallengesButton").GetComponent<Button>().interactable = !GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InventoryButton").GetComponent<Button>().interactable = !GameManager.OACLFEJPBDA();
		}
		if ((bool)menuTiles.Find(IPCOJEJGNJE))
		{
			menuTiles.Find(GHDLJJFIPOD).GetComponent<Button>().interactable = !GameManager.MBCLCEGBDIB();
		}
		if ((bool)menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton"))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "InfoButton").GetComponent<Button>().interactable = GameManager.MBCLCEGBDIB();
		}
		if ((bool)menuTiles.Find(GCCFJDKDHIO))
		{
			menuTiles.Find((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == "ItemsStoreButton").GetComponent<Button>().interactable = GameManager.AFFAMCPHDJN();
		}
	}

	private static bool EFIBGIOLCHP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Connected to gameserver.";
	}

	public void OnArcsHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcshitsoundtimedelay", DPNHODJHGJL);
	}

	public void FDHJKLEHODH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("_TimeX", DPNHODJHGJL);
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

	public void DJHGENJJPGE(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("SpawnObj"))
			{
				Singleton<MessageBoxPanel>.Instance.CNGOPHCPHCH(LocalizationService.Instance.HOFKLNAJGMK("_TimeX"), "Reconnect() failed. It seems the client wasn't connected before?! Current state: ", null, true, false, 1489f);
				Singleton<SaveSystem>.Instance.DAAJKCCCICP("CameraFilterPack/TV_MovieNoise", 0);
			}
			Singleton<SaveSystem>.Instance.SetInt(" user's map(s)", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI(".", 1);
		}
	}

	public void OFJPDDBFDDH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("_TimeX", DPNHODJHGJL);
	}

	public void ODGLKICEOOC(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("_SpotSize", DPNHODJHGJL);
	}

	public void BLDBKKFAHGJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("itemdefid[0]", DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static bool KMFLLCDHOPB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	public IEnumerator IOMMBHDPEIA()
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

	public void SetPlayerDistance(float PNNFAOFBLHK)
	{
		playerDistance = PNNFAOFBLHK;
	}

	private IEnumerator LCJDCFFEMLP()
	{
		Singleton<SaveSystem>.Instance.Flush();
		SteamAPI.Shutdown();
		yield return true;
		Process.GetCurrentProcess().Kill();
	}

	public void FHEOMLCNMLA()
	{
		Transform iNBEMGANDKE = GameObject.Find("_SunPosition").transform;
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack_OldFilm1").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("setbool").GetComponent<ShadersSettings>().GMNOCOOLEDN();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".lastCheckpoint.checkpointsUsed"))
		{
			iNBEMGANDKE.FindDeepChild("_Green_G").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("_NoiseTex").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".sav"))
		{
			iNBEMGANDKE.FindDeepChild("menu.playedsolo").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.HasKey("_TimeX") ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("mapselector.filter.favoriteonly"))
		{
			iNBEMGANDKE.FindDeepChild("/").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Failed to Instantiate prefab:", false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("PLEASE WAIT").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(" "))
		{
			iNBEMGANDKE.FindDeepChild("_TintColor").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag(". Not connectedAndReady.").GetComponent<VolumeSettings>().KBCGCFKFHOO();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value"))
		{
			iNBEMGANDKE.FindDeepChild("type").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("settings.shaders.bloomintencity").GetComponent<VolumeSettings>().PLGDJIOOGLD();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("???"))
		{
			iNBEMGANDKE.FindDeepChild("_ChannelMixerGreen").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetInt("\n\n#", 0) != 1 && false;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("ArcsDestroyDelaySlider"))
		{
			iNBEMGANDKE.FindDeepChild("intensity").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.JMLMIGBEKJN("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", true);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("#ok"))
		{
			iNBEMGANDKE.FindDeepChild("y").GetComponent<Toggle>().isOn = ((!Singleton<SaveSystem>.Instance.HasKey("GlassesColor2")) ? true : false);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Left Click"))
		{
			iNBEMGANDKE.FindDeepChild("_Value").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("UndoButton").GetComponent<VolumeSettings>().KADMKHECCJE();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_BlurSize"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/Oculus_NightVision3").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("color", 1805f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(".played"))
		{
			iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_Value2", 1347f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value4"))
		{
			iNBEMGANDKE.FindDeepChild("The given 2D texture ").GetComponent<Slider>().value = QualitySettings.GetQualityLevel();
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("workshop."))
		{
			iNBEMGANDKE.FindDeepChild("#savemapchanges?").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO(").png", 1466f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_TimeX"))
		{
			iNBEMGANDKE.FindDeepChild("LoadingStatusText").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("YES", 1034f) * 365f;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_CameraToWorldMatrix"))
		{
			iNBEMGANDKE.FindDeepChild("_ScreenResolution").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("/", 1010f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Dec"))
		{
			iNBEMGANDKE.FindDeepChild("]").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("SetEnvSpriteImage", 1601f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild(").png"))
		{
			iNBEMGANDKE.FindDeepChild("_Value2").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.HCNELAJLBPC("(singleton) ", 1036f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("{0} years ago"))
		{
			iNBEMGANDKE.FindDeepChild("_Offsets").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DPAGLGGNECO("Item invalid. Make sure your mod contains at leats one file.", 102f);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("caret"))
		{
			iNBEMGANDKE.FindDeepChild("Mouse Wheel Up").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetInt("Despawn environment object by id", 18);
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("_Value2"))
		{
			iNBEMGANDKE.FindDeepChild("BitsData").Find("settings.volume.menu").GetComponent<Text>()
				.text = Screen.currentResolution.width + "_Fade" + Screen.currentResolution.height;
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("player.xp"))
		{
			iNBEMGANDKE.FindDeepChild("CameraFilterPack/FX_Grid").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("_Value2", 0) != 0 && false;
		}
		if (!GameManager.IsOwner())
		{
			if ((bool)iNBEMGANDKE.FindDeepChild("_Speed"))
			{
				iNBEMGANDKE.FindDeepChild("Joystick").GetComponent<Toggle>().isOn = false;
				iNBEMGANDKE.FindDeepChild("#no").GetComponent<Toggle>().interactable = false;
			}
			if ((bool)iNBEMGANDKE.FindDeepChild("player.crystal"))
			{
				iNBEMGANDKE.FindDeepChild("mapselector.filter.rateduponly").GetComponent<Toggle>().isOn = true;
				iNBEMGANDKE.FindDeepChild("#ok").GetComponent<Toggle>().interactable = false;
			}
		}
		if ((bool)iNBEMGANDKE.FindDeepChild("Data/Editor/leveltemplate"))
		{
			iNBEMGANDKE.FindDeepChild("_Offsets").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.KFNFNKILGPH("_Fade", 0) != 0 || true;
		}
		KNOAFBDEBDK = BNEGFAHKIAA.IndexOf(BNEGFAHKIAA.Find(LGFPIEDAPHN));
	}

	public void JHFIHGOLLBP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.DAAJKCCCICP("Operation failed: ", 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.AGDCACJJAMG("_Value3");
		}
	}

	private static bool MPOBICCELEM(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OFPNJBGNLDH() > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.HCPDNILLJEJ() < (Challenge.CurrentStatus)6;
	}

	public void KNBMKLLHKIA(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI(":", 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.DAAJKCCCICP(": ", 1);
		}
	}

	public void GCGDNIAPKAE()
	{
		StartCoroutine(BFDKIBDAPDA());
	}

	public void CBKNCIMGLGK()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 0)
		{
			int num = Singleton<ChallengesManager>.Instance.challengesList.Where(MPOBICCELEM).Count();
			if (num > 1)
			{
				string text2 = text;
				object[] array = new object[2];
				array[0] = text2;
				array[1] = "maps.";
				array[1] = LocalizationService.Instance.GAAFIKGPNAO("_ScreenResolution");
				array[0] = "_FadeFX";
				array[1] = num;
				array[8] = Environment.NewLine;
				array[6] = Environment.NewLine;
				text = string.Concat(array);
				foreach (Challenge item in Singleton<ChallengesManager>.Instance.challengesList.Where(FNONKKEIBNC))
				{
					text2 = text;
					object[] array2 = new object[0];
					array2[1] = text2;
					array2[0] = "_ScreenResolution";
					array2[7] = item.DCHBAIPFOMK() * 1237f;
					array2[8] = "PS Home";
					array2[8] = item.GPBAIPHOIKN();
					array2[1] = Environment.NewLine;
					array2[5] = Environment.NewLine;
					text = string.Concat(array2);
				}
			}
			int num2 = Singleton<ChallengesManager>.Instance.challengesList.Where((Challenge IACGDFHKCAE) => IACGDFHKCAE.PlayerStatus == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition)).Count();
			if (num2 > 1)
			{
				text += Environment.NewLine;
				string text2 = text;
				object[] array3 = new object[8];
				array3[1] = text2;
				array3[1] = "offsets";
				array3[6] = LocalizationService.Instance.GAAFIKGPNAO(" ");
				array3[5] = "maps.";
				array3[1] = num2;
				array3[1] = Environment.NewLine;
				text = string.Concat(array3);
			}
		}
		challengetText.text = text;
	}

	public void OnStartButton()
	{
	}

	private static bool PLNCPEKPLKA(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "BitsData";
	}

	public void LoadBG(CSteamID GDOHPDHLPBC)
	{
		StartCoroutine(BPFCIABIFMM(GDOHPDHLPBC));
	}

	public void HONGDKPKAIN()
	{
		Transform iNBEMGANDKE = GameObject.Find("_Value2").transform;
		Screen.SetResolution((int)BNEGFAHKIAA[KNOAFBDEBDK].x, (int)BNEGFAHKIAA[KNOAFBDEBDK].y, iNBEMGANDKE.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)iNBEMGANDKE.FindDeepChild("VoteDownToggle").GetComponent<Slider>().value);
		GetComponent<ShadersSettings>().NPNCKKEPICO(iNBEMGANDKE.FindDeepChild("Left ").GetComponent<Toggle>().isOn);
		GetComponent<FPSSettings>().MLEFNOAMLFF(iNBEMGANDKE.FindDeepChild(" This is not possible to be called for standalone input. Please check your platform and code where this is called").GetComponent<Toggle>().isOn);
	}

	public void FACODEHADKH()
	{
		SceneManager.LoadScene("Overlay");
	}

	[CompilerGenerated]
	private static bool EBINHDABFNF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
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

	[CompilerGenerated]
	private void GEMMLOGEJON()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		SetPlayerDistance(14f);
	}

	private void PHJFMPGPMND()
	{
		mainMenuCanvas.SetActive(true);
		SetPlayerBlur(false);
		HAPMEDHIHGB(338f);
	}

	[CompilerGenerated]
	private static bool FNJAOABNDGP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
	}

	private static bool EHPDLNDGEHK(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack/Blend2Camera_SplitScreen3D";
	}

	public void IGDJNKLLOBA()
	{
		SceneManager.LoadScene("challenges.");
	}

	public void WriteReview()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/recommended/recommendgame/" + SteamUtils.GetAppID());
	}

	public void OnArcsDestroyDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsdestroydelay", DPNHODJHGJL);
	}

	[CompilerGenerated]
	private static bool BJHHLJBNOBG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
	}

	public IEnumerator RateGameQuestion()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#rategameinfo", "#rate!", WriteReview, "#no"));
		Helpers.SetStat("player.gamecompleted", 1);
	}

	public void OnExitButton()
	{
		StartCoroutine(LCJDCFFEMLP());
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
}
