// OHGAIJCPAJB
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

internal class OHGAIJCPAJB : PhotonPeer
{
	private enum DBMPJAAINPM
	{
		CheckUserOnJoin = 1,
		DeleteCacheOnLeave = 2,
		SuppressRoomEvents = 4,
		PublishUserId = 8,
		DeleteNullProps = 0x10,
		BroadcastPropsChangeToAll = 0x20
	}

	private readonly Dictionary<byte, object> EJELAMOKKKA = new Dictionary<byte, object>();

	internal bool CPIPNMBMBDP => base.UsedProtocol == ConnectionProtocol.WebSocketSecure;

	public OHGAIJCPAJB(ConnectionProtocol MBOEJGPGFJB)
		: base(MBOEJGPGFJB)
	{
	}

	protected void IOOFIOPBHKM(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		AHLIHHHHNOH(hashtable);
	}

	public virtual bool KOKPMCDJGHA()
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_ScreenResolution");
		}
		return OpCustom(75, null, true);
	}

	public virtual bool ECHGNEANEGA(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Value5");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.FLIPOJABMED() != null)
		{
			dictionary[111] = GPDFHODMOIJ.ACMNPNLGMPK();
			return OpCustom(149, dictionary, true, 1, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-116) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("ShineEffect" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[9] = (byte)AMKMACFDKEC;
		dictionary[63] = (byte)NLNNMECNKEL;
		dictionary[219] = GKMFHELOOOH;
		dictionary[112] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[179] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.BABEDIEEKFN()))
			{
				dictionary[183] = GPDFHODMOIJ.BABEDIEEKFN();
			}
			if (GPDFHODMOIJ.KJAAHDFPDGJ() != (CustomAuthenticationType)198)
			{
				dictionary[23] = (byte)GPDFHODMOIJ.EHNNPFGHOLL();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.ACMNPNLGMPK()))
				{
					dictionary[136] = GPDFHODMOIJ.EOMEPOCICCP();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[47] = GPDFHODMOIJ.OGKOAMJKFND();
					}
					if (GPDFHODMOIJ.IGIJEIFPGBG() != null)
					{
						dictionary[151] = GPDFHODMOIJ.LACDBGDDOMD();
					}
				}
			}
		}
		return OpCustom(155, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	private void FFMCNJNMECK(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)62] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)13] = DPODHCMGCPF.IsVisible;
		hashtable[(byte)42] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[(byte)237] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[138] = hashtable;
		int num = 0;
		EKJLPPMJFBB[115] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 0;
			hashtable[(byte)168] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 1 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[100] = true;
			EKJLPPMJFBB[105] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[127] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 2;
			EKJLPPMJFBB[184] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[8] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 3;
			EKJLPPMJFBB[72] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= 0x5C;
		}
		EKJLPPMJFBB[110] = num;
	}

	public virtual bool JGKLCCPJJNN(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "[LevelEditorScene] Print Audio Wave: Start");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[128] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[157] = BBACCNINICP;
		}
		return OpCustom(34, dictionary, true, 1);
	}

	public virtual bool OpCreateRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpCreateRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[byte.MaxValue] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[213] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[212] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[238] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[249] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[250] = true;
			}
			KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(227, dictionary, true);
	}

	public virtual bool OpRaiseEvent(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[244] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[245] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[247] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[246] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[240] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[252] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[234] = true;
			}
		}
		return OpCustom(253, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	protected internal bool OONILMBMJHC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)6, "VisionBlur");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 5)
			{
				base.Listener.DebugReturn((DebugLevel)7, "BitsData");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(128, FPBCPOGCCBD);
		dictionary.Add(238, KHACEEGCPEP);
		dictionary.Add(234, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(98, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[53] = false;
		}
		return OpCustom(11, dictionary, false, 0, false);
	}

	public virtual bool KHJHJILCFGO(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_ScreenResolution");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.EOMEPOCICCP() != null)
		{
			dictionary[174] = GPDFHODMOIJ.Token;
			return OpCustom(90, dictionary, false, 1, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)27 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("#pleasewait" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[151] = (byte)AMKMACFDKEC;
		dictionary[173] = (byte)NLNNMECNKEL;
		dictionary[184] = GKMFHELOOOH;
		dictionary[107] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[169] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NNDJMHDCCEM()))
			{
				dictionary[103] = GPDFHODMOIJ.NNDJMHDCCEM();
			}
			if ((int)GPDFHODMOIJ.AuthType != -80)
			{
				dictionary[227] = (byte)GPDFHODMOIJ.KJAAHDFPDGJ();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[94] = GPDFHODMOIJ.NDKBOHNOFIF();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.NILIHMHPGDD()))
					{
						dictionary[10] = GPDFHODMOIJ.CDGJMFDHDFJ();
					}
					if (GPDFHODMOIJ.LGPEDFPIKGO() != null)
					{
						dictionary[160] = GPDFHODMOIJ.PLLAELCJGEM();
					}
				}
			}
		}
		return OpCustom(233, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	public virtual bool CIKNAPBIKBG()
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)8, "Day_");
		}
		return OpCustom(190, null, true);
	}

	public virtual bool ACEDLCAELNF(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[248] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[73] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[163] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[126] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[146] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[173] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[235] = false;
			}
		}
		return OpCustom(81, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	public virtual bool OpJoinLobby(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinLobby()");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.IsDefault)
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[213] = PKPEDDGHALP.Name;
			dictionary[212] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(229, dictionary, true);
	}

	public virtual bool MCDLKJJNOKN(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[245] = PPNEJGFIAJP;
		return OpCustom(101, dictionary, false, 1, true);
	}

	public virtual bool MHLCJBCFMNH()
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)6, "_ScreenResolution");
		}
		return OpCustom(199, null, true);
	}

	protected internal bool GMKICGKBIKI(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)7, "COMPLETED");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 8)
			{
				base.Listener.DebugReturn((DebugLevel)7, "_HardBlend");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(71, FPBCPOGCCBD);
		dictionary.Add(138, KHACEEGCPEP);
		dictionary.Add(153, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(253, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[85] = false;
		}
		return OpCustom(108, dictionary, false, 1, false);
	}

	public virtual bool OpGetRegions(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[224] = PPNEJGFIAJP;
		return OpCustom(220, dictionary, true, 0, true);
	}

	public virtual bool OpGetGameList(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList()");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. Lobby cannot be null.");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. LobbyType must be SqlLobby.");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[213] = PKPEDDGHALP.Name;
		dictionary[212] = (byte)PKPEDDGHALP.Type;
		dictionary[245] = INIFMIHFOGD;
		return OpCustom(217, dictionary, true);
	}

	public bool AIGDMIHGJAN(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	public virtual bool OpAuthenticateOnce(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[221] = GPDFHODMOIJ.Token;
			return OpCustom(231, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == EncryptionMode.DatagramEncryption && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: " + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[195] = (byte)AMKMACFDKEC;
		dictionary[193] = (byte)NLNNMECNKEL;
		dictionary[220] = GKMFHELOOOH;
		dictionary[224] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[210] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[225] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != CustomAuthenticationType.None)
			{
				dictionary[217] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[221] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[216] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[214] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return OpCustom(231, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	public virtual bool MOGIKKKFHFI(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[188] = PPNEJGFIAJP;
		return OpCustom(83, dictionary, true, 0, false);
	}

	public virtual bool PFDLKPNDDLL(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)4, "Current xp: ");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[(byte)80] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[69] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[62] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[207] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[184] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[161] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[2] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(94, dictionary, false);
	}

	public virtual bool JCCNCJFOMNB(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[117] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[188] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[99] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[110] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[101] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[135] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[253] = false;
			}
		}
		return OpCustom(181, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	protected internal bool LJEFICMOPMO(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor()");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(251, FPBCPOGCCBD);
		dictionary.Add(254, KHACEEGCPEP);
		dictionary.Add(250, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(231, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[234] = true;
		}
		return OpCustom(252, dictionary, true, 0, false);
	}

	private void KCAACFHDJAF(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)21] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)112] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[(byte)116] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[(byte)94] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[56] = hashtable;
		int num = 0;
		EKJLPPMJFBB[117] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 2;
			hashtable[(byte)121] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[127] = false;
			EKJLPPMJFBB[128] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[192] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 3;
			EKJLPPMJFBB[160] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[175] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 2;
			EKJLPPMJFBB[199] = true;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= 0x49;
		}
		EKJLPPMJFBB[72] = num;
	}

	private void HCFNDKNMBAD(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)45] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)117] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[(byte)105] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[(byte)36] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[92] = hashtable;
		int num = 1;
		EKJLPPMJFBB[45] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 7;
			hashtable[(byte)236] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[73] = false;
			EKJLPPMJFBB[89] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[198] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 7;
			EKJLPPMJFBB[82] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[71] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 7;
			EKJLPPMJFBB[175] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= -55;
		}
		EKJLPPMJFBB[85] = num;
	}

	public virtual bool PHCHODANOCM(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)4, "{0}");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.AGBMBKMONMJ())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[2] = PKPEDDGHALP.Name;
			dictionary[78] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(143, dictionary, false);
	}

	public virtual bool CMAAGANHEKP(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(114, dictionary, false);
	}

	public virtual bool MHIMMALLHJM(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)7, "CameraFilterPack/Atmosphere_Fog");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[161] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.FJHAAFMHNMI() != null)
		{
			dictionary[113] = GPDFHODMOIJ.GKCKHIMAJJD();
			return OpCustom(64, dictionary, true, 1, true);
		}
		dictionary[59] = GKMFHELOOOH;
		dictionary[80] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[106] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.ABJLGGHEFOB()))
			{
				dictionary[48] = GPDFHODMOIJ.FENGKLEBAFM();
			}
			if ((int)GPDFHODMOIJ.EAHPMDFBDGK() != -66)
			{
				if (!KDPCAPGOEBE() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "KickThePlayer");
					return true;
				}
				dictionary[116] = (byte)GPDFHODMOIJ.KJOCGAHCLGC();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DDGHJJHKHJN()))
				{
					dictionary[153] = GPDFHODMOIJ.ACMNPNLGMPK();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[122] = GPDFHODMOIJ.IIPDGFEDEJP();
					}
					if (GPDFHODMOIJ.LGPEDFPIKGO() != null)
					{
						dictionary[105] = GPDFHODMOIJ.PLLAELCJGEM();
					}
				}
			}
		}
		bool flag = OpCustom(76, dictionary, true, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "FullscreenToggle");
		}
		return flag;
	}

	public virtual bool ONANIHOAHDB(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Anomaly_Distortion");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(82, EJELAMOKKKA, true);
	}

	protected internal bool AHLIHHHHNOH(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "Texture2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(105, MJJMNIDHDEC);
		dictionary.Add(159, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(127, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[9] = true;
		}
		return OpCustom(181, dictionary, false, 0, true);
	}

	public virtual bool JMLDDBMEHLA(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(182, dictionary, false);
	}

	protected internal bool PFMDCFLEFDJ(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_ScreenResolution");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 2)
			{
				base.Listener.DebugReturn((DebugLevel)6, "Creating new item...");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(77, FPBCPOGCCBD);
		dictionary.Add(114, KHACEEGCPEP);
		dictionary.Add(221, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(130, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[9] = true;
		}
		return OpCustom(6, dictionary, false, 0, true);
	}

	public virtual bool OIDGDPNFEKI(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)6, "{0}");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[158] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[170] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[47] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[181] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[117] = (byte)1;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[70] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[162] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[192] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				HCFNDKNMBAD(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(53, dictionary, true);
	}

	protected internal bool PGBPNPHDNJB(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "CameraFilterPack_Paper3");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 6)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack/Retro_Loading");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(89, FPBCPOGCCBD);
		dictionary.Add(191, KHACEEGCPEP);
		dictionary.Add(115, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(228, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[118] = false;
		}
		return OpCustom(187, dictionary, false, 1, true);
	}

	public virtual bool PAHIOHPIFEN(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Destroy all spawned environment objects");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[249] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[160] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[85] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[244] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[179] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[170] = true;
			}
			FFMCNJNMECK(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(85, dictionary, false);
	}

	public virtual bool OpJoinRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[byte.MaxValue] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[215] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[213] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[212] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[215] = (byte)3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[238] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[249] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[250] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(226, dictionary, true);
	}

	public virtual bool LKAMBGLNOBI(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "#ok");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return false;
		}
		return OpCustom(63, EJELAMOKKKA, true);
	}

	public virtual bool JJEKHIFJGHP(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "RequestForPickupItems");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[(byte)177] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[139] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[168] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[11] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[177] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[177] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[90] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(181, dictionary, true);
	}

	private void FIMLJEFAIOD(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)41] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)108] = DPODHCMGCPF.MDPFAPDEGHH();
		hashtable[(byte)90] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)0] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[69] = hashtable;
		int num = 1;
		EKJLPPMJFBB[190] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 4;
			hashtable[(byte)53] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[132] = false;
			EKJLPPMJFBB[151] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[90] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 0;
			EKJLPPMJFBB[188] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[126] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 2;
			EKJLPPMJFBB[5] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= 0x49;
		}
		EKJLPPMJFBB[50] = num;
	}

	public bool OpSetCustomPropertiesOfActor(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return LJEFICMOPMO(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	public virtual bool NFDCFGAHJHI(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(114, dictionary, false);
	}

	public virtual bool LCFPIMAKDDB(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)6, "shaders");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 8)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "settings_bindings_controller_type");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)7)
		{
			if ((int)DebugOut >= 4)
			{
				base.Listener.DebugReturn((DebugLevel)8, "ticket");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[191] = PKPEDDGHALP.Name;
		dictionary[64] = (byte)PKPEDDGHALP.Type;
		dictionary[135] = INIFMIHFOGD;
		return OpCustom(99, dictionary, false);
	}

	public bool OpSetCustomPropertiesOfRoom(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys());
	}

	public virtual bool HHNIHHLKCEF(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "settings.enablehitsoundsinnormal");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[121] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[62] = BBACCNINICP;
		}
		return OpCustom(57, dictionary, false, 1);
	}

	protected void IAEPEJHOCJO(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		AHLIHHHHNOH(hashtable);
	}

	[SpecialName]
	internal bool KDPCAPGOEBE()
	{
		return base.UsedProtocol == ConnectionProtocol.Tcp;
	}

	public bool PDJBDPBJCNK(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	public virtual bool MGPGALNFDDC(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Radius");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[76] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[36] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[199] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[51] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[171] = (byte)8;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[152] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[24] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[160] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PNLPKLMEGKP(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(171, dictionary, true);
	}

	[SpecialName]
	internal bool MJPPHBEEGAO()
	{
		return base.UsedProtocol == (ConnectionProtocol)7;
	}

	public virtual bool IANNCEHAAOF(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[197] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[42] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[62] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[15] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[8] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[212] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[196] = false;
			}
		}
		return OpCustom(74, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	public virtual bool HCFKMEDAAKD(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)8, "0");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[46] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[183] = BBACCNINICP;
		}
		return OpCustom(180, dictionary, true, 1);
	}

	public virtual bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(222, dictionary, true);
	}

	public virtual bool JGNNMPNBAAM(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[85] = PPNEJGFIAJP;
		return OpCustom(254, dictionary, false, 0, true);
	}

	public virtual bool KPPNFHBFDIF(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)7, ".played");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IEKBHDFCJCC() != null)
		{
			dictionary[108] = GPDFHODMOIJ.AOFNNEBEKOL();
			return OpCustom(134, dictionary, true, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-65) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("_TimeX" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[113] = (byte)AMKMACFDKEC;
		dictionary[72] = (byte)NLNNMECNKEL;
		dictionary[67] = GKMFHELOOOH;
		dictionary[162] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[195] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.FENGKLEBAFM()))
			{
				dictionary[178] = GPDFHODMOIJ.DGGNHDMPPJK();
			}
			if ((int)GPDFHODMOIJ.KJOCGAHCLGC() != -102)
			{
				dictionary[40] = (byte)GPDFHODMOIJ.EAHPMDFBDGK();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.FMBOGMIPLOD()))
				{
					dictionary[212] = GPDFHODMOIJ.ACMNPNLGMPK();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.CLEHOIKGCMG()))
					{
						dictionary[81] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.ELACGNMDCJF() != null)
					{
						dictionary[77] = GPDFHODMOIJ.JJBFICBMMLF();
					}
				}
			}
		}
		return OpCustom(203, dictionary, false, 1, base.IsEncryptionAvailable);
	}

	public virtual bool GAPGMKLFDMF()
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "CameraFilterPack/Drawing_Toon");
		}
		return OpCustom(195, null, false);
	}

	public virtual bool PCPGJIEICIM(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)4, ".GoalProgress");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[167] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[158] = BBACCNINICP;
		}
		return OpCustom(176, dictionary, true, 1);
	}

	public virtual bool JMPOEDIBOAK(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_Value");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[184] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[153] = BBACCNINICP;
		}
		return OpCustom(100, dictionary, false, 1);
	}

	public virtual bool JNLBJAKLDKO(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[138] = PPNEJGFIAJP;
		return OpCustom(177, dictionary, true, 0, false);
	}

	protected internal bool DPEFFAKCAFC(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)8, " has ");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(121, MJJMNIDHDEC);
		dictionary.Add(249, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(133, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[18] = true;
		}
		return OpCustom(204, dictionary, true, 0, false);
	}

	public virtual bool BBEADFGENFD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, " to: ");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 0)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "menu.selectedlevelid");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != (LobbyType)8)
		{
			if ((int)DebugOut >= 0)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "_ScreenResolution");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[248] = PKPEDDGHALP.Name;
		dictionary[173] = (byte)PKPEDDGHALP.Type;
		dictionary[138] = INIFMIHFOGD;
		return OpCustom(157, dictionary, false);
	}

	public virtual bool OpSettings(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "OpSettings()");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(218, EJELAMOKKKA, true);
	}

	public virtual bool PADIGBHNBHN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_LayerThickness");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.FMBOGMIPLOD() != null)
		{
			dictionary[115] = GPDFHODMOIJ.FLIPOJABMED();
			return OpCustom(91, dictionary, true, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-101) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("_Value3" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[0] = (byte)AMKMACFDKEC;
		dictionary[115] = (byte)NLNNMECNKEL;
		dictionary[169] = GKMFHELOOOH;
		dictionary[239] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[152] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.FENGKLEBAFM()))
			{
				dictionary[135] = GPDFHODMOIJ.BABEDIEEKFN();
			}
			if ((int)GPDFHODMOIJ.PHJLKGJNCIA() != -189)
			{
				dictionary[67] = (byte)GPDFHODMOIJ.KJAAHDFPDGJ();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.NDKBOHNOFIF()))
				{
					dictionary[180] = GPDFHODMOIJ.AOFNNEBEKOL();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OGKOAMJKFND()))
					{
						dictionary[158] = GPDFHODMOIJ.IIPDGFEDEJP();
					}
					if (GPDFHODMOIJ.CMKMANEGMDO() != null)
					{
						dictionary[252] = GPDFHODMOIJ.CMKMANEGMDO();
					}
				}
			}
		}
		return OpCustom(84, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	private void PNLPKLMEGKP(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)66] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)58] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[(byte)124] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)217] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[30] = hashtable;
		int num = 0;
		EKJLPPMJFBB[89] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 6;
			hashtable[(byte)248] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[83] = false;
			EKJLPPMJFBB[23] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[172] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 0;
			EKJLPPMJFBB[230] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[76] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 5;
			EKJLPPMJFBB[251] = true;
		}
		if (DPODHCMGCPF.DeleteNullProperties)
		{
			num |= 0x63;
		}
		EKJLPPMJFBB[47] = num;
	}

	public virtual bool OpLeaveRoom(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[233] = EEPAJBBCGJK;
		}
		return OpCustom(254, dictionary, true);
	}

	private void JOLOKHNHHHJ(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)12] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)25] = DPODHCMGCPF.MDPFAPDEGHH();
		hashtable[(byte)123] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)91] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[12] = hashtable;
		int num = 0;
		EKJLPPMJFBB[62] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 0;
			hashtable[(byte)130] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[105] = false;
			EKJLPPMJFBB[154] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[26] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.GEEECIMLLBB())
		{
			num |= 7;
			EKJLPPMJFBB[158] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[5] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 5;
			EKJLPPMJFBB[139] = false;
		}
		if (DPODHCMGCPF.DeleteNullProperties)
		{
			num |= 0x7F;
		}
		EKJLPPMJFBB[79] = num;
	}

	public virtual bool DJJIHHGPELA(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_Value9");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[101] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[90] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[157] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[150] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[82] = (byte)8;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[15] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[175] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[194] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PNLPKLMEGKP(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(92, dictionary, false);
	}

	public virtual bool OGKPIFFLGPN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Populate Mesh Data");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.FLIPOJABMED() != null)
		{
			dictionary[76] = GPDFHODMOIJ.EOMEPOCICCP();
			return OpCustom(198, dictionary, false, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)117 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("MenuScene" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[175] = (byte)AMKMACFDKEC;
		dictionary[63] = (byte)NLNNMECNKEL;
		dictionary[188] = GKMFHELOOOH;
		dictionary[175] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[72] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.ABJLGGHEFOB()))
			{
				dictionary[233] = GPDFHODMOIJ.NOBDNHBOGFG();
			}
			if (GPDFHODMOIJ.EMHCPPOAGNB() != (CustomAuthenticationType)190)
			{
				dictionary[116] = (byte)GPDFHODMOIJ.LECPDEEOHJP();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.EOMEPOCICCP()))
				{
					dictionary[162] = GPDFHODMOIJ.AOFNNEBEKOL();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AAAIEKBNFPJ()))
					{
						dictionary[83] = GPDFHODMOIJ.HDGNLACBEDN();
					}
					if (GPDFHODMOIJ.LIJIKHHFJHG() != null)
					{
						dictionary[25] = GPDFHODMOIJ.JJBFICBMMLF();
					}
				}
			}
		}
		return OpCustom(86, dictionary, false, 1, base.IsEncryptionAvailable);
	}

	private void CDGJJKDFPLA(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)105] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)118] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[(byte)7] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)148] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[110] = hashtable;
		int num = 1;
		EKJLPPMJFBB[121] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 2;
			hashtable[(byte)22] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 1 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[62] = true;
			EKJLPPMJFBB[214] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 1)
		{
			EKJLPPMJFBB[67] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 2;
			EKJLPPMJFBB[149] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[100] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 5;
			EKJLPPMJFBB[73] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= -88;
		}
		EKJLPPMJFBB[120] = num;
	}

	protected internal bool IILDKFGHOHK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "StopSounds");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(144, MJJMNIDHDEC);
		dictionary.Add(182, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(180, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[91] = false;
		}
		return OpCustom(97, dictionary, false, 1, false);
	}

	public virtual bool NMPNBCKAJFH(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_MatrixSpeed");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)51] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[252] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[22] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[209] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[52] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[158] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[80] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(126, dictionary, false);
	}

	public virtual bool IIAJHPKHDNO(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_Value3");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[67] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[183] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[216] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[206] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[58] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[168] = true;
			}
			DCDIKNEBAMN(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(233, dictionary, false);
	}

	public virtual bool MOEMDAAIALC(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[197] = PPNEJGFIAJP;
		return OpCustom(131, dictionary, false, 1, true);
	}

	public bool HAKHCPJDFEJ(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return IILDKFGHOHK(MJJMNIDHDEC.StripToStringKeys());
	}

	public bool OOCDPAAEFAN(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return BACNBJMIBOK(MJJMNIDHDEC.StripToStringKeys());
	}

	public virtual bool AHNEABADBCL(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[83] = PPNEJGFIAJP;
		return OpCustom(15, dictionary, true, 1, true);
	}

	public virtual bool MBEMCMKGFEB(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(128, dictionary, true);
	}

	public virtual bool BKMFOEOLKIF(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)7, "[Singleton] multiple instances of '");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn((DebugLevel)4, "_ScreenResolution");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != (LobbyType)5)
		{
			if ((int)DebugOut >= 1)
			{
				base.Listener.DebugReturn((DebugLevel)4, "maps.");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[82] = PKPEDDGHALP.Name;
		dictionary[131] = (byte)PKPEDDGHALP.Type;
		dictionary[159] = INIFMIHFOGD;
		return OpCustom(234, dictionary, false);
	}

	protected internal bool ENLHKMFBDMG(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "PublishButton");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(166, MJJMNIDHDEC);
		dictionary.Add(194, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(220, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[25] = true;
		}
		return OpCustom(138, dictionary, false, 1, true);
	}

	public virtual bool HPDDLOGBJEI(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "DPADHOR");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[189] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[112] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[68] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[168] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[146] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[79] = false;
			}
			KKGGPEIHPFE(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(190, dictionary, true);
	}

	protected internal bool GLAAOHKMLGC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "player.greenlollipop");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 4)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "880078120");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(204, FPBCPOGCCBD);
		dictionary.Add(152, KHACEEGCPEP);
		dictionary.Add(174, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(107, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[179] = true;
		}
		return OpCustom(168, dictionary, false, 1, false);
	}

	public virtual bool DEMEGDBHOHN(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "\n\n#");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 0)
			{
				base.Listener.DebugReturn((DebugLevel)7, "Netw. Sim.");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != 0)
		{
			if ((int)DebugOut >= 2)
			{
				base.Listener.DebugReturn((DebugLevel)8, "RecieveChatActionMessage");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[164] = PKPEDDGHALP.Name;
		dictionary[14] = (byte)PKPEDDGHALP.Type;
		dictionary[76] = INIFMIHFOGD;
		return OpCustom(83, dictionary, true);
	}

	public virtual bool CALHIBNNKGC()
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "stretchWidth");
		}
		return OpCustom(119, null, true);
	}

	public virtual bool FLHOCGGFDOK()
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_Level");
		}
		return OpCustom(107, null, false);
	}

	private void CINJBEFHCBP(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)162] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)62] = DPODHCMGCPF.IsVisible;
		hashtable[(byte)150] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[(byte)155] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[6] = hashtable;
		int num = 0;
		EKJLPPMJFBB[80] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 1;
			hashtable[(byte)56] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[38] = true;
			EKJLPPMJFBB[77] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 1)
		{
			EKJLPPMJFBB[133] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 5;
			EKJLPPMJFBB[206] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[61] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 0;
			EKJLPPMJFBB[185] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= 0x3A;
		}
		EKJLPPMJFBB[175] = num;
	}

	protected internal bool JBBEGBKFAMH(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Received your NickName from server. Updating local value to: {0}");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 6)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "Bad parameters for setbool! Use <key> <value>");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(196, FPBCPOGCCBD);
		dictionary.Add(75, KHACEEGCPEP);
		dictionary.Add(114, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(217, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[124] = true;
		}
		return OpCustom(58, dictionary, false, 0, true);
	}

	public virtual bool NLFGGGLGINC(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Value2");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(210, EJELAMOKKKA, true);
	}

	public virtual bool HKNJIFLAJOC(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, ";");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.GNNCOPOEBLP())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[196] = PKPEDDGHALP.Name;
			dictionary[158] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(35, dictionary, true);
	}

	public virtual bool OpChangeGroups(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "OpChangeGroups()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[239] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[238] = BBACCNINICP;
		}
		return OpCustom(248, dictionary, true, 0);
	}

	public bool JMBLBOODGDD(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return PFMDCFLEFDJ(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, true);
	}

	public virtual bool JCLBBMOEFNM(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Value2");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(36, EJELAMOKKKA, false);
	}

	private void KFMBAGPOOPO(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)253] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)254] = DPODHCMGCPF.IsVisible;
		hashtable[(byte)250] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[byte.MaxValue] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[248] = hashtable;
		int num = 0;
		EKJLPPMJFBB[241] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 2;
			hashtable[(byte)249] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[232] = true;
			EKJLPPMJFBB[235] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[236] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 4;
			EKJLPPMJFBB[237] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[204] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 8;
			EKJLPPMJFBB[239] = true;
		}
		if (DPODHCMGCPF.DeleteNullProperties)
		{
			num |= 0x10;
		}
		EKJLPPMJFBB[191] = num;
	}

	protected internal bool POCGAHHKCLG(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "ns.exitgames.com");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(72, MJJMNIDHDEC);
		dictionary.Add(104, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(159, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[221] = false;
		}
		return OpCustom(125, dictionary, true, 0, true);
	}

	public virtual bool PMGECCFBGIG(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(25, dictionary, true);
	}

	public virtual bool LBLCMEBOENM(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "The given 2D texture ");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[80] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.AOFNNEBEKOL() != null)
		{
			dictionary[66] = GPDFHODMOIJ.NDKBOHNOFIF();
			return OpCustom(233, dictionary, true, 1, false);
		}
		dictionary[166] = GKMFHELOOOH;
		dictionary[125] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[129] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[103] = GPDFHODMOIJ.ELOLBCJBILP();
			}
			if (GPDFHODMOIJ.KJAAHDFPDGJ() != (CustomAuthenticationType)151)
			{
				if (!CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack/Drawing_Paper3");
					return false;
				}
				dictionary[98] = (byte)GPDFHODMOIJ.LECPDEEOHJP();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.FHGOCDMCAJJ()))
				{
					dictionary[46] = GPDFHODMOIJ.IEKBHDFCJCC();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.GIMMNIKDHII()))
					{
						dictionary[127] = GPDFHODMOIJ.PIOLAKFMJIH();
					}
					if (GPDFHODMOIJ.LIJIKHHFJHG() != null)
					{
						dictionary[12] = GPDFHODMOIJ.ELACGNMDCJF();
					}
				}
			}
		}
		bool flag = OpCustom(199, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "GenerationMenu");
		}
		return flag;
	}

	public virtual bool IDCMLGBBFMG(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)7, "_BlurCoe");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[(byte)92] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[100] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[41] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[99] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[10] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[105] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[130] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(126, dictionary, true);
	}

	public virtual bool KDOPBHGHJMB()
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "skins");
		}
		return OpCustom(112, null, false);
	}

	public virtual bool OpAuthenticate(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[211] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[221] = GPDFHODMOIJ.Token;
			return OpCustom(230, dictionary, true, 0, false);
		}
		dictionary[220] = GKMFHELOOOH;
		dictionary[224] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[210] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[225] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != CustomAuthenticationType.None)
			{
				if (!CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.");
					return false;
				}
				dictionary[217] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[221] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[216] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[214] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = OpCustom(230, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.");
		}
		return flag;
	}

	public virtual bool HLMCAMEGCGN(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[226] = EEPAJBBCGJK;
		}
		return OpCustom(156, dictionary, true);
	}

	public virtual bool MCIMCKDHHPL(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_DistortionSize");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[235] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[60] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[139] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[71] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[41] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[44] = true;
			}
			FIMLJEFAIOD(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(48, dictionary, false);
	}

	public OHGAIJCPAJB(IPhotonPeerListener LONKELGPCJD, ConnectionProtocol MBOEJGPGFJB)
		: this(MBOEJGPGFJB)
	{
		base.Listener = LONKELGPCJD;
	}

	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRandomRoom()");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[byte.MaxValue] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[248] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[223] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[213] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[212] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[245] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[238] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(225, dictionary, true);
	}

	private void JLNGODGDCNE(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)68] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)95] = DPODHCMGCPF.MDPFAPDEGHH();
		hashtable[(byte)84] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)191] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[235] = hashtable;
		int num = 1;
		EKJLPPMJFBB[229] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 0;
			hashtable[(byte)119] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[94] = false;
			EKJLPPMJFBB[96] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 1)
		{
			EKJLPPMJFBB[145] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 7;
			EKJLPPMJFBB[86] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[78] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 6;
			EKJLPPMJFBB[221] = true;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= -111;
		}
		EKJLPPMJFBB[57] = num;
	}

	private void KKGGPEIHPFE(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)107] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)135] = DPODHCMGCPF.MDPFAPDEGHH();
		hashtable[(byte)143] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[1]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)134] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[111] = hashtable;
		int num = 1;
		EKJLPPMJFBB[121] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 1;
			hashtable[(byte)207] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 1 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[102] = false;
			EKJLPPMJFBB[164] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[110] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.GEEECIMLLBB())
		{
			num |= 3;
			EKJLPPMJFBB[13] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[191] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 7;
			EKJLPPMJFBB[28] = false;
		}
		if (DPODHCMGCPF.DeleteNullProperties)
		{
			num |= -12;
		}
		EKJLPPMJFBB[129] = num;
	}

	protected void AGIKJINNDPN(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		HFECLDIOHNJ(hashtable);
	}

	public bool KOGBJDNCNOF(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return PGBPNPHDNJB(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	protected internal bool BACNBJMIBOK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CameraFilterPack/TV_Video3D");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(210, MJJMNIDHDEC);
		dictionary.Add(173, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(20, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[218] = false;
		}
		return OpCustom(109, dictionary, false, 1, true);
	}

	protected void EFFDLAHOOAL(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		BACNBJMIBOK(hashtable, null, true);
	}

	private void DCDIKNEBAMN(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)203] = DPODHCMGCPF.ALKCGCIEJDD();
		hashtable[(byte)185] = DPODHCMGCPF.IsVisible;
		hashtable[(byte)144] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[(byte)243] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[188] = hashtable;
		int num = 0;
		EKJLPPMJFBB[215] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 6;
			hashtable[(byte)89] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 1 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[59] = true;
			EKJLPPMJFBB[226] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 1)
		{
			EKJLPPMJFBB[191] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 8;
			EKJLPPMJFBB[250] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[83] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 1;
			EKJLPPMJFBB[96] = false;
		}
		if (DPODHCMGCPF.IAMGOANHKPI())
		{
			num |= -85;
		}
		EKJLPPMJFBB[120] = num;
	}

	public virtual bool FFHOIPOHIOL(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[209] = PPNEJGFIAJP;
		return OpCustom(90, dictionary, false, 0, false);
	}

	public virtual bool OpLeaveLobby()
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpLeaveLobby()");
		}
		return OpCustom(228, null, true);
	}

	public virtual bool KJNCENGOFBE(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[105] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[71] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[106] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[190] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[38] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[141] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[134] = false;
			}
		}
		return OpCustom(127, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	protected void GLAEBANEKPE(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		BACNBJMIBOK(hashtable, null, true);
	}

	public virtual bool FHMJOIADBFH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CrosshairOpacitySlider");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[223] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[78] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[184] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[208] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[65] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[42] = false;
			}
			FFMCNJNMECK(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(175, dictionary, true);
	}

	public virtual bool KNPKHHNCKDN()
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn((DebugLevel)7, "GlassesColor");
		}
		return OpCustom(199, null, false);
	}

	public virtual bool BGIJGNONHEO(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[197] = EEPAJBBCGJK;
		}
		return OpCustom(194, dictionary, false);
	}

	public bool JOFCNAHNPON(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return BACNBJMIBOK(MJJMNIDHDEC.StripToStringKeys());
	}

	public virtual bool KGBFGMPBEEN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)6, "offsets");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[168] = GPDFHODMOIJ.ACMNPNLGMPK();
			return OpCustom(81, dictionary, false, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-32) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("/" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[45] = (byte)AMKMACFDKEC;
		dictionary[78] = (byte)NLNNMECNKEL;
		dictionary[100] = GKMFHELOOOH;
		dictionary[199] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[186] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.FENGKLEBAFM()))
			{
				dictionary[65] = GPDFHODMOIJ.ABJLGGHEFOB();
			}
			if ((int)GPDFHODMOIJ.KJAAHDFPDGJ() != -19)
			{
				dictionary[144] = (byte)GPDFHODMOIJ.IHLAMAEPKEO();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.FJHAAFMHNMI()))
				{
					dictionary[143] = GPDFHODMOIJ.FLIPOJABMED();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[196] = GPDFHODMOIJ.OGKOAMJKFND();
					}
					if (GPDFHODMOIJ.LACDBGDDOMD() != null)
					{
						dictionary[168] = GPDFHODMOIJ.LIJIKHHFJHG();
					}
				}
			}
		}
		return OpCustom(169, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	protected internal bool HFECLDIOHNJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(251, MJJMNIDHDEC);
		dictionary.Add(250, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(231, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[234] = true;
		}
		return OpCustom(252, dictionary, true, 0, false);
	}
}
