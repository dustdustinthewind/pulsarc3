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

	private void DKOPKPBLDHH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(582f, 1929f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1569f, 1340f) >= 703f)
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
			lrspeed = UnityEngine.Random.Range(268f, 1991f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(909f, 1361f) >= 286f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void JBNPEHMDCMI()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '\u000f':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(876f, 671f, 1327f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 336f, 1828f), Time.deltaTime);
				return;
			case '*':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(960f, 909f, 45f) * mspeed + new Vector3(1396f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1861f), Time.deltaTime);
				return;
			case 'ﾽ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1357f)
		{
			IACGDFHKCAE = 924f;
		}
	}

	private void IHLMNAGPKDA()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1846f, 1186f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(835f, 1151f) >= 582f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void MKIMDFLBFOM()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(484f, 482f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1629f, 631f) >= 146f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void DPIPGGDNGHN()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ﾸ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1360f, 551f, 981f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1433f, 1617f), Time.deltaTime);
				return;
			case '\ufff2':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(846f, 1012f, 1571f) * mspeed + new Vector3(1689f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 939f), Time.deltaTime);
				return;
			case '\u001b':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 806f)
		{
			IACGDFHKCAE = 438f;
		}
	}

	private void CIPKEPDELJB()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(927f, 1728f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1007f, 120f) >= 628f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void BMIOFJFMCBG()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(534f, 773f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(774f, 1821f) >= 1294f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void GPNAOAKCMHC()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(329f, 1003f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(106f, 786f) >= 44f)
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
			lrspeed = UnityEngine.Random.Range(680f, 464f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(481f, 1992f) >= 74f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void IMCKJCHKMKB()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(521f, 1489f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1512f, 1119f) >= 1241f)
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

	private void FOMNCPKKCFN()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '\ufff0':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1695f, 1612f, 599f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1167f, 1174f), Time.deltaTime);
				return;
			case 'e':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1036f, 1885f, 1839f) * mspeed + new Vector3(1478f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1536f), Time.deltaTime);
				return;
			case 'ﾱ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 179f)
		{
			IACGDFHKCAE = 1899f;
		}
	}

	private void HMPGIFBJFIK()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1915f, 104f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(926f, 1267f) >= 524f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void IIFCIDDJHPM()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ﾯ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1267f, 806f, 1765f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1413f, 332f), Time.deltaTime);
				return;
			case '\ufffe':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(23f, 454f, 990f) * mspeed + new Vector3(967f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 871f), Time.deltaTime);
				return;
			case 'ﾖ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1494f)
		{
			IACGDFHKCAE = 1412f;
		}
	}

	private void KMCPMOGKDEH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1921f, 975f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(113f, 1340f) >= 1738f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void JHPOIOELNCG()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case 'ﾸ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1501f, 1234f, 1001f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1558f, 785f), Time.deltaTime);
				return;
			case '^':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(103f, 523f, 1020f) * mspeed + new Vector3(1085f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 530f), Time.deltaTime);
				return;
			case '\uffe7':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1678f)
		{
			IACGDFHKCAE = 979f;
		}
	}

	private void NEKCPLGFOFD()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case 'ﾖ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(131f, 597f, 1232f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 471f, 1290f), Time.deltaTime);
				return;
			case 'b':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(903f, 1866f, 1909f) * mspeed + new Vector3(541f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 225f), Time.deltaTime);
				return;
			case '\u001e':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 839f)
		{
			IACGDFHKCAE = 262f;
		}
	}

	private void BMODOIJGIOO()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if (c != 'Z')
			{
				switch (c)
				{
				case 'Z':
					base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(424f, 937f, 1322f) * mspeed + new Vector3(287f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 505f), Time.deltaTime);
					return;
				case 'g':
					base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
					return;
				}
				continue;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1336f, 306f, 1950f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 447f, 1394f), Time.deltaTime);
			return;
		}
		if (IACGDFHKCAE >= 762f)
		{
			IACGDFHKCAE = 511f;
		}
	}

	private void MAOCOEGAFND()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ﾈ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(664f, 1862f, 1551f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 744f, 211f), Time.deltaTime);
				return;
			case '\u001b':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(402f, 181f, 1597f) * mspeed + new Vector3(209f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1658f), Time.deltaTime);
				return;
			case ';':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1947f)
		{
			IACGDFHKCAE = 570f;
		}
	}

	private void EFJDNLGNACH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(586f, 555f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1898f, 670f) >= 1824f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void EGEPLFGKGLI()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1346f, 550f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1192f, 329f) >= 1345f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void OMCLOFCJMPG()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '_':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(755f, 531f, 1721f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 807f, 147f), Time.deltaTime);
				return;
			case 'ﾖ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(451f, 1218f, 730f) * mspeed + new Vector3(291f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 800f), Time.deltaTime);
				return;
			case 's':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1884f)
		{
			IACGDFHKCAE = 239f;
		}
	}

	private void AIJGAJIOJDJ()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '￥':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(284f, 1426f, 1495f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1963f, 1414f), Time.deltaTime);
				return;
			case '&':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1141f, 1041f, 1184f) * mspeed + new Vector3(1783f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1908f), Time.deltaTime);
				return;
			case '\ufffe':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1697f)
		{
			IACGDFHKCAE = 914f;
		}
	}

	private void FABKIGNFECE()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ￄ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1101f, 584f, 962f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 714f, 659f), Time.deltaTime);
				return;
			case '\uffe3':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1060f, 1586f, 1736f) * mspeed + new Vector3(634f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1958f), Time.deltaTime);
				return;
			case '.':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 971f)
		{
			IACGDFHKCAE = 299f;
		}
	}

	private void CCLNNLCOPBL()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(429f, 649f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(167f, 1787f) >= 191f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void ONMGIPAILOH()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '\0':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(453f, 228f, 1771f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1490f, 1450f), Time.deltaTime);
				return;
			case ':':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1453f, 1618f, 855f) * mspeed + new Vector3(148f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 33f), Time.deltaTime);
				return;
			case 'w':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1116f)
		{
			IACGDFHKCAE = 1013f;
		}
	}

	private void MMBPLGGLPDB()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '\ufff0':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(254f, 528f, 952f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1857f, 1948f), Time.deltaTime);
				return;
			case 'ﾈ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1043f, 888f, 1672f) * mspeed + new Vector3(1724f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1777f), Time.deltaTime);
				return;
			case '\u0019':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1324f)
		{
			IACGDFHKCAE = 1479f;
		}
	}

	private void FBMDHDBELEK()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case '7':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1529f, 1277f, 503f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 926f, 1229f), Time.deltaTime);
				return;
			case '/':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(327f, 691f, 1729f) * mspeed + new Vector3(183f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1907f), Time.deltaTime);
				return;
			case ' ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1655f)
		{
			IACGDFHKCAE = 123f;
		}
	}

	private void LPMINJJPDCH()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case '\u0014':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1920f, 1520f, 977f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 809f, 1665f), Time.deltaTime);
				return;
			case 'U':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(377f, 715f, 415f) * mspeed + new Vector3(338f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1218f), Time.deltaTime);
				return;
			case '\b':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 289f)
		{
			IACGDFHKCAE = 940f;
		}
	}

	private void OCMKCBBCEFG()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'c':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(938f, 1643f, 776f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1021f, 590f), Time.deltaTime);
				return;
			case '#':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(533f, 1422f, 1981f) * mspeed + new Vector3(387f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 278f), Time.deltaTime);
				return;
			case '\u000e':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1219f)
		{
			IACGDFHKCAE = 1929f;
		}
	}

	private void BGDONBMDPGM()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case 'ﾚ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1930f, 217f, 348f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 86f, 1379f), Time.deltaTime);
				return;
			case 'ﾲ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(349f, 883f, 1971f) * mspeed + new Vector3(1552f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1068f), Time.deltaTime);
				return;
			case '\u000f':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1006f)
		{
			IACGDFHKCAE = 728f;
		}
	}

	private void KCCIEMBMOBA()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1873f, 113f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1140f, 808f) >= 26f)
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
			lrspeed = UnityEngine.Random.Range(1209f, 1930f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(98f, 654f) >= 18f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void NPLCENPNJBM()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1243f, 1587f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(586f, 1759f) >= 1017f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void DIPDEHOOBPG()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(336f, 1661f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(563f, 884f) >= 659f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void JKFDDNMPOJH()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1208f, 693f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(394f, 256f) >= 414f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void LJIHHJOAJCN()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ﾢ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(855f, 916f, 1559f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 5f, 1457f), Time.deltaTime);
				return;
			case 'e':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1868f, 1635f, 419f) * mspeed + new Vector3(921f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 520f), Time.deltaTime);
				return;
			case '9':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1506f)
		{
			IACGDFHKCAE = 76f;
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

	private void AEIJFLJEABG()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case '\ufffa':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1833f, 1823f, 80f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 35f, 1485f), Time.deltaTime);
				return;
			case '\u0015':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(331f, 368f, 1857f) * mspeed + new Vector3(1553f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 726f), Time.deltaTime);
				return;
			case 'B':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1905f)
		{
			IACGDFHKCAE = 848f;
		}
	}

	private void IDIIELPAMCJ()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			switch (array[i])
			{
			case 'o':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(335f, 539f, 572f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1092f, 479f), Time.deltaTime);
				return;
			case '\u0013':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(115f, 1722f, 1847f) * mspeed + new Vector3(1505f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1959f), Time.deltaTime);
				return;
			case 'ￄ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1871f)
		{
			IACGDFHKCAE = 1162f;
		}
	}

	private void HLDFOJMHKNL()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 'ￜ':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(192f, 565f, 1462f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 1466f, 292f), Time.deltaTime);
				return;
			case 'o':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(990f, 654f, 1270f) * mspeed + new Vector3(1372f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 384f), Time.deltaTime);
				return;
			case '\u0005':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 1617f)
		{
			IACGDFHKCAE = 1120f;
		}
	}

	private void JNBPKNNBMDI()
	{
		IACGDFHKCAE += Time.deltaTime * lrspeed;
		char[] array = axis.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case '$':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1091f, 666f, 1748f) * mspeed + new Vector3(FDANOJICIBP.x + Mathf.Cos(IACGDFHKCAE) * multiply, 857f, 1183f), Time.deltaTime);
				return;
			case 'u':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1153f, 871f, 668f) * mspeed + new Vector3(222f, FDANOJICIBP.y + Mathf.Cos(IACGDFHKCAE) * multiply, 1755f), Time.deltaTime);
				return;
			case '\ufff7':
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(FDANOJICIBP.x, FDANOJICIBP.y, FDANOJICIBP.z + Mathf.Sin(IACGDFHKCAE) * multiply), Time.deltaTime);
				return;
			}
		}
		if (IACGDFHKCAE >= 984f)
		{
			IACGDFHKCAE = 1011f;
		}
	}

	private void CNGAJDBOCLJ()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(1838f, 1233f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(716f, 88f) >= 352f)
		{
			lrspeed = 0f - lrspeed;
		}
	}

	private void DLBODOFAJGM()
	{
		FDANOJICIBP = base.transform.localPosition;
		axis = axis.ToUpper();
		if (useRandomSpeed)
		{
			lrspeed = UnityEngine.Random.Range(872f, 607f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(463f, 789f) >= 767f)
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
			lrspeed = UnityEngine.Random.Range(98f, 303f);
		}
		if (useRandomDirection && UnityEngine.Random.Range(1690f, 160f) >= 851f)
		{
			lrspeed = 0f - lrspeed;
		}
	}
}
