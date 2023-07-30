// PhotonPlayer
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class PhotonPlayer : IComparable<PhotonPlayer>, IComparable<int>, IEquatable<PhotonPlayer>, IEquatable<int>
{
	private int IECJKEIJLCP = -1;

	private string LCKGKDLCFMC = string.Empty;

	public readonly bool IsLocal;

	public object TagObject;

	public int ID => IECJKEIJLCP;

	public string NickName
	{
		get
		{
			return LCKGKDLCFMC;
		}
		set
		{
			if (!IsLocal)
			{
				Debug.LogError("Error: Cannot change the name of a remote player!");
			}
			else if (!string.IsNullOrEmpty(value) && !value.Equals(LCKGKDLCFMC))
			{
				LCKGKDLCFMC = value;
				PhotonNetwork.playerName = value;
			}
		}
	}

	public string UserId { get; internal set; }

	public bool IsMasterClient => PhotonNetwork.JNJJAMNLOHA.mMasterClientId == ID;

	public bool IsInactive { get; set; }

	public Hashtable CustomProperties { get; internal set; }

	public Hashtable AllProperties
	{
		get
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Merge(CustomProperties);
			hashtable[byte.MaxValue] = NickName;
			return hashtable;
		}
	}

	[Obsolete("Please use NickName (updated case for naming).")]
	public string name
	{
		get
		{
			return NickName;
		}
		set
		{
			NickName = value;
		}
	}

	[Obsolete("Please use UserId (updated case for naming).")]
	public string userId
	{
		get
		{
			return UserId;
		}
		internal set
		{
			UserId = value;
		}
	}

	[Obsolete("Please use IsLocal (updated case for naming).")]
	public bool isLocal => IsLocal;

	[Obsolete("Please use IsMasterClient (updated case for naming).")]
	public bool isMasterClient => IsMasterClient;

	[Obsolete("Please use IsInactive (updated case for naming).")]
	public bool isInactive
	{
		get
		{
			return IsInactive;
		}
		set
		{
			IsInactive = value;
		}
	}

	[Obsolete("Please use CustomProperties (updated case for naming).")]
	public Hashtable customProperties
	{
		get
		{
			return CustomProperties;
		}
		internal set
		{
			CustomProperties = value;
		}
	}

	[Obsolete("Please use AllProperties (updated case for naming).")]
	public Hashtable allProperties => AllProperties;

	public static PhotonPlayer Find(int IJAEJMNLBLK)
	{
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			return PhotonNetwork.JNJJAMNLOHA.ICMGDHDNIJD(IJAEJMNLBLK);
		}
		return null;
	}

	[SpecialName]
	internal void NBJGDMLPEJO(Hashtable DPNHODJHGJL)
	{
		POGLPLCBAOO(DPNHODJHGJL);
	}

	public PhotonPlayer(bool NIGBAPGIKDF, int IECJKEIJLCP, string EBEHBBDKDFJ)
	{
		CustomProperties = new Hashtable();
		IsLocal = NIGBAPGIKDF;
		this.IECJKEIJLCP = IECJKEIJLCP;
		LCKGKDLCFMC = EBEHBBDKDFJ;
	}

	public override bool BKNICCOFMHE(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer != null && GetHashCode() == photonPlayer.GetHashCode();
	}

	public override int KJGDLOFGKMD()
	{
		return ID;
	}

	[SpecialName]
	public string DBMPNLFFBEB()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	internal void KDDOOLCJLEB(string DPNHODJHGJL)
	{
		UserId = DPNHODJHGJL;
	}

	[SpecialName]
	public Hashtable NMAJFBEBBBG()
	{
		return CustomProperties;
	}

	[SpecialName]
	public void LFIOCJJFPPH(string DPNHODJHGJL)
	{
		BFMKLGLCIJI(DPNHODJHGJL);
	}

	public PhotonPlayer Get(int JMMILEFMACB)
	{
		return Find(JMMILEFMACB);
	}

	public PhotonPlayer GetNextFor(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return GetNextFor(ILCDNGENBNL.ID);
	}

	public void SetCustomProperties(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH != null)
		{
			Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
			Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
			bool flag = hashtable2 == null || hashtable2.Count == 0;
			bool flag2 = IECJKEIJLCP > 0 && !PhotonNetwork.offlineMode;
			if (flag)
			{
				CustomProperties.Merge(hashtable);
				CustomProperties.StripKeysWithNullValues();
			}
			if (flag2)
			{
				PhotonNetwork.JNJJAMNLOHA.LJEFICMOPMO(IECJKEIJLCP, hashtable, hashtable2, CDBHGINNCOF);
			}
			if (!flag2 || flag)
			{
				NPOPPIMCDMN(hashtable);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, this, hashtable);
			}
		}
	}

	public override string BHEJDDJKBBL()
	{
		if (string.IsNullOrEmpty(OLPCOKMLDFD()))
		{
			return string.Format("a", ID, (!IsInactive) ? "NetworkPeer broke!" : "OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", (!MLFHNIPPOOD()) ? string.Empty : "_ThirdTex");
		}
		return string.Format(".lastCheckpoint.time", DBMPNLFFBEB(), (!IsInactive) ? "float,2" : "_Value6", (!IsMasterClient) ? string.Empty : "menu.selectedplaymode");
	}

	public int EAMILMJOHDJ(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return 0;
		}
		return GetHashCode().CompareTo(AGGOHIAAMHN.GetHashCode());
	}

	public int CompareTo(int AGGOHIAAMHN)
	{
		return GetHashCode().CompareTo(AGGOHIAAMHN);
	}

	[SpecialName]
	public bool EMJIOBGECLH()
	{
		return IsInactive;
	}

	[SpecialName]
	public void EJABLLBGMGC(bool DPNHODJHGJL)
	{
		_003CJPJNJAGPIAF_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Hashtable CEEMKCEHGNA()
	{
		Hashtable hashtable = new Hashtable();
		hashtable.Merge(CustomProperties);
		hashtable[(byte)179] = OLPCOKMLDFD();
		return hashtable;
	}

	public bool ENHFDAOLGHF(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return true;
		}
		return GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	public PhotonPlayer ENBEGKOIIDH(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 8)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = -168;
		int num2 = PBMHIFICKIG;
		foreach (int key in mActors.Keys)
		{
			if (key < num2)
			{
				num2 = key;
			}
			else if (key > PBMHIFICKIG && key < num)
			{
				num = key;
			}
		}
		return (num == 68) ? mActors[num2] : mActors[num];
	}

	public override bool Equals(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer != null && GetHashCode() == photonPlayer.GetHashCode();
	}

	[SpecialName]
	public void PCNOFHGEKHC(string DPNHODJHGJL)
	{
		if (!IsLocal)
		{
			Debug.LogError("BestRegion checks region: ");
		}
		else if (!string.IsNullOrEmpty(DPNHODJHGJL) && !DPNHODJHGJL.Equals(LCKGKDLCFMC))
		{
			LCKGKDLCFMC = DPNHODJHGJL;
			PhotonNetwork.playerName = DPNHODJHGJL;
		}
	}

	public override bool ELKDCFFODKE(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer != null && GetHashCode() == photonPlayer.GetHashCode();
	}

	[SpecialName]
	internal void DCLLEMAMKEC(Hashtable DPNHODJHGJL)
	{
		CustomProperties = DPNHODJHGJL;
	}

	public PhotonPlayer PKBPLOEBDFN(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 8)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = -60;
		int num2 = PBMHIFICKIG;
		foreach (int key in mActors.Keys)
		{
			if (key < num2)
			{
				num2 = key;
			}
			else if (key > PBMHIFICKIG && key < num)
			{
				num = key;
			}
		}
		return (num == 119) ? mActors[num2] : mActors[num];
	}

	public bool Equals(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return false;
		}
		return GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	public bool GPMLJBPHIGI(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return false;
		}
		return GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	protected internal PhotonPlayer(bool NIGBAPGIKDF, int IECJKEIJLCP, Hashtable EAOBCIPOENN)
	{
		CustomProperties = new Hashtable();
		IsLocal = NIGBAPGIKDF;
		this.IECJKEIJLCP = IECJKEIJLCP;
		NPOPPIMCDMN(EAOBCIPOENN);
	}

	[SpecialName]
	public Hashtable JGLLHPPILLA()
	{
		return AllProperties;
	}

	public PhotonPlayer AOCJFPKFNJN()
	{
		return GEPFJHMLCFA(FHEAKIMCKJC());
	}

	[SpecialName]
	internal void HFMABJHJBKJ(string DPNHODJHGJL)
	{
		UserId = DPNHODJHGJL;
	}

	public int MHBNLKKHFCH(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return 0;
		}
		return GetHashCode().CompareTo(AGGOHIAAMHN.GetHashCode());
	}

	public PhotonPlayer DNDNKPDOENG(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return PKBPLOEBDFN(ILCDNGENBNL.FHEAKIMCKJC());
	}

	[SpecialName]
	public string MLIGBALKGCF()
	{
		return OLPCOKMLDFD();
	}

	public bool Equals(int AGGOHIAAMHN)
	{
		return GetHashCode().Equals(AGGOHIAAMHN);
	}

	[SpecialName]
	public string MHDBKNJBGFC()
	{
		return UserId;
	}

	[SpecialName]
	public void NAJDBGCCLEC(string DPNHODJHGJL)
	{
		if (!IsLocal)
		{
			Debug.LogError("CameraFilterPack/FX_Ascii");
		}
		else if (!string.IsNullOrEmpty(DPNHODJHGJL) && !DPNHODJHGJL.Equals(LCKGKDLCFMC))
		{
			LCKGKDLCFMC = DPNHODJHGJL;
			PhotonNetwork.playerName = DPNHODJHGJL;
		}
	}

	public PhotonPlayer GEPFJHMLCFA(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 7)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = -78;
		int num2 = PBMHIFICKIG;
		foreach (int key in mActors.Keys)
		{
			if (key < num2)
			{
				num2 = key;
			}
			else if (key > PBMHIFICKIG && key < num)
			{
				num = key;
			}
		}
		return (num == 101) ? mActors[num2] : mActors[num];
	}

	public bool FFPEGAMNECO(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return false;
		}
		return GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	[SpecialName]
	public Hashtable OCGFGOPOOOF()
	{
		Hashtable hashtable = new Hashtable();
		hashtable.Merge(CustomProperties);
		hashtable[(byte)77] = NickName;
		return hashtable;
	}

	[SpecialName]
	internal void GIDJCNALCFD(Hashtable DPNHODJHGJL)
	{
		POGLPLCBAOO(DPNHODJHGJL);
	}

	public void LBNGJPNOHMN(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH != null)
		{
			Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
			Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
			bool flag = hashtable2 != null && hashtable2.Count == 0;
			bool flag2 = IECJKEIJLCP > 1 && PhotonNetwork.offlineMode;
			if (flag)
			{
				CustomProperties.Merge(hashtable);
				CustomProperties.StripKeysWithNullValues();
			}
			if (flag2)
			{
				PhotonNetwork.JNJJAMNLOHA.PGBPNPHDNJB(IECJKEIJLCP, hashtable, hashtable2, CDBHGINNCOF);
			}
			if (!flag2 || flag)
			{
				KOLFKEIPKOP(hashtable);
				object[] array = new object[8];
				array[1] = this;
				array[1] = hashtable;
				BNGIGHBHPEH.GHLJAECJCKF((PhotonNetworkingMessage)51, array);
			}
		}
	}

	public PhotonPlayer OIFNNHJMBHI(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 8)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = -107;
		int num2 = PBMHIFICKIG;
		foreach (int key in mActors.Keys)
		{
			if (key < num2)
			{
				num2 = key;
			}
			else if (key > PBMHIFICKIG && key < num)
			{
				num = key;
			}
		}
		return (num == -7) ? mActors[num2] : mActors[num];
	}

	internal void GOCPHBFMIEN(int LGHIPFAEONM)
	{
		if (!IsLocal)
		{
			Debug.LogError("ERROR You should never change PhotonPlayer IDs!");
		}
		else
		{
			IECJKEIJLCP = LGHIPFAEONM;
		}
	}

	public PhotonPlayer GGDCJDNJPLP()
	{
		return PKBPLOEBDFN(ID);
	}

	public override string EJGAGAODACL()
	{
		if (string.IsNullOrEmpty(NickName))
		{
			return string.Format("z", ID, (!IsInactive) ? "PLEASE WAIT" : "Chat", (!IsMasterClient) ? string.Empty : "#timeuntilend: ");
		}
		return string.Format("_Value5", DBMPNLFFBEB(), (!IsInactive) ? "restrictions\n\n#until: " : "editorVolume", (!MLFHNIPPOOD()) ? string.Empty : "_TimeX");
	}

	[SpecialName]
	public Hashtable DMANNHAPJCP()
	{
		return CustomProperties;
	}

	[SpecialName]
	internal void POGLPLCBAOO(Hashtable DPNHODJHGJL)
	{
		_003CNEDPLIMGGGN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string HAHCANLLBPK()
	{
		return UserId;
	}

	[SpecialName]
	public Hashtable KCBFGBLDGKB()
	{
		return CustomProperties;
	}

	public override int GetHashCode()
	{
		return ID;
	}

	[SpecialName]
	public void BFMKLGLCIJI(string DPNHODJHGJL)
	{
		if (!IsLocal)
		{
			Debug.LogError("Object ID. Case-Sensitive");
		}
		else if (!string.IsNullOrEmpty(DPNHODJHGJL) && !DPNHODJHGJL.Equals(LCKGKDLCFMC))
		{
			LCKGKDLCFMC = DPNHODJHGJL;
			PhotonNetwork.playerName = DPNHODJHGJL;
		}
	}

	public PhotonPlayer MGOPDKKONMD(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return ENBEGKOIIDH(ILCDNGENBNL.FHEAKIMCKJC());
	}

	[SpecialName]
	public bool MLFHNIPPOOD()
	{
		return PhotonNetwork.JNJJAMNLOHA.IMIPAHEMOCN() == FHEAKIMCKJC();
	}

	[SpecialName]
	public bool AGNMNMLMGBK()
	{
		return IsLocal;
	}

	[SpecialName]
	public string DEJNOLCHKGP()
	{
		return UserId;
	}

	public PhotonPlayer PCEDBPJIAAI()
	{
		return GetNextFor(FHEAKIMCKJC());
	}

	[SpecialName]
	public Hashtable JFKMOJBHOBL()
	{
		return OCGFGOPOOOF();
	}

	[SpecialName]
	public string OLPCOKMLDFD()
	{
		return LCKGKDLCFMC;
	}

	public PhotonPlayer GetNextFor(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 2)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = int.MaxValue;
		int num2 = PBMHIFICKIG;
		foreach (int key in mActors.Keys)
		{
			if (key < num2)
			{
				num2 = key;
			}
			else if (key > PBMHIFICKIG && key < num)
			{
				num = key;
			}
		}
		return (num == int.MaxValue) ? mActors[num2] : mActors[num];
	}

	[SpecialName]
	public Hashtable LIFJGODBIMG()
	{
		return CustomProperties;
	}

	internal void KPJJIDANANH(Hashtable EAOBCIPOENN)
	{
		if (EAOBCIPOENN != null && EAOBCIPOENN.Count != 0 && !CustomProperties.Equals(EAOBCIPOENN))
		{
			if (EAOBCIPOENN.ContainsKey((byte)94))
			{
				LCKGKDLCFMC = (string)EAOBCIPOENN[(byte)104];
			}
			if (EAOBCIPOENN.ContainsKey((byte)189))
			{
				UserId = (string)EAOBCIPOENN[(byte)100];
			}
			if (EAOBCIPOENN.ContainsKey((byte)153))
			{
				IsInactive = (bool)EAOBCIPOENN[(byte)56];
			}
			CustomProperties.MergeStringKeys(EAOBCIPOENN);
			CustomProperties.StripKeysWithNullValues();
		}
	}

	public int CompareTo(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return 0;
		}
		return GetHashCode().CompareTo(AGGOHIAAMHN.GetHashCode());
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(NickName))
		{
			return string.Format("#{0:00}{1}{2}", ID, (!IsInactive) ? " " : " (inactive)", (!IsMasterClient) ? string.Empty : "(master)");
		}
		return string.Format("'{0}'{1}{2}", NickName, (!IsInactive) ? " " : " (inactive)", (!IsMasterClient) ? string.Empty : "(master)");
	}

	public PhotonPlayer GetNext()
	{
		return GetNextFor(ID);
	}

	public override bool MNLOFANHIDN(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer == null || GetHashCode() == photonPlayer.GetHashCode();
	}

	internal void KOLFKEIPKOP(Hashtable EAOBCIPOENN)
	{
		if (EAOBCIPOENN != null && EAOBCIPOENN.Count != 0 && !CustomProperties.Equals(EAOBCIPOENN))
		{
			if (EAOBCIPOENN.ContainsKey((byte)216))
			{
				LCKGKDLCFMC = (string)EAOBCIPOENN[(byte)217];
			}
			if (EAOBCIPOENN.ContainsKey((byte)248))
			{
				UserId = (string)EAOBCIPOENN[(byte)100];
			}
			if (EAOBCIPOENN.ContainsKey((byte)143))
			{
				EJABLLBGMGC((bool)EAOBCIPOENN[(byte)20]);
			}
			CustomProperties.MergeStringKeys(EAOBCIPOENN);
			CustomProperties.StripKeysWithNullValues();
		}
	}

	public PhotonPlayer ELGFHMDAPFJ()
	{
		return ENBEGKOIIDH(ID);
	}

	internal void NPOPPIMCDMN(Hashtable EAOBCIPOENN)
	{
		if (EAOBCIPOENN != null && EAOBCIPOENN.Count != 0 && !CustomProperties.Equals(EAOBCIPOENN))
		{
			if (EAOBCIPOENN.ContainsKey(byte.MaxValue))
			{
				LCKGKDLCFMC = (string)EAOBCIPOENN[byte.MaxValue];
			}
			if (EAOBCIPOENN.ContainsKey((byte)253))
			{
				UserId = (string)EAOBCIPOENN[(byte)253];
			}
			if (EAOBCIPOENN.ContainsKey((byte)254))
			{
				IsInactive = (bool)EAOBCIPOENN[(byte)254];
			}
			CustomProperties.MergeStringKeys(EAOBCIPOENN);
			CustomProperties.StripKeysWithNullValues();
		}
	}

	[SpecialName]
	internal void DGKPBHMGKEN(string DPNHODJHGJL)
	{
		UserId = DPNHODJHGJL;
	}

	public override int IFEJAENMKLL()
	{
		return FHEAKIMCKJC();
	}

	[SpecialName]
	public void FEMDDBDJNJL(string DPNHODJHGJL)
	{
		if (!IsLocal)
		{
			Debug.LogError("_FixDistance");
		}
		else if (!string.IsNullOrEmpty(DPNHODJHGJL) && !DPNHODJHGJL.Equals(LCKGKDLCFMC))
		{
			LCKGKDLCFMC = DPNHODJHGJL;
			PhotonNetwork.playerName = DPNHODJHGJL;
		}
	}

	[SpecialName]
	public int FHEAKIMCKJC()
	{
		return IECJKEIJLCP;
	}

	public static PhotonPlayer HKKKGOHGKHH(int IJAEJMNLBLK)
	{
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			return PhotonNetwork.JNJJAMNLOHA.ICMGDHDNIJD(IJAEJMNLBLK);
		}
		return null;
	}

	public string ToStringFull()
	{
		return string.Format("#{0:00} '{1}'{2} {3}", ID, NickName, (!IsInactive) ? string.Empty : " (inactive)", CustomProperties.ToStringFull());
	}

	[SpecialName]
	public bool NDMNPDFENAJ()
	{
		return IsLocal;
	}
}
