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

	public IEnumerator HJNJHHDMCLB(Region LPCNAHJGAFK)
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
	public bool HJKNBIEGABJ()
	{
		return LAONIGHJPPD == 0;
	}

	public static string PMHIDDGICPK(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("Drop_Near"))
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
			UnityEngine.Debug.Log("visible" + ex.Source + "Hex value #RRGGBB" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public bool LNHDOLFKEKE()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public bool CLFABIHBHEK()
	{
		return LAONIGHJPPD == 0;
	}

	public static string GBMJMBGHMGE(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("float,0"))
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
			UnityEngine.Debug.Log("/" + ex.Source + "EventConfigButton" + ex.Message);
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

	public static string KODGNIKOPKB(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("_ScreenResolution"))
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
			UnityEngine.Debug.Log("Texture2" + ex.Source + "CameraFilterPack/Real_VHS" + ex.Message);
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

	public IEnumerator NCIJCHEKMIB(Region LPCNAHJGAFK)
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

	public IEnumerator JLJFMCDOOKF(Region LPCNAHJGAFK)
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

	public IEnumerator KHLIBOBDOAH(Region LPCNAHJGAFK)
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
	public Region BOEOCKKGMFB()
	{
		Region result = null;
		int num = -107;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("DPADVER" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public IEnumerator PENHDNCDCPH(Region LPCNAHJGAFK)
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

	public static string AJLDNCPEAAF(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("LoadPlayerEnvironment"))
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
			UnityEngine.Debug.Log("Screenshots only supported in PlayMode" + ex.Source + "EnableRankedNotificationsToggle" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public bool BOLKKKDFBKM()
	{
		return LAONIGHJPPD == 1;
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
	public Region IDOPGMNDDOD()
	{
		Region result = null;
		int num = 105;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("Mouse Y" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string HAJKNENBFPI(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("_PColor2"))
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
			UnityEngine.Debug.Log("_Value3" + ex.Source + "CameraFilterPack_Glasses_On7" + ex.Message);
			return text;
		}
	}

	public static string EMGNAEEGMJH(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("_ScreenSize"))
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
			UnityEngine.Debug.Log("CameraFilterPack/Blend2Camera_VividLight" + ex.Source + "..." + ex.Message);
			return text;
		}
	}

	public static string KBJAEGIHBFJ(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("<color=#{0}>{1}</color>"))
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
			UnityEngine.Debug.Log("_ScreenResolution" + ex.Source + "id" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public bool ECDNJOOFIKO()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public Region JPBBBNDKCAD()
	{
		Region result = null;
		int num = 109;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("CameraFilterPack/Blend2Camera_Overlay" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public bool KACAHOFIANL()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool FBCJKIPPPBE()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public bool JPJMINDNKPP()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public Region ENHDLNKECPF()
	{
		Region result = null;
		int num = 174;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("_ScreenResolution" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string DKAMGPJPEFD(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains(" not exist"))
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
			UnityEngine.Debug.Log("id" + ex.Source + "\t" + ex.Message);
			return text;
		}
	}

	public IEnumerator ODKEJABDMIN(Region LPCNAHJGAFK)
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
	public bool PHGDAELGCKE()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public Region DDFFPPECOAA()
	{
		Region result = null;
		int num = -197;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("." + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string CFDEAKMOOHA(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("https://steamcommunity.com/sharedfiles/filedetails/?id="))
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
			UnityEngine.Debug.Log("CameraFilterPack/Blend2Camera_Saturation" + ex.Source + "_TimeX" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public bool BDBENNCJCGE()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool GMDCHLNMCGF()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool NDGDGFJJNMC()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public bool AFIFABNPHOD()
	{
		return LAONIGHJPPD == 0;
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

	public IEnumerator FEGCCMGIEKL(Region LPCNAHJGAFK)
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

	public static string KKGDFDOIJJA(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("mainmenu"))
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
			UnityEngine.Debug.Log("cipherText" + ex.Source + "3;4;9;10;21x6" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public bool ADFOEPGEAIM()
	{
		return LAONIGHJPPD == 0;
	}

	public IEnumerator PKPBEKFNNOE(Region LPCNAHJGAFK)
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
	public bool CDIJGHEDMFH()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool LKBDGNJIDCK()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public bool EFDOEAFPOJH()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public Region GFCFBMENFEM()
	{
		Region result = null;
		int num = -74;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("Hello World, is my item a clone? [" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public IEnumerator LHDKBJJGEIM(Region LPCNAHJGAFK)
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

	public IEnumerator IAHLCKCOALM(Region LPCNAHJGAFK)
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

	public static string MOENLNFCOBC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("settings.crosshairopacity"))
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
			UnityEngine.Debug.Log("y" + ex.Source + "$ {0}" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region CEKCLKCBNKJ()
	{
		Region result = null;
		int num = -200;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("skin." + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string MPALHLKLLBL(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress iPAddress = hostAddresses[i];
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
			UnityEngine.Debug.Log("_ScreenResolution" + ex.Source + "[PlayerBase] Delete checkpoint data" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region KLJIOGDEBGG()
	{
		Region result = null;
		int num = -72;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("EditMenu" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public IEnumerator NDFMCECHNOP(Region LPCNAHJGAFK)
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
	public Region PENOEHHJIPE()
	{
		Region result = null;
		int num = 86;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("#mapnotloaded" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string OBBDJDPHPII(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains("end"))
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
			UnityEngine.Debug.Log("_Value" + ex.Source + "_TimeX" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region BGMNGFNPIOB()
	{
		Region result = null;
		int num = 112;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("_VelocityScale" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string MMIMIKKIIGH(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("PointsScoreText"))
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
			UnityEngine.Debug.Log("yesterday" + ex.Source + "RecordButton" + ex.Message);
			return text;
		}
	}

	public IEnumerator JPKEIFODNJE(Region LPCNAHJGAFK)
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
	public Region KIKOOHMPKCM()
	{
		Region result = null;
		int num = -84;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("/" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string KEHAENCPPOK(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("BitsData"))
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
			UnityEngine.Debug.Log(" argument(s): " + ex.Source + "skin.hit_perfect" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region EHAKMHKLIGI()
	{
		Region result = null;
		int num = -101;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("float,10" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
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

	[SpecialName]
	public bool KLBFNJAGAME()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public bool PMKMPNKFNHD()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public Region BKCJBGJIMGA()
	{
		Region result = null;
		int num = -135;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("_AlphaMask" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public Region HGMLPAPBDGG()
	{
		Region result = null;
		int num = -34;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("shader.frost" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public Region DKCHKKCNBNA()
	{
		Region result = null;
		int num = -86;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("icon.png" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public Region AKIAKHPJLFF()
	{
		Region result = null;
		int num = 159;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("BackButton" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public IEnumerator MLCPOCMJMAC(Region LPCNAHJGAFK)
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

	public IEnumerator LAMLOCHKIDO(Region LPCNAHJGAFK)
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
	public Region NOOLOBKOIEM()
	{
		Region result = null;
		int num = 90;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("#ok" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public bool EGNCPNPHGNE()
	{
		return LAONIGHJPPD == 0;
	}

	public IEnumerator NIEILENACFN(Region LPCNAHJGAFK)
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
	public bool BCOEDKLKDCB()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public Region FMJNADPMOJE()
	{
		Region result = null;
		int num = 62;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("Init" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public bool LLJFDGEJEFB()
	{
		return LAONIGHJPPD == 0;
	}

	[SpecialName]
	public Region LCECBMBELOB()
	{
		Region result = null;
		int num = -6;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("downloading" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public IEnumerator KNJEDGKMDIJ(Region LPCNAHJGAFK)
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
	public Region EAEDIKHGEJI()
	{
		Region result = null;
		int num = -197;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("_Value" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public Region HKBMLKLAJDE()
	{
		Region result = null;
		int num = -113;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log(" with prefix " + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	[SpecialName]
	public bool LHDJECFLMCB()
	{
		return LAONIGHJPPD == 1;
	}

	[SpecialName]
	public Region BNLJALPLNLI()
	{
		Region result = null;
		int num = -38;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("clear" + availableRegion);
			if (availableRegion.Ping != 0 && availableRegion.Ping < num)
			{
				num = availableRegion.Ping;
				result = availableRegion;
			}
		}
		return result;
	}

	public static string BBHPFMHABIE(string DIBNLGMIJMN)
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
					if (iPAddress.ToString().Contains("Menu"))
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
			UnityEngine.Debug.Log("_ScreenResolution" + ex.Source + "[CraftingPanel] Init" + ex.Message);
			return text;
		}
	}

	[SpecialName]
	public Region IGCIEOMIAOF()
	{
		Region result = null;
		int num = -195;
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("_ScreenResolution" + availableRegion);
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
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress iPAddress = hostAddresses[i];
				if (iPAddress != null)
				{
					if (iPAddress.ToString().Contains(".lastCheckpoint.penaltyScore"))
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
			UnityEngine.Debug.Log("GlassColor" + ex.Source + "_Value7" + ex.Message);
			return text;
		}
	}
}
