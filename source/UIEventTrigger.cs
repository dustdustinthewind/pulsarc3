// UIEventTrigger
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIEventTrigger : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
{
	public UnityEvent onPointerEnter;

	public UnityEvent onPointerExit;

	public UnityEvent onPointerClick;

	public UnityEvent onPointerDown;

	public UnityEvent onPointerUp;

	public UnityEvent onSelect;

	public UnityEvent onDeselect;

	public void LNMLCNDAOPC(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}

	public void OnPointerEnter(PointerEventData GIOOFMGDGNH)
	{
		onPointerEnter.Invoke();
	}

	public void OnSelect(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	private void HLIAEEMGBHN()
	{
	}

	private void ONMGIPAILOH()
	{
	}

	public void FPGBAKDMNFF(PointerEventData GIOOFMGDGNH)
	{
		onPointerClick.Invoke();
	}

	private void FABMDEHEDNO()
	{
	}

	public void MKFGJGKNDIB(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}

	public void MDDELAOIKPD(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	public void OnDeselect(BaseEventData OLIIPKODDIN)
	{
		onDeselect.Invoke();
	}

	private void Update()
	{
	}

	public void BDNEOOBFNBN(PointerEventData GIOOFMGDGNH)
	{
		onPointerEnter.Invoke();
	}

	public void ABKDPJJOEAK(PointerEventData GIOOFMGDGNH)
	{
		onPointerUp.Invoke();
	}

	public void NEJNJNBAKGG(PointerEventData GIOOFMGDGNH)
	{
		onPointerClick.Invoke();
	}

	public void BLMBJDOCJEG(BaseEventData OLIIPKODDIN)
	{
		onDeselect.Invoke();
	}

	public void LFLIIDGPAJC(PointerEventData GIOOFMGDGNH)
	{
		onPointerUp.Invoke();
	}

	public void OnPointerClick(PointerEventData GIOOFMGDGNH)
	{
		onPointerClick.Invoke();
	}

	public void LKEOEKONABE(PointerEventData GIOOFMGDGNH)
	{
		onPointerEnter.Invoke();
	}

	public void OPMBOIOMIMN(PointerEventData GIOOFMGDGNH)
	{
		onPointerExit.Invoke();
	}

	public void KPJKJNIDECJ(PointerEventData GIOOFMGDGNH)
	{
		onPointerEnter.Invoke();
	}

	public void HPEKIOCMHCM(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	public void INKFELLKDFO(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}

	private void BGDPIHMAACO()
	{
	}

	public void OnPointerExit(PointerEventData GIOOFMGDGNH)
	{
		onPointerExit.Invoke();
	}

	public void PIPIDPPIJCF(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}

	private void CCLNNLCOPBL()
	{
	}

	private void Start()
	{
	}

	public void KGFKGMLPFEC(PointerEventData GIOOFMGDGNH)
	{
		onPointerEnter.Invoke();
	}

	public void APIEEAJLPBO(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	private void AGMJDGHLBMN()
	{
	}

	public void OAOMDADPBCL(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	private void NPLCENPNJBM()
	{
	}

	public void LBLPGKPCPAL(BaseEventData GIOOFMGDGNH)
	{
		onSelect.Invoke();
	}

	public void OnPointerDown(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}

	public void FHFNOPDMFEH(PointerEventData GIOOFMGDGNH)
	{
		onPointerClick.Invoke();
	}

	public void OnPointerUp(PointerEventData GIOOFMGDGNH)
	{
		onPointerUp.Invoke();
	}

	public void HDIFNFDNLDE(PointerEventData GIOOFMGDGNH)
	{
		onPointerDown.Invoke();
	}
}
