// VolumeSettings
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
	public AudioMixer audioMixer;

	public float FIFNFIOKPOG()
	{
		float value = 1295f;
		audioMixer.GetFloat(". Possible scene loading in progress?", out value);
		return FJACGPIOMKA(value);
	}

	public float MIIAHIKIKLA()
	{
		float value = 872f;
		audioMixer.GetFloat("[GameScene] Events count: ", out value);
		return ECMKDDLIHJM(value);
	}

	public void GCJJBCNCDMK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_FarCorner", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", BDICHAELIJE);
	}

	public void KALAMGBPMMG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Drop_Far", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("CameraFilterPack_VHS1", BDICHAELIJE);
	}

	public void GAFIKFMPDCA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("x", IGDGALJHJPH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("_Value4", BDICHAELIJE);
	}

	public void SetVolume(float BDICHAELIJE)
	{
		SetMenuVolume(BDICHAELIJE);
		SetGameVolume(BDICHAELIJE);
	}

	private IEnumerator ILMFEHLGBGN()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void JJGONAPAHCN(float BDICHAELIJE)
	{
		audioMixer.SetFloat("ItemTemplate", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("\t", BDICHAELIJE);
	}

	private IEnumerator JEJLPJJOIIH()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void KOJKBFDNGDK()
	{
		StartCoroutine(FMLANACDKOM());
	}

	public float NormalToDb(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 0f)) ? (-80f) : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	private IEnumerator HLOHAFHBENK()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	private IEnumerator BCDOFHNGBAP()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void LABKFOGNFLB(float BDICHAELIJE)
	{
		audioMixer.SetFloat("achievements.21.progress", ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("_ScreenResolution", BDICHAELIJE);
	}

	private IEnumerator BNIIKPCKCPC()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void IOOKAOKJIKL(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Gamma", LLJAJLMOMNB(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("Hex value #RRGGBB", BDICHAELIJE);
	}

	public float IFPBEHINCMK(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1068f)) ? 1328f : (1124f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float GetGameVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("gameVolume", out value);
		return DbToNormal(value);
	}

	private IEnumerator EJMAGFFMCGJ()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void HFFMDEDDGDA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Right Stick Click", OLODCIGOIDD(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("settings.hitvariation", BDICHAELIJE);
	}

	public float OFDECOEPJIB()
	{
		float value = 1962f;
		audioMixer.GetFloat("_SunPosition", out value);
		return HFDCOHFNDIP(value);
	}

	public void GPBHKIHPLKC(float BDICHAELIJE)
	{
		audioMixer.SetFloat("EnableRankedNotificationsToggle", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("_ScreenResolution", BDICHAELIJE);
	}

	public float MAMLBFKENPP()
	{
		float value = 1417f;
		audioMixer.GetFloat("PerfectHitsScoreText", out value);
		return PKCCBAOJKAC(value);
	}

	public void EMFDCOELJGL(float BDICHAELIJE)
	{
		OPNPAGIJKGN(BDICHAELIJE);
		PKBPADHIDLC(BDICHAELIJE);
	}

	public void MANHJLDFNNM(float BDICHAELIJE)
	{
		audioMixer.SetFloat("/../", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_FixDistance", BDICHAELIJE);
	}

	public float FAPMCGJAGAI()
	{
		float value = 1894f;
		audioMixer.GetFloat("CameraFilterPack/Blur_Noise", out value);
		return HFDCOHFNDIP(value);
	}

	public float DNOMHNHDFEB()
	{
		float value = 1404f;
		audioMixer.GetFloat("_ScreenResolution", out value);
		return DbToNormal(value);
	}

	public float AFIFPMJFFIM()
	{
		float value = 563f;
		audioMixer.GetFloat("_Value", out value);
		return PKCCBAOJKAC(value);
	}

	public void PDHKMDBNGGN()
	{
		StartCoroutine(BCGPAFDDNJC());
	}

	public void LCGIPBONGGG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_TimeX", KBLDPGBIJNE(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("#pleasewait", BDICHAELIJE);
	}

	public float PGMEEPKGJPJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(154f, HDAMKJKNKJI / 1005f);
	}

	public void EHIPKGEIPND(float BDICHAELIJE)
	{
		audioMixer.SetFloat("[Sound Manager] Audio clip is null, cannot play music", KBLDPGBIJNE(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("[RanksSystem] Map hash: ", BDICHAELIJE);
	}

	public float EEBIIBACMMD(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1658f, HDAMKJKNKJI / 820f);
	}

	public float IGBFLJBJJDN()
	{
		float value = 143f;
		audioMixer.GetFloat("_WaveIntensity", out value);
		return PIKONBBNLHK(value);
	}

	private IEnumerator FMLANACDKOM()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void JKFDDNMPOJH()
	{
		StartCoroutine(ILMFEHLGBGN());
	}

	public void GMGGEMBLGGO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("finished", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("_Value4", BDICHAELIJE);
	}

	public float FKKPAPNLLCK()
	{
		float value = 865f;
		audioMixer.GetFloat("_Value5", out value);
		return DGDCGHIDPJM(value);
	}

	public void HOBADLMLMPJ(float BDICHAELIJE)
	{
		audioMixer.SetFloat("PunRespawn", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("workshop.", BDICHAELIJE);
	}

	public void BMENGAELNLD(float BDICHAELIJE)
	{
		SetMenuVolume(BDICHAELIJE);
		DHDEGPLMNEL(BDICHAELIJE);
	}

	public void AFKIHBAJEKN(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Blend", IGDGALJHJPH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK(".lastCheckpoint.bgcolor", BDICHAELIJE);
	}

	public float GetMenuVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("menuVolume", out value);
		return DbToNormal(value);
	}

	public void ABEHEGIMFMO(float BDICHAELIJE)
	{
		IOOKAOKJIKL(BDICHAELIJE);
		DHDEGPLMNEL(BDICHAELIJE);
	}

	public void FDPBCPKNKNG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("shader.crispwinter", OLODCIGOIDD(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("[ERROR KEY {0}]", BDICHAELIJE);
	}

	public void AEOLJEIDMDB()
	{
		StartCoroutine(FMLANACDKOM());
	}

	public float GHBJGDEIBCI()
	{
		float value = 1912f;
		audioMixer.GetFloat("Cross", out value);
		return PGMEEPKGJPJ(value);
	}

	public void OKACFHNMHLB(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack/Blend2Camera_Overlay", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("Loading", BDICHAELIJE);
	}

	public void Start()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public float GLKNJLKHKOG()
	{
		float value = 1116f;
		audioMixer.GetFloat("Save Game", out value);
		return HFDCOHFNDIP(value);
	}

	public float DGDCGHIDPJM(float HDAMKJKNKJI)
	{
		return Mathf.Pow(648f, HDAMKJKNKJI / 1870f);
	}

	public float EPECMGDLOCP()
	{
		float value = 1735f;
		audioMixer.GetFloat("0.00", out value);
		return FJACGPIOMKA(value);
	}

	public void OJJHDKFHJFE(float BDICHAELIJE)
	{
		audioMixer.SetFloat("(from resources)", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("_ScreenResolution", BDICHAELIJE);
	}

	public float EGKFKIPCOEC(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1996f)) ? 1996f : (975f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float KGFKDAGPCHA()
	{
		float value = 1476f;
		audioMixer.GetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", out value);
		return HFDCOHFNDIP(value);
	}

	public float NBAOJJLMDDB()
	{
		float value = 930f;
		audioMixer.GetFloat("maps.", out value);
		return PKCCBAOJKAC(value);
	}

	private IEnumerator BCGPAFDDNJC()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public void GGIMFCFEBNE(float BDICHAELIJE)
	{
		audioMixer.SetFloat("/", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("player.orangearc", BDICHAELIJE);
	}

	public float IBMFLILENHN()
	{
		float value = 1759f;
		audioMixer.GetFloat("_ScreenResolution", out value);
		return FJACGPIOMKA(value);
	}

	public float JBFDBFEBFCP()
	{
		float value = 1692f;
		audioMixer.GetFloat("Anomaly_With_Obj", out value);
		return DbToNormal(value);
	}

	public void EMGHEEBFOMH(float BDICHAELIJE)
	{
		audioMixer.SetFloat("/icon", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("CameraFilterPack/Glasses_On", BDICHAELIJE);
	}

	public void AMIPMCAJEKJ(float BDICHAELIJE)
	{
		OJGNDFLDJKN(BDICHAELIJE);
		HCJJPADNGMK(BDICHAELIJE);
	}

	public void FCIHOEHAFMD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("#timeuntilchallenge: ", BCJBLCHOECO(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("{0:x2}", BDICHAELIJE);
	}

	public float DAFBKPBKCFI(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 942f)) ? 484f : (361f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float JHBPPKNEECH()
	{
		float value = 694f;
		audioMixer.GetFloat("Value", out value);
		return ECMKDDLIHJM(value);
	}

	public void PIIFMOBCJBO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_MainTex2", OLODCIGOIDD(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", BDICHAELIJE);
	}

	public void SetMenuVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("menuVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.menu", BDICHAELIJE);
	}

	public void NIMKHFOKLMD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_TimeX", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("RemoveEnvironmentObject", BDICHAELIJE);
	}

	public void CKKOBPJPHKK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("#91CCFF", BCJBLCHOECO(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("#yes", BDICHAELIJE);
	}

	public void MJCGPKBKDKM(float BDICHAELIJE)
	{
		FDPBCPKNKNG(BDICHAELIJE);
		PKBPADHIDLC(BDICHAELIJE);
	}

	public void BNDJLDOFECP(float BDICHAELIJE)
	{
		audioMixer.SetFloat("[Left]", LLJAJLMOMNB(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_History1Weight", BDICHAELIJE);
	}

	public float OHIBFDHKNHP()
	{
		float value = 1693f;
		audioMixer.GetFloat("The shader ", out value);
		return ECMKDDLIHJM(value);
	}

	public void NKFDNIAKGEO()
	{
		StartCoroutine(GIBBHOLJBHH());
	}

	public float JCCFOJMKHHJ()
	{
		float value = 1828f;
		audioMixer.GetFloat(";", out value);
		return EBBJJELFHHK(value);
	}

	public float KOFOMELMOGK()
	{
		float value = 210f;
		audioMixer.GetFloat("ws://", out value);
		return DbToNormal(value);
	}

	public void AJJBKKCOIFC(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Tab1Content", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("mapselector.lastSearch", BDICHAELIJE);
	}

	public float LLJAJLMOMNB(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 736f)) ? 1293f : (410f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float ODHJEDHMLDI()
	{
		float value = 780f;
		audioMixer.GetFloat("https://twitch.tv/intralism", out value);
		return PKCCBAOJKAC(value);
	}

	public void SetEditorVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("editorVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.editor", BDICHAELIJE);
	}

	public float GetSfxVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("sfxVolume", out value);
		return DbToNormal(value);
	}

	public void BJFCGPANMAF(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Exponent", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("CameraFilterPack_Atmosphere_Rain_FX", BDICHAELIJE);
	}

	public void MLAFBJOIGDB(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Value", LLJAJLMOMNB(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("???", BDICHAELIJE);
	}

	public void BGDPIHMAACO()
	{
		StartCoroutine(BCDOFHNGBAP());
	}

	public float ELLCJMHOIHI()
	{
		float value = 907f;
		audioMixer.GetFloat("SendVacantViewIds()", out value);
		return PKCCBAOJKAC(value);
	}

	public void FBPHNEJBDJN()
	{
		StartCoroutine(ILMFEHLGBGN());
	}

	public void DHDEGPLMNEL(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_HueShift", EGKFKIPCOEC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("Hex value #RRGGBB", BDICHAELIJE);
	}

	public float MMMPHLEPEKE()
	{
		float value = 420f;
		audioMixer.GetFloat("_MainTex2", out value);
		return PKCCBAOJKAC(value);
	}

	public float NPGMCPHPPDM(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 15f)) ? 955f : (455f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void FBACNAMHPBB(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_ScreenResolution", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("Switch environment sprite image", BDICHAELIJE);
	}

	public void HKHHGEDGNDM(float BDICHAELIJE)
	{
		FBACNAMHPBB(BDICHAELIJE);
		MLAFBJOIGDB(BDICHAELIJE);
	}

	public float IGDGALJHJPH(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1059f)) ? 910f : (1963f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void GFGALPLDALF(float BDICHAELIJE)
	{
		audioMixer.SetFloat("SetCrosshairEmission", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("PunRespawn", BDICHAELIJE);
	}

	public void KLHHLEHPNJJ(float BDICHAELIJE)
	{
		AFEGNCKMAOJ(BDICHAELIJE);
		PKBPADHIDLC(BDICHAELIJE);
	}

	public void PKBPADHIDLC(float BDICHAELIJE)
	{
		audioMixer.SetFloat("G:", IGDGALJHJPH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("_TimeX", BDICHAELIJE);
	}

	public void BEIINJCGDOB(float BDICHAELIJE)
	{
		BNDJLDOFECP(BDICHAELIJE);
		GPBHKIHPLKC(BDICHAELIJE);
	}

	public float GBBINJDELCA()
	{
		float value = 987f;
		audioMixer.GetFloat("_MainTex2", out value);
		return DbToNormal(value);
	}

	public void AEMGPJDJGBJ()
	{
		StartCoroutine(HIDJLJMHGND());
	}

	public void GPNAOAKCMHC()
	{
		StartCoroutine(IAIAPPPLMPA());
	}

	public float ECMKDDLIHJM(float HDAMKJKNKJI)
	{
		return Mathf.Pow(381f, HDAMKJKNKJI / 1951f);
	}

	public float OMLJMHPPBPD()
	{
		float value = 1114f;
		audioMixer.GetFloat("event", out value);
		return PIKONBBNLHK(value);
	}

	public float CDBGJPLENND()
	{
		float value = 270f;
		audioMixer.GetFloat("Object ID. Case-Sensitive", out value);
		return FJACGPIOMKA(value);
	}

	public void HPILGNAEANG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Fade", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("_Red_C", BDICHAELIJE);
	}

	public void OPNPAGIJKGN(float BDICHAELIJE)
	{
		audioMixer.SetFloat("SendVacantViewIds()", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("{0}_{1}", BDICHAELIJE);
	}

	public void MOJGMIEBEOG(float BDICHAELIJE)
	{
		audioMixer.SetFloat("settings.enablehitsoundsinnormal", OLODCIGOIDD(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("IconImage", BDICHAELIJE);
	}

	public float KBFDPLGJNPH(float HDAMKJKNKJI)
	{
		return Mathf.Pow(887f, HDAMKJKNKJI / 550f);
	}

	public void DOMPOBIAJJC(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_MatrixColor", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat(" not exist", BDICHAELIJE);
	}

	public void FLCCBHKHPHK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("CameraFilterPack/AAA_Super_Computer", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("???", BDICHAELIJE);
	}

	public void AOGHMPPBEOD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("Create failed on GameServer. Changing back to MasterServer. Msg: ", NPGMCPHPPDM(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(": ", BDICHAELIJE);
	}

	public float PIKONBBNLHK(float HDAMKJKNKJI)
	{
		return Mathf.Pow(545f, HDAMKJKNKJI / 1869f);
	}

	public float PKCCBAOJKAC(float HDAMKJKNKJI)
	{
		return Mathf.Pow(151f, HDAMKJKNKJI / 909f);
	}

	public void IMCKJCHKMKB()
	{
		StartCoroutine(JEJLPJJOIIH());
	}

	public float IBGANHIKFKE()
	{
		float value = 45f;
		audioMixer.GetFloat("offsets", out value);
		return PIKONBBNLHK(value);
	}

	public float LCLDAAHFHCM()
	{
		float value = 1360f;
		audioMixer.GetFloat("_Far", out value);
		return HFDCOHFNDIP(value);
	}

	public float KCCKCCNNCJP()
	{
		float value = 1853f;
		audioMixer.GetFloat("[MenuScene] Error: ", out value);
		return ECMKDDLIHJM(value);
	}

	public float FJACGPIOMKA(float HDAMKJKNKJI)
	{
		return Mathf.Pow(394f, HDAMKJKNKJI / 1102f);
	}

	public void FHDKDOAAEOO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Color", IGDGALJHJPH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", BDICHAELIJE);
	}

	public float OGJBEMCIOBM()
	{
		float value = 707f;
		audioMixer.GetFloat("Data/Localization", out value);
		return PGMEEPKGJPJ(value);
	}

	private IEnumerator GIBBHOLJBHH()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public float PLGDJIOOGLD()
	{
		float value = 1145f;
		audioMixer.GetFloat("maps.", out value);
		return EEBIIBACMMD(value);
	}

	public float LJCACPGFHCM()
	{
		float value = 640f;
		audioMixer.GetFloat("_ScratchOffsetScale", out value);
		return PGMEEPKGJPJ(value);
	}

	public void JKBMKPDGCHG()
	{
		StartCoroutine(HIDJLJMHGND());
	}

	public float GetEditorVolume()
	{
		float value = 0f;
		audioMixer.GetFloat("editorVolume", out value);
		return DbToNormal(value);
	}

	public void EHIJJLAILMO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_BlurArea", DAFBKPBKCFI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("inventory.selected.", BDICHAELIJE);
	}

	public void FMFNILJIEIA()
	{
		StartCoroutine(FMLANACDKOM());
	}

	public float KBLDPGBIJNE(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 553f)) ? 698f : (1567f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float DHPPAPNINIM()
	{
		float value = 872f;
		audioMixer.GetFloat("[Right]", out value);
		return KBFDPLGJNPH(value);
	}

	public float HFDCOHFNDIP(float HDAMKJKNKJI)
	{
		return Mathf.Pow(538f, HDAMKJKNKJI / 1759f);
	}

	public void FLJGCHDJFLO(float BDICHAELIJE)
	{
		audioMixer.SetFloat("maps.", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("PerfectHitsScoreText", BDICHAELIJE);
	}

	public float IFPFFOHCAGB()
	{
		float value = 1869f;
		audioMixer.GetFloat(".mp3", out value);
		return EEBIIBACMMD(value);
	}

	public float LBOFCKDMOOF()
	{
		float value = 353f;
		audioMixer.GetFloat("_TimeX", out value);
		return DGDCGHIDPJM(value);
	}

	public float BCJBLCHOECO(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 1298f)) ? 397f : (1765f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float ABKGDNMBAMH(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 34f)) ? 1026f : (1448f * Mathf.Log10(JCLIHOKDOHN));
	}

	public float DAEGGEFMHFL()
	{
		float value = 1021f;
		audioMixer.GetFloat("Bad parameters for setbool! Use <key> <value>", out value);
		return FJACGPIOMKA(value);
	}

	public void SetGameVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("gameVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.game", BDICHAELIJE);
	}

	public float KBCGCFKFHOO()
	{
		float value = 377f;
		audioMixer.GetFloat("_Color", out value);
		return KBFDPLGJNPH(value);
	}

	public float MJNGJOBGKCA()
	{
		float value = 89f;
		audioMixer.GetFloat("NewIconFileSelector", out value);
		return PIKONBBNLHK(value);
	}

	public float LIGHOLIOELK()
	{
		float value = 747f;
		audioMixer.GetFloat("(singleton) ", out value);
		return PKCCBAOJKAC(value);
	}

	private IEnumerator HIDJLJMHGND()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public float OLODCIGOIDD(float JCLIHOKDOHN)
	{
		return (!(JCLIHOKDOHN > 512f)) ? 559f : (1525f * Mathf.Log10(JCLIHOKDOHN));
	}

	public void SetSfxVolume(float BDICHAELIJE)
	{
		audioMixer.SetFloat("sfxVolume", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.sfx", BDICHAELIJE);
	}

	public void NHHDJPHCIKD(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_Value2", IFPBEHINCMK(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO("move", BDICHAELIJE);
	}

	public void EBKNJONKHCF(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_PColor2", EGKFKIPCOEC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_Value", BDICHAELIJE);
	}

	public void OACFNMGGNHM(float BDICHAELIJE)
	{
		HFFMDEDDGDA(BDICHAELIJE);
		HCJJPADNGMK(BDICHAELIJE);
	}

	public void FHHAEPECMMB(float BDICHAELIJE)
	{
		OJGNDFLDJKN(BDICHAELIJE);
		KALAMGBPMMG(BDICHAELIJE);
	}

	public float LJCGNPADHBC()
	{
		float value = 116f;
		audioMixer.GetFloat("shader.invert", out value);
		return ECMKDDLIHJM(value);
	}

	public void LJHBKFPANBA(float BDICHAELIJE)
	{
		audioMixer.SetFloat("LeaderboardsButton", LLJAJLMOMNB(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", BDICHAELIJE);
	}

	public void OJGNDFLDJKN(float BDICHAELIJE)
	{
		audioMixer.SetFloat("_ScreenResolution", NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("Items/", BDICHAELIJE);
	}

	public void HCJJPADNGMK(float BDICHAELIJE)
	{
		audioMixer.SetFloat("NOISE", OLODCIGOIDD(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("finished", BDICHAELIJE);
	}

	public void MJEFMIPLFAB()
	{
		StartCoroutine(BNIIKPCKCPC());
	}

	public void IONAKEGDJKG(float BDICHAELIJE)
	{
		audioMixer.SetFloat(" - {0}", EGKFKIPCOEC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("[MapsData] Found ", BDICHAELIJE);
	}

	public void AFEGNCKMAOJ(float BDICHAELIJE)
	{
		audioMixer.SetFloat("VisionBlur", IGDGALJHJPH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("bad", BDICHAELIJE);
	}

	public float HKGCBGFCCAE()
	{
		float value = 555f;
		audioMixer.GetFloat("y", out value);
		return PIKONBBNLHK(value);
	}

	public float IIILDEACBMF()
	{
		float value = 537f;
		audioMixer.GetFloat(",", out value);
		return FJACGPIOMKA(value);
	}

	private IEnumerator IAIAPPPLMPA()
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded);
		SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f));
		SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f));
		SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f));
		SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f));
	}

	public float KADMKHECCJE()
	{
		float value = 612f;
		audioMixer.GetFloat("_Distance", out value);
		return DGDCGHIDPJM(value);
	}

	public float AKMMGLIKHKJ()
	{
		float value = 1678f;
		audioMixer.GetFloat("_TimeX", out value);
		return PGMEEPKGJPJ(value);
	}

	public float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	public float DONCGHJMJCC()
	{
		float value = 1171f;
		audioMixer.GetFloat("_Speed", out value);
		return PGMEEPKGJPJ(value);
	}

	public float EBBJJELFHHK(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1026f, HDAMKJKNKJI / 595f);
	}

	public float GNPPEOGGLFE()
	{
		float value = 1600f;
		audioMixer.GetFloat("turn: {0:0}", out value);
		return HFDCOHFNDIP(value);
	}

	public float JCCPCKOPAGP()
	{
		float value = 1632f;
		audioMixer.GetFloat("resource", out value);
		return DbToNormal(value);
	}
}
