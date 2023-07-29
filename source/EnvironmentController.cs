// EnvironmentController
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
	public bool resetOnStart = true;

	public Vector3 targetPosition = new Vector3(0f, 0f, 0f);

	public Vector3 targetRotation = new Vector3(0f, 0f, 0f);

	public Vector3 targetScale = new Vector3(1f, 1f, 1f);

	public float positionLerpSpeed = 10f;

	public float rotationLerpSpeed = 10f;

	public float scaleLerpSpeed = 10f;

	public void IABLKKAALGI()
	{
		if (resetOnStart)
		{
			CEACMFGNDEB();
		}
	}

	public virtual Transform DKHOEKHNPCF()
	{
		return base.transform;
	}

	public void MLLPGPANCHI()
	{
		if (resetOnStart)
		{
			CEACMFGNDEB();
		}
	}

	public virtual void OPFDGBDADMA()
	{
	}

	public void OnEnable()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void FBMDHDBELEK()
	{
		if (positionLerpSpeed > 1235f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 917f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 691f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual Transform HFBPLEFHAAL()
	{
		return base.transform;
	}

	public virtual void HHJBBHEBJCJ()
	{
	}

	public void LIEGJOHINGC()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void BMODOIJGIOO()
	{
		if (positionLerpSpeed > 202f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 191f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1232f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void EOEOCMANAMH(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public void GKNKIIEALCH()
	{
		if (resetOnStart)
		{
			IJFMKNEPKEJ();
		}
	}

	public void OnDisable()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void GEAPEDDHDAB(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void EFGLPLCJHLC(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual Transform GetChild()
	{
		return base.transform;
	}

	public void KFEKCJDEECK()
	{
		if (resetOnStart)
		{
			LAACNNJDKBI();
		}
	}

	public virtual void Awake()
	{
	}

	public virtual void PLPOEHKKKJH(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void HBPLJMJAAHK()
	{
	}

	public virtual void SetRotation(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual void EHCGBJDFMHG()
	{
		if (positionLerpSpeed > 1550f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 416f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1710f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void FGJOIELIIID(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void DDBIHOGBDKM(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public void EAOKCECGKAK()
	{
		if (resetOnStart)
		{
			LAACNNJDKBI();
		}
	}

	public void DFENCIHAADO()
	{
		if (resetOnStart)
		{
			EGFBPCMCNDJ();
		}
	}

	public virtual void Update()
	{
		if (positionLerpSpeed > 0f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 0f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 0f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void OADGIILFOJL(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void FMAFBLKAJDF()
	{
	}

	public void GJLKJAOBPJD()
	{
		if (resetOnStart)
		{
			IJFMKNEPKEJ();
		}
	}

	public virtual void PKCELMBKBFO(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void EGFBPCMCNDJ()
	{
		targetPosition = new Vector3(1491f, 1637f, 1468f);
		targetRotation = new Vector3(1415f, 21f, 1690f);
		targetScale = new Vector3(758f, 1879f, 1536f);
		positionLerpSpeed = 343f;
		rotationLerpSpeed = 499f;
		scaleLerpSpeed = 891f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual Transform PLKIOLIDCLM()
	{
		return base.transform;
	}

	public virtual void CEACMFGNDEB()
	{
		targetPosition = new Vector3(114f, 703f, 327f);
		targetRotation = new Vector3(767f, 1913f, 1493f);
		targetScale = new Vector3(1462f, 383f, 1086f);
		positionLerpSpeed = 400f;
		rotationLerpSpeed = 1031f;
		scaleLerpSpeed = 1056f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void NPFELDCPNJO(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public void MGFFNGEGFDC()
	{
		if (resetOnStart)
		{
			CKCPHFLOLAH();
		}
	}

	public virtual void LAACNNJDKBI()
	{
		targetPosition = new Vector3(575f, 1401f, 1244f);
		targetRotation = new Vector3(877f, 1127f, 6f);
		targetScale = new Vector3(1013f, 580f, 156f);
		positionLerpSpeed = 92f;
		rotationLerpSpeed = 715f;
		scaleLerpSpeed = 1868f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void Reset()
	{
		targetPosition = new Vector3(0f, 0f, 0f);
		targetRotation = new Vector3(0f, 0f, 0f);
		targetScale = new Vector3(1f, 1f, 1f);
		positionLerpSpeed = 10f;
		rotationLerpSpeed = 10f;
		scaleLerpSpeed = 10f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void OLFNCABJBHA()
	{
	}

	public virtual void EEBGCGFNELO()
	{
		targetPosition = new Vector3(375f, 1201f, 1418f);
		targetRotation = new Vector3(491f, 1348f, 1170f);
		targetScale = new Vector3(619f, 654f, 554f);
		positionLerpSpeed = 323f;
		rotationLerpSpeed = 143f;
		scaleLerpSpeed = 1086f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void DNFFABFKHEK(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void EMANBHKAONB()
	{
	}

	public virtual Transform JJCOLGDKJNL()
	{
		return base.transform;
	}

	public virtual void LEKMLDEKHJF(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual void GONKPNAAIEE()
	{
		targetPosition = new Vector3(1384f, 1759f, 1570f);
		targetRotation = new Vector3(1431f, 1890f, 1459f);
		targetScale = new Vector3(1257f, 1532f, 869f);
		positionLerpSpeed = 940f;
		rotationLerpSpeed = 136f;
		scaleLerpSpeed = 1868f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void PCDAJFKCGJO(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void IJFMKNEPKEJ()
	{
		targetPosition = new Vector3(492f, 668f, 1187f);
		targetRotation = new Vector3(1538f, 821f, 641f);
		targetScale = new Vector3(195f, 936f, 258f);
		positionLerpSpeed = 1530f;
		rotationLerpSpeed = 1539f;
		scaleLerpSpeed = 1132f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public void JLNNHKPHMAB()
	{
		if (resetOnStart)
		{
			BJIKAHNJNEB();
		}
	}

	public virtual void GMIOCKFLJAK()
	{
	}

	public virtual void CKCPHFLOLAH()
	{
		targetPosition = new Vector3(771f, 907f, 1147f);
		targetRotation = new Vector3(732f, 553f, 1171f);
		targetScale = new Vector3(1129f, 508f, 75f);
		positionLerpSpeed = 1455f;
		rotationLerpSpeed = 1424f;
		scaleLerpSpeed = 1858f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void BJIKAHNJNEB()
	{
		targetPosition = new Vector3(688f, 1263f, 1862f);
		targetRotation = new Vector3(99f, 196f, 848f);
		targetScale = new Vector3(1056f, 688f, 41f);
		positionLerpSpeed = 766f;
		rotationLerpSpeed = 184f;
		scaleLerpSpeed = 1698f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void HLECFMGMLMA(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual void CCMJDMOOOIP(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void BGDONBMDPGM()
	{
		if (positionLerpSpeed > 569f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 1952f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1560f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual Transform FHGOJAADNIK()
	{
		return base.transform;
	}

	public virtual void NKLIHNJCHOG()
	{
		if (positionLerpSpeed > 1899f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 1254f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1681f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void FAAJAMIGJNK()
	{
	}

	public void DHNGNHGDPLM()
	{
		if (resetOnStart)
		{
			GONKPNAAIEE();
		}
	}

	public virtual void JDLABNJGJIB(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void EHNKGKELFCC(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void CFIAKIJAILI()
	{
		if (positionLerpSpeed > 565f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 417f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 894f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void BFLNNFJCLLC(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void IOMCHHBGJEC()
	{
	}

	public void EDBEHEKMGFH()
	{
		if (resetOnStart)
		{
			EEBGCGFNELO();
		}
	}

	public virtual void NLNAJMCBNDC()
	{
	}

	public virtual void SetPosition(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void OKADMJFLMGP()
	{
	}

	public virtual void LOKKIADJAFE()
	{
		targetPosition = new Vector3(432f, 1662f, 512f);
		targetRotation = new Vector3(1069f, 1110f, 694f);
		targetScale = new Vector3(28f, 662f, 257f);
		positionLerpSpeed = 122f;
		rotationLerpSpeed = 1969f;
		scaleLerpSpeed = 345f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual Transform AJHJOLDIKAB()
	{
		return base.transform;
	}

	public virtual Transform PCOHOHLJMDG()
	{
		return base.transform;
	}

	public virtual void CAPPKCBFILL()
	{
		targetPosition = new Vector3(385f, 106f, 1110f);
		targetRotation = new Vector3(1590f, 13f, 1560f);
		targetScale = new Vector3(293f, 1727f, 259f);
		positionLerpSpeed = 461f;
		rotationLerpSpeed = 516f;
		scaleLerpSpeed = 456f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void IFOCJKKDCJO(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public void JOJFHFHOCHO()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void FCEGNLNDPGL(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void SetScale(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public virtual void MDPDFGHGBDA(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual void DGJCMMAMONB(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual Transform NJDFFIMHILH()
	{
		return base.transform;
	}
}
