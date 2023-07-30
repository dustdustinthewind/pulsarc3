// OnClickInstantiate
using UnityEngine;

public class OnClickInstantiate : MonoBehaviour
{
	public GameObject Prefab;

	public int InstantiateType;

	private string[] PDBHEIPKPIN = new string[2] { "Mine", "Scene" };

	public bool showGui;

	private void KMEPPEEEGGP()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(113f, 1675f, 164f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(340f, 23f, 684f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void LGMADMDBKNE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 176, 481f, 1985f, 563f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void JABMMIMOJMJ()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 126, 1030f, 1336f, 85f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void EIDIMHEPOLO()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(341f, 649f, 65f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(221f, 1141f, 563f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void EOJGCJABGNC()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 167, 602f, 1038f, 875f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void JLJHPNKKJPJ()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 114, 619f, 1490f, 783f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void HPKNKMOCCHJ()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(680f, 367f, 1285f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1512f, 177f, 1959f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void JLKEEOILNFI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -73, 911f, 240f, 1800f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void PDKFMFCMPGE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 38, 915f, 679f, 157f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HMKPEEAJODO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -166, 1665f, 1214f, 956f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void IKKCBILMLMC()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1535f, 287f, 1130f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1991f, 1962f, 106f), Quaternion.identity, 0);
		}
	}

	private void KCDLPGIDHCK()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -191, 123f, 1522f, 349f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HHKCCIJMGAB()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -127, 1225f, 979f, 339f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void FAGGMAKKMAE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 17, 810f, 1065f, 686f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void LAOCNFBGEDE()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(662f, 1855f, 1187f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1900f, 542f, 1607f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void GAMPNFOIFHF()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -90, 61f, 1088f, 931f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HFGANPKDCJI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(311f, 188f, 1545f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1294f, 702f, 1941f), Quaternion.identity, 0);
		}
	}

	private void OnGUI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 180, 0f, 180f, 50f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void JFMFICMKIAG()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(690f, 1060f, 302f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1880f, 1209f, 665f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void HHAECEMFKND()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(503f, 1340f, 515f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1339f, 930f, 756f), Quaternion.identity, 0);
		}
	}

	private void CJBCKPEOOGI()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(301f, 1436f, 1042f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(403f, 318f, 1869f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void OnClick()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void NECOKPEMDKP()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(938f, 319f, 1028f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(223f, 262f, 985f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void JPNOHODALMI()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(724f, 899f, 1296f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(905f, 264f, 1349f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void NHKMALPBBAP()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1562f, 265f, 64f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(168f, 1416f, 594f), Quaternion.identity, 0);
		}
	}

	private void KFMDOEEADDM()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1885f, 157f, 368f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1642f, 670f, 442f), Quaternion.identity, 1);
		}
	}

	private void GAIOOLFFAFI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1072f, 859f, 583f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(635f, 254f, 1312f), Quaternion.identity, 1);
		}
	}

	private void PCABPJAANFH()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -133, 1718f, 987f, 1216f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void DAPLLJDMJCK()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(318f, 675f, 1868f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1285f, 1766f, 944f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void MOHGKNDJFFL()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1889f, 338f, 1949f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1339f, 1544f, 1113f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void AHAIBKMLNAP()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 122, 497f, 734f, 1203f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void AKBAPOMKFPE()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1074f, 1437f, 719f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(389f, 1108f, 128f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void IIPAHIBFIHH()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(12f, 1887f, 1526f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1942f, 463f, 422f), Quaternion.identity, 1);
		}
	}

	private void CPJBNBJMJFA()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 49, 928f, 1195f, 1244f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void FCADKGNNELN()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -189, 1078f, 1274f, 716f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void PNEKMLABFCE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -46, 1132f, 177f, 1854f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void DDLBJCGMACI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1225f, 1998f, 757f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1757f, 569f, 1655f), Quaternion.identity, 1);
		}
	}

	private void ALKAFKPMGIK()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(965f, 1847f, 663f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(953f, 1345f, 341f), Quaternion.identity, 0);
		}
	}

	private void OADJCAIEKNN()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1219f, 1200f, 380f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1135f, 570f, 1451f), Quaternion.identity, 0);
		}
	}

	private void BDEGMPGLODD()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1179f, 12f, 278f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1166f, 262f, 74f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void PFILMFOHFPB()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(966f, 755f, 1833f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(826f, 144f, 1763f), Quaternion.identity, 0);
		}
	}

	private void OLHMGFBCENO()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(698f, 191f, 102f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(176f, 5f, 1272f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void CJFLPGBFBNL()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 9, 773f, 420f, 1172f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void MINMKOCOLEP()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 64, 177f, 802f, 40f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HKOJIMNBFPN()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 8, 510f, 788f, 209f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void KDABDGBBAAN()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1477f, 742f, 1223f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1173f, 1868f, 1607f), Quaternion.identity, 1);
		}
	}

	private void PJCIENAGBGH()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 19, 1543f, 454f, 161f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void LJKOEIMJMMD()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(935f, 1965f, 27f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(750f, 1274f, 1594f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void FBDOGLBMDNG()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -35, 1891f, 1626f, 1393f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void BOGPGCFPCIC()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1969f, 454f, 870f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1758f, 194f, 1499f), Quaternion.identity, 1);
		}
	}

	private void LGHNKDFEOKO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 104, 688f, 1031f, 1263f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void LPKLOFJJJEI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 121, 1516f, 1975f, 1850f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void MDDGMDDHICG()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1592f, 1260f, 204f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1977f, 573f, 1006f), Quaternion.identity, 0);
		}
	}

	private void ODDHKPJIJGI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1821f, 30f, 760f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1448f, 599f, 962f), Quaternion.identity, 1);
		}
	}

	private void NMHIDAOMOGO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -177, 1608f, 1782f, 1465f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void OAGAGCMFGOM()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 78, 1998f, 559f, 78f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void JDNMFCFIDEM()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(933f, 1944f, 191f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(61f, 1629f, 1101f), Quaternion.identity, 1);
		}
	}

	private void MOIFIHHBFFF()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 68, 35f, 1063f, 1209f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void LLLOCCNLCNL()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -92, 977f, 722f, 0f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void KNKOCAKPJKF()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -100, 433f, 1767f, 261f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void NMOMMMPKMEL()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(633f, 946f, 100f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1844f, 1618f, 307f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void OGAIIBPLJBB()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 176, 287f, 1480f, 10f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void GCLJNMOCIDM()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 65, 430f, 1878f, 107f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void IDJHCPHEKFP()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 90, 769f, 431f, 500f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HJICAJKELGI()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(630f, 917f, 531f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(161f, 721f, 1640f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void MLFACDCDMAL()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -37, 701f, 1272f, 64f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void MILJCGDAPKA()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1580f, 643f, 1878f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1566f, 540f, 117f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void LPHKBPIIEMA()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1170f, 1896f, 1169f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1574f, 614f, 861f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void MBPKLNFHAFH()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1539f, 481f, 707f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1412f, 338f, 1122f), Quaternion.identity, 0);
		}
	}

	private void DPMIABFMGCO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 2, 1333f, 1489f, 850f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void IMNOHPHOEMN()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1036f, 18f, 1197f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(950f, 1758f, 408f), Quaternion.identity, 0);
		}
	}

	private void MCFNPLNJKBP()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(506f, 1043f, 335f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1530f, 398f, 1624f), Quaternion.identity, 0);
		}
	}

	private void DDOMIEPBBBI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -119, 313f, 1238f, 556f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void PHACPKPPBJF()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -53, 1670f, 436f, 1922f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void OEGDGBIKNGG()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(53f, 1057f, 800f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1963f, 792f, 1716f), Quaternion.identity, 1);
		}
	}

	private void GGCLKOJPPDD()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1405f, 516f, 914f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1624f, 587f, 1394f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void CAEGIHPNLOG()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 10, 983f, 1245f, 255f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void JABGIOLEKPG()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(760f, 1622f, 720f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(734f, 648f, 185f), Quaternion.identity, 0);
		}
	}

	private void LIFJIJLOEFK()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -156, 415f, 1586f, 1591f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void OJJEKKHIKAO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 152, 1161f, 1538f, 1210f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void FHGDNGBIFGF()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1091f, 169f, 1815f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1737f, 1131f, 233f), Quaternion.identity, 0);
		}
	}

	private void MMDIKBDNMLJ()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1560f, 1184f, 1113f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(394f, 1319f, 310f), Quaternion.identity, 0);
		}
	}

	private void PCHKMGNOEDF()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(873f, 113f, 1790f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(80f, 1159f, 628f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void AKGHJPACNLP()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 13, 1339f, 1564f, 79f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void KOCIIOKHKME()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 180, 321f, 549f, 561f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void EFLAICJDONO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 112, 1453f, 1605f, 1503f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}
}
