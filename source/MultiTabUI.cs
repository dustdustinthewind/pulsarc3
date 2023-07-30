// MultiTabUI
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MultiTabUI : MonoBehaviour
{
	public List<GameObject> tabs;

	public List<GameObject> panels;

	public int currentTab;

	public void OMENOBPMAFH(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_Distortion");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		GFFPJICLEJI();
		KNGLBJONBOG();
	}

	private void HPNNCNNFMGK()
	{
	}

	private void IAJKLKJJKEJ()
	{
	}

	public void JIIADPBJBGE(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("RecordButton");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		DHOLKKPFBEG();
		NELIEGICCGD();
	}

	private void KOGNNIBKMEF()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().NDEEHLAJGIM(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void NGMPJNGAIBK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Drawing_Manga_Flash");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		CECPMNODBLA();
		CCIDBLACHOD();
	}

	private void IBNONKCHOGO()
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

	private void IGHMNAAGHPC()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().AEGJGKNOBEE(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void JEEDBJHBEKE()
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

	private void DLBODOFAJGM()
	{
		HPFNNJEFIMN(currentTab);
	}

	public void FDGCBHOJJCN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_color");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KOPOCNGHBHH();
		KPOEHFNLKCC();
	}

	public void HPFNNJEFIMN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_ChannelMixerGreen");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOLHGLPBMHH();
		GFNHOINOHKF();
	}

	private void DBEMDAJDDDA()
	{
		OMENOBPMAFH(currentTab);
	}

	private void EHAHDCEOOKG()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void OPMJIBIBJGM(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Blend2Camera_LighterColor");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		FEDPLLHGCAA();
		OKHOKCHDDOM();
	}

	private void AKNJOAAHIEF()
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

	public void EABICKMBGOF(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find(" left");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KBBFLFFAEJN();
		NAEMKNGNGHN();
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void GPNAOAKCMHC()
	{
		PCLHMGJAEFN(currentTab);
	}

	private void IIDNJGHJEBL()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().NDEEHLAJGIM(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void BOBFKDPCPHI()
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

	private void JFNBHGBKLCI()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ONPCGCOGNBJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void CCIDBLACHOD()
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

	private void GFFPJICLEJI()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void LLIONKKPNKJ(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("#close");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		OJKMPGAGECN();
		AKNJOAAHIEF();
	}

	private void KGPCLNGCONM()
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

	private void NFEDLAOPHML()
	{
	}

	private void OJKMPGAGECN()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ONPCGCOGNBJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void LKJMIODJGCM()
	{
	}

	private void OEENOOGEEHD()
	{
	}

	public void IJEABJLHGAB(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("SettingsCanvas");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KFJLBMHCKBM();
		IBNONKCHOGO();
	}

	private void KFACDBHDAOD()
	{
	}

	public void NIFEKBKPNHD(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventConfigButton");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOLHGLPBMHH();
		KCEIJLCPNAP();
	}

	private void KLCOIJONDFB()
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

	private void PCHCFIOHIKK()
	{
		CJEPOGFKHPK(currentTab);
	}

	private void DDFCMGDCJPD()
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

	private void EILOFIONJPF()
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

	private void GFNHOINOHKF()
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

	private void GGPDKCHEBAG()
	{
	}

	private void IFDFLKGAPJL()
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

	private void ANKIJGCGCBF()
	{
	}

	private void HMPGIFBJFIK()
	{
		LLIONKKPNKJ(currentTab);
	}

	private void LLDHEJIEDHO()
	{
	}

	public void AJEBMKCLGLK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("menu.playedpage");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		IIDNJGHJEBL();
		BONHCCHEJGL();
	}

	public void GMNBIEGJHEO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("MenuScene");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOLHGLPBMHH();
		FNNMDLMGDOI();
	}

	private void PMPKMGKAAJH()
	{
		FOCBNINLHFL(currentTab);
	}

	private void EGEPLFGKGLI()
	{
		OIIAHALBLFN(currentTab);
	}

	private void LFBGJIIECLD()
	{
		EABICKMBGOF(currentTab);
	}

	private void KOPOCNGHBHH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void DEEPMOLMGED()
	{
	}

	private void MFKMPLCPEJN()
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

	private void IHBOGLJFPGK()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void DHGNICBHBBF()
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

	private void PBIGHNGAAID()
	{
	}

	private void DHOLKKPFBEG()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ONPCGCOGNBJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void LDAOAKEKCKA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void AEPOMLHIOCN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("Joystick1Button8");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		AIFDDFADOHL();
		EILOFIONJPF();
	}

	private void BONHCCHEJGL()
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

	private void MDNHCLKNCLE()
	{
		IPJFHDIHDHF(currentTab);
	}

	private void BJNKKNAEGIK()
	{
		IJEABJLHGAB(currentTab);
	}

	private void MGLEPGDLHPO()
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

	private void NELIEGICCGD()
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

	private void BNIJDEMMHBA()
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

	private void COIADCBPPHJ()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().POPJEBPBDEA(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void GDKDFJACKDC(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("ItemNameBGImage");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JFNBHGBKLCI();
		KPOEHFNLKCC();
	}

	public void GHKLPJABAGE(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_Value2");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KOGNNIBKMEF();
		KNGLBJONBOG();
	}

	private void GAMLOHBLEDL()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ONPCGCOGNBJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void AKCADICOFDD()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	public void BOHOECFHFKE(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		FEJDJIFHLCE();
		MGLEPGDLHPO();
	}

	public void IPJFHDIHDHF(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("ViewMenu");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EHAHDCEOOKG();
		INKDOEJHCFH();
	}

	private void AKJFMEBJEPI()
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

	public void OnTabSelect(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		CECPMNODBLA();
		PJNCCGDMJPH();
	}

	private void CHMJCEMKCJF()
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

	private void OIPGAIMGIGD()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void KNGLBJONBOG()
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

	private void MECJHOJPODB()
	{
	}

	public void MMLGJPALKFG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CountEventsGoal");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		BFLNPIIAMJA();
		HIIHGIOIOOI();
	}

	public void EHAIJOMFAEP(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("OK");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		LDAOAKEKCKA();
		DHGNICBHBBF();
	}

	private void Update()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	public void MFLOPCJABLO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		PIHNIFKKBMH();
		KELFGKMAAFJ();
	}

	private void GMELGGJOPBB()
	{
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

	private void MKIMDFLBFOM()
	{
		HPFNNJEFIMN(currentTab);
	}

	private void BEBNOKFLJPH()
	{
		FCADHEJKDPK(currentTab);
	}

	private void IPJFFIDBPFE()
	{
		MMLGJPALKFG(currentTab);
	}

	private void MMBPLGGLPDB()
	{
	}

	private void BKABIDMABHH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void PCIMPDNLCHH()
	{
	}

	private void INKDOEJHCFH()
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

	public void PCLHMGJAEFN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("getint");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOLHGLPBMHH();
		FNNMDLMGDOI();
	}

	private void KIMMMCJFMAB()
	{
		OMENOBPMAFH(currentTab);
	}

	private void FANADGBGCPI()
	{
		PCLHMGJAEFN(currentTab);
	}

	private void KBBFLFFAEJN()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().POPJEBPBDEA(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void JGFPIEMNMHO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_FixDistance");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KOGNNIBKMEF();
		NAEMKNGNGHN();
	}

	private void APBNNKJBPGJ()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void FCADHEJKDPK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("Joystick1Button12");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		JFNBHGBKLCI();
		KHKAJFOADBN();
	}

	private void KFJLBMHCKBM()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void Start()
	{
		OnTabSelect(currentTab);
	}

	private void PDHKMDBNGGN()
	{
		GHOPFIOCGKK(currentTab);
	}

	private void HIIHGIOIOOI()
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

	private void NHOHGIEKNPO()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentTab;
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void EOLHGLPBMHH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().FIKELIIJIMB(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void GHJHDLIPFEK()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().PLNGJNBKNIJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void HPFOFGJPNCI()
	{
		AEPOMLHIOCN(currentTab);
	}

	private void FEDPLLHGCAA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().PLNGJNBKNIJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void NAEMKNGNGHN()
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

	private void KELFGKMAAFJ()
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

	private void DPGEHNHFHJE()
	{
		PCLHMGJAEFN(currentTab);
	}

	private void NBGIMIDICKE()
	{
		FCADHEJKDPK(currentTab);
	}

	private void CECPMNODBLA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentTab;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void KCEIJLCPNAP()
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

	public void CJEPOGFKHPK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("[Up-Right-Left]");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		FEDPLLHGCAA();
		KNGLBJONBOG();
	}

	private void FEJDJIFHLCE()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentTab;
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void PIHNIFKKBMH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().AEGJGKNOBEE(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void BBHDLIOGEHB()
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

	private void BHPBKJABNLH()
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

	private void OKLAJINHPAN()
	{
		NIFEKBKPNHD(currentTab);
	}

	private void BFLNPIIAMJA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().DDKCMOLADFN(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void AIFDDFADOHL()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().NDEEHLAJGIM(tabs.IndexOf(tab) == currentTab);
		}
	}

	public void IHGIHILOAAE(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		IGHMNAAGHPC();
		OKHOKCHDDOM();
	}

	public void KENLNCNAAIL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("Tab2Content");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		BKABIDMABHH();
		HIIHGIOIOOI();
	}

	public void GJADEBKGHAM(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Distortion_Noise");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		IGHMNAAGHPC();
		GFNHOINOHKF();
	}

	private void IDJKNBDKHBD()
	{
		GMNBIEGJHEO(currentTab);
	}

	private void OKHOKCHDDOM()
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

	private void IBEJNPBHFGH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().POPJEBPBDEA(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void KPOEHFNLKCC()
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

	private void MKKNHEJMLHI()
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

	private void PODAJNAPCHP()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentTab;
		}
	}

	public void ONPLMKDAGKC(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_Value");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EHAHDCEOOKG();
		MGLEPGDLHPO();
	}

	public void GHOPFIOCGKK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("ItemNameBGImage");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		AIFDDFADOHL();
		BNIJDEMMHBA();
	}

	private void JABNHMIHBHC()
	{
		CJEPOGFKHPK(currentTab);
	}

	private void MAGHEIAMDEG()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().NDEEHLAJGIM(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void KHKAJFOADBN()
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

	public void FOCBNINLHFL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("colorC");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		EOLHGLPBMHH();
		BHPBKJABNLH();
	}

	private void FABKIGNFECE()
	{
	}

	public void OIIAHALBLFN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("[MapsData] Found ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		APBNNKJBPGJ();
		JCOMGGPMPED();
	}

	private void HNDNDPECBPL()
	{
	}

	private void JCGMGLMADEN()
	{
	}

	private void FAHOFPKAMCB()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().PLNGJNBKNIJ(tabs.IndexOf(tab) == currentTab);
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void DFGIJDJMBID()
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

	private void FNNMDLMGDOI()
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

	private void FEHCNJLLJMP()
	{
		FOCBNINLHFL(currentTab);
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void JCOMGGPMPED()
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

	public void MPJBPOCEENB(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_Value2");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		currentTab = JMMILEFMACB;
		KBBFLFFAEJN();
		HIIHGIOIOOI();
	}
}
