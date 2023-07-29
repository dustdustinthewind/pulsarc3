// LevelsSelectorListElement
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class LevelsSelectorListElement : MonoBehaviour
{
	public string levelid;

	private void NNCCPEBIAKH()
	{
	}

	public void CPECIABOMOL()
	{
		StartCoroutine(CPPOOLHICFL());
	}

	public void BADPFPFPGKP()
	{
		StartCoroutine(PIAMGOBOLMP());
	}

	private void DLBODOFAJGM()
	{
	}

	public void POAKODFNAIM()
	{
		StartCoroutine(MMHPCINCIJP());
	}

	private void KMCPMOGKDEH()
	{
	}

	public void HHAECEMFKND()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).BDOIODEMFHC(levelid);
	}

	public void AKEIPNLIHNL()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).EBAGFEDOKHD(levelid);
	}

	public void MIHEEHLLAND()
	{
		StartCoroutine(MMHPCINCIJP());
	}

	private void NPLCENPNJBM()
	{
	}

	private IEnumerator BLMFNJPDDIE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	public void OnClick()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(levelid);
	}

	private void Start()
	{
	}

	public void EEBOIKAPOOO()
	{
		StartCoroutine(PIAMGOBOLMP());
	}

	public void GGCLKOJPPDD()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).BDOIODEMFHC(levelid);
	}

	private void FIKFJDFELIP()
	{
	}

	public void DBDCIAIJOKG()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).EBAGFEDOKHD(levelid);
	}

	private void KLILJHJNICK()
	{
	}

	private void BGFJOEPFOPM()
	{
		base.transform.Find("play").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true;
		base.transform.Find("GameModeText").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
	}

	public void JCLEGIJAGMG()
	{
		StartCoroutine(MMHPCINCIJP());
	}

	private void DKOPKPBLDHH()
	{
	}

	private void AEIJFLJEABG()
	{
		base.transform.Find("_MainTex2").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false);
		base.transform.Find("_Offsets").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
	}

	private void Update()
	{
		base.transform.Find("OpenButton").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
		base.transform.Find("DeleteButton").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid)) ? true : false);
	}

	private void BEBNOKFLJPH()
	{
	}

	private void EPEGAEGDJAM()
	{
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

	public void DFFDCFIFCAL()
	{
		StartCoroutine(POMLILLIBOI());
	}

	private void JHPOIOELNCG()
	{
		base.transform.Find("_ScreenResolution").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) && false;
		base.transform.Find("CameraFilterPack/Colors_HUE_Rotate").gameObject.GetComponent<Button>().interactable = ((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) || true);
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

	private IEnumerator PIAMGOBOLMP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void DAHFFNNIGML()
	{
	}

	private void AGMJDGHLBMN()
	{
		base.transform.Find("caret").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
		base.transform.Find("PLEASE WAIT").gameObject.GetComponent<Button>().interactable = !((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((((LevelEditorScene)Singleton<Scene>.Instance).mapID == levelid) ? true : false);
	}

	public void OnDeleteClick()
	{
		StartCoroutine(POMLILLIBOI());
	}

	private IEnumerator MMHPCINCIJP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper()));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
	}

	private void HLIAEEMGBHN()
	{
	}
}
