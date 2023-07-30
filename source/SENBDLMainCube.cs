// SENBDLMainCube
using UnityEngine;

public class SENBDLMainCube : MonoBehaviour
{
	private Color[] KJCHBLHFDJJ = new Color[4];

	public GameObject orbitingCube;

	public GameObject glowingOrbitingCube;

	public GameObject cubeEmissivePart;

	public GameObject particles;

	private const float INMKGOCKHGA = 8f;

	private float ILFPMAGAMLE;

	private Color AGDIGEMCIJE;

	private Color MKPEALIKJBL;

	[HideInInspector]
	public Color glowColor;

	private int MMCGDPKAHFG;

	private float HJGGEKOKHEM = 0.04f;

	private float IHLNKOMCHKI = 0.3f;

	private float GLNIHJKBEIK;

	private float JAJEIIFPFBC;

	private SENaturalBloomAndDirtyLens DCDKPOOLJNC;

	private void BIMEBIACDLK()
	{
		if (ILFPMAGAMLE >= 1267f)
		{
			ILFPMAGAMLE = 33f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 1631f * 1439f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 1016f + 73f, 728f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_Value3", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 388f - glowColor.r;
		a.g = 1726f - glowColor.g;
		a.b = 1261f - glowColor.b;
		a = Color.Lerp(a, Color.white, 955f);
		particles.GetComponent<Renderer>().material.SetColor("_ChannelMixerGreen", a);
	}

	private void PJPLIABCAPL()
	{
		if (Input.GetKey((KeyCode)(-155)))
		{
			HJGGEKOKHEM += 574f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-191)))
		{
			HJGGEKOKHEM -= 342f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-181)))
		{
			IHLNKOMCHKI += 1215f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-44)))
		{
			IHLNKOMCHKI -= 831f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-20)))
		{
			Time.timeScale += 1148f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)87))
		{
			Time.timeScale -= 158f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 195f, 1219f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1064f, 602f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1293f, 901f);
		if (Input.GetKeyDown((KeyCode)66))
		{
			HJGGEKOKHEM = 1499f;
			IHLNKOMCHKI = 1796f;
			Time.timeScale = 1941f;
		}
	}

	private void KMGAEEOJCEM()
	{
		if (ILFPMAGAMLE >= 232f)
		{
			ILFPMAGAMLE = 1252f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 1) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 979f * 1509f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 47f + 206f, 763f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_AlphaMask", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 1991f - glowColor.r;
		a.g = 292f - glowColor.g;
		a.b = 1271f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1501f);
		particles.GetComponent<Renderer>().material.SetColor(" not exist", a);
	}

	private void EEEAGLDCCCE()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1810f / JAJEIIFPFBC, 1468f * JAJEIIFPFBC);
	}

	private void Start()
	{
		ref Color reference = ref KJCHBLHFDJJ[0];
		reference = new Color(1f, 0.470588237f, 0.0509803928f);
		ref Color reference2 = ref KJCHBLHFDJJ[2];
		reference2 = new Color(28f / 85f, 0.6392157f, 1f);
		ref Color reference3 = ref KJCHBLHFDJJ[1];
		reference3 = new Color(31f / 51f, 1f, 0.117647059f);
		ref Color reference4 = ref KJCHBLHFDJJ[3];
		reference4 = new Color(1f, 0.184313729f, 0f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 150; i++)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < 19; j++)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(0.08f, 0.08f, 0.08f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void NEHDLDOIFNO()
	{
		if (ILFPMAGAMLE >= 8f)
		{
			ILFPMAGAMLE = 0f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 1) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 8f * 5f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 0.48f + 0.52f, 4f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 1f - glowColor.r;
		a.g = 1f - glowColor.g;
		a.b = 1f - glowColor.b;
		a = Color.Lerp(a, Color.white, 0.1f);
		particles.GetComponent<Renderer>().material.SetColor("_TintColor", a);
	}

	private void ADIGEGAOKAN()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1281f / JAJEIIFPFBC, 1707f * JAJEIIFPFBC);
	}

	private void PAKCDNIPPKN()
	{
		if (Input.GetKey(KeyCode.Alpha5))
		{
			HJGGEKOKHEM += 1613f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)86))
		{
			HJGGEKOKHEM -= 1190f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)159))
		{
			IHLNKOMCHKI += 164f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)168))
		{
			IHLNKOMCHKI -= 606f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Comma))
		{
			Time.timeScale += 382f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-101)))
		{
			Time.timeScale -= 789f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 502f, 1002f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 892f, 917f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 666f, 314f);
		if (Input.GetKeyDown(KeyCode.Plus))
		{
			HJGGEKOKHEM = 1213f;
			IHLNKOMCHKI = 192f;
			Time.timeScale = 1618f;
		}
	}

	private void HLIAEEMGBHN()
	{
		ref Color reference = ref KJCHBLHFDJJ[1];
		reference = new Color(520f, 1429f, 582f);
		ref Color reference2 = ref KJCHBLHFDJJ[2];
		reference2 = new Color(521f, 1424f, 748f);
		ref Color reference3 = ref KJCHBLHFDJJ[0];
		reference3 = new Color(17f, 1349f, 877f);
		ref Color reference4 = ref KJCHBLHFDJJ[0];
		reference4 = new Color(1496f, 1306f, 1398f);
		AGDIGEMCIJE = KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 6; i++)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < 50; j++)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1957f, 1314f, 1998f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void LBBDILIAACL()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1143f);
	}

	private void AGMJDGHLBMN()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		KMGAEEOJCEM();
		LBBDILIAACL();
		float num = 318f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1575f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		DIGMFMNMCBC();
		PAKCDNIPPKN();
		GHCPAHGAOAM();
		EEEAGLDCCCE();
	}

	private void FHANFCKAKJM()
	{
		if (Input.GetKey((KeyCode)(-27)))
		{
			HJGGEKOKHEM += 387f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-192)))
		{
			HJGGEKOKHEM -= 790f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-167)))
		{
			IHLNKOMCHKI += 257f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-120)))
		{
			IHLNKOMCHKI -= 142f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-126)))
		{
			Time.timeScale += 1597f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-88)))
		{
			Time.timeScale -= 1468f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 1557f, 110f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 135f, 559f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1449f, 1229f);
		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			HJGGEKOKHEM = 1532f;
			IHLNKOMCHKI = 1571f;
			Time.timeScale = 467f;
		}
	}

	private void DLBODOFAJGM()
	{
		ref Color reference = ref KJCHBLHFDJJ[0];
		reference = new Color(1909f, 991f, 1395f);
		ref Color reference2 = ref KJCHBLHFDJJ[3];
		reference2 = new Color(1724f, 939f, 1453f);
		ref Color reference3 = ref KJCHBLHFDJJ[0];
		reference3 = new Color(953f, 872f, 1786f);
		ref Color reference4 = ref KJCHBLHFDJJ[4];
		reference4 = new Color(12f, 1731f, 318f);
		AGDIGEMCIJE = KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 73; i++)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < -23; j++)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1999f, 308f, 291f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void CLFADLEBMDF()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void INACGJLKMEB()
	{
		if (ILFPMAGAMLE >= 709f)
		{
			ILFPMAGAMLE = 1027f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 303f * 1860f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 1669f + 1303f, 670f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("UI", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 980f - glowColor.r;
		a.g = 188f - glowColor.g;
		a.b = 871f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1355f);
		particles.GetComponent<Renderer>().material.SetColor("You need to have a Graphic control (such as an Image) for the list [", a);
	}

	private void DDFJNEPBNLO()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void DIGMFMNMCBC()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void DNJMMFOCAEK()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1f / JAJEIIFPFBC, 5f * JAJEIIFPFBC);
	}

	private void DOBFNLBAKNE()
	{
		if (ILFPMAGAMLE >= 433f)
		{
			ILFPMAGAMLE = 1412f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 605f * 1596f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 80f + 313f, 1762f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 537f - glowColor.r;
		a.g = 1207f - glowColor.g;
		a.b = 1386f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1781f);
		particles.GetComponent<Renderer>().material.SetColor("_Value2", a);
	}

	private void JHPOIOELNCG()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		NEHDLDOIFNO();
		HGCOBCIFNMC();
		float num = 219f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1656f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		DDFJNEPBNLO();
		HFCPMCLCBFN();
		HHMCKHEDHDO();
		DNJMMFOCAEK();
	}

	private void MOAIJJAMNKO()
	{
		if (Input.GetKey((KeyCode)(-70)))
		{
			HJGGEKOKHEM += 349f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)155))
		{
			HJGGEKOKHEM -= 213f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			IHLNKOMCHKI += 609f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-184)))
		{
			IHLNKOMCHKI -= 1124f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-46)))
		{
			Time.timeScale += 492f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)86))
		{
			Time.timeScale -= 656f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 498f, 1151f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 965f, 511f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1935f, 1487f);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			HJGGEKOKHEM = 985f;
			IHLNKOMCHKI = 1303f;
			Time.timeScale = 386f;
		}
	}

	private void NEHNCMFGAIO()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void BGDPIHMAACO()
	{
		ref Color reference = ref KJCHBLHFDJJ[1];
		reference = new Color(1494f, 960f, 1352f);
		ref Color reference2 = ref KJCHBLHFDJJ[1];
		reference2 = new Color(377f, 69f, 1471f);
		ref Color reference3 = ref KJCHBLHFDJJ[1];
		reference3 = new Color(703f, 704f, 1915f);
		ref Color reference4 = ref KJCHBLHFDJJ[8];
		reference4 = new Color(502f, 227f, 758f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -74; i++)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < -93; j += 0)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1413f, 1551f, 1903f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void HFCPMCLCBFN()
	{
		if (Input.GetKey((KeyCode)(-64)))
		{
			HJGGEKOKHEM += 1094f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-195)))
		{
			HJGGEKOKHEM -= 1926f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)141))
		{
			IHLNKOMCHKI += 812f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Dollar))
		{
			IHLNKOMCHKI -= 577f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-64)))
		{
			Time.timeScale += 340f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-12)))
		{
			Time.timeScale -= 995f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 778f, 779f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1106f, 892f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 934f, 1762f);
		if (Input.GetKeyDown((KeyCode)(-110)))
		{
			HJGGEKOKHEM = 514f;
			IHLNKOMCHKI = 1639f;
			Time.timeScale = 953f;
		}
	}

	private void PDPDOBKJKEA()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void OnGUI()
	{
	}

	private void FBMDHDBELEK()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		NEHDLDOIFNO();
		HGCOBCIFNMC();
		float num = 1096f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1106f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		DDFJNEPBNLO();
		MOAIJJAMNKO();
		NEHNCMFGAIO();
		EEEAGLDCCCE();
	}

	private void FODMLBEOLNF()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void Update()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		NEHDLDOIFNO();
		HGCOBCIFNMC();
		float num = 40f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 0.5f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		FODMLBEOLNF();
		DGDKJNBEPGE();
		CLFADLEBMDF();
		DNJMMFOCAEK();
	}

	private void DGDKJNBEPGE()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			HJGGEKOKHEM += 0.2f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			HJGGEKOKHEM -= 0.2f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			IHLNKOMCHKI += 0.4f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			IHLNKOMCHKI -= 0.4f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Period))
		{
			Time.timeScale += 0.5f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Comma))
		{
			Time.timeScale -= 0.5f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 0f, 0.4f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 0f, 0.95f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 0.1f, 1f);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			HJGGEKOKHEM = 0.05f;
			IHLNKOMCHKI = 0.1f;
			Time.timeScale = 1f;
		}
	}

	private void MJFKEMCBOKL()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1355f);
	}

	private void HHMCKHEDHDO()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void GHCPAHGAOAM()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void KDMANOEMOCA()
	{
		ref Color reference = ref KJCHBLHFDJJ[0];
		reference = new Color(1035f, 1282f, 1168f);
		ref Color reference2 = ref KJCHBLHFDJJ[7];
		reference2 = new Color(1571f, 622f, 1292f);
		ref Color reference3 = ref KJCHBLHFDJJ[0];
		reference3 = new Color(1169f, 1399f, 921f);
		ref Color reference4 = ref KJCHBLHFDJJ[3];
		reference4 = new Color(703f, 1205f, 402f);
		AGDIGEMCIJE = KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -161; i += 0)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < 34; j++)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1001f, 721f, 1476f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void HGCOBCIFNMC()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 20f);
	}

	private void HPIBGBDGMLB()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1249f);
	}
}
