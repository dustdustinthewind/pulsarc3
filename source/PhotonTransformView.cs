// PhotonTransformView
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon Transform View")]
[RequireComponent(typeof(PhotonView))]
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private PhotonTransformViewPositionModel m_PositionModel = new PhotonTransformViewPositionModel();

	[SerializeField]
	private PhotonTransformViewRotationModel m_RotationModel = new PhotonTransformViewRotationModel();

	[SerializeField]
	private PhotonTransformViewScaleModel m_ScaleModel = new PhotonTransformViewScaleModel();

	private PhotonTransformViewPositionControl DKKKOMOJCIF;

	private PhotonTransformViewRotationControl NIJLJGDNBHE;

	private PhotonTransformViewScaleControl JAJKFGFBPIL;

	private PhotonView GDIAJCAHCEC;

	private bool PPJNLMEJHCN;

	private bool NBJNCJAJNPP;

	private void EAMHLEHJLDO()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.HNDBPLMHBDH(base.transform.localScale);
		}
	}

	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	public void NIMPHKAKFGO(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CHEEDIIKAAB(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.OnPhotonSerializeView(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.OnPhotonSerializeView(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.OnPhotonSerializeView(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.isMine && m_PositionModel.DrawErrorGizmo)
		{
			EEFIMMHNBAC();
		}
		if (!HCIJEDFCNOP.isReading)
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.GetNetworkPosition();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.GetNetworkRotation();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.GetNetworkScale();
			}
		}
	}

	private void Update()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			OJHFIEEDJGB();
			ALOAIMHLEFK();
			IPIDOPPAPPH();
		}
	}

	private void GBNCNPAMMLD()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.NKAMJHFKFFE(base.transform.localRotation);
		}
	}

	private void ENKEBEKGAFM()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.PEPILCKHHNG(base.transform.localRotation);
		}
	}

	private void OnEnable()
	{
		NBJNCJAJNPP = true;
	}

	private void FJANGBBAPKO()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.PABIECBIOEG(base.transform.localRotation);
		}
	}

	private void BFEPFLEBEFK()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.NEJCFEAMOHP(base.transform.localPosition);
		}
	}

	private void OCHMKJKBAPI()
	{
		NBJNCJAJNPP = true;
	}

	private void JAAJECBCCFM()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			BFEPFLEBEFK();
			GBNCNPAMMLD();
			IPIDOPPAPPH();
		}
	}

	private void Awake()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void FAAJAMIGJNK()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void PBCJGBEENOP(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.OIHBJOKGEIE(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void IPIDOPPAPPH()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GetScale(base.transform.localScale);
		}
	}

	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.CNMIIGDELGE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.HMMHABFJHEC(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.OnPhotonSerializeView(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.isMine && m_PositionModel.DrawErrorGizmo)
		{
			EEFIMMHNBAC();
		}
		if (!HCIJEDFCNOP.isReading)
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.AKMNELPCBBP();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.EFGEHCMCCLE();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.CLPJDAHHOAN();
			}
		}
	}

	private void BODPLDJLFCF()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void OJHFIEEDJGB()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}

	private void EEFIMMHNBAC()
	{
		Vector3 vector = DKKKOMOJCIF.GetNetworkPosition();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 2f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 2f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 2f);
	}

	private void IFKNIHJCAFB()
	{
		NBJNCJAJNPP = false;
	}

	public void BIDIBIPKAAG(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.FHAMLBCLHLK(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void ALOAIMHLEFK()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GetRotation(base.transform.localRotation);
		}
	}
}
