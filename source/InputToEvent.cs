// InputToEvent
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputToEvent : MonoBehaviour
{
	private GameObject AAEFEIGCJGG;

	public static Vector3 inputHitPos;

	public bool DetectPointedAtGameObject;

	private Vector2 GGKIGGBGLOA = Vector2.zero;

	private Vector2 GMMIPJMMMEI = Vector2.zero;

	public bool Dragging;

	private Camera CMMMNLFGCJB;

	public static GameObject goPointedAt { get; private set; }

	public Vector2 DragVector => (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);

	private void AANKFBFFODO(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = DEEMBJNPOIJ(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("}", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void Update()
	{
		if (DetectPointedAtGameObject)
		{
			goPointedAt = AFGBEEIODHH(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				IMLHKBFBBGK(touch.position);
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				MFMMDDJFMGI(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			MFMMDDJFMGI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = AFGBEEIODHH(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("OnPressRight", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private GameObject GFGALLDGNHP(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1425f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void JILOMOBDPIA()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void DEFPCJMGMFI(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = OPFCKEAEPGC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_ColorBuffer", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void Start()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private GameObject AANABPBOBEG(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 927f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void IMLHKBFBBGK(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = AFGBEEIODHH(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("OnPress", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject KKKHLHDPFHE()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void LCJHDLKJEOM()
	{
		if (DetectPointedAtGameObject)
		{
			LFLGENLBCCE(LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				OFPBJLNIPDF(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				GLEMAAPOJLO(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			OHJJJFCOJPP(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JJHIFDNOPBI(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Value2", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void PGJNJBFBDFD(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Vector2 MLNMIBBFOBM()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void AOGKEMMCNIF(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = BNPIECAMPNK(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("Cause: ", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("note.6", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private GameObject EBEHLENFGHA(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1084f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public Vector2 LDFGLJMDNCL()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void MFMMDDJFMGI(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = AFGBEEIODHH(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("OnRelease", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private void ABIAEEHOAKE(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JJHIFDNOPBI(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("BestRegion checks region: ", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("Horizontal", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private void OHFOLGANOLC()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private GameObject LLCBANNMBJB(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 474f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void FHPFJBFCOOF()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	[SpecialName]
	public Vector2 MBAKAHMAOAP()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	public Vector2 NGBOLLLOLAO()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private GameObject DEEMBJNPOIJ(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 226f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public static GameObject CDAGDJMAHLH()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private GameObject GFHLGLEEKHC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 728f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void FIKFJDFELIP()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void OHJJJFCOJPP(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JJHIFDNOPBI(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("note.4", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	private static void ALBOOMNODCL(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Vector2 NJHOKAJGCID()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void BGDONBMDPGM()
	{
		if (DetectPointedAtGameObject)
		{
			PGJNJBFBDFD(AANABPBOBEG(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				AANKFBFFODO(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				OEOEIIGKLPA(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			OFPBJLNIPDF(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PMFFFFPFKEG(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Value", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private GameObject JJHIFDNOPBI(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1172f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	private static void LFLGENLBCCE(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private static void FMFGAIGOJHG(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void OFPBJLNIPDF(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = DEEMBJNPOIJ(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("CameraFilterPack/Drawing_Crosshatch", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject JHMGPBIPOFP()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject EPNIEGKMAHG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject BHMCMOMJNEB()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private GameObject DGGEDPILEMJ(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1687f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public static GameObject HKPJGDBCCIJ()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void DEAIEEAGCBB(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = BNPIECAMPNK(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("player.abstract", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject NLBLELFIJJC()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void FANADGBGCPI()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private GameObject PMFFFFPFKEG(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 671f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public Vector2 GKHHOANMMDC()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void NKLIHNJCHOG()
	{
		if (DetectPointedAtGameObject)
		{
			goPointedAt = AANABPBOBEG(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				IMLHKBFBBGK(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				OEOEIIGKLPA(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			FOALLFHOGOI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = LLCBANNMBJB(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("maps.", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void OCMKCBBCEFG()
	{
		if (DetectPointedAtGameObject)
		{
			PGJNJBFBDFD(DEEMBJNPOIJ(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				OHJJJFCOJPP(touch.position);
			}
			else if (touch.phase == (TouchPhase)5)
			{
				GLEMAAPOJLO(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = OPFCKEAEPGC(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("^", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private GameObject OPFCKEAEPGC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1218f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void GLEMAAPOJLO(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = DGGEDPILEMJ(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("[SteamManager] Connecting to server", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("ChatHistoryInputField", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	private GameObject AFGBEEIODHH(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 200f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public Vector2 BEFJDBLCHDI()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private GameObject BNPIECAMPNK(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1495f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public Vector2 DGGCDNLCMLA()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	public static GameObject ALBDFMNBNMM()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void FOALLFHOGOI(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JJHIFDNOPBI(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("colorD", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("player.currentrank", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	[SpecialName]
	public Vector2 MLGAPCMGGEI()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	public static GameObject GOPJFDFJDEE()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void OEOEIIGKLPA(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = AANABPBOBEG(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("#savemapchanges?", SendMessageOptions.RequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("y", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private void BIJPCIFBDAJ(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JJHIFDNOPBI(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("#", SendMessageOptions.RequireReceiver);
			}
			AAEFEIGCJGG.SendMessage(".completedCount", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}
}
