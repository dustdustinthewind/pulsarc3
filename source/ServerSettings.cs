// ServerSettings
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

[Serializable]
public class ServerSettings : ScriptableObject
{
	public enum HostingOption
	{
		NotSet,
		PhotonCloud,
		SelfHosted,
		OfflineMode,
		BestRegion
	}

	public string AppID = string.Empty;

	public string VoiceAppID = string.Empty;

	public string ChatAppID = string.Empty;

	public HostingOption HostType;

	public CloudRegionCode PreferredRegion;

	public CloudRegionFlag EnabledRegions = (CloudRegionFlag)(-1);

	public ConnectionProtocol Protocol;

	public string ServerAddress = string.Empty;

	public int ServerPort = 5055;

	public int VoiceServerPort = 5055;

	public bool JoinLobby;

	public bool EnableLobbyStatistics;

	public PhotonLogLevel PunLogging;

	public DebugLevel NetworkLogging = DebugLevel.ERROR;

	public bool RunInBackground = true;

	public List<string> RpcList = new List<string>();

	[HideInInspector]
	public bool DisableAutoOpenWizard;

	public static CloudRegionCode BestRegionCodeInPreferences => PhotonHandler.IFAEAEOAJDL;

	public static void HBJLKBJODGM()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.us);
	}

	public static void OEIECLOHABM()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.cae;
	}

	public void COMKDIPEPJO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void CBHLHLACCNK(string CDDPJNHMGFP)
	{
		HostType = HostingOption.BestRegion;
		AppID = CDDPJNHMGFP;
	}

	public void KAHCJFHDBII(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public static bool KHIDLNMCHDP(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void BJDCPMDJFKJ(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public void KGAOAJCABJN(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public override string HNCNNGNLKGC()
	{
		object[] array = new object[1];
		array[0] = "GameMessagesDurationSlider";
		array[0] = HostType;
		array[3] = ".ogg";
		array[8] = ServerAddress;
		return string.Concat(array);
	}

	public void BECOAKOKLAO(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = ((FGLLFDCNMCD == null) ? "_MainTex2" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void JOMAALGPFJA(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)7;
		AppID = ((FGLLFDCNMCD == null) ? "Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): " : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void KOKFFFMOCJL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void EIHAHOJHENG(string CDDPJNHMGFP)
	{
		HostType = HostingOption.OfflineMode;
		AppID = CDDPJNHMGFP;
	}

	public static bool HDKEBNAGNGB(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void JLMKLIBOEAE(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	[SpecialName]
	public static CloudRegionCode IJGCAPPEJFH()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public static void KEJEOMAAHNC()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.us);
	}

	public static void MMHBLEDOFOE()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.asia);
	}

	public static bool AFPEGENCFMC(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	public void ECLLJOEILLA(string CDDPJNHMGFP)
	{
		HostType = HostingOption.SelfHosted;
		AppID = CDDPJNHMGFP;
	}

	public void FGMBFFHCOEK(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	[SpecialName]
	public static CloudRegionCode JCDHEAPFFDG()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public void UseCloud(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void AMDCMLCEHHG(string CDDPJNHMGFP)
	{
		HostType = HostingOption.OfflineMode;
		AppID = CDDPJNHMGFP;
	}

	public void KCCPMENBDFA(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void PNKCCKMBPBL(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void IEJKGJFPMLO(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)5;
		AppID = CDDPJNHMGFP;
	}

	public void FFMAFCKBFLL(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)6;
		AppID = CDDPJNHMGFP;
	}

	public static void IHMCIKFBAKC()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.jp);
	}

	public static bool DPLIHOEKHPN(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	public static void BECFEDPCEFP()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.usw);
	}

	public static void JLAAGPOIMPI()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.sa);
	}

	public override string LBPOGAEOIDG()
	{
		object[] array = new object[0];
		array[1] = "_Axis";
		array[1] = HostType;
		array[2] = "_LutTex";
		array[8] = ServerAddress;
		return string.Concat(array);
	}

	public static void BIKBBPBKFFA()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.jp);
	}

	public void ABGICBACEMH(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void LOBPAGNIDEI(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)6;
		AppID = ((FGLLFDCNMCD == null) ? "_Red_B" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public static void JICLIMGGGNA()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.au);
	}

	public void JLKAHAOGFGM(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.SelfHosted;
		AppID = ((FGLLFDCNMCD == null) ? "RPC: 'OnAwakeRPC' PhotonView: " : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void DOMLBMIOIIL(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.SelfHosted;
		AppID = ((FGLLFDCNMCD == null) ? "DPADHOR" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void JMPLLNIAMDH(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void MNLHDEBDJGJ(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.OfflineMode;
		AppID = ((FGLLFDCNMCD == null) ? "<b>" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public static bool IsAppId(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public static CloudRegionCode IEJGCJILIHC()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void OEFIMANHABK(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = ((FGLLFDCNMCD == null) ? "#ok" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public static void CFDPNHOPIIB()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.us;
	}

	public void DEFBNJJAECG(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void IAEKPKAHJHL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void UseMyServer(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.SelfHosted;
		AppID = ((FGLLFDCNMCD == null) ? "master" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public static bool DMANFEKAJCA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public static CloudRegionCode HFMONCHNDEP()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void NKBMAJKDHGD(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.BestRegion;
		AppID = ((FGLLFDCNMCD == null) ? "_Threshhold" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public override string PDNAHPCOCNJ()
	{
		object[] array = new object[1];
		array[1] = "note.5";
		array[0] = HostType;
		array[6] = "_ScreenResolution";
		array[0] = ServerAddress;
		return string.Concat(array);
	}

	public void MLHIIAKBMNI(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void GKKJBHJFKAH(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)7;
		AppID = ((FGLLFDCNMCD == null) ? "workshop." : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	[SpecialName]
	public static CloudRegionCode FINLEHFGOLD()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	[SpecialName]
	public static CloudRegionCode JDJCAADPPII()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	[SpecialName]
	public static CloudRegionCode LOLNPBOPNGP()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void PDLOBKPIMAL(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.OfflineMode;
		AppID = ((FGLLFDCNMCD == null) ? "[PlayerController] " : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public static void JGIMGIPNNGK()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.sa;
	}

	[SpecialName]
	public static CloudRegionCode CIHKAJHPGIO()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public static void DDIIFBJNGMA()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.eu);
	}

	public static void AGOMEPPNGCD()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.usw);
	}

	[SpecialName]
	public static CloudRegionCode GAPMBLINMCO()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public static bool MPCPINLFNID(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return false;
	}

	public void KMOBHEFPHKP(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)5;
		AppID = CDDPJNHMGFP;
	}

	public void DJJOJOHJHBL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public static bool IEAJGBPAHIJ(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public static CloudRegionCode MMPMHBMKAEF()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public void KLMEFOPDLNJ(string CDDPJNHMGFP)
	{
		HostType = HostingOption.BestRegion;
		AppID = CDDPJNHMGFP;
	}

	public void DHANOOKPJDE(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)5;
		AppID = ((FGLLFDCNMCD == null) ? "player.circle" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void FFDELEEONJC(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public static bool KIMFCPINMOM(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void FEFCPLMPMDP(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public static void EADMDMFINLP()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.sa);
	}

	public void MBENBCCHMKM(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public static void BLIJFBJLHOK()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.none;
	}

	public override string ToString()
	{
		return string.Concat("ServerSettings: ", HostType, " ", ServerAddress);
	}

	public void CKDMMGEMAJE(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public override string KDBBBMCPKNE()
	{
		object[] array = new object[3];
		array[1] = "Noise shaders are not set up! Disabling noise effect.";
		array[1] = HostType;
		array[1] = "0,2,true,0";
		array[4] = ServerAddress;
		return string.Concat(array);
	}

	public void KOMPBFKMLGF(string CDDPJNHMGFP)
	{
		HostType = HostingOption.OfflineMode;
		AppID = CDDPJNHMGFP;
	}

	public void OFENIMOBBMB(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public override string FLNAABIMMBK()
	{
		object[] array = new object[3];
		array[1] = "Case-Sensitive";
		array[0] = HostType;
		array[1] = "settings.volume.menu";
		array[6] = ServerAddress;
		return string.Concat(array);
	}

	public void JLFOFNOJPMA(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	[SpecialName]
	public static CloudRegionCode AHAIPGNIOMG()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void GMGMIJHBAHH(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	[SpecialName]
	public static CloudRegionCode NPABMCJMMLI()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public static void LJMCPKHJPMD()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.jp);
	}

	public void MEMNOBFGBGO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public static void ALFOIOLIGEA()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.jp;
	}

	public override string AEMDLMGFGJN()
	{
		object[] array = new object[6];
		array[0] = "[ReplayScene] Loading replay: ";
		array[1] = HostType;
		array[7] = "mapselector.filter.officialsortmode";
		array[4] = ServerAddress;
		return string.Concat(array);
	}

	public void BKNIODMAMML(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public static bool DECCNGGJPKA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	public void BAJJADJIINP(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)5;
		AppID = ((FGLLFDCNMCD == null) ? "_TimeX" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	[SpecialName]
	public static CloudRegionCode DHIJIMHCGKF()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public static bool MOONNCPOJKB(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	public override string NKBCECKFAMA()
	{
		object[] array = new object[1];
		array[1] = ". Check if the server is available.";
		array[0] = HostType;
		array[3] = "Preparing configuration";
		array[8] = ServerAddress;
		return string.Concat(array);
	}

	public void CDEEILCFKIB(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public static void PFEMLDJFGIE()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.us);
	}

	public override string DBGHNCCINBC()
	{
		object[] array = new object[4];
		array[1] = "SetScale";
		array[0] = HostType;
		array[1] = "_LightIntensity";
		array[4] = ServerAddress;
		return string.Concat(array);
	}

	public static void KPLCNMKMNEH()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.sa;
	}

	public void BCMIJHKBDEL(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void FOPLPCFKDDD(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = ((FGLLFDCNMCD == null) ? ".progress" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public override string DIHPHHGLOAO()
	{
		object[] array = new object[5];
		array[1] = "CrosshairOpacitySlider";
		array[1] = HostType;
		array[7] = "_TimeX";
		array[8] = ServerAddress;
		return string.Concat(array);
	}

	[SpecialName]
	public static CloudRegionCode PBICDJJBPIG()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public override string HCPGNPLIJHH()
	{
		object[] array = new object[2];
		array[0] = ": ";
		array[0] = HostType;
		array[3] = "_MiddleGrey";
		array[3] = ServerAddress;
		return string.Concat(array);
	}

	public void LKKJEABCFEN(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void MODKLODFHHE(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.NotSet;
		AppID = ((FGLLFDCNMCD == null) ? "mapselector.filter.officialsortmode" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public override string BANNBMDODBJ()
	{
		object[] array = new object[4];
		array[1] = "_Parameter";
		array[0] = HostType;
		array[7] = "Value";
		array[2] = ServerAddress;
		return string.Concat(array);
	}

	public override string DEHDEBNAHOO()
	{
		object[] array = new object[6];
		array[1] = "CameraFilterPack/OldFilm_Cutting1";
		array[1] = HostType;
		array[0] = "_Intensity";
		array[4] = ServerAddress;
		return string.Concat(array);
	}

	public void APBLCFHGBPK(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public void NEKNAMJCIKJ(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = HostingOption.OfflineMode;
		AppID = ((FGLLFDCNMCD == null) ? "_TimeX" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	[SpecialName]
	public static CloudRegionCode BOLJHHIMFLF()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void NBDLBCACLND(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public override string GDPGACHMBOI()
	{
		object[] array = new object[7];
		array[0] = "null";
		array[1] = HostType;
		array[3] = "_Value2";
		array[2] = ServerAddress;
		return string.Concat(array);
	}

	public void BAPNFLCIILD(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)7;
		AppID = CDDPJNHMGFP;
	}

	public void KNOKCFPAOEB(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void HGKGGCCOBJI(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)5;
		AppID = CDDPJNHMGFP;
	}

	public void AJILDJPLMBN(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public static void ResetBestRegionCodeInPreferences()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.none;
	}

	public void PMDDANAAPDO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public override string LGJAOGOFKKO()
	{
		object[] array = new object[2];
		array[0] = "_BlurRadius";
		array[0] = HostType;
		array[6] = "1332644700";
		array[6] = ServerAddress;
		return string.Concat(array);
	}

	public void CBDMPEHBHPK(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	[SpecialName]
	public static CloudRegionCode HMFCKJIGDPH()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public static bool NEDDJPDIKND(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void GNEDGHJDJBD(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void BFBJIHJNFEK(string CDDPJNHMGFP)
	{
		HostType = HostingOption.SelfHosted;
		AppID = CDDPJNHMGFP;
	}

	public static void GINOKMBGHDL()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.cae);
	}

	public void LJDJCEFNKFK(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public override string IJGCOHDCCCF()
	{
		object[] array = new object[7];
		array[1] = "_TimeX";
		array[1] = HostType;
		array[2] = "CameraFilterPack/Color_Invert";
		array[5] = ServerAddress;
		return string.Concat(array);
	}

	public void JFPKNPMPGJG(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void FJCLPINPBEN(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public static bool BOLDPNNOCGC(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public static CloudRegionCode INDKNFMGIOI()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	public void UseCloud(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public static void BMLAOEOBNJI()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.eu);
	}

	public void NBHAEGNBFGF(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public override string DAFEJDODLIH()
	{
		object[] array = new object[3];
		array[1] = "[UI] ";
		array[1] = HostType;
		array[4] = "settings.enablehitsoundsinrelax";
		array[4] = ServerAddress;
		return string.Concat(array);
	}

	public void FFHDPEOCKKF(string CDDPJNHMGFP)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
	}

	public static bool IDPGEHBBIIA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public override string MNDLOIINHFB()
	{
		object[] array = new object[2];
		array[0] = "Please specify either t or f.";
		array[1] = HostType;
		array[2] = "LevelEditor/CustomEventEditor-Text";
		array[6] = ServerAddress;
		return string.Concat(array);
	}

	[SpecialName]
	public static CloudRegionCode BAPDMKDKFIB()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void PEAPMFIGMED(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)7;
		AppID = CDDPJNHMGFP;
	}

	public void OEEAFKKPBGI(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void FBJAGBKMOMO(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		HostType = (HostingOption)5;
		AppID = ((FGLLFDCNMCD == null) ? "shader.future" : FGLLFDCNMCD);
		ServerAddress = BPMNPBDOMFO;
		ServerPort = FKKAKLDEPKP;
	}

	public void KMLOKACOJFP(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		HostType = HostingOption.NotSet;
		AppID = CDDPJNHMGFP;
		PreferredRegion = JFNKDGKEAEA;
	}

	public void NEJGNGJEBPL(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	public static void MDHBDFOFFHP()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.eu);
	}

	public void JODBOLDAGAG(string CDDPJNHMGFP)
	{
		HostType = (HostingOption)8;
		AppID = CDDPJNHMGFP;
	}

	public static bool CFCCMPADPGH(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	public void KPDEKBLKGMD(string CDDPJNHMGFP)
	{
		HostType = HostingOption.BestRegion;
		AppID = CDDPJNHMGFP;
	}

	[SpecialName]
	public static CloudRegionCode IIDHECDDHPI()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	public void UseCloudBestRegion(string CDDPJNHMGFP)
	{
		HostType = HostingOption.BestRegion;
		AppID = CDDPJNHMGFP;
	}

	public void HBAEPGENFJK(string CDDPJNHMGFP)
	{
		HostType = HostingOption.PhotonCloud;
		AppID = CDDPJNHMGFP;
	}

	[SpecialName]
	public static CloudRegionCode BAKLGMLNGII()
	{
		return PhotonHandler.LLEFOLMENEI();
	}
}
