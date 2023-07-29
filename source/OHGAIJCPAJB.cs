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

	public virtual bool HKCPBMODCGA(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "PlayButton");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[109] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[76] = BBACCNINICP;
		}
		return OpCustom(249, dictionary, false, 0);
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

	public virtual bool CGIPKIOMHCO(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[76] = PPNEJGFIAJP;
		return OpCustom(121, dictionary, false, 0, true);
	}

	public virtual bool BDCHBCMHOGD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Value5");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn((DebugLevel)4, "path");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)5)
		{
			if ((int)DebugOut >= 6)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "_ScreenResolution");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[102] = PKPEDDGHALP.Name;
		dictionary[35] = (byte)PKPEDDGHALP.Type;
		dictionary[121] = INIFMIHFOGD;
		return OpCustom(148, dictionary, true);
	}

	public bool OHPJAAGIDJP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return IILDKFGHOHK(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	public virtual bool NCAJBJHONIN(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[110] = EEPAJBBCGJK;
		}
		return OpCustom(61, dictionary, false);
	}

	public virtual bool DEBJAENPEII(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Blur_GaussianBlur");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)206] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[159] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[178] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[112] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[110] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[72] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[153] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(210, dictionary, false);
	}

	public virtual bool MPELLFNHBGN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Value3");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[45] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[39] = GPDFHODMOIJ.DGINDFBNNDO();
			return OpCustom(30, dictionary, false, 0, true);
		}
		dictionary[57] = GKMFHELOOOH;
		dictionary[145] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[10] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[94] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)193)
			{
				if (!CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "_Blue_G");
					return true;
				}
				dictionary[94] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[116] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[109] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[79] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = OpCustom(173, dictionary, false, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "DPADVER");
		}
		return flag;
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

	public virtual bool OpGetRegions(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[224] = PPNEJGFIAJP;
		return OpCustom(220, dictionary, true, 0, true);
	}

	protected void PHIOGBIOJFF(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		FEPNICODBNC(hashtable, null, true);
	}

	public bool OpSetCustomPropertiesOfRoom(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys());
	}

	public bool INMMEFNAMIP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return APMINOMEBPE(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	protected void KFEGIKMAGDH(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		OABLOBEGOPJ(hashtable);
	}

	public virtual bool FHBKMBGDDMC(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Value2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[202] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[147] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[21] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[63] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[129] = (byte)8;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[15] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[159] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[253] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(29, dictionary, true);
	}

	public virtual bool BEHIACDGHHC(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Green_C");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.KHPAOCFGPGM())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[110] = PKPEDDGHALP.Name;
			dictionary[142] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(193, dictionary, false);
	}

	public virtual bool BBFIHFBJIKE()
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "/");
		}
		return OpCustom(123, null, true);
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

	public virtual bool OBGLEAGJJKK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(160, dictionary, false);
	}

	public bool ANLEJMLBKLN(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return IFBHCMGLLIM(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, true);
	}

	public bool GHMNEFECONA(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys());
	}

	public virtual bool KLLLCEHNJED(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(141, dictionary, false);
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

	public virtual bool BGIJGNONHEO(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[36] = EEPAJBBCGJK;
		}
		return OpCustom(108, dictionary, true);
	}

	public virtual bool HGNDNHICNKF(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn((DebugLevel)4, "[Left]");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[144] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[21] = GPDFHODMOIJ.DGINDFBNNDO();
			return OpCustom(30, dictionary, true, 1, false);
		}
		dictionary[78] = GKMFHELOOOH;
		dictionary[62] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[97] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[189] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)168)
			{
				if (!LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "maps.");
					return true;
				}
				dictionary[1] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[154] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[214] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[134] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		bool flag = OpCustom(71, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "id");
		}
		return flag;
	}

	public virtual bool HIKIDBBNFBM(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)7, "Set particles color");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[23] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[23] = GPDFHODMOIJ.Token;
			return OpCustom(163, dictionary, false, 1, true);
		}
		dictionary[167] = GKMFHELOOOH;
		dictionary[159] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[68] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[168] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -86)
			{
				if (!CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack_RainFX_Anm2");
					return false;
				}
				dictionary[136] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[41] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[76] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[238] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		bool flag = OpCustom(204, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_MainTex2");
		}
		return flag;
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

	public virtual bool LHOCCIABPNJ(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[121] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[246] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[123] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[70] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[217] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[72] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[78] = true;
			}
		}
		return OpCustom(92, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	public virtual bool LINKHIOFDPB()
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "Warning: No Shape Curve set for CurveWaveform.cs on ");
		}
		return OpCustom(96, null, false);
	}

	protected internal bool LPJIFHNJBMO(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Set satellite clockwise rotattion speed");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(198, MJJMNIDHDEC);
		dictionary.Add(233, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(43, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[108] = false;
		}
		return OpCustom(227, dictionary, true, 0, true);
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

	public virtual bool BCCNNNLOADO(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)6, "/../");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[109] = false;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[162] = GPDFHODMOIJ.IFKGNPNPDDI();
			return OpCustom(94, dictionary, true, 0, false);
		}
		dictionary[207] = GKMFHELOOOH;
		dictionary[221] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[240] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[125] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if ((int)GPDFHODMOIJ.AuthType != -86)
			{
				if (!LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "Left Stick Click");
					return true;
				}
				dictionary[226] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[67] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[72] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[67] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = OpCustom(58, dictionary, true, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Distance");
		}
		return flag;
	}

	[SpecialName]
	internal bool LCILDJEFKFI()
	{
		return base.UsedProtocol == ConnectionProtocol.WebSocketSecure;
	}

	public virtual bool HFBOBEKKBHK(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[130] = PPNEJGFIAJP;
		return OpCustom(71, dictionary, true, 0, true);
	}

	public virtual bool JCJBOMAOPIP(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "y");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 0)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, ".lastCheckpoint.penaltyScore");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)4)
		{
			if ((int)DebugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "CameraFilterPack/TV_WideScreenHV");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[172] = PKPEDDGHALP.Name;
		dictionary[222] = (byte)PKPEDDGHALP.Type;
		dictionary[108] = INIFMIHFOGD;
		return OpCustom(59, dictionary, false);
	}

	public virtual bool GAOMBMOHHCP(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn((DebugLevel)7, "' ping: ");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)133] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[78] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[156] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[18] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[174] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[117] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[2] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(43, dictionary, false);
	}

	protected internal bool FEPNICODBNC(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)7, "CameraFilterPack/Oculus_ThermaVision");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(84, MJJMNIDHDEC);
		dictionary.Add(138, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(90, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[188] = true;
		}
		return OpCustom(128, dictionary, true, 1, false);
	}

	public virtual bool JCHOHGKONJI(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "CameraFilterPack/Distortion_Dream2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[17] = GPDFHODMOIJ.DGINDFBNNDO();
			return OpCustom(88, dictionary, false, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-123) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("ConfigVersionSlider" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[151] = (byte)AMKMACFDKEC;
		dictionary[119] = (byte)NLNNMECNKEL;
		dictionary[165] = GKMFHELOOOH;
		dictionary[185] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[81] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[35] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if ((int)GPDFHODMOIJ.NKIEPEALJIB() != -162)
			{
				dictionary[74] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[168] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[40] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[154] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return OpCustom(240, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	public virtual bool EDLLPOONPPO()
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)8, "OK");
		}
		return OpCustom(74, null, true);
	}

	public virtual bool OIOPKLGHDGM(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[87] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[104] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[96] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[83] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[16] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[91] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[111] = false;
			}
		}
		return OpCustom(199, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	protected internal bool CKFJPBAJPHC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)6, "SetTrailZoomSpeed");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 2)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "st");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(115, FPBCPOGCCBD);
		dictionary.Add(149, KHACEEGCPEP);
		dictionary.Add(81, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(195, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[223] = false;
		}
		return OpCustom(6, dictionary, false, 1, false);
	}

	public virtual bool FBFFAGLHBCB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)4, "CameraFilterPack/BlurHole");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[193] = GPDFHODMOIJ.PPFIBJOHICJ();
			return OpCustom(86, dictionary, true, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)64 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("_Speed" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[172] = (byte)AMKMACFDKEC;
		dictionary[9] = (byte)NLNNMECNKEL;
		dictionary[142] = GKMFHELOOOH;
		dictionary[28] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[96] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[191] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.NKIEPEALJIB() != -165)
			{
				dictionary[64] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[55] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[204] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[32] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return OpCustom(6, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	protected internal bool HPGLPPCPEJC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn((DebugLevel)7, "tintColor");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 4)
			{
				base.Listener.DebugReturn(DebugLevel.WARNING, "GroupNameText");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(148, FPBCPOGCCBD);
		dictionary.Add(50, KHACEEGCPEP);
		dictionary.Add(240, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(173, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[83] = true;
		}
		return OpCustom(68, dictionary, true, 0, false);
	}

	protected void HPDAKLMDBIC(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		OABLOBEGOPJ(hashtable);
	}

	public virtual bool KLGCDNLPLAO(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(76, dictionary, false);
	}

	public virtual bool PNOCMLPFNBI()
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)4, " PhotonView: ");
		}
		return OpCustom(81, null, false);
	}

	public virtual bool OJFFLJAHOKP(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)8, "#exit");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 4)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "Editor/");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.AsyncRandomLobby)
		{
			if ((int)DebugOut >= 4)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_FgOverlap");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[109] = PKPEDDGHALP.Name;
		dictionary[104] = (byte)PKPEDDGHALP.Type;
		dictionary[250] = INIFMIHFOGD;
		return OpCustom(74, dictionary, true);
	}

	public virtual bool HFKAJEBEDIL(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)8, "settings.enablehitsoundsinnormal");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[109] = GPDFHODMOIJ.Token;
			return OpCustom(18, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-85) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("Right Stick Click" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[96] = (byte)AMKMACFDKEC;
		dictionary[198] = (byte)NLNNMECNKEL;
		dictionary[145] = GKMFHELOOOH;
		dictionary[148] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[159] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[117] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)119)
			{
				dictionary[77] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[21] = GPDFHODMOIJ.IFKGNPNPDDI();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[175] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[206] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return OpCustom(36, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	public bool GIPNIFODHCA(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return HPGLPPCPEJC(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, true);
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

	public virtual bool BBIOIEGCLDJ(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_ScreenResolution");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[79] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[234] = GPDFHODMOIJ.IFKGNPNPDDI();
			return OpCustom(159, dictionary, false, 0, true);
		}
		dictionary[122] = GKMFHELOOOH;
		dictionary[98] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[193] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[123] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)198)
			{
				if (!LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "ItemsCountText");
					return true;
				}
				dictionary[26] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.IFKGNPNPDDI()))
				{
					dictionary[115] = GPDFHODMOIJ.IFKGNPNPDDI();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[187] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[102] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		bool flag = OpCustom(153, dictionary, false, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "L1");
		}
		return flag;
	}

	public virtual bool KOCJEDALDDL(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_SmoothEnd");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[(byte)11] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[229] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[0] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[22] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[175] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[157] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[113] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(250, dictionary, true);
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

	protected internal bool IILDKFGHOHK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_Value4");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(72, MJJMNIDHDEC);
		dictionary.Add(130, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(133, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[157] = true;
		}
		return OpCustom(74, dictionary, false, 1, true);
	}

	protected internal bool FMDMPEMOAAB(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "menu.enableselectormusic");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(11, MJJMNIDHDEC);
		dictionary.Add(137, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(134, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[181] = true;
		}
		return OpCustom(189, dictionary, false, 1, true);
	}

	public virtual bool MGCPCNDACGG(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Value7");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.IsDefault)
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[39] = PKPEDDGHALP.Name;
			dictionary[91] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(156, dictionary, false);
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

	public virtual bool PIEPJOLEACH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)6, "maps.");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[96] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[106] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[99] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[73] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[70] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[247] = true;
			}
			KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(101, dictionary, false);
	}

	public virtual bool IPOIGDNKHJN(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "z");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[121] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[123] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[71] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[123] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[4] = (byte)0;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[2] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[21] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[53] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(211, dictionary, false);
	}

	protected void DLKJFOOLIFF(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		OABLOBEGOPJ(hashtable);
	}

	public virtual bool FKFFPHFNPLP(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn((DebugLevel)4, "SpawnObj");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return false;
		}
		return OpCustom(77, EJELAMOKKKA, false);
	}

	protected internal bool BEOJCMLIENM(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "#");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(159, MJJMNIDHDEC);
		dictionary.Add(124, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(179, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[146] = true;
		}
		return OpCustom(175, dictionary, false, 0, false);
	}

	public virtual bool JLLCPJGDHOL(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)6, "Object ID. Case-Sensitive");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[87] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[61] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[121] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[211] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[88] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[30] = true;
			}
			KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(254, dictionary, true);
	}

	protected internal bool JBBEGBKFAMH(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "Texture3");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 1)
			{
				base.Listener.DebugReturn((DebugLevel)7, ",");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(158, FPBCPOGCCBD);
		dictionary.Add(79, KHACEEGCPEP);
		dictionary.Add(206, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(189, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[251] = true;
		}
		return OpCustom(80, dictionary, false, 1, true);
	}

	public OHGAIJCPAJB(IPhotonPeerListener LONKELGPCJD, ConnectionProtocol MBOEJGPGFJB)
		: this(MBOEJGPGFJB)
	{
		base.Listener = LONKELGPCJD;
	}

	public virtual bool FELJKHFIBFD(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "steamid");
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
		return OpCustom(160, EJELAMOKKKA, true);
	}

	protected internal bool NOJCGHELIEK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "CameraFilterPack/Colors_BleachBypass");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(36, MJJMNIDHDEC);
		dictionary.Add(138, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(66, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[128] = true;
		}
		return OpCustom(9, dictionary, true, 1, false);
	}

	public virtual bool OFGIIHGFNCN(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn((DebugLevel)8, "Clear Environment");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[60] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[36] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[85] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[117] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[77] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[238] = true;
			}
			PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(130, dictionary, true);
	}

	public virtual bool PKLLHBHANGC(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(223, dictionary, false);
	}

	protected internal bool EBELCLCCFFJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)7, "CameraFilterPack/Blend2Camera_Luminosity");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(91, MJJMNIDHDEC);
		dictionary.Add(201, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(25, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[211] = false;
		}
		return OpCustom(145, dictionary, true, 0, true);
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

	private void PJMBJJMOILI(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)168] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)69] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[(byte)186] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)71] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[79] = hashtable;
		int num = 1;
		EKJLPPMJFBB[133] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 7;
			hashtable[(byte)91] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[190] = true;
			EKJLPPMJFBB[158] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[109] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.BDEFAIOFJDI())
		{
			num |= 5;
			EKJLPPMJFBB[0] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[220] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.KKMHCPJLBAB())
		{
			num |= 2;
			EKJLPPMJFBB[65] = false;
		}
		if (DPODHCMGCPF.OJIGPFICGKB())
		{
			num |= 0x63;
		}
		EKJLPPMJFBB[156] = num;
	}

	public virtual bool CKBCKDPCODK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(12, dictionary, false);
	}

	public virtual bool JLOPOLBOJBG(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn((DebugLevel)6, "settings.fps");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 1)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "_Value2");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != (LobbyType)5)
		{
			if ((int)DebugOut >= 7)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "ScrollPanel");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[87] = PKPEDDGHALP.Name;
		dictionary[10] = (byte)PKPEDDGHALP.Type;
		dictionary[152] = INIFMIHFOGD;
		return OpCustom(86, dictionary, true);
	}

	[SpecialName]
	internal bool JKAKCGOLJAE()
	{
		return base.UsedProtocol == ConnectionProtocol.Tcp;
	}

	public virtual bool PBIHOMIGJPG(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_TimeX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[105] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[123] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[47] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[148] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[81] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[83] = true;
			}
			PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(59, dictionary, false);
	}

	protected internal bool CADDOMOCLIJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_ReprojectionMatrix");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(45, MJJMNIDHDEC);
		dictionary.Add(156, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(133, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[122] = true;
		}
		return OpCustom(2, dictionary, false, 0, true);
	}

	public virtual bool OIPBLLHGHNB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_Near");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[158] = false;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[140] = GPDFHODMOIJ.IFKGNPNPDDI();
			return OpCustom(165, dictionary, true, 1, true);
		}
		dictionary[202] = GKMFHELOOOH;
		dictionary[44] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[112] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[32] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)156)
			{
				if (!LEBELEEEIDO() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "achievements.21.progress");
					return true;
				}
				dictionary[85] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[157] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[166] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[104] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = OpCustom(121, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "[EditorEvent] Exception: ");
		}
		return flag;
	}

	protected void AGIKJINNDPN(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		HFECLDIOHNJ(hashtable);
	}

	public virtual bool HBAKDBPIBJE(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Color_RGB");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)21] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[12] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[111] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[240] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[70] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[172] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[154] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(164, dictionary, true);
	}

	public bool OpSetCustomPropertiesOfActor(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return LJEFICMOPMO(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	public virtual bool ADKPCNKKLCI(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_MaxRadiusOrKInPaper");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[173] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[87] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[195] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[211] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[162] = (byte)0;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[11] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[87] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[214] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(192, dictionary, false);
	}

	public virtual bool LEMMBMIBBMF(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[105] = PPNEJGFIAJP;
		return OpCustom(136, dictionary, true, 0, true);
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

	public bool OOOPBJPEFLP(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return LJEFICMOPMO(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	public virtual bool GHDAINIGOMP(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_History3Weight");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[58] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[27] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[89] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[128] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[56] = (byte)3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[112] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[149] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[103] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(136, dictionary, false);
	}

	public virtual bool AMPLECEGLLN(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn((DebugLevel)4, "LevelURLInputField");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[74] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[93] = BBACCNINICP;
		}
		return OpCustom(251, dictionary, true, 0);
	}

	protected internal bool DGNOGCOIPIA(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "turn: {0:0}");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(6, MJJMNIDHDEC);
		dictionary.Add(91, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(152, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[154] = true;
		}
		return OpCustom(97, dictionary, true, 1, false);
	}

	public virtual bool FJCMOCPLACC(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, ":");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.MAKPKDLNCDO())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[63] = PKPEDDGHALP.Name;
			dictionary[28] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(42, dictionary, true);
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

	public virtual bool GAGAEBLPPFM(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)8, "[SERVER] Selected map: ");
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
		return OpCustom(156, EJELAMOKKKA, false);
	}

	public virtual bool KBEICOFLCFC(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "PPI: ");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 6)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "Set Arcs Speed");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if ((int)DebugOut >= 2)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "_DotSize");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[15] = PKPEDDGHALP.Name;
		dictionary[91] = (byte)PKPEDDGHALP.Type;
		dictionary[47] = INIFMIHFOGD;
		return OpCustom(180, dictionary, true);
	}

	public virtual bool DMIKNEPMMJB(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "#ok");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.LJHKKOEPODN())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[111] = PKPEDDGHALP.Name;
			dictionary[253] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(128, dictionary, false);
	}

	public virtual bool HGGNBHOELEK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return OpCustom(254, dictionary, true);
	}

	public virtual bool LHFNDEPFJAF(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[249] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[127] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[67] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[197] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[25] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[74] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[173] = true;
			}
		}
		return OpCustom(146, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	public virtual bool OIPJGPKILNF(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "/../");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[164] = GPDFHODMOIJ.IFKGNPNPDDI();
			return OpCustom(194, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)12 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("CameraFilterPack/Drawing_BluePrint" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[197] = (byte)AMKMACFDKEC;
		dictionary[178] = (byte)NLNNMECNKEL;
		dictionary[39] = GKMFHELOOOH;
		dictionary[87] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[199] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[182] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)109)
			{
				dictionary[165] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[20] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[149] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[71] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return OpCustom(22, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	public virtual bool MBMAGCCPKPI(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn((DebugLevel)6, "_Convolved_TexelSize");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[156] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[173] = GPDFHODMOIJ.DGINDFBNNDO();
			return OpCustom(104, dictionary, false, 1, true);
		}
		dictionary[241] = GKMFHELOOOH;
		dictionary[122] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[103] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[84] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -167)
			{
				if (!CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "[CraftingPanel] Init");
					return true;
				}
				dictionary[107] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.IFKGNPNPDDI()))
				{
					dictionary[153] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[177] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[99] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = OpCustom(73, dictionary, true, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack_VHS1");
		}
		return flag;
	}

	protected internal bool APMINOMEBPE(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_NoiseAmount");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(175, MJJMNIDHDEC);
		dictionary.Add(149, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(17, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[177] = false;
		}
		return OpCustom(237, dictionary, false, 0, true);
	}

	public virtual bool IHGINBNOBKB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, " - {0}");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[89] = GPDFHODMOIJ.IFKGNPNPDDI();
			return OpCustom(113, dictionary, false, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-38) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("InfoText" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[byte.MaxValue] = (byte)AMKMACFDKEC;
		dictionary[126] = (byte)NLNNMECNKEL;
		dictionary[209] = GKMFHELOOOH;
		dictionary[76] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[21] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[147] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)129)
			{
				dictionary[241] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[222] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[5] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[30] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		return OpCustom(175, dictionary, true, 1, base.IsEncryptionAvailable);
	}

	public virtual bool KNJOPJNBFCA(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_TimeX");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(131, EJELAMOKKKA, true);
	}

	public virtual bool CDDNMNDHELA(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Drawing_Curve");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return false;
		}
		return OpCustom(97, EJELAMOKKKA, true);
	}

	public virtual bool JODDCFJILCH(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[56] = EEPAJBBCGJK;
		}
		return OpCustom(57, dictionary, false);
	}

	public virtual bool IHIKIFHBOJA()
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "[");
		}
		return OpCustom(104, null, false);
	}

	public virtual bool LDBKPCIKPDD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)7, "_ChromaticAberration");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 7)
			{
				base.Listener.DebugReturn((DebugLevel)4, "EventMenu");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn((DebugLevel)6, "#{0:00} '{1}'{2} {3}");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[145] = PKPEDDGHALP.Name;
		dictionary[254] = (byte)PKPEDDGHALP.Type;
		dictionary[120] = INIFMIHFOGD;
		return OpCustom(79, dictionary, false);
	}

	public bool LPLFNMFBHIP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return FEPNICODBNC(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	public virtual bool NOIJCDINDLL(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_Distortion");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.NLPINAKJLPF())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[91] = PKPEDDGHALP.Name;
			dictionary[237] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(190, dictionary, false);
	}

	public virtual bool BGGJHBKFGPD(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(22, dictionary, true);
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

	public virtual bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(222, dictionary, true);
	}

	public virtual bool OpLeaveLobby()
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpLeaveLobby()");
		}
		return OpCustom(228, null, true);
	}

	public virtual bool PEBMBNGKOBH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 7)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "checkpoint");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[226] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[228] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[175] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[129] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[185] = (byte)1;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[18] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[161] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[199] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(147, dictionary, true);
	}

	public virtual bool LKLAJKINLFG(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[188] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[47] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[56] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[206] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[176] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[130] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[153] = false;
			}
		}
		return OpCustom(107, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	public virtual bool MPKLAJGIHGP(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[145] = PPNEJGFIAJP;
		return OpCustom(72, dictionary, false, 1, false);
	}

	public virtual bool BBIMCKFDFHG(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Adding player twice: ");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[168] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[127] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[147] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[199] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[110] = (byte)3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[184] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[59] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[103] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(169, dictionary, true);
	}

	protected void MGCPDDMDAIO(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		IILDKFGHOHK(hashtable, null, true);
	}

	protected internal bool IFBHCMGLLIM(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CameraFilterPack/Blend2Camera_LighterColor");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 1)
			{
				base.Listener.DebugReturn((DebugLevel)7, "_TimeX");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(69, FPBCPOGCCBD);
		dictionary.Add(85, KHACEEGCPEP);
		dictionary.Add(187, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(71, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[125] = false;
		}
		return OpCustom(73, dictionary, true, 0, true);
	}

	public virtual bool DOFHCJGBGAD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn((DebugLevel)6, "76561198041679481");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 6)
			{
				base.Listener.DebugReturn((DebugLevel)7, " Path: ");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)1)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_CurveParams");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[46] = PKPEDDGHALP.Name;
		dictionary[28] = (byte)PKPEDDGHALP.Type;
		dictionary[149] = INIFMIHFOGD;
		return OpCustom(207, dictionary, true);
	}

	public virtual bool BJDOBCFLMAC(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)6, "mapselector.filter.officialsortmode");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[165] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[11] = (byte)1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[165] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[111] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[98] = (byte)4;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[52] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[105] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[164] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(89, dictionary, true);
	}

	public virtual bool MNJCIJOJAEM(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "rarity");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[119] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[139] = BBACCNINICP;
		}
		return OpCustom(111, dictionary, true, 1);
	}

	public virtual bool HGLDGECBKBO(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(245, dictionary, false);
	}

	public virtual bool AOIDAOKBANL(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_TimeX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[130] = GPDFHODMOIJ.Token;
			return OpCustom(95, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)105 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("_TimeX" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[138] = (byte)AMKMACFDKEC;
		dictionary[226] = (byte)NLNNMECNKEL;
		dictionary[165] = GKMFHELOOOH;
		dictionary[196] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[26] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[156] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)124)
			{
				dictionary[186] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[177] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[131] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[89] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return OpCustom(145, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	public virtual bool CBGKMKKPHOA(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)7, "Item invalid. Make sure your mod contains at leats one file.");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[102] = GPDFHODMOIJ.PPFIBJOHICJ();
			return OpCustom(149, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)67 && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("GroupNameText" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[235] = (byte)AMKMACFDKEC;
		dictionary[172] = (byte)NLNNMECNKEL;
		dictionary[87] = GKMFHELOOOH;
		dictionary[71] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[167] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[136] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)152)
			{
				dictionary[62] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[178] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[132] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[198] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return OpCustom(173, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	protected void KCECKNONGIP(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		APMINOMEBPE(hashtable);
	}

	public virtual bool NHOJKCKGGIH()
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)4, "#onrankchangeuptext");
		}
		return OpCustom(223, null, true);
	}

	public virtual bool OOECDGHNPEF(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return OpCustom(88, dictionary, false);
	}

	public virtual bool DPHMJJOHGCG(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_MatrixSize");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.BEDADDBKMLN())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[125] = PKPEDDGHALP.Name;
			dictionary[177] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(170, dictionary, true);
	}

	public OHGAIJCPAJB(ConnectionProtocol MBOEJGPGFJB)
		: base(MBOEJGPGFJB)
	{
	}

	public virtual bool JIPNEAJNHEH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CameraFilterPack_Atmosphere_Rain_FX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[106] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[140] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[153] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[213] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[87] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[251] = false;
			}
			KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return OpCustom(144, dictionary, true);
	}

	public bool ODOJDLNLBEA(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return BHDGFLNLJCH(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	public virtual bool OJKDKHPLIGO(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "win");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)2] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[56] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[107] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[39] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[61] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[182] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[162] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(220, dictionary, false);
	}

	[SpecialName]
	internal bool LEBELEEEIDO()
	{
		return base.UsedProtocol == ConnectionProtocol.Tcp;
	}

	public virtual bool FKFDEKALFIN()
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "#random #rare #item");
		}
		return OpCustom(236, null, false);
	}

	protected void NFMDPHKFHDL(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		OABLOBEGOPJ(hashtable, null, true);
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

	public virtual bool KJGBJHIEKDC(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "offsets");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[60] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[149] = BBACCNINICP;
		}
		return OpCustom(38, dictionary, false, 1);
	}

	public virtual bool IEBPDKACDBD(TypedLobby PKPEDDGHALP = null)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn((DebugLevel)8, "CameraFilterPack/Drawing_Manga_Flash");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.NAKOCKGALKH())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[70] = PKPEDDGHALP.Name;
			dictionary[39] = (byte)PKPEDDGHALP.Type;
		}
		return OpCustom(73, dictionary, true);
	}

	public virtual bool DBOPFGEEBMH(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[100] = PPNEJGFIAJP;
		return OpCustom(168, dictionary, true, 1, false);
	}

	[SpecialName]
	internal bool MGBHJHHIMJF()
	{
		return base.UsedProtocol == (ConnectionProtocol)2;
	}

	public bool HDPOINGMPEE(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return JBBEGBKFAMH(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys());
	}

	protected internal bool OABLOBEGOPJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 1)
		{
			base.Listener.DebugReturn((DebugLevel)4, "#onfirstranktext");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(207, MJJMNIDHDEC);
		dictionary.Add(141, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(143, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[131] = true;
		}
		return OpCustom(97, dictionary, false, 0, false);
	}

	public virtual bool EMCJJFPNKCK(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		EJELAMOKKKA.Clear();
		EJELAMOKKKA[2] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			EJELAMOKKKA[68] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != 0)
			{
				EJELAMOKKKA[220] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != 0)
			{
				EJELAMOKKKA[170] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				EJELAMOKKKA[144] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				EJELAMOKKKA[132] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				EJELAMOKKKA[169] = true;
			}
		}
		return OpCustom(233, EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	protected internal bool BHDGFLNLJCH(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn((DebugLevel)6, "Floating point textures aren't supported on this device ({0})");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if ((int)DebugOut >= 7)
			{
				base.Listener.DebugReturn((DebugLevel)4, "_ColorBuffer");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(127, FPBCPOGCCBD);
		dictionary.Add(95, KHACEEGCPEP);
		dictionary.Add(30, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(242, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[196] = true;
		}
		return OpCustom(30, dictionary, false, 0, true);
	}

	public virtual bool MKJDEBIJGFK(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 3)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Stream did not contain properly formatted byte array");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 7)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_LutTex");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.AsyncRandomLobby)
		{
			if ((int)DebugOut >= 2)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "Clears the console and prints the logs in the specified range");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[110] = PKPEDDGHALP.Name;
		dictionary[133] = (byte)PKPEDDGHALP.Type;
		dictionary[21] = INIFMIHFOGD;
		return OpCustom(108, dictionary, false);
	}

	public virtual bool EIEGEHCICNP(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if ((int)DebugOut >= 2)
		{
			base.Listener.DebugReturn((DebugLevel)8, "14");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)61] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[35] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != 0)
		{
			dictionary[114] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[124] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[107] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[91] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[234] = IFIMMPPLLHI.ExpectedUsers;
		}
		return OpCustom(114, dictionary, true);
	}

	public virtual bool KNNOIBMABCN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 0)
		{
			base.Listener.DebugReturn((DebugLevel)6, "_ScreenResolution");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[58] = GPDFHODMOIJ.PPFIBJOHICJ();
			return OpCustom(180, dictionary, false, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-64) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("Chat" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[158] = (byte)AMKMACFDKEC;
		dictionary[237] = (byte)NLNNMECNKEL;
		dictionary[10] = GKMFHELOOOH;
		dictionary[197] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[45] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[73] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -90)
			{
				dictionary[166] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[20] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[166] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[57] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return OpCustom(24, dictionary, true, 1, base.IsEncryptionAvailable);
	}

	public virtual bool PNKFPJJPELO(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Amount");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[39] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[189] = (byte)0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[168] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[243] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[59] = (byte)3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[246] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[71] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[175] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return OpCustom(180, dictionary, false);
	}

	public virtual bool OLOMFHLPHDH(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_Heigh");
		}
		if (PKPEDDGHALP == null)
		{
			if ((int)DebugOut >= 8)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "colorD");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != 0)
		{
			if ((int)DebugOut >= 0)
			{
				base.Listener.DebugReturn((DebugLevel)6, "SpawnObj");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[178] = PKPEDDGHALP.Name;
		dictionary[211] = (byte)PKPEDDGHALP.Type;
		dictionary[77] = INIFMIHFOGD;
		return OpCustom(7, dictionary, false);
	}

	public virtual bool MDEGPIGGGEE(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if ((int)DebugOut >= 6)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Value2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[16] = GPDFHODMOIJ.DGINDFBNNDO();
			return OpCustom(76, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-125) && AMKMACFDKEC != 0)
		{
			Debug.LogWarning("_TimeX" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[165] = (byte)AMKMACFDKEC;
		dictionary[155] = (byte)NLNNMECNKEL;
		dictionary[170] = GKMFHELOOOH;
		dictionary[166] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[220] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[148] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)192)
			{
				dictionary[128] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[166] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[67] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[170] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return OpCustom(163, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	public virtual bool CJKBKAJFFJA()
	{
		if ((int)DebugOut >= 8)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_CurTex");
		}
		return OpCustom(158, null, false);
	}

	public virtual bool CJJOICDBDNJ()
	{
		if ((int)DebugOut >= 4)
		{
			base.Listener.DebugReturn((DebugLevel)7, "_ScreenResolution");
		}
		return OpCustom(195, null, true);
	}

	public virtual bool NGMNPIIMODA(bool GNAFHNLBPHP)
	{
		if ((int)DebugOut >= 5)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "menu.enableselectormusic");
		}
		EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		if (EJELAMOKKKA.Count == 0)
		{
			return true;
		}
		return OpCustom(242, EJELAMOKKKA, true);
	}
}
