// MLLAJENMBFL
using UnityEngine;

internal class MLLAJENMBFL
{
	private static Mesh[] FOJEDICIPCP;

	private static int CONDNDOJJNB;

	public static void DHBIJICEAKN()
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

	private static Mesh DDHDKPEOLBD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 379f - 1161f, num5 * 66f - 1767f, 1525f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(550f, 1624f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1844f, 792f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(538f, 1046f);
			ref Vector2 reference4 = ref array2[num + 3];
			reference4 = new Vector2(1978f, 967f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 7];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 7] = num + 1;
			array4[num2 + 1] = num + 6;
			array4[num2 + 1] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void DJNJKEPIDCB()
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

	public static Mesh[] LEHNHPHMJDG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NJBHPDECJFA() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 33;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(92f * (float)num2 / (1080f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = JOGFILFAPEA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void GLJEPGDGLLE()
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

	private static Mesh BCCLHOJAOEC(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 3;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 393f - 295f, num5 * 1992f - 688f, 790f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1184f, 1085f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(338f, 1866f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(658f, 1476f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1377f, 640f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 3] = num + 3;
			array4[num2 + 5] = num + 0;
			array4[num2 + 8] = num + 5;
			array4[num2 + 8] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] EJLIAAMHFFA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JIDPGKPAEOG() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -56;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1221f * (float)num2 / (1665f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = GLNEGPDFPOD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh EJEAPDCNIPI(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 653f - 335f, num5 * 329f - 522f, 874f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(99f, 1340f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(601f, 1173f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(1723f, 916f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(239f, 1983f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 1];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 1] = num + 5;
			array4[num2 + 6] = num + 1;
			array4[num2 + 2] = num + 0;
			array4[num2 + 4] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh GKCJJEOEEKJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1841f - 24f, num5 * 1654f - 969f, 634f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(920f, 1987f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(341f, 1037f);
			ref Vector2 reference3 = ref array2[num + 7];
			reference3 = new Vector2(1271f, 1711f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(277f, 545f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 7];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 1] = num + 3;
			array4[num2 + 6] = num + 0;
			array4[num2 + 2] = num + 2;
			array4[num2 + 0] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh BIPOAJKMKKN(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 906f - 1944f, num5 * 1345f - 1354f, 1786f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1885f, 1873f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(247f, 390f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(670f, 611f);
			ref Vector2 reference4 = ref array2[num + 0];
			reference4 = new Vector2(708f, 1089f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 3;
			array4[num2 + 4] = num + 1;
			array4[num2 + 6] = num + 0;
			array4[num2 + 5] = num + 0;
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
		return false;
	}

	public static void DNCENFPBDCL()
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

	public static void KBIEJCGOEFA()
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

	public static Mesh[] FEPPNCLOGCN(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -171;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1278f * (float)num2 / (12f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = LNOPDCOBNGJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] HJKCKJCLEEO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NIPEJBEBCMO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 167;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(76f * (float)num2 / (785f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ABANKGCBHPB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool NILCIONGPOH()
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
				return false;
			}
		}
		return true;
	}

	private static bool OKOPPGEHECP()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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

	private static bool JODGMEIIJOE()
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
		return false;
	}

	public static Mesh[] BLOHGEFIGEC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (DMAPFEFBEOA() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 94;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1260f * (float)num2 / (482f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GLNEGPDFPOD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void EMACFHKJBHF()
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

	private static Mesh FHIDHDJPIOM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1121f - 583f, num5 * 1560f - 1871f, 274f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1553f, 1019f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(263f, 1951f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(1174f, 52f);
			ref Vector2 reference4 = ref array2[num + 2];
			reference4 = new Vector2(329f, 681f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 3];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 2] = num + 4;
			array4[num2 + 0] = num + 1;
			array4[num2 + 8] = num + 0;
			array4[num2 + 7] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool PECOGPGFCNN()
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
				return false;
			}
		}
		return true;
	}

	public static Mesh[] DEMAKJGICFD(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LBEJOAJAPGB() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 24;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1303f * (float)num2 / (1163f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = KPPPCDIPLPM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh GLNEGPDFPOD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)101;
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 137f - 1115f, num5 * 853f - 1753f, 1213f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1672f, 1179f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1762f, 592f);
			ref Vector2 reference3 = ref array2[num + 0];
			reference3 = new Vector2(1747f, 1350f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(1238f, 825f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 5;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 2;
			array4[num2 + 5] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool NIPEJBEBCMO()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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

	public static Mesh[] EOPOCILHDPN(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (KFIHECIEGOO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 160;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(61f * (float)num2 / (1612f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = KPPPCDIPLPM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] HCAIIGLNPDF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HLGAIKGPCDK() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 45;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(329f * (float)num2 / (859f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = ABANKGCBHPB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] HLHENFJODJP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (ACJJACIJIAI() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -102;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1329f * (float)num2 / (730f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GKCJJEOEEKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool COMHKEPCGHG()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
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

	private static Mesh HCNAJLPHIGP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)110;
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1280f - 1233f, num5 * 1281f - 330f, 1700f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1204f, 366f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(483f, 24f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(983f, 1693f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(1990f, 1028f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 5];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 0];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 4] = num + 5;
			array4[num2 + 2] = num + 0;
			array4[num2 + 4] = num + 2;
			array4[num2 + 3] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void MHNDJOIJBCI()
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

	private static Mesh FHKIMEAMMKI(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.HideAndDontSave;
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 444f - 1023f, num5 * 16f - 1352f, 1611f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1315f, 704f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(335f, 1838f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(1062f, 231f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(538f, 1854f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 7] = num + 6;
			array4[num2 + 8] = num + 0;
			array4[num2 + 7] = num + 8;
			array4[num2 + 7] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] NDPKAPNLPHI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (EHGCAOPBLIF() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -60;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(978f * (float)num2 / (1563f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = EEDLHNKBPGD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh EOOJCPKGKOP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = i * 8;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 244f - 147f, num5 * 1344f - 735f, 1594f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(830f, 183f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(529f, 403f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(814f, 630f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(315f, 602f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 8];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 5] = num + 1;
			array4[num2 + 6] = num + 0;
			array4[num2 + 8] = num + 0;
			array4[num2 + 6] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void IADOAKMIONM()
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

	public static Mesh[] BKPLIIKPAMC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 82;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(429f * (float)num2 / (524f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EJEAPDCNIPI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
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

	public static Mesh[] BLEFCEKDNNE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OJKMDFDNJEM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -129;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1570f * (float)num2 / (361f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EJEAPDCNIPI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] PPBLFFKLCHF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OJPGHJLINOE() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -9;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1326f * (float)num2 / (1748f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = BIPOAJKMKKN(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] CFCMDBADGDE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 14;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1517f * (float)num2 / (397f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = EOOJCPKGKOP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] AAJICDGGKBE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MJGCADPBBFA() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -77;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(879f * (float)num2 / (81f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ENGJGAMKAHH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] PHADPCGGPEI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CADENPBBFAO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -164;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1277f * (float)num2 / (1771f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GKCJJEOEEKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] ODDEDHPFCKG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 102;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1803f * (float)num2 / (1662f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = BNHMBOMANBF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool HLGAIKGPCDK()
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
		return true;
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

	private static Mesh JEFCEBBPDJD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1458f - 87f, num5 * 1193f - 167f, 1774f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1099f, 1659f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1591f, 1506f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(584f, 734f);
			ref Vector2 reference4 = ref array2[num + 4];
			reference4 = new Vector2(874f, 740f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 1];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 7];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 3;
			array4[num2 + 5] = num + 1;
			array4[num2 + 5] = num + 3;
			array4[num2 + 7] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] BOBGKNJILEJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (ACJJACIJIAI() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -140;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1573f * (float)num2 / (1021f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = DLDLJKFJMDD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool MJGCADPBBFA()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
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

	public static Mesh[] KNPKHPBGJAB(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JIDPGKPAEOG() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 54;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1379f * (float)num2 / (1482f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = FHKIMEAMMKI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void OIHKKNHLAHE()
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

	public static Mesh[] EGJAPNEHLHJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OPJIFJCLKBF() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -4;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1410f * (float)num2 / (1182f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = ABANKGCBHPB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void CLECCMJDEMG()
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

	public static Mesh[] DCIKEFMKJPM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JIDPGKPAEOG() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -45;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(700f * (float)num2 / (1416f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = FHIDHDJPIOM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static void GLIGCNFPJJJ()
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

	public static void MGBANHIGKMD()
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

	private static bool JOPGFOKJFPP()
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

	private static bool CADENPBBFAO()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
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

	private static bool NJBHPDECJFA()
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

	public static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OKOPPGEHECP() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 136;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1037f * (float)num2 / (1521f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EJEAPDCNIPI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool IFJLAHMBAHH()
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

	public static void KPOJOJNNHEI()
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

	public static void EGHJNMGFJKK()
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

	public static void PGLJHPLMJBO()
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

	public static Mesh[] DFPEAFILCPJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CMOHEGBJPBJ() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 3;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(493f * (float)num2 / (154f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EJEAPDCNIPI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static void FGLKDHHLKGA()
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

	public static void NBGBEODBEKO()
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

	private static Mesh ENGJGAMKAHH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 226f - 1524f, num5 * 1969f - 1764f, 959f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1024f, 1749f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(344f, 1236f);
			ref Vector2 reference3 = ref array2[num + 7];
			reference3 = new Vector2(835f, 37f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1639f, 383f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 3];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 3] = num + 7;
			array4[num2 + 7] = num + 1;
			array4[num2 + 1] = num + 7;
			array4[num2 + 0] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool CMOHEGBJPBJ()
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
				return false;
			}
		}
		return true;
	}

	private static bool HBACHMONCGF()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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

	public static void EPNDCPIMONB()
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

	private static bool KFIHECIEGOO()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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
		return false;
	}

	public static Mesh[] DGMACGLIKLO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NAJCAEKDMDO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 182;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(133f * (float)num2 / (45f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = DLDLJKFJMDD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] PGEHFKFBHIA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NAJCAEKDMDO() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 166;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1886f * (float)num2 / (1183f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GKCJJEOEEKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] ANJEBNPJDKL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (DMAPFEFBEOA() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 59;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1223f * (float)num2 / (1193f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = BIKJIJENENE(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool MCCPHBGPFLN()
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
		return false;
	}

	private static bool JLAHFJCELPA()
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

	public static Mesh[] KLOEBIKIAIA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCGNCPJGLPM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -26;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(597f * (float)num2 / (1622f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = BNHMBOMANBF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] JCKNJDANHPK(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (PAGLBBGPBHH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 94;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1307f * (float)num2 / (383f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FHKIMEAMMKI(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] DKLJAFEMFON(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JONAMLMDONM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 151;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(396f * (float)num2 / (381f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GKCJJEOEEKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh JOGFILFAPEA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-102);
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1295f - 1400f, num5 * 1563f - 791f, 220f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1525f, 1472f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1461f, 582f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(1938f, 785f);
			ref Vector2 reference4 = ref array2[num + 1];
			reference4 = new Vector2(1484f, 770f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 1];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 2] = num + 7;
			array4[num2 + 3] = num + 1;
			array4[num2 + 5] = num + 4;
			array4[num2 + 4] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool BOFJGJNCLNL()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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

	public static void EBGIDBKPBKO()
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

	public static Mesh[] LCHCBPAOLDJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IFJLAHMBAHH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 48;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1737f * (float)num2 / (1896f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FHIDHDJPIOM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static void HDCGIJELJLM()
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

	private static bool NAJCAEKDMDO()
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

	public static Mesh[] KEDCKIBEOHM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (COMHKEPCGHG() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -37;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1410f * (float)num2 / (660f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FHIDHDJPIOM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool JIDPGKPAEOG()
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
				return false;
			}
		}
		return true;
	}

	private static bool DMAPFEFBEOA()
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

	public static void IFJJOHBDMAK()
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

	public static void HHJPFDEKKHE()
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

	public static void DHGFPAGJIHL()
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

	private static Mesh KPPPCDIPLPM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)119;
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 3;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1115f - 1479f, num5 * 1209f - 1510f, 1114f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(597f, 646f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1560f, 1767f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(1345f, 460f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(1946f, 808f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 5] = num + 1;
			array4[num2 + 0] = num + 1;
			array4[num2 + 5] = num + 8;
			array4[num2 + 2] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool OJKMDFDNJEM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
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

	private static Mesh LNOPDCOBNGJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 4;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1965f - 302f, num5 * 1592f - 1377f, 1567f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(116f, 1766f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1538f, 1236f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(984f, 911f);
			ref Vector2 reference4 = ref array2[num + 1];
			reference4 = new Vector2(1285f, 49f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 4];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 5] = num + 0;
			array4[num2 + 8] = num + 1;
			array4[num2 + 7] = num + 2;
			array4[num2 + 3] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void GCGFBJNLJPK()
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

	private static bool OJPGHJLINOE()
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

	private static bool GPJCPMOPIOL()
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

	public static Mesh[] MCFLDEBJDPI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JONAMLMDONM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 132;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(258f * (float)num2 / (1709f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = DDHDKPEOLBD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

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
				return true;
			}
		}
		return false;
	}

	public static void CGCBEOAKCFC()
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

	private static Mesh FGFDIMKNMHL(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 1;
			int num2 = i * 8;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 566f - 1590f, num5 * 250f - 188f, 151f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1045f, 1900f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(88f, 1805f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(564f, 16f);
			ref Vector2 reference4 = ref array2[num + 1];
			reference4 = new Vector2(1935f, 968f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 7;
			array4[num2 + 8] = num + 1;
			array4[num2 + 2] = num + 2;
			array4[num2 + 8] = num + 4;
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

	private static Mesh AJDCBGFOOHA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-116);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 6;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 958f - 1915f, num5 * 1671f - 828f, 512f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1665f, 1311f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1182f, 632f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(1915f, 1772f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(965f, 1900f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 2];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 6];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 0] = num + 8;
			array4[num2 + 8] = num + 1;
			array4[num2 + 2] = num + 3;
			array4[num2 + 5] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] HDGGPJPHPHP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OJKMDFDNJEM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 109;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(934f * (float)num2 / (356f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = GKCJJEOEEKJ(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void PEJKFPGEGDH()
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

	public static void FEAHIIBGBJA()
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

	public static void DIHLIKKAGNG()
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

	private static bool KCLHIJKLFNA()
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

	public static void NJNPPFANBMI()
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

	public static Mesh[] DFEHPNIPHJM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LBEJOAJAPGB() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 121;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(508f * (float)num2 / (791f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GLNEGPDFPOD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh DFLDIOIHPBA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-70);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = i * 4;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1858f - 652f, num5 * 215f - 827f, 1305f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1941f, 1551f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1822f, 384f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(1580f, 1608f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1655f, 1814f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 5] = num + 0;
			array4[num2 + 8] = num + 0;
			array4[num2 + 4] = num + 0;
			array4[num2 + 1] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void IAJOLHONDNF()
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

	public static void HFOJIHCDBLB()
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

	public static Mesh[] MFLFAHLHNOC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (GPJCPMOPIOL() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -64;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(657f * (float)num2 / (156f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ABANKGCBHPB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static void ELAOOANDDGH()
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

	public static Mesh[] MADHIJFAJAC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JOPGFOKJFPP() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 192;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1019f * (float)num2 / (1651f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ENGJGAMKAHH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static void IDLBBKFJHKJ()
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

	public static Mesh[] BDNLDCBOBDO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (KCLHIJKLFNA() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -164;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(974f * (float)num2 / (1419f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = ABOCPNPEPKF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] FJIMIMKENAL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OJKMDFDNJEM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -39;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(389f * (float)num2 / (1602f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EOOJCPKGKOP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh ICOPMCJOAMM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 467f - 1086f, num5 * 979f - 1124f, 1766f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(959f, 398f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(17f, 426f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(492f, 1697f);
			ref Vector2 reference4 = ref array2[num + 7];
			reference4 = new Vector2(1730f, 1453f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 7];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 8] = num + 6;
			array4[num2 + 7] = num + 0;
			array4[num2 + 3] = num + 0;
			array4[num2 + 2] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh BNHMBOMANBF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-100);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1038f - 1019f, num5 * 1776f - 128f, 1377f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1387f, 611f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(273f, 701f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(23f, 569f);
			ref Vector2 reference4 = ref array2[num + 6];
			reference4 = new Vector2(1147f, 130f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 0];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 7] = num + 8;
			array4[num2 + 5] = num + 1;
			array4[num2 + 7] = num + 5;
			array4[num2 + 8] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static void NFJBGHOBKEP()
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

	private static Mesh DLDLJKFJMDD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-75);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 329f - 293f, num5 * 1133f - 655f, 1305f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1766f, 208f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1435f, 1916f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(1506f, 1795f);
			ref Vector2 reference4 = ref array2[num + 0];
			reference4 = new Vector2(78f, 509f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 7];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 4;
			array4[num2 + 1] = num + 0;
			array4[num2 + 0] = num + 6;
			array4[num2 + 0] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh AKJEJFDBNIH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)101;
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1005f - 604f, num5 * 651f - 700f, 1370f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1934f, 101f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(596f, 1499f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(1728f, 803f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(378f, 1843f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 1;
			array4[num2 + 4] = num + 1;
			array4[num2 + 2] = num + 6;
			array4[num2 + 7] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] IHMCMBCAPAN(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCGNCPJGLPM() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 125;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1051f * (float)num2 / (1303f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FGFDIMKNMHL(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] OJDLGECHMCI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HBACHMONCGF() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -17;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(326f * (float)num2 / (168f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = AKJEJFDBNIH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool MCGNCPJGLPM()
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
				return false;
			}
		}
		return true;
	}

	public static void HDKABBKFDMP()
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
				return true;
			}
		}
		return false;
	}

	private static bool EHGCAOPBLIF()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
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
		return false;
	}

	private static Mesh ABOCPNPEPKF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 8];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 404f - 1881f, num5 * 1333f - 721f, 1052f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1201f, 486f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(280f, 1842f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(785f, 941f);
			ref Vector2 reference4 = ref array2[num + 8];
			reference4 = new Vector2(1487f, 457f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 1];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 4];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 5;
			array4[num2 + 4] = num + 0;
			array4[num2 + 7] = num + 2;
			array4[num2 + 4] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh EEDLHNKBPGD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 4;
			int num2 = i * 7;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1006f - 1145f, num5 * 93f - 1108f, 1593f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(670f, 1346f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(792f, 1365f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(682f, 1364f);
			ref Vector2 reference4 = ref array2[num + 2];
			reference4 = new Vector2(255f, 719f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 8];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 5];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 2;
			array4[num2 + 3] = num + 0;
			array4[num2 + 3] = num + 7;
			array4[num2 + 6] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh BIKJIJENENE(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-95);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 8];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 4;
			int num2 = i * 7;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1363f - 48f, num5 * 487f - 1291f, 1310f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(163f, 1777f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(626f, 483f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(432f, 1892f);
			ref Vector2 reference4 = ref array2[num + 3];
			reference4 = new Vector2(790f, 1417f);
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
			array4[num2 + 5] = num + 5;
			array4[num2 + 2] = num + 0;
			array4[num2 + 1] = num + 8;
			array4[num2 + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public static Mesh[] KOEMJDOKMNH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OJPGHJLINOE() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -136;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(783f * (float)num2 / (1436f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = BCCLHOJAOEC(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool ACJJACIJIAI()
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

	public static Mesh[] NMLJJLGLKCG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (NILCIONGPOH() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -81;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(293f * (float)num2 / (1271f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = BCCLHOJAOEC(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	public static Mesh[] NCAFLCBEPAJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JIDPGKPAEOG() && CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 33;
		int num2 = (CONDNDOJJNB = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1359f * (float)num2 / (711f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = GOGGBGBAINP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh ABANKGCBHPB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 5;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor(num3 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor(num3 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 56f - 1237f, num5 * 1135f - 880f, 675f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(510f, 902f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1919f, 1287f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(1414f, 1387f);
			ref Vector2 reference4 = ref array2[num + 0];
			reference4 = new Vector2(736f, 836f);
			ref Vector2 reference5 = ref array3[num];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num4, num5);
			ref Vector2 reference7 = ref array3[num + 6];
			reference7 = new Vector2(num4, num5);
			ref Vector2 reference8 = ref array3[num + 2];
			reference8 = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 5] = num + 2;
			array4[num2 + 5] = num + 1;
			array4[num2 + 7] = num + 4;
			array4[num2 + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}
}
