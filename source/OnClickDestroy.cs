// OnClickDestroy
using System.Collections;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnClickDestroy : Photon.MonoBehaviour
{
	public bool DestroyByRpc;

	public IEnumerator MIOMHKDPDDN()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator HDOMAFFLHDN()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void AKEIPNLIHNL()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.photonView.IKIJDNPJKPM("_InvViewProj", PhotonTargets.MasterClient, new object[0]);
		}
	}

	public void NLGGGEBBFAH()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			ACPGHFHDCIP().PBMFBOOALKA("_Value5", PhotonTargets.Others, new object[1]);
		}
	}

	public IEnumerator JABKLNDKJBD()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator OKNCPHPIGIJ()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator MPNNIGNAMGO()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void PCHKMGNOEDF()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			GBHNDHLAJLI().RPC("https://api.steampowered.com/IInventoryService/AddItem/v001", PhotonTargets.MasterClient);
		}
	}

	public IEnumerator GPONFOHFAAJ()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator CEPFEBJKNKI()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void ONNJFFAFGGN()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			EOOCGIFFKBG().PBMFBOOALKA(").png", PhotonTargets.MasterClient, new object[1]);
		}
	}

	public IEnumerator DFKBMBKKHCI()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void HFGANPKDCJI()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			IBKCMBIGOEJ().GNFNHDCJOFC("Alpha", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	public IEnumerator MHCFBJACDJC()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator OKDBDPLBJNA()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	[PunRPC]
	public IEnumerator DestroyRpc()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void KKBODBLJHOB()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			CIACEFBNDDJ().PBMFBOOALKA("Share", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	public IEnumerator IKDFLMEIDGD()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator KFPPAKHLILA()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void KBOKCPHKCMI()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			JAEJDHHCJJO().IKIJDNPJKPM("NetworkCanvas", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	public void GAIOOLFFAFI()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			EOOCGIFFKBG().IKIJDNPJKPM("_Bullet_3", (PhotonTargets)8, new object[1]);
		}
	}

	public IEnumerator NNMLKBEKBAG()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public IEnumerator AOOICLHFCEA()
	{
		Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
	}

	public void OnClick()
	{
		if (!DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.photonView.RPC("DestroyRpc", PhotonTargets.AllBuffered);
		}
	}
}
