// PhotonTransformViewPositionControl
using System.Collections.Generic;
using UnityEngine;

public class PhotonTransformViewPositionControl
{
	private PhotonTransformViewPositionModel HNCFAJJGIPN;

	private float JEEKDHDNPKB;

	private double IMNELEFELLD;

	private Vector3 JPAGJFHJAAB = Vector3.zero;

	private float FEMCINHEMEO;

	private Vector3 LPBKKPPALCD;

	private Queue<Vector3> LLCJGHBKDJF = new Queue<Vector3>();

	private bool KNEDICOFDOC = true;

	public void DLFLONFGGGG(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GFNOFOOGLHA(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private Vector3 DJGBPPCBIAP()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	private void GOMDFKNFIDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			FEMCINHEMEO = (float)HCIJEDFCNOP.ReceiveNext();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public Vector3 MDAKHCPMDIE()
	{
		return LPBKKPPALCD;
	}

	public void OnPhotonSerializeView(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				OCPONOCDGGO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private void OCPONOCDGGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.ReceiveNext();
			FEMCINHEMEO = (float)HCIJEDFCNOP.ReceiveNext();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	private void AEACCHDDKDN(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PBECMJMDHBI(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)5)
		{
			HCIJEDFCNOP.FADAIFFMBEL(JPAGJFHJAAB);
			HCIJEDFCNOP.FADAIFFMBEL(FEMCINHEMEO);
		}
	}

	private void MAKLJGJLMGM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.SendNext(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(FEMCINHEMEO);
		}
	}

	private Vector3 NBDLINFNPDD()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 GetNetworkPosition()
	{
		return LPBKKPPALCD;
	}

	public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	private void DLIEMONDDJB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			FEMCINHEMEO = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public Vector3 FBGHNHMHIFM(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = GetNetworkPosition() + NEIMAGJMAID();
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				KNEDICOFDOC = false;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(LPBKKPPALCD, EPAOHJJPLHF()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 927f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, NLNDBCNKLJH()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = GetNetworkPosition();
		}
		return BLPBCOCAKGG;
	}

	private Vector3 MADPPANNBPF()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 MAPFEGKAOOG()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1222f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(1115f, FEMCINHEMEO * num, 819f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)8:
		{
			Vector3 normalized = (LPBKKPPALCD - DJGBPPCBIAP()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed:
		{
			Vector3 vector = (LPBKKPPALCD - DJGBPPCBIAP()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 NEIMAGJMAID()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1153f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
		{
			switch (extrapolateOption)
			{
			case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
			{
				Vector3 normalized = (LPBKKPPALCD - IBCEDCJHLAM()).normalized;
				result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
				break;
			}
			case (PhotonTransformViewPositionModel.ExtrapolateOptions)7:
			{
				Vector3 vector = (LPBKKPPALCD - MADPPANNBPF()) * PhotonNetwork.sendRateOnSerialize;
				result = vector * num;
				break;
			}
			}
		}
		else
		{
			Quaternion quaternion = Quaternion.Euler(1607f, FEMCINHEMEO * num, 1661f);
			result = quaternion * (JPAGJFHJAAB * num);
		}
		return result;
	}

	private Vector3 FAOPHBBFBMP()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 JHBPKKMPBGA()
	{
		return LPBKKPPALCD;
	}

	private void CGDCPIBAGCO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)7)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			FEMCINHEMEO = (float)HCIJEDFCNOP.IDKHBJIHKEB();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public Vector3 DEEDPNNEJPO(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = NLNDBCNKLJH() + NEIMAGJMAID();
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				KNEDICOFDOC = false;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(LPBKKPPALCD, DEKDAMEJFGB()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 390f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, GetNetworkPosition()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = NLNDBCNKLJH();
		}
		return BLPBCOCAKGG;
	}

	private Vector3 DNCBFGDAEKL()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public void DEKGPEDBDJE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				FAPILEEODKG(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				LCOGBDHHONG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private void IKCDKEKJCCA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)6)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			FEMCINHEMEO = (float)HCIJEDFCNOP.LNDLNKJPAGO();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	private Vector3 DEKDAMEJFGB()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	private Vector3 IBCEDCJHLAM()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public void CNABAIGBLIC(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 GLDIJDCGPJG(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = JHBPKKMPBGA() + MGLDFCEODCA();
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(LPBKKPPALCD, DNCBFGDAEKL()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 93f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, APJJAKOIMIK()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = LFJPMNKJBMG();
		}
		return BLPBCOCAKGG;
	}

	public void PKDPLHBMKPM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				FAPILEEODKG(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				CGDCPIBAGCO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	private void LCOGBDHHONG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Lerp)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			FEMCINHEMEO = (float)HCIJEDFCNOP.HPPOACOIMOJ();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public Vector3 UpdatePosition(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = GetNetworkPosition() + GetExtrapolatedPositionOffset();
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(LPBKKPPALCD, DNCBFGDAEKL()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 0f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, GetNetworkPosition()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = GetNetworkPosition();
		}
		return BLPBCOCAKGG;
	}

	public void PNLAIDLOIDE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				LCOGBDHHONG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	private void GFNOFOOGLHA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)8)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.ReceiveNext();
			FEMCINHEMEO = (float)HCIJEDFCNOP.FIBMOBNIALK();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public Vector3 FLFDHNJMIOC()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 540f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(161f, FEMCINHEMEO * num, 1645f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 normalized = (LPBKKPPALCD - DEKDAMEJFGB()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)8:
		{
			Vector3 vector = (LPBKKPPALCD - DJGBPPCBIAP()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 CBALKDFGNPE()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 736f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(931f, FEMCINHEMEO * num, 203f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed:
		{
			Vector3 normalized = (LPBKKPPALCD - DNCBFGDAEKL()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)8:
		{
			Vector3 vector = (LPBKKPPALCD - IBCEDCJHLAM()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 APJJAKOIMIK()
	{
		return LPBKKPPALCD;
	}

	public Vector3 GetExtrapolatedPositionOffset()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1000f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(0f, FEMCINHEMEO * num, 0f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed:
		{
			Vector3 normalized = (LPBKKPPALCD - DNCBFGDAEKL()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.EstimateSpeedAndTurn:
		{
			Vector3 vector = (LPBKKPPALCD - DNCBFGDAEKL()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 BEDHNBMPPGM(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = APJJAKOIMIK() + CBALKDFGNPE();
		switch (HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(LPBKKPPALCD, IBCEDCJHLAM()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 888f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, NLNDBCNKLJH()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = LFJPMNKJBMG();
		}
		return BLPBCOCAKGG;
	}

	private void NDOFEBPLPBC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			FEMCINHEMEO = (float)HCIJEDFCNOP.NLPFEFOCGBC();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	private void NLCMPPDJJAJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			FEMCINHEMEO = (float)HCIJEDFCNOP.IDKHBJIHKEB();
		}
		if (LLCJGHBKDJF.Count == 0)
		{
			LPBKKPPALCD = lPBKKPPALCD;
		}
		LLCJGHBKDJF.Enqueue(LPBKKPPALCD);
		LPBKKPPALCD = lPBKKPPALCD;
		while (LLCJGHBKDJF.Count > HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			LLCJGHBKDJF.Dequeue();
		}
	}

	public void HIDJLJIEPHK(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				AEACCHDDKDN(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GFNOFOOGLHA(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private void FAPILEEODKG(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.IBCLJIACBKG(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(JPAGJFHJAAB);
			HCIJEDFCNOP.CPIBABMPJLE(FEMCINHEMEO);
		}
	}

	public Vector3 NLNDBCNKLJH()
	{
		return LPBKKPPALCD;
	}

	public Vector3 LFJPMNKJBMG()
	{
		return LPBKKPPALCD;
	}

	public Vector3 ECGDJCOKCBF()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 737f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = HNCFAJJGIPN.ExtrapolateOption;
		switch (extrapolateOption)
		{
		default:
			if (extrapolateOption == (PhotonTransformViewPositionModel.ExtrapolateOptions)4)
			{
				Vector3 vector = (LPBKKPPALCD - DEKDAMEJFGB()) * PhotonNetwork.sendRateOnSerialize;
				result = vector * num;
			}
			break;
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(1224f, FEMCINHEMEO * num, 1456f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 normalized = (LPBKKPPALCD - DNCBFGDAEKL()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		}
		return result;
	}

	private void DLMGGIPOMCE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PBECMJMDHBI(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			HCIJEDFCNOP.PBECMJMDHBI(JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(FEMCINHEMEO);
		}
	}

	public void FBMDDFMGFMF(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				DLIEMONDDJB(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	public void HMMHABFJHEC(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GOMDFKNFIDK(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private void OCPFJLCANNF(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PNAPNHJHBMN(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.BBHGPGBHMML(FEMCINHEMEO);
		}
	}

	private Vector3 EPAOHJJPLHF()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 MGLDFCEODCA()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 478f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(340f, FEMCINHEMEO * num, 761f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)6:
		{
			Vector3 normalized = (LPBKKPPALCD - IBCEDCJHLAM()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Vector3 vector = (LPBKKPPALCD - MADPPANNBPF()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public void AAAGGIHAKEH(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				CGDCPIBAGCO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}
}
