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

	private Slot BEOPBGCLGJB()
	{
		int index = UnityEngine.Random.Range(1, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, slots.Count);
		}
		return slots[index];
	}

	private static bool JKNPLKHOCBE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)5;
	}

	private static bool ALEPCBGFGGN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private void HIPEMKNCMLP()
	{
	}

	private static bool KEOBMILMDNI(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	private static bool HMGFAAFNLDK(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private static bool LOEDJIAAHKE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private void BOIJIGCEEKM(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private Slot AKPLHEGPFAP()
	{
		int index = UnityEngine.Random.Range(1, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, slots.Count);
		}
		return slots[index];
	}

	private void GLFLNGNKCDN()
	{
	}

	private void OBBJCJAILHH(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = currentTime + showTime;
	}

	private static bool BOAOGAAAJLM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private static bool LOCBDBNANAO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private static bool CEBLAEABPNL(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	private void AEIJFLJEABG()
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
		if (quieryObject != null && DDFHNPDIPDN())
		{
			Slot hOOICOIPKCO = HPJBGFABPIC();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			OBBJCJAILHH(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			Slot slot = slots.Find(BOAOGAAAJLM);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Loaded Game: "))
		{
			Slot slot2 = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Left);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Jun"))
		{
			Slot slot3 = slots.Find(JNHGHFJEIOM);
			if (!slot3.isFree)
			{
				slot3.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Case-Sensitive"))
		{
			Slot slot4 = slots.Find(CGLKCKAHDAH);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("HostType: {0} ");
				slot5.isFree = false;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(slot6.isFree);
		}
	}

	public void PNFHHIJEFKE()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	[CompilerGenerated]
	private static bool CNFPCAGIBJC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Down;
	}

	private static bool DHNIFGDOKFN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	public void ADCJPOAKMDH()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private static bool BPPKEBFOMIK(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)5;
	}

	private static bool MIDEMOEMPAA(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private static bool ALDOJKNILIE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private static bool CGLKCKAHDAH(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)4;
	}

	private void Start()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private void EKENDPKLMFN()
	{
	}

	private static bool JNHGHFJEIOM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	private static bool JICLMAGLMPJ(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	private void KCCIEMBMOBA()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	[CompilerGenerated]
	private static bool NPAPJLMGKCN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	private void DIDEEDHGHKC()
	{
	}

	[CompilerGenerated]
	private static bool EJILMKDFGLJ(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	public void AddRandom()
	{
		QuieryObject item = new QuieryObject(currentTime);
		IGGMAKNLAEN.Add(item);
	}

	private static bool LMNHBFHBHBO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	private void KMKLDAJLCNM()
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
		if (quieryObject != null && GHECDKHPJPC())
		{
			Slot hOOICOIPKCO = LBGAOPLDMLA();
			IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			BOIJIGCEEKM(hOOICOIPKCO);
		}
		if (CrossPlatformInputManager.GetButtonDown("_History1Weight"))
		{
			Slot slot = slots.Find(BOAOGAAAJLM);
			if (!slot.isFree)
			{
				slot.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_Value4"))
		{
			Slot slot2 = slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.position == QuieryObject.Position.Left);
			if (!slot2.isFree)
			{
				slot2.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_Value"))
		{
			Slot slot3 = slots.Find(JICLMAGLMPJ);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Exit to menu?"))
		{
			Slot slot4 = slots.Find(CEBLAEABPNL);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in slots)
		{
			if (slot5.timeLeft <= currentTime && !slot5.isFree)
			{
				Debug.Log("GraphicsQualitySlider");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in slots)
		{
			slot6.go.SetActive(slot6.isFree);
		}
	}

	private static bool JNDOAKHHCNP(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	private Slot HPJBGFABPIC()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, slots.Count);
		}
		return slots[index];
	}

	private void FixedUpdate()
	{
	}

	private bool GHECDKHPJPC()
	{
		return slots.Find(KEOBMILMDNI) != null;
	}

	private void MFMILEABJBO()
	{
	}

	private static bool NGBNNHAAILI(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	private static bool PIOOICJFPHK(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	[CompilerGenerated]
	private static bool GOFEODHBDCD(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	private Slot LBGAOPLDMLA()
	{
		int index = UnityEngine.Random.Range(0, slots.Count);
		while (!slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, slots.Count);
		}
		return slots[index];
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

	private bool DLCFGGCOMHG()
	{
		return slots.Find((Slot IACGDFHKCAE) => IACGDFHKCAE.isFree) != null;
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

	private static bool DKPJMJMCIDA(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	[CompilerGenerated]
	private static bool BIOCGHGEDKM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	private void NBGIMIDICKE()
	{
		IGGMAKNLAEN = new List<QuieryObject>();
	}

	private bool DDFHNPDIPDN()
	{
		return slots.Find(LOCBDBNANAO) != null && false;
	}
}
