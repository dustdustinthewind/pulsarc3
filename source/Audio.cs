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

	[SpecialName]
	public void GKCNAEMPANF(float DPNHODJHGJL)
	{
		_003CECBIHDHGMMO_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public AudioSource AKHKFKHDAEK()
	{
		return _003CBIEKOBGKLGM_003Ek__BackingField;
	}

	[SpecialName]
	public void LANNCDEJFOG(bool DPNHODJHGJL)
	{
		_003CINFLLAMBHEH_003Ek__BackingField = DPNHODJHGJL;
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

	public void Resume()
	{
		audioSource.UnPause();
		paused = false;
	}

	[SpecialName]
	public void HJKKFKPLEBC(bool DPNHODJHGJL)
	{
		_003CINFLLAMBHEH_003Ek__BackingField = DPNHODJHGJL;
	}

	public void NBAPCMJFNLL(float MEMALLLANHH)
	{
		EFBNFACGJLI().maxDistance = MEMALLLANHH;
	}

	[SpecialName]
	public float AOINJLFJHIL()
	{
		return _003CHMPINPCDONH_003Ek__BackingField;
	}

	[SpecialName]
	public bool LEFMMNMAGFH()
	{
		return _003CDDPKOPCMGJE_003Ek__BackingField;
	}

	public void FHBCEACPFHN(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		POCJBONPHKG(IFNAPFNEGMP);
		NBAPCMJFNLL(MEMALLLANHH);
	}

	public void Set3DMaxDistance(float MEMALLLANHH)
	{
		audioSource.maxDistance = MEMALLLANHH;
	}

	public void Stop()
	{
		HCCAAMOMPHF = 0f;
		OAJPIBOLJII = BDICHAELIJE;
		OFPKJBHHLGK = 0f;
		stopping = true;
	}

	public void ELBJMOEMHNM(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		Set3DMinDistance(IFNAPFNEGMP);
		Set3DMaxDistance(MEMALLLANHH);
	}

	[SpecialName]
	private void PEANIIBIIJP(int DPNHODJHGJL)
	{
		_003CAAJKLPLJBCI_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public float IAKKKEHGBEP()
	{
		return _003CHMPINPCDONH_003Ek__BackingField;
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

	[SpecialName]
	public AudioSource EFBNFACGJLI()
	{
		return _003CBIEKOBGKLGM_003Ek__BackingField;
	}

	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		HCCAAMOMPHF = 0f;
		OAJPIBOLJII = GOHKPLNBDCI;
		JGLODIINJAF = CEAKGNGMEEH;
	}

	public void Set3DMinDistance(float IFNAPFNEGMP)
	{
		audioSource.minDistance = IFNAPFNEGMP;
	}

	public void DACMEPBBOFI(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		HCCAAMOMPHF = 1562f;
		OAJPIBOLJII = GOHKPLNBDCI;
		JGLODIINJAF = CEAKGNGMEEH;
	}

	[SpecialName]
	public void CEOPCECBLGE(bool DPNHODJHGJL)
	{
		_003CCMBMPMDFPAD_003Ek__BackingField = DPNHODJHGJL;
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

	public void POCJBONPHKG(float IFNAPFNEGMP)
	{
		audioSource.minDistance = IFNAPFNEGMP;
	}

	public void Pause()
	{
		audioSource.Pause();
		paused = true;
	}

	public void EFGFFEECBAF(float BDICHAELIJE)
	{
		if (AKHKFKHDAEK() == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, BJFJBACHCCD());
		}
		audioSource.Play();
		LANNCDEJFOG(false);
		HCCAAMOMPHF = 49f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	[SpecialName]
	public void CDCNJEMHLPK(bool DPNHODJHGJL)
	{
		_003CCMBMPMDFPAD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private void BGPLHOCOJJE(int DPNHODJHGJL)
	{
		_003CAAJKLPLJBCI_003Ek__BackingField = DPNHODJHGJL;
	}

	public void LMCBKNINIKN()
	{
		EFGFFEECBAF(EHBJNJAFFHP);
	}

	[SpecialName]
	public void BJBCEEIGLPL(bool DPNHODJHGJL)
	{
		_003CCMBMPMDFPAD_003Ek__BackingField = DPNHODJHGJL;
	}

	public void EFMLHJDDGPJ(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		Set3DMinDistance(IFNAPFNEGMP);
		Set3DMaxDistance(MEMALLLANHH);
	}

	[SpecialName]
	private void IMAJCFHBHGI(bool DPNHODJHGJL)
	{
		_003CONIFIPLNHGN_003Ek__BackingField = DPNHODJHGJL;
	}

	public void DEKJCKHCACJ(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		DACMEPBBOFI(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	[SpecialName]
	public void HPPNKFOMDKC(bool DPNHODJHGJL)
	{
		_003CCMBMPMDFPAD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool PNEPMOGOEKP()
	{
		return _003CINFLLAMBHEH_003Ek__BackingField;
	}

	[SpecialName]
	private void LNAHKFJNNCD(int DPNHODJHGJL)
	{
		_003CAAJKLPLJBCI_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public float FECJFOLBBCJ()
	{
		return _003CHMPINPCDONH_003Ek__BackingField;
	}

	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		SetVolume(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	public void EAOPPLGPBEN(float BDICHAELIJE)
	{
		if (AKHKFKHDAEK() == null)
		{
			JPFMCDJKGLK(JPIBNPJDMFM, loop);
		}
		audioSource.Play();
		playing = false;
		HCCAAMOMPHF = 538f;
		OAJPIBOLJII = this.BDICHAELIJE;
		OFPKJBHHLGK = BDICHAELIJE;
	}

	public void HCOLFILANBE(float MEMALLLANHH)
	{
		EFBNFACGJLI().maxDistance = MEMALLLANHH;
	}

	public void Play()
	{
		Play(EHBJNJAFFHP);
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

	[SpecialName]
	public void IBNHGNKAILN(bool DPNHODJHGJL)
	{
		_003CCJPNMJAAGBI_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool JAAOFJFLLHN()
	{
		return _003CONIFIPLNHGN_003Ek__BackingField;
	}

	[SpecialName]
	public void MIDCEKKDEBJ(bool DPNHODJHGJL)
	{
		_003CINFLLAMBHEH_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public bool AHADHELAKAM()
	{
		return _003CINFLLAMBHEH_003Ek__BackingField;
	}

	public void KMCICHOPOPB()
	{
		HCCAAMOMPHF = 1277f;
		OAJPIBOLJII = BDICHAELIJE;
		OFPKJBHHLGK = 425f;
		stopping = false;
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

	public void Set3DDistances(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		Set3DMinDistance(IFNAPFNEGMP);
		Set3DMaxDistance(MEMALLLANHH);
	}

	public void HLDFOJMHKNL()
	{
		if (!(audioSource == null))
		{
			activated = false;
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
				audioSource.volume = BDICHAELIJE;
				break;
			}
			if (BDICHAELIJE == 1120f && stopping)
			{
				AKHKFKHDAEK().Stop();
				stopping = false;
				HJKKFKPLEBC(false);
				paused = true;
			}
			if (EFBNFACGJLI().isPlaying != AHADHELAKAM())
			{
				MIDCEKKDEBJ(EFBNFACGJLI().isPlaying);
			}
		}
	}

	[SpecialName]
	public bool BJFJBACHCCD()
	{
		return _003CCMBMPMDFPAD_003Ek__BackingField;
	}
}
