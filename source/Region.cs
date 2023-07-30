// Region
using System;

public class Region
{
	public CloudRegionCode Code;

	public string Cluster;

	public string HostAndPort;

	public int Ping;

	public override string FLOGLPAPFLF()
	{
		return string.Format("_Value3", Cluster, Ping, HostAndPort);
	}

	public static CloudRegionCode FDPFMPAFCAJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.us;
		}
		int num = EJHKMJOLONP.IndexOf('y');
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

	public override string NJFCPBFAKNL()
	{
		return string.Format("Right", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag KJGLJCMAMCO(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public static CloudRegionCode KIAECLDONLK(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.cae;
		}
		int num = EJHKMJOLONP.IndexOf(',');
		if (num > 0)
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

	public Region(CloudRegionCode JFNKDGKEAEA, string GOLPAHODNFE, string FJPNDMCELJN)
	{
		Code = JFNKDGKEAEA;
		Cluster = GOLPAHODNFE;
		HostAndPort = FJPNDMCELJN;
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

	internal static CloudRegionFlag JGBOOKILAEJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string LGDBJKIMNCE()
	{
		return string.Format("UnityEngine.MonoBehaviour", Cluster, Ping, HostAndPort);
	}

	public override string ToString()
	{
		return $"'{Cluster}' \t{Ping}ms \t{HostAndPort}";
	}

	public static CloudRegionCode GKIDIPFOGCN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('ﾌ');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.jp;
	}

	internal static CloudRegionFlag DLDGELCJECA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public static CloudRegionCode PGHMCJGKPPM(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.cae;
		}
		int num = EJHKMJOLONP.IndexOf('5');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.sa;
	}

	internal static CloudRegionFlag HLNGKPHACHF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string CLJAJDILKFK()
	{
		return string.Format("Set camera (or player) distance. Base player distance - 14", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag KHONIFNBLDM(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public static CloudRegionCode LOGCFBGCFKG(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('\u0017');
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

	internal static CloudRegionFlag MFIGBOMAHGE(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	internal static CloudRegionFlag LBKNIEAMKKN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag HEMHPKHGOMN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public override string NOJAIFGAMOO()
	{
		return string.Format("menu.enableselectormusic", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag HOODFCHANJA(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
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

	internal static CloudRegionFlag FEGLAFNJKON(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	internal static CloudRegionFlag LFFMCKIJKJG(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
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

	internal static CloudRegionFlag JFBLMOGHMPF(CloudRegionCode LPCNAHJGAFK)
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

	public static CloudRegionCode IIIMEGPHEFF(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('ﾢ');
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

	public static CloudRegionCode CDGOLHAJJNC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf(' ');
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

	public static CloudRegionCode GAKCEOLLGCL(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf('z');
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

	internal static CloudRegionFlag IIDBBJMIMGF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	public override string EKJKNCOLJGD()
	{
		return string.Format("Joystick1Button7", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag HOOMADNFBHH(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	public override string HNHNKFEAAKA()
	{
		return string.Format("Fade", Cluster, Ping, HostAndPort);
	}

	internal static CloudRegionFlag KPNJAOAJDAK(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	public static CloudRegionCode OAGCFAEKBCN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.none;
		}
		int num = EJHKMJOLONP.IndexOf('L');
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

	public Region(CloudRegionCode JFNKDGKEAEA)
	{
		Code = JFNKDGKEAEA;
		Cluster = JFNKDGKEAEA.ToString();
	}

	public static CloudRegionCode FMIFJFOENND(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.sa;
		}
		int num = EJHKMJOLONP.IndexOf('i');
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

	public override string MJIJPCPAFPJ()
	{
		return string.Format("SetSpeed", Cluster, Ping, HostAndPort);
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

	public static CloudRegionCode FICGCHLJFFH(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('ￏ');
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

	public static CloudRegionCode OHOINFLIPBJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf('ﾫ');
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
}
