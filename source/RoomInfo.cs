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

	[SpecialName]
	internal void MJFHIPPPIFC(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	public override string PIHOCGDHMDH()
	{
		object[] array = new object[6];
		array[1] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "_TimeX" : "Bad parameters for getstring! Use <key> <value>");
		array[4] = ((!PNAALABONJG) ? "Joystick1Button8" : "EditMenu");
		array[0] = MDLLBJEFCCJ;
		array[2] = IHCFPJIDFOP();
		return string.Format("Creating new item...", array);
	}

	[SpecialName]
	public bool PMBLEHFDGCN()
	{
		return NJDMEIOHILA();
	}

	[SpecialName]
	public void HFHFBFPMIHG(bool DPNHODJHGJL)
	{
		GMAADPICNOF(DPNHODJHGJL);
	}

	[SpecialName]
	public bool EEKFKBANKFH()
	{
		return FKPGMMEIEJD();
	}

	[SpecialName]
	public bool NMBLKEMKGFL()
	{
		return DBFGBOLNOIO();
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
	internal void HEPDIDMOOBL(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string DHFECLEBANC()
	{
		return LCKGKDLCFMC;
	}

	public override bool FAEELIPGIBL(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public byte HAKOLKCNMME()
	{
		return MDLLBJEFCCJ;
	}

	public string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount, ILOIDCICMKC.ToStringFull());
	}

	[SpecialName]
	public string LLDKMIJOMJE()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public bool KEFEAENEDJO()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public byte LGGHIADHKAO()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public void JPMNHFMALJB(bool DPNHODJHGJL)
	{
		_003CGBODHEAGOGK_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool NJDMEIOHILA()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public Hashtable FLIGPINOOGI()
	{
		return ILOIDCICMKC;
	}

	public override bool IAIKFPLMECP(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || KPOEKHOONAE().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public bool EPJBEHKANHJ()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public bool IMGLOFGLDJK()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public int FEABBJGGNEA()
	{
		return _003CMENHEBDBIFC_003Ek__BackingField;
	}

	[SpecialName]
	public byte LEGDCDGCALI()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public void FDPCDHGJFGA(bool DPNHODJHGJL)
	{
		BFPOAJNHBLE(DPNHODJHGJL);
	}

	[SpecialName]
	public bool ALKCGCIEJDD()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public void EFJLOAJOGID(int DPNHODJHGJL)
	{
		PlayerCount = DPNHODJHGJL;
	}

	[SpecialName]
	public string HOKHGFFAKGG()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public Hashtable BGOPIJPICLJ()
	{
		return ILOIDCICMKC;
	}

	[SpecialName]
	public bool DBFGBOLNOIO()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public bool PKEEBGMKFCD()
	{
		return KCLILCMPKIF();
	}

	[SpecialName]
	public bool MCJCLCKFPLG()
	{
		return IMGLOFGLDJK();
	}

	[SpecialName]
	public int HGEDKPOGLFC()
	{
		return PlayerCount;
	}

	[SpecialName]
	public Hashtable EHLPGMBBDLG()
	{
		return CustomProperties;
	}

	[SpecialName]
	public bool JIOMABAFFGE()
	{
		return IsLocalClientInside;
	}

	[SpecialName]
	public void GMAADPICNOF(bool DPNHODJHGJL)
	{
		_003CGBODHEAGOGK_003Ek__BackingField = DPNHODJHGJL;
	}

	public override int JNPJFOJAJFG()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	[SpecialName]
	private void PDAPBBGFOHE(int DPNHODJHGJL)
	{
		_003CMENHEBDBIFC_003Ek__BackingField = DPNHODJHGJL;
	}

	public override int GetHashCode()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	[SpecialName]
	public byte HLICJKDDECK()
	{
		return LEGDCDGCALI();
	}

	[SpecialName]
	public void JPBAEFPAABM(bool DPNHODJHGJL)
	{
		JPMNHFMALJB(DPNHODJHGJL);
	}

	[SpecialName]
	public byte FMPNAJBBAMM()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public string KPOEKHOONAE()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public void DHMKNLPFOKE(bool DPNHODJHGJL)
	{
		BFPOAJNHBLE(DPNHODJHGJL);
	}

	[SpecialName]
	private void GMHFOPLAHFA(int DPNHODJHGJL)
	{
		_003CMENHEBDBIFC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	internal void FFDJINLBACL(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private void DFFOIFOINGL(bool DPNHODJHGJL)
	{
		_003CIGNEFDJICLF_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public Hashtable MMANMADHAND()
	{
		return ILOIDCICMKC;
	}

	public override bool Equals(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	public override bool JPGKHHINOIL(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || CGPHGEJJENL().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public string IAACBCKEOKI()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public void DCKHCGMJDHF(bool DPNHODJHGJL)
	{
		CIJJEMMHBGM(DPNHODJHGJL);
	}

	public override bool OPJOBDOOGPB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public Hashtable OJKFLHKNPKO()
	{
		return FLIGPINOOGI();
	}

	public string HBKDADPEFLP()
	{
		object[] array = new object[4];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "CameraFilterPack_Paper2" : "_BaseTex");
		array[5] = ((!PNAALABONJG) ? ".completedMaps" : ".completedMaps");
		array[7] = MDLLBJEFCCJ;
		array[2] = BFMOMEFLOPF();
		array[1] = ILOIDCICMKC.ToStringFull();
		return string.Format("_TimeX", array);
	}

	protected internal RoomInfo(string IOJPMCOBHEJ, Hashtable EAOBCIPOENN)
	{
		NPOPPIMCDMN(EAOBCIPOENN);
		LCKGKDLCFMC = IOJPMCOBHEJ;
	}

	[SpecialName]
	public Hashtable PFFHNNODEMM()
	{
		return CustomProperties;
	}

	public string JCBKKBIANLD()
	{
		object[] array = new object[6];
		array[0] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "_SweaterSize" : "EditMenu");
		array[6] = ((!PNAALABONJG) ? "Paste events" : "ArcsHitsoundTimeDelaySlider");
		array[1] = MDLLBJEFCCJ;
		array[5] = PlayerCount;
		array[1] = ILOIDCICMKC.ToStringFull();
		return string.Format("RequestForPickupItems", array);
	}

	[SpecialName]
	public int IPOLOPNJIHB()
	{
		return _003CMENHEBDBIFC_003Ek__BackingField;
	}

	public override bool GIILICBCEEB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public bool GKCAPAFNILA()
	{
		return NNKPAPHLCIN();
	}

	[SpecialName]
	private void MKKAMEBKKDK(bool DPNHODJHGJL)
	{
		_003CIGNEFDJICLF_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void BKDNGAJNOCI(int DPNHODJHGJL)
	{
		PlayerCount = DPNHODJHGJL;
	}

	public override bool CJHGNEBNMNB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public byte NGEMOEEPDMC()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public bool DHHCGHCIEDK()
	{
		return DBFGBOLNOIO();
	}

	[SpecialName]
	private void EGNGCMILMND(bool DPNHODJHGJL)
	{
		_003CIGNEFDJICLF_003Ek__BackingField = DPNHODJHGJL;
	}

	public override int CGLEEFLBJIE()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	[SpecialName]
	public Hashtable ODKNHODFPJK()
	{
		return ILOIDCICMKC;
	}

	[SpecialName]
	public void NNDCPJBINJE(int DPNHODJHGJL)
	{
		GMHFOPLAHFA(DPNHODJHGJL);
	}

	[SpecialName]
	public void IBBLDNKGBNL(int DPNHODJHGJL)
	{
		GMHFOPLAHFA(DPNHODJHGJL);
	}

	[SpecialName]
	public void PJHAPBDFMBH(bool DPNHODJHGJL)
	{
		CIJJEMMHBGM(DPNHODJHGJL);
	}

	[SpecialName]
	public string EGDILAHOLCC()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public bool EINCKBNFALL()
	{
		return KEFEAENEDJO();
	}

	[SpecialName]
	public void CIJJEMMHBGM(bool DPNHODJHGJL)
	{
		_003CGBODHEAGOGK_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool GAPAFCEEHIP()
	{
		return IsLocalClientInside;
	}

	[SpecialName]
	public bool DCEBNBGKFHC()
	{
		return _003CDCAKFOHNABM_003Ek__BackingField;
	}

	public override string BEKGOMJHHND()
	{
		object[] array = new object[8];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "Testing, the group has toggled [" : "_MainTex2");
		array[4] = ((!PNAALABONJG) ? "NetworkCanvas" : "_Value2");
		array[8] = MDLLBJEFCCJ;
		array[3] = BFMOMEFLOPF();
		return string.Format("SetSpeed", array);
	}

	public override string AAPCGENPDKE()
	{
		object[] array = new object[0];
		array[1] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "recipes" : "_ScreenResolution");
		array[6] = ((!PNAALABONJG) ? "_VignetteBlur" : "menutheme.summerbreeze");
		array[8] = MDLLBJEFCCJ;
		array[1] = FEABBJGGNEA();
		return string.Format("mapselector.filter.subscribedonly", array);
	}

	[SpecialName]
	public bool BHLIJAIEGIM()
	{
		return EPJBEHKANHJ();
	}

	public string CNJIIFJGNDM()
	{
		object[] array = new object[3];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "_Value" : "event");
		array[5] = ((!PNAALABONJG) ? "_TimeX" : "Up");
		array[5] = MDLLBJEFCCJ;
		array[8] = IHCFPJIDFOP();
		array[1] = ILOIDCICMKC.ToStringFull();
		return string.Format("sfxVolume", array);
	}

	[SpecialName]
	public bool JAMCLPIFMED()
	{
		return NJDMEIOHILA();
	}

	[SpecialName]
	public bool NKIENLFMMOL()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public Hashtable KMBLODHBAFO()
	{
		return BGOPIJPICLJ();
	}

	[SpecialName]
	private void INGBNFJELAJ(int DPNHODJHGJL)
	{
		_003CMENHEBDBIFC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public int EOCKFCNGHAD()
	{
		return PlayerCount;
	}

	public string GGDFOHIGJLK()
	{
		object[] array = new object[4];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "0,2,true,0" : "_Offsets");
		array[7] = ((!PNAALABONJG) ? "_ScreenResolution" : "event");
		array[7] = MDLLBJEFCCJ;
		array[2] = IPOLOPNJIHB();
		array[0] = ILOIDCICMKC.ToStringFull();
		return string.Format("[Up-Right]", array);
	}

	public string IMCIGKBAJKJ()
	{
		object[] array = new object[7];
		array[1] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? " " : "_HardBlend");
		array[7] = ((!PNAALABONJG) ? "CameraFilterPack/Drawing_CellShading" : "[MapsSystem] Unloading maps resources...");
		array[5] = MDLLBJEFCCJ;
		array[8] = BFMOMEFLOPF();
		array[0] = ILOIDCICMKC.ToStringFull();
		return string.Format(".jpg", array);
	}

	[SpecialName]
	internal void OBBPPCHMOOM(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	public override string NHHOIHIOCDI()
	{
		object[] array = new object[2];
		array[1] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "Set sun audio input" : "yyyy-MM-dd HH:mm:ss");
		array[4] = ((!PNAALABONJG) ? "CameraFilterPack/Color_YUV" : "Set Object Scale");
		array[8] = MDLLBJEFCCJ;
		array[6] = BFMOMEFLOPF();
		return string.Format("settings.disablestoryboard", array);
	}

	public string OENLPGLAELP()
	{
		object[] array = new object[6];
		array[0] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "_Value2" : "players");
		array[7] = ((!PNAALABONJG) ? "settings.volume.editor" : "_Value3");
		array[2] = MDLLBJEFCCJ;
		array[0] = PlayerCount;
		array[0] = ILOIDCICMKC.ToStringFull();
		return string.Format("settings.crosshairopacity", array);
	}

	[SpecialName]
	internal void GAGJIOPKAGB(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool HDBGEHLINHJ()
	{
		return _003CDCAKFOHNABM_003Ek__BackingField;
	}

	public override bool JHCGGHMMEDK(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public string CGPHGEJJENL()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public int MLOONFAAGLG()
	{
		return BFMOMEFLOPF();
	}

	[SpecialName]
	public byte CKKLGDMDFPN()
	{
		return MDLLBJEFCCJ;
	}

	[SpecialName]
	public string DPGOJAHONLO()
	{
		return CGPHGEJJENL();
	}

	public override bool BPOBCHFLHPO(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public bool NNKPAPHLCIN()
	{
		return PNAALABONJG;
	}

	[SpecialName]
	public void ADMDCAKOJKI(int DPNHODJHGJL)
	{
		INGBNFJELAJ(DPNHODJHGJL);
	}

	[SpecialName]
	public int BFMOMEFLOPF()
	{
		return _003CMENHEBDBIFC_003Ek__BackingField;
	}

	[SpecialName]
	public int IHCFPJIDFOP()
	{
		return _003CMENHEBDBIFC_003Ek__BackingField;
	}

	public override string BIKPHEFOKOC()
	{
		object[] array = new object[3];
		array[1] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "\n" : "settings.enablerankingnotifications");
		array[4] = ((!PNAALABONJG) ? "_CutOff" : "_Value");
		array[7] = MDLLBJEFCCJ;
		array[7] = FEABBJGGNEA();
		return string.Format("icon", array);
	}

	[SpecialName]
	public bool LPBKMHINIIL()
	{
		return EPJBEHKANHJ();
	}

	public override string ToString()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", LCKGKDLCFMC, (!FMPBAGHEJDN) ? "hidden" : "visible", (!PNAALABONJG) ? "closed" : "open", MDLLBJEFCCJ, PlayerCount);
	}

	[SpecialName]
	protected internal bool APLNBBHLMFP()
	{
		return _003CIGNEFDJICLF_003Ek__BackingField;
	}

	[SpecialName]
	public bool FKPGMMEIEJD()
	{
		return FMPBAGHEJDN;
	}

	[SpecialName]
	public bool BMCMFOHDLOP()
	{
		return _003CGBODHEAGOGK_003Ek__BackingField;
	}

	[SpecialName]
	public int GPJHLKJLFOM()
	{
		return FEABBJGGNEA();
	}

	[SpecialName]
	public void GMHFJIFDIKL(bool DPNHODJHGJL)
	{
		JPMNHFMALJB(DPNHODJHGJL);
	}

	[SpecialName]
	public Hashtable MMPBJBAJAAI()
	{
		return ILOIDCICMKC;
	}

	[SpecialName]
	public bool MOAPFJCANFA()
	{
		return _003CGBODHEAGOGK_003Ek__BackingField;
	}

	[SpecialName]
	internal void INOPPFPKPJE(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string OHHFGLCLGAD()
	{
		return LCKGKDLCFMC;
	}

	[SpecialName]
	public bool KLFKAPJIKAN()
	{
		return NJDMEIOHILA();
	}

	[SpecialName]
	internal void EBCABOJAIKH(bool DPNHODJHGJL)
	{
		_003CDCAKFOHNABM_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool JHMMCKPCNDL()
	{
		return NNKPAPHLCIN();
	}

	public override int PLLLJDJJJKN()
	{
		return LCKGKDLCFMC.GetHashCode();
	}

	public override bool JOGDFHOLLME(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	[SpecialName]
	public void BFPOAJNHBLE(bool DPNHODJHGJL)
	{
		_003CGBODHEAGOGK_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool KCLILCMPKIF()
	{
		return _003CGBODHEAGOGK_003Ek__BackingField;
	}

	[SpecialName]
	public byte JNMMOPHKDHB()
	{
		return MDLLBJEFCCJ;
	}

	public override bool NPBOHIHIMJA(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	public string FNKLJHFHFIL()
	{
		object[] array = new object[4];
		array[0] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "note.5" : "_Value5");
		array[5] = ((!PNAALABONJG) ? "_TimeX" : "CameraFilterPack_Glasses_On7");
		array[5] = MDLLBJEFCCJ;
		array[5] = IPOLOPNJIHB();
		array[0] = ILOIDCICMKC.ToStringFull();
		return string.Format("#tryagain", array);
	}

	public override string BNGOOJMFMDB()
	{
		object[] array = new object[1];
		array[0] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "Creating new item..." : ".lastCheckpoint.isMapCompleted");
		array[7] = ((!PNAALABONJG) ? "_MainTex2" : "PAUSE [SPACE]");
		array[1] = MDLLBJEFCCJ;
		array[7] = IHCFPJIDFOP();
		return string.Format(" This is not possible to be called for standalone input. Please check your platform and code where this is called", array);
	}

	public string LACNKJGENJM()
	{
		object[] array = new object[5];
		array[0] = LCKGKDLCFMC;
		array[0] = ((!FMPBAGHEJDN) ? "_FgOverlap" : "_Value7");
		array[7] = ((!PNAALABONJG) ? "CameraFilterPack_Paper2" : "_TimeX");
		array[3] = MDLLBJEFCCJ;
		array[3] = PlayerCount;
		array[7] = ILOIDCICMKC.ToStringFull();
		return string.Format(" This is not possible to be called for standalone input. Please check your platform and code where this is called", array);
	}

	public string MJDNELPFKDD()
	{
		object[] array = new object[6];
		array[1] = LCKGKDLCFMC;
		array[1] = ((!FMPBAGHEJDN) ? "_Value" : "_Red_R");
		array[1] = ((!PNAALABONJG) ? "_Green_G" : "LoadMapCanvas");
		array[7] = MDLLBJEFCCJ;
		array[3] = PlayerCount;
		array[5] = ILOIDCICMKC.ToStringFull();
		return string.Format("BadgeText", array);
	}

	[SpecialName]
	public void MELFLLIKPPM(int DPNHODJHGJL)
	{
		PlayerCount = DPNHODJHGJL;
	}

	protected internal void ANMNGNKMHLG(Hashtable KBKCLMDMKCF)
	{
		if (KBKCLMDMKCF == null || KBKCLMDMKCF.Count == 0 || ILOIDCICMKC.Equals(KBKCLMDMKCF))
		{
			return;
		}
		if (KBKCLMDMKCF.ContainsKey((byte)119))
		{
			removedFromList = (bool)KBKCLMDMKCF[(byte)76];
			if (HDBGEHLINHJ())
			{
				return;
			}
		}
		if (KBKCLMDMKCF.ContainsKey((byte)188))
		{
			MDLLBJEFCCJ = (byte)KBKCLMDMKCF[(byte)181];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)175))
		{
			PNAALABONJG = (bool)KBKCLMDMKCF[(byte)154];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)52))
		{
			FMPBAGHEJDN = (bool)KBKCLMDMKCF[(byte)149];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)143))
		{
			INGBNFJELAJ((byte)KBKCLMDMKCF[(byte)162]);
		}
		if (KBKCLMDMKCF.ContainsKey((byte)154))
		{
			FECDEAJPAAJ = (bool)KBKCLMDMKCF[(byte)136];
		}
		if (KBKCLMDMKCF.ContainsKey((byte)134))
		{
			BDHOOLIDFJO = false;
			bool flag = IPBANMNLDPC != 1;
			IPBANMNLDPC = (int)KBKCLMDMKCF[(byte)142];
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.ELDLAPJAPBJ();
			}
		}
		if (KBKCLMDMKCF.ContainsKey((byte)121))
		{
			GFEDJEMJEND = (string[])KBKCLMDMKCF[(byte)41];
		}
		ILOIDCICMKC.MergeStringKeys(KBKCLMDMKCF);
		ILOIDCICMKC.StripKeysWithNullValues();
	}
}
