// ParticlesController
using AudioVisualizer;
using UnityEngine;

public class ParticlesController : EnvironmentController
{
	public Color color = new Color(1f, 1f, 1f);

	public float colorLerp = 10f;

	public float emission = 0.75f;

	public int particlesPerBit = 100;

	private Renderer HKIDNEAKGNO;

	private ParticleSystem MEAJNJKMKPA;

	private AudioEventListener JAJLKKICEPG;

	public void SetParticleSize(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 0.02f * DPNHODJHGJL;
		startSize.constantMin = 0f;
		main.startSize = startSize;
	}

	public void SetParticleCountPerBeat(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public override void Awake()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void LBEIJMMCGMI()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void LDGAEJGEBPG(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void PMPMNICBOOE()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void NAIGBCKKINH(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public override void Reset()
	{
		base.Reset();
		JAJLKKICEPG.Reset();
		color = new Color(1f, 1f, 1f);
		colorLerp = 10f;
		emission = 0.75f;
		particlesPerBit = 50;
		JAJLKKICEPG.OnBeat.AddListener(Beat);
		SetParticleSize(1f);
	}

	public void GLKGFPGHEAG(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void KLGKDHAPJGF(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void FHMDALPJHIF(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void SetInput(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void Beat()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void DDDHIOHDKFK()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void SetGravity(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void NLFCFJJDPMB(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void GPLOPKHCDKP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void JHPOIOELNCG()
	{
		base.LEAHIBJDMBI();
		HKIDNEAKGNO.material.SetColor("Search: ", Color.Lerp(HKIDNEAKGNO.material.GetColor("stretchWidth"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_FresnelFadePower", Color.Lerp(HKIDNEAKGNO.material.GetColor("SetPlayerDistance"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_TimeX", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("grid"), emission * 200f, Time.smoothDeltaTime * colorLerp));
	}

	public override void AEIJFLJEABG()
	{
		base.LEAHIBJDMBI();
		HKIDNEAKGNO.material.SetColor("\"", Color.Lerp(HKIDNEAKGNO.material.GetColor("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("FinalScoreSmallText", Color.Lerp(HKIDNEAKGNO.material.GetColor("CameraFilterPack/AAA_Blood"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("maps.", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("MenuScene"), emission * 1464f, Time.smoothDeltaTime * colorLerp));
	}

	public void DCLEHDFFKLE(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void EPCGHAAONLN()
	{
		base.FMAFBLKAJDF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void KMKLDAJLCNM()
	{
		base.AEIJFLJEABG();
		HKIDNEAKGNO.material.SetColor("_Red_C", Color.Lerp(HKIDNEAKGNO.material.GetColor("SpawnObj"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_Value", Color.Lerp(HKIDNEAKGNO.material.GetColor("Fade"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat(" respawn in future: ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_Amount"), emission * 1883f, Time.smoothDeltaTime * colorLerp));
	}

	public void SetParticleSpeed(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1f * DPNHODJHGJL;
		startSpeed.constantMin = 0f;
		main.startSpeed = startSpeed;
	}

	public void HKNGKPNMJCK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 358f * DPNHODJHGJL;
		startSpeed.constantMin = 577f;
		main.startSpeed = startSpeed;
	}

	public void HDFOEMCOGLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void FOKLHEDLEON(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void KKOIDNJJFGO(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void OABKJFIAGKK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 154f * DPNHODJHGJL;
		startSpeed.constantMin = 506f;
		main.startSpeed = startSpeed;
	}

	public void JGPLIAFMNID()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public override void Update()
	{
		base.Update();
		HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_DiffuseColor"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_EmissionColor"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
	}

	public override void MMBPLGGLPDB()
	{
		base.AEIJFLJEABG();
		HKIDNEAKGNO.material.SetColor("(\\[ */ *quote *\\])", Color.Lerp(HKIDNEAKGNO.material.GetColor("ready"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("value", Color.Lerp(HKIDNEAKGNO.material.GetColor("Received RPC \""), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Value7", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_MainTex2"), emission * 1672f, Time.smoothDeltaTime * colorLerp));
	}
}
