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

	internal IEnumerator ALAJHODMPEJ()
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
	public bool KBOBFIOCPIF()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("CameraFilterPack/3D_Anomaly");
	}

	[SpecialName]
	public double ECPNGDNDHAN()
	{
		uint num = (uint)BGCBMMIIIOP();
		double num2 = num;
		return num2 / 1513.0;
	}

	public void COLOKJJLMCC(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("_MainTex2");
	}

	public void FHPAKJEHGJC(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("id"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["float,0"];
		}
	}

	[SpecialName]
	public double FDIFCOCAPPG()
	{
		uint num = (uint)PLPMEEOOFLN();
		double num2 = num;
		return num2 / 385.0;
	}

	internal IEnumerator BFHBAJOBKKJ()
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
	public double LDCPBFGDKII()
	{
		uint num = (uint)IHMAMCBCELD();
		double num2 = num;
		return num2 / 1736.0;
	}

	[SpecialName]
	public double MDEBBKOGLJI()
	{
		uint num = (uint)IHMAMCBCELD();
		double num2 = num;
		return num2 / 1120.0;
	}

	public void PLFLBELOEAO(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("No regions available. Are you sure your appid is valid and setup?"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK[":\n"];
		}
	}

	public void JNPBFMKNOFH(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("_AdaptationMin");
	}

	[SpecialName]
	public int PBMGIIIBOGH()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public int KADNHMJKKKD()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	[SpecialName]
	public bool HKOEOHKJDKM()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.PFFHNNODEMM().ContainsKey("_Value3");
	}

	public void NPJHKAOGAAH(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("PlayMusic");
	}

	[SpecialName]
	public double JPFJHLECONI()
	{
		uint num = (uint)PBMGIIIBOGH();
		double num2 = num;
		return num2 / 692.0;
	}

	public void IJOJEFDGGHH()
	{
		StartCoroutine("_EmissionGain");
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
	public double FPBDFDIFLGH()
	{
		uint num = (uint)IHMAMCBCELD();
		double num2 = num;
		return num2 / 882.0;
	}

	internal IEnumerator OCMDBDAJLGE()
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

	public void FADMAHGLBKD(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("1278033234");
	}

	internal IEnumerator EJBIMAIIGHE()
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

	public void HOMDPDBILPL(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("FinishMap");
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
	public int BGCBMMIIIOP()
	{
		return PhotonNetwork.inRoom ? (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK) : 0;
	}

	[SpecialName]
	public double DGEAOLBLEEN()
	{
		uint num = (uint)IHMAMCBCELD();
		double num2 = num;
		return num2 / 613.0;
	}

	[SpecialName]
	public double EBCLCKKBJJI()
	{
		uint num = (uint)PBMGIIIBOGH();
		double num2 = num;
		return num2 / 477.0;
	}

	public void PBLHJEBMLNH(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("UseScanLine");
	}

	public void BDMDBCOMELA()
	{
		StartCoroutine("_ScreenResolution");
	}

	public void ICOIEGANENL(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Red_R"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["?"];
		}
	}

	public void OnJoinedRoom()
	{
		StartCoroutine("CAMFLJLDDPH");
	}

	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#rt"))
		{
			LOMGHAIPHJK = (int)DGIHEPAHAJK["#rt"];
		}
	}

	[SpecialName]
	public bool KHKMFIMOMPL()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.KMBLODHBAFO().ContainsKey("\t");
	}

	[SpecialName]
	public int IHMAMCBCELD()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	internal IEnumerator GLLLJAMKDME()
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

	internal IEnumerator BEMAEEAKBOK()
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

	public void NKECEAOOHOO()
	{
		StartCoroutine("LoadingStatusText");
	}

	[SpecialName]
	public double JOGGLEEDGEA()
	{
		uint num = (uint)LKDGAKAACIA();
		double num2 = num;
		return num2 / 1521.0;
	}

	public void LJOKDDAOOKO()
	{
		StartCoroutine(".completed");
	}

	[SpecialName]
	public double IFBLKICLOAF()
	{
		uint num = (uint)PLPMEEOOFLN();
		double num2 = num;
		return num2 / 1225.0;
	}

	[SpecialName]
	public int LKDGAKAACIA()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public bool OAKCAHDNLDA()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.PFFHNNODEMM().ContainsKey("_LutTex");
	}

	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		StartCoroutine("CAMFLJLDDPH");
	}

	[SpecialName]
	public bool HFNBEFEBDBP()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("<b>#banended</b>");
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

	public void PLEDKHBAIAA()
	{
		StartCoroutine("_MainTex2");
	}

	[SpecialName]
	public double EHHMJNDGDLH()
	{
		uint num = (uint)KGIDPINFFFM();
		double num2 = num;
		return num2 / 1305.0;
	}

	public void PBJIMOILOLE()
	{
		StartCoroutine("Finished");
	}

	[SpecialName]
	public int NDGIEIAEANN()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public int PLPMEEOOFLN()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public int KGIDPINFFFM()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - LOMGHAIPHJK);
	}

	[SpecialName]
	public double OMEHLJCNHKC()
	{
		uint num = (uint)LKDGAKAACIA();
		double num2 = num;
		return num2 / 147.0;
	}
}
