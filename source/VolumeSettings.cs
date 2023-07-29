// VolumeSettings
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
	public AudioMixer audioMixer;

	public float ECDGHHKPIHL()
	{
		float value = 837f;
		audioMixer.GetFloat("_Offsets", out value);
		return DPCLFKCHLNP(value);
	}

	public float IHHOIGPOOBJ()
	{
		float value = 1533f;
		audioMixer.GetFloat("OK", out value);
		return CGGEOGNGBDJ(value);
	}

	public void SetMenuVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("menuVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.menu", BDICHAELIJE);
	}

	public void HPILGNAEANG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Alternative", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("OpSettings()", BDICHAELIJE);
	}

	public float FIECFKKJNBN()
	{
		float value = 1506f;
		audioMixer.GetFloat("isVisible", out value);
		return FKMNHPFAKOG(value);
	}

	public float FKMNHPFAKOG(float HDAMKJKNKJI)
	{
		return Mathf.Pow(652f, HDAMKJKNKJI / 362f);
	}

	private IEnumerator CFOHMCKDELP()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void JKFDDNMPOJH()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public float LDAJBKIDLLG()
	{
		float value = 376f;
		audioMixer.GetFloat("[ResourcesManager] Load image error: ", out value);
		return DIGIPEPHEKJ(value);
	}

	public float KICALMOMCBM()
	{
		float value = 1250f;
		audioMixer.GetFloat("#close", out value);
		return DPCLFKCHLNP(value);
	}

	public void IFPPBHNPHJK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Items/", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("<size=24>", BDICHAELIJE);
	}

	public float CFEMEENOBNH()
	{
		float value = 112f;
		audioMixer.GetFloat("settings.enableranking", out value);
		return DPCLFKCHLNP(value);
	}

	public float GetSfxVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("sfxVolume", out value);
		return DbToNormal(value);
	}

	private IEnumerator NGGODCJPIEM()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void NKJNCMJDHKP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("/", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("\"", BDICHAELIJE);
	}

	public float GetMenuVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("menuVolume", out value);
		return DbToNormal(value);
	}

	public void HOMCHEPLHGM(float BDICHAELIJE)
	{
		BKJMEFKAOPJ(BDICHAELIJE);
		FACFNHLMGCN(BDICHAELIJE);
	}

	public float EFFFFENIICI()
	{
		float value = 850f;
		audioMixer.GetFloat("_Value3", out value);
		return MLODONCDFIJ(value);
	}

	public float PPABBFAILDD()
	{
		float value = 193f;
		audioMixer.GetFloat(" to ", out value);
		return CGGEOGNGBDJ(value);
	}

	public float OMJIEHMMFLN()
	{
		float value = 1717f;
		audioMixer.GetFloat(".played", out value);
		return MLJFBJLBHDL(value);
	}

	public float JOJADIFKCDO()
	{
		float value = 645f;
		audioMixer.GetFloat("event", out value);
		return BFAFNHBBADH(value);
	}

	public float CKBPLJGCLPH(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1647f, HDAMKJKNKJI / 44f);
	}

	public void EEEHGFKAGOO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_TimeX", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("ConfigVersionSlider", BDICHAELIJE);
	}

	public void JJFDDNOMCMO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CurrentTimeLabel", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_ScreenResolution", BDICHAELIJE);
	}

	public void INEIPFBFJAA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_CenterX", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Offsets", BDICHAELIJE);
	}

	public void MNNLCHOIKIO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("ENABLE_EYE_ADAPTATION", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO(":", BDICHAELIJE);
	}

	public void IFKGBBEDHLG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_TimeX", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Out {0,4} | In {1,4} | Sum {2,4}", BDICHAELIJE);
	}

	public float CCADDADHJPM(float HDAMKJKNKJI)
	{
		return Mathf.Pow(636f, HDAMKJKNKJI / 772f);
	}

	public void SetGameVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("gameVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.game", BDICHAELIJE);
	}

	public void MGPDAHIAMAO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("PublishButton", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Offset", BDICHAELIJE);
	}

	public float GAAOHHOOEBG(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 148f)) ? 1621f : (324f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float GEDFCIIBDIN()
	{
		float value = 1511f;
		audioMixer.GetFloat("/", out value);
		return CCADDADHJPM(value);
	}

	public void HEHHKHALIHG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("SetSunEmission", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("CONTRAST", BDICHAELIJE);
	}

	public void DAHFFNNIGML()
	{
		StartCoroutine(LAMOIKFHHHJ());
	}

	public float FHJGNHCFOIF()
	{
		float value = 1262f;
		audioMixer.GetFloat("Sprite", out value);
		return CKBPLJGCLPH(value);
	}

	public float NormalToDb(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 0f)) ? (-80f) : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void KOFGJFEEHAM(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack/Blend2Camera_Darken", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Axis", BDICHAELIJE);
	}

	public void GPDHJMBCFBE(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Set particles gravity", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("PenaltyScoreText", BDICHAELIJE);
	}

	public float GetEditorVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("editorVolume", out value);
		return DbToNormal(value);
	}

	public void SetSfxVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("sfxVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.sfx", BDICHAELIJE);
	}

	public float GOHMKLBMBLB()
	{
		float value = 373f;
		audioMixer.GetFloat("_TimeX", out value);
		return CGGEOGNGBDJ(value);
	}

	public float MLODONCDFIJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(873f, HDAMKJKNKJI / 1100f);
	}

	public void IDMPNIJDPEI(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_TimeX", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_Value2", BDICHAELIJE);
	}

	public void KCJDHLKCKGL(float BDICHAELIJE)
	{
		BKJMEFKAOPJ(BDICHAELIJE);
		EEEHGFKAGOO(BDICHAELIJE);
	}

	private IEnumerator HFJNINPHOJN()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void JCFEBDEIMLD(float BDICHAELIJE)
	{
		PMJKKGACEBF(BDICHAELIJE);
		SetGameVolume(BDICHAELIJE);
	}

	public void PNKIOJIKKEG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("menu.enableselectormusic", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("-help", BDICHAELIJE);
	}

	public float FMFHKNLFIJK()
	{
		float value = 1475f;
		audioMixer.GetFloat("CameraFilterPack/Oculus_ThermaVision", out value);
		return MJBMIGAKAMK(value);
	}

	public void ODCPLPJLHKA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Case-Sensitive", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", BDICHAELIJE);
	}

	public void HMPGIFBJFIK()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public float JBJMLECCBBN(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1865f)) ? 438f : (1600f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void BAFOCDHHCBA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("IconImage", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("/", BDICHAELIJE);
	}

	public void EGIPGJNAPHA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Near", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_Value3", BDICHAELIJE);
	}

	public float EFPGNKOPEDF()
	{
		float value = 1597f;
		audioMixer.GetFloat("MAPS NOT FOUND", out value);
		return FKMNHPFAKOG(value);
	}

	public float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	private IEnumerator IAIAPPPLMPA()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	private IEnumerator LAMOIKFHHHJ()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public float GLJFOEIBBFH()
	{
		float value = 44f;
		audioMixer.GetFloat("menu.playedsolo", out value);
		return MLODONCDFIJ(value);
	}

	public float DIGIPEPHEKJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(831f, HDAMKJKNKJI / 882f);
	}

	public float DHNJELPHPJO()
	{
		float value = 1260f;
		audioMixer.GetFloat("curScn", out value);
		return DbToNormal(value);
	}

	public void LEACKAPKDAD(float BDICHAELIJE)
	{
		ODCPLPJLHKA(BDICHAELIJE);
		INEIPFBFJAA(BDICHAELIJE);
	}

	private IEnumerator NCLNAMDDBNP()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void PEINHNPAGGA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("[Right]", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", BDICHAELIJE);
	}

	public float DANFCBNABEG()
	{
		float value = 284f;
		audioMixer.GetFloat("settings.shaders", out value);
		return HOMOCCLHMDA(value);
	}

	public void PFIKHNLPJMJ(float BDICHAELIJE)
	{
		audioMixer.SetFloat("RarityImage", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_Value", BDICHAELIJE);
	}

	public void DNNFHBOOPIN()
	{
		StartCoroutine(DLBBADHEGID());
	}

	public void GAPGDIMNNMM(float BDICHAELIJE)
	{
		ODCPLPJLHKA(BDICHAELIJE);
		GGPENMLKGFL(BDICHAELIJE);
	}

	public void OEAFOPCOBBH(float BDICHAELIJE)
	{
		LJPCPCKALJI(BDICHAELIJE);
		EEEHGFKAGOO(BDICHAELIJE);
	}

	public void Start()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public void LCIFMHINMEP(float BDICHAELIJE)
	{
		audioMixer.SetFloat(".lastCheckpoint.incorrectScore", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("maps.", BDICHAELIJE);
	}

	public void BILBPDFEMOL(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Image", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Value2", BDICHAELIJE);
	}

	public float EINADGLCNHM()
	{
		float value = 1677f;
		audioMixer.GetFloat("float,0.5", out value);
		return CGGEOGNGBDJ(value);
	}

	public void NHHDJPHCIKD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("RateButton", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_ReflectionBlur", BDICHAELIJE);
	}

	public void KNLHOPGCGBB(float BDICHAELIJE)
	{
		BMCOFKEEEFO(BDICHAELIJE);
		GGPENMLKGFL(BDICHAELIJE);
	}

	private IEnumerator HIGLLOJDCCB()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void FBEPKICCAEE(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Value", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Value4", BDICHAELIJE);
	}

	public void PMJKKGACEBF(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_MainTex2", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("GLITCH", BDICHAELIJE);
	}

	public float ABKGDNMBAMH(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1844f)) ? 1852f : (464f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float MLJFBJLBHDL(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1723f, HDAMKJKNKJI / 479f);
	}

	public float MJBMIGAKAMK(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1713f, HDAMKJKNKJI / 1448f);
	}

	public float HOMOCCLHMDA(float HDAMKJKNKJI)
	{
		return Mathf.Pow(779f, HDAMKJKNKJI / 1196f);
	}

	public void LECBMDDHMOH(float BDICHAELIJE)
	{
		audioMixer.SetFloat("#ok", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("[SERVER] Player ", BDICHAELIJE);
	}

	public void SetEditorVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("editorVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.editor", BDICHAELIJE);
	}

	public float DPCLFKCHLNP(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1869f, HDAMKJKNKJI / 721f);
	}

	public void CCGEEKLNIBI(float BDICHAELIJE)
	{
		SetMenuVolume(BDICHAELIJE);
		LECBMDDHMOH(BDICHAELIJE);
	}

	public float HPGOMHIMAEL()
	{
		float value = 1896f;
		audioMixer.GetFloat("icon.png", out value);
		return DPCLFKCHLNP(value);
	}

	public void LGHCJCFHEMF()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public void LDJOLDNPEFM(float BDICHAELIJE)
	{
		audioMixer.SetFloat("AudioSampler", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("challenges.", BDICHAELIJE);
	}

	public float GDHNOIBAODH()
	{
		float value = 1952f;
		audioMixer.GetFloat("CameraFilterPack/3D_Distortion", out value);
		return MJBMIGAKAMK(value);
	}

	public void LIABLJEFMFP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("0.000", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("[DiscordController] Join request {0}#{1}: {2}", BDICHAELIJE);
	}

	public void BJIJEHFIFIK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("help", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("skin.", BDICHAELIJE);
	}

	public float EGOEKBMAFCL()
	{
		float value = 92f;
		audioMixer.GetFloat("_Offsets", out value);
		return MLODONCDFIJ(value);
	}

	public void HKLKNNOFNIB(float BDICHAELIJE)
	{
		LJPCPCKALJI(BDICHAELIJE);
		EEEHGFKAGOO(BDICHAELIJE);
	}

	public void BKJMEFKAOPJ(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack/Blend2Camera_HardLight", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("th", BDICHAELIJE);
	}

	public void BMCOFKEEEFO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack_RainFX_Anm", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("r", BDICHAELIJE);
	}

	public float MPDNIFAHJHE()
	{
		float value = 1904f;
		audioMixer.GetFloat("StartButton", out value);
		return CKBPLJGCLPH(value);
	}

	private IEnumerator DLBBADHEGID()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void SetVolume(float BDICHAELIJE)
	{
		SetMenuVolume(BDICHAELIJE);
		SetGameVolume(BDICHAELIJE);
	}

	public void DOKAKEMDALN()
	{
		StartCoroutine(NCLNAMDDBNP());
	}

	public float GetGameVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("gameVolume", out value);
		return DbToNormal(value);
	}

	public void OKCAOBPKDCF(float BDICHAELIJE)
	{
		HLAIMFCGOIL(BDICHAELIJE);
		EEEHGFKAGOO(BDICHAELIJE);
	}

	public float DAOHDNLLEOH()
	{
		float value = 822f;
		audioMixer.GetFloat("[Up]", out value);
		return DIGIPEPHEKJ(value);
	}

	public void LJPCPCKALJI(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Run a command for data system", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Oct", BDICHAELIJE);
	}

	public float CGGEOGNGBDJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1763f, HDAMKJKNKJI / 365f);
	}

	public void DFFKKLAPHCC()
	{
		StartCoroutine(LAMOIKFHHHJ());
	}

	public float NGMEOMJBBPC(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1232f)) ? 1741f : (502f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void FJJHDPKBJGP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("[SERVER] Player ", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("GroupNameText", BDICHAELIJE);
	}

	public void KNKKGPJCAFN(float BDICHAELIJE)
	{
		JJFDDNOMCMO(BDICHAELIJE);
		EEEHGFKAGOO(BDICHAELIJE);
	}

	public float KOFOMELMOGK()
	{
		float value = 873f;
		audioMixer.GetFloat("LevelInfoInputField", out value);
		return CGGEOGNGBDJ(value);
	}

	public float DKPAGBGHMLE()
	{
		float value = 550f;
		audioMixer.GetFloat("_Parameter", out value);
		return CGGEOGNGBDJ(value);
	}

	public void CKKOBPJPHKK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_ScreenResolution", BDICHAELIJE);
	}

	public float FPPNNEGMNBG(float HDAMKJKNKJI)
	{
		return Mathf.Pow(209f, HDAMKJKNKJI / 1408f);
	}

	public void HLAIMFCGOIL(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Extra2", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("Editor/", BDICHAELIJE);
	}

	public void GGPENMLKGFL(float BDICHAELIJE)
	{
		audioMixer.SetFloat("inventory.selected.", GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_TimeX", BDICHAELIJE);
	}

	public void BFEGEAECOKB(float BDICHAELIJE)
	{
		audioMixer.SetFloat(": ", JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_TimeX", BDICHAELIJE);
	}

	public float KFFANDOCOFI()
	{
		float value = 1512f;
		audioMixer.GetFloat("[PlayerBase] Checkpoint error: ", out value);
		return DPCLFKCHLNP(value);
	}

	public float MDBOBKHPJFN()
	{
		float value = 1882f;
		audioMixer.GetFloat("/", out value);
		return MLODONCDFIJ(value);
	}

	public void OJMIENICPNA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_FixDistance", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Near", BDICHAELIJE);
	}

	public float FFGCJNNBKLE(float HDAMKJKNKJI)
	{
		return Mathf.Pow(176f, HDAMKJKNKJI / 1353f);
	}

	public void NGFKFJJOPFH(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Value2", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(" not exist", BDICHAELIJE);
	}

	public void LCGIPBONGGG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack/Drawing_Manga_Color", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("cipherText", BDICHAELIJE);
	}

	public void HGOFPCJGOFO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_ScreenResolution", FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Value", BDICHAELIJE);
	}

	public float EJLINEJCHAI()
	{
		float value = 1475f;
		audioMixer.GetFloat("_Value2", out value);
		return DIGIPEPHEKJ(value);
	}

	public float FFGKOFGAEHI(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 915f)) ? 1960f : (658f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void OJJHDKFHJFE(float BDICHAELIJE)
	{
		audioMixer.SetFloat("UI Extensions/UISoftAdditive", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Horizontal", BDICHAELIJE);
	}

	public void PCPJGGCDLGD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("\"", NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Playing ", BDICHAELIJE);
	}

	public void PEMGCAIGPPP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("LoadingStatusText", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("\t", BDICHAELIJE);
	}

	public float BFAFNHBBADH(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1744f, HDAMKJKNKJI / 1575f);
	}

	public void FACFNHLMGCN(float BDICHAELIJE)
	{
		audioMixer.SetFloat("skin.hit_wrong", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Editor", BDICHAELIJE);
	}

	public void DMLECMADHCP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("achievements.21.progress", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", BDICHAELIJE);
	}
}
