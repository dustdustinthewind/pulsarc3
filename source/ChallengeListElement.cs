// ChallengeListElement
using System;
using System.Collections;
using System.Globalization;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeListElement : MonoBehaviour
{
	public Text infoText;

	public Text timeText;

	public Text rewardText;

	public Image bg;

	public Slider progressBar;

	public GameObject lockedCanvas;

	public Text actionText;

	private ulong DLNONMLNOJJ;

	private DateTime DKJCKNPNPAB;

	private DateTime BLKCBHFNLGB;

	private bool IHEDNJNCIPM;

	public void PFMJPIJONIP(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.BBPGJKOIAKM();
		EOBIHAGLMIK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.GetProgress();
		PKNEKFHMCOJ();
	}

	private void JAMNLCBMABC()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).OLPHAJDLEDK()))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(true);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(true);
		}
	}

	private void KKMMFEPKFDJ()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Please specify a map name or buildID").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-109];
		array[1] = "maps.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("DPADHOR");
		array[8] = "menu.tabid";
		array[1] = challenge.AMBFPMPCHFE();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[2] = "[GameEvent] Exeption:";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL("Texture3");
		array[1] = "[PlayerBase] Loaded music";
		array[100] = LocalizationService.Instance.HOPMEAJKPHL("Pop" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.KIJCJELFFPO();
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("DifficultyBG").ToUpper() + text2;
		BLBBEACCFGG();
	}

	public void MDCFIHDPLIG()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("PPI: ").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("[NetworkManager] Updating rooms...").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("skin.hit_normal").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("settings.volume.editor").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.InProgress)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("LevelURLInputField").ToUpper();
		}
	}

	private void BLBBEACCFGG()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(true);
		}
	}

	public void Init(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.id;
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.GetProgress();
		MIBKLDAKMLF();
	}

	private void PKNEKFHMCOJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(true);
		}
	}

	public void GOAGFAFGBDL(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.BBPGJKOIAKM();
		LOELNKLKDPO();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		MIBKLDAKMLF();
	}

	public void OnClick()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(3.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ), true);
				OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				OEFGNIAHHNH();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.TryGetReward(DLNONMLNOJJ);
			}
		}
	}

	private void PNBDOOFABJB()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Params1").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_ReflectionTexture3").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[111];
		array[0] = "JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("LevelNameInputField");
		array[6] = "Set Particle Size";
		array[7] = challenge.IGAHKBHFBNE();
		array[0] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[5] = "Bad parameters for setbool! Use <key> <value>";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("Clear Environment");
		array[4] = "Tab2Content";
		array[124] = LocalizationService.Instance.GetLocalizatedText("_DisplayVelocityScale" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("maps.").ToUpper() + reward;
		MHIKFCHKCPP();
	}

	public IEnumerator BEBNOKFLJPH()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator KDMANOEMOCA()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void POEMOLBJDLG()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value3").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("ready").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("ArcsNoHitsoundTimeDelaySlider").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_ColorBuffer").ToUpper();
		}
	}

	public void FIMJABKECNG(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.HJCBNLFCNAM();
		CIPOJCALGKN();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		INLBJELNLAL();
	}

	public IEnumerator AKHCOBHHGJP()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void NKLNGGOHLMO(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.HJCBNLFCNAM();
		POBAEGNACOL();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		JAMNLCBMABC();
	}

	private void OEFGNIAHHNH()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktoacceptchallenge]").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktogetreward]").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		infoText.text = "<b>" + LocalizationService.Instance.GetLocalizatedText("#task") + ":</b> " + challengeByID.info + Environment.NewLine + Environment.NewLine + "<b>" + LocalizationService.Instance.GetLocalizatedText("#status") + ":</b> " + LocalizationService.Instance.GetLocalizatedText("#" + challengeByID.PlayerStatus.ToString().ToLower());
		string reward = challengeByID.reward;
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("#reward: ").ToUpper() + reward;
		MIBKLDAKMLF();
	}

	public IEnumerator DKGBFNCOAEO()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void INLBJELNLAL()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(false);
		}
	}

	private void GDAFKPFKGIM()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("offsets").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Atmosphere_Fog").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[102];
		array[1] = "LostLive";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL(".lastCheckpoint.checkpointsUsed");
		array[3] = "event";
		array[5] = challenge.IGAHKBHFBNE();
		array[3] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "pointBuffer";
		array[1] = LocalizationService.Instance.GetLocalizatedText("Noise shaders are not set up! Disabling noise effect.");
		array[6] = "_Extra";
		array[-47] = LocalizationService.Instance.GetLocalizatedText("]" + challenge.PlayerStatus.ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.NJPNFKMPJNE();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("Joystick1Button5").ToUpper() + text2;
		MHIKFCHKCPP();
	}

	public IEnumerator PAKPHKPDKGE()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void OCPFHCPEFCM()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.MBJHDNCOGIK(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ));
				LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				MDDHIDGCIMK();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EEIMLBLFCCA(DLNONMLNOJJ);
			}
		}
	}

	public void ALKBNPMCEOM(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.AKJKDMMKNFO();
		LOGGOJBMPCG();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		ELFIMAMIENI();
	}

	private void APFLHIECIAE()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).PNHHKLBLPEB()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(true);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(true);
		}
	}

	public void LIMLHBICMPL()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1138.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.MIDCODCLJLE(Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ));
				PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.InProgress && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				PNBDOOFABJB();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(DLNONMLNOJJ);
			}
		}
	}

	private void EOBIHAGLMIK()
	{
		if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("CompletedLevel").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("#ok").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-93];
		array[1] = "Object ID. Case-Sensitive";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("y");
		array[7] = "Set Sun Colors";
		array[4] = challenge.info;
		array[8] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[4] = "Items/";
		array[1] = LocalizationService.Instance.GetLocalizatedText("settings.selectormapsperpage");
		array[0] = " not exist";
		array[37] = LocalizationService.Instance.GetLocalizatedText(")" + challenge.PlayerStatus.ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.BAMLNCCNGFB();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper() + text2;
		KNICJEFJFAF();
	}

	private void LJHCMDOMAAD()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_EmissionColor").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("OpGetGameList()").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[98];
		array[0] = "<b>Max Score</b>:";
		array[0] = LocalizationService.Instance.GetLocalizatedText("hand");
		array[1] = "_Bullet_5";
		array[8] = challenge.EBENNNMBEAP();
		array[6] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[5] = "BitsData";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL(" Message: ");
		array[7] = "/";
		array[14] = LocalizationService.Instance.HOPMEAJKPHL("A" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.ONMCIPNMCAF();
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("EventSystem").ToUpper() + text2;
		PKNEKFHMCOJ();
	}

	public void MPELHKFCCFA()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1743.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ), true);
				LOELNKLKDPO();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				LOGGOJBMPCG();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.PBALPILMOKK(DLNONMLNOJJ);
			}
		}
	}

	public void LDKFAGOEDKF(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		MDDHIDGCIMK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		EECOAHLCCHH();
	}

	private void JLIFPFHKDMK()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_Blue_C").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("MapCreationCanvas").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-78];
		array[0] = ".mp3";
		array[1] = LocalizationService.Instance.GetLocalizatedText("Set sun min/max size");
		array[4] = "_Value";
		array[0] = challenge.DPKPLOJNEOG();
		array[8] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[4] = "_SSAO";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("_ChromaticAberration");
		array[0] = "CameraFilterPack/BlurTiltShift_Hole";
		array[-23] = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Gradients_FireGradient" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("OpAuthenticate()").ToUpper() + reward;
		PKNEKFHMCOJ();
	}

	public IEnumerator OHFOLGANOLC()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator MGMAOBPPOBJ()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void ABFNJCEBIKA()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("/").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("event").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" timeUntilRespawn: ").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Have you fully accept the terms?").ToUpper();
		}
	}

	public void LCJHDLKJEOM()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("menu.relaxinfo").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Error: I/O Failure").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText(".g").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("Hidden/Subpixel Morphological Anti-aliasing").ToUpper();
		}
	}

	public void ONFIKFDPHLL()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1088.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.JGLNHCHILNJ(Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ), true);
				PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)4 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				BJLHNNBLHKC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(DLNONMLNOJJ);
			}
		}
	}

	private void CFKMEAENIEJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).PNHHKLBLPEB()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(true);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(true);
		}
	}

	public void NOBNCNJKOLA(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.IKACPLICNNB();
		HDKLNBKGFKH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.GetProgress();
		MHIKFCHKCPP();
	}

	public void BDDNELHPLNI()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(22.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ));
				HDKLNBKGFKH();
			}
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				MDDHIDGCIMK();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.FAFMBMPLOCI(DLNONMLNOJJ);
			}
		}
	}

	public void AOHJJDALDPL()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(788.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GDLKPBLABII(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ));
				GDAFKPFKGIM();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				BKKHHJAMNOB();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(DLNONMLNOJJ);
			}
		}
	}

	private void MIBKLDAKMLF()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(false);
		}
	}

	private void PNJKMILCMPI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).CKEGGOIGPIO()))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(true);
		}
	}

	public void NNFJJJLBPKE(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		OBCDJFHEDGG();
	}

	public void EHBMHKDHAEG()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(639.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.KCKLDEBDNFB(Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ), true);
				FLJALKKICLN();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = false;
				FHNJLKMHJHA();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CGBGIGPIAHL(DLNONMLNOJJ);
			}
		}
	}

	private void BKKHHJAMNOB()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("[PlayerController] ").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[0];
		array[1] = "Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_InvViewProj");
		array[8] = "Tab2Content";
		array[1] = challenge.FBCMLBBHIEE();
		array[7] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[0] = "_TimeX";
		array[6] = LocalizationService.Instance.GetLocalizatedText("Drop_With_Obj");
		array[6] = "float,1.5";
		array[14] = LocalizationService.Instance.GetLocalizatedText(".completedMaps" + challenge.JMGIKADHIGM().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("Set Satellite Trail MinVertexDistance").ToUpper() + reward;
		EECOAHLCCHH();
	}

	public void IIFCIDDJHPM()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("player.deleted").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("HitVariationSlider").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Could not find RPC with index: ").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_FixDistance").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.incorrectScore").ToUpper();
		}
	}

	public void NHJNFAFBIFP()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(160.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ));
				LOGGOJBMPCG();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				JLIFPFHKDMK();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(DLNONMLNOJJ);
			}
		}
	}

	public IEnumerator HIPEHGNBJMN()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void ONKDMMJPEMN()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("CompletedLevel").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_LinearDodge").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_ChannelMixerBlue").ToUpper();
		}
	}

	public void AOEEOKNJDCK(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		EOBIHAGLMIK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		KNICJEFJFAF();
	}

	public void PAFMNAIDAFH(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		JLIFPFHKDMK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.ONELLAMBEAG(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		PNJKMILCMPI();
	}

	private void CFCMJBPDLBI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(false);
		}
	}

	private void AECJNOBOIJB()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("[Down]").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)8)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("Hello").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[45];
		array[0] = "Already exist!";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("GLITCH");
		array[3] = "subscribeall";
		array[2] = challenge.FBCMLBBHIEE();
		array[3] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[8] = "EnvironmentSlider";
		array[6] = LocalizationService.Instance.GetLocalizatedText("icon");
		array[2] = "_Value";
		array[-100] = LocalizationService.Instance.HOPMEAJKPHL("_TimeX" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.FPMDJMOAEFM();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("DPADHOR").ToUpper() + text2;
		PNJKMILCMPI();
	}

	private void FHNJLKMHJHA()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("note.4").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.InProgress)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Failed to InstantiateSceneObject prefab: ").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[75];
		array[0] = "mapselector.tags.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_ColorBurn");
		array[4] = "[MapsData] Preloading ";
		array[3] = challenge.DPKPLOJNEOG();
		array[8] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "z";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[7] = "ItemNameBGImage";
		array[-43] = LocalizationService.Instance.GetLocalizatedText("_InvRenderTargetSize" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)").ToUpper() + reward;
		INLBJELNLAL();
	}

	public void DEIMIKBHIIF()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1450.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ));
				LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				LOELNKLKDPO();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(DLNONMLNOJJ);
			}
		}
	}

	public IEnumerator OGJJDKENBNC()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void BHDPKGOKKPF()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(795.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ), true);
				AECJNOBOIJB();
			}
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				LJHCMDOMAAD();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(DLNONMLNOJJ);
			}
		}
	}

	public void AKCADICOFDD()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).OCNOEDGAPNL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("menu.selectedlevelid").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("HightScoreMaxPointsText").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("SetRotation").ToUpper();
		}
	}

	private void CIPOJCALGKN()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value3").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Alternative").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-84];
		array[1] = "\n";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[7] = "Can't set visible when not in that room.";
		array[3] = challenge.IOCJJJCAFLK();
		array[6] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[1] = "_TimeX";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_Distortion");
		array[1] = "/";
		array[26] = LocalizationService.Instance.HOPMEAJKPHL("Tab2Content" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.MEHPEEFFGPH();
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("_Parameter").ToUpper() + text2;
		ELFIMAMIENI();
	}

	public void PEEFILGCABG(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.PHCHLPBPKHL();
		JLIFPFHKDMK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		KNICJEFJFAF();
	}

	public IEnumerator MNBPNHNAEBK()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator KOFAMEKHHGD()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator AGEJKLMJGDO()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void CDJAHKOLGDA()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("team").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)6)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-94];
		array[0] = "[Left]";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[3] = "BitsData";
		array[6] = challenge.AMBFPMPCHFE();
		array[4] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[0] = "player.licenceaccepted";
		array[4] = LocalizationService.Instance.HOPMEAJKPHL("MusicFileSelector");
		array[1] = "_MainTex2";
		array[57] = LocalizationService.Instance.HOPMEAJKPHL("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting." + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.FPMDJMOAEFM();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("bad").ToUpper() + text2;
		INLBJELNLAL();
	}

	public IEnumerator JKBMKPDGCHG()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void LCDJFJIBADI()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("float,10").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Distortion_Wave_Horizontal").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("In Maps Editor").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("BitsData").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)4)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("No player left to ask").ToUpper();
		}
	}

	private void PGGLDHFKGOC()
	{
		if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("w").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.InProgress)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("ReconnectToMaster() with AuthValues == null is not correct!").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[10];
		array[0] = "player.blackcat";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_Value4");
		array[5] = " ";
		array[5] = challenge.EBENNNMBEAP();
		array[8] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[6] = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
		array[2] = LocalizationService.Instance.HOPMEAJKPHL("_Value3");
		array[3] = "#tryagain";
		array[29] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Color_Convert_Normal" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution").ToUpper() + reward;
		INLBJELNLAL();
	}

	public void FABMDEHEDNO()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("\\").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" timeUntilRespawn: ").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_DiffuseColor").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value1").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.InProgress)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("workshop.").ToUpper();
		}
	}

	public void JEPPDIDLANG()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1311.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ));
				FHNJLKMHJHA();
			}
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)7 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				HDKLNBKGFKH();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.MLIHOLEHFIM(DLNONMLNOJJ);
			}
		}
	}

	private void MHIKFCHKCPP()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(true);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(false);
		}
	}

	private void MDDHIDGCIMK()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_Value").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("z").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-92];
		array[0] = "CameraFilterPack/3D_Matrix";
		array[1] = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution");
		array[5] = "CameraFilterPack/Drawing_Manga_Color";
		array[5] = challenge.DPKPLOJNEOG();
		array[6] = Environment.NewLine;
		array[1] = Environment.NewLine;
		array[4] = " registered.";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL("maphash");
		array[8] = "_Saturation";
		array[-18] = LocalizationService.Instance.HOPMEAJKPHL("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.NJPNFKMPJNE();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Vision_Warp").ToUpper() + text2;
		APFLHIECIAE();
	}

	private void NADOLPJJFNL()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Set satellite audio input").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[49];
		array[0] = "Particles/Additive";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("x");
		array[3] = "_Value2";
		array[0] = challenge.IOCJJJCAFLK();
		array[7] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[7] = "Clears the console and prints the logs in the specified range";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("UpdateNewsTileStart");
		array[6] = "_TimeX";
		array[48] = LocalizationService.Instance.HOPMEAJKPHL("[LocalizationService] All keys for " + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.NJPNFKMPJNE();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.currentCombo").ToUpper() + text2;
		CFCMJBPDLBI();
	}

	public void AEIJFLJEABG()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value4").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Sprite").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value2").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Show Image").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.Complete)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("SetPlayerDistance").ToUpper();
		}
	}

	public void AKMLEJJBBNG(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.AKJKDMMKNFO();
		GDAFKPFKGIM();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		BLBBEACCFGG();
	}

	public IEnumerator HLIAEEMGBHN()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void HPKNKMOCCHJ()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1180.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.LCJFAOGLEEM(Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ));
				HADPIJCKFMA();
			}
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				JLIFPFHKDMK();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CGBGIGPIAHL(DLNONMLNOJJ);
			}
		}
	}

	public void LHIEKHPLMFI(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.PHCHLPBPKHL();
		GDAFKPFKGIM();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		MIBKLDAKMLF();
	}

	public void AKBAPOMKFPE()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1875.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ), true);
				PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				CIPOJCALGKN();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(DLNONMLNOJJ);
			}
		}
	}

	private void BJLHNNBLHKC()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value2").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("value").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[92];
		array[0] = ".";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_Value4");
		array[5] = "Tab1Content";
		array[6] = challenge.FBCMLBBHIEE();
		array[7] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[8] = "settings_bindings_controller_type";
		array[2] = LocalizationService.Instance.HOPMEAJKPHL("achievements.26.progress");
		array[1] = "offsets";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL(" does not exist!" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.JDMKFLEFEFA();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("[LevelEditorScene] Print Audio Wave: Start").ToUpper() + text2;
		AEKABKKFDHI();
	}

	public void JLPBFDFLBAF()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(881.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.JGLNHCHILNJ(Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ), true);
				AECJNOBOIJB();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.InProgress && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				JLIFPFHKDMK();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.MLIHOLEHFIM(DLNONMLNOJJ);
			}
		}
	}

	public void LCKKDMKJJEF(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.IHBDBALJGBO();
		LJHCMDOMAAD();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.GetProgress();
		AEKABKKFDHI();
	}

	private void LOGGOJBMPCG()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL(" is muted").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[20];
		array[1] = "Select";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_Value");
		array[6] = "settings.enableranking";
		array[2] = challenge.IGAHKBHFBNE();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[3] = "_TimeX";
		array[5] = LocalizationService.Instance.GetLocalizatedText("powerup.1");
		array[7] = "Result for ";
		array[-60] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Blur_Radial" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.FPMDJMOAEFM();
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("Children").ToUpper() + text2;
		JAMNLCBMABC();
	}

	public void FECMEIJGLJI(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.KHCJFLGCAFL();
		POBAEGNACOL();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		EECOAHLCCHH();
	}

	public IEnumerator CEDFFAOOPOG()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void GFBDFGACCLH()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1402.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.NMAJHGEGJCG(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ), true);
				OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)7 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				FLJALKKICLN();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(DLNONMLNOJJ);
			}
		}
	}

	public void ONNJFFAFGGN()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1223.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.PMBBDPNMGHK(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ), true);
				MDDHIDGCIMK();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				PGGLDHFKGOC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.PAIOCIDCBJL(DLNONMLNOJJ);
			}
		}
	}

	private void ENFIPKFPJPC()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("settings.shaders.bloomintencity").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_Value2").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-10];
		array[0] = "[PlayerController] ";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[0] = "<b>";
		array[4] = challenge.IGAHKBHFBNE();
		array[5] = Environment.NewLine;
		array[6] = Environment.NewLine;
		array[0] = "_Value4";
		array[4] = LocalizationService.Instance.GetLocalizatedText("Updated!");
		array[0] = "_ScreenResolution";
		array[51] = LocalizationService.Instance.HOPMEAJKPHL("Fade" + challenge.IFAJDLKJIDL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.BBKGHFHMHDA();
		rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("LeaderboardsButton").ToUpper() + text2;
		OBCDJFHEDGG();
	}

	public IEnumerator ALNNIDLFILB()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator FEKECCBFGMI()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void LKEPIEEIMAE(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.KHCJFLGCAFL();
		LJHCMDOMAAD();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		PKNEKFHMCOJ();
	}

	public void FOMNCPKKCFN()
	{
		if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Cross").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Horizontal").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/OldFilm_Cutting1").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("Object ID. Case-Sensitive").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)7)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
	}

	private void HADPIJCKFMA()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-113];
		array[1] = "SetCrosshairEmission";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_TimeX");
		array[7] = "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.";
		array[1] = challenge.IMDDDMOPBMA();
		array[5] = Environment.NewLine;
		array[1] = Environment.NewLine;
		array[0] = "Left";
		array[4] = LocalizationService.Instance.GetLocalizatedText(".mp3");
		array[6] = "Gameplay/Base";
		array[-110] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Light_Water" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.NJPNFKMPJNE();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("BadgeText").ToUpper() + text2;
		JAMNLCBMABC();
	}

	private void HDKLNBKGFKH()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText(".g").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("#no").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-20];
		array[1] = "CameraFilterPack/Blend2Camera_DarkerColor";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("#getrewardfailed: ");
		array[2] = "workshop.";
		array[4] = challenge.info;
		array[7] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[2] = "_CenterX";
		array[1] = LocalizationService.Instance.GetLocalizatedText("MusicFileSelector");
		array[2] = "VisionBlur";
		array[-122] = LocalizationService.Instance.GetLocalizatedText("#,0.00" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.ONMCIPNMCAF();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("Noise & Grain effect failing as noise texture is not assigned. please assign.").ToUpper() + text2;
		BLBBEACCFGG();
	}

	public IEnumerator BOPKKCAFODF()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void POBAEGNACOL()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("menu.selectedlevelid").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("(scene)").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-50];
		array[1] = "CameraFilterPack/Atmosphere_Rain_Pro_3D";
		array[0] = LocalizationService.Instance.GetLocalizatedText(" SecondsBeforeRespawn: ");
		array[3] = "_TimeX";
		array[7] = challenge.KJPHHLIPAMA();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "maps.";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("Myst_Color");
		array[2] = "FinalScoreText";
		array[-68] = LocalizationService.Instance.GetLocalizatedText("_LumTex" + challenge.IFAJDLKJIDL().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.KIJCJELFFPO();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_Overlay").ToUpper() + text2;
		BLBBEACCFGG();
	}

	public void KMEONPMCNJG()
	{
		if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TempTexture").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Use ticket: ").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("</color>").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_Distortion").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)7)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_FixDistance").ToUpper();
		}
	}

	public void JNBPKNNBMDI()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText(" registered.").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("offsets").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("Set Sun DirectionVector").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_MainTex2").ToUpper();
		}
	}

	private void FLJALKKICLN()
	{
		if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("ItemNameText").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText(".completedMaps").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[95];
		array[1] = "OneHand";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("Gameplay/sun");
		array[3] = "[ResourcesManager] Load audio error: ";
		array[0] = challenge.info;
		array[6] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[8] = "RecieveChatActionMessage";
		array[6] = LocalizationService.Instance.GetLocalizatedText("#exitmapeditor");
		array[0] = "CameraFilterPack/Blur_Focus";
		array[-69] = LocalizationService.Instance.HOPMEAJKPHL("set id" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.MEHPEEFFGPH();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("[Up-Left]").ToUpper() + text2;
		CFCMJBPDLBI();
	}

	public IEnumerator ODBNMPGBCGO()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void AEKABKKFDHI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).NFNAMIJACFE()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(true);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(false);
		}
	}

	public void JOACBIEHHCE()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("/icon").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Trackpad").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("other.dust1").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.ObtainedReward)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText(" - ").ToUpper();
		}
	}

	public void BBICIPNPMLL(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		JLIFPFHKDMK();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		OBCDJFHEDGG();
	}

	public void OBAEDJJDCPN()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("13").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Vision_Blood_Fast").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL(";").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("BitsData").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
		}
	}

	public void LPHKBPIIEMA()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(870.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ), true);
				LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				LJHCMDOMAAD();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EONFOJMJJNE(DLNONMLNOJJ);
			}
		}
	}

	public void AOLABBMIEIM()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("[NetworkMenu] Joining ").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("You need to have a Graphic control (such as an Image) for the list [").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Edited unlock conditions").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.ObtainedReward)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_NoiseAmount").ToUpper();
		}
	}

	public void MHLHDKJJJEK(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		NADOLPJJFNL();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.ONELLAMBEAG(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		KNICJEFJFAF();
	}

	public void CLPNGMEGNOC()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1295.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.LCJFAOGLEEM(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ), true);
				GDAFKPFKGIM();
			}
			if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				HADPIJCKFMA();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EEIMLBLFCCA(DLNONMLNOJJ);
			}
		}
	}

	public void KFMDOEEADDM()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1934.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.NMAJHGEGJCG(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ), true);
				BKKHHJAMNOB();
			}
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = true;
				LOGGOJBMPCG();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(DLNONMLNOJJ);
			}
		}
	}

	public IEnumerator DLBODOFAJGM()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void EMENGNIOCLJ(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		LOGGOJBMPCG();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		ELFIMAMIENI();
	}

	public IEnumerator CHOPDIGHJNH()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void AGMJDGHLBMN()
	{
		if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("player.currentrank").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Fade").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("maps.").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" This is not possible to be called for standalone input. Please check your platform and code where this is called").ToUpper();
		}
	}

	public IEnumerator Start()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void EECOAHLCCHH()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).NFNAMIJACFE()))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(true);
		}
	}

	public IEnumerator KCCIEMBMOBA()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator FMFNILJIEIA()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator EFJDNLGNACH()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator MMMDPANNAIO()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator DOKAKEMDALN()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void Update()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilend: ").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilchallenge: ").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("#finished").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("#getrewardnow ").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("#obtained").ToUpper();
		}
	}

	public IEnumerator FJNCHGLIEMA()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void LOELNKLKDPO()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("materialsquantity[").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.InProgress)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Gameplay/sun").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-4];
		array[0] = "_Value";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_Distortion");
		array[2] = "CameraFilterPack/FX_Grid";
		array[8] = challenge.FBCMLBBHIEE();
		array[8] = Environment.NewLine;
		array[3] = Environment.NewLine;
		array[8] = "_Offsets";
		array[6] = LocalizationService.Instance.GetLocalizatedText("_Value2");
		array[5] = "#forever";
		array[-9] = LocalizationService.Instance.HOPMEAJKPHL("request" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.NJPNFKMPJNE();
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("_Value2").ToUpper() + text2;
		MHIKFCHKCPP();
	}

	public void PFNFPINPCMH()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CorrectHitsScoreText").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_PixelsPerMeterAtOneMeter").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.perfectHits").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)4)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("float,0").ToUpper();
		}
	}

	private void OBCDJFHEDGG()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(false);
		}
	}

	public IEnumerator AIBNKIDADPI()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void ELFIMAMIENI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = false;
			lockedCanvas.SetActive(false);
		}
	}

	public void KMKLDAJLCNM()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("#random #common #item").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("#md5submitionfailed: ").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Set Satellite Color").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Triangle").ToUpper();
		}
	}

	public IEnumerator JONGNKNLLND()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	private void KNICJEFJFAF()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.NOPECAKEGAN(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(true);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(true);
		}
	}

	public IEnumerator MKIMDFLBFOM()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public IEnumerator IGPCNCJIEOJ()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void AKEIPNLIHNL()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1675.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.CDDFIMMJECM(DLNONMLNOJJ));
				CDJAHKOLGDA();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)8 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = true;
				BKKHHJAMNOB();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.FAFMBMPLOCI(DLNONMLNOJJ);
			}
		}
	}

	public IEnumerator ILCFPCIPENO()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon));
			bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
	}

	public void OEGDGBIKNGG()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1557.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(DLNONMLNOJJ));
				FHNJLKMHJHA();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = false;
				PNBDOOFABJB();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.IIHGLLIKGKH(DLNONMLNOJJ);
			}
		}
	}

	private void PPBOIGBIIDL()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GetLocalizatedText("Right").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.HOPMEAJKPHL("value").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[81];
		array[0] = "_MainTex2";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_FilteredReflections");
		array[1] = "88f00bdf0ad61b16b803971ebe071962";
		array[6] = challenge.KJPHHLIPAMA();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[2] = ".lastCheckpoint.checkpointsUsed";
		array[7] = LocalizationService.Instance.GetLocalizatedText("_Overlay");
		array[5] = "HiddenToggle";
		array[-6] = LocalizationService.Instance.HOPMEAJKPHL("Call ConnectToNameServer to ping available regions." + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper() + reward;
		EECOAHLCCHH();
	}

	public void PNLKFANNOKO()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("DisableStoryboardToggle").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GetLocalizatedText("powerup.1").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete)
		{
			timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
	}
}
