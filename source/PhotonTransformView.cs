// PhotonTransformView
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
[AddComponentMenu("Photon Networking/Photon Transform View")]
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

	private void APMIILJFAHI()
	{
		Vector3 vector = DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 815f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 769f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1214f);
	}

	private void CPCDFMMLHLO()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.KCAOJFPDEIP() && PhotonNetwork.connected)
		{
			BFEPFLEBEFK();
			BCJPFGDJAID();
			CAOGNPLGMEH();
		}
	}

	private void PNFGAPFDPIG()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	private void JHOGBKNMCIF()
	{
		Vector3 vector = DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 490f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1163f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 505f);
	}

	private void MLPCIDDEIDC()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void ILBIMLHMECN(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void IHJHGLDCHFK()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.JIHNIHKFFBN(base.transform.localRotation);
		}
	}

	private void GAIOINPOIHM()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.OCIAPBJGCOM(base.transform.localRotation);
		}
	}

	public void MCEKDLDCGAO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.DEKGPEDBDJE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.FOHGOGIMPJJ(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			MHLIFACJNLA();
		}
		if (!HCIJEDFCNOP.CAOIPMAGIFI())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.LFJPMNKJBMG();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.JPJLCPLIOCA();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JHLAPBECKPH();
			}
		}
	}

	private void HNOLLNNJKCO()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	public void JNABPAJHLML(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.OnPhotonSerializeView(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.HHODOGMIJGI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.KLFPENLPMJP(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			MNHPFGNPMNL();
		}
		if (!HCIJEDFCNOP.CAOIPMAGIFI())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.APJJAKOIMIK();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.CEPDDADCDCG();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JBGODNPHENN();
			}
		}
	}

	public void BDLOPMIFLJG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.HIDJLJIEPHK(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.CNMIIGDELGE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.BGJKMGJBPFA() && m_PositionModel.DrawErrorGizmo)
		{
			JHOGBKNMCIF();
		}
		if (!HCIJEDFCNOP.DCGOJLBDGEG())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.MDAKHCPMDIE();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.GBGENCNGBJH();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.MPJGCCAJAOA();
			}
		}
	}

	private void LJEFMGOBKGE()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void EIFCCFBJKOO()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void JLDJIHNGDMP()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
		}
	}

	private void EBCBBBKOKFG()
	{
		Vector3 vector = DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 461f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 700f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1519f);
	}

	private void EBOLINNNGLK()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
		}
	}

	private void EPCGHAAONLN()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.PKDPLHBMKPM(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.GBNDJBNLKLI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.FBMDDFMGFMF(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			BBJHDJBGDAN();
		}
		if (!HCIJEDFCNOP.EKDCDLDMKDL())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.LFJPMNKJBMG();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.AOLDNFKNMAP();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JHLAPBECKPH();
			}
		}
	}

	private void OEFLDIGHANK()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	public void KLLLFJIDALE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void EHKAMNFEGMG()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void EOFAACNPFDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.JNENAPDBOKE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			EAOINGGMHOH();
		}
		if (!HCIJEDFCNOP.EKDCDLDMKDL())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.NLNDBCNKLJH();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.GFLGLDGIGLK();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.GIMLEHMPBKA();
			}
		}
	}

	public void ICPOCNHAAEK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.HIDJLJIEPHK(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.HHODOGMIJGI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			EBCBBBKOKFG();
		}
		if (!HCIJEDFCNOP.EKDCDLDMKDL())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.MDAKHCPMDIE();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.HAGGDALINJC();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.DBBAOGADAFG();
			}
		}
	}

	private void HOLDCFBBHHP()
	{
		NBJNCJAJNPP = true;
	}

	public void KLFPENLPMJP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.AAAGGIHAKEH(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.MKPBBAPGGND(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.isMine && m_PositionModel.DrawErrorGizmo)
		{
			OICPDNHGCLA();
		}
		if (!HCIJEDFCNOP.DCGOJLBDGEG())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.LFJPMNKJBMG();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.FMKLCNHHPGM();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JBGODNPHENN();
			}
		}
	}

	private void APNJLHDKGDB()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
		}
	}

	public void FMLLKJIBBPO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.MOLNBJLBPOO(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.DOLKFPIABDD() && m_PositionModel.DrawErrorGizmo)
		{
			MHLIFACJNLA();
		}
		if (!HCIJEDFCNOP.CAOIPMAGIFI())
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
				base.transform.localRotation = NIJLJGDNBHE.BFGDOFKCPGN();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.BMOPJJPOKEE();
			}
		}
	}

	private void FAKGFMFAPDG()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.BGJKMGJBPFA() && PhotonNetwork.connected)
		{
			APNJLHDKGDB();
			IHCIMKAONKC();
			PEGIABKFJNH();
		}
	}

	private void JHPKLGGMCBL()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void CAGLAMLNJAH()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.NKLAIOJCAHD(base.transform.localScale);
		}
	}

	private void IPIDOPPAPPH()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GetScale(base.transform.localScale);
		}
	}

	private void PPPFNMIOPNH()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.AIKONMOBJOF(base.transform.localRotation);
		}
	}

	public void GCAKKECECPI(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void OJHFIEEDJGB()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}

	public void CMPDMPKMBMO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.JJGHNKLDANI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.DOLKFPIABDD() && m_PositionModel.DrawErrorGizmo)
		{
			BBJHDJBGDAN();
		}
		if (!HCIJEDFCNOP.DCGOJLBDGEG())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.NLNDBCNKLJH();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.HODEBPDPNLN();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.HIAGDLDLOJO();
			}
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

	public void HBDKIJHLHCH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void IFKNIHJCAFB()
	{
		NBJNCJAJNPP = false;
	}

	public void ENPHBNKFFPK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.DEKGPEDBDJE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.COHGAEMDFEI(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			AEEKOEDHGAM();
		}
		if (!HCIJEDFCNOP.EKDCDLDMKDL())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.MDAKHCPMDIE();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.FMKLCNHHPGM();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.FLFKMOEGOKL();
			}
		}
	}

	private void DKIJEFDDODC()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
		}
	}

	private void HIELFODJCMI()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
		}
	}

	private void HIDOPHINPAL()
	{
		NBJNCJAJNPP = false;
	}

	private void BHCCNFJKGPD()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void MHECPMBMHIC()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void PPFGHAKKLMN()
	{
		NBJNCJAJNPP = true;
	}

	private void MAOCOEGAFND()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.KCAOJFPDEIP() && PhotonNetwork.connected)
		{
			APNJLHDKGDB();
			CGEKJECJIKC();
			CAOGNPLGMEH();
		}
	}

	private void PFFFLMFHLMG()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
		}
	}

	private void HCIPECAOGIA()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			BFEPFLEBEFK();
			HLGENFAPEIC();
			OGHNPKKPLKE();
		}
	}

	private void MHLIFACJNLA()
	{
		Vector3 vector = DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 845f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 861f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 374f);
	}

	private void PEAPFFDOJAB()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.OMAOHOBIMNM(base.transform.localScale);
		}
	}

	private void KMEONPMCNJG()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			HFPHCAIJKEC();
			PMOBDAJCAAP();
			BNDCAGHJMJN();
		}
	}

	private void LGELACBDPEH()
	{
		NBJNCJAJNPP = false;
	}

	private void Awake()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void KLJKFGAMMNC()
	{
		Vector3 vector = DKKKOMOJCIF.JHBPKKMPBGA();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 343f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1299f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1787f);
	}

	private void HFPHCAIJKEC()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}

	private void GEPELODHBFN()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void OAKGOHPMEDF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void LGNMHMDEECO()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void IHCIMKAONKC()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.NNKFAAFFADP(base.transform.localRotation);
		}
	}

	public void EEDIHPHLNND(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void ANKIJGCGCBF()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			HNOLLNNJKCO();
			HLGENFAPEIC();
			LOBECCEMCFA();
		}
	}

	public void DOCHFMEEKGN(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void PEGIABKFJNH()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.FNKIOEHHAMB(base.transform.localScale);
		}
	}

	public void EJPKMLLGMGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.DAFGPDBLAMA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.BGJKMGJBPFA() && m_PositionModel.DrawErrorGizmo)
		{
			APMIILJFAHI();
		}
		if (!HCIJEDFCNOP.JKIGCGFEOOE())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.JHBPKKMPBGA();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.AGKPEIKIPJI();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.HIAGDLDLOJO();
			}
		}
	}

	private void EMKLCPGKNJL()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void ILAMPNNIIPC()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.GLDIJDCGPJG(base.transform.localPosition);
		}
	}

	public void HGHNBKDLGJF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	public void ENJMPDFKPJD(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void IFDDACMDNOO()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.HJKPAPHBNND(base.transform.localScale);
		}
	}

	private void EAOINGGMHOH()
	{
		Vector3 vector = DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 779f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1103f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 175f);
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

	public void KOJEAMINJFE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void BKDGEHFBEPA()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.NKLAIOJCAHD(base.transform.localScale);
		}
	}

	private void OGHNPKKPLKE()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
		}
	}

	public void GNKBEAPDNOE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.GBNDJBNLKLI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.isMine && m_PositionModel.DrawErrorGizmo)
		{
			BBJHDJBGDAN();
		}
		if (!HCIJEDFCNOP.EMLLALJBPJF())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.MDAKHCPMDIE();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.PGGPFBOADOB();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.PEFDNEOFNBE();
			}
		}
	}

	public void IFDFBONAJEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.PKDPLHBMKPM(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.NMMEHKPNBCA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.BGJKMGJBPFA() && m_PositionModel.DrawErrorGizmo)
		{
			MNHPFGNPMNL();
		}
		if (!HCIJEDFCNOP.EKDCDLDMKDL())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.GetNetworkPosition();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.OAHAHAGJAPD();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JHLAPBECKPH();
			}
		}
	}

	private void NIFJMJGAMGI()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GetScale(base.transform.localScale);
		}
	}

	public void PMMMEJDBJAH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	public void JOHIEOOOHNA(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void GBNCNPAMMLD()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.JIHNIHKFFBN(base.transform.localRotation);
		}
	}

	private void CAOGNPLGMEH()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
		}
	}

	private void EOPMOFAGCGP()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.HCGAJCIDHPO(base.transform.localRotation);
		}
	}

	private void BKCJHBJCAKO()
	{
		NBJNCJAJNPP = true;
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

	private void LIFBFDKFMMH()
	{
		NBJNCJAJNPP = false;
	}

	private void PAJLGDDPDFL()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.BOEOKPPMJFP(base.transform.localRotation);
		}
	}

	private void GCNKABKPNOJ()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void PBBNDLOHDNH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void BNDCAGHJMJN()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.HJKPAPHBNND(base.transform.localScale);
		}
	}

	private void EMAHOMAPBNL()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
		}
	}

	private void LPJAEOBLLPF()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}

	private void KFCCKOBOLAH()
	{
		NBJNCJAJNPP = false;
	}

	private void EKFBJDDMDGE()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
		}
	}

	public void CHPEJCIKJOF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void MDFMACKDHBH()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
		}
	}

	private void ENKEBEKGAFM()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GKJEOLEBMMP(base.transform.localRotation);
		}
	}

	public void CMIKIPBKBPH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void OnEnable()
	{
		NBJNCJAJNPP = true;
	}

	private void KFMEAMBLODG()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			BFEPFLEBEFK();
			PPPFNMIOPNH();
			BHCIENHFBNC();
		}
	}

	private void MECJHOJPODB()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			BFEPFLEBEFK();
			APJEGOELEGG();
			CAOGNPLGMEH();
		}
	}

	private void BCJPFGDJAID()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.ABCJPDICMOB(base.transform.localRotation);
		}
	}

	private void BBJHDJBGDAN()
	{
		Vector3 vector = DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1039f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1802f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 28f);
	}

	public void IDHELAJOLCB(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void FGIMGAKLNGD()
	{
		Vector3 vector = DKKKOMOJCIF.GetNetworkPosition();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1258f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 257f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 6f);
	}

	private void KCOFHPBDLLP()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
		}
	}

	private void BFEPFLEBEFK()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	private void AMPGFJNNALG()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}

	private void OICPDNHGCLA()
	{
		Vector3 vector = DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 799f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 639f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 395f);
	}

	public void ONJLEAGAKAG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.HODGFKONIFC(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			OICPDNHGCLA();
		}
		if (!HCIJEDFCNOP.EMLLALJBPJF())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.LFJPMNKJBMG();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.OAHAHAGJAPD();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.HIAGDLDLOJO();
			}
		}
	}

	private void AEEKOEDHGAM()
	{
		Vector3 vector = DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1330f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1405f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1160f);
	}

	private void BDLEJBFBIEK()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.FNKIOEHHAMB(base.transform.localScale);
		}
	}

	public void BJHJEDJDCEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.HMMHABFJHEC(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.PNLAIDLOIDE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.BGJKMGJBPFA() && m_PositionModel.DrawErrorGizmo)
		{
			OICPDNHGCLA();
		}
		if (!HCIJEDFCNOP.JKIGCGFEOOE())
		{
			return;
		}
		PPJNLMEJHCN = false;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = true;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.LFJPMNKJBMG();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.AOLDNFKNMAP();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.JBGODNPHENN();
			}
		}
	}

	private void COOIEKBKCPL()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.GLDIJDCGPJG(base.transform.localPosition);
		}
	}

	private void GPMDMOCJONP()
	{
		Vector3 vector = DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1799f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1641f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1680f);
	}

	private void DEEDPNNEJPO()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	private void APJEGOELEGG()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
		}
	}

	private void MNHPFGNPMNL()
	{
		Vector3 vector = DKKKOMOJCIF.MDAKHCPMDIE();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 514f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 95f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1497f);
	}

	private void BHCIENHFBNC()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
		}
	}

	private void GOBHPAJFFDB()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void HLGENFAPEIC()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
		}
	}

	private void LOBECCEMCFA()
	{
		if (m_ScaleModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localScale = JAJKFGFBPIL.GetScale(base.transform.localScale);
		}
	}

	private void HGKEFDMBELD()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
		}
	}

	private void DLNMAGMEIOA()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.PMEKGEFAEON(base.transform.localRotation);
		}
	}

	private void FABKIGNFECE()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			JLDJIHNGDMP();
			HLGENFAPEIC();
			PEGIABKFJNH();
		}
	}

	private void HENBNNAGIKN()
	{
		NBJNCJAJNPP = true;
	}

	private void IACFFKGGFKB()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
		}
	}

	private void PNMCFKNENLJ()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	public void NLCNKMOLPNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		NIJLJGDNBHE.DCKLCCMEGAA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!GDIAJCAHCEC.KCAOJFPDEIP() && m_PositionModel.DrawErrorGizmo)
		{
			JHOGBKNMCIF();
		}
		if (!HCIJEDFCNOP.JKIGCGFEOOE())
		{
			return;
		}
		PPJNLMEJHCN = true;
		if (NBJNCJAJNPP)
		{
			NBJNCJAJNPP = false;
			if (m_PositionModel.SynchronizeEnabled)
			{
				base.transform.localPosition = DKKKOMOJCIF.MDAKHCPMDIE();
			}
			if (m_RotationModel.SynchronizeEnabled)
			{
				base.transform.localRotation = NIJLJGDNBHE.BKIPKPDHDEL();
			}
			if (m_ScaleModel.SynchronizeEnabled)
			{
				base.transform.localScale = JAJKFGFBPIL.PEFDNEOFNBE();
			}
		}
	}

	private void ALOAIMHLEFK()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GetRotation(base.transform.localRotation);
		}
	}

	private void IICACFLHBCP()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void LEHKEGLAPPO()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.JJIODDBPLDP(base.transform.localRotation);
		}
	}

	private void IIPMEPPIFCK()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void JOBBGDGHJMB()
	{
		GDIAJCAHCEC = GetComponent<PhotonView>();
		DKKKOMOJCIF = new PhotonTransformViewPositionControl(m_PositionModel);
		NIJLJGDNBHE = new PhotonTransformViewRotationControl(m_RotationModel);
		JAJKFGFBPIL = new PhotonTransformViewScaleControl(m_ScaleModel);
	}

	private void BBPDDHFHJCG()
	{
		NBJNCJAJNPP = false;
	}

	private void CGEKJECJIKC()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
		}
	}

	private void FGNFILLNPJK()
	{
		if (!(GDIAJCAHCEC == null) && !GDIAJCAHCEC.BGJKMGJBPFA() && PhotonNetwork.connected)
		{
			OHPBHCGDONH();
			IHJHGLDCHFK();
			IPIDOPPAPPH();
		}
	}

	private void FLHBCHLMOFK()
	{
		NBJNCJAJNPP = true;
	}

	private void PMOBDAJCAAP()
	{
		if (m_RotationModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localRotation = NIJLJGDNBHE.GKJEOLEBMMP(base.transform.localRotation);
		}
	}

	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	private void OHPBHCGDONH()
	{
		if (m_PositionModel.SynchronizeEnabled && PPJNLMEJHCN)
		{
			base.transform.localPosition = DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
		}
	}
}
