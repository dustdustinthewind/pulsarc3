// GOLJCGMCKMG
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

internal static class GOLJCGMCKMG
{
	public static readonly byte[] memVector3 = new byte[12];

	public static readonly byte[] memVector2 = new byte[8];

	public static readonly byte[] memQuarternion = new byte[16];

	public static readonly byte[] memPlayer = new byte[4];

	[CompilerGenerated]
	private static SerializeStreamMethod BOGJGOAMCHK;

	[CompilerGenerated]
	private static DeserializeStreamMethod BDPNFNJNEFM;

	[CompilerGenerated]
	private static SerializeStreamMethod MJKNAFJKDMG;

	[CompilerGenerated]
	private static DeserializeStreamMethod JENGHDFDLII;

	[CompilerGenerated]
	private static SerializeStreamMethod BMJHMBNEACI;

	[CompilerGenerated]
	private static DeserializeStreamMethod EPENHHMDDMB;

	[CompilerGenerated]
	private static SerializeStreamMethod DNLDPCIINIC;

	[CompilerGenerated]
	private static DeserializeStreamMethod ILAKDECCIME;

	internal static void FJPBNMBIOHG()
	{
		PhotonPeer.RegisterType(typeof(Vector2), 87, LCNMHEMBEFI, HANJLNGFAKP);
		PhotonPeer.RegisterType(typeof(Vector3), 86, ANBBLBLNDBH, BFLLDNIBMHP);
		PhotonPeer.RegisterType(typeof(Quaternion), 81, PKPCNJJBOJB, BNPJAGNEBPN);
		PhotonPeer.RegisterType(typeof(PhotonPlayer), 80, AJKFOONFMDK, AEKFJLLFGFB);
	}

	private static short ANBBLBLNDBH(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector3 vector = (Vector3)CCKPKLEKCFF;
		int targetOffset = 0;
		lock (memVector3)
		{
			byte[] array = memVector3;
			Protocol.Serialize(vector.x, array, ref targetOffset);
			Protocol.Serialize(vector.y, array, ref targetOffset);
			Protocol.Serialize(vector.z, array, ref targetOffset);
			GBJIGMOJIDF.Write(array, 0, 12);
		}
		return 12;
	}

	private static object BFLLDNIBMHP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector3 vector = default(Vector3);
		lock (memVector3)
		{
			OHAAEIEHLMD.Read(memVector3, 0, 12);
			int offset = 0;
			Protocol.Deserialize(out vector.x, memVector3, ref offset);
			Protocol.Deserialize(out vector.y, memVector3, ref offset);
			Protocol.Deserialize(out vector.z, memVector3, ref offset);
		}
		return vector;
	}

	private static short LCNMHEMBEFI(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector2 vector = (Vector2)CCKPKLEKCFF;
		lock (memVector2)
		{
			byte[] array = memVector2;
			int targetOffset = 0;
			Protocol.Serialize(vector.x, array, ref targetOffset);
			Protocol.Serialize(vector.y, array, ref targetOffset);
			GBJIGMOJIDF.Write(array, 0, 8);
		}
		return 8;
	}

	private static object HANJLNGFAKP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector2 vector = default(Vector2);
		lock (memVector2)
		{
			OHAAEIEHLMD.Read(memVector2, 0, 8);
			int offset = 0;
			Protocol.Deserialize(out vector.x, memVector2, ref offset);
			Protocol.Deserialize(out vector.y, memVector2, ref offset);
		}
		return vector;
	}

	private static short PKPCNJJBOJB(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Quaternion quaternion = (Quaternion)CCKPKLEKCFF;
		lock (memQuarternion)
		{
			byte[] array = memQuarternion;
			int targetOffset = 0;
			Protocol.Serialize(quaternion.w, array, ref targetOffset);
			Protocol.Serialize(quaternion.x, array, ref targetOffset);
			Protocol.Serialize(quaternion.y, array, ref targetOffset);
			Protocol.Serialize(quaternion.z, array, ref targetOffset);
			GBJIGMOJIDF.Write(array, 0, 16);
		}
		return 16;
	}

	private static object BNPJAGNEBPN(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Quaternion quaternion = default(Quaternion);
		lock (memQuarternion)
		{
			OHAAEIEHLMD.Read(memQuarternion, 0, 16);
			int offset = 0;
			Protocol.Deserialize(out quaternion.w, memQuarternion, ref offset);
			Protocol.Deserialize(out quaternion.x, memQuarternion, ref offset);
			Protocol.Deserialize(out quaternion.y, memQuarternion, ref offset);
			Protocol.Deserialize(out quaternion.z, memQuarternion, ref offset);
		}
		return quaternion;
	}

	private static short AJKFOONFMDK(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		int iD = ((PhotonPlayer)CCKPKLEKCFF).ID;
		lock (memPlayer)
		{
			byte[] array = memPlayer;
			int targetOffset = 0;
			Protocol.Serialize(iD, array, ref targetOffset);
			GBJIGMOJIDF.Write(array, 0, 4);
			return 4;
		}
	}

	private static object AEKFJLLFGFB(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		int value;
		lock (memPlayer)
		{
			OHAAEIEHLMD.Read(memPlayer, 0, NIEADDJOIEG);
			int offset = 0;
			Protocol.Deserialize(out value, memPlayer, ref offset);
		}
		if (PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(value))
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors[value];
		}
		return null;
	}
}
