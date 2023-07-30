// DragController
using UnityEngine;

public class DragController : MonoBehaviour
{
	private Vector3 KAOOCILPJCN;

	private Vector3 INLGAOLENMD;

	private bool ODOEHCEMDKB;

	public void LDGALMPOFJM()
	{
		ODOEHCEMDKB = true;
		OEHKJJODCIO().mapEvent.time = Singleton<MapEditor>.Instance.JCNHFKOAHHH(base.transform.localPosition.x);
		GBANAAEJEGI().UpdateEvent();
	}

	public void OFLMBGFOMIL(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public EditorEvent AIDCBDGMNFB()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent GOHGLJEOFCH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent PFMLOAKGAOB()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent GBANAAEJEGI()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent KFNBAKNJDKE()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
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

	public void IOMLIBBMGPJ(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public void AMHPLPIBMGA(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public void OnDragEnd()
	{
		ODOEHCEMDKB = false;
		GetEditorEvent().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		GetEditorEvent().UpdateEvent();
	}

	public void ADKAMCJKCHL(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public void CMCBIEGNLHC(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = false;
	}

	public void BBEFGGMIGML()
	{
		ODOEHCEMDKB = true;
		KFNBAKNJDKE().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		PFMLOAKGAOB().UpdateEvent();
	}

	private void JAAJECBCCFM()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 154f);
		}
	}

	public void NJFAOGAFJDM(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	private void AEIJFLJEABG()
	{
		if (ODOEHCEMDKB)
		{
			Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector2 = vector + INLGAOLENMD;
			vector2.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector2.x), vector2.y, 817f);
		}
	}

	public EditorEvent OEHKJJODCIO()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public void KBPKJADKLCM(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public void GDPOALKKBHE()
	{
		ODOEHCEMDKB = false;
		GFONGNJJMEH().mapEvent.time = Singleton<MapEditor>.Instance.JCNHFKOAHHH(base.transform.localPosition.x);
		GFONGNJJMEH().CMNPEMEIJEJ();
	}

	public void OnDragStart(Vector3 KMDIKEAGGHB)
	{
		INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		ODOEHCEMDKB = true;
	}

	public EditorEvent GetEditorEvent()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent GFONGNJJMEH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}
}
