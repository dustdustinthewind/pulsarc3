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

	private void NCPAFCKGJEA()
	{
		if (GJOLNGBIOIN() > 0 && PPEHOCMMMAA() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(PMKDJOOGMLK());
		}
	}

	public void BeginTurn()
	{
		Turn++;
	}

	[SpecialName]
	public float MHDHBLHBMLL()
	{
		return Mathf.Max(665f, TurnDuration - OELMDPDDDCM());
	}

	[SpecialName]
	public bool KCMDKCAOPML()
	{
		return PhotonNetwork.room == null || GDJLPABBBKN() <= 0 || KLPNNDHINIO.Count == PhotonNetwork.room.DHOGHIOACME();
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
	public bool DMELHDCJKJB()
	{
		return PhotonNetwork.room != null && LMJKMHLMDPM() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.DHOGHIOACME();
	}

	[SpecialName]
	public float FJENCBAGBNP()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1495f;
	}

	public void HFDJCEBDBJG(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (IsFinishedByMe)
		{
			Debug.LogWarning("[PlayerController] ");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("_ScreenResolution", HHHGEKHMGHN());
		hashtable.Add("mapselector.lastSearch", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)(OEGKPMHIJGF ? 6 : 0);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(LMJKMHLMDPM());
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	public bool EKFHKCOCELJ(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return true;
	}

	[SpecialName]
	public int IDFPOLFAFBL()
	{
		return PhotonNetwork.room.GetTurn();
	}

	public void OJOCFMINBLC(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["_ScreenResolution"];
			object hNOKMIIDHHH2 = hashtable2["_Near"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 3:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["In Main Menu"];
			object hNOKMIIDHHH = hashtable["settings.cameramovements"];
			if (num == HHHGEKHMGHN())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (CPCNILDNMFI())
			{
				TurnManagerListener.OnTurnCompleted(HHHGEKHMGHN());
			}
			break;
		}
		}
	}

	public void EECLNGDOIIA(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (IsFinishedByMe)
		{
			Debug.LogWarning("AddEnvironmentObject");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("UseScanLine", PMKDJOOGMLK());
		hashtable.Add("plainText", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 0 : 0);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(GJOLNGBIOIN());
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.ID);
	}

	public bool HAHPLCCAMKE(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return false;
	}

	private void AEEGKLABFLN()
	{
		if (PMKDJOOGMLK() > 0 && IIMDNFFIDJO() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(PMKDJOOGMLK());
		}
	}

	public void MLMGLFPMPKC()
	{
		LHFLIDFLPNA(IDFPOLFAFBL() + 0);
	}

	[SpecialName]
	public bool IIMDNFFIDJO()
	{
		return !(DADCNDMNKKE() <= 1045f);
	}

	[SpecialName]
	public bool ILKADLIPFEH()
	{
		return PhotonNetwork.room == null || Turn <= 1 || KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	[SpecialName]
	private void LJCOFHNGJNB(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	public override void PBFDMLGIPOM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Crosshair"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(PMKDJOOGMLK());
		}
	}

	public void DCPCOHNMJLL(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (GIDIJDPOODD())
		{
			Debug.LogWarning("ControllerRightX");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("mapselector.filter.favoriteonly", LMJKMHLMDPM());
		hashtable.Add("The other scroll rect doesnt support scrolling horizontally", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 5);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCacheForActorsLeft
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(Turn);
		}
		OnEvent(iMCBEMICJFC, hashtable, PhotonNetwork.player.ONIKFABKELO());
	}

	[SpecialName]
	public float DADCNDMNKKE()
	{
		return Mathf.Max(1547f, TurnDuration - CBNGNDADEAG());
	}

	private void POJFHDFJOPE()
	{
		if (Turn > 0 && JNKECPKBLOG() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(PMKDJOOGMLK());
		}
	}

	public void IHGGPNLHDGI(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["CameraFilterPack/Drawing_CellShading"];
			object hNOKMIIDHHH2 = hashtable2["menu.tabid"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 5:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["_Value2"];
			object hNOKMIIDHHH = hashtable["maps."];
			if (num == IDFPOLFAFBL())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (CPCNILDNMFI())
			{
				TurnManagerListener.OnTurnCompleted(IDFPOLFAFBL());
			}
			break;
		}
		}
	}

	[SpecialName]
	public bool FONBPACMNAL()
	{
		return EBPAGJBFEEE() <= 1388f;
	}

	[SpecialName]
	public float MCDBAACFMLA()
	{
		return Mathf.Max(1494f, TurnDuration - FJENCBAGBNP());
	}

	public void LOCAHNOMIGH(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["menu.playedsolo"];
			object hNOKMIIDHHH2 = hashtable2["Offline or in OfflineMode. No VitalStats available."];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 0:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["MenuScene"];
			object hNOKMIIDHHH = hashtable["_ScreenResolution"];
			if (num == HHHGEKHMGHN())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (HLLMADAHHIJ())
			{
				TurnManagerListener.OnTurnCompleted(LMJKMHLMDPM());
			}
			break;
		}
		}
	}

	[SpecialName]
	public float CBNGNDADEAG()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 987f;
	}

	[SpecialName]
	public int GJOLNGBIOIN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public float AAFOEEEMIMH()
	{
		return Mathf.Max(1018f, TurnDuration - CBNGNDADEAG());
	}

	[SpecialName]
	public bool JNKECPKBLOG()
	{
		return !(NBAKEGJNADK() <= 163f);
	}

	[SpecialName]
	private void LHFLIDFLPNA(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL);
	}

	[SpecialName]
	public bool CPCNILDNMFI()
	{
		return PhotonNetwork.room == null || HHHGEKHMGHN() <= 0 || KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	[SpecialName]
	public bool HANCFPKFHDN()
	{
		return PhotonNetwork.room != null && PMKDJOOGMLK() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	[SpecialName]
	public float EBPAGJBFEEE()
	{
		return Mathf.Max(944f, TurnDuration - CBNGNDADEAG());
	}

	public bool LFLJFHPDNDP(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return false;
	}

	public void IBKKGJOIENM()
	{
		GJLBGOBMPIH(PMKDJOOGMLK() + 1);
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

	[SpecialName]
	public bool APDMMAJIHAL()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public void JIKMAAJPFIC(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["Default UI Material"];
			object hNOKMIIDHHH2 = hashtable2["Preparing content..."];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 6:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["Soundtrack"];
			object hNOKMIIDHHH = hashtable["value"];
			if (num == IDFPOLFAFBL())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (POOPLIFHPKH())
			{
				TurnManagerListener.OnTurnCompleted(Turn);
			}
			break;
		}
		}
	}

	[SpecialName]
	private void GJLBGOBMPIH(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	[SpecialName]
	public int GDJLPABBBKN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	public void JKHBDPIGFOE(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["#exit"];
			object hNOKMIIDHHH2 = hashtable2["_TimeX"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 6:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["_Near"];
			object hNOKMIIDHHH = hashtable["_BlurTexture"];
			if (num == GJOLNGBIOIN())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (HANCFPKFHDN())
			{
				TurnManagerListener.OnTurnCompleted(PMKDJOOGMLK());
			}
			break;
		}
		}
	}

	[SpecialName]
	private void POBKGKFOFGM(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL);
	}

	[SpecialName]
	public bool HLLMADAHHIJ()
	{
		return PhotonNetwork.room != null && HHHGEKHMGHN() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	[SpecialName]
	private void LAEPOOENKEC(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL);
	}

	public void LEOFMGELGDM()
	{
		LPMEFHODEJA(IDFPOLFAFBL() + 1);
	}

	[SpecialName]
	public bool AOCEABALDBM()
	{
		return !(MCDBAACFMLA() <= 839f);
	}

	public override void CKGEIHEOCCN(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#kicked"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(PMKDJOOGMLK());
		}
	}

	[SpecialName]
	public float OELMDPDDDCM()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1339f;
	}

	public override void OGDKLPLPOGO(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Coord"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(PMKDJOOGMLK());
		}
	}

	private void LMBDNPLDGIJ()
	{
		if (HHHGEKHMGHN() > 0 && FONBPACMNAL() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = false;
			TurnManagerListener.OnTurnTimeEnds(HHHGEKHMGHN());
		}
	}

	public void HEBJFNEEKBG(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["SubBass"];
			object hNOKMIIDHHH2 = hashtable2["_Value3"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 6:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["_TimeX"];
			object hNOKMIIDHHH = hashtable["settings_bindings_sec_"];
			if (num == Turn)
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (JJPOMGDJCKH())
			{
				TurnManagerListener.OnTurnCompleted(IDFPOLFAFBL());
			}
			break;
		}
		}
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
	private void DKHANOKHJIF(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL);
	}

	[SpecialName]
	public bool GIDIJDPOODD()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	[SpecialName]
	public bool JKCAALPKFCH()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public void KFBCOGFPGHN(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 0:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["settings.volume.editor"];
			object hNOKMIIDHHH2 = hashtable2["_ScreenResolution"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 5:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable["_ScreenResolution"];
			object hNOKMIIDHHH = hashtable["_FadeFX"];
			if (num == HHHGEKHMGHN())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (DMELHDCJKJB())
			{
				TurnManagerListener.OnTurnCompleted(LMJKMHLMDPM());
			}
			break;
		}
		}
	}

	[SpecialName]
	public bool GBICDEPEKPK()
	{
		return PhotonNetwork.room == null || GDJLPABBBKN() <= 0 || KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	public override void DIDCELLBNFP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_SSRMultiplier"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(IDFPOLFAFBL());
		}
	}

	[SpecialName]
	public bool OJCCFBFMBAN()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	[SpecialName]
	public bool PPEHOCMMMAA()
	{
		return DADCNDMNKKE() <= 1310f;
	}

	[SpecialName]
	private void KLMNHJIPEBH(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	[SpecialName]
	public bool HFNFGJOCPFI()
	{
		return PhotonNetwork.room != null && HHHGEKHMGHN() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	private void KMCPMOGKDEH()
	{
		PhotonNetwork.OnEventCall = GBCMPJFBABG;
	}

	public void GJAHEPLOPJF(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (IsFinishedByMe)
		{
			Debug.LogWarning("_Speed");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add(";", LMJKMHLMDPM());
		hashtable.Add("_Value3", HNOKMIIDHHH);
		byte iMCBEMICJFC = (byte)((!OEGKPMHIJGF) ? 1 : 4);
		PhotonNetwork.RaiseEvent(iMCBEMICJFC, hashtable, false, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(IDFPOLFAFBL());
		}
		LOCAHNOMIGH(iMCBEMICJFC, hashtable, PhotonNetwork.player.ONIKFABKELO());
	}

	public override void JOPPNDFKDMD(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("GLITCH"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(GDJLPABBBKN());
		}
	}

	[SpecialName]
	public bool CGJPLHMAIGB()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public override void MIFBDCHLMPK(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_ScreenResolution"))
		{
			FCAOCIMNLEK = false;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(GJOLNGBIOIN());
		}
	}

	[SpecialName]
	public bool DPJDJMIBNMO()
	{
		return !(AAFOEEEMIMH() <= 547f);
	}

	public override void GKCLHCNEGJM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[PlayerBase] SpawnObj error: "))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(GDJLPABBBKN());
		}
	}

	public bool NMGANNLCKDP(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return false;
		}
		return false;
	}

	public void GBCMPJFBABG(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		switch (IMCBEMICJFC)
		{
		case 1:
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jPFFPMDKAMC = (int)hashtable2["BadgeImage"];
			object hNOKMIIDHHH2 = hashtable2["InfoCanvas"];
			TurnManagerListener.OnPlayerMove(photonPlayer, jPFFPMDKAMC, hNOKMIIDHHH2);
			break;
		}
		case 2:
		{
			Hashtable hashtable = FKODMINIAEC as Hashtable;
			int num = (int)hashtable[" Time: "];
			object hNOKMIIDHHH = hashtable[".lastCheckpoint.correctScore"];
			if (num == IDFPOLFAFBL())
			{
				KLPNNDHINIO.Add(photonPlayer);
				TurnManagerListener.OnPlayerFinished(photonPlayer, num, hNOKMIIDHHH);
			}
			if (KCMDKCAOPML())
			{
				TurnManagerListener.OnTurnCompleted(PMKDJOOGMLK());
			}
			break;
		}
		}
	}

	public bool COOBFGAGNKH(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return false;
	}

	private void NEKCPLGFOFD()
	{
		if (GDJLPABBBKN() > 0 && DPJDJMIBNMO() && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(LMJKMHLMDPM());
		}
	}

	[SpecialName]
	public float NBAKEGJNADK()
	{
		return Mathf.Max(1927f, TurnDuration - ElapsedTimeInTurn);
	}

	private void JBNPEHMDCMI()
	{
		if (PMKDJOOGMLK() > 1 && IsOver && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(IDFPOLFAFBL());
		}
	}

	[SpecialName]
	public float FCJAALNKPKB()
	{
		return Mathf.Max(593f, TurnDuration - FJENCBAGBNP());
	}

	public void KANBGPFIBIF()
	{
		LHFLIDFLPNA(PMKDJOOGMLK() + 0);
	}

	[SpecialName]
	public bool IPMPPPOOMMJ()
	{
		return KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	public bool EIHACAGLIML(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return true;
	}

	[SpecialName]
	public int HHHGEKHMGHN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	[SpecialName]
	public bool JJPOMGDJCKH()
	{
		return PhotonNetwork.room != null && Turn > 0 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	[SpecialName]
	public int PMKDJOOGMLK()
	{
		return PhotonNetwork.room.GetTurn();
	}

	private void Start()
	{
		PhotonNetwork.OnEventCall = OnEvent;
	}

	public override void EGEOALDCKCB(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Joystick1Button12"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(PMKDJOOGMLK());
		}
	}

	public override void IFCAJMABPPM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("kick"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(PMKDJOOGMLK());
		}
	}

	public bool NHBPGPFDBBE(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public int LMJKMHLMDPM()
	{
		return PhotonNetwork.room.GetTurn();
	}

	public void JOFMBBFJHDD()
	{
		POBKGKFOFGM(Turn + 1);
	}

	private void DKGBFNCOAEO()
	{
		PhotonNetwork.OnEventCall = LOCAHNOMIGH;
	}

	[SpecialName]
	private void LPMEFHODEJA(int DPNHODJHGJL)
	{
		FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL);
	}

	private void Update()
	{
		if (Turn > 0 && IsOver && !FCAOCIMNLEK)
		{
			FCAOCIMNLEK = true;
			TurnManagerListener.OnTurnTimeEnds(Turn);
		}
	}

	public override void JKKLOHIBDDP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("RecordButton"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(GDJLPABBBKN());
		}
	}

	[SpecialName]
	public bool DFNAMNFLJKH()
	{
		return PhotonNetwork.room != null && GJOLNGBIOIN() > 0 && KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	public bool JDJMIACFLJA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK != null && KLPNNDHINIO != null && KLPNNDHINIO.Contains(JHOEDACNNKK))
		{
			return true;
		}
		return true;
	}

	[SpecialName]
	public bool POOPLIFHPKH()
	{
		return PhotonNetwork.room != null && GDJLPABBBKN() > 1 && KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	public override void LDKHJEKAKHA(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("ConfigVersionSlider"))
		{
			FCAOCIMNLEK = true;
			KLPNNDHINIO.Clear();
			TurnManagerListener.OnTurnBegins(HHHGEKHMGHN());
		}
	}

	public void PBMDNABCCIE()
	{
		DKHANOKHJIF(HHHGEKHMGHN() + 0);
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
}
