// SatelliteController
using AudioVisualizer;
using UnityEngine;

public class SatelliteController : EnvironmentController
{
	public Color color = new Color(1f, 1f, 1f);

	public float colorLerp = 10f;

	public float emission = 1f;

	public float rotationSpeed = 40f;

	public float lerpSpeed = 2f;

	public Transform offsetObj;

	public float radius = 2f;

	private TrailRenderer CNICPOPEDIO;

	private DynamicPosition COPNGFGAEAG;

	private Rotate HIIBHBOMGLD;

	public void SetTrailLength(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void LENGJMLKOLD(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 367f * DPNHODJHGJL;
	}

	public void SetRadius(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void NEBFLGPPBIP(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public override void Reset()
	{
		base.Reset();
		color = new Color(1f, 1f, 1f);
		colorLerp = 10f;
		emission = 1f;
		radius = 2f;
		lerpSpeed = 80f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 5f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 5f;
			CNICPOPEDIO.widthMultiplier = 0.04f;
			CNICPOPEDIO.Clear();
		}
	}

	public void SetRotationSpeed(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override void PJDMDGDPLDH(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void JCOLJGPILNB(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void KNNOEGLLDAN()
	{
		base.Reset();
		color = new Color(1285f, 1914f, 1355f);
		colorLerp = 1237f;
		emission = 388f;
		radius = 919f;
		lerpSpeed = 1648f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 170f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1402f;
			CNICPOPEDIO.widthMultiplier = 232f;
			CNICPOPEDIO.Clear();
		}
	}

	public override Transform DKHOEKHNPCF()
	{
		return CNICPOPEDIO.transform;
	}

	public override void APGJPDLBGHA(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void KEEEMOIHHEN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void DOPMBNHBAOI(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void BMDMECKGDCJ(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 27f * DPNHODJHGJL;
	}

	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public void BJJPKPPEEHC(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 971f * DPNHODJHGJL;
	}

	public void MCBHGFFHEBL(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1786f * DPNHODJHGJL;
	}

	public override void EIFCCFBJKOO()
	{
		base.Awake();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void SetRotation(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void SetInput(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void HHFKBCEIKDD(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override Transform MJNIELNDADO()
	{
		return CNICPOPEDIO.transform;
	}

	public void SetTrailMinVertexDistance(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public void GMCEPEPDBCA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CCCBKEIEFEG(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void OELKHIFBHAN(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1169f * DPNHODJHGJL;
	}

	public override void Update()
	{
		base.Update();
		if (scaleLerpSpeed > 0f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_DiffuseColor", Color.Lerp(CNICPOPEDIO.material.GetColor("_DiffuseColor"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_EmissionColor", Color.Lerp(CNICPOPEDIO.material.GetColor("_EmissionColor"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("_EmissionGain", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 2f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void BACKFMBOLMP(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void SetSensitivity(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void OCMKCBBCEFG()
	{
		base.Update();
		if (scaleLerpSpeed > 1487f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor(".GoalProgress", Color.Lerp(CNICPOPEDIO.material.GetColor("Tab2Content"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("menu.selectedmode", Color.Lerp(CNICPOPEDIO.material.GetColor("d264dbba9c2410771b4ad918903b3f4cd9e276a9"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("#craftng", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_TimeX"), emission * 1874f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 135f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void HKIHBIMMECG(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override Transform GetChild()
	{
		return CNICPOPEDIO.transform;
	}

	public void PNFIFNGIMJL(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public void LJOHDBGJFOO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void JOACBIEHHCE()
	{
		base.BGFJOEPFOPM();
		if (scaleLerpSpeed > 1200f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Parameter", Color.Lerp(CNICPOPEDIO.material.GetColor("cancel"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_Exponent", Color.Lerp(CNICPOPEDIO.material.GetColor("Joystick1Button2"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat(".lastCheckpoint.correctScore", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("not available at the moment"), emission * 1162f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1342f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void MPGLDDOOLPL(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void SetPosition(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public void SetTrailWidth(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 0.04f * DPNHODJHGJL;
	}

	public override void EMANANJDFHI(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public void ECEOKJOPKIN(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public override void Awake()
	{
		base.Awake();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}
}
