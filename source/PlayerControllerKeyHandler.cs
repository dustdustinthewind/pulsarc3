// PlayerControllerKeyHandler
using System;
using UnityEngine;

[Serializable]
public class PlayerControllerKeyHandler
{
	public PlayerController player;

	public PlayerController.Direction direction;

	public string buttonKey = string.Empty;

	public bool wasPressed;

	public float currentTimeout = 0.1f;

	public int handId;

	public float attime;

	public void ABDEGHLHHHF()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void Reset()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.playerBase.photonView.isMine)
			{
				player.playerBase.photonView.RPC("CheckCombo", PhotonTargets.All, player.GetCombo(), handId);
			}
			else
			{
				player.CheckCombo(player.GetCombo(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void NBOKAGMABPN()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.GKGCHBJANLF().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = player.DFPMJLHLFNK().photonView;
				string lBLKDNNPACO = "mapselector.orderby";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = player.KNBOIOEKJID();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.POFBCEKBIDH(player.CNLDGEMKLPP(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void NEKCPLGFOFD()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				HKJJMPCFEPL();
			}
			if (wasPressed && currentTimeout > 1970f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1588f)
			{
				BBBNLHALLBN();
			}
		}
		else if (hardInput.EBAHBLEMKKC(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NABBDBMIHOI().JDBCGCJJIAF().isMine)
			{
				PhotonView photonView = player.GENOLDKFAPB().FFIPLLNKGEN();
				string lBLKDNNPACO = "_TimeX";
				PhotonTargets mPNMOONBMII = (PhotonTargets)8;
				object[] array = new object[1] { player.GCBPLIIAODI() };
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.KIPNNNAHGDJ(player.BPJOPJPCKDA(), handId, 1074f);
			}
		}
	}

	public void OBAEDJJDCPN()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				GKFOIOALDFH();
			}
			if (wasPressed && currentTimeout > 298f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1966f)
			{
				KHGOJDPMPML();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NJODHOMKIED().IFENGKHOKPC().isMine)
			{
				PhotonView photonView = player.LMENGPDOOJG().AAMNKPHHHCI();
				string lBLKDNNPACO = "Warning: No Shape Curve set for CurveWaveform.cs on ";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[4];
				array[1] = player.CNLDGEMKLPP();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.KNBOIOEKJID(), handId, 265f);
			}
		}
	}

	public void ABDHDGNIHHI()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DMMGMCGNILI().GBMJAPGLMGB().isMine)
			{
				PhotonView photonView = player.GKGCHBJANLF().JDBCGCJJIAF();
				string lBLKDNNPACO = "Localization Servise\nWorking commands:\nset <language>\nlist\nkeys";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[0];
				array[1] = player.CNLDGEMKLPP();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GCPKNBBPAHJ(player.GCBPLIIAODI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void FHPPMBEEKBL()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ENNCFNJBJAG().JDBCGCJJIAF().isMine)
			{
				PhotonView photonView = player.KJHMNOEDBJJ().GBMJAPGLMGB();
				string lBLKDNNPACO = "_Value3";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = player.GCBPLIIAODI();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.JOAEFBPDEJP(player.GPBFAEIADJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void JEKEBJCHOHO()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.MEBPHCDCLCC().EOOCGIFFKBG().isMine)
			{
				PhotonView photonView = player.JAGBDKPMBGP().GBMJAPGLMGB();
				string lBLKDNNPACO = "PopulateMapsList";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[8];
				array[0] = player.ALKGJEEHEBN();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CNHOOPMOBPG(player.BHECOHDKMGO(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void KIBLMKAKPOB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void OJECBKEMOBH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.JAGBDKPMBGP().EDIJKHEMPAD().isMine)
			{
				PhotonView photonView = player.NJODHOMKIED().GBHNDHLAJLI();
				string lBLKDNNPACO = "settings.enablehitsoundsinnormal";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[5];
				array[1] = player.GPBFAEIADJD();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GPCPPDDHDAG(player.GCBPLIIAODI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void LOBIGJMOMCD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void DBFBKCFEMDD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void LJIHHJOAJCN()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				LJDMIDDBBPA();
			}
			if (wasPressed && currentTimeout > 1312f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1641f)
			{
				GGHCBIAEBBH();
			}
		}
		else if (hardInput.EBAHBLEMKKC(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.LMENGPDOOJG().ACPGHFHDCIP().isMine)
			{
				PhotonView photonView = player.OBBDJECLANB().OELHGNKAMEG();
				string lBLKDNNPACO = "/";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.GetCombo(), handId, null, null, null, null, null);
			}
			else
			{
				player.GFGHHDOBFEJ(player.BPJOPJPCKDA(), handId, 757f);
			}
		}
	}

	public void DAMCEJEEBCD()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.GENOLDKFAPB().PHCBHAFMDEJ().isMine)
			{
				PhotonView photonView = player.ENNCFNJBJAG().GBMJAPGLMGB();
				string lBLKDNNPACO = "_SunPosition";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.GCBPLIIAODI(), handId, null, null, null, null);
			}
			else
			{
				player.PHDABEGNCON(player.GPBFAEIADJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void CGBHOELMAOC()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				GLHGOGIMHBP();
			}
			if (wasPressed && currentTimeout > 1840f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 240f)
			{
				FHPPMBEEKBL();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.KJHMNOEDBJJ().IJBFILBDGDO().isMine)
			{
				PhotonView photonView = player.GKGCHBJANLF().PHCBHAFMDEJ();
				string lBLKDNNPACO = "settings.selectormapsperpage";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.ALKGJEEHEBN(), handId, null);
			}
			else
			{
				player.AEDJKCPNEOC(player.BHECOHDKMGO(), handId, 656f);
			}
		}
	}

	public void HLDFOJMHKNL()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				LJDMIDDBBPA();
			}
			if (wasPressed && currentTimeout > 1571f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 449f)
			{
				GAOMPMFOJNC();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.playerBase.OELHGNKAMEG().isMine)
			{
				PhotonView photonView = player.DFPMJLHLFNK().GBMJAPGLMGB();
				string lBLKDNNPACO = "PlayersScrollRectContent";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[3];
				array[1] = player.CNLDGEMKLPP();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.PHDABEGNCON(player.GetCombo(), handId, 1769f);
			}
		}
	}

	public void JAAJECBCCFM()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				PFDPNHHKMCN();
			}
			if (wasPressed && currentTimeout > 1899f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 880f)
			{
				Reset();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.GKGCHBJANLF().PHCBHAFMDEJ().isMine)
			{
				PhotonView photonView = player.FBMHDALMKAL().GBMJAPGLMGB();
				string lBLKDNNPACO = "CameraFilterPack/FX_DigitalMatrix";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[1];
				array[1] = player.GPBFAEIADJD();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.GetCombo(), handId, 1408f);
			}
		}
	}

	public void EKPOOJKFJFC()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void KIEJKBNBHMD()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				OFOHOAPHFBD();
			}
			if (wasPressed && currentTimeout > 973f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 108f)
			{
				FPKJJBAENGF();
			}
		}
		else if (hardInput.EBAHBLEMKKC(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.KIPGGHFMKLC().AAMNKPHHHCI().isMine)
			{
				PhotonView photonView = player.KEFGHEIOHON().IFENGKHOKPC();
				string lBLKDNNPACO = "achievements.21.progress";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[2];
				array[0] = player.BHECOHDKMGO();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.JOAEFBPDEJP(player.GetCombo(), handId, 752f);
			}
		}
	}

	public void GGHCBIAEBBH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.GENOLDKFAPB().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = player.PJFCDBLDDHB().IJBFILBDGDO();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.AEDJKCPNEOC(player.FFHJBOCNMMA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void CLMDACAINOA()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void AEIJFLJEABG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				PIPMHJMDHPK();
			}
			if (wasPressed && currentTimeout > 1875f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 794f)
			{
				DAMCEJEEBCD();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NABBDBMIHOI().JDBCGCJJIAF().isMine)
			{
				PhotonView photonView = player.playerBase.EOOCGIFFKBG();
				string lBLKDNNPACO = "_Green_R";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[1];
				array[1] = player.BHECOHDKMGO();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.BHECOHDKMGO(), handId, 1439f);
			}
		}
	}

	public void NNNCKCELBCE()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KEFGHEIOHON().JDBCGCJJIAF().isMine)
			{
				PhotonView photonView = player.HEDFKOIPLEM().BLMHOKPIMOD();
				string lBLKDNNPACO = "CameraFilterPack/3D_Distortion";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = player.KNBOIOEKJID();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.IPFCGDAKPNE(player.FFHJBOCNMMA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void EHCGBJDFMHG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NHJCNJBKDMK(buttonKey))
			{
				OFOHOAPHFBD();
			}
			if (wasPressed && currentTimeout > 1325f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 349f)
			{
				BJIKAHNJNEB();
			}
		}
		else if (hardInput.EBAHBLEMKKC(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.playerBase.GMAHNPNHMFK().isMine)
			{
				PhotonView photonView = player.KIPGGHFMKLC().EOOCGIFFKBG();
				string lBLKDNNPACO = "[MapsData] Workshop maps was loaded";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[6];
				array[1] = player.CNLDGEMKLPP();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.PHDABEGNCON(player.GCBPLIIAODI(), handId, 625f);
			}
		}
	}

	public void MJNPIDGNJMK()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				DBFBKCFEMDD();
			}
			if (wasPressed && currentTimeout > 1579f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 865f)
			{
				GGHCBIAEBBH();
			}
		}
		else if (hardInput.EBAHBLEMKKC(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.PJFCDBLDDHB().ACPGHFHDCIP().isMine)
			{
				PhotonView photonView = player.PJFCDBLDDHB().ACPGHFHDCIP();
				string lBLKDNNPACO = "set";
				PhotonTargets mPNMOONBMII = (PhotonTargets)8;
				object[] array = new object[0];
				array[1] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.KIPNNNAHGDJ(player.GPBFAEIADJD(), handId, 1128f);
			}
		}
	}

	public void OPCLBGHAPMG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				ABDEGHLHHHF();
			}
			if (wasPressed && currentTimeout > 1773f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 735f)
			{
				GAOMPMFOJNC();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.GKGCHBJANLF().PHCBHAFMDEJ().isMine)
			{
				PhotonView photonView = player.GIGCAEODABJ().IFENGKHOKPC();
				string lBLKDNNPACO = " scene: ";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.ALKGJEEHEBN(), handId, null, null, null, null, null);
			}
			else
			{
				player.DMHHPPDONJG(player.ALKGJEEHEBN(), handId, 1281f);
			}
		}
	}

	public void MANOCIJICLG()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ENNCFNJBJAG().NABDKNPNEMM().isMine)
			{
				PhotonView photonView = player.JAGBDKPMBGP().PHCBHAFMDEJ();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = player.CNLDGEMKLPP();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BIGLPCNFMFA(player.FFHJBOCNMMA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void GKFOIOALDFH()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void OFOHOAPHFBD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void HNNDLFBNBBO()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void PHFLEEBHEFN()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void MAOCOEGAFND()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				LOBIGJMOMCD();
			}
			if (wasPressed && currentTimeout > 1004f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 363f)
			{
				OJECBKEMOBH();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DMMGMCGNILI().EDIJKHEMPAD().isMine)
			{
				PhotonView photonView = player.NABBDBMIHOI().GBMJAPGLMGB();
				string lBLKDNNPACO = "menu.selectedplaymode";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBuffered;
				object[] array = new object[4];
				array[0] = player.CNLDGEMKLPP();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BIGLPCNFMFA(player.ALKGJEEHEBN(), handId, 702f);
			}
		}
	}

	public void OnPressed()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void GOFMABPMLKF()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.IFACNHFOOAM().EOOCGIFFKBG().isMine)
			{
				PhotonView photonView = player.FDKFJLHFNMK().IFENGKHOKPC();
				string lBLKDNNPACO = "settings.enablehitsoundsinnormal";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[1];
				array[1] = player.GetCombo();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.PHDABEGNCON(player.BPJOPJPCKDA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void BMODOIJGIOO()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				OnPressed();
			}
			if (wasPressed && currentTimeout > 149f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1380f)
			{
				KHGOJDPMPML();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.LMENGPDOOJG().IFENGKHOKPC().isMine)
			{
				PhotonView photonView = player.OBBDJECLANB().GBMJAPGLMGB();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				object[] array = new object[5];
				array[0] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CNHOOPMOBPG(player.CNLDGEMKLPP(), handId, 902f);
			}
		}
	}

	public PlayerControllerKeyHandler(PlayerController.Direction LPIMAGMABLC, string CIMJCIDACFJ, int PGJECADBIOI, PlayerController JHOEDACNNKK)
	{
		attime = 0f;
		wasPressed = false;
		direction = LPIMAGMABLC;
		buttonKey = CIMJCIDACFJ;
		player = JHOEDACNNKK;
		handId = PGJECADBIOI;
		currentTimeout = 0f;
	}

	public void PIPMHJMDHPK()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void KHGOJDPMPML()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.NJODHOMKIED().EOOCGIFFKBG().isMine)
			{
				PhotonView photonView = player.KIPGGHFMKLC().JAEJDHHCJJO();
				string lBLKDNNPACO = "[PlayerBase] Delete checkpoint data";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = player.GCBPLIIAODI();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GPCPPDDHDAG(player.FFHJBOCNMMA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void PMLPJADKFMG()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ENNCFNJBJAG().PHCBHAFMDEJ().isMine)
			{
				PhotonView photonView = player.JDFCILGMEOJ().PHCBHAFMDEJ();
				string lBLKDNNPACO = "Set sun audio input";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[5];
				array[1] = player.GPBFAEIADJD();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.JOAEFBPDEJP(player.GPBFAEIADJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void HKJJMPCFEPL()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void JOACBIEHHCE()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				PFDPNHHKMCN();
			}
			if (wasPressed && currentTimeout > 1449f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 855f)
			{
				MANOCIJICLG();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NJODHOMKIED().CIACEFBNDDJ().isMine)
			{
				PhotonView photonView = player.KIPGGHFMKLC().EDIJKHEMPAD();
				string lBLKDNNPACO = "/";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				object[] array = new object[1];
				array[0] = player.GetCombo();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.IPFCGDAKPNE(player.CNLDGEMKLPP(), handId, 970f);
			}
		}
	}

	public void KMHCLFLINIO()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DPJHDOFBJLE().CIACEFBNDDJ().isMine)
			{
				PhotonView photonView = player.IFACNHFOOAM().OELHGNKAMEG();
				string lBLKDNNPACO = " (now: ";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[2]
				{
					null,
					player.GetCombo()
				};
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.CNLDGEMKLPP(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void LJDMIDDBBPA()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void ILFEAADGHEO()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void LDGJGONCEND()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DPJHDOFBJLE().JIOCGDBKGIL().isMine)
			{
				PhotonView photonView = player.OBBDJECLANB().IBKCMBIGOEJ();
				string lBLKDNNPACO = "menutheme.deleted";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = player.CNLDGEMKLPP();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GCPKNBBPAHJ(player.KNBOIOEKJID(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void KNNOEGLLDAN()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.GKGCHBJANLF().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = player.FDKFJLHFNMK().photonView;
				string lBLKDNNPACO = "CameraFilterPack/Oculus_ThermaVision";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[6];
				array[1] = player.CNLDGEMKLPP();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.JOAEFBPDEJP(player.BPJOPJPCKDA(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void NCPAFCKGJEA()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NHJCNJBKDMK(buttonKey))
			{
				BPJBFPOMCGB();
			}
			if (wasPressed && currentTimeout > 1757f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1625f)
			{
				JEKEBJCHOHO();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DFPMJLHLFNK().PHCBHAFMDEJ().isMine)
			{
				PhotonView photonView = player.FDKFJLHFNMK().PHCBHAFMDEJ();
				string lBLKDNNPACO = "_Value2";
				PhotonTargets mPNMOONBMII = (PhotonTargets)8;
				object[] array = new object[1];
				array[1] = player.GPBFAEIADJD();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.PHDABEGNCON(player.GPBFAEIADJD(), handId, 1648f);
			}
		}
	}

	public void BJHJCGJACEA()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.IDJIIFOLKMG().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = player.JDFCILGMEOJ().JDBCGCJJIAF();
				string lBLKDNNPACO = "Run a command for the Localization Servise";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[6];
				array[1] = player.GCBPLIIAODI();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DMHHPPDONJG(player.KNBOIOEKJID(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void LIMBEFBJNPL()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.EICAMMJELIE().AAMNKPHHHCI().isMine)
			{
				PhotonView photonView = player.GENOLDKFAPB().BLMHOKPIMOD();
				string lBLKDNNPACO = "PlayButton";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[0] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CNHOOPMOBPG(player.GPBFAEIADJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void MJINNGLCFDC()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void NKLIHNJCHOG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				BPJBFPOMCGB();
			}
			if (wasPressed && currentTimeout > 267f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1830f)
			{
				ABDHDGNIHHI();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.GIGCAEODABJ().GBMJAPGLMGB().isMine)
			{
				PhotonView photonView = player.MEBPHCDCLCC().IFENGKHOKPC();
				string lBLKDNNPACO = "From {0} at Index {1} \n";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[2];
				array[0] = player.FFHJBOCNMMA();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CNHOOPMOBPG(player.KNBOIOEKJID(), handId, 1839f);
			}
		}
	}

	public void BBBNLHALLBN()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.FDKFJLHFNMK().EDIJKHEMPAD().isMine)
			{
				PhotonView photonView = player.IFACNHFOOAM().JIOCGDBKGIL();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[7];
				array[1] = player.BHECOHDKMGO();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BIGLPCNFMFA(player.GCBPLIIAODI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void IJFMKNEPKEJ()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.PJFCDBLDDHB().OELHGNKAMEG().isMine)
			{
				PhotonView photonView = player.ENNCFNJBJAG().JDBCGCJJIAF();
				string lBLKDNNPACO = "[ImageLoader] Loaded image from ";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[8];
				array[0] = player.BHECOHDKMGO();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.JOAEFBPDEJP(player.ALKGJEEHEBN(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void JBNPEHMDCMI()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				JKOEOMPDFDI();
			}
			if (wasPressed && currentTimeout > 1902f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1717f)
			{
				BJIKAHNJNEB();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.OBBDJECLANB().FFIPLLNKGEN().isMine)
			{
				PhotonView photonView = player.DFPMJLHLFNK().BLMHOKPIMOD();
				string lBLKDNNPACO = "_Vignette";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[1];
				array[1] = player.KNBOIOEKJID();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GCPKNBBPAHJ(player.FFHJBOCNMMA(), handId, 706f);
			}
		}
	}

	public void LPMINJJPDCH()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				OFOHOAPHFBD();
			}
			if (wasPressed && currentTimeout > 1052f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1016f)
			{
				Reset();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DFPMJLHLFNK().GMAHNPNHMFK().isMine)
			{
				PhotonView photonView = player.JHEFABODNPO().EDIJKHEMPAD();
				string lBLKDNNPACO = ".completed";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBuffered;
				object[] array = new object[6];
				array[1] = player.GCBPLIIAODI();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.KNBOIOEKJID(), handId, 738f);
			}
		}
	}

	public void GOANPHDJCLL()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void BJIKAHNJNEB()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.JDFCILGMEOJ().IJBFILBDGDO().isMine)
			{
				PhotonView photonView = player.EICAMMJELIE().BLMHOKPIMOD();
				string lBLKDNNPACO = "Tab2Content";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.GCBPLIIAODI(), handId, null, null, null, null, null, null);
			}
			else
			{
				player.POFBCEKBIDH(player.GCBPLIIAODI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void HNGCMCGOECM()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void Update()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				OnPressed();
			}
			if (wasPressed && currentTimeout > 0f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 0f)
			{
				Reset();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.playerBase.photonView.isMine)
			{
				player.playerBase.photonView.RPC("CheckCombo", PhotonTargets.AllBuffered, player.GetCombo(), handId);
			}
			else
			{
				player.CheckCombo(player.GetCombo(), handId);
			}
		}
	}

	public void DEJLOIGKEKO()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void KMEFHCDNDNF()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KIPGGHFMKLC().FFIPLLNKGEN().isMine)
			{
				PhotonView photonView = player.KJHMNOEDBJJ().BBGIDKNEGHD();
				string lBLKDNNPACO = "_MainTex2";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.GCBPLIIAODI(), handId, null, null, null, null, null);
			}
			else
			{
				player.AEDJKCPNEOC(player.GetCombo(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void GAOMPMFOJNC()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ENNCFNJBJAG().GBHNDHLAJLI().isMine)
			{
				PhotonView photonView = player.JFINMCMCFIL().AAMNKPHHHCI();
				string lBLKDNNPACO = "#tryagain";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = player.CNLDGEMKLPP();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.AEDJKCPNEOC(player.GetCombo(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void FOMNCPKKCFN()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.EBAHBLEMKKC(buttonKey))
			{
				DBFBKCFEMDD();
			}
			if (wasPressed && currentTimeout > 1844f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 498f)
			{
				KMHCLFLINIO();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.HEDFKOIPLEM().JDBCGCJJIAF().isMine)
			{
				PhotonView photonView = player.NJODHOMKIED().BLMHOKPIMOD();
				string lBLKDNNPACO = "HightScoreMaxPointsText";
				PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
				object[] array = new object[3];
				array[0] = player.GPBFAEIADJD();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.KNBOIOEKJID(), handId, 11f);
			}
		}
	}

	public void LCJHDLKJEOM()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				DBFBKCFEMDD();
			}
			if (wasPressed && currentTimeout > 323f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1682f)
			{
				FPKJJBAENGF();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.GKGCHBJANLF().GMAHNPNHMFK().isMine)
			{
				PhotonView photonView = player.KEFGHEIOHON().NABDKNPNEMM();
				string lBLKDNNPACO = "_Green_R";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[5];
				array[1] = player.CNLDGEMKLPP();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.IPFCGDAKPNE(player.BHECOHDKMGO(), handId, 1916f);
			}
		}
	}

	public void OCMKCBBCEFG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				ILFEAADGHEO();
			}
			if (wasPressed && currentTimeout > 1747f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 434f)
			{
				PMLPJADKFMG();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NJODHOMKIED().AAMNKPHHHCI().isMine)
			{
				PhotonView photonView = player.NABBDBMIHOI().BBGIDKNEGHD();
				string lBLKDNNPACO = "bpmgrid";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[1];
				array[1] = player.BHECOHDKMGO();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BIGLPCNFMFA(player.CNLDGEMKLPP(), handId, 201f);
			}
		}
	}

	public void PFDPNHHKMCN()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void EOGGMDHKKDB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void FPKJJBAENGF()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.MEBPHCDCLCC().BBGIDKNEGHD().isMine)
			{
				PhotonView photonView = player.IDJIIFOLKMG().GBMJAPGLMGB();
				string lBLKDNNPACO = "_Value";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[1];
				array[1] = player.ALKGJEEHEBN();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.POFBCEKBIDH(player.BHECOHDKMGO(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void OIBMHPIFAKK()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NHJCNJBKDMK(buttonKey))
			{
				LOBIGJMOMCD();
			}
			if (wasPressed && currentTimeout > 675f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 896f)
			{
				KHGOJDPMPML();
			}
		}
		else if (hardInput.NHJCNJBKDMK(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.ENNCFNJBJAG().JAEJDHHCJJO().isMine)
			{
				player.DMMGMCGNILI().NABDKNPNEMM().RPC("_Value2", PhotonTargets.AllBufferedViaServer, player.ALKGJEEHEBN(), handId);
			}
			else
			{
				player.CheckCombo(player.BHECOHDKMGO(), handId, 1865f);
			}
		}
	}

	public void GLHGOGIMHBP()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void JKOEOMPDFDI()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void IJHGPCAHDEH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ENNCFNJBJAG().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = player.GENOLDKFAPB().GBHNDHLAJLI();
				string lBLKDNNPACO = "SetSatelliteInput";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[1] { player.CNLDGEMKLPP() };
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GCPKNBBPAHJ(player.GCBPLIIAODI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void BPJBFPOMCGB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}
}
