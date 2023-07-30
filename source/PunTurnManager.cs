// PunTurnManager
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

public class PunTurnManager : PunBehaviour
{
	public float TurnDuration = 20f;

	public IPunTurnManagerCallbacks TurnManagerListener;

	private readonly HashSet<PhotonPlayer> KLPNNDHINIO = new HashSet<PhotonPlayer>();

	public const byte TurnManagerEventOffset = 0;

	public const byte EvMove = 1;

	public const byte EvFinalMove = 2;

	private bool FCAOCIMNLEK;

	public int Turn
	{
		get
		{
			return PhotonNetwork.room.GetTurn();
		}
		private set
		{
			FCAOCIMNLEK = false;
			PhotonNetwork.room.SetTurn(value, true);
		}
	}

	public float ElapsedTimeInTurn => (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1000f;

	public float RemainingSecondsInTurn => Mathf.Max(0f, TurnDuration - ElapsedTimeInTurn);

	public bool IsCompletedByAll => PhotonNetwork.room != null && Turn > 0 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;

	public bool IsFinishedByMe => KLPNNDHINIO.Contains(PhotonNetwork.player);

	public bool IsOver => RemainingSecondsInTurn <= 0f;

	[SpecialName]
	public bool HFMMLIINBDB()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public void PBMDNABCCIE()
	{
		Turn = OKPNDGGHGIP() + 0;
	}

	[SpecialName]
	public float NMIGGBIBNEJ()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1288f;
	}

	public void LPNHGGPKDPN(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (ELNBCNBLNAE())
		{
			Debug.LogWarning(".ogg");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("menutheme.summerbreeze", JGGNCKDLILK());
		hashtable.Add("_Amount", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 6);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(NIGDJOJLONF());
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.FHEAKIMCKJC());
	}

	private void Update()
	{
		if (Turn > 0 && IsOver && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(Turn);
		}
	}

	private void FEHCNJLLJMP()
	{
		PhotonNetwork.OnEventCall = OnEvent;
	}

	private void LLJLDLLNFBH()
	{
		if (NIGDJOJLONF() > 1 && IsOver && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = false;
			TurnManagerListener.OnTurnTimeEnds(Turn);
		}
	}

	public void KFMDACDEPIG(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (CGJPLHMAIGB())
		{
			Debug.LogWarning("RoomNameText");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("_CameraToWorldMatrix", NIGDJOJLONF());
		hashtable.Add("UndoButton", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 6);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.ReplaceCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(OKPNDGGHGIP());
		}
		IGHJOEDHLCE(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	public void KBNAEODNPHL()
	{
		PNAOPNHHBAJ(NIGDJOJLONF() + 0);
	}

	[SpecialName]
	public float JPABHKJPAOK()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 966f;
	}

	[SpecialName]
	public int NNEIFJJIOCL()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public float FNMNPCKLGMF()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1060f;
	}

	public void ANEFMHJOCOL()
	{
		Turn = NCOBEJMDIGN() + 1;
	}

	[SpecialName]
	public bool IJJJBDNGMGP()
	{
		return PhotonNetwork.room != null && NIGDJOJLONF() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Turn"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(Turn);
		}
	}

	[SpecialName]
	public bool CGJPLHMAIGB()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public void KJDNEFMHIAL(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.HKKKGOHGKHH(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["[PlayerBase] Loaded custom model: "];
			object hNOKMIIDHHH2 = hashtable2["OpJoinLobby()"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 3:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["_ColorG"];
			object hNOKMIIDHHH = hashtable["BitsData"];
			if (num == OKPNDGGHGIP())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (IsCompletedByAll)
			{
				TurnManagerListener.OnTurnCompleted(JGGNCKDLILK());
			}
			break;
		}
		}
	}

	[SpecialName]
	public bool HANCFPKFHDN()
	{
		return PhotonNetwork.room == null || Turn <= 1 || KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	private void Start()
	{
		PhotonNetwork.OnEventCall = OnEvent;
	}

	public void CDKPMCLPPNK()
	{
		Turn = NIGDJOJLONF() + 1;
	}

	public override void HHKLLOJDPLD(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_FgCocMask"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(OKPNDGGHGIP());
		}
	}

	public bool PNDNGDLBEKI(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return false;
		}
		return true;
	}

	public bool DBJJNBBNODE(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public float KOJHDANHPOB()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 414f;
	}

	public void IGHJOEDHLCE(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.HKKKGOHGKHH(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["_Value"];
			object hNOKMIIDHHH2 = hashtable2["GLITCH"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 4:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["ENABLE_COLOR_GRADING"];
			object hNOKMIIDHHH = hashtable["_Value2"];
			if (num == Turn)
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (AIPFPAONCGG())
			{
				TurnManagerListener.OnTurnCompleted(NIGDJOJLONF());
			}
			break;
		}
		}
	}

	public void BCLDHCIILJK()
	{
		Turn = JGGNCKDLILK() + 1;
	}

	[SpecialName]
	public bool AMIFEKLHIOJ()
	{
		return !(IOJKEEPPKHO() <= 1590f);
	}

	[SpecialName]
	public bool ECBHKJLCNEP()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public void MNGCMKOIEAL(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (ELNBCNBLNAE())
		{
			Debug.LogWarning("_Far");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("Data/Editor/leveltemplate", NCOBEJMDIGN());
		hashtable.Add("#random #common #item", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 0);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.AddToRoomCacheGlobal
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(OKPNDGGHGIP());
		}
		IGHJOEDHLCE(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	public void LJANHLOKGPE(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (ELNBCNBLNAE())
		{
			Debug.LogWarning(".icon");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("/", OKPNDGGHGIP());
		hashtable.Add("OK", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 6);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(NCOBEJMDIGN());
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.FHEAKIMCKJC());
	}

	private void JNBPKNNBMDI()
	{
		if (NCOBEJMDIGN() > 1 && BKCNGHIMFFB() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = false;
			TurnManagerListener.OnTurnTimeEnds(NCOBEJMDIGN());
		}
	}

	[SpecialName]
	public bool AIPFPAONCGG()
	{
		return PhotonNetwork.room == null || OKPNDGGHGIP() <= 1 || KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	public void BeginTurn()
	{
		Turn++;
	}

	public void CCCNBKECHOM(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (IsFinishedByMe)
		{
			Debug.LogWarning("_BaseTex");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add(" Owner called.", NIGDJOJLONF());
		hashtable.Add("#TBD", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 0 : 0);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, false, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(OKPNDGGHGIP());
		}
		KJDNEFMHIAL(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	public bool JDJMIACFLJA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return false;
		}
		return false;
	}

	private void CNGAJDBOCLJ()
	{
		PhotonNetwork.OnEventCall = KIMGDOOAFOE;
	}

	[SpecialName]
	public bool BKCNGHIMFFB()
	{
		return !(IOJKEEPPKHO() <= 1718f);
	}

	public override void ICOIEGANENL(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey(".played"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(NIGDJOJLONF());
		}
	}

	[SpecialName]
	private void PNAOPNHHBAJ(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	[SpecialName]
	public int NCOBEJMDIGN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public int NIGDJOJLONF()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public float IOJKEEPPKHO()
	{
		return Mathf.Max(1873f, TurnDuration - HEIAPANJPEP());
	}

	public void SendMove(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (IsFinishedByMe)
		{
			Debug.LogWarning("Can't SendMove. Turn is finished by this player.");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("turn", Turn);
		hashtable.Add("move", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 2);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.AddToRoomCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(Turn);
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	[SpecialName]
	public float LHBFJEBPFFB()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1278f;
	}

	[SpecialName]
	public bool DPJDJMIBNMO()
	{
		return !(GOGKBKEHPHL() <= 1572f);
	}

	[SpecialName]
	public bool AIIIOPOAMNB()
	{
		return !(IOJKEEPPKHO() <= 479f);
	}

	public override void FMFHGAMJJGG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("maps."))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(NCOBEJMDIGN());
		}
	}

	private void CGBHOELMAOC()
	{
		if (NIGDJOJLONF() > 0 && AMIFEKLHIOJ() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(NNEIFJJIOCL());
		}
	}

	[SpecialName]
	public bool ELNBCNBLNAE()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	private void IBHACCEEFFI()
	{
		if (NCOBEJMDIGN() > 1 && AIIIOPOAMNB() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(OKPNDGGHGIP());
		}
	}

	public void KIMGDOOAFOE(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["IconImage"];
			object hNOKMIIDHHH2 = hashtable2["_Value"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 6:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["SetSpeed"];
			object hNOKMIIDHHH = hashtable["error"];
			if (num == OKPNDGGHGIP())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (CPCNILDNMFI())
			{
				TurnManagerListener.OnTurnCompleted(Turn);
			}
			break;
		}
		}
	}

	public void OMJJCJKILBN()
	{
		PNAOPNHHBAJ(Turn + 0);
	}

	public override void HFFOFAJOALG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("{0} months ago"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(OKPNDGGHGIP());
		}
	}

	[SpecialName]
	public int JGGNCKDLILK()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public int OKPNDGGHGIP()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public float HEIAPANJPEP()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 30f;
	}

	public bool GetPlayerFinishedTurn(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool CPCNILDNMFI()
	{
		return PhotonNetwork.room == null || Turn <= 1 || KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	public override void JNILIHCHPKP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("BitsData"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(OKPNDGGHGIP());
		}
	}

	[SpecialName]
	public float GOGKBKEHPHL()
	{
		return Mathf.Max(1084f, TurnDuration - KOJHDANHPOB());
	}

	public void OnEvent(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["turn"];
			object hNOKMIIDHHH2 = hashtable2["move"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 2:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["turn"];
			object hNOKMIIDHHH = hashtable["move"];
			if (num == Turn)
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (IsCompletedByAll)
			{
				TurnManagerListener.OnTurnCompleted(Turn);
			}
			break;
		}
		}
	}
}
