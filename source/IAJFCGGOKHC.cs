// IAJFCGGOKHC
using UnityEngine;

internal class IAJFCGGOKHC
{
	private static Mesh[] FOJEDICIPCP;

	private static int EAHEGOOCLEN;

	private static void LCBEBBKFPAP()
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

	private static Mesh[] BKIJCCIDNHD(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (PJJLAKFHFPJ() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 84;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(165f * (float)num2 / (860f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = AFNNCLKIPJK(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] COGNFOPNBMM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HNOJOKEKFPE() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 116;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1653f * (float)num2 / (970f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = EDHHJJIAIGD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static void PGFHEGCMJDK()
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

	private static Mesh GKDJAJFDGEK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)114;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 441f - 808f, num4 * 934f - 599f, 914f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1626f, 634f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(252f, 578f);
			ref Vector2 reference3 = ref array2[num + 0];
			reference3 = new Vector2(216f, 1333f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 3];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 4] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void KMHDKCNHIAF()
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

	private static void IDLBBKFJHKJ()
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

	private static Mesh JOGFILFAPEA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1130f - 1744f, num4 * 1768f - 575f, 207f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(86f, 233f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(491f, 1706f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(142f, 1028f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 8];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 4] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool HNOJOKEKFPE()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool DHFAFDMDHPK()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	private static Mesh KPPPCDIPLPM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1344f - 1012f, num4 * 115f - 1535f, 1432f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1543f, 1549f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(879f, 1007f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(1470f, 1830f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 8];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 2] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void CPHOJAIMOHJ()
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

	private static Mesh PGFBHPKNLNH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)82;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 157f - 321f, num4 * 688f - 318f, 888f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1897f, 670f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1279f, 1457f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(1785f, 1358f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 4];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 5] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void MLIGGBLNODB()
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

	private static Mesh[] LBMBOLPAGPE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (DHFAFDMDHPK() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -103;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1686f * (float)num2 / (1968f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = HKCFHGKPDHC(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh MCDJHDLLLCO(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)127;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 4;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1207f - 1489f, num4 * 710f - 364f, 1179f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1759f, 1571f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1792f, 1522f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(1886f, 996f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 6];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool IELOEEKBADJ()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static void GOFADNOCCAN()
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

	private static void CIMOEAMJFCD()
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

	private static Mesh GOGGBGBAINP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 3;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 2];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void NCBOPFJOJFF()
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

	private static bool KMPAFFJKBNB()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static void KBIEJCGOEFA()
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

	private static void FAFFINAGBND()
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

	private static void NFLDEAKCMGJ()
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

	private static Mesh[] FDGMCEDAAFC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OBFKJDOKHNB() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -90;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(767f * (float)num2 / (1419f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = EDHHJJIAIGD(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static void GLIGCNFPJJJ()
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

	private static Mesh[] HHFDDHCEBLP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JODGMEIIJOE() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 35;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(641f * (float)num2 / (1239f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = JOGFILFAPEA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] BPOFLNNBPCC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JONAMLMDONM() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 21666;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
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

	private static Mesh NJHHPOCGMDM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-119);
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 67f - 1740f, num4 * 1871f - 1559f, 1212f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(44f, 1328f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1533f, 531f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(243f, 1663f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 6] = num + 2;
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
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static void DFNCDAJLEGI()
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

	private static void CEEJMFFDGJA()
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

	private static void ALPNBMHLMOP()
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

	private static bool JKNKFJFHNHG()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
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
			return true;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static void HHJPFDEKKHE()
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

	private static void CIOGIPBMIFO()
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

	private static bool LMKJADGAADA()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static Mesh IDNDHCHGAND(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 1;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1863f - 1565f, num4 * 1611f - 557f, 340f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1225f, 277f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1510f, 1278f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(1793f, 1181f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 7];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 0] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void NFJBGHOBKEP()
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

	private static void IKNEIFALLLE()
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
		mesh.hideFlags = (HideFlags)(-122);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 1;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 122f - 1567f, num4 * 1191f - 1048f, 1420f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(133f, 1118f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(247f, 363f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(1631f, 97f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 3] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool JGOCGEPFDBI()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
	}

	private static Mesh[] KAEMJDDNHIE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (PAGLBBGPBHH() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 67;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(828f * (float)num2 / (216f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = AFNNCLKIPJK(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool PCHMEADGONH()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static bool LADAFOCDHFA()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	private static bool JONAMLMDONM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static Mesh[] MADHIJFAJAC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (EKKGJCAPHFM() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -194;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1477f * (float)num2 / (853f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = KPPPCDIPLPM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JGOCGEPFDBI() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 164;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(655f * (float)num2 / (486f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = AFNNCLKIPJK(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool OBFKJDOKHNB()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool EKKGJCAPHFM()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static void NGHJLJEDIEM()
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

	private static bool AFDCOFPAGIC()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	private static Mesh MEKCEKKHBOK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)113;
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 8];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 5;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 74f - 1020f, num4 * 1024f - 630f, 366f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(211f, 830f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(315f, 736f);
			ref Vector2 reference3 = ref array2[num + 0];
			reference3 = new Vector2(657f, 356f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 6];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 1] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh FNKPBIHNIGF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)74;
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 22f - 421f, num4 * 931f - 1126f, 1601f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1590f, 1384f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(12f, 1825f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(962f, 483f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 4] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh KFLBEFPEEGF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-66);
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 8];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 207f - 958f, num4 * 324f - 54f, 1842f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1394f, 574f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(359f, 449f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(1207f, 1351f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 3];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 2] = num + 6;
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
		mesh.hideFlags = (HideFlags)(-110);
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1836f - 1003f, num4 * 284f - 511f, 1501f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1199f, 562f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1254f, 1657f);
			ref Vector2 reference3 = ref array2[num + 7];
			reference3 = new Vector2(1536f, 1683f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 6];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 0] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh[] PHEHABPLEBH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JODGMEIIJOE() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -59;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(980f * (float)num2 / (1098f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = MEKCEKKHBOK(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void EFFNKIOCBHH()
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

	private static Mesh[] HDDEOEIOKFD(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (OBFKJDOKHNB() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -87;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(406f * (float)num2 / (1530f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = JOGFILFAPEA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] DFEHPNIPHJM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LADAFOCDHFA() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -53;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1233f * (float)num2 / (1099f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = FNKPBIHNIGF(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] CFCMDBADGDE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (LMKJADGAADA() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -92;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(560f * (float)num2 / (681f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = GOGGBGBAINP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh AFNNCLKIPJK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1331f - 1606f, num4 * 1613f - 1152f, 351f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1184f, 945f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1589f, 1526f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(970f, 1295f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 2] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool MCGNCPJGLPM()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static bool PJJLAKFHFPJ()
	{
		if (FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return false;
	}

	private static void MIPDDLBMPCO()
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

	private static Mesh[] KLOEBIKIAIA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IELOEEKBADJ() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -142;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1560f * (float)num2 / (1447f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = MCDJHDLLLCO(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}
}
