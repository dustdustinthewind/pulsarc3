// from dnspy (right click -> edit class)

using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200033D RID: 829
public class CullArea : MonoBehaviour
{
	// Token: 0x0600BC1A RID: 48154 RVA: 0x00442ABC File Offset: 0x00440CBC
	private void LDJPJAINJNA(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1589f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 850f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)4), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 547f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 450f;
					cellTreeNode.Center = new Vector3(num5, num8, 1586f);
					cellTreeNode.Size = new Vector3(num4, num7, 1852f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1254f, num8 - num7 / 832f, 1818f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 907f, num8 + num7 / 364f, 854f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1600f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 519f;
					cellTreeNode.Center = new Vector3(num5, 446f, num11);
					cellTreeNode.Size = new Vector3(num4, 864f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 58f, 421f, num11 - num10 / 1754f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1659f, 1849f, num11 + num10 / 682f);
				}
				OJICGBOIKNA.MPDCNPHDBBO(cellTreeNode);
				this.KPEFIJINIKH(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC1B RID: 48155 RVA: 0x0008FA03 File Offset: 0x0008DC03
	private void PFJOBFJPLPO()
	{
		if (this.HFPDFLNLFDE() != null && this.NAGODBBNBAG().OKJGPJFNHGK() != null)
		{
			this.BEKPEPKJKPB().LALDPEAHACP().FBKBMIKIEKE();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC1C RID: 48156 RVA: 0x0008FA3C File Offset: 0x0008DC3C
	private void GFFEEOPEOJG()
	{
		if (this.BEKPEPKJKPB() != null && this.NAGODBBNBAG().JEDEPCHGHKN() != null)
		{
			this.OIPOHEPBNNB().NDFHDHMGMBI().NJLEDOJJFJN();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC1D RID: 48157 RVA: 0x00442D2C File Offset: 0x00440F2C
	private void OOFNADDMHLP()
	{
		if (!this.FGCPLJMMBPC())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[5];
				array[1] = "_Intensity";
				array[0] = (int)(162 - this.FIRST_GROUP_ID);
				array[1] = "'{0}' \t{1}ms \t{2}";
				array[6] = this.CellCount;
				array[2] = "Creating new item...";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 512f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 1893f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 646f, this.Center.y - this.Size.y / 81f, 478f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 105f, this.Center.y + this.Size.y / 1230f, 760f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 1806f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1098f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 266f, 326f, this.Center.y - this.Size.y / 626f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 153f, 574f, this.Center.y + this.Size.y / 1209f);
		}
		this.DKPECGACDNE(cellTreeNode, 0);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BC1E RID: 48158 RVA: 0x0008FA75 File Offset: 0x0008DC75
	public void IBJKHNIIPIA()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.BGBDNKMCJFM();
		}
		this.LIOOACOMJKN();
	}

	// Token: 0x0600BC1F RID: 48159 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	public CellTree NAGODBBNBAG()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BC20 RID: 48160 RVA: 0x00443070 File Offset: 0x00441270
	public CullArea()
	{
	}

	// Token: 0x0600BC21 RID: 48161 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void OHNCLPFIBAG(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC22 RID: 48162 RVA: 0x004430F8 File Offset: 0x004412F8
	public List<byte> KAMPFMDNIHO(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		this.OIPOHEPBNNB().OKJGPJFNHGK().CCIKBIKMOMH(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC23 RID: 48163 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void BGKPMIAKEFH(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x0008FAAB File Offset: 0x0008DCAB
	private void OPFDGBDADMA()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.OOFNADDMHLP();
	}

	// Token: 0x0600BC25 RID: 48165 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> LCKDKOIKLGK()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC26 RID: 48166 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int JGIMDKNACLC()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC27 RID: 48167 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int OPEEDKDBGGF()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC28 RID: 48168 RVA: 0x00443128 File Offset: 0x00441328
	private void IGHOLHPJMFL()
	{
		if (!this.DFCFOIDFBAL())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[3];
				array[1] = "_ScreenResolution";
				array[0] = (int)(109 - this.FIRST_GROUP_ID);
				array[7] = ",";
				array[8] = this.FNDIKKLOMKE();
				array[0] = "_PositionX";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1273f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 733f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1506f, this.Center.y - this.Size.y / 842f, 871f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1324f, this.Center.y + this.Size.y / 1427f, 1767f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 1339f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1744f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1076f, 1967f, this.Center.y - this.Size.y / 1801f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 110f, 262f, this.Center.y + this.Size.y / 217f);
		}
		this.ABOCGGIBAMK(cellTreeNode, 0);
		this.JHPNKEHEBCA(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC29 RID: 48169 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int DHNPGHENNBB()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC2A RID: 48170 RVA: 0x0044346C File Offset: 0x0044166C
	private void KPEFIJINIKH(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1611f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1376f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)8), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1062f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1593f;
					cellTreeNode.Center = new Vector3(num5, num8, 1031f);
					cellTreeNode.Size = new Vector3(num4, num7, 1150f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 695f, num8 - num7 / 789f, 897f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 197f, num8 + num7 / 1146f, 374f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1444f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1293f;
					cellTreeNode.Center = new Vector3(num5, 604f, num11);
					cellTreeNode.Size = new Vector3(num4, 257f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1565f, 614f, num11 - num10 / 690f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1025f, 1107f, num11 + num10 / 1629f);
				}
				OJICGBOIKNA.CGKJMMOHJOK(cellTreeNode);
				this.JACDMBCEAOF(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC2B RID: 48171 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void AGONAHDCPHD(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC2C RID: 48172 RVA: 0x004436DC File Offset: 0x004418DC
	private void ECGJCHCBGJG()
	{
		if (!this.FGCPLJMMBPC())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[2];
				array[0] = "Working.\nPlease wait..";
				array[0] = (int)(123 - this.FIRST_GROUP_ID);
				array[0] = "settings.disablestoryboard";
				array[5] = this.CellCount;
				array[0] = "#ok";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1936f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 944f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 169f, this.Center.y - this.Size.y / 161f, 1872f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 393f, this.Center.y + this.Size.y / 1406f, 1650f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 505f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1821f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1962f, 1474f, this.Center.y - this.Size.y / 354f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1046f, 687f, this.Center.y + this.Size.y / 311f);
		}
		this.LDJPJAINJNA(cellTreeNode, 1);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BC2D RID: 48173 RVA: 0x0008FAD8 File Offset: 0x0008DCD8
	public void OnDrawGizmos()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.FEHDNBICKPD();
		}
		this.EOPIOEHBEHO();
	}

	// Token: 0x0600BC2E RID: 48174 RVA: 0x0008FAFD File Offset: 0x0008DCFD
	private void JHHHBFEGJBN()
	{
		if (this.OHFAMNJPPHB() != null && this.BEKPEPKJKPB().AOLLJGHPKNI() != null)
		{
			this.OIPOHEPBNNB().JFKCCNJCMIJ().FHCKMAHODHN();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC2F RID: 48175 RVA: 0x00443A20 File Offset: 0x00441C20
	private bool IGOCDAEKKEN()
	{
		int num = 1;
		int num2 = 0;
		Vector2[] subdivisions = this.Subdivisions;
		for (int i = 1; i < subdivisions.Length; i += 0)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.OHNCLPFIBAG(num * num2);
		return this.JGIMDKNACLC() <= -86 - (int)this.FIRST_GROUP_ID;
	}

	// Token: 0x0600BC30 RID: 48176 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void OCEBBCPFAOE(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC31 RID: 48177 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> HFALHNHCANM()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC32 RID: 48178 RVA: 0x00443A94 File Offset: 0x00441C94
	private void CFEICIDJJKO()
	{
		if (!this.MKCPDLFDDKJ())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[7];
				array[1] = "_TimeX";
				array[1] = -57 - (int)this.FIRST_GROUP_ID;
				array[2] = "EventSystem";
				array[7] = this.OPEEDKDBGGF();
				array[4] = "\n\n#";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 863f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 972f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 320f, this.Center.y - this.Size.y / 1680f, 800f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 896f, this.Center.y + this.Size.y / 1316f, 170f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 1282f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1742f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 147f, 1676f, this.Center.y - this.Size.y / 1566f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1463f, 1876f, this.Center.y + this.Size.y / 478f);
		}
		this.ABOCGGIBAMK(cellTreeNode, 0);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BC33 RID: 48179 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void BKJKDFEADNI(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC34 RID: 48180 RVA: 0x0008FB36 File Offset: 0x0008DD36
	private void KACPCCMPAHA()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.HODNJHNDKGA();
	}

	// Token: 0x0600BC35 RID: 48181 RVA: 0x0008FB4A File Offset: 0x0008DD4A
	public void KDOELELGGLD()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.ECGJCHCBGJG();
		}
		this.JHHHBFEGJBN();
	}

	// Token: 0x0600BC36 RID: 48182 RVA: 0x0008FB6F File Offset: 0x0008DD6F
	private void CBGLALOEPGN(CellTree DPNHODJHGJL)
	{
		this.<GCJHHIHBOND>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC37 RID: 48183 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void OKCBGJHNKGA(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC38 RID: 48184 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	public CellTree OHFAMNJPPHB()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BC39 RID: 48185 RVA: 0x0008FB36 File Offset: 0x0008DD36
	private void GGKPLCJNEHF()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.HODNJHNDKGA();
	}

	// Token: 0x0600BC3A RID: 48186 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> KPLIKODKMHB()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC3B RID: 48187 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int FNDIKKLOMKE()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x00443DD8 File Offset: 0x00441FD8
	private void AIBLGKJGPGI()
	{
		if (!this.FGCPLJMMBPC())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[4];
				array[0] = "curScn";
				array[1] = (int)(195 - this.FIRST_GROUP_ID);
				array[4] = "image";
				array[7] = this.OPEEDKDBGGF();
				array[1] = ": ";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 192f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 563f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1742f, this.Center.y - this.Size.y / 1196f, 1457f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 518f, this.Center.y + this.Size.y / 1959f, 711f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 1026f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1329f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1834f, 471f, this.Center.y - this.Size.y / 905f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 295f, 164f, this.Center.y + this.Size.y / 1866f);
		}
		this.DCJCOOBBDNN(cellTreeNode, 0);
		this.CBGLALOEPGN(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> HHLONCCLJHN()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC3E RID: 48190 RVA: 0x0008FB78 File Offset: 0x0008DD78
	public void MCBBLMFNOME()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.OOFNADDMHLP();
		}
		this.HCDPJNPIEEI();
	}

	// Token: 0x0600BC3F RID: 48191 RVA: 0x0044411C File Offset: 0x0044231C
	private void JACDMBCEAOF(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 389f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 720f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)6), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1942f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1101f;
					cellTreeNode.Center = new Vector3(num5, num8, 382f);
					cellTreeNode.Size = new Vector3(num4, num7, 745f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 654f, num8 - num7 / 173f, 508f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 59f, num8 + num7 / 1824f, 1798f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1202f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 814f;
					cellTreeNode.Center = new Vector3(num5, 704f, num11);
					cellTreeNode.Size = new Vector3(num4, 1690f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1508f, 866f, num11 - num10 / 1917f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1926f, 111f, num11 + num10 / 336f);
				}
				OJICGBOIKNA.FNEHKFAHOLP(cellTreeNode);
				this.DCJCOOBBDNN(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x0044438C File Offset: 0x0044258C
	private bool MKCPDLFDDKJ()
	{
		int num = 1;
		int num2 = 1;
		foreach (Vector2 vector in this.Subdivisions)
		{
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.CellCount = num * num2;
		return this.EMMHIHIANGL() > -43 - (int)this.FIRST_GROUP_ID;
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x0008FB9D File Offset: 0x0008DD9D
	private void LPKKCDDNKAD()
	{
		if (this.BEKPEPKJKPB() != null && this.BEKPEPKJKPB().AIDLEAFFHKL() != null)
		{
			this.HFPDFLNLFDE().LMLJDGAPDPI().DIKHLOJLCME();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC42 RID: 48194 RVA: 0x0008FBD6 File Offset: 0x0008DDD6
	public void AMHGELLGCBB()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.CFEICIDJJKO();
		}
		this.JPCJIGOGBII();
	}

	// Token: 0x0600BC43 RID: 48195 RVA: 0x0008FBFB File Offset: 0x0008DDFB
	public void FCDFIPNBNGL()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.AIBLGKJGPGI();
		}
		this.GFFEEOPEOJG();
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	// (set) Token: 0x0600BC55 RID: 48213 RVA: 0x0008FB6F File Offset: 0x0008DD6F
	public CellTree CellTree { get; private set; }

	// Token: 0x0600BC45 RID: 48197 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void KKHNBLMLEOH(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> JNEJFPKBJBJ()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void FMLPNHBOLIK(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC48 RID: 48200 RVA: 0x0008FC20 File Offset: 0x0008DE20
	public void IGIDDJBOLCM()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.BGBDNKMCJFM();
		}
		this.JHHHBFEGJBN();
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x00444400 File Offset: 0x00442600
	private void OIHNDIFOIMA(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 306f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1829f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : ((CellTreeNode.ENodeType)3), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1057f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1587f;
					cellTreeNode.Center = new Vector3(num5, num8, 147f);
					cellTreeNode.Size = new Vector3(num4, num7, 985f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 607f, num8 - num7 / 1141f, 1068f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1704f, num8 + num7 / 1472f, 153f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 616f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 637f;
					cellTreeNode.Center = new Vector3(num5, 1773f, num11);
					cellTreeNode.Size = new Vector3(num4, 736f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1882f, 1293f, num11 - num10 / 252f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 812f, 42f, num11 + num10 / 1391f);
				}
				OJICGBOIKNA.BDELMHBAKOI(cellTreeNode);
				this.ABOCGGIBAMK(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC4A RID: 48202 RVA: 0x0008FC45 File Offset: 0x0008DE45
	private void EOPIOEHBEHO()
	{
		if (this.CellTree != null && this.CellTree.RootNode != null)
		{
			this.CellTree.RootNode.Draw();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC4B RID: 48203 RVA: 0x00444670 File Offset: 0x00442870
	private void GJKKDOFGBJI(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 998f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 463f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Root, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1992f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1325f;
					cellTreeNode.Center = new Vector3(num5, num8, 421f);
					cellTreeNode.Size = new Vector3(num4, num7, 151f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1000f, num8 - num7 / 1283f, 265f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1881f, num8 + num7 / 63f, 1022f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1264f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1014f;
					cellTreeNode.Center = new Vector3(num5, 766f, num11);
					cellTreeNode.Size = new Vector3(num4, 569f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 112f, 1870f, num11 - num10 / 521f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 725f, 1646f, num11 + num10 / 1155f);
				}
				OJICGBOIKNA.MPDCNPHDBBO(cellTreeNode);
				this.BIHGNOALFAG(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC4C RID: 48204 RVA: 0x0008FC7E File Offset: 0x0008DE7E
	private void HCCMANDFEPL()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.IGHOLHPJMFL();
	}

	// Token: 0x0600BC4D RID: 48205 RVA: 0x004448E0 File Offset: 0x00442AE0
	public List<byte> KEBHODOHCIB(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		this.HFPDFLNLFDE().JIBHJOKKIKB().HONILALBABF(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC4E RID: 48206 RVA: 0x0008FC92 File Offset: 0x0008DE92
	private void HCDPJNPIEEI()
	{
		if (this.BEKPEPKJKPB() != null && this.OIPOHEPBNNB().HFONNGKHHAK() != null)
		{
			this.CellTree.NPAMENLMELP().FBKBMIKIEKE();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC4F RID: 48207 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void CCNOIIADOPF(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC50 RID: 48208 RVA: 0x00444910 File Offset: 0x00442B10
	private void ABOCGGIBAMK(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 25f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 420f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : ((CellTreeNode.ENodeType)5), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 581f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1642f;
					cellTreeNode.Center = new Vector3(num5, num8, 1654f);
					cellTreeNode.Size = new Vector3(num4, num7, 1748f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 542f, num8 - num7 / 1272f, 530f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1793f, num8 + num7 / 1494f, 1494f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1014f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1812f;
					cellTreeNode.Center = new Vector3(num5, 859f, num11);
					cellTreeNode.Size = new Vector3(num4, 1688f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1494f, 1110f, num11 - num10 / 383f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1255f, 152f, num11 + num10 / 690f);
				}
				OJICGBOIKNA.AMMKMACNAOL(cellTreeNode);
				this.NBNOCABOPIA(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC51 RID: 48209 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int KEMEMDDGHIB()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC52 RID: 48210 RVA: 0x00444B80 File Offset: 0x00442D80
	private void LCFKFJFIMHH()
	{
		if (!this.FGCPLJMMBPC())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[6];
				array[1] = "[PlayerBase] Checkpoint error: ";
				array[1] = (int)(107 - this.FIRST_GROUP_ID);
				array[7] = "ItemNameText";
				array[1] = this.CellCount;
				array[3] = "_TimeX";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 9f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 1343f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 861f, this.Center.y - this.Size.y / 936f, 168f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1183f, this.Center.y + this.Size.y / 1167f, 1251f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 393f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 650f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1059f, 14f, this.Center.y - this.Size.y / 1134f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 951f, 612f, this.Center.y + this.Size.y / 1054f);
		}
		this.KPEFIJINIKH(cellTreeNode, 0);
		this.JHPNKEHEBCA(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC53 RID: 48211 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	public CellTree OIPOHEPBNNB()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x0008FABF File Offset: 0x0008DCBF
	// (set) Token: 0x0600BC54 RID: 48212 RVA: 0x0008FACF File Offset: 0x0008DCCF
	public Dictionary<int, GameObject> Map { get; private set; }

	// Token: 0x0600BC56 RID: 48214 RVA: 0x0008FCCB File Offset: 0x0008DECB
	public void LJLCNBNOPLL()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.FEHDNBICKPD();
		}
		this.AFKHGGAFGDN();
	}

	// Token: 0x0600BC57 RID: 48215 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	public CellTree HFPDFLNLFDE()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BC58 RID: 48216 RVA: 0x0008FCF0 File Offset: 0x0008DEF0
	private void AFKHGGAFGDN()
	{
		if (this.NAGODBBNBAG() != null && this.HFPDFLNLFDE().ECLLLOKILPM() != null)
		{
			this.CellTree.JEDEPCHGHKN().FHPEOMJCKIH();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC59 RID: 48217 RVA: 0x00444EC4 File Offset: 0x004430C4
	private bool DFCFOIDFBAL()
	{
		int num = 1;
		int num2 = 1;
		foreach (Vector2 vector in this.Subdivisions)
		{
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.CellCount = num * num2;
		return this.CellCount <= (int)(250 - this.FIRST_GROUP_ID);
	}

	// Token: 0x0600BC5A RID: 48218 RVA: 0x00444F38 File Offset: 0x00443138
	private void FEHDNBICKPD()
	{
		if (!this.DFCFOIDFBAL())
		{
			if (Debug.isDebugBuild)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"There are too many cells created by your subdivision options. Maximum allowed number of cells is ",
					(int)(250 - this.FIRST_GROUP_ID),
					". Current number of cells is ",
					this.CellCount,
					"."
				}));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 0f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 0f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 2f, this.Center.y - this.Size.y / 2f, 0f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 2f, this.Center.y + this.Size.y / 2f, 0f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 0f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 0f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 2f, 0f, this.Center.y - this.Size.y / 2f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 2f, 0f, this.Center.y + this.Size.y / 2f);
		}
		this.KPGHEBANPOB(cellTreeNode, 1);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC5B RID: 48219 RVA: 0x0008FD29 File Offset: 0x0008DF29
	private void JMBAJDBHJHL()
	{
		if (this.NAGODBBNBAG() != null && this.CellTree.EDGKIAHABCO() != null)
		{
			this.HFPDFLNLFDE().NDPACPKGCEH().ODLGCHBFCPF();
		}
		else
		{
			this.RecreateCellHierarchy = false;
		}
	}

	// Token: 0x0600BC5C RID: 48220 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void NJEJIILOKBO(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC5D RID: 48221 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void BFIHFCPMDDC(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC5E RID: 48222 RVA: 0x0008FD62 File Offset: 0x0008DF62
	private void GBKAIENPPAP()
	{
		if (this.CellTree != null && this.CellTree.BELIIHPCOHI() != null)
		{
			this.NAGODBBNBAG().ENIMPKDMHLI().GADLADPKCNE();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x0008FD9B File Offset: 0x0008DF9B
	private void JOBFJKDKOFJ()
	{
		if (this.CellTree != null && this.HFPDFLNLFDE().PNBBOHNENBK() != null)
		{
			this.BEKPEPKJKPB().BOAIDMHLCDD().KNIJFMBAFGE();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void OPOPMPBMONI(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x0008FDD4 File Offset: 0x0008DFD4
	private void Awake()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.FEHDNBICKPD();
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x0008FDE8 File Offset: 0x0008DFE8
	private void JPCJIGOGBII()
	{
		if (this.OIPOHEPBNNB() != null && this.OHFAMNJPPHB().PNBBOHNENBK() != null)
		{
			this.OHFAMNJPPHB().AIDLEAFFHKL().FHPEOMJCKIH();
		}
		else
		{
			this.RecreateCellHierarchy = false;
		}
	}

	// Token: 0x0600BC63 RID: 48227 RVA: 0x0044527C File Offset: 0x0044347C
	public List<byte> ELMBCNNBICM(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(1);
		this.HFPDFLNLFDE().AFNOOIKBKFA().CCIKBIKMOMH(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC64 RID: 48228 RVA: 0x0008FE21 File Offset: 0x0008E021
	private void AJIKPEIGACI()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.LCFKFJFIMHH();
	}

	// Token: 0x0600BC65 RID: 48229 RVA: 0x004452AC File Offset: 0x004434AC
	private void FDGOBPEMKEM(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1558f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 75f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Node, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 968f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1605f;
					cellTreeNode.Center = new Vector3(num5, num8, 97f);
					cellTreeNode.Size = new Vector3(num4, num7, 924f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1934f, num8 - num7 / 1287f, 1869f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 226f, num8 + num7 / 1119f, 472f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 59f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 432f;
					cellTreeNode.Center = new Vector3(num5, 1860f, num11);
					cellTreeNode.Size = new Vector3(num4, 514f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1758f, 1748f, num11 - num10 / 1432f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1942f, 171f, num11 + num10 / 1750f);
				}
				OJICGBOIKNA.NHHBPLBJJEJ(cellTreeNode);
				this.ABOCGGIBAMK(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC66 RID: 48230 RVA: 0x0044551C File Offset: 0x0044371C
	private void PNADNBIIMAP()
	{
		if (!this.MKCPDLFDDKJ())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[4];
				array[1] = "_SunColor";
				array[0] = -178 - (int)this.FIRST_GROUP_ID;
				array[7] = "_TimeX";
				array[6] = this.FNDIKKLOMKE();
				array[1] = "_Extra2";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1219f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 1160f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 520f, this.Center.y - this.Size.y / 1947f, 1466f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 720f, this.Center.y + this.Size.y / 1015f, 1686f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 212f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 451f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1016f, 881f, this.Center.y - this.Size.y / 1183f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 409f, 335f, this.Center.y + this.Size.y / 1201f);
		}
		this.GJKKDOFGBJI(cellTreeNode, 1);
		this.JHPNKEHEBCA(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC67 RID: 48231 RVA: 0x0008FE35 File Offset: 0x0008E035
	private void LIOOACOMJKN()
	{
		if (this.OIPOHEPBNNB() != null && this.OHFAMNJPPHB().BOAIDMHLCDD() != null)
		{
			this.CellTree.LALDPEAHACP().FHCKMAHODHN();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC68 RID: 48232 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	public int EMMHIHIANGL()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x0600BC69 RID: 48233 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> CFGHEDEMDOH()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC6A RID: 48234 RVA: 0x00445860 File Offset: 0x00443A60
	private void DBNKIFHNKDC()
	{
		if (!this.IGOCDAEKKEN())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[]
				{
					"CameraFilterPack/Blend2Camera_Luminosity",
					-199 - (int)this.FIRST_GROUP_ID,
					null,
					null,
					null,
					null,
					null,
					"_LightIntensity"
				};
				array[0] = this.JGIMDKNACLC();
				array[7] = "_Value";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1174f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 334f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 670f, this.Center.y - this.Size.y / 432f, 1757f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 173f, this.Center.y + this.Size.y / 1282f, 712f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 707f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1501f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1869f, 624f, this.Center.y - this.Size.y / 1066f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 122f, 191f, this.Center.y + this.Size.y / 479f);
		}
		this.OIHNDIFOIMA(cellTreeNode, 0);
		this.CBGLALOEPGN(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC6B RID: 48235 RVA: 0x0008FE6E File Offset: 0x0008E06E
	public void DLJFGNHKDKI()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.CFEICIDJJKO();
		}
		this.JOBFJKDKOFJ();
	}

	// Token: 0x0600BC6C RID: 48236 RVA: 0x00445BA4 File Offset: 0x00443DA4
	private bool FGCPLJMMBPC()
	{
		int num = 0;
		int num2 = 1;
		Vector2[] subdivisions = this.Subdivisions;
		for (int i = 0; i < subdivisions.Length; i += 0)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.BKJKDFEADNI(num * num2);
		return this.FNDIKKLOMKE() > (int)(91 - this.FIRST_GROUP_ID);
	}

	// Token: 0x0600BC6D RID: 48237 RVA: 0x00445C18 File Offset: 0x00443E18
	private void DKPECGACDNE(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1959f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 979f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)5), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 113f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1967f;
					cellTreeNode.Center = new Vector3(num5, num8, 347f);
					cellTreeNode.Size = new Vector3(num4, num7, 838f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 952f, num8 - num7 / 1953f, 1660f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 603f, num8 + num7 / 1222f, 1232f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 571f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 835f;
					cellTreeNode.Center = new Vector3(num5, 1030f, num11);
					cellTreeNode.Size = new Vector3(num4, 500f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1980f, 770f, num11 - num10 / 1458f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1261f, 771f, num11 + num10 / 1504f);
				}
				OJICGBOIKNA.PKBCCPADPFG(cellTreeNode);
				this.FDGOBPEMKEM(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC6E RID: 48238 RVA: 0x00445E88 File Offset: 0x00444088
	public List<byte> GetActiveCells(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		this.CellTree.RootNode.GetActiveCells(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC6F RID: 48239 RVA: 0x00445EB8 File Offset: 0x004440B8
	public List<byte> AHBHLMMJDEC(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(1);
		this.HFPDFLNLFDE().NKPGMGBGNJE().EPHCAFNANAP(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC70 RID: 48240 RVA: 0x00445EE8 File Offset: 0x004440E8
	private void BIHGNOALFAG(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 968f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1308f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)7), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 239f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 398f;
					cellTreeNode.Center = new Vector3(num5, num8, 111f);
					cellTreeNode.Size = new Vector3(num4, num7, 1170f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 903f, num8 - num7 / 1460f, 1220f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 95f, num8 + num7 / 74f, 1257f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1888f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1468f;
					cellTreeNode.Center = new Vector3(num5, 889f, num11);
					cellTreeNode.Size = new Vector3(num4, 507f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 209f, 1773f, num11 - num10 / 1832f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 570f, 1736f, num11 + num10 / 1974f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				this.KPGHEBANPOB(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void NMEAILAJAJB(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC72 RID: 48242 RVA: 0x00446158 File Offset: 0x00444358
	private void BGBDNKMCJFM()
	{
		if (!this.MKCPDLFDDKJ())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[5];
				array[1] = "#91CCFF";
				array[0] = (int)(75 - this.FIRST_GROUP_ID);
				array[5] = "Unknown player asked for PickupItems";
				array[5] = this.KEMEMDDGHIB();
				array[7] = "_Value2";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 486f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 1156f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 204f, this.Center.y - this.Size.y / 740f, 553f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1497f, this.Center.y + this.Size.y / 432f, 767f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 503f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 472f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1624f, 489f, this.Center.y - this.Size.y / 1747f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1021f, 1718f, this.Center.y + this.Size.y / 1700f);
		}
		this.GOPOBDAKOLC(cellTreeNode, 1);
		this.CBGLALOEPGN(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void AAHPGCFLION(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC74 RID: 48244 RVA: 0x0008FE93 File Offset: 0x0008E093
	private void BPKANKPLJMO()
	{
		if (this.OHFAMNJPPHB() != null && this.BEKPEPKJKPB().NDPACPKGCEH() != null)
		{
			this.BEKPEPKJKPB().GOAFJLEFEOD().FBKBMIKIEKE();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BC75 RID: 48245 RVA: 0x0008FACF File Offset: 0x0008DCCF
	private void GMPGOANOACK(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC76 RID: 48246 RVA: 0x0044649C File Offset: 0x0044469C
	private bool LGNFHOLJENP()
	{
		int num = 0;
		int num2 = 1;
		Vector2[] subdivisions = this.Subdivisions;
		for (int i = 0; i < subdivisions.Length; i += 0)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.OHNCLPFIBAG(num * num2);
		return this.JGIMDKNACLC() > (int)(179 - this.FIRST_GROUP_ID);
	}

	// Token: 0x0600BC77 RID: 48247 RVA: 0x0008FECC File Offset: 0x0008E0CC
	private void BGFCMMDKCOI()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.HFLNGPFHCFD();
	}

	// Token: 0x0600BC78 RID: 48248 RVA: 0x00446510 File Offset: 0x00444710
	private void DCJCOOBBDNN(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1795f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1848f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Root, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1257f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 96f;
					cellTreeNode.Center = new Vector3(num5, num8, 1628f);
					cellTreeNode.Size = new Vector3(num4, num7, 1159f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1089f, num8 - num7 / 698f, 27f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 562f, num8 + num7 / 176f, 1417f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1759f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 595f;
					cellTreeNode.Center = new Vector3(num5, 1690f, num11);
					cellTreeNode.Size = new Vector3(num4, 730f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 509f, 1616f, num11 - num10 / 584f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 873f, 643f, num11 + num10 / 1003f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				this.GOPOBDAKOLC(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC7A RID: 48250 RVA: 0x00446780 File Offset: 0x00444980
	public List<byte> JJLNGHHPFOM(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(1);
		this.OHFAMNJPPHB().ECLEOHLDHAC().CCIKBIKMOMH(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC7B RID: 48251 RVA: 0x004467B0 File Offset: 0x004449B0
	private void GOPOBDAKOLC(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 54f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 435f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Node, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1618f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1192f;
					cellTreeNode.Center = new Vector3(num5, num8, 996f);
					cellTreeNode.Size = new Vector3(num4, num7, 1248f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1166f, num8 - num7 / 1221f, 974f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 408f, num8 + num7 / 1312f, 336f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 594f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1353f;
					cellTreeNode.Center = new Vector3(num5, 1235f, num11);
					cellTreeNode.Size = new Vector3(num4, 35f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 379f, 845f, num11 - num10 / 469f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 452f, 233f, num11 + num10 / 780f);
				}
				OJICGBOIKNA.CADHBIGOLKK(cellTreeNode);
				this.OIHNDIFOIMA(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC7C RID: 48252 RVA: 0x0008FEE0 File Offset: 0x0008E0E0
	private void EPCAPPLPFED()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.PNADNBIIMAP();
	}

	// Token: 0x0600BC7D RID: 48253 RVA: 0x00446A20 File Offset: 0x00444C20
	public List<byte> HFALBFGIPKO(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(1);
		this.BEKPEPKJKPB().MCOMLDBMBMB().GNMJGLGICGB(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x00446A50 File Offset: 0x00444C50
	private void KPGHEBANPOB(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 2f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 2f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : CellTreeNode.ENodeType.Leaf, OJICGBOIKNA);
				if (this.YIsUpAxis)
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
				this.KPGHEBANPOB(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC7F RID: 48255 RVA: 0x0008FB6F File Offset: 0x0008DD6F
	private void JHPNKEHEBCA(CellTree DPNHODJHGJL)
	{
		this.<GCJHHIHBOND>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC80 RID: 48256 RVA: 0x00446CC0 File Offset: 0x00444EC0
	private void OPNHJGJALEH(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 499f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1187f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)6), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1515f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 423f;
					cellTreeNode.Center = new Vector3(num5, num8, 698f);
					cellTreeNode.Size = new Vector3(num4, num7, 480f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1475f, num8 - num7 / 1228f, 397f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 192f, num8 + num7 / 925f, 1257f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1077f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1351f;
					cellTreeNode.Center = new Vector3(num5, 1238f, num11);
					cellTreeNode.Size = new Vector3(num4, 1475f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 400f, 1940f, num11 - num10 / 730f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 925f, 168f, num11 + num10 / 620f);
				}
				OJICGBOIKNA.MPDCNPHDBBO(cellTreeNode);
				this.NBNOCABOPIA(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BC81 RID: 48257 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void OIHDNODFBLI(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x0008FAC7 File Offset: 0x0008DCC7
	// (set) Token: 0x0600BC87 RID: 48263 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	public int CellCount { get; private set; }

	// Token: 0x0600BC83 RID: 48259 RVA: 0x0008FA9A File Offset: 0x0008DC9A
	public CellTree BEKPEPKJKPB()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BC84 RID: 48260 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
	public void FNNCPGGOGMF()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.BGBDNKMCJFM();
		}
		this.HCDPJNPIEEI();
	}

	// Token: 0x0600BC85 RID: 48261 RVA: 0x0008FAA2 File Offset: 0x0008DCA2
	private void JPJGJPGABBL(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC86 RID: 48262 RVA: 0x0008FABF File Offset: 0x0008DCBF
	public Dictionary<int, GameObject> CAOGMMKDGFD()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BC88 RID: 48264 RVA: 0x00446F30 File Offset: 0x00445130
	private void HODNJHNDKGA()
	{
		if (!this.IGOCDAEKKEN())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[0];
				array[1] = "R1";
				array[1] = (int)(110 - this.FIRST_GROUP_ID);
				array[7] = "_TimeX";
				array[7] = this.EMMHIHIANGL();
				array[1] = "maps.";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 48f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 1630f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1925f, this.Center.y - this.Size.y / 1979f, 575f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 135f, this.Center.y + this.Size.y / 1010f, 998f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 295f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 16f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1628f, 1575f, this.Center.y - this.Size.y / 225f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 973f, 1941f, this.Center.y + this.Size.y / 903f);
		}
		this.JACDMBCEAOF(cellTreeNode, 0);
		this.CBGLALOEPGN(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC89 RID: 48265 RVA: 0x00447274 File Offset: 0x00445474
	private void HFLNGPFHCFD()
	{
		if (!this.FGCPLJMMBPC())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[6];
				array[0] = "_TimeX";
				array[0] = (int)(160 - this.FIRST_GROUP_ID);
				array[4] = " while connecting to: ";
				array[5] = this.OPEEDKDBGGF();
				array[0] = "_ScreenResolution";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1974f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 808f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 1932f, this.Center.y - this.Size.y / 489f, 1495f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 75f, this.Center.y + this.Size.y / 367f, 644f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 1590f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 1327f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 518f, 93f, this.Center.y - this.Size.y / 1315f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 954f, 58f, this.Center.y + this.Size.y / 1476f);
		}
		this.FDGOBPEMKEM(cellTreeNode, 1);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BC8A RID: 48266 RVA: 0x004475B8 File Offset: 0x004457B8
	private void NNIJHCDJMFG(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 877f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 576f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Node, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 664f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 623f;
					cellTreeNode.Center = new Vector3(num5, num8, 1351f);
					cellTreeNode.Size = new Vector3(num4, num7, 1369f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 678f, num8 - num7 / 1767f, 1933f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1493f, num8 + num7 / 924f, 755f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 921f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 598f;
					cellTreeNode.Center = new Vector3(num5, 1399f, num11);
					cellTreeNode.Size = new Vector3(num4, 1031f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 688f, 9f, num11 - num10 / 953f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1996f, 377f, num11 + num10 / 1973f);
				}
				OJICGBOIKNA.FNEHKFAHOLP(cellTreeNode);
				this.LDJPJAINJNA(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BC8B RID: 48267 RVA: 0x00447828 File Offset: 0x00445A28
	public List<byte> CCIKBIKMOMH(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(1);
		this.OHFAMNJPPHB().INGDIFJLAAP().HOHFPFFAOOO(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BC8C RID: 48268 RVA: 0x00447858 File Offset: 0x00445A58
	private bool ONLEIFEJKMA()
	{
		int num = 1;
		int num2 = 1;
		Vector2[] subdivisions = this.Subdivisions;
		for (int i = 1; i < subdivisions.Length; i += 0)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.BKJKDFEADNI(num * num2);
		return this.EMMHIHIANGL() <= (int)(35 - this.FIRST_GROUP_ID);
	}

	// Token: 0x0600BC8D RID: 48269 RVA: 0x004478CC File Offset: 0x00445ACC
	private void NBNOCABOPIA(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1341f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 802f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)7), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1418f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1297f;
					cellTreeNode.Center = new Vector3(num5, num8, 1242f);
					cellTreeNode.Size = new Vector3(num4, num7, 401f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 943f, num8 - num7 / 1469f, 1412f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1369f, num8 + num7 / 170f, 1368f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 635f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1185f;
					cellTreeNode.Center = new Vector3(num5, 1562f, num11);
					cellTreeNode.Size = new Vector3(num4, 1620f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1965f, 350f, num11 - num10 / 609f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1082f, 1629f, num11 + num10 / 932f);
				}
				OJICGBOIKNA.AMMKMACNAOL(cellTreeNode);
				this.OPNHJGJALEH(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x04001605 RID: 5637
	private const int FEKPDAFDEJL = 250;

	// Token: 0x04001606 RID: 5638
	public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;

	// Token: 0x04001607 RID: 5639
	public readonly byte FIRST_GROUP_ID = 1;

	// Token: 0x04001608 RID: 5640
	public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER = new int[]
	{
		0,
		1,
		1,
		1
	};

	// Token: 0x04001609 RID: 5641
	public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER = new int[]
	{
		0,
		2,
		1,
		2,
		0,
		2,
		1,
		2
	};

	// Token: 0x0400160A RID: 5642
	public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER = new int[]
	{
		0,
		3,
		2,
		3,
		1,
		3,
		2,
		3,
		1,
		3,
		2,
		3
	};

	// Token: 0x0400160B RID: 5643
	public Vector2 Center;

	// Token: 0x0400160C RID: 5644
	public Vector2 Size = new Vector2(25f, 25f);

	// Token: 0x0400160D RID: 5645
	public Vector2[] Subdivisions = new Vector2[3];

	// Token: 0x0400160E RID: 5646
	public int NumberOfSubdivisions;

	// Token: 0x04001612 RID: 5650
	public bool YIsUpAxis = true;

	// Token: 0x04001613 RID: 5651
	public bool RecreateCellHierarchy;

	// Token: 0x04001614 RID: 5652
	private byte KDGFPOOOFEA;
}
