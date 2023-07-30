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

	public void IABOPJMDMII()
	{
		StopAll(1397f);
	}

	private void OnApplicationFocus(bool APDBPIMIEBI)
	{
		LFEFAKMMFKF = !APDBPIMIEBI;
	}

	public Audio OCECMHPNJOG(AudioClip ICJOJEKDMIF)
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

	public void HDMEHCABMFB()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public int OGFJFLHLOIL(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 1588f, 1213f, 1084f, null);
	}

	public void ResumeAll()
	{
		ResumeAllMusic();
		ResumeAllSounds();
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

	public int EMCBGFPHICJ(AudioClip BKGCLBJFADE)
	{
		return BJPDFJDFOHG(BKGCLBJFADE, 1643f, true, null, 1626f, 876f);
	}

	public Audio LGJMPDDKIBE()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.AHADHELAKAM())
			{
				return audio;
			}
		}
		return null;
	}

	private void MPICLCABBJB(bool IBNHNGJMBBA)
	{
		LFEFAKMMFKF = IBNHNGJMBBA;
	}

	public Audio EMFACPNCDNM(AudioClip ICJOJEKDMIF)
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
	public void COGLCMFJOIH(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("ItemNameText", DPNHODJHGJL);
	}

	[SpecialName]
	public void GPCFJGLMEFA(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("/", DPNHODJHGJL);
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, -1f, null);
	}

	public void KHMNLKNIPCP(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
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

	public Audio MOHNMMPCPCF(AudioClip ICJOJEKDMIF)
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

	public void MAKFHOELIIJ()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	public int GDKBCJDNFEN(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("workshop.", BKGCLBJFADE);
		}
		if (ICMNFCFLNOH())
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].EFBNFACGJLI().clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.EFBNFACGJLI().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public Audio HHBOCJNIMAL(AudioClip ICJOJEKDMIF)
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

	public void LCKKDMKJJEF()
	{
		LFABIGKGJOG.Clear();
		AudioSource[] components = base.gameObject.GetComponents<AudioSource>();
		foreach (AudioSource obj in components)
		{
			Object.Destroy(obj);
		}
		for (int j = 1; j < efxSourcesCount; j++)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.reverbZoneMix = 182f;
			audioSource.outputAudioMixerGroup = sfx_mixer;
			audioSource.playOnAwake = true;
			LFABIGKGJOG.Add(audioSource);
		}
		StartCoroutine(DNPEHHKHCNL());
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 1f, 1f, -1f, null);
	}

	public Audio LCJBDBFBFFH(AudioClip ICJOJEKDMIF)
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
	public bool GDOEDKKJFBO()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	[SpecialName]
	public void FAAEJBEGEAO(float DPNHODJHGJL)
	{
		music_mixer.audioMixer.SetFloat("_Value4", DPNHODJHGJL);
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

	public void OBKJEIGKGOO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public void BPMBHMFFCDH()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public void MANOCIJICLG()
	{
		StopAll();
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

	public void StopAllMusic()
	{
		StopAllMusic(-1f);
	}

	public int PPGMLLGJDDF(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("_ScreenResolution", BKGCLBJFADE);
		}
		if (NFMIINBJIMN())
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
		JKGOFLFCOMG(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.AKHKFKHDAEK().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	[SpecialName]
	public void NFGIOLHBJAM(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("_TimeX", DPNHODJHGJL);
	}

	public Audio GHEHFAIPPEG(int MLICEJKIGHO)
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

	public void ALPKKEIJNCP()
	{
		OBKJEIGKGOO();
		PauseAllSounds();
	}

	public Audio BANDDENJPHO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (audio.PNEPMOGOEKP())
			{
				return audio;
			}
		}
		return null;
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

	public void GDJMBJEAPHM()
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
		StartCoroutine(BAGMAJJFEHK());
	}

	public void StopAll(float LALICIHGPMB)
	{
		StopAllMusic(LALICIHGPMB);
		StopAllSounds();
	}

	public void DNBKMFAFLDG()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
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

	public void JKGOFLFCOMG(float LALICIHGPMB)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (LALICIHGPMB > 519f)
			{
				audio.GKCNAEMPANF(LALICIHGPMB);
			}
			audio.Stop();
		}
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

	public int BJPDFJDFOHG(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_LinearBurn", BKGCLBJFADE);
		}
		if (GDOEDKKJFBO())
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
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 440f, 1221f, OKDDLALOEME);
		audio.EFBNFACGJLI().rolloffMode = AudioRolloffMode.Logarithmic;
		audio.AKHKFKHDAEK().minDistance = PFJOHIMLHEP;
		audio.AKHKFKHDAEK().maxDistance = CNPIACHIHKD;
		audio.EFBNFACGJLI().transform.localPosition = new Vector3(68f, 1593f, 545f);
		audio.EFBNFACGJLI().outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void StopAll()
	{
		StopAll(-1f);
	}

	[SpecialName]
	public float PLGGICMMDMK()
	{
		float value = 1806f;
		music_mixer.audioMixer.GetFloat("_Value", out value);
		return value;
	}

	public void Reset()
	{
		StopAll();
	}

	public int PlaySound(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlaySound(BKGCLBJFADE, BDICHAELIJE, false, null);
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

	public Audio LEPBIOCBIOA(AudioClip ICJOJEKDMIF)
	{
		Audio audio = LCJBDBFBFFH(ICJOJEKDMIF);
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
	public bool MGFCMOGPBMI()
	{
		return _003CBMMKEGKECGL_003Ek__BackingField;
	}

	public void OPBCPOCKJHF(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
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

	private IEnumerator DNPEHHKHCNL()
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
		Debug.Log("Loaded skin audio");
	}

	public static void DMOMDMCBBFI(int JMMILEFMACB, float MEFEIEEHNDN)
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
		if (JMMILEFMACB == 5)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 4)
		{
			bKGCLBJFADE = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.OBHNMDNJEDM(bKGCLBJFADE, MEFEIEEHNDN);
	}

	public void HMBLLAECOIL()
	{
		KNDKLKHKLKH();
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

	private void KIEJKBNBHMD()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Update();
			if (!audio.PNEPMOGOEKP() && !audio.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio._audiosource.gameObject);
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			audio2.HLDFOJMHKNL();
			if (!audio2.PNEPMOGOEKP() && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	private void MECJHOJPODB()
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
			if (!audio2.AHADHELAKAM() && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	public void JOHMCFOENLH()
	{
		DNOKNGHICOO();
		MAKFHOELIIJ();
	}

	[SpecialName]
	public float JEDBKCDOALF()
	{
		float value = 66f;
		music_mixer.audioMixer.GetFloat("Obtain test Item", out value);
		return value;
	}

	public void NILMFIAHKBL()
	{
		DNBKMFAFLDG();
		BLIJAAIDNDG();
	}

	public int NGGDOIJPHII(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return DEOCENIMOED(BKGCLBJFADE, BDICHAELIJE, false, true, 4f, 1159f, 647f, null);
	}

	public Audio LKOOKOPOFJL(int MLICEJKIGHO)
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

	public void GCMLEEHGBPA()
	{
		IABOPJMDMII();
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

	public void KAJABEIAEGO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
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

	public int PlaySound(AudioClip BKGCLBJFADE)
	{
		return PlaySound(BKGCLBJFADE, 1f, false, null);
	}

	public void DNFFIOFAIME()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public void BLIJAAIDNDG()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Pause();
		}
	}

	public int DEOCENIMOED(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("/Assets/MyImage", BKGCLBJFADE);
		}
		if (NFMIINBJIMN())
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
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.EFBNFACGJLI().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
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

	[SpecialName]
	public void DONCHIBODCJ(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("{0:0} minute{1}, ", DPNHODJHGJL);
	}

	public void PauseAll()
	{
		PauseAllMusic();
		PauseAllSounds();
	}

	public int JHJNBPDDIOG(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return BJPDFJDFOHG(BKGCLBJFADE, 9f, AIPGGFGKNFE, null, 1123f, 1158f);
	}

	public Audio FKNGAFGLFBP(int MLICEJKIGHO)
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

	private void IEMEHGCFAPD()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Update();
			if (!audio.PNEPMOGOEKP() && !audio.paused && !LFEFAKMMFKF)
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

	public int PPJKMFAMPFC(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return OKMIDMIIIMA(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 1831f, 1792f, 1067f, null);
	}

	public int PlayMusic(AudioClip BKGCLBJFADE)
	{
		return PlayMusic(BKGCLBJFADE, 1f, true, false, 1f, 1f, -1f, null);
	}

	public void CDILNBNHGLL(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
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

	public void HGHLPCGPMHM()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Pause();
		}
	}

	public void KEKNHAAEPCJ()
	{
		base.Awake();
		LCKKDMKJJEF();
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
	public bool ICMNFCFLNOH()
	{
		return _003CNEACNFNFMJK_003Ek__BackingField;
	}

	public int JFALLLNEFDO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 836f, null);
	}

	public new void Awake()
	{
		base.Awake();
		Init();
	}

	public Audio OCCAAPFDGFJ(int MLICEJKIGHO)
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

	[SpecialName]
	public float GPHLHJOANLP()
	{
		float value = 1404f;
		music_mixer.audioMixer.GetFloat("PLEASE WAIT", out value);
		return value;
	}

	[SpecialName]
	public void DBIDPLPNOAN(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("_MatrixSize", DPNHODJHGJL);
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

	public Audio PBOPPFONCFF(int MLICEJKIGHO)
	{
		Audio audio = GHEHFAIPPEG(MLICEJKIGHO);
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

	public void OPHOGLMEENM()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Resume();
		}
	}

	public void JCOKFDKIDJA()
	{
		DNBKMFAFLDG();
		PauseAllSounds();
	}

	private void LLDHEJIEDHO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.HLDFOJMHKNL();
			if (!audio.AHADHELAKAM() && !audio.paused && !LFEFAKMMFKF)
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
			if (!audio2.PNEPMOGOEKP() && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	private void OPCLBGHAPMG()
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
			if (!audio2.AHADHELAKAM() && !audio2.paused && !LFEFAKMMFKF)
			{
				Object.Destroy(audio2._audiosource.gameObject);
				MECONPJBFIL.Remove(item2);
			}
		}
	}

	public int EHGCEMJDLIG(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1189f, null);
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

	public void MMMNELCEDDM()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public void FHOCONCMBME()
	{
		KAJABEIAEGO();
		BLIJAAIDNDG();
	}

	public void OMABJDAIMJP()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	public int PlaySound(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return PlaySound(BKGCLBJFADE, 1f, AIPGGFGKNFE, null);
	}

	public void GONHOEMAGHN()
	{
		KAJABEIAEGO();
		BLIJAAIDNDG();
	}

	public void KNDKLKHKLKH()
	{
		StopAll(1155f);
	}

	public Audio KKACNNHLDNI(AudioClip ICJOJEKDMIF)
	{
		Audio audio = EMFACPNCDNM(ICJOJEKDMIF);
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

	public void DNOKNGHICOO()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
	}

	[SpecialName]
	public void AKIDNCCJGGB(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("value", DPNHODJHGJL);
	}

	public int MLDOGKCDPEL(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("SetEnvSpriteImage", BKGCLBJFADE);
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
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 502f, 612f, OKDDLALOEME);
		audio.audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
		audio.audioSource.minDistance = PFJOHIMLHEP;
		audio.EFBNFACGJLI().maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(1996f, 1131f, 533f);
		audio.AKHKFKHDAEK().outputAudioMixerGroup = sfx_mixer;
		MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return PlayMusic(BKGCLBJFADE, BDICHAELIJE, true, false, 1f, 1f, -1f, null);
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

	public Audio KEDEGDMKAEM(AudioClip ICJOJEKDMIF)
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
	public void GJDBEPBHINL(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("settings.arcshitsoundtimedelay", DPNHODJHGJL);
	}

	public Audio GEKNHCBFFKB(AudioClip ICJOJEKDMIF)
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

	private void NLKGMNIKBKC(Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (!audio.persist && audio.activated)
			{
				Object.Destroy(audio.EFBNFACGJLI());
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

	[SpecialName]
	public bool JGKFONNHGNC()
	{
		return _003CEDKNFIIEBBC_003Ek__BackingField;
	}

	public void HPLINLEJOAM(float LALICIHGPMB)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (LALICIHGPMB > 1943f)
			{
				audio.fadeOutSeconds = LALICIHGPMB;
			}
			audio.Stop();
		}
	}

	public int OKMIDMIIIMA(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("OpSetPropertiesOfRoom()", BKGCLBJFADE);
		}
		if (ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(DJBIELKMADE.Keys);
			foreach (int item in list)
			{
				if (DJBIELKMADE[item].AKHKFKHDAEK().clip == BKGCLBJFADE)
				{
					return DJBIELKMADE[item].audioID;
				}
			}
		}
		StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.AKHKFKHDAEK().outputAudioMixerGroup = music_mixer;
		DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	public void PGALMAJLOHK()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Pause();
		}
	}

	public void FMHBLFELOGC()
	{
		KNDKLKHKLKH();
	}

	[SpecialName]
	public void BBNEIDHJJJE(float DPNHODJHGJL)
	{
		master_mixer.audioMixer.SetFloat("RestartButton", DPNHODJHGJL);
	}

	private void OnApplicationPause(bool IBNHNGJMBBA)
	{
		LFEFAKMMFKF = IBNHNGJMBBA;
	}

	public Audio CJPHELLFJOO(int MLICEJKIGHO)
	{
		Audio audio = GHEHFAIPPEG(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = OCCAAPFDGFJ(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	public void OBHNMDNJEDM(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
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
	public void KMLGMOCKEME(bool DPNHODJHGJL)
	{
		_003CEDKNFIIEBBC_003Ek__BackingField = DPNHODJHGJL;
	}

	private IEnumerator BAGMAJJFEHK()
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
		Debug.Log("Loaded skin audio");
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
		Debug.Log("Loaded skin audio");
	}

	[SpecialName]
	public float CCNNLCEKOEK()
	{
		float value = 626f;
		sfx_mixer.audioMixer.GetFloat("_HSV", out value);
		return value;
	}

	public Audio KGIOEIMBPJG()
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

	public Audio NHFNJEHCAOF(int MLICEJKIGHO)
	{
		Audio audio = GHEHFAIPPEG(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = OCCAAPFDGFJ(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	public int BMIFIPNJAKN(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return MLDOGKCDPEL(BKGCLBJFADE, BDICHAELIJE, true, null, 142f, 171f);
	}

	public int KHHNECCNAMF(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return DEOCENIMOED(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 347f, 1429f, 440f, null);
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

	[SpecialName]
	public void IOGOJCDECOE(bool DPNHODJHGJL)
	{
		_003CEDKNFIIEBBC_003Ek__BackingField = DPNHODJHGJL;
	}

	private void DKONBMKHDCK(Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			if (!audio.persist && audio.JAAOFJFLLHN())
			{
				Object.Destroy(audio.AKHKFKHDAEK());
				DJBIELKMADE.Remove(item);
			}
		}
		list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item2 in list)
		{
			Audio audio2 = MECONPJBFIL[item2];
			Object.Destroy(audio2.EFBNFACGJLI());
			MECONPJBFIL.Remove(item2);
		}
	}

	public void LFOGHDKIMCK()
	{
		List<int> list = new List<int>(MECONPJBFIL.Keys);
		foreach (int item in list)
		{
			Audio audio = MECONPJBFIL[item];
			audio.Stop();
		}
	}

	private void LAAAOEAOJFC(bool IBNHNGJMBBA)
	{
		LFEFAKMMFKF = IBNHNGJMBBA;
	}

	public void PIMGPPIHJLH()
	{
		JKGOFLFCOMG(380f);
	}

	public int LFGKEAIJAIB(AudioClip BKGCLBJFADE)
	{
		return BJPDFJDFOHG(BKGCLBJFADE, 305f, true, null, 1177f, 489f);
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

	public void NLOGMAMPHNB()
	{
		List<int> list = new List<int>(DJBIELKMADE.Keys);
		foreach (int item in list)
		{
			Audio audio = DJBIELKMADE[item];
			audio.Resume();
		}
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

	[SpecialName]
	public void BOIDLCHBLDJ(float DPNHODJHGJL)
	{
		sfx_mixer.audioMixer.SetFloat("_TimeX", DPNHODJHGJL);
	}

	public Audio MOHPPIOCCPF()
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

	[SpecialName]
	public bool NFMIINBJIMN()
	{
		return _003CNEACNFNFMJK_003Ek__BackingField;
	}
}
