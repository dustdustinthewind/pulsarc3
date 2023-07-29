// FollowClick
using UnityEngine;

public class FollowClick : MonoBehaviour
{
	public AnimationCurve LeftClick;

	public AnimationCurve RightClick;

	public EasyTween TweenToControl;

	public Transform RootCanvas;

	private void LCHBFNIPBHB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			CILEALNEGAI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			NKJOOIFGNEF(RightClick);
		}
	}

	private void CHBANIHKAFN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 754f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void GFEKPHFDENH(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1533f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void KJFFGNHEKDA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 813f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void AEEGKLABFLN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			FGPNEPGJOGI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			JPENMJLBKAF(RightClick);
		}
	}

	private void EHANNFEOCKB(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 854f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void GCPNPMELIGP(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 887f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void MMBPLGGLPDB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			HKMGEDGBGKM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			BHNFCLDFEFD(RightClick);
		}
	}

	private void OEENOOGEEHD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PHPCFLJLDCE(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			CILEALNEGAI(RightClick);
		}
	}

	private void JBNPEHMDCMI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GHMCFOOAFHF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			EHANNFEOCKB(RightClick);
		}
	}

	private void NCPAFCKGJEA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			HKMGEDGBGKM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			HELCCDAIGNE(RightClick);
		}
	}

	private void IKIDIJLIGOH()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GHMCFOOAFHF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FGPNEPGJOGI(RightClick);
		}
	}

	private void KNJFMLBLOPF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 231f);
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

	private void JPENMJLBKAF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1461f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void HKMGEDGBGKM(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1800f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void GHMCFOOAFHF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 248f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void ILKFPGNBHJC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1306f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void MECJHOJPODB()
	{
		if (Input.GetMouseButtonDown(0))
		{
			KJFFGNHEKDA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			KJFFGNHEKDA(RightClick);
		}
	}

	private void NOMCCMELEDE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 291f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void DNENFLNCIJP()
	{
		if (Input.GetMouseButtonDown(1))
		{
			NKJOOIFGNEF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FFEHADCOLPF(RightClick);
		}
	}

	private void LEAHIBJDMBI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			KJFFGNHEKDA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			GCPNPMELIGP(RightClick);
		}
	}

	private void IABHEJLDKLG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 762f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void PBEPCAPAKLG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			KNJFMLBLOPF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			PMEHFFIEEKI(RightClick);
		}
	}

	private void OFPEHPLFBAG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1913f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void JNMBPNPNNBN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 699f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void MFMIODIAKNI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GLPADIGNIJA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			PMEHFFIEEKI(RightClick);
		}
	}

	private void FHDOICBNMNC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 83f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void FFEHADCOLPF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 757f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void INBBPACAPGK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 205f);
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

	private void EHCGBJDFMHG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			CILEALNEGAI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FHDOICBNMNC(RightClick);
		}
	}

	private void DGCGGKMNPLD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FGPNEPGJOGI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			ILKFPGNBHJC(RightClick);
		}
	}

	private void JOACBIEHHCE()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GHMCFOOAFHF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			FHDOICBNMNC(RightClick);
		}
	}

	private void IDIIELPAMCJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			DDMJPHIKODF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			GHMCFOOAFHF(RightClick);
		}
	}

	private void ANKECMMLNOP(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1724f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void LPMINJJPDCH()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GCPNPMELIGP(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			CHBANIHKAFN(RightClick);
		}
	}

	private void MJNPIDGNJMK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			NKJOOIFGNEF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			OFPEHPLFBAG(RightClick);
		}
	}

	private void GPFJMKCGHGB()
	{
		if (Input.GetMouseButtonDown(0))
		{
			HKMGEDGBGKM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			JFKEIMGOJOM(RightClick);
		}
	}

	private void LMBDNPLDGIJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			KJFFGNHEKDA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			BHNFCLDFEFD(RightClick);
		}
	}

	private void FABMDEHEDNO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FGPNEPGJOGI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			IKDPMFCJAIK(RightClick);
		}
	}

	private void HDDECCMEJKA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FHDOICBNMNC(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			GFEKPHFDENH(RightClick);
		}
	}

	private void EGEGNHLODAA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			IKDPMFCJAIK(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			KJFFGNHEKDA(RightClick);
		}
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

	private void FBMDHDBELEK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			NKJOOIFGNEF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			FFEHADCOLPF(RightClick);
		}
	}

	private void LJIHHJOAJCN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			CILEALNEGAI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FGPNEPGJOGI(RightClick);
		}
	}

	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			PHPCFLJLDCE(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			CHBANIHKAFN(RightClick);
		}
	}

	private void NEKCPLGFOFD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			NOMCCMELEDE(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			INBBPACAPGK(RightClick);
		}
	}

	private void KIEJKBNBHMD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GHMCFOOAFHF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			EHANNFEOCKB(RightClick);
		}
	}

	private void BMODOIJGIOO()
	{
		if (Input.GetMouseButtonDown(1))
		{
			OFPEHPLFBAG(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			KJFFGNHEKDA(RightClick);
		}
	}

	private void NKJOOIFGNEF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1867f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void OCMKCBBCEFG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			JFKEIMGOJOM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			PLDLEHLKGHG(RightClick);
		}
	}

	private void FGPNEPGJOGI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1465f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void DDMJPHIKODF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1974f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void CILEALNEGAI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 632f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void AGMJDGHLBMN()
	{
		if (Input.GetMouseButtonDown(0))
		{
			NOMCCMELEDE(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FGPNEPGJOGI(RightClick);
		}
	}

	private void AAPKBNDHBLI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			NOMCCMELEDE(LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			OFPEHPLFBAG(RightClick);
		}
	}

	private void PLDLEHLKGHG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1552f);
		if (!TweenToControl.IsObjectOpened())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void HELCCDAIGNE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 348f);
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

	private void MAOCOEGAFND()
	{
		if (Input.GetMouseButtonDown(1))
		{
			KNJFMLBLOPF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			FGPNEPGJOGI(RightClick);
		}
	}

	private void BHNFCLDFEFD(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 718f);
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

	private void PMEHFFIEEKI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1382f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.OpenCloseObjectAnimation();
	}

	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			KJFFGNHEKDA(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			NOMCCMELEDE(RightClick);
		}
	}

	private void IKDPMFCJAIK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 118f);
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

	private void PHPCFLJLDCE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 331f);
		if (!TweenToControl.FJFANHLGGHL())
		{
			TweenToControl.SetAnimationPosition(TweenToControl.rectTransform.anchoredPosition, vector, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			TweenToControl.SetAnimationPosition(vector, TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		TweenToControl.NIOMFNEEMDF();
	}

	private void ONMGIPAILOH()
	{
		if (Input.GetMouseButtonDown(1))
		{
			HKMGEDGBGKM(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			IKDPMFCJAIK(RightClick);
		}
	}

	private void HPNNCNNFMGK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GHMCFOOAFHF(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			PHPCFLJLDCE(RightClick);
		}
	}

	private void JDGFCEPDKAJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FGPNEPGJOGI(LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			BHNFCLDFEFD(RightClick);
		}
	}

	private void JFKEIMGOJOM(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		vector = new Vector3(vector.x * (float)Screen.width / RootCanvas.localScale.x, vector.y * (float)Screen.height / RootCanvas.localScale.y, 1582f);
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
}
