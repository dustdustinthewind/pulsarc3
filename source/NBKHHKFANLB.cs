// NBKHHKFANLB
using System;
using System.Collections.Generic;

internal static class NBKHHKFANLB
{
	public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB)
	{
		return HLBKCLPNHEB.MaxBy(PGBBGIOBPGB, null);
	}

	public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB, IComparer<TKey> CDNIFCBKPMN)
	{
		if (HLBKCLPNHEB == null)
		{
			throw new ArgumentNullException("source");
		}
		if (PGBBGIOBPGB == null)
		{
			throw new ArgumentNullException("selector");
		}
		CDNIFCBKPMN = CDNIFCBKPMN ?? Comparer<TKey>.Default;
		using (IEnumerator<TSource> enumerator = HLBKCLPNHEB.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			TSource val = enumerator.Current;
			TKey y = PGBBGIOBPGB(val);
			while (enumerator.MoveNext())
			{
				TSource current = enumerator.Current;
				TKey val2 = PGBBGIOBPGB(current);
				if (CDNIFCBKPMN.Compare(val2, y) > 0)
				{
					val = current;
					y = val2;
				}
			}
			return val;
		}
	}

	public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB)
	{
		return HLBKCLPNHEB.MinBy(PGBBGIOBPGB, null);
	}

	public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB, IComparer<TKey> CDNIFCBKPMN)
	{
		if (HLBKCLPNHEB == null)
		{
			throw new ArgumentNullException("source");
		}
		if (PGBBGIOBPGB == null)
		{
			throw new ArgumentNullException("selector");
		}
		CDNIFCBKPMN = CDNIFCBKPMN ?? Comparer<TKey>.Default;
		using (IEnumerator<TSource> enumerator = HLBKCLPNHEB.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			TSource val = enumerator.Current;
			TKey y = PGBBGIOBPGB(val);
			while (enumerator.MoveNext())
			{
				TSource current = enumerator.Current;
				TKey val2 = PGBBGIOBPGB(current);
				if (CDNIFCBKPMN.Compare(val2, y) < 0)
				{
					val = current;
					y = val2;
				}
			}
			return val;
		}
	}
}
