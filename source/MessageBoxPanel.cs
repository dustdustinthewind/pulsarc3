// MessageBoxPanel
using System.Collections;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MessageBoxPanel : Singleton<MessageBoxPanel>
{
	public GameObject bg;

	public GameObject messageBox;

	public Text infoText;

	public Slider progressSlider;

	public Button button0;

	public GameObject dialogButtonsCanvas;

	public Button button1;

	public Button button2;

	public InputField input;

	public bool finished = true;

	public int result = -1;

	public string textResult;

	public IEnumerator KNOPGACCMCN(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator DGHILKGOFHI(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator DisplayDialog(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void MDDBLLLPJBH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public IEnumerator PGBDHNNAAMM(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void JDAGGOPDHNM(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void KJPEAAAGNGK(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(HHKKOEFBIDN);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator IOLBDBFIOAM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	[CompilerGenerated]
	private void ADAFOPAEAPH()
	{
		Close();
	}

	private void HHKKOEFBIDN()
	{
		CKBPMBBKINC();
	}

	public void EOKFGEFEDBB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void JCHNDBKFGFP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(CHIBDIECIEO);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void CLLBEDAJKBE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	private void IEAONCFDFNC()
	{
		JDAGGOPDHNM();
	}

	public void ALHLMBCOILP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(HHKKOEFBIDN);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator DisplayInputDialog(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	private void LMFLEEPBKDB()
	{
		LLJMNFMEIPE();
	}

	public IEnumerator MLDHDCNBHGL(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void ANCIONGLJAC(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(IEAONCFDFNC);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void LKFALPEABHP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(GICAFOMBKPL);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator FOKENJJAIDE(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void ILNLMMEOALM(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(IEAONCFDFNC);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator BJKANLKLPBL(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator GINFCJIPPHE(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void CHBFDGFOLLL(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(IEAONCFDFNC);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void CEPIBOBEIHE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public void LNBENKOBLCG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void CKBPMBBKINC(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public IEnumerator OOFFNLACIMP(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	private void CHIBDIECIEO()
	{
		EOKFGEFEDBB();
	}

	public void LLJMNFMEIPE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public void Close(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void IPMMEMNBGNL(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public void NNNCEGFJLOB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator IMGGNCJBANC(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator MDBCFODECPM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator KPJFLMDCPMK(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void KOKMKCJONBG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(true);
	}

	public IEnumerator JKIKIMKNNKK(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void DisplayMessage(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close();
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void GIKJIFGFMFP(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void PALFHOFEKEG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public IEnumerator ABDEPPPGGBM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator FNLHHMEJCON(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void AGMKJJLMOHG(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(LEOOCHBHIKA);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(GICAFOMBKPL);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void FCNDDFJNFPH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public IEnumerator MEFKBOBCJKG(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		dialogButtonsCanvas.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.onClick.RemoveAllListeners();
		button0.gameObject.SetActive(false);
		progressSlider.gameObject.SetActive(false);
		input.gameObject.SetActive(false);
		button1.onClick.RemoveAllListeners();
		button2.onClick.RemoveAllListeners();
		button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			button2.onClick.AddListener(CBGPGFDGKCH);
		}
		button1.onClick.AddListener(delegate
		{
			Close(1);
		});
		button2.onClick.AddListener(delegate
		{
			Close(2);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button1.transform.gameObject);
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public IEnumerator DBDPBPINJLC(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		infoText.text = DAGALCAILLN;
		button0.onClick.RemoveAllListeners();
		button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		button0.gameObject.SetActive(true);
		progressSlider.gameObject.SetActive(false);
		input.text = EAFAMAMDNEG;
		input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			button0.onClick.AddListener(NBIMAPNDKKA);
		}
		button0.onClick.AddListener(delegate
		{
			Close(1, input.text);
		});
		bg.SetActive(true);
		messageBox.SetActive(true);
		if (dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
		}
		while (!finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
	}

	public void CNHKJNCBIAG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	private void GICAFOMBKPL()
	{
		JDAGGOPDHNM();
	}
}
