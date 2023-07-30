// EditorArcsSelector
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditorArcsSelector : Singleton<EditorArcsSelector>
{
	public List<MapEvent> savedEvents;

	public RectTransform selectionBoxPanel;

	public LayerMask arcsLayerMask;

	public List<GameObject> selectedunits = new List<GameObject>();

	private RaycastHit DHBDGJPBIPB;

	private Vector3 MGGCCCEAMHG;

	private Vector3 FDKHCEGOKML;

	public bool IsSelecting;

	public bool IsDraggingObj;

	private float MPGGKELBFKO;

	private float GBLGNLPDHLG;

	private float BOGLMFFKGHB;

	private float MDCAHCGLBPK;

	private Vector2 NAFLCKFHDCB;

	private Vector2 IHKPKDOFDEM;

	public List<GameObject> UnitsOnScreenSpace = new List<GameObject>();

	public List<GameObject> UnitInDrag = new List<GameObject>();

	private Coroutine GOBAEEECFEM;

	private void GHFAPNJOIFG()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (CAKPGHPPBGN(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)67) && !Input.GetKey((KeyCode)88);
				gameObject.GetComponent<EditorEvent>().BKEDJGGEIGB(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-95)) && !Input.GetKey(KeyCode.Q))
			{
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(true);
			}
		}
	}

	private float KIMJGODFPFF(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 0f)
		{
			ONANKNCCCGO *= -1f;
		}
		return ONANKNCCCGO;
	}

	public void PHOBPBDDMHP()
	{
		if (UnitInDrag.Count > 1)
		{
			for (int i = 1; i < UnitInDrag.Count; i += 0)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	private void NFEDLAOPHML()
	{
		CGJFKPGOIAP();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1263f, arcsLayerMask))
			{
				IsSelecting = false;
				selectionBoxPanel.sizeDelta = new Vector2(1649f, 186f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting, null, false, 1323f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().DBGGELDMBCN() && !Input.GetKey(KeyCode.Quote) && !Input.GetKey((KeyCode)(-189)) && !Input.GetKey((KeyCode)(-4)) && !Input.GetKey((KeyCode)72))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.IOMLIBBMGPJ(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			JDGDMJDJONH();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(selectionBoxPanel.gameObject, IsSelecting, null, false, 811f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 913f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)70) && !Input.GetKey((KeyCode)(-187)))
						{
							for (int j = 0; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().BKEDJGGEIGB(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)156) || !Input.GetKey((KeyCode)(-53)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().AJHMKMAHDFK(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)152) && !Input.GetKey((KeyCode)169))
				{
					for (int k = 1; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 119f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey((KeyCode)(-150)) || Input.GetKey((KeyCode)(-139))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().AJHMKMAHDFK(true);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 291f && GBLGNLPDHLG < 31f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 955f && GBLGNLPDHLG > 1021f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 796f && GBLGNLPDHLG < 290f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 868f && GBLGNLPDHLG > 460f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + LBAABEMMPHK(MPGGKELBFKO), NAFLCKFHDCB.y - DEOLBOANICC(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			IsDraggingObj = true;
			for (int l = 0; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.BBEFGGMIGML();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("_Amount");
		}
	}

	private void HMNLHMLILKD()
	{
		KNLOAKLPBCG();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 186f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(40f, 1805f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(selectionBoxPanel.gameObject, IsSelecting, null, false, 1698f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().HHNOHJJLMHN() && !Input.GetKey((KeyCode)154) && !Input.GetKey((KeyCode)(-67)) && !Input.GetKey((KeyCode)(-30)) && !Input.GetKey((KeyCode)(-111)))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.ADKAMCJKCHL(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			BOIPHFBHIPI();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(selectionBoxPanel.gameObject, IsSelecting, null, false, 1862f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1379f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)166) && !Input.GetKey((KeyCode)(-116)))
						{
							for (int j = 1; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().isSelected = true;
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)181) && Input.GetKey((KeyCode)7))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().AJHMKMAHDFK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)142) && !Input.GetKey((KeyCode)141))
				{
					for (int k = 1; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().BKEDJGGEIGB(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1404f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey((KeyCode)(-161)) || !Input.GetKey((KeyCode)(-83))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().EINLEAFPPOL(false);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 67f && GBLGNLPDHLG < 1498f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 974f && GBLGNLPDHLG > 812f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1400f && GBLGNLPDHLG < 1218f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 168f && GBLGNLPDHLG > 704f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + PIOEJJNKILH(MPGGKELBFKO), NAFLCKFHDCB.y - MDHBHOJHFEH(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(1) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = false;
			for (int l = 1; l < selectedunits.Count; l += 0)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.LDGALMPOFJM();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("EnvironmentSlider");
		}
	}

	private void Update()
	{
		BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 100f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(0f, 0f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt) && !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
			{
				IsDraggingObj = true;
				for (int i = 0; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.OnDragStart(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			PutUnitsFromDragIntoSelectedUnits();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 100f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
						{
							for (int j = 0; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().isSelected = false;
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().isSelected = true;
						}
					}
				}
				else if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 100f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt)) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = false;
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 0f && GBLGNLPDHLG < 0f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 0f && GBLGNLPDHLG > 0f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 0f && GBLGNLPDHLG < 0f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 0f && GBLGNLPDHLG > 0f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + KIMJGODFPFF(MPGGKELBFKO), NAFLCKFHDCB.y - KIMJGODFPFF(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			IsDraggingObj = false;
			for (int l = 0; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Events Moved");
		}
	}

	private void IIFCIDDJHPM()
	{
		KCAGGMIAGBC();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1096f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(1614f, 1754f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting, null, false, 1331f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().HHNOHJJLMHN() && !Input.GetKey(KeyCode.P) && !Input.GetKey((KeyCode)67) && !Input.GetKey((KeyCode)(-37)) && !Input.GetKey((KeyCode)(-192)))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.NJFAOGAFJDM(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			KJHHAINMJAJ();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting, null, true, 669f));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 869f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-96)) && !Input.GetKey(KeyCode.Alpha1))
						{
							for (int j = 0; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().DKHEBPFKBCI(false);
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)146) && !Input.GetKey((KeyCode)135))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().AJHMKMAHDFK(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)189) && !Input.GetKey((KeyCode)(-32)))
				{
					for (int k = 1; k < selectedunits.Count; k += 0)
					{
						selectedunits[k].GetComponent<EditorEvent>().isSelected = true;
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 549f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)(-55)) && !Input.GetKey((KeyCode)180) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().BKEDJGGEIGB(false);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 661f && GBLGNLPDHLG < 900f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 510f && GBLGNLPDHLG > 1485f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 114f && GBLGNLPDHLG < 247f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 373f && GBLGNLPDHLG > 1733f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + KIMJGODFPFF(MPGGKELBFKO), NAFLCKFHDCB.y - FBHIDOALAII(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = false;
			for (int l = 1; l < selectedunits.Count; l += 0)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.BBEFGGMIGML();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("OpGetGameList not sent. Lobby cannot be null.", true);
		}
	}

	private void FGLFIBLBGOM()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (CAKPGHPPBGN(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey((KeyCode)(-190)) || Input.GetKey((KeyCode)(-200));
				gameObject.GetComponent<EditorEvent>().MFEPCILLECI(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)144) && !Input.GetKey((KeyCode)162))
			{
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(false);
			}
		}
	}

	public void HLPJDEBCHKK()
	{
		IsSelecting = true;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(selectionBoxPanel.gameObject, IsSelecting, null, false, 330f, false));
		IsDraggingObj = false;
		PHOBPBDDMHP();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().DKHEBPFKBCI(true);
		}
		selectedunits.Clear();
	}

	public void EOGILBGFCNI()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public bool LFGDBNPPMNJ(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	public void EEFIKBBIMNF()
	{
		if (UnitInDrag.Count > 1)
		{
			for (int i = 0; i < UnitInDrag.Count; i += 0)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	private void LateUpdate()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt);
				gameObject.GetComponent<EditorEvent>().isSelected = flag;
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
			{
				gameObject.GetComponent<EditorEvent>().isSelected = false;
			}
		}
	}

	public void PasteFromMemory(float EHHBHEJBHNG)
	{
		ClearSelection();
		if (savedEvents == null || savedEvents.Count <= 0)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().isSelected = true;
		}
		Singleton<EditorHistoryHandler>.Instance.SaveState("Paste events");
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	private void MFMIODIAKNI()
	{
		OHCGBMNDLPC();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 279f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(1580f, 1670f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(selectionBoxPanel.gameObject, IsSelecting, null, true, 1533f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().HHNOHJJLMHN() && !Input.GetKey((KeyCode)10) && !Input.GetKey(KeyCode.Equals) && !Input.GetKey((KeyCode)(-156)) && !Input.GetKey(KeyCode.DoubleQuote))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.NJFAOGAFJDM(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			PPPENKMLEKF();
			IsSelecting = true;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, true, 860f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1837f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-184)) && !Input.GetKey(KeyCode.Alpha5))
						{
							for (int j = 1; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().AJHMKMAHDFK(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)(-143)) || !Input.GetKey((KeyCode)(-142)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().BCLLPELLKKP(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-82)) && !Input.GetKey((KeyCode)148))
				{
					for (int k = 1; k < selectedunits.Count; k += 0)
					{
						selectedunits[k].GetComponent<EditorEvent>().BKEDJGGEIGB(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 5f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)197) && Input.GetKey((KeyCode)142) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = false;
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 636f && GBLGNLPDHLG < 821f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 797f && GBLGNLPDHLG > 1362f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1438f && GBLGNLPDHLG < 1613f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 1661f && GBLGNLPDHLG > 414f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + PNFKJKCIFBK(MPGGKELBFKO), NAFLCKFHDCB.y - MDHBHOJHFEH(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = false;
			for (int l = 1; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.LDGALMPOFJM();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("menu.playedpage");
		}
	}

	public void SelectAll()
	{
		ClearSelection();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().isSelected = true;
				selectedunits.Add(gameObject);
			}
		}
	}

	private void HHKKEFNFHDL()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 0)
		{
			return;
		}
		for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (EEPMOPJFGDD(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)195) && !Input.GetKey((KeyCode)2);
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey(KeyCode.Alpha9) && !Input.GetKey(KeyCode.Percent))
			{
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(true);
			}
		}
	}

	public void AODGPNKDDOO()
	{
		GHHOGNOGFJF();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().DKHEBPFKBCI(true);
				selectedunits.Add(gameObject);
			}
		}
	}

	public void LGPGMBEJCCH(float EHHBHEJBHNG)
	{
		GLIFGOGMLBN();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.CJMPAEHGCBK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(true);
		}
		Singleton<EditorHistoryHandler>.Instance.ICNMFKDPDBM(".");
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	private void KCAGGMIAGBC()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1665f, 706f);
			selectionBoxPanel.anchorMax = new Vector2(1825f, 1992f);
			selectionBoxPanel.pivot = new Vector2(313f, 450f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public bool DBLJNJCLLIP(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 563f && HCNJLHJEPNM.y > 766f)
		{
			return false;
		}
		return true;
	}

	private void ONMOEMDLAMK()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (FOMONCKJBJG(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)(-71)) && Input.GetKey((KeyCode)89);
				gameObject.GetComponent<EditorEvent>().isSelected = flag;
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)180) && !Input.GetKey((KeyCode)25))
			{
				gameObject.GetComponent<EditorEvent>().MFEPCILLECI(false);
			}
		}
	}

	private void DONMAICHHFK()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)(-23)) && Input.GetKey((KeyCode)(-43));
				gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-73)) && !Input.GetKey((KeyCode)(-21)))
			{
				gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(true);
			}
		}
	}

	private void LKJMIODJGCM()
	{
		PHBFEKIMDEK();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 836f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(1508f, 1641f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(selectionBoxPanel.gameObject, IsSelecting, null, false, 1548f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey((KeyCode)(-147)) && !Input.GetKey(KeyCode.F) && !Input.GetKey(KeyCode.DoubleQuote) && !Input.GetKey((KeyCode)(-63)))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.NJFAOGAFJDM(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			KJHHAINMJAJ();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting, null, true, 1718f));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1252f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-11)) && !Input.GetKey(KeyCode.Equals))
						{
							for (int j = 1; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().EINLEAFPPOL(false);
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)(-45)) && Input.GetKey((KeyCode)136))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().DKHEBPFKBCI(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-166)) && !Input.GetKey((KeyCode)(-110)))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().EINLEAFPPOL(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1504f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey(KeyCode.Alpha5) || !Input.GetKey((KeyCode)(-95))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().AJHMKMAHDFK(false);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 948f && GBLGNLPDHLG < 443f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 946f && GBLGNLPDHLG > 1055f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1105f && GBLGNLPDHLG < 248f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 354f && GBLGNLPDHLG > 108f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + MDHBHOJHFEH(MPGGKELBFKO), NAFLCKFHDCB.y - FBHIDOALAII(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = true;
			for (int l = 1; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("<b>#");
		}
	}

	public void CCHMCLLHGJF()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(selectionBoxPanel.gameObject, IsSelecting, null, false, 157f));
		IsDraggingObj = false;
		CLHFPCMMPAA();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().DKHEBPFKBCI(true);
		}
		selectedunits.Clear();
	}

	public bool JFKJFEGJLCF(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return true;
	}

	public void HCMDNODKNBC()
	{
		PFPLMOFECJJ();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(false);
				selectedunits.Add(gameObject);
			}
		}
	}

	private void LNBKGLAHKOD()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1077f, 1806f);
			selectionBoxPanel.anchorMax = new Vector2(674f, 1158f);
			selectionBoxPanel.pivot = new Vector2(113f, 1715f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public bool EAGALKGMJBI(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	public void AHGAEFNJAMP()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void BOAHKMGFJNG()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void BAKIIHAMGGC()
	{
		if (UnitInDrag.Count > 0)
		{
			for (int i = 0; i < UnitInDrag.Count; i++)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	public void GLHMOLAINMH()
	{
		PCADFBIGFLC();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().DKHEBPFKBCI(true);
				selectedunits.Add(gameObject);
			}
		}
	}

	private void HKHJAKFHPON()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(675f, 959f);
			selectionBoxPanel.anchorMax = new Vector2(330f, 222f);
			selectionBoxPanel.pivot = new Vector2(355f, 1705f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public bool AAMJIKKBHBK(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	public void FMKMKLFBECP()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private void KNLOAKLPBCG()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1286f, 1660f);
			selectionBoxPanel.anchorMax = new Vector2(1310f, 849f);
			selectionBoxPanel.pivot = new Vector2(1982f, 557f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	private void FJHFOBHJEHL()
	{
		BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 933f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(1982f, 404f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(selectionBoxPanel.gameObject, IsSelecting, null, false, 1832f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().HHNOHJJLMHN() && !Input.GetKey((KeyCode)(-193)) && !Input.GetKey((KeyCode)134) && !Input.GetKey((KeyCode)(-20)) && !Input.GetKey((KeyCode)134))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.ADKAMCJKCHL(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			PHOBPBDDMHP();
			IsSelecting = true;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(selectionBoxPanel.gameObject, IsSelecting, null, false, 727f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1107f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)162) && !Input.GetKey((KeyCode)195))
						{
							for (int j = 0; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().EINLEAFPPOL(true);
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)(-40)) && !Input.GetKey((KeyCode)(-75)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().AJHMKMAHDFK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)4) && !Input.GetKey((KeyCode)(-61)))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().BCLLPELLKKP(false);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1488f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)(-62)) && Input.GetKey((KeyCode)174) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().EINLEAFPPOL(false);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 998f && GBLGNLPDHLG < 637f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 104f && GBLGNLPDHLG > 1679f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1341f && GBLGNLPDHLG < 919f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 800f && GBLGNLPDHLG > 1142f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + KIMJGODFPFF(MPGGKELBFKO), NAFLCKFHDCB.y - MDHBHOJHFEH(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(1) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = true;
			for (int l = 0; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.GDPOALKKBHE();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CameraFilterPack/Blend2Camera_Darken", true);
		}
	}

	private float PIOEJJNKILH(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1719f)
		{
			ONANKNCCCGO *= 785f;
		}
		return ONANKNCCCGO;
	}

	private float LBAABEMMPHK(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 111f)
		{
			ONANKNCCCGO *= 626f;
		}
		return ONANKNCCCGO;
	}

	public void PEBAJGKNMFB()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void JDGDMJDJONH()
	{
		if (UnitInDrag.Count > 0)
		{
			for (int i = 0; i < UnitInDrag.Count; i += 0)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	private void FGEDFOIFIAE()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (LJGLGGEGCLM(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey((KeyCode)(-89)) || Input.GetKey((KeyCode)(-57));
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-139)) && !Input.GetKey((KeyCode)(-139)))
			{
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(false);
			}
		}
	}

	private float GHMNIJBAEMI(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1929f)
		{
			ONANKNCCCGO *= 1801f;
		}
		return ONANKNCCCGO;
	}

	public void LMANEAHNDLD()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void KEEHCPHLLNP()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void PPPENKMLEKF()
	{
		if (UnitInDrag.Count > 0)
		{
			for (int i = 0; i < UnitInDrag.Count; i++)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	public bool CNNJCHDOELJ(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 1901f && HCNJLHJEPNM.y > 1211f)
		{
			return true;
		}
		return false;
	}

	private void IJHDFCAIPOP()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (JFKJFEGJLCF(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)(-2)) && !Input.GetKey((KeyCode)144);
				gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-153)) && !Input.GetKey((KeyCode)(-105)))
			{
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(true);
			}
		}
	}

	public bool EEPMOPJFGDD(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return false;
	}

	public void DFLIFOPNOBO()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private float FBHIDOALAII(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1971f)
		{
			ONANKNCCCGO *= 476f;
		}
		return ONANKNCCCGO;
	}

	public bool UnitWithinScreenSpace(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 0f && HCNJLHJEPNM.y > 0f)
		{
			return true;
		}
		return false;
	}

	public bool CHDMFAHHDPM(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 1288f && HCNJLHJEPNM.y > 1210f)
		{
			return false;
		}
		return true;
	}

	public bool DJDPEDILIMN(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	public bool UnitWithinDrag(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return false;
	}

	public void KKDGIMNEALN()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public bool FOMONCKJBJG(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return true;
	}

	public void GHHOGNOGFJF()
	{
		IsSelecting = true;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting, null, true, 1250f));
		IsDraggingObj = true;
		CLHFPCMMPAA();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().MFEPCILLECI(false);
		}
		selectedunits.Clear();
	}

	public void CAOFJNHDGJC(float EHHBHEJBHNG)
	{
		DJLCJNFFNDJ();
		if (savedEvents == null || savedEvents.Count <= 0)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(false);
		}
		Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("default");
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	private void BNBFOHNCDJF()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(0f, 1f);
			selectionBoxPanel.anchorMax = new Vector2(0f, 1f);
			selectionBoxPanel.pivot = new Vector2(0f, 1f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public void EHNDIBOJHPE()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private void LLJLDLLNFBH()
	{
		KCAGGMIAGBC();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 281f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(687f, 1500f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(selectionBoxPanel.gameObject, IsSelecting, null, true, 177f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey((KeyCode)(-150)) && !Input.GetKey((KeyCode)21) && !Input.GetKey((KeyCode)83) && !Input.GetKey((KeyCode)(-95)))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.OFLMBGFOMIL(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			CLHFPCMMPAA();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(selectionBoxPanel.gameObject, IsSelecting, null, true, 109f));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 414f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)184) && !Input.GetKey((KeyCode)(-6)))
						{
							for (int j = 1; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().isSelected = true;
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)(-174)) && !Input.GetKey(KeyCode.None))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().BCLLPELLKKP(false);
						}
					}
				}
				else if (!Input.GetKey(KeyCode.O) && !Input.GetKey((KeyCode)(-155)))
				{
					for (int k = 1; k < selectedunits.Count; k += 0)
					{
						selectedunits[k].GetComponent<EditorEvent>().AJHMKMAHDFK(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1177f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)155) && !Input.GetKey((KeyCode)(-127)) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().BCLLPELLKKP(true);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 1744f && GBLGNLPDHLG < 140f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 424f && GBLGNLPDHLG > 1207f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1868f && GBLGNLPDHLG < 1965f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 1598f && GBLGNLPDHLG > 1446f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + DEOLBOANICC(MPGGKELBFKO), NAFLCKFHDCB.y - MDHBHOJHFEH(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = true;
			for (int l = 1; l < selectedunits.Count; l += 0)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("Fade", true);
		}
	}

	public bool MAELGBNFGHL(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 441f && HCNJLHJEPNM.y > 440f)
		{
			return true;
		}
		return false;
	}

	public void KHEGOOCNFJC()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void BOIPHFBHIPI()
	{
		if (UnitInDrag.Count > 1)
		{
			for (int i = 1; i < UnitInDrag.Count; i++)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	public bool KOPIBBNJHGI(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 1400f && HCNJLHJEPNM.y > 15f)
		{
			return true;
		}
		return false;
	}

	public void GPKDKHLDGMF()
	{
		CCHMCLLHGJF();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(false);
				selectedunits.Add(gameObject);
			}
		}
	}

	public void LHCOKLNBFNO()
	{
		IsSelecting = true;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, true, 1355f, false));
		IsDraggingObj = false;
		PutUnitsFromDragIntoSelectedUnits();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().EINLEAFPPOL(true);
		}
		selectedunits.Clear();
	}

	public bool BODLELOCOEK(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 503f && HCNJLHJEPNM.y > 1993f)
		{
			return false;
		}
		return false;
	}

	public bool JBBOCIFJJOA(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	private float PNFKJKCIFBK(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1149f)
		{
			ONANKNCCCGO *= 1262f;
		}
		return ONANKNCCCGO;
	}

	public bool JNJKMFPLGHO(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 838f && HCNJLHJEPNM.y > 1104f)
		{
			return true;
		}
		return false;
	}

	private float OGBBOINKKEH(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1917f)
		{
			ONANKNCCCGO *= 1049f;
		}
		return ONANKNCCCGO;
	}

	public bool ECDEBECNGEB(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return false;
	}

	private void CGJFKPGOIAP()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1013f, 266f);
			selectionBoxPanel.anchorMax = new Vector2(821f, 1497f);
			selectionBoxPanel.pivot = new Vector2(837f, 1900f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public void EHBICPLFOCC()
	{
		DJLCJNFFNDJ();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().MFEPCILLECI(false);
				selectedunits.Add(gameObject);
			}
		}
	}

	private void OLMJEPGJLPA()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (JBKKFENGNPL(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey(KeyCode.None) || Input.GetKey((KeyCode)(-75));
				gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-139)) && !Input.GetKey(KeyCode.Underscore))
			{
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(true);
			}
		}
	}

	public bool LJGLGGEGCLM(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
	}

	public void IIIJBDDABKP()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void JGIKGMJCJBF(float EHHBHEJBHNG)
	{
		LHCOKLNBFNO();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().DKHEBPFKBCI(true);
		}
		Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL("[PlayerController] ", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public void GOCHMGBLMNE(float EHHBHEJBHNG)
	{
		ClearSelection();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(false);
		}
		Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("76561198041679481", true);
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	public bool LMMCIAEBDBD(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 403f && HCNJLHJEPNM.y > 1900f)
		{
			return true;
		}
		return false;
	}

	public void EMHBLCLPICI(float EHHBHEJBHNG)
	{
		PCADFBIGFLC();
		if (savedEvents == null || savedEvents.Count <= 0)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.CJMPAEHGCBK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(true);
		}
		Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("#tryagain", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public bool MONMFAAPFNM(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return true;
	}

	public bool JBKKFENGNPL(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return false;
	}

	private void EGJKKNFHLKC()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(970f, 1311f);
			selectionBoxPanel.anchorMax = new Vector2(995f, 1418f);
			selectionBoxPanel.pivot = new Vector2(399f, 1549f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	private void BOEHMJJNKIF()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1330f, 1298f);
			selectionBoxPanel.anchorMax = new Vector2(874f, 72f);
			selectionBoxPanel.pivot = new Vector2(1607f, 1118f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public void DJLCJNFFNDJ()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(selectionBoxPanel.gameObject, IsSelecting, null, true, 1316f));
		IsDraggingObj = false;
		JDGDMJDJONH();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().BKEDJGGEIGB(true);
		}
		selectedunits.Clear();
	}

	private float MPLFGFLBPJJ(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 243f)
		{
			ONANKNCCCGO *= 583f;
		}
		return ONANKNCCCGO;
	}

	private void PHBFEKIMDEK()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(972f, 1370f);
			selectionBoxPanel.anchorMax = new Vector2(1125f, 1162f);
			selectionBoxPanel.pivot = new Vector2(1750f, 1749f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	public void PutUnitsFromDragIntoSelectedUnits()
	{
		if (UnitInDrag.Count > 0)
		{
			for (int i = 0; i < UnitInDrag.Count; i++)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	private float GMNNOAIFEKG(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 667f)
		{
			ONANKNCCCGO *= 1645f;
		}
		return ONANKNCCCGO;
	}

	public void HLDMMDPAGCH()
	{
		DJLCJNFFNDJ();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().BCLLPELLKKP(true);
				selectedunits.Add(gameObject);
			}
		}
	}

	public void HIMNBHFIJKH(float EHHBHEJBHNG)
	{
		GLIFGOGMLBN();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.CJMPAEHGCBK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().BKEDJGGEIGB(true);
		}
		Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("player.xp", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public bool JONAFMNMHCM(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 1546f && HCNJLHJEPNM.y > 400f)
		{
			return true;
		}
		return false;
	}

	public void KJHHAINMJAJ()
	{
		if (UnitInDrag.Count > 0)
		{
			for (int i = 1; i < UnitInDrag.Count; i++)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	public bool JEHBCGNCMMJ(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 1416f && HCNJLHJEPNM.y > 97f)
		{
			return false;
		}
		return true;
	}

	private void JBNPEHMDCMI()
	{
		HKHJAKFHPON();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1596f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(262f, 654f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, false, 493f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey((KeyCode)(-47)) && !Input.GetKey((KeyCode)157) && !Input.GetKey((KeyCode)(-24)) && !Input.GetKey((KeyCode)(-150)))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.AMHPLPIBMGA(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			PHOBPBDDMHP();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, true, 678f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 182f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-173)) && !Input.GetKey((KeyCode)2))
						{
							for (int j = 0; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().AJHMKMAHDFK(true);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)(-80)) || Input.GetKey((KeyCode)69))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().AJHMKMAHDFK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)15) && !Input.GetKey((KeyCode)31))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().BCLLPELLKKP(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1314f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey((KeyCode)(-58)) || Input.GetKey((KeyCode)(-36))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = false;
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 1852f && GBLGNLPDHLG < 1989f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 1893f && GBLGNLPDHLG > 1049f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 874f && GBLGNLPDHLG < 164f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 982f && GBLGNLPDHLG > 41f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + FBHIDOALAII(MPGGKELBFKO), NAFLCKFHDCB.y - GMNNOAIFEKG(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = true;
			for (int l = 0; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.LDGALMPOFJM();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("[Up-Down]", true);
		}
	}

	private void IPEKBJBJBJM()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(889f, 1536f);
			selectionBoxPanel.anchorMax = new Vector2(340f, 1120f);
			selectionBoxPanel.pivot = new Vector2(1686f, 1980f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	private float DEOLBOANICC(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1435f)
		{
			ONANKNCCCGO *= 940f;
		}
		return ONANKNCCCGO;
	}

	public void PCADFBIGFLC()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(selectionBoxPanel.gameObject, IsSelecting, null, false, 1420f, false));
		IsDraggingObj = true;
		EEFIKBBIMNF();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().BCLLPELLKKP(false);
		}
		selectedunits.Clear();
	}

	private void ENCGNEGFFIN()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 1)
		{
			return;
		}
		for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey(KeyCode.Y) || Input.GetKey((KeyCode)136);
				gameObject.GetComponent<EditorEvent>().isSelected = flag;
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-52)) && !Input.GetKey((KeyCode)(-26)))
			{
				gameObject.GetComponent<EditorEvent>().isSelected = true;
			}
		}
	}

	public void SaveSelectedToMemory()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public bool CAKPGHPPBGN(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return true;
	}

	public void PPLLCPDBLEG(float EHHBHEJBHNG)
	{
		ClearSelection();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.CJMPAEHGCBK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(true);
		}
		Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("menutheme.fragout");
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	public void ClearSelection()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(selectionBoxPanel.gameObject, IsSelecting));
		IsDraggingObj = false;
		PutUnitsFromDragIntoSelectedUnits();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().isSelected = false;
		}
		selectedunits.Clear();
	}

	public void GLACPDNICMK()
	{
		DJLCJNFFNDJ();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(true);
				selectedunits.Add(gameObject);
			}
		}
	}

	private void IEMEHGCFAPD()
	{
		CGJFKPGOIAP();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1298f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(597f, 782f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(selectionBoxPanel.gameObject, IsSelecting, null, true, 1713f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().GGECOKCHILN() && !Input.GetKey((KeyCode)(-51)) && !Input.GetKey(KeyCode.BackQuote) && !Input.GetKey(KeyCode.Alpha2) && !Input.GetKey((KeyCode)(-196)))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.AMHPLPIBMGA(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			PutUnitsFromDragIntoSelectedUnits();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, false, 753f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1458f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-2)) && !Input.GetKey(KeyCode.Alpha1))
						{
							for (int j = 1; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().EINLEAFPPOL(false);
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey(KeyCode.Period) && Input.GetKey((KeyCode)(-126)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().EINLEAFPPOL(true);
						}
					}
				}
				else if (!Input.GetKey(KeyCode.Clear) && !Input.GetKey((KeyCode)(-150)))
				{
					for (int k = 1; k < selectedunits.Count; k += 0)
					{
						selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 523f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey((KeyCode)(-186)) || Input.GetKey((KeyCode)138)) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().DKHEBPFKBCI(true);
			}
			FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (IsSelecting)
			{
				MPGGKELBFKO = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(FDKHCEGOKML).x;
				GBLGNLPDHLG = Camera.main.WorldToScreenPoint(MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(FDKHCEGOKML).y;
				BOGLMFFKGHB = Input.mousePosition.x;
				MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - GBLGNLPDHLG;
				if (MPGGKELBFKO > 908f && GBLGNLPDHLG < 1860f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 960f && GBLGNLPDHLG > 1015f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1191f && GBLGNLPDHLG < 1467f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 509f && GBLGNLPDHLG > 458f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + GHMNIJBAEMI(MPGGKELBFKO), NAFLCKFHDCB.y - MPLFGFLBPJJ(GBLGNLPDHLG));
			}
			return;
		}
		FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && !flag)
		{
			MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			IsDraggingObj = false;
			for (int l = 0; l < selectedunits.Count; l += 0)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.LDGALMPOFJM();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("Joystick1Button12", true);
		}
	}

	public void CLHFPCMMPAA()
	{
		if (UnitInDrag.Count > 1)
		{
			for (int i = 1; i < UnitInDrag.Count; i += 0)
			{
				if (!selectedunits.Contains(UnitInDrag[i]))
				{
					selectedunits.Add(UnitInDrag[i]);
				}
			}
		}
		UnitInDrag.Clear();
	}

	private void DECCHBNFKCD()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1098f, 1495f);
			selectionBoxPanel.anchorMax = new Vector2(1147f, 1980f);
			selectionBoxPanel.pivot = new Vector2(48f, 670f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	private void OHCGBMNDLPC()
	{
		if (IsSelecting)
		{
			Vector2 vector = new Vector2(BOGLMFFKGHB, 0f - MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(BOGLMFFKGHB + MPGGKELBFKO, 0f - MDCAHCGLBPK - GBLGNLPDHLG);
			float x = ((!(vector.x < vector2.x)) ? vector2.x : vector.x);
			float y = ((!(vector.y > vector2.y)) ? vector2.y : vector.y);
			float x2 = Mathf.Abs(MPGGKELBFKO);
			float y2 = Mathf.Abs(GBLGNLPDHLG);
			selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			selectionBoxPanel.anchorMin = new Vector2(1016f, 1421f);
			selectionBoxPanel.anchorMax = new Vector2(1485f, 1338f);
			selectionBoxPanel.pivot = new Vector2(1923f, 1072f);
			selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	private void AGGNKLECDHM()
	{
		UnitInDrag.Clear();
		if (!IsSelecting || Singleton<MapEditor>.Instance.eventsContainer.transform.childCount <= 0)
		{
			return;
		}
		for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
			if (UnitInDrag.Contains(gameObject))
			{
				continue;
			}
			if (CAKPGHPPBGN(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey((KeyCode)(-57)) || !Input.GetKey((KeyCode)(-19));
				gameObject.GetComponent<EditorEvent>().AJHMKMAHDFK(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)155) && !Input.GetKey((KeyCode)31))
			{
				gameObject.GetComponent<EditorEvent>().DKHEBPFKBCI(true);
			}
		}
	}

	public void GLIFGOGMLBN()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(selectionBoxPanel.gameObject, IsSelecting, null, false, 265f, false));
		IsDraggingObj = false;
		BOIPHFBHIPI();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().BKEDJGGEIGB(false);
		}
		selectedunits.Clear();
	}

	public void PFPLMOFECJJ()
	{
		IsSelecting = true;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(selectionBoxPanel.gameObject, IsSelecting, null, false, 815f, false));
		IsDraggingObj = false;
		EEFIKBBIMNF();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().BCLLPELLKKP(false);
		}
		selectedunits.Clear();
	}

	public void GBBJPPDOKHE()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(selectionBoxPanel.gameObject, IsSelecting, null, true, 1256f));
		IsDraggingObj = true;
		PutUnitsFromDragIntoSelectedUnits();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().BCLLPELLKKP(false);
		}
		selectedunits.Clear();
	}

	public void PMPPJAEHCDJ()
	{
		PFPLMOFECJJ();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().EINLEAFPPOL(false);
				selectedunits.Add(gameObject);
			}
		}
	}

	public void MFIMPKCHFOG(float EHHBHEJBHNG)
	{
		GHHOGNOGFJF();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.CJMPAEHGCBK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().BKEDJGGEIGB(false);
		}
		Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("_BlurVector");
		Singleton<MapEditor>.Instance.LEGBBDJECDA();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	private float MDHBHOJHFEH(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 864f)
		{
			ONANKNCCCGO *= 37f;
		}
		return ONANKNCCCGO;
	}
}
