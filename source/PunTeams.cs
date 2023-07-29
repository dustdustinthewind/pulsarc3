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

	public void KMODBOJMCGM(object[] EMIPGAIEKMK)
	{
		PNDLAAGMDKG();
	}

	public void BINNHCEOJMK(PhotonPlayer FKKHMGIGLKM)
	{
		KJEJABMICLJ();
	}

	public void IDCKFBKAPLG(object[] EMIPGAIEKMK)
	{
		OODPBGLNDBB();
	}

	public void IBPAPNIDHNG()
	{
		FMNPFCHBLJF();
	}

	public void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		UpdateTeams();
	}

	public void OANPGFAKCJP(object[] EMIPGAIEKMK)
	{
		ELEENIFILJN();
	}

	public void MMBPPLMMAEP(object[] EMIPGAIEKMK)
	{
		UpdateTeams();
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

	public void GPJNGDBFIEF(object[] EMIPGAIEKMK)
	{
		KJEJABMICLJ();
	}

	public void OODPBGLNDBB()
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

	public void PLLJLMAMJAF(object[] EMIPGAIEKMK)
	{
		FLGKDMIDFEM();
	}

	public void PAKPHKPDKGE()
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

	public void IFJDKDFLGBG()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void PBPPONHHCKF(object[] EMIPGAIEKMK)
	{
		KIJOCBLAAAH();
	}

	public void JLMBFPCHOMI()
	{
		CIPKEPDELJB();
	}

	public void LBFONLCIOMM(object[] EMIPGAIEKMK)
	{
		KJEJABMICLJ();
	}

	public void KOJKBFDNGDK()
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

	public void LCJFGHJDCOB()
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

	public void EBBHDEHPHKA()
	{
		EPEGAEGDJAM();
	}

	public void NGKAGGEHJCO()
	{
		CPBKHGJJNAJ();
	}

	public void FNCDAPDOBBI()
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

	public void BOEAEAMIIPN(object[] EMIPGAIEKMK)
	{
		DMNDKAFNNOD();
	}

	public void CPDMBJCOCAM(object[] EMIPGAIEKMK)
	{
		JBJEKKFGLLP();
	}

	public void JBJEKKFGLLP()
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

	public void OnDisable()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void CIEIBNLCIGE(object[] EMIPGAIEKMK)
	{
		LMBNFKGBDNK();
	}

	public void KIJOCBLAAAH()
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
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void DMNDKAFNNOD()
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
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void OHFOLGANOLC()
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

	public void FAFNDLCHPHC()
	{
		FLGKDMIDFEM();
	}

	public void ICLONIMMFLG()
	{
		LCJFGHJDCOB();
	}

	public void FEIJFPOFEHA()
	{
		ELEENIFILJN();
	}

	public void KMCPMOGKDEH()
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

	public void HGDDCINLDAD()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void CIPKEPDELJB()
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

	public void CJMGILMCGHG(PhotonPlayer MCDOIGNGJBJ)
	{
		LMBNFKGBDNK();
	}

	public void GJOFHFOCGAB(PhotonPlayer FKKHMGIGLKM)
	{
		FLGKDMIDFEM();
	}

	public void CKFDNMMCHEC(PhotonPlayer FKKHMGIGLKM)
	{
		CPBKHGJJNAJ();
	}

	public void FMNPFCHBLJF()
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

	public void GDMLOIIILIL(PhotonPlayer FKKHMGIGLKM)
	{
		JBJEKKFGLLP();
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
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void EACGGDMMJCA(object[] EMIPGAIEKMK)
	{
		LMBNFKGBDNK();
	}

	public void DMLFOFLEGAH(PhotonPlayer FKKHMGIGLKM)
	{
		CPBKHGJJNAJ();
	}

	public void CCGENFLKPPE(PhotonPlayer MCDOIGNGJBJ)
	{
		FLGKDMIDFEM();
	}

	public void MBBBDIIIOFC()
	{
		LCJFGHJDCOB();
	}

	public void OnJoinedRoom()
	{
		UpdateTeams();
	}

	public void BKGJOECFMID()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void EDAAPBJEEKJ(PhotonPlayer MCDOIGNGJBJ)
	{
		KJEJABMICLJ();
	}

	public void NIEFNFBHNDB(object[] EMIPGAIEKMK)
	{
		LMBNFKGBDNK();
	}

	public void PNAGJMHIGGN()
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
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			Team team = photonPlayer.GetTeam();
			PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	public void NCIAGGDENJE(PhotonPlayer MCDOIGNGJBJ)
	{
		FLGKDMIDFEM();
	}

	public void OnLeftRoom()
	{
		Start();
	}

	public void EPEGAEGDJAM()
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

	public void LMBNFKGBDNK()
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

	public void OLFOHNNDHMK()
	{
		PNDLAAGMDKG();
	}

	public void MGKJFIOOMHP(object[] EMIPGAIEKMK)
	{
		DMNDKAFNNOD();
	}

	public void KAAIAIBIFOE(PhotonPlayer FKKHMGIGLKM)
	{
		LMBNFKGBDNK();
	}

	public void NMKMMIOCODL(PhotonPlayer MCDOIGNGJBJ)
	{
		LCJFGHJDCOB();
	}

	public void JOJFHFHOCHO()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void IABLKKAALGI()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void ELEENIFILJN()
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

	public void OnPhotonPlayerPropertiesChanged(object[] EMIPGAIEKMK)
	{
		UpdateTeams();
	}

	public void KJEJABMICLJ()
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

	public void PALPIANCGLL()
	{
		FNCDAPDOBBI();
	}

	public void AFJAAJCOLCI(PhotonPlayer FKKHMGIGLKM)
	{
		LMBNFKGBDNK();
	}

	public void BINJHPNHEJB(PhotonPlayer FKKHMGIGLKM)
	{
		KIJOCBLAAAH();
	}

	public void JNHPFMKIBMO(PhotonPlayer FKKHMGIGLKM)
	{
		KJEJABMICLJ();
	}

	public void JJCENHLNEEJ()
	{
		IHLMNAGPKDA();
	}

	public void MOCHFOLGBMM()
	{
		FLGKDMIDFEM();
	}

	public void FLGKDMIDFEM()
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

	public void DBNPDNJNDBL(PhotonPlayer FKKHMGIGLKM)
	{
		OCNEBMKFLLN();
	}

	public void LONKEDEIJKJ()
	{
		EPEGAEGDJAM();
	}

	public void KGGMHBDCOIO(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void JHJGJJKELJM()
	{
		PlayersPerTeam = new Dictionary<Team, List<PhotonPlayer>>();
	}

	public void GGAKOEPCCGB(object[] EMIPGAIEKMK)
	{
		CPBKHGJJNAJ();
	}

	public void GECDHLCPKNO()
	{
		PNDLAAGMDKG();
	}

	public void NIEHJGHECJL(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void OCNEBMKFLLN()
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

	public void IHLMNAGPKDA()
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

	public void CPBKHGJJNAJ()
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

	public void GHPHOPNDONN(PhotonPlayer MCDOIGNGJBJ)
	{
		CPBKHGJJNAJ();
	}

	public void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		UpdateTeams();
	}

	public void DBEMDAJDDDA()
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
}
