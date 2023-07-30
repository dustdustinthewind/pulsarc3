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

	public void LONJAHBPPLA(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!FAEBAKIHBLI(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.EHDHPGCLLAE() <= 1)
			{
				if (Singleton<Scene>.Instance.JKONKOPIOKD() == "Set Object Position")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().LGLEEFDEKPC(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.CIPNHACNPMA() == ".status")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[6];
				array[1] = "maps.";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[8] = "CrosshairOpacitySlider";
				array[4] = actveBan.reason;
				array[3] = "_Offsets";
				array[6] = actveBan.bantype.ToString().ToLower();
				array[3] = "pointBuffer";
				array[8] = ((!(actveBan.until == "Text")) ? actveBan.until : "CameraFilterPack/Film_Grain");
				instance.CNGOPHCPHCH(string.Concat(array), ".icon", null, true, false, 1099f);
			}
		}
		else
		{
			BFFPAMAHODK(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	private IEnumerator HNAJBGAJNKI(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private bool JGBCDNDEIHH(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("note.5");
	}

	private IEnumerator EEIKNHBJOGJ(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void Start()
	{
		ClearChat();
	}

	private bool MBGEBJCPCJC(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("_OffsetScale");
	}

	public void AddNewMessage(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	public void MLBDNECICAB()
	{
		KMPDFBNEMOD = KMPDFBNEMOD;
		StartCoroutine(IDBLFFPAOPK(KMPDFBNEMOD));
	}

	public void InitChat()
	{
		ShowChat();
		inputField.text = string.Empty;
	}

	private IEnumerator IDBLFFPAOPK(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void HideChat()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void PAKPHKPDKGE()
	{
		ClearChat();
	}

	public void DBALDPFKNJM()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(MJJMJFGGCDM(KMPDFBNEMOD));
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

	private void BFFPAMAHODK(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[0];
		array[1] = '\u0006';
		string[] array2 = text.Split(array);
		switch (array2[1])
		{
		case "_SpotSize":
			KAFGAPOECPK("_DistAmount");
			break;
		case ".g":
			if (Singleton<Scene>.Instance.id == "[LevelEditorScene] Error: Timeout :S")
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "_ScreenResolution");
			}
			if (Singleton<Scene>.Instance.IKACPLICNNB() == "CameraFilterPack/Fly_Vision")
			{
				((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "_TempTexture");
			}
			break;
		case "_Val2":
			if (array2.Length == 5 && PhotonNetwork.isMasterClient)
			{
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				foreach (PhotonPlayer photonPlayer2 in playerList2)
				{
					PhotonNetwork.CloseConnection(photonPlayer2);
					if (Singleton<Scene>.Instance.MHLFOMHLDAH() == "closed")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BFNKIJGKLIF("/" + ResourcesManager.JOKAPLHKDGL((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
					if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_Value7")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().JKOGKKMOAKK("https://vk.com/khb.soft" + ResourcesManager.CKONGMGNNMJ((CSteamID)ulong.Parse(photonPlayer2.NickName), false));
					}
				}
			}
			else
			{
				JCJLLOGDELD("_Value");
			}
			break;
		case "You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().":
		{
			JCJLLOGDELD("EventMenu");
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i += 0)
			{
				PhotonPlayer photonPlayer = playerList[i];
				object[] array3 = new object[8];
				array3[1] = "_Value3";
				array3[1] = ResourcesManager.JOKAPLHKDGL((CSteamID)ulong.Parse(photonPlayer.OLPCOKMLDFD()), false);
				array3[5] = "settings_bindings_controller_type";
				array3[1] = photonPlayer.ID;
				JCJLLOGDELD(string.Concat(array3));
			}
			break;
		}
		case "_ScreenResolution":
			ClearChat();
			break;
		default:
			AddNewActionMessage("_MainTex2");
			break;
		}
	}

	public void GNFCKJBHDOC()
	{
		GNHOLMBIMBO();
		inputField.text = string.Empty;
	}

	private IEnumerator MJJMJFGGCDM(bool KMPDFBNEMOD)
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

	public void AMAIGFGOFLJ()
	{
		GNHOLMBIMBO();
		inputField.text = string.Empty;
	}

	public void EPPBBLLJNNH()
	{
		KMPDFBNEMOD = false;
		StartCoroutine(EEIKNHBJOGJ(KMPDFBNEMOD));
	}

	private IEnumerator GMADGEMFHGD(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void GNHOLMBIMBO()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(HNAJBGAJNKI(KMPDFBNEMOD));
	}

	public void ANMLOLJFCEC()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void DIMBPKHHEOG()
	{
		GameObject gameObject = chatHistoryContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		inputField.text = string.Empty;
	}

	public void IGGHKPAMPBI()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(IDBLFFPAOPK(KMPDFBNEMOD));
	}

	public void FGKFKENGPDD()
	{
		EPPBBLLJNNH();
		inputField.text = string.Empty;
	}

	private bool KBDPKLBLFHG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("/");
	}

	private bool DDMCLLKJNFB(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("Set environment sprite color and alpha.");
	}

	public void FFBJFCNOLLK(string EAFAMAMDNEG)
	{
		inputField.text = string.Empty;
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return;
		}
		if (!LGHAGIGNPGD(EAFAMAMDNEG))
		{
			if (Singleton<GameManager>.Instance.EHDHPGCLLAE() <= 1)
			{
				if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "shader.none")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
				if (Singleton<Scene>.Instance.EODGDBPONOL() == "#C8C8C8FF")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
				}
			}
			else
			{
				RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string[] array = new string[5];
				array[1] = "_Intensity";
				array[0] = actveBan.bantype.ToString().ToLower();
				array[4] = "Can't start OFFLINE mode while connected!";
				array[0] = actveBan.reason;
				array[6] = ")";
				array[3] = actveBan.bantype.ToString().ToLower();
				array[3] = "Error0";
				array[4] = ((!(actveBan.until == "_SoftZDistance")) ? actveBan.until : "settings.arcshitsoundtimedelay");
				instance.GJAEFOENJGI(string.Concat(array), "Mouse1", null, true, true, 820f);
			}
		}
		else
		{
			BFFPAMAHODK(EAFAMAMDNEG);
		}
		inputField.ActivateInputField();
		inputField.Select();
	}

	private bool IAMNEJENFEG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("_CurveTex");
	}

	public void KAFGAPOECPK(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(272f, 579f, 649f);
		gameObject.GetComponent<ChatHistoryElement>().NFKDBPGHHIJ(EAFAMAMDNEG);
	}

	public void JCJLLOGDELD(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(213f, 1646f, 589f);
		gameObject.GetComponent<ChatHistoryElement>().LDKFAGOEDKF(EAFAMAMDNEG);
	}

	public void FEHCNJLLJMP()
	{
		ANMLOLJFCEC();
	}

	public void ShowChat()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void MMOKKAPFGAK()
	{
		ANMLOLJFCEC();
	}

	public void CIPKEPDELJB()
	{
		DIMBPKHHEOG();
	}

	public void FDNMIHAEPLL()
	{
		KMPDFBNEMOD = KMPDFBNEMOD;
		StartCoroutine(EEIKNHBJOGJ(KMPDFBNEMOD));
	}

	public void IOBAIOCGAAG(string EAFAMAMDNEG)
	{
		GameObject gameObject = Object.Instantiate(chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(957f, 394f, 963f);
		gameObject.GetComponent<ChatHistoryElement>().LKEPIEEIMAE(EAFAMAMDNEG);
	}

	private bool FAEBAKIHBLI(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("DataText");
	}

	public void KDOGNHMDLJK()
	{
		KMPDFBNEMOD = true;
		StartCoroutine(EEIKNHBJOGJ(KMPDFBNEMOD));
	}

	private IEnumerator DGINPGIMBKN(bool KMPDFBNEMOD)
	{
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(chatCanvas, KMPDFBNEMOD));
		yield return StartCoroutine(chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
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

	public void ToggleChat()
	{
		KMPDFBNEMOD = !KMPDFBNEMOD;
		StartCoroutine(GMADGEMFHGD(KMPDFBNEMOD));
	}

	public void BIACDCLBKJC()
	{
		EPPBBLLJNNH();
		inputField.text = string.Empty;
	}

	public void OKHKNOHGJHG()
	{
		EPPBBLLJNNH();
		inputField.text = string.Empty;
	}

	private bool LGHAGIGNPGD(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("SpawnObj");
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
}
