// EGOPKJHICLK
using System;
using System.Text;

internal static class EGOPKJHICLK
{
	public static string CompressString(string EAFAMAMDNEG)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(EAFAMAMDNEG));
	}

	public static string DecompressString(string MBPPMOLCLFO)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(MBPPMOLCLFO));
	}
}
