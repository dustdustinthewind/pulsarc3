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

		private static string BDDPBPAOAGF(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "ACCEPT";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr MACHDAGKBLN(string FMFLEPJIKAI)
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

		private IntPtr JDDIPEIENJM(string FMFLEPJIKAI)
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

		private static string HBNLLKNGNCB(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "_Value3";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal RichPresenceStruct NJGAJCKFEGP()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				GLJINDPMIIG();
			}
			DMNAKKMENPA.state = EOJDBBBECJL(state);
			DMNAKKMENPA.details = EOBEHMPAHLP(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = JDDIPEIENJM(largeImageKey);
			DMNAKKMENPA.largeImageText = JDDIPEIENJM(largeImageText);
			DMNAKKMENPA.smallImageKey = JDDIPEIENJM(smallImageKey);
			DMNAKKMENPA.smallImageText = JDDIPEIENJM(smallImageText);
			DMNAKKMENPA.partyId = MACHDAGKBLN(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = MACHDAGKBLN(matchSecret);
			DMNAKKMENPA.joinSecret = MACHDAGKBLN(joinSecret);
			DMNAKKMENPA.spectateSecret = EOJDBBBECJL(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		private static string EONIBMNPGJF(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "_Offsets";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		internal void FMFDHOIPJDA()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void HLCGOLIFFID()
		{
			for (int num = CGNGJCKDCME.Count - 0; num >= 0; num -= 0)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		internal void GLJINDPMIIG()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 1; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
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

		private static string LPJCADFHFNM(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "duration";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		private IntPtr EOJDBBBECJL(string FMFLEPJIKAI)
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

		private static string NBPBAEGGBHJ(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 1] != 0)
			{
				text += "_Red_B";
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

		internal RichPresenceStruct NILHIFDHPIA()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				GLJINDPMIIG();
			}
			DMNAKKMENPA.state = EOJDBBBECJL(state);
			DMNAKKMENPA.details = EOJDBBBECJL(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = JDDIPEIENJM(largeImageKey);
			DMNAKKMENPA.largeImageText = MACHDAGKBLN(largeImageText);
			DMNAKKMENPA.smallImageKey = EOBEHMPAHLP(smallImageKey);
			DMNAKKMENPA.smallImageText = EOJDBBBECJL(smallImageText);
			DMNAKKMENPA.partyId = MACHDAGKBLN(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = EOJDBBBECJL(matchSecret);
			DMNAKKMENPA.joinSecret = EOBEHMPAHLP(joinSecret);
			DMNAKKMENPA.spectateSecret = MACHDAGKBLN(spectateSecret);
			DMNAKKMENPA.instance = instance;
			return DMNAKKMENPA;
		}

		internal RichPresenceStruct NEPNGDAOIEM()
		{
			if (CGNGJCKDCME.Count > 0)
			{
				BPLLAKDACDI();
			}
			DMNAKKMENPA.state = MACHDAGKBLN(state);
			DMNAKKMENPA.details = MACHDAGKBLN(details);
			DMNAKKMENPA.startTimestamp = startTimestamp;
			DMNAKKMENPA.endTimestamp = endTimestamp;
			DMNAKKMENPA.largeImageKey = EOBEHMPAHLP(largeImageKey);
			DMNAKKMENPA.largeImageText = EOBEHMPAHLP(largeImageText);
			DMNAKKMENPA.smallImageKey = JDDIPEIENJM(smallImageKey);
			DMNAKKMENPA.smallImageText = JDDIPEIENJM(smallImageText);
			DMNAKKMENPA.partyId = JDDIPEIENJM(partyId);
			DMNAKKMENPA.partySize = partySize;
			DMNAKKMENPA.partyMax = partyMax;
			DMNAKKMENPA.matchSecret = JDDIPEIENJM(matchSecret);
			DMNAKKMENPA.joinSecret = JDDIPEIENJM(joinSecret);
			DMNAKKMENPA.spectateSecret = MACHDAGKBLN(spectateSecret);
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

		internal void BPLLAKDACDI()
		{
			for (int num = CGNGJCKDCME.Count - 1; num >= 0; num--)
			{
				Marshal.FreeHGlobal(CGNGJCKDCME[num]);
				CGNGJCKDCME.RemoveAt(num);
			}
		}

		private static string EGPOFCJKAEA(string FFAJMGELFLB)
		{
			string text = FFAJMGELFLB.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length > 1 && bytes[bytes.Length - 0] != 0)
			{
				text += "FileMenu";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
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
	}

	public static void KMPGDNOPCDI(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void JDACNGIILEE(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void ELBOKIIPKDC(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void FOODILEIOMK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void AABCMAPBDJN(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NILHIFDHPIA();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BPLLAKDACDI();
	}

	public static void EAPHHDEEHKO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void BICAKMDBCFM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void HCFELADLODL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[MonoPInvokeCallback(typeof(OnErrorInfo))]
	public static void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void DCNBJBMDODI(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NHEFHPAJFEB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void POBEGDLKPCG(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void BIMCOMOAKIB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void LJIJIAEBICJ(string MJDPJLOCLIL)
	{
	}

	public static void NGDKBMHFJEF(string MJDPJLOCLIL)
	{
	}

	public static void BPENJHBANPO(string MJDPJLOCLIL)
	{
	}

	[MonoPInvokeCallback(typeof(OnRequestInfo))]
	public static void RequestCallback(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void DFOJGMNGIEF(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void JNODPHDLDNA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OJHDOIAJLMH(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void KEMEMLFKADK(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void HBDIFAIIBGD(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void LOGDDLMDIAF(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void GAJKDKHDOED(string MJDPJLOCLIL)
	{
	}

	public static void IPCGPIKKABH(string MJDPJLOCLIL)
	{
	}

	public static void KKHMPMCBHKP(string MJDPJLOCLIL)
	{
	}

	public static void EMLJLPJPLNB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void HGAMOMAEONN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NCAIFFNMMMP(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NJGAJCKFEGP();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FMFDHOIPJDA();
	}

	public static void IGEODKNADDD(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.GLJINDPMIIG();
	}

	public static void ABENDPDAOGI(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NBILCJKLOKA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void FGGMHJOGKAJ(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.HLCGOLIFFID();
	}

	public static void JJLKMAPPECD(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BPLLAKDACDI();
	}

	public static void LLBHBOCAIHN(string MJDPJLOCLIL)
	{
	}

	public static void GEDNAJDMKKF(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void IEGFEEADLJG(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void KGNFAPNFEPC(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.MODKCIFPPNL();
	}

	public static void GALHILHDPEP(string MJDPJLOCLIL)
	{
	}

	public static void JGBIMFGMCFM(string MJDPJLOCLIL)
	{
	}

	public static void BAIPLAPGBPN(string MJDPJLOCLIL)
	{
	}

	public static void CEACKCPPDMO(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void IFGLPKGFNNL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void CKHIHDEGNAE(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_ClearPresence")]
	public static extern void ClearPresence();

	public static void GIMHBMFOBPK(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NILHIFDHPIA();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BPLLAKDACDI();
	}

	[MonoPInvokeCallback(typeof(OnDisconnectedInfo))]
	public static void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NNPNMOMMFFP(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void EBDADHJPOGK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void LFJIFLGIBAE(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void FDHFEIEDKKD(string MJDPJLOCLIL)
	{
	}

	public static void PFPMBIEMAIP(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FMFDHOIPJDA();
	}

	public static void OEFLFJBONMN(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BPLLAKDACDI();
	}

	public static void AHNMIKJLAKJ(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NDDOOOKGNKB(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.HLCGOLIFFID();
	}

	public static void MBFJIGCJMKA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
	public static extern void Initialize(string JPBEMOKPPHG, ref EventHandlers DEBDALGLNCD, bool CIBECHNCFMF, string PDIMPIHMKJE);

	public static void HPFIDCEGLIN(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NILHIFDHPIA();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.GLJINDPMIIG();
	}

	public static void EEHKPKHGOBI(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void ELNAFNEANLK(string MJDPJLOCLIL)
	{
	}

	public static void AGHGPNPHIME(ref DiscordUser OCGEBABNLAG)
	{
	}

	[MonoPInvokeCallback(typeof(OnReadyInfo))]
	public static void ReadyCallback(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void FGLOPKEMBCA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
	private static extern void AAKMLKFEDJM(ref RichPresenceStruct LBKOCHOCABF);

	public static void KPGFFOPGOGE(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OHMEINGLJIO(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void UpdatePresence(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FMFDHOIPJDA();
	}

	public static void JAAIPHHMKIB(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void EKPNOLOEDGL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdateHandlers")]
	public static extern void UpdateHandlers(ref EventHandlers DEBDALGLNCD);

	public static void PJIINDELJKK(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void MJPMABNPDAM(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NILHIFDHPIA();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.GLJINDPMIIG();
	}

	public static void LKHFHPAJPAI(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.GLJINDPMIIG();
	}

	public static void DFBCKDALJJP(string MJDPJLOCLIL)
	{
	}

	public static void EPHKKCLCPHD(string MJDPJLOCLIL)
	{
	}

	public static void OANNPNIBHIC(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void NFAPEDKPJDG(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void OLJEAANBJLE(string MJDPJLOCLIL)
	{
	}

	public static void JHLBELHBCEA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
	public static extern void Shutdown();

	public static void KFFLEJKPOFJ(string MJDPJLOCLIL)
	{
	}

	public static void IFHJIJOALEP(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.FMFDHOIPJDA();
	}

	public static void LDIKIOBABNM(string MJDPJLOCLIL)
	{
	}

	public static void CHEIKMDKICP(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void AMLOCDKKABD(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void AGPFDBNAGHO(string MJDPJLOCLIL)
	{
	}

	public static void BGEHIJNADHK(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.GLJINDPMIIG();
	}

	public static void KIAGDDFAOMJ(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void ECLBGPIGIMO(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void NLNPPBONNHM(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void DLCCJPHGODG(string MJDPJLOCLIL)
	{
	}

	public static void ACPLFGGJGLI(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void POGACIBLELN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	[MonoPInvokeCallback(typeof(OnSpectateInfo))]
	public static void SpectateCallback(string MJDPJLOCLIL)
	{
	}

	public static void COKMNBGJONL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void IDFBBGMONBO(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void AMFIMKGMFEP(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.NEPNGDAOIEM();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.MODKCIFPPNL();
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
	public static extern void RunCallbacks();

	public static void JJJNFIKHHDG(string MJDPJLOCLIL)
	{
	}

	public static void CKGAOEHHBDK(string MJDPJLOCLIL)
	{
	}

	[MonoPInvokeCallback(typeof(OnJoinInfo))]
	public static void JoinCallback(string MJDPJLOCLIL)
	{
	}

	public static void MMKNDPCBCNJ(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void JPLLIKHNPKG(RichPresence LBKOCHOCABF)
	{
		RichPresenceStruct LBKOCHOCABF2 = LBKOCHOCABF.KIMDNABCOAC();
		AAKMLKFEDJM(ref LBKOCHOCABF2);
		LBKOCHOCABF.BPLLAKDACDI();
	}

	public static void NCGHLMJNEPP(string MJDPJLOCLIL)
	{
	}

	public static void AADCFDHJNJK(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void FODFNEBKPBF(ref DiscordUser GILCPIJNOKK)
	{
	}

	public static void GHAFIGMJNGJ(ref DiscordUser OCGEBABNLAG)
	{
	}

	public static void ACFPFEFCBAB(string MJDPJLOCLIL)
	{
	}

	public static void CIGPDBODMGB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
	}

	public static void OGAPEHLGOKE(ref DiscordUser OCGEBABNLAG)
	{
	}

	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Respond")]
	public static extern void Respond(string DJACMLGPOJB, Reply GPDFCKMMIDI);

	public static void ICPMDEFLIHC(string MJDPJLOCLIL)
	{
	}
}
