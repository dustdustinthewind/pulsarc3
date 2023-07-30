// InRoomTime
using System.Collections;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomTime : MonoBehaviour
{
	private int LOMGHAIPHJK;

	private const string JJDHAIONGKL = "#rt";

	public double RoomTime
	{
		get
		{
			uint roomTimestamp = (uint)RoomTimestamp;
			double num = roomTimestamp;
			return num / 1000.0;
		}
	}

	public int RoomTimestamp => PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;

	public bool IsRoomTimeSet => PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("#rt");

	public void MBNAOLLEFBE(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Level"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["Tab2Content"];
		}
	}

	public void EEKBPIMIOAF()
	{
		StartCoroutine("CameraFilterPack/Oculus_NightVision1");
	}

	public void OnJoinedRoom()
	{
		StartCoroutine("CAMFLJLDDPH");
	}

	public void ANLLMELCMMM(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("AddEnvironmentObject");
	}

	public void OOAEIEDDIGM(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("bpmgrid"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["HIDE CONFIG [Ctrl+E]"];
		}
	}

	[SpecialName]
	public bool MLKJMLHIFNJ()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.DMANNHAPJCP().ContainsKey("-1");
	}

	internal IEnumerator ELGLCPPPMJI()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int EKNPEFIGAKG()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public bool LKKPMCBBIOA()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.DMANNHAPJCP().ContainsKey("LeaderboardsButton");
	}

	public void CJOEIPNDONJ(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("Player");
	}

	public void IMNLBGHLDGI()
	{
		StartCoroutine(" Gb");
	}

	[SpecialName]
	public bool PPIEOBDMMOL()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.customProperties.ContainsKey(": ");
	}

	[SpecialName]
	public bool KBKOLEDIPED()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("InventoryButton");
	}

	public void BDMDBCOMELA()
	{
		StartCoroutine("maps.");
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("CAMFLJLDDPH");
	}

	public void JEONBFLDFGI()
	{
		StartCoroutine("Please attach component to a Graphical UI component");
	}

	[SpecialName]
	public bool NGGKBKIPILO()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("Could not execute RPC ");
	}

	public void AFGMHKGMCCE()
	{
		StartCoroutine("Left Stick Click");
	}

	public void EHBNOOGBJNK(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("CameraFilterPack_RainFX_Anm");
	}

	public void OABEHFCGGKH(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("In Map Editor");
	}

	[SpecialName]
	public int DBJFPLMNDBB()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public double BPICAFLGFPB()
	{
		uint num = (uint)EKNPEFIGAKG();
		double num2 = num;
		return num2 / 657.0;
	}

	public void FHPAKJEHGJC(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Curve"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["skin."];
		}
	}

	[SpecialName]
	public double DBFBGMBEELC()
	{
		uint num = (uint)EKNPEFIGAKG();
		double num2 = num;
		return num2 / 741.0;
	}

	[SpecialName]
	public bool DOOJCMEANPI()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.customProperties.ContainsKey("mapselector.filter.favoriteonly");
	}

	public void KIHNMOGGBGK(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[#clicktoacceptchallenge]"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["Mouse Wheel Down"];
		}
	}

	internal IEnumerator JBKJHKGLNGK()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int DPCIGLHHBPG()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	public void JHCDIAOLNLK(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("/icon"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["SpawnObj"];
		}
	}

	public void MOJGCADBPBI(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("return ");
	}

	[SpecialName]
	public bool MCKJAMEBOLO()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.DMANNHAPJCP().ContainsKey(".played");
	}

	[SpecialName]
	public double FPFCKHODALO()
	{
		uint num = (uint)DBJFPLMNDBB();
		double num2 = num;
		return num2 / 52.0;
	}

	[SpecialName]
	public bool LDCGBPLEPEK()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("materialsitemid[");
	}

	internal IEnumerator LFADEEHDHAN()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public double NHONGBIPIDC()
	{
		uint num = (uint)JHJNKJOMHNH();
		double num2 = num;
		return num2 / 333.0;
	}

	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#rt"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["#rt"];
		}
	}

	public void GMKMLFAIIAJ()
	{
		StartCoroutine("_Intensity");
	}

	internal IEnumerator ABPCDPBGDPM()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int BEDDEMDPHJC()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	internal IEnumerator NJFECGBCNND()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	public void CAOHNPGLELG(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Fade"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["_ReflectionTexture4"];
		}
	}

	public void OFDPLAMAPNL(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_DiffuseColor"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["Drop_Far"];
		}
	}

	internal IEnumerator BMLGMLLJAPC()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public double EMLMIJBNINM()
	{
		uint num = (uint)NNNGLFHDJPK();
		double num2 = num;
		return num2 / 705.0;
	}

	public void EELPCEICELK()
	{
		StartCoroutine("_Value4");
	}

	public void ENOJOIOCCOC(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("settings.hitvariation"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["logc"];
		}
	}

	internal IEnumerator CBCNIFLHGNG()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int DNCDBCDDPDO()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	[SpecialName]
	public double APCBGBDELEB()
	{
		uint num = (uint)PICNLAHPNKL();
		double num2 = num;
		return num2 / 819.0;
	}

	[SpecialName]
	public bool NGFJCGJLHID()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("_MainTex");
	}

	public void LDANECPONPA(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["_Value6"];
		}
	}

	public void MLCELEGLCHP(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("DifficultyBG");
	}

	[SpecialName]
	public bool EEGEDINLDKO()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.customProperties.ContainsKey("Set Sun Emission");
	}

	public void HEBLHMNKGDD()
	{
		StartCoroutine("CameraFilterPack/Blur_Movie");
	}

	[SpecialName]
	public int GMNLOGJGFPP()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	[SpecialName]
	public int DEBACKDBGBE()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public bool LGPMIPHMPNN()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.DMANNHAPJCP().ContainsKey("PunRespawn");
	}

	public void LGJPGLCIHBI(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("_Value4");
	}

	[SpecialName]
	public int BGCBMMIIIOP()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	public void IIOOMBMJOGM(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("materialsquantity[");
	}

	internal IEnumerator FCNCODNANAJ()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int BFHAHOOEAAH()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	public void DGDGKPMMEBA(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("_ScreenResolution");
	}

	public void JIJHNCLMGLC()
	{
		StartCoroutine("file://");
	}

	public void MOIMNNPEBFF()
	{
		StartCoroutine("_ScreenResolution");
	}

	public void EAABKPJPPHL()
	{
		StartCoroutine("_BlurRadius4");
	}

	public void KHHDJEOGOMO()
	{
		StartCoroutine("_Value4");
	}

	internal IEnumerator NCOBFCADOFO()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	public void NFLHOJMPOCF(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("MAMMIDNFMOM");
	}

	internal IEnumerator PLEDHKEHKPP()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	public void MOCHFOLGBMM()
	{
		StartCoroutine("MAPS NOT FOUND");
	}

	public void MIOFHHOCHJC(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine(" not exist");
	}

	[SpecialName]
	public int NOFLOHECGEC()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	public void BLMJKBLMMLB(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[PlayerBase] Unknown event: "))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["OnPlayerGameMessage"];
		}
	}

	public void GKIKOMLPGPO(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("difficulty");
	}

	[SpecialName]
	public bool BOBIKAADHOI()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.customProperties.ContainsKey("settings.fps");
	}

	internal IEnumerator NJOIBLJBDID()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	public void HPAHLCMDMOI(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("Texture2");
	}

	[SpecialName]
	public double HIHANGEPHNM()
	{
		uint num = (uint)JHJNKJOMHNH();
		double num2 = num;
		return num2 / 1621.0;
	}

	public void PBJIMOILOLE()
	{
		StartCoroutine("Gameplay/LobbyPlayerIconElement");
	}

	public void JNPBFMKNOFH(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("Set sun directionVector - in which direction sun will grow on beat");
	}

	[SpecialName]
	public bool FNMLACFELCP()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.customProperties.ContainsKey("_Value3");
	}

	public void LMMJHKICIMM()
	{
		StartCoroutine("[ERROR KEY {0}]");
	}

	public void MOMNILADDOC()
	{
		StartCoroutine(".lastCheckpoint.powerupsScore");
	}

	[SpecialName]
	public double IBILPBEFILE()
	{
		uint roomTimestamp = (uint)RoomTimestamp;
		double num = roomTimestamp;
		return num / 165.0;
	}

	public void FLKDGGPEIPN(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
	}

	[SpecialName]
	public int ACFAKIBFIDN()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	public void BGKMOBDBDNF(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Distortion"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["skin."];
		}
	}

	[SpecialName]
	public double JOPDENMNEOK()
	{
		uint num = (uint)DEBACKDBGBE();
		double num2 = num;
		return num2 / 639.0;
	}

	[SpecialName]
	public bool IFHCKIDAELD()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("_Value3");
	}

	[SpecialName]
	public int EDOMKCJPKFF()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	public void ACOAJKGJFAE(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("mapselector.lastSearch"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["r"];
		}
	}

	[SpecialName]
	public bool GMEGFNMBLOD()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.DMANNHAPJCP().ContainsKey(" isInactive: ");
	}

	[SpecialName]
	public int NNNGLFHDJPK()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public double IFBLKICLOAF()
	{
		uint num = (uint)BEDDEMDPHJC();
		double num2 = num;
		return num2 / 1498.0;
	}

	internal IEnumerator NIPPMCNPMPH()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public int MKNKBLLHLOD()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public int JHJNKJOMHNH()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public int MINNCDNOBEH()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	public void HEMEJLDJKOP(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("Joystick1Button7");
	}

	public void PCJNMNLEJCF(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("ENABLE_DITHERING");
	}

	internal IEnumerator DCNMLJMOBMJ()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	internal IEnumerator NHAGNAFCAFI()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}

	[SpecialName]
	public bool JNKOIHEHFPB()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.DMANNHAPJCP().ContainsKey("_ReflectionTexture0");
	}

	[SpecialName]
	public bool CCOPCPEGMIP()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("_Radius");
	}

	public void HADJEFMLBCI(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("selColor"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["bool"];
		}
	}

	[SpecialName]
	public int PICNLAHPNKL()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	internal IEnumerator CAMFLJLDDPH()
	{
		if (!IsRoomTimeSet && PhotonNetwork.isMasterClient)
		{
			if (PhotonNetwork.ServerTimestamp == 0)
			{
				yield return 0;
			}
			ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { ["#rt"] = PhotonNetwork.ServerTimestamp };
			PhotonNetwork.room.SetCustomProperties(eNEEBHGAAJH);
		}
	}
}
