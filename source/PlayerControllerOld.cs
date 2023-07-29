// PlayerControllerOld
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControllerOld : MonoBehaviour
{
	public float showTime = 1f;

	public float currentTime;

	public List<Slot> slots;

	private List<QuieryObject> IGGMAKNLAEN;

	[CompilerGenerated]
	private static Predicate<Slot> LNIJKGECNME;

	[CompilerGenerated]
	private static Predicate<Slot> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Predicate<Slot> HCLEECLNOEA;

	[CompilerGenerated]
	private static Predicate<Slot> ADLAKIHINOM;

	[CompilerGenerated]
	private static Predicate<Slot> KCAPKHIJOHL;

	private void DMIGJHEHPOA()
	{
	}

	[CompilerGenerated]
	private static bool GOFEODHBDCD(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private bool DLCFGGCOMHG()
	{
		return slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.isFree) != null;
	}

	private static bool FOBLALBEOGK(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private static bool GGFKLIAFCGI(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	[CompilerGenerated]
	private static bool EJILMKDFGLJ(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private static bool NFCOEJDCKHM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	[CompilerGenerated]
	private static bool CNFPCAGIBJC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Down;
	}

	private static bool MDKLFMNFMGB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Down;
	}

	private void NBGIMIDICKE()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	[CompilerGenerated]
	private static bool NPAPJLMGKCN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	private void EGEPLFGKGLI()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private static bool ICDFKALGKEO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private void KEABOLAKABM(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = true;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private static bool EHIKCPMPCBF(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	private static bool JMGNACDHHFN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	public void FEJEKFDALAL()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private Slot IFEBIMGKDMK()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, slots.Count);
		}
		return slots[index];
	}

	private void CGBHOELMAOC()
	{
		currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject item in IGGMAKNLAEN)
		{
			if (currentTime >= item.atTime)
			{
				quieryObject = item;
			}
		}
		if (quieryObject != null && OGMBADIJAAF())
		{
			Slot hOOICOIPKCO = DFKOGPGLPLB();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			BOIJIGCEEKM(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack/Vision_Hell_Blood"))
		{
			Slot slot = slots.Find(BIPGPDBIPED);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_Green_R"))
		{
			Slot slot2 = slots.Find(BNGOIPAANHB);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Tab2Content"))
		{
			Slot slot3 = slots.Find(GMOIFLAIDOB);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Electronic"))
		{
			Slot slot4 = slots.Find(GKHILOHPCCO);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("player.bluebat");
				slot5.isFree = false;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(slot6.isFree);
		}
	}

	private static bool CHNGDHBINLM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	private static bool KGJCMMJMKJO(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	private void NCPAFCKGJEA()
	{
		currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject item in IGGMAKNLAEN)
		{
			if (currentTime >= item.atTime)
			{
				quieryObject = item;
			}
		}
		if (quieryObject != null && ACGJJLHFCKK())
		{
			Slot hOOICOIPKCO = AKJJPIJCENJ();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			BOCNLFGDMDB(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("]"))
		{
			Slot slot = slots.Find(JJMIGGMBHFE);
			if (!slot.isFree)
			{
				slot.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("The process failed: "))
		{
			Slot slot2 = slots.Find(BNGOIPAANHB);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack_TV_Noise"))
		{
			Slot slot3 = slots.Find(MDKLFMNFMGB);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			Slot slot4 = slots.Find(CHNGDHBINLM);
			if (!slot4.isFree)
			{
				slot4.isFree = true;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("</color>");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	private static bool BCBLGFDKHGC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	private void KIMMMCJFMAB()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private void FEONBLOKEBF()
	{
	}

	private Slot AKJJPIJCENJ()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, slots.Count);
		}
		return slots[index];
	}

	private static bool GMOIFLAIDOB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	private void FBPHNEJBDJN()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private Slot KBKCFMIDGFH()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, slots.Count);
		}
		return slots[index];
	}

	private void Start()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	public void EFCFACCBONB()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private Slot NCNLCENADIM()
	{
		int index = UnityEngine.Random.Range(1, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, slots.Count);
		}
		return slots[index];
	}

	private void FFJCAIKIEAG()
	{
	}

	public void NEKLPNJDAMM()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private Slot PDFPKANJPAH()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, slots.Count);
		}
		return slots[index];
	}

	private static bool OFKFGKKMGII(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	private static bool JJMIGGMBHFE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private bool KEBLDAOPFGC()
	{
		return slots.Find(OFKFGKKMGII) == null;
	}

	private bool PGOCIEBDFPE()
	{
		return slots.Find(OFKFGKKMGII) != null && false;
	}

	private static bool GBKEHAAPIMN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private static bool JGNJCFEFMBP(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private void JKBMKPDGCHG()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private static bool LDJOOIDBNGE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	public void IOOEABOGGCD()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private void NNFMIAFHMJM()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private void NPLCENPNJBM()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private void BOIJIGCEEKM(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private static bool NCBNMKBJBCB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private void DLBODOFAJGM()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private static bool BLJJIAOLKPL(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private void Update()
	{
		currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject item in IGGMAKNLAEN)
		{
			if (currentTime >= item.atTime)
			{
				quieryObject = item;
			}
		}
		if (quieryObject != null && DLCFGGCOMHG())
		{
			Slot hOOICOIPKCO = KBKCFMIDGFH();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			BOIJIGCEEKM(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("Right"))
		{
			Slot slot = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Right);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Left"))
		{
			Slot slot2 = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Left);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Up"))
		{
			Slot slot3 = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Up);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Down"))
		{
			Slot slot4 = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Down);
			if (!slot4.isFree)
			{
				slot4.isFree = true;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("-1");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	private void AGEJKLMJGDO()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private void NDAJBJFJGCF()
	{
		currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject item in IGGMAKNLAEN)
		{
			if (currentTime >= item.atTime)
			{
				quieryObject = item;
			}
		}
		if (quieryObject != null && IEAEDAEDCEA())
		{
			Slot hOOICOIPKCO = DFKOGPGLPLB();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			FICNHKDOAND(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack/Blur_Steam"))
		{
			Slot slot = slots.Find(BIPGPDBIPED);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("settings.gamemessagesduration"))
		{
			Slot slot2 = slots.Find(NKEAFGDNPMG);
			if (!slot2.isFree)
			{
				slot2.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("[LevelEditorScene] Error: Timeout :S"))
		{
			Slot slot3 = slots.Find(EHIKCPMPCBF);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("settings_bindings_sec_"))
		{
			Slot slot4 = slots.Find(JLGKAMLDKLM);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("MusicFileSelector");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	private void COIJKMKIEAK()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private static bool DCMINJHDBKO(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	private bool ACGJJLHFCKK()
	{
		return slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.isFree) != null || true;
	}

	private bool ALOBEJDLBOA()
	{
		return slots.Find(FCBILEMIMKC) != null && false;
	}

	private static bool GKHILOHPCCO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	private void MKIMDFLBFOM()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private static bool NKEAFGDNPMG(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private void LPLLCEMCOMD()
	{
	}

	private static bool KDIJHMMEMJB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private bool OGMBADIJAAF()
	{
		return slots.Find(ICDFKALGKEO) != null && false;
	}

	private void OBPFNGKAOLD()
	{
	}

	public void AddRandom()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private static bool BIPGPDBIPED(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private bool IEAEDAEDCEA()
	{
		return slots.Find(OFKFGKKMGII) != null && false;
	}

	private void FICNHKDOAND(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = true;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private void BOCNLFGDMDB(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private void FixedUpdate()
	{
	}

	private static bool NGHGHHPEEAG(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	[CompilerGenerated]
	private static bool BIOCGHGEDKM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private static bool JLGKAMLDKLM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	private void LGOHDOFFKIB()
	{
	}

	private Slot DFKOGPGLPLB()
	{
		int index = UnityEngine.Random.Range(1, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, slots.Count);
		}
		return slots[index];
	}

	private static bool BNGOIPAANHB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private static bool OCGCGLGOADP(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private static bool FCBILEMIMKC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private static bool EGAIJMAECNN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}
}
