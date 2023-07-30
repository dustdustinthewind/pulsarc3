// InRoomChat
using System.Collections.Generic;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class InRoomChat : Photon.MonoBehaviour
{
	public Rect GuiRect = new Rect(0f, 0f, 250f, 300f);

	public bool IsVisible = true;

	public bool AlignBottom;

	public List<string> messages = new List<string>();

	private string LHMPNAANKMC = string.Empty;

	private Vector2 BMHLPJCOMAA = Vector2.zero;

	public static readonly string ChatRPC = "Chat";

	public void OLFFIKHJIEO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)(-179) || Event.current.keyCode == KeyCode.E))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GBMJAPGLMGB();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("Tab2Content", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl(": ");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("_Value");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("_OcclusionTexture", array2))
		{
			EDIJKHEMPAD().RPC("id", PhotonTargets.Others, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void KNBJBNDGCIJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void OJBANLJIBLK(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void GKFJKOGGFDI(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void LFBCALDODCP(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void EPPBNCOEKPH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void JLBAIGOEPPN(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void IKDNLHLBHID()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void NPLCENPNJBM()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void IKLFOOPFHIF(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void ANCKKLFPGDI()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void NNHACMKKBFE(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void FPLPEFHKHFM(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void OLBKLJLAKFF(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_Value1";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("Failed to InstantiateSceneObject prefab: " + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + ";" + PDDLDFCMAOO);
	}

	public void CDALCLNKDJA(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void PDHKMDBNGGN()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void GBIJOHMGMDO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "[Up]";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("MapConfig" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.OLPCOKMLDFD());
		}
		messages.Add(text + "PointsScoreText" + PDDLDFCMAOO);
	}

	public void OnGUI()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.KeypadEnter || Event.current.keyCode == KeyCode.Return))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				base.photonView.RPC("Chat", PhotonTargets.All, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("ChatInput");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("ChatInput");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("Send", GUILayout.ExpandWidth(false)))
		{
			base.photonView.RPC("Chat", PhotonTargets.All, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void LFMBOPJEBJO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "PunSupportLogger";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("shader.ghost" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.OLPCOKMLDFD());
		}
		messages.Add(text + "settings.volume.menu" + PDDLDFCMAOO);
	}

	public void IMCKJCHKMKB()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void GLEJGFLCLPJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void PFBCFLKPJHB(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void MMPHNFPPEHO()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void JODODFGLOLD()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == (KeyCode)164 || Event.current.keyCode == (KeyCode)(-41)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BBGIDKNEGHD();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("CameraFilterPack_Glasses_On4", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_TimeX");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_Value");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("_ScreenResolution", array2))
		{
			PhotonView obj2 = IFENGKHOKPC();
			object[] array3 = new object[0];
			array3[0] = LHMPNAANKMC;
			obj2.RPC("_ScreenResolution", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void DDOMIEPBBBI()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDown && (Event.current.keyCode == (KeyCode)(-127) || Event.current.keyCode == (KeyCode)(-96)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = OELHGNKAMEG();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("\t", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("workshop.");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_Offsets");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("isBunned", array2))
		{
			PhotonView obj2 = GBHNDHLAJLI();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("bpmgrid", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void FCMBKMAFPEF(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void MPMBBLGGHAL(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_InternalLutTex";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("F3" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + " : " + PDDLDFCMAOO);
	}

	public void FMJCMIHHPNG(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "1177138211";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? (". Using max value: 255." + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.OLPCOKMLDFD());
		}
		messages.Add(text + "Scene" + PDDLDFCMAOO);
	}

	public void ENLNHCGMCAN(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_Vignetting2";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("FrostCanvas" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_Value2" + PDDLDFCMAOO);
	}

	public void JJBJPIDBCDH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void KNFOLOODJEE(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "bloomintencity:";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("[LevelEditorScene] Error: I/O Failure! :(" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "Brightness" + PDDLDFCMAOO);
	}

	public void CGNJFCHOFNN(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void EFDHOOAPHAP(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "[PlayerBase] ShowTitle error: ";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("_TimeX" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "Can't find key " + PDDLDFCMAOO);
	}

	public void NHMPDIECMCJ(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "Delete events";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("BadgeImage" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "-" + PDDLDFCMAOO);
	}

	public void PLLCMFMGEIH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void ODBNMPGBCGO()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void KDMKDEKCELE()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void LAMLOEMNCMO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "2;13;14;15;16";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("Switch environment sprite image" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "Load Game" + PDDLDFCMAOO);
	}

	public void MNBPNHNAEBK()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void KIKJALBEDEH(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "SpawnObj";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("traffic" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "play" + PDDLDFCMAOO);
	}

	public void AHNBAOIENOO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDrag && (Event.current.keyCode == (KeyCode)172 || Event.current.keyCode == (KeyCode)31))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BBGIDKNEGHD();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("[ResourcesManager] Load text error: not found", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_ScreenResolution");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("#close");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("_ScreenResolution", array2))
		{
			PhotonView obj2 = JIOCGDBKGIL();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("_TimeX", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void BIMFAICCOHL(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void GOKOBIOBEKP(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void DPGOHCCPHJG(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void AddLine(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void HPJKBODBEOL(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void DPMIABFMGCO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDown && (Event.current.keyCode == (KeyCode)(-147) || Event.current.keyCode == (KeyCode)(-67)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = DJHCJIJAIJP();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("HIDE CONFIG [Ctrl+E]", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_History4Weight");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName(" ownership transfered to: ");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("#close", array2))
		{
			PhotonView obj2 = FFIPLLNKGEN();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("DPADHOR", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void INMBOEPBLPO(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void IEHKJPADFFM()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.Quote || Event.current.keyCode == (KeyCode)1))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = OELHGNKAMEG();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("_ScreenResolution", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Bullet_7");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("float,1.5");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("settings.enablerankingnotifications", array2))
		{
			PhotonView obj2 = JIOCGDBKGIL();
			object[] array3 = new object[0];
			array3[0] = LHMPNAANKMC;
			obj2.RPC("PointsScoreText", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void BCJDNJPJCKB()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDown && (Event.current.keyCode == KeyCode.Minus || Event.current.keyCode == (KeyCode)89))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BLMHOKPIMOD();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("mapselector.filter.favoriteonly", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("VisionBlur");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("#ok");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("LevelURLInputField", array2))
		{
			IJBFILBDGDO().RPC("settings.customdataskin", PhotonTargets.Others, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void IFPAKPMPCCM(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void CGDMLHLJIDK()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void JGNDGCHOGLI(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_Value";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("_ScreenResolution" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.OLPCOKMLDFD());
		}
		messages.Add(text + "_Offsets" + PDDLDFCMAOO);
	}

	public void JABMMIMOJMJ()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-130) || Event.current.keyCode == KeyCode.Minus))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PHCBHAFMDEJ().RPC("0,1,false", PhotonTargets.All, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("OxOD.lastPath");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName(" ");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("maps.", array))
		{
			PhotonView obj = JIOCGDBKGIL();
			object[] array2 = new object[0];
			array2[0] = LHMPNAANKMC;
			obj.RPC("[Left]", PhotonTargets.All, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void IKLNBNNBNHE(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "CameraFilterPack/3D_Myst";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("CameraFilterPack/FX_Hypno" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "_Value4" + PDDLDFCMAOO);
	}

	public void CJPMHBAOKJM(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "ItemNameBGImage";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? (" should be overwritten." + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "_Value4" + PDDLDFCMAOO);
	}

	public void EPEGAEGDJAM()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void ONFFNCHGHPH(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "[LevelEditorScene] Error: Timeout :S";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("_CameraClipInfo" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "musicVolume" + PDDLDFCMAOO);
	}

	public void ALOPNDLLJFA()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Layout && (Event.current.keyCode == (KeyCode)139 || Event.current.keyCode == (KeyCode)66))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				OELHGNKAMEG().RPC("settings_bindings_controller_type", PhotonTargets.All, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("SpawnObj");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("action");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		if (GUILayout.Button(", ", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj = GMAHNPNHMFK();
			object[] array = new object[0];
			array[0] = LHMPNAANKMC;
			obj.RPC("_TimeX", PhotonTargets.Others, array);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void BCBLKMJLCFG(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void GJGHKAFNAIG(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void GNPNBKEOPAP(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "not available at the moment";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("DPADVER" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "https://www.youtube.com/watch?v=cDVXukrKo74" + PDDLDFCMAOO);
	}

	public void NGGLCOLOLHF()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-125) || Event.current.keyCode == (KeyCode)(-83)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = EDIJKHEMPAD();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("OnPickedUp", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("maps.");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("settings.volume.game");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("GameScene", array2))
		{
			PhotonView obj2 = BLMHOKPIMOD();
			object[] array3 = new object[1];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("CameraFilterPack_Paper4", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void OHDNHKIEIFC(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "musicVolume";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("PhotonMono" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + ".png" + PDDLDFCMAOO);
	}

	public void DICFNLLKGIO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = " Path: ";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("_Line" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "In Main Menu" + PDDLDFCMAOO);
	}

	public void GKHMLLHGKEJ(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void EDEJLJBJBHA(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void GPPPHBIFKMO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == (KeyCode)131 || Event.current.keyCode == (KeyCode)(-45)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = JIOCGDBKGIL();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("_Value3", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_History2ChromaTex");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("[PlayerController] ");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("] ", array2))
		{
			ACPGHFHDCIP().RPC("SpawnObj", PhotonTargets.Others, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void HFAFJFBDMCC(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void CLMDCHHLJOM(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void BPBJEPNMANO(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void FMFNILJIEIA()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void GIMFEMMLANB()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.ScrollWheel && (Event.current.keyCode == (KeyCode)(-48) || Event.current.keyCode == KeyCode.LeftBracket))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GBHNDHLAJLI();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("[LevelEditorScene] Print Audio Wave: Done", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_ScreenResolution");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("_Green_R");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("_Distortion", GUILayout.ExpandWidth(true)))
		{
			EDIJKHEMPAD().RPC("Text", PhotonTargets.Others, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void COHIJHCNNFP()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)156 || Event.current.keyCode == (KeyCode)(-108)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = base.photonView;
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("player.mysteryitem", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Joystick1Button1");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("#reward: ");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(".lastCheckpoint.penaltyScore", array2))
		{
			PhotonView obj2 = BBGIDKNEGHD();
			object[] array3 = new object[0];
			array3[0] = LHMPNAANKMC;
			obj2.RPC("_NoiseTilingPerChannel", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void MJEFMIPLFAB()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void EFNIKEMPDIF()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyUp && (Event.current.keyCode == (KeyCode)79 || Event.current.keyCode == (KeyCode)(-105)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = OELHGNKAMEG();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("settings.enablehitsoundsinrelax", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("CameraFilterPack/Blend2Camera_Difference");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("SetSatelliteInput");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		if (GUILayout.Button("_BlurPass", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj2 = BLMHOKPIMOD();
			object[] array2 = new object[1];
			array2[1] = LHMPNAANKMC;
			obj2.RPC("menu.selectedplaymode", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void PADFKBHPEIH(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = ".completed";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? (" not exist" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_Extra2" + PDDLDFCMAOO);
	}

	public void DEKBFAFABNG()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDown && (Event.current.keyCode == KeyCode.Quote || Event.current.keyCode == (KeyCode)(-92)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BLMHOKPIMOD();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("_Blue_B", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("workshop.txt");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("fade in duration");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("maps.", array2))
		{
			PhotonView obj2 = IFENGKHOKPC();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("#availablechallenges", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void EAELMLKKFOL()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseMove && (Event.current.keyCode == (KeyCode)162 || Event.current.keyCode == (KeyCode)20))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = EOOCGIFFKBG();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("FrostCanvas", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Value2");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_Value4");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("SetSunEmission", array2))
		{
			PhotonView obj2 = EOOCGIFFKBG();
			object[] array3 = new object[0];
			array3[0] = LHMPNAANKMC;
			obj2.RPC("/", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void IADMCJMGIHO(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void HHKCCIJMGAB()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDrag && (Event.current.keyCode == (KeyCode)(-139) || Event.current.keyCode == KeyCode.Alpha1))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = CIACEFBNDDJ();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("_BlurCoe", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Fade");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("3");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("_Value2", array2))
		{
			PhotonView obj2 = NABDKNPNEMM();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void NGGBLPJHKPH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	[PunRPC]
	public void Chat(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "anonymous";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("player " + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + ": " + PDDLDFCMAOO);
	}

	public void AEMGPJDJGBJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void DPDEIFDEAKJ(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void Start()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void HLIAEEMGBHN()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void JFJLGJEPEAA()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void HHCCMHCELPO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseDown && (Event.current.keyCode == (KeyCode)73 || Event.current.keyCode == (KeyCode)(-91)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GBMJAPGLMGB();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("_Value3", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Value3");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("Reload Steam Inventory");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("0,7,true,0", array2))
		{
			PhotonView obj2 = DJHCJIJAIJP();
			object[] array3 = new object[1];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("[ResourcesManager] Load text error: not found", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void MEHOHIGLCCL(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "randomdrop";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("BitsData" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "SAVE" + PDDLDFCMAOO);
	}

	public void MFLHFIPMDCL(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "Joystick1Button12";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("Texture2" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "_Value4" + PDDLDFCMAOO);
	}

	public void CCLNNLCOPBL()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void DBEMDAJDDDA()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void BIEMJFPEDGA(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "SetParticlesEmission";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("[PlayerBase] Unknown event: " + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.OLPCOKMLDFD());
		}
		messages.Add(text + "Tab2Content" + PDDLDFCMAOO);
	}

	public void FDNONDCGGCG()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void DBLILJGKGHJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void MJOPBHMIBNH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void MCCMOFLCKBH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void MHKBAPHANKN(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void EIMNPCMHJLJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void BPGNAAIDMNN(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void KNFCHALMBDH(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void FFJMMBGFDMD()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)170 || Event.current.keyCode == KeyCode.Alpha2))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = IJBFILBDGDO();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("red", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("stretchWidth");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("KickThePlayer");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("inventory.selected.", array2))
		{
			ACPGHFHDCIP().RPC("DISTORT", PhotonTargets.All, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void GPNAOAKCMHC()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void KIMMMCJFMAB()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void AIOFJEMFOFL(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "/music";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.DBMPNLFFBEB()) ? ("_VignetteSettings" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "MultiplayerButton" + PDDLDFCMAOO);
	}

	public void EGBNNBLCKNE()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-86) || Event.current.keyCode == (KeyCode)85))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GBMJAPGLMGB();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("id", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_ScreenResolution");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("_ScreenResolution");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("CameraFilterPack_Glasses_On5", array2))
		{
			PhotonView obj2 = BLMHOKPIMOD();
			object[] array3 = new object[1];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("note.4", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void HHGNLEBNIEI(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "Done!";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("_Bullet_3" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "CameraFilterPack/Oculus_ThermaVision" + PDDLDFCMAOO);
	}

	public void FCADKGNNELN()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.ScrollWheel && (Event.current.keyCode == KeyCode.Dollar || Event.current.keyCode == KeyCode.Delete))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = EOOCGIFFKBG();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("_Value2", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_ScreenResolution");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("CameraFilterPack/TV_Horror");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("D-Pad Up", GUILayout.ExpandWidth(true)))
		{
			PhotonView obj2 = ACPGHFHDCIP();
			object[] array2 = new object[0];
			array2[1] = LHMPNAANKMC;
			obj2.RPC("_ScreenResolution", PhotonTargets.All, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void APCENGAAHMC()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseMove && (Event.current.keyCode == (KeyCode)166 || Event.current.keyCode == (KeyCode)(-93)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				FFIPLLNKGEN().RPC("DifficultyBG", PhotonTargets.Others, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_EmissionColor");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("USE_CORNER_DETECTION");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("[LocalizationService] Error: ", array))
		{
			PhotonView obj = IFENGKHOKPC();
			object[] array2 = new object[0];
			array2[0] = LHMPNAANKMC;
			obj.RPC("SetParticlesParticleSpeed", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void DPLLKHHLDBB()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void EFJDNLGNACH()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void AEOLJEIDMDB()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void COIJKMKIEAK()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void JJCPPGGJKNC(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void EEKAADHJGGL()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Layout && (Event.current.keyCode == (KeyCode)78 || Event.current.keyCode == KeyCode.S))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PHCBHAFMDEJ().RPC("[MapEditor] Importing map: ", PhotonTargets.Others, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Fade");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("Fill");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("Set sun min/max size", array))
		{
			PhotonView obj = IFENGKHOKPC();
			object[] array2 = new object[1];
			array2[1] = LHMPNAANKMC;
			obj.RPC("ItemsCountText", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void OJJEKKHIKAO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)(-130) || Event.current.keyCode == (KeyCode)(-128)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BBGIDKNEGHD();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("Texture2", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Far");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 0; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("Object ID. Case-Sensitive");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("getint", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj2 = AAMNKPHHHCI();
			object[] array2 = new object[0];
			array2[1] = LHMPNAANKMC;
			obj2.RPC("keys", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void GOFKOPEFLFF(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_Bullet_7";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("_Value2" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.DBMPNLFFBEB());
		}
		messages.Add(text + "Year_" + PDDLDFCMAOO);
	}

	public void EFFEJFOOIDM()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseMove && (Event.current.keyCode == KeyCode.F || Event.current.keyCode == (KeyCode)1))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = EDIJKHEMPAD();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.RPC("ResetButton", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl(" not exist");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("shader.invert");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("|", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj2 = GBHNDHLAJLI();
			object[] array2 = new object[0];
			array2[0] = LHMPNAANKMC;
			obj2.RPC("Bad parameters for setbool! Use <key> <value>", PhotonTargets.All, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void FAGGMAKKMAE()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == (KeyCode)(-8) || Event.current.keyCode == (KeyCode)26))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = ACPGHFHDCIP();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC(".", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("ViewMenu");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num--)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("Other");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("_Value", array2))
		{
			PhotonView obj2 = IFENGKHOKPC();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("SetPosition", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void MKIMDFLBFOM()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void MLFACDCDMAL()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.ScrollWheel && (Event.current.keyCode == KeyCode.G || Event.current.keyCode == (KeyCode)16))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				EDIJKHEMPAD().RPC("Failed to Instantiate prefab:", PhotonTargets.All, LHMPNAANKMC);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("RecieveChatMessage");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("Type \"help\" for list of commands");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.ExpandWidth(true);
		if (GUILayout.Button("_ScreenResolution", array))
		{
			PhotonView obj = IBKCMBIGOEJ();
			object[] array2 = new object[1];
			array2[1] = LHMPNAANKMC;
			obj.RPC("SpawnObj", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void DKOPKPBLDHH()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void LGMADMDBKNE()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)198 || Event.current.keyCode == KeyCode.Z))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = AAMNKPHHHCI();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("\t", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_TimeX");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 0; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("_Red_B");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("_Value4", array2))
		{
			PhotonView obj2 = JDBCGCJJIAF();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.RPC("_Bullet_12", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void NANPFJBGBOO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "InfoText";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.OLPCOKMLDFD()) ? ("RT" + MKLKGCPAPOC.sender.FHEAKIMCKJC()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_ColorRGB" + PDDLDFCMAOO);
	}

	public void HJPCJGOEKMF()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}
}
