// ClickedWaveAnimation
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickedWaveAnimation : MonoBehaviour
{
	public GameObject WaveObject;

	public GameObject CanvasMain;

	public int PoolSize;

	private Pool MHCIODHIFGG;

	private void DBEMDAJDDDA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.IECHADGJJBN(WaveObject, PoolSize);
	}

	public GameObject LLPBMMMJKMN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = UiHitted();
			if ((bool)gameObject)
			{
				LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	private void EGEPLFGKGLI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void FJKCOMIKDAG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OJLOOIEONGI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(359f, 128f, 854f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1196f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 28f;
			vector.z = 1369f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	private void GINIGCEOCMH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.JLLHOBJBDNN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(582f, 1714f, 1605f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 535f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1563f;
			vector.z = 1379f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void KMCPMOGKDEH()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.ABBHFBOBILM(WaveObject, PoolSize);
	}

	private void GHILDCBCDJI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = UiHitted();
			if ((bool)gameObject)
			{
				PPGAIGGNAFH(gameObject.transform);
			}
		}
	}

	public GameObject DMGFNONDPGB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject MKCFBEHEFJP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void ANCKKLFPGDI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.LONKKOFBDDN(WaveObject, PoolSize);
	}

	private void GELKNIJFHBJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.PBCCDPILANO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(43f, 1644f, 341f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1618f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1587f;
			vector.z = 235f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = JGHJFAJAJON();
			if ((bool)gameObject)
			{
				MLPCEOOGPEI(gameObject.transform);
			}
		}
	}

	public GameObject CJHDCLBOLED()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void FANADGBGCPI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.KJFGJDHMLHJ(WaveObject, PoolSize);
	}

	private void JOACBIEHHCE()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = LPFLGOBJDFI();
			if ((bool)gameObject)
			{
				FLNBKOEMOIP(gameObject.transform);
			}
		}
	}

	private void IPMGONDHOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.DACIIEBNKBN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1678f, 1419f, 1849f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1843f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 969f;
			vector.z = 187f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void Start()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void IOFBEKPNMAM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.IAOPMEFNKKB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1073f, 553f, 164f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 595f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1788f;
			vector.z = 756f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	public GameObject CNEMDIBCCEK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void GANGJOMAAIL(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KABEIEDMAJK();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1966f, 678f, 1788f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 805f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1165f;
			vector.z = 373f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	public GameObject JGHJFAJAJON()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void LEAHIBJDMBI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = DMGFNONDPGB();
			if ((bool)gameObject)
			{
				IOFBEKPNMAM(gameObject.transform);
			}
		}
	}

	private void EFLDOJLPBHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.GCKMCKGHKJB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(998f, 1549f, 1066f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1519f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1735f;
			vector.z = 1498f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	private void NEKCPLGFOFD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = FCJEPGJIPAB();
			if ((bool)gameObject)
			{
				IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	public GameObject DALHGPAIBAE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void PMPKMGKAAJH()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.FAMGGJOHJFK(WaveObject, PoolSize);
	}

	public GameObject NGBLCKIIOEE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject PPFGNIFIAGO()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void GPNAOAKCMHC()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.KJFGJDHMLHJ(WaveObject, PoolSize);
	}

	public GameObject NJJPKMBOMHJ()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject LFJBAIEJAIN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void DIPDEHOOBPG()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.FAMGGJOHJFK(WaveObject, PoolSize);
	}

	private void LNBJBGFCBLC(Transform KFHEOLKCAJK)
	{
		GameObject @object = MHCIODHIFGG.GetObject();
		if ((bool)@object)
		{
			@object.transform.SetParent(CanvasMain.transform);
			@object.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(0.1f, 0.1f, 0.1f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 2f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 2f;
			vector.z = 0f;
			@object.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			@object.transform.SetParent(KFHEOLKCAJK);
			@object.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void PDGFFPLDPJJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.DACIIEBNKBN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(59f, 1808f, 845f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 897f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 49f;
			vector.z = 1855f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	public GameObject CLNBFFNIDFG()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject BMBAHHBCLBE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject OBFAGLBLMKH()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject FCJEPGJIPAB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject EKOHHBHAMND()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void MAOCOEGAFND()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = MKCFBEHEFJP();
			if ((bool)gameObject)
			{
				LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	private void ICPNIMIFGHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.FIFJDDBGONJ();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1733f, 346f, 1295f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1542f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 135f;
			vector.z = 846f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void JNBPKNNBMDI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = JGHJFAJAJON();
			if ((bool)gameObject)
			{
				IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	public GameObject ILGGAMKKFMK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void MLPCEOOGPEI(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.AFCDLOLBNNM();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1384f, 495f, 617f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 265f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 159f;
			vector.z = 1725f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void FCNBDNMMAML(Transform KFHEOLKCAJK)
	{
		GameObject @object = MHCIODHIFGG.GetObject();
		if ((bool)@object)
		{
			@object.transform.SetParent(CanvasMain.transform);
			@object.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(505f, 585f, 485f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 160f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1276f;
			vector.z = 1485f;
			@object.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			@object.transform.SetParent(KFHEOLKCAJK);
			@object.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void GICHJOJPCOC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KFJOEEDEODL();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(242f, 77f, 46f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 783f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1668f;
			vector.z = 1328f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = GCNOKDFCDPL();
			if ((bool)gameObject)
			{
				LOLIELBLLBJ(gameObject.transform);
			}
		}
	}

	private void KDMKDEKCELE()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.HDPNDDHNFOJ(WaveObject, PoolSize);
	}

	private void BMODOIJGIOO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = MKCFBEHEFJP();
			if ((bool)gameObject)
			{
				GINIGCEOCMH(gameObject.transform);
			}
		}
	}

	private void PPGAIGGNAFH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NBIKOBBNFGM();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(894f, 756f, 78f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 636f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1449f;
			vector.z = 716f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void JMMABGLJNMF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.FGCEDMAPAGA();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(198f, 1916f, 0f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1951f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1548f;
			vector.z = 1385f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void EGEGNHLODAA()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = PFGAFEPCIMH();
			if ((bool)gameObject)
			{
				EFLDOJLPBHA(gameObject.transform);
			}
		}
	}

	private void JONCLDHGLCA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NNMEAEKODCB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1456f, 637f, 531f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1667f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1281f;
			vector.z = 790f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	private void LOLIELBLLBJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NNMEAEKODCB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1400f, 747f, 805f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1092f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1415f;
			vector.z = 248f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	public GameObject UiHitted()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void KLILJHJNICK()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.NPGADDCHIEF(WaveObject, PoolSize);
	}

	private void EPEGAEGDJAM()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.DOPLKFDBGAM(WaveObject, PoolSize);
	}

	private void DKOPKPBLDHH()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.MJKODGBPPJI(WaveObject, PoolSize);
	}

	public GameObject PFGAFEPCIMH()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject DDHCBHGALBN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void FLNBKOEMOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.DPHGKHICPLP();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(104f, 384f, 1117f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1472f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1455f;
			vector.z = 1766f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void DPIPGGDNGHN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = LGKFHICIJFG();
			if ((bool)gameObject)
			{
				JMMABGLJNMF(gameObject.transform);
			}
		}
	}

	private void LGDDAJEAMOG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.PBCCDPILANO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1949f, 1951f, 420f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1890f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 371f;
			vector.z = 519f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void LCJHDLKJEOM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = CJHDCLBOLED();
			if ((bool)gameObject)
			{
				PDGFFPLDPJJ(gameObject.transform);
			}
		}
	}

	private void KIEJKBNBHMD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = LKENFFLHPFN();
			if ((bool)gameObject)
			{
				GANGJOMAAIL(gameObject.transform);
			}
		}
	}

	private void JILOMOBDPIA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.HDPNDDHNFOJ(WaveObject, PoolSize);
	}

	private void CGBHOELMAOC()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = JGHJFAJAJON();
			if ((bool)gameObject)
			{
				PPGAIGGNAFH(gameObject.transform);
			}
		}
	}

	public GameObject LKENFFLHPFN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject LGKFHICIJFG()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject GCNOKDFCDPL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	private void JKBMKPDGCHG()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.EAANLGHMLDE(WaveObject, PoolSize);
	}

	public GameObject LPFLGOBJDFI()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	public GameObject PJHFIEFCHOB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if ((bool)list[i].gameObject.GetComponent<Button>() && (bool)list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}
}
