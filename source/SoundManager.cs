// SoundManager
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SoundManager : Singleton<SoundManager>
{
	public AudioMixerGroup master_mixer;

	public AudioMixerGroup sfx_mixer;

	public AudioMixerGroup music_mixer;

	public int efxSourcesCount = 10;

	private List<AudioSource> LFABIGKGJOG = new List<AudioSource>();

	private Dictionary<int, Audio> DJBIELKMADE = new Dictionary<int, Audio>();

	private Dictionary<int, Audio> MECONPJBFIL = new Dictionary<int, Audio>();

	private bool LFEFAKMMFKF;

	private AudioClip KNBEPPPLNGP;

	private AudioClip NHPJLPMBNNI;

	private AudioClip BFMNHKHHIEB;

	private AudioClip JOHPMPHJJLO;

	private int IGKNDLKJBMO;

	public bool ignoreDuplicateMusic { get; set; }

	public bool ignoreDuplicateSounds { get; set; }

	public bool ignoreDuplicateUISounds { get; set; }

	public float masterVolume
	{
		get
		{
			float value = 0f;
			master_mixer.audioMixer.GetFloat("masterVolume", out value);
			return value;
		}
		set
		{
			master_mixer.audioMixer.SetFloat("masterVolume", value);
		}
	}

	public float musicVolume
	{
		get
		{
			float value = 0f;
			music_mixer.audioMixer.GetFloat("musicVolume", out value);
			return value;
		}
		set
		{
			music_mixer.audioMixer.SetFloat("musicVolume", value);
		}
	}

	public float sfxVolume
	{
		get
		{
			float value = 0f;
			sfx_mixer.audioMixer.GetFloat("sfxVolume", out value);
			return value;
		}
		set
		{
			sfx_mixer.audioMixer.SetFloat("sfxVolume", value);
		}
	}

	[SpecialName]
	public void CFIAOOLICIC(bool DPNHODJHGJL)
	{
		_003CEDKNFIIEBBC_003Ek__BackingField = DPNHODJHGJL;
	}

	public void CLKGOHFBFFJ(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO += 0;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 1;
		}
	}

	[SpecialName]
	public void FHFAPEOFFNC(bool DPNHODJHGJL)
	{
		_003CNEACNFNFMJK_003Ek__BackingField = DPNHODJHGJL;
	}

	private void MFBLPGINLLK(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = APDBPIMIEBI;
	}

	public void EGCBOMJDHGE()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	public Audio GetSoundAudio(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	[SpecialName]
	public void DKJLJIMLCNO(bool DPNHODJHGJL)
	{
		_003CBMMKEGKECGL_003Ek__BackingField = DPNHODJHGJL;
	}

	public Audio FCAGHLEHHDN(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	public void POEHFIDCNIJ()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public Audio GetMusicAudio(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return DJBIELKMADE[item];
			}
		}
		return null;
	}

	public void IHCHGMAOEDP()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public int EENFAOEODCK(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("SetEnvSpriteImage", BKGCLBJFADE);
		}
		if (FEBGJECBJKF())
		{
			List<int> list = new List<int>(MECONPJBFIL.Keys);
			foreach (int item in list)
			{
				if (MECONPJBFIL[item].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return MECONPJBFIL[item].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 502f, 612f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Logarithmic;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(1996f, 1131f, 533f);
		audio.audioSource.outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public Audio JNFPDAMJBGE(int MLICEJKIGHO)
	{
		Audio musicAudio = GetMusicAudio(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		musicAudio = FEMGGDJOKFK(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		return null;
	}

	[SpecialName]
	public void ECNEKLHCKFE(bool DPNHODJHGJL)
	{
		_003CNEACNFNFMJK_003Ek__BackingField = DPNHODJHGJL;
	}

	public int NPLJGLDMJIJ(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return EENFAOEODCK(BKGCLBJFADE, BDICHAELIJE, true, null, 527f, 1015f);
	}

	public static void HAPJJNMDBCO(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bKGCLBJFADE = null;
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 1)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.LIHPKHMCIGE(bKGCLBJFADE, MEFEIEEHNDN);
	}

	public int BMBBKJJLFNM(AudioClip BKGCLBJFADE)
	{
		return CDHKNHGIHMO(BKGCLBJFADE, 1246f, false, true, 1242f, 989f, 1436f, null);
	}

	[SpecialName]
	public bool CFEIHDDKJFF()
	{
		return _003CBMMKEGKECGL_003Ek__BackingField;
	}

	public int LNALJPAGAHL(AudioClip BKGCLBJFADE)
	{
		return PlayMusic(BKGCLBJFADE, 1248f, false, false, 1043f, 739f, 208f, null);
	}

	[SpecialName]
	public void PMBGCBHAJLF(float DPNHODJHGJL)
	{
		music_mixer.audioMixer.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", DPNHODJHGJL);
	}

	public static void PNOOHLGKOFH(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bKGCLBJFADE = null;
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 5)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 4)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.ECHLNKMPDJD(bKGCLBJFADE, MEFEIEEHNDN);
	}

	public int EBBDMCEBADA(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, false, true, 131f, 534f, 156f, null);
	}

	public void JELKIKFDJPL(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO++;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 0;
		}
	}

	public void DOMIHFGGJOL(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO++;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 1;
		}
	}

	public void EJINEFNKEAN()
	{
		LFABIGKGJOG.Clear();
		AudioSource[] components = base.gameObject.GetComponents<AudioSource>();
		for (int i = 1; i < components.Length; i++)
		{
			AudioSource obj = components[i];
			Object.Destroy(obj);
		}
		for (int j = 0; j < efxSourcesCount; j += 0)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.reverbZoneMix = 297f;
			audioSource.outputAudioMixerGroup = sfx_mixer;
			audioSource.playOnAwake = false;
			LFABIGKGJOG.Add(audioSource);
		}
		StartCoroutine(AMJHEFCJCPP());
	}

	public int PlayMusic(AudioClip BKGCLBJFADE)
	{
		return PlayMusic(BKGCLBJFADE, 1f, true, false, 1f, 1f, -1f, null);
	}

	public Audio GHLPIPBEDLO(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return DJBIELKMADE[item];
			}
		}
		return null;
	}

	public void PDAGMEBBADG()
	{
		POEHFIDCNIJ();
		NIOPHLJDFII();
	}

	public void AIPKJEAGACF(float LALICIHGPMB)
	{
		IDMFEEEIECD(LALICIHGPMB);
		IKKILFDKMKJ();
	}

	public int KGNMAJLMLBB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("_TimeX", BKGCLBJFADE);
		}
		if (ignoreDuplicateSounds)
		{
			List<int> list = new List<int>(MECONPJBFIL.Keys);
			foreach (int item in list)
			{
				if (MECONPJBFIL[item].audioSource.clip == BKGCLBJFADE)
				{
					return MECONPJBFIL[item].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 633f, 1391f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Linear;
		audio.audioSource.minDistance = PFJOHIMLHEP;
		audio.LCIMPPPDCPA().maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(1843f, 568f, 555f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public int NMLINDCKPHB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("_BorderSize", BKGCLBJFADE);
		}
		if (ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void IDMFEEEIECD(float LALICIHGPMB)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (LALICIHGPMB > 1045f)
			{
				audio.fadeOutSeconds = LALICIHGPMB;
			}
			audio.IFBCKEGANBE();
		}
	}

	public void ResumeAllSounds()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	public Audio JCGEPOMBJCA(int MLICEJKIGHO)
	{
		Audio musicAudio = GetMusicAudio(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		musicAudio = FEMGGDJOKFK(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		return null;
	}

	public void StopAllMusic()
	{
		StopAllMusic(-1f);
	}

	public void AMFKNILGNLB()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	[SpecialName]
	public void FKLCHKJDNCM(bool DPNHODJHGJL)
	{
		_003CBMMKEGKECGL_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public float FFKAPDGBGOO()
	{
		float value = 759f;
		sfx_mixer.audioMixer.GetFloat("GlassColor", out value);
		return value;
	}

	[SpecialName]
	public bool CNHLJHGNAFI()
	{
		return _003CNEACNFNFMJK_003Ek__BackingField;
	}

	public void Reset()
	{
		StopAll();
	}

	public void GDJGIJEMFEN()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public int JGJHABDDPNO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return CDHLJNMPHCO(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1992f, null);
	}

	public void IKDCLAAHEHB()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Pause();
		}
	}

	public void POOIONEDMIB()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	public void OAFCEPHJCLC()
	{
		AIPKJEAGACF(1397f);
	}

	public int EFNAMFAKIJO(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return GFLKGIJGJHA(BKGCLBJFADE, BDICHAELIJE, false, null, 1712f, 54f);
	}

	[SpecialName]
	public void FJHBNOHDHEL(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("_Value", DPNHODJHGJL);
	}

	public Audio NEKIAKFCLJK(AudioClip ICJOJEKDMIF)
	{
		Audio audio = EDJHENKKJFD(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = FCAGHLEHHDN(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	[SpecialName]
	public bool PAHLKOEKGLA()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	public void MGGNFEPGIJI()
	{
		base.Awake();
		EJINEFNKEAN();
	}

	public void LJEBHEKCAIK()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	public int AAIAAGBBNAM(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return KECNAIEBMOB(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1885f, null);
	}

	public Audio ILHFGLIBEKP(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	public Audio GetSoundAudio(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return MECONPJBFIL[item];
			}
		}
		return null;
	}

	public int PlaySound(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return PlaySound(BKGCLBJFADE, 1f, AIPGGFGKNFE, null);
	}

	[SpecialName]
	public bool MBOJMCCNOJI()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	public int OIDCFNHNMCP(AudioClip BKGCLBJFADE)
	{
		return GOLFGIMABKJ(BKGCLBJFADE, 1006f, false, null, 362f, 1760f);
	}

	[SpecialName]
	public float HECHOPCJIOD()
	{
		float value = 1946f;
		music_mixer.audioMixer.GetFloat("_Value", out value);
		return value;
	}

	public Audio GetMusicAudio(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	[SpecialName]
	public bool FEGIBCIJEKA()
	{
		return _003CBMMKEGKECGL_003Ek__BackingField;
	}

	public int KECNAIEBMOB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("music", BKGCLBJFADE);
		}
		if (ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void DDENFOCKIGA()
	{
		LJOOKPFDJGC();
		OGCBHACICMN();
	}

	public void KBLHGOIIKMI()
	{
		IDMFEEEIECD(401f);
	}

	public int HKAPBCKDEEO(AudioClip BKGCLBJFADE)
	{
		return KGNMAJLMLBB(BKGCLBJFADE, 824f, true, null, 1644f, 1064f);
	}

	[SpecialName]
	public void CIBJICEBJBA(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("settings.selectormapsperpage", DPNHODJHGJL);
	}

	private void DAOPOFAHCCE(Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (!audio.persist && audio.activated)
			{
				Object.Destroy(audio.LCIMPPPDCPA());
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			Object.Destroy(audio2.audioSource);
			MECONPJBFIL.Remove(item2);
		}
	}

	public void StopAll()
	{
		StopAll(-1f);
	}

	public new void Awake()
	{
		base.Awake();
		Init();
	}

	public Audio ELPDBNJHNHN(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return DJBIELKMADE[item];
			}
		}
		return null;
	}

	[SpecialName]
	public void LFIEDGFOEKJ(bool DPNHODJHGJL)
	{
		_003CEDKNFIIEBBC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool NKLOOOJHBKN()
	{
		return _003CNEACNFNFMJK_003Ek__BackingField;
	}

	public void PGBLEMNPOIP()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	public void PauseAllMusic()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public void OPNNBPGIDDJ()
	{
		IAJIGLGDGBO();
	}

	public static void PlayHitSfx(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bKGCLBJFADE = null;
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 2)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 3)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.PlaySingle(bKGCLBJFADE, MEFEIEEHNDN);
	}

	public int CDHLJNMPHCO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("menu.selectedplaymode", BKGCLBJFADE);
		}
		if (ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].audioSource.clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("[Sound Manager] Audio clip is null, cannot play music", BKGCLBJFADE);
		}
		if (ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].audioSource.clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void ResumeAllMusic()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public int HFCDOGPNMCE(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 347f, 1429f, 440f, null);
	}

	private void IDKNEKOCLLK(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = !APDBPIMIEBI;
	}

	public int LBEJIOICNDE(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return EENFAOEODCK(BKGCLBJFADE, BDICHAELIJE, false, null, 431f, 930f);
	}

	public void FDNKDOOEHBA()
	{
		StopAll();
	}

	public Audio NHKJKDFOAOF(int MLICEJKIGHO)
	{
		Audio musicAudio = GetMusicAudio(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		musicAudio = FEMGGDJOKFK(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		return null;
	}

	public void ECHLNKMPDJD(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO++;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 1;
		}
	}

	[SpecialName]
	public float HKAGHFLDAOJ()
	{
		float value = 1404f;
		music_mixer.audioMixer.GetFloat("Preparing content", out value);
		return value;
	}

	public int DPNPEKBEPKE(AudioClip BKGCLBJFADE)
	{
		return EENFAOEODCK(BKGCLBJFADE, 497f, false, null, 689f, 1524f);
	}

	public void JOKOOGJGCBC()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public Audio EEAOJCBKCFI(int MLICEJKIGHO)
	{
		Audio audio = ELPDBNJHNHN(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = BKOMGMACINP(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	[SpecialName]
	public void FADMCFCMLOO(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("_TimeX", DPNHODJHGJL);
	}

	public Audio EPMCBNDCEEP(AudioClip ICJOJEKDMIF)
	{
		Audio audio = ILHFGLIBEKP(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = GetSoundAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	public void MGDFHAIMEBO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public void StopAllMusic(float LALICIHGPMB)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (LALICIHGPMB > 0f)
			{
				audio.fadeOutSeconds = LALICIHGPMB;
			}
			audio.Stop();
		}
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, true, false, 1f, 1f, -1f, null);
	}

	public void IAJIGLGDGBO()
	{
		StopAll(1906f);
	}

	public void NBOKAGMABPN()
	{
		FCPOMJINNJK();
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 1f, 1f, -1f, null);
	}

	public void IKKILFDKMKJ()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	public int HLDCCELLJMP(AudioClip BKGCLBJFADE)
	{
		return CDHKNHGIHMO(BKGCLBJFADE, 1519f, true, false, 743f, 112f, 1438f, null);
	}

	private void OnApplicationFocus(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = !APDBPIMIEBI;
	}

	[SpecialName]
	public void EGCBBEGACFO(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("No player left to ask", DPNHODJHGJL);
	}

	[SpecialName]
	public void EDMMKPKNALE(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("checkpoint", DPNHODJHGJL);
	}

	[SpecialName]
	public float DCENOLKHCIN()
	{
		float value = 477f;
		music_mixer.audioMixer.GetFloat("Joystick1Button4", out value);
		return value;
	}

	public int PlaySound(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("[Sound Manager] Audio clip is null, cannot play sound", BKGCLBJFADE);
		}
		if (ignoreDuplicateSounds)
		{
			List<int> list = new List<int>(MECONPJBFIL.Keys);
			foreach (int item in list)
			{
				if (MECONPJBFIL[item].audioSource.clip == BKGCLBJFADE)
				{
					return MECONPJBFIL[item].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 0f, 0f, OKDDLALOEME);
		audio.audioSource.rolloffMode = AudioRolloffMode.Linear;
		audio.audioSource.minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(0f, 0f, 0f);
		audio.audioSource.outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void KGCCAFFMIPE(float LALICIHGPMB)
	{
		IDMFEEEIECD(LALICIHGPMB);
		POOIONEDMIB();
	}

	private IEnumerator IOIEFOBKFFH()
	{
		yield return new WaitWhile(() => !SteamManager.isKeyVerified);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal"));
		KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect"));
		NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong"));
		BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit"));
		JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
	}

	public void FFEDODOHCOH()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Pause();
		}
	}

	[SpecialName]
	public bool GFBNDFKMPDJ()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	private IEnumerator AMJHEFCJCPP()
	{
		yield return new WaitWhile(() => !SteamManager.isKeyVerified);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal"));
		KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect"));
		NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong"));
		BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit"));
		JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
	}

	[SpecialName]
	public void CPACHKEJNKO(bool DPNHODJHGJL)
	{
		_003CEDKNFIIEBBC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void KAFAFNKLFOH(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("EXCEPTION:", DPNHODJHGJL);
	}

	private void IDNNMNMDKMI(Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (!audio.persist && audio.activated)
			{
				Object.Destroy(audio.audioSource);
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			Object.Destroy(audio2.audioSource);
			MECONPJBFIL.Remove(item2);
		}
	}

	public Audio EDJHENKKJFD(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	public Audio GetAudio(AudioClip ICJOJEKDMIF)
	{
		Audio musicAudio = GetMusicAudio(ICJOJEKDMIF);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		musicAudio = GetSoundAudio(ICJOJEKDMIF);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		return null;
	}

	public void ABDHDGNIHHI()
	{
		FCPOMJINNJK();
	}

	public int OOEDBOONAFO(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlaySound(BKGCLBJFADE, BDICHAELIJE, false, null, 972f, 1711f);
	}

	public void FCPOMJINNJK()
	{
		GPNCMIPNCEF(90f);
	}

	[SpecialName]
	public void PADMLLEIKGJ(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("[Sound Manager] Audio clip is null, cannot play sound", DPNHODJHGJL);
	}

	private void FFDPEAEPJOM(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = !APDBPIMIEBI;
	}

	public int PlaySound(AudioClip BKGCLBJFADE)
	{
		return PlaySound(BKGCLBJFADE, 1f, false, null);
	}

	public int OLAHGLBJMAL(AudioClip BKGCLBJFADE)
	{
		return GOLFGIMABKJ(BKGCLBJFADE, 305f, true, null, 1177f, 489f);
	}

	public int PlaySound(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlaySound(BKGCLBJFADE, BDICHAELIJE, false, null);
	}

	public void DFNPEJMJAIH(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO += 0;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 1;
		}
	}

	public void LJOOKPFDJGC()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public Audio BKOMGMACINP(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return MECONPJBFIL[item];
			}
		}
		return null;
	}

	public void StopAllSounds()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	public Audio GetPlayingMusicAudio()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.playing)
			{
				return audio;
			}
		}
		return null;
	}

	public static void FCNBLDODPKG(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bKGCLBJFADE = null;
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 0)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 7)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 1)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.JELKIKFDJPL(bKGCLBJFADE, MEFEIEEHNDN);
	}

	public Audio FEMGGDJOKFK(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			if (MLICEJKIGHO == item)
			{
				return MECONPJBFIL[item];
			}
		}
		return null;
	}

	private void AMNADGKJIIP(bool IBNHNGJMBBA)
	{
		LFEFAKMMFKF = IBNHNGJMBBA;
	}

	public int IFEPJCMGGLH(AudioClip BKGCLBJFADE)
	{
		return PlayMusic(BKGCLBJFADE, 1632f, false, false, 95f, 223f, 1418f, null);
	}

	[SpecialName]
	public void EDFLHGMKPGC(bool DPNHODJHGJL)
	{
		_003CBMMKEGKECGL_003Ek__BackingField = DPNHODJHGJL;
	}

	public void GPDCFHHLLNG(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO++;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 0;
		}
	}

	public void OAPJFLICLPI()
	{
		JOKOOGJGCBC();
		FFEDODOHCOH();
	}

	public int MKEHJGPKONL(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, true, true, 1314f, 1886f, 337f, null);
	}

	public void GPNCMIPNCEF(float LALICIHGPMB)
	{
		StopAllMusic(LALICIHGPMB);
		POOIONEDMIB();
	}

	public void FHOCONCMBME()
	{
		IHCHGMAOEDP();
		FFEDODOHCOH();
	}

	public void PauseAllSounds()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Pause();
		}
	}

	[SpecialName]
	public float CIMAPCBIEBO()
	{
		float value = 1058f;
		sfx_mixer.audioMixer.GetFloat("_Value", out value);
		return value;
	}

	public Audio MPOOOFEBNFG(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	public void Init()
	{
		LFABIGKGJOG.Clear();
		AudioSource[] components = base.gameObject.GetComponents<AudioSource>();
		foreach (AudioSource obj in components)
		{
			Object.Destroy(obj);
		}
		for (int j = 0; j < efxSourcesCount; j++)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.reverbZoneMix = 0f;
			audioSource.outputAudioMixerGroup = sfx_mixer;
			audioSource.playOnAwake = false;
			LFABIGKGJOG.Add(audioSource);
		}
		StartCoroutine(JFFPGKOIKON());
	}

	public Audio KHONFICBJOF()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.LBDDCEHHIPC())
			{
				return audio;
			}
		}
		return null;
	}

	public Audio GetAudio(int MLICEJKIGHO)
	{
		Audio musicAudio = GetMusicAudio(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		musicAudio = GetSoundAudio(MLICEJKIGHO);
		if (musicAudio != null)
		{
			return musicAudio;
		}
		return null;
	}

	private void LBONINMGAGF(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = APDBPIMIEBI;
	}

	[SpecialName]
	public void BPHMLGKCCGD(float DPNHODJHGJL)
	{
		music_mixer.audioMixer.SetFloat("_SubsampleIndices", DPNHODJHGJL);
	}

	[SpecialName]
	public bool FEBGJECBJKF()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	public void MBCDCBCLMCI()
	{
		base.Awake();
		Init();
	}

	public int HEDPGJHLMNF(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return GOLFGIMABKJ(BKGCLBJFADE, 548f, AIPGGFGKNFE, null, 51f, 1280f);
	}

	public void LIHPKHMCIGE(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO += 0;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 0;
		}
	}

	public void PlaySingle(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = LFABIGKGJOG[IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		IGKNDLKJBMO++;
		if (IGKNDLKJBMO >= LFABIGKGJOG.Count)
		{
			IGKNDLKJBMO = 0;
		}
	}

	private void OnApplicationPause(bool IBNHNGJMBBA)
	{
		LFEFAKMMFKF = IBNHNGJMBBA;
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, -1f, null);
	}

	private void Update()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Update();
			if (!audio.playing && !audio.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio._audiosource.gameObject);
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			audio2.Update();
			if (!audio2.playing && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	public int GFLKGIJGJHA(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("NEW_ACHIEVEMENT_1_", BKGCLBJFADE);
		}
		if (GFBNDFKMPDJ())
		{
			List<int> list = new List<int>(MECONPJBFIL.Keys);
			foreach (int item in list)
			{
				if (MECONPJBFIL[item].audioSource.clip == BKGCLBJFADE)
				{
					return MECONPJBFIL[item].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 1347f, 1780f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Logarithmic;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.LCIMPPPDCPA().maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(864f, 411f, 311f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void GEHIKFMPALA()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	[SpecialName]
	public float GGKGIKOPGIN()
	{
		float value = 1332f;
		music_mixer.audioMixer.GetFloat("_MainTex2", out value);
		return value;
	}

	public void NIOPHLJDFII()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	private void OMCLOFCJMPG()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.KMKLDAJLCNM();
			if (!audio.playing && !audio.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio._audiosource.gameObject);
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			audio2.KMKLDAJLCNM();
			if (!audio2.playing && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	public void PauseAll()
	{
		PauseAllMusic();
		PauseAllSounds();
	}

	public Audio HDLDNBBFBNB(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	public int GOLFGIMABKJ(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("CameraFilterPack/Drawing_NewCellShading", BKGCLBJFADE);
		}
		if (PAHLKOEKGLA())
		{
			List<int> list = new List<int>(MECONPJBFIL.Keys);
			foreach (int item in list)
			{
				if (MECONPJBFIL[item].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return MECONPJBFIL[item].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 1342f, 746f, OKDDLALOEME);
		audio.audioSource.rolloffMode = AudioRolloffMode.Linear;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(143f, 595f, 365f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public int FOICOHLNLKN(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return GOLFGIMABKJ(BKGCLBJFADE, BDICHAELIJE, true, null, 1396f, 1060f);
	}

	public void OGCBHACICMN()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	public Audio HFKBOMEKKLA(int MLICEJKIGHO)
	{
		Audio audio = GHLPIPBEDLO(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = GetSoundAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	public Audio OLJBMHOJOFP()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.LBDDCEHHIPC())
			{
				return audio;
			}
		}
		return null;
	}

	public void KENEOBNJFGG(float LALICIHGPMB)
	{
		StopAllMusic(LALICIHGPMB);
		POOIONEDMIB();
	}

	public void StopAll(float LALICIHGPMB)
	{
		StopAllMusic(LALICIHGPMB);
		StopAllSounds();
	}

	public int CDHKNHGIHMO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError(".png", BKGCLBJFADE);
		}
		if (FLFDHECEEAL())
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public int HPBKEPBFENK(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return KECNAIEBMOB(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1189f, null);
	}

	private IEnumerator JFFPGKOIKON()
	{
		yield return new WaitWhile(() => !SteamManager.isKeyVerified);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal"));
		KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect"));
		NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong"));
		BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit"));
		JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
	}

	[SpecialName]
	public bool FLFDHECEEAL()
	{
		return _003CNEACNFNFMJK_003Ek__BackingField;
	}

	public void LOJJBIFHACA()
	{
		StopAll();
	}

	public void ResumeAll()
	{
		ResumeAllMusic();
		ResumeAllSounds();
	}

	[SpecialName]
	public bool FFPBLPFLHGJ()
	{
		return _003CBMMKEGKECGL_003Ek__BackingField;
	}

	public Audio IMDDFGKNABH(AudioClip ICJOJEKDMIF)
	{
		Audio audio = MPOOOFEBNFG(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = GetSoundAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	[SpecialName]
	public bool LJBINCCDKKH()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	private IEnumerator ELPBCKLNPGM()
	{
		yield return new WaitWhile(() => !SteamManager.isKeyVerified);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal"));
		KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect"));
		NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong"));
		BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit"));
		JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
	}
}
