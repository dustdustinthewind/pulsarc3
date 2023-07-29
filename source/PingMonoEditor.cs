// PingMonoEditor
using System;
using System.Net.Sockets;
using ExitGames.Client.Photon;
using UnityEngine;

public class PingMonoEditor : PhotonPing
{
	private Socket OKENFOLOCDK;

	public override bool NHBGKNMCCNH(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("SetSunEmission"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, (SocketType)6, (ProtocolType)(-88));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-124), (SocketType)7, (ProtocolType)103);
			}
			OKENFOLOCDK.ReceiveTimeout = 173;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override bool EFGHDEFBJAM(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("colorC"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, SocketType.Dgram, (ProtocolType)(-108));
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.Cluster, SocketType.Raw, (ProtocolType)(-93));
			}
			OKENFOLOCDK.ReceiveTimeout = -100;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override void BKFJJKFBIEH()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override void LGIHDEFPKOL()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool StartPing(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("."))
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
			}
			OKENFOLOCDK.ReceiveTimeout = 5000;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 5055);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override void OJNIBAHCIPL()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool LHACEJINMOM(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("/"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, (SocketType)8, (ProtocolType)93);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-18), SocketType.Rdm, (ProtocolType)120);
			}
			OKENFOLOCDK.ReceiveTimeout = 128;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 121);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override void OPMANHCADGI()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool KBKADHBBHEA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("0,7,true,0"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Stream, (ProtocolType)(-98));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-46), SocketType.Stream, (ProtocolType)78);
			}
			OKENFOLOCDK.ReceiveTimeout = 181;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 161);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override bool HJCNPAOOFMM()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("_SampleCount");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return true;
	}

	public override bool GKKEMJKBPOC()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("SAVE");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool BGHEBOPALJI()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log(",0");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return false;
	}

	public override bool BCCLCMIKHKL()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("Object ID. Case-Sensitive");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return false;
	}

	public override bool LLMLAMNJPAG()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("PUNCloudBestRegion");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return true;
	}

	public override bool ADFFKHNEMPC(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("file://"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Rdm, (ProtocolType)(-46));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)120, SocketType.Stream, (ProtocolType)(-6));
			}
			OKENFOLOCDK.ReceiveTimeout = 24;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 70);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override bool CCKJBIKKKJN()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("_Value3");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override bool COECLOLIPJM()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("CameraFilterPack/TV_Old");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override void CHNHCMHIBBJ()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool KDDGJFKAELH()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("_ScreenResolution");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override bool FDCINAIHAKH()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("No Dispatcher exists in the scene. Actions will not be invoked!");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return false;
	}

	public override bool DGHHFLMGHDA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Far"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Seqpacket, (ProtocolType)(-63));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)34, (SocketType)6, (ProtocolType)100);
			}
			OKENFOLOCDK.ReceiveTimeout = -57;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -178);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool HHDJFHGIANE()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("st");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return false;
	}

	public override bool IKKEEOMMNMA()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("null");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override bool ALAPHBGLJCE()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("#rt");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return true;
	}

	public override bool BFGPMHLPGMF(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains(":</b> "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, SocketType.Rdm, (ProtocolType)53);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)72, SocketType.Stream, (ProtocolType)(-20));
			}
			OKENFOLOCDK.ReceiveTimeout = -14;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 72);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool IMDJBENDBPA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/TV_CompressionFX"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, SocketType.Raw, (ProtocolType)76);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-34), SocketType.Rdm, (ProtocolType)(-68));
			}
			OKENFOLOCDK.ReceiveTimeout = 110;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 129);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override bool EIANOGFPKGJ(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_ColorLevel"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, SocketType.Raw, (ProtocolType)45);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-33), SocketType.Stream, (ProtocolType)(-120));
			}
			OKENFOLOCDK.ReceiveTimeout = -192;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -42);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool KCHODDMGJME(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains(": "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Stream, (ProtocolType)(-84));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-32), (SocketType)7, (ProtocolType)(-95));
			}
			OKENFOLOCDK.ReceiveTimeout = -80;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -178);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool BEFCMFBJFLG()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("] to be droppable");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool ICKELLNDHLK()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("HightScoreMaxPointsText");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override bool DCIBHPKMHNI()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log(" GameServer:");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override void EFGEKIBICJE()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override void BLIJEFNDGIF()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool LAIFEDKNPKB(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("replayData"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, (SocketType)8, (ProtocolType)(-101));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)33, (SocketType)0, (ProtocolType)(-69));
			}
			OKENFOLOCDK.ReceiveTimeout = 64;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override bool MFPNMAHJPCG()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("tagElement");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override bool PKCOFKLDHKL(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("#mapnotloaded"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Seqpacket, (ProtocolType)(-59));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-97), SocketType.Seqpacket, (ProtocolType)8);
			}
			OKENFOLOCDK.ReceiveTimeout = 81;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 131);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool BECFOOGCCDI(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("UNDISTORT"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, (SocketType)8, (ProtocolType)46);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-48), SocketType.Stream, (ProtocolType)(-20));
			}
			OKENFOLOCDK.ReceiveTimeout = -94;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -172);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	public override void EIHFHDNBJFD()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool OJADIOHDNDJ(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("#availablechallenges"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Iso, SocketType.Dgram, (ProtocolType)(-6));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)43, (SocketType)6, (ProtocolType)(-56));
			}
			OKENFOLOCDK.ReceiveTimeout = -144;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -189);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override void GFJMMACHGKP()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool BMMNIJIBFCA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("music"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Dgram, (ProtocolType)(-83));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-72), (SocketType)0, (ProtocolType)(-70));
			}
			OKENFOLOCDK.ReceiveTimeout = -173;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 187);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool ENNNAKBIHBD()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("Horizontal");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return false;
	}

	public override bool LFKOENNONPA()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log(":");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override bool EGDDNGGCHND(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_TimeX"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, (SocketType)8, (ProtocolType)82);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-82), SocketType.Raw, (ProtocolType)(-15));
			}
			OKENFOLOCDK.ReceiveTimeout = 154;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -98);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool OINIKOAGPNH(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_VignetteSettings"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Dgram, (ProtocolType)54);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)47, SocketType.Dgram, (ProtocolType)(-75));
			}
			OKENFOLOCDK.ReceiveTimeout = -49;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 159);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool JOEEDDFPAEH(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value5"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Stream, (ProtocolType)(-122));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)125, (SocketType)0, (ProtocolType)(-107));
			}
			OKENFOLOCDK.ReceiveTimeout = 180;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -81);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override void Dispose()
	{
		try
		{
			OKENFOLOCDK.Close();
		}
		catch
		{
		}
		OKENFOLOCDK = null;
	}

	public override bool NPLLJOIMBMP(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("ServerSettings: "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)(-76));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-44), SocketType.Dgram, (ProtocolType)102);
			}
			OKENFOLOCDK.ReceiveTimeout = 135;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 117);
			PingBytes[PingBytes.Length - 0] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	public override bool Done()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("ReplyMatch is false! ");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool BHHHABFEHOB(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value4"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)(-33));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)104, (SocketType)8, (ProtocolType)116);
			}
			OKENFOLOCDK.ReceiveTimeout = 6;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 60);
			PingBytes[PingBytes.Length - 1] = PingId;
			OKENFOLOCDK.Send(PingBytes);
			PingBytes[PingBytes.Length - 0] = (byte)(PingId - 0);
		}
		catch (Exception value)
		{
			OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}
}
