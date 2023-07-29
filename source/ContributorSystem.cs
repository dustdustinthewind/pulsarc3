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

	public void CMPNNHPGJHA()
	{
		StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(promoCanvas, false, null, true, 326f, false));
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(managerCanvas, false, null, true, 1955f, false));
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

	public IEnumerator HGFILODOJGH(string EEBCDMFNKLH)
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

	public void ShowTicketsStore()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Write me to get one for testing :)", "Ok", null);
	}

	private void OFDKGPBLCIL(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public void JHMFFEAANLI()
	{
	}

	public void PGKLGJABKEA()
	{
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(promoCanvas, false, null, false, 1349f, false));
		StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(managerCanvas, true, null, false, 80f));
	}

	public bool OBEILGHDEDH(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public bool LIBHPMCCOCC(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public IEnumerator JFGOMIIHHMK(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public IEnumerator AFAOIMHOLJM(string EEBCDMFNKLH)
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

	public void KLLLPJHDFIA()
	{
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("_TimeX", "ShowTitle", null, false, true, 921f);
	}

	private void BNJBMOFBHLA(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public IEnumerator ANHEADKMODP(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public bool PNPAPDNCGBD(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator KKHLDFJCIEK(string EEBCDMFNKLH)
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

	private void BOGCGCAFIND(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public IEnumerator GDDMBKGEGCB(string EEBCDMFNKLH)
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

	public IEnumerator DFGCDGFDABE(string EEBCDMFNKLH)
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

	public IEnumerator BGBONLPDHKH(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public void HideTicketsStore()
	{
	}

	public bool ACIHIGGAFOJ(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator NPBGNMMMPNA(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public void ODDNPBGMMGE()
	{
	}

	public IEnumerator CJGDDHMOIAA(string EEBCDMFNKLH)
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

	public IEnumerator ALGKENJGNLL()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public bool MJNEHMLOFJC(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator CGKEFHGMKMM(string EEBCDMFNKLH)
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

	public void CCODGHNACBO()
	{
	}

	public bool ADOIJJEICFB(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	private void DPKFMIJPJIO(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public void CloseViewer()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(promoCanvas, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(managerCanvas, false));
	}

	public void CMBCFFHONFL()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("x", "_TimeX", null, true, false, 774f);
	}

	public IEnumerator MDPJHKECLOF()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public void DCDFACDDNHC()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL(".g", "ns", null, true, false, 1739f);
	}

	public bool CHLFPOBDIFO(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public bool IDKJFPIKALJ(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator FBCIBNAGIHM(string EEBCDMFNKLH)
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

	public IEnumerator DAFAFBGFPLM(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public IEnumerator LCKKDMKJJEF()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	public void HEGJEDHJEFA()
	{
	}

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

	public bool FAGGPADPEGK(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void JIDMMCCLHBO()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("workshop.", "_Value", null, true, true, 925f);
	}

	public IEnumerator POGCJFEDMJK(string EEBCDMFNKLH)
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

	public IEnumerator MDGAFIGCHNF(string EEBCDMFNKLH)
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

	public bool BOOHFGEIJCG(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public IEnumerator NNKOMICIOBP(string EEBCDMFNKLH)
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

	public void OAGFCKCIDKA()
	{
	}

	public IEnumerator JMFDJLNMBMO(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	private void BMPOBADLBJD(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public void FJOJEHBJACA()
	{
	}

	public bool IsContributor(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return false;
	}

	public void EJOFHDBBDKN()
	{
	}

	public IEnumerator Init()
	{
		yield return StartCoroutine(LoadContributor(SteamUser.GetSteamID()));
	}

	private void IFKPAMCGIGL(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public void PKCHDIHNDDN()
	{
	}

	public IEnumerator ELIFGJJCPPF(CSteamID JMMILEFMACB)
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

	public IEnumerator KKIAGAGMLPG(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public IEnumerator LCJIGDBJEBC(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public void JEDEKAMHAKF()
	{
	}

	public IEnumerator EKNOOKNNLLI(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public void NCNGCIEAIIE()
	{
		StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(promoCanvas, true, null, false, 671f, false));
		StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(managerCanvas, false, null, false, 929f));
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

	public bool KCECAOBCGLN(CSteamID HFEFHOPOLIK)
	{
		if (HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
		}
		return true;
	}

	public IEnumerator GGOJMMMAOOA(string EEBCDMFNKLH)
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

	private void BMNLKFEHCHB(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
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

	public IEnumerator JIMODLHJFLN(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
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

	public IEnumerator GOEMAOAMNLG(string EEBCDMFNKLH)
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

	public void PINOHCHDHBO()
	{
	}
}
