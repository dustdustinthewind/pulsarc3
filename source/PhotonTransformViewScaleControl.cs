// PhotonTransformViewScaleControl
using UnityEngine;

public class PhotonTransformViewScaleControl
{
	private PhotonTransformViewScaleModel HNCFAJJGIPN;

	private Vector3 ENAJHAMBNFK = Vector3.one;

	public void OCPCKNHCMKP(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.AIAIEPFCCDO(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Vector3 HNDBPLMHBDH(Vector3 MGMPJFHHBMM)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Vector3 GetScale(Vector3 MGMPJFHHBMM)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Vector3 PEFDNEOFNBE()
	{
		return ENAJHAMBNFK;
	}

	public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	public void DCKLCCMEGAA(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.SendNext(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public void GBOFDLLNLLL(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.GJDCOKMGHOG(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public void HBBLLHAOBLE(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HCIJEDFCNOP.NICKMDDINKP(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Vector3 LAGCPMPNEBJ()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 ABCGHBHCKIK(Vector3 MGMPJFHHBMM)
	{
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, ENAJHAMBNFK, HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	public Vector3 LFLEBBLFHNO()
	{
		return ENAJHAMBNFK;
	}

	public void OnPhotonSerializeView(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.SendNext(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Vector3 CLPJDAHHOAN()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 CADLHOPJEBH()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 GetNetworkScale()
	{
		return ENAJHAMBNFK;
	}
}
