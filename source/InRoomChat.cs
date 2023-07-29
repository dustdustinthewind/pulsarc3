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

	public void HNCMBMAOJIP(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("CameraFilterPack/Glitch_Mozaic" + MKLKGCPAPOC.sender.ONIKFABKELO()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "CameraFilterPack/Vision_Blood_Fast" + PDDLDFCMAOO);
	}

	public void KIKJALBEDEH(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("x" + MKLKGCPAPOC.sender.ONIKFABKELO()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "From {0} at Index {1} \n" + PDDLDFCMAOO);
	}

	public void AECAAGNAKDP(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void LGHNKDFEOKO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyUp && (Event.current.keyCode == KeyCode.Alpha3 || Event.current.keyCode == (KeyCode)(-1)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				GMAHNPNHMFK().MIAHMDGOOPJ(" not found", PhotonTargets.Others, new object[1] { LHMPNAANKMC });
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Room: '{0}' {1},{2} {4}/{3} players.");
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
		GUI.SetNextControlName("IconFileSelector");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("A", array))
		{
			EDIJKHEMPAD().RPC("Set Particles Count Per Beat", PhotonTargets.Others, LHMPNAANKMC);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void GBIJOHMGMDO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? (".sav" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_Value4" + PDDLDFCMAOO);
	}

	public void MLDKPIPEIHC(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void PCBMEONHFMJ(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void AHNBAOIENOO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == (KeyCode)18 || Event.current.keyCode == KeyCode.Z))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = JAEJDHHCJJO();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.PBMFBOOALKA("_Value3", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl(" evLeave: ");
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
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("/?player=");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("System.String", array2))
		{
			PhotonView obj2 = CIACEFBNDDJ();
			object[] array3 = new object[0];
			array3[0] = LHMPNAANKMC;
			obj2.RPC("value", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void BIEMJFPEDGA(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = ".lastCheckpoint.longestComboScore";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("[MapsSystem] Unloading maps resources..." + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + " cannot be used as a 3D LUT." + PDDLDFCMAOO);
	}

	public void CNGAJDBOCLJ()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void AHAJMCFCIOO(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
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

	public void FBMPOJDOBHF(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("menu.enableselectormusic" + MKLKGCPAPOC.sender.ONIKFABKELO()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "EventData0DropDownList" + PDDLDFCMAOO);
	}

	public void OKKKCIAIABC()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)75 || Event.current.keyCode == (KeyCode)(-128)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GMAHNPNHMFK();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.GNFNHDCJOFC("maps.", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
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
		GUI.SetNextControlName("_BlurPass");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		if (GUILayout.Button("[MapsStats] Map ID: ", GUILayout.ExpandWidth(true)))
		{
			PhotonView obj2 = GMAHNPNHMFK();
			object[] array2 = new object[0];
			array2[1] = LHMPNAANKMC;
			obj2.PBMFBOOALKA("note.1", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void NPLCENPNJBM()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void CPJBNBJMJFA()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == KeyCode.X || Event.current.keyCode == KeyCode.Y))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = ACPGHFHDCIP();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.KEKKFNNMLMG("Tab1Content", PhotonTargets.Others, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("There is already a virtual axis named ");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 0; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("Instrumental");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("_Value4", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj2 = base.photonView;
			object[] array2 = new object[0];
			array2[0] = LHMPNAANKMC;
			obj2.RPC("Start", PhotonTargets.All, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void NAENMLJCHFM(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "_Value2";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("CameraFilterPack/FX_Psycho" + MKLKGCPAPOC.sender.ID) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "[GameScene] Checkpoints count: " + PDDLDFCMAOO);
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

	public void CPFLKDAGLAD(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "mapselector.filter.favoriteonly";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("SpawnObj" + MKLKGCPAPOC.sender.ONIKFABKELO()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_TimeX" + PDDLDFCMAOO);
	}

	public void PDKFMFCMPGE()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-50) || Event.current.keyCode == KeyCode.Percent))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GMAHNPNHMFK();
				object[] array = new object[1];
				array[1] = LHMPNAANKMC;
				obj.RPC("_ScreenResolution", PhotonTargets.Others, array);
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
		GUI.SetNextControlName("#ok");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		if (GUILayout.Button("steamid", GUILayout.ExpandWidth(false)))
		{
			PhotonView obj2 = BLMHOKPIMOD();
			object[] array2 = new object[1];
			array2[1] = LHMPNAANKMC;
			obj2.IKIJDNPJKPM("FToA", PhotonTargets.Others, array2);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void KDMANOEMOCA()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void CAEGIHPNLOG()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.D || Event.current.keyCode == (KeyCode)(-120)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GMAHNPNHMFK();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.RPC("WARNING: rotation axis set to 0 on ", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("menu.playedsolo");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num--)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_PosX");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("DPADHOR", array2))
		{
			PhotonView obj2 = AAMNKPHHHCI();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.GNFNHDCJOFC("_TimeX", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void Start()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void AddLine(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void LEJBDGFNLLG(string PDDLDFCMAOO)
	{
		messages.Add(PDDLDFCMAOO);
	}

	public void APCENGAAHMC()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-150) || Event.current.keyCode == (KeyCode)(-5)))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = BLMHOKPIMOD();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.GNFNHDCJOFC(" does not exist!", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("settings.volume.sfx");
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
		GUI.SetNextControlName("value");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("Tab2Content", array2))
		{
			PhotonView obj2 = CIACEFBNDDJ();
			object[] array3 = new object[1];
			array3[1] = LHMPNAANKMC;
			obj2.IKIJDNPJKPM("SetPlayerDistance", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void FMJCMIHHPNG(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string text = "colorC";
		if (MKLKGCPAPOC.sender != null)
		{
			text = (string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName) ? ("BitsData" + MKLKGCPAPOC.sender.ONIKFABKELO()) : MKLKGCPAPOC.sender.NickName);
		}
		messages.Add(text + "_TimeX" + PDDLDFCMAOO);
	}

	public void BCODHAOJLJL()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.ScrollWheel && (Event.current.keyCode == (KeyCode)67 || Event.current.keyCode == (KeyCode)4))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = CIACEFBNDDJ();
				object[] array = new object[0];
				array[0] = LHMPNAANKMC;
				obj.GNFNHDCJOFC("_Value3", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Left");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(GuiRect);
		BMHLPJCOMAA = GUILayout.BeginScrollView(BMHLPJCOMAA);
		GUILayout.FlexibleSpace();
		for (int num = messages.Count - 1; num >= 1; num -= 0)
		{
			GUILayout.Label(messages[num], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal();
		GUI.SetNextControlName("selColor");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC, new GUILayoutOption[1]);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button("Tab2Content", array2))
		{
			PhotonView obj2 = GMAHNPNHMFK();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.GNFNHDCJOFC("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", PhotonTargets.Others, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public void NNCCPEBIAKH()
	{
		if (AlignBottom)
		{
			GuiRect.y = (float)Screen.height - GuiRect.height;
		}
	}

	public void IDDPLCAHDPO()
	{
		if (!IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseMove && (Event.current.keyCode == (KeyCode)(-60) || Event.current.keyCode == (KeyCode)7))
		{
			if (!string.IsNullOrEmpty(LHMPNAANKMC))
			{
				PhotonView obj = GBHNDHLAJLI();
				object[] array = new object[0];
				array[1] = LHMPNAANKMC;
				obj.GNFNHDCJOFC("NEW", PhotonTargets.All, array);
				LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Value2");
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
		GUI.SetNextControlName("shader.future");
		LHMPNAANKMC = GUILayout.TextField(LHMPNAANKMC);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(".played", array2))
		{
			PhotonView obj2 = EOOCGIFFKBG();
			object[] array3 = new object[0];
			array3[1] = LHMPNAANKMC;
			obj2.PBMFBOOALKA("runas", PhotonTargets.All, array3);
			LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
