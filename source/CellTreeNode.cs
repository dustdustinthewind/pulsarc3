// CellTreeNode
using System.Collections.Generic;
using UnityEngine;

public class CellTreeNode
{
	public enum ENodeType
	{
		Root,
		Node,
		Leaf
	}

	public byte Id;

	public Vector3 Center;

	public Vector3 Size;

	public Vector3 TopLeft;

	public Vector3 BottomRight;

	public ENodeType NodeType;

	public CellTreeNode Parent;

	public List<CellTreeNode> Childs;

	private float CNPIACHIHKD;

	public bool NMBELGEIENA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public bool HFJFIGKDLIK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 295f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1190f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void NEMEFLABHLE()
	{
	}

	public void EDEDOPLOHCI()
	{
	}

	public void DHDDGIEELKJ()
	{
	}

	public bool NELBHGAPMDK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return false;
	}

	public void CMPGPNNHNIJ(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void NGLDKNJDCOK()
	{
	}

	public bool LMDHOOOLOMN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1967f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1057f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool PFGGLIDPDOE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public bool MDGFCKNGJPA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public void JANKHBIIGIA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)7)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!AKGEDOANLJA(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void CHEBDEFBPCJ()
	{
	}

	public void DDPMKCNBBDC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)6)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!GHBKIJEEOHA(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (PDFBKJPNBNJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool ELLOCFDGHKF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1515f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 136f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public CellTreeNode()
	{
	}

	public void ECOMEJAKNKF()
	{
	}

	public bool DBDNCGMEPDM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1366f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1116f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void LIGIABGAEGM()
	{
	}

	public bool GDPBEDNLIJD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1295f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 934f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool GHBKIJEEOHA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 347f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1472f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool GDPIIKAEBHM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 862f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 332f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void GJKLHMCOAGE()
	{
	}

	public void NOOFDCCDCGF(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void ANNOEGFBPNC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.HGOPIFCAAII(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!AKGEDOANLJA(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HLDONMPPOJB(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void Draw()
	{
	}

	public bool FCHJNDHIMAK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public void LFGHCJAKCOF()
	{
	}

	public void IPECMFMPHLG(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void BECEKBEMOHA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != 0)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.AHBHLMMJDEC(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!GDPBEDNLIJD(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (GAGLFGAECCN(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void EMPOBMIAENA()
	{
	}

	public void LLBINGMKBHL(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.ALLMEMKPBOE(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!DLCACJNALCB(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (PIPHBDHEMFA(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool AOBPBKNPDLA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public bool PJJDGBNGBKN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public void DFJDCCPEDGA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.ALLMEMKPBOE(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!NJCLPGMNHLL(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (NMBELGEIENA(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void OLDGCEOLDMN(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void BPEEDLPNPCB()
	{
	}

	public void MOKFGMHFHFM(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void FIOEMIMKGLF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!ALBHGMHLJMK(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (PDFBKJPNBNJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool KELBGKBHOAA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 239f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 73f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool OCANCJNGMDJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public void BIJNGCBHJOJ(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!IENJCNJFKEN(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (DIJHINFDGGA(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void FCGJPIONJMC(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void JOGGNNGCKGD(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool CHBJBCMLFFN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 498f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 402f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool NJCLPGMNHLL(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 347f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1126f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool LAFAJGMMMHF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return false;
	}

	public bool FFBIALNCLMP(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public void KEBHODOHCIB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!KELBGKBHOAA(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (KAEDIAFMHHI(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void IKGCEOPLOOP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)6)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.CKNGPLDAGEB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!DLCACJNALCB(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (LNPEFAJLPBF(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool HIIIPHIKIPI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return false;
	}

	public void IKKGIBIJBOJ()
	{
	}

	public void FLICAKGALBI(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.KEBHODOHCIB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (LNPEFAJLPBF(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void KPOAIENGKDL()
	{
	}

	public CellTreeNode(byte JMMILEFMACB, ENodeType CKEACKJDOPA, CellTreeNode OJICGBOIKNA)
	{
		Id = JMMILEFMACB;
		NodeType = CKEACKJDOPA;
		Parent = OJICGBOIKNA;
	}

	public void FPBMCGDBNNL()
	{
	}

	public bool PDFBKJPNBNJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public bool POLPIKDALDH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 113f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 395f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void GODNFNGLIGH(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void KJBNDCHOLEK(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void APCHLIDFJIA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Node)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.KDFMFCBIDIF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!IEHKKLFKNOI(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (LAFAJGMMMHF(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void GetActiveCells(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!IsPointNearCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (IsPointInsideCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool DIJHINFDGGA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public bool PIPHBDHEMFA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public bool FNJENOLOAKD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public bool GAKEPBBEMPK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 659f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 265f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void NAHNABFFJKF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)5)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.KEBHODOHCIB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!HOIAMGPNMHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (FFBIALNCLMP(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void DBIDFDBFPMB()
	{
	}

	public bool IsPointInsideCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public bool EPJJCJICNLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 528f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 91f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void OPBKEFPFGDE()
	{
	}

	public bool FLBJIGIGCIE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 774f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1084f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void GHBGJMMLJLP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)5)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.BECEKBEMOHA(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!GDPIIKAEBHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (LAFAJGMMMHF(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool GAGLFGAECCN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public void BCJDCNIGLEI(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void BMFHNOGJDOH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)6)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!LMDHOOOLOMN(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (MLMKEHJMFLH(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool JCNLFKEIICC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 925f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1308f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool LDFHIFOABBN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public void JCCMGLEJKAO()
	{
	}

	public bool DLCACJNALCB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 399f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 18f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool FOLLIEOFKOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return false;
	}

	public void MDPDHOHHGDF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.JANKHBIIGIA(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!EPJJCJICNLI(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HIIIPHIKIPI(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void FGHJJFLABHM(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!HOIAMGPNMHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (LDEJIAAPNMI(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(0, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void HANJAOELBBD(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!EEGFPABBMOP(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void CJCKIJNHEOF(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool HGAFPFHDGOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public bool HLDONMPPOJB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public void ECNBANDEBAJ(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool HCIOEHKIGPJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public bool ALBHGMHLJMK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1487f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 847f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void NCLNCCPEEBA(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void JOGMBEECLKG(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void EFMEGDKLJNO(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool GHMOLNPCNEM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public void NNCHEPFGKGE(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void HDKELGGAAAP(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void CNLHEHFGFCO()
	{
	}

	public bool FELLGOKLPKB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1426f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1014f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool LDEJIAAPNMI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return true;
	}

	public void OECLDIOKCAN(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool IEHKKLFKNOI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 736f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 551f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void HGOPIFCAAII(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!KELBGKBHOAA(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (FNJENOLOAKD(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool AALCHPHNLIN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return false;
		}
		return false;
	}

	public bool HOIAMGPNMHM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 494f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 444f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool IsPointNearCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 0f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 2f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void AddChild(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool DPGDLDAJMID(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1915f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1695f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool OEBAFFDFHDC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 809f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 332f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void EFDEBAIGGJC(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void EPHCAFNANAP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)6)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void ALLMEMKPBOE(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Leaf)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.HANJAOELBBD(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!OEBAFFDFHDC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (FNJENOLOAKD(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public bool AKGEDOANLJA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1329f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1849f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool KAEDIAFMHHI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public void BLCMAHBOELD(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void MFFPCCIFFPL()
	{
	}

	public void KDFMFCBIDIF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != 0)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!EEGFPABBMOP(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (PFGGLIDPDOE(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(1, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void CIIPKLDANMM(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void BALLCNLCOPI(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void FNOFCBBKHIJ()
	{
	}

	public bool IENJCNJFKEN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 97f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1060f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void FEJAIKODJON(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool EEGFPABBMOP(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 845f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 497f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void BGBIOINFGLC()
	{
	}

	public bool MLMKEHJMFLH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public bool LNPEFAJLPBF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < TopLeft.x || CGAHPDFGJHH.x > BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= TopLeft.y && CGAHPDFGJHH.y <= BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= TopLeft.z && CGAHPDFGJHH.z <= BottomRight.z)
		{
			return true;
		}
		return true;
	}

	public void AHBHLMMJDEC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)7)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.AHBHLMMJDEC(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (OCANCJNGMDJ(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}

	public void DNJFKFABJCI(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void DIJIAKPIJCL(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void CKNGPLDAGEB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.HANJAOELBBD(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!DPGDLDAJMID(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (HLDONMPPOJB(EFODIOEJNAC, JOPCODOJBHD))
		{
			NBMPFGDCLEL.Insert(0, Id);
			for (CellTreeNode parent = Parent; parent != null; parent = parent.Parent)
			{
				NBMPFGDCLEL.Insert(1, parent.Id);
			}
		}
		else
		{
			NBMPFGDCLEL.Add(Id);
		}
	}
}
