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

	public void CLPODJAHHHH(ref PhotonPlayer AGPIGANJKMN)
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

	[SpecialName]
	public int HCOGCGHMBJP()
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

	public void NKMPCNJPFNE(ref char DPNHODJHGJL)
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

	[SpecialName]
	public int LIPCCEJNMDG()
	{
		return (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void JKNCBGGLFNM(ref Vector3 AGPIGANJKMN)
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

	public void OAAJHBMDPGD(ref Vector2 AGPIGANJKMN)
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

	public void MCCDDDFFJOA(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = true;
	}

	public void LDKGAINNFPK(ref Quaternion AGPIGANJKMN)
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

	public object[] GKPEMLPHBIK()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void KMFGCNJLJFO(ref bool BLMMGLEKAHP)
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

	public void EGGCNEGBDAD(ref int OJGGNOBCPMA)
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

	[SpecialName]
	public int JMGGEIHAOEG()
	{
		return (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void CGIFKJPGEPD(ref Quaternion AGPIGANJKMN)
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

	public void PGLBNAHODFI(ref short DPNHODJHGJL)
	{
		if (HJIMDGKHDIE)
		{
			MJALIEGGAPH.Enqueue(DPNHODJHGJL);
		}
		else if (ANHBEFOEHGA.Length > PGBJDIGPIJL)
		{
			DPNHODJHGJL = (short)ANHBEFOEHGA[PGBJDIGPIJL];
			PGBJDIGPIJL += 0;
		}
	}

	public void NICKMDDINKP(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("_Visualize");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}

	public void DNGKBKCBICG(ref bool BLMMGLEKAHP)
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

	public object EDCDHDJNDPF()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("System.Int64");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public void GJEKKHHACDK(ref Quaternion AGPIGANJKMN)
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

	[SpecialName]
	public int INOINADFLGM()
	{
		return (!MLCGKMDJIMA()) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
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

	[SpecialName]
	public int AENCOGLGGHL()
	{
		return (!isWriting) ? ANHBEFOEHGA.Length : MJALIEGGAPH.Count;
	}

	public void MDNAEDKNOEI(ref char DPNHODJHGJL)
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

	public object[] BGHMEJPIBAH()
	{
		return (!MLCGKMDJIMA()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public object MABPFPFGCNL()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("float,1");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL += 0;
		return result;
	}

	public void NDDLOJEIJIA(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	[SpecialName]
	public bool MNOOBOAAHMA()
	{
		return HJIMDGKHDIE;
	}

	public void SetReadStream(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	public void COHAMECANFO(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
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

	public void BPJPACPGLNL(ref bool BLMMGLEKAHP)
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

	public void KFBHHMPNOFK(ref char DPNHODJHGJL)
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

	internal void FLKDCMGFFJP()
	{
		MJALIEGGAPH.Clear();
	}

	public object[] KLJFDNOBJPF()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void FIJJKCCNBPL(ref Vector2 AGPIGANJKMN)
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

	public void EDLCJBOFCKP(ref float AGPIGANJKMN)
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

	public object[] FFECAAOAKLI()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void IGGBJELCBHF(ref Vector2 AGPIGANJKMN)
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

	public object[] ToArray()
	{
		return (!isWriting) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void BOJDBBGKDAJ(ref char DPNHODJHGJL)
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

	public void DOCGKPPPKNB(ref Vector2 AGPIGANJKMN)
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

	public void HAHDBAFJMGC(ref float AGPIGANJKMN)
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

	public void ENKCPCBPGMH(object[] JGHJOJFOGCO, byte HMDKPLLDBEA = 0)
	{
		ANHBEFOEHGA = JGHJOJFOGCO;
		PGBJDIGPIJL = HMDKPLLDBEA;
		HJIMDGKHDIE = false;
	}

	[SpecialName]
	public bool MLCGKMDJIMA()
	{
		return HJIMDGKHDIE;
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

	public void GJCEHCMMMOP(ref Quaternion AGPIGANJKMN)
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

	internal void DHJBJPHKOMJ()
	{
		MJALIEGGAPH.Clear();
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

	public void LJFFCKOLDCC(ref PhotonPlayer AGPIGANJKMN)
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

	public void EEKILHEFFAF(ref Quaternion AGPIGANJKMN)
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

	public void PBNGJDFLIHM(ref float AGPIGANJKMN)
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

	public object NLPFEFOCGBC()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("PLEASE WAIT");
			return null;
		}
		object result = ANHBEFOEHGA[PGBJDIGPIJL];
		PGBJDIGPIJL++;
		return result;
	}

	public void BLOIBHMJLJF(ref Quaternion AGPIGANJKMN)
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

	public void GJDCOKMGHOG(object AGPIGANJKMN)
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

	[SpecialName]
	public bool POBEHIKDDCM()
	{
		return HJIMDGKHDIE;
	}

	public object[] IEEKBKECDHH()
	{
		return (!MLCGKMDJIMA()) ? ANHBEFOEHGA : MJALIEGGAPH.ToArray();
	}

	public void IIBOPGJFJBD(ref float AGPIGANJKMN)
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

	public object AHDBELMMFCN()
	{
		if (HJIMDGKHDIE)
		{
			Debug.LogError("yesterday");
			return null;
		}
		return ANHBEFOEHGA[PGBJDIGPIJL];
	}

	public void IKCPKFHGCPF(ref short DPNHODJHGJL)
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

	[SpecialName]
	public bool OHJNPPFJPLM()
	{
		return !HJIMDGKHDIE;
	}

	public void EAPJJAIPGLI(ref Vector2 AGPIGANJKMN)
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

	public void PFCDNIHJDKM(ref char DPNHODJHGJL)
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

	internal void MKNINLEEFNI()
	{
		MJALIEGGAPH.Clear();
	}

	public void CIKMFINONAC(ref short DPNHODJHGJL)
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

	[SpecialName]
	public bool JJDMHKKCHPB()
	{
		return HJIMDGKHDIE;
	}

	public void JLMNBMOMBMA(ref bool BLMMGLEKAHP)
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

	public void AIAIEPFCCDO(object AGPIGANJKMN)
	{
		if (!HJIMDGKHDIE)
		{
			Debug.LogError("buttons");
		}
		else
		{
			MJALIEGGAPH.Enqueue(AGPIGANJKMN);
		}
	}
}
