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

	public IEnumerator DILAPPPAKCF(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator GKFLOACFHCN(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator EPJIMEBMJLM(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void JOLCMGGMFAC(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(true);
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

	public void APGKDAJLFIG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public IEnumerator BLGJBKGLPPH(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator EGPDNFPMKLP(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator MPOMHPPFBBP(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void KPKNPMPPKPG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator HJHNHBPLPHI(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	private void LGEFCKKPHDJ()
	{
		GDFNFALPCDB();
	}

	public void OCCGGEFLPLH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator FMJIHENKKLM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void CNGOPHCPHCH(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.FOOAGGCODAH(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NDKGHJGLCFI);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator JLGACNMNEKE(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	private void HPJJHAPPHEJ()
	{
		JOLCMGGMFAC();
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

	public IEnumerator IALKNMGLCFJ(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void LJNBBOEIADJ(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public IEnumerator DDEBEJKBIGK(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void CCDPLNMCPJB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(true);
	}

	public void NAGLDFEMLKE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(true);
	}

	[CompilerGenerated]
	private void ADAFOPAEAPH()
	{
		Close();
	}

	public void JJEOAFDDLHK(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.DKECBIHCKJL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.PLFJBNAEKML(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NDEBCOHKIIH);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	private void NDKGHJGLCFI()
	{
		JOLCMGGMFAC();
	}

	public IEnumerator KNEDOFIJCHO(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator KKNIONJNONE(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void GIKJIFGFMFP(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	private void BKBHGCLLHEI()
	{
		Close();
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

	public void GNKJLJNJJFP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(BOPNGKNOIKB);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void BPANCBNKDKD(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.EHOJEKMEKCB(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(LDBPKDIBJKH);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void DKJDPAGPJOI(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void NCIKLIFEAMB(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.KDBLEDDGCJK(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(BKBHGCLLHEI);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator DLFAEEALJDD(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void HPNLNGHGNOI(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public IEnumerator AGCLEAFDACH(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator AIDPHEDNBMI(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator FAFAOMHGKGH(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator PKGBEKDAJKH(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator GFHKFIPMNOO(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void ENIHMMBIHDH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public void NNACLNIABJF(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator EDFOLFALIDD(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator INOCIPHLMFP(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator KNAOBMDHIMM(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void GJAEFOENJGI(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.POMBHCDEONC(DAGALCAILLN);
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
		button0.onClick.AddListener(NCFHDGBGJJF);
		bg.SetActive(true);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator AJKGIIPMJIJ(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator PEOEIDKKMPH(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void PJPLOFFCMHH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	private void KKAGDMIFLHJ()
	{
		LOLHNKMKNCJ();
	}

	public void BIGHIEJMHHA(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GAAFIKGPNAO(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.EHOJEKMEKCB(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NDEBCOHKIIH);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void LOLNHCPOKFP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.PLFJBNAEKML(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(CCOPONJFNNK);
		bg.SetActive(true);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void GDFNFALPCDB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	private void KKHBGNKJAHN()
	{
		JDAGGOPDHNM();
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

	public IEnumerator PPBJJEJBBHG(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void GALODIIICGN(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public IEnumerator BFKBAHNBIIE(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator GACFNEHALFB(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void DPFKHGBCDFH(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.GAAFIKGPNAO(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.DKECBIHCKJL(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NCFHDGBGJJF);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void DGACNGGHJPM(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(true);
	}

	private void NDEBCOHKIIH()
	{
		OCCGGEFLPLH();
	}

	public void DEAKLIGJIFG(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.KDBLEDDGCJK(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GAAFIKGPNAO(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NCFHDGBGJJF);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator LFPIIMKNLAN(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void JDAGGOPDHNM(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	private void CCOPONJFNNK()
	{
		DKJDPAGPJOI();
	}

	private void NCFHDGBGJJF()
	{
		DKJDPAGPJOI();
	}

	public void Close(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator JCIPCAPDHID(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void JPHEAJOLIGK(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.POMBHCDEONC(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.POMBHCDEONC(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(BKBHGCLLHEI);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator COPAIHLMAIL(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void GFFLCOHDODA(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public IEnumerator OOCJPEFPDKD(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator AJPPJFOKLLE(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator KGMJAHDDNPH(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void COIPKIFPDBL(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.EHOJEKMEKCB(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(CCOPONJFNNK);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void PGJLMNEJGML(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.DKECBIHCKJL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.FOOAGGCODAH(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(KKHBGNKJAHN);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator MHLFAMCLABG(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void CIOKBENBFPJ(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.DKECBIHCKJL(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(LDBPKDIBJKH);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator CPEPGLFNCNO(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	private void LDBPKDIBJKH()
	{
		DGACNGGHJPM();
	}

	public IEnumerator DFMAIEEEINE(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void KOHGHEGHONA(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public void MEGHOGOANGJ(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.PLFJBNAEKML(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(DLMCLGLCMDC);
		bg.SetActive(true);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void KFOGMFJEJJN(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator AKHBEJOKPGC(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator OKBDDBEIHFO(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public IEnumerator HDDAPBIBFPN(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void DMDDLAICNDI(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.FOOAGGCODAH(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.DKECBIHCKJL(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NCFHDGBGJJF);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void FDMCEKAMPNE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(false);
	}

	public IEnumerator LLFIFHHDKHH(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public IEnumerator PCJNOGNGJIN(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void LOLHNKMKNCJ(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(false);
		messageBox.SetActive(true);
	}

	public void HFDGADCBPPD(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(true);
		messageBox.SetActive(true);
	}

	public void JKIIHMENEDD(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	public void EIBOENDJFEK(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = true;
		bg.SetActive(false);
		messageBox.SetActive(false);
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

	public void IINDNBDIOMJ(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.FOOAGGCODAH(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(NEFDGPCDBAG);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator ENDDPILNCDO(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void BOKKOAKIDMK(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.KDBLEDDGCJK(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.EHOJEKMEKCB(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(CCOPONJFNNK);
		bg.SetActive(true);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator GIINGHBINOP(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void HLEOBMODPLO(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = false;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GAAFIKGPNAO(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(BOPNGKNOIKB);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void AMBEIAGHBEF(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.OJCHMJIMHHE(DAGALCAILLN);
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
		button0.onClick.AddListener(NCFHDGBGJJF);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public IEnumerator NIHFDDAAOPE(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	private void BOPNGKNOIKB()
	{
		LJNBBOEIADJ();
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

	public IEnumerator MJGEPGLLIEJ(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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

	public void CKDBDGFENAF(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(false);
		infoText.text = LocalizationService.Instance.DKECBIHCKJL(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.PLFJBNAEKML(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(HPJJHAPPHEJ);
		bg.SetActive(true);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void FKPCEFPFPJD(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.EHOJEKMEKCB(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.KDBLEDDGCJK(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(DLMCLGLCMDC);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	private void NEFDGPCDBAG()
	{
		HFDGADCBPPD();
	}

	public IEnumerator GEAOGNKHLNP(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
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

	public void DKGAEEALMLE(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(false);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.DKECBIHCKJL(DAGALCAILLN);
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
		button0.onClick.AddListener(BOPNGKNOIKB);
		bg.SetActive(false);
		messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	public void EOKFGEFEDBB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		result = NBGPBKCPFDN;
		textResult = EAFAMAMDNEG;
		finished = false;
		bg.SetActive(true);
		messageBox.SetActive(false);
	}

	private void KICGPHDCKGI()
	{
		CCDPLNMCPJB();
	}

	public void POHMPIDHJII(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		result = -1;
		textResult = null;
		finished = true;
		dialogButtonsCanvas.SetActive(true);
		input.gameObject.SetActive(true);
		infoText.text = LocalizationService.Instance.EHOJEKMEKCB(DAGALCAILLN);
		button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.POMBHCDEONC(MLDACKJMKMN).ToUpper();
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
		button0.onClick.AddListener(KICGPHDCKGI);
		bg.SetActive(false);
		messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(button0.transform.gameObject);
	}

	private void DLMCLGLCMDC()
	{
		HPNLNGHGNOI();
	}

	public IEnumerator OPHKALEJKKM(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
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
}
