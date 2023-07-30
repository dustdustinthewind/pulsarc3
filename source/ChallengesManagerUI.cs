// ChallengesManagerUI
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChallengesManagerUI : Singleton<ChallengesManagerUI>
{
	public GameObject canvas;

	public Text infoText;

	public Button buttonBack;

	public GameObject challengeListContent;

	public GameObject challengeListElementPrefab;

	private bool NNMBIFEBFGD;

	public IEnumerator CGAKGPGFAAH(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator LPJDKNPGGJN(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator PHKIFFJAGCL(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void FLEILMCOLPH()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(canvas, true, null, true, 1127f, false));
	}

	public void GAMJJIBMFBG()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, true, null, true, 1655f, false));
	}

	public IEnumerator DisplayViewer(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void CJIPCEEFIGP()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, false, null, false, 655f));
	}

	public IEnumerator HOPMPKEKJCJ(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator FANLNIPGEII(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void GAGNJOFDAHF()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true, null, false, 21f, false));
	}

	public void NEBBDIHMOLM()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, true, null, false, 460f, false));
	}

	public void GEPGLFMJJDI()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false, null, false, 1092f, false));
	}

	public void AIOEGPBMFIO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false, null, false, 179f));
	}

	public IEnumerator KILGJIBFBDL(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void FEFAHOMMICK()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, true, null, false, 475f));
	}

	public IEnumerator NGLEIIHHKCD(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator MIIAHMOFFEH(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator AEJKNCLEFNN(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void PJCFOHKLHEN()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(canvas, false, null, true, 1895f, false));
	}

	public IEnumerator CIGLEJADFDL(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void PFPAPFMHBDA()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(canvas, true, null, false, 15f, false));
	}

	public void HNDBMNLDILD()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, true, null, true, 454f, false));
	}

	public IEnumerator IDGAGPEPBGO(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator KDBNKDAOLOB(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void MIKDILPAOOI()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(canvas, false, null, false, 1832f, false));
	}

	public IEnumerator LHCEHBGEGED(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void FGDIBNNJCLK()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(canvas, true, null, true, 1725f, false));
	}

	public void DAJOCCFPEPJ()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(canvas, true, null, false, 1033f, false));
	}

	public void DHJILJCJJCG()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(canvas, true, null, false, 520f, false));
	}

	public IEnumerator HGFGMCIMHHA(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator PHLLLNPPPEO(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void IGEAFKKFMBO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(canvas, true, null, true, 539f));
	}

	public void EOEOMBKLLPF()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(canvas, false, null, true, 1432f));
	}

	public IEnumerator KOBBDINKNFM(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator JCCPLKDFGIJ(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator DOHCPHEEGJJ(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void CloseViewer()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public IEnumerator CMMDPOBFLAC(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void FGBBFBOBILD()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, false, null, true, 519f));
	}

	public void IADJGEBPENF()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, true, null, false, 1510f, false));
	}

	public void EELFFPJDBFB()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, true, null, true, 1106f, false));
	}

	public void IKHNDOCFOLN()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(canvas, true, null, true, 1633f));
	}

	public void PEEBPAIOEHM()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(canvas, false, null, true, 112f));
	}

	public IEnumerator BEOOPPNPBBH(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void LFILBMDGBBI()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, false, null, false, 771f));
	}

	public IEnumerator PAHCAKAJLAH(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void KOJJMLMCPKP()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(canvas, true, null, false, 1927f));
	}

	public void FOBIAAOHIIC()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(canvas, true, null, true, 538f));
	}

	public void CMMJOOGMPOP()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(canvas, true, null, true, 931f, false));
	}

	public IEnumerator NBGGKHGOKIF(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public IEnumerator GAHDLFHKILG(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}

	public void IGFMOEFLHCF()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(canvas, false, null, true, 1931f));
	}

	public void GDMBKNLAMEH()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(canvas, false, null, true, 1235f, false));
	}

	public void CKKGGBFFHHC()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, false, null, false, 82f));
	}

	public IEnumerator IMGADBAGEMK(UnityAction KPCNMGBCOLP = null)
	{
		NNMBIFEBFGD = true;
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
		GameObject gameObject = challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge challenges in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = Object.Instantiate(challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(challenges);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, true));
	}
}
