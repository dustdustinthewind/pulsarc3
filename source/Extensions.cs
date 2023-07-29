// Extensions
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

public static class Extensions
{
	public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods = new Dictionary<MethodInfo, ParameterInfo[]>();

	public static ParameterInfo[] GetCachedParemeters(this MethodInfo HCGPGHJPJAM)
	{
		ParameterInfo[] value;
		if (!ParametersOfMethods.TryGetValue(HCGPGHJPJAM, out value))
		{
			value = HCGPGHJPJAM.GetParameters();
			ParametersOfMethods[HCGPGHJPJAM] = value;
		}
		return value;
	}

	public static PhotonView[] GetPhotonViewsInChildren(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
	}

	public static PhotonView GetPhotonView(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponent<PhotonView>();
	}

	public static bool AlmostEquals(this Vector3 MPNMOONBMII, Vector3 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	public static bool AlmostEquals(this Vector2 MPNMOONBMII, Vector2 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	public static bool AlmostEquals(this Quaternion MPNMOONBMII, Quaternion BICCGCFNNLP, float MNAOJGNELDM)
	{
		return Quaternion.Angle(MPNMOONBMII, BICCGCFNNLP) < MNAOJGNELDM;
	}

	public static bool AlmostEquals(this float MPNMOONBMII, float BICCGCFNNLP, float OGODMIJJENE)
	{
		return Mathf.Abs(MPNMOONBMII - BICCGCFNNLP) < OGODMIJJENE;
	}

	public static void Merge(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				MPNMOONBMII[current] = PFLIKPMIGLK[current];
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static void MergeStringKeys(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (current is string)
				{
					MPNMOONBMII[current] = PFLIKPMIGLK[current];
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static string ToStringFull(this IDictionary GEMDHBEGEFH)
	{
		return SupportClass.DictionaryToString(GEMDHBEGEFH, false);
	}

	public static string ToStringFull(this object[] NOJGGCLPPAM)
	{
		if (NOJGGCLPPAM == null)
		{
			return "null";
		}
		string[] array = new string[NOJGGCLPPAM.Length];
		for (int i = 0; i < NOJGGCLPPAM.Length; i++)
		{
			object obj = NOJGGCLPPAM[i];
			array[i] = ((obj == null) ? "null" : obj.ToString());
		}
		return string.Join(", ", array);
	}

	public static ExitGames.Client.Photon.Hashtable StripToStringKeys(this IDictionary LMHCHLAIMJH)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (LMHCHLAIMJH != null)
		{
			IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					if (current is string)
					{
						hashtable[current] = LMHCHLAIMJH[current];
					}
				}
				return hashtable;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}
		return hashtable;
	}

	public static void StripKeysWithNullValues(this IDictionary LMHCHLAIMJH)
	{
		object[] array = new object[LMHCHLAIMJH.Count];
		int num = 0;
		IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				array[num++] = current;
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (object key in array)
		{
			if (LMHCHLAIMJH[key] == null)
			{
				LMHCHLAIMJH.Remove(key);
			}
		}
	}

	public static bool Contains(this int[] MPNMOONBMII, int FGBCKIIKMNC)
	{
		if (MPNMOONBMII == null)
		{
			return false;
		}
		for (int i = 0; i < MPNMOONBMII.Length; i++)
		{
			if (MPNMOONBMII[i] == FGBCKIIKMNC)
			{
				return true;
			}
		}
		return false;
	}
}
