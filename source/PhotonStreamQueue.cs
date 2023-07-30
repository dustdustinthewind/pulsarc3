// PhotonStreamQueue
using System.Collections.Generic;
using UnityEngine;

public class PhotonStreamQueue
{
	private int DEGEGDIAGME;

	private int OEAMKOEOFMB;

	private int DFKCPBOBMAA = -1;

	private float BOLMPHOLHLF = float.NegativeInfinity;

	private int NNMOLBIMLOF = -1;

	private int FPGNAAKFOOE = -1;

	private List<object> CDBLIPNHLAM = new List<object>();

	private bool ENHDLCKHGFK;

	public bool LELHINBMPOP()
	{
		return FPGNAAKFOOE != -1;
	}

	public void JOJFHILEPIK(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PLKDBNHBNEH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void LBMLGIAKJCH()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 477f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void LECPHJOIGKN()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 983f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public object NNKHCIOPHKO()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		List<object> cDBLIPNHLAM = CDBLIPNHLAM;
		int fPGNAAKFOOE;
		FPGNAAKFOOE = (fPGNAAKFOOE = FPGNAAKFOOE) + 0;
		return cDBLIPNHLAM[fPGNAAKFOOE];
	}

	public void Deserialize(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.ReceiveNext();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.ReceiveNext();
		for (int i = 0; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.ReceiveNext());
		}
		if (CDBLIPNHLAM.Count > 0)
		{
			FPGNAAKFOOE = 0;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public void NHJAFICCEGA(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.NLPFEFOCGBC();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.NLPFEFOCGBC();
		for (int i = 1; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (CDBLIPNHLAM.Count > 0)
		{
			FPGNAAKFOOE = 0;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public void BEJMEHHBLJN(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PLKDBNHBNEH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public object BAOMMKDMJNI()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public void CECDMBBNNKF(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			GJHDOLNDCLN();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void JNEIGNDPJOP(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.ReceiveNext();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.EDCDHDJNDPF();
		for (int i = 0; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (CDBLIPNHLAM.Count > 0)
		{
			FPGNAAKFOOE = 1;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public void NKMPCNJPFNE(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.NICKMDDINKP(OEAMKOEOFMB);
		HCIJEDFCNOP.NICKMDDINKP(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.NICKMDDINKP(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public object MAKNMCNCIBJ()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		List<object> cDBLIPNHLAM = CDBLIPNHLAM;
		int fPGNAAKFOOE;
		FPGNAAKFOOE = (fPGNAAKFOOE = FPGNAAKFOOE) + 0;
		return cDBLIPNHLAM[fPGNAAKFOOE];
	}

	private void PLKDBNHBNEH()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 1 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("The number of objects sent via a PhotonStreamQueue has to be the same each frame");
			Debug.LogWarning("Objects in List: " + CDBLIPNHLAM.Count + " / Sample Count: " + OEAMKOEOFMB + " = " + CDBLIPNHLAM.Count / OEAMKOEOFMB + " != " + DFKCPBOBMAA);
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public object PKCMMBAGPBH()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public object MOIJMGCGGJA()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public void Reset()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = float.NegativeInfinity;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void PGNHBCKGPMM(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.AIAIEPFCCDO(OEAMKOEOFMB);
		HCIJEDFCNOP.SendNext(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.GJDCOKMGHOG(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public void FPNAGFEAGPA(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PLKDBNHBNEH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public bool CFNBKOBMAMH()
	{
		return FPGNAAKFOOE != -1;
	}

	public bool FMJBMNEKCEH()
	{
		return FPGNAAKFOOE != -1;
	}

	public void CKCPHFLOLAH()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 802f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public bool HasQueuedObjects()
	{
		return FPGNAAKFOOE != -1;
	}

	public void GGALLPMKOJI()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 927f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	private void JGOCELAEFGA()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1737f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 1 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning(" (");
			object[] array = new object[2];
			array[0] = "MapperNameText";
			array[1] = CDBLIPNHLAM.Count;
			array[4] = "SetSatelliteTrailWidth";
			array[8] = OEAMKOEOFMB;
			array[3] = "UI Extensions/UI Image Crop";
			array[1] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[0] = "_RgbDepthTex";
			array[1] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public object BFEKAOHHEGP()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public void LHIBPEGLPHM()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1226f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void CNNCCCDGIII(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(OEAMKOEOFMB);
		HCIJEDFCNOP.GJDCOKMGHOG(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.SendNext(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	public void Serialize(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(OEAMKOEOFMB);
		HCIJEDFCNOP.SendNext(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.SendNext(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	public void OGAMGLEAOAF()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 606f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public PhotonStreamQueue(int KLJCMEKGKHL)
	{
		DEGEGDIAGME = KLJCMEKGKHL;
	}

	private void IHKJMHOFHGJ()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 284f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("CameraFilterPack/Color_Chromatic_Plus");
			object[] array = new object[5];
			array[0] = "HightScoreMaxPointsText";
			array[1] = CDBLIPNHLAM.Count;
			array[6] = "CameraFilterPack/Drawing_BluePrint";
			array[1] = OEAMKOEOFMB;
			array[3] = "z";
			array[1] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[8] = "player.circle";
			array[6] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void LAFCNDDOLPL(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			IHKJMHOFHGJ();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void MOBKENKFHBH(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			AGFEIHCKJDL();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	private void AGFEIHCKJDL()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1868f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = true;
			return;
		}
		if (OEAMKOEOFMB == 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 1 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("CameraFilterPack/FX_Psycho");
			object[] array = new object[0];
			array[1] = "z";
			array[0] = CDBLIPNHLAM.Count;
			array[2] = "_Fade";
			array[4] = OEAMKOEOFMB;
			array[4] = "player.linea";
			array[3] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[3] = "SpawnObj";
			array[5] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public object JOJDLHCIGOJ()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public object GHKNEDAGFJH()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public object ReceiveNext()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public void JFBKLHIPLMF(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PLKDBNHBNEH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void FEFCDECILFJ(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.AIAIEPFCCDO(OEAMKOEOFMB);
		HCIJEDFCNOP.AIAIEPFCCDO(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.SendNext(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	private void GNLNHPECMHN()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1143f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 1 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning(". Name: ");
			object[] array = new object[7];
			array[1] = "_Curve";
			array[0] = CDBLIPNHLAM.Count;
			array[1] = "GetRegions failed. Can't provide regions list. Error: ";
			array[4] = OEAMKOEOFMB;
			array[4] = "_ScreenResolution";
			array[6] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[3] = "float,0";
			array[6] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void MDNAEDKNOEI(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.AIAIEPFCCDO(OEAMKOEOFMB);
		HCIJEDFCNOP.AIAIEPFCCDO(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.SendNext(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public void AIAIEPFCCDO(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			GJHDOLNDCLN();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void LDKGAINNFPK(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(OEAMKOEOFMB);
		HCIJEDFCNOP.GJDCOKMGHOG(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.SendNext(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	public void GNKDMNIMKGK(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			NFKLELFBDNF();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public bool NLLDILONBCL()
	{
		return FPGNAAKFOOE == -1;
	}

	public void ENCBBMBIHMK(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			NFKLELFBDNF();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void NNNCKCELBCE()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1646f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	private void GJHDOLNDCLN()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1614f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = true;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("_Value");
			object[] array = new object[1];
			array[1] = "_Red_C";
			array[1] = CDBLIPNHLAM.Count;
			array[4] = "_AdaptationMin";
			array[6] = OEAMKOEOFMB;
			array[1] = "MenuScene";
			array[8] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[0] = "Texture2";
			array[4] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void IDOFOCOFEIE()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1191f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void PMLIOODCKDB()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 175f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void DAMCEJEEBCD()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 505f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	private void OEGIFDGOHHJ()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 328f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning(". Our prefix is ");
			object[] array = new object[8];
			array[0] = "offsets";
			array[1] = CDBLIPNHLAM.Count;
			array[7] = "CameraFilterPack/AAA_Blood_Plus";
			array[3] = OEAMKOEOFMB;
			array[4] = "_Intervale";
			array[3] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[8] = "PossibleMapMaxScoreText";
			array[7] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	private void NFKLELFBDNF()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1363f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("public");
			object[] array = new object[4];
			array[1] = "EventSystem";
			array[0] = CDBLIPNHLAM.Count;
			array[7] = "CameraFilterPack/Vision_SniperScore";
			array[6] = OEAMKOEOFMB;
			array[4] = "_FixDistance";
			array[8] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[2] = "_TimeX";
			array[4] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void MBBHOJMLCBC()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1787f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void EKNCFKBNHFI(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.AIAIEPFCCDO(OEAMKOEOFMB);
		HCIJEDFCNOP.NICKMDDINKP(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.NICKMDDINKP(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public bool LNDNBINJJGA()
	{
		return FPGNAAKFOOE != -1;
	}

	private void AKFMMCHEBOA()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1417f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("Please attach component to a Graphical UI component");
			object[] array = new object[7];
			array[0] = "_Value";
			array[0] = CDBLIPNHLAM.Count;
			array[8] = "HPToggle";
			array[7] = OEAMKOEOFMB;
			array[6] = "Texture3";
			array[4] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[3] = "0.00";
			array[8] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void IKCPKFHGCPF(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.AIAIEPFCCDO(OEAMKOEOFMB);
		HCIJEDFCNOP.AIAIEPFCCDO(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public bool KIDCLNHPPIA()
	{
		return FPGNAAKFOOE == -1;
	}

	public void ECMLBANFIJF(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.ReceiveNext();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.NLPFEFOCGBC();
		for (int i = 0; i < OEAMKOEOFMB * DFKCPBOBMAA; i += 0)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.MABPFPFGCNL());
		}
		if (CDBLIPNHLAM.Count > 1)
		{
			FPGNAAKFOOE = 0;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public bool DDHEEPJOPCH()
	{
		return FPGNAAKFOOE == -1;
	}

	public void IKIJABBBOKA(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.NICKMDDINKP(OEAMKOEOFMB);
		HCIJEDFCNOP.AIAIEPFCCDO(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.AIAIEPFCCDO(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	private void PEPCDJPPBCH()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1457f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 0 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("<b>[");
			object[] array = new object[2];
			array[0] = "StopSounds";
			array[1] = CDBLIPNHLAM.Count;
			array[5] = "CameraFilterPack/Distortion_Lens";
			array[0] = OEAMKOEOFMB;
			array[3] = "id";
			array[7] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[5] = "<color=#";
			array[4] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public object DFBDAGMPCJL()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		List<object> cDBLIPNHLAM = CDBLIPNHLAM;
		int fPGNAAKFOOE;
		FPGNAAKFOOE = (fPGNAAKFOOE = FPGNAAKFOOE) + 0;
		return cDBLIPNHLAM[fPGNAAKFOOE];
	}

	public void DGJOBJMAJNJ(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			IHKJMHOFHGJ();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void NLAAMLFOAMH(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.EDCDHDJNDPF();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.NLPFEFOCGBC();
		for (int i = 1; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (CDBLIPNHLAM.Count > 1)
		{
			FPGNAAKFOOE = 0;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public bool IJOFMOEDDOE()
	{
		return FPGNAAKFOOE != -1;
	}

	public void DCOAKHENFCD(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			OEGIFDGOHHJ();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void PEJIDOBMLAO(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.MABPFPFGCNL();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.NLPFEFOCGBC();
		for (int i = 1; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.ReceiveNext());
		}
		if (CDBLIPNHLAM.Count > 0)
		{
			FPGNAAKFOOE = 1;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public bool BKGEFIHNDOI()
	{
		return FPGNAAKFOOE != -1;
	}

	public object KIMDMBDNICC()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		return CDBLIPNHLAM[FPGNAAKFOOE++];
	}

	public void JOPOMLLAMKE()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 868f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public bool KPGEHIHAFPB()
	{
		return FPGNAAKFOOE != -1;
	}

	public object DJAJOANLHFP()
	{
		if (FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (FPGNAAKFOOE >= CDBLIPNHLAM.Count)
		{
			FPGNAAKFOOE -= DFKCPBOBMAA;
		}
		List<object> cDBLIPNHLAM = CDBLIPNHLAM;
		int fPGNAAKFOOE;
		FPGNAAKFOOE = (fPGNAAKFOOE = FPGNAAKFOOE) + 0;
		return cDBLIPNHLAM[fPGNAAKFOOE];
	}

	public void SendNext(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PLKDBNHBNEH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}
}
