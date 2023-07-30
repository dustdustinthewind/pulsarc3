// Player_Look
using UnityEngine;

[AddComponentMenu("Hard Shell Studios/Examples/Player Look")]
public class Player_Look : MonoBehaviour
{
	public bool inverted;

	public float speedX;

	public float speedY;

	private float EHMFFCEONCO;

	private float MEPPLCHOHBA;

	private void JOACBIEHHCE()
	{
		float num = hardInput.DCOBLPDBKID("/C tasklist", 971f) + hardInput.PPKDBNLBDIJ("_TimeX", 1804f);
		float y = hardInput.DCOBLPDBKID("_Visualize", 1862f) + hardInput.GetAxis("RoomDescriptionText", 992f);
		base.transform.parent.eulerAngles += new Vector3(1564f, y, 793f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 599f, 1921f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1297f, 992f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1135f);
	}

	private void IDIIELPAMCJ()
	{
		float num = hardInput.PPKDBNLBDIJ("Parameter levelId can't be null!", 340f) + hardInput.GetAxis("_MatrixColor", 1287f);
		float y = hardInput.PPKDBNLBDIJ("_Near", 1775f) + hardInput.GMKFPOJIHOH("#", 348f);
		base.transform.parent.eulerAngles += new Vector3(456f, y, 1193f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1049f, 291f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 220f, 981f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 177f);
	}

	private void OEENOOGEEHD()
	{
		float num = hardInput.GMKFPOJIHOH("_TimeX", 472f) + hardInput.PPKDBNLBDIJ("_Value4", 1056f);
		float y = hardInput.EBBBDEAMIKO("CameraFilterPack/Blend2Camera_ColorBurn", 955f) + hardInput.PPKDBNLBDIJ("Editor", 714f);
		base.transform.parent.eulerAngles += new Vector3(174f, y, 1147f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 306f, 133f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1627f, 1657f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 109f);
	}

	private void MAOCOEGAFND()
	{
		float num = hardInput.EBBBDEAMIKO("_Vibrance", 19f) + hardInput.GMKFPOJIHOH("{0:0} hour{1}, ", 986f);
		float y = hardInput.PKIDLNBMMBO("_Blue_C", 550f) + hardInput.PPKDBNLBDIJ("CameraFilterPack/Drawing_Manga5", 1685f);
		base.transform.parent.eulerAngles += new Vector3(559f, y, 1858f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1279f, 1330f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 643f, 1808f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 717f);
	}

	private void JHPOIOELNCG()
	{
		float num = hardInput.EBBBDEAMIKO("#changenote", 1228f) + hardInput.DCOBLPDBKID("settings.selectormapsperpage", 1723f);
		float y = hardInput.GetAxis("_Value7", 1618f) + hardInput.NPAAKMHOGBO("value", 667f);
		base.transform.parent.eulerAngles += new Vector3(1849f, y, 1354f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1312f, 964f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1678f, 217f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1708f);
	}

	private void LEAHIBJDMBI()
	{
		float num = hardInput.EBBBDEAMIKO("BitsData", 234f) + hardInput.PKIDLNBMMBO(",", 1938f);
		float y = hardInput.GMKFPOJIHOH("_Amount", 997f) + hardInput.DCOBLPDBKID("/", 597f);
		base.transform.parent.eulerAngles += new Vector3(1817f, y, 1393f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1991f, 1585f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 175f, 76f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1471f);
	}

	private void OBAEDJJDCPN()
	{
		float num = hardInput.DCOBLPDBKID("workshop.", 813f) + hardInput.EBBBDEAMIKO("workshop.", 314f);
		float y = hardInput.PKIDLNBMMBO("_VelocityScale", 1789f) + hardInput.GetAxis("\" that takes ", 207f);
		base.transform.parent.eulerAngles += new Vector3(739f, y, 974f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 61f, 673f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 227f, 419f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1542f);
	}

	private void DPIPGGDNGHN()
	{
		float num = hardInput.NPAAKMHOGBO("_Value", 778f) + hardInput.GMKFPOJIHOH("_Value3", 1597f);
		float y = hardInput.PPKDBNLBDIJ("_TimeX", 994f) + hardInput.GetAxis("{0} hours ago", 1179f);
		base.transform.parent.eulerAngles += new Vector3(1181f, y, 1125f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 505f, 317f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 569f, 962f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 930f);
	}

	private void ONMGIPAILOH()
	{
		float num = hardInput.PKIDLNBMMBO("KickThePlayer", 553f) + hardInput.PPKDBNLBDIJ("levelcompleted", 138f);
		float y = hardInput.NPAAKMHOGBO("id", 148f) + hardInput.PKIDLNBMMBO(".highscore", 1738f);
		base.transform.parent.eulerAngles += new Vector3(204f, y, 22f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 751f, 756f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 130f, 1343f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1881f);
	}

	private void AAPKBNDHBLI()
	{
		float num = hardInput.PPKDBNLBDIJ("_Value1", 13f) + hardInput.NPAAKMHOGBO("{0,-18} {1,18}", 748f);
		float y = hardInput.GetAxis("id", 202f) + hardInput.GetAxis("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", 683f);
		base.transform.parent.eulerAngles += new Vector3(885f, y, 384f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1997f, 1174f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1209f, 1047f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1684f);
	}

	private void HMNLHMLILKD()
	{
		float num = hardInput.GMKFPOJIHOH("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", 1247f) + hardInput.GMKFPOJIHOH("_Value4", 1263f);
		float y = hardInput.PKIDLNBMMBO("00", 1140f) + hardInput.GetAxis("Fade", 585f);
		base.transform.parent.eulerAngles += new Vector3(523f, y, 367f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 99f, 466f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1997f, 93f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1748f);
	}

	private void NKLIHNJCHOG()
	{
		float num = hardInput.GMKFPOJIHOH("CameraFilterPack/Colors_DarkColor", 1869f) + hardInput.PKIDLNBMMBO("_GreenAmplifier", 477f);
		float y = hardInput.GetAxis("BitsData", 283f) + hardInput.PPKDBNLBDIJ("_Value6", 1682f);
		base.transform.parent.eulerAngles += new Vector3(1050f, y, 1861f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 493f, 1557f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 438f, 215f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1411f);
	}

	private void LPMINJJPDCH()
	{
		float num = hardInput.GetAxis("Tab2Content", 1125f) + hardInput.EBBBDEAMIKO("CameraFilterPack/Gradients_Desert", 1323f);
		float y = hardInput.PKIDLNBMMBO("[Down]", 1329f) + hardInput.PKIDLNBMMBO(" to: ", 1300f);
		base.transform.parent.eulerAngles += new Vector3(1675f, y, 1094f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 698f, 1228f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 575f, 892f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1395f);
	}

	private void GHILDCBCDJI()
	{
		float num = hardInput.GMKFPOJIHOH("GlassAberration", 1034f) + hardInput.EBBBDEAMIKO("Can't start OFFLINE mode while connected!", 514f);
		float y = hardInput.GMKFPOJIHOH("ticket", 944f) + hardInput.GetAxis("Exception while connecting to: ", 1217f);
		base.transform.parent.eulerAngles += new Vector3(1486f, y, 1897f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1301f, 1590f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1058f, 843f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 969f);
	}

	private void MFMIODIAKNI()
	{
		float num = hardInput.GetAxis("_FullResolutionFiltering", 930f) + hardInput.NPAAKMHOGBO("resource", 1418f);
		float y = hardInput.GMKFPOJIHOH("SetSatelliteTrailWidth", 904f) + hardInput.GMKFPOJIHOH("_ScreenResolution", 1323f);
		base.transform.parent.eulerAngles += new Vector3(1255f, y, 808f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1341f, 1900f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1283f, 1953f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 79f);
	}

	private void AIJGAJIOJDJ()
	{
		float num = hardInput.PPKDBNLBDIJ("_Extra2", 805f) + hardInput.GMKFPOJIHOH("UI/Particles/Hidden", 1836f);
		float y = hardInput.PPKDBNLBDIJ("y", 1084f) + hardInput.PKIDLNBMMBO("USE_DIAG_SEARCH", 713f);
		base.transform.parent.eulerAngles += new Vector3(629f, y, 1485f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1466f, 1909f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 389f, 721f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 521f);
	}

	private void BGDONBMDPGM()
	{
		float num = hardInput.NPAAKMHOGBO("_Color", 1351f) + hardInput.PPKDBNLBDIJ("_ScreenResolution", 282f);
		float y = hardInput.EBBBDEAMIKO("_Value2", 868f) + hardInput.PKIDLNBMMBO("[Left]", 1296f);
		base.transform.parent.eulerAngles += new Vector3(821f, y, 634f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 904f, 1743f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1838f, 104f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 575f);
	}

	private void FABMDEHEDNO()
	{
		float num = hardInput.DCOBLPDBKID("time", 901f) + hardInput.GMKFPOJIHOH("CameraFilterPack/Drawing_Manga_Flash", 496f);
		float y = hardInput.PKIDLNBMMBO("note.0", 1762f) + hardInput.GMKFPOJIHOH("CameraFilterPack/Blur_Radial_Fast", 1454f);
		base.transform.parent.eulerAngles += new Vector3(614f, y, 166f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1746f, 869f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 430f, 1606f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1129f);
	}

	private void IIFCIDDJHPM()
	{
		float num = hardInput.GMKFPOJIHOH("_Blue_G", 1948f) + hardInput.PKIDLNBMMBO("_Value3", 1273f);
		float y = hardInput.EBBBDEAMIKO("float,50", 1583f) + hardInput.GetAxis("DISTORT", 1902f);
		base.transform.parent.eulerAngles += new Vector3(1907f, y, 346f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 754f, 1326f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1839f, 1108f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1499f);
	}

	private void BMODOIJGIOO()
	{
		float num = hardInput.PPKDBNLBDIJ("_AOTex", 827f) + hardInput.DCOBLPDBKID("Horizontal", 1709f);
		float y = hardInput.GMKFPOJIHOH(" = ", 1817f) + hardInput.EBBBDEAMIKO("PUNCloudBestRegion", 111f);
		base.transform.parent.eulerAngles += new Vector3(736f, y, 1184f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 445f, 1588f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1407f, 158f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1890f);
	}

	private void FABKIGNFECE()
	{
		float num = hardInput.GMKFPOJIHOH("PhotonMono", 1027f) + hardInput.GMKFPOJIHOH("[ResourcesManager] Load text error: not found", 1464f);
		float y = hardInput.PPKDBNLBDIJ("ItemTemplate", 833f) + hardInput.GMKFPOJIHOH("ControllerRightX", 1670f);
		base.transform.parent.eulerAngles += new Vector3(1643f, y, 1716f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1766f, 1615f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 68f, 936f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1127f);
	}

	private void FOMNCPKKCFN()
	{
		float num = hardInput.PKIDLNBMMBO("_ScreenResolution", 1810f) + hardInput.PKIDLNBMMBO("/", 1663f);
		float y = hardInput.GMKFPOJIHOH("CameraFilterPack/EXTRA_Rotation", 1785f) + hardInput.NPAAKMHOGBO("_ScreenResolution", 1442f);
		base.transform.parent.eulerAngles += new Vector3(1210f, y, 1871f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 495f, 795f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 281f, 1446f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 241f);
	}

	private void AEIJFLJEABG()
	{
		float num = hardInput.PPKDBNLBDIJ("_MainTex2", 93f) + hardInput.DCOBLPDBKID("id", 962f);
		float y = hardInput.EBBBDEAMIKO("value", 1478f) + hardInput.GetAxis("PossibleMapPointsText", 1951f);
		base.transform.parent.eulerAngles += new Vector3(804f, y, 1120f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 200f, 798f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1066f, 660f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 978f);
	}

	private void HLDFOJMHKNL()
	{
		float num = hardInput.GMKFPOJIHOH("player.linea", 966f) + hardInput.GMKFPOJIHOH("/Assets/MyImage", 887f);
		float y = hardInput.DCOBLPDBKID("Anomaly_Distortion_Size", 1995f) + hardInput.NPAAKMHOGBO("[PlayerController] ", 1694f);
		base.transform.parent.eulerAngles += new Vector3(988f, y, 609f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1598f, 506f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 549f, 1356f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 875f);
	}

	private void EJFJENFKLND()
	{
		float num = hardInput.PKIDLNBMMBO("#close", 1445f) + hardInput.GMKFPOJIHOH("Load Game", 1097f);
		float y = hardInput.EBBBDEAMIKO("CameraFilterPack/Light_Rainbow2", 435f) + hardInput.PPKDBNLBDIJ("Solo", 1172f);
		base.transform.parent.eulerAngles += new Vector3(1981f, y, 1477f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1757f, 1017f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 397f, 723f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1621f);
	}

	private void KCDOMIJBFLL()
	{
		float num = hardInput.PKIDLNBMMBO("/", 68f) + hardInput.DCOBLPDBKID("Fade", 636f);
		float y = hardInput.NPAAKMHOGBO("player.greenarc", 1463f) + hardInput.PPKDBNLBDIJ("_MatrixColor", 1834f);
		base.transform.parent.eulerAngles += new Vector3(1921f, y, 1948f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 457f, 2f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1713f, 415f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 584f);
	}

	private void CFIAKIJAILI()
	{
		float num = hardInput.PKIDLNBMMBO("_Value3", 1326f) + hardInput.EBBBDEAMIKO("float,2", 689f);
		float y = hardInput.NPAAKMHOGBO("_NoiseTilingPerChannel", 1494f) + hardInput.EBBBDEAMIKO("_Colored", 608f);
		base.transform.parent.eulerAngles += new Vector3(107f, y, 1820f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 965f, 427f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 633f, 917f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 348f);
	}

	private void LCJHDLKJEOM()
	{
		float num = hardInput.PKIDLNBMMBO("speed", 1032f) + hardInput.EBBBDEAMIKO("[PlayerBase] ShowTitle error: ", 1043f);
		float y = hardInput.NPAAKMHOGBO("workshop.", 1128f) + hardInput.PKIDLNBMMBO("G:", 1689f);
		base.transform.parent.eulerAngles += new Vector3(746f, y, 1594f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 506f, 1785f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 156f, 478f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1381f);
	}

	private void MMBPLGGLPDB()
	{
		float num = hardInput.PKIDLNBMMBO("GameScene", 1354f) + hardInput.EBBBDEAMIKO("_Value", 759f);
		float y = hardInput.PPKDBNLBDIJ("End index must in an integer.", 65f) + hardInput.PPKDBNLBDIJ("speed", 426f);
		base.transform.parent.eulerAngles += new Vector3(1021f, y, 874f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1380f, 376f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1879f, 1484f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1456f);
	}

	private void KMKLDAJLCNM()
	{
		float num = hardInput.DCOBLPDBKID("AddEnvironmentObject", 1360f) + hardInput.EBBBDEAMIKO("_SizeY", 1930f);
		float y = hardInput.EBBBDEAMIKO("_FresnelFade", 791f) + hardInput.PPKDBNLBDIJ("Creating awesome map", 1753f);
		base.transform.parent.eulerAngles += new Vector3(93f, y, 1614f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 84f, 229f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 444f, 1642f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1024f);
	}

	private void EHCGBJDFMHG()
	{
		float num = hardInput.EBBBDEAMIKO("_DiffuseColor", 967f) + hardInput.EBBBDEAMIKO("settings.arcshitsoundtimedelay", 998f);
		float y = hardInput.PKIDLNBMMBO("event", 649f) + hardInput.PKIDLNBMMBO("menuthemes", 1092f);
		base.transform.parent.eulerAngles += new Vector3(301f, y, 1870f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 536f, 866f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1870f, 1577f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1026f);
	}

	private void BGFJOEPFOPM()
	{
		float num = hardInput.GetAxis("_TimeX", 1483f) + hardInput.GetAxis("Middle Click", 1953f);
		float y = hardInput.GMKFPOJIHOH("settings.fps", 270f) + hardInput.EBBBDEAMIKO("mapselector.tags.", 908f);
		base.transform.parent.eulerAngles += new Vector3(192f, y, 50f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1368f, 920f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1712f, 1099f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 420f);
	}

	private void NDAJBJFJGCF()
	{
		float num = hardInput.NPAAKMHOGBO("_EmissionGain", 1028f) + hardInput.NPAAKMHOGBO("_ScreenResolution", 1552f);
		float y = hardInput.PPKDBNLBDIJ("_ScreenResolution", 207f) + hardInput.EBBBDEAMIKO("_ScreenResolution", 949f);
		base.transform.parent.eulerAngles += new Vector3(1185f, y, 381f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1910f, 1420f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1923f, 1634f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1256f);
	}

	private void Update()
	{
		float num = hardInput.GetAxis("MouseY", 1f) + hardInput.GetAxis("ControllerRightY", 1f);
		float y = hardInput.GetAxis("MouseX", 1f) + hardInput.GetAxis("ControllerRightX", 1f);
		base.transform.parent.eulerAngles += new Vector3(0f, y, 0f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, -80f, 60f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, -80f, 60f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 0f);
	}

	private void AGMJDGHLBMN()
	{
		float num = hardInput.GMKFPOJIHOH("{0}", 1276f) + hardInput.PPKDBNLBDIJ("_TimeX", 1977f);
		float y = hardInput.GetAxis("_MainTex2", 1307f) + hardInput.EBBBDEAMIKO("_Value3", 1447f);
		base.transform.parent.eulerAngles += new Vector3(392f, y, 91f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 827f, 675f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 887f, 1742f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 503f);
	}

	private void GPFJMKCGHGB()
	{
		float num = hardInput.GMKFPOJIHOH("_ScreenResolution", 678f) + hardInput.GetAxis("[Right]", 1140f);
		float y = hardInput.NPAAKMHOGBO("Loaded skin audio", 1613f) + hardInput.NPAAKMHOGBO("_Value4", 984f);
		base.transform.parent.eulerAngles += new Vector3(387f, y, 1650f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 415f, 1276f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1963f, 1291f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 571f);
	}

	private void OCMKCBBCEFG()
	{
		float num = hardInput.NPAAKMHOGBO("NEW", 729f) + hardInput.GMKFPOJIHOH("Right", 1862f);
		float y = hardInput.EBBBDEAMIKO("#useticket", 1610f) + hardInput.NPAAKMHOGBO("_Near", 1265f);
		base.transform.parent.eulerAngles += new Vector3(1770f, y, 1850f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 364f, 506f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1241f, 27f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1989f);
	}

	private void NEKCPLGFOFD()
	{
		float num = hardInput.EBBBDEAMIKO("_Value2", 1375f) + hardInput.PKIDLNBMMBO("Write me to get one for testing :)", 976f);
		float y = hardInput.GMKFPOJIHOH("_ExposureAdjustment", 1987f) + hardInput.DCOBLPDBKID("Cant ask anyone else for PickupItem spawn times.", 189f);
		base.transform.parent.eulerAngles += new Vector3(1826f, y, 1437f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1348f, 867f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1486f, 301f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1825f);
	}

	private void JAAJECBCCFM()
	{
		float num = hardInput.NPAAKMHOGBO("_TapLow", 1559f) + hardInput.PPKDBNLBDIJ("Set Satellite Sensitivity", 1451f);
		float y = hardInput.EBBBDEAMIKO("Item ", 538f) + hardInput.PKIDLNBMMBO("Please wait..", 249f);
		base.transform.parent.eulerAngles += new Vector3(453f, y, 1605f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 343f, 702f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 91f, 1557f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1253f);
	}

	private void FBMDHDBELEK()
	{
		float num = hardInput.GetAxis("ViewMenu", 673f) + hardInput.GetAxis("<b>#", 468f);
		float y = hardInput.EBBBDEAMIKO("Lerp speed. Recomended 10", 1529f) + hardInput.EBBBDEAMIKO("ERROR: preview file name is empty in modName.workshop.json", 455f);
		base.transform.parent.eulerAngles += new Vector3(648f, y, 505f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 474f, 335f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1557f, 1657f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 725f);
	}

	private void LLJLDLLNFBH()
	{
		float num = hardInput.EBBBDEAMIKO("HighScaleShot", 1439f) + hardInput.NPAAKMHOGBO("resetall", 1501f);
		float y = hardInput.GMKFPOJIHOH("_TimeX", 754f) + hardInput.GetAxis("_Red_B", 811f);
		base.transform.parent.eulerAngles += new Vector3(529f, y, 1216f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1021f, 461f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 93f, 103f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 647f);
	}

	private void JBNPEHMDCMI()
	{
		float num = hardInput.GetAxis("/?player=", 200f) + hardInput.PKIDLNBMMBO("_Value4", 1352f);
		float y = hardInput.DCOBLPDBKID("#", 167f) + hardInput.GetAxis("_TimeX", 602f);
		base.transform.parent.eulerAngles += new Vector3(1693f, y, 1340f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1288f, 739f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1647f, 114f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 969f);
	}
}
