// PhotonTransformViewScaleControl
using UnityEngine;

public class PhotonTransformViewScaleControl
{
	private PhotonTransformViewScaleModel HNCFAJJGIPN;

	private Vector3 ENAJHAMBNFK = Vector3.one;

	public Vector3 JHLAPBECKPH()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 NKLAIOJCAHD(Vector3 MGMPJFHHBMM)
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

	public Vector3 MPJGCCAJAOA()
	{
		return ENAJHAMBNFK;
	}

	public void KLFPENLPMJP(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	public Vector3 OMAOHOBIMNM(Vector3 MGMPJFHHBMM)
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

	public void BAEICBGEECA(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.PNAPNHJHBMN(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	public Vector3 BMOPJJPOKEE()
	{
		return ENAJHAMBNFK;
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

	public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	public Vector3 HJKPAPHBNND(Vector3 MGMPJFHHBMM)
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

	public void COHGAEMDFEI(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.FADAIFFMBEL(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	public Vector3 FLFKMOEGOKL()
	{
		return ENAJHAMBNFK;
	}

	public void DLFLONFGGGG(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.CPIBABMPJLE(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public Vector3 GetNetworkScale()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 DBBAOGADAFG()
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

	public void FBMDDFMGFMF(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				HCIJEDFCNOP.FADAIFFMBEL(MGMPJFHHBMM);
				ENAJHAMBNFK = MGMPJFHHBMM;
			}
			else
			{
				ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public Vector3 IACAMHINPMK()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 HIAGDLDLOJO()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 GCKHEBOACNA(Vector3 MGMPJFHHBMM)
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

	public Vector3 GIMLEHMPBKA()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 PEFDNEOFNBE()
	{
		return ENAJHAMBNFK;
	}

	public Vector3 FNKIOEHHAMB(Vector3 MGMPJFHHBMM)
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

	public Vector3 JBGODNPHENN()
	{
		return ENAJHAMBNFK;
	}
}
