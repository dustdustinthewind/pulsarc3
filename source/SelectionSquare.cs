// SelectionSquare
using System;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSquare : MonoBehaviour
{
	public RectTransform selectionSquareTrans;

	public Transform sphere1;

	public Transform sphere2;

	public Transform sphere3;

	public Transform sphere4;

	public Material normalMaterial;

	public Material highlightMaterial;

	public Material selectedMaterial;

	[NonSerialized]
	public List<GameObject> selectedUnits = new List<GameObject>();

	private GameObject OBCOCNICLKP;

	private float KMDMAONLAPB = 0.3f;

	private float FIKPGAEAEAG;

	private Vector3 FHMDDCEDGJC;

	private Vector3 FFCFGCIOLCI;

	private bool OHFPIMDOPLD;

	private Vector3 BOPPMKAHKJP;

	private Vector3 HGDIBPDFPBA;

	private Vector3 JLNJGFBKHEN;

	private Vector3 FEEGAAPJDGP;

	private void NFEDLAOPHML()
	{
		FEBFOIEDBPD();
		OIBAPILGHON();
	}

	private void GBBHAODFFMB()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < FGGPCFECJKO().Length; i++)
				{
					GameObject gameObject = PECKJHJEKKI()[i].gameObject;
					if (IGECAHIPOMM(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 774f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(false);
		}
		FFCFGCIOLCI = Input.mousePosition;
		HFKBNIGIJKD();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < FOPJGKMMDJB().Length; k++)
		{
			GameObject gameObject3 = IBIKJMDDKHI()[k].gameObject;
			if (JCOBFNLNNLL(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private bool DCPGCHDBPKP(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 792f - num2 - num3;
		if (num2 >= 693f && num2 <= 200f && num3 >= 478f && num3 <= 1549f && num4 >= 1783f && num4 <= 483f)
		{
			result = true;
		}
		return result;
	}

	private void CCCJHCJFHMF()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < NCHJDNPOGGJ().Length; i += 0)
				{
					GameObject gameObject = GetAllUnits()[i].gameObject;
					if (MLPGFGBEGIM(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(1) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 934f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(false);
		}
		FFCFGCIOLCI = Input.mousePosition;
		HFKBNIGIJKD();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < LHPLNIBDAJE().Length; k += 0)
		{
			GameObject gameObject3 = DKHJLMDJBIL()[k].gameObject;
			if (KFBAOFOIBFE(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void PIPCNJOHIHA()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1537f;
		FFCFGCIOLCI.z = 793f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1688f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 13f, position.y + num2 / 1323f, 633f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1662f, position.y + num2 / 873f, 1179f);
		JLNJGFBKHEN = new Vector3(position.x - num / 313f, position.y - num2 / 1741f, 1244f);
		FEEGAAPJDGP = new Vector3(position.x + num / 672f, position.y - num2 / 1729f, 1934f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 863f, 132))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1142f, 97))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 130f, 174))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1032f, -189))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 3)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void LPMINJJPDCH()
	{
		NHODGNHIOEN();
		GMDGLNGHNOI();
	}

	private bool IJMHNFHKFJM(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (BCIFAFCMDCO(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (DDNFEFACMIC(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void GNJOMFGHFPA()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 0; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 200f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 0; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	public EditorEvent[] PECKJHJEKKI()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool KFBAOFOIBFE(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (LINCDHACHEI(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (DEECPEGNGIF(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void Start()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void PKGJBLMOAKJ()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 1; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1534f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = true;
		for (int j = 1; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private bool LNPDBEBGHAJ(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1f - num2 - num3;
		if (num2 >= 0f && num2 <= 1f && num3 >= 0f && num3 <= 1f && num4 >= 0f && num4 <= 1f)
		{
			result = true;
		}
		return result;
	}

	private void OCDOOEGLHFB()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 1; i < FGGPCFECJKO().Length; i++)
				{
					GameObject gameObject = PECKJHJEKKI()[i].gameObject;
					if (JENMHFOECOF(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 367f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(false);
		}
		FFCFGCIOLCI = Input.mousePosition;
		PAHMNEINEFE();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < FOPJGKMMDJB().Length; k++)
		{
			GameObject gameObject3 = FGGPCFECJKO()[k].gameObject;
			if (JENMHFOECOF(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] IBIKJMDDKHI()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void PKEHAFGKGBC()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1527f;
		FFCFGCIOLCI.z = 1525f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1603f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1609f, position.y + num2 / 1562f, 1014f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1462f, position.y + num2 / 973f, 669f);
		JLNJGFBKHEN = new Vector3(position.x - num / 132f, position.y - num2 / 1572f, 1483f);
		FEEGAAPJDGP = new Vector3(position.x + num / 437f, position.y - num2 / 455f, 451f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 605f, -31))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 796f, 195))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 713f, -137))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1393f, 20))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 0)
		{
			OHFPIMDOPLD = false;
		}
	}

	private bool LINCDHACHEI(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1941f - num2 - num3;
		if (num2 >= 72f && num2 <= 1454f && num3 >= 1495f && num3 <= 403f && num4 >= 1928f && num4 <= 437f)
		{
			result = true;
		}
		return result;
	}

	private void FEBFOIEDBPD()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < IMMBLBJFEMK().Length; i++)
				{
					GameObject gameObject = HDHNEMLJCAH()[i].gameObject;
					if (BAFFLCEJJLG(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(1) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1658f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(false);
		}
		FFCFGCIOLCI = Input.mousePosition;
		HFKBNIGIJKD();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < LHPLNIBDAJE().Length; k += 0)
		{
			GameObject gameObject3 = MDMDOOCAMFA()[k].gameObject;
			if (LBFBDCPOBKF(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void PAHMNEINEFE()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1789f;
		FFCFGCIOLCI.z = 990f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 827f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 12f, position.y + num2 / 1171f, 367f);
		HGDIBPDFPBA = new Vector3(position.x + num / 215f, position.y + num2 / 1452f, 1985f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1176f, position.y - num2 / 1950f, 1405f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1735f, position.y - num2 / 87f, 1741f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 132f, 15))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 204f, 145))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 386f, -95))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 372f, -67))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 7)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void EANFBJOFAEJ()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 330f;
		FFCFGCIOLCI.z = 1377f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1780f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 867f, position.y + num2 / 243f, 1062f);
		HGDIBPDFPBA = new Vector3(position.x + num / 655f, position.y + num2 / 1284f, 1309f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1123f, position.y - num2 / 368f, 826f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1782f, position.y - num2 / 1753f, 1148f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1042f, -42))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1690f, 50))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 253f, -33))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1886f, 142))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = true;
		if (num3 == 2)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void HNAAGAHOONB()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1359f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = true;
		for (int j = 0; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private bool GPEHOEJEBDD(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 548f - num2 - num3;
		if (num2 >= 1707f && num2 <= 1929f && num3 >= 1825f && num3 <= 1748f && num4 >= 355f && num4 <= 1992f)
		{
			result = true;
		}
		return result;
	}

	private bool BAFFLCEJJLG(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (DEECPEGNGIF(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (LINCDHACHEI(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	public EditorEvent[] NCHJDNPOGGJ()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void LONGDPHGFDE()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 627f;
		FFCFGCIOLCI.z = 1478f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1371f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 694f, position.y + num2 / 892f, 1154f);
		HGDIBPDFPBA = new Vector3(position.x + num / 123f, position.y + num2 / 1875f, 1802f);
		JLNJGFBKHEN = new Vector3(position.x - num / 262f, position.y - num2 / 290f, 1474f);
		FEEGAAPJDGP = new Vector3(position.x + num / 995f, position.y - num2 / 1400f, 615f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 423f, 70))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 567f, -4))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 864f, -37))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 796f, 155))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 3)
		{
			OHFPIMDOPLD = false;
		}
	}

	private bool HAEPIAHPIPF(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 270f - num2 - num3;
		if (num2 >= 433f && num2 <= 526f && num3 >= 1622f && num3 <= 1805f && num4 >= 1028f && num4 <= 1607f)
		{
			result = true;
		}
		return result;
	}

	private bool CDPGKCNOEFJ(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (LNPDBEBGHAJ(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (LNPDBEBGHAJ(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void MGMAOBPPOBJ()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	public EditorEvent[] LHPLNIBDAJE()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void AEOLJEIDMDB()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool OAMEFAIBGHC(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (LNPDBEBGHAJ(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (PLKKPJFIKIA(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void HFKBNIGIJKD()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 714f;
		FFCFGCIOLCI.z = 458f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 236f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 917f, position.y + num2 / 281f, 1730f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1933f, position.y + num2 / 1642f, 1687f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1929f, position.y - num2 / 1761f, 279f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1515f, position.y - num2 / 877f, 1486f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 483f, 8))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 49f, 33))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 437f, 140))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 527f, 100))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 2)
		{
			OHFPIMDOPLD = false;
		}
	}

	public EditorEvent[] FOPJGKMMDJB()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool MFCPLCCGPPA(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (GPEHOEJEBDD(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (PJFDBKECGFB(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void DFFKKLAPHCC()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	public EditorEvent[] FAFFFMPAADB()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void LMOCEBHMKKO()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < HDHNEMLJCAH().Length; i++)
				{
					GameObject gameObject = MLNBNCBEAMH()[i].gameObject;
					if (IJMHNFHKFJM(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1613f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		OCIHFNFIIIH();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < IBIKJMDDKHI().Length; k += 0)
		{
			GameObject gameObject3 = DKHJLMDJBIL()[k].gameObject;
			if (KFBAOFOIBFE(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void DGCGGKMNPLD()
	{
		CCCJHCJFHMF();
		GNJOMFGHFPA();
	}

	private bool LEMEGPNDHMG(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 985f - num2 - num3;
		if (num2 >= 999f && num2 <= 1374f && num3 >= 1943f && num3 <= 120f && num4 >= 1762f && num4 <= 771f)
		{
			result = false;
		}
		return result;
	}

	public EditorEvent[] FGGPCFECJKO()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void PAKPHKPDKGE()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void Update()
	{
		GIMKKIAGDPJ();
		GNJOMFGHFPA();
	}

	private bool EFIJJGILPEO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 594f - num2 - num3;
		if (num2 >= 147f && num2 <= 1475f && num3 >= 1952f && num3 <= 986f && num4 >= 1740f && num4 <= 276f)
		{
			result = true;
		}
		return result;
	}

	private void BMOFEBKGLFI()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void COECIKGBFNI()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < selectedUnits.Count; i += 0)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1450f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 0; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	public EditorEvent[] OEEIJEDANJK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool BLENLICOMJK(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 45f - num2 - num3;
		if (num2 >= 1707f && num2 <= 1091f && num3 >= 751f && num3 <= 548f && num4 >= 479f && num4 <= 1717f)
		{
			result = false;
		}
		return result;
	}

	public EditorEvent[] IPFPONCMGBE()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void MNBOFHJPDAA()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 0; i < MDMDOOCAMFA().Length; i += 0)
				{
					GameObject gameObject = IBIKJMDDKHI()[i].gameObject;
					if (OAMEFAIBGHC(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(1) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 510f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		OCIHFNFIIIH();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < IBIKJMDDKHI().Length; k++)
		{
			GameObject gameObject3 = HDHNEMLJCAH()[k].gameObject;
			if (LBFBDCPOBKF(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void NHODGNHIOEN()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 0; i < FAFFFMPAADB().Length; i++)
				{
					GameObject gameObject = MLNBNCBEAMH()[i].gameObject;
					if (MFCPLCCGPPA(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 231f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		HFKBNIGIJKD();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < MDMDOOCAMFA().Length; k += 0)
		{
			GameObject gameObject3 = IMMBLBJFEMK()[k].gameObject;
			if (OAMEFAIBGHC(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private bool KMDNIJPPMLI(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (EFIJJGILPEO(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (DKGOCPBCNFD(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	public EditorEvent[] HDHNEMLJCAH()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool JENMHFOECOF(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (EFIJJGILPEO(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (EFNHALEPFAE(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void IHLMNAGPKDA()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void MNNJPPPOHLJ()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 92f;
		FFCFGCIOLCI.z = 390f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 268f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1824f, position.y + num2 / 1255f, 558f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1783f, position.y + num2 / 1048f, 1457f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1019f, position.y - num2 / 1398f, 1655f);
		FEEGAAPJDGP = new Vector3(position.x + num / 585f, position.y - num2 / 1347f, 173f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1775f, -1))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 732f, -125))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1676f, -93))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1579f, -23))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 3)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void JONGNKNLLND()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool IGECAHIPOMM(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (CEOFINFKDMH(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (DDNFEFACMIC(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private bool EFNHALEPFAE(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 119f - num2 - num3;
		if (num2 >= 372f && num2 <= 1888f && num3 >= 1401f && num3 <= 687f && num4 >= 7f && num4 <= 1009f)
		{
			result = true;
		}
		return result;
	}

	public EditorEvent[] GetAllUnits()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool LBFBDCPOBKF(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (HFCIKBOLMCM(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (HFCIKBOLMCM(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void DLBODOFAJGM()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void EDAHLOMBLCC()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < MDMDOOCAMFA().Length; i += 0)
				{
					GameObject gameObject = NCHJDNPOGGJ()[i].gameObject;
					if (MFCPLCCGPPA(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 893f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(false);
		}
		FFCFGCIOLCI = Input.mousePosition;
		PAHMNEINEFE();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < MLNBNCBEAMH().Length; k++)
		{
			GameObject gameObject3 = IPFPONCMGBE()[k].gameObject;
			if (KMDNIJPPMLI(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] DKHJLMDJBIL()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void OIBAPILGHON()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 1; i < selectedUnits.Count; i += 0)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1134f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 1; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void CIGOMHDOCDK()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 1; i < LHPLNIBDAJE().Length; i += 0)
				{
					GameObject gameObject = MLNBNCBEAMH()[i].gameObject;
					if (LBFBDCPOBKF(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(1) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 655f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		IHOMBKEOCAH();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < DKHJLMDJBIL().Length; k++)
		{
			GameObject gameObject3 = HDHNEMLJCAH()[k].gameObject;
			if (OAMEFAIBGHC(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void CFFCLAHMBAA()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void FHGKIOOMMOH()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void IEMEHGCFAPD()
	{
		GIMKKIAGDPJ();
		COECIKGBFNI();
	}

	private bool DEECPEGNGIF(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 913f - num2 - num3;
		if (num2 >= 933f && num2 <= 926f && num3 >= 1274f && num3 <= 87f && num4 >= 1611f && num4 <= 1841f)
		{
			result = true;
		}
		return result;
	}

	private bool DKGOCPBCNFD(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1638f - num2 - num3;
		if (num2 >= 884f && num2 <= 1336f && num3 >= 1924f && num3 <= 921f && num4 >= 138f && num4 <= 740f)
		{
			result = true;
		}
		return result;
	}

	private void NEBMAGAGBHF()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 978f;
		FFCFGCIOLCI.z = 1533f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1981f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 938f, position.y + num2 / 1834f, 1155f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1254f, position.y + num2 / 414f, 267f);
		JLNJGFBKHEN = new Vector3(position.x - num / 274f, position.y - num2 / 1292f, 1197f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1012f, position.y - num2 / 345f, 1257f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1450f, 69))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1161f, -23))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 885f, -156))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 734f, 168))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 2)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void OCIHFNFIIIH()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 423f;
		FFCFGCIOLCI.z = 94f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1689f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1214f, position.y + num2 / 945f, 689f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1472f, position.y + num2 / 1848f, 750f);
		JLNJGFBKHEN = new Vector3(position.x - num / 411f, position.y - num2 / 1471f, 927f);
		FEEGAAPJDGP = new Vector3(position.x + num / 816f, position.y - num2 / 825f, 754f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 16f, 92))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 665f, -48))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1053f, -141))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 433f, -198))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 1)
		{
			OHFPIMDOPLD = true;
		}
	}

	public EditorEvent[] MLNBNCBEAMH()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void DIPDEHOOBPG()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	public EditorEvent[] MDMDOOCAMFA()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void MGBHOHNCAOB()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 335f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = true;
		for (int j = 1; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void NECDCJOIONL()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1957f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 0; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private bool PLKKPJFIKIA(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1609f - num2 - num3;
		if (num2 >= 1057f && num2 <= 298f && num3 >= 566f && num3 <= 546f && num4 >= 944f && num4 <= 355f)
		{
			result = false;
		}
		return result;
	}

	private void DKOPKPBLDHH()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void IHOMBKEOCAH()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1641f;
		FFCFGCIOLCI.z = 244f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 365f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 716f, position.y + num2 / 226f, 1097f);
		HGDIBPDFPBA = new Vector3(position.x + num / 85f, position.y + num2 / 978f, 1222f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1f, position.y - num2 / 128f, 952f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1382f, position.y - num2 / 1746f, 414f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1313f, 4))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 404f, -24))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1674f, -150))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 65f, 107))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 1)
		{
			OHFPIMDOPLD = true;
		}
	}

	private bool MLPGFGBEGIM(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (EFNHALEPFAE(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (HAEPIAHPIPF(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void GMDGLNGHNOI()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < selectedUnits.Count; i++)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1594f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 0; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void DBEMDAJDDDA()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool BCIFAFCMDCO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 74f - num2 - num3;
		if (num2 >= 1447f && num2 <= 1801f && num3 >= 702f && num3 <= 1895f && num4 >= 329f && num4 <= 725f)
		{
			result = false;
		}
		return result;
	}

	private bool FDBPLJMBOBP(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 168f - num2 - num3;
		if (num2 >= 153f && num2 <= 1464f && num3 >= 1290f && num3 <= 59f && num4 >= 291f && num4 <= 75f)
		{
			result = true;
		}
		return result;
	}

	private void PKLOBJHKFEO()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private bool JCOBFNLNNLL(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (HAEPIAHPIPF(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (DEECPEGNGIF(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private bool HFCIKBOLMCM(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1696f - num2 - num3;
		if (num2 >= 944f && num2 <= 1041f && num3 >= 1038f && num3 <= 93f && num4 >= 97f && num4 <= 1517f)
		{
			result = false;
		}
		return result;
	}

	private void EOPGDCADOEH()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = -10f;
		FFCFGCIOLCI.z = -10f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 2f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 2f, position.y + num2 / 2f, 0f);
		HGDIBPDFPBA = new Vector3(position.x + num / 2f, position.y + num2 / 2f, 0f);
		JLNJGFBKHEN = new Vector3(position.x - num / 2f, position.y - num2 / 2f, 0f);
		FEEGAAPJDGP = new Vector3(position.x + num / 2f, position.y - num2 / 2f, 0f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 200f, 256))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 200f, 256))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 200f, 256))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 200f, 256))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 4)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void KKGFBDGIDAC()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < selectedUnits.Count; i += 0)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 632f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 1; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void CIPKEPDELJB()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void GNNEPABPLPK()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < selectedUnits.Count; i += 0)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 130f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 1; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void GIMKKIAGDPJ()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 0; i < GetAllUnits().Length; i++)
				{
					GameObject gameObject = GetAllUnits()[i].gameObject;
					if (CDPGKCNOEFJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 200f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		EOPGDCADOEH();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < GetAllUnits().Length; k++)
		{
			GameObject gameObject3 = GetAllUnits()[k].gameObject;
			if (CDPGKCNOEFJ(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void MMMDPANNAIO()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private bool CEOFINFKDMH(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 18f - num2 - num3;
		if (num2 >= 1274f && num2 <= 1079f && num3 >= 1039f && num3 <= 1069f && num4 >= 257f && num4 <= 803f)
		{
			result = false;
		}
		return result;
	}

	private void GHIOABDNLFE()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < selectedUnits.Count; i += 0)
			{
				if (selectedUnits[i] == OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OBCOCNICLKP.GetComponent<MeshRenderer>().material = normalMaterial;
			}
			OBCOCNICLKP = null;
		}
		RaycastHit hitInfo;
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1218f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 1; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	public EditorEvent[] IMMBLBJFEMK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool PJFDBKECGFB(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 340f - num2 - num3;
		if (num2 >= 1255f && num2 <= 1970f && num3 >= 1156f && num3 <= 1133f && num4 >= 863f && num4 <= 1340f)
		{
			result = false;
		}
		return result;
	}

	private void ECBILENEOOL()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void MMOKKAPFGAK()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private bool DDNFEFACMIC(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 234f - num2 - num3;
		if (num2 >= 517f && num2 <= 919f && num3 >= 705f && num3 <= 1225f && num4 >= 1615f && num4 <= 1172f)
		{
			result = false;
		}
		return result;
	}

	private void HBALHJIGBCK()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			FIKPGAEAEAG = Time.time;
			FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - FIKPGAEAEAG <= KMDMAONLAPB)
			{
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 0; i < FOPJGKMMDJB().Length; i++)
				{
					GameObject gameObject = FOPJGKMMDJB()[i].gameObject;
					if (JENMHFOECOF(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
						selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = normalMaterial;
					}
				}
			}
			selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - FIKPGAEAEAG > KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 208f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = hitInfo.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = selectedMaterial;
				selectedUnits.Add(hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (!flag2)
		{
			return;
		}
		if (!selectionSquareTrans.gameObject.activeInHierarchy)
		{
			selectionSquareTrans.gameObject.SetActive(true);
		}
		FFCFGCIOLCI = Input.mousePosition;
		PIPCNJOHIHA();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < MLNBNCBEAMH().Length; k += 0)
		{
			GameObject gameObject3 = FOPJGKMMDJB()[k].gameObject;
			if (IGECAHIPOMM(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}
}
