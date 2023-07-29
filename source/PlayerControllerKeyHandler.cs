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

	public void IJHGPCAHDEH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.NLIGEMDBEOA().JAEJDHHCJJO().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JHEFABODNPO().CIACEFBNDDJ();
				string lBLKDNNPACO = "_Value2";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = player.GBLDJPCFLPC();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.AIFIMLBHNOM(player.PDKJFCMEIEE(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void IDOFOCOFEIE()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DFLDMFKFBPC().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = player.NODPGAOEHGL().GBHNDHLAJLI();
				string lBLKDNNPACO = "Populate Mesh Data";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[7];
				array[0] = player.BODCFCGDMDA();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NLPAHKLGJMK(player.FPFBFHALAJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void MJINNGLCFDC()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
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

	public void HGDELHLBLJI()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void BJKJEJJOPLC()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KEFGHEIOHON().photonView.KCAOJFPDEIP())
			{
				PhotonView photonView = player.DMFKOAIAHDC().EOOCGIFFKBG();
				string lBLKDNNPACO = "CameraFilterPack/Color_Chromatic_Aberration";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[2];
				array[0] = player.GetCombo();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NLPAHKLGJMK(player.PDKJFCMEIEE(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void LIMBEFBJNPL()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KEFGHEIOHON().AAMNKPHHHCI().KCAOJFPDEIP())
			{
				PhotonView photonView = player.KEFGHEIOHON().JAEJDHHCJJO();
				string lBLKDNNPACO = "[Left]";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = player.JPDMLANDOOI();
				array[0] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.AIFIMLBHNOM(player.HFKKBJFPABL(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void OIBMHPIFAKK()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				GOANPHDJCLL();
			}
			if (wasPressed && currentTimeout > 540f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1230f)
			{
				BJIKAHNJNEB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NFANBIICAFM().AAMNKPHHHCI().isMine)
			{
				PhotonView photonView = player.JHEFABODNPO().IBKCMBIGOEJ();
				string lBLKDNNPACO = "CameraFilterPack_Atmosphere_Rain_FX";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = player.GetCombo();
				array[0] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.KNBOIOEKJID(), handId, 1953f);
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

	public void FPKJJBAENGF()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DFLDMFKFBPC().ACPGHFHDCIP().DOLKFPIABDD())
			{
				PhotonView photonView = player.JJPEGCHJJED().BLMHOKPIMOD();
				string lBLKDNNPACO = "action";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[8];
				array[0] = player.ALKGJEEHEBN();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.HPBPJKFHMCD(player.GetCombo(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void EMKKGIEFKML()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.NLIGEMDBEOA().EOOCGIFFKBG().isMine)
			{
				PhotonView photonView = player.NODPGAOEHGL().BLMHOKPIMOD();
				string lBLKDNNPACO = "Uploading preview image...";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[1];
				array[0] = player.FPFBFHALAJD();
				array[1] = handId;
				photonView.MIAHMDGOOPJ(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GIGMGMDAJOG(player.KNBOIOEKJID(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void BPIGKCAHDGG()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void OGKGIAAACAD()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.PELOCGBHJFO().GMAHNPNHMFK().isMine)
			{
				PhotonView photonView = player.NLIGEMDBEOA().GBMJAPGLMGB();
				string lBLKDNNPACO = "Turn";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = player.JPDMLANDOOI();
				array[1] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.HPBPJKFHMCD(player.ALKGJEEHEBN(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void LMBDNPLDGIJ()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				CLMDACAINOA();
			}
			if (wasPressed && currentTimeout > 1354f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1817f)
			{
				PMLPJADKFMG();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.HBDLLAKOFKJ().CIACEFBNDDJ().DOLKFPIABDD())
			{
				PhotonView photonView = player.DGNIAONOGKK().IBKCMBIGOEJ();
				string lBLKDNNPACO = "_CurTex";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = player.JPDMLANDOOI();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.KNBOIOEKJID(), handId, 1893f);
			}
		}
	}

	public void NKLIHNJCHOG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.CHAJOGCCKDA(buttonKey))
			{
				MAJBGPMBOKB();
			}
			if (wasPressed && currentTimeout > 1623f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 156f)
			{
				IDOFOCOFEIE();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JJPEGCHJJED().EDIJKHEMPAD().DOLKFPIABDD())
			{
				PhotonView photonView = player.PELOCGBHJFO().JAEJDHHCJJO();
				string lBLKDNNPACO = "_Value";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = player.ALKGJEEHEBN();
				array[1] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GIGMGMDAJOG(player.PDKJFCMEIEE(), handId, 1913f);
			}
		}
	}

	public void BBBNLHALLBN()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.JJPEGCHJJED().OELHGNKAMEG().DOLKFPIABDD())
			{
				PhotonView photonView = player.NLIGEMDBEOA().IBKCMBIGOEJ();
				string lBLKDNNPACO = "_TimeX";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[5];
				array[1] = player.GetCombo();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BHMNLMFCJLE(player.ALKGJEEHEBN(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void FJHFOBHJEHL()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				CLMDACAINOA();
			}
			if (wasPressed && currentTimeout > 1870f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 420f)
			{
				LIMBEFBJNPL();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DGNIAONOGKK().JAEJDHHCJJO().DOLKFPIABDD())
			{
				PhotonView photonView = player.NLIGEMDBEOA().EOOCGIFFKBG();
				string lBLKDNNPACO = "_AccumOrig";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				object[] array = new object[2];
				array[0] = player.MHMBDPMDDAC();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.GBLDJPCFLPC(), handId, 1802f);
			}
		}
	}

	public void CKCPHFLOLAH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DMFKOAIAHDC().EOOCGIFFKBG().DOLKFPIABDD())
			{
				PhotonView photonView = player.JJPEGCHJJED().CIACEFBNDDJ();
				string lBLKDNNPACO = "_Parameter";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[3];
				array[0] = player.HFKKBJFPABL();
				array[0] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DPOCLHCABII(player.GBLDJPCFLPC(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void LCJHDLKJEOM()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				IPEGECAHFCD();
			}
			if (wasPressed && currentTimeout > 1750f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 720f)
			{
				HFFAJNCOJNB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.playerBase.GMAHNPNHMFK().KCAOJFPDEIP())
			{
				PhotonView photonView = player.DGNIAONOGKK().AAMNKPHHHCI();
				string lBLKDNNPACO = "CameraFilterPack/Distortion_Wave_Horizontal";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, new object[4]
				{
					player.GetCombo(),
					handId,
					null,
					null
				});
			}
			else
			{
				player.PPJDDKHHDMP(player.JPDMLANDOOI(), handId, 1737f);
			}
		}
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

	public void CPGAFFIOGCH()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.playerBase.ACPGHFHDCIP().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JJPEGCHJJED().GBMJAPGLMGB();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = player.GetCombo();
				array[1] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NLPAHKLGJMK(player.HFKKBJFPABL(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void AEIJFLJEABG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.CHAJOGCCKDA(buttonKey))
			{
				EJBLHPIOAJF();
			}
			if (wasPressed && currentTimeout > 951f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1953f)
			{
				IJHGPCAHDEH();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.CCBCAICCJLD().CIACEFBNDDJ().KCAOJFPDEIP())
			{
				PhotonView photonView = player.HBDLLAKOFKJ().CIACEFBNDDJ();
				string lBLKDNNPACO = "PopulateMapsList";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = player.ALKGJEEHEBN();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.POFBCEKBIDH(player.ALKGJEEHEBN(), handId, 682f);
			}
		}
	}

	public void MDIDEHPCJBD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void LNLEHBBCGLM()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void ABDEGHLHHHF()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void KFACDBHDAOD()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				KIBLMKAKPOB();
			}
			if (wasPressed && currentTimeout > 1601f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 364f)
			{
				OGKGIAAACAD();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DMFKOAIAHDC().JAEJDHHCJJO().BGJKMGJBPFA())
			{
				PhotonView photonView = player.DFLDMFKFBPC().photonView;
				string lBLKDNNPACO = "_CenterX";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBuffered;
				object[] array = new object[3];
				array[1] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DPOCLHCABII(player.KNBOIOEKJID(), handId, 1952f);
			}
		}
	}

	public void AJAAPDBCKPP()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void CFOOCBMIFGA()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
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

	public void GANNKLPODAD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void OFGMLJJEDMM()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void EGFBPCMCNDJ()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.NLIGEMDBEOA().IBKCMBIGOEJ().BGJKMGJBPFA())
			{
				PhotonView photonView = player.JJPEGCHJJED().CIACEFBNDDJ();
				string lBLKDNNPACO = "settings_bindings_";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[7];
				array[1] = player.MHMBDPMDDAC();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CONKAILPANP(player.MHMBDPMDDAC(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void ENAANLLCMPK()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void GAOMPMFOJNC()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.EICAMMJELIE().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = player.NLIGEMDBEOA().JAEJDHHCJJO();
				string lBLKDNNPACO = "_WaveIntensity";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[2];
				array[0] = player.MHMBDPMDDAC();
				array[0] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.AEDJKCPNEOC(player.HFKKBJFPABL(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void HFFAJNCOJNB()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DGNIAONOGKK().GBMJAPGLMGB().BGJKMGJBPFA())
			{
				PhotonView photonView = player.DMFKOAIAHDC().GBMJAPGLMGB();
				string lBLKDNNPACO = "_ChangeBlue";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = player.HFKKBJFPABL();
				array[1] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NBMHHGHIHDJ(player.ALKGJEEHEBN(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void KIBLMKAKPOB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void GOFMABPMLKF()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.JHEFABODNPO().ACPGHFHDCIP().DOLKFPIABDD())
			{
				PhotonView photonView = player.PELOCGBHJFO().FFIPLLNKGEN();
				string lBLKDNNPACO = "solo";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = player.FPFBFHALAJD();
				array[1] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.OGACJDOPABH(player.GBLDJPCFLPC(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void JHPOIOELNCG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				KIBLMKAKPOB();
			}
			if (wasPressed && currentTimeout > 1544f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 334f)
			{
				Reset();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.CCBCAICCJLD().BLMHOKPIMOD().DOLKFPIABDD())
			{
				PhotonView photonView = player.NFANBIICAFM().photonView;
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.PDKJFCMEIEE(), handId, null, null, null, null, null, null);
			}
			else
			{
				player.OGACJDOPABH(player.HFKKBJFPABL(), handId, 428f);
			}
		}
	}

	public void IPEGECAHFCD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void CLMDACAINOA()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void MAOCOEGAFND()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				GHGNCNDBHCG();
			}
			if (wasPressed && currentTimeout > 1268f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 45f)
			{
				JEKEBJCHOHO();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JJPEGCHJJED().FFIPLLNKGEN().DOLKFPIABDD())
			{
				PhotonView photonView = player.HBDLLAKOFKJ().BLMHOKPIMOD();
				string lBLKDNNPACO = "_Value2";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = player.GBLDJPCFLPC();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.MHMBDPMDDAC(), handId, 1284f);
			}
		}
	}

	public void IDIIELPAMCJ()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.GetKeyDown(buttonKey))
			{
				JDDCECNFJAB();
			}
			if (wasPressed && currentTimeout > 1685f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 134f)
			{
				NNNCKCELBCE();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NFANBIICAFM().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = player.NODPGAOEHGL().photonView;
				string lBLKDNNPACO = "_MainTex2";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[1];
				array[1] = player.ALKGJEEHEBN();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.DJLACMJODFF(), handId, 501f);
			}
		}
	}

	public void PMLPJADKFMG()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KEFGHEIOHON().GMAHNPNHMFK().DOLKFPIABDD())
			{
				PhotonView photonView = player.DNOKKLIKLAM().GMAHNPNHMFK();
				string lBLKDNNPACO = "' was created: ";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[3];
				array[1] = player.MHMBDPMDDAC();
				array[1] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NBMHHGHIHDJ(player.KNBOIOEKJID(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
	}

	public void EJBLHPIOAJF()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void GLHGOGIMHBP()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void IAPOBEGCHLG()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.ODHBANOIMPN().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JHEFABODNPO().AAMNKPHHHCI();
				string lBLKDNNPACO = "Editor";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = player.GetCombo();
				array[0] = handId;
				photonView.MIAHMDGOOPJ(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.HPBPJKFHMCD(player.JPDMLANDOOI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void MFMIODIAKNI()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				ENAANLLCMPK();
			}
			if (wasPressed && currentTimeout > 715f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1717f)
			{
				Reset();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JHEFABODNPO().OELHGNKAMEG().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JHEFABODNPO().EOOCGIFFKBG();
				string lBLKDNNPACO = "_Value3";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[0] = player.PDKJFCMEIEE();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.POFBCEKBIDH(player.KNBOIOEKJID(), handId, 183f);
			}
		}
	}

	public void BJIKAHNJNEB()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.KEFGHEIOHON().EOOCGIFFKBG().KCAOJFPDEIP())
			{
				PhotonView photonView = player.DGNIAONOGKK().EDIJKHEMPAD();
				string lBLKDNNPACO = "CameraFilterPack_Fly_VisionFX";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = player.BODCFCGDMDA();
				array[0] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.GBLDJPCFLPC(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = true;
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

	public void KMEONPMCNJG()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				BPIGKCAHDGG();
			}
			if (wasPressed && currentTimeout > 1262f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 690f)
			{
				GOFMABPMLKF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DGNIAONOGKK().FFIPLLNKGEN().DOLKFPIABDD())
			{
				PhotonView photonView = player.EICAMMJELIE().EOOCGIFFKBG();
				string lBLKDNNPACO = "id";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[6];
				array[1] = player.DJLACMJODFF();
				array[0] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CONKAILPANP(player.ALKGJEEHEBN(), handId, 260f);
			}
		}
	}

	public void NCPAFCKGJEA()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				ENAANLLCMPK();
			}
			if (wasPressed && currentTimeout > 1860f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1225f)
			{
				DABMBPBGPPI();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JHEFABODNPO().EDIJKHEMPAD().BGJKMGJBPFA())
			{
				PhotonView photonView = player.DMFKOAIAHDC().BLMHOKPIMOD();
				string lBLKDNNPACO = "Failed to 'GetKeyCode' for key: ";
				PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
				object[] array = new object[4];
				array[1] = player.FPFBFHALAJD();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DBKJHNBJBKK(player.KNBOIOEKJID(), handId, 1596f);
			}
		}
	}

	public void HLDFOJMHKNL()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				KIBLMKAKPOB();
			}
			if (wasPressed && currentTimeout > 1292f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1231f)
			{
				GAOMPMFOJNC();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.PELOCGBHJFO().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JHEFABODNPO().photonView;
				string lBLKDNNPACO = "No valid adaptive tonemapper type found!";
				PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, player.ALKGJEEHEBN(), handId, null, null, null, null, null, null);
			}
			else
			{
				player.OGACJDOPABH(player.KNBOIOEKJID(), handId, 1389f);
			}
		}
	}

	public void LLJLDLLNFBH()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				FFEJFNEFNFD();
			}
			if (wasPressed && currentTimeout > 386f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 212f)
			{
				BJKJEJJOPLC();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JHEFABODNPO().JAEJDHHCJJO().DOLKFPIABDD())
			{
				PhotonView photonView = player.PELOCGBHJFO().ACPGHFHDCIP();
				string lBLKDNNPACO = "Preparing configuration...";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllBuffered;
				object[] array = new object[6];
				array[0] = player.GetCombo();
				array[0] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.HPBPJKFHMCD(player.BODCFCGDMDA(), handId, 1517f);
			}
		}
	}

	public void KCDOMIJBFLL()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				BPIGKCAHDGG();
			}
			if (wasPressed && currentTimeout > 1147f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 171f)
			{
				IJHGPCAHDEH();
			}
		}
		else if (hardInput.GetKeyDown(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.playerBase.EOOCGIFFKBG().BGJKMGJBPFA())
			{
				PhotonView photonView = player.playerBase.BLMHOKPIMOD();
				string lBLKDNNPACO = "OnDeserialize";
				PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
				object[] array = new object[5];
				array[1] = player.FPFBFHALAJD();
				array[1] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.CheckCombo(player.KNBOIOEKJID(), handId, 1198f);
			}
		}
	}

	public void GPFJMKCGHGB()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				CFOOCBMIFGA();
			}
			if (wasPressed && currentTimeout > 1287f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 195f)
			{
				FPKJJBAENGF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DNOKKLIKLAM().EOOCGIFFKBG().DOLKFPIABDD())
			{
				PhotonView photonView = player.NFANBIICAFM().CIACEFBNDDJ();
				string lBLKDNNPACO = "PAUSE [SPACE]";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[1];
				array[0] = player.BODCFCGDMDA();
				array[1] = handId;
				photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.OGACJDOPABH(player.HFKKBJFPABL(), handId, 1948f);
			}
		}
	}

	public void IEMEHGCFAPD()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.CHAJOGCCKDA(buttonKey))
			{
				JDDCECNFJAB();
			}
			if (wasPressed && currentTimeout > 622f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1830f)
			{
				EGFBPCMCNDJ();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DGNIAONOGKK().EOOCGIFFKBG().KCAOJFPDEIP())
			{
				PhotonView photonView = player.DGNIAONOGKK().AAMNKPHHHCI();
				string lBLKDNNPACO = "VeryHigh";
				PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
				object[] array = new object[6];
				array[1] = player.GetCombo();
				array[1] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.POFBCEKBIDH(player.PDKJFCMEIEE(), handId, 1066f);
			}
		}
	}

	public void NNNCKCELBCE()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.PELOCGBHJFO().IBKCMBIGOEJ().isMine)
			{
				PhotonView photonView = player.NLIGEMDBEOA().BLMHOKPIMOD();
				string lBLKDNNPACO = "JoinButton";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[8];
				array[1] = player.PDKJFCMEIEE();
				array[1] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BHMNLMFCJLE(player.FPFBFHALAJD(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void MAJBGPMBOKB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void DEDANNMJNOC()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DNOKKLIKLAM().CIACEFBNDDJ().DOLKFPIABDD())
			{
				PhotonView photonView = player.CCBCAICCJLD().EDIJKHEMPAD();
				string lBLKDNNPACO = "inventory.selected.";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[2]
				{
					null,
					player.DJLACMJODFF()
				};
				array[1] = handId;
				photonView.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.GIGMGMDAJOG(player.MHMBDPMDDAC(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void LJIHHJOAJCN()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.AADFFLGEJPP(buttonKey))
			{
				EJBLHPIOAJF();
			}
			if (wasPressed && currentTimeout > 73f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 52f)
			{
				GOFMABPMLKF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.DMFKOAIAHDC().OELHGNKAMEG().KCAOJFPDEIP())
			{
				PhotonView photonView = player.JJPEGCHJJED().OELHGNKAMEG();
				string lBLKDNNPACO = "_Value3";
				PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, new object[4]
				{
					player.JPDMLANDOOI(),
					handId,
					null,
					null
				});
			}
			else
			{
				player.CheckCombo(player.DJLACMJODFF(), handId, 850f);
			}
		}
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

	public void DABMBPBGPPI()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.DNOKKLIKLAM().JAEJDHHCJJO().BGJKMGJBPFA())
			{
				PhotonView photonView = player.DFLDMFKFBPC().GBMJAPGLMGB();
				string lBLKDNNPACO = "SingleplayerButton";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = player.MHMBDPMDDAC();
				array[0] = handId;
				photonView.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DPOCLHCABII(player.JPDMLANDOOI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void EKPOOJKFJFC()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void GHGNCNDBHCG()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = false;
	}

	public void KMKLDAJLCNM()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				MAJBGPMBOKB();
			}
			if (wasPressed && currentTimeout > 1411f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 9f)
			{
				Reset();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.CCBCAICCJLD().GBHNDHLAJLI().DOLKFPIABDD())
			{
				PhotonView photonView = player.NFANBIICAFM().ACPGHFHDCIP();
				string lBLKDNNPACO = "_ScreenResolution";
				PhotonTargets mPNMOONBMII = (PhotonTargets)7;
				object[] array = new object[3];
				array[1] = player.MHMBDPMDDAC();
				array[1] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.DBKJHNBJBKK(player.PDKJFCMEIEE(), handId, 1934f);
			}
		}
	}

	public void FFEJFNEFNFD()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}

	public void BPJBFPOMCGB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
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

	public void JEKEBJCHOHO()
	{
		if (wasPressed)
		{
			if (!player.isRecording && player.JHEFABODNPO().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = player.JJPEGCHJJED().EDIJKHEMPAD();
				string lBLKDNNPACO = "_TimeX";
				PhotonTargets mPNMOONBMII = PhotonTargets.All;
				object[] array = new object[4];
				array[0] = player.KNBOIOEKJID();
				array[0] = handId;
				photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.BHMNLMFCJLE(player.JPDMLANDOOI(), handId, attime);
			}
		}
		player.currentCombo.Clear();
		wasPressed = false;
	}

	public void JNBPKNNBMDI()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.CHAJOGCCKDA(buttonKey))
			{
				OFOHOAPHFBD();
			}
			if (wasPressed && currentTimeout > 1810f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 105f)
			{
				HFFAJNCOJNB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.JJPEGCHJJED().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = player.HBDLLAKOFKJ().BLMHOKPIMOD();
				string lBLKDNNPACO = "SetTrailZoomSpeed";
				PhotonTargets mPNMOONBMII = PhotonTargets.Others;
				object[] array = new object[2]
				{
					null,
					player.DJLACMJODFF()
				};
				array[0] = handId;
				photonView.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.NLPAHKLGJMK(player.GBLDJPCFLPC(), handId, 356f);
			}
		}
	}

	public void DPIPGGDNGHN()
	{
		if (player.useComboSystem)
		{
			if (!wasPressed && hardInput.NGFFMGKPMNP(buttonKey))
			{
				MAJBGPMBOKB();
			}
			if (wasPressed && currentTimeout > 1904f)
			{
				currentTimeout -= Time.deltaTime;
			}
			if (wasPressed && currentTimeout <= 1504f)
			{
				NNNCKCELBCE();
			}
		}
		else if (hardInput.CHAJOGCCKDA(buttonKey))
		{
			player.currentCombo.Add(direction);
			if (!player.isRecording && player.NLIGEMDBEOA().AAMNKPHHHCI().KCAOJFPDEIP())
			{
				PhotonView photonView = player.PELOCGBHJFO().OELHGNKAMEG();
				string lBLKDNNPACO = " : ";
				PhotonTargets mPNMOONBMII = (PhotonTargets)8;
				object[] array = new object[3];
				array[0] = player.GetCombo();
				array[0] = handId;
				photonView.MIAHMDGOOPJ(lBLKDNNPACO, mPNMOONBMII, array);
			}
			else
			{
				player.LNAOENCHKGI(player.FPFBFHALAJD(), handId, 562f);
			}
		}
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

	public void JDDCECNFJAB()
	{
		if (player.useComboSystem)
		{
			attime = Singleton<MapEditor>.Instance.currentTime;
			currentTimeout = player.currentComboTimeout;
		}
		player.currentCombo.Add(direction);
		wasPressed = true;
	}
}
