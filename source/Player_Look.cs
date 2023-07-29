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

	private void LEAHIBJDMBI()
	{
		float num = hardInput.GetAxis("BloomShaderValueSlider", 1259f) + hardInput.GMNJKCNIPGD("#newhighscore", 219f);
		float y = hardInput.GMNJKCNIPGD(". Verify the Prefab is in a Resources folder (and not in a subfolder)", 82f) + hardInput.PMJHMIKCPBI("Mouse1", 1215f);
		base.transform.parent.eulerAngles += new Vector3(1712f, y, 649f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 203f, 112f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1588f, 1187f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 607f);
	}

	private void KMKLDAJLCNM()
	{
		float num = hardInput.GMNJKCNIPGD("_Offsets", 551f) + hardInput.GMNJKCNIPGD("?", 602f);
		float y = hardInput.GMNJKCNIPGD("_MainTex2", 1066f) + hardInput.PMJHMIKCPBI("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", 1676f);
		base.transform.parent.eulerAngles += new Vector3(767f, y, 974f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 983f, 1966f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1719f, 494f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1728f);
	}

	private void JAAJECBCCFM()
	{
		float num = hardInput.PMJHMIKCPBI("Failed to Instantiate prefab: ", 1807f) + hardInput.GMNJKCNIPGD("_TimeX", 925f);
		float y = hardInput.PMJHMIKCPBI("\"", 1063f) + hardInput.PMJHMIKCPBI("Mouse X", 969f);
		base.transform.parent.eulerAngles += new Vector3(974f, y, 234f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1370f, 181f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 419f, 1113f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1208f);
	}

	private void MAOCOEGAFND()
	{
		float num = hardInput.PMJHMIKCPBI("Exception while connecting to: ", 10f) + hardInput.PMJHMIKCPBI("_MainTex2", 406f);
		float y = hardInput.GetAxis("<b>", 1020f) + hardInput.PMJHMIKCPBI("LevelFolderInputField", 1487f);
		base.transform.parent.eulerAngles += new Vector3(580f, y, 1994f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1395f, 1883f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1942f, 1620f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1880f);
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

	private void MMBPLGGLPDB()
	{
		float num = hardInput.GMNJKCNIPGD("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 962f) + hardInput.PMJHMIKCPBI("AudioSampler", 453f);
		float y = hardInput.PMJHMIKCPBI("float,1.5", 1117f) + hardInput.PMJHMIKCPBI("CameraFilterPack/VHS_Tracking", 560f);
		base.transform.parent.eulerAngles += new Vector3(1895f, y, 160f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1537f, 1116f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1558f, 1910f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1594f);
	}

	private void MFMIODIAKNI()
	{
		float num = hardInput.GMNJKCNIPGD("cancel", 1711f) + hardInput.GMNJKCNIPGD("' ping: ", 1363f);
		float y = hardInput.GetAxis("GlassDistortion", 1642f) + hardInput.GMNJKCNIPGD("FavoriteButton", 1629f);
		base.transform.parent.eulerAngles += new Vector3(83f, y, 1560f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 650f, 1660f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 308f, 1474f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1876f);
	}

	private void BGFJOEPFOPM()
	{
		float num = hardInput.GMNJKCNIPGD("Parameter levelId must be int or string!", 655f) + hardInput.GetAxis("_Size", 424f);
		float y = hardInput.GetAxis(".", 256f) + hardInput.GMNJKCNIPGD("BadgeText", 815f);
		base.transform.parent.eulerAngles += new Vector3(1052f, y, 1779f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1662f, 523f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 952f, 1556f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1979f);
	}

	private void AGMJDGHLBMN()
	{
		float num = hardInput.GMNJKCNIPGD("2hands", 513f) + hardInput.GetAxis("GraphicsQualitySlider", 355f);
		float y = hardInput.GMNJKCNIPGD("settings.customdataskin", 793f) + hardInput.PMJHMIKCPBI("_Offsets", 722f);
		base.transform.parent.eulerAngles += new Vector3(1493f, y, 1027f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1570f, 1030f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 66f, 231f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 494f);
	}

	private void OCMKCBBCEFG()
	{
		float num = hardInput.GetAxis("player.egglipszerotwo", 395f) + hardInput.PMJHMIKCPBI(".lastCheckpoint.bgcolor", 452f);
		float y = hardInput.GetAxis("Case-Sensitive", 713f) + hardInput.GMNJKCNIPGD("_Value2", 348f);
		base.transform.parent.eulerAngles += new Vector3(1029f, y, 1724f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 141f, 1499f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1488f, 1645f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1975f);
	}

	private void NKLIHNJCHOG()
	{
		float num = hardInput.GMNJKCNIPGD("SteamManager", 1201f) + hardInput.GetAxis("_Value", 1780f);
		float y = hardInput.PMJHMIKCPBI("PLAY [SPACE]", 546f) + hardInput.GMNJKCNIPGD("_Distortion", 919f);
		base.transform.parent.eulerAngles += new Vector3(1738f, y, 88f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1545f, 684f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 910f, 1939f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1234f);
	}

	private void JHPOIOELNCG()
	{
		float num = hardInput.GetAxis("Skipping EstablishEncryption. Protocol is secure.", 1615f) + hardInput.GetAxis("_Red_B", 1418f);
		float y = hardInput.GetAxis("set", 323f) + hardInput.PMJHMIKCPBI("_ScreenResolution", 1457f);
		base.transform.parent.eulerAngles += new Vector3(1084f, y, 866f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1404f, 1658f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1672f, 276f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1541f);
	}

	private void AEIJFLJEABG()
	{
		float num = hardInput.GetAxis("stretchWidth", 900f) + hardInput.GetAxis("player.xp", 714f);
		float y = hardInput.GMNJKCNIPGD("ItemNameBGImage", 1453f) + hardInput.GMNJKCNIPGD("\n", 1036f);
		base.transform.parent.eulerAngles += new Vector3(338f, y, 774f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1743f, 1339f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 842f, 367f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 978f);
	}

	private void LLJLDLLNFBH()
	{
		float num = hardInput.GetAxis("No Dispatcher exists in the scene. Actions will not be invoked!", 324f) + hardInput.PMJHMIKCPBI("CameraFilterPack/Distortion_BigFace", 731f);
		float y = hardInput.GetAxis("PhotonMono", 329f) + hardInput.GetAxis(".b", 935f);
		base.transform.parent.eulerAngles += new Vector3(920f, y, 1032f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 739f, 555f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 393f, 440f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1874f);
	}

	private void AAPKBNDHBLI()
	{
		float num = hardInput.PMJHMIKCPBI(" registered.", 796f) + hardInput.GetAxis("Current xp: ", 1293f);
		float y = hardInput.GMNJKCNIPGD("ConfigVersionSlider", 1703f) + hardInput.GMNJKCNIPGD("\r", 1047f);
		base.transform.parent.eulerAngles += new Vector3(450f, y, 1937f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 627f, 1174f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1707f, 51f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1727f);
	}

	private void FBMDHDBELEK()
	{
		float num = hardInput.PMJHMIKCPBI("MainThreadExecuter", 1652f) + hardInput.GMNJKCNIPGD("https://steamcommunity.com/app/513510/workshop/", 729f);
		float y = hardInput.GMNJKCNIPGD("Run a command for data system", 1877f) + hardInput.GetAxis("Save the map before exiting?", 1223f);
		base.transform.parent.eulerAngles += new Vector3(1045f, y, 1746f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 1736f, 887f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 1792f, 228f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 1485f);
	}

	private void CFIAKIJAILI()
	{
		float num = hardInput.PMJHMIKCPBI("Dec", 1583f) + hardInput.GetAxis("CorrectHitsScoreText", 1726f);
		float y = hardInput.PMJHMIKCPBI("_VignetteDesat", 1068f) + hardInput.GetAxis("/", 503f);
		base.transform.parent.eulerAngles += new Vector3(1157f, y, 1729f) * speedX;
		EHMFFCEONCO = base.transform.eulerAngles.y;
		if (inverted)
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + num * speedY, 785f, 632f);
		}
		else
		{
			MEPPLCHOHBA = Mathf.Clamp(MEPPLCHOHBA + (0f - num) * speedY, 784f, 531f);
		}
		base.transform.rotation = Quaternion.Euler(MEPPLCHOHBA, EHMFFCEONCO, 179f);
	}
}
