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

	public virtual void AGEJKLMJGDO()
	{
		JHBKBOFFBIJ = new Thread(PPEKEGNDEHL);
		JHBKBOFFBIJ.Start();
	}

	[SpecialName]
	public bool FIJCPDOBEEI()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void IECFHDBHBED()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void CNJDBEKDJPO()
	{
	}

	protected virtual void CDDKPLKBMPJ()
	{
	}

	public IEnumerator INJIININAKM()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void IOKOCPLIHFK()
	{
	}

	public virtual void Start()
	{
		JHBKBOFFBIJ = new Thread(CCCCEEIEBAC);
		JHBKBOFFBIJ.Start();
	}

	[SpecialName]
	public void PHGJBMHMCHJ(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public IEnumerator NJLGBPKAAEB()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	[SpecialName]
	public bool BCNIJPGCOOE()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual bool JBNPEHMDCMI()
	{
		if (IsDone)
		{
			IHCBHMKFDMK();
			return false;
		}
		return true;
	}

	private void PKKHPCOLNGC()
	{
		JAFCCBIPELN();
		AEKHHCHLJJD(true);
	}

	public IEnumerator PMJNJFLEMMO()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public IEnumerator JPANNALKAFD()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void PAKPHKPDKGE()
	{
		JHBKBOFFBIJ = new Thread(EBGKDJPBFPI);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void ODMOKEHNALI()
	{
	}

	protected virtual void HOAJKHOOEJI()
	{
	}

	public IEnumerator FIGGJJPGOJL()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void MNFONFLHHFL()
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

	private void EBGKDJPBFPI()
	{
		CNJDBEKDJPO();
		PHGJBMHMCHJ(false);
	}

	public virtual void BKEICCPCDIO()
	{
		JHBKBOFFBIJ.Abort();
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

	public virtual void LBDJBKEKALL()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void IHCBHMKFDMK()
	{
	}

	[SpecialName]
	public void AEKHHCHLJJD(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	[SpecialName]
	public void MMIBGKLFGKN(bool DPNHODJHGJL)
	{
		lock (BNNAECCMLCB)
		{
			HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	public IEnumerator NMNBACMMHJM()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void DAHFFNNIGML()
	{
		JHBKBOFFBIJ = new Thread(COKOANLBCCM);
		JHBKBOFFBIJ.Start();
	}

	public IEnumerator OMCDMKGMMBP()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void BLFNOPKJDGC()
	{
	}

	private void IHCBCILHDHF()
	{
		CNJDBEKDJPO();
		MMIBGKLFGKN(false);
	}

	public virtual void Abort()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void GEJKOHKEEHF()
	{
		JHBKBOFFBIJ.Abort();
	}

	private void DCAPPAPIBKJ()
	{
		CNJDBEKDJPO();
		PHGJBMHMCHJ(false);
	}

	private void COKOANLBCCM()
	{
		HNBCBALPKON();
		AEKHHCHLJJD(true);
	}

	[SpecialName]
	public bool BJAMIKAPFBK()
	{
		lock (BNNAECCMLCB)
		{
			return HNHEJMGLAIG;
		}
	}

	public virtual void IMCKJCHKMKB()
	{
		JHBKBOFFBIJ = new Thread(IHMAKINGADF);
		JHBKBOFFBIJ.Start();
	}

	private void IHMAKINGADF()
	{
		JAFCCBIPELN();
		IsDone = true;
	}

	public IEnumerator NMDNIJFCFIE()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	protected virtual void MBPJCAPNFCC()
	{
	}

	protected virtual void GKEEMJLCCHK()
	{
	}

	public IEnumerator HPDONKGFGGA()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void CCEIGFALMML()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void HMCFBEENDMG()
	{
		JHBKBOFFBIJ.Abort();
	}

	protected virtual void JAFCCBIPELN()
	{
	}

	private void MFDAIMAAIEE()
	{
		GKEEMJLCCHK();
		IsDone = true;
	}

	private void PPEKEGNDEHL()
	{
		JAFCCBIPELN();
		AEKHHCHLJJD(false);
	}

	public virtual void KIMMMCJFMAB()
	{
		JHBKBOFFBIJ = new Thread(PKKHPCOLNGC);
		JHBKBOFFBIJ.Start();
	}

	public virtual void CIIBLDNFLEL()
	{
		JHBKBOFFBIJ.Abort();
	}

	public virtual void FEHCNJLLJMP()
	{
		JHBKBOFFBIJ = new Thread(CCCCEEIEBAC);
		JHBKBOFFBIJ.Start();
	}

	public virtual void DNNFHBOOPIN()
	{
		JHBKBOFFBIJ = new Thread(PKKHPCOLNGC);
		JHBKBOFFBIJ.Start();
	}

	protected virtual void HNBCBALPKON()
	{
	}

	private void CCCCEEIEBAC()
	{
		JAFCCBIPELN();
		IsDone = true;
	}

	public virtual void FANADGBGCPI()
	{
		JHBKBOFFBIJ = new Thread(EBGKDJPBFPI);
		JHBKBOFFBIJ.Start();
	}

	private void NGDBPHBAECA()
	{
		GKEEMJLCCHK();
		PHGJBMHMCHJ(true);
	}

	public virtual void FGAMEFONIGF()
	{
		JHBKBOFFBIJ.Abort();
	}

	public IEnumerator WaitFor()
	{
		while (!Update())
		{
			yield return null;
		}
	}

	public virtual void JNJPKDHOKAB()
	{
		JHBKBOFFBIJ.Abort();
	}
}
