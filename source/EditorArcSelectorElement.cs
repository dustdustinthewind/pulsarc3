// EditorArcSelectorElement
using UnityEngine;
using UnityEngine.UI;

public class EditorArcSelectorElement : MonoBehaviour
{
	public CustomEventEditorHandler_ArcSelector arcSelector;

	public int id;

	public void PANBFBFFGBG()
	{
		Object.Destroy(base.gameObject);
	}

	private void KCDOMIJBFLL()
	{
	}

	private void MMOKKAPFGAK()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Down")[id];
		}
	}

	public void EDJEGDPCBGO()
	{
		arcSelector.Selected(id);
	}

	public void OnAddButton()
	{
	}

	public void DIOECAJGBPC()
	{
		KGEPBJDPEJJ();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1309f, 1929f, 1546f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "settings.volume.game";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1304f, 94f, 1549f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("SetRotation");
	}

	public void OHHKBBGEJEB()
	{
		Object.Destroy(base.gameObject);
	}

	public void CHAJBMMEOFC()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	public void NAAMBLOKPOD()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	private void FJNCHGLIEMA()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_BlurCoe")[id];
		}
	}

	public void LJEHFEDFMID()
	{
		Object.Destroy(base.gameObject);
	}

	public void LBIHKHBFONK()
	{
		Object.Destroy(base.gameObject);
	}

	private void NEKCPLGFOFD()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	public void IADBAMIBOCG()
	{
	}

	private void DBLILJGKGHJ()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[id];
		}
	}

	public void OnSelect()
	{
		arcSelector.Selected(id);
	}

	private void DBEMDAJDDDA()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Texture2")[id];
		}
	}

	private void EFJDNLGNACH()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[id];
		}
	}

	private void KLILJHJNICK()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("settings.arcsdestroydelay")[id];
		}
	}

	public void IGFHKCKCHNH()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	public void OnAddNewUnlockConditionButton()
	{
		OnDeleteButton();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "addNewButton";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added unlock condition");
	}

	private void PDHKMDBNGGN()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Near")[id];
		}
	}

	public void DCLPCNFIHHJ()
	{
		MDKEGDLADCD();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(973f, 435f, 1623f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "CameraFilterPack/FX_DigitalMatrix";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(904f, 1053f, 347f);
		Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("CameraFilterPack/Blend2Camera_VividLight");
	}

	public void KKJAHGFGAON()
	{
	}

	private void HAIAHJPCPAG()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Params1")[id];
		}
	}

	public void NGFLLEFBINA()
	{
		arcSelector.EKHMANFCAEI(id);
	}

	public void HEAPABJGJKB()
	{
		arcSelector.Selected(id);
	}

	public void CGKBDCFNNIH()
	{
		Object.Destroy(base.gameObject);
	}

	public void BNIAEJMIIGG()
	{
		LBIHKHBFONK();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(162f, 420f, 1516f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "GlassesColor";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(667f, 1285f, 958f);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("skin.", true);
	}

	public void JIFHCFLKKJH()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	public void IKKGNBAIHEN()
	{
		arcSelector.NLDJECMCEOO(id);
	}

	private void MMMDPANNAIO()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("GameScene")[id];
		}
	}

	private void IDJKNBDKHBD()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Blend2Camera_Subtract")[id];
		}
	}

	public void GJCADLOBGIK()
	{
	}

	public void GOIDNMINHHD()
	{
		Object.Destroy(base.gameObject);
	}

	public void BEOEODBNOIF()
	{
		Object.Destroy(base.gameObject);
	}

	public void AOPGPLHJMCN()
	{
		GOIDNMINHHD();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(634f, 1911f, 266f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "0.00";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1549f, 49f, 893f);
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("inventory.selected.");
	}

	public void DDHANCKCMHB()
	{
	}

	public void OnDeleteButton()
	{
		Object.Destroy(base.gameObject);
	}

	public void MDKEGDLADCD()
	{
		Object.Destroy(base.gameObject);
	}

	private void NCNPAKFAFOE()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("PointsScoreText")[id];
		}
	}

	public void LICIIFLDHLM()
	{
		Object.Destroy(base.gameObject);
	}

	public void BDCOOFEBPAE()
	{
	}

	public void AFPGEBNCAKO()
	{
		Object.Destroy(base.gameObject);
	}

	public void JMKAIBBEOND()
	{
		arcSelector.NLDJECMCEOO(id);
	}

	public void ANIHADFHFEH()
	{
	}

	public void PNLBOAOMDGI()
	{
		Object.Destroy(base.gameObject);
	}

	private void JKBMKPDGCHG()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_DistortionSize")[id];
		}
	}

	public void PHBKNJHOAKE()
	{
		LICIIFLDHLM();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1333f, 286f, 1335f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = " is not supported on this platform!";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(102f, 1572f, 1645f);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("settings.arcsdestroydelay", true);
	}

	public void DOOFFFLOMIE()
	{
		PNLBOAOMDGI();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(336f, 757f, 104f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_NeighbourMaxTex";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(734f, 1203f, 319f);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_Value3", true);
	}

	private void HIPEHGNBJMN()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("true")[id];
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	public void CBPBCKDFDMO()
	{
		arcSelector.NLDJECMCEOO(id);
	}

	private void KMEONPMCNJG()
	{
	}

	private void ILCFPCIPENO()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Min")[id];
		}
	}

	public void GCMILINAEAG()
	{
	}

	private void Update()
	{
	}

	public void OJMCAHMAHHD()
	{
	}

	private void MKIMDFLBFOM()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("SelectorMapsCountSlider")[id];
		}
	}

	public void OJJJICOBEBM()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	private void JBCNIPJDPJB()
	{
	}

	private void JHANGPCOCIG()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Offsets")[id];
		}
	}

	public void IKIOOGDKGGC()
	{
	}

	private void FIKFJDFELIP()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[id];
		}
	}

	public void OFEPLDCHBOL()
	{
	}

	private void EPEGAEGDJAM()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/FX_8bits")[id];
		}
	}

	private void Start()
	{
		if (id >= 0)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[id];
		}
	}

	public void BPGEOHOCCDH()
	{
	}

	private void PMPKMGKAAJH()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Luminance")[id];
		}
	}

	private void JONGNKNLLND()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>(".lastCheckpoint.currentCombo")[id];
		}
	}

	public void BHMDEODGBBO()
	{
		Object.Destroy(base.gameObject);
	}

	private void NKLIHNJCHOG()
	{
	}

	public void NIJNGHIPGIC()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void JMEOGJHCONJ()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("no lives color")[id];
		}
	}

	public void GIOEPMNDEFK()
	{
		PANBFBFFGBG();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(253f, 1296f, 1505f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_Value4";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(50f, 663f, 749f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("HiddenToggle", true);
	}

	public void KGEIMFFMPDD()
	{
		arcSelector.DMIJDKKPBMJ(id);
	}

	public void KGEPBJDPEJJ()
	{
		Object.Destroy(base.gameObject);
	}

	private void HLIAEEMGBHN()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("ticket.ticket1")[id];
		}
	}

	public void PKMMDOGFAEJ()
	{
		BHMDEODGBBO();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1136f, 1319f, 449f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "&page=";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(301f, 484f, 240f);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Most likely the game became empty during the switch to GameServer.");
	}

	public void NMCEFIBPBNK()
	{
		OHHKBBGEJEB();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1761f, 24f, 357f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "ready";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1217f, 797f, 1477f);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Texture2");
	}

	private void OHFOLGANOLC()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Vignetting2")[id];
		}
	}

	public void KNIHFOEIJEN()
	{
		AFPGEBNCAKO();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1999f, 1907f, 1229f);
		GameObject gameObject2 = Object.Instantiate(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_Value3";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(45f, 714f, 1357f);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("challenges.", true);
	}

	private void GPFJMKCGHGB()
	{
	}

	private void DKOPKPBLDHH()
	{
		if (id >= 1)
		{
			GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("[PlayerBase] Loading checkpoint data")[id];
		}
	}
}
