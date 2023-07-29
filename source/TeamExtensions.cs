// TeamExtensions
using ExitGames.Client.Photon;
using UnityEngine;

public static class TeamExtensions
{
	public static PunTeams.Team GetTeam(this PhotonPlayer JHOEDACNNKK)
	{
		object value;
		if (JHOEDACNNKK.CustomProperties.TryGetValue("team", out value))
		{
			return (PunTeams.Team)value;
		}
		return PunTeams.Team.none;
	}

	public static void SetTeam(this PhotonPlayer JHOEDACNNKK, PunTeams.Team DEIIIPLIPPF)
	{
		if (!PhotonNetwork.connectedAndReady)
		{
			Debug.LogWarning(string.Concat("JoinTeam was called in state: ", PhotonNetwork.connectionStateDetailed, ". Not connectedAndReady."));
			return;
		}
		PunTeams.Team team = JHOEDACNNKK.GetTeam();
		if (team != DEIIIPLIPPF)
		{
			JHOEDACNNKK.SetCustomProperties(new Hashtable { 
			{
				"team",
				(byte)DEIIIPLIPPF
			} });
		}
	}
}
