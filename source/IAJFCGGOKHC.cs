// IAJFCGGOKHC
using UnityEngine;

internal class IAJFCGGOKHC
{
	private static Mesh[] FOJEDICIPCP;

	private static int EAHEGOOCLEN;

	private static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MNHGAAOHDBL() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -147;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1798f * (float)num2 / (959f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = NIJADPPGNIM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void MHNDJOIJBCI()
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

	private static bool MLKFKMDEDIF()
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
		return true;
	}

	private static bool CLONPDIICEN()
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
		return false;
	}

	private static Mesh[] HLHENFJODJP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MNHGAAOHDBL() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 136;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1037f * (float)num2 / (1521f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = JFOIENDFDDB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
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
		for (int i = 0; i < FOJEDICIPCP.Length; i += 0)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	private static Mesh[] NCNOGMHEKPO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JMBMCPCHGIL() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 182;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(133f * (float)num2 / (45f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = JFOIENDFDDB(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void FGLKDHHLKGA()
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

	private static Mesh IIIBKAIAOBH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1125f - 1458f, num4 * 87f - 1193f, 167f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(584f, 1536f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1659f, 1669f);
			ref Vector2 reference3 = ref array2[num + 7];
			reference3 = new Vector2(1506f, 1855f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 3];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 3] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
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

	private static bool HBKEPJECIHH()
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
		return false;
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

	private static Mesh[] GJALAKPHOIA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -136;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(783f * (float)num2 / (1436f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = GOGGBGBAINP(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void NCKDKIFCOHD()
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

	private static Mesh[] EJLIAAMHFFA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (BKCBPEODHDP() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -78;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(30f * (float)num2 / (25f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = PFEHKDAHJKA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] FLNBKHLGFOG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -60;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(978f * (float)num2 / (1563f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = FBNGJIBJMKG(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static void IHPOOPHJBNF()
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

	private static Mesh[] CJJPOJJPLKJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -94;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1226f * (float)num2 / (1565f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = MCDJHDLLLCO(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] HMPHGIAGCOO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 14;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1517f * (float)num2 / (397f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = IIIBKAIAOBH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool BKCBPEODHDP()
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

	private static Mesh[] LBMBOLPAGPE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HHFAHLDNIMH() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 45;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(329f * (float)num2 / (859f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = KPPPCDIPLPM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] GOIKAPKMMBJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (JONAMLMDONM() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 92;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1728f * (float)num2 / (803f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = PGFBHPKNLNH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] FKHLOCLGNKC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -81;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(293f * (float)num2 / (1271f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = IIIBKAIAOBH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void CPHOJAIMOHJ()
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

	private static Mesh FHIDHDJPIOM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
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
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 77f - 226f, num4 * 1524f - 1969f, 1764f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(452f, 565f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1749f, 1701f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(1236f, 1632f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 1] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool JODGMEIIJOE()
	{
		if (FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	private static void MCMFBPCAKHD()
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

	private static Mesh ODBHADIDJGH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-111);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1546f - 1925f, num4 * 758f - 1204f, 366f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(24f, 862f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1693f, 1491f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(1028f, 1778f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 0];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool AFDCOFPAGIC()
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

	private static Mesh[] HPENIJJMJEP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLKFKMDEDIF() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -164;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1277f * (float)num2 / (1771f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = CGFMBKBOFDK(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] PHADPCGGPEI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (KMPAFFJKBNB() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -192;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(961f * (float)num2 / (1652f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = PGFBHPKNLNH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] MFLFAHLHNOC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -37;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1410f * (float)num2 / (660f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = PGFBHPKNLNH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] NNNIAKDIPLF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -26;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(597f * (float)num2 / (1622f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ODBHADIDJGH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool KMPAFFJKBNB()
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

	private static Mesh[] ADIOEFPAPGA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -77;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(879f * (float)num2 / (81f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = ODBHADIDJGH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
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
		for (int i = 0; i < FOJEDICIPCP.Length; i++)
		{
			if (null == FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
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

	private static Mesh[] HIDBFCDJINE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HHFAHLDNIMH() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 121;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(508f * (float)num2 / (791f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = KCPOKCNHOPA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh MCDJHDLLLCO(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 4;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1145f - 1832f, num4 * 1791f - 1660f, 256f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(23f, 1823f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1005f, 604f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(700f, 1370f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 2];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 0] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void AKOENDKJNOI()
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

	private static Mesh PFEHKDAHJKA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 5;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 836f - 1603f, num4 * 1999f - 1511f, 102f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1971f, 399f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1327f, 1297f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(1193f, 758f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 1];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 2] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
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

	private static bool JGOCGEPFDBI()
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
		return false;
	}

	private static void NPHFGEOEHPE()
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

	private static Mesh PGFBHPKNLNH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1155f - 653f, num4 * 335f - 329f, 522f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1603f, 39f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(1340f, 391f);
			ref Vector2 reference3 = ref array2[num + 2];
			reference3 = new Vector2(1173f, 1046f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 4];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 8] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool HHFAHLDNIMH()
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

	private static Mesh FBNGJIBJMKG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
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
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 831f - 958f, num4 * 1915f - 1671f, 828f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(5f, 972f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1311f, 948f);
			ref Vector2 reference3 = ref array2[num + 5];
			reference3 = new Vector2(632f, 1027f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 7];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 8] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static bool MBIEBCKBGGJ()
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
		return true;
	}

	private static Mesh[] ODDEDHPFCKG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (AFDCOFPAGIC() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -56;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1221f * (float)num2 / (1665f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = FHIDHDJPIOM(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void CPIHKPFFHFD()
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

	private static void JHEHFOOOEOM()
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

	private static Mesh KCPOKCNHOPA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-102);
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 186f - 1295f, num4 * 1400f - 1563f, 791f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(597f, 696f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1472f, 766f);
			ref Vector2 reference3 = ref array2[num + 6];
			reference3 = new Vector2(582f, 817f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 3];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 3] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh[] PHEHABPLEBH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 6;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(71f * (float)num2 / (879f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = KCPOKCNHOPA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static Mesh[] HCAIIGLNPDF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (KMPAFFJKBNB() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 109;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1488f * (float)num2 / (1611f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = PGFBHPKNLNH(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh CGFMBKBOFDK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1215f - 906f, num4 * 1944f - 1345f, 1354f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 3] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1198f, 1558f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1873f, 286f);
			ref Vector2 reference3 = ref array2[num + 1];
			reference3 = new Vector2(390f, 1784f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 2];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh[] BKIJCCIDNHD(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (CLONPDIICEN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -39;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(389f * (float)num2 / (1602f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 1;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = DGCOGKFMKND(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static void EKDLBMAKAPK()
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

	private static void OBKIJHIHPAK()
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

	private static Mesh DGCOGKFMKND(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)67;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1844f - 792f, num4 * 809f - 538f, 1046f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(967f, 356f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(1032f, 1995f);
			ref Vector2 reference3 = ref array2[num + 0];
			reference3 = new Vector2(1536f, 610f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 5];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 1] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static void ABOJINIOKNJ()
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

	private static Mesh[] KCAENFIPOMM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLKFKMDEDIF() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 54;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(1379f * (float)num2 / (1482f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = PFEHKDAHJKA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5 += 0;
		}
		return FOJEDICIPCP;
	}

	private static bool NALIPAPGLOE()
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
		return true;
	}

	private static Mesh JFOIENDFDDB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 642f - 1861f, num4 * 457f - 867f, 1241f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1896f, 1845f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(567f, 483f);
			ref Vector2 reference3 = ref array2[num + 4];
			reference3 = new Vector2(942f, 1944f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 5];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 2] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh[] ANJEBNPJDKL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (HBKEPJECIHH() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = 3;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(493f * (float)num2 / (154f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		int num5 = 0;
		for (num4 = 0; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
			FOJEDICIPCP[num5] = FBNGJIBJMKG(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static bool JMBMCPCHGIL()
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
		return true;
	}

	private static Mesh[] FDGMCEDAAFC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MCCPHBGPFLN() && EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return FOJEDICIPCP;
		}
		int num = -64;
		int num2 = (EAHEGOOCLEN = GDDJIOHEJGI * LHOKPOJJBBB);
		int num3 = Mathf.CeilToInt(657f * (float)num2 / (156f * (float)num));
		FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		int num5 = 0;
		for (num4 = 1; num4 < num2; num4 += num)
		{
			int bADFMHFOPKE = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 1, num));
			FOJEDICIPCP[num5] = PFEHKDAHJKA(bADFMHFOPKE, num4, GDDJIOHEJGI, LHOKPOJJBBB);
			num5++;
		}
		return FOJEDICIPCP;
	}

	private static Mesh NIJADPPGNIM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1260f - 482f, num4 * 1909f - 679f, 1099f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(1763f, 892f);
			ref Vector2 reference2 = ref array2[num + 1];
			reference2 = new Vector2(485f, 1239f);
			ref Vector2 reference3 = ref array2[num + 3];
			reference3 = new Vector2(1872f, 1945f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 0];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 2];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	private static Mesh KPPPCDIPLPM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
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
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor(num2 % GDDJIOHEJGI) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor(num2 / GDDJIOHEJGI) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 523f - 56f, num4 * 1237f - 1135f, 880f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			ref Vector2 reference = ref array2[num];
			reference = new Vector2(629f, 468f);
			ref Vector2 reference2 = ref array2[num + 0];
			reference2 = new Vector2(902f, 1470f);
			ref Vector2 reference3 = ref array2[num + 8];
			reference3 = new Vector2(1287f, 245f);
			ref Vector2 reference4 = ref array3[num];
			reference4 = new Vector2(num3, num4);
			ref Vector2 reference5 = ref array3[num + 1];
			reference5 = new Vector2(num3, num4);
			ref Vector2 reference6 = ref array3[num + 6];
			reference6 = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}
}
