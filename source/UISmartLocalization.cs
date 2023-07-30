// UISmartLocalization
using System;
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class UISmartLocalization : MonoBehaviour
{
	public bool useCaps = true;

	public string _string;

	private Text OCAMCGEINLB;

	private void CIJHMEKMMNL()
	{
		NEPOMCMOGEL();
	}

	private void OnDestroy()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
	}

	private void KCDJGMCNBIN(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = ELHHIIPGOGM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "ChallengesButton") && !(EAFAMAMDNEG == string.Format("[PlayerBase] Loaded spawner data", _string)))
		{
		}
	}

	private IEnumerator AENDFKKBDID()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	public bool LDOJHGDKIHE()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void DKOPKPBLDHH()
	{
		StartCoroutine(BDAOBBILHOC());
	}

	private void INCMKKKEHEA(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = ELHHIIPGOGM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "settings.hitvariation") && !(EAFAMAMDNEG == string.Format("SpawnObj", _string)))
		{
		}
	}

	private void GHCGIPDAOEK(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = ELHHIIPGOGM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "resetach21") && !(EAFAMAMDNEG == string.Format("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", _string)))
		{
		}
	}

	public bool IsHasOutputHelper()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void NEPOMCMOGEL()
	{
		IFEGMAMLIHI(LocalizationService.Instance.POMBHCDEONC(_string));
	}

	private void NFADGEDMNMF()
	{
		MNHCBCCOOMJ();
	}

	private void KPFCINLODFE()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CIJHMEKMMNL();
	}

	private void DIPDEHOOBPG()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private IEnumerator EPJBCPOPKGB()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void Start()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private void DDEKPGECKCD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		NFADGEDMNMF();
	}

	private void BGDPIHMAACO()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private void NBNOKBBDMEC()
	{
		AEPICGAOLJM();
	}

	private void HGIGIMHCJEH()
	{
		HENFHFDKDOO();
	}

	private void BKMGAGLKDLB()
	{
		MAJHGBKCBEA();
	}

	private IEnumerator BDAOBBILHOC()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void HENFHFDKDOO()
	{
		IFEGMAMLIHI(LocalizationService.Instance.FOOAGGCODAH(_string));
	}

	private void NPLCENPNJBM()
	{
		StartCoroutine(BDAOBBILHOC());
	}

	private void GHJJDAJIOPM(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = ELHHIIPGOGM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "[EMPTY]") && !(EAFAMAMDNEG == $"[ERROR KEY {_string}]"))
		{
		}
	}

	private void MNHCBCCOOMJ()
	{
		GHJJDAJIOPM(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	private void DLBODOFAJGM()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private void MAJHGBKCBEA()
	{
		KCDJGMCNBIN(LocalizationService.Instance.EHOJEKMEKCB(_string));
	}

	private void AEPICGAOLJM()
	{
		IFEGMAMLIHI(LocalizationService.Instance.GAAFIKGPNAO(_string));
	}

	private void CIPKEPDELJB()
	{
		StartCoroutine(BDAOBBILHOC());
	}

	private string ELHHIIPGOGM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("\\n", Environment.NewLine);
	}

	private void IFEGMAMLIHI(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = ELHHIIPGOGM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "CameraFilterPack/FX_Drunk") && !(EAFAMAMDNEG == string.Format("LevelEditor/icons", _string)))
		{
		}
	}

	private void FIMEMDDJEHK()
	{
		MNHCBCCOOMJ();
	}

	private void AGBNHEBHFDG()
	{
		IFEGMAMLIHI(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	private IEnumerator POCPKICJPFE()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void CCLNNLCOPBL()
	{
		StartCoroutine(POCPKICJPFE());
	}
}
