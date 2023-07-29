// PhotonTransformViewRotationControl
using UnityEngine;

public class PhotonTransformViewRotationControl
{
	private PhotonTransformViewRotationModel HNCFAJJGIPN;

	private Quaternion JNONKGEGLID;

	public Quaternion MEBDCCHLBEH(Quaternion LJCFLDEONDG)
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

	public void DEKGPEDBDJE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
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

	public void FOHGOGIMPJJ(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	public Quaternion JHEBHGPEKHK(Quaternion LJCFLDEONDG)
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

	public Quaternion GLDKMEANMAL(Quaternion LJCFLDEONDG)
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

	public Quaternion HCGAJCIDHPO(Quaternion LJCFLDEONDG)
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

	public Quaternion NCMHIMAKPCK()
	{
		return JNONKGEGLID;
	}

	public void PNLAIDLOIDE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion EOGMILGMGLH()
	{
		return JNONKGEGLID;
	}

	public Quaternion NOMHOGGPPBG()
	{
		return JNONKGEGLID;
	}

	public Quaternion BFGDOFKCPGN()
	{
		return JNONKGEGLID;
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

	public void MOLNBJLBPOO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public void MCEKDLDCGAO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public Quaternion FMKLCNHHPGM()
	{
		return JNONKGEGLID;
	}

	public Quaternion FAHKNKNOGPA()
	{
		return JNONKGEGLID;
	}

	public Quaternion JPJLCPLIOCA()
	{
		return JNONKGEGLID;
	}

	public Quaternion GetNetworkRotation()
	{
		return JNONKGEGLID;
	}

	public Quaternion EJONOHDCBLA()
	{
		return JNONKGEGLID;
	}

	public void FBBMPGICGKC(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public void EJPKMLLGMGB(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public Quaternion KGPEHOLHPDF()
	{
		return JNONKGEGLID;
	}

	public Quaternion CKHDHEGPMHB()
	{
		return JNONKGEGLID;
	}

	public Quaternion JJIODDBPLDP(Quaternion LJCFLDEONDG)
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

	public void BJHJEDJDCEN(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.FADAIFFMBEL(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public void JLPFFACDLJL(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	public Quaternion JIDMMGNNJNB()
	{
		return JNONKGEGLID;
	}

	public Quaternion GBGENCNGBJH()
	{
		return JNONKGEGLID;
	}

	public Quaternion IGMHPDBMMMH(Quaternion LJCFLDEONDG)
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

	public Quaternion OAHAHAGJAPD()
	{
		return JNONKGEGLID;
	}

	public Quaternion NNKFAAFFADP(Quaternion LJCFLDEONDG)
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

	public void NMMEHKPNBCA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.FADAIFFMBEL(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion OCIAPBJGCOM(Quaternion LJCFLDEONDG)
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

	public Quaternion DMPPHLOHFKA(Quaternion LJCFLDEONDG)
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

	public void DAFGPDBLAMA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Quaternion HAGGDALINJC()
	{
		return JNONKGEGLID;
	}

	public Quaternion BKIPKPDHDEL()
	{
		return JNONKGEGLID;
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

	public Quaternion PMEKGEFAEON(Quaternion LJCFLDEONDG)
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

	public Quaternion KLHIJOJANBB()
	{
		return JNONKGEGLID;
	}

	public void HPGOHBHACKF(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.BBHGPGBHMML(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	public Quaternion NBHOLMCPBAE(Quaternion LJCFLDEONDG)
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

	public Quaternion CEPDDADCDCG()
	{
		return JNONKGEGLID;
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

	public Quaternion AGKPEIKIPJI()
	{
		return JNONKGEGLID;
	}

	public Quaternion KHNGEMPHIAP()
	{
		return JNONKGEGLID;
	}

	public void DHCCMDLAJIO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public Quaternion CEABHPLMEPO()
	{
		return JNONKGEGLID;
	}

	public Quaternion AOLDNFKNMAP()
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

	public Quaternion MJAKBALLDGD()
	{
		return JNONKGEGLID;
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

	public Quaternion POGBNHOFEGA()
	{
		return JNONKGEGLID;
	}

	public Quaternion GKKBHDPOBFN(Quaternion LJCFLDEONDG)
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

	public void CNMIIGDELGE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	public void JNENAPDBOKE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.SendNext(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public Quaternion HODEBPDPNLN()
	{
		return JNONKGEGLID;
	}

	public void GBNDJBNLKLI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public Quaternion BMKBHDKEOHO(Quaternion LJCFLDEONDG)
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

	public void HOGEJPIBJAL(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	public Quaternion JAOFDDCABEG()
	{
		return JNONKGEGLID;
	}

	public void JJGHNKLDANI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public void HHODOGMIJGI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.isWriting)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel PMLNAMDEBFI)
	{
		HNCFAJJGIPN = PMLNAMDEBFI;
	}

	public void DCKLCCMEGAA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	public void LBLAKDBHADA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.GKJCHGIMOEJ())
			{
				HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	public void HODGFKONIFC(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	public Quaternion PGGPFBOADOB()
	{
		return JNONKGEGLID;
	}

	public Quaternion OAKCMDFCILC(Quaternion LJCFLDEONDG)
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

	public void HDPOECGCALE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.FAOJEFAMBFN())
			{
				HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	public void MKPBBAPGGND(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HNCFAJJGIPN.SynchronizeEnabled)
		{
			if (HCIJEDFCNOP.PGJIELMHMEJ())
			{
				HCIJEDFCNOP.OLACNHHHOEL(LJCFLDEONDG);
				JNONKGEGLID = LJCFLDEONDG;
			}
			else
			{
				JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	public Quaternion GFLGLDGIGLK()
	{
		return JNONKGEGLID;
	}
}
