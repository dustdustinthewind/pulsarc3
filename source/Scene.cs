// Scene
using System.Runtime.CompilerServices;
using UnityEngine;

public class Scene : Singleton<Scene>
{
	public bool hideCursor = true;

	public bool lockCursor = true;

	public string id => GetType().ToString();

	public virtual void MJEFMIPLFAB()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string KHDLEJLPGKP()
	{
		return GetType().ToString();
	}

	public void NJPIIAECJFO(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public virtual void MEBPBNLBECA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string AMEGOBFCECJ()
	{
		return GetType().ToString();
	}

	public void GNHEECNBLOC(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		DKPCMCEGMME(false);
	}

	public void GMGMPMIIMLP(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		FACGFLHIDCL(true);
	}

	[SpecialName]
	public string IKPGAGMDCLP()
	{
		return GetType().ToString();
	}

	public void LOIDEKAJHJM(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	[SpecialName]
	public string EODGDBPONOL()
	{
		return GetType().ToString();
	}

	public void ALAJMFBMENK(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		OKKKFINFMDJ(true);
	}

	public virtual void MKIMDFLBFOM()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string DPALDJIDPDN()
	{
		return GetType().ToString();
	}

	public void PMEEJELAKKL(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		MMHHMCKBJBL(false);
	}

	public virtual void NCPAFCKGJEA()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void BGDPIHMAACO()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void LICGKFKFJOF(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		JHKNPBHCBEJ(false);
	}

	public void DPAJGNPKAHD(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	[SpecialName]
	public string CHDCIFPPIFI()
	{
		return GetType().ToString();
	}

	public void ShowCursor(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		LockCursor(false);
	}

	public void FMNOONOIHDC(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void OKKKFINFMDJ(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void FIMAMPOCBFK(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void MMHHMCKBJBL(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void PEFMNHNECBK(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		OKKKFINFMDJ(true);
	}

	public void KAGHABABGCB(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		CKODJNPKHOI(false);
	}

	public void CIEGLBDAOOI(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		OKKKFINFMDJ(false);
	}

	public void JCEKIILMPHH(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		DKPCMCEGMME(false);
	}

	public virtual void FLKEJJEGCFA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void BDMABAGHOOF(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		MMHHMCKBJBL(false);
	}

	public virtual void NKLIHNJCHOG()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string CFNPEEMCLJP()
	{
		return GetType().ToString();
	}

	public void PMHAHKGFPLK(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		DKPCMCEGMME(true);
	}

	public virtual void KDMANOEMOCA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void Start()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void MFMIODIAKNI()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string ALIGPAANMFA()
	{
		return GetType().ToString();
	}

	public virtual void DLBODOFAJGM()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void JFJLGJEPEAA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void HPNNCNNFMGK()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string PACECPHKLNE()
	{
		return GetType().ToString();
	}

	public void OMGILEICCNJ(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		NJPIIAECJFO(false);
	}

	public virtual void BGFJOEPFOPM()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void DKPCMCEGMME(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void NFJBCNGPCAO(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		FACGFLHIDCL(true);
	}

	public virtual void LCJHDLKJEOM()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void ODBNMPGBCGO()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void FOMNCPKKCFN()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void CKODJNPKHOI(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void DEFOLPODPPI(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void KIJNHCEDOPE(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		DKPCMCEGMME(true);
	}

	[SpecialName]
	public string EMOAHNADEHK()
	{
		return GetType().ToString();
	}

	public virtual void NFEDLAOPHML()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string JOAAANFJKIC()
	{
		return GetType().ToString();
	}

	public virtual void GCDLIKEDMCF()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void IDIIELPAMCJ()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void PHJJHFBLICM()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void ADPLHDFJFID()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string GEDAFOHFDIA()
	{
		return GetType().ToString();
	}

	public void OAKIFMFLMPI(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void GFNINHCBMAN(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		DEFOLPODPPI(true);
	}

	[SpecialName]
	public string CNEOMFHNLOD()
	{
		return GetType().ToString();
	}

	public virtual void EHCGBJDFMHG()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string PNOCNIBEHMF()
	{
		return GetType().ToString();
	}

	public virtual void KCDBBPKIFNJ()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string FJNAJNBGCJD()
	{
		return GetType().ToString();
	}

	public virtual void CFFCLAHMBAA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void PLCAPHCDHJK(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		DKPCMCEGMME(true);
	}

	[SpecialName]
	public string GOMJAEIDHNM()
	{
		return GetType().ToString();
	}

	public void ALBDINIHDNE(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		NJPIIAECJFO(true);
	}

	public virtual void FIKFJDFELIP()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void MDNHCLKNCLE()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void OAIIEOHOKGJ(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		FMNOONOIHDC(false);
	}

	[SpecialName]
	public string BDJMLNLIIMB()
	{
		return GetType().ToString();
	}

	public virtual void EPEGAEGDJAM()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void PJHICJBICHE(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		DEFOLPODPPI(true);
	}

	public virtual void BGDONBMDPGM()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void IBHACCEEFFI()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void JHKNPBHCBEJ(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public void HNCCOHFLKAN(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	[SpecialName]
	public string KEGJGPOECHA()
	{
		return GetType().ToString();
	}

	public virtual void AIJGAJIOJDJ()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void AEDABLEPKLG(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public virtual void MBLDJEFBLFL()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void BOECOLNJNOC(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		FIMAMPOCBFK(true);
	}

	public void NCJKEKHBFHA(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		HNCCOHFLKAN(false);
	}

	[SpecialName]
	public string LCBFAFEADIO()
	{
		return GetType().ToString();
	}

	public void OGDCFEEPFNG(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public virtual void KLILJHJNICK()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string HLGJHICPDMO()
	{
		return GetType().ToString();
	}

	public virtual void LJIHHJOAJCN()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void JDONOMPKEED(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		OGDCFEEPFNG(false);
	}

	public virtual void KOJKBFDNGDK()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	[SpecialName]
	public string CFADADIIOAM()
	{
		return GetType().ToString();
	}

	public void NCLFDGJCJGK(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		HNCCOHFLKAN(false);
	}

	[SpecialName]
	public string EKIBIEFGIJC()
	{
		return GetType().ToString();
	}

	public virtual void NEKCPLGFOFD()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void LBAJLLFMMMP()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void AJOOLOFFFGF(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		FMNOONOIHDC(true);
	}

	public virtual void BEBNOKFLJPH()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void OIBMHPIFAKK()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void LockCursor(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	[SpecialName]
	public string HJCBNLFCNAM()
	{
		return GetType().ToString();
	}

	public virtual void JILOMOBDPIA()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = false;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void DFFKKLAPHCC()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void JECMJNFGBGC()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string HPKHOICGMFC()
	{
		return GetType().ToString();
	}

	public void EEOIHHPKPAC(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}

	public virtual void KIMMMCJFMAB()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	[SpecialName]
	public string KCGOFGJNCME()
	{
		return GetType().ToString();
	}

	public void IDCJMKMMGJA(bool IDNLBGOCOEK)
	{
		hideCursor = IDNLBGOCOEK;
		OKKKFINFMDJ(false);
	}

	public virtual void Update()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public virtual void LCDJFJIBADI()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public virtual void DPIPGGDNGHN()
	{
		if (hideCursor)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void GIIBKOADAMF(bool IDNLBGOCOEK)
	{
		hideCursor = !IDNLBGOCOEK;
		OKKKFINFMDJ(true);
	}

	public virtual void LFAFJKJAEEL()
	{
		if (hideCursor)
		{
			Cursor.visible = true;
		}
		else
		{
			Cursor.visible = true;
		}
		if (lockCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void FACGFLHIDCL(bool NODADLMFEBA)
	{
		lockCursor = NODADLMFEBA;
	}
}
