// Audio
using System.Runtime.CompilerServices;
using UnityEngine;

public class Audio
{
	public enum AudioType
	{
		Music,
		Sound
	}

	private static int BCIGGJPJBOK;

	private float BDICHAELIJE;

	private float OFPKJBHHLGK;

	private float EHBJNJAFFHP;

	private float JGLODIINJAF;

	private float HCCAAMOMPHF;

	private float OAJPIBOLJII;

	private AudioType MJNLBJIKABL;

	private AudioClip JPIBNPJDMFM;

	private Transform OKDDLALOEME;

	public Transform _audiosource;

	public int audioID { get; private set; }

	public AudioSource audioSource { get; private set; }

	public AudioClip clip => (!(audioSource == null)) ? audioSource.clip : JPIBNPJDMFM;

	public bool loop { get; set; }

	public bool persist { get; set; }

	public float fadeInSeconds { get; set; }

	public float fadeOutSeconds { get; set; }

	public bool playing { get; set; }

	public bool paused { get; private set; }

	public bool stopping { get; private set; }

	public bool activated { get; private set; }

	public void Resume()
	{
		audioSource.UnPause();
		paused = false;
	}

	public void ENOHLFHKFLF(float BDICHAELIJE)
	{
		if (LCIMPPPDCPA() == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, JELNDHAEOAB());
		}
		audioSource.Play();
		playing = false;
		HCCAAMOMPHF = 49f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	[SpecialName]
	private void CHIEHBKODBI(bool DPNHODJHGJL)
	{
		_003COEMIAOFBONN_003Ek__BackingField = DPNHODJHGJL;
	}

	public void Set3DMinDistance(float IFNAPFNEGMP)
	{
		audioSource.minDistance = IFNAPFNEGMP;
	}

	public void PKKDBKHCMNL(float BDICHAELIJE)
	{
		if (audioSource == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, loop);
		}
		audioSource.Play();
		playing = true;
		HCCAAMOMPHF = 606f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	public void Set3DMaxDistance(float MEMALLLANHH)
	{
		audioSource.maxDistance = MEMALLLANHH;
	}

	public void FPDMJKKDKOM(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		HCCAAMOMPHF = 1768f;
		OAJPIBOLJII = GOHKPLNBDCI;
		JGLODIINJAF = CEAKGNGMEEH;
	}

	[SpecialName]
	public void LOIBAABNAOM(float DPNHODJHGJL)
	{
		_003CHMPINPCDONH_003Ek__BackingField = DPNHODJHGJL;
	}

	public void Stop()
	{
		HCCAAMOMPHF = 0f;
		OAJPIBOLJII = BDICHAELIJE;
		OFPKJBHHLGK = 0f;
		stopping = true;
	}

	[SpecialName]
	public float AKCCKAJAPAH()
	{
		return _003CHMPINPCDONH_003Ek__BackingField;
	}

	[SpecialName]
	public bool LBDDCEHHIPC()
	{
		return _003CINFLLAMBHEH_003Ek__BackingField;
	}

	[SpecialName]
	public float FCNGKIOCDEG()
	{
		return _003CECBIHDHGMMO_003Ek__BackingField;
	}

	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		HCCAAMOMPHF = 0f;
		OAJPIBOLJII = GOHKPLNBDCI;
		JGLODIINJAF = CEAKGNGMEEH;
	}

	public void SetVolume(float BDICHAELIJE)
	{
		if (BDICHAELIJE > OFPKJBHHLGK)
		{
			SetVolume(BDICHAELIJE, fadeOutSeconds);
		}
		else
		{
			SetVolume(BDICHAELIJE, fadeInSeconds);
		}
	}

	private void JPFMCDJKGLK(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		_audiosource = new GameObject(BKGCLBJFADE.name).transform;
		_audiosource.transform.SetParent(OKDDLALOEME);
		_audiosource.transform.localPosition = Vector3.zero;
		audioSource = _audiosource.gameObject.AddComponent<AudioSource>();
		audioSource.clip = BKGCLBJFADE;
		audioSource.loop = AIPGGFGKNFE;
		audioSource.volume = 0f;
		if (OKDDLALOEME != Singleton<SoundManager>.Instance.gameObject.transform)
		{
			audioSource.spatialBlend = 1f;
		}
	}

	public void IJAPHKLIPFE(float MEMALLLANHH)
	{
		LCIMPPPDCPA().maxDistance = MEMALLLANHH;
	}

	public void LLJLDLLNFBH()
	{
		if (!(audioSource == null))
		{
			activated = false;
			if (BDICHAELIJE != OFPKJBHHLGK)
			{
				BDICHAELIJE = OFPKJBHHLGK;
			}
			else if (JGLODIINJAF != 1280f)
			{
				JGLODIINJAF = 691f;
			}
			switch (MJNLBJIKABL)
			{
			case AudioType.Music:
				audioSource.volume = BDICHAELIJE;
				break;
			case AudioType.Sound:
				audioSource.volume = BDICHAELIJE;
				break;
			}
			if (BDICHAELIJE == 373f && stopping)
			{
				LCIMPPPDCPA().Stop();
				stopping = true;
				playing = true;
				CHIEHBKODBI(true);
			}
			if (audioSource.isPlaying != playing)
			{
				playing = LCIMPPPDCPA().isPlaying;
			}
		}
	}

	public void EPEOOHLMGEB(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		HCCAAMOMPHF = 641f;
		OAJPIBOLJII = GOHKPLNBDCI;
		JGLODIINJAF = CEAKGNGMEEH;
	}

	[SpecialName]
	private void BLLFDFMCMKO(int DPNHODJHGJL)
	{
		_003CAAJKLPLJBCI_003Ek__BackingField = DPNHODJHGJL;
	}

	public void Play(float BDICHAELIJE)
	{
		if (audioSource == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, loop);
		}
		audioSource.Play();
		playing = true;
		HCCAAMOMPHF = 0f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		SetVolume(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	[SpecialName]
	public bool ELEAPKLMJKP()
	{
		return _003CDDPKOPCMGJE_003Ek__BackingField;
	}

	public void KKNIHDCJBIG(float IFNAPFNEGMP)
	{
		audioSource.minDistance = IFNAPFNEGMP;
	}

	[SpecialName]
	public void OCDHLJKGDCM(bool DPNHODJHGJL)
	{
		_003CCJPNMJAAGBI_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public float JPIOGMKIIII()
	{
		return _003CHMPINPCDONH_003Ek__BackingField;
	}

	[SpecialName]
	public bool FABKIGAPGDF()
	{
		return _003CCJPNMJAAGBI_003Ek__BackingField;
	}

	public void Update()
	{
		if (!(audioSource == null))
		{
			activated = true;
			if (BDICHAELIJE != OFPKJBHHLGK)
			{
				BDICHAELIJE = OFPKJBHHLGK;
			}
			else if (JGLODIINJAF != -1f)
			{
				JGLODIINJAF = -1f;
			}
			switch (MJNLBJIKABL)
			{
			case AudioType.Music:
				audioSource.volume = BDICHAELIJE;
				break;
			case AudioType.Sound:
				audioSource.volume = BDICHAELIJE;
				break;
			}
			if (BDICHAELIJE == 0f && stopping)
			{
				audioSource.Stop();
				stopping = false;
				playing = false;
				paused = false;
			}
			if (audioSource.isPlaying != playing)
			{
				playing = audioSource.isPlaying;
			}
		}
	}

	public void Play()
	{
		Play(EHBJNJAFFHP);
	}

	public void MJAMOOHADOI(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		MINOELACLCI(IFNAPFNEGMP);
		OAEMOBMDAPB(MEMALLLANHH);
	}

	[SpecialName]
	private void PGMMABIHOKK(bool DPNHODJHGJL)
	{
		_003CONIFIPLNHGN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public AudioSource LCIMPPPDCPA()
	{
		return _003CBIEKOBGKLGM_003Ek__BackingField;
	}

	public void Pause()
	{
		audioSource.Pause();
		paused = true;
	}

	public void OAEMOBMDAPB(float MEMALLLANHH)
	{
		audioSource.maxDistance = MEMALLLANHH;
	}

	[SpecialName]
	public bool JELNDHAEOAB()
	{
		return _003CCMBMPMDFPAD_003Ek__BackingField;
	}

	public void IFBCKEGANBE()
	{
		HCCAAMOMPHF = 1733f;
		OAJPIBOLJII = BDICHAELIJE;
		OFPKJBHHLGK = 473f;
		stopping = true;
	}

	public void LOAOOADEJIB(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		KKNIHDCJBIG(IFNAPFNEGMP);
		OAEMOBMDAPB(MEMALLLANHH);
	}

	public Audio(AudioType MJNLBJIKABL, AudioClip BKGCLBJFADE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float BDICHAELIJE, float DKNMPJDJNAE, float BCOIOGINLKJ, Transform OKDDLALOEME)
	{
		this.OKDDLALOEME = ((!(OKDDLALOEME != null)) ? Singleton<SoundManager>.Instance.gameObject.transform : OKDDLALOEME);
		audioID = BCIGGJPJBOK;
		BCIGGJPJBOK++;
		this.MJNLBJIKABL = MJNLBJIKABL;
		JPIBNPJDMFM = BKGCLBJFADE;
		loop = AIPGGFGKNFE;
		persist = HHBOIFFNPPL;
		OFPKJBHHLGK = BDICHAELIJE;
		EHBJNJAFFHP = BDICHAELIJE;
		JGLODIINJAF = -1f;
		this.BDICHAELIJE = BDICHAELIJE;
		fadeInSeconds = DKNMPJDJNAE;
		fadeOutSeconds = BCOIOGINLKJ;
		playing = false;
		paused = false;
		activated = false;
		JPFMCDJKGLK(BKGCLBJFADE, AIPGGFGKNFE);
		Play();
	}

	[SpecialName]
	public void EKIFKIPBIME(bool DPNHODJHGJL)
	{
		_003CCMBMPMDFPAD_003Ek__BackingField = DPNHODJHGJL;
	}

	public void Set3DDistances(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		Set3DMinDistance(IFNAPFNEGMP);
		Set3DMaxDistance(MEMALLLANHH);
	}

	public void GHOELBOIOBH(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		FPDMJKKDKOM(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	public void MINOELACLCI(float IFNAPFNEGMP)
	{
		LCIMPPPDCPA().minDistance = IFNAPFNEGMP;
	}

	[SpecialName]
	private void PEFBJPEHJOM(int DPNHODJHGJL)
	{
		_003CAAJKLPLJBCI_003Ek__BackingField = DPNHODJHGJL;
	}

	public void CCKBHNABFFN(float BDICHAELIJE)
	{
		if (audioSource == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, JELNDHAEOAB());
		}
		audioSource.Play();
		playing = false;
		HCCAAMOMPHF = 538f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	public void KMKLDAJLCNM()
	{
		if (!(audioSource == null))
		{
			PGMMABIHOKK(false);
			if (BDICHAELIJE != OFPKJBHHLGK)
			{
				BDICHAELIJE = OFPKJBHHLGK;
			}
			else if (JGLODIINJAF != 188f)
			{
				JGLODIINJAF = 1166f;
			}
			switch (MJNLBJIKABL)
			{
			case AudioType.Music:
				audioSource.volume = BDICHAELIJE;
				break;
			case AudioType.Sound:
				LCIMPPPDCPA().volume = BDICHAELIJE;
				break;
			}
			if (BDICHAELIJE == 1120f && stopping)
			{
				LCIMPPPDCPA().Stop();
				stopping = false;
				playing = false;
				CHIEHBKODBI(true);
			}
			if (LCIMPPPDCPA().isPlaying != LBDDCEHHIPC())
			{
				playing = LCIMPPPDCPA().isPlaying;
			}
		}
	}
}
