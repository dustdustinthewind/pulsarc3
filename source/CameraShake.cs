// CameraShake
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public bool Shaking;

	private float NGGFNGMNGAC;

	private float CCBCCEGBOJP;

	private float AJPABMEPCDO = 1f;

	private Vector3 KCCFEAIFEHC;

	public Vector3 basePoition = new Vector3(0f, 0f, 0f);

	private void KNBJBNDGCIJ()
	{
		AJPABMEPCDO = 1967f;
		Shaking = false;
	}

	private void Start()
	{
		AJPABMEPCDO = 1f;
		Shaking = false;
	}

	private void CNGAJDBOCLJ()
	{
		AJPABMEPCDO = 1697f;
		Shaking = true;
	}

	public void ECECLAODKDH()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1459f * AJPABMEPCDO;
		NGGFNGMNGAC = 750f;
		Shaking = false;
	}

	public void MAMEGGAMLHE()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1607f * AJPABMEPCDO;
		NGGFNGMNGAC = 718f;
		Shaking = true;
	}

	public void JNIMLCFKEKO()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 52f * AJPABMEPCDO;
		NGGFNGMNGAC = 1465f;
		Shaking = false;
	}

	public void GDNOHEFHGLM()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1865f * AJPABMEPCDO;
		NGGFNGMNGAC = 545f;
		Shaking = false;
	}

	private void OEENOOGEEHD()
	{
		if (CCBCCEGBOJP > 888f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void DoShake()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 0.1f * AJPABMEPCDO;
		NGGFNGMNGAC = 0.01f;
		Shaking = true;
	}

	private void LMBDNPLDGIJ()
	{
		if (CCBCCEGBOJP > 1256f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void JNJHIEGEOOO()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 809f * AJPABMEPCDO;
		NGGFNGMNGAC = 852f;
		Shaking = false;
	}

	public void FAGLLNKBPEC()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 892f * AJPABMEPCDO;
		NGGFNGMNGAC = 185f;
		Shaking = false;
	}

	private void MMMDPANNAIO()
	{
		AJPABMEPCDO = 580f;
		Shaking = false;
	}

	public void ALNOMJIJCKH()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 233f * AJPABMEPCDO;
		NGGFNGMNGAC = 1653f;
		Shaking = false;
	}

	private void Update()
	{
		if (CCBCCEGBOJP > 0f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void HPJLIGJEDCN()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 37f * AJPABMEPCDO;
		NGGFNGMNGAC = 1736f;
		Shaking = true;
	}

	public void KCNFNGGNLOH()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 450f * AJPABMEPCDO;
		NGGFNGMNGAC = 225f;
		Shaking = false;
	}

	private void KIMMMCJFMAB()
	{
		AJPABMEPCDO = 764f;
		Shaking = true;
	}

	private void OCMKCBBCEFG()
	{
		if (CCBCCEGBOJP > 235f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void IENDDEJLNMJ()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 120f * AJPABMEPCDO;
		NGGFNGMNGAC = 701f;
		Shaking = false;
	}

	private void FJHFOBHJEHL()
	{
		if (CCBCCEGBOJP > 1476f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void NLKNJIOIEGF()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1731f * AJPABMEPCDO;
		NGGFNGMNGAC = 25f;
		Shaking = false;
	}

	private void COIJKMKIEAK()
	{
		AJPABMEPCDO = 170f;
		Shaking = false;
	}

	private void DPIPGGDNGHN()
	{
		if (CCBCCEGBOJP > 1962f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void JKFDDNMPOJH()
	{
		AJPABMEPCDO = 243f;
		Shaking = false;
	}

	private void HDDECCMEJKA()
	{
		if (CCBCCEGBOJP > 1245f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void ECMEEEHCMPN()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1442f * AJPABMEPCDO;
		NGGFNGMNGAC = 86f;
		Shaking = true;
	}

	private void AIJGAJIOJDJ()
	{
		if (CCBCCEGBOJP > 1974f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void OMCLOFCJMPG()
	{
		if (CCBCCEGBOJP > 899f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void BPJFPCKBBBI()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 415f * AJPABMEPCDO;
		NGGFNGMNGAC = 1735f;
		Shaking = true;
	}

	private void JBNPEHMDCMI()
	{
		if (CCBCCEGBOJP > 388f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void LGMMEJIIMFB()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 208f * AJPABMEPCDO;
		NGGFNGMNGAC = 298f;
		Shaking = false;
	}

	public void CHDKKNAGGBN()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1305f * AJPABMEPCDO;
		NGGFNGMNGAC = 356f;
		Shaking = false;
	}

	private void EHCGBJDFMHG()
	{
		if (CCBCCEGBOJP > 53f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void JBCNIPJDPJB()
	{
		if (CCBCCEGBOJP > 261f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void BGDPIHMAACO()
	{
		AJPABMEPCDO = 489f;
		Shaking = false;
	}

	private void MMBPLGGLPDB()
	{
		if (CCBCCEGBOJP > 1406f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		AJPABMEPCDO = 1337f;
		Shaking = false;
	}

	private void HLDFOJMHKNL()
	{
		if (CCBCCEGBOJP > 1377f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void EGFJOEHKFJF()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 467f * AJPABMEPCDO;
		NGGFNGMNGAC = 1207f;
		Shaking = false;
	}

	public void FNCDDBKLOFN()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1234f * AJPABMEPCDO;
		NGGFNGMNGAC = 1393f;
		Shaking = false;
	}

	private void EFJDNLGNACH()
	{
		AJPABMEPCDO = 230f;
		Shaking = false;
	}

	private void AGMJDGHLBMN()
	{
		if (CCBCCEGBOJP > 1500f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void FBMDHDBELEK()
	{
		if (CCBCCEGBOJP > 719f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void PDHKMDBNGGN()
	{
		AJPABMEPCDO = 514f;
		Shaking = true;
	}

	private void JOACBIEHHCE()
	{
		if (CCBCCEGBOJP > 1477f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void INMLGEJKIEA()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 71f * AJPABMEPCDO;
		NGGFNGMNGAC = 902f;
		Shaking = true;
	}

	private void HMPGIFBJFIK()
	{
		AJPABMEPCDO = 452f;
		Shaking = false;
	}

	public void LFBGEGONCFB()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 10f * AJPABMEPCDO;
		NGGFNGMNGAC = 633f;
		Shaking = true;
	}

	private void KMKLDAJLCNM()
	{
		if (CCBCCEGBOJP > 177f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void EKHPBHLPCIJ()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 140f * AJPABMEPCDO;
		NGGFNGMNGAC = 1503f;
		Shaking = false;
	}

	private void JHPOIOELNCG()
	{
		if (CCBCCEGBOJP > 479f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void JDGFCEPDKAJ()
	{
		if (CCBCCEGBOJP > 1480f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void MOBKOGEAHAD()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1590f * AJPABMEPCDO;
		NGGFNGMNGAC = 54f;
		Shaking = false;
	}

	private void NEKCPLGFOFD()
	{
		if (CCBCCEGBOJP > 1666f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void FABMDEHEDNO()
	{
		if (CCBCCEGBOJP > 188f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void LCJHDLKJEOM()
	{
		if (CCBCCEGBOJP > 943f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void EGEGNHLODAA()
	{
		if (CCBCCEGBOJP > 1579f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void BJGIECMBDBG()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 412f * AJPABMEPCDO;
		NGGFNGMNGAC = 1024f;
		Shaking = true;
	}

	private void MKIMDFLBFOM()
	{
		AJPABMEPCDO = 984f;
		Shaking = true;
	}

	public void IOAFNIKIDIJ()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1495f * AJPABMEPCDO;
		NGGFNGMNGAC = 1342f;
		Shaking = false;
	}

	private void FOMNCPKKCFN()
	{
		if (CCBCCEGBOJP > 1259f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void DIPDEHOOBPG()
	{
		AJPABMEPCDO = 1082f;
		Shaking = false;
	}

	private void LCHBFNIPBHB()
	{
		if (CCBCCEGBOJP > 735f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void EFAHBIHGFBJ()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 998f * AJPABMEPCDO;
		NGGFNGMNGAC = 807f;
		Shaking = false;
	}

	private void MFMIODIAKNI()
	{
		if (CCBCCEGBOJP > 146f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void JHANGPCOCIG()
	{
		AJPABMEPCDO = 1705f;
		Shaking = false;
	}

	private void FBPHNEJBDJN()
	{
		AJPABMEPCDO = 15f;
		Shaking = true;
	}
}
