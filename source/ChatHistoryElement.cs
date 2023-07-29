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

	private IEnumerator LPLEAFOLDHP(CSteamID JMMILEFMACB)
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

	public void PFMJPIJONIP(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(HJFDEEMKFDJ(GDOHPDHLPBC));
	}

	public void EOPEMLDJAAO(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().OABFKACDOFO();
	}

	public void EFEONCCCKNP(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(LNEJMKFDKJH(GDOHPDHLPBC));
	}

	private IEnumerator LNEJMKFDKJH(CSteamID JMMILEFMACB)
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

	public void POGJLIDHDIH(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().OABFKACDOFO();
	}

	public void CFNDDGFGKKG(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JJHNOHLFNGO(GDOHPDHLPBC));
	}

	public void LNMKDFDKFPF(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DEIBEBOEPPK();
	}

	public void CMFBCPNHGOF(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KBGBMIHOPLF();
	}

	public void KJBJBNGJDAD(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(MPNDPGDPHPF(GDOHPDHLPBC));
	}

	public void FIMJABKECNG(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().NOGJCBJLPPI();
	}

	public void ALKBNPMCEOM(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(LPLEAFOLDHP(GDOHPDHLPBC));
	}

	public void EPDCHKECMBL(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().FHNHEBMLGNI();
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

	private IEnumerator CLHJFMGDODK(CSteamID JMMILEFMACB)
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

	private IEnumerator JCFPJFHBAEJ(CSteamID JMMILEFMACB)
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

	public void IFGOHEOEGKH(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(DLODAEFGHIH(GDOHPDHLPBC));
	}

	public void LBICLFNOLAK(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(PGHGGKFDCAA(GDOHPDHLPBC));
	}

	public void Init(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().DoFix();
	}

	public void FECMEIJGLJI(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().KLGENHIIIBK();
	}

	public void Init(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(HJFDEEMKFDJ(GDOHPDHLPBC));
	}

	private IEnumerator KFBPICANOJO(CSteamID JMMILEFMACB)
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

	private IEnumerator BBEKOKGPJNH(CSteamID JMMILEFMACB)
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

	public void MIAIEKCLEAO(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(KFBPICANOJO(GDOHPDHLPBC));
	}

	private IEnumerator MPNDPGDPHPF(CSteamID JMMILEFMACB)
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

	private IEnumerator HFMIKDDGCIC(CSteamID JMMILEFMACB)
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

	private IEnumerator BAKJJFJENBC(CSteamID JMMILEFMACB)
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

	public void MOKHHEMAJBJ(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(OJNBBBLCDMH(GDOHPDHLPBC));
	}

	private IEnumerator OJNBBBLCDMH(CSteamID JMMILEFMACB)
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

	public void HBKEHHCMMBN(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		StartCoroutine(JJHNOHLFNGO(GDOHPDHLPBC));
	}

	private IEnumerator DLODAEFGHIH(CSteamID JMMILEFMACB)
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

	public void GDJMBJEAPHM(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().LAEIHIHMKNG();
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

	public void NBHGPDAKJGF(string EAFAMAMDNEG)
	{
		message.text = EAFAMAMDNEG;
		GetComponent<ContentSizeFitterFx>().IEJKGNLANAE();
	}
}
