// CFGKBDICDIH
using System;
using System.Collections.Generic;

internal static class CFGKBDICDIH
{
	internal static Type LEMHLODODPL(Type ANFOJNABFFJ)
	{
		Type type = BNNBDLGMAIE(ANFOJNABFFJ);
		if (type == null)
		{
			return ANFOJNABFFJ;
		}
		return type.GetGenericArguments()[0];
	}

	private static Type BNNBDLGMAIE(Type ANFOJNABFFJ)
	{
		if (ANFOJNABFFJ == null || ANFOJNABFFJ == typeof(string))
		{
			return null;
		}
		if (ANFOJNABFFJ.IsArray)
		{
			return typeof(IEnumerable<>).MakeGenericType(ANFOJNABFFJ.GetElementType());
		}
		if (ANFOJNABFFJ.IsGenericType)
		{
			Type[] genericArguments = ANFOJNABFFJ.GetGenericArguments();
			foreach (Type type in genericArguments)
			{
				Type type2 = typeof(IEnumerable<>).MakeGenericType(type);
				if (type2.IsAssignableFrom(ANFOJNABFFJ))
				{
					return type2;
				}
			}
		}
		Type[] interfaces = ANFOJNABFFJ.GetInterfaces();
		if (interfaces != null && interfaces.Length > 0)
		{
			Type[] array = interfaces;
			foreach (Type aNFOJNABFFJ in array)
			{
				Type type3 = BNNBDLGMAIE(aNFOJNABFFJ);
				if (type3 != null)
				{
					return type3;
				}
			}
		}
		if (ANFOJNABFFJ.BaseType != null && ANFOJNABFFJ.BaseType != typeof(object))
		{
			return BNNBDLGMAIE(ANFOJNABFFJ.BaseType);
		}
		return null;
	}

	public static bool IsEnumerableType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("IEnumerable") != null;
	}

	public static bool IsCollectionType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("ICollection") != null;
	}
}
