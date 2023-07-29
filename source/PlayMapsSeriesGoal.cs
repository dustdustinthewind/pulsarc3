// PlayMapsSeriesGoal
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class PlayMapsSeriesGoal : ChallengeGoal
{
	private int MHLPNLMDILP;

	private string CBMKNPLELGP = "true";

	private List<string> ODBKIFAGALM;

	public override void KOPCJLJINGL()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(BNFMCBKNANL);
		base.OnCompleted();
	}

	public override void GNFAPFNAHGA()
	{
		base.IJLBKALOBNO();
		string @string = Singleton<SaveSystem>.Instance.GetString(DIDHNLABPNG() + "_Blue_G");
		if (!string.IsNullOrEmpty(@string))
		{
			char[] array = new char[0];
			array[1] = '￢';
			ODBKIFAGALM = @string.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = HBBKCBNFAHL();
	}

	public override void LEOGCFNJJKP()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(JPEODDLKMPI);
		base.OnCompleted();
	}

	public override void MGPDJFEAODD()
	{
		Singleton<GameManager>.Instance.AEIIHIGCCOF(MAPGGELENNM);
		base.DDOBENFDOKL();
	}

	public override void DINBNCDLEAN()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(FDHGPNBJKMP() + "Vertical");
		base.GONKPNAAIEE();
	}

	private void FHOJKHCHFDB(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			NHCKOAMBEDE(DLGFNCGHLPK());
		}
	}

	public override void MJDPGEMCBID(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '(';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("CameraFilterPack_Paper3", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(HCPDBEPGAPP);
		Singleton<GameManager>.Instance.PGNNMANJJAC(NFEKBNOPFBC);
		IJLBKALOBNO();
	}

	public override void NBAMNMMPFDN()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(PHPLKBPIMIH() + "PUNCloudBestRegion");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = '\ufffa';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		EHAMFOBIPEO(BAGMMHJOHBC());
	}

	public override void DOPPMCDLPBE()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(CKOFDGAJCFF() + "_Value2", string.Join("_Value3", ODBKIFAGALM.ToArray()));
	}

	public override void AIFAGDOHAGD()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(FDHGPNBJKMP() + "Set Satellite Sensitivity");
		base.GONKPNAAIEE();
	}

	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = CAOJDEFHMAG();
		}
	}

	public override void JABAIIKHHCF()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetString(FDHGPNBJKMP() + "Freq: ", string.Join("float,1.5", ODBKIFAGALM.ToArray()));
	}

	private float PKFDNFMNMOD()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void JKILPDLMHMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '￨';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("_Saturation", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(OGCLNFHJAHE);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(FHOJKHCHFDB);
		DKHLEEPCLEL();
	}

	public override void JLDKJHBIDGP()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(FDHGPNBJKMP() + "_Curve");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = '\uffde';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		OFPKLCAICJA(EOOBFBPJFKE());
	}

	public override void NEPIKEBNOHI()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(CKOFDGAJCFF() + "CameraFilterPack/Oculus_ThermaVision", string.Join("settings_bindings_", ODBKIFAGALM.ToArray()));
	}

	public override void EPFCHBACBAH()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(CKOFDGAJCFF() + "RequestForPickupItems");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('N').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		JMMJKHLAIMI(PKFDNFMNMOD());
	}

	public override void EAJBKDEOBLE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('ﾗ');
		string s = array[1];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("mapid", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(FHOJKHCHFDB);
		Singleton<GameManager>.Instance.OnFinishedMap += EIFKFKKKENO;
		LoadProgress();
	}

	private float DLGFNCGHLPK()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private float EJMAHGJLNBG()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private void JPEODDLKMPI(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = EJMAHGJLNBG();
		}
	}

	public override void DPPBKDMBLHN()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(FDHGPNBJKMP() + "_Value3");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[1];
			array[1] = 'ﾻ';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		ENHBNIOEKLF(NHJKKMCFKCH());
	}

	private float BAGMMHJOHBC()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private void BNFMCBKNANL(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			JMMJKHLAIMI(DLGFNCGHLPK());
		}
	}

	public override void KBKFJCIEPLO()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetString(CKOFDGAJCFF() + "Menu", string.Join("icon", ODBKIFAGALM.ToArray()));
	}

	public override void IOIAOIMIIMA()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(EIFKFKKKENO);
		base.LMCKEFAMAJG();
	}

	public override void APJPLEFJFJP()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(DIDHNLABPNG() + "_Value2", string.Join("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", ODBKIFAGALM.ToArray()));
	}

	public override void BMCHFDEABCK()
	{
		base.LoadProgress();
		string @string = Singleton<SaveSystem>.Instance.GetString(PFIOEOGECFG() + "lobby '{0}'[{1}]");
		if (!string.IsNullOrEmpty(@string))
		{
			char[] array = new char[0];
			array[1] = 'W';
			ODBKIFAGALM = @string.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		ENHBNIOEKLF(DLGFNCGHLPK());
	}

	private void FOMECIHDEJO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			EHAMFOBIPEO(OCHLGJOOOPJ());
		}
	}

	public override void BLFODOAHNGK()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(PFIOEOGECFG() + "menutheme.deleted", string.Join("[MapEditor] Created new map: ", ODBKIFAGALM.ToArray()));
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.OnCompleted();
	}

	public override void JOABPMBAHCA()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(FDHGPNBJKMP() + "menutheme.jamaicanorcdub");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('\uffc0').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		OFPKLCAICJA(ODDPHOKLIJJ());
	}

	public override void CJLIDOOABHD()
	{
		base.DKHLEEPCLEL();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(FDHGPNBJKMP() + "y");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = 'ﾟ';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		ENHBNIOEKLF(NHJKKMCFKCH());
	}

	public override void HJAGMELHNGH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '￤';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("r", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(HOGJGGGDPDD);
		Singleton<GameManager>.Instance.IDDINACMJAK(BNFMCBKNANL);
		AFGLHMCLJJN();
	}

	public override void PKFHBBCFEHG()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(FDHGPNBJKMP() + "Editor/", string.Join("#craftng", ODBKIFAGALM.ToArray()));
	}

	public override void NJBGPNNPBNH()
	{
		base.LoadProgress();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(PHPLKBPIMIH() + "_Far");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = '3';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		NHCKOAMBEDE(EIHBAKMMIPB());
	}

	public override void ONJJLLEOMAH()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(EIFKFKKKENO);
		base.DDOBENFDOKL();
	}

	public override void GENNDFFJJNH()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(DIDHNLABPNG() + "/");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[1];
			array[1] = 'e';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		JMMJKHLAIMI(EJMAHGJLNBG());
	}

	public override void MANOCIJICLG()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(PHPLKBPIMIH() + "CameraFilterPack/OldFilm_Cutting2");
		base.GONKPNAAIEE();
	}

	public override void OIIALMBOFIF()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(FDHGPNBJKMP() + "Myst", string.Join("No peer to communicate with. ", ODBKIFAGALM.ToArray()));
	}

	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PHPLKBPIMIH() + ".completedMaps");
		base.Reset();
	}

	private void BEJELNEHAKF(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			OFPKLCAICJA(PKFDNFMNMOD());
		}
	}

	public override void NHDLPBMMEDK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\ufffb';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("Can't do manual instantiation without PhotonView component.", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(GLALLABIBEH);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(FOMECIHDEJO);
		CCGAPNPGAOL();
	}

	public override void PMLIOODCKDB()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PNLACKIPGLD() + ">");
		base.JGMBGCOFCJI();
	}

	public override void NHJBGDIEGPH()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(PFIOEOGECFG() + ".lastCheckpoint.comboScore");
		base.GONKPNAAIEE();
	}

	private void HCPDBEPGAPP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			PNACFCEIEHH(DAMBIOACPOI());
		}
	}

	public override void HNOFKPAIJEN()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(DIDHNLABPNG() + "ViewMenu", string.Join("player.bluebat", ODBKIFAGALM.ToArray()));
	}

	public override void ICAAJACIAPH()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(PNLACKIPGLD() + "selector");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = 'E';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		EHAMFOBIPEO(EOOBFBPJFKE());
	}

	public override void EEOILGPOBJG()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(CKOFDGAJCFF() + "Sent count: ");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('$').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		NHCKOAMBEDE(PKFDNFMNMOD());
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		string @string = Singleton<SaveSystem>.Instance.GetString(PHPLKBPIMIH() + ".completedMaps");
		if (!string.IsNullOrEmpty(@string))
		{
			ODBKIFAGALM = @string.Split(',').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = CAOJDEFHMAG();
	}

	private float CAOJDEFHMAG()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void GHILLBKBCBO()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(FDHGPNBJKMP() + "BitsData", string.Join("CameraFilterPack/Gradients_Ansi", ODBKIFAGALM.ToArray()));
	}

	private float KFACOFLCBFJ()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\ufff1';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("ACCEPT", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(MAPGGELENNM);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(BDJEFCKJDNF);
		LoadProgress();
	}

	private void NFEKBNOPFBC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			PNACFCEIEHH(BAGMMHJOHBC());
		}
	}

	public override void EFHAJPNDLCA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('d');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("MenuScene", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(EIFKFKKKENO);
		Singleton<GameManager>.Instance.CDJJAFLCOGO(BDJEFCKJDNF);
		AFGLHMCLJJN();
	}

	private float AHHAEFIBOAD()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void PCFMEKEIBPA()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(FDHGPNBJKMP() + "_EdgeSharpness");
		base.GONKPNAAIEE();
	}

	public override void BANGDPJJFJL()
	{
		Singleton<GameManager>.Instance.AEIIHIGCCOF(FOMECIHDEJO);
		base.OnCompleted();
	}

	public override void KHMFEHEPGAM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\uffc1';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("CameraFilterPack/3D_Myst", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(GLALLABIBEH);
		Singleton<GameManager>.Instance.PGNNMANJJAC(MAPGGELENNM);
		JJPHFPDNDEC();
	}

	private void DIPOCCCCAKM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			EHAMFOBIPEO(HBBKCBNFAHL());
		}
	}

	public override void KMEFHCDNDNF()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PNLACKIPGLD() + ".played");
		base.GONKPNAAIEE();
	}

	public override void KJIKILLKNDJ()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(CKOFDGAJCFF() + ". Check if the server is available.");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('\u001d').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		PNACFCEIEHH(CAOJDEFHMAG());
	}

	public override void LKADGENOJFK()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(CKOFDGAJCFF() + "CameraFilterPack/TV_Old_Movie");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[1] = '\n';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		PNACFCEIEHH(ODDPHOKLIJJ());
	}

	public override void HBEJAGDGJAI()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetString(FDHGPNBJKMP() + "Outdated version. Please restart the game to get lastest updates.", string.Join("_Size", ODBKIFAGALM.ToArray()));
	}

	private float HBBKCBNFAHL()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private float NHJKKMCFKCH()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void KHLHDMNJCOE()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.LMCKEFAMAJG();
	}

	public override void IIBOPBADDGH()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PFIOEOGECFG() + ".lastCheckpoint.bgcolor");
		base.Reset();
	}

	private float OKMLICIEMEG()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private void OGCLNFHJAHE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			ENHBNIOEKLF(EIHBAKMMIPB());
		}
	}

	public override void PMDCMCFHBNM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '^';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("HightScoreMaxPointsText", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(LIIGHENCIFC);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(HCPDBEPGAPP);
		DKHLEEPCLEL();
	}

	public override void KKMJBDCDDAH()
	{
		base.LoadProgress();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(PHPLKBPIMIH() + "_TimeX");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[1] = 'ﾗ';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		ENHBNIOEKLF(KFACOFLCBFJ());
	}

	public override void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('ﾘ');
		string s = array[1];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("Hidden/LensAberrations", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(BNFMCBKNANL);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(HCPDBEPGAPP);
		DKHLEEPCLEL();
	}

	private float DAMBIOACPOI()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private float EOOBFBPJFKE()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private float OCHLGJOOOPJ()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void BBMFEBFCLJI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '`';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_ClutTex", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(BEJELNEHAKF);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(HOGJGGGDPDD);
		DKHLEEPCLEL();
	}

	private float EIHBAKMMIPB()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void EGJFECEMKFC()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(FOMECIHDEJO);
		base.OnCompleted();
	}

	public override void DLMODJHDOGK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'ﾏ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("settings.volume.sfx", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(DIPOCCCCAKM);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(BDJEFCKJDNF);
		LoadProgress();
	}

	public override void HJHMCJPPINB()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(PNLACKIPGLD() + "Move environment object to the position", string.Join("[Left]", ODBKIFAGALM.ToArray()));
	}

	private void LIIGHENCIFC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			OFPKLCAICJA(DLGFNCGHLPK());
		}
	}

	public override void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('￢');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("restrictions\n\n#until: ", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		Singleton<GameManager>.Instance.CDJJAFLCOGO(BEJELNEHAKF);
		LoadProgress();
	}

	public override void KAEILMBFJHE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '￭';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_FadeFX", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(NFEKBNOPFBC);
		Singleton<GameManager>.Instance.IDDINACMJAK(BDJEFCKJDNF);
		JJPHFPDNDEC();
	}

	public override void HAPELGDNDFN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '\uffd0';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("shader.sunny", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(BEJELNEHAKF);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(OGCLNFHJAHE);
		CCGAPNPGAOL();
	}

	public override void FMHBLFELOGC()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PHPLKBPIMIH() + "settings.hitvariation");
		base.JGMBGCOFCJI();
	}

	public override void KFHEJFGOHIN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '\u0005';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("DPADVER", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(FOMECIHDEJO);
		Singleton<GameManager>.Instance.PGNNMANJJAC(EIFKFKKKENO);
		NAHLBHOLNCG();
	}

	public override void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = 'ﾦ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("Sent count: ", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(EIFKFKKKENO);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(JPEODDLKMPI);
		DKHLEEPCLEL();
	}

	public override void CCGAPNPGAOL()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(DIDHNLABPNG() + "yyyy-MM-dd HH:mm:ss");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('ￛ').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = DLGFNCGHLPK();
	}

	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(',');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join(",", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += HOGJGGGDPDD;
		LoadProgress();
	}

	public override void CPGAFFIOGCH()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(DIDHNLABPNG() + "[Left]");
		base.EEBGCGFNELO();
	}

	public override void DGDGIJFIKDE()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(GLALLABIBEH);
		base.LMCKEFAMAJG();
	}

	public override void FBHAGNFBIHL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '\ufff2';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= BDJEFCKJDNF;
		Singleton<GameManager>.Instance.OnFinishedMap += NFEKBNOPFBC;
		LoadProgress();
	}

	public override void EJDGJIHCNOA()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.IPEDKOMAKPP(FDHGPNBJKMP() + "CameraFilterPack/Blur_Radial");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('\u001d').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = HBBKCBNFAHL();
	}

	public override void AFFLBJKDKMD()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(DIDHNLABPNG() + " room(s)", string.Join("_Distortion", ODBKIFAGALM.ToArray()));
	}

	public override void EEBGCGFNELO()
	{
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP(PHPLKBPIMIH() + "BadgeImage");
		base.JGMBGCOFCJI();
	}

	public override void FPNFJNEABNP()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(BEJELNEHAKF);
		base.LMCKEFAMAJG();
	}

	public override void COMOGFCIOMP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'ￜ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("/", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(FHOJKHCHFDB);
		Singleton<GameManager>.Instance.OnFinishedMap += BNFMCBKNANL;
		LoadProgress();
	}

	public override void FKCNACFMIOD()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(FDHGPNBJKMP() + "SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", string.Join("_TimeX", ODBKIFAGALM.ToArray()));
	}

	public override void OGAMGLEAOAF()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PNLACKIPGLD() + "[EMPTY]");
		base.Reset();
	}

	public override void AFCNHKOOHDF()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(FDHGPNBJKMP() + "settings.enableselectormusic", string.Join("_Value2", ODBKIFAGALM.ToArray()));
	}

	public override void IACAMALGJKO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('{');
		string s = array[1];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("Save level before uploading?", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(MAPGGELENNM);
		Singleton<GameManager>.Instance.CDJJAFLCOGO(OGCLNFHJAHE);
		IJLBKALOBNO();
	}

	private void BDJEFCKJDNF(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			ENHBNIOEKLF(AHHAEFIBOAD());
		}
	}

	private float ODDPHOKLIJJ()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void KBOHCNNJGCN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(GLALLABIBEH);
		base.LMCKEFAMAJG();
	}

	public override void LBAEJINADDP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '\u007f';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_TimeX", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= NFEKBNOPFBC;
		Singleton<GameManager>.Instance.DCGKDPPLKBP(FOMECIHDEJO);
		NAHLBHOLNCG();
	}

	public override void BEJNMIKAFON(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'ￛ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("Mouse1", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(HOGJGGGDPDD);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(BEJELNEHAKF);
		DKHLEEPCLEL();
	}

	public override void OKDKEJEJJAN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(JPEODDLKMPI);
		base.LMCKEFAMAJG();
	}

	public override void FEFLLKFKCBG()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(PHPLKBPIMIH() + "X2", string.Join("_BokehParams", ODBKIFAGALM.ToArray()));
	}

	public override void NHDCGONGILN()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.LMCKEFAMAJG();
	}

	private void EIFKFKKKENO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = ODDPHOKLIJJ();
		}
	}

	public override void MOOFNOAOAMF(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\uffde';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("NOISE", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(HOGJGGGDPDD);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(MAPGGELENNM);
		IJLBKALOBNO();
	}

	public override void DOKEOBBOHEL()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(FHOJKHCHFDB);
		base.OnCompleted();
	}

	private float JFLGNNHAHEJ()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void JODHOODGJGP()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(PNLACKIPGLD() + "/", string.Join("Scene", ODBKIFAGALM.ToArray()));
	}

	public override void ODMIEHCODOK()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(PHPLKBPIMIH() + "Text");
		base.LIMBEFBJNPL();
	}

	public override void OOEIABOMFHP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '~';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("VIGNETTE_CLASSIC", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(HCPDBEPGAPP);
		Singleton<GameManager>.Instance.PGNNMANJJAC(FHOJKHCHFDB);
		AFGLHMCLJJN();
	}

	public override void GCLJDBADLOA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('\u0019');
		string s = array[1];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("[PlayerController] ", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(BNFMCBKNANL);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(LIIGHENCIFC);
		AFGLHMCLJJN();
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetString(PHPLKBPIMIH() + ".completedMaps", string.Join(",", ODBKIFAGALM.ToArray()));
	}

	public override void PCIOHCMKFBE()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(CKOFDGAJCFF() + "_Axis");
		base.JGMBGCOFCJI();
	}

	public override void IIMKNABKCAL()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(FDHGPNBJKMP() + "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", string.Join("_Value", ODBKIFAGALM.ToArray()));
	}

	private void MAPGGELENNM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			OFPKLCAICJA(ODDPHOKLIJJ());
		}
	}

	public override void PLCBPLLCNIC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'ﾲ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("Tab2Content", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(DIPOCCCCAKM);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(BDJEFCKJDNF);
		CCGAPNPGAOL();
	}

	public override void LECPHJOIGKN()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(DIDHNLABPNG() + "_ScreenResolution");
		base.LIMBEFBJNPL();
	}

	public override void DINJDLBLOEC()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(PNLACKIPGLD() + "float,0");
		base.JGMBGCOFCJI();
	}

	public override void JLBNGLIKEPA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '.';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join(",", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(BEJELNEHAKF);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(NFEKBNOPFBC);
		LoadProgress();
	}

	private void GLALLABIBEH(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = PKFDNFMNMOD();
		}
	}
}
