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

	public void ILHKKFBHAIC(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			FEOGOEFJOMF();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	private void EBFBEHNJGGF()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 651f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("_Distortion");
			object[] array = new object[6];
			array[1] = "Run a command for the Localization Servise";
			array[1] = CDBLIPNHLAM.Count;
			array[4] = "UseScanLineSize";
			array[0] = OEAMKOEOFMB;
			array[4] = " = ";
			array[0] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[8] = "_Value";
			array[6] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void DGJOBJMAJNJ(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			EBFBEHNJGGF();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void AIAIEPFCCDO(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			GPMNBGAKMPB();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void HBDJEFBMFEP(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.CPIBABMPJLE(OEAMKOEOFMB);
		HCIJEDFCNOP.PNAPNHJHBMN(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.FADAIFFMBEL(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
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

	public void HPCOFADNBPA(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			KPJALJOEEGI();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public bool ECAILPILEGB()
	{
		return FPGNAAKFOOE == -1;
	}

	public void BPDLLMHJBPP(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.BBHGPGBHMML(OEAMKOEOFMB);
		HCIJEDFCNOP.PBECMJMDHBI(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.PBECMJMDHBI(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public void DNGKBKCBICG(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.PNAPNHJHBMN(OEAMKOEOFMB);
		HCIJEDFCNOP.SendNext(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.BBHGPGBHMML(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public void JBCGIHLGLIJ(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.KIEJNJBDAJJ();
		for (int i = 0; i < OEAMKOEOFMB * DFKCPBOBMAA; i += 0)
		{
			CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (CDBLIPNHLAM.Count > 1)
		{
			FPGNAAKFOOE = 1;
		}
		else
		{
			FPGNAAKFOOE = -1;
		}
	}

	public bool OJDBMJDAHPH()
	{
		return FPGNAAKFOOE != -1;
	}

	public void KHMCLKHDKAN(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.ACOGAHJKGJH();
		for (int i = 1; i < OEAMKOEOFMB * DFKCPBOBMAA; i++)
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

	public void FIDPDKNOIFH(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			JAGPJBEJCGA();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public bool POPNINEGMHF()
	{
		return FPGNAAKFOOE != -1;
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

	public void IBCKJIHGKAI(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			LCHODHLMJCH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void OJECBKEMOBH()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 187f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	private void FHCGFCEBKGH()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1692f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("_Value6");
			object[] array = new object[2];
			array[0] = "id";
			array[1] = CDBLIPNHLAM.Count;
			array[4] = "CameraFilterPack/TV_PlanetMars";
			array[1] = OEAMKOEOFMB;
			array[0] = "_Threshhold";
			array[5] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[0] = "_Speed";
			array[6] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public bool DDJDIKMONBJ()
	{
		return FPGNAAKFOOE != -1;
	}

	public object IKEKLFCNONN()
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

	private void JAGPJBEJCGA()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1195f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("_SampleScale");
			object[] array = new object[5];
			array[1] = "shader.pixel";
			array[0] = CDBLIPNHLAM.Count;
			array[1] = "[LevelEditorScene] Error: You're not logged into Steam!";
			array[8] = OEAMKOEOFMB;
			array[7] = ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
			array[8] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[8] = "CameraFilterPack_RainFX_Anm2";
			array[8] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void OGKGIAAACAD()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1293f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public bool MNDENFOIGLI()
	{
		return FPGNAAKFOOE == -1;
	}

	public void LCKFPEJGGHF(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 0 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.BBHGPGBHMML(OEAMKOEOFMB);
		HCIJEDFCNOP.IBCLJIACBKG(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.BBHGPGBHMML(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 1;
	}

	public object LHDLFDPJLEA()
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

	public void DDHLHOGOGNP(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			PNPDEOMKPMC();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void ABKGKDOLPBF(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 1)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.OLACNHHHOEL(OEAMKOEOFMB);
		HCIJEDFCNOP.OLACNHHHOEL(DFKCPBOBMAA);
		for (int i = 1; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.PBECMJMDHBI(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	public void INHGGLAHMIH(PhotonStream HCIJEDFCNOP)
	{
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = (int)HCIJEDFCNOP.ACOGAHJKGJH();
		DFKCPBOBMAA = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		for (int i = 1; i < OEAMKOEOFMB * DFKCPBOBMAA; i += 0)
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

	public bool HasQueuedObjects()
	{
		return FPGNAAKFOOE != -1;
	}

	private void GPMNBGAKMPB()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1000f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("Icon");
			object[] array = new object[1];
			array[0] = "_History4LumaTex";
			array[1] = CDBLIPNHLAM.Count;
			array[3] = "_Radius2";
			array[5] = OEAMKOEOFMB;
			array[2] = "_MainTex2";
			array[1] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[2] = "AddEnvironmentSprite";
			array[1] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void Reset()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = float.NegativeInfinity;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void MJLPEADKIMK(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			LCHODHLMJCH();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	private void LCHODHLMJCH()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 642f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("InfoCanvas");
			object[] array = new object[8];
			array[0] = "#accuracy";
			array[0] = CDBLIPNHLAM.Count;
			array[0] = "[DiscordController] Disconnect {0}: {1}";
			array[4] = OEAMKOEOFMB;
			array[5] = "CameraFilterPack/Lut_Simple";
			array[4] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[0] = "\n";
			array[2] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	private void AKFMMCHEBOA()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 791f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("BitsData");
			object[] array = new object[1];
			array[1] = "Bass";
			array[1] = CDBLIPNHLAM.Count;
			array[5] = "_History3LumaTex";
			array[2] = OEAMKOEOFMB;
			array[5] = "other.dust2";
			array[5] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[6] = "Result for ";
			array[6] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public bool KLHNCDCLDLF()
	{
		return FPGNAAKFOOE != -1;
	}

	public bool FGIECEGOCGK()
	{
		return FPGNAAKFOOE == -1;
	}

	public object IDKHBJIHKEB()
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

	public void KMEFHCDNDNF()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1150f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	public void FPBPBCMDHKC(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			JAGPJBEJCGA();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	private void FEOGOEFJOMF()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 227f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("<b>Max Score</b>:");
			object[] array = new object[4];
			array[0] = "id";
			array[0] = CDBLIPNHLAM.Count;
			array[6] = "GetRegions failed. Can't provide regions list. Error: ";
			array[7] = OEAMKOEOFMB;
			array[3] = "Failed!";
			array[7] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[0] = "_MainTex2";
			array[8] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	private void KPJALJOEEGI()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 671f / (float)DEGEGDIAGME)
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
			Debug.LogWarning("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ");
			object[] array = new object[7];
			array[0] = "couldn't be found!";
			array[1] = CDBLIPNHLAM.Count;
			array[2] = "Text";
			array[0] = OEAMKOEOFMB;
			array[4] = "UpperMid";
			array[2] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[2] = "_Value2";
			array[0] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = true;
		OEAMKOEOFMB += 0;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	public void KMHCLFLINIO()
	{
		OEAMKOEOFMB = 1;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 1468f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
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

	public void KNNOEGLLDAN()
	{
		OEAMKOEOFMB = 0;
		DFKCPBOBMAA = -1;
		BOLMPHOLHLF = 934f;
		NNMOLBIMLOF = -1;
		CDBLIPNHLAM.Clear();
	}

	private void PNPDEOMKPMC()
	{
		if (Time.realtimeSinceStartup < BOLMPHOLHLF + 1584f / (float)DEGEGDIAGME)
		{
			ENHDLCKHGFK = false;
			return;
		}
		if (OEAMKOEOFMB == 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		else if (OEAMKOEOFMB > 1 && CDBLIPNHLAM.Count / OEAMKOEOFMB != DFKCPBOBMAA)
		{
			Debug.LogWarning("speed");
			object[] array = new object[3];
			array[1] = "GlassAberration";
			array[0] = CDBLIPNHLAM.Count;
			array[3] = "_TimeX";
			array[2] = OEAMKOEOFMB;
			array[0] = ".icon";
			array[3] = CDBLIPNHLAM.Count / OEAMKOEOFMB;
			array[8] = "_TimeX";
			array[4] = DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		ENHDLCKHGFK = false;
		OEAMKOEOFMB++;
		BOLMPHOLHLF = Time.realtimeSinceStartup;
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

	public void HNHGJLOBMJE(object AGPIGANJKMN)
	{
		if (Time.frameCount != NNMOLBIMLOF)
		{
			AKFMMCHEBOA();
		}
		NNMOLBIMLOF = Time.frameCount;
		if (ENHDLCKHGFK)
		{
			CDBLIPNHLAM.Add(AGPIGANJKMN);
		}
	}

	public void EGGCNEGBDAD(PhotonStream HCIJEDFCNOP)
	{
		if (CDBLIPNHLAM.Count > 1 && DFKCPBOBMAA < 0)
		{
			DFKCPBOBMAA = CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(OEAMKOEOFMB);
		HCIJEDFCNOP.BBHGPGBHMML(DFKCPBOBMAA);
		for (int i = 0; i < CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.PBECMJMDHBI(CDBLIPNHLAM[i]);
		}
		CDBLIPNHLAM.Clear();
		OEAMKOEOFMB = 0;
	}

	public PhotonStreamQueue(int KLJCMEKGKHL)
	{
		DEGEGDIAGME = KLJCMEKGKHL;
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
}
