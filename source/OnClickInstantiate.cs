// OnClickInstantiate
using UnityEngine;

public class OnClickInstantiate : MonoBehaviour
{
	public GameObject Prefab;

	public int InstantiateType;

	private string[] PDBHEIPKPIN = new string[2] { "Mine", "Scene" };

	public bool showGui;

	private void DAPLLJDMJCK()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(124f, 545f, 846f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(943f, 116f, 862f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void OLFFIKHJIEO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -158, 1938f, 705f, 618f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void OBNBENFFJAC()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1671f, 236f, 1944f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(28f, 703f, 321f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void CAEGIHPNLOG()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 148, 580f, 840f, 626f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void HHKCCIJMGAB()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -42, 852f, 1060f, 1515f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void LEKGHGJPIJE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 151, 535f, 1844f, 1937f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void AHNBAOIENOO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -97, 446f, 864f, 58f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void JPNOHODALMI()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1301f, 156f, 1660f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1315f, 1936f, 944f), Quaternion.identity, 0, null);
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
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(93f, 1315f, 954f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(644f, 1590f, 1327f), Quaternion.identity, 0);
		}
	}

	private void JFMFICMKIAG()
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
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1887f, 1213f, 556f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(961f, 1206f, 716f), Quaternion.identity, 0);
		}
	}

	private void AJCFIBPGAME()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -171, 1676f, 1566f, 1463f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void PCABPJAANFH()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 9, 1239f, 797f, 387f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void JLJHPNKKJPJ()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -69, 1063f, 770f, 738f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void NGGLCOLOLHF()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -67, 613f, 1860f, 139f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void OJJEKKHIKAO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 132, 547f, 450f, 1586f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void GCLJNMOCIDM()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 148, 1076f, 1967f, 1801f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void PDKFMFCMPGE()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 39, 1313f, 1298f, 1925f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void LGHNKDFEOKO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -160, 740f, 553f, 1497f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
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
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(709f, 1523f, 454f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1808f, 1625f, 596f), Quaternion.identity, 1);
		}
	}

	private void GDNMIEHNGBL()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1705f, 1059f, 1314f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(765f, 863f, 972f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void KOCIIOKHKME()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 194, 808f, 1932f, 489f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void DBDCIAIJOKG()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1249f, 1060f, 1122f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(416f, 558f, 1874f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void OAGAGCMFGOM()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -11, 1293f, 53f, 445f));
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
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1861f, 1470f, 679f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(709f, 594f, 1758f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void CJFHNNICLEN()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(525f, 34f, 1703f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1075f, 1423f, 1336f), Quaternion.identity, 0, null);
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

	private void OGAIIBPLJBB()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 127, 1433f, 177f, 229f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
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

	private void LAOCNFBGEDE()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1273f, 733f, 1506f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(871f, 1324f, 1427f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void DJAABMENCCB()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(881f, 1183f, 409f), Quaternion.identity, 0);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1201f, 1906f, 674f), Quaternion.identity, 1, null);
				break;
			}
		}
	}

	private void CPJBNBJMJFA()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 134, 1333f, 511f, 1633f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void GGJKHODKNOC()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 112, 1999f, 1838f, 1954f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void CMOBHGHIBKL()
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
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(568f, 396f, 820f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(298f, 78f, 1272f), Quaternion.identity, 1);
		}
	}

	private void BCODHAOJLJL()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 125, 1786f, 1920f, 118f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void PCHKMGNOEDF()
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
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(1021f, 1718f, 1700f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(472f, 1624f, 489f), Quaternion.identity, 1);
		}
	}

	private void NMHIDAOMOGO()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 117, 18f, 299f, 1470f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void OGBJNAAAEGI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -136, 1471f, 301f, 425f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void APCENGAAHMC()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -40, 896f, 1316f, 170f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void HBNHHPJNNIP()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -138, 937f, 553f, 738f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void EOJGCJABGNC()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 117, 1211f, 440f, 850f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void GHDFEDMLPCB()
	{
		if (PhotonNetwork.inRoom)
		{
			switch (InstantiateType)
			{
			case 0:
				PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(1160f, 520f, 1947f), Quaternion.identity, 1);
				break;
			case 1:
				PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(720f, 1015f, 1686f), Quaternion.identity, 0, null);
				break;
			}
		}
	}

	private void ADLAFICKCFG()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 61, 1652f, 1371f, 1188f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}

	private void DDOMIEPBBBI()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - 131, 1849f, 682f, 898f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	private void LKFBADCLLML()
	{
		if (showGui)
		{
			GUILayout.BeginArea(new Rect(Screen.width - -34, 1818f, 907f, 364f));
			InstantiateType = GUILayout.Toolbar(InstantiateType, PDBHEIPKPIN);
			GUILayout.EndArea();
		}
	}
}
