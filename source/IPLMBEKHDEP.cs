// IPLMBEKHDEP
using UnityEngine;

internal static class IPLMBEKHDEP
{
	public static bool SetColor(ref Color NGKKLGPFEBB, Color IHIAMPBEFEE)
	{
		if (NGKKLGPFEBB.r == IHIAMPBEFEE.r && NGKKLGPFEBB.g == IHIAMPBEFEE.g && NGKKLGPFEBB.b == IHIAMPBEFEE.b && NGKKLGPFEBB.a == IHIAMPBEFEE.a)
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}

	public static bool SetStruct<T>(ref T NGKKLGPFEBB, T IHIAMPBEFEE) where T : struct
	{
		if (NGKKLGPFEBB.Equals(IHIAMPBEFEE))
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}

	public static bool SetClass<T>(ref T NGKKLGPFEBB, T IHIAMPBEFEE) where T : class
	{
		if ((NGKKLGPFEBB == null && IHIAMPBEFEE == null) || (NGKKLGPFEBB != null && NGKKLGPFEBB.Equals(IHIAMPBEFEE)))
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}
}
