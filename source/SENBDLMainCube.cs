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

	private void POIMNOBDBBN()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		NEHDLDOIFNO();
		HGCOBCIFNMC();
		float num = 350f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 339f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		BIBHPMGILBO();
		FNAKKDEKGOA();
		CECCDGEMHDN();
		FBJGHDLGLGA();
	}

	private void ELCBKHDDHBH()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1637f / JAJEIIFPFBC, 998f * JAJEIIFPFBC);
	}

	private void FBJGHDLGLGA()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1617f / JAJEIIFPFBC, 1465f * JAJEIIFPFBC);
	}

	private void OCEJDJPHIDO()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1281f / JAJEIIFPFBC, 1707f * JAJEIIFPFBC);
	}

	private void JLJHPNKKJPJ()
	{
	}

	private void FDJIKIBBOOA()
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
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_AlphaUV", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 1991f - glowColor.r;
		a.g = 292f - glowColor.g;
		a.b = 1271f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1501f);
		particles.GetComponent<Renderer>().material.SetColor("[PlayerController] ", a);
	}

	private void PKJMDNMMOHN()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void GMHACAAGEHM()
	{
		if (ILFPMAGAMLE >= 1403f)
		{
			ILFPMAGAMLE = 326f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 1) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 1303f * 839f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 750f + 1937f, 1233f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_Green_R", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 1543f - glowColor.r;
		a.g = 1776f - glowColor.g;
		a.b = 177f - glowColor.b;
		a = Color.Lerp(a, Color.white, 623f);
		particles.GetComponent<Renderer>().material.SetColor("/music", a);
	}

	private void MNMJAGGKLBH()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1249f);
	}

	private void APKDMFHIGHM()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1367f);
	}

	private void IKIDIJLIGOH()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		GMHACAAGEHM();
		MNMJAGGKLBH();
		float num = 1995f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1327f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		CKMLCCFDJEM();
		FNAKKDEKGOA();
		KJLJIDKONLD();
		OCEJDJPHIDO();
	}

	private void CLFADLEBMDF()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void INHJINCNLMK()
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

	private void EOGEFHIDAMC()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void HMEGLDEHHAE()
	{
		if (ILFPMAGAMLE >= 799f)
		{
			ILFPMAGAMLE = 272f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 522f * 743f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 644f + 503f, 1746f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("accuracy", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 1287f - glowColor.r;
		a.g = 659f - glowColor.g;
		a.b = 110f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1715f);
		particles.GetComponent<Renderer>().material.SetColor("Object ID. Case-Sensitive", a);
	}

	private void JMANGPIOJHA()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void GGJKHODKNOC()
	{
	}

	private void AONGGIKHJNG()
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
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("custom", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 980f - glowColor.r;
		a.g = 188f - glowColor.g;
		a.b = 871f - glowColor.b;
		a = Color.Lerp(a, Color.white, 1355f);
		particles.GetComponent<Renderer>().material.SetColor("Event Received", a);
	}

	private void LLMMEABEGFH()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void KDLJAJLCABM()
	{
		if (Input.GetKey((KeyCode)190))
		{
			HJGGEKOKHEM += 1311f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)140))
		{
			HJGGEKOKHEM -= 1443f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.T))
		{
			IHLNKOMCHKI += 736f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-62)))
		{
			IHLNKOMCHKI -= 323f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Greater))
		{
			Time.timeScale += 1959f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)70))
		{
			Time.timeScale -= 638f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 148f, 1895f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1617f, 226f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1576f, 1400f);
		if (Input.GetKeyDown((KeyCode)(-59)))
		{
			HJGGEKOKHEM = 1674f;
			IHLNKOMCHKI = 228f;
			Time.timeScale = 1664f;
		}
	}

	private void FLLEJFACIHE()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void ADDKKPOIHOM()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 211f / JAJEIIFPFBC, 1178f * JAJEIIFPFBC);
	}

	private void KDMANOEMOCA()
	{
		ref Color reference = ref KJCHBLHFDJJ[0];
		reference = new Color(1378f, 1336f, 449f);
		ref Color reference2 = ref KJCHBLHFDJJ[7];
		reference2 = new Color(1363f, 506f, 1479f);
		ref Color reference3 = ref KJCHBLHFDJJ[1];
		reference3 = new Color(1923f, 1595f, 1793f);
		ref Color reference4 = ref KJCHBLHFDJJ[5];
		reference4 = new Color(172f, 1452f, 1036f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -143; i += 0)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < 41; j += 0)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(759f, 383f, 1118f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void IHEEJFCAJJM()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1092f / JAJEIIFPFBC, 1213f * JAJEIIFPFBC);
	}

	private void NIAFGFEMLCN()
	{
		if (Input.GetKey(KeyCode.Colon))
		{
			HJGGEKOKHEM += 1655f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-148)))
		{
			HJGGEKOKHEM -= 1913f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)190))
		{
			IHLNKOMCHKI += 1959f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha6))
		{
			IHLNKOMCHKI -= 962f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha5))
		{
			Time.timeScale += 1213f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-47)))
		{
			Time.timeScale -= 1550f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 1294f, 436f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 560f, 1574f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 152f, 466f);
		if (Input.GetKeyDown((KeyCode)(-88)))
		{
			HJGGEKOKHEM = 537f;
			IHLNKOMCHKI = 1729f;
			Time.timeScale = 1576f;
		}
	}

	private void DPLAEBBNCII()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void LFIGMNAOPJF()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void PDPDOBKJKEA()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void INACGJLKMEB()
	{
		if (ILFPMAGAMLE >= 1012f)
		{
			ILFPMAGAMLE = 1083f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 904f * 1890f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 711f + 1081f, 1376f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("CameraFilterPack/Blend2Camera_Lighten", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 816f - glowColor.r;
		a.g = 1002f - glowColor.g;
		a.b = 224f - glowColor.b;
		a = Color.Lerp(a, Color.white, 181f);
		particles.GetComponent<Renderer>().material.SetColor("_TimeX", a);
	}

	private void BCODHAOJLJL()
	{
	}

	private void FODMLBEOLNF()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void MFLGLMFFIKA()
	{
		if (Input.GetKey((KeyCode)(-96)))
		{
			HJGGEKOKHEM += 1329f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-43)))
		{
			HJGGEKOKHEM -= 391f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)5))
		{
			IHLNKOMCHKI += 1772f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)128))
		{
			IHLNKOMCHKI -= 320f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Pipe))
		{
			Time.timeScale += 511f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-46)))
		{
			Time.timeScale -= 1180f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 131f, 257f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1916f, 203f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1813f, 417f);
		if (Input.GetKeyDown((KeyCode)90))
		{
			HJGGEKOKHEM = 1364f;
			IHLNKOMCHKI = 221f;
			Time.timeScale = 1678f;
		}
	}

	private void NGGLCOLOLHF()
	{
	}

	private void GGLBOMDPAJI()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1710f);
	}

	private void FEFGFIBCMNB()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1810f / JAJEIIFPFBC, 1468f * JAJEIIFPFBC);
	}

	private void BDAAOKOIGML()
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

	private void MKLFMPFABEG()
	{
	}

	private void IFEIFGEHHOG()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 40f / JAJEIIFPFBC, 1076f * JAJEIIFPFBC);
	}

	private void PBBKNFMGJBI()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
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

	private void FABKIGNFECE()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		NEHDLDOIFNO();
		GGLBOMDPAJI();
		float num = 163f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 957f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		LLMMEABEGFH();
		NIAFGFEMLCN();
		KJLJIDKONLD();
		FEFGFIBCMNB();
	}

	private void ADBAPMLPHIE()
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

	private void JGMKAPELGCK()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1355f);
	}

	private void EABLJCHHCBE()
	{
		if (Input.GetKey((KeyCode)(-12)))
		{
			HJGGEKOKHEM += 681f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha7))
		{
			HJGGEKOKHEM -= 1895f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)184))
		{
			IHLNKOMCHKI += 368f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)142))
		{
			IHLNKOMCHKI -= 410f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Less))
		{
			Time.timeScale += 225f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)15))
		{
			Time.timeScale -= 856f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 563f, 95f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 300f, 1462f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1857f, 1148f);
		if (Input.GetKeyDown((KeyCode)(-125)))
		{
			HJGGEKOKHEM = 152f;
			IHLNKOMCHKI = 0f;
			Time.timeScale = 106f;
		}
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

	private void ADIGEGAOKAN()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 71f / JAJEIIFPFBC, 1361f * JAJEIIFPFBC);
	}

	private void ECNCMFPFACF()
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

	private void MNIOFKKGDIG()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void DGCGGKMNPLD()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		INACGJLKMEB();
		FLDLPPGMFPM();
		float num = 219f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1656f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		FODMLBEOLNF();
		MFLGLMFFIKA();
		DPLAEBBNCII();
		FEFGFIBCMNB();
	}

	private void BOOJHDBJLPE()
	{
		if (Input.GetKey((KeyCode)(-183)))
		{
			HJGGEKOKHEM += 217f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)70))
		{
			HJGGEKOKHEM -= 13f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-65)))
		{
			IHLNKOMCHKI += 701f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-55)))
		{
			IHLNKOMCHKI -= 1318f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)78))
		{
			Time.timeScale += 697f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-63)))
		{
			Time.timeScale -= 1807f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 1572f, 1701f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 566f, 768f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1784f, 1170f);
		if (Input.GetKeyDown(KeyCode.Slash))
		{
			HJGGEKOKHEM = 1038f;
			IHLNKOMCHKI = 1539f;
			Time.timeScale = 876f;
		}
	}

	private void MNBPNHNAEBK()
	{
		ref Color reference = ref KJCHBLHFDJJ[1];
		reference = new Color(555f, 2f, 303f);
		ref Color reference2 = ref KJCHBLHFDJJ[7];
		reference2 = new Color(794f, 1527f, 1849f);
		ref Color reference3 = ref KJCHBLHFDJJ[0];
		reference3 = new Color(732f, 1399f, 701f);
		ref Color reference4 = ref KJCHBLHFDJJ[4];
		reference4 = new Color(1258f, 1145f, 581f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 169; i++)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -75; j++)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(872f, 167f, 944f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void BIBHPMGILBO()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void GCHBGCGBMCK()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		HMEGLDEHHAE();
		LJCJDDHHBHE();
		float num = 1096f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1106f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		PDPDOBKJKEA();
		BOOJHDBJLPE();
		CECCDGEMHDN();
		FBJGHDLGLGA();
	}

	private void LJCJDDHHBHE()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 84f);
	}

	private void MCAMKNHEOLJ()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void OEOCCHGGIBH()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void FLDLPPGMFPM()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 231f);
	}

	private void ELFCDOPMMNK()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void DNPMOIPKPFC()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void JHPOIOELNCG()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		AONGGIKHJNG();
		GGLBOMDPAJI();
		float num = 428f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 23f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		EOGEFHIDAMC();
		EABLJCHHCBE();
		KJLJIDKONLD();
		DNJMMFOCAEK();
	}

	private void KMEONPMCNJG()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		FDJIKIBBOOA();
		LJCJDDHHBHE();
		float num = 318f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1575f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		HPFJBKCIDHP();
		ADBAPMLPHIE();
		JMANGPIOJHA();
		DNJMMFOCAEK();
	}

	private void DNJMMFOCAEK()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1f / JAJEIIFPFBC, 5f * JAJEIIFPFBC);
	}

	private void NACHHLNBOBK()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void PCCEPADONHK()
	{
	}

	private void CNGAJDBOCLJ()
	{
		ref Color reference = ref KJCHBLHFDJJ[1];
		reference = new Color(1913f, 878f, 799f);
		ref Color reference2 = ref KJCHBLHFDJJ[6];
		reference2 = new Color(497f, 1356f, 1118f);
		ref Color reference3 = ref KJCHBLHFDJJ[0];
		reference3 = new Color(1328f, 1363f, 1329f);
		ref Color reference4 = ref KJCHBLHFDJJ[8];
		reference4 = new Color(1966f, 389f, 1140f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 130; i += 0)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < -22; j += 0)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(776f, 343f, 710f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void IMCKJCHKMKB()
	{
		ref Color reference = ref KJCHBLHFDJJ[0];
		reference = new Color(1346f, 1965f, 857f);
		ref Color reference2 = ref KJCHBLHFDJJ[8];
		reference2 = new Color(1983f, 43f, 794f);
		ref Color reference3 = ref KJCHBLHFDJJ[1];
		reference3 = new Color(1450f, 553f, 1519f);
		ref Color reference4 = ref KJCHBLHFDJJ[2];
		reference4 = new Color(960f, 178f, 580f);
		AGDIGEMCIJE = KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -81; i += 0)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -116; j += 0)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1819f, 1402f, 15f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void OMCLOFCJMPG()
	{
		JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		CHDNGFLDGNI();
		APKDMFHIGHM();
		float num = 432f;
		Vector3 vector = Vector3.up * num;
		vector = Quaternion.Euler(Vector3.right * Time.time * num * 1023f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		MNIOFKKGDIG();
		INHJINCNLMK();
		CECCDGEMHDN();
		ELCBKHDDHBH();
	}

	private void DDFOMFBPFFB()
	{
	}

	private void GJAIKDNLOCH()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void NMHIDAOMOGO()
	{
	}

	private void EKFCKGFMNOJ()
	{
		if (Input.GetKey((KeyCode)(-137)))
		{
			HJGGEKOKHEM += 377f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-187)))
		{
			HJGGEKOKHEM -= 1471f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Dollar))
		{
			IHLNKOMCHKI += 703f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-60)))
		{
			IHLNKOMCHKI -= 1915f * JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.J))
		{
			Time.timeScale += 502f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-99)))
		{
			Time.timeScale -= 758f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 756f, 211f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1453f, 630f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1568f, 378f);
		if (Input.GetKeyDown((KeyCode)(-93)))
		{
			HJGGEKOKHEM = 1413f;
			IHLNKOMCHKI = 1551f;
			Time.timeScale = 1903f;
		}
	}

	private void HPFJBKCIDHP()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void OnGUI()
	{
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

	private void DDFJNEPBNLO()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void FNAKKDEKGOA()
	{
		if (Input.GetKey((KeyCode)88))
		{
			HJGGEKOKHEM += 876f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-181)))
		{
			HJGGEKOKHEM -= 686f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)146))
		{
			IHLNKOMCHKI += 1073f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-140)))
		{
			IHLNKOMCHKI -= 1668f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)72))
		{
			Time.timeScale += 688f * JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)87))
		{
			Time.timeScale -= 922f * JAJEIIFPFBC;
		}
		HJGGEKOKHEM = Mathf.Clamp(HJGGEKOKHEM, 115f, 1405f);
		IHLNKOMCHKI = Mathf.Clamp(IHLNKOMCHKI, 1250f, 1113f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 479f, 299f);
		if (Input.GetKeyDown((KeyCode)(-114)))
		{
			HJGGEKOKHEM = 1880f;
			IHLNKOMCHKI = 1563f;
			Time.timeScale = 512f;
		}
	}

	private void JILOMOBDPIA()
	{
		ref Color reference = ref KJCHBLHFDJJ[1];
		reference = new Color(1749f, 660f, 1958f);
		ref Color reference2 = ref KJCHBLHFDJJ[7];
		reference2 = new Color(1266f, 596f, 1780f);
		ref Color reference3 = ref KJCHBLHFDJJ[1];
		reference3 = new Color(1743f, 567f, 1763f);
		ref Color reference4 = ref KJCHBLHFDJJ[2];
		reference4 = new Color(1242f, 1135f, 611f);
		AGDIGEMCIJE = KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -20; i += 0)
		{
			Object.Instantiate(orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -26; j += 0)
		{
			Object.Instantiate(glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1892f, 593f, 1713f);
		SENBDLGlobal.mainCube = this;
		DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	private void HHKAHAGOPMB()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1686f / JAJEIIFPFBC, 1358f * JAJEIIFPFBC);
	}

	private void CECCDGEMHDN()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}

	private void DBEMDAJDDDA()
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

	private void EEOCMJOLALG()
	{
		GLNIHJKBEIK = Mathf.Lerp(GLNIHJKBEIK, 1072f / JAJEIIFPFBC, 1473f * JAJEIIFPFBC);
	}

	private void CHDNGFLDGNI()
	{
		if (ILFPMAGAMLE >= 1046f)
		{
			ILFPMAGAMLE = 1406f;
			MMCGDPKAHFG = (MMCGDPKAHFG + 0) % KJCHBLHFDJJ.Length;
			MKPEALIKJBL = AGDIGEMCIJE;
			AGDIGEMCIJE = KJCHBLHFDJJ[MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(ILFPMAGAMLE / 411f * 475f);
		glowColor = Color.Lerp(MKPEALIKJBL, AGDIGEMCIJE, t);
		Color color = glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 1586f + 155f, 1614f);
		cubeEmissivePart.GetComponent<Renderer>().material.SetColor("VisionBlur", color);
		GetComponent<Light>().color = color;
		Color a = default(Color);
		a.r = 917f - glowColor.r;
		a.g = 802f - glowColor.g;
		a.b = 652f - glowColor.b;
		a = Color.Lerp(a, Color.white, 787f);
		particles.GetComponent<Renderer>().material.SetColor(":", a);
	}

	private void HGCOBCIFNMC()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 20f);
	}

	private void CKMLCCFDJEM()
	{
		ILFPMAGAMLE += Time.deltaTime;
	}

	private void KJLJIDKONLD()
	{
		DCDKPOOLJNC.bloomIntensity = HJGGEKOKHEM;
		DCDKPOOLJNC.lensDirtIntensity = IHLNKOMCHKI;
	}
}
