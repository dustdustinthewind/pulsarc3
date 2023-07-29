// DragController
using UnityEngine;

public class DragController : MonoBehaviour
{
	private Vector3 KAOOCILPJCN;

	private Vector3 INLGAOLENMD;

	private bool ODOEHCEMDKB;

	public void AIMAEDIEEGI(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public void CCPFGCKHHCN(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public EditorEvent FIEKNFJBJKP()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent GetEditorEvent()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public void OnDragEnd()
	{
		ODOEHCEMDKB = false;
		GetEditorEvent().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		GetEditorEvent().UpdateEvent();
	}

	public void AIOJCNCPCEG(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public void ADPFOONOBBA(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	private void GHILDCBCDJI()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 1055f);
		}
	}

	public void NCJNAIBOBJF()
	{
		ODOEHCEMDKB = false;
		EFKICKGLPAA().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		FIEKNFJBJKP().UpdateEvent();
	}

	public EditorEvent HCBHBLNKMGD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent LDGJPECJDKD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void MFMIODIAKNI()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 984f);
		}
	}

	private void NKLIHNJCHOG()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 686f);
		}
	}

	public void HDBMLLJFIAJ()
	{
		ODOEHCEMDKB = false;
		FIEKNFJBJKP().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		GetEditorEvent().NCMDCMHLIKD();
	}

	public EditorEvent EKLLANBFINH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public void OnDragStart(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public void OFLMBGFOMIL(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	private void Update()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 0f);
		}
	}

	public EditorEvent HMCKEOGAHJM()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public void CLCAABBGECG(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public EditorEvent JPCLJPBKBCD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public void GDPOALKKBHE()
	{
		ODOEHCEMDKB = true;
		FIEKNFJBJKP().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		HCBHBLNKMGD().FMGBIHDGKBI();
	}

	private void ONMGIPAILOH()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 1317f);
		}
	}

	public EditorEvent EFKICKGLPAA()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void AAPKBNDHBLI()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 156f);
		}
	}

	public void MGAJMKHJCOJ()
	{
		ODOEHCEMDKB = false;
		HMCKEOGAHJM().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		GetEditorEvent().NJDJHMPAIFE();
	}
}
