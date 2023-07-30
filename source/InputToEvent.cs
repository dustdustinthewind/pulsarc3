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

	[SpecialName]
	public static GameObject GBBOGHGEMDI()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject BGBBJJEEHGA()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject CAFEKBFGLKG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public Vector2 MAOMJBGNJIK()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void GILCKHBBDHC(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = PMPKLBHJBMC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("[", SendMessageOptions.RequireReceiver);
		}
	}

	private void JMMMIMMFMPE(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = PFHIBKGJHFO(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("SetSatelliteSensitivity", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void BMODOIJGIOO()
	{
		if (DetectPointedAtGameObject)
		{
			PKGPPLPFOLB(FGEMAMFBNBF(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				IPPFAHGEIGC(touch.position);
			}
			else if (touch.phase == (TouchPhase)7)
			{
				HOAADBJHIIK(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			DNOHBFDCPFE(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			HOAADBJHIIK(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = AJIPCBNPBDJ(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("/../", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void LEPGHGEKMED(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = PMPKLBHJBMC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("JoinButton", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public Vector2 MBAKAHMAOAP()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void JOLHHDBFOMG(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JJHIFDNOPBI(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("CameraFilterPack_AAA_Blood_Hit1", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("_Alpha2", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	[SpecialName]
	private static void JGIEADBGJLJ(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void HFJGFGDGNAJ(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = FGEMAMFBNBF(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_ScreenResolution", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject PNMKLDIOGNC()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void AKCADICOFDD()
	{
		if (DetectPointedAtGameObject)
		{
			JGIEADBGJLJ(FGEMAMFBNBF(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				KKJOBJAIDJI(touch.position);
			}
			else if (touch.phase == TouchPhase.Began)
			{
				IICBGBFOOJC(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			DDKNLBNLPJO(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			BINFPMPPGEH(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JLFDPIONEOE(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("file://", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	public static GameObject NEGEFGKGMNG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void IAJKLKJJKEJ()
	{
		if (DetectPointedAtGameObject)
		{
			JGIEADBGJLJ(LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				LEPGHGEKMED(touch.position);
			}
			else if (touch.phase == (TouchPhase)8)
			{
				MFMMDDJFMGI(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			KKJOBJAIDJI(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			JOLHHDBFOMG(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PFHIBKGJHFO(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("Deleted data", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private GameObject LLCBANNMBJB(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1669f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void BGFJOEPFOPM()
	{
		if (DetectPointedAtGameObject)
		{
			ALBOOMNODCL(AFGBEEIODHH(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				DFEKEEKJEDG(touch.position);
			}
			else if (touch.phase == TouchPhase.Began)
			{
				AFLJNAOKGOB(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			JNCFCPILNOK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			OHIPMEGDNNI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = FGEMAMFBNBF(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_ScreenResolution", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void KIOHFMLOOPL(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private static void LHJLAKDBEHH(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void DNOHBFDCPFE(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JJHIFDNOPBI(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("Cancel", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void GFGOLBBOLAN(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JLFDPIONEOE(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("default", SendMessageOptions.DontRequireReceiver);
		}
	}

	private GameObject PMPKLBHJBMC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 143f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void OHIPMEGDNNI(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = GAPEJDNMHAC(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("G:", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("VoteUpToggle", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	private void IINAOAFHOKO(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JJHIFDNOPBI(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("/", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void JBCNIPJDPJB()
	{
		if (DetectPointedAtGameObject)
		{
			EBEAIPJGJPP(AJIPCBNPBDJ(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				IINAOAFHOKO(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				FKOFJOKENIH(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			JMMMIMMFMPE(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			BINFPMPPGEH(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JLFDPIONEOE(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("SetParticlesEmission", SendMessageOptions.RequireReceiver);
			}
		}
	}

	[SpecialName]
	public Vector2 NGBOLLLOLAO()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void HNEOKJNKACE(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = LLCBANNMBJB(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("GameScene", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	public Vector2 EFCFDEGOJPI()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void DOFDGBGEDFI()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	[SpecialName]
	public static GameObject JLOKEGDMHHH()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void DJCHIPNIEMP(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = LLCBANNMBJB(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Value7", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void COIJKMKIEAK()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
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

	[SpecialName]
	private static void KGPLNOGAGLP(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void HEOBPDNCCNG(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = PFHIBKGJHFO(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("_Near", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("_TimeX", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private GameObject JJHIFDNOPBI(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1802f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void DMPAIEPOIFP(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = AFGBEEIODHH(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("setstring", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void PKGJJFIFLII()
	{
		if (DetectPointedAtGameObject)
		{
			ALBOOMNODCL(GAPEJDNMHAC(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				FOBDPIKOCFK(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				HOAADBJHIIK(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			FJNLIKLCLAK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			AFLJNAOKGOB(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PMPKLBHJBMC(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("StartButton", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void NKHICPLBPBG(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public static GameObject NLBLELFIJJC()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject FFBJKGDNMPN()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject DPPANNPKECP()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void IBFJAOINHMK()
	{
		if (DetectPointedAtGameObject)
		{
			KIOHFMLOOPL(PMPKLBHJBMC(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				FJNLIKLCLAK(touch.position);
			}
			else if (touch.phase == (TouchPhase)8)
			{
				IICBGBFOOJC(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			JNCFCPILNOK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			HEOBPDNCCNG(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = FGEMAMFBNBF(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("entering", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void HOAADBJHIIK(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = PFHIBKGJHFO(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("menu.selectedlevelid", SendMessageOptions.RequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("Vertical", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private void POIMNOBDBBN()
	{
		if (DetectPointedAtGameObject)
		{
			KIOHFMLOOPL(LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				FJNLIKLCLAK(touch.position);
			}
			else if (touch.phase == TouchPhase.Moved)
			{
				FKOFJOKENIH(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			LEPGHGEKMED(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			OHIPMEGDNNI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = LLCBANNMBJB(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("settings.shaders.bloomintencity", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void CMAJEJBFHBC(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = GAPEJDNMHAC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("false", SendMessageOptions.RequireReceiver);
		}
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
	private static void DEKEDIICHLA(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void KKJOBJAIDJI(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = GAPEJDNMHAC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("LoadMapCanvas", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void BOPKKCAFODF()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void CEDFFAOOPOG()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void BNMCFLKKDMG(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = LLCBANNMBJB(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Min", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	private static void ALBOOMNODCL(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public static GameObject GJNOKEDHBLM()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void FKOFJOKENIH(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = GAPEJDNMHAC(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("inventory.selected.", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("X", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	private void Start()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	[SpecialName]
	public Vector2 AJPFOOEIMJP()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void DFEKEEKJEDG(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = LLCBANNMBJB(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("GlassDistortion", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void PKNODEDFKDN(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JLFDPIONEOE(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("DestroyRpc", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("FavoriteButton", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	private void FJNLIKLCLAK(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JLFDPIONEOE(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Value7", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	public Vector2 LEJDCFAPENF()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void FOBDPIKOCFK(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = GAPEJDNMHAC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Visualize", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject BPMNKAMBHFF()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject ABPEFOBKIFI()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void PKLOBJHKFEO()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void PNLKFANNOKO()
	{
		if (DetectPointedAtGameObject)
		{
			goPointedAt = AFGBEEIODHH(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				OHJJJFCOJPP(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				MFMMDDJFMGI(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			MAAEKHBPKAK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			HEOBPDNCCNG(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = LLCBANNMBJB(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Value2", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void FGNFILLNPJK()
	{
		if (DetectPointedAtGameObject)
		{
			NKHICPLBPBG(AFGBEEIODHH(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				LEPGHGEKMED(touch.position);
			}
			else if (touch.phase == (TouchPhase)8)
			{
				HEOBPDNCCNG(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			HNEOKJNKACE(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			MFMMDDJFMGI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JJHIFDNOPBI(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Value2", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void MODENHKMKOC()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void NDAJBJFJGCF()
	{
		if (DetectPointedAtGameObject)
		{
			HHOCMHBGJCI(AJIPCBNPBDJ(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				AANKFBFFODO(touch.position);
			}
			else if (touch.phase == TouchPhase.Canceled)
			{
				PKNODEDFKDN(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			LEPGHGEKMED(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			AFLJNAOKGOB(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = AJIPCBNPBDJ(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Size", SendMessageOptions.RequireReceiver);
			}
		}
	}

	[SpecialName]
	public Vector2 DFJECNALJCE()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void AEMGPJDJGBJ()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void IKMELABKBHO()
	{
		if (DetectPointedAtGameObject)
		{
			LHJLAKDBEHH(JLFDPIONEOE(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				DMPAIEPOIFP(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				PKNODEDFKDN(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			IINAOAFHOKO(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IICBGBFOOJC(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = AFGBEEIODHH(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("MenuScene", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	public static GameObject GOPJFDFJDEE()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void LCJHDLKJEOM()
	{
		if (DetectPointedAtGameObject)
		{
			ACHAGIBMDCD(AJIPCBNPBDJ(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				IINAOAFHOKO(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				HEOBPDNCCNG(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			AANKFBFFODO(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			HOAADBJHIIK(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PMPKLBHJBMC(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("[MapEditor] Reset", SendMessageOptions.RequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void PKGPPLPFOLB(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Vector2 PFOADIOKHCA()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void OPCLBGHAPMG()
	{
		if (DetectPointedAtGameObject)
		{
			DCDKJICPBIE(FGEMAMFBNBF(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				GILCKHBBDHC(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				PKNODEDFKDN(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			KKJOBJAIDJI(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			HOAADBJHIIK(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JLFDPIONEOE(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("y", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void GMOCKKIOPHJ(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JLFDPIONEOE(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("_Value", SendMessageOptions.RequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("move", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	[SpecialName]
	public static GameObject HNJGEGIJCIP()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void GHILDCBCDJI()
	{
		if (DetectPointedAtGameObject)
		{
			DCDKJICPBIE(AFGBEEIODHH(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				GFGOLBBOLAN(touch.position);
			}
			else if (touch.phase == (TouchPhase)5)
			{
				AFLJNAOKGOB(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			DJCHIPNIEMP(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			AFLJNAOKGOB(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PFHIBKGJHFO(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("RPCs can only be sent in rooms. Call of \"", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void IICBGBFOOJC(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JLFDPIONEOE(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("Joystick1Button", SendMessageOptions.RequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("/", SendMessageOptions.DontRequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	[SpecialName]
	private static void BFJLMPAHENP(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public static GameObject NHJCAABAOCK()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void LGHCJCFHEMF()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private GameObject PFHIBKGJHFO(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1781f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	private static void NOAFBPLMBGI(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private static void ACHAGIBMDCD(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
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

	[SpecialName]
	public static GameObject BHPFOCPLKKD()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void AFLJNAOKGOB(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = JLFDPIONEOE(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("StartButton", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage(",", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = false;
	}

	private void OHJJJFCOJPP(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = JLFDPIONEOE(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("Populate Mesh Data", SendMessageOptions.RequireReceiver);
		}
	}

	private void BINFPMPPGEH(Vector2 OPDCNOOGBIF)
	{
		if (AAEFEIGCJGG != null)
		{
			GameObject gameObject = AJIPCBNPBDJ(OPDCNOOGBIF);
			if (gameObject == AAEFEIGCJGG)
			{
				AAEFEIGCJGG.SendMessage("_Blue_B", SendMessageOptions.DontRequireReceiver);
			}
			AAEFEIGCJGG.SendMessage("workshop.", SendMessageOptions.RequireReceiver);
			AAEFEIGCJGG = null;
		}
		GGKIGGBGLOA = Vector2.zero;
		Dragging = true;
	}

	[SpecialName]
	public Vector2 PMJHEECLDEB()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private GameObject JLFDPIONEOE(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1996f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void NBGIMIDICKE()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void PCCLBJJIGOD(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = LLCBANNMBJB(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_TimeX", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void GCHBGCGBMCK()
	{
		if (DetectPointedAtGameObject)
		{
			BFJLMPAHENP(LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				GILCKHBBDHC(touch.position);
			}
			else if (touch.phase == (TouchPhase)5)
			{
				IICBGBFOOJC(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			LEPGHGEKMED(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			OHIPMEGDNNI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = GAPEJDNMHAC(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("NetworkCanvas", SendMessageOptions.RequireReceiver);
			}
		}
	}

	[SpecialName]
	public static GameObject AMEAGHJJPJC()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void PMPKMGKAAJH()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void FBHNPHLOAGP(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = JLFDPIONEOE(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("CameraFilterPack/Vision_Plasma", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public Vector2 NCNAKKLLNMH()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	private static void DCDKJICPBIE(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void MAAEKHBPKAK(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = AJIPCBNPBDJ(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("shader.crispwinter", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject GHCOGMMAGHG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject NKCBJPHKCOG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private GameObject FGEMAMFBNBF(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 883f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	[SpecialName]
	public static GameObject NPIPJHKAPLE()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void LKJMIODJGCM()
	{
		if (DetectPointedAtGameObject)
		{
			HHOCMHBGJCI(FGEMAMFBNBF(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				FBHNPHLOAGP(touch.position);
			}
			else if (touch.phase == TouchPhase.Canceled)
			{
				FKOFJOKENIH(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			DNOHBFDCPFE(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			HEOBPDNCCNG(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = JJHIFDNOPBI(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_TimeX", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void FANADGBGCPI()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	[SpecialName]
	public Vector2 HALDMELCMEH()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	public Vector2 GJLKMIMLHKF()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void NEKCPLGFOFD()
	{
		if (DetectPointedAtGameObject)
		{
			JGIEADBGJLJ(JLFDPIONEOE(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				LEPGHGEKMED(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				JOLHHDBFOMG(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			DMPAIEPOIFP(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IICBGBFOOJC(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PFHIBKGJHFO(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("offsets", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void HEINFOIAMPC(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public static GameObject EPNIEGKMAHG()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void IPPFAHGEIGC(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = PMPKLBHJBMC(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Value5", SendMessageOptions.RequireReceiver);
		}
	}

	private GameObject AJIPCBNPBDJ(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 1732f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void AOLABBMIEIM()
	{
		if (DetectPointedAtGameObject)
		{
			DEKEDIICHLA(JJHIFDNOPBI(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				BNMCFLKKDMG(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				GMOCKKIOPHJ(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			GILCKHBBDHC(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			GMOCKKIOPHJ(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = LLCBANNMBJB(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_ScreenResolution", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void KCICACOBEAJ(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	private void JILOMOBDPIA()
	{
		CMMMNLFGCJB = GetComponent<Camera>();
	}

	private void JNCFCPILNOK(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = AJIPCBNPBDJ(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("player.greenlifering", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	private static void EBEAIPJGJPP(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
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

	private void ABFNJCEBIKA()
	{
		if (DetectPointedAtGameObject)
		{
			HEINFOIAMPC(PFHIBKGJHFO(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				DJCHIPNIEMP(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				FKOFJOKENIH(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			DDKNLBNLPJO(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			OHIPMEGDNNI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = FGEMAMFBNBF(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_TimeX", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void JFMIDILENDO()
	{
		if (DetectPointedAtGameObject)
		{
			BFJLMPAHENP(JJHIFDNOPBI(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				BNMCFLKKDMG(touch.position);
			}
			else if (touch.phase == (TouchPhase)7)
			{
				GMOCKKIOPHJ(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			KKJOBJAIDJI(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			JOLHHDBFOMG(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PMPKLBHJBMC(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_Distortion", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	[SpecialName]
	private static void HHOCMHBGJCI(GameObject DPNHODJHGJL)
	{
		_003CDDEJNLMHIAE_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Vector2 EBGPGKAJMPJ()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	private void DDKNLBNLPJO(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = false;
		AAEFEIGCJGG = JJHIFDNOPBI(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("ready", SendMessageOptions.DontRequireReceiver);
		}
	}

	[SpecialName]
	public static GameObject NIFAMLOPILI()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private void AANKFBFFODO(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = AJIPCBNPBDJ(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("Destroy all spawned environment objects", SendMessageOptions.RequireReceiver);
		}
	}

	private void FOLDLDLFFLM()
	{
		if (DetectPointedAtGameObject)
		{
			KCICACOBEAJ(LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(0);
			GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				DMPAIEPOIFP(touch.position);
			}
			else if (touch.phase == (TouchPhase)5)
			{
				FKOFJOKENIH(touch.position);
			}
			return;
		}
		GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			FOBDPIKOCFK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			AFLJNAOKGOB(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			GGKIGGBGLOA = Input.mousePosition;
			AAEFEIGCJGG = PFHIBKGJHFO(GGKIGGBGLOA);
			if (AAEFEIGCJGG != null)
			{
				AAEFEIGCJGG.SendMessage("_InvScreenSize", SendMessageOptions.RequireReceiver);
			}
		}
	}

	[SpecialName]
	public Vector2 NIDEEPGFNKP()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}

	[SpecialName]
	public static GameObject LEGIHEGNHJO()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	[SpecialName]
	public static GameObject LEHGEHGANLD()
	{
		return _003CDDEJNLMHIAE_003Ek__BackingField;
	}

	private GameObject GAPEJDNMHAC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit hitInfo;
		if (Physics.Raycast(CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out hitInfo, 709f))
		{
			inputHitPos = hitInfo.point;
			return hitInfo.collider.gameObject;
		}
		return null;
	}

	private void HPBLABBOMLH(Vector2 OPDCNOOGBIF)
	{
		GGKIGGBGLOA = OPDCNOOGBIF;
		Dragging = true;
		AAEFEIGCJGG = JLFDPIONEOE(OPDCNOOGBIF);
		if (AAEFEIGCJGG != null)
		{
			AAEFEIGCJGG.SendMessage("_Red_R", SendMessageOptions.RequireReceiver);
		}
	}

	[SpecialName]
	public Vector2 CJKLFCIMDKD()
	{
		return (!Dragging) ? Vector2.zero : (GMMIPJMMMEI - GGKIGGBGLOA);
	}
}
