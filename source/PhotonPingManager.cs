// PhotonPingManager
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class PhotonPingManager
{
	public bool UseNative;

	public static int Attempts = 5;

	public static bool IgnoreInitialAttempt = true;

	public static int MaxMilliseconsPerPing = 800;

	private const string FGFMFHNMJOA = "wss://";

	private int LAONIGHJPPD;

	public Region BestRegion
	{
		get
		{
			Region result = null;
			int num = int.MaxValue;
			foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
			{
				UnityEngine.Debug.Log("BestRegion checks region: " + availableRegion);
				if (availableRegion.Ping != 0 && availableRegion.Ping < num)
				{
					num = availableRegion.Ping;
					result = availableRegion;
				}
			}
			return result;
		}
	}

	public bool Done => LAONIGHJPPD == 0;

	[SpecialName]
	public Region CPIJHGIHFIA()
	{
		Region result = null;
		int num = -127;
		foreach (Region item in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("CameraFilterPack/Drawing_Crosshatch" + item);
			if (item.Ping != 0 && item.Ping < num)
			{
				num = item.Ping;
				result = item;
			}
		}
		return result;
	}

	public IEnumerator NBFPMBGKCMI(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator FHHDJCPNGIN(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator JFDEKPDPCHA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public bool IIHOBCPFMKL()
	{
		return LAONIGHJPPD == 0;
	}

	public static string EAICGEHOBJG(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("ERROR: Make sure your mod contains at leats one file!"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("ResetSpeed" + ex.Source + "_Value2" + ex.Message);
			return text;
		}
	}

	public IEnumerator AAGHAIHLDIO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator AAHGEGBEAHG(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public Region JLPHEDADGMD()
	{
		Region result = null;
		int num = -139;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("open" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public Region DDFFPPECOAA()
	{
		Region result = null;
		int num = 59;
		foreach (Region item in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("_Saturation" + item);
			if (item.Ping != 0 && item.Ping < num)
			{
				num = item.Ping;
				result = item;
			}
		}
		return result;
	}

	public IEnumerator EPELHCLFNEK(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public bool PMKLFOJMBKA()
	{
		return LAONIGHJPPD == 1;
	}

	public IEnumerator MCEMKLGEEBO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public bool BDBENNCJCGE()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool DMBEPHNHMHB()
	{
		return LAONIGHJPPD == 1;
	}

	public static string CPJNNIFJPMC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("0,1,false"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("_Val3" + ex.Source + "_Value2" + ex.Message);
			return text;
		}
	}

	public IEnumerator FGAEIKABKNO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public Region NFBJHHENDCG()
	{
		Region result = null;
		int num = 178;
		foreach (Region item in PhotonNetwork.JNJJAMNLOHA.ILANOBPPIBF())
		{
			UnityEngine.Debug.Log("GlassesColor2" + item);
			if (item.Ping != 0 && item.Ping < num)
			{
				num = item.Ping;
				result = item;
			}
		}
		return result;
	}

	public static string FFKNLHJKFIM(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("Offline or in OfflineMode. No VitalStats available."))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("CameraFilterPack_AAA_BloodOnScreen1" + ex.Source + "_Intensity" + ex.Message);
			return text;
		}
	}

	public IEnumerator IJIAAMFLGLL(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator FJOFJMFCCOJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public bool BOFENDOCGOJ()
	{
		return LAONIGHJPPD == 0;
	}

	public static string GPCLGBNNMFO(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains(" registered."))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("settings.disablestoryboard" + ex.Source + "BitsData" + ex.Message);
			return text;
		}
	}

	public static string LDIFPCKBMBC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("_Value2"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("maps." + ex.Source + "skin." + ex.Message);
			return text;
		}
	}

	public IEnumerator DEKCJCBJCPA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator KBNFDPGCDBJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public static string MJFAIPIAHAM(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("CameraFilterPack/TV_PlanetMars"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("y" + ex.Source + "_TimeX" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region ENHDLNKECPF()
	{
		Region result = null;
		int num = 128;
		foreach (Region item in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("_RGB" + item);
			if (item.Ping != 0 && item.Ping < num)
			{
				num = item.Ping;
				result = item;
			}
		}
		return result;
	}

	public IEnumerator EIPLJCBOBPA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public Region NJFAIHPONKD()
	{
		Region result = null;
		int num = 124;
		foreach (Region item in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log(" : " + item);
			if (item.Ping != 0 && item.Ping < num)
			{
				num = item.Ping;
				result = item;
			}
		}
		return result;
	}

	public static string ResolveHost(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains(":"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("Exception caught! " + ex.Source + " Message: " + ex.Message);
			return text;
		}
	}

	public IEnumerator JHCFCNGNLMB(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public static string IMOLKLDMGFN(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("_MainTex"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("Fill Area" + ex.Source + "[LocalizationService] All languages: " + ex.Message);
			return text;
		}
	}

	public IEnumerator FAIHGNPBNHO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator PingSocket(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator MGIILGNOEIB(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator NPIDOHABGBI(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public static string EBAAOAHBNDA(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("_Value"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("76561198041679481" + ex.Source + "Scrollbar" + ex.Message);
			return text;
		}
	}

	public IEnumerator JFIKCFLOIEJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	public IEnumerator IGKIIGGLPIF(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = Attempts * MaxMilliseconsPerPing;
		LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH != typeof(PingNativeStatic))
		{
			photonPing = ((PhotonHandler.LEILCLLNGGH != typeof(PingMono)) ? ((PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH)) : new PingMono());
		}
		else
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = ResolveHost(text);
		for (int i = 0; i < Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("catched: " + ex);
				LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if ((!IgnoreInitialAttempt || i != 0) && photonPing.Successful && !flag)
			{
				num += (float)num5;
				num2++;
				LPCNAHJGAFK.Ping = (int)(num / (float)num2);
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		LAONIGHJPPD--;
		yield return null;
	}

	[SpecialName]
	public bool GMACBIJPBFB()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public Region FNMKAPINHCA()
	{
		Region result = null;
		int num = -64;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("USE_UV_BASED_REPROJECTION" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string FMPAOKDMAAC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[1].ToString();
			}
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("CameraFilterPack/BlurTiltShift_V"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("workshop." + ex.Source + "_TapLow" + ex.Message);
			return text;
		}
	}

	public static string PFKKPPHFLDK(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("Event Received"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("ZoomSpeed" + ex.Source + "_Saturation" + ex.Message);
			return text;
		}
	}

	public static string GBMJMBGHMGE(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("Player"))
					{
						return iPAddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("_Near" + ex.Source + "CameraFilterPack/Light_Rainbow2" + ex.Message);
			return text;
		}
	}
}
