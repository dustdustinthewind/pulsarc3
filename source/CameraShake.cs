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

	public void NLKNJIOIEGF()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 602f * AJPABMEPCDO;
		NGGFNGMNGAC = 1195f;
		Shaking = false;
	}

	public void HPJLIGJEDCN()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1166f * AJPABMEPCDO;
		NGGFNGMNGAC = 1329f;
		Shaking = false;
	}

	private void FIKFJDFELIP()
	{
		AJPABMEPCDO = 1348f;
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

	private void LCJHDLKJEOM()
	{
		if (CCBCCEGBOJP > 672f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void KIMMMCJFMAB()
	{
		AJPABMEPCDO = 579f;
		Shaking = false;
	}

	private void KMCPMOGKDEH()
	{
		AJPABMEPCDO = 766f;
		Shaking = false;
	}

	private void AGEJKLMJGDO()
	{
		AJPABMEPCDO = 526f;
		Shaking = true;
	}

	private void FABKIGNFECE()
	{
		if (CCBCCEGBOJP > 10f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		AJPABMEPCDO = 1561f;
		Shaking = false;
	}

	private void MMMDPANNAIO()
	{
		AJPABMEPCDO = 15f;
		Shaking = false;
	}

	private void LLJLDLLNFBH()
	{
		if (CCBCCEGBOJP > 924f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void FEIKJBMEHLD()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1271f * AJPABMEPCDO;
		NGGFNGMNGAC = 726f;
		Shaking = false;
	}

	public void HDAPEPPPOGG()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 516f * AJPABMEPCDO;
		NGGFNGMNGAC = 1911f;
		Shaking = true;
	}

	private void EPEGAEGDJAM()
	{
		AJPABMEPCDO = 1135f;
		Shaking = true;
	}

	private void FBMDHDBELEK()
	{
		if (CCBCCEGBOJP > 600f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = false;
		}
	}

	public void DoShake()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 0.1f * AJPABMEPCDO;
		NGGFNGMNGAC = 0.01f;
		Shaking = true;
	}

	private void DLBODOFAJGM()
	{
		AJPABMEPCDO = 1188f;
		Shaking = false;
	}

	private void BMODOIJGIOO()
	{
		if (CCBCCEGBOJP > 1193f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		AJPABMEPCDO = 813f;
		Shaking = false;
	}

	private void CIPKEPDELJB()
	{
		AJPABMEPCDO = 814f;
		Shaking = false;
	}

	private void NKLIHNJCHOG()
	{
		if (CCBCCEGBOJP > 366f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void MMBPLGGLPDB()
	{
		if (CCBCCEGBOJP > 1706f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		AJPABMEPCDO = 1109f;
		Shaking = true;
	}

	public void HBEEJAFHFCG()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 266f * AJPABMEPCDO;
		NGGFNGMNGAC = 1014f;
		Shaking = false;
	}

	private void NCNPAKFAFOE()
	{
		AJPABMEPCDO = 519f;
		Shaking = false;
	}

	private void JILOMOBDPIA()
	{
		AJPABMEPCDO = 23f;
		Shaking = true;
	}

	private void Start()
	{
		AJPABMEPCDO = 1f;
		Shaking = false;
	}

	private void PAKPHKPDKGE()
	{
		AJPABMEPCDO = 206f;
		Shaking = true;
	}

	private void AGMJDGHLBMN()
	{
		if (CCBCCEGBOJP > 1605f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	private void NBGIMIDICKE()
	{
		AJPABMEPCDO = 138f;
		Shaking = false;
	}

	public void IOAFNIKIDIJ()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1534f * AJPABMEPCDO;
		NGGFNGMNGAC = 1733f;
		Shaking = false;
	}

	public void DCKGCKPGPII()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 1236f * AJPABMEPCDO;
		NGGFNGMNGAC = 1059f;
		Shaking = false;
	}

	private void CNGAJDBOCLJ()
	{
		AJPABMEPCDO = 189f;
		Shaking = true;
	}

	private void BEBNOKFLJPH()
	{
		AJPABMEPCDO = 401f;
		Shaking = false;
	}

	private void FOMNCPKKCFN()
	{
		if (CCBCCEGBOJP > 228f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}

	public void PCLJLDJLCKH()
	{
		KCCFEAIFEHC = basePoition;
		CCBCCEGBOJP = 325f * AJPABMEPCDO;
		NGGFNGMNGAC = 44f;
		Shaking = true;
	}

	private void NPLCENPNJBM()
	{
		AJPABMEPCDO = 1749f;
		Shaking = false;
	}

	private void IDIIELPAMCJ()
	{
		if (CCBCCEGBOJP > 393f)
		{
			base.transform.localPosition = new Vector3((KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).x, (KCCFEAIFEHC + Random.insideUnitSphere * CCBCCEGBOJP).y, base.transform.localPosition.z);
			CCBCCEGBOJP -= NGGFNGMNGAC;
		}
		else if (Shaking)
		{
			Shaking = true;
		}
	}
}
