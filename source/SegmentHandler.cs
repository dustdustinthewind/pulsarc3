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

	private void KMKLDAJLCNM()
	{
		if (base.transform.localPosition.z >= 188f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 619f)
		{
			if (NBPGDBABKIC.JAEJDHHCJJO().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.EDIJKHEMPAD();
				object[] array = new object[1];
				array[1] = true;
				photonView.RPC("_ForceYSwap", PhotonTargets.Others, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	public void LBICLFNOLAK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	public void Init(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	private void CFIAKIJAILI()
	{
		if (base.transform.localPosition.z >= 845f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 397f)
		{
			if (NBPGDBABKIC.photonView.isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.IBKCMBIGOEJ();
				object[] array = new object[1];
				array[1] = false;
				photonView.RPC("_TimeX", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.KHCIDFMOBPK(base.gameObject);
		}
	}

	public void IFGOHEOEGKH(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void AAPKBNDHBLI()
	{
		if (base.transform.localPosition.z >= 1437f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1280f)
		{
			if (NBPGDBABKIC.JIOCGDBKGIL().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.OELHGNKAMEG();
				object[] array = new object[0];
				array[0] = false;
				photonView.RPC("USE_PREDICATION", PhotonTargets.AllBufferedViaServer, array);
			}
			TrashMan.KHCIDFMOBPK(base.gameObject);
		}
	}

	public void HBKEHHCMMBN(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = false;
		onSpawn.Invoke();
	}

	public void FFBDGOBNNCO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void JHPOIOELNCG()
	{
		if (base.transform.localPosition.z >= 707f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 517f)
		{
			if (NBPGDBABKIC.OELHGNKAMEG().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				NBPGDBABKIC.AAMNKPHHHCI().RPC(".lastCheckpoint.powerupsScore", PhotonTargets.AllBufferedViaServer, true);
			}
			TrashMan.NMCBFOGNHPP(base.gameObject);
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

	public void FIMJABKECNG(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		DIEJJADFJGO = true;
		onSpawn.Invoke();
	}

	private void BGFJOEPFOPM()
	{
		if (base.transform.localPosition.z >= 149f && !DIEJJADFJGO)
		{
			DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1378f)
		{
			if (NBPGDBABKIC.GBMJAPGLMGB().isMine && NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && NBPGDBABKIC.GetGameScene().gameMode != 0)
			{
				PhotonView photonView = NBPGDBABKIC.IFENGKHOKPC();
				object[] array = new object[0];
				array[1] = true;
				photonView.RPC("GetRegions failed. Can't provide regions list. Error: ", PhotonTargets.AllViaServer, array);
			}
			TrashMan.KHCIDFMOBPK(base.gameObject);
		}
	}
}
