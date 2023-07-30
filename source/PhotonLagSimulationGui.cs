// PhotonLagSimulationGui
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class PhotonLagSimulationGui : MonoBehaviour
{
	public Rect WindowRect = new Rect(0f, 100f, 120f, 100f);

	public int WindowId = 101;

	public bool Visible = true;

	public PhotonPeer Peer { get; set; }

	[SpecialName]
	public void PJBIHNPIDFN(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer PNJIPPOIOEP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void CKHOOGMFDMD(int ENDMCOMANKJ)
	{
		GUILayout.Label("No peer to communicate with. ");
	}

	private void AGGCMMPPBHD(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_Green_R", KILIAAMJGIK().RoundTripTime, Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = OOIKIABCOOP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Scrollbar", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			FHJPPPFLJOH().IsSimulationEnabled = flag;
		}
		float num = NNLCACDMKPD().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("[RanksSystem] Ranks: no need to update" + num);
		num = GUILayout.HorizontalSlider(num, 1382f, 1944f);
		CKFALOKOKNP().NetworkSimulationSettings.IncomingLag = (int)num;
		FHJPPPFLJOH().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = PNJIPPOIOEP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("BitsData" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1262f, 467f, new GUILayoutOption[1]);
		KILIAAMJGIK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		PBHPEEAJOGD().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = EOHBNJOCGKE().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 400f, 1674f);
		KILIAAMJGIK().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		Peer.NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1366f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer APEFIBHNINL()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public PhotonPeer EOHBNJOCGKE()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void LGHNKDFEOKO()
	{
		if (Visible)
		{
			if (CKFALOKOKNP() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JIGBGEEAONA, "float,1.5", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, MJEECCOMDDI, "_BlurPass", new GUILayoutOption[1]);
			}
		}
	}

	private void GKIHJINMGOD(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("#tryagain", EOHBNJOCGKE().RoundTripTime, KILIAAMJGIK().RoundTripTimeVariance));
		bool isSimulationEnabled = PNJIPPOIOEP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_ScreenResolution");
		if (flag != isSimulationEnabled)
		{
			CKFALOKOKNP().IsSimulationEnabled = flag;
		}
		float num = PBHPEEAJOGD().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_DepthLevel" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1907f, 1724f, new GUILayoutOption[1]);
		EOHBNJOCGKE().NetworkSimulationSettings.IncomingLag = (int)num;
		APEFIBHNINL().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = APEFIBHNINL().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_Value3" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1664f, 147f);
		APEFIBHNINL().NetworkSimulationSettings.IncomingJitter = (int)num2;
		FHJPPPFLJOH().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = CKFALOKOKNP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("FullscreenToggle" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 302f, 945f);
		PNJIPPOIOEP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		Peer.NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1400f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer NNLCACDMKPD()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void HOJAJOEFNKJ(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer KILIAAMJGIK()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void JIGBGEEAONA(int ENDMCOMANKJ)
	{
		GUILayout.Label("Environment/SunBase_");
	}

	public void Start()
	{
		Peer = PhotonNetwork.JNJJAMNLOHA;
	}

	[SpecialName]
	public PhotonPeer OOIKIABCOOP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void NMADACEBBEM(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("CameraFilterPack/Pixelisation_Sweater", NNLCACDMKPD().RoundTripTime, CKFALOKOKNP().RoundTripTimeVariance));
		bool isSimulationEnabled = CKFALOKOKNP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Params3");
		if (flag != isSimulationEnabled)
		{
			APEFIBHNINL().IsSimulationEnabled = flag;
		}
		float num = PBHPEEAJOGD().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("LivesSlider" + num);
		num = GUILayout.HorizontalSlider(num, 387f, 1501f, new GUILayoutOption[1]);
		APEFIBHNINL().NetworkSimulationSettings.IncomingLag = (int)num;
		NNLCACDMKPD().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = PBHPEEAJOGD().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("PerfectHitsScoreText" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1015f, 1656f);
		FHJPPPFLJOH().NetworkSimulationSettings.IncomingJitter = (int)num2;
		Peer.NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = EOHBNJOCGKE().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Saturation" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1935f, 997f);
		Peer.NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 695f;
		}
		GUI.DragWindow();
	}

	public void ADLAFICKCFG()
	{
		if (Visible)
		{
			if (Peer == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JIGBGEEAONA, "BadgeText", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, NMADACEBBEM, "health", new GUILayoutOption[1]);
			}
		}
	}

	private void LPNLGGLNFFI(int ENDMCOMANKJ)
	{
		GUILayout.Label("Rtt:{0,4} +/-{1,3}");
	}

	[SpecialName]
	public PhotonPeer CKFALOKOKNP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void CCLNNLCOPBL()
	{
		LCCMMNCBLMJ(PhotonNetwork.JNJJAMNLOHA);
	}

	private void CPFHJLFNHIE(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Edited unlock conditions", NNLCACDMKPD().RoundTripTime, EOHBNJOCGKE().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = NNLCACDMKPD().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Offline", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			CKFALOKOKNP().IsSimulationEnabled = flag;
		}
		float num = Peer.NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Registered PhotonView: " + num);
		num = GUILayout.HorizontalSlider(num, 882f, 1199f, new GUILayoutOption[1]);
		CKFALOKOKNP().NetworkSimulationSettings.IncomingLag = (int)num;
		FHJPPPFLJOH().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = NNLCACDMKPD().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("GroupNameText" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 779f, 1704f);
		PBHPEEAJOGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		OOIKIABCOOP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = FHJPPPFLJOH().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("#failed!" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1570f, 593f);
		EOHBNJOCGKE().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		OOIKIABCOOP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 98f;
		}
		GUI.DragWindow();
	}

	public void BGDPIHMAACO()
	{
		HOJAJOEFNKJ(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void OPHEBLOLAGF(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void GPNAOAKCMHC()
	{
		MPHKBLFLGID(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void OOCHGPBLNKM(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void DLBODOFAJGM()
	{
		LCCMMNCBLMJ(PhotonNetwork.JNJJAMNLOHA);
	}

	public void NGGLCOLOLHF()
	{
		if (Visible)
		{
			if (CKFALOKOKNP() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JIGBGEEAONA, "Object ID");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PONJJDMBJHI, "Arc");
			}
		}
	}

	private void PFPLDCNPGCH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_TimeX", CKFALOKOKNP().RoundTripTime, PBHPEEAJOGD().RoundTripTimeVariance));
		bool isSimulationEnabled = CKFALOKOKNP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Editor", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			APEFIBHNINL().IsSimulationEnabled = flag;
		}
		float num = EOHBNJOCGKE().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("CameraFilterPack/Oculus_NightVision3" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1865f, 740f);
		EOHBNJOCGKE().NetworkSimulationSettings.IncomingLag = (int)num;
		CKFALOKOKNP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = KILIAAMJGIK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_ScreenResolution" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1089f, 1088f, new GUILayoutOption[1]);
		CKFALOKOKNP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		OOIKIABCOOP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = APEFIBHNINL().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 137f, 443f, new GUILayoutOption[1]);
		NNLCACDMKPD().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		OOIKIABCOOP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 693f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer FHJPPPFLJOH()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void OnGUI()
	{
		if (Visible)
		{
			if (Peer == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, CKHOOGMFDMD, "Netw. Sim.");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PONJJDMBJHI, "Netw. Sim.");
			}
		}
	}

	private void HEDNBCLBFIK(int ENDMCOMANKJ)
	{
		GUILayout.Label("SupportLogger OnJoinedLobby(");
	}

	[SpecialName]
	public void LCCMMNCBLMJ(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void PHHILLBKLFF(int ENDMCOMANKJ)
	{
		GUILayout.Label("InventoryButton");
	}

	public void EOJGCJABGNC()
	{
		if (Visible)
		{
			if (FHJPPPFLJOH() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PHHILLBKLFF, ". Going to authenticate anyways.");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PFPLDCNPGCH, "_Value7");
			}
		}
	}

	private void CMDDBENDKCM(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Distortion", new GUILayoutOption[1]);
	}

	[SpecialName]
	public void MPHKBLFLGID(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer PBHPEEAJOGD()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void MKIMDFLBFOM()
	{
		PJBIHNPIDFN(PhotonNetwork.JNJJAMNLOHA);
	}

	public void FEHCNJLLJMP()
	{
		OOCHGPBLNKM(PhotonNetwork.JNJJAMNLOHA);
	}

	private void PONJJDMBJHI(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Rtt:{0,4} +/-{1,3}", Peer.RoundTripTime, Peer.RoundTripTimeVariance));
		bool isSimulationEnabled = Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Simulate");
		if (flag != isSimulationEnabled)
		{
			Peer.IsSimulationEnabled = flag;
		}
		float num = Peer.NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Lag " + num);
		num = GUILayout.HorizontalSlider(num, 0f, 500f);
		Peer.NetworkSimulationSettings.IncomingLag = (int)num;
		Peer.NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = Peer.NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Jit " + num2);
		num2 = GUILayout.HorizontalSlider(num2, 0f, 100f);
		Peer.NetworkSimulationSettings.IncomingJitter = (int)num2;
		Peer.NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = Peer.NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Loss " + num3);
		num3 = GUILayout.HorizontalSlider(num3, 0f, 10f);
		Peer.NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		Peer.NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 100f;
		}
		GUI.DragWindow();
	}

	public void HLIAEEMGBHN()
	{
		MPHKBLFLGID(PhotonNetwork.JNJJAMNLOHA);
	}

	private void MGHCJJLGNDP(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("time", PBHPEEAJOGD().RoundTripTime, EOHBNJOCGKE().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = EOHBNJOCGKE().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Angle", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			PBHPEEAJOGD().IsSimulationEnabled = flag;
		}
		float num = OOIKIABCOOP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Mouse2" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 886f, 963f);
		EOHBNJOCGKE().NetworkSimulationSettings.IncomingLag = (int)num;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = PNJIPPOIOEP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_NoOuterClip" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1584f, 1224f, new GUILayoutOption[1]);
		FHJPPPFLJOH().NetworkSimulationSettings.IncomingJitter = (int)num2;
		APEFIBHNINL().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = FHJPPPFLJOH().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Ignored PU RPC, cause item is inactive. " + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 225f, 761f, new GUILayoutOption[1]);
		Peer.NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		APEFIBHNINL().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1651f;
		}
		GUI.DragWindow();
	}

	private void FGGIAEGNIPC(int ENDMCOMANKJ)
	{
		GUILayout.Label("ShowTitle");
	}

	[SpecialName]
	public void HNHJJCBMCPH(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void MOEACHAPNOL(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void MJEECCOMDDI(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("buttons", PNJIPPOIOEP().RoundTripTime, FHJPPPFLJOH().RoundTripTimeVariance));
		bool isSimulationEnabled = PBHPEEAJOGD().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_MainTex2", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			NNLCACDMKPD().IsSimulationEnabled = flag;
		}
		float num = PBHPEEAJOGD().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("settings.arcshitsoundtimedelay" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1502f, 1652f, new GUILayoutOption[1]);
		OOIKIABCOOP().NetworkSimulationSettings.IncomingLag = (int)num;
		EOHBNJOCGKE().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = OOIKIABCOOP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("getstring" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 891f, 1913f);
		OOIKIABCOOP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		FHJPPPFLJOH().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = EOHBNJOCGKE().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 863f, 336f, new GUILayoutOption[1]);
		APEFIBHNINL().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		CKFALOKOKNP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1690f;
		}
		GUI.DragWindow();
	}
}
