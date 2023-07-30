// PhotonTransformViewRotationControl
using UnityEngine;

public class PhotonTransformViewRotationControl
{
	private PhotonTransformViewRotationModel HNCFAJJGIPN;

	private Quaternion JNONKGEGLID;

	public Quaternion KGKEOICMONA(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion PABIECBIOEG(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public void OFFPGECPIMN(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Quaternion BOEOKPPMJFP(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion MJAKBALLDGD()
	{
		return JNONKGEGLID;
	}

	public Quaternion NGBKFIJDLFH()
	{
		return JNONKGEGLID;
	}

	public void HMMHABFJHEC(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion OCEPLKNPOCD()
	{
		return JNONKGEGLID;
	}

	public Quaternion GCEHLPKIMKH()
	{
		return JNONKGEGLID;
	}

	public Quaternion GetNetworkRotation()
	{
		return JNONKGEGLID;
	}

	public Quaternion GetRotation(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion OJIMODNLGBG()
	{
		return JNONKGEGLID;
	}

	public void KLFPENLPMJP(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void AAAGGIHAKEH(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public Quaternion EBOCNAOMKPE(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public void LBDNIDJNDJK(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.GJDCOKMGHOG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Quaternion AEDBNKAAGEH(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public void GGEKDHHOOCH(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.NICKMDDINKP(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.MABPFPFGCNL();
			}
		}
	}

	public Quaternion JIHNIHKFFBN(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public void OnPhotonSerializeView(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion GKJEOLEBMMP(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion ABCJPDICMOB(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion JEGCEPGNLFF(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	public Quaternion EOCHBNJBOII(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion CCNJIHHJCKA()
	{
		return JNONKGEGLID;
	}

	public Quaternion AIBFAOHLPKA()
	{
		return JNONKGEGLID;
	}

	public Quaternion MENCBKEOJLN(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion EFGEHCMCCLE()
	{
		return JNONKGEGLID;
	}

	public Quaternion CDIMMMCAFDG(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion AIKONMOBJOF(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion PEPILCKHHNG(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion LCGBAAIDOHE()
	{
		return JNONKGEGLID;
	}

	public Quaternion PKPOJPAJGFB()
	{
		return JNONKGEGLID;
	}

	public Quaternion NMAGOKCJCGF(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public void CLNCFAJJONH(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.EDCDHDJNDPF();
			}
		}
	}

	public Quaternion OOHHCGOMOFM(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion EOGMILGMGLH()
	{
		return JNONKGEGLID;
	}

	public Quaternion DAFCPIJGBEK()
	{
		return JNONKGEGLID;
	}

	public Quaternion KHNGEMPHIAP()
	{
		return JNONKGEGLID;
	}

	public Quaternion NKAMJHFKFFE(Quaternion LJCFLDEONDG)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, JNONKGEGLID, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Quaternion ELLHGIGIPDE()
	{
		return JNONKGEGLID;
	}

	public void MPGJDLCANPA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.AIAIEPFCCDO(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion EJONOHDCBLA()
	{
		return JNONKGEGLID;
	}
}
