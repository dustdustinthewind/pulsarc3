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

	public Vector3 CEFBHIBEGAB()
	{
		return LPBKKPPALCD;
	}

	private Vector3 KLGFDJOGMLB()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public void HMMHABFJHEC(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				FPKBPNMNNII(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				BBBMEPOMCFG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 HLGACFLGLDC()
	{
		return LPBKKPPALCD;
	}

	public Vector3 DEGPGKCFBAC()
	{
		return LPBKKPPALCD;
	}

	public Vector3 GLDIJDCGPJG(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = AKMNELPCBBP() + GEJGHPINLPD();
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
				float num = Vector3.Distance(LPBKKPPALCD, FELCBDEGBGJ()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1253f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, AKMNELPCBBP()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = JBJPMKCGNOO();
		}
		return BLPBCOCAKGG;
	}

	public Vector3 GDPAGDLDEHM()
	{
		return LPBKKPPALCD;
	}

	public Vector3 JONNEBEMFBO(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = CEFBHIBEGAB() + OAHDCIGFEJI();
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
				float num = Vector3.Distance(LPBKKPPALCD, OGADNEIBGCO()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 8f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, KOJKJHKJOEH()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = GetNetworkPosition();
		}
		return BLPBCOCAKGG;
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

	public Vector3 KNMEEJEIPKK()
	{
		return LPBKKPPALCD;
	}

	private void GIOKIKOCNDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
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

	public void CLIELFAJGDA(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				AMPGNKAONOD(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				BBBMEPOMCFG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public void OJLAKKDMNCA(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				CEIGPKCPGEI(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GFMJPPAHIFM(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	private void HKIGJEHHIDM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.AIAIEPFCCDO(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.AIAIEPFCCDO(FEMCINHEMEO);
		}
	}

	public void CHEEDIIKAAB(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	private void AMPGNKAONOD(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.NICKMDDINKP(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)8)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.NICKMDDINKP(FEMCINHEMEO);
		}
	}

	public void OAEPJEMIBOB(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	private void GFMJPPAHIFM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			FEMCINHEMEO = (float)HCIJEDFCNOP.EDCDHDJNDPF();
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

	public Vector3 NEIMAGJMAID()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1031f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(582f, FEMCINHEMEO * num, 1730f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)6:
		{
			Vector3 normalized = (LPBKKPPALCD - FIKPJNFFAAB()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 vector = (LPBKKPPALCD - DNCBFGDAEKL()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	private Vector3 MADPPANNBPF()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 DBMFENLECJP()
	{
		return LPBKKPPALCD;
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

	public Vector3 PGKOLFCKMDM()
	{
		return LPBKKPPALCD;
	}

	public Vector3 BGFCECCCFJN()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1687f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = HNCFAJJGIPN.ExtrapolateOption;
		switch (extrapolateOption)
		{
		default:
			if (extrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
			{
				Vector3 vector = (LPBKKPPALCD - CDGKAEFIACI()) * PhotonNetwork.sendRateOnSerialize;
				result = vector * num;
			}
			break;
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(712f, FEMCINHEMEO * num, 1454f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Vector3 normalized = (LPBKKPPALCD - JHKOGMJIOII()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		}
		return result;
	}

	public void IFHKKPEFEOM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				BGLICLBKDBM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				CIANPIEEEIO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	private void FPKBPNMNNII(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.AIAIEPFCCDO(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(FEMCINHEMEO);
		}
	}

	public void EJPKMLLGMGB(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				BGLICLBKDBM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				BBBMEPOMCFG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 NALLHMGJOAD(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = OLMOHIBJGLJ() + GetExtrapolatedPositionOffset();
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
				float num = Vector3.Distance(LPBKKPPALCD, FIKPJNFFAAB()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1478f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, MDAKHCPMDIE()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = PGKOLFCKMDM();
		}
		return BLPBCOCAKGG;
	}

	public Vector3 DBNDJHDKFOD()
	{
		return LPBKKPPALCD;
	}

	public void FHAMLBCLHLK(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	private void BCKLFCHDHFC(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.GJDCOKMGHOG(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)6)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(FEMCINHEMEO);
		}
	}

	private void CEIGPKCPGEI(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.GJDCOKMGHOG(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed)
		{
			HCIJEDFCNOP.SendNext(JPAGJFHJAAB);
			HCIJEDFCNOP.AIAIEPFCCDO(FEMCINHEMEO);
		}
	}

	public Vector3 NCBEMJHNOCP(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = DEGPGKCFBAC() + NEIMAGJMAID();
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
				float num = Vector3.Distance(LPBKKPPALCD, CDGKAEFIACI()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
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
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, DBNDJHDKFOD()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = PGKOLFCKMDM();
		}
		return BLPBCOCAKGG;
	}

	public Vector3 NEJCFEAMOHP(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = DBMFENLECJP() + GEJGHPINLPD();
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
				float num = Vector3.Distance(LPBKKPPALCD, IGIBCMNJJII()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1526f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, CCDBIHJPMGL()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = HLGACFLGLDC();
		}
		return BLPBCOCAKGG;
	}

	public Vector3 GetNetworkPosition()
	{
		return LPBKKPPALCD;
	}

	public void EOBMGCKFNNL(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HKIGJEHHIDM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GIOKIKOCNDM(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public void CNMIIGDELGE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				HKIGJEHHIDM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				OKIIDNOEFJC(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public void GBNDJBNLKLI(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				CEIGPKCPGEI(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				BBBMEPOMCFG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 MMKEFIBHNPA()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 585f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != 0)
		{
			switch (extrapolateOption)
			{
			case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
			{
				Vector3 normalized = (LPBKKPPALCD - CDGKAEFIACI()).normalized;
				result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
				break;
			}
			case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
			{
				Vector3 vector = (LPBKKPPALCD - FAOPHBBFBMP()) * PhotonNetwork.sendRateOnSerialize;
				result = vector * num;
				break;
			}
			}
		}
		else
		{
			Quaternion quaternion = Quaternion.Euler(1099f, FEMCINHEMEO * num, 783f);
			result = quaternion * (JPAGJFHJAAB * num);
		}
		return result;
	}

	public void ENJMPDFKPJD(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public void FODIJCCIION(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				BGLICLBKDBM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				CIANPIEEEIO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 CCDBIHJPMGL()
	{
		return LPBKKPPALCD;
	}

	private Vector3 BONCHCEMGHK()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	private Vector3 CDGKAEFIACI()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public void OIHBJOKGEIE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 OLMOHIBJGLJ()
	{
		return LPBKKPPALCD;
	}

	public void PMMMEJDBJAH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public void CLEFPOJEJJH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 CELBNKNJFOG()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1954f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = HNCFAJJGIPN.ExtrapolateOption;
		switch (extrapolateOption)
		{
		default:
			if (extrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
			{
				Vector3 vector = (LPBKKPPALCD - CDGKAEFIACI()) * PhotonNetwork.sendRateOnSerialize;
				result = vector * num;
			}
			break;
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(790f, FEMCINHEMEO * num, 1481f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed:
		{
			Vector3 normalized = (LPBKKPPALCD - IGIBCMNJJII()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		}
		return result;
	}

	public void BFANAEJEMNB(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 AKMNELPCBBP()
	{
		return LPBKKPPALCD;
	}

	private void OKIIDNOEFJC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Lerp)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
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

	public Vector3 JHBPKKMPBGA()
	{
		return LPBKKPPALCD;
	}

	public void CLNCFAJJONH(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				AMPGNKAONOD(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				GIOKIKOCNDM(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 OMONMIFBHGM(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = GDPAGDLDEHM() + CELBNKNJFOG();
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
				float num = Vector3.Distance(LPBKKPPALCD, FIKPJNFFAAB()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1873f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, HLGACFLGLDC()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = BNHOINJKKJD();
		}
		return BLPBCOCAKGG;
	}

	private Vector3 JHKOGMJIOII()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 MDFMACKDHBH(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = HKIFELDMBKH() + NIPAEGKDNBI();
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
				float num = Vector3.Distance(LPBKKPPALCD, CDGKAEFIACI()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1056f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, DBMFENLECJP()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = DEGPGKCFBAC();
		}
		return BLPBCOCAKGG;
	}

	public Vector3 HKIFELDMBKH()
	{
		return LPBKKPPALCD;
	}

	public void DALBCFGNLLD(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				CEIGPKCPGEI(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				BBBMEPOMCFG(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public Vector3 GOHFIKJIEIK(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = DBFJEBBPHKM() + MAPFEGKAOOG();
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
				float num = Vector3.Distance(LPBKKPPALCD, AOHBGOGDBPD()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1529f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, JPCOPHKFKPK()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = KNMEEJEIPKK();
		}
		return BLPBCOCAKGG;
	}

	private void KFJKLHIPFHJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)7)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.ReceiveNext();
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

	private void BGLICLBKDBM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.NICKMDDINKP(BLPBCOCAKGG);
		LPBKKPPALCD = BLPBCOCAKGG;
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(FEMCINHEMEO);
		}
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

	public void JLPFFACDLJL(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				KFJKLHIPFHJ(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	public Vector3 BNHOINJKKJD()
	{
		return LPBKKPPALCD;
	}

	public Vector3 JPCOPHKFKPK()
	{
		return LPBKKPPALCD;
	}

	private void BBBMEPOMCFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)7)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
			FEMCINHEMEO = (float)HCIJEDFCNOP.MABPFPFGCNL();
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

	private void KPEIFJNEOOK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)7)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.EDCDHDJNDPF();
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

	private Vector3 FELCBDEGBGJ()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 GCBHKONPHIG()
	{
		return LPBKKPPALCD;
	}

	public Vector3 CCJJAHCDNFG()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1722f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(285f, FEMCINHEMEO * num, 1315f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Vector3 normalized = (LPBKKPPALCD - IGIBCMNJJII()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)8:
		{
			Vector3 vector = (LPBKKPPALCD - FELCBDEGBGJ()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	private Vector3 FIKPJNFFAAB()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public void EEDIHPHLNND(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 ICBEHEPIKDC()
	{
		return LPBKKPPALCD;
	}

	public Vector3 GEJGHPINLPD()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1939f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(598f, FEMCINHEMEO * num, 696f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)7:
		{
			Vector3 normalized = (LPBKKPPALCD - MADPPANNBPF()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 vector = (LPBKKPPALCD - FIKPJNFFAAB()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 JBJPMKCGNOO()
	{
		return LPBKKPPALCD;
	}

	public void FBMDDFMGFMF(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				CEIGPKCPGEI(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				OCPONOCDGGO(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = true;
		}
	}

	public Vector3 OMCPBBJKDNG()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1705f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(1592f, FEMCINHEMEO * num, 1905f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)7:
		{
			Vector3 normalized = (LPBKKPPALCD - IGIBCMNJJII()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 vector = (LPBKKPPALCD - JHKOGMJIOII()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 DAFHKAKLKPH()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1927f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(1406f, FEMCINHEMEO * num, 514f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.EstimateSpeedAndTurn:
		{
			Vector3 normalized = (LPBKKPPALCD - KLGFDJOGMLB()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)6:
		{
			Vector3 vector = (LPBKKPPALCD - IGIBCMNJJII()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 KOJKJHKJOEH()
	{
		return LPBKKPPALCD;
	}

	public Vector3 DKHPLAAFJOB()
	{
		return LPBKKPPALCD;
	}

	public Vector3 NIPAEGKDNBI()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1965f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(215f, FEMCINHEMEO * num, 513f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Vector3 normalized = (LPBKKPPALCD - FAOPHBBFBMP()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)4:
		{
			Vector3 vector = (LPBKKPPALCD - FELCBDEGBGJ()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
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

	public void GGADBDONAHA(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 DFKBFCLMBPB()
	{
		return LPBKKPPALCD;
	}

	public void OHMIDABONOM(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
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

	private Vector3 OGADNEIBGCO()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	private Vector3 IGIBCMNJJII()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 1)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	private void CIANPIEEEIO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lPBKKPPALCD = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		if (HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)8)
		{
			JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.MABPFPFGCNL();
			FEMCINHEMEO = (float)HCIJEDFCNOP.MABPFPFGCNL();
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

	public void CGCMLFBANIP(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		JPAGJFHJAAB = KEDDLFDAIDE;
		FEMCINHEMEO = HGHGFIDFHLO;
	}

	public Vector3 ANJLBACAOOL()
	{
		return LPBKKPPALCD;
	}

	private Vector3 AOHBGOGDBPD()
	{
		Vector3 result = LPBKKPPALCD;
		if (LLCJGHBKDJF.Count > 0)
		{
			result = LLCJGHBKDJF.Peek();
		}
		return result;
	}

	public Vector3 DNKFADKBIKC()
	{
		return LPBKKPPALCD;
	}

	public Vector3 MAPFEGKAOOG()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1554f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled:
		{
			Quaternion quaternion = Quaternion.Euler(1045f, FEMCINHEMEO * num, 617f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed:
		{
			Vector3 normalized = (LPBKKPPALCD - FIKPJNFFAAB()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.EstimateSpeedAndTurn:
		{
			Vector3 vector = (LPBKKPPALCD - FAOPHBBFBMP()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
	}

	public Vector3 OAHDCIGFEJI()
	{
		float num = (float)(PhotonNetwork.time - IMNELEFELLD);
		if (HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 634f;
		}
		Vector3 result = Vector3.zero;
		switch (HNCFAJJGIPN.ExtrapolateOption)
		{
		case PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues:
		{
			Quaternion quaternion = Quaternion.Euler(1401f, FEMCINHEMEO * num, 1323f);
			result = quaternion * (JPAGJFHJAAB * num);
			break;
		}
		case PhotonTransformViewPositionModel.ExtrapolateOptions.EstimateSpeedAndTurn:
		{
			Vector3 normalized = (LPBKKPPALCD - FAOPHBBFBMP()).normalized;
			result = normalized * HNCFAJJGIPN.ExtrapolateSpeed * num;
			break;
		}
		case (PhotonTransformViewPositionModel.ExtrapolateOptions)5:
		{
			Vector3 vector = (LPBKKPPALCD - FAOPHBBFBMP()) * PhotonNetwork.sendRateOnSerialize;
			result = vector * num;
			break;
		}
		}
		return result;
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

	public void AAKPEHOAMGP(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.MLCGKMDJIMA())
			{
				BCKLFCHDHFC(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
			}
			else
			{
				OKIIDNOEFJC(HCIJEDFCNOP, DAGALCAILLN);
			}
			IMNELEFELLD = PhotonNetwork.time;
			KNEDICOFDOC = false;
		}
	}

	public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	public Vector3 DBFJEBBPHKM()
	{
		return LPBKKPPALCD;
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

	public Vector3 MMHODJEDELH(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = DBNDJHDKFOD() + CELBNKNJFOG();
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
				float num = Vector3.Distance(LPBKKPPALCD, FAOPHBBFBMP()) / (float)LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			BLPBCOCAKGG = ((JPAGJFHJAAB.magnitude != 1843f) ? Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * JPAGJFHJAAB.magnitude) : vector);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, MDAKHCPMDIE()) > HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = KNMEEJEIPKK();
		}
		return BLPBCOCAKGG;
	}
}
