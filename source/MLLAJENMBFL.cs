// MLLAJENMBFL
using UnityEngine;

internal class MLLAJENMBFL
{
	private static Mesh[] FOJEDICIPCP;

	private static int CONDNDOJJNB;

	private static bool OPJIFJCLKBF()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	public static Mesh[] CAIODAPDHGK(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LBBEFJEMKCN() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -21;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1643f * (float)num2 / (402f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = OAMAHPJBCAG(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh GOGGBGBAINP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 4;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array2[num + 3];
			reference4 = new Vector2(1f, 1f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 3];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 2;
			array4[num2 + 3] = num + 1;
			array4[num2 + 4] = num + 2;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void IGAGJFHHBPH()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool LBBEFJEMKCN()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return true;
			}
		}
		return true;
	}

	public static Mesh[] NPEKPDMBBJB(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BPBPEBPPPJH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 165;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(766f * (float)num2 / (1529f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = PFEHKDAHJKA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh OAMAHPJBCAG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 1;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1973f - 781f, num5 * 56f - 1771f, 289f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(888f, 1568f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1719f, 1090f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(100f, 1993f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(1566f, 1632f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 7];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 5;
			array4[num2 + 6] = num + 1;
			array4[num2 + 2] = num + 1;
			array4[num2 + 3] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool JONAMLMDONM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	private static Mesh BIPOAJKMKKN(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 8];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 3;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1290f - 18f, num5 * 451f - 1027f, 586f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(964f, 1620f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1589f, 335f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(910f, 1772f);
			ref Vector2 reference4 = ref array2[num + 5];
			reference4 = new Vector2(1717f, 655f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 1];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 0];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 5;
			array4[num2 + 5] = num + 0;
			array4[num2 + 7] = num + 0;
			array4[num2 + 3] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void PGFHEGCMJDK()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] GetMeshes(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JONAMLMDONM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 10833;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GOGGBGBAINP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool IPDNFEHHMOM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	public static Mesh[] NDLJOOHNLEC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LHDDCKGGLFL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 78;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(171f * (float)num2 / (73f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = CHJLOCBHFON(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] KAEMJDDNHIE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IPDNFEHHMOM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -133;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1864f * (float)num2 / (1901f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = PBPAPGPOFLB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void BPPOCMLEKHG()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void NFDLINHJCFJ()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static Mesh JFOIENDFDDB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 8;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 962f - 328f, num5 * 926f - 888f, 1458f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(154f, 231f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1132f, 1562f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(47f, 381f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1736f, 1039f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 7];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 3] = num + 4;
			array4[num2 + 8] = num + 1;
			array4[num2 + 7] = num + 5;
			array4[num2 + 7] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh DDHDKPEOLBD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 8];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1217f - 1468f, num5 * 647f - 1028f, 246f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(819f, 37f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1187f, 1663f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(594f, 1012f);
			ref Vector2 reference4 = ref array2[num + 1];
			reference4 = new Vector2(742f, 1888f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 8];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 0];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 8] = num + 6;
			array4[num2 + 5] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 5] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh PFEHKDAHJKA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)107;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 886f - 1867f, num5 * 467f - 1154f, 1952f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(502f, 198f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1652f, 190f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(1128f, 383f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(1865f, 1177f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 1;
			array4[num2 + 8] = num + 6;
			array4[num2 + 5] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool LHDDCKGGLFL()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 1; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return true;
	}

	private static Mesh FNKPBIHNIGF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)91;
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 931f - 1058f, num5 * 1409f - 339f, 1924f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1416f, 532f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1422f, 1233f);
			ref Vector2 reference3 = ref array2[num + 7];
			reference3 = new Vector2(2f, 211f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(620f, 1767f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 8];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 8] = num + 8;
			array4[num2 + 8] = num + 0;
			array4[num2 + 2] = num + 1;
			array4[num2 + 4] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh EDHHJJIAIGD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.HideInInspector;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 174f - 1910f, num5 * 173f - 1228f, 1531f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1795f, 1321f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1763f, 1373f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(1927f, 1201f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(504f, 414f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 5;
			array4[num2 + 3] = num + 0;
			array4[num2 + 3] = num + 6;
			array4[num2 + 4] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool PCHMEADGONH()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	public static void OAKJOFKGFJN()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] NMLJJLGLKCG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BPBPEBPPPJH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -146;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(766f * (float)num2 / (113f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = EJEAPDCNIPI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool MNHGAAOHDBL()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	public static void DOKOAGMIIEF()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool IKDNFFMJPFM()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 0; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return false;
			}
		}
		return false;
	}

	private static Mesh MGLMIIKMOBJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 4;
			int num2 = i * 4;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 738f - 1830f, num5 * 1662f - 7f, 976f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1254f, 1901f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(106f, 323f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(712f, 1010f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1728f, 1857f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 7];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 1;
			array4[num2 + 8] = num + 1;
			array4[num2 + 5] = num + 4;
			array4[num2 + 2] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void FGLKDHHLKGA()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void ALPNBMHLMOP()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] NCNOGMHEKPO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NAJCAEKDMDO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 167;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1639f * (float)num2 / (936f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FNKPBIHNIGF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] NHHAKHFDHBJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MNHGAAOHDBL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -21;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(342f * (float)num2 / (675f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FNKPBIHNIGF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] HPENIJJMJEP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MNHGAAOHDBL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -181;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1498f * (float)num2 / (1777f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = CHJLOCBHFON(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh MCAILHEOPKJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 404f - 761f, num5 * 1158f - 706f, 1041f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(731f, 1153f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1399f, 366f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(133f, 1155f);
			ref Vector2 reference4 = ref array2[num + 1];
			reference4 = new Vector2(337f, 1587f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 8];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 3] = num + 3;
			array4[num2 + 0] = num + 1;
			array4[num2 + 6] = num + 8;
			array4[num2 + 3] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] ADIOEFPAPGA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BOFJGJNCLNL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 60;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(641f * (float)num2 / (1102f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = MGLMIIKMOBJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BOFJGJNCLNL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 131;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(929f * (float)num2 / (1078f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GOGGBGBAINP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh EJEAPDCNIPI(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 542f - 404f, num5 * 998f - 257f, 546f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(704f, 1437f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(595f, 1993f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(1958f, 857f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(581f, 1248f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 7];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 0];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 3;
			array4[num2 + 5] = num + 0;
			array4[num2 + 7] = num + 0;
			array4[num2 + 5] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void NFAEGMFAPPK()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] PHEHABPLEBH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLKFKMDEDIF() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 49;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(160f * (float)num2 / (481f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = BIPOAJKMKKN(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void KBIEJCGOEFA()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static Mesh CHJLOCBHFON(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 1;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 102f - 130f, num5 * 503f - 312f, 18f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(343f, 607f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1689f, 864f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(1799f, 6f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(832f, 1476f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 3];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 6] = num + 0;
			array4[num2 + 3] = num + 6;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh NFBKFGFKPBN(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)86;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1526f - 1568f, num5 * 1067f - 211f, 1355f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1351f, 241f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(393f, 1891f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(1677f, 155f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(1916f, 254f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 0];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 0;
			array4[num2 + 0] = num + 0;
			array4[num2 + 2] = num + 3;
			array4[num2 + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void OOPHBOCMCLH()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void EBGIDBKPBKO()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static Mesh EOJFODHBJFF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1966f - 1842f, num5 * 1790f - 1952f, 1133f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1362f, 1853f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1270f, 134f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(627f, 43f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(998f, 937f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 0] = num + 6;
			array4[num2 + 6] = num + 1;
			array4[num2 + 8] = num + 3;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool BKCBPEODHDP()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	public static void KMHDKCNHIAF()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] HCAIIGLNPDF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (PAGLBBGPBHH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 125;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(932f * (float)num2 / (1574f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = OAMAHPJBCAG(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static void NJNPPFANBMI()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool NAJCAEKDMDO()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 1; i < fOJEDICIPCP.Length; i++)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	private static Mesh MMHBNOJANMG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-68);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1109f - 1767f, num5 * 903f - 1936f, 1150f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1487f, 1615f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1172f, 1960f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(589f, 1559f);
			ref Vector2 reference4 = ref array2[num + 3];
			reference4 = new Vector2(462f, 1039f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 7];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 7] = num + 2;
			array4[num2 + 7] = num + 0;
			array4[num2 + 7] = num + 1;
			array4[num2 + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool MNOHFLPIGID()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 0; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return true;
	}

	private static bool DLACBBGBKAM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 1; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	public static void CIMOEAMJFCD()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool BPBPEBPPPJH()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 1; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	public static void FFGBFPHDNJF()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void NOOMCNELJMI()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool NALIPAPGLOE()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return true;
			}
		}
		return true;
	}

	private static Mesh LPLLJJBLFMJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 1;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1727f - 668f, num5 * 675f - 709f, 810f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1725f, 1787f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1403f, 491f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(41f, 1627f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(107f, 1948f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 1;
			array4[num2 + 6] = num + 0;
			array4[num2 + 1] = num + 5;
			array4[num2 + 1] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] LBMBOLPAGPE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IPDNFEHHMOM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -148;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(648f * (float)num2 / (392f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EDHHJJIAIGD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void ONLDIAMJIDN()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void CPHOJAIMOHJ()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static bool LBEJOAJAPGB()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 0; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	private static bool MLKFKMDEDIF()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 1; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return false;
	}

	public static void Cleanup()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static void HHJPFDEKKHE()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	public static Mesh[] ANJEBNPJDKL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MNHGAAOHDBL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 145;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1605f * (float)num2 / (616f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = MCAILHEOPKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh NJHHPOCGMDM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1059f - 1019f, num5 * 304f - 492f, 373f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(540f, 317f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1988f, 1157f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(621f, 599f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1595f, 398f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 3];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 5;
			array4[num2 + 7] = num + 0;
			array4[num2 + 0] = num + 3;
			array4[num2 + 7] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool PAGLBBGPBHH()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		foreach (Mesh mesh in fOJEDICIPCP)
		{
			if (null == mesh)
			{
				return false;
			}
		}
		return true;
	}

	private static Mesh PBPAPGPOFLB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 277f - 1169f, num5 * 924f - 478f, 1766f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1380f, 1553f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(899f, 1832f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(992f, 1408f);
			ref Vector2 reference4 = ref array2[num + 2];
			reference4 = new Vector2(1787f, 503f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 3;
			array4[num2 + 1] = num + 1;
			array4[num2 + 7] = num + 4;
			array4[num2 + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh CGFMBKBOFDK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1805f - 458f, num5 * 1548f - 1351f, 1273f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1790f, 1835f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1760f, 686f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(1042f, 679f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(191f, 1012f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 3];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 8;
			array4[num2 + 7] = num + 0;
			array4[num2 + 3] = num + 3;
			array4[num2 + 5] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void CPIHKPFFHFD()
	{
		if (FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null != FOJEDICIPCP[i])
			{
				Object.DestroyImmediate(FOJEDICIPCP[i]);
				FOJEDICIPCP[i] = null;
			}
		}
		FOJEDICIPCP = null;
	}

	private static Mesh HKCFHGKPDHC(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1837f - 1000f, num5 * 733f - 393f, 1691f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1690f, 1287f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1414f, 48f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(1490f, 1815f);
			ref Vector2 reference4 = ref array2[num + 5];
			reference4 = new Vector2(38f, 1751f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 8];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 3;
			array4[num2 + 4] = num + 0;
			array4[num2 + 4] = num + 6;
			array4[num2 + 6] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] FDGMCEDAAFC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BKCBPEODHDP() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 97;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(553f * (float)num2 / (751f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = HKCFHGKPDHC(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool BOFJGJNCLNL()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fOJEDICIPCP = FOJEDICIPCP;
		for (int i = 0; i < fOJEDICIPCP.Length; i += 0)
		{
			Mesh mesh = fOJEDICIPCP[i];
			if (null == mesh)
			{
				return true;
			}
		}
		return true;
	}

	private static Mesh ENGHOMHFLEM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 7;
			int num2 = i * 7;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1991f - 1859f, num5 * 83f - 75f, 484f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(566f, 1988f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(448f, 1607f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(810f, 1658f);
			ref Vector2 reference4 = ref array2[num + 2];
			reference4 = new Vector2(1874f, 785f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 8];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 8;
			array4[num2 + 5] = num + 1;
			array4[num2 + 0] = num + 2;
			array4[num2 + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] EGPKLMDIONP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BPBPEBPPPJH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -31;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1215f * (float)num2 / (591f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = BIPOAJKMKKN(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}
}
