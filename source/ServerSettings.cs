// taken from dnspy (right click -> edit class)

using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000321 RID: 801
[Serializable]
public class ServerSettings : ScriptableObject
{
	// Token: 0x0600B8BF RID: 47295
	public virtual string FFJLDNEABNA()
	{
		object[] array = new object[7];
		array[1] = "Crosshair";
		array[0] = this.HostType;
		array[4] = "inventory.itemscash";
		array[1] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8C0 RID: 47296
	public void MGEDMBBNMNK(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = ((FGLLFDCNMCD == null) ? "." : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8C1 RID: 47297
	public static void JLAAGPOIMPI()
	{
		PhotonHandler.AKCFDMKDPDF(CloudRegionCode.cae);
	}

	// Token: 0x0600B8C2 RID: 47298
	public void OHINHFAJKPO(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8C3 RID: 47299
	public void NBHAEGNBFGF(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8C4 RID: 47300
	public void KGHIKPDDOCO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8C5 RID: 47301
	public void KLMEFOPDLNJ(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8C6 RID: 47302
	public void DGHCHNCLPCK(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8C7 RID: 47303
	public void DJKFHNGBPIA(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8C8 RID: 47304
	public void NIODGMFADMO(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8C9 RID: 47305
	public static void FCNOHGJGCDE()
	{
		PhotonHandler.MGFNBDJHJHF(CloudRegionCode.au);
	}

	// Token: 0x0600B8CA RID: 47306
	public void PLLIJBPPDHI(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8CB RID: 47307
	public static void FHPNJDCOKDP()
	{
		PhotonHandler.EMNECPFJKCF(CloudRegionCode.sa);
	}

	// Token: 0x0600B8CC RID: 47308
	public static CloudRegionCode LGJMKDKBINP()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B8CD RID: 47309
	public static CloudRegionCode FPABBEFPGCJ()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B8CE RID: 47310
	public void JFPKNPMPGJG(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8CF RID: 47311
	public static CloudRegionCode JKEPIEAGFEK()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B8D0 RID: 47312
	public void FFPLAPGMFNN(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = ((FGLLFDCNMCD == null) ? "Set sun beat detection sensitivity" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8D1 RID: 47313
	public static void ICDDICIPGLI()
	{
		PhotonHandler.EPAAGLKFNKN(CloudRegionCode.none);
	}

	// Token: 0x0600B8D2 RID: 47314
	public void AJDDOAGLJKF(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "/" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8D3 RID: 47315
	public void UseCloud(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8D4 RID: 47316
	public void DDKCMGOLPCC(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8D5 RID: 47317
	public void GBBJPFGBGDL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8D6 RID: 47318
	public static void NEFABPDBNDF()
	{
		PhotonHandler.MGFNBDJHJHF(CloudRegionCode.au);
	}

	// Token: 0x0600B8D7 RID: 47319
	public void BECOAKOKLAO(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = ((FGLLFDCNMCD == null) ? "_TimeX" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8D8 RID: 47320
	public void JLMKLIBOEAE(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8D9 RID: 47321
	public void FBFFDLGLEIB(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "PunSupportLogger" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8DA RID: 47322
	public static CloudRegionCode JJEFBCDAMOA()
	{
		return PhotonHandler.LOLNPBOPNGP();
	}

	// Token: 0x0600B8DB RID: 47323
	public static CloudRegionCode LMBNIMLIFPC()
	{
		return PhotonHandler.BBGGKBOFEEJ();
	}

	// Token: 0x0600B8DC RID: 47324
	public static CloudRegionCode PBICDJJBPIG()
	{
		return PhotonHandler.LOLNPBOPNGP();
	}

	// Token: 0x0600B8DD RID: 47325
	public static void LGGCIKGCNCD()
	{
		PhotonHandler.EMNECPFJKCF(CloudRegionCode.au);
	}

	// Token: 0x0600B8DE RID: 47326
	public static CloudRegionCode HNMHONMFKFE()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B8DF RID: 47327
	public static void KOJFJKDOHHG()
	{
		PhotonHandler.MGFNBDJHJHF(CloudRegionCode.eu);
	}

	// Token: 0x0600B8E0 RID: 47328
	public static CloudRegionCode LLNNKKJBHJJ()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B8E1 RID: 47329
	public virtual string BNGOOJMFMDB()
	{
		object[] array = new object[4];
		array[0] = "_Intensity";
		array[1] = this.HostType;
		array[5] = "_Distortion";
		array[6] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8E2 RID: 47330
	public static bool OODBIFIOGBB(string ONANKNCCCGO)
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

	// Token: 0x0600B8E3 RID: 47331
	public virtual string DPKHAAJNCBI()
	{
		object[] array = new object[]
		{
			null,
			"s"
		};
		array[0] = this.HostType;
		array[0] = "ConfigVersionSlider";
		array[5] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8E4 RID: 47332
	public virtual string LBHNHFNFGOE()
	{
		object[] array = new object[]
		{
			null,
			"LevelNameInputField"
		};
		array[1] = this.HostType;
		array[3] = "_MainTex2";
		array[5] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8E5 RID: 47333
	public virtual string BFDPAGJIDAO()
	{
		object[] array = new object[5];
		array[0] = ".played";
		array[1] = this.HostType;
		array[8] = "_ScreenResolution";
		array[8] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8E6 RID: 47334
	public void IOHJKLOBLGP(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8E7 RID: 47335
	public void BMIHPOOJIPP(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = ((FGLLFDCNMCD == null) ? "_PositionX" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8E8 RID: 47336
	public void UseCloud(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8E9 RID: 47337
	public void DFBOPANOKEM(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)8;
		this.AppID = ((FGLLFDCNMCD == null) ? " should be overwritten." : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8EA RID: 47338
	public void EINOGKCBCJE(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8EB RID: 47339
	public void DHJKCIGHPNA(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = ((FGLLFDCNMCD == null) ? "Player Connected" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8EC RID: 47340
	public void BPEEBFPHFML(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8ED RID: 47341
	public void EELIKCPMHCE(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)8;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8EE RID: 47342
	public void UseCloudBestRegion(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8EF RID: 47343
	public void NFNCPFMGAFI(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8F0 RID: 47344
	public static CloudRegionCode PCAHHENPIOA()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B8F1 RID: 47345
	public void GKKHIILOJDB(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8F2 RID: 47346
	public static void JICLIMGGGNA()
	{
		PhotonHandler.EAIMGDDNOAD(CloudRegionCode.none);
	}

	// Token: 0x0600B8F3 RID: 47347
	public static CloudRegionCode FLBHJAGDDDB()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B8F4 RID: 47348
	public void OMJKCKPDDHF(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)8;
		this.AppID = ((FGLLFDCNMCD == null) ? "PowerUp" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8F5 RID: 47349
	public static void CCGIPJMHELF()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.cae;
	}

	// Token: 0x0600B8F6 RID: 47350
	public static void AHIBHAOFMPJ()
	{
		PhotonHandler.EAIMGDDNOAD(CloudRegionCode.jp);
	}

	// Token: 0x0600B8F7 RID: 47351
	public static bool LEMPPPHICGG(string ONANKNCCCGO)
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

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x0600B8F8 RID: 47352
	public static CloudRegionCode BestRegionCodeInPreferences
	{
		get
		{
			return PhotonHandler.IFAEAEOAJDL;
		}
	}

	// Token: 0x0600B8F9 RID: 47353
	public static void JJDHNECOAKP()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.us;
	}

	// Token: 0x0600B8FA RID: 47354
	public static CloudRegionCode MCNHIKOLCBD()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B8FB RID: 47355
	public virtual string FJKKMOLOGFP()
	{
		object[] array = new object[1];
		array[1] = "shader.sunny";
		array[1] = this.HostType;
		array[2] = "Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8FC RID: 47356
	public void HGKGGCCOBJI(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8FD RID: 47357
	public void UseMyServer(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "master" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8FE RID: 47358
	public static bool EDJALMLMEDM(string ONANKNCCCGO)
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

	// Token: 0x0600B8FF RID: 47359
	public override string ToString()
	{
		return string.Concat(new object[]
		{
			"ServerSettings: ",
			this.HostType,
			" ",
			this.ServerAddress
		});
	}

	// Token: 0x0600B900 RID: 47360
	public static void ICJHECMKAEC()
	{
		PhotonHandler.EMNECPFJKCF(CloudRegionCode.sa);
	}

	// Token: 0x0600B901 RID: 47361
	public void NKBMAJKDHGD(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = ((FGLLFDCNMCD == null) ? "???" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B902 RID: 47362
	public static bool JMBHAENPFOA(string ONANKNCCCGO)
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

	// Token: 0x0600B903 RID: 47363
	public static void IJCPKEHOGKM()
	{
		PhotonHandler.LFAAMMACPOO(CloudRegionCode.usw);
	}

	// Token: 0x0600B904 RID: 47364
	public void CAMAHIEKEJN(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = ((FGLLFDCNMCD == null) ? "menu.selectedplaymode" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B905 RID: 47365
	public void IHECAMFMPBP(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = ((FGLLFDCNMCD == null) ? "false" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B906 RID: 47366
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

	// Token: 0x0600B907 RID: 47367
	public static bool NFMLKOEEHPC(string ONANKNCCCGO)
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

	// Token: 0x0600B908 RID: 47368
	public static void ResetBestRegionCodeInPreferences()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.none;
	}

	// Token: 0x0600B909 RID: 47369
	public void DOMLBMIOIIL(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = ((FGLLFDCNMCD == null) ? "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B90A RID: 47370
	public void GPDLHCEJGNG(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B90B RID: 47371
	public void BKNIODMAMML(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B90C RID: 47372
	public virtual string LANIINMKIBO()
	{
		object[] array = new object[]
		{
			"_CameraClipInfo",
			this.HostType,
			null,
			null,
			null,
			null,
			"CameraFilterPack/AAA_BloodOnScreen"
		};
		array[5] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B90D RID: 47373
	public static bool PLNJLNMOPAI(string ONANKNCCCGO)
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

	// Token: 0x0600B90E RID: 47374
	public static CloudRegionCode ACOMHNGDKOP()
	{
		return PhotonHandler.PILGGGKCGMO();
	}

	// Token: 0x0600B90F RID: 47375
	public static void PEOCCOKPNMP()
	{
		PhotonHandler.EMNECPFJKCF(CloudRegionCode.jp);
	}

	// Token: 0x0600B910 RID: 47376
	public static void CLNIANFEHFB()
	{
		PhotonHandler.MGFNBDJHJHF(CloudRegionCode.asia);
	}

	// Token: 0x0600B911 RID: 47377
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
		return false;
	}

	// Token: 0x0600B912 RID: 47378
	public static bool NGGIPACAHPD(string ONANKNCCCGO)
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

	// Token: 0x0600B913 RID: 47379
	public void KIHLCDMDGGA(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B914 RID: 47380
	public void EICPNKPPBIJ(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B915 RID: 47381
	public static CloudRegionCode DJNKIJOBHLH()
	{
		return PhotonHandler.FAKCBKGPMBF();
	}

	// Token: 0x0600B916 RID: 47382
	public static CloudRegionCode GNAGKAMLJPO()
	{
		return PhotonHandler.ACOMHNGDKOP();
	}

	// Token: 0x0600B917 RID: 47383
	public void HLFLDKKIDNF(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = ((FGLLFDCNMCD == null) ? "_Value3" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B918 RID: 47384
	public void ECLLJOEILLA(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)6;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B919 RID: 47385
	public virtual string HNCNNGNLKGC()
	{
		object[] array = new object[1];
		array[0] = "Vertical";
		array[1] = this.HostType;
		array[5] = "_Value2";
		array[7] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B91A RID: 47386
	public virtual string CFALDCPGMCA()
	{
		object[] array = new object[8];
		array[1] = "Editing: ";
		array[0] = this.HostType;
		array[2] = "colorC";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B91B RID: 47387
	public ServerSettings()
	{
	}

	// Token: 0x0600B91C RID: 47388
	public static void HCLNHJOHOCL()
	{
		PhotonHandler.AKCFDMKDPDF(CloudRegionCode.au);
	}

	// Token: 0x0600B91D RID: 47389
	public static CloudRegionCode HHHNPAFLALB()
	{
		return PhotonHandler.LOLNPBOPNGP();
	}

	// Token: 0x0600B91E RID: 47390
	public void CBDMPEHBHPK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B91F RID: 47391
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

	// Token: 0x0600B920 RID: 47392
	public static void PGHLAEEPPNA()
	{
		PhotonHandler.EAIMGDDNOAD(CloudRegionCode.none);
	}

	// Token: 0x0600B921 RID: 47393
	public static void EFAFPNLEGJO()
	{
		PhotonHandler.EPAAGLKFNKN(CloudRegionCode.usw);
	}

	// Token: 0x0600B922 RID: 47394
	public void OMGJGKOGKBF(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B923 RID: 47395
	public static CloudRegionCode ILAMBJLENJD()
	{
		return PhotonHandler.MFGPJCLHKJL();
	}

	// Token: 0x0600B924 RID: 47396
	public static void LCCDHGJDIKB()
	{
		PhotonHandler.IGGNAKLOFLO(CloudRegionCode.cae);
	}

	// Token: 0x04001586 RID: 5510
	public string AppID = string.Empty;

	// Token: 0x04001587 RID: 5511
	public string VoiceAppID = string.Empty;

	// Token: 0x04001588 RID: 5512
	public string ChatAppID = string.Empty;

	// Token: 0x04001589 RID: 5513
	public ServerSettings.HostingOption HostType;

	// Token: 0x0400158A RID: 5514
	public CloudRegionCode PreferredRegion;

	// Token: 0x0400158B RID: 5515
	public CloudRegionFlag EnabledRegions = (CloudRegionFlag)(-1);

	// Token: 0x0400158C RID: 5516
	public ConnectionProtocol Protocol;

	// Token: 0x0400158D RID: 5517
	public string ServerAddress = string.Empty;

	// Token: 0x0400158E RID: 5518
	public int ServerPort = 5055;

	// Token: 0x0400158F RID: 5519
	public int VoiceServerPort = 5055;

	// Token: 0x04001590 RID: 5520
	public bool JoinLobby;

	// Token: 0x04001591 RID: 5521
	public bool EnableLobbyStatistics;

	// Token: 0x04001592 RID: 5522
	public PhotonLogLevel PunLogging;

	// Token: 0x04001593 RID: 5523
	public DebugLevel NetworkLogging = DebugLevel.ERROR;

	// Token: 0x04001594 RID: 5524
	public bool RunInBackground = true;

	// Token: 0x04001595 RID: 5525
	public List<string> RpcList = new List<string>();

	// Token: 0x04001596 RID: 5526
	[HideInInspector]
	public bool DisableAutoOpenWizard;

	// Token: 0x02000322 RID: 802
	public enum HostingOption
	{
		// Token: 0x04001598 RID: 5528
		NotSet,
		// Token: 0x04001599 RID: 5529
		PhotonCloud,
		// Token: 0x0400159A RID: 5530
		SelfHosted,
		// Token: 0x0400159B RID: 5531
		OfflineMode,
		// Token: 0x0400159C RID: 5532
		BestRegion
	}
}
