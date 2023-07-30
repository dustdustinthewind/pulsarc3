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

	public void FHPNIFPJKCK()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1299.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).EFOKGOMPFIO() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.CDDLPAHMHHJ(Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ), true);
				OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).BBLDABFGDFF() == Challenge.CurrentStatus.InProgress && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(DLNONMLNOJJ);
			}
		}
	}

	public void PFMJPIJONIP(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.ENDOGIJIIMN();
		HJJFKFJFKLJ();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.LACOFOPCNBG(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.DCHBAIPFOMK();
		CAPPGMDHJEN();
	}

	public IEnumerator FIKFJDFELIP()
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
		DLNONMLNOJJ = BFLLKFPPAAB.OFGNFACIGIL();
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		PKNEKFHMCOJ();
	}

	public void NKLIHNJCHOG()
	{
		if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.EHOJEKMEKCB("0.00").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.GAAFIKGPNAO("maps.").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.FOOAGGCODAH("VoteDownToggle").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).EBJMABMHEEO() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.OJCHMJIMHHE("VisionBlur").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).JNEKHPIOHIK() == (Challenge.CurrentStatus)5)
		{
			timeText.text = LocalizationService.Instance.GetLocalizatedText("Failed to Destroy objects of playerId: ").ToUpper();
		}
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

	public IEnumerator IMCKJCHKMKB()
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

	public void FFBDGOBNNCO(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.BGIOHLIFHND();
		AFILPDENJAC();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.KCMBMLFLEOK();
		CAPPGMDHJEN();
	}

	private void NKODDACKFKI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).unlockCondition))
		{
			GetComponent<Button>().interactable = true;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(true);
		}
	}

	public void HBKEHHCMMBN(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.id;
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BDKJGGONHEL(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		LNCDNKGHOHJ();
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

	private void PKNEKFHMCOJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).unlockCondition))
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

	private void CAPPGMDHJEN()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(DLNONMLNOJJ).CCCHEABDHMH()))
		{
			GetComponent<Button>().interactable = false;
			actionText.gameObject.SetActive(false);
			lockedCanvas.SetActive(false);
		}
		else
		{
			GetComponent<Button>().interactable = true;
			lockedCanvas.SetActive(false);
		}
	}

	private void INLBJELNLAL()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).CCCHEABDHMH()))
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

	public void GDNMIEHNGBL()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(950.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).HCPDNILLJEJ() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ));
				AFILPDENJAC();
			}
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(DLNONMLNOJJ).JNEKHPIOHIK() == Challenge.CurrentStatus.ObtainedReward && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = false;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(DLNONMLNOJJ);
			}
		}
	}

	public void LAOCNFBGEDE()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(435.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.PMBBDPNMGHK(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ), true);
				HJJFKFJFKLJ();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.OCOJEBKMIEJ(DLNONMLNOJJ);
			}
		}
	}

	public void JPNOHODALMI()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1979.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).BBLDABFGDFF() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.KCKLDEBDNFB(Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ));
				OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).BBLDABFGDFF() == (Challenge.CurrentStatus)8 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.KCEHNEPHBPH(DLNONMLNOJJ);
			}
		}
	}

	public void CJBCKPEOOGI()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1610.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(DLNONMLNOJJ).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.FKMBPEGKILO(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ), true);
				OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).EBJMABMHEEO() == Challenge.CurrentStatus.ObtainedReward && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(DLNONMLNOJJ);
			}
		}
	}

	public void GHILDCBCDJI()
	{
		if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).EBJMABMHEEO() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= DKJCKNPNPAB && utcNow <= BLKCBHFNLGB)
			{
				TimeSpan nMCHKFGKGFJ = BLKCBHFNLGB - utcNow;
				timeText.text = LocalizationService.Instance.KDBLEDDGCJK("(\\[ */ *quote *\\])").ToUpper() + nMCHKFGKGFJ.ToReadableString();
			}
			else if (utcNow < DKJCKNPNPAB)
			{
				TimeSpan nMCHKFGKGFJ2 = DKJCKNPNPAB - utcNow;
				timeText.text = LocalizationService.Instance.POMBHCDEONC("_TimeX").ToUpper() + nMCHKFGKGFJ2.ToReadableString();
			}
			else
			{
				timeText.text = LocalizationService.Instance.GetLocalizatedText("Joystick1Button9").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).HCPDNILLJEJ() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nMCHKFGKGFJ3 = BLKCBHFNLGB - utcNow2;
			timeText.text = LocalizationService.Instance.EHOJEKMEKCB("_Color_B").ToUpper() + nMCHKFGKGFJ3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).HCPDNILLJEJ() == Challenge.CurrentStatus.ObtainedReward)
		{
			timeText.text = LocalizationService.Instance.PLFJBNAEKML("_ScreenResolution").ToUpper();
		}
	}

	public void DBDCIAIJOKG()
	{
		DateTime dateTime = DateTime.UtcNow.AddHours(1194.0);
		if (dateTime >= DKJCKNPNPAB && dateTime <= BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(DLNONMLNOJJ).EFOKGOMPFIO() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ));
				AFILPDENJAC();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(DLNONMLNOJJ).EFOKGOMPFIO() == (Challenge.CurrentStatus)7 && !IHEDNJNCIPM)
			{
				GetComponent<Button>().interactable = true;
				IHEDNJNCIPM = false;
				AFILPDENJAC();
				actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EOGLBNCHOIO(DLNONMLNOJJ);
			}
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

	private void LNCDNKGHOHJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).CCCHEABDHMH()))
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

	public IEnumerator NPLCENPNJBM()
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

	private void AFILPDENJAC()
	{
		if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.DKECBIHCKJL("_MainTex2").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).EBJMABMHEEO() == (Challenge.CurrentStatus)4)
		{
			actionText.gameObject.SetActive(true);
			actionText.text = LocalizationService.Instance.EHOJEKMEKCB("_ScreenResolution").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[83];
		array[1] = "_Red_G";
		array[0] = LocalizationService.Instance.GAAFIKGPNAO("Scrollbar");
		array[0] = "Freq: ";
		array[8] = challenge.info;
		array[4] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[7] = "CameraFilterPack/Blend2Camera_Saturation";
		array[8] = LocalizationService.Instance.EHOJEKMEKCB("(\\[ */ *h1 *\\])");
		array[6] = "CameraFilterPack/FX_Grid";
		array[21] = LocalizationService.Instance.EHOJEKMEKCB(" (" + challenge.JNEKHPIOHIK().ToString().ToLower());
		text.text = string.Concat(array);
		string text2 = challenge.KJOKBLAMHLN();
		rewardText.text = LocalizationService.Instance.OJCHMJIMHHE("#useticket").ToUpper() + text2;
		NKODDACKFKI();
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

	public IEnumerator CCLNNLCOPBL()
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

	public void Init(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.id;
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.GetProgress();
		MIBKLDAKMLF();
	}

	public void LNMKDFDKFPF(Challenge BFLLKFPPAAB)
	{
		DLNONMLNOJJ = BFLLKFPPAAB.ENDOGIJIIMN();
		OEFGNIAHHNH();
		DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MHNLMDPIGLB(), CultureInfo.InvariantCulture);
		BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BAMLANAIFEO(), CultureInfo.InvariantCulture);
		progressBar.value = BFLLKFPPAAB.ADKFDALFMAE();
		INLBJELNLAL();
	}

	private void HJJFKFJFKLJ()
	{
		if (Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.GAAFIKGPNAO("DataText").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)6)
		{
			actionText.gameObject.SetActive(false);
			actionText.text = LocalizationService.Instance.POMBHCDEONC("PublishButton").ToUpper();
		}
		else
		{
			actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.JIPIKLINJOF(DLNONMLNOJJ);
		Text text = infoText;
		string[] array = new string[-32];
		array[1] = "USE_PREDICATION";
		array[0] = LocalizationService.Instance.PLFJBNAEKML("#close");
		array[4] = "_ColoredChange";
		array[3] = challenge.GPBAIPHOIKN();
		array[3] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[0] = "RoomNameText";
		array[7] = LocalizationService.Instance.KDBLEDDGCJK("STICKRVER");
		array[2] = "menu.tabid";
		array[34] = LocalizationService.Instance.FOOAGGCODAH("1278033234" + challenge.EFOKGOMPFIO().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		rewardText.text = LocalizationService.Instance.PLFJBNAEKML("_MainTex2").ToUpper() + reward;
		NKODDACKFKI();
	}

	public IEnumerator FEHCNJLLJMP()
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
}
