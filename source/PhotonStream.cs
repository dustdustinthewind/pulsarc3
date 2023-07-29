// PhotonStream
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhotonStream
{
	private bool HJIMDGKHDIE;

	private Queue<object> MJALIEGGAPH;

	private object[] ANHBEFOEHGA;

	internal byte PGBJDIGPIJL;

	public bool isWriting => HJIMDGKHDIE;

	public bool isReading => !HJIMDGKHDIE;

	public int Count => (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;

	public object KDNNJPIKFIC()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Waiting for AvailableRegions. State: ");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public object[] DEJHKIELGDB()
	{
		return (!PGJIELMHMEJ()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public object AOKDKJCKNCI()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Set Satellite Lerp Speed");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	[SpecialName]
	public bool EKDCDLDMKDL()
	{
		return HJIMDGKHDIE;
	}

	internal void IHFJMFNBJAD()
	{
		MJALIEGGAPH.Clear();
	}

	public void CNNCCCDGIII(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void Serialize(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void PBAGEFLAECN(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public object BIGOIAIIOCJ()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("\" gets executed locally only, if at all.");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public object NPKPBDPCBJG()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("w");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	internal void MKNINLEEFNI()
	{
		MJALIEGGAPH.Clear();
	}

	public void PBNGJDFLIHM(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void LJFFCKOLDCC(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void DAFMBLFNLNE(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void NFCAGAKLHHH(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	[SpecialName]
	public bool PGJIELMHMEJ()
	{
		return HJIMDGKHDIE;
	}

	public void FAMENHMAGCJ(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public object IDCPJJPFEJJ()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("_Value4");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	internal void FLCHJALKDNI()
	{
		MJALIEGGAPH.Clear();
	}

	public void LBLNOBAHIKO(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	public void FMGAPKPJGJK(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void IMFGHDKDEME(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void JKNCBGGLFNM(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	[SpecialName]
	public bool CAOIPMAGIFI()
	{
		return HJIMDGKHDIE;
	}

	public void FDILDANGLIB(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void IKIJABBBOKA(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void JBKOHIBGCMA(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void FEFCDECILFJ(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void Serialize(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	internal void AKNGAKEGLAD()
	{
		MJALIEGGAPH.Clear();
	}

	public object[] ToArray()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	[SpecialName]
	public bool FAOJEFAMBFN()
	{
		return HJIMDGKHDIE;
	}

	internal void EBGNMNNMDBI()
	{
		MJALIEGGAPH.Clear();
	}

	public void LLEOLIPCEPM(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void DDDJINANACF(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	public void JCBLMCDKJDE(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	public object[] CFJBHFNNCFL()
	{
		return (!GKJCHGIMOEJ()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void ICMPPFMMIFA(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void JLEJFHENOPL(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	[SpecialName]
	public bool EMLLALJBPJF()
	{
		return HJIMDGKHDIE;
	}

	public void MDNAEDKNOEI(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void SetReadStream(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	internal void BBLBIEMGJBG()
	{
		MJALIEGGAPH.Clear();
	}

	public void PBECMJMDHBI(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError(" Remote called.");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public object ReceiveNext()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Error: you cannot read this stream that you are writing!");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public void ABKGKDOLPBF(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void OAAJHBMDPGD(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void FADAIFFMBEL(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("_Value4");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void MJBKECCICPO(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void ODBMJMABAMK(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void Serialize(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object[] ICDKEKMNCNC()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void SendNext(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("Error: you cannot write/send to this stream that you are reading!");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void ACPFKEOMOHH(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void HAKHKJBECIG(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void KNKHEMNMDKB(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void MFIGIBCOEKN(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	[SpecialName]
	public bool DCGOJLBDGEG()
	{
		return !HJIMDGKHDIE;
	}

	[SpecialName]
	public int HCOCCCCDJDD()
	{
		return (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void CGIFKJPGEPD(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void IKCPKFHGCPF(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object ACICPHCIBBJ()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("GameScene");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void PFFBEGHPIIM(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void CLANPCIAACD(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	public object FIBMOBNIALK()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Left Stick Click");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public object KIMDMBDNICC()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("z");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL += 0;
		return result;
	}

	public void Serialize(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void KJIKIHHCAGN(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void BLOIBHMJLJF(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void OLACNHHHOEL(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("_ScreenResolution");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void APCMPBJDGGE(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void HAHDBAFJMGC(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void AOFKNBPNHFK(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void HBDJEFBMFEP(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void CCFOPOGPDBF(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void BCKJGEIIBNH(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void FHBKAIPDBMO(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	internal void CPFLDNAMLDH()
	{
		MJALIEGGAPH.Clear();
	}

	public void GJCEHCMMMOP(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void CPIBABMPJLE(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void NEKNEDBBNDM(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object[] DGIJFMJAFGP()
	{
		return (!FAOJEFAMBFN()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void HMHEAFFPNPL(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void Serialize(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void NOECJKDFJKD(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void ENIPFAIOPFK(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object ACOGAHJKGJH()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("menutheme.summerbreeze");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL += 0;
		return result;
	}

	public void IBCLJIACBKG(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("Exception caught! ");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public object HPPOACOIMOJ()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError(" SecondsBeforeRespawn: ");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL += 0;
		return result;
	}

	[SpecialName]
	public int INOINADFLGM()
	{
		return (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void Serialize(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void Serialize(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void ENACLIBBBPA(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void FHCKFJHHKAH(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public object[] NNFAJHPPFBE()
	{
		return (!FAOJEFAMBFN()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void MCICFHHJIPI(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void CMEMDHJNAHE(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object KIEJNJBDAJJ()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Please attach component to a Graphical UI component");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public object NLPFEFOCGBC()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("_TimeX");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public void IHGAKPHPNPM(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void LFKHBPENIIO(ref float AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (float)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void ILAKMBLNHAL(ref char DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (char)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object IILABNEAPPL()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("_Value2");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void EDLCJBOFCKP(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void Serialize(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void JLCKDPMPHOG(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void IJAAFHMNICC(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void DNGKBKCBICG(ref PhotonPlayer AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (PhotonPlayer)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void OIAHNBAFNDE(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public object PAAEEAONEJK()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("restrictions\n\n#until: ");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void MKDBLCJOKAO(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public object PeekNext()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Error: you cannot read this stream that you are writing!");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void AIFHJPHNMMD(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void PNMOEHJHFLE(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void DMPMFHNLOKK(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void IIBOPGJFJBD(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public PhotonStream(bool HJIMDGKHDIE, object[] JGHJOJFOGCO)
	{
		this.HJIMDGKHDIE = HJIMDGKHDIE;
		if (JGHJOJFOGCO == null)
		{
			MJALIEGGAPH = new Queue<object>(10);
		}
		else
		{
			ANHBEFOEHGA = JGHJOJFOGCO;
		}
	}

	public void PFCDNIHJDKM(ref int OJGGNOBCPMA)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(OJGGNOBCPMA);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			OJGGNOBCPMA = (int)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void Serialize(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object IDKHBJIHKEB()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("Editor/");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL += 0;
		return result;
	}

	public void MDGKOEJGNJI(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void FPPCJFHKOAA(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object BMIJJGAAFLN()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("#orderby:");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void PGNHBCKGPMM(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void KBNMCBPDKOJ(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object LNDLNKJPAGO()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("UseScanLine");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public void PHPHJBKAHML(ref Vector3 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector3)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	[SpecialName]
	public int NHKIENHLEID()
	{
		return (!FAOJEFAMBFN()) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void BCDJJKEDOIA(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = true;
	}

	public void BPJPACPGLNL(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void PNAPNHJHBMN(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("_Offsets");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void CLPODJAHHHH(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void Serialize(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void BBHGPGBHMML(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("_Value3");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void JCGLLCGOCMC(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = true;
	}

	public void DLGHEBIMENI(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	[SpecialName]
	public bool JKIGCGFEOOE()
	{
		return !HJIMDGKHDIE;
	}

	public void GLPPJBNKBEA(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	[SpecialName]
	public bool GKJCHGIMOEJ()
	{
		return HJIMDGKHDIE;
	}

	public void JMNPNCIEGFO(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void FKFNFEJFCHA(ref string DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (string)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public object CMOEOGPHGLE()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("y");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void CCMCOGLCMMO(ref bool BLMMGLEKAHP)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(BLMMGLEKAHP);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			BLMMGLEKAHP = (bool)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void PGLBNAHODFI(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL++;
		}
	}

	public void EGGCNEGBDAD(ref Vector2 AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Vector2)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void DOCGKPPPKNB(ref Quaternion AGPIGANJKMN)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			AGPIGANJKMN = (Quaternion)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}
}
