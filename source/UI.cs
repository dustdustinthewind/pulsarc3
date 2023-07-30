// UI
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI : Singleton<UI>
{
	[Serializable]
	public class UIView
	{
		public string id;

		public bool useZoom;

		public float zoom;

		public bool blurBG;

		public List<GameObject> canvases;
	}

	[CompilerGenerated]
	private sealed class HKOLOPJKHIF
	{
		internal string HFEFHOPOLIK;

		internal bool KFNBKFELFLH(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool AEINPAGJFME(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool JKEDCEOCPJO(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BKNHHGBPLGH(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool BDGDIDPDBHG(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LNDGINDKPFA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool DBFPGFHEGKA(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LLNDDFGPOPL(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool MEMPOPNAEDN(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool GBKBDKHPLKG(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}

		internal bool LOEAMHGMMPK(UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == HFEFHOPOLIK;
		}
	}

	[CompilerGenerated]
	private sealed class MACNHEJAEDM
	{
		internal GameObject IPIOPNOHDOB;

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool INHOEMCLAAP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PKAPLCFHDOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BEBAENEJFLD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FMIHBNPKEEO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}
	}

	[CompilerGenerated]
	private sealed class IAMIDBEHMEC
	{
		internal GameObject IPIOPNOHDOB;

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == IPIOPNOHDOB.transform;
		}
	}

	[CompilerGenerated]
	private sealed class PEPADDKCAGK
	{
		internal GameObject IPIOPNOHDOB;

		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}

		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == IPIOPNOHDOB.name;
		}
	}

	[SerializeField]
	public List<UIView> viewsDictionary;

	public void EMPCBGGNGJN()
	{
		Singleton<UI>.Instance.LOOFBILFEME("_MainTex2", 1937f);
	}

	public void CHDCHBJCJDD(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'ￆ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ￕ';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = 'ﾴ';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB3, false, oEJIJIPGMCO, false, 922f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(AJGPBCBAPIF(item2, false, oEJIJIPGMCO, false, 616f, false));
					}
					else
					{
						StartCoroutine(SwitchViewAnimation(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("/files/editor_manual.pdf" + HFEFHOPOLIK + "Arc");
	}

	public void CCHMCLLHGJF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void LIEMGBMNJGH(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "Set satellite MinVertexDistance - how much distance should be between to points of the trail line")
		{
			PPFBFANEHEA();
		}
		else
		{
			Debug.LogWarning("_Scale" + JMMILEFMACB);
		}
	}

	public void NGLGEKJCFFM(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_Value6")
		{
			DGFKMFBCKKJ();
		}
		else
		{
			Debug.LogWarning("SpectatingUserInfo" + JMMILEFMACB);
		}
	}

	public void HDJBNGPMLJC()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void DGFKMFBCKKJ()
	{
		Singleton<UI>.Instance.GNPMFBMPDPO("SetParticlesEmission", 80f);
	}

	public void FBGFDEJPFHK()
	{
		Singleton<UI>.Instance.KPMPAGHHINJ("_Color_G", 1736f);
	}

	public IEnumerator SwitchViewAnimation(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator IONNACCHGJL(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator CBLGHHBMCPD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void MJLEAPCLIEK(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'p';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('\uffdd').Length > 0)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = '%';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(GMKIDJLMDGE(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 678f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(IONNACCHGJL(item2, true, oEJIJIPGMCO, false, 1981f, false));
					}
					else
					{
						StartCoroutine(MILOPMDKLKL(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("_Green_G" + HFEFHOPOLIK + "_ScreenResolution");
	}

	public IEnumerator AJGPBCBAPIF(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void ClearSelection()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public IEnumerator PKHAEJHIMGD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void ButtonClick(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "mainmenu")
		{
			BackToMainMenu();
		}
		else
		{
			Debug.LogWarning("[UI] Unknows button action: " + JMMILEFMACB);
		}
	}

	public void IOOEOHAHDAG()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void FCHHPLCCNLN(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "challenges.")
		{
			PPFBFANEHEA();
		}
		else
		{
			Debug.LogWarning("_TimeX" + JMMILEFMACB);
		}
	}

	public void IGLHHNJFLDO(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('ﾨ')[0];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = '\'';
		if (text2.Split(array).Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('\u0012')[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 101f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(IONNACCHGJL(item2, true, oEJIJIPGMCO, true, 1134f, false));
					}
					else
					{
						StartCoroutine(JCLKEGPNBJJ(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Fade" + HFEFHOPOLIK + "\" error: ");
	}

	public void MPAOPOODNAK()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public IEnumerator GMKIDJLMDGE(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void DMOLPOJGKID(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\ufff5';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = '\ufffe';
		if (text3.Split(array2).Length > 0)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('ﾗ')[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(GMKIDJLMDGE(IPIOPNOHDOB, false, oEJIJIPGMCO, true, 885f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PGEJNAMOJGB(item2, false, oEJIJIPGMCO, false, 1127f, false));
					}
					else
					{
						StartCoroutine(CBLGHHBMCPD(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("Load Game" + HFEFHOPOLIK + "maps.");
	}

	public void LOOFBILFEME(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = '=';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = '\ufffa';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'ﾢ';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(MILOPMDKLKL(IPIOPNOHDOB3, true, oEJIJIPGMCO, true, 1171f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(PKHAEJHIMGD(item2, true, oEJIJIPGMCO, false, 1100f));
					}
					else
					{
						StartCoroutine(GMKIDJLMDGE(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Value11" + HFEFHOPOLIK + "ItemNameText");
	}

	public void FLHOKJILPIP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ﾭ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('ﾹ').Length > 1)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[1] = 'ﾨ';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB, false, oEJIJIPGMCO, true, 1638f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(AJGPBCBAPIF(item2, true, oEJIJIPGMCO, true, 196f));
					}
					else
					{
						StartCoroutine(MILOPMDKLKL(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("DataText" + HFEFHOPOLIK + "CameraFilterPack/Vision_SniperScore");
	}

	public void IKDAEPDGPFI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "Xbox Home")
		{
			DGFKMFBCKKJ();
		}
		else
		{
			Debug.LogWarning("Set Crosshair Color" + JMMILEFMACB);
		}
	}

	public IEnumerator JCLKEGPNBJJ(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator PGEJNAMOJGB(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public void SwitchView(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('#')[0];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('#').Length > 1)
		{
			oEJIJIPGMCO = HFEFHOPOLIK.Split('#')[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB, false, oEJIJIPGMCO));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(SwitchViewAnimation(item2, true, oEJIJIPGMCO));
					}
					else
					{
						StartCoroutine(SwitchViewAnimation(item2, true, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("[UI] " + HFEFHOPOLIK + " canvas not found");
	}

	public void BOILOHFAADM()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void CLBHFLKPCNF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void PFHGBNNBFAN(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "RanksButton")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("SetParticlesGravity" + JMMILEFMACB);
		}
	}

	public void BECBNOPIPMM(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = 'z';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'ﾠ';
		if (text3.Split(array2).Length > 1)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'F';
			oEJIJIPGMCO = text4.Split(array3)[0];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(SwitchViewAnimation(IPIOPNOHDOB3, true, oEJIJIPGMCO, false, 950f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(CBLGHHBMCPD(item2, false, oEJIJIPGMCO, true, 850f));
					}
					else
					{
						StartCoroutine(JCLKEGPNBJJ(item2, false, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("menu.tabid" + HFEFHOPOLIK + "_Value");
	}

	public void KPMPAGHHINJ(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\u0011';
		string text2 = text.Split(array)[0];
		string oEJIJIPGMCO = null;
		string text3 = HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = 'ￜ';
		if (text3.Split(array2).Length > 0)
		{
			string text4 = HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'Y';
			oEJIJIPGMCO = text4.Split(array3)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB.transform))
						{
							list2.Add(IPIOPNOHDOB);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB3 in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB3.name))
				{
					StartCoroutine(FHHCCJAPBKA(IPIOPNOHDOB3, false, oEJIJIPGMCO, true, 1152f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(MILOPMDKLKL(item2, false, oEJIJIPGMCO, true, 820f, false));
					}
					else
					{
						StartCoroutine(MILOPMDKLKL(item2, true, oEJIJIPGMCO, false, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_Value3" + HFEFHOPOLIK + "_Value2");
	}

	public void LNDLDKAPMAE(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'ﾞ';
		string text2 = text.Split(array)[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('ﾢ').Length > 0)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = '9';
			oEJIJIPGMCO = text3.Split(array2)[1];
		}
		HFEFHOPOLIK = text2;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(AJGPBCBAPIF(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 675f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(CBLGHHBMCPD(item2, true, oEJIJIPGMCO, false, 124f));
					}
					else
					{
						StartCoroutine(SwitchViewAnimation(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE));
					}
				}
				return;
			}
		}
		Debug.LogError("CameraFilterPack/FX_Grid" + HFEFHOPOLIK + "IncorrectHitsScoreText");
	}

	public void MDKHCGABDAI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "_TimeX")
		{
			PPFBFANEHEA();
		}
		else
		{
			Debug.LogWarning("clicked " + JMMILEFMACB);
		}
	}

	public void AEDHECMGOJG(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('ﾔ')[0];
		string oEJIJIPGMCO = null;
		string text2 = HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '}';
		if (text2.Split(array).Length > 0)
		{
			string text3 = HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = '<';
			oEJIJIPGMCO = text3.Split(array2)[0];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(CBLGHHBMCPD(IPIOPNOHDOB, true, oEJIJIPGMCO, true, 897f));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(FHHCCJAPBKA(item2, false, oEJIJIPGMCO, true, 703f));
					}
					else
					{
						StartCoroutine(PKHAEJHIMGD(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_TimeX" + HFEFHOPOLIK + "RecordButton");
	}

	public void ODEKNBPEHKH()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void AEJENOFBCKI()
	{
		Singleton<UI>.Instance.SwitchView("not available at the moment", 741f);
	}

	public void GNPMFBMPDPO(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		string text = HFEFHOPOLIK.Split('R')[1];
		string oEJIJIPGMCO = null;
		if (HFEFHOPOLIK.Split('\uffdf').Length > 0)
		{
			string text2 = HFEFHOPOLIK;
			char[] array = new char[1];
			array[1] = 'q';
			oEJIJIPGMCO = text2.Split(array)[1];
		}
		HFEFHOPOLIK = text;
		if (viewsDictionary.Exists((UIView IACGDFHKCAE) => IACGDFHKCAE.id == HFEFHOPOLIK))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UIView item in viewsDictionary)
			{
				if (item.id == HFEFHOPOLIK)
				{
					foreach (GameObject IPIOPNOHDOB3 in item.canvases)
					{
						if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB3.transform))
						{
							list2.Add(IPIOPNOHDOB3);
						}
					}
					if ((bool)UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (item.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HAPMEDHIHGB(item.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(item.blurBG);
					}
					continue;
				}
				foreach (GameObject IPIOPNOHDOB2 in item.canvases)
				{
					if (!list.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.transform == IPIOPNOHDOB2.transform))
					{
						list.Add(IPIOPNOHDOB2);
					}
				}
			}
			foreach (GameObject IPIOPNOHDOB in list)
			{
				if (!list2.Exists((GameObject IACGDFHKCAE) => IACGDFHKCAE.name == IPIOPNOHDOB.name))
				{
					StartCoroutine(GMKIDJLMDGE(IPIOPNOHDOB, false, oEJIJIPGMCO, false, 867f, false));
				}
			}
			{
				foreach (GameObject item2 in list2)
				{
					if (!item2.activeSelf)
					{
						StartCoroutine(IONNACCHGJL(item2, false, oEJIJIPGMCO, true, 1502f));
					}
					else
					{
						StartCoroutine(MILOPMDKLKL(item2, false, oEJIJIPGMCO, true, KEDDLFDAIDE, false));
					}
				}
				return;
			}
		}
		Debug.LogError("_MainTex2" + HFEFHOPOLIK + "_Intensity");
	}

	public void GNAAOKCGBGH(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "maps.")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("note.4" + JMMILEFMACB);
		}
	}

	public void PPFBFANEHEA()
	{
		Singleton<UI>.Instance.AEDHECMGOJG("shader.none", 1780f);
	}

	public void CLBLFIEOOBD()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void BackToMainMenu()
	{
		Singleton<UI>.Instance.SwitchView("mainMenu");
	}

	public void ABLHAKDMDDJ(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == " connected: ")
		{
			AEJENOFBCKI();
		}
		else
		{
			Debug.LogWarning("_Near" + JMMILEFMACB);
		}
	}

	public void EGADGDAABML()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void DDPFPLAIMBA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == ".completed")
		{
			EMPCBGGNGJN();
		}
		else
		{
			Debug.LogWarning("sfxVolume" + JMMILEFMACB);
		}
	}

	public void GLIFGOGMLBN()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public void CFFJFFOALEE(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null && JMMILEFMACB == "ControllerRightY")
		{
			DGFKMFBCKKJ();
		}
		else
		{
			Debug.LogWarning("Reset All" + JMMILEFMACB);
		}
	}

	public void DPKMEJPGDIN()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	public IEnumerator MILOPMDKLKL(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}

	public IEnumerator FHHCCJAPBKA(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if ((bool)IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		Tweener LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade(BNKMBAECHGB ? 1 : 0, KEDDLFDAIDE);
		yield return new WaitWhile(() => !LGILGCGIHHM.IsComplete() && LGILGCGIHHM.IsPlaying());
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
	}
}
