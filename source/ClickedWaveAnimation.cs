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

	public GameObject AOAAAAIFIHP()
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

	private void ECBILENEOOL()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.GFGDPNACMBG(WaveObject, PoolSize);
	}

	public GameObject ECNLNGCMIDG()
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

	private void FDNONDCGGCG()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.INPIOKFFDND(WaveObject, PoolSize);
	}

	public GameObject MHBKFIMMOJP()
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

	private void LLDHEJIEDHO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = AHLOGMPKGHL();
			if ((bool)gameObject)
			{
				GPIOEIOMOHA(gameObject.transform);
			}
		}
	}

	private void MENMHCBMHJD(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.LIFAHJFIOMO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(676f, 1764f, 1967f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1925f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1748f;
			vector.z = 70f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	private void IKIDIJLIGOH()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = KMMJOPLLPLK();
			if ((bool)gameObject)
			{
				BOJJNHOLFIF(gameObject.transform);
			}
		}
	}

	public GameObject CMFDFPDOCCD()
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

	private void DPIPGGDNGHN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = NJJPKMBOMHJ();
			if ((bool)gameObject)
			{
				EJGENEGGPME(gameObject.transform);
			}
		}
	}

	private void BGFJOEPFOPM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = ILGGAMKKFMK();
			if ((bool)gameObject)
			{
				FLCPKLOHAMB(gameObject.transform);
			}
		}
	}

	private void GPIOEIOMOHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OJLOOIEONGI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1362f, 789f, 1029f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 642f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 937f;
			vector.z = 779f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	public GameObject LIDGJHMNAPK()
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

	private void DEEPMOLMGED()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = MDMAPECMEBL();
			if ((bool)gameObject)
			{
				GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	private void NDMHMHMDHHJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.PHCHNMBHCNC();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1817f, 25f, 224f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 113f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 423f;
			vector.z = 1635f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	private void LIBGAKMKHJJ()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void JAAJECBCCFM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = MIBCACOOKOK();
			if ((bool)gameObject)
			{
				CDIJAMDPAJB(gameObject.transform);
			}
		}
	}

	public GameObject FCJEPGJIPAB()
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

	public GameObject NJJPKMBOMHJ()
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

	private void OBAEDJJDCPN()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = PPIPLPMEFJK();
			if ((bool)gameObject)
			{
				PFOKPJMHNOH(gameObject.transform);
			}
		}
	}

	private void CGDMLHLJIDK()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void EJGENEGGPME(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.HDNMHMBPICA();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(389f, 571f, 920f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1734f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1449f;
			vector.z = 781f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	public GameObject AFGDGMALKDA()
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

	private void JDKHBGDEONK()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.INPIOKFFDND(WaveObject, PoolSize);
	}

	private void DBLILJGKGHJ()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.IKGMFIAMHNL(WaveObject, PoolSize);
	}

	private void ICILLMAKLMI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.GFGDPNACMBG(WaveObject, PoolSize);
	}

	private void FCNBDNMMAML(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.PODGFKFAFBN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1622f, 1058f, 1684f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 813f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 37f;
			vector.z = 458f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
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

	private void JONGNKNLLND()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.EPINJLOBFJD(WaveObject, PoolSize);
	}

	private void OEENOOGEEHD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = AJBBGJBDGIN();
			if ((bool)gameObject)
			{
				CEODKENENEC(gameObject.transform);
			}
		}
	}

	public GameObject AHLOGMPKGHL()
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

	private void EPJJDKJEDMM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = PFFGHBKALAD();
			if ((bool)gameObject)
			{
				DHCDCDAILLM(gameObject.transform);
			}
		}
	}

	public GameObject EHABLMNLLBD()
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

	private void AEOLJEIDMDB()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.NJAEONDJHCD(WaveObject, PoolSize);
	}

	private void KLILJHJNICK()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.GFGDPNACMBG(WaveObject, PoolSize);
	}

	private void HPFOFGJPNCI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.DOPLKFDBGAM(WaveObject, PoolSize);
	}

	private void DEDEFDBGOFH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.LIFAHJFIOMO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(330f, 1234f, 3f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1576f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1564f;
			vector.z = 1391f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void NNFMIAFHMJM()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.NJAEONDJHCD(WaveObject, PoolSize);
	}

	private void DNENFLNCIJP()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = AHLOGMPKGHL();
			if ((bool)gameObject)
			{
				BOJJNHOLFIF(gameObject.transform);
			}
		}
	}

	private void NPLCENPNJBM()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.ABBHFBOBILM(WaveObject, PoolSize);
	}

	private void IOFBEKPNMAM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.LPIBIMBHPKB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(920f, 1225f, 784f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1253f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1967f;
			vector.z = 219f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	private void CDIJAMDPAJB(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.HDJPELJGKGO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(813f, 741f, 1512f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 473f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1249f;
			vector.z = 311f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	private void CEODKENENEC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.ODGKJOMBBPJ();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1240f, 209f, 834f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 50f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1419f;
			vector.z = 1557f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	public GameObject AJBBGJBDGIN()
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

	private void HMNLHMLILKD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = HOJGGMNNCDA();
			if ((bool)gameObject)
			{
				JPGCKMEEGCP(gameObject.transform);
			}
		}
	}

	private void PFOKPJMHNOH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KABEIEDMAJK();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1101f, 1323f, 586f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 728f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1930f;
			vector.z = 1945f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	private void LKJMIODJGCM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = MIFCGKMPJIL();
			if ((bool)gameObject)
			{
				FCNBDNMMAML(gameObject.transform);
			}
		}
	}

	private void DKEHGPPOKEA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.IKGMFIAMHNL(WaveObject, PoolSize);
	}

	private void AEMGPJDJGBJ()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void FLCPKLOHAMB(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.MFONOACAODI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1934f, 1228f, 1144f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1690f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 962f;
			vector.z = 1692f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	private void DBBHOGGMMCC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NNMEAEKODCB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1869f, 568f, 1412f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 381f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1567f;
			vector.z = 1122f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	private void IKDNLHLBHID()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OBPKKILBADL(WaveObject, PoolSize);
	}

	private void FIJHDKIPENG()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.JBNMLKGMFFA(WaveObject, PoolSize);
	}

	public GameObject PCAEILIIEAK()
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

	public GameObject EKOHHBHAMND()
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

	private void JBNPEHMDCMI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = ECNLNGCMIDG();
			if ((bool)gameObject)
			{
				JMMABGLJNMF(gameObject.transform);
			}
		}
	}

	private void NFEDLAOPHML()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = LIDGJHMNAPK();
			if ((bool)gameObject)
			{
				OMKBADJMDMJ(gameObject.transform);
			}
		}
	}

	private void KDMANOEMOCA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.AJMEEHEFDLL(WaveObject, PoolSize);
	}

	private void HEEOBEGPJGO(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KABEIEDMAJK();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(834f, 961f, 1041f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 847f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1937f;
			vector.z = 1494f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	private void CNGAJDBOCLJ()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OCIHAKKPJOE(WaveObject, PoolSize);
	}

	public GameObject MIBCACOOKOK()
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

	private void OMKBADJMDMJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KBKMDALIBJC();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(252f, 1736f, 842f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1687f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1291f;
			vector.z = 851f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
	}

	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = PNJMNJPHDAM();
			if ((bool)gameObject)
			{
				HEEOBEGPJGO(gameObject.transform);
			}
		}
	}

	private void GPFJMKCGHGB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = LIDGJHMNAPK();
			if ((bool)gameObject)
			{
				GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	private void JHPOIOELNCG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = KMMJOPLLPLK();
			if ((bool)gameObject)
			{
				DEDEFDBGOFH(gameObject.transform);
			}
		}
	}

	private void JMMABGLJNMF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.JLLHOBJBDNN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(657f, 1372f, 872f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 400f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1097f;
			vector.z = 4f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	private void FLNBKOEMOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OJLOOIEONGI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(271f, 1195f, 1904f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 631f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 110f;
			vector.z = 128f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	public GameObject BMBAHHBCLBE()
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

	private void DAMEGFHBCIO(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NNMEAEKODCB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(470f, 77f, 1333f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1780f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 459f;
			vector.z = 585f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	private void LFAFJKJAEEL()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.EPINJLOBFJD(WaveObject, PoolSize);
	}

	private void OGJJDKENBNC()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.IKGMFIAMHNL(WaveObject, PoolSize);
	}

	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = HGLKKJAIFDL();
			if ((bool)gameObject)
			{
				MPLCLOFBIOD(gameObject.transform);
			}
		}
	}

	private void BBEMGNBAFIN(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.PBCCDPILANO();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1613f, 1768f, 1672f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 943f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 962f;
			vector.z = 1666f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	private void BOJJNHOLFIF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.NNMEAEKODCB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(960f, 287f, 641f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1107f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 921f;
			vector.z = 1874f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void EGEPLFGKGLI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.JBNMLKGMFFA(WaveObject, PoolSize);
	}

	private void KOJKBFDNGDK()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.IKGMFIAMHNL(WaveObject, PoolSize);
	}

	private void JBMBNKOOENB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = LICGBCCDGFP();
			if ((bool)gameObject)
			{
				CEODKENENEC(gameObject.transform);
			}
		}
	}

	public GameObject MDMAPECMEBL()
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

	public GameObject IENDGLFEIHP()
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

	public GameObject HAKDALCNHDN()
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

	private void DOFDGBGEDFI()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OBPKKILBADL(WaveObject, PoolSize);
	}

	private void HDDECCMEJKA()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = ECNLNGCMIDG();
			if ((bool)gameObject)
			{
				EJGENEGGPME(gameObject.transform);
			}
		}
	}

	public GameObject PJHFIEFCHOB()
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

	public GameObject MIFCGKMPJIL()
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

	private void MFMIODIAKNI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = HGLKKJAIFDL();
			if ((bool)gameObject)
			{
				PDGFFPLDPJJ(gameObject.transform);
			}
		}
	}

	private void MPLCLOFBIOD(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.ODGKJOMBBPJ();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(172f, 1033f, 771f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 256f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1893f;
			vector.z = 833f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	private void DHCDCDAILLM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.CKLALLEDMOB();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1693f, 627f, 925f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1224f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1875f;
			vector.z = 722f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
	}

	public GameObject PPIPLPMEFJK()
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

	public GameObject PNJMNJPHDAM()
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

	private void Start()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void PDGFFPLDPJJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.MHCCLBBHNPP();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(716f, 1570f, 910f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 974f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 830f;
			vector.z = 473f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	private void OKLAJINHPAN()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.JBNMLKGMFFA(WaveObject, PoolSize);
	}

	public GameObject CGJLBMLJBLJ()
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

	private void GGFBMANAJJL(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.HDNMHMBPICA();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(656f, 1893f, 761f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 630f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1649f;
			vector.z = 572f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	private void BGDONBMDPGM()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = OJOEOIHAKOC();
			if ((bool)gameObject)
			{
				FCNBDNMMAML(gameObject.transform);
			}
		}
	}

	private void LCJHDLKJEOM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = HGLKKJAIFDL();
			if ((bool)gameObject)
			{
				JPGCKMEEGCP(gameObject.transform);
			}
		}
	}

	private void LCHBFNIPBHB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = EKOHHBHAMND();
			if ((bool)gameObject)
			{
				GGFBMANAJJL(gameObject.transform);
			}
		}
	}

	private void AEEGKLABFLN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = IENDGLFEIHP();
			if ((bool)gameObject)
			{
				FLCPKLOHAMB(gameObject.transform);
			}
		}
	}

	private void JABNHMIHBHC()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.MJKODGBPPJI(WaveObject, PoolSize);
	}

	private void BMNOHLNANIP()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = EKOHHBHAMND();
			if ((bool)gameObject)
			{
				LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	private void MODENHKMKOC()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.LHKJCDGPEKD(WaveObject, PoolSize);
	}

	private void DBEMDAJDDDA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OBPKKILBADL(WaveObject, PoolSize);
	}

	public GameObject OJOEOIHAKOC()
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

	public GameObject HGLKKJAIFDL()
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

	private void IPMGONDHOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OGLLBBOGIIE();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(151f, 1809f, 805f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1118f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1322f;
			vector.z = 582f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().BAGJNDODMCP();
		}
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

	private void MECJHOJPODB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = OJOEOIHAKOC();
			if ((bool)gameObject)
			{
				MENMHCBMHJD(gameObject.transform);
			}
		}
	}

	private void FHGKIOOMMOH()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.CreatePool(WaveObject, PoolSize);
	}

	private void JECMJNFGBGC()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.DOPLKFDBGAM(WaveObject, PoolSize);
	}

	public GameObject KJNENFBPHOB()
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

	public GameObject AAJGEJPGDPI()
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

	public GameObject KMMJOPLLPLK()
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

	private void AEDDNDHCLNN()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.MJKODGBPPJI(WaveObject, PoolSize);
	}

	private void GLEJGFLCLPJ()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OCIHAKKPJOE(WaveObject, PoolSize);
	}

	private void OBMOANGBJOG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.HDNMHMBPICA();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(857f, 750f, 733f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 239f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 701f;
			vector.z = 1729f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DMMEHNCIKDG();
		}
	}

	public GameObject LICGBCCDGFP()
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

	private void HLDFOJMHKNL()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = CMFDFPDOCCD();
			if ((bool)gameObject)
			{
				MENMHCBMHJD(gameObject.transform);
			}
		}
	}

	public GameObject HOJGGMNNCDA()
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

	private void EDDPLJGKLKJ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = KMMJOPLLPLK();
			if ((bool)gameObject)
			{
				FLNBKOEMOIP(gameObject.transform);
			}
		}
	}

	private void ADPLHDFJFID()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.NJAEONDJHCD(WaveObject, PoolSize);
	}

	private void GICHJOJPCOC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.MFONOACAODI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1206f, 824f, 529f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1600f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 447f;
			vector.z = 471f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().LMHFGDCFHOD();
		}
	}

	private void EJFJENFKLND()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = AOAAAAIFIHP();
			if ((bool)gameObject)
			{
				FANJBDGCKNM(gameObject.transform);
			}
		}
	}

	private void JFMIDILENDO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = UiHitted();
			if ((bool)gameObject)
			{
				GICHJOJPCOC(gameObject.transform);
			}
		}
	}

	private void ICFFEEHGAMN(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OJLOOIEONGI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1319f, 841f, 370f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 394f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 957f;
			vector.z = 722f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().DJLKKODJHNP();
		}
	}

	private void OIBMHPIFAKK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = MHBKFIMMOJP();
			if ((bool)gameObject)
			{
				DHCDCDAILLM(gameObject.transform);
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

	private void BIOOPKPNKPM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.OJLOOIEONGI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1016f, 1844f, 1833f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 842f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 1271f;
			vector.z = 1953f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().AILAMHCFDOB();
		}
	}

	private void DKGBFNCOAEO()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.INPIOKFFDND(WaveObject, PoolSize);
	}

	private void BGDPIHMAACO()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.NJAEONDJHCD(WaveObject, PoolSize);
	}

	private void JPGCKMEEGCP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.KBKMDALIBJC();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1280f, 1075f, 275f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 1516f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 928f;
			vector.z = 64f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().GIAJEMNMCDA();
		}
	}

	private void FANJBDGCKNM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.JLLHOBJBDNN();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1916f, 1581f, 1275f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 198f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 447f;
			vector.z = 1221f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().ODJBGKGFCOE();
		}
	}

	private void GNJDKAECPKA()
	{
		MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		MHCIODHIFGG.OBPKKILBADL(WaveObject, PoolSize);
	}

	public GameObject PFFGHBKALAD()
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

	private void EFLDOJLPBHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = MHCIODHIFGG.MFONOACAODI();
		if ((bool)gameObject)
		{
			gameObject.transform.SetParent(CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1614f, 496f, 1732f);
			Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			vector.x = vector.x * (float)Screen.width - (float)Screen.width / 52f;
			vector.y = vector.y * (float)Screen.height - (float)Screen.height / 719f;
			vector.z = 1242f;
			gameObject.GetComponent<RectTransform>().localPosition = vector / CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	private void ODCJJFBJJNF()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = UiHitted();
			if ((bool)gameObject)
			{
				IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	public GameObject GIIOLDPLHBB()
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

	public GameObject JGHJFAJAJON()
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
}
