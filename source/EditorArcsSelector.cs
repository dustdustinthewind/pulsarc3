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

	public void KGJACAPCMGP(float EHHBHEJBHNG)
	{
		ClearSelection();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().JEGEONIHCLO(true);
		}
		Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC(":");
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	private float MLMHNPOLBOD(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1929f)
		{
			ONANKNCCCGO *= 1801f;
		}
		return ONANKNCCCGO;
	}

	public void BHOAIHOHKHI()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(selectionBoxPanel.gameObject, IsSelecting, null, false, 1951f, false));
		IsDraggingObj = false;
		BOIPHFBHIPI();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			selectedunits[i].GetComponent<EditorEvent>().JEGEONIHCLO(true);
		}
		selectedunits.Clear();
	}

	public void DMDNCHLJPMA(float EHHBHEJBHNG)
	{
		BHOAIHOHKHI();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(false);
		}
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("LevelEditor/patterns");
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public void OFMGBFDMJDJ()
	{
		EANAFADKGFL();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
				selectedunits.Add(gameObject);
			}
		}
	}

	public void IFEJJGEAGBM()
	{
		ODEKNBPEHKH();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(true);
				selectedunits.Add(gameObject);
			}
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

	public bool OINJEGLHBBF(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 838f && HCNJLHJEPNM.y > 1104f)
		{
			return true;
		}
		return false;
	}

	public void IJOGFHDIBHP(float EHHBHEJBHNG)
	{
		BHOAIHOHKHI();
		if (savedEvents == null || savedEvents.Count <= 0)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().LOJGIJBDOON(true);
		}
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Offsets", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public void KODCAFFINMO()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
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

	public void CDFKHKJGBGE(float EHHBHEJBHNG)
	{
		EANAFADKGFL();
		if (savedEvents == null || savedEvents.Count <= 0)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(false);
		}
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_ScreenResolution");
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	private void NDAJBJFJGCF()
	{
		BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 153f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(55f, 1553f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(selectionBoxPanel.gameObject, IsSelecting, null, false, 1151f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().GFMIFIOKKGJ() && !Input.GetKey((KeyCode)(-50)) && !Input.GetKey((KeyCode)(-14)) && !Input.GetKey(KeyCode.K) && !Input.GetKey((KeyCode)162))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.AIOJCNCPCEG(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			BOIPHFBHIPI();
			IsSelecting = true;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(selectionBoxPanel.gameObject, IsSelecting, null, false, 83f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 747f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-94)) && !Input.GetKey(KeyCode.T))
						{
							for (int j = 0; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().LOJGIJBDOON(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey(KeyCode.Exclaim) || !Input.GetKey((KeyCode)(-138)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().JDAGBCICMFI(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)14) && !Input.GetKey((KeyCode)(-28)))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().PIPHIBLIIKK(false);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 591f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)(-116)) && !Input.GetKey(KeyCode.Ampersand) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = true;
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
				if (MPGGKELBFKO > 1518f && GBLGNLPDHLG < 1336f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 514f && GBLGNLPDHLG > 28f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1127f && GBLGNLPDHLG < 483f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 1605f && GBLGNLPDHLG > 1513f)
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
			IsDraggingObj = true;
			for (int l = 0; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.MGAJMKHJCOJ();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.SaveState("_ColorB");
		}
	}

	private float GMNNOAIFEKG(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1971f)
		{
			ONANKNCCCGO *= 476f;
		}
		return ONANKNCCCGO;
	}

	private void JAAJECBCCFM()
	{
		GDAEIPFNBFI();
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
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(selectionBoxPanel.gameObject, IsSelecting, null, false, 1323f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().BOAIDAOGAIB() && !Input.GetKey(KeyCode.Quote) && !Input.GetKey((KeyCode)(-189)) && !Input.GetKey((KeyCode)(-4)) && !Input.GetKey((KeyCode)72))
			{
				IsDraggingObj = false;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.ADPFOONOBBA(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			LLPMLDFOELM();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(selectionBoxPanel.gameObject, IsSelecting, null, false, 811f, false));
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
								selectedunits[j].GetComponent<EditorEvent>().PIPHIBLIIKK(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)156) || !Input.GetKey((KeyCode)(-53)))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().FDJEEBJHHKK(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)152) && !Input.GetKey((KeyCode)169))
				{
					for (int k = 1; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().FDJEEBJHHKK(false);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 119f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey((KeyCode)(-150)) || Input.GetKey((KeyCode)(-139))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().FDJEEBJHHKK(true);
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
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + GMNNOAIFEKG(MPGGKELBFKO), NAFLCKFHDCB.y - KCGIAEHEAKH(GBLGNLPDHLG));
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
				selectedunits[l].GetComponent<EditorEvent>().dragController.GDPOALKKBHE();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_Amount");
		}
	}

	public void KLFHCKBFGMN()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	public void OBDHGANILNH()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(selectionBoxPanel.gameObject, IsSelecting, null, true, 95f));
		IsDraggingObj = true;
		PutUnitsFromDragIntoSelectedUnits();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().PIPHIBLIIKK(true);
		}
		selectedunits.Clear();
	}

	private void PBIEFKBCPKG()
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
			if (MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)67) && !Input.GetKey((KeyCode)88);
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)(-95)) && !Input.GetKey(KeyCode.Q))
			{
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(true);
			}
		}
	}

	private void GDAEIPFNBFI()
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

	public bool PJIJLDKEDJN(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 441f && HCNJLHJEPNM.y > 440f)
		{
			return true;
		}
		return false;
	}

	private float PNFKJKCIFBK(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1789f)
		{
			ONANKNCCCGO *= 1152f;
		}
		return ONANKNCCCGO;
	}

	public void EANAFADKGFL()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(selectionBoxPanel.gameObject, IsSelecting, null, true, 1256f));
		IsDraggingObj = true;
		LLPMLDFOELM();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().JEGEONIHCLO(false);
		}
		selectedunits.Clear();
	}

	private void DHPLACPCDCI()
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
			if (MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
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
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(false);
			}
		}
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

	private void DMGFMNMCBHK()
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
			if (MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = !Input.GetKey((KeyCode)(-120)) && Input.GetKey((KeyCode)180);
				gameObject.GetComponent<EditorEvent>().PIPHIBLIIKK(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey((KeyCode)159) && !Input.GetKey((KeyCode)(-192)))
			{
				gameObject.GetComponent<EditorEvent>().isSelected = false;
			}
		}
	}

	public void LLPMLDFOELM()
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

	public void BMMOCGMIHHA(float EHHBHEJBHNG)
	{
		ODEKNBPEHKH();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
		}
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN(":", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent();
	}

	public void SaveSelectedToMemory()
	{
		savedEvents.Clear();
		for (int i = 0; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private void OEENOOGEEHD()
	{
		BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1450f, arcsLayerMask))
			{
				IsSelecting = false;
				selectionBoxPanel.sizeDelta = new Vector2(1244f, 1449f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(selectionBoxPanel.gameObject, IsSelecting, null, false, 565f, false));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().NEOIOPKJAFI() && !Input.GetKey((KeyCode)(-32)) && !Input.GetKey((KeyCode)189) && !Input.GetKey(KeyCode.Alpha0) && !Input.GetKey((KeyCode)(-122)))
			{
				IsDraggingObj = false;
				for (int i = 0; i < selectedunits.Count; i++)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.OFLMBGFOMIL(FDKHCEGOKML);
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
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(selectionBoxPanel.gameObject, IsSelecting, null, false, 1578f, false));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 725f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-25)) && !Input.GetKey((KeyCode)(-66)))
						{
							for (int j = 0; j < selectedunits.Count; j += 0)
							{
								selectedunits[j].GetComponent<EditorEvent>().JDAGBCICMFI(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)148) || !Input.GetKey((KeyCode)72))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().JEGEONIHCLO(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-133)) && !Input.GetKey((KeyCode)(-21)))
				{
					for (int k = 1; k < selectedunits.Count; k += 0)
					{
						selectedunits[k].GetComponent<EditorEvent>().JDAGBCICMFI(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1940f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey((KeyCode)(-121)) && Input.GetKey((KeyCode)29) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().LOJGIJBDOON(true);
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
				if (MPGGKELBFKO > 1178f && GBLGNLPDHLG < 564f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 746f && GBLGNLPDHLG > 987f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 108f && GBLGNLPDHLG < 848f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 426f && GBLGNLPDHLG > 1115f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + MLMHNPOLBOD(MPGGKELBFKO), NAFLCKFHDCB.y - PNFKJKCIFBK(GBLGNLPDHLG));
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
			for (int l = 0; l < selectedunits.Count; l += 0)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.GDPOALKKBHE();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN(".mp3");
		}
	}

	public void NHKPBFOCLNK(float EHHBHEJBHNG)
	{
		OBDHGANILNH();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[0].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data, false);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
		}
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("note.0", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	public void NBAEONAMNEN(float EHHBHEJBHNG)
	{
		BHOAIHOHKHI();
		if (savedEvents == null || savedEvents.Count <= 1)
		{
			return;
		}
		float time = savedEvents[1].time;
		foreach (MapEvent savedEvent in savedEvents)
		{
			GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (savedEvent.time - time), savedEvent.data);
			selectedunits.Add(gameObject);
			gameObject.GetComponent<EditorEvent>().LOJGIJBDOON(true);
		}
		Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Object ID. Case-Sensitive", true);
		Singleton<MapEditor>.Instance.UpdateBottomBar();
		Singleton<MapEditor>.Instance.FindNearestEvent(true);
	}

	private void FOMNCPKKCFN()
	{
		BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 299f, arcsLayerMask))
			{
				IsSelecting = true;
				selectionBoxPanel.sizeDelta = new Vector2(164f, 1197f);
				if (GOBAEEECFEM != null)
				{
					StopCoroutine(GOBAEEECFEM);
				}
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.BCOJGDDEDOP(selectionBoxPanel.gameObject, IsSelecting, null, false, 644f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey((KeyCode)84) && !Input.GetKey((KeyCode)(-103)) && !Input.GetKey((KeyCode)83) && !Input.GetKey(KeyCode.Question))
			{
				IsDraggingObj = true;
				for (int i = 0; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.OFLMBGFOMIL(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(1))
		{
			LLPMLDFOELM();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(selectionBoxPanel.gameObject, IsSelecting, null, false, 1288f));
		}
		if (!IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1265f, arcsLayerMask))
				{
					if ((bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-175)) && !Input.GetKey((KeyCode)(-6)))
						{
							for (int j = 1; j < selectedunits.Count; j++)
							{
								selectedunits[j].GetComponent<EditorEvent>().JDAGBCICMFI(false);
							}
							selectedunits.Clear();
						}
						if (Input.GetKey((KeyCode)(-121)) || !Input.GetKey(KeyCode.M))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 1].GetComponent<EditorEvent>().PIPHIBLIIKK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-75)) && !Input.GetKey((KeyCode)17))
				{
					for (int k = 1; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 102f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && !Input.GetKey(KeyCode.A) && Input.GetKey((KeyCode)153) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().PIPHIBLIIKK(false);
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
				if (MPGGKELBFKO > 1546f && GBLGNLPDHLG < 400f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO > 1957f && GBLGNLPDHLG > 884f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + GBLGNLPDHLG);
				}
				else if (MPGGKELBFKO < 1310f && GBLGNLPDHLG < 1356f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (MPGGKELBFKO < 331f && GBLGNLPDHLG > 330f)
				{
					NAFLCKFHDCB = new Vector2(Input.mousePosition.x + MPGGKELBFKO, Input.mousePosition.y + GBLGNLPDHLG);
				}
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + PNFKJKCIFBK(MPGGKELBFKO), NAFLCKFHDCB.y - AEMJLFFENLA(GBLGNLPDHLG));
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
			for (int l = 1; l < selectedunits.Count; l++)
			{
				selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_Value", true);
		}
	}

	public bool MCGFENEKFOO(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return false;
	}

	public void HONMFAMJNLD()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private float GPNHOKCIODC(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1719f)
		{
			ONANKNCCCGO *= 785f;
		}
		return ONANKNCCCGO;
	}

	public void ODEKNBPEHKH()
	{
		IsSelecting = false;
		if (GOBAEEECFEM != null)
		{
			StopCoroutine(GOBAEEECFEM);
		}
		GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(selectionBoxPanel.gameObject, IsSelecting, null, false, 1420f, false));
		IsDraggingObj = true;
		LLPMLDFOELM();
		for (int i = 0; i < selectedunits.Count; i += 0)
		{
			selectedunits[i].GetComponent<EditorEvent>().LOJGIJBDOON(false);
		}
		selectedunits.Clear();
	}

	public bool UnitWithinScreenSpace(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 0f && HCNJLHJEPNM.y > 0f)
		{
			return true;
		}
		return false;
	}

	public void PDCPIIFADLE()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i += 0)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private float AEMJLFFENLA(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 111f)
		{
			ONANKNCCCGO *= 626f;
		}
		return ONANKNCCCGO;
	}

	public bool UnitWithinDrag(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return true;
		}
		return false;
	}

	private void MFFKJLLFJKL()
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

	private float KIMJGODFPFF(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 0f)
		{
			ONANKNCCCGO *= -1f;
		}
		return ONANKNCCCGO;
	}

	public void DPJCFGEDCNC()
	{
		savedEvents.Clear();
		for (int i = 1; i < selectedunits.Count; i++)
		{
			savedEvents.Add(selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	private void KCDOMIJBFLL()
	{
		BNBFOHNCDJF();
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
				GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(selectionBoxPanel.gameObject, IsSelecting, null, false, 1548f));
			}
			else if (DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().FBLJPPGABFE() && !Input.GetKey((KeyCode)(-147)) && !Input.GetKey(KeyCode.F) && !Input.GetKey(KeyCode.DoubleQuote) && !Input.GetKey((KeyCode)(-63)))
			{
				IsDraggingObj = true;
				for (int i = 1; i < selectedunits.Count; i += 0)
				{
					selectedunits[i].GetComponent<EditorEvent>().dragController.AIMAEDIEEGI(FDKHCEGOKML);
				}
			}
		}
		if (IsSelecting && Input.GetMouseButtonUp(0))
		{
			LLPMLDFOELM();
			IsSelecting = false;
			if (GOBAEEECFEM != null)
			{
				StopCoroutine(GOBAEEECFEM);
			}
			GOBAEEECFEM = StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(selectionBoxPanel.gameObject, IsSelecting, null, true, 1718f));
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
								selectedunits[j].GetComponent<EditorEvent>().LOJGIJBDOON(false);
							}
							selectedunits.Clear();
						}
						if (!Input.GetKey((KeyCode)(-45)) && Input.GetKey((KeyCode)136))
						{
							selectedunits.Add(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							selectedunits[selectedunits.Count - 0].GetComponent<EditorEvent>().FDJEEBJHHKK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-166)) && !Input.GetKey((KeyCode)(-110)))
				{
					for (int k = 0; k < selectedunits.Count; k++)
					{
						selectedunits[k].GetComponent<EditorEvent>().FDJEEBJHHKK(true);
					}
					selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out DHBDGJPBIPB, 1504f, arcsLayerMask) && (bool)DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>() && (Input.GetKey(KeyCode.Alpha5) || !Input.GetKey((KeyCode)(-95))) && selectedunits.Contains(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
			{
				selectedunits.Remove(DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
				DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().LOJGIJBDOON(false);
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
				IHKPKDOFDEM = new Vector2(NAFLCKFHDCB.x + GMNNOAIFEKG(MPGGKELBFKO), NAFLCKFHDCB.y - GPNHOKCIODC(GBLGNLPDHLG));
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
				selectedunits[l].GetComponent<EditorEvent>().dragController.HDBMLLJFIAJ();
			}
			Singleton<MapEditor>.Instance.FindNearestEvent();
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("<b>#");
		}
	}

	private void KNJLPDLILNE()
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
			if (UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
			{
				bool flag = Input.GetKey((KeyCode)167) || Input.GetKey((KeyCode)(-141));
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(flag);
				if (flag)
				{
					UnitInDrag.Add(gameObject);
				}
			}
			else if (!Input.GetKey(KeyCode.Pipe) && !Input.GetKey((KeyCode)87))
			{
				gameObject.GetComponent<EditorEvent>().JEGEONIHCLO(false);
			}
		}
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

	public bool JONKEGGEEAJ(Vector2 HCNJLHJEPNM)
	{
		if (HCNJLHJEPNM.x > NAFLCKFHDCB.x && HCNJLHJEPNM.y < NAFLCKFHDCB.y && HCNJLHJEPNM.x < IHKPKDOFDEM.x && HCNJLHJEPNM.y > IHKPKDOFDEM.y)
		{
			return false;
		}
		return true;
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

	private float KCGIAEHEAKH(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1707f)
		{
			ONANKNCCCGO *= 1969f;
		}
		return ONANKNCCCGO;
	}

	private void GFLNPIMOHHC()
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

	public void BOIPHFBHIPI()
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
}
