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

	private void MJEFMIPLFAB()
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

	private void HBNHHPJNNIP()
	{
		if (!LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "settings.enableranking";
		string text2 = "#failed: ";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "CameraFilterPack/FX_Funk";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_MatrixSpeed";
		}
		GUI.Label(new Rect(721f, (float)Screen.height - 444f, 1158f, 52f), "SetSatelliteColor" + LMGCEPHCNBN.group + "UsernameText", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -50
		});
		GUI.Label(new Rect(252f, (float)Screen.height - 82f, 371f, 1360f), "offsets" + text + "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -21
		});
		GUI.Label(new Rect(1744f, (float)Screen.height - 815f, 816f, 206f), "_TimeX" + text2 + "_Parasite", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 125
		});
	}

	private void KKGMKGHFELO()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.DOLKFPIABDD())
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

	private bool BFJNDDIFPJC()
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
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return false;
		}
		return true;
	}

	private void GPFJMKCGHGB()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && PHOGNHBFNHA())
			{
				OIMFIKGNNEB();
			}
		}
	}

	private bool JCFIFAAIJOM()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	private bool GCFFKNOHJGM()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	public void CJKDMGMPMJM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void ICILLMAKLMI()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD() && PhotonNetwork.inRoom)
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

	private bool FMILHKLNLPH()
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
			return false;
		}
		return false;
	}

	public void GLCCIHKIOJI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void JDKHBGDEONK()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void CNHEENCFCMF()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.BGJKMGJBPFA())
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

	private bool GCECOAALNFP()
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
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return true;
	}

	private void GFLAINNLMBO()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.BGJKMGJBPFA())
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

	private void ONKDMMJPEMN()
	{
		if (LMGCEPHCNBN.BGJKMGJBPFA())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && FMILHKLNLPH())
			{
				MMGEGAHEGIM();
			}
		}
	}

	private void JODODFGLOLD()
	{
		if (!LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "en";
		string text2 = "AudioClip";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "Can not SetMasterClient(). Not in room or in offlineMode.";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "resetach21";
		}
		GUI.Label(new Rect(576f, (float)Screen.height - 1524f, 8f, 1969f), "float,1" + LMGCEPHCNBN.group + "_SoftZDistance", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -42
		});
		GUI.Label(new Rect(421f, (float)Screen.height - 225f, 1740f, 1101f), "ItemNameText" + text + "_EmissionGain", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -12
		});
		GUI.Label(new Rect(1293f, (float)Screen.height - 446f, 1065f, 569f), "/" + text2 + "_ScreenResolution", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 68
		});
	}

	private void PCABPJAANFH()
	{
		if (!LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "{0}{1}:{2}";
		string text2 = "bad";
		for (int i = 0; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "SetParticlesColor";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "Subscribed cells:\n";
		}
		GUI.Label(new Rect(955f, (float)Screen.height - 291f, 1432f, 127f), "EditMenu" + LMGCEPHCNBN.group + "_RandomTexture", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -28
		});
		GUI.Label(new Rect(1092f, (float)Screen.height - 55f, 1362f, 1814f), "_Intensity" + text + "_Value", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -26
		});
		GUI.Label(new Rect(251f, (float)Screen.height - 1028f, 1155f, 649f), "_Value7" + text2 + "speed", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -50
		});
	}

	private void INODCHEOKGF()
	{
		if (!LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "The number of objects sent via a PhotonStreamQueue has to be the same each frame";
		string text2 = "_Value4";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "_ScreenResolution";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_Value1";
		}
		GUI.Label(new Rect(637f, (float)Screen.height - 768f, 761f, 1495f), "_Value7" + LMGCEPHCNBN.group + "Object ID. Case-Sensitive", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -9
		});
		GUI.Label(new Rect(1260f, (float)Screen.height - 1723f, 1983f, 93f), "_VelTex" + text + "_Value", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -17
		});
		GUI.Label(new Rect(215f, (float)Screen.height - 1231f, 288f, 1269f), "LoadMapCanvas" + text2 + "menu.selectedplaymode", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 29
		});
	}

	private void IEHKJPADFFM()
	{
		if (!LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "settings.enablehitsoundsinnormal";
		string text2 = "PossibleMapPointsText";
		for (int i = 1; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "_TimeX";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_MidGrey";
		}
		GUI.Label(new Rect(681f, (float)Screen.height - 188f, 403f, 1878f), "Fade" + LMGCEPHCNBN.group + "return ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -102
		});
		GUI.Label(new Rect(1351f, (float)Screen.height - 999f, 1134f, 1861f), "Image" + text + "/?player=", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 38
		});
		GUI.Label(new Rect(1559f, (float)Screen.height - 1342f, 1911f, 1781f), "[SERVER] Selected mode: " + text2 + "_MaxRadiusOrKInPaper", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 26
		});
	}

	private void AENGMPAMCFL()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.DOLKFPIABDD())
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

	private bool EJEDJODNBEN()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	public void FOHGOGIMPJJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
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

	private void FCKIJIKNMCF()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.BGJKMGJBPFA())
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

	public void LEPNLHBAHOL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	public void LBDNIDJNDJK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 5)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 5)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void GLEJGFLCLPJ()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD() && PhotonNetwork.inRoom)
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

	private bool MAFAKMHPAKE()
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
			return false;
		}
		if (NBMPFGDCLEL[BMLPKAEJLDK.NumberOfSubdivisions] != NHLHOKCKIEF[BMLPKAEJLDK.NumberOfSubdivisions])
		{
			return true;
		}
		return true;
	}

	private void HNDNDPECBPL()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && MAFAKMHPAKE())
			{
				NEKBANHJJJC();
			}
		}
	}

	private void EPJJDKJEDMM()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && MIBMPMEMPHH())
			{
				GEONJNILKEM();
			}
		}
	}

	public void JNCHBPPANKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	public void EOFAACNPFDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	public void LMOILMNEOFE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	public void HIDJLJIEPHK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void HOLDCFBBHHP()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.DOLKFPIABDD())
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

	private void FLHBCHLMOFK()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.BGJKMGJBPFA())
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

	private void DDOMIEPBBBI()
	{
		if (!LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = " url: ";
		string text2 = "_FixDistance";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "_Value2";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "GlassDistortion";
		}
		GUI.Label(new Rect(115f, (float)Screen.height - 549f, 1014f, 1234f), "CameraFilterPack/FX_Mirror" + LMGCEPHCNBN.group + "PossibleMapPointsText", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 15
		});
		GUI.Label(new Rect(511f, (float)Screen.height - 114f, 1234f, 1494f), "Tab2Content" + text + "_TimeX", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -53
		});
		GUI.Label(new Rect(1834f, (float)Screen.height - 430f, 1386f, 799f), "_WaveIntensity" + text2 + "settings_bindings_controller_type", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 35
		});
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

	private void ANDFECJLDIO()
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

	private void BMIOFJFMCBG()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void KMKLDAJLCNM()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && MAFAKMHPAKE())
			{
				GEONJNILKEM();
			}
		}
	}

	private void FABKIGNFECE()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GCFFKNOHJGM())
			{
				GEONJNILKEM();
			}
		}
	}

	private void HIDOPHINPAL()
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

	private void ANCKKLFPGDI()
	{
		if (LMGCEPHCNBN.BGJKMGJBPFA() && PhotonNetwork.inRoom)
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

	private void KLILJHJNICK()
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

	private bool MIKJANEDHJC()
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

	private void HJPCJGOEKMF()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void OCHMKJKBAPI()
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

	private void CHGDMHFEJOH()
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

	private void KJMHKHDMKIE()
	{
		if (!LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "_Value2";
		string text2 = "SetPosition";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "[LevelEditorScene] Print Audio Wave: Done";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "Gameplay/satellite";
		}
		GUI.Label(new Rect(1847f, (float)Screen.height - 1866f, 470f, 318f), "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy()." + LMGCEPHCNBN.group + "misses", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -38
		});
		GUI.Label(new Rect(1746f, (float)Screen.height - 253f, 1442f, 1813f), "_Value2" + text + "Set Background Color", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -27
		});
		GUI.Label(new Rect(1984f, (float)Screen.height - 1501f, 889f, 1189f), "settings.volume.game" + text2 + "_MainTex2", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 11
		});
	}

	private void GFBOBIBIOMC()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.DOLKFPIABDD())
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

	private void CFFCLAHMBAA()
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

	private void PAHNKEGFGHB()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.KCAOJFPDEIP())
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

	private void CDMHFHPNCDO()
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

	private void AAPKBNDHBLI()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && CPGDKKIDALK())
			{
				GEONJNILKEM();
			}
		}
	}

	private void FJNCHGLIEMA()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD() && PhotonNetwork.inRoom)
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

	private bool HBFCEAFEMJH()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
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
		NBMPFGDCLEL = new List<byte>(1);
		BLPBCOCAKGG = (DBBNMCLENHH = base.transform.position);
	}

	private void KGNKDPBGJHC()
	{
		if (!LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "Unsupported type: ";
		string text2 = "workshop.";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "CameraFilterPack/Blur_Radial_Fast";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "deleteall";
		}
		GUI.Label(new Rect(1327f, (float)Screen.height - 218f, 1561f, 1592f), "player.licenceaccepted" + LMGCEPHCNBN.group + "0,1,false", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 60
		});
		GUI.Label(new Rect(522f, (float)Screen.height - 1225f, 272f, 608f), "null" + text + "setbool", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 77
		});
		GUI.Label(new Rect(303f, (float)Screen.height - 1982f, 638f, 1994f), "_Params" + text2 + ",0", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 90
		});
	}

	private bool IFLHNIEIGCO()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 7)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private bool CPGDKKIDALK()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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

	private void IDJHCPHEKFP()
	{
		if (!LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "_TimeX";
		string text2 = "_Distortion";
		for (int i = 0; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "_Value4";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "_NoiseTex";
		}
		GUI.Label(new Rect(348f, (float)Screen.height - 1996f, 793f, 364f), "?" + LMGCEPHCNBN.group + ".mp3", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 117
		});
		GUI.Label(new Rect(318f, (float)Screen.height - 1656f, 375f, 249f), "_VelocityTex" + text + "menu.enableselectormusic", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 59
		});
		GUI.Label(new Rect(1990f, (float)Screen.height - 1899f, 1289f, 1806f), "JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?" + text2 + " ", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -32
		});
	}

	private void PDKFMFCMPGE()
	{
		if (!LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "GLITCH";
		string text2 = "CameraFilterPack/Distortion_Flag";
		for (int i = 0; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "restrictions\n\n#until: ";
			}
			text2 = text2 + NBMPFGDCLEL[i] + ". Possible scene loading in progress?";
		}
		GUI.Label(new Rect(408f, (float)Screen.height - 1424f, 952f, 347f), "Circle" + LMGCEPHCNBN.group + "VisionBlur", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -34
		});
		GUI.Label(new Rect(1415f, (float)Screen.height - 880f, 1864f, 1119f), "Y" + text + "_CurveParams", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 64
		});
		GUI.Label(new Rect(715f, (float)Screen.height - 771f, 619f, 1230f), "ENABLE_EYE_ADAPTATION" + text2 + "[DiscordController] Error {0}: {1}", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 124
		});
	}

	private void MBNMADBPDLL()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.BGJKMGJBPFA())
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

	private void OHFOLGANOLC()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void PHACPKPPBJF()
	{
		if (!LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "_Blood";
		string text2 = "_MainTex2";
		for (int i = 1; i < NBMPFGDCLEL.Count; i++)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + " ownership transfered to: ";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "Joystick1Button0";
		}
		GUI.Label(new Rect(450f, (float)Screen.height - 1967f, 412f, 1071f), "Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception" + LMGCEPHCNBN.group + "Join failed on GameServer. Changing back to MasterServer. Msg: ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 68
		});
		GUI.Label(new Rect(213f, (float)Screen.height - 1321f, 903f, 1138f), "z" + text + "LevelEditor/icons", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -62
		});
		GUI.Label(new Rect(509f, (float)Screen.height - 1788f, 350f, 782f), "_TimeX" + text2 + "CameraFilterPack/Color_Contrast", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -47
		});
	}

	public void LIFMLJFPLDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void BMOFEBKGLFI()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void NEKBANHJJJC()
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

	private void IDIIELPAMCJ()
	{
		if (LMGCEPHCNBN.isMine)
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GCFFKNOHJGM())
			{
				CDMHFHPNCDO();
			}
		}
	}

	private bool KJPNKCDLKBO()
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
			return false;
		}
		return false;
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

	private void AEEGKLABFLN()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && FMILHKLNLPH())
			{
				MMGEGAHEGIM();
			}
		}
	}

	private void HDDECCMEJKA()
	{
		if (LMGCEPHCNBN.BGJKMGJBPFA())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && HNEKIANDEOI())
			{
				GHDBOAPJLFJ();
			}
		}
	}

	private void MKIMDFLBFOM()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private void MMOKKAPFGAK()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD() && PhotonNetwork.inRoom)
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

	private void EOPFFHIGFDA()
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

	private void POJFHDFJOPE()
	{
		if (LMGCEPHCNBN.BGJKMGJBPFA())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && KJPNKCDLKBO())
			{
				EOPFFHIGFDA();
			}
		}
	}

	private void JBBCMAJIMCA()
	{
		if (LMGCEPHCNBN == null)
		{
			LMGCEPHCNBN = GetComponent<PhotonView>();
			if (!LMGCEPHCNBN.DOLKFPIABDD())
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

	public void IFDFBONAJEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void OFNIAEEBJCB()
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

	private void OJJEKKHIKAO()
	{
		if (!LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "Changed config";
		string text2 = "<b><i>Map's Stats:</i></b>";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "selector";
			}
			text2 = text2 + NBMPFGDCLEL[i] + " evLeave: ";
		}
		GUI.Label(new Rect(635f, (float)Screen.height - 755f, 1576f, 718f), "UI Extensions/UISoftAdditive" + LMGCEPHCNBN.group + "_ScreenResolution", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 32
		});
		GUI.Label(new Rect(1455f, (float)Screen.height - 1360f, 852f, 342f), "float,1.5" + text + "Adreno", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -61
		});
		GUI.Label(new Rect(1456f, (float)Screen.height - 1782f, 1615f, 859f), "_Fade" + text2 + "[PlayerBase] Loaded custom model: ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 99
		});
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

	private void GHDBOAPJLFJ()
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

	private void MMGEGAHEGIM()
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

	private void JHPOIOELNCG()
	{
		if (LMGCEPHCNBN.DOLKFPIABDD())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && PHOGNHBFNHA())
			{
				NEKBANHJJJC();
			}
		}
	}

	public void JNENAPDBOKE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (NBMPFGDCLEL.Count <= BMLPKAEJLDK.NumberOfSubdivisions)
		{
			NBMPFGDCLEL.Add(BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void JFDIAAOJJEA()
	{
		if (!LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "Cross";
		string text2 = "New SaveGame";
		for (int i = 1; i < NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + NBMPFGDCLEL[i] + "win";
			}
			text2 = text2 + NBMPFGDCLEL[i] + "player.mysteryitem";
		}
		GUI.Label(new Rect(1193f, (float)Screen.height - 1374f, 263f, 1131f), "[Up]" + LMGCEPHCNBN.group + " ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 2
		});
		GUI.Label(new Rect(22f, (float)Screen.height - 1487f, 218f, 956f), "_Value9" + text + "ticket", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -59
		});
		GUI.Label(new Rect(53f, (float)Screen.height - 1083f, 161f, 1470f), "BitsData" + text2 + "UseFinalGlassColor", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 100
		});
	}

	private void OIMFIKGNNEB()
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

	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 7)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void EHJJFJCKGAJ()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP())
		{
			DBBNMCLENHH = BLPBCOCAKGG;
			BLPBCOCAKGG = base.transform.position;
			if (BLPBCOCAKGG != DBBNMCLENHH && GCECOAALNFP())
			{
				OIMFIKGNNEB();
			}
		}
	}

	private bool MIBMPMEMPHH()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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
		return true;
	}

	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			DPGILFLHKIM = ++DPGILFLHKIM % BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[DPGILFLHKIM]];
		}
		else if (BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			DPGILFLHKIM = (DPGILFLHKIM += 0) % BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			LMGCEPHCNBN.group = NBMPFGDCLEL[BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[DPGILFLHKIM]];
		}
	}

	private void FLKEJJEGCFA()
	{
		if (LMGCEPHCNBN.KCAOJFPDEIP() && PhotonNetwork.inRoom)
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

	private bool HNEKIANDEOI()
	{
		if (BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		NHLHOKCKIEF = new List<byte>(NBMPFGDCLEL);
		NBMPFGDCLEL = BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
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
}
