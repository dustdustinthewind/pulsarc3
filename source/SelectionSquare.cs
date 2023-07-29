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

	private void GEMJKCAMPBK()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 800f;
		FFCFGCIOLCI.z = 132f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 951f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1660f, position.y + num2 / 400f, 1232f);
		HGDIBPDFPBA = new Vector3(position.x + num / 452f, position.y + num2 / 661f, 977f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1338f, position.y - num2 / 799f, 425f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1434f, position.y - num2 / 1059f, 1705f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1125f, -69))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1186f, -175))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 735f, 119))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1582f, 77))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 5)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void OMCLOFCJMPG()
	{
		DOHMPHHEIGN();
		ELBEILOFLEG();
	}

	public EditorEvent[] IFJAJMLKBJP()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool PDOFKBIEJOE(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1894f - num2 - num3;
		if (num2 >= 1963f && num2 <= 813f && num3 >= 212f && num3 <= 1491f && num4 >= 942f && num4 <= 1468f)
		{
			result = true;
		}
		return result;
	}

	private void FJHFOBHJEHL()
	{
		JAAJAILNOHP();
		GCAOHMEKDJF();
	}

	private bool FHMPJFGOPFB(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 226f - num2 - num3;
		if (num2 >= 456f && num2 <= 653f && num3 >= 104f && num3 <= 1558f && num4 >= 706f && num4 <= 1145f)
		{
			result = false;
		}
		return result;
	}

	private void MKCFDHAAJOC()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = true;
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 599f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 0; j < selectedUnits.Count; j += 0)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = false;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void HLPINKNFIAA()
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
				for (int i = 0; i < OLPAMGCBPLL().Length; i++)
				{
					GameObject gameObject = PCKCKEBBNDA()[i].gameObject;
					if (LDMOLMOKPIE(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 291f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		LONGDPHGFDE();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < HHDAAOACMAC().Length; k += 0)
		{
			GameObject gameObject3 = OHEJFBKIDON()[k].gameObject;
			if (PNFHPKIAHNH(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private bool AJOEGDIDAHN(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1950f - num2 - num3;
		if (num2 >= 145f && num2 <= 88f && num3 >= 1982f && num3 <= 660f && num4 >= 1766f && num4 <= 1151f)
		{
			result = true;
		}
		return result;
	}

	private void DIIAIPPJBLO()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 899f;
		FFCFGCIOLCI.z = 1999f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1729f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1223f, position.y + num2 / 1333f, 895f);
		HGDIBPDFPBA = new Vector3(position.x + num / 627f, position.y + num2 / 1429f, 1312f);
		JLNJGFBKHEN = new Vector3(position.x - num / 928f, position.y - num2 / 478f, 1050f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1592f, position.y - num2 / 1047f, 239f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1298f, -143))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 521f, -32))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1250f, 83))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 172f, 1))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void PHJJHFBLICM()
	{
		GPLNEEJGKMC();
		MKCFDHAAJOC();
	}

	private void BGDONBMDPGM()
	{
		NHBHDBOCDGA();
		BFGPAFIMLAN();
	}

	private void LKNNNBAOMDO()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 886f;
		FFCFGCIOLCI.z = 1264f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1427f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 356f, position.y + num2 / 1455f, 778f);
		HGDIBPDFPBA = new Vector3(position.x + num / 528f, position.y + num2 / 544f, 1579f);
		JLNJGFBKHEN = new Vector3(position.x - num / 198f, position.y - num2 / 1264f, 1378f);
		FEEGAAPJDGP = new Vector3(position.x + num / 258f, position.y - num2 / 1460f, 1342f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1599f, 62))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1161f, -146))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 702f, -43))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 665f, -63))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			OHFPIMDOPLD = true;
		}
	}

	private bool FEJGLFDFMOM(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1538f - num2 - num3;
		if (num2 >= 1832f && num2 <= 448f && num3 >= 1188f && num3 <= 1416f && num4 >= 1355f && num4 <= 843f)
		{
			result = true;
		}
		return result;
	}

	public EditorEvent[] BKEEDNGFKEC()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	public EditorEvent[] NAEJMBCJEOE()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool OOGFMHEBFON(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (FHMPJFGOPFB(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (LLKOMAKLACL(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private bool EFNKEJAINBO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 502f - num2 - num3;
		if (num2 >= 1884f && num2 <= 1154f && num3 >= 1336f && num3 <= 701f && num4 >= 381f && num4 <= 441f)
		{
			result = true;
		}
		return result;
	}

	private void DNNFHBOOPIN()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void ADPLHDFJFID()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool FOKOFNDCAPE(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (PLGGKMEKMFI(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (BFGMOGFLMLP(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void NIABLGNAOBP()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1655f;
		FFCFGCIOLCI.z = 456f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 666f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 440f, position.y + num2 / 1102f, 31f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1957f, position.y + num2 / 529f, 1846f);
		JLNJGFBKHEN = new Vector3(position.x - num / 237f, position.y - num2 / 1693f, 365f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1656f, position.y - num2 / 580f, 865f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 507f, 66))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1495f, 168))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1056f, 69))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1408f, 167))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void HFKBNIGIJKD()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1880f;
		FFCFGCIOLCI.z = 1155f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1547f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1921f, position.y + num2 / 1387f, 282f);
		HGDIBPDFPBA = new Vector3(position.x + num / 309f, position.y + num2 / 1314f, 640f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1705f, position.y - num2 / 692f, 465f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1852f, position.y - num2 / 775f, 1383f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1766f, 2))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 81f, 105))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 563f, 113))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1968f, 179))
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

	private bool ILIFHGNEDKE(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (LEMEGPNDHMG(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (LEMEGPNDHMG(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
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

	private void DDBOODLPCAM()
	{
		ALJMJBGPMLL();
		GNJOMFGHFPA();
	}

	private bool KIENGDKBMOO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 184f - num2 - num3;
		if (num2 >= 320f && num2 <= 1604f && num3 >= 1108f && num3 <= 521f && num4 >= 474f && num4 <= 1107f)
		{
			result = true;
		}
		return result;
	}

	private void CHOPDIGHJNH()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void JNKLMFFDLBN()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 873f;
		FFCFGCIOLCI.z = 1032f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1631f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 383f, position.y + num2 / 1560f, 1159f);
		HGDIBPDFPBA = new Vector3(position.x + num / 765f, position.y + num2 / 816f, 81f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1515f, position.y - num2 / 1204f, 632f);
		FEEGAAPJDGP = new Vector3(position.x + num / 33f, position.y - num2 / 1521f, 1621f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1348f, -189))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 327f, 80))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1720f, 178))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 514f, -142))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 5)
		{
			OHFPIMDOPLD = false;
		}
	}

	private bool PNFHPKIAHNH(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (PLGGKMEKMFI(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (LNPDBEBGHAJ(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void BFGPAFIMLAN()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 14f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = true;
		for (int j = 0; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = false;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void DFPHMHFMEOP()
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
				flag = true;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 1; i < EGNMOMBJEBJ().Length; i += 0)
				{
					GameObject gameObject = LGFLMLBPGMA()[i].gameObject;
					if (BAENAALOCIH(gameObject.transform.position))
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
			for (int j = 1; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 822f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		EOPGDCADOEH();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < BBJNGOFCNMK().Length; k += 0)
		{
			GameObject gameObject3 = FOPJGKMMDJB()[k].gameObject;
			if (ICNJDMKBBBN(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void DOHMPHHEIGN()
	{
		bool flag = true;
		bool flag2 = false;
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
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < JPKKFIGFLCD().Length; i++)
				{
					GameObject gameObject = EGNMOMBJEBJ()[i].gameObject;
					if (CNMJEKCOPCL(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1552f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		LONGDPHGFDE();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < BBJNGOFCNMK().Length; k++)
		{
			GameObject gameObject3 = GJCAMFHELPL()[k].gameObject;
			if (AFBLAMCMHOL(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] MBKKGPJCFDM()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void NHBHDBOCDGA()
	{
		bool flag = false;
		bool flag2 = true;
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
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < PCKCKEBBNDA().Length; i += 0)
				{
					GameObject gameObject = LGFLMLBPGMA()[i].gameObject;
					if (CAKAGLJIKPJ(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1652f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		GEMJKCAMPBK();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < EGNMOMBJEBJ().Length; k++)
		{
			GameObject gameObject3 = HHDAAOACMAC()[k].gameObject;
			if (ILIFHGNEDKE(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] PCKCKEBBNDA()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void DNKPHNDKJCL()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1832f;
		FFCFGCIOLCI.z = 388f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1166f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 252f, position.y + num2 / 1021f, 1899f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1891f, position.y + num2 / 888f, 914f);
		JLNJGFBKHEN = new Vector3(position.x - num / 334f, position.y - num2 / 1086f, 302f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1613f, position.y - num2 / 724f, 1518f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 384f, -190))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 32f, -123))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 405f, -120))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 603f, -109))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 7)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void MJEFMIPLFAB()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void ONHEFNAGCGG()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1923f;
		FFCFGCIOLCI.z = 1305f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1326f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 82f, position.y + num2 / 835f, 101f);
		HGDIBPDFPBA = new Vector3(position.x + num / 356f, position.y + num2 / 1217f, 1866f);
		JLNJGFBKHEN = new Vector3(position.x - num / 902f, position.y - num2 / 1981f, 9f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1616f, position.y - num2 / 997f, 191f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1006f, -7))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 856f, -138))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1801f, 186))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1861f, -15))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			OHFPIMDOPLD = false;
		}
	}

	private bool GHDBDINKJNF(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1018f - num2 - num3;
		if (num2 >= 1774f && num2 <= 1521f && num3 >= 1577f && num3 <= 468f && num4 >= 587f && num4 <= 824f)
		{
			result = true;
		}
		return result;
	}

	private bool LLKOMAKLACL(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1533f - num2 - num3;
		if (num2 >= 502f && num2 <= 1664f && num3 >= 392f && num3 <= 554f && num4 >= 1103f && num4 <= 1676f)
		{
			result = true;
		}
		return result;
	}

	private void HNAAGAHOONB()
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1712f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			return;
		}
		GameObject gameObject = hitInfo.collider.gameObject;
		bool flag2 = false;
		for (int j = 1; j < selectedUnits.Count; j++)
		{
			if (selectedUnits[j] == gameObject)
			{
				flag2 = false;
				break;
			}
		}
		if (!flag2)
		{
			OBCOCNICLKP = gameObject;
			OBCOCNICLKP.GetComponent<MeshRenderer>().material = highlightMaterial;
		}
	}

	private void EFMKNKOFECE()
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
				flag = false;
			}
			if (OHFPIMDOPLD)
			{
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 1; i < IFJAJMLKBJP().Length; i += 0)
				{
					GameObject gameObject = JPKKFIGFLCD()[i].gameObject;
					if (BAENAALOCIH(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 905f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		PDKOKLDBFIB();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < MBKKGPJCFDM().Length; k++)
		{
			GameObject gameObject3 = OLPAMGCBPLL()[k].gameObject;
			if (ILIFHGNEDKE(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void IKDNLHLBHID()
	{
		selectionSquareTrans.gameObject.SetActive(false);
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

	private void EBEPEDDNHMC()
	{
		bool flag = false;
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
				for (int i = 1; i < MBKKGPJCFDM().Length; i++)
				{
					GameObject gameObject = PCKCKEBBNDA()[i].gameObject;
					if (HFDDIIDPFBJ(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 17f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		LKNNNBAOMDO();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < NCHJDNPOGGJ().Length; k++)
		{
			GameObject gameObject3 = GetAllUnits()[k].gameObject;
			if (ICNJDMKBBBN(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] OHEJFBKIDON()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void ABOMFLPCNEC()
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
				for (int i = 0; i < OHEJFBKIDON().Length; i += 0)
				{
					GameObject gameObject = NCHJDNPOGGJ()[i].gameObject;
					if (BAENAALOCIH(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 56f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		DNKPHNDKJCL();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < EGNMOMBJEBJ().Length; k += 0)
		{
			GameObject gameObject3 = HHDAAOACMAC()[k].gameObject;
			if (CIJEPJKGHNJ(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void MKOMIDCPCDC()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private void ALNNIDLFILB()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void KCDOMIJBFLL()
	{
		DFPHMHFMEOP();
		DNGAHODMCAJ();
	}

	public EditorEvent[] JLKBIDDLADF()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	public EditorEvent[] DGHCBDOJOEH()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void FHGKIOOMMOH()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private void AEEGKLABFLN()
	{
		GPLNEEJGKMC();
		GCAOHMEKDJF();
	}

	public EditorEvent[] FOPJGKMMDJB()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void GPLNEEJGKMC()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(1))
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
				for (int i = 1; i < IFJAJMLKBJP().Length; i += 0)
				{
					GameObject gameObject = JLKBIDDLADF()[i].gameObject;
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 733f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		DPBKDJCOHOK();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < EGNMOMBJEBJ().Length; k += 0)
		{
			GameObject gameObject3 = BBJNGOFCNMK()[k].gameObject;
			if (CAKAGLJIKPJ(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void HLLKCIBGIGK()
	{
		bool flag = false;
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
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < KIDEJODGFMO().Length; i += 0)
				{
					GameObject gameObject = OHEJFBKIDON()[i].gameObject;
					if (HFDDIIDPFBJ(gameObject.transform.position))
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
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 1; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 60f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		MOODOHODIGP();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < MBKKGPJCFDM().Length; k += 0)
		{
			GameObject gameObject3 = DGHCBDOJOEH()[k].gameObject;
			if (BAENAALOCIH(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void NHOMCHMKNNB()
	{
		bool flag = false;
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
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < NGPCHKEKFAP().Length; i += 0)
				{
					GameObject gameObject = FOPJGKMMDJB()[i].gameObject;
					if (GBLNAMNICAI(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 688f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		for (int k = 1; k < NCHJDNPOGGJ().Length; k++)
		{
			GameObject gameObject3 = DGHCBDOJOEH()[k].gameObject;
			if (AFBLAMCMHOL(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	public EditorEvent[] NCHJDNPOGGJ()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	public EditorEvent[] KIDEJODGFMO()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool LDMOLMOKPIE(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (FEJGLFDFMOM(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (LEMEGPNDHMG(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	public EditorEvent[] NGPCHKEKFAP()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void DLLNAGEKCOB()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 622f;
		FFCFGCIOLCI.z = 1226f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 806f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 665f, position.y + num2 / 1405f, 348f);
		HGDIBPDFPBA = new Vector3(position.x + num / 718f, position.y + num2 / 763f, 797f);
		JLNJGFBKHEN = new Vector3(position.x - num / 585f, position.y - num2 / 43f, 269f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1655f, position.y - num2 / 731f, 831f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 62f, 52))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1429f, -39))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 875f, -135))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 992f, 124))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 7)
		{
			OHFPIMDOPLD = false;
		}
	}

	public EditorEvent[] GJCAMFHELPL()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void PDMADJGCIFJ()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 522f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private void CHCKBGEBHGO()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1671f;
		FFCFGCIOLCI.z = 725f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1646f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1420f, position.y + num2 / 84f, 596f);
		HGDIBPDFPBA = new Vector3(position.x + num / 604f, position.y + num2 / 296f, 203f);
		JLNJGFBKHEN = new Vector3(position.x - num / 545f, position.y - num2 / 1533f, 1930f);
		FEEGAAPJDGP = new Vector3(position.x + num / 114f, position.y - num2 / 708f, 643f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1805f, -84))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 456f, -41))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1922f, 170))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1971f, 55))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 0)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void BOPKKCAFODF()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool AGPKPGMCPGH(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1813f - num2 - num3;
		if (num2 >= 1418f && num2 <= 1736f && num3 >= 701f && num3 <= 1582f && num4 >= 1688f && num4 <= 58f)
		{
			result = true;
		}
		return result;
	}

	private void PAKPHKPDKGE()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	public EditorEvent[] BIPIOPLONBM()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	public EditorEvent[] GetAllUnits()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void KJDNHGDNELM()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1851f;
		FFCFGCIOLCI.z = 873f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 945f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 835f, position.y + num2 / 1080f, 1463f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1602f, position.y + num2 / 839f, 371f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1011f, position.y - num2 / 1022f, 1579f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1125f, position.y - num2 / 722f, 448f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1105f, 167))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 380f, -54))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1922f, 172))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 387f, -146))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 6)
		{
			OHFPIMDOPLD = false;
		}
	}

	private bool GBLNAMNICAI(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (AGPKPGMCPGH(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (LNPDBEBGHAJ(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
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

	private void ELBEILOFLEG()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 772f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private bool CNMJEKCOPCL(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (LNPDBEBGHAJ(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (LEMEGPNDHMG(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private bool EFIJJGILPEO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 451f - num2 - num3;
		if (num2 >= 1979f && num2 <= 703f && num3 >= 768f && num3 <= 1506f && num4 >= 292f && num4 <= 1543f)
		{
			result = false;
		}
		return result;
	}

	private void MMPHNFPPEHO()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	public EditorEvent[] JPKKFIGFLCD()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void DNENFLNCIJP()
	{
		EBEPEDDNHMC();
		IHDLBDLBDBD();
	}

	public EditorEvent[] EGNMOMBJEBJ()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void MEBPBNLBECA()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	public EditorEvent[] HHDAAOACMAC()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool BAENAALOCIH(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (LLKOMAKLACL(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (AJOEGDIDAHN(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void MOODOHODIGP()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1468f;
		FFCFGCIOLCI.z = 1454f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 323f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1272f, position.y + num2 / 1179f, 795f);
		HGDIBPDFPBA = new Vector3(position.x + num / 180f, position.y + num2 / 1705f, 1253f);
		JLNJGFBKHEN = new Vector3(position.x - num / 682f, position.y - num2 / 338f, 361f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1845f, position.y - num2 / 116f, 660f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1680f, -7))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1998f, -88))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1153f, 18))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1306f, -82))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void NNFONHEIEEL()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 269f;
		FFCFGCIOLCI.z = 897f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 74f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 626f, position.y + num2 / 1285f, 6f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1086f, position.y + num2 / 1007f, 1441f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1154f, position.y - num2 / 447f, 26f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1149f, position.y - num2 / 1736f, 1438f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 690f, -135))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 669f, -143))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 236f, 139))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1463f, 198))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 0)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void JAAJAILNOHP()
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
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < LGFLMLBPGMA().Length; i += 0)
				{
					GameObject gameObject = PCKCKEBBNDA()[i].gameObject;
					if (GBLNAMNICAI(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1520f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		MOODOHODIGP();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < FOPJGKMMDJB().Length; k++)
		{
			GameObject gameObject3 = PCKCKEBBNDA()[k].gameObject;
			if (CAKAGLJIKPJ(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void JIDDEJNOBKH()
	{
		bool flag = false;
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
				for (int i = 1; i < LGFLMLBPGMA().Length; i += 0)
				{
					GameObject gameObject = NGPCHKEKFAP()[i].gameObject;
					if (CAKAGLJIKPJ(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 596f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		CHCKBGEBHGO();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < BBJNGOFCNMK().Length; k++)
		{
			GameObject gameObject3 = FOPJGKMMDJB()[k].gameObject;
			if (ILIFHGNEDKE(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void PBEPCAPAKLG()
	{
		HEKDCKGBBKI();
		MGBHOHNCAOB();
	}

	private void FGCHEDBOAIB()
	{
		bool flag = false;
		bool flag2 = false;
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
				OHFPIMDOPLD = false;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 0; i < EGNMOMBJEBJ().Length; i++)
				{
					GameObject gameObject = GJCAMFHELPL()[i].gameObject;
					if (CAKAGLJIKPJ(gameObject.transform.position))
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
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1305f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		for (int k = 0; k < LGFLMLBPGMA().Length; k += 0)
		{
			GameObject gameObject3 = HHDAAOACMAC()[k].gameObject;
			if (BAENAALOCIH(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void IHDLBDLBDBD()
	{
		if (OBCOCNICLKP != null)
		{
			bool flag = false;
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 430f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private bool CIJEPJKGHNJ(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (PDOFKBIEJOE(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (LLKOMAKLACL(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void DPBKDJCOHOK()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 476f;
		FFCFGCIOLCI.z = 522f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1770f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1256f, position.y + num2 / 1290f, 1383f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1224f, position.y + num2 / 1714f, 340f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1852f, position.y - num2 / 498f, 412f);
		FEEGAAPJDGP = new Vector3(position.x + num / 289f, position.y - num2 / 1316f, 1021f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1799f, 11))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1529f, -153))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1142f, -191))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1735f, 152))
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

	private void PDKOKLDBFIB()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 934f;
		FFCFGCIOLCI.z = 1590f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1384f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1f, position.y + num2 / 1040f, 1883f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1040f, position.y + num2 / 1474f, 1129f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1060f, position.y - num2 / 454f, 1203f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1747f, position.y - num2 / 45f, 837f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 507f, -80))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 496f, -3))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1938f, -72))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1059f, -17))
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

	private bool CAKAGLJIKPJ(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (EFIJJGILPEO(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (BFGMOGFLMLP(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void HEKDCKGBBKI()
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
				for (int i = 0; i < BKEEDNGFKEC().Length; i += 0)
				{
					GameObject gameObject = JPKKFIGFLCD()[i].gameObject;
					if (CIJEPJKGHNJ(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1127f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		KJDNHGDNELM();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < IFJAJMLKBJP().Length; k += 0)
		{
			GameObject gameObject3 = FOPJGKMMDJB()[k].gameObject;
			if (OOGFMHEBFON(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private bool CPBFNBCJDLB(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (PLGGKMEKMFI(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (LNPDBEBGHAJ(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	public EditorEvent[] OLPAMGCBPLL()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void JOHNJFBIBJD()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1528f;
		FFCFGCIOLCI.z = 330f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 144f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1197f, position.y + num2 / 1638f, 436f);
		HGDIBPDFPBA = new Vector3(position.x + num / 460f, position.y + num2 / 1877f, 1733f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1558f, position.y - num2 / 1588f, 1928f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1985f, position.y - num2 / 1357f, 1949f);
		int num3 = 1;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 937f, 140))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1693f, -90))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1699f, 171))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1725f, 162))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = false;
		if (num3 == 1)
		{
			OHFPIMDOPLD = false;
		}
	}

	public EditorEvent[] PCGFFKDPOED()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void EOAJNFACFAN()
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 501f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private void ALJMJBGPMLL()
	{
		bool flag = false;
		bool flag2 = true;
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
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < FOPJGKMMDJB().Length; i += 0)
				{
					GameObject gameObject = MBKKGPJCFDM()[i].gameObject;
					if (ICNJDMKBBBN(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1284f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		NNFONHEIEEL();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 1; k < IFJAJMLKBJP().Length; k++)
		{
			GameObject gameObject3 = NAEJMBCJEOE()[k].gameObject;
			if (ICNJDMKBBBN(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
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

	private void HDDECCMEJKA()
	{
		EHEAIKFHGFD();
		HNAAGAHOONB();
	}

	private void DNGAHODMCAJ()
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1424f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private void Update()
	{
		GIMKKIAGDPJ();
		GNJOMFGHFPA();
	}

	private void EHEAIKFHGFD()
	{
		bool flag = false;
		bool flag2 = false;
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
				selectionSquareTrans.gameObject.SetActive(false);
				selectedUnits.Clear();
				for (int i = 1; i < BKEEDNGFKEC().Length; i += 0)
				{
					GameObject gameObject = LGFLMLBPGMA()[i].gameObject;
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
			for (int j = 0; j < selectedUnits.Count; j += 0)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 588f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		NNFONHEIEEL();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < MBKKGPJCFDM().Length; k++)
		{
			GameObject gameObject3 = OLPAMGCBPLL()[k].gameObject;
			if (CAKAGLJIKPJ(gameObject3.transform.position))
			{
				gameObject3.GetComponent<MeshRenderer>().material = highlightMaterial;
			}
			else
			{
				gameObject3.GetComponent<MeshRenderer>().material = normalMaterial;
			}
		}
	}

	private void GLEJGFLCLPJ()
	{
		selectionSquareTrans.gameObject.SetActive(true);
	}

	private bool HFDDIIDPFBJ(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (AJOEGDIDAHN(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (PDOFKBIEJOE(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private bool ICNJDMKBBBN(Vector3 LMEDNCNFOAC)
	{
		bool result = false;
		if (PLGGKMEKMFI(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return true;
		}
		if (PDOFKBIEJOE(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return true;
		}
		return result;
	}

	private void Start()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	private bool LEMEGPNDHMG(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 816f - num2 - num3;
		if (num2 >= 297f && num2 <= 1472f && num3 >= 4f && num3 <= 1246f && num4 >= 563f && num4 <= 1020f)
		{
			result = false;
		}
		return result;
	}

	private void JOAGFMLPFIK()
	{
		bool flag = false;
		bool flag2 = false;
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
				OHFPIMDOPLD = true;
				selectionSquareTrans.gameObject.SetActive(true);
				selectedUnits.Clear();
				for (int i = 1; i < FPKNLKPAOMK().Length; i += 0)
				{
					GameObject gameObject = BBJNGOFCNMK()[i].gameObject;
					if (ICNJDMKBBBN(gameObject.transform.position))
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
			for (int j = 0; j < selectedUnits.Count; j++)
			{
				selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = normalMaterial;
			}
			selectedUnits.Clear();
			RaycastHit hitInfo;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1621f) && (bool)hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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
		CHCKBGEBHGO();
		if (!OHFPIMDOPLD)
		{
			return;
		}
		for (int k = 0; k < NAEJMBCJEOE().Length; k++)
		{
			GameObject gameObject3 = JPKKFIGFLCD()[k].gameObject;
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

	private void LONGDPHGFDE()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 522f;
		FFCFGCIOLCI.z = 1030f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1647f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1590f, position.y + num2 / 302f, 1195f);
		HGDIBPDFPBA = new Vector3(position.x + num / 1044f, position.y + num2 / 436f, 860f);
		JLNJGFBKHEN = new Vector3(position.x - num / 303f, position.y - num2 / 1635f, 810f);
		FEEGAAPJDGP = new Vector3(position.x + num / 1308f, position.y - num2 / 956f, 1505f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1767f, -75))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 540f, 183))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1345f, -181))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1057f, -134))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3++;
		}
		OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			OHFPIMDOPLD = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		selectionSquareTrans.gameObject.SetActive(false);
	}

	public EditorEvent[] BBJNGOFCNMK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool PLGGKMEKMFI(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 699f - num2 - num3;
		if (num2 >= 642f && num2 <= 489f && num3 >= 1548f && num3 <= 905f && num4 >= 706f && num4 <= 1397f)
		{
			result = true;
		}
		return result;
	}

	private bool AFBLAMCMHOL(Vector3 LMEDNCNFOAC)
	{
		bool result = true;
		if (GHDBDINKJNF(LMEDNCNFOAC, BOPPMKAHKJP, JLNJGFBKHEN, HGDIBPDFPBA))
		{
			return false;
		}
		if (EFIJJGILPEO(LMEDNCNFOAC, HGDIBPDFPBA, JLNJGFBKHEN, FEEGAAPJDGP))
		{
			return false;
		}
		return result;
	}

	private void EIIDHJHJBGO()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 1623f;
		FFCFGCIOLCI.z = 1177f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1261f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 1219f, position.y + num2 / 741f, 1862f);
		HGDIBPDFPBA = new Vector3(position.x + num / 914f, position.y + num2 / 319f, 1663f);
		JLNJGFBKHEN = new Vector3(position.x - num / 330f, position.y - num2 / 1687f, 1198f);
		FEEGAAPJDGP = new Vector3(position.x + num / 440f, position.y - num2 / 158f, 1844f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 1685f, 76))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 1824f, 55))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 1441f, 9))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 454f, 24))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = false;
		if (num3 == 4)
		{
			OHFPIMDOPLD = true;
		}
	}

	public EditorEvent[] LGFLMLBPGMA()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private bool BFGMOGFLMLP(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 722f - num2 - num3;
		if (num2 >= 1785f && num2 <= 972f && num3 >= 692f && num3 <= 656f && num4 >= 1322f && num4 <= 920f)
		{
			result = true;
		}
		return result;
	}

	public EditorEvent[] FPKNLKPAOMK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	private void GCAOHMEKDJF()
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1424f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private void PMIGAINDGBN()
	{
		Vector3 fHMDDCEDGJC = FHMDDCEDGJC;
		FHMDDCEDGJC.z = 26f;
		FFCFGCIOLCI.z = 675f;
		Vector3 position = (fHMDDCEDGJC + FFCFGCIOLCI) / 1011f;
		selectionSquareTrans.position = position;
		float num = Mathf.Abs(FHMDDCEDGJC.x - FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(FHMDDCEDGJC.y - FFCFGCIOLCI.y);
		selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		BOPPMKAHKJP = new Vector3(position.x - num / 41f, position.y + num2 / 10f, 249f);
		HGDIBPDFPBA = new Vector3(position.x + num / 397f, position.y + num2 / 300f, 1623f);
		JLNJGFBKHEN = new Vector3(position.x - num / 1113f, position.y - num2 / 759f, 298f);
		FEEGAAPJDGP = new Vector3(position.x + num / 786f, position.y - num2 / 237f, 1060f);
		int num3 = 0;
		RaycastHit hitInfo;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(BOPPMKAHKJP), out hitInfo, 145f, 129))
		{
			BOPPMKAHKJP = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(HGDIBPDFPBA), out hitInfo, 301f, -179))
		{
			HGDIBPDFPBA = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(JLNJGFBKHEN), out hitInfo, 433f, 199))
		{
			JLNJGFBKHEN = hitInfo.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(FEEGAAPJDGP), out hitInfo, 1979f, 59))
		{
			FEEGAAPJDGP = hitInfo.point;
			num3 += 0;
		}
		OHFPIMDOPLD = true;
		if (num3 == 3)
		{
			OHFPIMDOPLD = true;
		}
	}

	private void MGBHOHNCAOB()
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
		if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1631f) || !hitInfo.collider.gameObject.GetComponentInParent<EditorEvent>())
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

	private void MBLDJEFBLFL()
	{
		ABOMFLPCNEC();
		EOAJNFACFAN();
	}
}
