// MultiTabUI
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MultiTabUI : MonoBehaviour
{
	public List<GameObject> tabs;

	public List<GameObject> panels;

	public int currentTab;

	private void EOPBGLHKCAF()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().KGPPEIOBEDJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void FHGKIOOMMOH()
	{
		JKGEHINBJLL(currentTab);
	}

	public void NAEGBHFEGJL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find(".highscore");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOPBGLHKCAF();
		KGGCLKEPEJL();
	}

	private void LDDKCCMHMIC()
	{
	}

	public void EABICKMBGOF(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("#onrankchangeuptext");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JFNBHGBKLCI();
		PJNCCGDMJPH();
	}

	private void LJGDIIIOEEN()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void AKIMHIDLGLB()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(true);
		}
	}

	private void KGGCLKEPEJL()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void JKMANIOFCEM()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().DEKCCEKJEKP(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void DLOINDFHMGM()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().BHNJGNCINHD(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void MKCEKKCEKFP(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find(".icon");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOPBGLHKCAF();
		PJNCCGDMJPH();
	}

	private void COIJKMKIEAK()
	{
		NAEGBHFEGJL(currentTab);
	}

	public void NMNPLENMAPI(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		INJOFKJFDEM();
		HJDDLMCOENE();
	}

	public void OnTabSelect(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		CECPMNODBLA();
		PJNCCGDMJPH();
	}

	private void BGFJOEPFOPM()
	{
	}

	private void NCPAFCKGJEA()
	{
	}

	private void HJDDLMCOENE()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(true);
		}
	}

	private void ILCFPCIPENO()
	{
		CEJKHCODENB(currentTab);
	}

	private void CCIDBLACHOD()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void ELENFKEEPLP()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void JFNBHGBKLCI()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().OJAJAOFMBAG(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void IMCKJCHKMKB()
	{
		MMLGJPALKFG(currentTab);
	}

	private void PJNCCGDMJPH()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(true);
		}
	}

	private void AFKHIPJGKBC()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(true);
		}
	}

	private void NBGIMIDICKE()
	{
		MMLGJPALKFG(currentTab);
	}

	private void GIHHKHDEEDE()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().CBNJLHDJDDO(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void JECMJNFGBGC()
	{
		CEBJCKHBCJP(currentTab);
	}

	private void HNDNDPECBPL()
	{
	}

	private void Start()
	{
		OnTabSelect(currentTab);
	}

	private void NDAJBJFJGCF()
	{
	}

	private void BFLNPIIAMJA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().BCBNGINEAJG(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void HFKMIPNOIIC()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().AKLCEKDMDCC(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void JMEOGJHCONJ()
	{
		MKCEKKCEKFP(currentTab);
	}

	public void IAPBIAFMIOC(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_MainTex2");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		MGGAMOFLCLN();
		INPOALKOLAF();
	}

	public void GHOPFIOCGKK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Atmosphere_Rain");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		CECPMNODBLA();
		HJDDLMCOENE();
	}

	private void KCCIEMBMOBA()
	{
		EKMJJMCFEJI(currentTab);
	}

	private void GGKPJBBAHNO()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().EEJOKOAIHPM(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void NCNPAKFAFOE()
	{
		MMLGJPALKFG(currentTab);
	}

	private void CECPMNODBLA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentTab;
		}
	}

	public void CEBJCKHBCJP(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("[Left]");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JFNBHGBKLCI();
		JFIGOFMCEHB();
	}

	private void IIFCIDDJHPM()
	{
	}

	private void MOKLLKMFJPF()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void LDAOAKEKCKA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ADMACILOBFL(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void JKGEHINBJLL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("GameScene");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		CECPMNODBLA();
		KCEIJLCPNAP();
	}

	public void CEJKHCODENB(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_SprTex");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KDMODFJGGPG();
		HJDDLMCOENE();
	}

	private void KCEIJLCPNAP()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void MGGAMOFLCLN()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().MHDBGGHELEH(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void EMJLLDAKBHA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().MHDBGGHELEH(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void CCLNNLCOPBL()
	{
		IAPBIAFMIOC(currentTab);
	}

	private void EJFJENFKLND()
	{
	}

	private void KLILJHJNICK()
	{
		JKGEHINBJLL(currentTab);
	}

	public void LGCHOAOBPLO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("OperationResponse ignored while disconnecting. Code: ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		BFLNPIIAMJA();
		JFIGOFMCEHB();
	}

	private void MKKNHEJMLHI()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void NNFMIAFHMJM()
	{
		NAEGBHFEGJL(currentTab);
	}

	private void MGMAOBPPOBJ()
	{
		GHOPFIOCGKK(currentTab);
	}

	private void LCJHDLKJEOM()
	{
	}

	private void CNEOHPBCBMJ()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(false);
		}
	}

	public void GMNBIEGJHEO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Gradients_Stripe");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EMJLLDAKBHA();
		AFKHIPJGKBC();
	}

	private void Update()
	{
	}

	private void IGPCNHOHNCK()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 1)
		{
			panels[currentTab].SetActive(false);
		}
	}

	private void INJOFKJFDEM()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().BHNJGNCINHD(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void MMLGJPALKFG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_SpotSize");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JFNBHGBKLCI();
		INPOALKOLAF();
	}

	private void KMCPMOGKDEH()
	{
		KGBDLPJPAAG(currentTab);
	}

	private void KNBJBNDGCIJ()
	{
		CEJKHCODENB(currentTab);
	}

	private void FOMNCPKKCFN()
	{
	}

	private void KDMODFJGGPG()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FLNOCLOIMEK(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void ILGBFOEMMNN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EMJLLDAKBHA();
		ELENFKEEPLP();
	}

	public void EKMJJMCFEJI(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_FixDistance");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		MGGAMOFLCLN();
		MOKLLKMFJPF();
	}

	private void KFACDBHDAOD()
	{
	}

	private void JFIGOFMCEHB()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(false);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(true);
		}
	}

	private void KIMMMCJFMAB()
	{
		EKMJJMCFEJI(currentTab);
	}

	public void KGBDLPJPAAG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("\" error: ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JKMANIOFCEM();
		HJDDLMCOENE();
	}

	private void INPOALKOLAF()
	{
		foreach (GameObject panel in panels)
		{
			panel.SetActive(true);
		}
		if (panels.Count > 0)
		{
			panels[currentTab].SetActive(true);
		}
	}
}
