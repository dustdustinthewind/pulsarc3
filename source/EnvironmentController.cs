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

	public virtual void Awake()
	{
	}

	public void OnDisable()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void GFINDLLGLOA(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public void ICDBMJKMIKC()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void DPMGFHNFMBN(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual void SetScale(Vector3 FEKLHOPGFNC)
	{
		targetScale = FEKLHOPGFNC;
	}

	public void LLDBPKHDPKI()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void BGFJOEPFOPM()
	{
		if (positionLerpSpeed > 437f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 718f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1875f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual void AEIJFLJEABG()
	{
		if (positionLerpSpeed > 502f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 484f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1562f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual Transform GetChild()
	{
		return base.transform;
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

	public void JHJFBCFBKLD()
	{
		if (resetOnStart)
		{
			OGAMGLEAOAF();
		}
	}

	public virtual void CFABPFCHHLN(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void LEAHIBJDMBI()
	{
		if (positionLerpSpeed > 1271f)
		{
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, targetPosition, Time.deltaTime * positionLerpSpeed);
		}
		if (rotationLerpSpeed > 1231f)
		{
			base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * rotationLerpSpeed);
		}
		if (scaleLerpSpeed > 1252f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
	}

	public virtual Transform CLANIKJPMDP()
	{
		return base.transform;
	}

	public virtual void OGAMGLEAOAF()
	{
		targetPosition = new Vector3(1078f, 106f, 274f);
		targetRotation = new Vector3(492f, 1095f, 575f);
		targetScale = new Vector3(1754f, 1379f, 123f);
		positionLerpSpeed = 1792f;
		rotationLerpSpeed = 1976f;
		scaleLerpSpeed = 1444f;
		base.transform.localPosition = targetPosition;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
		base.transform.localScale = targetScale;
	}

	public virtual void BODPLDJLFCF()
	{
	}

	public virtual void LIGDABDFABK(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void FMAFBLKAJDF()
	{
	}

	public virtual void NKPEPBLNJCH(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void POHMFMNEPKK()
	{
	}

	public virtual void SetPosition(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public virtual void SetRotation(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public void OnEnable()
	{
		if (resetOnStart)
		{
			Reset();
		}
	}

	public virtual void HDKKGDIAJLB(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
	}

	public virtual Transform GMGBIILPLLH()
	{
		return base.transform;
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

	public void BDBKIEIIFPB()
	{
		if (resetOnStart)
		{
			OGAMGLEAOAF();
		}
	}
}
