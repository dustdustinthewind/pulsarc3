// ContributorSystem
using System;
using System.Collections;
using System.Collections.Generic;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContributorSystem : Singleton<ContributorSystem>
{
	public string checkContributorURL = "?";

	public string redeemTicketURL = "?";

	public Button buttonBack;

	public GameObject managerCanvas;

	public GameObject promoCanvas;

	private Dictionary<CSteamID, bool> HDCCFLLCGOA = new Dictionary<CSteamID, bool>();

	private void GFEEMBOFBPA(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public void AINAKFEAKLI()
	{
	}

	public void OBPDGOGLKOH()
	{
		Singleton<MessageBoxPanel>.Instance.DEAKLIGJIFG("_LrDepthTex", "SetPosition", null, true, true, 381f);
	}

	public IEnumerator EEKAJCCELHK()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public bool HBFJGBNJFAC(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator PNNDIMLJKDC(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator IDKIKHAPGBD(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public bool LIBHPMCCOCC(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public bool BLBFOAAHMIK(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public void IBDKABDCANB()
	{
	}

	public IEnumerator OPLOFNDCOPK(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public void FGDIBNNJCLK()
	{
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(promoCanvas, true, null, false, 816f));
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(managerCanvas, false, null, true, 1092f, false));
	}

	public void GEPGLFMJJDI()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(promoCanvas, false, null, false, 1718f));
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(managerCanvas, true, null, false, 12f));
	}

	public void LIBDIBDAEAK()
	{
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(promoCanvas, false, null, true, 1783f, false));
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(managerCanvas, true, null, false, 633f, false));
	}

	public void BOMPFAECDHM()
	{
		Singleton<MessageBoxPanel>.Instance.JJEOAFDDLHK("0", "/", null, false, true, 606f);
	}

	public bool IDKJFPIKALJ(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public IEnumerator LLAHPNGMEOO()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public IEnumerator IFINBHBFCBB()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public bool ELGHMABFPAA(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	private void NPGGPMJJMKO(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public IEnumerator JDIFPHIJLEJ(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public void JEBDOBLCLBL()
	{
	}

	public bool OCMBMEJBFNK(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public void ShowTicketsStore()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Write me to get one for testing :)", "Ok", null);
	}

	public IEnumerator OHCEKGAOKPN(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator LDKFAGOEDKF()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public bool DMOPBKDCIJP(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void CCBBHMFMBDJ()
	{
	}

	public IEnumerator ICOGEOLJLPP(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public IEnumerator IAEADNIKOEO(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		if (DLGIPFOEDCF == 1)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, true));
			yield break;
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true));
		if (!string.IsNullOrEmpty(MJDIIKCLBOF))
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", delegate
			{
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
			}, "#yes", delegate
			{
				StartCoroutine(UseTicket(MJDIIKCLBOF));
			}));
		}
	}

	public void ABGHFADKCBO()
	{
		Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP(".lastCheckpoint.isMapCompleted", "_Gain", null, false, false, 81f);
	}

	public IEnumerator AEFEGAMLBHF(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public bool CNMJEIPFNBF(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public IEnumerator CJCACFBMHIM(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator ShowManager(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		if (DLGIPFOEDCF == 1)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, true));
			yield break;
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true));
		if (!string.IsNullOrEmpty(MJDIIKCLBOF))
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", delegate
			{
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
			}, "#yes", delegate
			{
				StartCoroutine(UseTicket(MJDIIKCLBOF));
			}));
		}
	}

	public void COPGDOKLBNF()
	{
	}

	private void GIOKNBKHMBN(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public IEnumerator NKIDODEJMBJ(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public IEnumerator FFBDGOBNNCO()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public IEnumerator NOBNCNJKOLA()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public void CJIPCEEFIGP()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(promoCanvas, false, null, true, 1194f));
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(managerCanvas, true, null, true, 1953f));
	}

	public IEnumerator MMFFGDNJNKO(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator IBMAAHEAMDD(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		if (DLGIPFOEDCF == 1)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, true));
			yield break;
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true));
		if (!string.IsNullOrEmpty(MJDIIKCLBOF))
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", delegate
			{
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
			}, "#yes", delegate
			{
				StartCoroutine(UseTicket(MJDIIKCLBOF));
			}));
		}
	}

	public IEnumerator IFGOHEOEGKH()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public IEnumerator LMGEELNOLJD(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		if (DLGIPFOEDCF == 1)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, true));
			yield break;
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true));
		if (!string.IsNullOrEmpty(MJDIIKCLBOF))
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", delegate
			{
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
			}, "#yes", delegate
			{
				StartCoroutine(UseTicket(MJDIIKCLBOF));
			}));
		}
	}

	public void DNAOMGHDHPB()
	{
		StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(promoCanvas, true, null, true, 309f, false));
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(managerCanvas, true, null, true, 1112f));
	}

	public IEnumerator HPEAKJIDDIN(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public void KOJJMLMCPKP()
	{
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(promoCanvas, true, null, false, 1606f, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true, null, false, 1910f));
	}

	public IEnumerator GOPHPPIEEPC(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		if (DLGIPFOEDCF == 1)
		{
			yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, true));
			yield break;
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, true));
		if (!string.IsNullOrEmpty(MJDIIKCLBOF))
		{
			yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", delegate
			{
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
			}, "#yes", delegate
			{
				StartCoroutine(UseTicket(MJDIIKCLBOF));
			}));
		}
	}

	private void BMAKGFLNEBI(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public void CCODGHNACBO()
	{
	}

	public IEnumerator UseTicket(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator DHFCIFMOLMP(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public IEnumerator AHHOJDIEELN(string EEBCDMFNKLH)
	{
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + EEBCDMFNKLH);
		CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close();
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + steamID.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("itemid", EEBCDMFNKLH);
		wWWForm.AddField("quantity", 1);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(redeemTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			yield break;
		}
		if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			yield return new WaitWhile(() => Singleton<ItemsHandler>.Instance.isLoadeding);
			yield return StartCoroutine(LoadContributor(steamID));
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(IsContributor(steamID));
			}
			if (Singleton<InventorySelector>.Instance.IsActive())
			{
				Singleton<InventorySelector>.Instance.SwichCategory(4);
			}
			if (IsContributor(SteamUser.GetSteamID()))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + wWW.text, "ok", null);
				yield break;
			}
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#failed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UseTicket(EEBCDMFNKLH));
			}, "#close", delegate
			{
			}));
		}
	}

	public bool MJNEHMLOFJC(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void FPNIONDIKAN()
	{
		Singleton<MessageBoxPanel>.Instance.DMDDLAICNDI("#rt", "tagElement", null, false, false, 980f);
	}

	public void LMEPGBLANEP()
	{
		Singleton<MessageBoxPanel>.Instance.IINDNBDIOMJ("[Up]", "id", null, true, false, 1199f);
	}

	private void AHAILNCJFDL(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public void GAGNJOFDAHF()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(promoCanvas, true, null, false, 182f));
		StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(managerCanvas, false, null, false, 1681f, false));
	}

	public void CEKHLIBCLML()
	{
	}

	public bool AOBLMCONBFG(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator DLLKPBONKKK(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public IEnumerator LoadContributor(CSteamID JMMILEFMACB)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			yield break;
		}
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(checkContributorURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			try
			{
				bool kJPAHOFPCKD = int.Parse(wWW.text) == 1;
				ELOBOMNKFLH(JMMILEFMACB, kJPAHOFPCKD);
			}
			catch (Exception)
			{
			}
		}
	}

	public bool IsContributor(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void LHEIGAILFND()
	{
		Singleton<MessageBoxPanel>.Instance.COIPKIFPDBL("_ScreenResolution", "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", null, true, true, 229f);
	}

	public void CCLABFIPIDG()
	{
	}

	public bool OFCBGGLJAHH(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void CloseViewer()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
	}

	public void HAIJMHDFNGL()
	{
	}

	private void NPFOMCNHJFG(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public IEnumerator Init()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	private void ANGFEMEMDJN(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public void HideTicketsStore()
	{
	}

	public void AGJJFMNIJKM()
	{
		Singleton<MessageBoxPanel>.Instance.MEGHOGOANGJ("ScreenResolutionPanel", "_Bloom3", null, true, true, 1284f);
	}

	private void ELOBOMNKFLH(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	public void MHGPANGFPMF()
	{
	}

	public bool FOEDJMAGEIP(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}
}
