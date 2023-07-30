// DiscordRpc
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using AOT;

public class DiscordRpc
{
	public delegate void OnReadyInfo(ref DiscordUser OCGEBABNLAG);

	public delegate void OnDisconnectedInfo(int PNCJHNNOAAP, string JKPJCEMPAGH);

	public delegate void OnErrorInfo(int PNCJHNNOAAP, string JKPJCEMPAGH);

	public delegate void OnJoinInfo(string MJDPJLOCLIL);

	public delegate void OnSpectateInfo(string MJDPJLOCLIL);

	public delegate void OnRequestInfo(ref DiscordUser GILCPIJNOKK);

	public struct EventHandlers
	{
		public OnReadyInfo readyCallback;

		public OnDisconnectedInfo disconnectedCallback;

		public OnErrorInfo errorCallback;

		public OnJoinInfo joinCallback;

		public OnSpectateInfo spectateCallback;

		public OnRequestInfo requestCallback;
	}

	[Serializable]
	public struct RichPresenceStruct
	{
		public IntPtr state;

		public IntPtr details;

		public long startTimestamp;

		public long endTimestamp;

		public IntPtr largeImageKey;

		public IntPtr largeImageText;

		public IntPtr smallImageKey;

		public IntPtr smallImageText;

		public IntPtr partyId;

		public int partySize;

		public int partyMax;

		public IntPtr matchSecret;

		public IntPtr joinSecret;

		public IntPtr spectateSecret;

		public bool instance;
	}

	[Serializable]
	public struct DiscordUser
	{
		public string userId;

		public string username;

		public string discriminator;

		public string avatar;
	}

	public enum Reply
	{
		No,
		Yes,
		Ignore
	}

	public class RichPresence
	{
		private RichPresenceStruct DMNAKKMENPA;

		private readonly List<IntPtr> CGNGJCKDCME = new List<IntPtr>(10);

		public string state;

		public string details;

		public long startTimestamp;

		public long endTimestamp;

		public string largeImageKey;

		public string largeImageText;

		public string smallImageKey;

		public string smallImageText;

		public string partyId;

		public int partySize;

		public int partyMax;

		public string matchSecret;

		public string joinSecret;

		public string spectateSecret;

		public bool instance;

		private IntPtr LJIOGNNAGJM(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct KIMDNABCOAC()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FMFDHOIPJDA();
			}
			DMNAKKMENPA.state = EOBEHMPAHLP(state);
			DMNAKKMENPA.details = EOBEHMPAHLP(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = EOBEHMPAHLP(largeImageKey);
			DMNAKKMENPA.largeImageText = EOBEHMPAHLP(largeImageText);
			DMNAKKMENPA.smallImageKey = EOBEHMPAHLP(smallImageKey);
			DMNAKKMENPA.smallImageText = EOBEHMPAHLP(smallImageText);
			DMNAKKMENPA.partyId = EOBEHMPAHLP(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = EOBEHMPAHLP(matchSecret);
			DMNAKKMENPA.joinSecret = EOBEHMPAHLP(joinSecret);
			DMNAKKMENPA.spectateSecret = EOBEHMPAHLP(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct LJHANDCFKPM()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				LNJKFFEMPAM();
			}
			DMNAKKMENPA.state = FBJPOBHMDJI(state);
			DMNAKKMENPA.details = LNCLFLFBOOI(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = AKELBIKHGIG(largeImageKey);
			DMNAKKMENPA.largeImageText = KLFAJBACGIN(largeImageText);
			DMNAKKMENPA.smallImageKey = HLPLFJFEMAJ(smallImageKey);
			DMNAKKMENPA.smallImageText = KLFAJBACGIN(smallImageText);
			DMNAKKMENPA.partyId = FBPCBMMACFG(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = FBPCBMMACFG(matchSecret);
			DMNAKKMENPA.joinSecret = PCPGPLAAOFP(joinSecret);
			DMNAKKMENPA.spectateSecret = FBPCBMMACFG(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct HFIAFGHGMJJ()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FDCBNFFDJEL();
			}
			DMNAKKMENPA.state = DDOIPOAJLEB(state);
			DMNAKKMENPA.details = ECFJGEDDAIF(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = HLPLFJFEMAJ(largeImageKey);
			DMNAKKMENPA.largeImageText = AHICFOLOPJD(largeImageText);
			DMNAKKMENPA.smallImageKey = ABAJMFLNCCI(smallImageKey);
			DMNAKKMENPA.smallImageText = HGHIMGONHGD(smallImageText);
			DMNAKKMENPA.partyId = IKOJFIBOMPL(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = NJOGBILMBEB(matchSecret);
			DMNAKKMENPA.joinSecret = ECFJGEDDAIF(joinSecret);
			DMNAKKMENPA.spectateSecret = ABAJMFLNCCI(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void DCKAMPILMGC()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void BECBJJGLCAB()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct LPILMKAHAIG()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				ECHDPKAGJJC();
			}
			DMNAKKMENPA.state = BAIKDHMNEGC(state);
			DMNAKKMENPA.details = FBPCBMMACFG(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = ECPAKKOFJKC(largeImageKey);
			DMNAKKMENPA.largeImageText = DGEHKLJBGOI(largeImageText);
			DMNAKKMENPA.smallImageKey = DDOIPOAJLEB(smallImageKey);
			DMNAKKMENPA.smallImageText = ECIIHBMAHIK(smallImageText);
			DMNAKKMENPA.partyId = EABJDGOOHKC(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = GNODDDNCKIE(matchSecret);
			DMNAKKMENPA.joinSecret = EOBEHMPAHLP(joinSecret);
			DMNAKKMENPA.spectateSecret = ECFJGEDDAIF(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string HEAMIBDBPLD(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "_Value2";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void POOBLDFJFKE()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string JMJCPDBCAAN(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "Clear Environment";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string EHGNGLOMGHO(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "[Up]";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr BAIKDHMNEGC(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal void FMFDHOIPJDA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr AHICFOLOPJD(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr NJOGBILMBEB(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct AFEIAKPNOCG()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				HANDPIKONCN();
			}
			DMNAKKMENPA.state = IJDPHENMHFA(state);
			DMNAKKMENPA.details = LJIOGNNAGJM(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GAHDAKBJJBE(largeImageKey);
			DMNAKKMENPA.largeImageText = HLPLFJFEMAJ(largeImageText);
			DMNAKKMENPA.smallImageKey = GNODDDNCKIE(smallImageKey);
			DMNAKKMENPA.smallImageText = DDOIPOAJLEB(smallImageText);
			DMNAKKMENPA.partyId = KLGOFBKGHJC(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LJIOGNNAGJM(matchSecret);
			DMNAKKMENPA.joinSecret = HLCHEJHOBFJ(joinSecret);
			DMNAKKMENPA.spectateSecret = OPMLDPIBBDK(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string LEBHBNENKGD(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "open";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void BPLLAKDACDI()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void PFMDDCBFEPF()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr ECPAKKOFJKC(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr OCGECCCHJNA(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr DDOIPOAJLEB(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal void NKKOIONHHPP()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void CNGPNJIBLKJ()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string NDBIJFCACHM(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "saveGameName ";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string CEPMGGKLGHN(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += " or ";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string MGCFNFANOFJ(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "_Value4";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct KKBGDFJEGDG()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				AMBJODCOEDP();
			}
			DMNAKKMENPA.state = FBPCBMMACFG(state);
			DMNAKKMENPA.details = LJIOGNNAGJM(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GAHDAKBJJBE(largeImageKey);
			DMNAKKMENPA.largeImageText = NJOGBILMBEB(largeImageText);
			DMNAKKMENPA.smallImageKey = ABAJMFLNCCI(smallImageKey);
			DMNAKKMENPA.smallImageText = LNCLFLFBOOI(smallImageText);
			DMNAKKMENPA.partyId = OPMLDPIBBDK(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LJIOGNNAGJM(matchSecret);
			DMNAKKMENPA.joinSecret = JLIFDNMCEOH(joinSecret);
			DMNAKKMENPA.spectateSecret = JLIFDNMCEOH(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr FBPCBMMACFG(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct BFOKCNLNCCO()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				BPLLAKDACDI();
			}
			DMNAKKMENPA.state = LNCLFLFBOOI(state);
			DMNAKKMENPA.details = LNCLFLFBOOI(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = LILHGANNOFA(largeImageKey);
			DMNAKKMENPA.largeImageText = IKOJFIBOMPL(largeImageText);
			DMNAKKMENPA.smallImageKey = EOBEHMPAHLP(smallImageKey);
			DMNAKKMENPA.smallImageText = IJDPHENMHFA(smallImageText);
			DMNAKKMENPA.partyId = HLCHEJHOBFJ(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = EOBEHMPAHLP(matchSecret);
			DMNAKKMENPA.joinSecret = BGGDNOFMPIN(joinSecret);
			DMNAKKMENPA.spectateSecret = LJIOGNNAGJM(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr KLGOFBKGHJC(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr KBHOGNLGPOA(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal void JCBOGCIFCCC()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr HLCHEJHOBFJ(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private static string DBKHDBEPLGN(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "0.000";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr GNODDDNCKIE(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr GJCBDNCLBIF(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr GAHDAKBJJBE(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal void JGJIBGMDIMH()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr OPMLDPIBBDK(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal void FEGJFGGJEGM()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct EBJHODHJGOG()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FEMCFCOJNFJ();
			}
			DMNAKKMENPA.state = LJIOGNNAGJM(state);
			DMNAKKMENPA.details = NFGAKIDJPDM(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = HLCHEJHOBFJ(largeImageKey);
			DMNAKKMENPA.largeImageText = AGIIHKLLGMO(largeImageText);
			DMNAKKMENPA.smallImageKey = IKOJFIBOMPL(smallImageKey);
			DMNAKKMENPA.smallImageText = HLPLFJFEMAJ(smallImageText);
			DMNAKKMENPA.partyId = OPMLDPIBBDK(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = IJDPHENMHFA(matchSecret);
			DMNAKKMENPA.joinSecret = LNCLFLFBOOI(joinSecret);
			DMNAKKMENPA.spectateSecret = OPMLDPIBBDK(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr ECIIHBMAHIK(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal void KKLOGOCGJCN()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct DCOBCKJGALF()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FMFDHOIPJDA();
			}
			DMNAKKMENPA.state = FBJPOBHMDJI(state);
			DMNAKKMENPA.details = LILHGANNOFA(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = LNCLFLFBOOI(largeImageKey);
			DMNAKKMENPA.largeImageText = NFGAKIDJPDM(largeImageText);
			DMNAKKMENPA.smallImageKey = ECFJGEDDAIF(smallImageKey);
			DMNAKKMENPA.smallImageText = IKOJFIBOMPL(smallImageText);
			DMNAKKMENPA.partyId = LNCLFLFBOOI(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = IJDPHENMHFA(matchSecret);
			DMNAKKMENPA.joinSecret = IKOJFIBOMPL(joinSecret);
			DMNAKKMENPA.spectateSecret = IEPAGHFPEID(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string CCLDEPIGGNF(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "\0\0";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void MODKCIFPPNL()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void AFOBGDNPPMF()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct NILHIFDHPIA()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				HLCMIOMAKCF();
			}
			DMNAKKMENPA.state = AHICFOLOPJD(state);
			DMNAKKMENPA.details = KLGOFBKGHJC(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = KOLAHGJANED(largeImageKey);
			DMNAKKMENPA.largeImageText = NJOGBILMBEB(largeImageText);
			DMNAKKMENPA.smallImageKey = IJDPHENMHFA(smallImageKey);
			DMNAKKMENPA.smallImageText = GJCBDNCLBIF(smallImageText);
			DMNAKKMENPA.partyId = NFGAKIDJPDM(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LILHGANNOFA(matchSecret);
			DMNAKKMENPA.joinSecret = BGGDNOFMPIN(joinSecret);
			DMNAKKMENPA.spectateSecret = KBHOGNLGPOA(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string IJFGCHIKFCI(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += " or player:";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string OFPNDIECCPH(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "Encryption wasn't established: ";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr IEPAGHFPEID(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private static string LCFMEAFNDPP(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "Vertical";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string OKADBANEBJP(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "FileMenu";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void MLLFGDFNKEA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct FAAKBGEHOJE()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				PFMDDCBFEPF();
			}
			DMNAKKMENPA.state = NFGAKIDJPDM(state);
			DMNAKKMENPA.details = KLFAJBACGIN(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = FBJPOBHMDJI(largeImageKey);
			DMNAKKMENPA.largeImageText = NFGAKIDJPDM(largeImageText);
			DMNAKKMENPA.smallImageKey = OCGECCCHJNA(smallImageKey);
			DMNAKKMENPA.smallImageText = OCGECCCHJNA(smallImageText);
			DMNAKKMENPA.partyId = ECFJGEDDAIF(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = NJOGBILMBEB(matchSecret);
			DMNAKKMENPA.joinSecret = HLCHEJHOBFJ(joinSecret);
			DMNAKKMENPA.spectateSecret = NJOGBILMBEB(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct JHEFKAMECNO()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				MGOHCFMCMMP();
			}
			DMNAKKMENPA.state = GNODDDNCKIE(state);
			DMNAKKMENPA.details = IEPAGHFPEID(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = IEPAGHFPEID(largeImageKey);
			DMNAKKMENPA.largeImageText = KOLAHGJANED(largeImageText);
			DMNAKKMENPA.smallImageKey = NFGAKIDJPDM(smallImageKey);
			DMNAKKMENPA.smallImageText = KLGOFBKGHJC(smallImageText);
			DMNAKKMENPA.partyId = EOBEHMPAHLP(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LILHGANNOFA(matchSecret);
			DMNAKKMENPA.joinSecret = ECPAKKOFJKC(joinSecret);
			DMNAKKMENPA.spectateSecret = EABJDGOOHKC(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string JDOHCNKLMBL(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "scenes";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string BJDCBNPHCEK(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "\n";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void PGHODIJDAJA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void AFFMNPENHID()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct MPEKFDOBLLE()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				KKLOGOCGJCN();
			}
			DMNAKKMENPA.state = HLPLFJFEMAJ(state);
			DMNAKKMENPA.details = OPMLDPIBBDK(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = KLGOFBKGHJC(largeImageKey);
			DMNAKKMENPA.largeImageText = FBPCBMMACFG(largeImageText);
			DMNAKKMENPA.smallImageKey = GJCBDNCLBIF(smallImageKey);
			DMNAKKMENPA.smallImageText = FBPCBMMACFG(smallImageText);
			DMNAKKMENPA.partyId = AGIIHKLLGMO(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LNCLFLFBOOI(matchSecret);
			DMNAKKMENPA.joinSecret = BAIKDHMNEGC(joinSecret);
			DMNAKKMENPA.spectateSecret = HGHIMGONHGD(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string ANDFLGJLJOH(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "/";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string NOMFGLNBNHO(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "Failed to InstantiateSceneObject prefab: ";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void IIHAGHJDKKN()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr JLIFDNMCEOH(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct OIKFHNDDOEO()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				NKKOIONHHPP();
			}
			DMNAKKMENPA.state = IJDPHENMHFA(state);
			DMNAKKMENPA.details = IJDPHENMHFA(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = AKELBIKHGIG(largeImageKey);
			DMNAKKMENPA.largeImageText = DGEHKLJBGOI(largeImageText);
			DMNAKKMENPA.smallImageKey = EABJDGOOHKC(smallImageKey);
			DMNAKKMENPA.smallImageText = OPMLDPIBBDK(smallImageText);
			DMNAKKMENPA.partyId = ECIIHBMAHIK(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = KLGOFBKGHJC(matchSecret);
			DMNAKKMENPA.joinSecret = AHICFOLOPJD(joinSecret);
			DMNAKKMENPA.spectateSecret = FCHDBBNFBPO(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct OFHIMLLAAGP()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				PGHODIJDAJA();
			}
			DMNAKKMENPA.state = LNCLFLFBOOI(state);
			DMNAKKMENPA.details = BAIKDHMNEGC(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = BGGDNOFMPIN(largeImageKey);
			DMNAKKMENPA.largeImageText = BAIKDHMNEGC(largeImageText);
			DMNAKKMENPA.smallImageKey = IKOJFIBOMPL(smallImageKey);
			DMNAKKMENPA.smallImageText = DGEHKLJBGOI(smallImageText);
			DMNAKKMENPA.partyId = ECPAKKOFJKC(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = GJCBDNCLBIF(matchSecret);
			DMNAKKMENPA.joinSecret = HLPLFJFEMAJ(joinSecret);
			DMNAKKMENPA.spectateSecret = KBHOGNLGPOA(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr HBILPKAFJBA(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct FIAKCHLOCFP()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				KKLOGOCGJCN();
			}
			DMNAKKMENPA.state = BGGDNOFMPIN(state);
			DMNAKKMENPA.details = LILHGANNOFA(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = HGHIMGONHGD(largeImageKey);
			DMNAKKMENPA.largeImageText = IKOJFIBOMPL(largeImageText);
			DMNAKKMENPA.smallImageKey = EABJDGOOHKC(smallImageKey);
			DMNAKKMENPA.smallImageText = AGIIHKLLGMO(smallImageText);
			DMNAKKMENPA.partyId = IEPAGHFPEID(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = HGHIMGONHGD(matchSecret);
			DMNAKKMENPA.joinSecret = IJDPHENMHFA(joinSecret);
			DMNAKKMENPA.spectateSecret = LJIOGNNAGJM(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct DFBBNOJDKIC()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FMFDHOIPJDA();
			}
			DMNAKKMENPA.state = GJCBDNCLBIF(state);
			DMNAKKMENPA.details = FCHDBBNFBPO(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = KBHOGNLGPOA(largeImageKey);
			DMNAKKMENPA.largeImageText = GAHDAKBJJBE(largeImageText);
			DMNAKKMENPA.smallImageKey = BAIKDHMNEGC(smallImageKey);
			DMNAKKMENPA.smallImageText = GJCBDNCLBIF(smallImageText);
			DMNAKKMENPA.partyId = ABAJMFLNCCI(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = NJOGBILMBEB(matchSecret);
			DMNAKKMENPA.joinSecret = FCHDBBNFBPO(joinSecret);
			DMNAKKMENPA.spectateSecret = ECIIHBMAHIK(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string DKKKDGMJPGC(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "Emergency Help:";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct OMHICEEFEOH()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				IIHAGHJDKKN();
			}
			DMNAKKMENPA.state = LJIOGNNAGJM(state);
			DMNAKKMENPA.details = GNODDDNCKIE(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = EABJDGOOHKC(largeImageKey);
			DMNAKKMENPA.largeImageText = EABJDGOOHKC(largeImageText);
			DMNAKKMENPA.smallImageKey = HLCHEJHOBFJ(smallImageKey);
			DMNAKKMENPA.smallImageText = EOBEHMPAHLP(smallImageText);
			DMNAKKMENPA.partyId = FCHDBBNFBPO(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = FCHDBBNFBPO(matchSecret);
			DMNAKKMENPA.joinSecret = BFNDHPDPFEM(joinSecret);
			DMNAKKMENPA.spectateSecret = AKELBIKHGIG(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string FACMCMNLBMK(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "_TimeX";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct HKFMEJAAJDH()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				FMFDHOIPJDA();
			}
			DMNAKKMENPA.state = LILHGANNOFA(state);
			DMNAKKMENPA.details = KLGOFBKGHJC(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GJCBDNCLBIF(largeImageKey);
			DMNAKKMENPA.largeImageText = BAIKDHMNEGC(largeImageText);
			DMNAKKMENPA.smallImageKey = KLGOFBKGHJC(smallImageKey);
			DMNAKKMENPA.smallImageText = IJDPHENMHFA(smallImageText);
			DMNAKKMENPA.partyId = AHICFOLOPJD(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = PCPGPLAAOFP(matchSecret);
			DMNAKKMENPA.joinSecret = GAHDAKBJJBE(joinSecret);
			DMNAKKMENPA.spectateSecret = AGIIHKLLGMO(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void AMBJODCOEDP()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string BDPBPAGEBLI(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "_ScreenResolution";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void CFOCNEFEKPM()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct GBGNFGMGKLG()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				LOPEAOJMAMF();
			}
			DMNAKKMENPA.state = HLPLFJFEMAJ(state);
			DMNAKKMENPA.details = NJOGBILMBEB(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = ECPAKKOFJKC(largeImageKey);
			DMNAKKMENPA.largeImageText = KLGOFBKGHJC(largeImageText);
			DMNAKKMENPA.smallImageKey = FCHDBBNFBPO(smallImageKey);
			DMNAKKMENPA.smallImageText = KBHOGNLGPOA(smallImageText);
			DMNAKKMENPA.partyId = IEPAGHFPEID(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = HGHIMGONHGD(matchSecret);
			DMNAKKMENPA.joinSecret = DDOIPOAJLEB(joinSecret);
			DMNAKKMENPA.spectateSecret = NJOGBILMBEB(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void HAAFBGNIFNB()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr PCPGPLAAOFP(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private static string NBPBAEGGBHJ(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "CameraFilterPack/Gradients_Ansi";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void OHLMBBNOPMM()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string EIGLFNPICOA(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "SetSatelliteEmission";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct EDMICNADOFP()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				IKEOHFINPJE();
			}
			DMNAKKMENPA.state = GNODDDNCKIE(state);
			DMNAKKMENPA.details = IKOJFIBOMPL(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = BFNDHPDPFEM(largeImageKey);
			DMNAKKMENPA.largeImageText = BFNDHPDPFEM(largeImageText);
			DMNAKKMENPA.smallImageKey = KBHOGNLGPOA(smallImageKey);
			DMNAKKMENPA.smallImageText = GNODDDNCKIE(smallImageText);
			DMNAKKMENPA.partyId = HLPLFJFEMAJ(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = KLFAJBACGIN(matchSecret);
			DMNAKKMENPA.joinSecret = KLFAJBACGIN(joinSecret);
			DMNAKKMENPA.spectateSecret = BAIKDHMNEGC(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void FDCBNFFDJEL()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string NGOKPMFBACM(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "_TimeX";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr KLFAJBACGIN(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct NLEAFLENJII()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				POOBLDFJFKE();
			}
			DMNAKKMENPA.state = AHICFOLOPJD(state);
			DMNAKKMENPA.details = EOBEHMPAHLP(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GNODDDNCKIE(largeImageKey);
			DMNAKKMENPA.largeImageText = NFGAKIDJPDM(largeImageText);
			DMNAKKMENPA.smallImageKey = NJOGBILMBEB(smallImageKey);
			DMNAKKMENPA.smallImageText = EABJDGOOHKC(smallImageText);
			DMNAKKMENPA.partyId = IKOJFIBOMPL(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = ECPAKKOFJKC(matchSecret);
			DMNAKKMENPA.joinSecret = GAHDAKBJJBE(joinSecret);
			DMNAKKMENPA.spectateSecret = GNODDDNCKIE(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct NALNFICHJOB()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				OHLMBBNOPMM();
			}
			DMNAKKMENPA.state = IJDPHENMHFA(state);
			DMNAKKMENPA.details = LJIOGNNAGJM(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = KOLAHGJANED(largeImageKey);
			DMNAKKMENPA.largeImageText = EABJDGOOHKC(largeImageText);
			DMNAKKMENPA.smallImageKey = GAHDAKBJJBE(smallImageKey);
			DMNAKKMENPA.smallImageText = FCHDBBNFBPO(smallImageText);
			DMNAKKMENPA.partyId = FBPCBMMACFG(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = KOLAHGJANED(matchSecret);
			DMNAKKMENPA.joinSecret = ECPAKKOFJKC(joinSecret);
			DMNAKKMENPA.spectateSecret = ABAJMFLNCCI(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string HBNLLKNGNCB(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "note.4";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr BFNDHPDPFEM(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct OAIEKOLIAMK()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				PFMDDCBFEPF();
			}
			DMNAKKMENPA.state = LILHGANNOFA(state);
			DMNAKKMENPA.details = GJCBDNCLBIF(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GNODDDNCKIE(largeImageKey);
			DMNAKKMENPA.largeImageText = ECIIHBMAHIK(largeImageText);
			DMNAKKMENPA.smallImageKey = PCPGPLAAOFP(smallImageKey);
			DMNAKKMENPA.smallImageText = LILHGANNOFA(smallImageText);
			DMNAKKMENPA.partyId = NFGAKIDJPDM(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = ABAJMFLNCCI(matchSecret);
			DMNAKKMENPA.joinSecret = GNODDDNCKIE(joinSecret);
			DMNAKKMENPA.spectateSecret = GNODDDNCKIE(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr ABAJMFLNCCI(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr LILHGANNOFA(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct IKHIALABKNO()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				PGHODIJDAJA();
			}
			DMNAKKMENPA.state = LILHGANNOFA(state);
			DMNAKKMENPA.details = AKELBIKHGIG(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = ECPAKKOFJKC(largeImageKey);
			DMNAKKMENPA.largeImageText = FBPCBMMACFG(largeImageText);
			DMNAKKMENPA.smallImageKey = AGIIHKLLGMO(smallImageKey);
			DMNAKKMENPA.smallImageText = BGGDNOFMPIN(smallImageText);
			DMNAKKMENPA.partyId = BGGDNOFMPIN(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = AKELBIKHGIG(matchSecret);
			DMNAKKMENPA.joinSecret = OCGECCCHJNA(joinSecret);
			DMNAKKMENPA.spectateSecret = BGGDNOFMPIN(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr BGGDNOFMPIN(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct DOKDHMLBPPA()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				HIOKFIHOFLM();
			}
			DMNAKKMENPA.state = BGGDNOFMPIN(state);
			DMNAKKMENPA.details = HLPLFJFEMAJ(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = ABAJMFLNCCI(largeImageKey);
			DMNAKKMENPA.largeImageText = GAHDAKBJJBE(largeImageText);
			DMNAKKMENPA.smallImageKey = IKOJFIBOMPL(smallImageKey);
			DMNAKKMENPA.smallImageText = HLCHEJHOBFJ(smallImageText);
			DMNAKKMENPA.partyId = ABAJMFLNCCI(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = LNCLFLFBOOI(matchSecret);
			DMNAKKMENPA.joinSecret = JLIFDNMCEOH(joinSecret);
			DMNAKKMENPA.spectateSecret = LILHGANNOFA(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr IKOJFIBOMPL(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private static string NLEOFHFLPPG(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "_BlurParams";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void ECHDPKAGJJC()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr NFGAKIDJPDM(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr ECFJGEDDAIF(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr IJDPHENMHFA(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr LNCLFLFBOOI(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr HGHIMGONHGD(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct KPNPBMAHOPF()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				BPLLAKDACDI();
			}
			DMNAKKMENPA.state = BAIKDHMNEGC(state);
			DMNAKKMENPA.details = JLIFDNMCEOH(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = GNODDDNCKIE(largeImageKey);
			DMNAKKMENPA.largeImageText = GAHDAKBJJBE(largeImageText);
			DMNAKKMENPA.smallImageKey = GAHDAKBJJBE(smallImageKey);
			DMNAKKMENPA.smallImageText = EOBEHMPAHLP(smallImageText);
			DMNAKKMENPA.partyId = IEPAGHFPEID(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = FBPCBMMACFG(matchSecret);
			DMNAKKMENPA.joinSecret = JLIFDNMCEOH(joinSecret);
			DMNAKKMENPA.spectateSecret = PCPGPLAAOFP(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct FACDCHCONEO()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				CFOCNEFEKPM();
			}
			DMNAKKMENPA.state = AGIIHKLLGMO(state);
			DMNAKKMENPA.details = KLGOFBKGHJC(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = LJIOGNNAGJM(largeImageKey);
			DMNAKKMENPA.largeImageText = FBPCBMMACFG(largeImageText);
			DMNAKKMENPA.smallImageKey = GAHDAKBJJBE(smallImageKey);
			DMNAKKMENPA.smallImageText = ECFJGEDDAIF(smallImageText);
			DMNAKKMENPA.partyId = KLGOFBKGHJC(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = IEPAGHFPEID(matchSecret);
			DMNAKKMENPA.joinSecret = OCGECCCHJNA(joinSecret);
			DMNAKKMENPA.spectateSecret = HLPLFJFEMAJ(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void HANDPIKONCN()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void KHCOGCELHMA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr HLPLFJFEMAJ(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private static string IEJFLKEJAEL(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "_SampleDistance";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string KLDAKDKIFHB(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += " elements";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void LOPEAOJMAMF()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string AMNMOECLOIL(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "_Intensity";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void FEMCFCOJNFJ()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string IONEFDDBPLF(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += ",";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void IKEOHFINPJE()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct GFCFHKOENGF()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				KHCOGCELHMA();
			}
			DMNAKKMENPA.state = ECFJGEDDAIF(state);
			DMNAKKMENPA.details = OPMLDPIBBDK(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = HLCHEJHOBFJ(largeImageKey);
			DMNAKKMENPA.largeImageText = OCGECCCHJNA(largeImageText);
			DMNAKKMENPA.smallImageKey = GJCBDNCLBIF(smallImageKey);
			DMNAKKMENPA.smallImageText = ECIIHBMAHIK(smallImageText);
			DMNAKKMENPA.partyId = OPMLDPIBBDK(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = PCPGPLAAOFP(matchSecret);
			DMNAKKMENPA.joinSecret = HGHIMGONHGD(joinSecret);
			DMNAKKMENPA.spectateSecret = FCHDBBNFBPO(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct FAELFBGBOPO()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				POOBLDFJFKE();
			}
			DMNAKKMENPA.state = AGIIHKLLGMO(state);
			DMNAKKMENPA.details = BGGDNOFMPIN(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = IKOJFIBOMPL(largeImageKey);
			DMNAKKMENPA.largeImageText = IEPAGHFPEID(largeImageText);
			DMNAKKMENPA.smallImageKey = JLIFDNMCEOH(smallImageKey);
			DMNAKKMENPA.smallImageText = GNODDDNCKIE(smallImageText);
			DMNAKKMENPA.partyId = AGIIHKLLGMO(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = NFGAKIDJPDM(matchSecret);
			DMNAKKMENPA.joinSecret = NJOGBILMBEB(joinSecret);
			DMNAKKMENPA.spectateSecret = AHICFOLOPJD(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void HLCMIOMAKCF()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct IFGOBOIPBIP()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				FMFDHOIPJDA();
			}
			DMNAKKMENPA.state = LILHGANNOFA(state);
			DMNAKKMENPA.details = HLPLFJFEMAJ(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = AHICFOLOPJD(largeImageKey);
			DMNAKKMENPA.largeImageText = IJDPHENMHFA(largeImageText);
			DMNAKKMENPA.smallImageKey = NJOGBILMBEB(smallImageKey);
			DMNAKKMENPA.smallImageText = ECIIHBMAHIK(smallImageText);
			DMNAKKMENPA.partyId = HLPLFJFEMAJ(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = JLIFDNMCEOH(matchSecret);
			DMNAKKMENPA.joinSecret = FBJPOBHMDJI(joinSecret);
			DMNAKKMENPA.spectateSecret = ABAJMFLNCCI(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string HOLCJDIEEOC(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "Please specify a map name or buildID";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct JMOPEDPGPBP()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				NKKOIONHHPP();
			}
			DMNAKKMENPA.state = KOLAHGJANED(state);
			DMNAKKMENPA.details = NFGAKIDJPDM(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = FCHDBBNFBPO(largeImageKey);
			DMNAKKMENPA.largeImageText = LNCLFLFBOOI(largeImageText);
			DMNAKKMENPA.smallImageKey = DGEHKLJBGOI(smallImageKey);
			DMNAKKMENPA.smallImageText = HLPLFJFEMAJ(smallImageText);
			DMNAKKMENPA.partyId = DDOIPOAJLEB(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = AKELBIKHGIG(matchSecret);
			DMNAKKMENPA.joinSecret = AKELBIKHGIG(joinSecret);
			DMNAKKMENPA.spectateSecret = HLCHEJHOBFJ(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr AGIIHKLLGMO(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private static string NKANDPLKNGD(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "[NetworkManager] Join failed";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string BIEGPOPAMJL(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += " to ";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void MFHKICOOBAK()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string OPDFICLMAMI(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "22x1";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void DBCIDMFCPGA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct GAJJBHEEOGG()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				KHCOGCELHMA();
			}
			DMNAKKMENPA.state = KOLAHGJANED(state);
			DMNAKKMENPA.details = OCGECCCHJNA(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = NJOGBILMBEB(largeImageKey);
			DMNAKKMENPA.largeImageText = FCHDBBNFBPO(largeImageText);
			DMNAKKMENPA.smallImageKey = GNODDDNCKIE(smallImageKey);
			DMNAKKMENPA.smallImageText = EOBEHMPAHLP(smallImageText);
			DMNAKKMENPA.partyId = HBILPKAFJBA(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = PCPGPLAAOFP(matchSecret);
			DMNAKKMENPA.joinSecret = FCHDBBNFBPO(joinSecret);
			DMNAKKMENPA.spectateSecret = KBHOGNLGPOA(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct MODMGAPDAGJ()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				GCCGDLDLDII();
			}
			DMNAKKMENPA.state = OPMLDPIBBDK(state);
			DMNAKKMENPA.details = BGGDNOFMPIN(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = NJOGBILMBEB(largeImageKey);
			DMNAKKMENPA.largeImageText = ECFJGEDDAIF(largeImageText);
			DMNAKKMENPA.smallImageKey = DDOIPOAJLEB(smallImageKey);
			DMNAKKMENPA.smallImageText = FCHDBBNFBPO(smallImageText);
			DMNAKKMENPA.partyId = ECIIHBMAHIK(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = AHICFOLOPJD(matchSecret);
			DMNAKKMENPA.joinSecret = LNCLFLFBOOI(joinSecret);
			DMNAKKMENPA.spectateSecret = BAIKDHMNEGC(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void PPDCNMGBDCJ()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr EABJDGOOHKC(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr FCHDBBNFBPO(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		private IntPtr DGEHKLJBGOI(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 1; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal void GCCGDLDLDII()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct CHPAKIDKNFI()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				AFOBGDNPPMF();
			}
			DMNAKKMENPA.state = KLFAJBACGIN(state);
			DMNAKKMENPA.details = KOLAHGJANED(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = EABJDGOOHKC(largeImageKey);
			DMNAKKMENPA.largeImageText = JLIFDNMCEOH(largeImageText);
			DMNAKKMENPA.smallImageKey = EOBEHMPAHLP(smallImageKey);
			DMNAKKMENPA.smallImageText = EOBEHMPAHLP(smallImageText);
			DMNAKKMENPA.partyId = BGGDNOFMPIN(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = EOBEHMPAHLP(matchSecret);
			DMNAKKMENPA.joinSecret = ECFJGEDDAIF(joinSecret);
			DMNAKKMENPA.spectateSecret = LILHGANNOFA(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr KOLAHGJANED(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 0; i += 0)
			{
				Marshal.WriteByte(intPtr, i, 1);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private static string MNIHOAJNEKL(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "offsets";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void LNJKFFEMPAM()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal RichPresenceStruct NIBPLJNJBHJ()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				FEMCFCOJNFJ();
			}
			DMNAKKMENPA.state = HBILPKAFJBA(state);
			DMNAKKMENPA.details = IKOJFIBOMPL(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = FBJPOBHMDJI(largeImageKey);
			DMNAKKMENPA.largeImageText = OCGECCCHJNA(largeImageText);
			DMNAKKMENPA.smallImageKey = IJDPHENMHFA(smallImageKey);
			DMNAKKMENPA.smallImageText = ECPAKKOFJKC(smallImageText);
			DMNAKKMENPA.partyId = HBILPKAFJBA(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = GJCBDNCLBIF(matchSecret);
			DMNAKKMENPA.joinSecret = PCPGPLAAOFP(joinSecret);
			DMNAKKMENPA.spectateSecret = EABJDGOOHKC(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal void KMMOMEOGHGK()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr FBJPOBHMDJI(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 1; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 1, intPtr, byteCount);
			return intPtr;
		}

		internal RichPresenceStruct EOGFALEFHMJ()
		{
			if (CGNGJCKDCME.Count > 1)
			{
				AMBJODCOEDP();
			}
			DMNAKKMENPA.state = KOLAHGJANED(state);
			DMNAKKMENPA.details = GJCBDNCLBIF(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = KOLAHGJANED(largeImageKey);
			DMNAKKMENPA.largeImageText = KBHOGNLGPOA(largeImageText);
			DMNAKKMENPA.smallImageKey = AKELBIKHGIG(smallImageKey);
			DMNAKKMENPA.smallImageText = BGGDNOFMPIN(smallImageText);
			DMNAKKMENPA.partyId = GNODDDNCKIE(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = KLGOFBKGHJC(matchSecret);
			DMNAKKMENPA.joinSecret = DGEHKLJBGOI(joinSecret);
			DMNAKKMENPA.spectateSecret = EABJDGOOHKC(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private IntPtr EOBEHMPAHLP(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 1);
			for (int i = 0; i < byteCount + 1; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		private static string JOLMCEBKBJJ(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "duration";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void HIOKFIHOFLM()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private IntPtr AKELBIKHGIG(string FMFLEPJIKAI)
		{
			if (string.IsNullOrEmpty(FMFLEPJIKAI))
			{
				return IntPtr.Zero;
			}
			int byteCount = Encoding.UTF8.GetByteCount(FMFLEPJIKAI);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount + 0);
			for (int i = 0; i < byteCount + 0; i++)
			{
				Marshal.WriteByte(intPtr, i, 0);
			}
			CGNGJCKDCME.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(FMFLEPJIKAI), 0, intPtr, byteCount);
			return intPtr;
		}

		internal void MGOHCFMCMMP()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string HNHONOENFNI(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "LevelEditor/patterns";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private static string KIGLBHMEDBK(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "Drop_Far";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}
	}

	public static void GCLNKMDHKIB(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void CAGJIDDLHLD(string MJDPJLOCLIL)
	{
	}

	public static void NJHIHCGJHLL(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NLEAFLENJII();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.HAAFBGNIFNB();
	}

	public static void KDPOOFKAKHH(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
	public static extern void RunCallbacks();

	public static void NCBOEJKMACC(string MJDPJLOCLIL)
	{
	}

	public static void GPAOEPOEOLA(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void DFBGHLIIILJ(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void OOCNGBKKDBI(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void CEGIINBIHEP(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
	public static extern void Shutdown();

	public static void EJIKIGPNJCE(ref DiscordUser GILCPIJNOKK)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
	public static extern void Initialize(string JPBEMOKPPHG, ref EventHandlers DEBDALGLNCD, bool CIBECHNCFMF, string PDIMPIHMKJE);

	public static void JKCEOMANAFM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_ClearPresence")]
	public static extern void ClearPresence();

	public static void ECKLEMLMOCN(ref DiscordUser GILCPIJNOKK)
	{
	}

	[MonoPInvokeCallback(typeof(OnErrorInfo))]
	public static void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JEMHDNIKHNA(string MJDPJLOCLIL)
	{
	}

	public static void GNFKHHBDENH(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void PKHDMMGOCFL(string MJDPJLOCLIL)
	{
	}

	public static void KPGFFOPGOGE(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void HDPDIFIBEKJ(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.LPILMKAHAIG();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BECBJJGLCAB();
	}

	public static void MKCEFCFCJGO(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.MPEKFDOBLLE();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.DBCIDMFCPGA();
	}

	public static void EBMBBLHPBEL(string MJDPJLOCLIL)
	{
	}

	public static void JJGEHIFCJIH(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NLEAFLENJII();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.MFHKICOOBAK();
	}

	public static void DIGJACOLCNH(string MJDPJLOCLIL)
	{
	}

	public static void GBKBEOAGIIN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JAANBOGENDM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OBPLHLBCMMF(string MJDPJLOCLIL)
	{
	}

	public static void KIAGDDFAOMJ(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
	private static extern void AAKMLKFEDJM(ref RichPresenceStruct LBKOCHOCABF);

	public static void AFPEOLCODFK(string MJDPJLOCLIL)
	{
	}

	public static void KFFLEJKPOFJ(string MJDPJLOCLIL)
	{
	}

	public static void BFEEMNLCECO(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void BNMBAJJHFIC(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[MonoPInvokeCallback(typeof(OnSpectateInfo))]
	public static void SpectateCallback(string MJDPJLOCLIL)
	{
	}

	public static void BHKMBHJJHNE(string MJDPJLOCLIL)
	{
	}

	public static void EPHKKCLCPHD(string MJDPJLOCLIL)
	{
	}

	public static void MPOOPMPFFNF(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NIBPLJNJBHJ();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.IIHAGHJDKKN();
	}

	public static void ENHMFFFIILL(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void UpdatePresence(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FMFDHOIPJDA();
	}

	public static void MDFAICPJMAJ(string MJDPJLOCLIL)
	{
	}

	[MonoPInvokeCallback(typeof(OnDisconnectedInfo))]
	public static void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void CANHLENDJPA(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void KOJJFMHDGMO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void LOIIMDIMHFA(string MJDPJLOCLIL)
	{
	}

	public static void GLMKMJKLLPP(string MJDPJLOCLIL)
	{
	}

	public static void KJBIECMKIND(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void HKCPMJANHAP(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void KPDEFICLHJD(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.BFOKCNLNCCO();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.ECHDPKAGJJC();
	}

	public static void OOGBNGDALLG(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void CBLDKGBKABL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void IGFIHJNBJMB(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.EBJHODHJGOG();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FEMCFCOJNFJ();
	}

	[MonoPInvokeCallback(typeof(OnJoinInfo))]
	public static void JoinCallback(string MJDPJLOCLIL)
	{
	}

	public static void APPBBFFACHI(string MJDPJLOCLIL)
	{
	}

	public static void INFKGECFHDB(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void KOHMNKDJOBA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[MonoPInvokeCallback(typeof(OnReadyInfo))]
	public static void ReadyCallback(ref DiscordUser OCGEBABNLAG)
	{
	}

	[MonoPInvokeCallback(typeof(OnRequestInfo))]
	public static void RequestCallback(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void ABENDPDAOGI(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void BAMLMLCKBKM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JKMLICNLEID(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void GNDJLOJLELB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void BAIPLAPGBPN(string MJDPJLOCLIL)
	{
	}

	public static void LJCEBEKEHOO(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.CHPAKIDKNFI();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.PGHODIJDAJA();
	}

	public static void CKDOENPMHLD(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OPEOFFIKFPF(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void MLIMDCGDCNN(string MJDPJLOCLIL)
	{
	}

	public static void PGAJBFMKFCF(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NPBOCDCJBAL(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void ENAFNBLEPDA(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void NKPKLBABGDP(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.GFCFHKOENGF();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.PFMDDCBFEPF();
	}

	public static void LCHHIHEGLAA(string MJDPJLOCLIL)
	{
	}

	public static void AHMKBKFJCJA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OPAPEEBMLBK(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void LLAPHOBDKML(string MJDPJLOCLIL)
	{
	}

	public static void DNKHHMJKPNE(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void GJEIGNCKBDL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Respond")]
	public static extern void Respond(string DJACMLGPOJB, Reply GPDFCKMMIDI);

	public static void HGEBPHECINN(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void BLIDGOAFOEM(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void DLAHIFFCBCB(string MJDPJLOCLIL)
	{
	}

	public static void BAGHAAJAHDE(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void CHEIKMDKICP(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void BELCHMGLAHA(string MJDPJLOCLIL)
	{
	}

	public static void EKHFPGOJFLH(ref DiscordUser OCGEBABNLAG)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdateHandlers")]
	public static extern void UpdateHandlers(ref EventHandlers DEBDALGLNCD);

	public static void KEOJKDJCPGF(string MJDPJLOCLIL)
	{
	}

	public static void EHKAMIEPDMB(string MJDPJLOCLIL)
	{
	}

	public static void CMPIEKFPHFI(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.DOKDHMLBPPA();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.DCKAMPILMGC();
	}

	public static void AMIOJOIFLNJ(string MJDPJLOCLIL)
	{
	}

	public static void ABFOODNCGIB(string MJDPJLOCLIL)
	{
	}

	public static void HDKIHADHLHN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JNAGAEBJKIJ(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void EKPNOLOEDGL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void BMMHEHKIAIH(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JCBLBOCHHOM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void CNBBPAOPBKI(string MJDPJLOCLIL)
	{
	}

	public static void EEADDBKKEKG(string MJDPJLOCLIL)
	{
	}
}
