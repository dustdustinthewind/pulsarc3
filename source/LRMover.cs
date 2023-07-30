// LRMover
using System;
using UnityEngine;

public class LRMover : MonoBehaviour
{
	private float IACGDFHKCAE;

	public float multiply = 3f;

	public float mspeed = 50f;

	public float lrspeed = 1f;

	public bool useRandomDirection;

	public bool useRandomSpeed;

	public string axis = "X";

	private Vector3 FDANOJICIBP;

	private void JKFDDNMPOJH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1253f, 1359f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(560f, 1138f) >= 16f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void NNCCPEBIAKH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1949f, 93f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(725f, 531f) >= 924f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void AEIJFLJEABG()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case 'z':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(325f, 77f, 1330f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1936f, 1265f), Time.deltaTime);
				return;
			case '<':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1497f, 669f, 628f) * mspeed + new Vector3(1111f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 518f), Time.deltaTime);
				return;
			case '\f':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 923f)
		{
			IACGDFHKCAE = 1188f;
		}
	}

	private void MMBPLGGLPDB()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case ')':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1615f, 1386f, 1231f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1447f, 853f), Time.deltaTime);
				return;
			case '￨':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1611f, 703f, 1493f) * mspeed + new Vector3(1416f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 278f), Time.deltaTime);
				return;
			case 'v':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1557f)
		{
			IACGDFHKCAE = 879f;
		}
	}

	private void CCLNNLCOPBL()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(305f, 898f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1238f, 1077f) >= 1436f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void BGFJOEPFOPM()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		foreach (char c in array)
		{
			if (c != -100)
			{
				switch (c)
				{
				case 'ﾜ':
					base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1145f, 993f, 288f) * mspeed + new Vector3(1856f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 269f), Time.deltaTime);
					return;
				case '\ufff9':
					base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
					return;
				}
				continue;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1537f, 783f, 725f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 179f, 1504f), Time.deltaTime);
			return;
		}
		if (IACGDFHKCAE >= 1895f)
		{
			IACGDFHKCAE = 34f;
		}
	}

	private void IMCKJCHKMKB()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(991f, 1964f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1609f, 360f) >= 1400f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void KLILJHJNICK()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(56f, 354f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(120f, 1482f) >= 1701f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void FIKFJDFELIP()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(660f, 1051f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1943f, 1708f) >= 618f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void Start()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(0.1f, 5f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(0f, 1f) >= 0.5f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void NCNPAKFAFOE()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1836f, 1836f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(133f, 1167f) >= 1945f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void CIPKEPDELJB()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(667f, 1442f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1105f, 1860f) >= 391f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void DNNFHBOOPIN()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1999f, 487f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1938f, 1960f) >= 866f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void Update()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'X':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 0f, 0f), Time.deltaTime);
				return;
			case 'Y':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * mspeed + new Vector3(0f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 0f), Time.deltaTime);
				return;
			case 'Z':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= (float)Math.PI * 2f)
		{
			IACGDFHKCAE = 0f;
		}
	}

	private void NBGIMIDICKE()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1636f, 1147f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(909f, 97f) >= 1522f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void BEBNOKFLJPH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(976f, 391f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1682f, 47f) >= 1673f)
		{
			lrspeed = 0f - lrspeed;
		}
	}
}
