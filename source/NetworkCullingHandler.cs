// NetworkCullingHandler
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
	private int DPGILFLHKIM;

	private CullArea BMLPKAEJLDK;

	private List<byte> NHLHOKCKIEF;

	private List<byte> NBMPFGDCLEL;

	private PhotonView LMGCEPHCNBN;

	private Vector3 DBBNMCLENHH;

	private Vector3 BLPBCOCAKGG;

	private void OnGUI()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "Inside cells:\n";
		string text2 = "Subscribed cells:\n";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + " | ";
			}
			text2 = text2 + NBMPFGDCLEL[i] + " | ";
		}
		GUI.Label(new Rect(20f, (float)Screen.height - 120f, 200f, 40f), "<color=white>PhotonView Group: " + LMGCEPHCNBN.group + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
		GUI.Label(new Rect(20f, (float)Screen.height - 100f, 200f, 40f), "<color=white>" + text + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
		GUI.Label(new Rect(20f, (float)Screen.height - 60f, 200f, 40f), "<color=white>" + text2 + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
	}

	private void OKKKCIAIABC()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "/?player=";
		string text2 = " SphereWaveform.cs";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "settings.hitvariation";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_TimeX";
		}
		GUI.Label(new Rect(1547f, (float)Screen.height - 536f, 1475f, 705f), "Right Stick Click" + LMGCEPHCNBN.group + "TotalHitsScoreText", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 98
		});
		GUI.Label(new Rect(1092f, (float)Screen.height - 1254f, 375f, 865f), "_Value3" + text + "#000000", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 113
		});
		GUI.Label(new Rect(1866f, (float)Screen.height - 1037f, 1284f, 211f), "_ScreenResolution" + text2 + ".message", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 20
		});
	}

	private void IMCKJCHKMKB()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	private void BDBKIEIIFPB()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (BMLPKAEJLDK == null)
		{
			BMLPKAEJLDK = Object.FindObjectOfType<CullArea>();
		}
		NHLHOKCKIEF = new List<byte>(1);
		NBMPFGDCLEL = new List<byte>(1);
		BLPBCOCAKGG = (DBBNMCLENHH = base.transform.position);
	}

	private void OnEnable()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (BMLPKAEJLDK == null)
		{
			BMLPKAEJLDK = Object.FindObjectOfType<CullArea>();
		}
		NHLHOKCKIEF = new List<byte>(0);
		NBMPFGDCLEL = new List<byte>(0);
		BLPBCOCAKGG = (DBBNMCLENHH = base.transform.position);
	}

	private bool GJDBKAMMEAJ()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.KEBHODOHCIB(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return false;
		}
		return true;
	}

	private bool JMLADKONEMB()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.HFALBFGIPKO(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return false;
		}
		return false;
	}

	private bool OEHDLGCJONP()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return true;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return true;
	}

	private bool PHOGNHBFNHA()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return true;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return false;
	}

	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void GLKJFIOCPLF()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (BMLPKAEJLDK == null)
		{
			BMLPKAEJLDK = Object.FindObjectOfType<CullArea>();
		}
		NHLHOKCKIEF = new List<byte>(0);
		NBMPFGDCLEL = new List<byte>(1);
		BLPBCOCAKGG = (DBBNMCLENHH = base.transform.position);
	}

	private void FEHCNJLLJMP()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	private void KCDLPGIDHCK()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "_ScreenResolution";
		string text2 = "float,1.5";
		for (int i = 1; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "steamid";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "Joystick1Button1";
		}
		GUI.Label(new Rect(518f, (float)Screen.height - 1737f, 1703f, 1424f), "#" + LMGCEPHCNBN.group + "CameraFilterPack/Blend2Camera_PinLight", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -94
		});
		GUI.Label(new Rect(667f, (float)Screen.height - 700f, 1568f, 1873f), "_BlurSize" + text + "Joystick1Button11", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 116
		});
		GUI.Label(new Rect(1728f, (float)Screen.height - 852f, 1457f, 1566f), "menu.relaxinfo" + text2 + "_ColorR", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -87
		});
	}

	private void OJFLMBDKBME()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in NHLHOKCKIEF)
		{
			if (!NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), NBMPFGDCLEL.ToArray());
	}

	private void AJCFIBPGAME()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "misses";
		string text2 = "Set Sun Input";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "maps.";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "checkpoint";
		}
		GUI.Label(new Rect(1962f, (float)Screen.height - 122f, 10f, 1240f), "[MapsData] Base maps loaded" + LMGCEPHCNBN.group + "907198288", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 113
		});
		GUI.Label(new Rect(1537f, (float)Screen.height - 965f, 1257f, 1395f), "challenges." + text + "menu.playedsolo", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 116
		});
		GUI.Label(new Rect(72f, (float)Screen.height - 211f, 820f, 731f), "_MatrixColor" + text2 + "Editor/", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
	}

	private void CNGAJDBOCLJ()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	private void DAMLLADHOMK()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in NHLHOKCKIEF)
		{
			if (!NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), NBMPFGDCLEL.ToArray());
	}

	private void CAEGIHPNLOG()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "Tab1Content";
		string text2 = "{0}";
		for (int i = 0; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "OK";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_ScreenResolution";
		}
		GUI.Label(new Rect(220f, (float)Screen.height - 1903f, 1044f, 163f), "file://" + LMGCEPHCNBN.group + "_Radius", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -48
		});
		GUI.Label(new Rect(1894f, (float)Screen.height - 1966f, 1232f, 467f), "OK" + text + "hidden", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 73
		});
		GUI.Label(new Rect(52f, (float)Screen.height - 522f, 883f, 401f), "mapid" + text2 + "[MapsData] Base maps loaded", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 91
		});
	}

	private void Start()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	private bool GINMPGGEEEH()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.CCIKBIKMOMH(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return true;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return false;
		}
		return true;
	}

	private void MLLPGPANCHI()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (BMLPKAEJLDK == null)
		{
			BMLPKAEJLDK = Object.FindObjectOfType<CullArea>();
		}
		NHLHOKCKIEF = new List<byte>(1);
		NBMPFGDCLEL = new List<byte>(0);
		BLPBCOCAKGG = (DBBNMCLENHH = base.transform.position);
	}

	private bool NLAMGDAABAC()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.ELMBCNNBICM(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return false;
	}

	private void AMCBPKABFFI()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in NHLHOKCKIEF)
		{
			if (!NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), NBMPFGDCLEL.ToArray());
	}

	private void FOMNCPKKCFN()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GINMPGGEEEH())
			{
				BEEBFGOEFMC();
			}
		}
	}

	private void LPKLOFJJJEI()
	{
		if (!LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "challenges";
		string text2 = "_Value3";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "[LevelEditorScene] Error: I/O Failure! :(";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "Set particles gravity";
		}
		GUI.Label(new Rect(1720f, (float)Screen.height - 1422f, 116f, 1246f), "_Value3" + LMGCEPHCNBN.group + "_FarCorner", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 22
		});
		GUI.Label(new Rect(282f, (float)Screen.height - 1785f, 177f, 1859f), "ItemNameText" + text + "_TimeX", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -113
		});
		GUI.Label(new Rect(1986f, (float)Screen.height - 1471f, 1495f, 1934f), "Set Player Distance" + text2 + "[LevelEditorScene] Map submitted!", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 94
		});
	}

	private void BEEBFGOEFMC()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in NHLHOKCKIEF)
		{
			if (!NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), NBMPFGDCLEL.ToArray());
	}

	private void AAPKBNDHBLI()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && NLAMGDAABAC())
			{
				BEEBFGOEFMC();
			}
		}
	}

	private void KDMANOEMOCA()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void IIFCIDDJHPM()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GJDBKAMMEAJ())
			{
				GEONJNILKEM();
			}
		}
	}

	private void Update()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && PHOGNHBFNHA())
			{
				GEONJNILKEM();
			}
		}
	}

	private void LLJLDLLNFBH()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GINMPGGEEEH())
			{
				BEEBFGOEFMC();
			}
		}
	}

	private bool HGIJNIMIACB()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.AHBHLMMJDEC(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return true;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return true;
	}

	private void LCJHDLKJEOM()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && OEHDLGCJONP())
			{
				OJFLMBDKBME();
			}
		}
	}

	private void GEONJNILKEM()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in NHLHOKCKIEF)
		{
			if (!NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), NBMPFGDCLEL.ToArray());
	}

	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private bool IDFIDMFMIGL()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.KAMPFMDNIHO(base.transform.position);
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (NBMPFGDCLEL.Count != NHLHOKCKIEF.Count)
		{
			return true;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return false;
		}
		return true;
	}

	private void PAKPHKPDKGE()
	{
		if (LMGCEPHCNBN.isMine && PhotonNetwork.inRoom)
		{
			if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				LMGCEPHCNBN.group = BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}
}
