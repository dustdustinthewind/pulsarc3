// TurnExtensions
using ExitGames.Client.Photon;

public static class TurnExtensions
{
	public static readonly string TurnPropKey = "Turn";

	public static readonly string TurnStartPropKey = "TStart";

	public static readonly string FinishedTurnPropKey = "FToA";

	public static void SetTurn(this Room COLEOPNODBP, int JPFFPMDKAMC, bool LHOKCIBALFF = false)
	{
		if (COLEOPNODBP != null && COLEOPNODBP.CustomProperties != null)
		{
			Hashtable hashtable = new Hashtable();
			hashtable[TurnPropKey] = JPFFPMDKAMC;
			if (LHOKCIBALFF)
			{
				hashtable[TurnStartPropKey] = PhotonNetwork.ServerTimestamp;
			}
			COLEOPNODBP.SetCustomProperties(hashtable);
		}
	}

	public static int GetTurn(this RoomInfo COLEOPNODBP)
	{
		if (COLEOPNODBP == null || COLEOPNODBP.CustomProperties == null || !COLEOPNODBP.CustomProperties.ContainsKey(TurnPropKey))
		{
			return 0;
		}
		return (int)COLEOPNODBP.CustomProperties[TurnPropKey];
	}

	public static int GetTurnStart(this RoomInfo COLEOPNODBP)
	{
		if (COLEOPNODBP == null || COLEOPNODBP.CustomProperties == null || !COLEOPNODBP.CustomProperties.ContainsKey(TurnStartPropKey))
		{
			return 0;
		}
		return (int)COLEOPNODBP.CustomProperties[TurnStartPropKey];
	}

	public static int GetFinishedTurn(this PhotonPlayer JHOEDACNNKK)
	{
		Room room = PhotonNetwork.room;
		if (room == null || room.CustomProperties == null || !room.CustomProperties.ContainsKey(TurnPropKey))
		{
			return 0;
		}
		string key = FinishedTurnPropKey + JHOEDACNNKK.ID;
		return (int)room.CustomProperties[key];
	}

	public static void SetFinishedTurn(this PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC)
	{
		Room room = PhotonNetwork.room;
		if (room != null && room.CustomProperties != null)
		{
			string key = FinishedTurnPropKey + JHOEDACNNKK.ID;
			Hashtable hashtable = new Hashtable();
			hashtable[key] = JPFFPMDKAMC;
			room.SetCustomProperties(hashtable);
		}
	}
}
