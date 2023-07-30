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

	public void AFADNAIGHIG(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH != null)
		{
			Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
			Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
			bool flag = hashtable2 != null && hashtable2.Count == 1;
			if (PhotonNetwork.offlineMode || flag)
			{
				GBLNGKOOEMH().Merge(hashtable);
				GBLNGKOOEMH().StripKeysWithNullValues();
			}
			if (!PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.ENLHKMFBDMG(hashtable, hashtable2, CDBHGINNCOF);
			}
			if (PhotonNetwork.offlineMode || flag)
			{
				object[] array = new object[0];
				array[0] = hashtable;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipRequest, array);
			}
		}
	}

	public void SetPropertiesListedInLobby(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)250] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable);
		PropertiesListedInLobby = GNPOEBDMHMP;
	}

	public void NPJMMJGHLGK()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)59] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)56] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.DPEFFAKCAFC(hashtable, hashtable2, true);
	}

	public void ClearExpectedUsers()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)247] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)247] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2);
	}

	public override string ToString()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount);
	}

	[SpecialName]
	public void JHOKMGBHEKD(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_Value4");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.POCGAHHKCLG(new Hashtable { 
			{
				(byte)34,
				DPNHODJHGJL
			} });
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	[SpecialName]
	public void HGCLCBJIIKI(bool DPNHODJHGJL)
	{
		if (!Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("Set satellite lerp speed");
		}
		if (DPNHODJHGJL != FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.IILDKFGHOHK(new Hashtable { 
			{
				(byte)18,
				DPNHODJHGJL
			} }, null, true);
		}
		FMPBAGHEJDN = DPNHODJHGJL;
	}

	[SpecialName]
	public void EEDGDPHPLBD(bool DPNHODJHGJL)
	{
		JHOKMGBHEKD(DPNHODJHGJL);
	}

	[SpecialName]
	public bool BOKBJHPFCKK()
	{
		return IsVisible;
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

	public void SetExpectedUsers(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)247] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)247] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2);
	}

	public new string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount, base.CustomProperties.ToStringFull());
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

	[SpecialName]
	public void GEIONJONABH(bool DPNHODJHGJL)
	{
		IsOpen = DPNHODJHGJL;
	}

	[SpecialName]
	protected internal int KFFMAGECHDI()
	{
		return EJLAPIIGIMI;
	}

	[SpecialName]
	public bool HGADABNHIFG()
	{
		return FECDEAJPAAJ;
	}

	[SpecialName]
	protected internal int JAFBFLBDBDG()
	{
		return EJLAPIIGIMI;
	}

	public void CIAHEBLOKDJ(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)170] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)57] = ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.BACNBJMIBOK(hashtable, hashtable2);
	}

	[SpecialName]
	private void GOCNEEAHBKF(string[] DPNHODJHGJL)
	{
		PropertiesListedInLobby = DPNHODJHGJL;
	}
}
