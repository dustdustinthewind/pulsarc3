// SegmentHandler
using UnityEngine;
using UnityEngine.Events;

public class SegmentHandler : MonoBehaviour
{
	public float spawnAnimationDelay = 0.15f;

	public UnityEvent onSpawn;

	public UnityEvent onDestroy;

	private PlayerBase NBPGDBABKIC;

	private bool DIEJJADFJGO;

	public void NKLCNJEIAFB(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void EJFJENFKLND()
	{
		if (base.transform.localPosition.z >= 353f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 483f)
		{
			if (NBPGDBABKIC.EDIJKHEMPAD().KCAOJFPDEIP() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.FFIPLLNKGEN();
				object[] array = new object[0];
				array[0] = false;
				photonView.MIAHMDGOOPJ("CameraFilterPack/Color_YUV", PhotonTargets.AllViaServer, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	public void FEJAAGGMBOE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void IFGOHEOEGKH(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void FABKIGNFECE()
	{
		if (base.transform.localPosition.z >= 931f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1670f)
		{
			if (NBPGDBABKIC.EOOCGIFFKBG().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GBMJAPGLMGB();
				object[] array = new object[0];
				array[0] = true;
				photonView.RPC("MapEnd", PhotonTargets.All, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	public void CFKJHLOEDFO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void PAFMNAIDAFH(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void NBHGPDAKJGF(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void GAJEPOEIOPP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void AAPKBNDHBLI()
	{
		if (base.transform.localPosition.z >= 1525f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1589f)
		{
			if (NBPGDBABKIC.EOOCGIFFKBG().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GMAHNPNHMFK();
				object[] array = new object[1];
				array[1] = true;
				photonView.PBMFBOOALKA("#savemapbeforeuploading", PhotonTargets.MasterClient, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	public void CPFOEFKOJGA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void EMOCEKPLGBK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void LCGMHCBNCDM(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void ONMGIPAILOH()
	{
		if (base.transform.localPosition.z >= 173f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1748f)
		{
			if (NBPGDBABKIC.AAMNKPHHHCI().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GBHNDHLAJLI();
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA("SetBGColor", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	private void LCHBFNIPBHB()
	{
		if (base.transform.localPosition.z >= 1027f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 764f)
		{
			if (NBPGDBABKIC.FFIPLLNKGEN().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.IBKCMBIGOEJ();
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA("_Offsets", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	private void MMBPLGGLPDB()
	{
		if (base.transform.localPosition.z >= 697f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 648f)
		{
			if (NBPGDBABKIC.GBHNDHLAJLI().KCAOJFPDEIP() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				NBPGDBABKIC.EOOCGIFFKBG().PBMFBOOALKA("[Left]", PhotonTargets.All, new object[1] { false });
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	public void Init(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void POIMNOBDBBN()
	{
		if (base.transform.localPosition.z >= 174f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 546f)
		{
			if (NBPGDBABKIC.JAEJDHHCJJO().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.OELHGNKAMEG();
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG("_Value4", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	private void IKIDIJLIGOH()
	{
		if (base.transform.localPosition.z >= 1913f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 961f)
		{
			if (NBPGDBABKIC.EDIJKHEMPAD().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.OELHGNKAMEG();
				object[] array = new object[0];
				array[0] = true;
				photonView.PBMFBOOALKA("useSrcAlphaAsMask", PhotonTargets.Others, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	private void JBNPEHMDCMI()
	{
		if (base.transform.localPosition.z >= 1467f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1356f)
		{
			if (NBPGDBABKIC.GBMJAPGLMGB().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GBHNDHLAJLI();
				object[] array = new object[0];
				array[0] = false;
				photonView.KEKKFNNMLMG("_FadeFX", PhotonTargets.AllViaServer, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	private void MJNPIDGNJMK()
	{
		if (base.transform.localPosition.z >= 68f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 709f)
		{
			if (NBPGDBABKIC.photonView.isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				NBPGDBABKIC.GBMJAPGLMGB().MIAHMDGOOPJ("CameraFilterPack/Edge_Neon", PhotonTargets.OthersBuffered, new object[1] { true });
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	public void EFEONCCCKNP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void FIMJABKECNG(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void MFMIODIAKNI()
	{
		if (base.transform.localPosition.z >= 1663f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 450f)
		{
			if (NBPGDBABKIC.IBKCMBIGOEJ().KCAOJFPDEIP() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.FFIPLLNKGEN();
				object[] array = new object[0];
				array[1] = false;
				photonView.GNFNHDCJOFC("Object ID. Case-Sensitive", PhotonTargets.MasterClient, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	private void DPIPGGDNGHN()
	{
		if (base.transform.localPosition.z >= 932f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1929f)
		{
			if (NBPGDBABKIC.JAEJDHHCJJO().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				NBPGDBABKIC.BLMHOKPIMOD().MIAHMDGOOPJ("#discord{0}joinrequest", PhotonTargets.AllBuffered, new object[1] { false });
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	private void FBMDHDBELEK()
	{
		if (base.transform.localPosition.z >= 535f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1729f)
		{
			if (NBPGDBABKIC.OELHGNKAMEG().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.OELHGNKAMEG();
				object[] array = new object[0];
				array[1] = true;
				photonView.MIAHMDGOOPJ("_NumberOfWaves", PhotonTargets.All, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	private void Update()
	{
		if (base.transform.localPosition.z >= -0.08f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 10f)
		{
			if (NBPGDBABKIC.photonView.isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				NBPGDBABKIC.photonView.RPC("LostLive", PhotonTargets.AllBufferedViaServer, false);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	private void AEIJFLJEABG()
	{
		if (base.transform.localPosition.z >= 1021f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 629f)
		{
			if (NBPGDBABKIC.photonView.isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.EDIJKHEMPAD();
				object[] array = new object[1];
				array[1] = true;
				photonView.PBMFBOOALKA("Parent ID", PhotonTargets.OthersBuffered, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	public void KJBJBNGJDAD(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void GPFJMKCGHGB()
	{
		if (base.transform.localPosition.z >= 1766f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1977f)
		{
			if (NBPGDBABKIC.JAEJDHHCJJO().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.EOOCGIFFKBG();
				object[] array = new object[0];
				array[1] = false;
				photonView.RPC(".lastCheckpoint.time", PhotonTargets.OthersBuffered, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	public void ALKBNPMCEOM(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void FOMNCPKKCFN()
	{
		if (base.transform.localPosition.z >= 594f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 744f)
		{
			if (NBPGDBABKIC.EDIJKHEMPAD().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GBMJAPGLMGB();
				object[] array = new object[0];
				array[0] = false;
				photonView.MIAHMDGOOPJ("settings.gamemessagesduration", (PhotonTargets)8, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	public void LCKKDMKJJEF(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void IDIIELPAMCJ()
	{
		if (base.transform.localPosition.z >= 1053f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1176f)
		{
			if (NBPGDBABKIC.EDIJKHEMPAD().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.photonView;
				object[] array = new object[1];
				array[1] = false;
				photonView.RPC("Connecting", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	public void JJFLHFCBENC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void LBICLFNOLAK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void HMNLHMLILKD()
	{
		if (base.transform.localPosition.z >= 1244f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1270f)
		{
			if (NBPGDBABKIC.BLMHOKPIMOD().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.ACPGHFHDCIP();
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG(".lastCheckpoint.time", PhotonTargets.All, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	public void GCNKIJDNPMD(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void GGHCMPKGNGE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void NOBNCNJKOLA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void NKLNGGOHLMO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void BFMEBNFGCEA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void KMKLDAJLCNM()
	{
		if (base.transform.localPosition.z >= 738f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 390f)
		{
			if (NBPGDBABKIC.GMAHNPNHMFK().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				NBPGDBABKIC.EDIJKHEMPAD().MIAHMDGOOPJ("VHS2", PhotonTargets.AllViaServer, new object[1] { true });
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	public void LILOGPDPFDA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void OIBMHPIFAKK()
	{
		if (base.transform.localPosition.z >= 204f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1851f)
		{
			if (NBPGDBABKIC.BLMHOKPIMOD().BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GMAHNPNHMFK();
				object[] array = new object[1];
				array[1] = false;
				photonView.KEKKFNNMLMG("sfxVolume", PhotonTargets.All, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	public void CAJFKNFJEKC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void FFBDGOBNNCO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void OBAEDJJDCPN()
	{
		if (base.transform.localPosition.z >= 1543f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 675f)
		{
			if (NBPGDBABKIC.AAMNKPHHHCI().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GMAHNPNHMFK();
				object[] array = new object[0];
				array[0] = true;
				photonView.GNFNHDCJOFC("SUCCESS! Item submitted! :D :D :D", PhotonTargets.All, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	public void CDDHLFNJOGC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void KDJHONILJGK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void LLAHPNGMEOO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void LPMINJJPDCH()
	{
		if (base.transform.localPosition.z >= 1583f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 536f)
		{
			if (NBPGDBABKIC.JAEJDHHCJJO().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				NBPGDBABKIC.EOOCGIFFKBG().KEKKFNNMLMG("settings.shaders.bloomintencity", (PhotonTargets)7, new object[1] { false });
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	private void DNENFLNCIJP()
	{
		if (base.transform.localPosition.z >= 595f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1770f)
		{
			if (NBPGDBABKIC.photonView.BGJKMGJBPFA() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.GBHNDHLAJLI();
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA("file://", PhotonTargets.OthersBuffered, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	public void LKEPIEEIMAE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void EKOAKKNGGGI(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void EOPEMLDJAAO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void EGEGNHLODAA()
	{
		if (base.transform.localPosition.z >= 1004f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 794f)
		{
			if (NBPGDBABKIC.GBHNDHLAJLI().DOLKFPIABDD() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.DCLNDDJJJMA().gameMode != 0)
			{
				NBPGDBABKIC.ACPGHFHDCIP().IKIJDNPJKPM(": ", PhotonTargets.AllBuffered, new object[1] { true });
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	public void AOEEOKNJDCK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void LCJHDLKJEOM()
	{
		if (base.transform.localPosition.z >= 1314f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 459f)
		{
			if (NBPGDBABKIC.AAMNKPHHHCI().KCAOJFPDEIP() && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				NBPGDBABKIC.IBKCMBIGOEJ().MIAHMDGOOPJ("_Distortion", PhotonTargets.Others, new object[1] { false });
			}
			TrashMan.LEJGMANJAHM(base.gameObject);
		}
	}

	private void JDGFCEPDKAJ()
	{
		if (base.transform.localPosition.z >= 1650f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1802f)
		{
			if (NBPGDBABKIC.EOOCGIFFKBG().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.CIACEFBNDDJ();
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG("settings_bindings_sec_", PhotonTargets.All, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	public void PFMJPIJONIP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void BGDONBMDPGM()
	{
		if (base.transform.localPosition.z >= 1864f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 884f)
		{
			if (NBPGDBABKIC.EDIJKHEMPAD().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				NBPGDBABKIC.AAMNKPHHHCI().MIAHMDGOOPJ("_Value", PhotonTargets.AllViaServer, new object[1] { true });
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}
}
