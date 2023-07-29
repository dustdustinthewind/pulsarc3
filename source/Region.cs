// Region
using System;

public class Region
{
	public CloudRegionCode Code;

	public string Cluster;

	public string HostAndPort;

	public int Ping;

	public static CloudRegionCode AEPBKPIOJEJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.us;
		}
		int num = EJHKMJOLONP.IndexOf('s');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	public override string ToString()
	{
		return $"'{Cluster}' \t{Ping}ms \t{HostAndPort}";
	}

	public override string NOOLCGNJDMM()
	{
		return string.Format("_Shadow", Cluster, Ping, HostAndPort);
	}

	public override string BIJOMIMBEBL()
	{
		return string.Format("y", Cluster, Ping, HostAndPort);
	}

	public override string KDGLICFNLIE()
	{
		return string.Format("value", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode GBBOFINMPDE(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.us;
		}
		int num = EJHKMJOLONP.IndexOf('\u0011');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	internal static CloudRegionFlag OGDFCJCFMHM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag GGJHMHOBIDJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag AJAFBNKKBGK(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag BGBGOBANBOE(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string AAGGLDPCFPF()
	{
		return string.Format("SpawnObj", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode CJKLKFBMLCO(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('^');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.us;
	}

	internal static CloudRegionFlag PPJPIOHGDPI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public override string NGHDDAPEEHB()
	{
		return string.Format("Hex value #RRGGBB", Cluster, Ping, HostAndPort);
	}

	public override string ONMGBNBKPHD()
	{
		return string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode IAPELPAACFI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('s');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	internal static CloudRegionFlag DLDGELCJECA(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public static CloudRegionCode POBAEHEAOPF(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('\u0003');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.us;
	}

	public static CloudRegionCode ECEMJOBFMIM(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('8');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	public override string ENEOGOGJDBP()
	{
		return string.Format("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag CJBADGOCCDN(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public override string PILLKLPMOOH()
	{
		return string.Format("LT", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag EIPDMMHKPGO(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag HLNGKPHACHF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public override string BIKPHEFOKOC()
	{
		return string.Format("error", Cluster, Ping, HostAndPort);
	}

	public override string KAPOJCCKOLH()
	{
		return string.Format("speed", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag EOLGDGINBNB(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public static CloudRegionCode BGDOOLAGGFP(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('ￗ');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	public static CloudRegionCode CKDKMICJADC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('\ufff3');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	public static CloudRegionCode PABOGEPAPNH(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('\0');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	public override string KHOEEKGDNOM()
	{
		return string.Format("_Distortion", Cluster, Ping, HostAndPort);
	}

	public override string INLHLHDMHNK()
	{
		return string.Format("sounds/hit_wrong", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag PEECIJIGOKD(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag FHNAMHDHMLF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag HNGGFKOKEAM(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public static CloudRegionCode EOCMPOLKONB(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf('ￕ');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	internal static CloudRegionFlag HAPCADLMCME(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag FIDANGJOCEG(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag ANCLMFHDGMF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag IKBNKIFACEA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public override string NBADDMBFLNP()
	{
		return string.Format("action", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag HFKCAELGDBN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	[Obsolete]
	internal static CloudRegionFlag JFBLMOGHMPF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public static CloudRegionCode FNBNKIOMNKH(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('_');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	public override string FLJBCAOHMMN()
	{
		return string.Format("offsets", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode PHFOOCOEJEM(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf('￠');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	public override string BANNBMDODBJ()
	{
		return string.Format("settings.enableranking", Cluster, Ping, HostAndPort);
	}

	public override string NJFCPBFAKNL()
	{
		return string.Format("EventData0DropDownList", Cluster, Ping, HostAndPort);
	}

	public Region(CloudRegionCode JFNKDGKEAEA)
	{
		Code = JFNKDGKEAEA;
		Cluster = JFNKDGKEAEA.ToString();
	}

	internal static CloudRegionFlag JDPKCOCOPIA(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag BOHJEGCDFON(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string BEKGOMJHHND()
	{
		return string.Format("CameraFilterPack/Drawing_Manga_Flash", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag JPIMJHDCFFA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public static CloudRegionCode NFEHPMKNHOC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf('ﾬ');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	internal static CloudRegionFlag INKDIGGLLHP(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string DBGLPGMGMGD()
	{
		return string.Format("/", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag KIGKKKAPPIJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag NELEBCCIBGL(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag NOFIHOKNHAA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public override string CNOHJKCIHHN()
	{
		return string.Format("_Value", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag DDLDHNCMHBL(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag IGJJDLMHBPM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public static CloudRegionCode Parse(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.none;
		}
		int num = EJHKMJOLONP.IndexOf('/');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.none;
	}

	internal static CloudRegionFlag GAMALNCEHDP(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag FEGLAFNJKON(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag NACGGIAGBEK(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag OCLAFLBJIEI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag HGDKMJEJCIK(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag HBDKAGDMOFO(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag AIBFFAAGHDF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag JFBLMOGHMPF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag KHONIFNBLDM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string NMANIPNDOKJ()
	{
		return string.Format("OnMastedChangeScene", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode EOPNBLBODNP(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.sa;
		}
		int num = EJHKMJOLONP.IndexOf('\uffd0');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	internal static CloudRegionFlag JGBOOKILAEJ(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public static CloudRegionCode IBBAAFJKEHC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf('ￒ');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.jp;
	}

	internal static CloudRegionFlag LNBMJLKLOJI(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag GDAKNCCMFEI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag PIEBAKPDPOH(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public Region(CloudRegionCode JFNKDGKEAEA, string GOLPAHODNFE, string FJPNDMCELJN)
	{
		Code = JFNKDGKEAEA;
		Cluster = GOLPAHODNFE;
		HostAndPort = FJPNDMCELJN;
	}

	internal static CloudRegionFlag LPEJCCPEOMP(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag NKEOPOMIHJN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public static CloudRegionCode FKKAHBFFHKN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.cae;
		}
		int num = EJHKMJOLONP.IndexOf('\r');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	public override string FFJLDNEABNA()
	{
		return string.Format("_ScreenResolution", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode PKCNBKDDEHF(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('S');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	public static CloudRegionCode AGLOFMCGLJI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf('\ufff4');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	internal static CloudRegionFlag HJCPJAGBKHP(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag AFMODNOIAAM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag CCMBPJHCFBE(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag NBIOEICPLDG(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag HOIFAKMHCGF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag COLJLHFAJIB(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag EINCDGAHJMH(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public static CloudRegionCode HAMMOFBPLBI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('\u0006');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	public override string DEHDEBNAHOO()
	{
		return string.Format(":</b> ", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag PCOIOBMPFDF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public static CloudRegionCode OAGCFAEKBCN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('ﾳ');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.none;
	}

	public static CloudRegionCode EBPHPBNDNDJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf('\uffc1');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	public static CloudRegionCode FMKNGEGHEBL(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf(')');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	public override string JALEHOOBFID()
	{
		return string.Format(",", Cluster, Ping, HostAndPort);
	}

	public override string ALNGGCBILAM()
	{
		return string.Format("cmd.exe", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag BGDIGCILJAJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag HONMPIJDGGE(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	internal static CloudRegionFlag LBAHMLKLBDL(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}
}
