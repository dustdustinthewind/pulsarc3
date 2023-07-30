// FollowClick
using UnityEngine;

public class FollowClick : MonoBehaviour
{
	public AnimationCurve LeftClick;

	public AnimationCurve RightClick;

	public EasyTween TweenToControl;

	public Transform RootCanvas;

	private void IDIIELPAMCJ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			LAIDIAGPBGO(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			KNJFMLBLOPF(RightClick);
		}
	}

	private void HELCCDAIGNE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 721f);
		if (!TweenToControl.JEEOPHJBDNO())
		{
			TweenToControl.ABIPHKLOLPK(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.BAGJNDODMCP();
	}

	private void LAIDIAGPBGO(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 462f);
		if (!TweenToControl.BBHGMKJBJDD())
		{
			TweenToControl.ABIPHKLOLPK(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.ABIPHKLOLPK(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.LMHFGDCFHOD();
	}

	private void OFPEHPLFBAG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1165f);
		if (!TweenToControl.JEEOPHJBDNO())
		{
			TweenToControl.PGOIEGKLAKO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.HEGLICFNJCM(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DJLKKODJHNP();
	}

	private void IABHEJLDKLG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1811f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.PGOIEGKLAKO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DJLKKODJHNP();
	}

	private void GECFFPHCFHA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1733f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.OHDOCLGPIOE(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.AILAMHCFDOB();
	}

	private void KNJFMLBLOPF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 327f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.HEGLICFNJCM(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.GIAJEMNMCDA();
	}

	private void MAOCOEGAFND()
	{
		if (Input.GetMouseButtonDown(0))
		{
			JNMBPNPNNBN(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			HCJGKNBCINH(RightClick);
		}
	}

	private void BLDPKPHKFHJ(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1353f);
		if (!TweenToControl.BBHGMKJBJDD())
		{
			TweenToControl.OHDOCLGPIOE(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.ODJBGKGFCOE();
	}

	private void HJIKCGAKIBL(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 790f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.BBINADBINLO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.HEGLICFNJCM(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.GIAJEMNMCDA();
	}

	private void HKMGEDGBGKM(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1300f);
		if (!TweenToControl.KMCEIMLEPHI())
		{
			TweenToControl.BBINADBINLO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.BAGJNDODMCP();
	}

	private void FBMDHDBELEK()
	{
		if (Input.GetMouseButtonDown(0))
		{
			BLDPKPHKFHJ(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			CCPCGOGDHIA(RightClick);
		}
	}

	private void NEKCPLGFOFD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			EHANNFEOCKB(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			IKDPMFCJAIK(RightClick);
		}
	}

	private void CFFIBEFJPMC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 219f);
		if (!TweenToControl.KMCEIMLEPHI())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.AILAMHCFDOB();
	}

	private void DDMJPHIKODF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1206f);
		if (!TweenToControl.HEHPNAJNACK())
		{
			TweenToControl.HEGLICFNJCM(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.BAGJNDODMCP();
	}

	private void IKDPMFCJAIK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1738f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.BAGJNDODMCP();
	}

	private void CHBANIHKAFN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1307f);
		if (!TweenToControl.HEHPNAJNACK())
		{
			TweenToControl.HEGLICFNJCM(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DMMEHNCIKDG();
	}

	private void GPFJMKCGHGB()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PLDLEHLKGHG(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			OJAJOKAJDDC(RightClick);
		}
	}

	private void GLPADIGNIJA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 0f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void CHKBAIMCILO(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1964f);
		if (!TweenToControl.KMCEIMLEPHI())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.PGOIEGKLAKO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void PMEHFFIEEKI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1142f);
		if (!TweenToControl.BBHGMKJBJDD())
		{
			TweenToControl.BBINADBINLO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.ODJBGKGFCOE();
	}

	private void CCPCGOGDHIA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1525f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.OHDOCLGPIOE(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.ABIPHKLOLPK(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.GIAJEMNMCDA();
	}

	private void EJFJENFKLND()
	{
		if (Input.GetMouseButtonDown(0))
		{
			CILEALNEGAI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			KJFFGNHEKDA(RightClick);
		}
	}

	private void CILEALNEGAI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 137f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.GIAJEMNMCDA();
	}

	private void KJFFGNHEKDA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1152f);
		if (!TweenToControl.JEEOPHJBDNO())
		{
			TweenToControl.HEGLICFNJCM(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DJLKKODJHNP();
	}

	private void EHANNFEOCKB(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 769f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.ABIPHKLOLPK(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.LMHFGDCFHOD();
	}

	private void HLPMABFDAGL(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1809f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.PGOIEGKLAKO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.PGOIEGKLAKO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.GIAJEMNMCDA();
	}

	private void JPENMJLBKAF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 314f);
		if (!TweenToControl.HEHPNAJNACK())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void OJAJOKAJDDC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1327f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.PGOIEGKLAKO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DMMEHNCIKDG();
	}

	private void HCJGKNBCINH(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1285f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.PGOIEGKLAKO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void DPIPGGDNGHN()
	{
		if (Input.GetMouseButtonDown(0))
		{
			HLPMABFDAGL(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			IABHEJLDKLG(RightClick);
		}
	}

	private void MFMIODIAKNI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ANKECMMLNOP(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			PMEHFFIEEKI(RightClick);
		}
	}

	private void ANKECMMLNOP(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 776f);
		if (!TweenToControl.KMCEIMLEPHI())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DJLKKODJHNP();
	}

	private void ANJNEJPDBMI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1646f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.PGOIEGKLAKO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DMMEHNCIKDG();
	}

	private void PLDLEHLKGHG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 941f);
		if (!TweenToControl.FDPFHFMNBEA())
		{
			TweenToControl.OHDOCLGPIOE(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.OHDOCLGPIOE(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.BAGJNDODMCP();
	}

	private void LPMINJJPDCH()
	{
		if (Input.GetMouseButtonDown(0))
		{
			HKMGEDGBGKM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			KNJFMLBLOPF(RightClick);
		}
	}

	private void JNMBPNPNNBN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 574f);
		if (!TweenToControl.KMCEIMLEPHI())
		{
			TweenToControl.ABIPHKLOLPK(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.HEGLICFNJCM(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void DBCOKDJBCAK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 743f);
		if (!TweenToControl.JEEOPHJBDNO())
		{
			TweenToControl.HEGLICFNJCM(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.HEGLICFNJCM(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DJLKKODJHNP();
	}

	private void OEENOOGEEHD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			EHANNFEOCKB(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			HELCCDAIGNE(RightClick);
		}
	}

	private void INBBPACAPGK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1973f);
		if (!TweenToControl.JEEOPHJBDNO())
		{
			TweenToControl.BBINADBINLO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.ODJBGKGFCOE();
	}

	private void FGPNEPGJOGI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1399f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.BBINADBINLO(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.BBINADBINLO(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.DMMEHNCIKDG();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GLPADIGNIJA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			GLPADIGNIJA(RightClick);
		}
	}

	private void JBNPEHMDCMI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			BLDPKPHKFHJ(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			CILEALNEGAI(RightClick);
		}
	}

	private void LLJLDLLNFBH()
	{
		if (Input.GetMouseButtonDown(1))
		{
			KNJFMLBLOPF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			OFPEHPLFBAG(RightClick);
		}
	}
}
