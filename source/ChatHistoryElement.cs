// ChatHistoryElement
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class ChatHistoryElement : MonoBehaviour
{
	public enum ChatHistoryType
	{
		FromPlayer,
		Server
	}

	public ChatHistoryType messageType;

	public Text nicknameText;

	public Image bg;

	public Image icon;

	public GameObject contributorGO;

	public Text message;

	private CSteamID GDOHPDHLPBC;

	public void EPDCHKECMBL(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(BAMOGGMGKEF(GDOHPDHLPBC));
	}

	public void DPOELEBIAOE(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().GHFEDJOOJAL();
	}

	public void HBKEHHCMMBN(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().EPNHONDJOCN();
	}

	private IEnumerator JNHDMKACOIL(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void FFBDGOBNNCO(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().MJNCBNEIIOB();
	}

	public void LLAHPNGMEOO(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().LJBPHNIEMKO();
	}

	private IEnumerator NFLICFOEBDA(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void Init(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DoFix();
	}

	public void LILOGPDPFDA(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().JGPDCMDAKIG();
	}

	public void CFKJHLOEDFO(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(NFLICFOEBDA(GDOHPDHLPBC));
	}

	public void NOBNCNJKOLA(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().EPNHONDJOCN();
	}

	public void IFINBHBFCBB(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(PGHGGKFDCAA(GDOHPDHLPBC));
	}

	public void NKLCNJEIAFB(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().PFCOHJGGCEP();
	}

	public void PFMJPIJONIP(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DoFix();
	}

	private IEnumerator PGHGGKFDCAA(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void MDPJHKECLOF(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JIHLGDMPDCH(GDOHPDHLPBC));
	}

	public void IFGOHEOEGKH(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KLGENHIIIBK();
	}

	public void CFNDDGFGKKG(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(BAMOGGMGKEF(GDOHPDHLPBC));
	}

	public void LNMKDFDKFPF(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(KBMDGGPOLED(GDOHPDHLPBC));
	}

	public void MIAIEKCLEAO(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JIHLGDMPDCH(GDOHPDHLPBC));
	}

	public void Init(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(HJFDEEMKFDJ(GDOHPDHLPBC));
	}

	public void CDDHLFNJOGC(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().GHFEDJOOJAL();
	}

	public void OCHADIJNDJK(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KLGENHIIIBK();
	}

	public void GGHCMPKGNGE(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(KBMDGGPOLED(GDOHPDHLPBC));
	}

	public void NBIEIGBAKND(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(BAMOGGMGKEF(GDOHPDHLPBC));
	}

	private IEnumerator KBMDGGPOLED(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void LDKFAGOEDKF(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().ACNABEAEBNH();
	}

	private IEnumerator JIHLGDMPDCH(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private IEnumerator NBJAFEDELKC(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private IEnumerator HJFDEEMKFDJ(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void ALKBNPMCEOM(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DBPBNOLHJKB();
	}

	private IEnumerator EFCOMCEMBMF(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void PAFMNAIDAFH(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KPPBHBNMNHE();
	}

	public void NFKDBPGHHIJ(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DBPBNOLHJKB();
	}

	public void KDJHONILJGK(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(KBMDGGPOLED(GDOHPDHLPBC));
	}

	private IEnumerator HMNPHGALALI(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void GDJMBJEAPHM(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(PGHGGKFDCAA(GDOHPDHLPBC));
	}

	private IEnumerator LPIAHIDDABL(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private IEnumerator JJHNOHLFNGO(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void JJFLHFCBENC(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(EFCOMCEMBMF(GDOHPDHLPBC));
	}

	public void CMFBCPNHGOF(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(BAMOGGMGKEF(GDOHPDHLPBC));
	}

	private IEnumerator BAMOGGMGKEF(CSteamID JMMILEFMACB)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB));
		nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB);
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB));
		if ((bool)ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jMICLAEOFNP = 0;
		if (loadedRank != null)
		{
			jMICLAEOFNP = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		bg.color = RanksSystem.GetRankColor(jMICLAEOFNP);
		yield return StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public void NBHGPDAKJGF(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JIHLGDMPDCH(GDOHPDHLPBC));
	}

	public void FIMJABKECNG(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JNHDMKACOIL(GDOHPDHLPBC));
	}

	public void EFEONCCCKNP(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().PFCOHJGGCEP();
	}

	public void MOKHHEMAJBJ(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(PGHGGKFDCAA(GDOHPDHLPBC));
	}

	public void LKEPIEEIMAE(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KPPBHBNMNHE();
	}

	public void PJILLPKFCPO(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(NFLICFOEBDA(GDOHPDHLPBC));
	}
}
