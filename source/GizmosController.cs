// GizmosController
using UnityEngine;

public class GizmosController : MonoBehaviour
{
	public GameObject dragObj;

	public bool dragEnabled = true;

	private Vector3 KAOOCILPJCN;

	private Vector3 INLGAOLENMD;

	private void JHPOIOELNCG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(KGEOGKIKFOJ());
		}
	}

	private void JDBKGBIBNAA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 57f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1942f)
			{
				vector2.x = 743f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1560f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void KKDGGDJEILB()
	{
		KGEOGKIKFOJ().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("https://steamcommunity.com/sharedfiles/filedetails/?id=");
	}

	private void DPCCOLAPEAP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1203f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 139f)
			{
				vector2.x = 1675f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 822f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void JEGENOEENLG()
	{
		JPCLJPBKBCD().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("CameraFilterPack/Blend2Camera_LinearDodge", true);
	}

	private void ILMECDGLGJO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 902f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 214f)
			{
				vector2.x = 800f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 216f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void NGDDGBLKKKK()
	{
		MMGODILPCBG().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("curScn");
	}

	private void BGDONBMDPGM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PFPMBKOLBMI());
		}
	}

	private void AKCECJHPDDL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 149f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1860f)
			{
				vector2.x = 1085f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 952f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void IHLBONEMDDP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1711f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void JFMIDILENDO()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(OOKPCMHAODD());
		}
	}

	private void COGBDFKOHKK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(NJNDOJDJDDH());
		}
	}

	private void EPJJDKJEDMM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(KIMHOPLGIMN());
		}
	}

	private void KDEHHJBMJEM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 364f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent EKLLANBFINH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent AGDMBMBBMMJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void LMPNKBJCECI()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 640f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 295f)
			{
				vector2.x = 1848f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1670f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void AOPCEPBBGNG()
	{
		BAMMKNDLGOL().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_Value3");
	}

	private void BFLNJAKMMJK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 243f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void MBLDJEFBLFL()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(MLDIIFGGNCB());
		}
	}

	private void JFNMNFNEAAA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 988f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 544f)
			{
				vector2.x = 717f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 85f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void NMCKKBBILBB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 835f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1782f)
			{
				vector2.x = 1955f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 642f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent LLMDNEJFGOG()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent ICBHLAKNLLJ()
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
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(JPCLJPBKBCD());
		}
	}

	private void NDKFAFMPBCB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 466f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void AAPKBNDHBLI()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(HLFMBFEDKMI());
		}
	}

	private void CONCGJIEDAK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1508f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 66f)
			{
				vector2.x = 1244f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 743f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent KIMHOPLGIMN()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void HDDOBKMHIME()
	{
		HHFEMBJLCDP().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("selector", true);
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

	private void AEEDJOEAGOF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 611f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 894f)
			{
				vector2.x = 1754f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1824f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void JMKMLGMAIGN()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 691f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 922f)
			{
				vector2.x = 308f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1818f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent NJNDOJDJDDH()
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

	private void GILBKKANIMH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1327f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void IJNDNJBIDHN()
	{
		OOKPCMHAODD().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_NoiseTex", true);
	}

	public EditorEvent JPCLJPBKBCD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void GPIFGNFNOBM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 816f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1577f)
			{
				vector2.x = 619f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1658f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent PGDPIFACFEH()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void GAGEKMHMFCH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1871f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 733f)
			{
				vector2.x = 671f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1819f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
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

	private void LMILPLOBFCO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 858f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void KECKHMNEFJN()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1651f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1297f)
			{
				vector2.x = 313f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1432f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void GPKEBKMAJEG()
	{
		NJNDOJDJDDH().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("Joystick1Button11", true);
	}

	private void PKGJJFIFLII()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(KIMHOPLGIMN());
		}
	}

	private void OMCLOFCJMPG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(MLDIIFGGNCB());
		}
	}

	private void JBMBNKOOENB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(MFNOCLFKAIA());
		}
	}

	private void ONKDMMJPEMN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PFPMBKOLBMI());
		}
	}

	private void POIMNOBDBBN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(KIMHOPLGIMN());
		}
	}

	private void JGNGHFOBEFB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 246f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 332f)
			{
				vector2.x = 294f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 286f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void LNFLDPHHHAP()
	{
		NJNDOJDJDDH().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("masterSteamID", true);
	}

	private void LOIGNPEBHFD()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 930f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void LCHBFNIPBHB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(PGDPIFACFEH());
		}
	}

	public EditorEvent BJKLMFNJBNP()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void NLPFNKGCKMA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1524f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void NOEGBCCDMPL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1739f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1929f)
			{
				vector2.x = 1621f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1834f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void NFAALOKGPHP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 460f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void MNCOADBMPPF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1058f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent ABJHPCFIDDJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void HLDOKPCCDAP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1963f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void ACNEOFFJHPF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1714f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent MLDIIFGGNCB()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void JDGEPNDKDBL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1484f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void JFKBGAAOPOK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1740f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void OnMouseUp()
	{
		GetEditorEvent().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Moved event");
	}

	private void FOMNCPKKCFN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(FEOCBJLMJKE());
		}
	}

	private void IFBGEFFPCCF()
	{
		KIMHOPLGIMN().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("_Value");
	}

	private void CMOFDCGAIGB()
	{
		MMGODILPCBG().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.ICNMFKDPDBM(" ");
	}

	private void PNEMHGPAMDP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 139f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent HLFMBFEDKMI()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void GHIAMLDEOEO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1682f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 993f)
			{
				vector2.x = 822f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 573f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void AKCADICOFDD()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(LLMDNEJFGOG());
		}
	}

	private void IKMELABKBHO()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(JPCLJPBKBCD());
		}
	}

	private void EDDPLJGKLKJ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(GetEditorEvent());
		}
	}

	private void NEPAGMPBFCH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 218f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	public EditorEvent FEOCBJLMJKE()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void KKNJEHKGCNH()
	{
		KIMHOPLGIMN().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("D-Pad Left");
	}

	public EditorEvent HHFEMBJLCDP()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void EOIMAMMHCOP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 204f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 760f)
			{
				vector2.x = 1808f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1975f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void FABHLBDFBHC()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1520f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 403f)
			{
				vector2.x = 220f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1156f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	public EditorEvent KGEOGKIKFOJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void KIEJKBNBHMD()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(EKLLANBFINH());
		}
	}

	public EditorEvent MFJPMHHADNA()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void ABLAIDHNFFP()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1887f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 932f)
			{
				vector2.x = 1090f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1216f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void DLDIICLADJB()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 233f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void BFOIPCAHIIF()
	{
		ICBHLAKNLLJ().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("3d text");
	}

	private void JPNJKBDEPLL()
	{
		MFJPMHHADNA().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("BitsData", true);
	}

	public EditorEvent GetEditorEvent()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void HNOGGFCINIJ()
	{
		MFNOCLFKAIA().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_ScreenResolution");
	}

	public EditorEvent PFPMBKOLBMI()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void HCDIBFBBAMO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 286f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void IOOMLNACNIF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1553f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void LMGNLMEJIOG()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 217f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 798f)
			{
				vector2.x = 193f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1332f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent BAMMKNDLGOL()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void EICFCDIBFLJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 488f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1237f)
			{
				vector2.x = 477f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 980f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void KMEONPMCNJG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(KIMHOPLGIMN());
		}
	}

	private void NBNADDFBPDO()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1935f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1412f)
			{
				vector2.x = 911f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1385f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	public EditorEvent MFNOCLFKAIA()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void FABMDEHEDNO()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(ABJHPCFIDDJ());
		}
	}

	private void DPIPGGDNGHN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(DNJPMINNJIJ());
		}
	}

	private void OBFIIHOOGIJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1765f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 227f)
			{
				vector2.x = 706f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1171f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void BLEMAGIAGJA()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 416f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void HBLJJIOKLFH()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1715f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void FJECHEECPIL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 678f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1665f)
			{
				vector2.x = 559f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 189f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void ICLPHHOJHHM()
	{
		ABJHPCFIDDJ().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_ProjectToPixelMatrix");
	}

	private void HDDECCMEJKA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(EKLLANBFINH());
		}
	}

	public EditorEvent KMJHHEHKKMC()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void KKLMPKLKAEM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(JPCLJPBKBCD());
		}
	}

	private void PKOHPCEMMGJ()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 57f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void FBKKCJEPBND()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1637f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 975f)
			{
				vector2.x = 696f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 24f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void FBCHBMPPEKA()
	{
		MFNOCLFKAIA().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("0", true);
	}

	private void MNKNLNNNKAF()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 408f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1941f)
			{
				vector2.x = 674f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1904f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void PKOAOKLGHOL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 240f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 1123f)
			{
				vector2.x = 1111f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 316f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent();
		}
	}

	private void NEKCPLGFOFD()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(0) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(HLFMBFEDKMI());
		}
	}

	private void JFGLCPLHJAE()
	{
		ICBHLAKNLLJ().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("[FileSelector] Starting file dialog");
	}

	public EditorEvent OOKPCMHAODD()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void MDCFIHDPLIG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo) && Input.GetMouseButton(1) && hitInfo.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(BAMMKNDLGOL());
		}
	}

	private void DOANCIBPEEO()
	{
		PGDPIFACFEH().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("HelpMenu", true);
	}

	private void IHEFHMFMKOL()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1827f);
			INLGAOLENMD = dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	private void JANLBMLAGAK()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 197f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 684f)
			{
				vector2.x = 791f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 738f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	private void OCDCCACJKPM()
	{
		if (dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1174f);
			Vector3 vector = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector2 = vector + INLGAOLENMD;
			if (vector2.x < 362f)
			{
				vector2.x = 14f;
			}
			if (vector2.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector2.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			dragObj.transform.position = new Vector3(vector2.x, vector2.y, 1752f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	public EditorEvent MMGODILPCBG()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	public EditorEvent DNJPMINNJIJ()
	{
		if ((bool)base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	private void PJKHMHBPLAG()
	{
		KMJHHEHKKMC().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("_Threshold", true);
	}

	private void KJMIFKCFBDO()
	{
		MLDIIFGGNCB().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("visible", true);
	}

	private void EPIDIDCAICG()
	{
		NJNDOJDJDDH().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("_Bloom3", true);
	}

	private void HEHPKMABGAJ()
	{
		KMJHHEHKKMC().CMNPEMEIJEJ();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("ENABLE_EYE_ADAPTATION", true);
	}

	private void JLPHDJKLDDJ()
	{
		EKLLANBFINH().UpdateEvent();
		Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent();
		Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("Connection error: ", true);
	}
}
