// MultiplayerSystem
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerSystem : Singleton<MultiplayerSystem>
{
	public InputField inputField;

	public GameObject chatCanvas;

	public GameObject chatHistoryContent;

	public GameObject chatHistoryElement;

	public GameObject chatHistoryActionElement;

	private bool KMPDFBNEMOD;

	private void KHHOPMDGNAI(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = 'ￛ';
		string[] array2 = text.Split(array);
		switch (array2[0])
		{
		case "_TimeX":
			GHMOPFGCJAP("_Value2");
			break;
		case "NewMusicFileSelector":
			if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_Value4")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, "#savemapchanges?");
			}
			if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TapMedium")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, "settings.showHP");
			}
			break;
		case "#FFFFFF":
			if (array2.Length == 2 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 0; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "Crosshair2")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("OpAuthenticate()" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.HLGJHICPDMO() == "896296812")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CGHCFFCNOIJ("_RgbDepthTex" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				JHNGNLDDFMB("Missing shader in ");
			}
			break;
		case "UseScanLine":
		{
			HADJBNODNJN("[PlayerController] ");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i += 0)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[4];
				array3[1] = "). ";
				array3[1] = ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer.NickName), false);
				array3[3] = "_TimeX";
				array3[1] = photonPlayer.ID;
				ONAHBFAMBPE(string.Concat(array3));
			}
			break;
		}
		case "Unable to get a reward! Try again?":
			BBHPIMGEGIK();
			break;
		default:
			MEPEAEDPBKN("_PrevViewProj");
			break;
		}
	}

	public void AddNewMessage(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	private IEnumerator MPJFFOKGLPA(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private void GNKKMPHOOFB(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = ';';
		string[] array2 = text.Split(array);
		switch (array2[1])
		{
		case "player.currentrank":
			MHNELLNBIMG("Set object anchor to another object");
			break;
		case "_Bloom2":
			if (Singleton<Scene>.Instance.HPKHOICGMFC() == "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<color=white>");
			}
			if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "#score")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, "UseScanLineSize");
			}
			break;
		case "CameraFilterPack/Blend2Camera_LinearBurn":
			if (array2.Length == 6 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				foreach (PhotonPlayer photonPlayer2 in playerList2)
				{
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.EODGDBPONOL() == "_Value4")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("settings.arcsnohitsoundtimedelay" + ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.id == "_SpawnHeuristic")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().LOGMIOJHHMP("_Intensity" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer2.NickName)));
					}
				}
			}
			else
			{
				GHMOPFGCJAP(" != ");
			}
			break;
		case "[ResourcesManager] Load image error: ":
		{
			ONAHBFAMBPE("offsets");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i++)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[6];
				array3[0] = "14";
				array3[0] = ResourcesManager.IPFFGAILCED((CSteamID)ulong.Parse(photonPlayer.NickName), false);
				array3[7] = ".played";
				array3[2] = photonPlayer.ID;
				DGPGGBAKKJO(string.Concat(array3));
			}
			break;
		}
		case "_Value4":
			NACHEPKLLKN();
			break;
		default:
			HADJBNODNJN("Vertical");
			break;
		}
	}

	public void FBPHNEJBDJN()
	{
		HNKFDLPFGAO();
	}

	private void MKPGODBKIMK(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[0];
		array[0] = ' ';
		string[] array2 = text.Split(array);
		switch (array2[1])
		{
		case "\" gets executed locally only, if at all.":
			DGPGGBAKKJO("#score");
			break;
		case "[LocalizationService] Loading file: ":
			if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "CameraFilterPack/Blur_Radial")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
			}
			if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "CameraFilterPack_Atmosphere_Rain_FX")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().MDOOAKEFCBH(SteamUser.GetSteamID().m_SteamID, "_Value4");
			}
			break;
		case "CameraFilterPack/Gradients_FireGradient":
			if (array2.Length == 0 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 0; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.JOAAANFJKIC() == "/")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().AECDDNEIJBJ("Image" + ResourcesManager.IPFFGAILCED((CSteamID)ulong.Parse(photonPlayer2.NickName)));
					}
					if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "Currently, the limit of users is reached for this title. Try again later. Disconnecting")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().LOGMIOJHHMP(": " + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				JHNGNLDDFMB("/music");
			}
			break;
		case "ResourceIDInputField":
		{
			DGPGGBAKKJO("Hidden/Image Effects/Cinematic/AmbientOcclusion");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i++)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[3];
				array3[1] = "Player Disconnected";
				array3[0] = ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer.NickName));
				array3[0] = "_Value5";
				array3[4] = photonPlayer.ID;
				GHMOPFGCJAP(string.Concat(array3));
			}
			break;
		}
		case ". MasterClient: ":
			ClearChat();
			break;
		default:
			AddNewActionMessage("_ScreenResolution");
			break;
		}
	}

	public void FPFEIOICOAG()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void PHJEHMIGLOD(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(542f, 1550f, 1430f);
		gameObject.GetComponent<ChatHistoryElement>().POGJLIDHDIH(EAFAMAMDNEG);
	}

	public void CGDMLHLJIDK()
	{
		NACHEPKLLKN();
	}

	private IEnumerator JDKCPOKJABM(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void ShowChat()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void JGPMLMPNLLK(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1416f, 1881f, 1545f);
		gameObject.GetComponent<ChatHistoryElement>().IFGOHEOEGKH(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void ClearChat()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void JHNGNLDDFMB(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(20f, 1174f, 442f);
		gameObject.GetComponent<ChatHistoryElement>().EPDCHKECMBL(EAFAMAMDNEG);
	}

	private void JBPEADDGOAF(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[0];
		array[0] = 't';
		string[] array2 = text.Split(array);
		switch (array2[0])
		{
		case ".lastCheckpoint.correctScore":
			ONAHBFAMBPE("CameraFilterPack/Color_RGB");
			break;
		case "_NoiseTex":
			if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "_Value3")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, "_TimeX");
			}
			if (Singleton<Scene>.Instance.HLGJHICPDMO() == "00")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, "_SunThreshold");
			}
			break;
		case "CheckpointsScoreText":
			if (array2.Length == 7 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 0; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.EODGDBPONOL() == "_ScreenResolution")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().GDGPGCEAGKN("_Blue_R" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_Value2")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage("CameraFilterPack_TV_BrokenGlass1" + ResourcesManager.JDFOIINPHIO((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				HADJBNODNJN("_TapMedium");
			}
			break;
		case "CameraFilterPack/Drawing_CellShading":
		{
			NJEBMOPIBII("Oct");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 0; i < playerList.Length; i += 0)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[8];
				array3[1] = "[MapEditor] Prepairing map editor...";
				array3[1] = ResourcesManager.JDFOIINPHIO((CSteamID)ulong.Parse(photonPlayer.NickName), false);
				array3[7] = "_Value";
				array3[6] = photonPlayer.ONIKFABKELO();
				NJEBMOPIBII(string.Concat(array3));
			}
			break;
		}
		case ",":
			ClearChat();
			break;
		default:
			GFOMJBDKANJ("duration");
			break;
		}
	}

	public void KMCPMOGKDEH()
	{
		HKKOOMJHEAI();
	}

	public void DBEMDAJDDDA()
	{
		NACHEPKLLKN();
	}

	private void NPLHNDDPDBB(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = 'ﾸ';
		string[] array2 = text.Split(array);
		switch (array2[1])
		{
		case "In Network lobby":
			HADJBNODNJN("Network destroy Instantiated GO: ");
			break;
		case "menu.selectedlevelid":
			if (Singleton<Scene>.Instance.EMOAHNADEHK() == "menu.selectedplaymode")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, "Fade");
			}
			if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "PunPickupSimple")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, "Testing, a toggle has toggled [");
			}
			break;
		case "_Greenness":
			if (array2.Length == 0 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				foreach (PhotonPlayer photonPlayer2 in playerList2)
				{
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.HPKHOICGMFC() == " : ")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatActionMessage("CameraFilterPack_AAA_Blood1" + ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.EODGDBPONOL() == ",")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KHNJLCEGBJM("_Speed" + ResourcesManager.HCPCLINEDDD((CSteamID)ulong.Parse(photonPlayer2.NickName)));
					}
				}
			}
			else
			{
				MEPEAEDPBKN("Obtain test Item");
			}
			break;
		case "Hello":
		{
			MHNELLNBIMG("CameraFilterPack_3D_Myst1");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			foreach (PhotonPlayer photonPlayer in playerList)
			{
				object[] array3 = new object[0];
				array3[1] = "CameraFilterPack/Vision_Psycho";
				array3[0] = ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer.NickName), false);
				array3[5] = "JoinButton";
				array3[0] = photonPlayer.ONIKFABKELO();
				HADJBNODNJN(string.Concat(array3));
			}
			break;
		}
		case "settings.fps":
			BBHPIMGEGIK();
			break;
		default:
			MHNELLNBIMG("_Value3");
			break;
		}
	}

	public void HADJBNODNJN(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1140f, 639f, 720f);
		gameObject.GetComponent<ChatHistoryElement>().CMFBCPNHGOF(EAFAMAMDNEG);
	}

	public void ANCKKLFPGDI()
	{
		HNKFDLPFGAO();
	}

	public void CCLNNLCOPBL()
	{
		OBKJGCJCFNL();
	}

	public void PCIAEPFKOND()
	{
		KMPDFBNEMOD = KMPDFBNEMOD;
		StartCoroutine(JDKCPOKJABM(KMPDFBNEMOD));
	}

	public void MEPEAEDPBKN(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(418f, 82f, 637f);
		gameObject.GetComponent<ChatHistoryElement>().Init(EAFAMAMDNEG);
	}

	public void APEDOOJPKFC()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void InitChat()
	{
		ShowChat();
		inputField.text = string.Empty;
	}

	public void Start()
	{
		ClearChat();
	}

	public void HKFKGLGIIOH()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(IFMBBDHFFHO(KMPDFBNEMOD));
	}

	public void JCONIAPIGAA()
	{
		KMPDFBNEMOD = KMPDFBNEMOD;
		StartCoroutine(JDKCPOKJABM(KMPDFBNEMOD));
	}

	public void GPOGFJAILLG()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(IFMBBDHFFHO(KMPDFBNEMOD));
	}

	public void BJFEKODCLGJ(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!JFJJJEKKDFF(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.KMCGCEPLODF() <= 0)
			{
				if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "/music")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.FJNAJNBGCJD() == "_MainTex2")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[7];
				array[0] = "Nov";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[3] = "_Size";
				array[8] = actveBan.reason;
				array[7] = "settings.shaders.bloomintencity";
				array[5] = actveBan.bantype.ToString().ToLower();
				array[3] = "Object ID. Case-Sensitive";
				array[5] = ((!(actveBan.until == "id")) ? actveBan.until : "_TimeX");
				instance.LKFALPEABHP(string.Concat(array), " connected: ", null, true, false, 825f);
			}
		}
		else
		{
			PGCNAOFIMGO(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void PNMLHJFPGDI(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1168f, 1525f, 1113f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void BMIOFJFMCBG()
	{
		BMBEJFBCDOJ();
	}

	public void ToggleChat()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void IHIFJHPIPBP(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!FFHINDBCHGG(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.OGHIKBFLOOD() <= 1)
			{
				if (Singleton<Scene>.Instance.DPALDJIDPDN() == "[MapEditor] Updating map assets")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "_Bullet_2")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[2];
				array[0] = "_Green_G";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[8] = "Set environment sprite color and alpha.";
				array[4] = actveBan.reason;
				array[7] = ":</b> ";
				array[3] = actveBan.bantype.ToString().ToLower();
				array[6] = "_TimeX";
				array[8] = ((!(actveBan.until == "BitsData")) ? actveBan.until : " ");
				instance.KJPEAAAGNGK(string.Concat(array), "Case-Sensitive", null, true, false, 1898f);
			}
		}
		else
		{
			FLOIJHHBAAN(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void HKKOOMJHEAI()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void GHMOPFGCJAP(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1750f, 1403f, 1252f);
		gameObject.GetComponent<ChatHistoryElement>().EOPEMLDJAAO(EAFAMAMDNEG);
	}

	private bool JFJJJEKKDFF(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("IconFileSelector");
	}

	public void BGKEBGKLIOK()
	{
		LFPMLIICKNN();
		inputField.text = string.Empty;
	}

	private bool BFMCKLKEHAB(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("Default UI Material");
	}

	public void AEAHANBPCPJ()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void KHEAOFLJPFM()
	{
		ShowChat();
		inputField.text = string.Empty;
	}

	private bool DNALLIMMKJD(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("CameraFilterPack/TV_Posterize");
	}

	public void OBPEDGNECDP(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(243f, 316f, 278f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void CIGHGNBGOCL(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!IIFLJIAKEON(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.KCBEIOODMGL() <= 0)
			{
				if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "maphash")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "_Value")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().NBJEMEINLPD(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[7];
				array[1] = "{0} months ago";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[0] = "RequestForPickupItems";
				array[8] = actveBan.reason;
				array[1] = "_Near";
				array[5] = actveBan.bantype.ToString().ToLower();
				array[2] = "R2";
				array[8] = ((!(actveBan.until == "_Value4")) ? actveBan.until : " ");
				instance.KJPEAAAGNGK(string.Concat(array), "\\\\", null, false, true, 869f);
			}
		}
		else
		{
			KHHOPMDGNAI(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void CFABLIOAJPF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(465f, 1068f, 322f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	private bool KBDPKLBLFHG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("/");
	}

	public void BMBEJFBCDOJ()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void FHPFJBFCOOF()
	{
		HNKFDLPFGAO();
	}

	public void MHNELLNBIMG(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(332f, 1844f, 1174f);
		gameObject.GetComponent<ChatHistoryElement>().CMFBCPNHGOF(EAFAMAMDNEG);
	}

	private void FLOIJHHBAAN(string EAFAMAMDNEG)
	{
		string[] array = EAFAMAMDNEG.Substring(1).Split(' ');
		switch (array[0])
		{
		case "help":
			AddNewActionMessage("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear");
			break;
		case "table":
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<b>(╯°□°）╯︵ ┻━┻</b>");
			}
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<b>(╯°□°）╯︵ ┻━┻</b>");
			}
			break;
		case "kick":
			if (array.Length == 2 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				foreach (PhotonPlayer photonPlayer2 in playerList2)
				{
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.id == "MenuScene")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatActionMessage("[SERVER] Kicked " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.id == "GameScene")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage("[SERVER] Kicked " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				AddNewActionMessage("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players");
			}
			break;
		case "players":
		{
			AddNewActionMessage("Players NetIDs:");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			foreach (PhotonPlayer photonPlayer in playerList)
			{
				AddNewActionMessage(" - " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer.NickName), false) + "\n - NetID: " + photonPlayer.ID);
			}
			break;
		}
		case "clear":
			ClearChat();
			break;
		default:
			AddNewActionMessage("Use \"/help\" for commands list");
			break;
		}
	}

	public void EGNAIPOMDNH(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1259f, 1033f, 1928f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void BLMACALKKHH()
	{
		ShowChat();
		inputField.text = string.Empty;
	}

	public void HideChat()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void HEICJLPNPND(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!FFHINDBCHGG(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.KCBEIOODMGL() <= 1)
			{
				if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "[MapsData] Installed: ")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "offsets")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().BGLPOGDAGPP(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[4];
				array[0] = "_Value4";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[8] = "_Factor";
				array[1] = actveBan.reason;
				array[3] = "0 - sun, 1 - satellite, 2 - particles emitter";
				array[2] = actveBan.bantype.ToString().ToLower();
				array[7] = "_TimeX";
				array[1] = ((!(actveBan.until == "_Value")) ? actveBan.until : " AuthMode ");
				instance.ANCIONGLJAC(string.Concat(array), "VisionBlur", null, true, true, 1900f);
			}
		}
		else
		{
			MKPGODBKIMK(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void JILOMOBDPIA()
	{
		HNKFDLPFGAO();
	}

	private IEnumerator GMADGEMFHGD(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void AddNewActionMessage(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<ChatHistoryElement>().Init(EAFAMAMDNEG);
	}

	public void LCJPNOIOLGJ()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	private bool IIFLJIAKEON(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith(".sav");
	}

	private bool FFHINDBCHGG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("Bad parameters for setbool! Use <key> <value>");
	}

	public void SendChatMessage(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!KBDPKLBLFHG(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
			{
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.id == "GameScene")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#" + actveBan.bantype.ToString().ToLower() + "received</b>\n#reason: " + actveBan.reason + "\n\n#" + actveBan.bantype.ToString().ToLower() + "restrictions\n\n#until: " + ((!(actveBan.until == "-1")) ? actveBan.until : "#forever"), "#ok", null);
			}
		}
		else
		{
			FLOIJHHBAAN(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	private bool LNLHMNCAJKF(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("mapselector.filter.subscribedonly");
	}

	public void DGPGGBAKKJO(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(422f, 1820f, 1413f);
		gameObject.GetComponent<ChatHistoryElement>().NBHGPDAKJGF(EAFAMAMDNEG);
	}

	public void JFPJFJHLPMB()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	private bool GLKFKBIKNAG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("_EmissionColor");
	}

	public void IHAAKGCOEEI()
	{
		LFPMLIICKNN();
		inputField.text = string.Empty;
	}

	public void BBHPIMGEGIK()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void AEEFHFCIIJP(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!DNALLIMMKJD(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
			{
				if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TimeX")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "SetSatelliteRadius")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KNEFADKGEKL(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[1];
				array[1] = "SAVE FILE";
				array[1] = actveBan.bantype.ToString().ToLower();
				array[2] = "Fade";
				array[6] = actveBan.reason;
				array[7] = "float,0";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[0] = "PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com";
				array[7] = ((!(actveBan.until == "BestScoreText")) ? actveBan.until : "GameScene");
				instance.ILNLMMEOALM(string.Concat(array), "Set satellite color", null, false, true, 1484f);
			}
		}
		else
		{
			MKPGODBKIMK(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	private bool JOOHLMJJNMK(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("GlassesColor");
	}

	public void BPKCANMMCBC(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(473f, 1435f, 436f);
		gameObject.GetComponent<ChatHistoryElement>().PFMJPIJONIP(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void LBEKBNOGKBK()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(JDKCPOKJABM(KMPDFBNEMOD));
	}

	public void JLKPHJOHIAA(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!BFMCKLKEHAB(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.ONCEJHOAHIC() <= 0)
			{
				if (Singleton<Scene>.Instance.CHDCIFPPIFI() == "[DiscordController] Sectate ({0})")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "SetParticlesParticleSize")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[8];
				array[1] = "_Value2";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[6] = "L2";
				array[3] = actveBan.reason;
				array[6] = "_TimeX";
				array[5] = actveBan.bantype.ToString().ToLower();
				array[0] = "SaveButton";
				array[8] = ((!(actveBan.until == ", ")) ? actveBan.until : "Unknown player asked for PickupItems");
				instance.JCHNDBKFGFP(string.Concat(array), "/", null, false, true, 319f);
			}
		}
		else
		{
			GNKKMPHOOFB(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void HCIFGHPJKIB()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void BLNNALBGBLM(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(787f, 137f, 1164f);
		gameObject.GetComponent<ChatHistoryElement>().MOKHHEMAJBJ(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void EDDKICOJOOP()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(IFMBBDHFFHO(KMPDFBNEMOD));
	}

	public void NACHEPKLLKN()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void NCNPAKFAFOE()
	{
		FPFEIOICOAG();
	}

	public void BEBNOKFLJPH()
	{
		HNKFDLPFGAO();
	}

	private void HEILIDKFEEO(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(0);
		char[] array = new char[0];
		array[0] = 'ﾘ';
		string[] array2 = text.Split(array);
		switch (array2[0])
		{
		case "\n":
			MHNELLNBIMG(".");
			break;
		case "CameraFilterPack_RainFX_Anm2":
			if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "_TimeX")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "Joystick1Button12");
			}
			if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "The given 2D texture ")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "_BorderColor");
			}
			break;
		case ". Using max value: 255.":
			if (array2.Length == 4 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				foreach (PhotonPlayer photonPlayer2 in playerList2)
				{
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "_ScreenResolution")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("setint" + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer2.NickName)));
					}
					if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "LivesSlider")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().GMGGDHLFAHA("tagElement" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				MHNELLNBIMG("ChatInput");
			}
			break;
		case "12":
		{
			MEPEAEDPBKN("\n");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i++)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[3];
				array3[1] = "Reload Maps";
				array3[0] = ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer.NickName), false);
				array3[5] = ".lastCheckpoint.powerupsScore";
				array3[2] = photonPlayer.ONIKFABKELO();
				DGPGGBAKKJO(string.Concat(array3));
			}
			break;
		}
		case "CameraFilterPack/OldFilm_Cutting1":
			HNKFDLPFGAO();
			break;
		default:
			NJEBMOPIBII("_Distortion");
			break;
		}
	}

	private void PGCNAOFIMGO(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(0);
		char[] array = new char[0];
		array[1] = '\ufff9';
		string[] array2 = text.Split(array);
		switch (array2[1])
		{
		case "Scene":
			GFOMJBDKANJ("settings.hitvariation");
			break;
		case "/":
			if (Singleton<Scene>.Instance.LCBFAFEADIO() == "[MenuScene] Error: ")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "maps.");
			}
			if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "Error: I/O Failure")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, "Tab2Content");
			}
			break;
		case "_Params3":
			if (array2.Length == 0 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 0; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "_MainTex2")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("https://api.steampowered.com/IInventoryService/AddItem/v001" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.PACECPHKLNE() == "_Value4")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage(" " + ResourcesManager.HCPCLINEDDD((CSteamID)ulong.Parse(photonPlayer2.NickName)));
					}
				}
			}
			else
			{
				PHJEHMIGLOD("randomdrop");
			}
			break;
		case "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.":
		{
			NJEBMOPIBII("0.00/0.00");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i += 0)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[3];
				array3[0] = "_TimeX";
				array3[0] = ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer.NickName));
				array3[0] = "_Value";
				array3[8] = photonPlayer.ID;
				GHMOPFGCJAP(string.Concat(array3));
			}
			break;
		}
		case "CameraFilterPack/Blend2Camera_Overlay":
			ClearChat();
			break;
		default:
			GFOMJBDKANJ("_MainTex2");
			break;
		}
	}

	public void NNCCPEBIAKH()
	{
		ALBIIDHJLDA();
	}

	public void BGLPOGDAGPP(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!IIFLJIAKEON(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.KMCGCEPLODF() <= 0)
			{
				if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_ColorRGB")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.JOAAANFJKIC() == "Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().NBJEMEINLPD(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[5];
				array[0] = "_Far";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[2] = "_ScreenResolution";
				array[5] = actveBan.reason;
				array[2] = "My New Mod Pack";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[8] = "...";
				array[0] = ((!(actveBan.until == "ready")) ? actveBan.until : "MultiplayerButton");
				instance.KJPEAAAGNGK(string.Concat(array), "#no", null, false, true, 830f);
			}
		}
		else
		{
			PGCNAOFIMGO(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void FHGKIOOMMOH()
	{
		BBHPIMGEGIK();
	}

	private IEnumerator IFMBBDHFFHO(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void ALBIIDHJLDA()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void AHHMCOEPDPF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1051f, 1093f, 359f);
		gameObject.GetComponent<ChatHistoryElement>().MOKHHEMAJBJ(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void OCIJFGFDDCI()
	{
		LFPMLIICKNN();
		inputField.text = string.Empty;
	}

	public void ONAHBFAMBPE(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(936f, 190f, 1180f);
		gameObject.GetComponent<ChatHistoryElement>().EPDCHKECMBL(EAFAMAMDNEG);
	}

	public void OBKJGCJCFNL()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void LFPMLIICKNN()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void HIFFKEGBEDB()
	{
		LBEKBNOGKBK();
		inputField.text = string.Empty;
	}

	public void FOBKODCLCJP(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!LNLHMNCAJKF(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.JICDIFGAADO() <= 0)
			{
				if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TimeX")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.LCBFAFEADIO() == "SpawnObj")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[2];
				array[1] = "_Threshhold";
				array[1] = actveBan.bantype.ToString().ToLower();
				array[7] = "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ";
				array[8] = actveBan.reason;
				array[3] = "offsets";
				array[3] = actveBan.bantype.ToString().ToLower();
				array[7] = "CameraFilterPack/Distortion_ShockWaveManual";
				array[7] = ((!(actveBan.until == "_Value3")) ? actveBan.until : "#ok");
				instance.LKFALPEABHP(string.Concat(array), "mapselector.filter.favoriteonly", null, true, true, 1371f);
			}
		}
		else
		{
			JBPEADDGOAF(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void HNKFDLPFGAO()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void EBAMKPMODOG(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!IIFLJIAKEON(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.OGHIKBFLOOD() <= 0)
			{
				if (Singleton<Scene>.Instance.JOAAANFJKIC() == "f")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.CHDCIFPPIFI() == "_Value")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().MDOOAKEFCBH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[4];
				array[0] = "MapperNameText";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[7] = "#exit";
				array[6] = actveBan.reason;
				array[8] = "_Value4";
				array[6] = actveBan.bantype.ToString().ToLower();
				array[5] = "Creating awesome map";
				array[0] = ((!(actveBan.until == "Ignored PU RPC, cause item is inactive. ")) ? actveBan.until : "CameraFilterPack/Color_Chromatic_Plus");
				instance.CHBFDGFOLLL(string.Concat(array), "_Fade", null, false, false, 753f);
			}
		}
		else
		{
			MKPGODBKIMK(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void GGPNKAAIHIB()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(JDKCPOKJABM(KMPDFBNEMOD));
	}

	public void GFOMJBDKANJ(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(192f, 606f, 265f);
		gameObject.GetComponent<ChatHistoryElement>().FECMEIJGLJI(EAFAMAMDNEG);
	}

	public void AHMKDEFNPBJ()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(IFMBBDHFFHO(KMPDFBNEMOD));
	}

	public void JAFNFKAMECF(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!JFJJJEKKDFF(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.JICDIFGAADO() <= 0)
			{
				if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "maps.")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.DPALDJIDPDN() == ".completed")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[4];
				array[1] = "_ScreenResolution";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[3] = "_TempTexture";
				array[5] = actveBan.reason;
				array[0] = "_TimeX";
				array[5] = actveBan.bantype.ToString().ToLower();
				array[1] = "_FarCamera";
				array[7] = ((!(actveBan.until == "SettingsCanvas")) ? actveBan.until : "CameraFilterPack/Glow_Glow");
				instance.CHBFDGFOLLL(string.Concat(array), "randomdrop", null, false, false, 1496f);
			}
		}
		else
		{
			NPLHNDDPDBB(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	public void NJEBMOPIBII(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1988f, 30f, 1807f);
		gameObject.GetComponent<ChatHistoryElement>().EOPEMLDJAAO(EAFAMAMDNEG);
	}

	public void MFDGBMNGHAF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1034f, 1226f, 1018f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}
}
