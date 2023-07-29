// CullArea
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CullArea : MonoBehaviour
{
	private const int FEKPDAFDEJL = 250;

	public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;

	public readonly byte FIRST_GROUP_ID = 1;

	public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER = new int[4] { 0, 1, 1, 1 };

	public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER = new int[8] { 0, 2, 1, 2, 0, 2, 1, 2 };

	public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER = new int[12]
	{
		0, 3, 2, 3, 1, 3, 2, 3, 1, 3,
		2, 3
	};

	public Vector2 Center;

	public Vector2 Size = new Vector2(25f, 25f);

	public Vector2[] Subdivisions = new Vector2[3];

	public int NumberOfSubdivisions;

	public bool YIsUpAxis = true;

	public bool RecreateCellHierarchy;

	private byte KDGFPOOOFEA;

	public int CellCount { get; private set; }

	public CellTree CellTree { get; private set; }

	public Dictionary<int, GameObject> Map { get; private set; }

	[SpecialName]
	public Dictionary<int, GameObject> KHNIGOOIEEC()
	{
		return _003CHOIHLOCGNFJ_003Ek__BackingField;
	}

	[SpecialName]
	public int KPMAKLHIIKH()
	{
		return _003CCECLGELDNPC_003Ek__BackingField;
	}

	private void AFKHGGAFGDN()
	{
		if (LDCIKKFKHMP() != null && LDCIKKFKHMP().JLKPMMKNPKN() != null)
		{
			BJLDPNNDNKP().OHIODLBAKPJ().GJKLHMCOAGE();
		}
		else
		{
			RecreateCellHierarchy = false;
		}
	}

	private void EPCGHAAONLN()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		FEHDNBICKPD();
	}

	[SpecialName]
	public CellTree BJLDPNNDNKP()
	{
		return _003CGCJHHIHBOND_003Ek__BackingField;
	}

	private void HHJBBHEBJCJ()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		FEHDNBICKPD();
	}

	[SpecialName]
	public CellTree LDCIKKFKHMP()
	{
		return _003CGCJHHIHBOND_003Ek__BackingField;
	}

	[SpecialName]
	private void OIHDEBMIBCD(CellTree DPNHODJHGJL)
	{
		_003CGCJHHIHBOND_003Ek__BackingField = DPNHODJHGJL;
	}

	private void LBOBAIGNOML()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		DEPPKCAJAAH();
	}

	private void JNELLHIPIDO()
	{
		if (BJLDPNNDNKP() != null && LDCIKKFKHMP().JMBLAEKHIBH() != null)
		{
			LDCIKKFKHMP().JMBLAEKHIBH().LIGIABGAEGM();
		}
		else
		{
			RecreateCellHierarchy = true;
		}
	}

	public void OnDrawGizmos()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		if (RecreateCellHierarchy)
		{
			FEHDNBICKPD();
		}
		EOPIOEHBEHO();
	}

	[SpecialName]
	private void FJEFDOOCPAF(int DPNHODJHGJL)
	{
		_003CCECLGELDNPC_003Ek__BackingField = DPNHODJHGJL;
	}

	private void KPGHEBANPOB(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 2f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 2f;
				CellTreeNode cellTreeNode = new CellTreeNode(KDGFPOOOFEA++, (NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : CellTreeNode.ENodeType.Leaf, OJICGBOIKNA);
				if (YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 2f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 2f;
					cellTreeNode.Center = new Vector3(num5, num8, 0f);
					cellTreeNode.Size = new Vector3(num4, num7, 0f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 2f, num8 - num7 / 2f, 0f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 2f, num8 + num7 / 2f, 0f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 2f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 2f;
					cellTreeNode.Center = new Vector3(num5, 0f, num11);
					cellTreeNode.Size = new Vector3(num4, 0f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 2f, 0f, num11 - num10 / 2f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 2f, 0f, num11 + num10 / 2f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				KPGHEBANPOB(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	private void BANCKPKJKAP(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1263f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1346f;
				byte kDGFPOOOFEA;
				KDGFPOOOFEA = (byte)((kDGFPOOOFEA = KDGFPOOOFEA) + 0);
				CellTreeNode cellTreeNode = new CellTreeNode(kDGFPOOOFEA, (NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)4), OJICGBOIKNA);
				if (YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1936f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 578f;
					cellTreeNode.Center = new Vector3(num5, num8, 1815f);
					cellTreeNode.Size = new Vector3(num4, num7, 818f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1113f, num8 - num7 / 1919f, 22f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 687f, num8 + num7 / 460f, 127f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1606f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1700f;
					cellTreeNode.Center = new Vector3(num5, 522f, num11);
					cellTreeNode.Size = new Vector3(num4, 259f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1193f, 1574f, num11 - num10 / 1100f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1521f, 1020f, num11 + num10 / 1454f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				OPNHJGJALEH(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	private void FEHDNBICKPD()
	{
		if (!DFCFOIDFBAL())
		{
			if (Debug.isDebugBuild)
			{
				Debug.LogError("There are too many cells created by your subdivision options. Maximum allowed number of cells is " + (250 - FIRST_GROUP_ID) + ". Current number of cells is " + CellCount + ".");
				return;
			}
			Application.Quit();
		}
		CellTreeNode cellTreeNode = new CellTreeNode(KDGFPOOOFEA++, CellTreeNode.ENodeType.Root, null);
		if (YIsUpAxis)
		{
			Center = new Vector2(base.transform.position.x, base.transform.position.y);
			Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(Center.x, Center.y, 0f);
			cellTreeNode.Size = new Vector3(Size.x, Size.y, 0f);
			cellTreeNode.TopLeft = new Vector3(Center.x - Size.x / 2f, Center.y - Size.y / 2f, 0f);
			cellTreeNode.BottomRight = new Vector3(Center.x + Size.x / 2f, Center.y + Size.y / 2f, 0f);
		}
		else
		{
			Center = new Vector2(base.transform.position.x, base.transform.position.z);
			Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(Center.x, 0f, Center.y);
			cellTreeNode.Size = new Vector3(Size.x, 0f, Size.y);
			cellTreeNode.TopLeft = new Vector3(Center.x - Size.x / 2f, 0f, Center.y - Size.y / 2f);
			cellTreeNode.BottomRight = new Vector3(Center.x + Size.x / 2f, 0f, Center.y + Size.y / 2f);
		}
		KPGHEBANPOB(cellTreeNode, 1);
		CellTree = new CellTree(cellTreeNode);
		RecreateCellHierarchy = false;
	}

	private void IMABNMGHDFD(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 708f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1541f;
				CellTreeNode cellTreeNode = new CellTreeNode(KDGFPOOOFEA++, (NumberOfSubdivisions == KNKEPAJGEAH) ? CellTreeNode.ENodeType.Leaf : CellTreeNode.ENodeType.Root, OJICGBOIKNA);
				if (YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1986f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 55f;
					cellTreeNode.Center = new Vector3(num5, num8, 265f);
					cellTreeNode.Size = new Vector3(num4, num7, 1019f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 809f, num8 - num7 / 437f, 1060f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 722f, num8 + num7 / 175f, 420f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 522f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 562f;
					cellTreeNode.Center = new Vector3(num5, 1226f, num11);
					cellTreeNode.Size = new Vector3(num4, 1992f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1989f, 807f, num11 - num10 / 363f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1044f, 1385f, num11 + num10 / 1435f);
				}
				OJICGBOIKNA.NOOFDCCDCGF(cellTreeNode);
				OPNHJGJALEH(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	private void Awake()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		FEHDNBICKPD();
	}

	private bool DFCFOIDFBAL()
	{
		int num = 1;
		int num2 = 1;
		Vector2[] subdivisions = Subdivisions;
		for (int i = 0; i < subdivisions.Length; i++)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		CellCount = num * num2;
		return CellCount <= 250 - FIRST_GROUP_ID;
	}

	private void OPNHJGJALEH(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 645f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 784f;
				byte kDGFPOOOFEA;
				KDGFPOOOFEA = (byte)((kDGFPOOOFEA = KDGFPOOOFEA) + 0);
				CellTreeNode cellTreeNode = new CellTreeNode(kDGFPOOOFEA, (NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)7), OJICGBOIKNA);
				if (YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1774f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1277f;
					cellTreeNode.Center = new Vector3(num5, num8, 229f);
					cellTreeNode.Size = new Vector3(num4, num7, 1544f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 746f, num8 - num7 / 895f, 39f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 609f, num8 + num7 / 43f, 1936f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 6f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1507f;
					cellTreeNode.Center = new Vector3(num5, 1997f, num11);
					cellTreeNode.Size = new Vector3(num4, 1057f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 782f, 1578f, num11 - num10 / 1595f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1791f, 771f, num11 + num10 / 1862f);
				}
				OJICGBOIKNA.BCJDCNIGLEI(cellTreeNode);
				BANCKPKJKAP(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	private bool MMBBMGMEOMO()
	{
		int num = 1;
		int num2 = 1;
		Vector2[] subdivisions = Subdivisions;
		for (int i = 1; i < subdivisions.Length; i++)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		CellCount = num * num2;
		return CellCount > -105 - FIRST_GROUP_ID;
	}

	private void DEPPKCAJAAH()
	{
		if (!MMBBMGMEOMO())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[7];
				array[1] = "color";
				array[1] = 111 - FIRST_GROUP_ID;
				array[1] = "_GlowColor";
				array[6] = CellCount;
				array[1] = "maps.";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		CellTreeNode cellTreeNode = new CellTreeNode(KDGFPOOOFEA++, CellTreeNode.ENodeType.Node, null);
		if (YIsUpAxis)
		{
			Center = new Vector2(base.transform.position.x, base.transform.position.y);
			Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(Center.x, Center.y, 1941f);
			cellTreeNode.Size = new Vector3(Size.x, Size.y, 673f);
			cellTreeNode.TopLeft = new Vector3(Center.x - Size.x / 746f, Center.y - Size.y / 429f, 824f);
			cellTreeNode.BottomRight = new Vector3(Center.x + Size.x / 1799f, Center.y + Size.y / 1932f, 160f);
		}
		else
		{
			Center = new Vector2(base.transform.position.x, base.transform.position.z);
			Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(Center.x, 518f, Center.y);
			cellTreeNode.Size = new Vector3(Size.x, 426f, Size.y);
			cellTreeNode.TopLeft = new Vector3(Center.x - Size.x / 916f, 292f, Center.y - Size.y / 712f);
			cellTreeNode.BottomRight = new Vector3(Center.x + Size.x / 1173f, 1903f, Center.y + Size.y / 1964f);
		}
		KPGHEBANPOB(cellTreeNode, 1);
		OIHDEBMIBCD(new CellTree(cellTreeNode));
		RecreateCellHierarchy = true;
	}

	public void LFJNDDPFLBM()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		if (RecreateCellHierarchy)
		{
			FEHDNBICKPD();
		}
		AFKHGGAFGDN();
	}

	public List<byte> GetActiveCells(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		CellTree.RootNode.GetActiveCells(list, YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	public List<byte> MDICNFNOGEC(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		LDCIKKFKHMP().JIBHJOKKIKB().CKNGPLDAGEB(list, YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	private void CEKLAECJCKG()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		DEPPKCAJAAH();
	}

	public void BDIMPAGMFEK()
	{
		KDGFPOOOFEA = FIRST_GROUP_ID;
		if (RecreateCellHierarchy)
		{
			DEPPKCAJAAH();
		}
		EOPIOEHBEHO();
	}

	private void EOPIOEHBEHO()
	{
		if (CellTree != null && CellTree.RootNode != null)
		{
			CellTree.RootNode.Draw();
		}
		else
		{
			RecreateCellHierarchy = true;
		}
	}

	[SpecialName]
	private void ILGOHIDFMAB(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		_003CHOIHLOCGNFJ_003Ek__BackingField = DPNHODJHGJL;
	}
}
