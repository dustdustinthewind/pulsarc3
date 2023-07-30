// AnimationFromDistance
using UnityEngine;

public class AnimationFromDistance : MonoBehaviour
{
	private float MPNMOONBMII = 5f;

	private float IIFGDPMOKOO = 10f;

	private Animator EFGKBEHNOBH;

	private Transform OJICGBOIKNA;

	private bool CFCECAPJCOM;

	private static float LGILGCGIHHM;

	private float OLBDFLPFFHP;

	public void LLNGFJLNGPH()
	{
		LGILGCGIHHM = 294f;
		CFCECAPJCOM = true;
	}

	private void POHMFMNEPKK()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FGAPIOELJCG();
	}

	private void KIEJKBNBHMD()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1794f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1713f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Uploading content", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1999f;
			LGILGCGIHHM += Time.deltaTime * (1244f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 143f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("SfxVolumeSlider", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void DEJEBOGKMJO()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		HELAPIIFLCC();
	}

	private void NFMDNEJAGLB()
	{
		EFGKBEHNOBH.SetFloat("_Extra2", 1986f);
		OLBDFLPFFHP = 1899f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 3f;
	}

	public void AMADKKLPCBI()
	{
		LGILGCGIHHM = 28f;
		CFCECAPJCOM = false;
	}

	public void ABFGBBGNPGO()
	{
		LGILGCGIHHM = 961f;
		CFCECAPJCOM = false;
	}

	private void LBIOIEANMGI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 133f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1412f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Blues", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 62f;
			LGILGCGIHHM += Time.deltaTime * (966f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1596f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Value3", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void EGEGNHLODAA()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1079f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1991f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_Myst", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1501f;
			LGILGCGIHHM += Time.deltaTime * (492f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1222f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("0,7,true,0", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HBFLDGHLMBJ()
	{
		EFGKBEHNOBH.SetFloat("CameraFilterPack/Drawing_Curve", 1971f);
		OLBDFLPFFHP = 523f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1765f;
	}

	private void IPJENEAMGBP()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		PMLPJADKFMG();
	}

	private void HLDFOJMHKNL()
	{
		if (!CFCECAPJCOM)
		{
			float num = 749f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1123f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1398f;
			LGILGCGIHHM += Time.deltaTime * (888f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 394f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("player.dragon", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void Reset()
	{
		EFGKBEHNOBH.SetFloat("time", 0f);
		OLBDFLPFFHP = 0f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 0f;
	}

	public void CAILBNIDHHI()
	{
		LGILGCGIHHM = 836f;
		CFCECAPJCOM = true;
	}

	public void COFBCDEMIDI()
	{
		LGILGCGIHHM = 945f;
		CFCECAPJCOM = false;
	}

	private void HFFAJNCOJNB()
	{
		EFGKBEHNOBH.SetFloat("Failed to Destroy objects of playerId: ", 2f);
		OLBDFLPFFHP = 1618f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1368f;
	}

	private void PHJJHFBLICM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1310f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 499f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 512f;
			LGILGCGIHHM += Time.deltaTime * (1698f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1445f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("3d text", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void FGAPIOELJCG()
	{
		EFGKBEHNOBH.SetFloat("MainCamera", 1436f);
		OLBDFLPFFHP = 27f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 679f;
	}

	private void LOKKIADJAFE()
	{
		EFGKBEHNOBH.SetFloat("RecieveChatActionMessage", 1084f);
		OLBDFLPFFHP = 928f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1689f;
	}

	private void OEMJNJALGAC()
	{
		EFGKBEHNOBH.SetFloat("FinalScoreSmallText", 1597f);
		OLBDFLPFFHP = 85f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1907f;
	}

	private void IIFCIDDJHPM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 905f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1356f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 176f;
			LGILGCGIHHM += Time.deltaTime * (857f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1004f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("&search=", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HELAPIIFLCC()
	{
		EFGKBEHNOBH.SetFloat("_Value3", 1988f);
		OLBDFLPFFHP = 1969f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1585f;
	}

	private void HHJBBHEBJCJ()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FGAPIOELJCG();
	}

	public void NBBDMPCBKAM()
	{
		LGILGCGIHHM = 505f;
		CFCECAPJCOM = true;
	}

	public void FAFAPJOEHLC()
	{
		LGILGCGIHHM = 1097f;
		CFCECAPJCOM = true;
	}

	private void EIFCCFBJKOO()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		BJKJEJJOPLC();
	}

	private void KCDOMIJBFLL()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1410f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1633f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("[Singleton] Using instance of '", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1044f;
			LGILGCGIHHM += Time.deltaTime * (947f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1543f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat(",", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void EMANBHKAONB()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FMAIMMNHLHK();
	}

	private void JIJPHEDDIHC()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		IAPOBEGCHLG();
	}

	private void PPCGJBIIFAO()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		JHPDFCAGCHC();
	}

	private void JEKEBJCHOHO()
	{
		EFGKBEHNOBH.SetFloat("https://twitch.tv/intralism", 1426f);
		OLBDFLPFFHP = 1708f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 49f;
	}

	private void AEEGKLABFLN()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1722f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1915f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value3", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 668f;
			LGILGCGIHHM += Time.deltaTime * (94f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1577f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("th", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void DMIKIDGJEFC()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FGAPIOELJCG();
	}

	private void CPGAFFIOGCH()
	{
		EFGKBEHNOBH.SetFloat("PerfectHitsScoreText", 463f);
		OLBDFLPFFHP = 1134f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1120f;
	}

	private void KMEONPMCNJG()
	{
		if (!CFCECAPJCOM)
		{
			float num = 578f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1923f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("settings.enableranking", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 50f;
			LGILGCGIHHM += Time.deltaTime * (577f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1793f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("ShowTitle", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void JBCNIPJDPJB()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1721f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 381f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value4", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1701f;
			LGILGCGIHHM += Time.deltaTime * (1397f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1588f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Value2", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void BAAAOIHDFPA()
	{
		LGILGCGIHHM = 1094f;
		CFCECAPJCOM = true;
	}

	private void Awake()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		Reset();
	}

	public void OOFHLADJHHK()
	{
		LGILGCGIHHM = 1473f;
		CFCECAPJCOM = true;
	}

	public void GOAMJNAHLMP()
	{
		LGILGCGIHHM = 1417f;
		CFCECAPJCOM = true;
	}

	public void NFNBBGEAFPJ()
	{
		LGILGCGIHHM = 1157f;
		CFCECAPJCOM = false;
	}

	private void GLGOLEOAFOD()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		IAPOBEGCHLG();
	}

	public void LODJJNAJLPL()
	{
		LGILGCGIHHM = 271f;
		CFCECAPJCOM = true;
	}

	private void JGKICMKMOKO()
	{
		EFGKBEHNOBH.SetFloat("received</b>\n#reason: ", 1488f);
		OLBDFLPFFHP = 1271f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1781f;
	}

	private void NBOKAGMABPN()
	{
		EFGKBEHNOBH.SetFloat("[MapsData] User's maps was loaded", 215f);
		OLBDFLPFFHP = 753f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1934f;
	}

	private void KGMCGGIEPDE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		CHDIPOPHGCP();
	}

	public void DFAPKHJCBOC()
	{
		LGILGCGIHHM = 1399f;
		CFCECAPJCOM = true;
	}

	private void GBNOIKAPBBO()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		ABDHDGNIHHI();
	}

	public void Blow()
	{
		LGILGCGIHHM = 0f;
		CFCECAPJCOM = true;
	}

	private void DPIPGGDNGHN()
	{
		if (!CFCECAPJCOM)
		{
			float num = 385f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1347f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("DPADHOR", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1343f;
			LGILGCGIHHM += Time.deltaTime * (187f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1046f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("closed", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void IOFCBLHLCBB()
	{
		EFGKBEHNOBH.SetFloat("event", 1479f);
		OLBDFLPFFHP = 1091f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 694f;
	}

	private void EJFJENFKLND()
	{
		if (!CFCECAPJCOM)
		{
			float num = 84f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1388f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Text", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1276f;
			LGILGCGIHHM += Time.deltaTime * (688f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 579f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Simulate", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void CHDIPOPHGCP()
	{
		EFGKBEHNOBH.SetFloat("Received RPC: ", 1352f);
		OLBDFLPFFHP = 684f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1282f;
	}

	private void PMBIKIBOHOF()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		ABDHDGNIHHI();
	}

	public void EKKFKELDHGD()
	{
		LGILGCGIHHM = 1392f;
		CFCECAPJCOM = true;
	}

	private void MCIEAOAMOIG()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		OEMJNJALGAC();
	}

	private void JBIFKBNPHJE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		PMLPJADKFMG();
	}

	private void LEAHIBJDMBI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1120f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1514f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("#", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 856f;
			LGILGCGIHHM += Time.deltaTime * (1865f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 409f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("EventTimeInputField", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void GIIMPPGJLNB()
	{
		LGILGCGIHHM = 284f;
		CFCECAPJCOM = false;
	}

	private void NKHLPNAMBEH()
	{
		EFGKBEHNOBH.SetFloat("EventSystem", 1791f);
		OLBDFLPFFHP = 616f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 200f;
	}

	private void FEAPMDENLBN()
	{
		EFGKBEHNOBH.SetFloat("CameraFilterPack_WaterDrop", 1847f);
		OLBDFLPFFHP = 1628f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 767f;
	}

	public void BIBAKFKFPPM()
	{
		LGILGCGIHHM = 687f;
		CFCECAPJCOM = true;
	}

	private void JOACBIEHHCE()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1727f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1338f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("2;13;14;15;16", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 146f;
			LGILGCGIHHM += Time.deltaTime * (353f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1940f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat(" ", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void PNDKCDPIGAL()
	{
		LGILGCGIHHM = 1106f;
		CFCECAPJCOM = true;
	}

	private void BJKJEJJOPLC()
	{
		EFGKBEHNOBH.SetFloat("Remove Environment Object", 707f);
		OLBDFLPFFHP = 730f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 297f;
	}

	private void LMBDNPLDGIJ()
	{
		if (!CFCECAPJCOM)
		{
			float num = 90f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 702f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat(".status", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 230f;
			LGILGCGIHHM += Time.deltaTime * (1970f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1010f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Value6", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void GMELGGJOPBB()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1886f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 44f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_AdaptTex", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1672f;
			LGILGCGIHHM += Time.deltaTime * (23f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1109f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("achievements.21.progress", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void LJEFMGOBKGE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FGAPIOELJCG();
	}

	private void FJHFOBHJEHL()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1699f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1568f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Done!", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 827f;
			LGILGCGIHHM += Time.deltaTime * (1544f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1083f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("settings.gamemessagesduration", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void Update()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 0.4f;
			LGILGCGIHHM += Time.deltaTime * (1f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 0f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void CCDNJPNLGBN()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		HELAPIIFLCC();
	}

	private void IAPOBEGCHLG()
	{
		EFGKBEHNOBH.SetFloat("Set particles count per one beat", 1703f);
		OLBDFLPFFHP = 692f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 379f;
	}

	private void BGFJOEPFOPM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 35f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 688f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Committing changes...", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 14f;
			LGILGCGIHHM += Time.deltaTime * (1017f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1277f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("seconds", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void MDCFIHDPLIG()
	{
		if (!CFCECAPJCOM)
		{
			float num = 486f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 362f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_ExposureAdjustment", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1792f;
			LGILGCGIHHM += Time.deltaTime * (1851f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1762f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("MaxLivesSlider", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void CEEJCAJFJFL()
	{
		LGILGCGIHHM = 663f;
		CFCECAPJCOM = true;
	}

	private void HNDNDPECBPL()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1341f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1259f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Offsets", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1779f;
			LGILGCGIHHM += Time.deltaTime * (1849f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1653f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_FadeFX", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void POJFHDFJOPE()
	{
		if (!CFCECAPJCOM)
		{
			float num = 779f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 397f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat(".lastCheckpoint.correctScore", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1295f;
			LGILGCGIHHM += Time.deltaTime * (1309f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1294f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("InfoCanvas", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void AGMJDGHLBMN()
	{
		if (!CFCECAPJCOM)
		{
			float num = 331f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 559f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("<b><i>Map's Stats:</i></b>", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1692f;
			LGILGCGIHHM += Time.deltaTime * (649f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1654f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("CameraFilterPack/Blend2Camera_Hue", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HDDECCMEJKA()
	{
		if (!CFCECAPJCOM)
		{
			float num = 145f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 661f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Color", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 214f;
			LGILGCGIHHM += Time.deltaTime * (356f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1871f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void LBNJBBKMKIE()
	{
		LGILGCGIHHM = 1695f;
		CFCECAPJCOM = true;
	}

	private void KFACDBHDAOD()
	{
		if (!CFCECAPJCOM)
		{
			float num = 854f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1754f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("[PlayerController] ", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 219f;
			LGILGCGIHHM += Time.deltaTime * (856f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1763f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("id", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void JHPDFCAGCHC()
	{
		EFGKBEHNOBH.SetFloat("_MainTex2", 17f);
		OLBDFLPFFHP = 685f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 460f;
	}

	private void ABDHDGNIHHI()
	{
		EFGKBEHNOBH.SetFloat("_TimeX", 405f);
		OLBDFLPFFHP = 1058f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1130f;
	}

	private void BFFHPJMMGHD()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		ABDHDGNIHHI();
	}

	public void BAGCNPNMBMH()
	{
		LGILGCGIHHM = 945f;
		CFCECAPJCOM = true;
	}

	public void ICOFJDNIFHM()
	{
		LGILGCGIHHM = 1830f;
		CFCECAPJCOM = false;
	}

	public void IMIOENPJAAB()
	{
		LGILGCGIHHM = 542f;
		CFCECAPJCOM = true;
	}

	private void PMLPJADKFMG()
	{
		EFGKBEHNOBH.SetFloat("SaveButton", 133f);
		OLBDFLPFFHP = 911f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 414f;
	}

	private void HBPLJMJAAHK()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		OEMJNJALGAC();
	}

	public void NOPGKGNKECG()
	{
		LGILGCGIHHM = 1170f;
		CFCECAPJCOM = true;
	}

	private void FMAIMMNHLHK()
	{
		EFGKBEHNOBH.SetFloat("_LutTex", 1225f);
		OLBDFLPFFHP = 84f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1929f;
	}

	private void CGBHOELMAOC()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1767f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 211f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("Ok", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 777f;
			LGILGCGIHHM += Time.deltaTime * (1805f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 387f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Green_R", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}
}
