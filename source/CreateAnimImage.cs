// CreateAnimImage
using System.Collections.Generic;
using UnityEngine;

public class CreateAnimImage : MonoBehaviour
{
	public CreateAnimImage[] createImageOtherReference;

	public GameObject CreateInstance;

	public int HowManyButtons;

	public Vector3 StartAnim;

	public Vector3 EndAnim;

	public float Offset;

	public AnimationCurve EnterAnim;

	public AnimationCurve ExitAnim;

	public RectTransform RootRect;

	public RectTransform RootCanvas;

	private List<EasyTween> ABIMNKKBBKF = new List<EasyTween>();

	private Vector2 AFBJLGGJPEG;

	private float GDDJIOHEJGI;

	private void CCFEDENFNEF()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void CBFFGNOMEAK()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void OELGHOFHAGM()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	private void EIIJCCJLNDD()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 786f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.LMHFGDCFHOD();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void HHAPCIEKHKG()
	{
		ACEEIAIDHLC();
		JEHCPIHNKFM();
	}

	public void MCMLDECJOPH()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		ABIMNKKBBKF.Clear();
	}

	public void KAMOLLFOLHI()
	{
		KCCIJMNMADC();
		KNOFOFMEDOB();
	}

	private void KNMMNHEBMDI()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void EENNPPGMDLL()
	{
		IKOJNDGFKGM();
		HFBDGAOLJFB();
	}

	private void JKBMKPDGCHG()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void GEPIEEJAEMK()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].OELGHOFHAGM();
			}
			APFJEOHIDNN();
		}
	}

	private void JECMJNFGBGC()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void IKOJNDGFKGM()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1656f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.DJLKKODJHNP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void KNBJBNDGCIJ()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void EPEGAEGDJAM()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void ICILLMAKLMI()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void NBLMHJKINBM()
	{
		LFKNLGCIDHA();
		DIDHCAKMLOB();
	}

	private void EHIHOHBPDMH()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1658f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.BIIIKDKNLHH();
			component.ODJBGKGFCOE();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void LFKNLGCIDHA()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 361f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.BBINADBINLO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.BAGJNDODMCP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void JEDMPPOOBKC()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].LNPONHBGCJB();
			}
			EENNPPGMDLL();
		}
	}

	private void JOKPKIKDPEJ()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void CIPKEPDELJB()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void CCJMDELIJDP()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		ABIMNKKBBKF.Clear();
	}

	public void NECLICEIOKN()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		ABIMNKKBBKF.Clear();
	}

	private void HFECDNAKJGE()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void DCFKADMCJME()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].CADCBLBPNGD();
			}
			FCCLBLACJFK();
		}
	}

	public void CHPOBKBGJHJ()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		ABIMNKKBBKF.Clear();
	}

	private void CKABHECOIOL()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1890f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.ODJBGKGFCOE();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void APFJEOHIDNN()
	{
		MAPMOEGANFP();
		JFILJNLFDJL();
	}

	private void LJAJGEDIJKC()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void COBGLOPODPI()
	{
		EJKGAAIOAPA();
		HFECDNAKJGE();
	}

	private void AFEOEMBNGOL()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 0f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void HFBDGAOLJFB()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void POBMDIKPGGF()
	{
		ICDNPNAHCGA();
		JOKPKIKDPEJ();
	}

	public void PCGIJPAKBAE()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	public void HGDHFKJNFHG()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		ABIMNKKBBKF.Clear();
	}

	public void OOIDPIKMFHJ()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].GIAJEMNMCDA();
		}
		ABIMNKKBBKF.Clear();
	}

	private void PPNFLGFIFAM()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 247f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.BAGJNDODMCP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void CreateButtons()
	{
		AFEOEMBNGOL();
		FGIIEGMMKND();
	}

	public void APNJFAEHFFH()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].OOIDPIKMFHJ();
			}
			NBLMHJKINBM();
		}
	}

	public void DLMMFHILKPL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].NECLICEIOKN();
			}
			OLDKBAOMCLN();
		}
	}

	public void KNIPGEGIMOI()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		ABIMNKKBBKF.Clear();
	}

	public void EFODNPIDAMC()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].CCJMDELIJDP();
			}
			APFJEOHIDNN();
		}
	}

	private void BGAMEGDKEJB()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 85f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.ODJBGKGFCOE();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void KHIGHFJKPFG()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void PPBMBCKCJLH()
	{
		HIAILIFCMKK();
		HFECDNAKJGE();
	}

	private void DIDHCAKMLOB()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void LNDGEMEOFKL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].NHGFAFFIACM();
			}
			OLDKBAOMCLN();
		}
	}

	private void APILMONBJEN()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 68f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.HEGLICFNJCM(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.BIIIKDKNLHH();
			component.OpenCloseObjectAnimation();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void JLDFAFAIBBB()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].MCMLDECJOPH();
			}
			COBGLOPODPI();
		}
	}

	public void LNPONHBGCJB()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].AILAMHCFDOB();
		}
		ABIMNKKBBKF.Clear();
	}

	private void ACEEIAIDHLC()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 77f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.BBINADBINLO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.BAGJNDODMCP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void OKLAJINHPAN()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void PAKPHKPDKGE()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void KNOFOFMEDOB()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void MOPFHJNLMGP()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EAODJGNIKJD();
			}
			OLDKBAOMCLN();
		}
	}

	private void NNPKKIGLMCJ()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1631f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.LMHFGDCFHOD();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void LPEAGALOLKE()
	{
		LFKNLGCIDHA();
		KPKDKDIKNNK();
	}

	public void OOPIFOGNBPF()
	{
		JDJBHBAOIOF();
		NKOHAIMNONI();
	}

	private void EJDMILHICDI()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1580f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.LMHFGDCFHOD();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void IEJNFKIHOLG()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].BJKMBOFPNLD();
			}
			FCCLBLACJFK();
		}
	}

	private void CNHNKBMJEKH()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 273f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.ODJBGKGFCOE();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void BPIHDBDGJAF()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	public void BBKMIELOJJG()
	{
		ACEEIAIDHLC();
		KNOFOFMEDOB();
	}

	public void JHGAIGNDPMK()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		ABIMNKKBBKF.Clear();
	}

	public void AFMMFPBEBGO()
	{
		ACEEIAIDHLC();
		ILFDGCEAIND();
	}

	private void ALNNIDLFILB()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void CONGFBMFHPH()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void LHAJEFLLLGL()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void BBMCKBJNMJA()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].FLPAOOGDPCA();
			}
			AFMMFPBEBGO();
		}
	}

	public void CallBack()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].DestroyButtons();
			}
			CreateButtons();
		}
	}

	public void OLDKBAOMCLN()
	{
		IKOJNDGFKGM();
		ILFDGCEAIND();
	}

	public void FLPAOOGDPCA()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		ABIMNKKBBKF.Clear();
	}

	private void FEHCNJLLJMP()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void FCCLBLACJFK()
	{
		MAPMOEGANFP();
		KPKDKDIKNNK();
	}

	private void CEDFFAOOPOG()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void MAPMOEGANFP()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1448f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.DJLKKODJHNP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void JFILJNLFDJL()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void LFAFJKJAEEL()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void KPIKCFHDMAF()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].DLPKOGJDOHA();
			}
			HHAPCIEKHKG();
		}
	}

	public void EIANKICJDII()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].DJLKKODJHNP();
		}
		ABIMNKKBBKF.Clear();
	}

	private void LCGPNMMCKOI()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1269f;
		for (int i = 1; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.AILAMHCFDOB();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void DLPKOGJDOHA()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	public void EKGBNNNCEFO()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	private void Start()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void DJLJHEBJHJI()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 143f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.OHDOCLGPIOE(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.BAGJNDODMCP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void CADCBLBPNGD()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].ODJBGKGFCOE();
		}
		ABIMNKKBBKF.Clear();
	}

	public void OHOLFBIPHGE()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EKGBNNNCEFO();
			}
			CreateButtons();
		}
	}

	public void LNIGBLDBOIB()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].IMEENMOOCGA();
			}
			KAMOLLFOLHI();
		}
	}

	private void EJKGAAIOAPA()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1219f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.BIIIKDKNLHH();
			component.LMHFGDCFHOD();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void DKGBFNCOAEO()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void IHFOFPNHHHH()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void DHJPJIKAAIN()
	{
		EJDMILHICDI();
		NKOHAIMNONI();
	}

	private void JAAGGBOMLBE()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 116f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.BIIIKDKNLHH();
			component.LMHFGDCFHOD();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void BJKMBOFPNLD()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].LMHFGDCFHOD();
		}
		ABIMNKKBBKF.Clear();
	}

	public void NPNIEHJLJJH()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].AJPBFHAIDGJ();
			}
			PPBMBCKCJLH();
		}
	}

	private void PJKAKJJALNA()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void OMFPLLOBOMA()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1226f;
		for (int i = 0; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.BBINADBINLO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.BAGJNDODMCP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void BLBLIBINLEJ()
	{
		LHPJKIOJIOD();
		LJAJGEDIJKC();
	}

	public void FGLCDLJEPHF()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].OELGHOFHAGM();
			}
			KAMOLLFOLHI();
		}
	}

	public void CKIBBEJOPDK()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].JGDJDGDDEBA();
			}
			LPEAGALOLKE();
		}
	}

	public void NBOAJDADMLA()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EAODJGNIKJD();
			}
			DHJPJIKAAIN();
		}
	}

	public void MEJFIPAIHJD()
	{
		PPNFLGFIFAM();
		JOKPKIKDPEJ();
	}

	private void JKFDDNMPOJH()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void CGDMLHLJIDK()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void JGDJDGDDEBA()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	private void CJMNMCEPAAI()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1894f;
		for (int i = 1; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void ANMCBHIIKKH()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EIANKICJDII();
			}
			FCCLBLACJFK();
		}
	}

	private void IBLMFILAIIJ()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void EHDNOMNPMJI()
	{
		ACEEIAIDHLC();
		IHFOFPNHHHH();
	}

	private void KCCIJMNMADC()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1418f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.HEGLICFNJCM(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.DMMEHNCIKDG();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void FGIIEGMMKND()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void GLEJGFLCLPJ()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void EAODJGNIKJD()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		ABIMNKKBBKF.Clear();
	}

	private void JDJBHBAOIOF()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 3f;
		for (int i = 1; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.BBINADBINLO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.BIIIKDKNLHH();
			component.DMMEHNCIKDG();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void FKHBLFKDFPB()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	public void IMEENMOOCGA()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		ABIMNKKBBKF.Clear();
	}

	public void NECPFJELGCK()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].PCGIJPAKBAE();
			}
			MEJFIPAIHJD();
		}
	}

	public void FJKAIDCJJFF()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].NECLICEIOKN();
			}
			AFMMFPBEBGO();
		}
	}

	private void LHPJKIOJIOD()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1611f;
		for (int i = 1; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.PKICDNINIGD();
			component.OpenCloseObjectAnimation();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void KFDPIFBEMNC()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].BJKMBOFPNLD();
			}
			MEJFIPAIHJD();
		}
	}

	private void ILFDGCEAIND()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void HIAILIFCMKK()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1123f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.PGOIEGKLAKO(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.AILAMHCFDOB();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void FLINHIJFCBP()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].NECLICEIOKN();
			}
			POBMDIKPGGF();
		}
	}

	private void NKOHAIMNONI()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void ICEDPAHNPHM()
	{
		EJKGAAIOAPA();
		IHFOFPNHHHH();
	}

	private void BKOBFHGNPME()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void NHGFAFFIACM()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].BAGJNDODMCP();
		}
		ABIMNKKBBKF.Clear();
	}

	public void HHHGINCHPFL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].CHPOBKBGJHJ();
			}
			EENNPPGMDLL();
		}
	}

	public void GILAHDKGGIG()
	{
		BGAMEGDKEJB();
		HFBDGAOLJFB();
	}

	private void AADOOOHJBAJ()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void HPGHMACPOAL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].OOIDPIKMFHJ();
			}
			EENNPPGMDLL();
		}
	}

	private void ICDNPNAHCGA()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 836f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.ABIPHKLOLPK(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.JBEADLHMKMA();
			component.DJLKKODJHNP();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void OCOOBKKNKBF()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void AJPBFHAIDGJ()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].LMHFGDCFHOD();
		}
		ABIMNKKBBKF.Clear();
	}

	public void DestroyButtons()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	private void IMCKJCHKMKB()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void KPKDKDIKNNK()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void CIJGPGLOLLK()
	{
		AFEOEMBNGOL();
		OCOOBKKNKBF();
	}

	public void NEFJICPJFHC()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].DMMEHNCIKDG();
		}
		ABIMNKKBBKF.Clear();
	}

	public void LGEEHOAPJLL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].NEFJICPJFHC();
			}
			FCCLBLACJFK();
		}
	}

	private void JEHCPIHNKFM()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}
}
