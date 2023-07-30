// LevelsSelectorListElement
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class LevelsSelectorListElement : MonoBehaviour
{
	public string levelid;

	private IEnumerator GKIINNKBNAA()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void GPFJMKCGHGB()
	{
		base.transform.Find("CameraFilterPack/TV_Noise").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false;
		base.transform.Find("CameraFilterPack/FX_Hexagon").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
	}

	private void Update()
	{
		base.transform.Find("OpenButton").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("DeleteButton").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
	}

	public void LIMLHBICMPL()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void EFJDNLGNACH()
	{
	}

	private void AGMJDGHLBMN()
	{
		base.transform.Find("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("Misses:").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
	}

	private IEnumerator AIHGPLLFIBP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void MNMFCKOKKPP()
	{
		StartCoroutine(EIDAODANKGP());
	}

	private void CNGAJDBOCLJ()
	{
	}

	private IEnumerator IABOOBIAOKL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void MNBPNHNAEBK()
	{
	}

	private IEnumerator DEKKKDMNMNL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void CFIAKIJAILI()
	{
		base.transform.Find("_ScreenResolution").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("_ColorLevel").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
	}

	public void FBGMCGIKLHJ()
	{
		StartCoroutine(NAMFBBAPKEM());
	}

	private void FHGKIOOMMOH()
	{
	}

	public void FHPNIFPJKCK()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	public void JEHPPCLFENL()
	{
		StartCoroutine(JFGCNDIJOHP());
	}

	public void OnClick()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	public void OHLIPCGCMLD()
	{
		StartCoroutine(BEIEEAKINNJ());
	}

	private void AEIJFLJEABG()
	{
		base.transform.Find("#tryagain").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("CameraFilterPack/Colors_DarkColor").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true;
	}

	private void LLJLDLLNFBH()
	{
		base.transform.Find("notready").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
		base.transform.Find("didAuthenticate ").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
	}

	private IEnumerator IBICOAOJIBG()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private IEnumerator HDFCPEOPJPE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void KDMANOEMOCA()
	{
	}

	private void MMMDPANNAIO()
	{
	}

	public void KGJIHFEGPDH()
	{
		StartCoroutine(GKIINNKBNAA());
	}

	private IEnumerator POMLILLIBOI()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private IEnumerator ENNLFHLGKMC()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void POIMNOBDBBN()
	{
		base.transform.Find("_Value7").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
		base.transform.Find(" not exist").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
	}

	public void EMHMLGCCJHJ()
	{
		StartCoroutine(IBICOAOJIBG());
	}

	private void GPNAOAKCMHC()
	{
	}

	private IEnumerator CPPOOLHICFL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void CCLNNLCOPBL()
	{
	}

	private void JBNPEHMDCMI()
	{
		base.transform.Find("workshop.").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true);
		base.transform.Find("CameraFilterPack/Color_Switching").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true);
	}

	public void CPGCBNCCAOA()
	{
		StartCoroutine(EIDAODANKGP());
	}

	public void BKJHOIMIOBF()
	{
		StartCoroutine(DEKKKDMNMNL());
	}

	private IEnumerator NDBOMBCMJEL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void CMOBHGHIBKL()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void KNBJBNDGCIJ()
	{
	}

	private void Start()
	{
	}

	private IEnumerator ENEGJKOGOCL()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private IEnumerator NAMFBBAPKEM()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void NECOKPEMDKP()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void IIFCIDDJHPM()
	{
		base.transform.Find(":").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true;
		base.transform.Find("roomDescription").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
	}

	private IEnumerator JFGCNDIJOHP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void JABGIOLEKPG()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	public void CJFHNNICLEN()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void LEAHIBJDMBI()
	{
		base.transform.Find("player.bluelifering").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("Mouse1").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
	}

	public void BAEPJAFKPLE()
	{
		StartCoroutine(GKIINNKBNAA());
	}

	private void EGEGNHLODAA()
	{
		base.transform.Find("menutheme.melancholicose").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
		base.transform.Find("Can't SendMove. Turn is finished by this player.").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true);
	}

	public void DLGGEMDFGIH()
	{
		StartCoroutine(EIDAODANKGP());
	}

	public void ONNJFFAFGGN()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void JDGFCEPDKAJ()
	{
		base.transform.Find("CameraFilterPack/Color_BrightContrastSaturation").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
		base.transform.Find("_History3LumaTex").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true;
	}

	public void MCFNPLNJKBP()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).JLEFKKLJKFF(levelid);
	}

	private void FOMNCPKKCFN()
	{
		base.transform.Find("Despawn environment object by id").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
		base.transform.Find("LevelEditor/CustomEventEditor-Text").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
	}

	private void HLIAEEMGBHN()
	{
	}

	private IEnumerator EIDAODANKGP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void PDHKMDBNGGN()
	{
	}

	private void MGMAOBPPOBJ()
	{
	}

	private IEnumerator GJGPECEMPOC()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void POAKODFNAIM()
	{
		StartCoroutine(IBICOAOJIBG());
	}

	public void HKEIPOPDBLM()
	{
		StartCoroutine(GJGPECEMPOC());
	}

	private IEnumerator PPEGOJEMDOC()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void FIKFJDFELIP()
	{
	}

	public void OnDeleteClick()
	{
		StartCoroutine(POMLILLIBOI());
	}

	private void MECJHOJPODB()
	{
		base.transform.Find("#timeuntilchallenge: ").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true;
		base.transform.Find("Data/Skins/").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
	}

	private IEnumerator BEIEEAKINNJ()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}
}
