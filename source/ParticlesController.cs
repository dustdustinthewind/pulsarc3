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

	public override void Awake()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void MADENBGHKDD()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void OGKGIAAACAD()
	{
		base.Reset();
		JAJLKKICEPG.KHGOJDPMPML();
		color = new Color(431f, 152f, 492f);
		colorLerp = 1750f;
		emission = 1810f;
		particlesPerBit = -3;
		JAJLKKICEPG.OnBeat.AddListener(EPDLOFDOBHD);
		SetParticleSize(1099f);
	}

	public void MBGGKLDJICH()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public override void EHJJFJCKGAJ()
	{
		base.EHCGBJDFMHG();
		HKIDNEAKGNO.material.SetColor("CameraFilterPack/Vision_Warp", Color.Lerp(HKIDNEAKGNO.material.GetColor("st"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("settings.disablestoryboard", Color.Lerp(HKIDNEAKGNO.material.GetColor("[MapsData] Preloading "), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Jitter", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_Fade"), emission * 1163f, Time.smoothDeltaTime * colorLerp));
	}

	public void LHBOODNOJFO(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void JADEDAEMLBN()
	{
		base.Reset();
		JAJLKKICEPG.HFFAJNCOJNB();
		color = new Color(1596f, 766f, 1312f);
		colorLerp = 1844f;
		emission = 1994f;
		particlesPerBit = 118;
		JAJLKKICEPG.OnBeat.AddListener(MBGGKLDJICH);
		BBHCJIFFCLO(1244f);
	}

	public void BBHCJIFFCLO(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 904f * DPNHODJHGJL;
		startSize.constantMin = 1110f;
		main.startSize = startSize;
	}

	public void JMPJBCGABHD(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void CCGDBJFKBHL(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void GJNJDEOCMAF(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void BABMEBHPHDA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void PIIKOIINLHN(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void GLOJHNDCFHA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void KKALIMDILEG(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void GEPELODHBFN()
	{
		base.HBPLJMJAAHK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void EIPPJIKJOOD()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void GAKKHKBCFGP(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void BGDONBMDPGM()
	{
		base.Update();
		HKIDNEAKGNO.material.SetColor("bad", Color.Lerp(HKIDNEAKGNO.material.GetColor("[LevelEditorScene] Error: You're not logged into Steam!"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("SupportLogger OnJoinedLobby(", Color.Lerp(HKIDNEAKGNO.material.GetColor("Object ID. Case-Sensitive"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("[PlayerController] ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_PColor"), emission * 984f, Time.smoothDeltaTime * colorLerp));
	}

	public override void EMANBHKAONB()
	{
		base.HHJBBHEBJCJ();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void FDCDJLFLLCP()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void MNCIAMGKCOP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 58f * DPNHODJHGJL;
		startSpeed.constantMin = 520f;
		main.startSpeed = startSpeed;
	}

	public void EPDLOFDOBHD()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public override void OJACCGOHBGH()
	{
		base.OLFNCABJBHA();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void SetParticleSpeed(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1f * DPNHODJHGJL;
		startSpeed.constantMin = 0f;
		main.startSpeed = startSpeed;
	}

	public void PAPHPPBCNDF(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1571f * DPNHODJHGJL;
		startSpeed.constantMin = 448f;
		main.startSpeed = startSpeed;
	}

	public void NBLKCMGLFOO()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void HEFDKAKLJMB(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
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

	public override void LFHKGIHNONL()
	{
		base.FMAFBLKAJDF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void ODOIBJOKNEC(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 705f * DPNHODJHGJL;
		startSpeed.constantMin = 1171f;
		main.startSpeed = startSpeed;
	}

	public void FDKDBAOGBGI(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void SetParticleSize(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 0.02f * DPNHODJHGJL;
		startSize.constantMin = 0f;
		main.startSize = startSize;
	}

	public override void EGFBPCMCNDJ()
	{
		base.EGFBPCMCNDJ();
		JAJLKKICEPG.FDNKDOOEHBA();
		color = new Color(1114f, 750f, 21f);
		colorLerp = 721f;
		emission = 226f;
		particlesPerBit = 37;
		JAJLKKICEPG.OnBeat.AddListener(NBLKCMGLFOO);
		SetParticleSize(1598f);
	}

	public override void GBNOIKAPBBO()
	{
		base.GMIOCKFLJAK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void JMFHNBLFEIE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void OPCLBGHAPMG()
	{
		base.CFIAKIJAILI();
		HKIDNEAKGNO.material.SetColor("R2", Color.Lerp(HKIDNEAKGNO.material.GetColor(".lastCheckpoint.longestComboScore"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("settings.cameramovements", Color.Lerp(HKIDNEAKGNO.material.GetColor("NEW_ACHIEVEMENT_1_26"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("LevelInfoInputField", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("challenges."), emission * 967f, Time.smoothDeltaTime * colorLerp));
	}

	public override void LJEFMGOBKGE()
	{
		base.EMANBHKAONB();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void Beat()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void OFIJNACNPNI(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void DMOGNGJDADN(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void PLHOPLBKKGE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void OGDNJLMLAEH(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
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

	public void GDENGLNNBLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void GCHBGCGBMCK()
	{
		base.BGDONBMDPGM();
		HKIDNEAKGNO.material.SetColor("sfxVolume", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Intensity"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("\\\\", Color.Lerp(HKIDNEAKGNO.material.GetColor("menu.playedpage"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_FarCamera", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("SetSunMaxSize"), emission * 1702f, Time.smoothDeltaTime * colorLerp));
	}

	public void EHBPMCMHOCI()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void IGHBDMLKAPN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void LBOBAIGNOML()
	{
		base.IOMCHHBGJEC();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void CBNEEGEGJOH(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public override void LBMLGIAKJCH()
	{
		base.GONKPNAAIEE();
		JAJLKKICEPG.LPFLJILPAAH();
		color = new Color(1196f, 598f, 1166f);
		colorLerp = 811f;
		emission = 872f;
		particlesPerBit = 1;
		JAJLKKICEPG.OnBeat.AddListener(EHBPMCMHOCI);
		BBHCJIFFCLO(51f);
	}

	public void SetGravity(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void KGGJDLHKHHL(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void OKADMJFLMGP()
	{
		base.FAAJAMIGJNK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public void OKGAOAMGLPO(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 70f * DPNHODJHGJL;
		startSpeed.constantMin = 218f;
		main.startSpeed = startSpeed;
	}

	public void NFBHGMNGKDC(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void NINKMGDIBIN(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void LDDKCCMHMIC()
	{
		base.BGDONBMDPGM();
		HKIDNEAKGNO.material.SetColor("player.deleted", Color.Lerp(HKIDNEAKGNO.material.GetColor("Joystick1Button1"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_Value4", Color.Lerp(HKIDNEAKGNO.material.GetColor("_ScreenResolution"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("[PlayerBase] Loaded environment: ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("{0}"), emission * 790f, Time.smoothDeltaTime * colorLerp));
	}

	public void KMODDDDIEEP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void NOONLBIIGKO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void KIEJKBNBHMD()
	{
		base.BGDONBMDPGM();
		HKIDNEAKGNO.material.SetColor("Cant send PickupItem spawn times to unknown targetPlayer.", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Value"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("IconImage", Color.Lerp(HKIDNEAKGNO.material.GetColor(").png"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("ticket.ticket1", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_ScreenResolution"), emission * 1932f, Time.smoothDeltaTime * colorLerp));
	}

	public override void PEMPABLNJHL()
	{
		base.HHJBBHEBJCJ();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void CEACMFGNDEB()
	{
		base.LAACNNJDKBI();
		JAJLKKICEPG.PDDIOCCBAIL();
		color = new Color(1627f, 1187f, 1603f);
		colorLerp = 675f;
		emission = 1592f;
		particlesPerBit = 97;
		JAJLKKICEPG.OnBeat.AddListener(MBGGKLDJICH);
		BBHCJIFFCLO(1361f);
	}

	public void MFIMFONHFBP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 279f * DPNHODJHGJL;
		startSpeed.constantMin = 1549f;
		main.startSpeed = startSpeed;
	}

	public void FNHHELEALEG(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void MANIAKFKOMP(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void GPFJMKCGHGB()
	{
		base.Update();
		HKIDNEAKGNO.material.SetColor("</color>", Color.Lerp(HKIDNEAKGNO.material.GetColor("_TimeX"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_Value3", Color.Lerp(HKIDNEAKGNO.material.GetColor("DPADHOR"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("\n", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("LevelEditor/patterns"), emission * 363f, Time.smoothDeltaTime * colorLerp));
	}

	public void CGJFHCMNENI(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void MKNFLKBBIEI(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 435f * DPNHODJHGJL;
		startSize.constantMin = 1330f;
		main.startSize = startSize;
	}

	public override void GGKPLCJNEHF()
	{
		base.EMANBHKAONB();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void KGMCGGIEPDE()
	{
		base.OLFNCABJBHA();
		HKIDNEAKGNO = GetComponent<Renderer>();
		MEAJNJKMKPA = GetComponent<ParticleSystem>();
		JAJLKKICEPG = GetComponent<AudioEventListener>();
	}

	public override void AIJGAJIOJDJ()
	{
		base.EHCGBJDFMHG();
		HKIDNEAKGNO.material.SetColor("[Singleton] multiple instances of '", Color.Lerp(HKIDNEAKGNO.material.GetColor("settings.enableranking"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor(" = ", Color.Lerp(HKIDNEAKGNO.material.GetColor("SetSunInput"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("[ResourcesManager] Load image error: ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_Screen"), emission * 1746f, Time.smoothDeltaTime * colorLerp));
	}

	public void HBKKOHNGBNM(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 600f * DPNHODJHGJL;
		startSpeed.constantMin = 820f;
		main.startSpeed = startSpeed;
	}

	public void KJMIHJOKAPP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		main.gravityModifier = DPNHODJHGJL;
	}

	public void IGEAPHGPAML(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void MOGLPIBCCPI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void PPBBONBFIPG(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void NGJMONJPAKB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void KEOFFJJNKME()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void GGFFDJALCEK()
	{
		MEAJNJKMKPA.Emit(particlesPerBit);
	}

	public void HAICKBPCHBK(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void HOCOJMHOCPA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void CDGMLEOBIGM(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 632f * DPNHODJHGJL;
		startSize.constantMin = 1529f;
		main.startSize = startSize;
	}

	public void LOKBBBFIEMK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 684f * DPNHODJHGJL;
		startSpeed.constantMin = 1939f;
		main.startSpeed = startSpeed;
	}

	public override void NFEDLAOPHML()
	{
		base.Update();
		HKIDNEAKGNO.material.SetColor("note.0", Color.Lerp(HKIDNEAKGNO.material.GetColor(".highscore"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("{0}", Color.Lerp(HKIDNEAKGNO.material.GetColor("GlassAberration"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("shader.frost", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("Added checkpoint"), emission * 1683f, Time.smoothDeltaTime * colorLerp));
	}

	public void MIDOJPKHNAA(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void OLIGEOJEMJP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1311f * DPNHODJHGJL;
		startSpeed.constantMin = 1377f;
		main.startSpeed = startSpeed;
	}

	public void NHDGAAFDJIJ(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 23f * DPNHODJHGJL;
		startSpeed.constantMin = 612f;
		main.startSpeed = startSpeed;
	}

	public void SetParticleCountPerBeat(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void IHHPNMGIPPL(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void BKNPCNOOPMK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1764f * DPNHODJHGJL;
		startSpeed.constantMin = 1491f;
		main.startSpeed = startSpeed;
	}

	public void DIDMMBIIHEF(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public void MMHDOGBBLKH(int DPNHODJHGJL)
	{
		particlesPerBit = DPNHODJHGJL;
	}

	public override void MANOCIJICLG()
	{
		base.LAACNNJDKBI();
		JAJLKKICEPG.HFFAJNCOJNB();
		color = new Color(1420f, 1138f, 822f);
		colorLerp = 664f;
		emission = 589f;
		particlesPerBit = 34;
		JAJLKKICEPG.OnBeat.AddListener(NBLKCMGLFOO);
		CDGMLEOBIGM(461f);
	}

	public void SetInput(int JMMILEFMACB)
	{
		JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void MOGAJELFJOF(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void Update()
	{
		base.Update();
		HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_DiffuseColor"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_EmissionColor"), color, Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
	}
}
