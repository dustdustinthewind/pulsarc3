// FILE
using System;
using System.IO;
using System.Text;
using UnityEngine;

public static class FILE
{
	public static string ReadText(string HAEBGHHMEBH)
	{
		if (File.Exists(HAEBGHHMEBH))
		{
			StreamReader streamReader = null;
			try
			{
				using (streamReader = new StreamReader(HAEBGHHMEBH, Encoding.UTF8))
				{
					return streamReader.ReadToEnd();
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return null;
			}
			finally
			{
				streamReader?.Close();
			}
		}
		throw new IOException($"File not found: {HAEBGHHMEBH}");
	}

	public static Texture2D ReadTexture(string HAEBGHHMEBH)
	{
		if (File.Exists(HAEBGHHMEBH))
		{
			try
			{
				Texture2D texture2D = new Texture2D(0, 0);
				byte[] data = File.ReadAllBytes(HAEBGHHMEBH);
				if (!texture2D.LoadImage(data))
				{
					Debug.LogError($"Reading preview file failed!: \"{HAEBGHHMEBH}\"");
				}
				return texture2D;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return null;
			}
		}
		Debug.LogError($"Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{HAEBGHHMEBH}\"");
		return null;
	}

	public static bool WriteText(string HAEBGHHMEBH, string EAFAMAMDNEG)
	{
		StreamWriter streamWriter = null;
		try
		{
			if (File.Exists(HAEBGHHMEBH))
			{
				using (streamWriter = File.CreateText(HAEBGHHMEBH))
				{
					streamWriter.Write(EAFAMAMDNEG);
				}
				return true;
			}
			using (streamWriter = File.CreateText(HAEBGHHMEBH))
			{
				streamWriter.Write(EAFAMAMDNEG);
			}
			return true;
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			return false;
		}
		finally
		{
			streamWriter?.Close();
		}
	}
}
