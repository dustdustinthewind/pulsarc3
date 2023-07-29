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

	private IEnumerator AOHNELGHACA()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void NEEPEGIEHPF()
	{
		CBEDHJJKLFF(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private void NFADGEDMNMF()
	{
		MNHCBCCOOMJ();
	}

	private void GOCDFEABHHB()
	{
		GEAIBNOIDMP();
	}

	public bool IENKONGFMIC()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private string IHOAIDIJPNA(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_SecondTex", Environment.NewLine);
	}

	private void JHANGPCOCIG()
	{
		StartCoroutine(OGJGNCKCLAE());
	}

	private void MNHCBCCOOMJ()
	{
		GHJJDAJIOPM(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	private void IFPOBIMHJEK()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(GGHCKMDEIPH));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		GOCDFEABHHB();
	}

	private void FPFMKNFJCGG(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = AHCEFNLDNGG(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "_Offsets") && !(EAFAMAMDNEG == string.Format("Gameplay/Base", _string)))
		{
		}
	}

	public bool NENJGDNMNIO()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void NBBCPAFKLPK()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(DAOJOFAOPEC));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CBMBHICHMGI();
	}

	private void CHOPDIGHJNH()
	{
		StartCoroutine(GNHBLNKLCBG());
	}

	private void PCKABALNDAC()
	{
		NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private IEnumerator AFJIAEEHHDJ()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void GNPPHNFEIJG()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		JKMPONNDNDF();
	}

	private string AHCEFNLDNGG(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("move", Environment.NewLine);
	}

	private void BBJDNFFDKBN()
	{
		PMLLOEGKPGG();
	}

	private string ELHHIIPGOGM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("\\n", Environment.NewLine);
	}

	private string DFEBNJNDPHO(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Value2", Environment.NewLine);
	}

	public bool JDEFKMGGCOP()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void KKFMEHJPPAD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(NFGBFPOBEBE));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		JAFENCCFFML();
	}

	private void GEAIBNOIDMP()
	{
		NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	public bool ICFFHKAPJGP()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void FHANAANLEGL()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(ECHCAAJIOFB));
	}

	private void FIMBCPOBFFA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(CBMBHICHMGI));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CIJHMEKMMNL();
	}

	private void CCLDIMFBONJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(CBMBHICHMGI));
	}

	private string CDCMECNNCAG(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("setAF", Environment.NewLine);
	}

	private void KHBLMEGPPLJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(MINBMBHOGFD));
	}

	private void HOOPHJCBJAN(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = COMHNBJCPHM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "_TimeX") && !(EAFAMAMDNEG == string.Format("_ColorR", _string)))
		{
		}
	}

	private void JDCBHJOLOCJ(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = IHOAIDIJPNA(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "Object ID. Case-Sensitive") && !(EAFAMAMDNEG == string.Format("ns", _string)))
		{
		}
	}

	private string LEKLFDIODEK(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("settings.gamemessagesduration", Environment.NewLine);
	}

	private void GIAIENDLHPO()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(JKMPONNDNDF));
	}

	private void IKNJFKIBCMG()
	{
		CBEDHJJKLFF(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	public bool MIKMFCFCHPP()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void DAOJOFAOPEC()
	{
		PCKABALNDAC();
	}

	private void GLEJGFLCLPJ()
	{
		StartCoroutine(OGJGNCKCLAE());
	}

	private void HECGJGAEOID()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
	}

	private void OJIHBHNJFBB()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(JKMPONNDNDF));
	}

	private string LFBMPDPAOFH(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_ScreenResolution", Environment.NewLine);
	}

	private void BPNDDNKKFDD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(GGHCKMDEIPH));
	}

	private void JKBMKPDGCHG()
	{
		StartCoroutine(FNEIHKJEPBD());
	}

	private void JIBIMBGEBAP()
	{
		BMDOMKKNHAA(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private IEnumerator POCPKICJPFE()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void LDLPCEKMKOA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(ECHCAAJIOFB));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		GGHCKMDEIPH();
	}

	private void NILPHJIMCOJ(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = NKFDJOKNHKM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "#mapby") && !(EAFAMAMDNEG == string.Format(".icon", _string)))
		{
		}
	}

	private IEnumerator GNHBLNKLCBG()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	public bool ANFOPKCKCBL()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void LGAJFNNKGGL(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = DEBMGGDPDIE(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "Despawn environment object by id") && !(EAFAMAMDNEG == string.Format("Brightness", _string)))
		{
		}
	}

	private void AIFOJKKGPAE()
	{
		NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private void GJJKCBMHBKF(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = IHOAIDIJPNA(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "#close") && !(EAFAMAMDNEG == string.Format("[PlayerController] ", _string)))
		{
		}
	}

	private string LHALNEMEPJK(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Skybox", Environment.NewLine);
	}

	private void PMLLOEGKPGG()
	{
		DFHLFHPPPOD(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	private void EGIBNPNGOIK()
	{
		GHJJDAJIOPM(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private void HAIAHJPCPAG()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private void Start()
	{
		StartCoroutine(POCPKICJPFE());
	}

	private void NMILFNBCAMH(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = DBKPOMBOILM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "_BlurParams") && !(EAFAMAMDNEG == string.Format("Items/", _string)))
		{
		}
	}

	public bool BMAHPFENAHP()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private string JLOIEAKHCNO(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace(" or player:", Environment.NewLine);
	}

	private void AAPKEGAJABJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(AACHLFMEPIA));
	}

	private string DLAMDOADKLD(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("intensity", Environment.NewLine);
	}

	private void MINBMBHOGFD()
	{
		BJEKNHKJHPD();
	}

	private void NNFMIAFHMJM()
	{
		StartCoroutine(AOHNELGHACA());
	}

	private IEnumerator CCOHFBLMOJK()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void JKMPONNDNDF()
	{
		PCKABALNDAC();
	}

	private string DBKPOMBOILM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_TimeX", Environment.NewLine);
	}

	private void DJOOKCAPEHA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(MINBMBHOGFD));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CIJHMEKMMNL();
	}

	private void CPDIKGMOAMF()
	{
		DFHLFHPPPOD(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private void EHMGKLLKINB()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(BBJDNFFDKBN));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		DAOJOFAOPEC();
	}

	private void IFJGGEAMFON()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(AACHLFMEPIA));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CBMBHICHMGI();
	}

	private void JAKIEPHKMMG(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = COMHNBJCPHM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "_TimeX") && !(EAFAMAMDNEG == string.Format("_FixDistance", _string)))
		{
		}
	}

	private void JAFENCCFFML()
	{
		PCKABALNDAC();
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

	public bool OGDDBFIGOJE()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void MLAKNIGKOHO()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
	}

	private void KFDFBMFKHDA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(GOCDFEABHHB));
	}

	private void CAPPPBJAEEE(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = CDCMECNNCAG(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "CameraFilterPack_TV_Arcade1") && !(EAFAMAMDNEG == string.Format("checkpoint", _string)))
		{
		}
	}

	private void LFAFJKJAEEL()
	{
		StartCoroutine(AOHNELGHACA());
	}

	private void CBEDHJJKLFF(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = JLOIEAKHCNO(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "_Saturation") && !(EAFAMAMDNEG == string.Format("[Up]", _string)))
		{
		}
	}

	private IEnumerator LKAGNCOCHEI()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void CIJHMEKMMNL()
	{
		MNHCBCCOOMJ();
	}

	private IEnumerator KILFEEMMFKJ()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private IEnumerator FHGJNKHGPGC()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private IEnumerator OGJGNCKCLAE()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void AACHLFMEPIA()
	{
		PCKABALNDAC();
	}

	private void FJGNDJGLBEN()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(GOCDFEABHHB));
	}

	private void AKHCOBHHGJP()
	{
		StartCoroutine(GNHBLNKLCBG());
	}

	private void ELJLABPNDOE()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(NFGBFPOBEBE));
	}

	private void ECHCAAJIOFB()
	{
		AIFOJKKGPAE();
	}

	private void CBMBHICHMGI()
	{
		NEEPEGIEHPF();
	}

	public bool CJDAEBMOAJK()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void CHCKAEFABJA()
	{
		HLFHPKHKEFD(LocalizationService.Instance.HOPMEAJKPHL(_string));
	}

	private void DFHLFHPPPOD(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = NKFDJOKNHKM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "{0:0} day{1}, ") && !(EAFAMAMDNEG == string.Format("_PColor", _string)))
		{
		}
	}

	private void CHDGEHMPCMH()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(BBJDNFFDKBN));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		JKMPONNDNDF();
	}

	private void DDEKPGECKCD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		NFADGEDMNMF();
	}

	public bool DGCKNEBDDBB()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private string PEEMCNMCGBP(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("DPADHOR", Environment.NewLine);
	}

	private string COMHNBJCPHM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Value2", Environment.NewLine);
	}

	private void CIEPPCBBLIF()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(GGHCKMDEIPH));
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		CBMBHICHMGI();
	}

	public bool EGHOAOGAHMA()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private string HHHPAKCIMPA(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("{0} minutes ago", Environment.NewLine);
	}

	private void JKFDDNMPOJH()
	{
		StartCoroutine(FNEIHKJEPBD());
	}

	public bool AFILHMMDKAD()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void OnDestroy()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(NFADGEDMNMF));
	}

	private void AEDDNDHCLNN()
	{
		StartCoroutine(FNEIHKJEPBD());
	}

	private void JCHLGFDAAGC()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(CBMBHICHMGI));
	}

	public bool MFMEDAFHAAO()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private string NKFDJOKNHKM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_ScreenResolution", Environment.NewLine);
	}

	private void JJJABCLKCOD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(JKMPONNDNDF));
	}

	public bool IsHasOutputHelper()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void OLPCDNOICOM()
	{
		DFHLFHPPPOD(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	public bool KPOPMDOINLB()
	{
		OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return OCAMCGEINLB != null;
	}

	private void BMDOMKKNHAA(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = NKFDJOKNHKM(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "MusicFileSelector") && !(EAFAMAMDNEG == string.Format("_Value", _string)))
		{
		}
	}

	private void GGHCKMDEIPH()
	{
		CPDIKGMOAMF();
	}

	private void LGHCJCFHEMF()
	{
		StartCoroutine(OGJGNCKCLAE());
	}

	private IEnumerator FNEIHKJEPBD()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private string DEBMGGDPDIE(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("Protocol switch from: ", Environment.NewLine);
	}

	private void BJEKNHKJHPD()
	{
		BMDOMKKNHAA(LocalizationService.Instance.GetLocalizatedText(_string));
	}

	private IEnumerator IJEFOOHFHJD()
	{
		yield return new WaitWhile(() => LocalizationService.Instance == null || (LocalizationService.Instance != null && !LocalizationService.Instance.inited));
		DDEKPGECKCD();
	}

	private void NFGBFPOBEBE()
	{
		AIFOJKKGPAE();
	}

	private void HLFHPKHKEFD(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = LFBMPDPAOFH(EAFAMAMDNEG);
		if (OCAMCGEINLB != null)
		{
			OCAMCGEINLB.text = ((!useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (!(EAFAMAMDNEG == "curScn") && !(EAFAMAMDNEG == string.Format("1159514800", _string)))
		{
		}
	}
}
