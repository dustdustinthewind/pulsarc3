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

	public void LLEHKGIHFJL()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(canvas, true, null, true, 1349f));
	}

	public IEnumerator LLLKLEDFGAI(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator BBBNFOHPNOE(UnityAction KPCNMGBCOLP = null)
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
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(canvas, true, null, true, 316f, false));
	}

	public IEnumerator KJHGNLNKAIH(UnityAction KPCNMGBCOLP = null)
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

	public void CMPJLDPEGIF()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(canvas, false, null, true, 621f));
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

	public void CloseViewer()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false));
	}

	public void ACPPEEDNMJF()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(canvas, false, null, false, 1112f));
	}

	public void FBHBAAKFFIK()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(canvas, true, null, false, 644f));
	}

	public void CMMJOOGMPOP()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(canvas, true, null, true, 1383f, false));
	}

	public IEnumerator DOGKEHLLJML(UnityAction KPCNMGBCOLP = null)
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

	public void PGKLGJABKEA()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(canvas, false, null, true, 510f));
	}

	public void IAPKKDFOMNF()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(canvas, true, null, false, 418f));
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

	public IEnumerator NDIIHPKIOMB(UnityAction KPCNMGBCOLP = null)
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

	public void JPDGNCDDBEK()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(canvas, false, null, true, 972f, false));
	}

	public IEnumerator NGAONLGGDIA(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator FLNHFPHNNME(UnityAction KPCNMGBCOLP = null)
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

	public void IKHNDOCFOLN()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.BCOJGDDEDOP(canvas, false, null, false, 1607f));
	}

	public void FOBIAAOHIIC()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(canvas, false, null, false, 778f, false));
	}

	public void PLLPIDFANLI()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(canvas, true, null, false, 454f));
	}

	public void HNDBMNLDILD()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(canvas, true, null, true, 1053f));
	}

	public void EECCLNMPCEO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(canvas, false, null, true, 419f, false));
	}

	public void EELFFPJDBFB()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(canvas, false, null, false, 1604f, false));
	}

	public IEnumerator GKGAEBFMJNH(UnityAction KPCNMGBCOLP = null)
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

	public void MKHPBCJBCPN()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(canvas, false, null, false, 1865f));
	}

	public IEnumerator FIGPKFLPKMD(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator JFENHAEGOFE(UnityAction KPCNMGBCOLP = null)
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

	public void PKCADFLECKG()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(canvas, true, null, false, 800f, false));
	}

	public IEnumerator HBEIJLIILBF(UnityAction KPCNMGBCOLP = null)
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

	public void APEIHPBLOAG()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(canvas, true, null, true, 245f));
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

	public IEnumerator CKCOJGFHLEO(UnityAction KPCNMGBCOLP = null)
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

	public void CCHIGMACJKK()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(canvas, false, null, true, 231f));
	}

	public void NNCAKCMEDOJ()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(canvas, false, null, true, 361f, false));
	}

	public void LFILBMDGBBI()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(canvas, false, null, true, 416f, false));
	}

	public IEnumerator AOMMGOPABDA(UnityAction KPCNMGBCOLP = null)
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

	public void KOJJMLMCPKP()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(canvas, true, null, false, 9f));
	}

	public void PFPAPFMHBDA()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(canvas, true, null, false, 794f));
	}

	public IEnumerator BNECBFNHCDC(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator BBPIAEALFJJ(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator BNAGMGHHNBN(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator LFOOHBMHLPK(UnityAction KPCNMGBCOLP = null)
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
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(canvas, false, null, false, 600f, false));
	}

	public IEnumerator CKJGAKFFOFA(UnityAction KPCNMGBCOLP = null)
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

	public void NFLFAKMAGLA()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(canvas, true, null, true, 615f, false));
	}

	public void FGBBFBOBILD()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(canvas, true, null, false, 1017f, false));
	}

	public IEnumerator HBNGMMNFCJB(UnityAction KPCNMGBCOLP = null)
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

	public void EOEOMBKLLPF()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(canvas, false, null, true, 267f, false));
	}

	public void IMJCECEHKHP()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(canvas, true, null, true, 1203f));
	}

	public void LIBDIBDAEAK()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(canvas, false, null, false, 437f));
	}

	public void LLMBIBPOOBF()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(canvas, true, null, true, 268f));
	}

	public void PKDMAEGEEIH()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(canvas, true, null, true, 1204f, false));
	}

	public void GDGAAAIELPO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(canvas, false, null, true, 400f));
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

	public void MIKDILPAOOI()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(canvas, true, null, true, 799f, false));
	}

	public IEnumerator GGIOHKKJPCG(UnityAction KPCNMGBCOLP = null)
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

	public void AIOEGPBMFIO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(canvas, true, null, false, 1855f, false));
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

	public void FGDIBNNJCLK()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(canvas, true, null, true, 212f, false));
	}

	public IEnumerator PKBBMKOCLKD(UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator CGNBONFMPGD(UnityAction KPCNMGBCOLP = null)
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

	public void JCLAEAEANOO()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(canvas, false, null, false, 1703f, false));
	}

	public IEnumerator MFKDDGKHKJH(UnityAction KPCNMGBCOLP = null)
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
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(canvas, false, null, false, 1053f));
	}

	public void HOJKDEGKAEB()
	{
		NNMBIFEBFGD = true;
		StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(canvas, false, null, false, 1519f, false));
	}

	public void FBPHLGIJMEA()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(canvas, true, null, false, 820f, false));
	}

	public IEnumerator DGPPFIHLEML(UnityAction KPCNMGBCOLP = null)
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

	public void HOHJLOMIPNG()
	{
		NNMBIFEBFGD = false;
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(canvas, false, null, false, 1565f));
	}

	public IEnumerator FIFDFGDINMO(UnityAction KPCNMGBCOLP = null)
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
