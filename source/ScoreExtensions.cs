// ScoreExtensions
using ExitGames.Client.Photon;

public static class ScoreExtensions
{
	public static void SetScore(this PhotonPlayer JHOEDACNNKK, int PNOFOOIOBLC)
	{
		Hashtable hashtable = new Hashtable();
		hashtable["score"] = PNOFOOIOBLC;
		JHOEDACNNKK.SetCustomProperties(hashtable);
	}

	public static void AddScore(this PhotonPlayer JHOEDACNNKK, int GBOEHKKHOEB)
	{
		int score = JHOEDACNNKK.GetScore();
		score += GBOEHKKHOEB;
		Hashtable hashtable = new Hashtable();
		hashtable["score"] = score;
		JHOEDACNNKK.SetCustomProperties(hashtable);
	}

	public static int GetScore(this PhotonPlayer JHOEDACNNKK)
	{
		object value;
		if (JHOEDACNNKK.CustomProperties.TryGetValue("score", out value))
		{
			return (int)value;
		}
		return 0;
	}
}
