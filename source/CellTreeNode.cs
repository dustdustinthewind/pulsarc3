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

	public void AGLKKDBMAIH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)3)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.GNMJGLGICGB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!FELLGOKLPKB(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
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

	public bool GMAKJMJLJHH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void DIKHLOJLCME()
	{
	}

	public void LFGPIPAJDJA()
	{
	}

	public void LOFFINJKDHG(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.LOFFINJKDHG(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!FELLGOKLPKB(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (IIBBOPHLEKC(EFODIOEJNAC, JOPCODOJBHD))
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

	public void DHDDGIEELKJ()
	{
	}

	public bool HKJJBLKLMNB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 666f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1365f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void ODLGCHBFCPF()
	{
	}

	public void Draw()
	{
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

	public void CCIKBIKMOMH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.GNMJGLGICGB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!ILIOBKGDLGL(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
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
			return false;
		}
		return false;
	}

	public bool FELLGOKLPKB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 628f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 181f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void CGKJMMOHJOK(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool BJIPDJACEMM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void HONILALBABF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.HONILALBABF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!IsPointNearCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (ODCMPNMLEPA(EFODIOEJNAC, JOPCODOJBHD))
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

	public void CADHBIGOLKK(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void AddChild(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void GNMJGLGICGB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)5)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.LBHDCICHMNN(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (MDGFCKNGJPA(EFODIOEJNAC, JOPCODOJBHD))
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

	public void NHHBPLBJJEJ(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void FHPEOMJCKIH()
	{
	}

	public bool PKJHBIPKCLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1752f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 731f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool ODCMPNMLEPA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void CKNGPLDAGEB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)8)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.AGLKKDBMAIH(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (PNGAIKBAMLB(EFODIOEJNAC, JOPCODOJBHD))
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

	public CellTreeNode(byte JMMILEFMACB, ENodeType CKEACKJDOPA, CellTreeNode OJICGBOIKNA)
	{
		Id = JMMILEFMACB;
		NodeType = CKEACKJDOPA;
		Parent = OJICGBOIKNA;
	}

	public void GADLADPKCNE()
	{
	}

	public void PPDAGHKHLBL(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool IIBBOPHLEKC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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
			return false;
		}
		return true;
	}

	public void JCCMGLEJKAO()
	{
	}

	public void KNIJFMBAFGE()
	{
	}

	public void FNEHKFAHOLP(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool OIIDAKNCFHI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 607f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1634f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void LBHDCICHMNN(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Node)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.LOFFINJKDHG(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!FLBJIGIGCIE(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (FFBIALNCLMP(EFODIOEJNAC, JOPCODOJBHD))
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

	public void EPHCAFNANAP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.ELMBCNNBICM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
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

	public bool PNGAIKBAMLB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void BDELMHBAKOI(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool HFJFIGKDLIK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 914f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1178f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void OEKFHIGBMHG()
	{
	}

	public void HPFPCKDOFBJ()
	{
	}

	public bool GADPIKNPCJG(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 164f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1205f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool LCCNJDFCDLN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void JEHPCCANKDJ()
	{
	}

	public bool IEHKKLFKNOI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1195f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1328f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public void MPDCNPHDBBO(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void FBKBMIKIEKE()
	{
	}

	public void NJLEDOJJFJN()
	{
	}

	public CellTreeNode()
	{
	}

	public void HOHFPFFAOOO(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != ENodeType.Node)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!IEHKKLFKNOI(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (MDGFCKNGJPA(EFODIOEJNAC, JOPCODOJBHD))
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

	public bool JIMAMEJHCOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1395f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1348f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void ELMBCNNBICM(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (NodeType != (ENodeType)4)
		{
			foreach (CellTreeNode child in Childs)
			{
				child.AGLKKDBMAIH(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
			return;
		}
		if (!JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			return;
		}
		if (KLODKGLMOAD(EFODIOEJNAC, JOPCODOJBHD))
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

	public bool AKGEDOANLJA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1053f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 19f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool FLBJIGIGCIE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1992f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1098f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public bool FAHCBALMBLN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 293f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 656f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool AAHGPKANPHO(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public void HNAFFBPAHMG()
	{
	}

	public void PKBCCPADPFG(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(0);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public void FHCKMAHODHN()
	{
	}

	public bool NEALOMJLOJD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1029f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1602f;
		}
		return (CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD;
	}

	public void AMMKMACNAOL(CellTreeNode FGAAGCEKFLE)
	{
		if (Childs == null)
		{
			Childs = new List<CellTreeNode>(1);
		}
		Childs.Add(FGAAGCEKFLE);
	}

	public bool KLODKGLMOAD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
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

	public bool ILIOBKGDLGL(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 612f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 909f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool LIIPAJKMKKE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 959f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 970f;
		}
		return !((CGAHPDFGJHH - Center).sqrMagnitude <= CNPIACHIHKD * CNPIACHIHKD);
	}

	public bool EMIEDEMKFLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CNPIACHIHKD == 1070f)
		{
			CNPIACHIHKD = (Size.x + Size.y + Size.z) / 1284f;
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
}
