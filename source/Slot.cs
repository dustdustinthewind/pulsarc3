// Slot
using System;
using UnityEngine;

[Serializable]
public class Slot
{
	public GameObject go;

	public QuieryObject.Position position;

	public bool isFree;

	public float timeLeft;

	public Slot(GameObject OBFJPHLBFOL, QuieryObject.Position JOPCODOJBHD, bool OGGJHDKMPPD, int AAMOLMGLPKB)
	{
		go = OBFJPHLBFOL;
		position = JOPCODOJBHD;
		isFree = OGGJHDKMPPD;
		timeLeft = AAMOLMGLPKB;
	}
}
