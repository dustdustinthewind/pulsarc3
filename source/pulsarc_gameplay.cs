using System;
using UnityEngine;
using System.Collections.Generic;

// Token: 0x02000525 RID: 1317
using UnityEngine;

public class pulsarc_gameplay : ScriptableObject
{
	public List<MapEvent> hit_objects;

	public pulsarc_gameplay()
	{
		hit_objects = new List<MapEvent>();
	}
}