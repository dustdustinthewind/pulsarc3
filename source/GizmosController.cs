// GizmosController
using UnityEngine;

public class GizmosController : MonoBehaviour
{
	public GameObject dragObj;

	public bool dragEnabled = true;

	private Vector3 KAOOCILPJCN;

	private Vector3 INLGAOLENMD;

	private void FGNFILLNPJK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(PHFOIIGIBFN());
		}
	}

	private void MMOMODMCGAG()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 588f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1199f)
			{
				vector2.x = 1662f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 429f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void JIENIAGLCJO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1145f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void BLEMAGIAGJA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1665f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void PLBADDFPCPO()
	{
		PHFOIIGIBFN().EOEDBFHBPEI();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("{0,-18} {1,18}", true);
	}

	private void DNENFLNCIJP()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NMLINPHFOJJ());
		}
	}

	private void GCHBGCGBMCK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(DAJEEPICDLD());
		}
	}

	private void OnMouseUp()
	{
		GetEditorEvent().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Moved event");
	}

	private void BCFMIBKENIH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 587f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1470f)
			{
				vector2.x = 1738f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 464f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	private void FDBPLMOCJFH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 386f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void HBKFNDMDLBP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1475f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void GPFJMKCGHGB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(NMLINPHFOJJ());
		}
	}

	private void PGHOOCPIEAJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1791f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void JHPOIOELNCG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NMEPOAEPNFM());
		}
	}

	public EditorEvent BDAFJCNJNMC()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void LLJLDLLNFBH()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NGJPHBAPIKJ());
		}
	}

	private void KKLMPKLKAEM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(LJABCHJFAAA());
		}
	}

	private void BMOPLCBCIOM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 818f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1050f)
			{
				vector2.x = 179f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1176f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void NNOEAHIHOFC()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1100f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void NCPAFCKGJEA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(FMHIJJNLJIE());
		}
	}

	public EditorEvent GKEAKHFGHHH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void FJGPHHNCFBM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 226f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 513f)
			{
				vector2.x = 1681f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1623f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	private void GHEFAJABADL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1897f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 704f)
			{
				vector2.x = 540f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 81f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA();
		}
	}

	public EditorEvent NMLINPHFOJJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void EPJJDKJEDMM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(PIANIMBGNEG());
		}
	}

	public EditorEvent BPMBNNJMINL()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent EFJFMOANNMJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent DAJEEPICDLD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void MANDOGNJJBD()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(LJABCHJFAAA());
		}
	}

	private void IBGONHDCDIH()
	{
		HBNKOCHGKBI().NCMDCMHLIKD();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("_SSAO", true);
	}

	private void HOFEFJDDKDJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1304f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 422f)
			{
				vector2.x = 659f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 971f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void POJFHDFJOPE()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(GetEditorEvent());
		}
	}

	private void FABMDEHEDNO()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(HFAMJIHOJCH());
		}
	}

	private void CGBHOELMAOC()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(LJABCHJFAAA());
		}
	}

	private void PIFLFGFMIID()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 354f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1419f)
			{
				vector2.x = 1967f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1392f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent POPOCHKFGIM()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void KNKCANBEHMH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1877f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent NHGKAAPBNAO()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void AHKMGGICKOH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1546f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1719f)
			{
				vector2.x = 482f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1801f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	public EditorEvent MLALBGFHDCB()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void INLDEHPAMJC()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PHFOIIGIBFN());
		}
	}

	public EditorEvent HIGBPDDOABN()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void ELMKPIHFNEB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 435f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1316f)
			{
				vector2.x = 1484f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1697f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	private void ECCNFNBOOEJ()
	{
		NGJPHBAPIKJ().EOEDBFHBPEI();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Show Image", true);
	}

	private void HPNNCNNFMGK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NMLINPHFOJJ());
		}
	}

	private void NIEGGPFAFJF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1355f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1278f)
			{
				vector2.x = 1850f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1120f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD();
		}
	}

	private void PACCEJJBCFH()
	{
		HFAMJIHOJCH().FMGBIHDGKBI();
		Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA();
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_TimeX");
	}

	public EditorEvent PIANIMBGNEG()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void LOJFCLFDCED()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 725f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void FBCHBMPPEKA()
	{
		BPMBNNJMINL().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Value3", true);
	}

	public EditorEvent ECGGFGJJOEL()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void PBKHGNKHICG()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 141f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void GCBPIGJDIIC()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 271f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void NDAJBJFJGCF()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(DAJEEPICDLD());
		}
	}

	private void BOAIEKJJDOK()
	{
		HIGBPDDOABN().FMGBIHDGKBI();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK(" not exist", true);
	}

	private void BGDONBMDPGM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(JCKAGIDMKFN());
		}
	}

	private void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(GetEditorEvent());
		}
	}

	private void KCDBBPKIFNJ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PHFOIIGIBFN());
		}
	}

	private void JLPHDJKLDDJ()
	{
		JCKAGIDMKFN().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD();
		Singleton<EditorHistoryHandler>.Instance.SaveState("[NetworkManager] roomInfo.name: ", true);
	}

	public EditorEvent HMCKEOGAHJM()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void ALDINMIABAM()
	{
		JJPCJPPPOLF().KJJODHJJEOH();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("(scene)");
	}

	private void NDCCJONMODD()
	{
		FMHIJJNLJIE().NJDJHMPAIFE();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("z");
	}

	public EditorEvent NGJPHBAPIKJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void NLFMHCLMACL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1068f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent HBNKOCHGKBI()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void OnMouseDown()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void EHCGBJDFMHG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(BDAFJCNJNMC());
		}
	}

	private void GLGLAIFGACN()
	{
		JCKAGIDMKFN().FMGBIHDGKBI();
		Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB(".sawoutdatedmessage", true);
	}

	private void LDNHGEEIOPA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 671f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 199f)
			{
				vector2.x = 649f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1275f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	private void OBDEJFCNOBF()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(DBJLJKDGOOF());
		}
	}

	private void FEJJKFDDBOM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 143f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 353f)
			{
				vector2.x = 830f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 591f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	private void AGMJDGHLBMN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(PHFOIIGIBFN());
		}
	}

	private void JLNDHGEEKON()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 150f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void HAOOJEDEHAL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 299f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1148f)
			{
				vector2.x = 14f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 528f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent GetEditorEvent()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent IJIJEKKMFEO()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent ECAMHMKKJPF()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void KJMIFKCFBDO()
	{
		BPMBNNJMINL().EOEDBFHBPEI();
		Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("id");
	}

	public EditorEvent GJKNIBHFAMK()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void MOMICHIKBAL()
	{
		PCCANFLFPJD().NCMDCMHLIKD();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD();
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_ForceYSwap", true);
	}

	private void ABLAIDHNFFP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1463f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1688f)
			{
				vector2.x = 211f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1519f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void ENDIOFDAKGM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1441f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void LNNCJBHJPPI()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 320f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent FMHIJJNLJIE()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void ABFNJCEBIKA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(GJKNIBHFAMK());
		}
	}

	private void DHDAMOMCAMK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1007f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1885f)
			{
				vector2.x = 245f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 414f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD();
		}
	}

	private void PNEMHGPAMDP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1600f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void MHEEHIHPHNH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1727f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void MOACKDCEJBC()
	{
		PCCANFLFPJD().NCMDCMHLIKD();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("SelectorMapsCountSlider");
	}

	public EditorEvent NMEPOAEPNFM()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent LJABCHJFAAA()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void AMEJDNKEBJN()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1598f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void BPOMMPCBFMG()
	{
		DBJLJKDGOOF().EOEDBFHBPEI();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Bad modpack name: {0}", true);
	}

	private void IGDLDJHJJHM()
	{
		HMCKEOGAHJM().NJDJHMPAIFE();
		Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA();
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_ColorKey");
	}

	private void HCIPECAOGIA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NGJPHBAPIKJ());
		}
	}

	private void JAAJECBCCFM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(GJKNIBHFAMK());
		}
	}

	private void FFIBICKCENJ()
	{
		BPMBNNJMINL().FMGBIHDGKBI();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD();
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("SaveButton", true);
	}

	private void PAHNLCPOGCH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1234f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1018f)
			{
				vector2.x = 1347f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1223f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA();
		}
	}

	private void JBCNIPJDPJB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(PIANIMBGNEG());
		}
	}

	private void KGPJACPLNEK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1292f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent PCCANFLFPJD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void LEAHIBJDMBI()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(POPOCHKFGIM());
		}
	}

	private void CPDIDLOJGIN()
	{
		GKEAKHFGHHH().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Tab2Content", true);
	}

	private void BMNOHLNANIP()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(ECGGFGJJOEL());
		}
	}

	private void OnMouseDrag()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 0.01f)
			{
				vector2.x = 0.01f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 0f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent JJPCJPPPOLF()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void BGFJOEPFOPM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(LJABCHJFAAA());
		}
	}

	public EditorEvent JCKAGIDMKFN()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void BFGIMALGMAJ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(HBNKOCHGKBI());
		}
	}

	private void PCHCOGMLIJN()
	{
		FMHIJJNLJIE().NJDJHMPAIFE();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Tab2Content");
	}

	private void MECJHOJPODB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(HFAMJIHOJCH());
		}
	}

	private void HLDFOJMHKNL()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(NMEPOAEPNFM());
		}
	}

	private void EIIDKPHBOLM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1238f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 810f)
			{
				vector2.x = 1192f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 670f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void LCHBFNIPBHB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PHFOIIGIBFN());
		}
	}

	private void OKEHGHNHJFJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1415f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void HNOGGFCINIJ()
	{
		PHFOIIGIBFN().KJJODHJJEOH();
		Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("#FFDA44CC");
	}

	private void ABOJLAKEHOI()
	{
		PCCANFLFPJD().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Scrollbar");
	}

	private void MJNPIDGNJMK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(ECAMHMKKJPF());
		}
	}

	private void PINALAPAPDD()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 345f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 978f)
			{
				vector2.x = 1670f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1945f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	private void EJNPAAMMMIL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1825f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void MOKPIANAFEJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1876f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 519f)
			{
				vector2.x = 518f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 745f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void JDOCNDBKJLB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1467f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void HEHPKMABGAJ()
	{
		JCKAGIDMKFN().FMGBIHDGKBI();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("Drop_Far");
	}

	private void DNACNEMCJFA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 525f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void KICGCKKEGPF()
	{
		HFAMJIHOJCH().KJJODHJJEOH();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("_Value", true);
	}

	private void OCMKCBBCEFG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(IJIJEKKMFEO());
		}
	}

	public EditorEvent DBJLJKDGOOF()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void HFAEOGMPGIG()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 414f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 526f)
			{
				vector2.x = 1142f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 500f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD();
		}
	}

	private void ONKDMMJPEMN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PCCANFLFPJD());
		}
	}

	private void HLIOOCEPPLH()
	{
		HBNKOCHGKBI().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("isVisible");
	}

	private void AIEILPCFHHN()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 63f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1832f)
			{
				vector2.x = 596f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1150f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA();
		}
	}

	public EditorEvent PHFOIIGIBFN()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void APEBKMGJMKI()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1129f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 488f)
			{
				vector2.x = 554f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 312f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	private void KECFHJMDLLK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1664f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1114f)
			{
				vector2.x = 1931f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 898f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA();
		}
	}

	public EditorEvent HFAMJIHOJCH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void CJMPDPOPCNH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 610f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}
}
