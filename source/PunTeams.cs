// PunTeams
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunTeams : MonoBehaviour
{
	public enum Team : byte
	{
		none,
		red,
		blue
	}

	public static Dictionary<Team, List<PhotonPlayer>> PlayersPerTeam;

	public const string TeamPlayerProp = "team";

	public void LGFPGIOFDFF(PhotonPlayer MCDOIGNGJBJ)
	{
		IAHDBKBHACB();
	}

	public void HBBEELBKKOJ()
	{
		JILOMOBDPIA();
	}

	public void CHOPDIGHJNH()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void CANOHFMKCOL(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void JDLPKNBOIDK(object[] EMIPGAIEKMK)
	{
		HBBDKKDFLBM();
	}

	public void JJGCNENAOOO()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void DOEPOGLEGLE()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void FKEJGBFDCAH()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void DHHJGPAHLNE(PhotonPlayer MCDOIGNGJBJ)
	{
		EJBOICDDBOP();
	}

	public void Start()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void EACGGDMMJCA(object[] EMIPGAIEKMK)
	{
		EJBOICDDBOP();
	}

	public void OnDisable()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void AKKFMHJNCKH(object[] EMIPGAIEKMK)
	{
		EJBOICDDBOP();
	}

	public void CFCEHJLIKGE()
	{
		JILOMOBDPIA();
	}

	public void JKNOPMDDLML()
	{
		HBBDKKDFLBM();
	}

	public void BLCLBBOGALJ()
	{
		BGDPIHMAACO();
	}

	public void UpdateTeams()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void OJGDFDCDEAM()
	{
		JILOMOBDPIA();
	}

	public void POKDGOEGBEL()
	{
		EJBOICDDBOP();
	}

	public void EODOHEAKJFO()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void LOJJKCJDJOK()
	{
		CNGAJDBOCLJ();
	}

	public void AIDBBIGHLCG(PhotonPlayer MCDOIGNGJBJ)
	{
		HBBDKKDFLBM();
	}

	public void JEIFNPFBIPE(PhotonPlayer FKKHMGIGLKM)
	{
		HBBDKKDFLBM();
	}

	public void ODFBFGCJCIM(object[] EMIPGAIEKMK)
	{
		IAHDBKBHACB();
	}

	public void LGBFDGNNCCM()
	{
		BGDPIHMAACO();
	}

	public void KMOCDAOKGLI()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void IEKEKPJNMOO(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void IHEFMJLOOPN(PhotonPlayer MCDOIGNGJBJ)
	{
		HBBDKKDFLBM();
	}

	public void DEGGCNPCJIA()
	{
		CNGAJDBOCLJ();
	}

	public void HBBDKKDFLBM()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void EJBOICDDBOP()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		UpdateTeams();
	}

	public void ABGKOOKLHNP()
	{
		HBBDKKDFLBM();
	}

	public void BFEILOMHNPC()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void OnPhotonPlayerPropertiesChanged(object[] EMIPGAIEKMK)
	{
		UpdateTeams();
	}

	public void NPLCENPNJBM()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void BOLBPPHJBMI()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void MPHHHCEFJHD(PhotonPlayer MCDOIGNGJBJ)
	{
		IAHDBKBHACB();
	}

	public void BGDPIHMAACO()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void ALCPGEDENCM()
	{
		HBBDKKDFLBM();
	}

	public void JILOMOBDPIA()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void BINJHPNHEJB(PhotonPlayer FKKHMGIGLKM)
	{
		HBBDKKDFLBM();
	}

	public void CNGAJDBOCLJ()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void KNPJMCDFBLH()
	{
		FHPFJBFCOOF();
	}

	public void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void LFPIALDGOKI(PhotonPlayer MCDOIGNGJBJ)
	{
		JJGCNENAOOO();
	}

	public void NNMEDLDLDIN()
	{
		JILOMOBDPIA();
	}

	public void NPOFGBAEHHI(PhotonPlayer FKKHMGIGLKM)
	{
		UpdateTeams();
	}

	public void FHPFJBFCOOF()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void MEBKJNNGIKM(PhotonPlayer FKKHMGIGLKM)
	{
		PNDLAAGMDKG();
	}

	public void IAHDBKBHACB()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void GGPNPNGELEF()
	{
		UpdateTeams();
	}

	public void DKAIBDIGLCH(object[] EMIPGAIEKMK)
	{
		IAHDBKBHACB();
	}

	public void PNDLAAGMDKG()
	{
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void BLLGLKBLDFM(PhotonPlayer MCDOIGNGJBJ)
	{
		PNDLAAGMDKG();
	}

	public void OLNPGMFMALA(PhotonPlayer FKKHMGIGLKM)
	{
		EJBOICDDBOP();
	}

	public void IPOIPEKEHBI(PhotonPlayer MCDOIGNGJBJ)
	{
		IAHDBKBHACB();
	}

	public void GJOFHFOCGAB(PhotonPlayer FKKHMGIGLKM)
	{
		PNDLAAGMDKG();
	}

	public void HJDHEPJHDKD()
	{
		IAHDBKBHACB();
	}

	public void JDMGEEBNHJH(object[] EMIPGAIEKMK)
	{
		HBBDKKDFLBM();
	}

	public void NDEMGIDBIOM(PhotonPlayer FKKHMGIGLKM)
	{
		EJBOICDDBOP();
	}

	public void CKFDNMMCHEC(PhotonPlayer FKKHMGIGLKM)
	{
		IAHDBKBHACB();
	}

	public void PHJLHCMCCKE()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void EAABKPJPPHL()
	{
		HBBDKKDFLBM();
	}

	public void OnLeftRoom()
	{
		Start();
	}

	public void KOIENNGENFP()
	{
		Start();
	}

	public void NBGIMIDICKE()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				PlayersPerTeam[(Team)current] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void OnJoinedRoom()
	{
		UpdateTeams();
	}
}
