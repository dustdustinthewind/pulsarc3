// InRoomRoundTimer
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomRoundTimer : MonoBehaviour
{
	public int SecondsPerTurn = 5;

	public double StartTime;

	public Rect TextPos = new Rect(0f, 80f, 150f, 300f);

	private bool DBHJOONLNJE;

	private const string JJDHAIONGKL = "st";

	public void PELNCDEODGD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			JDKOEAMABCK();
		}
		else
		{
			Debug.Log("<b>Time</b>:" + PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("[DiscordController] Error {0}: {1}"));
		}
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("st"))
		{
			Debug.Log("The new master starts a new round, cause we didn't start yet.");
			AEMCMOBKOJK();
		}
	}

	private void LLJLDLLNFBH()
	{
		if (DBHJOONLNJE)
		{
			JDKOEAMABCK();
		}
	}

	private void AEMCMOBKOJK()
	{
		if (PhotonNetwork.time < 9.9999997473787516E-05)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["st"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void LKLDBEBLMBI(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_Size"))
		{
			Debug.Log(" in-game items");
			JLOCLBNNAAN();
		}
	}

	public void LEEHMNACMEI(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("ticket.ticket1"))
		{
			StartTime = (double)DGIHEPAHAJK["_Far"];
		}
	}

	public void MNNLMGKAPFG(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("Can't set Room.MaxPlayers to: "))
		{
			Debug.Log("0.000");
			NAPOAHBNGCK();
		}
	}

	public void OANDGCIFNAN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			NAPOAHBNGCK();
		}
		else
		{
			Debug.Log("settings.hideui" + PhotonNetwork.room.customProperties.ContainsKey("_Green_G"));
		}
	}

	public void PCABPJAANFH()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("11", num));
		GUILayout.Label(string.Format("_TimeX", num2));
		GUILayout.Label(string.Format("NetworkPeer broke!", num3), new GUILayoutOption[1]);
		if (GUILayout.Button(" ["))
		{
			NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	public void LLLOCCNLCNL()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_Fade", num));
		GUILayout.Label(string.Format(". Using max value: 255.", num2));
		GUILayout.Label(string.Format("_TimeX", num3));
		if (GUILayout.Button("MapEnd", new GUILayoutOption[1]))
		{
			JDKOEAMABCK();
		}
		GUILayout.EndArea();
	}

	public void JCJENMGGCLB(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("cancel"))
		{
			Debug.Log("music.ogg");
			AEMCMOBKOJK();
		}
	}

	public void LHACGKFCAMG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("PLEASE WAIT"))
		{
			StartTime = (double)DGIHEPAHAJK["workshop."];
		}
	}

	private void Update()
	{
		if (DBHJOONLNJE)
		{
			AEMCMOBKOJK();
		}
	}

	public void HOEJPDLECMG(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("<b>#"))
		{
			Debug.Log("_Amount");
			DNBPCAEIMHN();
		}
	}

	public void HMKPEEAJODO()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", num));
		GUILayout.Label(string.Format("EventSystem", num2));
		GUILayout.Label(string.Format("_Value", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("YES"))
		{
			DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	public void AHNBAOIENOO()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("#accuracy", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_Intensity", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("SetRotation", num3));
		if (GUILayout.Button("_VignetteDesat"))
		{
			DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	private void JDKOEAMABCK()
	{
		if (PhotonNetwork.time < 1276.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable[" PhotonView: "] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	private void NKLIHNJCHOG()
	{
		if (DBHJOONLNJE)
		{
			LPEOOKEOBEL();
		}
	}

	public void GKCLHCNEGJM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results"))
		{
			StartTime = (double)DGIHEPAHAJK[".played"];
		}
	}

	public void JLJHPNKKJPJ()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("settings.fps", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("OnAwakeRPC", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Object ID. Case-Sensitive", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Line", new GUILayoutOption[1]))
		{
			JAIBANMMMFF();
		}
		GUILayout.EndArea();
	}

	public void LPKLOFJJJEI()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_Value", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("VoteDownToggle", num2));
		GUILayout.Label(string.Format("menutheme.coldheat", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Speed", new GUILayoutOption[1]))
		{
			JLOCLBNNAAN();
		}
		GUILayout.EndArea();
	}

	public void HBBHCICNOMA(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.PFFHNNODEMM().ContainsKey("BloodAlternative3"))
		{
			Debug.Log("Set camera (or player) distance. Base player distance - 14");
			JAIBANMMMFF();
		}
	}

	private void JLOCLBNNAAN()
	{
		if (PhotonNetwork.time < 683.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["Joystick1Button9"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	private void NAPOAHBNGCK()
	{
		if (PhotonNetwork.time < 1239.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["plainText"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void NOHIOLKMJNH(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_PositionY"))
		{
			Debug.Log(".png");
			DDMJBHAHJED();
		}
	}

	public void CCPEJINHAGP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_ScreenResolution"))
		{
			StartTime = (double)DGIHEPAHAJK[" - PUBLISHED #"];
		}
	}

	private void CFIAKIJAILI()
	{
		if (DBHJOONLNJE)
		{
			JLOCLBNNAAN();
		}
	}

	public void GLNBFKKAAOP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("GameMessagesDurationSlider"))
		{
			StartTime = (double)DGIHEPAHAJK["_ScreenResolution"];
		}
	}

	public void MOJGCADBPBI(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("_TimeX"))
		{
			Debug.Log("_Contrast");
			AEMCMOBKOJK();
		}
	}

	private void HPNNCNNFMGK()
	{
		if (DBHJOONLNJE)
		{
			JAIBANMMMFF();
		}
	}

	private void BGDONBMDPGM()
	{
		if (DBHJOONLNJE)
		{
			JAIBANMMMFF();
		}
	}

	public void PBJIMOILOLE()
	{
		if (PhotonNetwork.isMasterClient)
		{
			LPEOOKEOBEL();
		}
		else
		{
			Debug.Log("_Value4" + PhotonNetwork.room.KMBLODHBAFO().ContainsKey("settings_bindings_controller_type"));
		}
	}

	public void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
		{
			AEMCMOBKOJK();
		}
		else
		{
			Debug.Log("StartTime already set: " + PhotonNetwork.room.customProperties.ContainsKey("st"));
		}
	}

	public void NEMLLIAHOBM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[SoundManager] Loaded skin audio"))
		{
			StartTime = (double)DGIHEPAHAJK["_Value3"];
		}
	}

	private void LPMINJJPDCH()
	{
		if (DBHJOONLNJE)
		{
			NAPOAHBNGCK();
		}
	}

	public void EOJGCJABGNC()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("ok", num));
		GUILayout.Label(string.Format("<b>#banended</b>", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Malformed RPC; this should never occur. Content: ", num3));
		if (GUILayout.Button("^"))
		{
			JDKOEAMABCK();
		}
		GUILayout.EndArea();
	}

	public void IDDPLCAHDPO()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_TimeX", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_BlurRadius4", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Gameplay/satellite", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Value"))
		{
			JLOCLBNNAAN();
		}
		GUILayout.EndArea();
	}

	public void ICOIEGANENL(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("help"))
		{
			StartTime = (double)DGIHEPAHAJK["s"];
		}
	}

	public void KOCIIOKHKME()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("isBunned", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("]", num2));
		GUILayout.Label(string.Format("GO==null", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Value", new GUILayoutOption[1]))
		{
			NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	public void PNHBOKMFFNN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			JLOCLBNNAAN();
		}
		else
		{
			Debug.Log("_Offsets" + PhotonNetwork.room.PFFHNNODEMM().ContainsKey("white"));
		}
	}

	public void GMKMLFAIIAJ()
	{
		if (PhotonNetwork.isMasterClient)
		{
			NAPOAHBNGCK();
		}
		else
		{
			Debug.Log("_Value2" + PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("Set Satellite Sensitivity"));
		}
	}

	private void JHPOIOELNCG()
	{
		if (DBHJOONLNJE)
		{
			JAIBANMMMFF();
		}
	}

	private void LPEOOKEOBEL()
	{
		if (PhotonNetwork.time < 1812.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable[". Going to ignore! Check PhotonServerSettings.RpcList"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	private void JAIBANMMMFF()
	{
		if (PhotonNetwork.time < 274.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["GridDataArcs"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	public void BNHKNBILGBK(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("[PlayerController] "))
		{
			Debug.Log("_Value2");
			JAIBANMMMFF();
		}
	}

	public void PHCOGMJPGNN(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_TimeX"))
		{
			Debug.Log("Init");
			DDMJBHAHJED();
		}
	}

	private void EGEGNHLODAA()
	{
		if (DBHJOONLNJE)
		{
			JAIBANMMMFF();
		}
	}

	private void DDMJBHAHJED()
	{
		if (PhotonNetwork.time < 576.0)
		{
			DBHJOONLNJE = false;
			return;
		}
		DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["offsets"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	private void DNBPCAEIMHN()
	{
		if (PhotonNetwork.time < 508.0)
		{
			DBHJOONLNJE = true;
			return;
		}
		DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["float,1.5"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	public void LEHMPPOHPEI()
	{
		if (PhotonNetwork.isMasterClient)
		{
			DDMJBHAHJED();
		}
		else
		{
			Debug.Log("," + PhotonNetwork.room.KMBLODHBAFO().ContainsKey("[DiscordController] Sectate ({0})"));
		}
	}

	public void OnGUI()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label($"elapsed: {num:0.000}");
		GUILayout.Label($"remaining: {num2:0.000}");
		GUILayout.Label($"turn: {num3:0}");
		if (GUILayout.Button("new round"))
		{
			AEMCMOBKOJK();
		}
		GUILayout.EndArea();
	}

	public void LKFBADCLLML()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format(": ", num));
		GUILayout.Label(string.Format("_Value", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_threshold", num3));
		if (GUILayout.Button("Subscribed cells:\n"))
		{
			DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	public void MPOCGBCPFJC(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_VelocityScale"))
		{
			Debug.Log("GridDataStoryboard");
			NAPOAHBNGCK();
		}
	}

	public void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("st"))
		{
			StartTime = (double)DGIHEPAHAJK["st"];
		}
	}

	public void BCODHAOJLJL()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_Red_G", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_ScreenResolution", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("OnAwakeRPC", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
		{
			NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	public void EDODBNGGNDF(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_Distortion"))
		{
			Debug.Log("00");
			LPEOOKEOBEL();
		}
	}

	public void HNOGLCMFLPA(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_Value"))
		{
			Debug.Log("_Offsets");
			JDKOEAMABCK();
		}
	}

	private void NDAJBJFJGCF()
	{
		if (DBHJOONLNJE)
		{
			DDMJBHAHJED();
		}
	}

	public void NMHIDAOMOGO()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("shader.sunny", num));
		GUILayout.Label(string.Format("Event Received", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("#ok", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("settings_bindings_", new GUILayoutOption[1]))
		{
			NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	private void HMNLHMLILKD()
	{
		if (DBHJOONLNJE)
		{
			LPEOOKEOBEL();
		}
	}

	public void EAHKLHCEDLB()
	{
		double num = PhotonNetwork.time - StartTime;
		double num2 = (double)SecondsPerTurn - num % (double)SecondsPerTurn;
		int num3 = (int)(num / (double)SecondsPerTurn);
		GUILayout.BeginArea(TextPos);
		GUILayout.Label(string.Format("_Value", num));
		GUILayout.Label(string.Format("EventTimeInputField", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_Value2", num3));
		if (GUILayout.Button("/music"))
		{
			JAIBANMMMFF();
		}
		GUILayout.EndArea();
	}

	public void LPLDDGOEEIJ(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("[NetworkManager] Exited"))
		{
			Debug.Log("color");
			JLOCLBNNAAN();
		}
	}

	public void PFPGCHHHEHM(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("CameraFilterPack/Blend2Camera_ColorBurn"))
		{
			Debug.Log("ShowTitle");
			JLOCLBNNAAN();
		}
	}

	public void GAAMDOMCJLK(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("UnityEngine.MonoBehaviour"))
		{
			Debug.Log("_CenterX");
			JLOCLBNNAAN();
		}
	}
}
