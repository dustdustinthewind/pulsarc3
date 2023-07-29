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

	private void JADEDAEMLBN()
	{
		EFGKBEHNOBH.SetFloat("Crosshair", 532f);
		OLBDFLPFFHP = 532f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1065f;
	}

	private void CPGAFFIOGCH()
	{
		EFGKBEHNOBH.SetFloat("GLITCH", 410f);
		OLBDFLPFFHP = 1062f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1368f;
	}

	private void IICACFLHBCP()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		NALOPIJDJCM();
	}

	private void MBBHOJMLCBC()
	{
		EFGKBEHNOBH.SetFloat("0 - background, 1 - foreground", 1236f);
		OLBDFLPFFHP = 1597f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1724f;
	}

	public void PHEEPDCDKLI()
	{
		LGILGCGIHHM = 696f;
		CFCECAPJCOM = false;
	}

	private void FEAPMDENLBN()
	{
		EFGKBEHNOBH.SetFloat("float,1", 1390f);
		OLBDFLPFFHP = 1418f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1911f;
	}

	private void HPNNCNNFMGK()
	{
		if (!CFCECAPJCOM)
		{
			float num = 681f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 222f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("quantity", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1086f;
			LGILGCGIHHM += Time.deltaTime * (1316f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1733f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Delete events", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void HFDKOFIDLBG()
	{
		LGILGCGIHHM = 1993f;
		CFCECAPJCOM = true;
	}

	private void GLGOLEOAFOD()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		MNBMLBLLDGL();
	}

	private void Reset()
	{
		EFGKBEHNOBH.SetFloat("time", 0f);
		OLBDFLPFFHP = 0f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 0f;
	}

	private void OJBFBLHIEBB()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		MIFIEGOGKDA();
	}

	public void GMPIALPBIKM()
	{
		LGILGCGIHHM = 406f;
		CFCECAPJCOM = false;
	}

	private void FBMDHDBELEK()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1861f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1431f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("/", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1675f;
			LGILGCGIHHM += Time.deltaTime * (862f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 685f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("PossibleMapMaxScoreText", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void KACPCCMPAHA()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		GLJIDEPMMFO();
	}

	private void JOBBGDGHJMB()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		JHPDFCAGCHC();
	}

	private void APKNAPHOFHC()
	{
		if (!CFCECAPJCOM)
		{
			float num = 293f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 809f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("CameraFilterPack/Distortion_Dissipation", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 463f;
			LGILGCGIHHM += Time.deltaTime * (822f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1329f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Noise", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void DBNHAJIJODM()
	{
		LGILGCGIHHM = 609f;
		CFCECAPJCOM = false;
	}

	private void EHMMNELHAPJ()
	{
		EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_Computer", 745f);
		OLBDFLPFFHP = 952f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 722f;
	}

	private void LCJHDLKJEOM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 916f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1145f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("offsets", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1958f;
			LGILGCGIHHM += Time.deltaTime * (813f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 749f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("skin.no_hit", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HFFAJNCOJNB()
	{
		EFGKBEHNOBH.SetFloat("EventMenu", 657f);
		OLBDFLPFFHP = 230f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 432f;
	}

	public void OHOEFHCIKEK()
	{
		LGILGCGIHHM = 57f;
		CFCECAPJCOM = false;
	}

	public void HHNHILPCCDM()
	{
		LGILGCGIHHM = 362f;
		CFCECAPJCOM = true;
	}

	public void BIBAKFKFPPM()
	{
		LGILGCGIHHM = 108f;
		CFCECAPJCOM = false;
	}

	public void GGLNMDBEBNB()
	{
		LGILGCGIHHM = 667f;
		CFCECAPJCOM = false;
	}

	private void BBBNLHALLBN()
	{
		EFGKBEHNOBH.SetFloat("Preparing configuration", 730f);
		OLBDFLPFFHP = 1183f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1383f;
	}

	private void MGGNFEPGIJI()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		BDAPPLGLBOL();
	}

	private void JOACBIEHHCE()
	{
		if (!CFCECAPJCOM)
		{
			float num = 622f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 145f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value5", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 170f;
			LGILGCGIHHM += Time.deltaTime * (1972f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 519f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Intensity", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void DPIPGGDNGHN()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1185f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 910f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("#status", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 353f;
			LGILGCGIHHM += Time.deltaTime * (368f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 50f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Set arcs speed. Base value - 15", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void PGGNNIKIDJI()
	{
		LGILGCGIHHM = 1081f;
		CFCECAPJCOM = true;
	}

	public void ABFGBBGNPGO()
	{
		LGILGCGIHHM = 840f;
		CFCECAPJCOM = true;
	}

	private void OFKDKJGIDLH()
	{
		EFGKBEHNOBH.SetFloat("GlassColor", 1484f);
		OLBDFLPFFHP = 337f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1186f;
	}

	public void KICHIJKKKDC()
	{
		LGILGCGIHHM = 1362f;
		CFCECAPJCOM = true;
	}

	private void GLJIDEPMMFO()
	{
		EFGKBEHNOBH.SetFloat("No", 865f);
		OLBDFLPFFHP = 211f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1886f;
	}

	private void KGMCGGIEPDE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		BDAPPLGLBOL();
	}

	private void CFIAKIJAILI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1475f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1468f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("stretchWidth", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1769f;
			LGILGCGIHHM += Time.deltaTime * (753f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 528f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("???", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void Blow()
	{
		LGILGCGIHHM = 0f;
		CFCECAPJCOM = true;
	}

	private void IIFCIDDJHPM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 102f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 973f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value6", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 694f;
			LGILGCGIHHM += Time.deltaTime * (1330f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1562f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("#8E8E8EFF", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void MMIACKKBMNH()
	{
		LGILGCGIHHM = 1292f;
		CFCECAPJCOM = false;
	}

	private void MANOCIJICLG()
	{
		EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_BlackHole", 1011f);
		OLBDFLPFFHP = 1369f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 313f;
	}

	private void JHPDFCAGCHC()
	{
		EFGKBEHNOBH.SetFloat("/", 330f);
		OLBDFLPFFHP = 1417f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1090f;
	}

	private void KKLMPKLKAEM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 86f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 905f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("x", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1740f;
			LGILGCGIHHM += Time.deltaTime * (428f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 16f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Joystick1Button12", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void NLNAJMCBNDC()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		MIFIEGOGKDA();
	}

	private void LAACNNJDKBI()
	{
		EFGKBEHNOBH.SetFloat("\n", 103f);
		OLBDFLPFFHP = 495f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 836f;
	}

	private void LHMDCEDONEE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		Reset();
	}

	public void GCJKCJODDOD()
	{
		LGILGCGIHHM = 1169f;
		CFCECAPJCOM = false;
	}

	public void DJCIINMFJII()
	{
		LGILGCGIHHM = 1916f;
		CFCECAPJCOM = true;
	}

	private void JAAJECBCCFM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 253f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 839f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("GenerationMenu", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 853f;
			LGILGCGIHHM += Time.deltaTime * (808f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 271f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_TimeX", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void LLNGFJLNGPH()
	{
		LGILGCGIHHM = 761f;
		CFCECAPJCOM = true;
	}

	private void LFHKGIHNONL()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		FEAPMDENLBN();
	}

	private void OCMKCBBCEFG()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1240f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1411f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("#highscore", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1504f;
			LGILGCGIHHM += Time.deltaTime * (154f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1782f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("JoinButton", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void OBPCMAFGLON()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		NELFFHHCADM();
	}

	public void KAPJDHKDFGO()
	{
		LGILGCGIHHM = 1696f;
		CFCECAPJCOM = false;
	}

	public void ALLLCFEJNKM()
	{
		LGILGCGIHHM = 1987f;
		CFCECAPJCOM = false;
	}

	private void EEDLLCHIAKG()
	{
		EFGKBEHNOBH.SetFloat(" ", 903f);
		OLBDFLPFFHP = 848f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 704f;
	}

	private void NELFFHHCADM()
	{
		EFGKBEHNOBH.SetFloat("_ScreenResolution", 1225f);
		OLBDFLPFFHP = 209f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1850f;
	}

	private void KNNOEGLLDAN()
	{
		EFGKBEHNOBH.SetFloat("#tryagain", 349f);
		OLBDFLPFFHP = 1377f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 612f;
	}

	private void MIFIEGOGKDA()
	{
		EFGKBEHNOBH.SetFloat(" ", 1175f);
		OLBDFLPFFHP = 1293f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 399f;
	}

	private void LPMINJJPDCH()
	{
		if (!CFCECAPJCOM)
		{
			float num = 434f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1737f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("/", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1331f;
			LGILGCGIHHM += Time.deltaTime * (579f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1145f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat(" ", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HIKKPDACJGI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1227f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1723f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("UI", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 292f;
			LGILGCGIHHM += Time.deltaTime * (904f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1169f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Bloom0", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void MNBMLBLLDGL()
	{
		EFGKBEHNOBH.SetFloat("SetParticlesParticleSize", 1973f);
		OLBDFLPFFHP = 473f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 175f;
	}

	private void EHCGBJDFMHG()
	{
		if (!CFCECAPJCOM)
		{
			float num = 262f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1524f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("NewMapHandsCountSlider", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1459f;
			LGILGCGIHHM += Time.deltaTime * (1314f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 630f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("#currentbpm: ", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void JBNPEHMDCMI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 451f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 757f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("No Name", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1535f;
			LGILGCGIHHM += Time.deltaTime * (127f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1356f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_TimeX", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void MNDJJENAJCL()
	{
		LGILGCGIHHM = 95f;
		CFCECAPJCOM = true;
	}

	private void EBPAOCJEJGE()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		KNNOEGLLDAN();
	}

	private void Awake()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		Reset();
	}

	private void BJIKAHNJNEB()
	{
		EFGKBEHNOBH.SetFloat("LeaderboardsButton", 165f);
		OLBDFLPFFHP = 1700f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 519f;
	}

	private void IEMEHGCFAPD()
	{
		if (!CFCECAPJCOM)
		{
			float num = 751f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 778f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_Value", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 214f;
			LGILGCGIHHM += Time.deltaTime * (314f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1807f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Red_B", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void HNDNDPECBPL()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1651f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 573f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_MainTex2", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1112f;
			LGILGCGIHHM += Time.deltaTime * (1468f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1611f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Near", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void LDGJGONCEND()
	{
		EFGKBEHNOBH.SetFloat("Prints list of commands", 67f);
		OLBDFLPFFHP = 1788f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1163f;
	}

	private void CCDNJPNLGBN()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		EEBGCGFNELO();
	}

	private void HCCMANDFEPL()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		Reset();
	}

	public void ILOBCDONJKI()
	{
		LGILGCGIHHM = 837f;
		CFCECAPJCOM = false;
	}

	private void MFAMHKBMBEI()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		LAACNNJDKBI();
	}

	private void AEIJFLJEABG()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1808f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 342f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("/Saved Games/", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1664f;
			LGILGCGIHHM += Time.deltaTime * (622f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1336f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void JEEINPBLBDI()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		OFKDKJGIDLH();
	}

	public void CMCIEBNIFAL()
	{
		LGILGCGIHHM = 8f;
		CFCECAPJCOM = false;
	}

	private void NLBAJOJIHGM()
	{
		EFGKBEHNOBH.SetFloat("_DotSize", 1932f);
		OLBDFLPFFHP = 1401f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 912f;
	}

	private void DAHIMKKFNPH()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		BBBNLHALLBN();
	}

	private void BGDONBMDPGM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 591f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1914f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("y", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1766f;
			LGILGCGIHHM += Time.deltaTime * (396f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 197f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("RecieveChatActionMessage", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void IKMELABKBHO()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1195f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1471f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("violet", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 129f;
			LGILGCGIHHM += Time.deltaTime * (1053f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1633f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("_Value2", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void LIMBEFBJNPL()
	{
		EFGKBEHNOBH.SetFloat("14", 143f);
		OLBDFLPFFHP = 1715f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 221f;
	}

	private void EEBGCGFNELO()
	{
		EFGKBEHNOBH.SetFloat("OK", 525f);
		OLBDFLPFFHP = 752f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1107f;
	}

	private void NALOPIJDJCM()
	{
		EFGKBEHNOBH.SetFloat("EnvironmentSlider", 592f);
		OLBDFLPFFHP = 225f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 779f;
	}

	private void OLFNCABJBHA()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		MIFIEGOGKDA();
	}

	public void MPLOJJAMAOC()
	{
		LGILGCGIHHM = 1485f;
		CFCECAPJCOM = true;
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

	private void ABDHDGNIHHI()
	{
		EFGKBEHNOBH.SetFloat("Item created: Id: ", 97f);
		OLBDFLPFFHP = 1102f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1074f;
	}

	public void ICOFJDNIFHM()
	{
		LGILGCGIHHM = 400f;
		CFCECAPJCOM = false;
	}

	public void IMIOENPJAAB()
	{
		LGILGCGIHHM = 1244f;
		CFCECAPJCOM = true;
	}

	private void BDAPPLGLBOL()
	{
		EFGKBEHNOBH.SetFloat("_ScreenResolution", 1671f);
		OLBDFLPFFHP = 1774f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 865f;
	}

	private void OBAEDJJDCPN()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1086f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 174f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat(" not exist", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 249f;
			LGILGCGIHHM += Time.deltaTime * (811f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1760f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("[BuildInfo] Error: ", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void DNENFLNCIJP()
	{
		if (!CFCECAPJCOM)
		{
			float num = 199f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1751f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("buttons", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 181f;
			LGILGCGIHHM += Time.deltaTime * (631f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1574f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Could not execute RPC ", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void PHJJHFBLICM()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1116f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 1127f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 197f;
			LGILGCGIHHM += Time.deltaTime * (1455f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 125f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("Jump", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	public void DJANNMFGNCC()
	{
		LGILGCGIHHM = 82f;
		CFCECAPJCOM = true;
	}

	private void GAOMPMFOJNC()
	{
		EFGKBEHNOBH.SetFloat("id", 1848f);
		OLBDFLPFFHP = 1201f;
		CFCECAPJCOM = false;
		LGILGCGIHHM = 1920f;
	}

	private void MFMIODIAKNI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 1760f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 565f;
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
			float num2 = 1095f;
			LGILGCGIHHM += Time.deltaTime * (1293f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 414f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("GlassColor", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void GEPELODHBFN()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		BJIKAHNJNEB();
	}

	private void JNBPKNNBMDI()
	{
		if (!CFCECAPJCOM)
		{
			float num = 767f;
			if (Mathf.Abs(OJICGBOIKNA.localPosition.z) < MPNMOONBMII)
			{
				num = 450f;
			}
			else if (OJICGBOIKNA.localPosition.z <= 0f - MPNMOONBMII)
			{
				num = (IIFGDPMOKOO - Mathf.Abs(OJICGBOIKNA.localPosition.z + MPNMOONBMII)) / IIFGDPMOKOO;
			}
			EFGKBEHNOBH.SetFloat("_ScreenResolution", Mathf.Clamp01(num));
			OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1475f;
			LGILGCGIHHM += Time.deltaTime * (295f / num2);
			float num3 = Mathf.Lerp(OLBDFLPFFHP, 1814f, LGILGCGIHHM);
			EFGKBEHNOBH.SetFloat("ItemsStoreButton", Mathf.Clamp01(num3));
			OLBDFLPFFHP = num3;
		}
	}

	private void KEKNHAAEPCJ()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		EEDLLCHIAKG();
	}

	private void GCMLEEHGBPA()
	{
		EFGKBEHNOBH.SetFloat("/", 951f);
		OLBDFLPFFHP = 1617f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1594f;
	}

	public void LEIHAKCEKID()
	{
		LGILGCGIHHM = 502f;
		CFCECAPJCOM = false;
	}

	private void FNMPIAMIKCP()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		LIMBEFBJNPL();
	}

	private void PHHOMLJECOJ()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		NELFFHHCADM();
	}

	private void LHIBPEGLPHM()
	{
		EFGKBEHNOBH.SetFloat("LevelEditor/patterns", 1326f);
		OLBDFLPFFHP = 986f;
		CFCECAPJCOM = true;
		LGILGCGIHHM = 1009f;
	}

	private void JIJPHEDDIHC()
	{
		EFGKBEHNOBH = GetComponent<Animator>();
		OJICGBOIKNA = base.transform.parent.transform;
		GLJIDEPMMFO();
	}
}
