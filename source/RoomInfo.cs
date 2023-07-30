// RoomInfo
using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

public class RoomInfo
{
	private Hashtable ILOIDCICMKC = new Hashtable();

	protected byte MDLLBJEFCCJ;

	protected string[] GFEDJEMJEND;

	protected bool PNAALABONJG = true;

	protected bool FMPBAGHEJDN = true;

	protected bool FECDEAJPAAJ = PhotonNetwork.autoCleanUpPlayerObjects;

	protected string LCKGKDLCFMC;

	protected internal int IPBANMNLDPC;

	public bool removedFromList { get; internal set; }

	protected internal bool BDHOOLIDFJO { get; private set; }

	public Hashtable CustomProperties => ILOIDCICMKC;

	public string Name => LCKGKDLCFMC;

	public int PlayerCount { get; private set; }

	public bool IsLocalClientInside { get; set; }

	public byte MaxPlayers => MDLLBJEFCCJ;

	public bool IsOpen => PNAALABONJG;

	public bool IsVisible => FMPBAGHEJDN;

	[Obsolete("Please use CustomProperties (updated case for naming).")]
	public Hashtable customProperties => CustomProperties;

	[Obsolete("Please use Name (updated case for naming).")]
	public string name => Name;

	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public int playerCount
	{
		get
		{
			return PlayerCount;
		}
		set
		{
			PlayerCount = value;
		}
	}

	[Obsolete("Please use IsLocalClientInside (updated case for naming).")]
	public bool isLocalClientInside
	{
		get
		{
			return IsLocalClientInside;
		}
		set
		{
			IsLocalClientInside = value;
		}
	}

	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public byte maxPlayers => MaxPlayers;

	[Obsolete("Please use IsOpen (updated case for naming).")]
	public bool open => IsOpen;

	[Obsolete("Please use IsVisible (updated case for naming).")]
	public bool visible => IsVisible;

	public override bool Equals(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public bool AGPOALMNDBI()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public bool DIIAMMHJHLE()
	{
		return PNAALABONJG;
	}

	public override int PMCIBOJLHGK()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	protected internal void NPOPPIMCDMN(Hashtable KBKCLMDMKCF)
	{
		if (KBKCLMDMKCF == null || KBKCLMDMKCF.Count == 0 || ILOIDCICMKC.Equals(KBKCLMDMKCF))
		{
			return;
		}
		if (KBKCLMDMKCF.ContainsKey((byte)251))
		{
			removedFromList = (bool)KBKCLMDMKCF[(byte)251];
			if (removedFromList)
			{
				return;
			}
		}
		if (KBKCLMDMKCF.ContainsKey(byte.MaxValue))
		{
			MDLLBJEFCCJ = (byte)KBKCLMDMKCF[byte.MaxValue];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)253))
		{
			PNAALABONJG = (bool)KBKCLMDMKCF[(byte)253];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)254))
		{
			FMPBAGHEJDN = (bool)KBKCLMDMKCF[(byte)254];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)252))
		{
			PlayerCount = (byte)KBKCLMDMKCF[(byte)252];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)249))
		{
			FECDEAJPAAJ = (bool)KBKCLMDMKCF[(byte)249];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)248))
		{
			BDHOOLIDFJO = true;
			bool flag = IPBANMNLDPC != 0;
			IPBANMNLDPC = (int)KBKCLMDMKCF[(byte)248];
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.ELDLAPJAPBJ();
			}
		}
		if (KBKCLMDMKCF.ContainsKey((byte)247))
		{
			GFEDJEMJEND = (string[])KBKCLMDMKCF[(byte)247];
		}
		ILOIDCICMKC.MergeStringKeys(KBKCLMDMKCF);
		ILOIDCICMKC.StripKeysWithNullValues();
	}

	[SpecialName]
	public bool ENHLDMICAJB()
	{
		return IsOpen;
	}

	public string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount, ILOIDCICMKC.ToStringFull());
	}

	public string AOCCOCDODPC()
	{
		object[] array = new object[5];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "_Parasite" : "g");
		array[0] = ((!PNAALABONJG) ? "st" : "&page=");
		array[3] = MDLLBJEFCCJ;
		array[8] = PlayerCount;
		array[6] = ILOIDCICMKC.ToStringFull();
		return string.Format("Can't start OFFLINE mode while connected!", array);
	}

	[SpecialName]
	public bool CMPODEKCNCH()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public byte JLGNBDJJGJC()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public int LCJDMGFIHKI()
	{
		return _003CMENHEBDBIFC_003Ek__BackingField;
	}

	[SpecialName]
	private void CAEAKIMCDKJ(int DPNHODJHGJL)
	{
		_003CMENHEBDBIFC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private void PFFDMGNGGFO(bool DPNHODJHGJL)
	{
		_003CIGNEFDJICLF_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void NPNGHIGLNNH(bool DPNHODJHGJL)
	{
		_003CGBODHEAGOGK_003Ek__BackingField = DPNHODJHGJL;
	}

	public override int GetHashCode()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	[SpecialName]
	public string AFAOFPEFKOL()
	{
		return Name;
	}

	public string PPAAFAOIKNL()
	{
		object[] array = new object[5];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "Delete events" : "achievements.21.progress");
		array[2] = ((!PNAALABONJG) ? "set id" : "_Value");
		array[1] = MDLLBJEFCCJ;
		array[3] = LCJDMGFIHKI();
		array[1] = ILOIDCICMKC.ToStringFull();
		return string.Format("{}", array);
	}

	[SpecialName]
	public void OJNMAABFODA(bool DPNHODJHGJL)
	{
		NPNGHIGLNNH(DPNHODJHGJL);
	}

	[SpecialName]
	public bool FDHACJNODDN()
	{
		return IsVisible;
	}

	[SpecialName]
	private void HCBBOFMHKCO(bool DPNHODJHGJL)
	{
		_003CIGNEFDJICLF_003Ek__BackingField = DPNHODJHGJL;
	}

	public override string ToString()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount);
	}

	[SpecialName]
	internal void HBDBNFKALJF(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public int IDIPFJBPBAL()
	{
		return PlayerCount;
	}

	[SpecialName]
	public byte LHAPBIBALKM()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public byte NEKMKFJFHEB()
	{
		return JLGNBDJJGJC();
	}

	[SpecialName]
	public string HBLACMCHNMB()
	{
		return Name;
	}

	protected internal RoomInfo(string IOJPMCOBHEJ, Hashtable EAOBCIPOENN)
	{
		NPOPPIMCDMN(EAOBCIPOENN);
		LCKGKDLCFMC = IOJPMCOBHEJ;
	}

	[SpecialName]
	public Hashtable GBLNGKOOEMH()
	{
		return ILOIDCICMKC;
	}

	[SpecialName]
	public Hashtable DMANNHAPJCP()
	{
		return GBLNGKOOEMH();
	}

	[SpecialName]
	public void BJMOMDLAEEP(int DPNHODJHGJL)
	{
		PlayerCount = DPNHODJHGJL;
	}

	[SpecialName]
	public int MLOONFAAGLG()
	{
		return LCJDMGFIHKI();
	}

	[SpecialName]
	public byte LIDPCNPKDBG()
	{
		return MaxPlayers;
	}

	protected internal void DHEOODECBHE(Hashtable KBKCLMDMKCF)
	{
		if (KBKCLMDMKCF == null || KBKCLMDMKCF.Count == 0 || ILOIDCICMKC.Equals(KBKCLMDMKCF))
		{
			return;
		}
		if (KBKCLMDMKCF.ContainsKey((byte)212))
		{
			removedFromList = (bool)KBKCLMDMKCF[(byte)28];
			if (removedFromList)
			{
				return;
			}
		}
		if (KBKCLMDMKCF.ContainsKey((byte)251))
		{
			MDLLBJEFCCJ = (byte)KBKCLMDMKCF[(byte)172];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)byte.MaxValue))
		{
			PNAALABONJG = (bool)KBKCLMDMKCF[(byte)119];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)134))
		{
			FMPBAGHEJDN = (bool)KBKCLMDMKCF[(byte)221];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)172))
		{
			PlayerCount = (byte)KBKCLMDMKCF[(byte)246];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)96))
		{
			FECDEAJPAAJ = (bool)KBKCLMDMKCF[(byte)199];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)227))
		{
			HCBBOFMHKCO(true);
			bool flag = IPBANMNLDPC != 1;
			IPBANMNLDPC = (int)KBKCLMDMKCF[(byte)181];
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.ELDLAPJAPBJ();
			}
		}
		if (KBKCLMDMKCF.ContainsKey((byte)201))
		{
			GFEDJEMJEND = (string[])KBKCLMDMKCF[(byte)181];
		}
		ILOIDCICMKC.MergeStringKeys(KBKCLMDMKCF);
		ILOIDCICMKC.StripKeysWithNullValues();
	}

	[SpecialName]
	public bool ACLKBNAOFPF()
	{
		return AGPOALMNDBI();
	}

	[SpecialName]
	public int DKDLKDBBPHH()
	{
		return LCJDMGFIHKI();
	}

	[SpecialName]
	protected internal bool PPODOKJKEHE()
	{
		return _003CIGNEFDJICLF_003Ek__BackingField;
	}

	[SpecialName]
	public void MJBEPOBFKLO(bool DPNHODJHGJL)
	{
		IsLocalClientInside = DPNHODJHGJL;
	}

	public override bool ILLAEPFOHCJ(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public bool MFLFAMDCNOB()
	{
		return AGPOALMNDBI();
	}
}
