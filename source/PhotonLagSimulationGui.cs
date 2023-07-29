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

	public void FDNONDCGGCG()
	{
		HBBPFLDICHB(PhotonNetwork.JNJJAMNLOHA);
	}

	public void PDKFMFCMPGE()
	{
		if (Visible)
		{
			if (HDAOIDAMNJO() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, IPNKKHBLGLD, "_Value4", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JACBDFDCLFC, "LevelInfoInputField", new GUILayoutOption[1]);
			}
		}
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

	[SpecialName]
	public PhotonPeer DLNPKPBLFOM()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void GELJPJKIIAF(int ENDMCOMANKJ)
	{
		GUILayout.Label("%", new GUILayoutOption[1]);
	}

	[SpecialName]
	public void KHNALNPPGNC(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void KDEMAJFLMEB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void MPHKBLFLGID(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void IEHKJPADFFM()
	{
		if (Visible)
		{
			if (NMIOPAHIFGH() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, ANAOLAFEDON, "_LowRez", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, IAALADGFAJC, "HightScoreMaxPointsText", new GUILayoutOption[1]);
			}
		}
	}

	[SpecialName]
	public PhotonPeer GENJEBLGKEF()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void EHHABKDKECJ(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void ILGBINPBIBG(int ENDMCOMANKJ)
	{
		GUILayout.Label("Exception while connecting to: ", new GUILayoutOption[1]);
	}

	[SpecialName]
	public void PJCPDOBOLPE(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void EKECEMMEIDL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("ItemNameText", NPBLKIPOKMF().RoundTripTime, Peer.RoundTripTimeVariance));
		bool isSimulationEnabled = HDNDGHCJEGJ().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Intensity", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_TimeX" + num);
		num = GUILayout.HorizontalSlider(num, 1554f, 1183f);
		BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag = (int)num;
		BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = NMIOPAHIFGH().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Data/Skins/" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 985f, 194f);
		IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		MKGMMLABLFD().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = AIMLGHOJNEG().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Operation " + num3);
		num3 = GUILayout.HorizontalSlider(num3, 865f, 1614f);
		BOBONFBENHG().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1813f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer IJCHMGDEGCK()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void IPNKKHBLGLD(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Offsets", new GUILayoutOption[1]);
	}

	private void DIBCOOGCKDC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("offsets", PBNJOGMIBDL().RoundTripTime, NPBLKIPOKMF().RoundTripTimeVariance));
		bool isSimulationEnabled = Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "ConfigVersionSlider", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			GGJGMLLHLKP().IsSimulationEnabled = flag;
		}
		float num = LOJMNGHPOOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_FarCamera" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1287f, 1653f);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		ODMKOICGKGD().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("<b>" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1062f, 138f, new GUILayoutOption[1]);
		LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter = (int)num2;
		PBNJOGMIBDL().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("GlassAberration" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1952f, 1817f, new GUILayoutOption[1]);
		LOJMNGHPOOM().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		NPBLKIPOKMF().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1449f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer PBNJOGMIBDL()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void DMPJMALHHGC(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Value2");
	}

	[SpecialName]
	public void OIPINPCNKIE(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer ALEBHIOJOMO()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void LPLGLCLMFFL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("/", GENJEBLGKEF().RoundTripTime, FABGKNDAMPK().RoundTripTimeVariance));
		bool isSimulationEnabled = DLNPKPBLFOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "OpSettings()");
		if (flag != isSimulationEnabled)
		{
			IJCHMGDEGCK().IsSimulationEnabled = flag;
		}
		float num = ALEBHIOJOMO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("(\\[ */ *b *\\])" + num);
		num = GUILayout.HorizontalSlider(num, 199f, 519f, new GUILayoutOption[1]);
		PBNJOGMIBDL().NetworkSimulationSettings.IncomingLag = (int)num;
		BOBONFBENHG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("," + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1855f, 1703f);
		NNOPMLIPGGI().NetworkSimulationSettings.IncomingJitter = (int)num2;
		ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1500f, 297f);
		IJCHMGDEGCK().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		NNOPMLIPGGI().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 866f;
		}
		GUI.DragWindow();
	}

	public void FFBECHMKMPK()
	{
		if (Visible)
		{
			if (LOJMNGHPOOM() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, ALMHGGJAPKN, "tagElement");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, ICNPOLOPHHL, "Object ID. Case-Sensitive");
			}
		}
	}

	public void GGJKHODKNOC()
	{
		if (Visible)
		{
			if (PBNJOGMIBDL() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, IPNKKHBLGLD, "_Value", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JACBDFDCLFC, "Joystick1Button4");
			}
		}
	}

	private void EHIODMNFFEH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Reset All", OBLGFLGCCFP().RoundTripTime, Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = MDIEKLDMNDJ().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Visualize");
		if (flag != isSimulationEnabled)
		{
			BOBONFBENHG().IsSimulationEnabled = flag;
		}
		float num = BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(".lastCheckpoint.incorrectScore" + num);
		num = GUILayout.HorizontalSlider(num, 620f, 1308f, new GUILayoutOption[1]);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		NMIOPAHIFGH().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("ok" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 589f, 1456f);
		LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter = (int)num2;
		FABGKNDAMPK().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = IJCHMGDEGCK().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label(").png" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 101f, 1216f);
		NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1008f;
		}
		GUI.DragWindow();
	}

	public void GIMFEMMLANB()
	{
		if (Visible)
		{
			if (NPBLKIPOKMF() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, GELJPJKIIAF, "_UV_Transform", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, BFFCJEDADJG, "_MaxBlurRadius", new GUILayoutOption[1]);
			}
		}
	}

	public void JABMMIMOJMJ()
	{
		if (Visible)
		{
			if (HDAOIDAMNJO() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, HMMBOEGODIP, "_ScreenResolution", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, DIBCOOGCKDC, "settings.arcshitsoundtimedelay");
			}
		}
	}

	public void CDLHBDMJAJI()
	{
		if (Visible)
		{
			if (LOJMNGHPOOM() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, CBKCFPBJDEL, "&page=");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, IAALADGFAJC, "_Size", new GUILayoutOption[1]);
			}
		}
	}

	public void BEBNOKFLJPH()
	{
		ELFGOKFMMHC(PhotonNetwork.JNJJAMNLOHA);
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

	private void MPOICLNJGJO(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_Near", DLNPKPBLFOM().RoundTripTime, MKGMMLABLFD().RoundTripTimeVariance));
		bool isSimulationEnabled = LHELEHPOIDN().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "DifficultyBG", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			ALEBHIOJOMO().IsSimulationEnabled = flag;
		}
		float num = BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("#ok" + num);
		num = GUILayout.HorizontalSlider(num, 368f, 1300f);
		PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag = (int)num;
		BOBONFBENHG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("LeaderboardsButton" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1671f, 61f);
		ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		AIMLGHOJNEG().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("float,1.5" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 488f, 38f, new GUILayoutOption[1]);
		HDAOIDAMNJO().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1059f;
		}
		GUI.DragWindow();
	}

	private void PGLDHAIEJGK(int ENDMCOMANKJ)
	{
		GUILayout.Label("EventSystem", new GUILayoutOption[1]);
	}

	public void DPLLKHHLDBB()
	{
		PJCPDOBOLPE(PhotonNetwork.JNJJAMNLOHA);
	}

	private void IAALADGFAJC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_ScreenResolution", PBNJOGMIBDL().RoundTripTime, PNJIPPOIOEP().RoundTripTimeVariance));
		bool isSimulationEnabled = BOBONFBENHG().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Set satellite radius (offset)");
		if (flag != isSimulationEnabled)
		{
			MDIEKLDMNDJ().IsSimulationEnabled = flag;
		}
		float num = GENJEBLGKEF().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("SupportLogger " + num);
		num = GUILayout.HorizontalSlider(num, 1012f, 10f, new GUILayoutOption[1]);
		FABGKNDAMPK().NetworkSimulationSettings.IncomingLag = (int)num;
		AIMLGHOJNEG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = FBOALIJENCM().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Sets the boolean value of the Auto Focus Input Field property." + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1101f, 676f, new GUILayoutOption[1]);
		NNOPMLIPGGI().NetworkSimulationSettings.IncomingJitter = (int)num2;
		MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 723f, 1466f, new GUILayoutOption[1]);
		PBNJOGMIBDL().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 524f;
		}
		GUI.DragWindow();
	}

	private void ICNPOLOPHHL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_Far", BCIJDDBHDLP().RoundTripTime, Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = DLNPKPBLFOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Curve", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			NPBLKIPOKMF().IsSimulationEnabled = flag;
		}
		float num = BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("float,1.5" + num);
		num = GUILayout.HorizontalSlider(num, 1057f, 139f);
		NPBLKIPOKMF().NetworkSimulationSettings.IncomingLag = (int)num;
		OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = PBNJOGMIBDL().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("NO" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1650f, 655f);
		HDNDGHCJEGJ().NetworkSimulationSettings.IncomingJitter = (int)num2;
		ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("CameraFilterPack/AAA_Super_Hexagon" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 538f, 1917f, new GUILayoutOption[1]);
		ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		GGJGMLLHLKP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 583f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public void MOECMBJKKDD(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void HDFOAJAFMDK(int ENDMCOMANKJ)
	{
		GUILayout.Label(".played", new GUILayoutOption[1]);
	}

	[SpecialName]
	public void HBBPFLDICHB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void AGEJKLMJGDO()
	{
		AFMPNJBFLGN(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void AFNCJLOGLBB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void CKHOOGMFDMD(int ENDMCOMANKJ)
	{
		GUILayout.Label("No peer to communicate with. ");
	}

	[SpecialName]
	public void AFMPNJBFLGN(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void JILOMOBDPIA()
	{
		FDOCLMLMBFI(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public PhotonPeer NPBLKIPOKMF()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void MALIOOJFHPG(int ENDMCOMANKJ)
	{
		GUILayout.Label("_EmissionGain");
	}

	public void KGNKDPBGJHC()
	{
		if (Visible)
		{
			if (GENJEBLGKEF() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, DKNKGNEHMMB, "LevelEditor/patterns");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, NNJJDHIOMIA, "shader.future");
			}
		}
	}

	[SpecialName]
	public void MBCHBLHDNBB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer BOBONFBENHG()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void IGPCNCJIEOJ()
	{
		NFCBEFDNDBG(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public PhotonPeer HDAOIDAMNJO()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void LKFMMEBLCMK(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer MKGMMLABLFD()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public PhotonPeer AIMLGHOJNEG()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void OGAIIBPLJBB()
	{
		if (Visible)
		{
			if (MDIEKLDMNDJ() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PGLDHAIEJGK, "[Right]", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, DIBCOOGCKDC, "[MapsData] Bad map: ", new GUILayoutOption[1]);
			}
		}
	}

	public void PCABPJAANFH()
	{
		if (Visible)
		{
			if (OBLGFLGCCFP() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, OBJPCCJPACN, "_Value2");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PONJJDMBJHI, "X", new GUILayoutOption[1]);
			}
		}
	}

	public void DLBODOFAJGM()
	{
		EEGCKCPJPPH(PhotonNetwork.JNJJAMNLOHA);
	}

	public void OGBJNAAAEGI()
	{
		if (Visible)
		{
			if (ODMKOICGKGD() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, IPNKKHBLGLD, "id");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, EHIODMNFFEH, "CameraFilterPack/FX_InverChromiLum");
			}
		}
	}

	[SpecialName]
	public void DAKLEHINMLD(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void CFFCLAHMBAA()
	{
		EGOIGBGDOGB(PhotonNetwork.JNJJAMNLOHA);
	}

	public void KLILJHJNICK()
	{
		AFMPNJBFLGN(PhotonNetwork.JNJJAMNLOHA);
	}

	private void HDEFDLBOLFF(int ENDMCOMANKJ)
	{
		GUILayout.Label("mapselector.filter.favoriteonly", new GUILayoutOption[1]);
	}

	private void PLICDMBDNPI(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_InvViewProj", MDIEKLDMNDJ().RoundTripTime, NMIOPAHIFGH().RoundTripTimeVariance));
		bool isSimulationEnabled = Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value3", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			OBLGFLGCCFP().IsSimulationEnabled = flag;
		}
		float num = BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("mapselector.filter.rateduponly" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 965f, 15f);
		ODMKOICGKGD().NetworkSimulationSettings.IncomingLag = (int)num;
		PBNJOGMIBDL().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Back" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1287f, 1082f);
		IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		Peer.NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = PBNJOGMIBDL().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("SpawnObj" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 837f, 915f, new GUILayoutOption[1]);
		NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 640f;
		}
		GUI.DragWindow();
	}

	private void CNOFJKHEELP(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("UI Extensions/UIMultiply", GGJGMLLHLKP().RoundTripTime, MKGMMLABLFD().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Crosshair1");
		if (flag != isSimulationEnabled)
		{
			GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("LevelInfoInputField" + num);
		num = GUILayout.HorizontalSlider(num, 1253f, 677f);
		HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag = (int)num;
		Peer.NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = AIMLGHOJNEG().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(". Calling ConnectToRegionMaster() is: " + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1570f, 1937f);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter = (int)num2;
		GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = BCIJDDBHDLP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Load scene by name or build id" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1351f, 1584f);
		GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		LHELEHPOIDN().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1495f;
		}
		GUI.DragWindow();
	}

	public void AFOKJPBHIEG()
	{
		if (Visible)
		{
			if (HDNDGHCJEGJ() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, CBKCFPBJDEL, "_NoiseScale", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, MPOICLNJGJO, "true", new GUILayoutOption[1]);
			}
		}
	}

	[SpecialName]
	public PhotonPeer PNJIPPOIOEP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public PhotonPeer ODMKOICGKGD()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void PGKMEFFAFJE(int ENDMCOMANKJ)
	{
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
	}

	[SpecialName]
	public PhotonPeer LOJMNGHPOOM()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public PhotonPeer HDNDGHCJEGJ()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void ALMHGGJAPKN(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Bullet_7");
	}

	public void JDJNNDBHBNP()
	{
		if (Visible)
		{
			if (HDAOIDAMNJO() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, BBOAGLIEBEI, "Joystick1Button10");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, JACBDFDCLFC, "<command>");
			}
		}
	}

	private void OBJPCCJPACN(int ENDMCOMANKJ)
	{
		GUILayout.Label("HIDE CONFIG [Ctrl+E]");
	}

	[SpecialName]
	public PhotonPeer OBLGFLGCCFP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void ECBILENEOOL()
	{
		FDOCLMLMBFI(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void EGOIGBGDOGB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void JACBDFDCLFC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Screen Space Reflections", ALEBHIOJOMO().RoundTripTime, ALEBHIOJOMO().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = OBLGFLGCCFP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "QuickSave");
		if (flag != isSimulationEnabled)
		{
			NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = ALEBHIOJOMO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("HPText" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 569f, 1101f, new GUILayoutOption[1]);
		MKGMMLABLFD().NetworkSimulationSettings.IncomingLag = (int)num;
		IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("x" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1271f, 1705f);
		LHELEHPOIDN().NetworkSimulationSettings.IncomingJitter = (int)num2;
		MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value2" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1674f, 1181f);
		HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		HDAOIDAMNJO().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1585f;
		}
		GUI.DragWindow();
	}

	public void FHGKIOOMMOH()
	{
		AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	private void HMMBOEGODIP(int ENDMCOMANKJ)
	{
		GUILayout.Label("Jump");
	}

	private void BBOAGLIEBEI(int ENDMCOMANKJ)
	{
		GUILayout.Label("finished");
	}

	public void FGGKEOLKCNH()
	{
		if (Visible)
		{
			if (MDIEKLDMNDJ() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, CKHOOGMFDMD, " has ");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, MPOICLNJGJO, "seconds");
			}
		}
	}

	private void BOKMOLOLOAN(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("#submit", NMIOPAHIFGH().RoundTripTime, OBLGFLGCCFP().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = NNOPMLIPGGI().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "CheckpointsScoreText", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = OBLGFLGCCFP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("CameraFilterPack/Light_Rainbow2" + num);
		num = GUILayout.HorizontalSlider(num, 119f, 1685f, new GUILayoutOption[1]);
		HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag = (int)num;
		FBOALIJENCM().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(").png" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 210f, 1475f);
		Peer.NetworkSimulationSettings.IncomingJitter = (int)num2;
		HDAOIDAMNJO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1401f, 1572f, new GUILayoutOption[1]);
		BCIJDDBHDLP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 403f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer BCIJDDBHDLP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void AKEAKKPPNPF(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void BMOFEBKGLFI()
	{
		AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public PhotonPeer NNOPMLIPGGI()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void BLJBEBLDEKB(int ENDMCOMANKJ)
	{
		GUILayout.Label("achievements.21.progress", new GUILayoutOption[1]);
	}

	public void MMPHNFPPEHO()
	{
		EEGCKCPJPPH(PhotonNetwork.JNJJAMNLOHA);
	}

	public void DDFOMFBPFFB()
	{
		if (Visible)
		{
			if (Peer == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, PGLDHAIEJGK, "_Value");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, BFFCJEDADJG, "_TimeX", new GUILayoutOption[1]);
			}
		}
	}

	[SpecialName]
	public PhotonPeer GGJGMLLHLKP()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	public void JONGNKNLLND()
	{
		HBBPFLDICHB(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public PhotonPeer FABGKNDAMPK()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void ELFGOKFMMHC(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void NNJJDHIOMIA(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("maps.", FBOALIJENCM().RoundTripTime, Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = PNJIPPOIOEP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_TapMedium");
		if (flag != isSimulationEnabled)
		{
			GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Value" + num);
		num = GUILayout.HorizontalSlider(num, 1975f, 250f);
		DLNPKPBLFOM().NetworkSimulationSettings.IncomingLag = (int)num;
		DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = BCIJDDBHDLP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Right Stick Click" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 1344f, 1514f);
		ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		ODMKOICGKGD().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("event" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1042f, 1392f);
		NPBLKIPOKMF().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1162f;
		}
		GUI.DragWindow();
	}

	private void DAPKGKFKLKL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format(":\n", IJCHMGDEGCK().RoundTripTime, DLNPKPBLFOM().RoundTripTimeVariance));
		bool isSimulationEnabled = LOJMNGHPOOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value3", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			LOJMNGHPOOM().IsSimulationEnabled = flag;
		}
		float num = DLNPKPBLFOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Error: Can not set the OnSerialize rate higher than the overall SendRate." + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1149f, 1598f, new GUILayoutOption[1]);
		NPBLKIPOKMF().NetworkSimulationSettings.IncomingLag = (int)num;
		HDNDGHCJEGJ().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = HDNDGHCJEGJ().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("[LocalizationService] Error: " + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1896f, 1820f);
		ALEBHIOJOMO().NetworkSimulationSettings.IncomingJitter = (int)num2;
		GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("OK" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1877f, 370f);
		NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		HDNDGHCJEGJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 893f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public PhotonPeer FBOALIJENCM()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public PhotonPeer NMIOPAHIFGH()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	[SpecialName]
	public void NFCBEFDNDBG(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void IFNJMMPONJA(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void ANAOLAFEDON(int ENDMCOMANKJ)
	{
		GUILayout.Label("MenuRecordButton");
	}

	private void GGMICJGBCBF(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("checkpoint", PNJIPPOIOEP().RoundTripTime, LOJMNGHPOOM().RoundTripTimeVariance));
		bool isSimulationEnabled = GGJGMLLHLKP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Scale environment object by the values", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			DLNPKPBLFOM().IsSimulationEnabled = flag;
		}
		float num = FBOALIJENCM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Blue_C" + num);
		num = GUILayout.HorizontalSlider(num, 1237f, 1464f, new GUILayoutOption[1]);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		NPBLKIPOKMF().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = BCIJDDBHDLP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(",viewkeys" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 371f, 1365f, new GUILayoutOption[1]);
		ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		NNOPMLIPGGI().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = GENJEBLGKEF().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("visible" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1568f, 1622f, new GUILayoutOption[1]);
		AIMLGHOJNEG().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		PBNJOGMIBDL().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1140f;
		}
		GUI.DragWindow();
	}

	public void FBDOGLBMDNG()
	{
		if (Visible)
		{
			if (HDNDGHCJEGJ() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, OBJPCCJPACN, "Please specify either t or f.", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, BOKMOLOLOAN, "---", new GUILayoutOption[1]);
			}
		}
	}

	[SpecialName]
	public void FDOCLMLMBFI(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void EEGCKCPJPPH(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void Start()
	{
		Peer = PhotonNetwork.JNJJAMNLOHA;
	}

	private void IHIGABDJEEC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("in seconds. 0 - forever", HDAOIDAMNJO().RoundTripTime, NNOPMLIPGGI().RoundTripTimeVariance));
		bool isSimulationEnabled = NMIOPAHIFGH().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "#tryagain");
		if (flag != isSimulationEnabled)
		{
			LHELEHPOIDN().IsSimulationEnabled = flag;
		}
		float num = PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Value3" + num);
		num = GUILayout.HorizontalSlider(num, 916f, 265f);
		MKGMMLABLFD().NetworkSimulationSettings.IncomingLag = (int)num;
		BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = PNJIPPOIOEP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_Distance" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1233f, 214f, new GUILayoutOption[1]);
		FABGKNDAMPK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		FBOALIJENCM().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("challengeid" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1666f, 1927f);
		NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		GGJGMLLHLKP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 409f;
		}
		GUI.DragWindow();
	}

	private void IHMAOOAPLPO(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_ScreenResolution", GENJEBLGKEF().RoundTripTime, MDIEKLDMNDJ().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = FBOALIJENCM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "RoomDescriptionText");
		if (flag != isSimulationEnabled)
		{
			GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_ScreenResolution" + num);
		num = GUILayout.HorizontalSlider(num, 1519f, 584f, new GUILayoutOption[1]);
		IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag = (int)num;
		OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = AIMLGHOJNEG().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_ScreenResolution" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 127f, 401f);
		OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("SetSpeed" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1893f, 1866f, new GUILayoutOption[1]);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 251f;
		}
		GUI.DragWindow();
	}

	[SpecialName]
	public void IJGEPFCBHDF(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void GHFMFJNDCBH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Fill", DLNPKPBLFOM().RoundTripTime, PNJIPPOIOEP().RoundTripTimeVariance));
		bool isSimulationEnabled = NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "settings.volume.sfx");
		if (flag != isSimulationEnabled)
		{
			NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(": " + num);
		num = GUILayout.HorizontalSlider(num, 187f, 537f, new GUILayoutOption[1]);
		LHELEHPOIDN().NetworkSimulationSettings.IncomingLag = (int)num;
		NNOPMLIPGGI().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = MKGMMLABLFD().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_ScreenResolution" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 453f, 1011f, new GUILayoutOption[1]);
		MKGMMLABLFD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		LHELEHPOIDN().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = FABGKNDAMPK().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("couldn't be found!" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 1989f, 1944f);
		DLNPKPBLFOM().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1830f;
		}
		GUI.DragWindow();
	}

	public void NMHIDAOMOGO()
	{
		if (Visible)
		{
			if (DLNPKPBLFOM() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, MALIOOJFHPG, "BadgeImage");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, MPOICLNJGJO, "_Value");
			}
		}
	}

	public void KMCPMOGKDEH()
	{
		AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	private void CBKCFPBJDEL(int ENDMCOMANKJ)
	{
		GUILayout.Label("grid");
	}

	public void NNCCPEBIAKH()
	{
		LKFMMEBLCMK(PhotonNetwork.JNJJAMNLOHA);
	}

	public void FCCFGOEKDKG()
	{
		if (Visible)
		{
			if (BOBONFBENHG() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, HDFOAJAFMDK, "YES");
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, DAPKGKFKLKL, "CameraFilterPack_Paper2", new GUILayoutOption[1]);
			}
		}
	}

	private void CBDBMEAEBMH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format(": ", HDNDGHCJEGJ().RoundTripTime, MDIEKLDMNDJ().RoundTripTimeVariance));
		bool isSimulationEnabled = LHELEHPOIDN().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value4", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			LOJMNGHPOOM().IsSimulationEnabled = flag;
		}
		float num = HDAOIDAMNJO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("ReconnectToMaster() with AuthValues == null is not correct!" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 878f, 1873f, new GUILayoutOption[1]);
		BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag = (int)num;
		ODMKOICGKGD().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = ALEBHIOJOMO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("#,0.00" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 720f, 50f);
		OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("ResetSpeed" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 20f, 1109f, new GUILayoutOption[1]);
		HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1754f;
		}
		GUI.DragWindow();
	}

	public void JLJHPNKKJPJ()
	{
		if (Visible)
		{
			if (FABGKNDAMPK() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, CKHOOGMFDMD, "CameraFilterPack/Blur_GaussianBlur", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, HMPHAICGEJK, "Set particless emission (glow)");
			}
		}
	}

	[SpecialName]
	public void BJANBIOLJFB(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public PhotonPeer LHELEHPOIDN()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void HMPHAICGEJK(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("steamid", HDNDGHCJEGJ().RoundTripTime, GENJEBLGKEF().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = FABGKNDAMPK().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "mapselector.orderby", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = LOJMNGHPOOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(":" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 361f, 699f, new GUILayoutOption[1]);
		FBOALIJENCM().NetworkSimulationSettings.IncomingLag = (int)num;
		HDAOIDAMNJO().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_SoftZDistance" + num2);
		num2 = GUILayout.HorizontalSlider(num2, 833f, 1200f);
		BOBONFBENHG().NetworkSimulationSettings.IncomingJitter = (int)num2;
		ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value" + num3);
		num3 = GUILayout.HorizontalSlider(num3, 930f, 1554f, new GUILayoutOption[1]);
		OBLGFLGCCFP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 1144f;
		}
		GUI.DragWindow();
	}

	private void BFFCJEDADJG(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("CameraFilterPack_Atmosphere_Rain_FX", NMIOPAHIFGH().RoundTripTime, OBLGFLGCCFP().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_TimeX", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			BOBONFBENHG().IsSimulationEnabled = flag;
		}
		float num = GGJGMLLHLKP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("\0\0" + num);
		num = GUILayout.HorizontalSlider(num, 279f, 138f, new GUILayoutOption[1]);
		IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag = (int)num;
		IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("error" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 872f, 1133f, new GUILayoutOption[1]);
		GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter = (int)num2;
		NNOPMLIPGGI().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = NPBLKIPOKMF().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value3" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1659f, 1707f);
		GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			WindowRect.height = 710f;
		}
		GUI.DragWindow();
	}

	public void FIKFJDFELIP()
	{
		BBBKFCHNLJH(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void MFKKGNBFNPL(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	public void LGMADMDBKNE()
	{
		if (Visible)
		{
			if (IJCHMGDEGCK() == null)
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, BLJBEBLDEKB, "#startofflinemessage", new GUILayoutOption[1]);
			}
			else
			{
				WindowRect = GUILayout.Window(WindowId, WindowRect, HMPHAICGEJK, "menu.selectedplaymode", new GUILayoutOption[1]);
			}
		}
	}

	[SpecialName]
	public PhotonPeer MDIEKLDMNDJ()
	{
		return _003CIIILKHCAJKM_003Ek__BackingField;
	}

	private void LFPCFFJGFEL(int ENDMCOMANKJ)
	{
		GUILayout.Label(" = ", new GUILayoutOption[1]);
	}

	[SpecialName]
	public void BBBKFCHNLJH(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}

	private void DKNKGNEHMMB(int ENDMCOMANKJ)
	{
		GUILayout.Label("RedoButton");
	}

	public void KHIGHFJKPFG()
	{
		MBCHBLHDNBB(PhotonNetwork.JNJJAMNLOHA);
	}

	[SpecialName]
	public void NODJAFLLGIK(PhotonPeer DPNHODJHGJL)
	{
		_003CIIILKHCAJKM_003Ek__BackingField = DPNHODJHGJL;
	}
}
