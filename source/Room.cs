// Room
using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class Room : RoomInfo
{
	public new string Name
	{
		get
		{
			return LCKGKDLCFMC;
		}
		internal set
		{
			LCKGKDLCFMC = value;
		}
	}

	public new bool IsOpen
	{
		get
		{
			return PNAALABONJG;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set open when not in that room.");
			}
			if (value != PNAALABONJG && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable { 
				{
					(byte)253,
					value
				} });
			}
			PNAALABONJG = value;
		}
	}

	public new bool IsVisible
	{
		get
		{
			return FMPBAGHEJDN;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set visible when not in that room.");
			}
			if (value != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable { 
				{
					(byte)254,
					value
				} });
			}
			FMPBAGHEJDN = value;
		}
	}

	public string[] PropertiesListedInLobby { get; private set; }

	public bool AutoCleanUp => FECDEAJPAAJ;

	public new int MaxPlayers
	{
		get
		{
			return MDLLBJEFCCJ;
		}
		set
		{
			if (!Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set MaxPlayers when not in that room.");
			}
			if (value > 255)
			{
				Debug.LogWarning("Can't set Room.MaxPlayers to: " + value + ". Using max value: 255.");
				value = 255;
			}
			if (value != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable { 
				{
					byte.MaxValue,
					(byte)value
				} });
			}
			MDLLBJEFCCJ = (byte)value;
		}
	}

	public new int PlayerCount
	{
		get
		{
			if (PhotonNetwork.playerList != null)
			{
				return PhotonNetwork.playerList.Length;
			}
			return 0;
		}
	}

	public string[] ExpectedUsers => GFEDJEMJEND;

	protected internal int EJLAPIIGIMI
	{
		get
		{
			return IPBANMNLDPC;
		}
		set
		{
			IPBANMNLDPC = value;
		}
	}

	[Obsolete("Please use Name (updated case for naming).")]
	public new string name
	{
		get
		{
			return Name;
		}
		internal set
		{
			Name = value;
		}
	}

	[Obsolete("Please use IsOpen (updated case for naming).")]
	public new bool open
	{
		get
		{
			return IsOpen;
		}
		set
		{
			IsOpen = value;
		}
	}

	[Obsolete("Please use IsVisible (updated case for naming).")]
	public new bool visible
	{
		get
		{
			return IsVisible;
		}
		set
		{
			IsVisible = value;
		}
	}

	[Obsolete("Please use PropertiesListedInLobby (updated case for naming).")]
	public string[] propertiesListedInLobby
	{
		get
		{
			return PropertiesListedInLobby;
		}
		private set
		{
			PropertiesListedInLobby = value;
		}
	}

	[Obsolete("Please use AutoCleanUp (updated case for naming).")]
	public bool autoCleanUp => AutoCleanUp;

	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public new int maxPlayers
	{
		get
		{
			return MaxPlayers;
		}
		set
		{
			MaxPlayers = value;
		}
	}

	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public new int playerCount => PlayerCount;

	[Obsolete("Please use ExpectedUsers (updated case for naming).")]
	public string[] expectedUsers => ExpectedUsers;

	[Obsolete("Please use MasterClientId (updated case for naming).")]
	protected internal int LHFOBFKEJNA
	{
		get
		{
			return EJLAPIIGIMI;
		}
		set
		{
			EJLAPIIGIMI = value;
		}
	}

	[SpecialName]
	public string GJCOLGAHAIO()
	{
		return LCKGKDLCFMC;
	}

	public void HLPLFJLNCOJ()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)128] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)83] = KLNEGBJPIBO();
		PhotonNetwork.JNJJAMNLOHA.LPJIFHNJBMO(hashtable, hashtable2, true);
	}

	public void SetExpectedUsers(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)247] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)247] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2);
	}

	[SpecialName]
	public string OFNKBGMDLPG()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public void NEHHLFLHCGE(bool DPNHODJHGJL)
	{
		KHMHEGIDGKK(DPNHODJHGJL);
	}

	public void DNLBOHAENEB(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)46] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(hashtable);
		PropertiesListedInLobby = GNPOEBDMHMP;
	}

	[SpecialName]
	public void FFGICDHDECA(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("maps.");
		}
		if (DPNHODJHGJL != PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.IILDKFGHOHK(new Hashtable { 
			{
				(byte)43,
				DPNHODJHGJL
			} }, null, true);
		}
		PNAALABONJG = DPNHODJHGJL;
	}

	[SpecialName]
	public bool KNLMKIPDHOI()
	{
		return IsVisible;
	}

	[SpecialName]
	public void KFAEFFBPMMF(bool DPNHODJHGJL)
	{
		CFONNEIKKLP(DPNHODJHGJL);
	}

	[SpecialName]
	internal void EECGOBHMHDB(string DPNHODJHGJL)
	{
		Name = DPNHODJHGJL;
	}

	[SpecialName]
	internal void LAMBHKJLNGG(string DPNHODJHGJL)
	{
		AJKPNAAMHMF(DPNHODJHGJL);
	}

	[SpecialName]
	public int BAEAAGJIHNJ()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public bool EFCFJHBJLOD()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	internal void FGHHNPKKOPJ(string DPNHODJHGJL)
	{
		HLPMDBODKKC(DPNHODJHGJL);
	}

	[SpecialName]
	public bool IMPLOHMDHAF()
	{
		return IsVisible;
	}

	[SpecialName]
	public string DMALJMMFNFE()
	{
		return GJCOLGAHAIO();
	}

	public string IAIADIGLPGC()
	{
		object[] array = new object[0];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "Traffic Stats" : "PunRespawn");
		array[0] = ((!PNAALABONJG) ? "maps." : ".lastCheckpoint.penaltyScore");
		array[3] = MDLLBJEFCCJ;
		array[0] = EGPGEMJNPFD();
		array[0] = base.CustomProperties.ToStringFull();
		return string.Format("_TimeX", array);
	}

	[SpecialName]
	public string[] GMMNJDMKBFD()
	{
		return PropertiesListedInLobby;
	}

	[SpecialName]
	public string[] JHFHDOPLLDF()
	{
		return GFEDJEMJEND;
	}

	public void SetCustomProperties(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH != null)
		{
			Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
			Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
			bool flag = hashtable2 == null || hashtable2.Count == 0;
			if (PhotonNetwork.offlineMode || flag)
			{
				base.CustomProperties.Merge(hashtable);
				base.CustomProperties.StripKeysWithNullValues();
			}
			if (!PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2, CDBHGINNCOF);
			}
			if (PhotonNetwork.offlineMode || flag)
			{
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCustomRoomPropertiesChanged, hashtable);
			}
		}
	}

	[SpecialName]
	public void OILCDELFIHI(bool DPNHODJHGJL)
	{
		CFONNEIKKLP(DPNHODJHGJL);
	}

	[SpecialName]
	public string GGAPAOIMIBP()
	{
		return Name;
	}

	[SpecialName]
	protected internal int GHDAFLPOLFA()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	public bool JPNACDODMEF()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public bool OADOCGJBGLG()
	{
		return IFGKKKFBIHE();
	}

	[SpecialName]
	protected internal void OPEKABONLBO(int DPNHODJHGJL)
	{
		IPBANMNLDPC = DPNHODJHGJL;
	}

	[SpecialName]
	public void GLKILAMADNE(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
		}
		if (DPNHODJHGJL > -48)
		{
			Debug.LogWarning("</color>" + DPNHODJHGJL + "SlidingArea");
			DPNHODJHGJL = 44;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable { 
			{
				(byte)208,
				(byte)DPNHODJHGJL
			} }, null, true);
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	public bool GEMHINDJHJL()
	{
		return MDBBBNDEANK();
	}

	[SpecialName]
	public int AOHMIPHOEBD()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	internal void BECALLBICNF(string DPNHODJHGJL)
	{
		AJKPNAAMHMF(DPNHODJHGJL);
	}

	[SpecialName]
	public void JOFLMEGAHEE(bool DPNHODJHGJL)
	{
		IsOpen = DPNHODJHGJL;
	}

	public void HGEPILMBPNP()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)135] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)241] = JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(hashtable, hashtable2, true);
	}

	[SpecialName]
	protected internal int FNIAGLHIBLL()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	public int LCKLEMHPLLC()
	{
		return DHOGHIOACME();
	}

	[SpecialName]
	public void JJIJDMIHOFM(bool DPNHODJHGJL)
	{
		CFONNEIKKLP(DPNHODJHGJL);
	}

	[SpecialName]
	public string POPKEPNKIAO()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	private void CBFLHMDCKHO(string[] DPNHODJHGJL)
	{
		EICJKLIICLJ(DPNHODJHGJL);
	}

	[SpecialName]
	public void PKLPIFABEIA(bool DPNHODJHGJL)
	{
		HJGBGMHJMPJ(DPNHODJHGJL);
	}

	[SpecialName]
	public bool ONCMEFOOFJF()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	public bool MMHFBAOFHLP()
	{
		return JPNACDODMEF();
	}

	[SpecialName]
	public bool CBCIPBLGBPO()
	{
		return ANMHADBIJGN();
	}

	[SpecialName]
	public void ILPPFLNOCDD(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("mapselector.filter.favoriteonly");
		}
		if (DPNHODJHGJL > 49)
		{
			Debug.LogWarning("[MenuScene] Error: " + DPNHODJHGJL + "green");
			DPNHODJHGJL = -86;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable { 
			{
				(byte)90,
				(byte)DPNHODJHGJL
			} }, null, true);
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	private void AEOBKBDOEBE(string[] DPNHODJHGJL)
	{
		BNNFCKHICOP(DPNHODJHGJL);
	}

	public void BPBICFHHIHF()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)125] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)41] = JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.FMDMPEMOAAB(hashtable, hashtable2, true);
	}

	public void SetPropertiesListedInLobby(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)250] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable);
		PropertiesListedInLobby = GNPOEBDMHMP;
	}

	[SpecialName]
	public bool OKLCDOKCFLB()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public int ADKLFKDIBPG()
	{
		return PlayerCount;
	}

	[SpecialName]
	private void IDGFIBFOOAG(string[] DPNHODJHGJL)
	{
		PropertiesListedInLobby = DPNHODJHGJL;
	}

	public void FHPFCJDEINO(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)16] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)61] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.LPJIFHNJBMO(hashtable, hashtable2);
	}

	[SpecialName]
	internal void OOLGFNPPJFJ(string DPNHODJHGJL)
	{
		LCKGKDLCFMC = DPNHODJHGJL;
	}

	[SpecialName]
	public bool OAJEBJIMNLI()
	{
		return IsOpen;
	}

	public void BNLBLHNHOHG(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)223] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)123] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(hashtable, hashtable2, true);
	}

	[SpecialName]
	public bool DJPCNGHHGFG()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	protected internal int CKDAKMFOPBA()
	{
		return COFIGFDNBLJ();
	}

	[SpecialName]
	public bool HDOGIJOMLNI()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	private void EICJKLIICLJ(string[] DPNHODJHGJL)
	{
		_003CHDDFDGJAIJD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public int MAKNGHPADGI()
	{
		return PlayerCount;
	}

	[SpecialName]
	public bool BIEGMBPEJLK()
	{
		return HDOGIJOMLNI();
	}

	[SpecialName]
	internal void JKMKLMHIDHH(string DPNHODJHGJL)
	{
		LCKGKDLCFMC = DPNHODJHGJL;
	}

	public override string BOKBCLJLOCL()
	{
		object[] array = new object[1];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "[SteamManager] Connection established, authorization" : "Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
		array[7] = ((!PNAALABONJG) ? "settings.selectormapsperpage" : "local CheckCondition = function()");
		array[8] = MDLLBJEFCCJ;
		array[3] = EGPGEMJNPFD();
		return string.Format("Solo", array);
	}

	public override string ToString()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount);
	}

	[SpecialName]
	public string[] FECOFGHMPPA()
	{
		return _003CHDDFDGJAIJD_003Ek__BackingField;
	}

	[SpecialName]
	public void GJOJMJBKDEI(int DPNHODJHGJL)
	{
		NDEBBNGMFFK(DPNHODJHGJL);
	}

	public void ClearExpectedUsers()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)247] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)247] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2);
	}

	[SpecialName]
	public string CCPCAPGFFNO()
	{
		return GJCOLGAHAIO();
	}

	[SpecialName]
	public string OBPBFJGEECJ()
	{
		return Name;
	}

	[SpecialName]
	protected internal int COFIGFDNBLJ()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	public bool IHKCBNNMLNK()
	{
		return FECDEAJPAAJ;
	}

	public void DGDMIPBJEPN(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)161] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable);
		EICJKLIICLJ(GNPOEBDMHMP);
	}

	[SpecialName]
	public void BGDKAJLOKLP(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_PositionX");
		}
		if (DPNHODJHGJL != PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.CADDOMOCLIJ(new Hashtable { 
			{
				(byte)126,
				DPNHODJHGJL
			} }, null, true);
		}
		PNAALABONJG = DPNHODJHGJL;
	}

	[SpecialName]
	public void HJGBGMHJMPJ(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("Validating mod pack...");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.CADDOMOCLIJ(new Hashtable { 
			{
				(byte)243,
				DPNHODJHGJL
			} });
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	[SpecialName]
	public bool CNNCLNGNMJA()
	{
		return IsVisible;
	}

	[SpecialName]
	internal void AABGMMMODEO(string DPNHODJHGJL)
	{
		JKMKLMHIDHH(DPNHODJHGJL);
	}

	public void DCNHBEJAGOJ(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)72] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable);
		EICJKLIICLJ(GNPOEBDMHMP);
	}

	public override string LCJLNHLMBLN()
	{
		object[] array = new object[5];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "materialsquantity[" : "_Value3");
		array[3] = ((!PNAALABONJG) ? "GlassesColor" : "EventTimeInputField");
		array[6] = MDLLBJEFCCJ;
		array[0] = DHOGHIOACME();
		return string.Format("CameraFilterPack/FX_Glitch3", array);
	}

	public void PLDDJCNGIAG(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)213] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)180] = JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.OABLOBEGOPJ(hashtable, hashtable2, true);
	}

	[SpecialName]
	public void NEIEIMFAMEK(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_TimeX");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.OABLOBEGOPJ(new Hashtable { 
			{
				(byte)196,
				DPNHODJHGJL
			} }, null, true);
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	public void PEPKBMBJPAP(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)232] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)78] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.IILDKFGHOHK(hashtable, hashtable2);
	}

	[SpecialName]
	public bool MDBBBNDEANK()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	public void LBHJHCKLANM(bool DPNHODJHGJL)
	{
		AOFIBMMLNAA(DPNHODJHGJL);
	}

	[SpecialName]
	public void DGPIBICDDMG(bool DPNHODJHGJL)
	{
		EMAPOENGEIN(DPNHODJHGJL);
	}

	[SpecialName]
	protected internal int LKHBADEOGKO()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	private void EACCKAOBBEP(string[] DPNHODJHGJL)
	{
		EICJKLIICLJ(DPNHODJHGJL);
	}

	[SpecialName]
	public bool PGFMHJAMBBN()
	{
		return AEIGNIMAAMO();
	}

	[SpecialName]
	internal void HLPMDBODKKC(string DPNHODJHGJL)
	{
		LCKGKDLCFMC = DPNHODJHGJL;
	}

	[SpecialName]
	public string LEGHJPDPLLC()
	{
		return GJCOLGAHAIO();
	}

	public string CEDLOMLHLDJ()
	{
		object[] array = new object[8];
		array[0] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "CameraFilterPack/Blend2Camera_HardLight" : "_VignetteBlur");
		array[1] = ((!PNAALABONJG) ? "SetSpeed" : "CameraFilterPack/TV_WideScreenHorizontal");
		array[0] = MDLLBJEFCCJ;
		array[4] = EGPGEMJNPFD();
		array[2] = BGOPIJPICLJ().ToStringFull();
		return string.Format("Ok", array);
	}

	[SpecialName]
	public void DLKAMKFEDPN(int DPNHODJHGJL)
	{
		GLKILAMADNE(DPNHODJHGJL);
	}

	public void ABLMEGAHILA(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)136] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(hashtable, null, true);
		NNKLLBPFBNP(GNPOEBDMHMP);
	}

	[SpecialName]
	public void EMAPOENGEIN(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_PrevViewProj");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(new Hashtable { 
			{
				(byte)151,
				DPNHODJHGJL
			} }, null, true);
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	[SpecialName]
	public int NBHPLOFGIEK()
	{
		return MaxPlayers;
	}

	[SpecialName]
	public string[] PAFNCGNIAGD()
	{
		return JHFHDOPLLDF();
	}

	[SpecialName]
	public int JNOGEIMFFEG()
	{
		return DHOGHIOACME();
	}

	[SpecialName]
	protected internal int ICODKICJIFI()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	public bool CLCCCFDCOBA()
	{
		return PNAALABONJG;
	}

	public string OIDHLIBGOHM()
	{
		object[] array = new object[0];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "JITTER" : "_HrDepthTex");
		array[4] = ((!PNAALABONJG) ? "_Value3" : ":\n");
		array[1] = MDLLBJEFCCJ;
		array[5] = DHOGHIOACME();
		array[6] = ODKNHODFPJK().ToStringFull();
		return string.Format("_Amount", array);
	}

	[SpecialName]
	public bool AJKJFECAAKD()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	public void KHMHEGIDGKK(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_BlurTexture");
		}
		if (DPNHODJHGJL != PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable { 
			{
				(byte)165,
				DPNHODJHGJL
			} });
		}
		PNAALABONJG = DPNHODJHGJL;
	}

	[SpecialName]
	internal void PKNPMJFGNIO(string DPNHODJHGJL)
	{
		LCKGKDLCFMC = DPNHODJHGJL;
	}

	public string IMKPICGDCNE()
	{
		object[] array = new object[2];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "_Value2" : "0 - default, 1 - left, 2 - right");
		array[4] = ((!PNAALABONJG) ? "#rt" : "sounds/no_hit");
		array[3] = MDLLBJEFCCJ;
		array[1] = PlayerCount;
		array[8] = FLIGPINOOGI().ToStringFull();
		return string.Format("BitsData", array);
	}

	[SpecialName]
	internal void CJDFCHEGBGK(string DPNHODJHGJL)
	{
		OOLGFNPPJFJ(DPNHODJHGJL);
	}

	[SpecialName]
	public int EGPGEMJNPFD()
	{
		if (PhotonNetwork.playerList != null)
		{
			return PhotonNetwork.playerList.Length;
		}
		return 0;
	}

	[SpecialName]
	public int PALHDLFINIP()
	{
		return PlayerCount;
	}

	[SpecialName]
	public bool NNDHBLBEKLI()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public bool MBHJNBADDEC()
	{
		return AJKJFECAAKD();
	}

	[SpecialName]
	public void EMNOOHLFLPH(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("file://");
		}
		if (DPNHODJHGJL > 72)
		{
			Debug.LogWarning("_MainTex2" + DPNHODJHGJL + "\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ");
			DPNHODJHGJL = 135;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(new Hashtable { 
			{
				(byte)210,
				(byte)DPNHODJHGJL
			} }, null, true);
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	public string[] DDMBOBMOODO()
	{
		return PropertiesListedInLobby;
	}

	[SpecialName]
	internal void DBEEFIJGPGC(string DPNHODJHGJL)
	{
		AJKPNAAMHMF(DPNHODJHGJL);
	}

	[SpecialName]
	public int DDDIFAMCNDO()
	{
		return MDLLBJEFCCJ;
	}

	internal Room(string IOJPMCOBHEJ, RoomOptions PCFOAMAODBD)
		: base(IOJPMCOBHEJ, null)
	{
		if (PCFOAMAODBD == null)
		{
			PCFOAMAODBD = new RoomOptions();
		}
		FMPBAGHEJDN = PCFOAMAODBD.IsVisible;
		PNAALABONJG = PCFOAMAODBD.IsOpen;
		MDLLBJEFCCJ = PCFOAMAODBD.MaxPlayers;
		FECDEAJPAAJ = false;
		NPOPPIMCDMN(PCFOAMAODBD.CustomRoomProperties);
		PropertiesListedInLobby = PCFOAMAODBD.CustomRoomPropertiesForLobby;
	}

	public void NCMLMADCFHJ(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)185] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)67] = KLNEGBJPIBO();
		PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(hashtable, hashtable2, true);
	}

	[SpecialName]
	public bool IHEBHOMEHIH()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	private void BNNFCKHICOP(string[] DPNHODJHGJL)
	{
		_003CHDDFDGJAIJD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void JIANOHENIBF(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("ready");
		}
		if (DPNHODJHGJL > -40)
		{
			Debug.LogWarning("<b>" + DPNHODJHGJL + "Set Satellite Emission");
			DPNHODJHGJL = -20;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(new Hashtable { 
			{
				(byte)239,
				(byte)DPNHODJHGJL
			} });
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	public int PEGAPCPKHAB()
	{
		return DHOGHIOACME();
	}

	[SpecialName]
	internal void AJKPNAAMHMF(string DPNHODJHGJL)
	{
		LCKGKDLCFMC = DPNHODJHGJL;
	}

	[SpecialName]
	private void EPKKLLKNBNE(string[] DPNHODJHGJL)
	{
		NNKLLBPFBNP(DPNHODJHGJL);
	}

	[SpecialName]
	public void IEAGMKEBIJP(bool DPNHODJHGJL)
	{
		AOFIBMMLNAA(DPNHODJHGJL);
	}

	[SpecialName]
	internal void PAEOJIPPLPF(string DPNHODJHGJL)
	{
		AJKPNAAMHMF(DPNHODJHGJL);
	}

	[SpecialName]
	public string[] MCHPEJLLEFM()
	{
		return FECOFGHMPPA();
	}

	[SpecialName]
	public void CFONNEIKKLP(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("SlidingArea");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable { 
			{
				(byte)107,
				DPNHODJHGJL
			} }, null, true);
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	public new string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount, base.CustomProperties.ToStringFull());
	}

	[SpecialName]
	public bool ANMHADBIJGN()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	private void NNKLLBPFBNP(string[] DPNHODJHGJL)
	{
		_003CHDDFDGJAIJD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool GBOINGMMKJD()
	{
		return JLHNLJGHMIJ();
	}

	[SpecialName]
	public void AOFIBMMLNAA(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_Value");
		}
		if (DPNHODJHGJL != PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable { 
			{
				(byte)253,
				DPNHODJHGJL
			} }, null, true);
		}
		PNAALABONJG = DPNHODJHGJL;
	}

	[SpecialName]
	public void KJFGMHJLDCK(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_Value4");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(new Hashtable { 
			{
				(byte)152,
				DPNHODJHGJL
			} }, null, true);
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	[SpecialName]
	public bool JLHNLJGHMIJ()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public int DHOGHIOACME()
	{
		if (PhotonNetwork.playerList != null)
		{
			return PhotonNetwork.playerList.Length;
		}
		return 0;
	}

	[SpecialName]
	public bool AEIGNIMAAMO()
	{
		return FMPBAGHEJDN;
	}

	public void DILKACMDELI()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)119] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)18] = JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable, hashtable2, true);
	}

	[SpecialName]
	public bool IFGKKKFBIHE()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public string[] DGJIEHFNKPO()
	{
		return PropertiesListedInLobby;
	}

	[SpecialName]
	public int MFKFOMBLHPH()
	{
		return EGPGEMJNPFD();
	}

	public override string FLJBCAOHMMN()
	{
		object[] array = new object[7];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "_Value2" : "[PlayerBase] Delete checkpoint data");
		array[8] = ((!PNAALABONJG) ? "_Color" : "color");
		array[2] = MDLLBJEFCCJ;
		array[7] = EGPGEMJNPFD();
		return string.Format("_MainTex2", array);
	}

	[SpecialName]
	public string[] KLNEGBJPIBO()
	{
		return GFEDJEMJEND;
	}

	[SpecialName]
	public bool AOCFNJKILCG()
	{
		return CLCCCFDCOBA();
	}

	[SpecialName]
	public void NDEBBNGMFFK(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("offsets");
		}
		if (DPNHODJHGJL > 148)
		{
			Debug.LogWarning("CameraFilterPack/Drawing_Manga2" + DPNHODJHGJL + "CameraFilterPack/Blend2Camera_LinearBurn");
			DPNHODJHGJL = -93;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FMDMPEMOAAB(new Hashtable { 
			{
				(byte)59,
				(byte)DPNHODJHGJL
			} });
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	internal void LFIOCJJFPPH(string DPNHODJHGJL)
	{
		AJKPNAAMHMF(DPNHODJHGJL);
	}

	[SpecialName]
	public int BBPPFMICKMI()
	{
		return DHOGHIOACME();
	}

	[SpecialName]
	protected internal int HLPFAGGIEKM()
	{
		return IPBANMNLDPC;
	}

	[SpecialName]
	public string[] LEABJPBNIKM()
	{
		return ExpectedUsers;
	}

	[SpecialName]
	public void PGADMIKCIDO(bool DPNHODJHGJL)
	{
		EMAPOENGEIN(DPNHODJHGJL);
	}

	[SpecialName]
	public int DEICKHNCDML()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public string[] KJIFDNOFGGP()
	{
		return FECOFGHMPPA();
	}

	[SpecialName]
	protected internal int FNPBFGNDHMC()
	{
		return LKHBADEOGKO();
	}

	[SpecialName]
	public bool JJHDBBKEKBL()
	{
		return IsVisible;
	}

	[SpecialName]
	public void DBFEOJAHPJA(int DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_TimeX");
		}
		if (DPNHODJHGJL > 105)
		{
			Debug.LogWarning("menu.selectedlevelid" + DPNHODJHGJL + "CameraFilterPack/BlurTiltShift_Hole");
			DPNHODJHGJL = 58;
		}
		if (DPNHODJHGJL != MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(new Hashtable { 
			{
				(byte)185,
				(byte)DPNHODJHGJL
			} });
		}
		MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	[SpecialName]
	protected internal void CAAADGPOBMA(int DPNHODJHGJL)
	{
		OPEKABONLBO(DPNHODJHGJL);
	}
}
