// ChallengesMessage
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ChallengesMessage : Singleton<ChallengesMessage>
{
	public GameObject canvas;

	public Image icon;

	public Slider progress;

	public Text header;

	public Text message;

	public float duration = 2f;

	public IEnumerator GDAILIHICED(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator MHIIDEFFOPG(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator OFIIHLGMHLA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator LPMANIOHNCB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator LLDNOFEBMNO(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator KOJGICNJMHK(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator BKLEAFCFGIF(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator EOAALFEALFB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator IKIFPMPCMHM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator CGJLEMDDPFK(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator BBGKHAOOLEA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator OEKGNHOHHKM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator MJGCLANHBNE(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator JPGPLFFIGDA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator IJFDCPFAPBP(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator DPPEKLIFMIJ(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator GBEONFANEGF(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator DNHHKBDDBGD(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator FPKCOIJLBLN(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator FJBFLGEKJEH(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator AGJLCNDGODP(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator FPCHLDCNODE(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator DPCGEHNCEAA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator CLBHJILJJJB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator JOCACBLCCMM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator CHAPAEBAGBG(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator JELKMEDPKCL(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator ShowMessage(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator DHPELKMAAFM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator DAFGMNEEOJN(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon));
			icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		progress.value = BFLLKFPPAAB.GetProgress();
		header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		message.text = COGJAGOFOKK;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
		yield return new WaitForSeconds(duration);
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}
}
