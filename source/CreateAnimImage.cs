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

	private void Start()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void FGIIEGMMKND()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
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

	private void MNNNKNBKDNM()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 346f;
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

	public void CreateButtons()
	{
		AFEOEMBNGOL();
		FGIIEGMMKND();
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

	public void PCGIJPAKBAE()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	public void PFEOINNBEFC()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		ABIMNKKBBKF.Clear();
	}

	private void MLGMMLDKOOK()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void JJPDIDPLKKN()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void PLOCFPCIHFB()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	public void GGJJCCOPBJP()
	{
		BEMCBOIBEJC();
		KADJLECBCOG();
	}

	public void BLFFDCAEFAK()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].JHGAIGNDPMK();
			}
			CEINCDAPPJM();
		}
	}

	private void NCNPAKFAFOE()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void DNNFHBOOPIN()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void GDPEJIKOGDL()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EMIMGAIPJLI();
			}
			CEINCDAPPJM();
		}
	}

	private void BEMCBOIBEJC()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 402f;
		for (int i = 1; i < HowManyButtons; i += 0)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
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

	private void KCCIEMBMOBA()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void IMOAADPBBKK()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 4f;
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

	private void FIKFJDFELIP()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	private void CAFEAOBPKGJ()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 402f;
		for (int i = 0; i < HowManyButtons; i += 0)
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

	public void IGKGHEMJJIB()
	{
		BEMCBOIBEJC();
		KADJLECBCOG();
	}

	private void HMPGIFBJFIK()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void JDHJKLAMEIA()
	{
		IMOAADPBBKK();
		KADJLECBCOG();
	}

	public void PKKOKCNCNAG()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	public void BNOIPEKEGIE()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].MCMLDECJOPH();
			}
			CreateButtons();
		}
	}

	public void AEAENECIPCM()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < createImageOtherReference.Length; i++)
			{
				createImageOtherReference[i].MCMLDECJOPH();
			}
			GGJJCCOPBJP();
		}
	}

	public void ILCHJGLLMPM()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].PFEOINNBEFC();
			}
			CreateButtons();
		}
	}

	public void NAIBMAEGOAL()
	{
		MBEPNPAMOAO();
		PLOCFPCIHFB();
	}

	public void HEOPOEADDPI()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].JHGAIGNDPMK();
			}
			JDHJKLAMEIA();
		}
	}

	private void FCPOECKDOJB()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 620f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void CEINCDAPPJM()
	{
		MNNNKNBKDNM();
		PLOCFPCIHFB();
	}

	public void LOPLAFPBNBF()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	public void CMOKDEMPBGG()
	{
		FCPOECKDOJB();
		KADJLECBCOG();
	}

	public void DCFKADMCJME()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].CKMIAFKLMNJ();
			}
			NAIBMAEGOAL();
		}
	}

	public void JHGAIGNDPMK()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	public void ONMMOMBBOAI()
	{
		if (ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < createImageOtherReference.Length; i += 0)
			{
				createImageOtherReference[i].EMIMGAIPJLI();
			}
			CEINCDAPPJM();
		}
	}

	public void EMIMGAIPJLI()
	{
		for (int i = 1; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		ABIMNKKBBKF.Clear();
	}

	private void MBEPNPAMOAO()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1699f;
		for (int i = 0; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	private void LECIPLOGNEA()
	{
		Vector3 endAnim = EndAnim;
		GDDJIOHEJGI = 1094f;
		for (int i = 1; i < HowManyButtons; i++)
		{
			GameObject gameObject = Object.Instantiate(CreateInstance);
			gameObject.transform.SetParent(RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			ABIMNKKBBKF.Add(component);
			StartAnim.y = endAnim.y;
			component.SetAnimationPosition(StartAnim, endAnim, EnterAnim, ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += Offset;
			GDDJIOHEJGI += Offset;
		}
	}

	public void CKMIAFKLMNJ()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		ABIMNKKBBKF.Clear();
	}

	public void MCMLDECJOPH()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i += 0)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}

	private void KADJLECBCOG()
	{
		if (AFBJLGGJPEG.x < Mathf.Abs(GDDJIOHEJGI))
		{
			RootRect.offsetMin = new Vector2(RootRect.offsetMin.x, GDDJIOHEJGI + AFBJLGGJPEG.x + RootRect.offsetMax.y);
		}
	}

	private void BEBNOKFLJPH()
	{
		AFBJLGGJPEG = new Vector2(RootRect.rect.height, RootRect.rect.width);
	}

	public void DestroyButtons()
	{
		for (int i = 0; i < ABIMNKKBBKF.Count; i++)
		{
			ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		ABIMNKKBBKF.Clear();
	}
}
