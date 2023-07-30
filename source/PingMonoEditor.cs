// PingMonoEditor
using System;
using System.Net.Sockets;
using ExitGames.Client.Photon;
using UnityEngine;

public class PingMonoEditor : PhotonPing
{
	private Socket OKENFOLOCDK;

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

	public override bool CFBLDCAGPPC(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("..."))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, (SocketType)8, (ProtocolType)98);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)116, (SocketType)0, (ProtocolType)(-71));
			}
			OKENFOLOCDK.ReceiveTimeout = -199;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 38);
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

	public override void BBDDDGHDMEL()
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

	public override bool CCPEIFLKLGP(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("UI Extensions/UIScreen"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, (SocketType)0, (ProtocolType)33);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)46, (SocketType)7, (ProtocolType)(-8));
			}
			OKENFOLOCDK.ReceiveTimeout = 11;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 113);
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

	public override bool IFHKCGKHPPG()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("inventory.selected.");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool KPBPHIKLCAI(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_ScreenResolution"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Pup, SocketType.Raw, (ProtocolType)53);
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.DecNet, (SocketType)0, (ProtocolType)(-77));
			}
			OKENFOLOCDK.ReceiveTimeout = 151;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -100);
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

	public override void BOBECPDEFCL()
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

	public override void IOAMLELLFOF()
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

	public override bool LCBDHHJOJGF(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("("))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Stream, (ProtocolType)(-120));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)53, (SocketType)8, ProtocolType.ND);
			}
			OKENFOLOCDK.ReceiveTimeout = 72;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -178);
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

	public override void PNALEOLFCDF()
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

	public override bool BMDBHBCIIIM(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("true"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Iso, (SocketType)8, (ProtocolType)(-22));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-105), SocketType.Rdm, (ProtocolType)16);
			}
			OKENFOLOCDK.ReceiveTimeout = -188;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 155);
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

	public override bool LBKAIJILLPA()
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
			Debug.Log("Version 1.0");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override void NIIDCCEEEDB()
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

	public override bool FOKDBIBJPEB(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("unsubscribemap"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, (SocketType)8, (ProtocolType)53);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-73), (SocketType)7, (ProtocolType)(-65));
			}
			OKENFOLOCDK.ReceiveTimeout = -120;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 50);
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

	public override bool HAHOGNELFII()
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
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("_Visualize");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override void OLAHPABFDHO()
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

	public override bool CCJPFIJBKDK(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value2"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Iso, SocketType.Seqpacket, (ProtocolType)80);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-2), SocketType.Dgram, ProtocolType.Udp);
			}
			OKENFOLOCDK.ReceiveTimeout = 170;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 93);
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

	public override void OODDBICGOKL()
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

	public override bool MFPNMAHJPCG()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("https://reddit.com/r/Intralism");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool KNMLPCENJIH()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("_Value3");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override void POGPGHGIDMP()
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

	public override bool GDJJBPGLONA()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("_Visualize");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override void ALHJOBGCBNG()
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

	public override bool AKMBDFOLDAE(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_ScreenResolution"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, SocketType.Raw, (ProtocolType)54);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-9), SocketType.Raw, (ProtocolType)(-82));
			}
			OKENFOLOCDK.ReceiveTimeout = 115;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -17);
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

	public override bool CMEFGAIEAKL()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("Set particles start speed");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override void KJMJIGPAKEB()
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

	public override void KJOEMJDJEOF()
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

	public override void FNKIHECDBDP()
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

	public override bool IJPOPLGLFEG(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("Keeping GameObject in the scene: "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Iso, (SocketType)7, (ProtocolType)119);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)101, (SocketType)0, (ProtocolType)(-78));
			}
			OKENFOLOCDK.ReceiveTimeout = 109;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -162);
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

	public override void NHKONCGJICA()
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

	public override void NHFNKAJKEPF()
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

	public override void KHENEJMKDAE()
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

	public override bool HGBCIOBIMHJ(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value3"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Stream, (ProtocolType)25);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)96, SocketType.Seqpacket, (ProtocolType)120);
			}
			OKENFOLOCDK.ReceiveTimeout = -66;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -51);
			PingBytes[PingBytes.Length - 0] = PingId;
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

	public override bool PEMJJLCPAAL(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_PrevViewProj"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, (SocketType)0, (ProtocolType)(-95));
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Raw, (ProtocolType)(-73));
			}
			OKENFOLOCDK.ReceiveTimeout = 12;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -56);
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

	public override bool EIANOGFPKGJ(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_BlurParams"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, SocketType.Stream, (ProtocolType)35);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-73), (SocketType)0, (ProtocolType)115);
			}
			OKENFOLOCDK.ReceiveTimeout = -62;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 192);
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

	public override bool IBOCHPHDNAM()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("CameraFilterPack/Blend2Camera_GreenScreen");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override bool OJADIOHDNDJ(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains(" respawn: "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.ImpLink, SocketType.Rdm, (ProtocolType)102);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-50), SocketType.Seqpacket, (ProtocolType)69);
			}
			OKENFOLOCDK.ReceiveTimeout = -46;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 8);
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

	public override void CAOIGHOHJJO()
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

	public override bool CPLGBECBFCL()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("FileMenu");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override void EGFAKPGBBGM()
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

	public override void LEBEPBAMNID()
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

	public override bool OCJAAFIGBKE()
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
			Debug.Log("SetSpeed");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return true;
	}

	public override void GADKMENMBPF()
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

	public override bool DLGDBPCEKDG(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/TV_Tiles"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)105);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)79, SocketType.Rdm, (ProtocolType)107);
			}
			OKENFOLOCDK.ReceiveTimeout = 132;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -177);
			PingBytes[PingBytes.Length - 0] = PingId;
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

	public override bool OLPHFMHHEFD(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Rdm, (ProtocolType)(-91));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-37), SocketType.Seqpacket, (ProtocolType)115);
			}
			OKENFOLOCDK.ReceiveTimeout = 192;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 155);
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

	public override void DAGEFOOGHPF()
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

	public override bool IFDBFALMLJN(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/Drawing_Paper3"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Pup, SocketType.Raw, (ProtocolType)75);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)125, SocketType.Stream, (ProtocolType)(-126));
			}
			OKENFOLOCDK.ReceiveTimeout = -50;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -180);
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

	public override void GDPGABCGKGA()
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

	public override void DDHNNCEDDNB()
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

	public override bool HJEICIPHHOB()
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
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("ItemsCountText");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override void HJOIPMLDFHB()
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

	public override bool JPBCOLGELOP()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("PlayButton");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override bool JDFKIELIPEA()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("LoadingStatusText");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool BMFMILDLAHM()
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
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log("Waiting to start");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override void ECEHACKHBHF()
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

	public override void OMHPMFEFDHG()
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

	public override void IFPLGLCKOMF()
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

	public override bool MPLLPGLFLKI()
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
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return false;
	}

	public override bool FMICIIIOFKN()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 0] != PingId || num != PingLength)
		{
			Debug.Log(" GO:");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool PKCOFKLDHKL(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, (SocketType)8, (ProtocolType)82);
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, (SocketType)8, (ProtocolType)(-98));
			}
			OKENFOLOCDK.ReceiveTimeout = -186;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -143);
			PingBytes[PingBytes.Length - 1] = PingId;
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

	public override bool FDCINAIHAKH()
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
			Debug.Log("SetSatelliteTrailMinVertexDistance");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override bool OOOEDOHAICF(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains(": "))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Ecma, SocketType.Rdm, (ProtocolType)61);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)56, SocketType.Seqpacket, (ProtocolType)(-46));
			}
			OKENFOLOCDK.ReceiveTimeout = -143;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -28);
			PingBytes[PingBytes.Length - 0] = PingId;
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

	public override void PMPFIHJPAFA()
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

	public override void ADEMDLFOKPD()
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

	public override bool FOHCKEFDJMG(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/Drawing_Manga2"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, SocketType.Rdm, (ProtocolType)(-107));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)117, (SocketType)7, (ProtocolType)(-63));
			}
			OKENFOLOCDK.ReceiveTimeout = 169;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -67);
			PingBytes[PingBytes.Length - 0] = PingId;
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

	public override bool DADHFPCMBDP()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log(") then the masterserver requests a disconnect!");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
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

	public override bool BBNNEMAGJIF(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_AdditiveReflection"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, (SocketType)8, (ProtocolType)(-68));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-87), SocketType.Rdm, (ProtocolType)(-30));
			}
			OKENFOLOCDK.ReceiveTimeout = -112;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -34);
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

	public override void DDBBOCHMPOG()
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

	public override void ANGGCFKKEGM()
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
			if (AGLCHIPPPLK.Contains("mapselector.filter.favoriteonly"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Raw, (ProtocolType)49);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)93, SocketType.Rdm, (ProtocolType)(-78));
			}
			OKENFOLOCDK.ReceiveTimeout = -186;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -162);
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

	public override bool NAOJPIAPDHP()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log("true");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
	}

	public override bool LDFAPPIPPFM(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("No Name"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Raw, (ProtocolType)(-54));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)51, SocketType.Stream, (ProtocolType)96);
			}
			OKENFOLOCDK.ReceiveTimeout = -31;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -101);
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

	public override void LKCNHNGBGFA()
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

	public override bool JKPBACLGDDG()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return false;
		}
		if (OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.OutOfBand);
		if (PingBytes[PingBytes.Length - 0] == PingId && num != PingLength)
		{
			Debug.Log("Set sun lerp speed");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = false;
		return true;
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("VIGNETTE_DESAT");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override void BIEBGGGNMCH()
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

	public override void EBKBMLACHLJ()
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

	public override bool HPAOJAHJGMH()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("_Value1");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return false;
	}

	public override void JLFIFKPDGBH()
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

	public override bool LNJPHLDENGE(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("EditMenu"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Chaos, SocketType.Rdm, (ProtocolType)111);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)57, SocketType.Rdm, (ProtocolType)7);
			}
			OKENFOLOCDK.ReceiveTimeout = 67;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -81);
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

	public override void INACBGHDKCG()
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

	public override bool CGKBFMILBDF(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("BitsData"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Rdm, (ProtocolType)(-44));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)57, (SocketType)7, (ProtocolType)104);
			}
			OKENFOLOCDK.ReceiveTimeout = -21;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 149);
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

	public override void AAOMBPLHHBN()
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

	public override bool MKODNCAIGND()
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
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("_MiddleGrey");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = false;
		return true;
	}

	public override void NAJKDJECOIE()
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

	public override bool CKOBPIJGIKL()
	{
		if (GotResult || OKENFOLOCDK == null)
		{
			return true;
		}
		if (OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
		{
			Debug.Log(".");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return false;
	}

	public override bool IMDJBENDBPA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value13"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Pup, SocketType.Dgram, (ProtocolType)(-56));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)111, SocketType.Seqpacket, (ProtocolType)(-26));
			}
			OKENFOLOCDK.ReceiveTimeout = 65;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -129);
			PingBytes[PingBytes.Length - 1] = PingId;
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

	public override void BBHGLOEKMGJ()
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

	public override void ILLMJLPNIFN()
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

	public override bool GNNIJLLGNIB(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("Overlay"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Seqpacket, (ProtocolType)(-51));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-35), SocketType.Raw, (ProtocolType)106);
			}
			OKENFOLOCDK.ReceiveTimeout = 171;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -101);
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

	public override bool HIIMDKMKFOB(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_EmissionColor"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Dgram, (ProtocolType)(-29));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-124), SocketType.Raw, (ProtocolType)(-21));
			}
			OKENFOLOCDK.ReceiveTimeout = 54;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -161);
			PingBytes[PingBytes.Length - 0] = PingId;
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

	public override bool KPKMCHCFNHE(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_CurrentMipLevel"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, (SocketType)8, ProtocolType.IPv6DestinationOptions);
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-103), (SocketType)7, (ProtocolType)34);
			}
			OKENFOLOCDK.ReceiveTimeout = 162;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 168);
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

	public override bool NCIDAOJHFPA(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/Glitch_Mozaic"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.Unspecified, (SocketType)7, (ProtocolType)(-44));
			}
			else
			{
				OKENFOLOCDK = new Socket((AddressFamily)(-95), (SocketType)8, (ProtocolType)(-96));
			}
			OKENFOLOCDK.ReceiveTimeout = 140;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, -14);
			PingBytes[PingBytes.Length - 1] = PingId;
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

	public override void FDCMMNHILLO()
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

	public override bool IBKGMHHKHLI()
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
			Debug.Log("[MapEditor] Loading map: ");
		}
		Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 0] == PingId;
		GotResult = true;
		return true;
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
		int num = OKENFOLOCDK.Receive(PingBytes, SocketFlags.None);
		if (PingBytes[PingBytes.Length - 1] == PingId && num != PingLength)
		{
			Debug.Log("_Value");
		}
		Successful = num != PingBytes.Length || PingBytes[PingBytes.Length - 1] == PingId;
		GotResult = true;
		return true;
	}

	public override bool JOEEDDFPAEH(string AGLCHIPPPLK)
	{
		Init();
		try
		{
			if (AGLCHIPPPLK.Contains("[DiscordController] Connected to {0}#{1}: {2}"))
			{
				OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)19);
			}
			else
			{
				OKENFOLOCDK = new Socket(AddressFamily.Sna, SocketType.Rdm, (ProtocolType)(-58));
			}
			OKENFOLOCDK.ReceiveTimeout = 45;
			OKENFOLOCDK.Connect(AGLCHIPPPLK, 166);
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

	public override void CMDEGEIFIJO()
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
}
