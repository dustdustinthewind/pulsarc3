// ThreadedJob
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;

public class ThreadedJob
{
	private bool HNHEJMGLAIG;

	private object BNNAECCMLCB = new object();

	private Thread JHBKBOFFBIJ;

	public bool IsDone
	{
		get
		{
			lock (BNNAECCMLCB)
			{
				return HNHEJMGLAIG;
			}
		}
		set
		{
			lock (BNNAECCMLCB)
			{
				HNHEJMGLAIG = value;
			}
		}
	}

	protected virtual void CGMJODOBINA()
	{
	}

	public virtual void HEAPJGAGAGL()
	{
		JHBKBOFFBIJ.Abort();
	}

	private void CCCCEEIEBAC()
	{
		JAFCCBIPELN();
		IsDone = true;
	}

	[SpecialName]
	public bool HCCJFONPKNG()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	[SpecialName]
	public void MCKEKOENPKO(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual void LAAOPGMOANL()
	{
		JHBKBOFFBIJ.Abort();
	}

	[SpecialName]
	public void MMIBGKLFGKN(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual bool JBCNIPJDPJB()
	{
		if (NJPGLBKALNF())
		{
			HHDOHGLHNHI();
			return false;
		}
		return true;
	}

	public IEnumerator PMJNJFLEMMO()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	private void OEFGKIDPCEE()
	{
		KACOCMHIAHP();
		JGIBKOGBOCL(true);
	}

	public IEnumerator CINPOEOOEAK()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void NHDNCAMNNDP()
	{
	}

	[SpecialName]
	public void NEMELABJNAD(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public IEnumerator PIHBFBHOCBN()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public void NKJHEMBBEKJ(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	protected virtual void JCFLIHMPFKN()
	{
	}

	public virtual void IIKJGEAGILG()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void KACOCMHIAHP()
	{
	}

	[SpecialName]
	public bool HDIOCHHNKAD()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual bool JAAJECBCCFM()
	{
		if (IsDone)
		{
			HHDOHGLHNHI();
			return false;
		}
		return true;
	}

	private void PELOINOKMIE()
	{
		HNBCBALPKON();
		BFHNLICBHGM(false);
	}

	[SpecialName]
	public void HECLDMBBBFK(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	[SpecialName]
	public void NMCILFOEIMF(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public IEnumerator FIGGJJPGOJL()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void JAFCCBIPELN()
	{
	}

	public virtual bool GHILDCBCDJI()
	{
		if (BFANLENFGBJ())
		{
			NPDCBGFHHAF();
			return true;
		}
		return true;
	}

	private void KKOOFPMGNBN()
	{
		HNBCBALPKON();
		PHFOAMNOLOI(true);
	}

	protected virtual void HHDOHGLHNHI()
	{
	}

	public IEnumerator LPGHFFEOBJC()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void DEEGILEDNBM()
	{
		JHBKBOFFBIJ.Abort();
	}

	private void EOPBPOPPOKG()
	{
		INEIAMHKAFF();
		PHFOAMNOLOI(true);
	}

	protected virtual void BLFNOPKJDGC()
	{
	}

	protected virtual void MNOCACNOIPB()
	{
	}

	protected virtual void INEIAMHKAFF()
	{
	}

	[SpecialName]
	public void ADPHNKCNFHJ(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual void MIAKPNFLJDO()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void OLBNEHNLGLO()
	{
	}

	[SpecialName]
	public bool CMANEFCBEBB()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void FNCDAPDOBBI()
	{
		JHBKBOFFBIJ = new Thread(GHJBLLBNBBM);
		JHBKBOFFBIJ.Start();
	}

	public IEnumerator KJPPHFHBPAK()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public void GAOKHINEGAD(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	[SpecialName]
	public void PHFOAMNOLOI(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	private void DAJEGGEMJMA()
	{
		CGMJODOBINA();
		IENPOLLNILL(true);
	}

	private void AIJAHEOABKJ()
	{
		GODPOOJFKEF();
		NMCILFOEIMF(false);
	}

	protected virtual void BCPDKGMCFPL()
	{
	}

	public virtual void CCLNNLCOPBL()
	{
		JHBKBOFFBIJ = new Thread(GHJBLLBNBBM);
		JHBKBOFFBIJ.Start();
	}

	public virtual void MODENHKMKOC()
	{
		JHBKBOFFBIJ = new Thread(LADLLJDECAM);
		JHBKBOFFBIJ.Start();
	}

	public virtual void HDMDKOKOOJC()
	{
		JHBKBOFFBIJ = new Thread(AIJAHEOABKJ);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void JHJKOHMCKAH()
	{
	}

	public IEnumerator LLHCIAKLMHG()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void HIPEHGNBJMN()
	{
		JHBKBOFFBIJ = new Thread(GGILEEHGNFP);
		JHBKBOFFBIJ.Start();
	}

	public virtual void Start()
	{
		JHBKBOFFBIJ = new Thread(CCCCEEIEBAC);
		JHBKBOFFBIJ.Start();
	}

	private void GBGFCGHHKJL()
	{
		HNBCBALPKON();
		BFHNLICBHGM(false);
	}

	[SpecialName]
	public void JGIBKOGBOCL(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual void HLIGOANMMIB()
	{
		JHBKBOFFBIJ.Abort();
	}

	[SpecialName]
	public void IENPOLLNILL(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual void DICMBDCKBKH()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void JLAPONBAOHB()
	{
	}

	private void FODBDKLKIGD()
	{
		JLAPONBAOHB();
		MMIBGKLFGKN(true);
	}

	public virtual bool FOLDLDLFFLM()
	{
		if (BFANLENFGBJ())
		{
			MMKBEAKPBIK();
			return false;
		}
		return true;
	}

	protected virtual void COOHMDACKGM()
	{
	}

	private void BCLEBNAOOGN()
	{
		JCFLIHMPFKN();
		BFHNLICBHGM(true);
	}

	public virtual void EFJDNLGNACH()
	{
		JHBKBOFFBIJ = new Thread(PELOINOKMIE);
		JHBKBOFFBIJ.Start();
	}

	public virtual bool EIDKCANPHJE()
	{
		if (MNJBDMBMKCN())
		{
			DHEBIKHIIAP();
			return false;
		}
		return false;
	}

	public IEnumerator ADGKLGALNJI()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public bool PFLCOPNEOPE()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void JFJLGJEPEAA()
	{
		JHBKBOFFBIJ = new Thread(OEFGKIDPCEE);
		JHBKBOFFBIJ.Start();
	}

	public virtual void JDKHBGDEONK()
	{
		JHBKBOFFBIJ = new Thread(OEFGKIDPCEE);
		JHBKBOFFBIJ.Start();
	}

	public virtual void OGJJDKENBNC()
	{
		JHBKBOFFBIJ = new Thread(GHJBLLBNBBM);
		JHBKBOFFBIJ.Start();
	}

	public virtual bool Update()
	{
		if (IsDone)
		{
			BLFNOPKJDGC();
			return true;
		}
		return false;
	}

	private void LADLLJDECAM()
	{
		KDCODIEELCE();
		NKJHEMBBEKJ(true);
	}

	public IEnumerator WaitFor()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void IDJKNBDKHBD()
	{
		JHBKBOFFBIJ = new Thread(GGILEEHGNFP);
		JHBKBOFFBIJ.Start();
	}

	[SpecialName]
	public void BFHNLICBHGM(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	protected virtual void BOACMLIHMGP()
	{
	}

	public virtual void MOJOIOOMBND()
	{
		JHBKBOFFBIJ.Abort();
	}

	private void EGJLMGLPLLG()
	{
		OIGJMFDCHKL();
		IENPOLLNILL(true);
	}

	public IEnumerator PONLOCOEIBC()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	private void GHJBLLBNBBM()
	{
		OIGJMFDCHKL();
		MBMBALOMJOM(false);
	}

	public virtual bool KCDOMIJBFLL()
	{
		if (IsDone)
		{
			MNOCACNOIPB();
			return true;
		}
		return true;
	}

	protected virtual void KDCODIEELCE()
	{
	}

	public IEnumerator LPBMGFBKACK()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void DHEBIKHIIAP()
	{
	}

	public virtual bool IAJKLKJJKEJ()
	{
		if (CMANEFCBEBB())
		{
			GLCNIPIBCAA();
			return true;
		}
		return false;
	}

	public virtual void LDALEDAOINM()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void BCMNBHHMKOP()
	{
	}

	public virtual void DMMBIAOENGI()
	{
		JHBKBOFFBIJ.Abort();
	}

	[SpecialName]
	public bool NJPGLBKALNF()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	protected virtual void CNJDBEKDJPO()
	{
	}

	public virtual void CKLFGEEELFC()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void OMEMPHADKEL()
	{
		JHBKBOFFBIJ.Abort();
	}

	private void MEJIHBBNOPM()
	{
		NHDNCAMNNDP();
		NMCILFOEIMF(false);
	}

	[SpecialName]
	public void MBMBALOMJOM(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public virtual void DKEHGPPOKEA()
	{
		JHBKBOFFBIJ = new Thread(DAJEGGEMJMA);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void FFGILCAEJMD()
	{
	}

	[SpecialName]
	public bool BDHGIHHGLJF()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void KHIALHDDPEP()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void KCCIEMBMOBA()
	{
		JHBKBOFFBIJ = new Thread(MEJIHBBNOPM);
		JHBKBOFFBIJ.Start();
	}

	public virtual void LCMDHDFOGIE()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void MGMAOBPPOBJ()
	{
		JHBKBOFFBIJ = new Thread(MEJIHBBNOPM);
		JHBKBOFFBIJ.Start();
	}

	public IEnumerator KPHILEKHJBL()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void GODPOOJFKEF()
	{
	}

	public virtual void BMOFEBKGLFI()
	{
		JHBKBOFFBIJ = new Thread(GBGFCGHHKJL);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void IHCBHMKFDMK()
	{
	}

	private void DOGDFFCDNPA()
	{
		BCPDKGMCFPL();
		GAOKHINEGAD(true);
	}

	[SpecialName]
	public bool MNJBDMBMKCN()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void OMILIDAPCAJ()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void NPDCBGFHHAF()
	{
	}

	private void OKALLNNKFHD()
	{
		CGMJODOBINA();
		NKJHEMBBEKJ(true);
	}

	public virtual void GNBIIMFLIPK()
	{
		JHBKBOFFBIJ.Abort();
	}

	[SpecialName]
	public bool JBEOCIOKEJA()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void Abort()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual bool BGDONBMDPGM()
	{
		if (HNKOKBMLIDI())
		{
			IHCBHMKFDMK();
			return true;
		}
		return true;
	}

	public virtual void CCHMIEFEGFJ()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void OKLAJINHPAN()
	{
		JHBKBOFFBIJ = new Thread(GBGFCGHHKJL);
		JHBKBOFFBIJ.Start();
	}

	public virtual bool BMODOIJGIOO()
	{
		if (BCNIJPGCOOE())
		{
			COOHMDACKGM();
			return false;
		}
		return true;
	}

	public virtual bool LJIHHJOAJCN()
	{
		if (IsDone)
		{
			MMKBEAKPBIK();
			return false;
		}
		return false;
	}

	public IEnumerator LHCLMIIOCIH()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public bool LHLIAPPHDJO()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	protected virtual void EAEAHCKIDCP()
	{
	}

	private void GGILEEHGNFP()
	{
		BCPDKGMCFPL();
		JGIBKOGBOCL(false);
	}

	protected virtual void MMKBEAKPBIK()
	{
	}

	protected virtual void OIGJMFDCHKL()
	{
	}

	public virtual bool HLDFOJMHKNL()
	{
		if (BDHGIHHGLJF())
		{
			BOACMLIHMGP();
			return false;
		}
		return true;
	}

	public virtual void AEMGPJDJGBJ()
	{
		JHBKBOFFBIJ = new Thread(DAJEGGEMJMA);
		JHBKBOFFBIJ.Start();
	}

	public IEnumerator KOOMMNGHMLC()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void JECMJNFGBGC()
	{
		JHBKBOFFBIJ = new Thread(KKOOFPMGNBN);
		JHBKBOFFBIJ.Start();
	}

	public virtual void MHMFAABEMEK()
	{
		JHBKBOFFBIJ.Abort();
	}

	public IEnumerator LLEFONJNLCL()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public bool HNKOKBMLIDI()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	protected virtual void CIFGNLJLCMM()
	{
	}

	protected virtual void HNBCBALPKON()
	{
	}

	protected virtual void GKEEMJLCCHK()
	{
	}

	private void FGMPLDOJGOC()
	{
		CGMJODOBINA();
		MCKEKOENPKO(false);
	}

	public IEnumerator KAFAJEJLHFP()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void MDEAHHIHOFK()
	{
	}

	[SpecialName]
	public bool BCNIJPGCOOE()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void NCNPAKFAFOE()
	{
		JHBKBOFFBIJ = new Thread(PELOINOKMIE);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void GLCNIPIBCAA()
	{
	}

	public virtual void JEJABONIBAN()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void BKEICCPCDIO()
	{
		JHBKBOFFBIJ.Abort();
	}

	public IEnumerator IEBGEEIDKKE()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public bool BFANLENFGBJ()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	private void EOEBGHHLPCD()
	{
		JCFLIHMPFKN();
		IsDone = true;
	}
}
