// ResourceListElement
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ResourceListElement : MonoBehaviour
{
	[HideInInspector]
	public Object resource;

	public string resourceName;

	public string resourceFile;

	public void FOLMBEGHIKG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator GAILBIBNJNM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void HKEFJGFEKHF(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void IGCBIGBMDCM()
	{
		StartCoroutine(GAILBIBNJNM());
	}

	public void CDDHLFNJOGC(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FJCDDAOBPNI();
	}

	private void FNEJEBGMKKJ()
	{
		FFBGAAJIEPG(resourceName);
		base.transform.Find("_Value2").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_FixDistance").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("0.00").GetComponent<Text>().text = resourceFile;
	}

	private void BFNMJNJEAJH()
	{
		MOGIDDKBJJN(resourceName);
		base.transform.Find("_SpawnHeuristic").GetComponent<InputField>().text = resourceName;
		base.transform.Find("-").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("maps.").GetComponent<Text>().text = resourceFile;
	}

	public void AFIJKLKEGEJ()
	{
		StartCoroutine(LIPLCCPHAJM());
	}

	public void MGLBFNMMNEO(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void GAABNLAMEHO()
	{
		POALFOOMJJO(resourceName);
		base.transform.Find("_ScreenResolution").GetComponent<InputField>().text = resourceName;
		base.transform.Find(": ").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_ScreenResolution").GetComponent<Text>().text = resourceFile;
	}

	public void GAJEPOEIOPP(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		IPMOLBHAPOG();
	}

	private void OFBAMGMNJOF()
	{
		DHDJPAMOHMK(resourceName);
		base.transform.Find("float").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_Value2").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("HandsCountSlider").GetComponent<Text>().text = resourceFile;
	}

	public void HBKEHHCMMBN(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		HHAJFDIEEAI();
	}

	public void LKEPIEEIMAE(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		KPLNLHJHALC();
	}

	private void MDCICPIELCA()
	{
		OENOOCKAPAG(resourceName);
		base.transform.Find("_TimeX").GetComponent<InputField>().text = resourceName;
		base.transform.Find("[Sound Manager] Audio clip is null, cannot play sound").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Anime").GetComponent<Text>().text = resourceFile;
	}

	public void ONPMGHLGIIL(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator MKPBHEEDCOB()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void BBICIPNPMLL(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		MDCICPIELCA();
	}

	private void LECIJJACADA()
	{
		FOLMBEGHIKG(resourceName);
		base.transform.Find("mapselector.tags.").GetComponent<InputField>().text = resourceName;
		base.transform.Find("No").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("/").GetComponent<Text>().text = resourceFile;
	}

	private void FGAOHKALECE()
	{
		OENOOCKAPAG(resourceName);
		base.transform.Find("Text").GetComponent<InputField>().text = resourceName;
		base.transform.Find("/").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Vibrance").GetComponent<Text>().text = resourceFile;
	}

	private void FJCDDAOBPNI()
	{
		PIGDIALHDLD(resourceName);
		base.transform.Find("_NeutralTonemapperParams1").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Drop_With_Obj").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Value6").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator AOEFOGHDFPB()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void KDJCHFJGNMD(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void GPEBNLPOOEF()
	{
		KDJCHFJGNMD(resourceName);
		base.transform.Find("ready").GetComponent<InputField>().text = resourceName;
		base.transform.Find("shader.future").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find(".lastCheckpoint.correctScore").GetComponent<Text>().text = resourceFile;
	}

	public void UpdateID(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void LMJPBOFPGMI()
	{
		StartCoroutine(GDJFMIAPDCE());
	}

	public void POGJLIDHDIH(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FNEJEBGMKKJ();
	}

	public void ANMBLEPCFCA()
	{
		StartCoroutine(KMFGNCLIICD());
	}

	public void MIAIEKCLEAO(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		PNKLKNCABBE();
	}

	public IEnumerator FENMOIIGAFO()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator LIPLCCPHAJM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void DGCNBJJMPAJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator CLOKCEEAPBC()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void GOABPDBLDAM()
	{
		StartCoroutine(PMFLOMNNEPJ());
	}

	public void AAGEPOLONEJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void HOEINHFMLNE(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator IHBPFBNGFND()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	private void IPMOLBHAPOG()
	{
		MOGIDDKBJJN(resourceName);
		base.transform.Find("CameraFilterPack/Light_Rainbow2").GetComponent<InputField>().text = resourceName;
		base.transform.Find(" By: ").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("SendVacantViewIds()").GetComponent<Text>().text = resourceFile;
	}

	public void MOGIDDKBJJN(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void GGAJGNAFABH()
	{
		DGCNBJJMPAJ(resourceName);
		base.transform.Find("[PlayerController] ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("AddEnvironmentObject").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_TimeX").GetComponent<Text>().text = resourceFile;
	}

	public void CGDGFPOHPPE()
	{
		StartCoroutine(CNICFGEINEN());
	}

	public IEnumerator GDJFMIAPDCE()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void NKINFKJBCJA()
	{
		StartCoroutine(HIFNMPKLJHM());
	}

	public void BECBCECGHPA(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FLJCPHNHNEI();
	}

	public void MDPJHKECLOF(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		HHAJFDIEEAI();
	}

	public IEnumerator HGIMKGIJLDH()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator HEBMMNOCPIL()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator DHHOHMPMMMM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void FFBDGOBNNCO(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		ELBPPGGENEP();
	}

	private void KPLNLHJHALC()
	{
		CAFDHDCMKGO(resourceName);
		base.transform.Find("ready").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_BlurRadius4").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("settings.volume.sfx").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator CMABICEBCGO()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void LMHFEBCKPDI(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		BFNMJNJEAJH();
	}

	public void FFBGAAJIEPG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void FHKNLCPLANG()
	{
		StartCoroutine(OIHEPPDICOA());
	}

	public IEnumerator OIHEPPDICOA()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void LBPNHCOOJBK()
	{
		StartCoroutine(AOEFOGHDFPB());
	}

	public IEnumerator DeleteResource()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	private void PNKLKNCABBE()
	{
		ONPMGHLGIIL(resourceName);
		base.transform.Find(" to: ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Created by ").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Joystick1Button9").GetComponent<Text>().text = resourceFile;
	}

	public void HGMCIDEMOOG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void POKCDHHNOKP()
	{
		StartCoroutine(CNICFGEINEN());
	}

	public void PJILLPKFCPO(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FNEJEBGMKKJ();
	}

	private void MCDKDHKBBIB()
	{
		BCKGKHPJKNL(resourceName);
		base.transform.Find("caret").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_Value5").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("ERROR You should never change PhotonPlayer IDs!").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator PDFNDDOLHKK()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	private void HHAJFDIEEAI()
	{
		MGLBFNMMNEO(resourceName);
		base.transform.Find("CameraFilterPack/Drawing_EnhancedComics").GetComponent<InputField>().text = resourceName;
		base.transform.Find("/").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("menu.selectedlevelid").GetComponent<Text>().text = resourceFile;
	}

	private void DOAOLALMBFL()
	{
		ABKLGHFCAEK(resourceName);
		base.transform.Find("Hidden/Image Effects/Cinematic/Bloom").GetComponent<InputField>().text = resourceName;
		base.transform.Find("DISTORT").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("id").GetComponent<Text>().text = resourceFile;
	}

	public void BMICAMAGHKE(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void CMFBCPNHGOF(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		PNKLKNCABBE();
	}

	public IEnumerator BDAMMKMNGJM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void BCKGKHPJKNL(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void OENOOCKAPAG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void BKLCHHKOMLD(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		KPLNLHJHALC();
	}

	private void JMPPLBPNEMM()
	{
		JIFBJJHFFEA(resourceName);
		base.transform.Find(".played").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_ScreenResolution").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("^").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator NLIKDNBCDIK()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void JIFBJJHFFEA(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void KJBJBNGJDAD(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		MDCICPIELCA();
	}

	public void ABKLGHFCAEK(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator HIFNMPKLJHM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	private void ELBPPGGENEP()
	{
		EEBLJIPMGEG(resourceName);
		base.transform.Find("/").GetComponent<InputField>().text = resourceName;
		base.transform.Find(".lastCheckpoint.isMapCompleted").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_FresnelFadePower").GetComponent<Text>().text = resourceFile;
	}

	private void FLJCPHNHNEI()
	{
		EEBLJIPMGEG(resourceName);
		base.transform.Find("music").GetComponent<InputField>().text = resourceName;
		base.transform.Find("workshop.").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Set Crosshair Emission").GetComponent<Text>().text = resourceFile;
	}

	public void ENBPPNKJIFD()
	{
		StartCoroutine(PDFNDDOLHKK());
	}

	public void LFIPFEODMOP(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator AGNPFJNNOEJ()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void GINPIKEJGJD(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GGAJGNAFABH();
	}

	public void PIGDIALHDLD(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void EEKAJCCELHK(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		MDCICPIELCA();
	}

	public void DHDJPAMOHMK(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void HDOMPNBHKJK()
	{
		StartCoroutine(AGNPFJNNOEJ());
	}

	public void HINJNBJFGHD(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		BFNMJNJEAJH();
	}

	public void MIGFOIJJJNL(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FNEJEBGMKKJ();
	}

	public void Remove()
	{
		StartCoroutine(DeleteResource());
	}

	public void CPJHNDOBFOD(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FJCDDAOBPNI();
	}

	public IEnumerator HIELIKKJIOL()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator PMFLOMNNEPJ()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	private void HBKAODNBDIN()
	{
		MGLBFNMMNEO(resourceName);
		base.transform.Find("{0:0} day{1}, ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("CameraFilterPack/Color_Switching").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("11").GetComponent<Text>().text = resourceFile;
	}

	public void KJADFPLOFKA()
	{
		StartCoroutine(GDJFMIAPDCE());
	}

	private void NAKHKPMHOIP()
	{
		JIFBJJHFFEA(resourceName);
		base.transform.Find("ScoreText").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Editor/").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Fade").GetComponent<Text>().text = resourceFile;
	}

	public void Init(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
	}

	public void JKHKHOIHLOI(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
	}

	public void NFKDBPGHHIJ(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FJCDDAOBPNI();
	}

	public void FNEKLACBDFL(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		COAEFBOMCJI();
	}

	public void DKOODMGKPHI(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator BHGMOEMKHJI()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator EPPOFLFBHCJ()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator CNICFGEINEN()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void CPFOEFKOJGA(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FJCDDAOBPNI();
	}

	public void PBBDHIFJHHC(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		ELBPPGGENEP();
	}

	private void GDAAJCJKHGB()
	{
		UpdateID(resourceName);
		base.transform.Find("IDInputField").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Icon").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("FileLabel").GetComponent<Text>().text = resourceFile;
	}

	public void POALFOOMJJO(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void IOFGNLOOGKH(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void EKOAKKNGGGI(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		DOAOLALMBFL();
	}

	public void KAJBOALBHEC(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void MOKHHEMAJBJ(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		HBKAODNBDIN();
	}

	public IEnumerator PGHINDJPFEC()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void EJLKPLOEEEP(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		NAKHKPMHOIP();
	}

	private void IGAFFIIEFLE()
	{
		BMICAMAGHKE(resourceName);
		base.transform.Find("gamemode").GetComponent<InputField>().text = resourceName;
		base.transform.Find(".lastCheckpoint.bgcolor").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("true").GetComponent<Text>().text = resourceFile;
	}

	public void EEBLJIPMGEG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void BKPHIAOFMEI()
	{
		StartCoroutine(PDFNDDOLHKK());
	}

	public IEnumerator PEMFKCPCCEC()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void ECCKDHJGLNE()
	{
		StartCoroutine(PGHINDJPFEC());
	}

	public IEnumerator ADLEFFJCFBM()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public IEnumerator KMFGNCLIICD()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == resourceName));
		yield return StartCoroutine(Singleton<MapEditor>.Instance.Save(false));
		yield return StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
	}

	public void CAFDHDCMKGO(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void COAEFBOMCJI()
	{
		DHDJPAMOHMK(resourceName);
		base.transform.Find("Sep").GetComponent<InputField>().text = resourceName;
		base.transform.Find("CameraFilterPack/Antialiasing_FXAA").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("InputField").GetComponent<Text>().text = resourceFile;
	}
}
