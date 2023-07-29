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

	public void KBFIOEBICDG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void FLMBJPODCOH()
	{
		AGIHKJPAKDB(resourceName);
		base.transform.Find("ItemNameBGImage").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_FgCocMask").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Joystick1Button12").GetComponent<Text>().text = resourceFile;
	}

	public void PABDAJGGKNL()
	{
		StartCoroutine(NGHGKCBKOKC());
	}

	public void AAGEPOLONEJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void HFBOMJFKMDL()
	{
		StartCoroutine(NEGNGJCGKPM());
	}

	private void BBMIEEFAMLI()
	{
		MJAGEKIDPIJ(resourceName);
		base.transform.Find("Editor/").GetComponent<InputField>().text = resourceName;
		base.transform.Find("%").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_NoisePerChannel").GetComponent<Text>().text = resourceFile;
	}

	public void PIMBFCPHPPP()
	{
		StartCoroutine(GIDGOJCLNOE());
	}

	public void IBLCJKLDJFP(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator GIDGOJCLNOE()
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

	private void MADOFDPAIFH()
	{
		MJAGEKIDPIJ(resourceName);
		base.transform.Find("Set Background Color").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_TimeX").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Value4").GetComponent<Text>().text = resourceFile;
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

	public IEnumerator FBLKGDAFNBO()
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

	public void FNEKLACBDFL(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		MADOFDPAIFH();
	}

	public void POGJLIDHDIH(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		KPAFHHNLNCO();
	}

	public void AGIHKJPAKDB(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void AOEEOKNJDCK(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FGAOHKALECE();
	}

	private void JMCOKJCEMDD()
	{
		IBLCJKLDJFP(resourceName);
		base.transform.Find("Editor/").GetComponent<InputField>().text = resourceName;
		base.transform.Find("SetTrailZoomSpeed").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Set particles gravity").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator PIBMAMMIKNN()
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

	private void PMOMAAEGNNE()
	{
		AHBLGDEPBMJ(resourceName);
		base.transform.Find("CameraFilterPack_eyes_vision_1").GetComponent<InputField>().text = resourceName;
		base.transform.Find("tagElement").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("player.xp").GetComponent<Text>().text = resourceFile;
	}

	public void LBPNHCOOJBK()
	{
		StartCoroutine(DBLJBKCOJIC());
	}

	public IEnumerator HHNOAEIHLNO()
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
		PMOMAAEGNNE();
	}

	public void LOLLNPCFBLF()
	{
		StartCoroutine(LLIIHFEFJJA());
	}

	public void AGHMCBOKCCK()
	{
		StartCoroutine(HHNOAEIHLNO());
	}

	public IEnumerator CGIBJICLECE()
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

	public void GCKOLPBJANJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void FAJPCAIIKHF()
	{
		StartCoroutine(GIDGOJCLNOE());
	}

	public IEnumerator BNLAEGAHFPM()
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

	private void JKCCKDMGBAC()
	{
		LHKONPDOJGI(resourceName);
		base.transform.Find(",").GetComponent<InputField>().text = resourceName;
		base.transform.Find("masterSteamID").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("[ResourcesManager] Load audio error: ").GetComponent<Text>().text = resourceFile;
	}

	public void IDHFBNDPOIN()
	{
		StartCoroutine(ANJKGPBBHMP());
	}

	public IEnumerator LLIIHFEFJJA()
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

	private void GDAAJCJKHGB()
	{
		UpdateID(resourceName);
		base.transform.Find("IDInputField").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Icon").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("FileLabel").GetComponent<Text>().text = resourceFile;
	}

	public void Remove()
	{
		StartCoroutine(DeleteResource());
	}

	public void IFGOHEOEGKH(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		JMCOKJCEMDD();
	}

	public void BMICAMAGHKE(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void AHBLGDEPBMJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator JIHJHMIEIAN()
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

	public void EFEONCCCKNP(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		JKCCKDMGBAC();
	}

	private void HFBCONFKOFA()
	{
		GDNGFFGPLLO(resourceName);
		base.transform.Find("_Near").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_TimeX").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_EmissionGain").GetComponent<Text>().text = resourceFile;
	}

	private void BDKHAJPELCL()
	{
		UpdateID(resourceName);
		base.transform.Find("settings.shaders").GetComponent<InputField>().text = resourceName;
		base.transform.Find("editor.").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("Using constructor for new PingNativeDynamic()").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator DBLJBKCOJIC()
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

	private void FGMBDLNECAB()
	{
		AHBLGDEPBMJ(resourceName);
		base.transform.Find("Items/").GetComponent<InputField>().text = resourceName;
		base.transform.Find("inventory.selected.").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Value2").GetComponent<Text>().text = resourceFile;
	}

	public void JIFBJJHFFEA(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public IEnumerator HOHJEDHCMBN()
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

	public IEnumerator CCFIABJCBLI()
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

	public void NFKKPHKGIEI(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
	}

	public void ALKBNPMCEOM(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		JMCOKJCEMDD();
	}

	private void ABJILFDKKDA()
	{
		AGIHKJPAKDB(resourceName);
		base.transform.Find("Ev Destroy Failed. Could not find PhotonView with instantiationId ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("_Parameter").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("settings.enableranking").GetComponent<Text>().text = resourceFile;
	}

	private void DFGHDMDDDCG()
	{
		JIFBJJHFFEA(resourceName);
		base.transform.Find("The given 2D texture ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("settings_bindings_sec_").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("\n").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator NGHGKCBKOKC()
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

	public IEnumerator CJGDNHAHIFP()
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

	private void EIJFDPPIAMH()
	{
		LHKONPDOJGI(resourceName);
		base.transform.Find("_Value3").GetComponent<InputField>().text = resourceName;
		base.transform.Find("VoteUpToggle").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Threshhold").GetComponent<Text>().text = resourceFile;
	}

	public void LCOHKDBLJBH()
	{
		StartCoroutine(CJGDNHAHIFP());
	}

	public void MDPJHKECLOF(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
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

	public void NBCMDHKCOBN()
	{
		StartCoroutine(CGIBJICLECE());
	}

	private void KOEANBPOBLO()
	{
		IBLCJKLDJFP(resourceName);
		base.transform.Find("_EdgeThreshold").GetComponent<InputField>().text = resourceName;
		base.transform.Find("settings.disablestoryboard").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("ItemsUploader").GetComponent<Text>().text = resourceFile;
	}

	public void BKPLFGJCJAN()
	{
		StartCoroutine(DBLJBKCOJIC());
	}

	private void FGAOHKALECE()
	{
		AGIHKJPAKDB(resourceName);
		base.transform.Find("_Value5").GetComponent<InputField>().text = resourceName;
		base.transform.Find("#{0:00} '{1}'{2} {3}").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("ItemTemplate").GetComponent<Text>().text = resourceFile;
	}

	private void DHCJFBNIIAK()
	{
		UpdateID(resourceName);
		base.transform.Find("CameraFilterPack/Colors_BleachBypass").GetComponent<InputField>().text = resourceName;
		base.transform.Find("CameraFilterPack/TV_Old_Movie").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("[SoundManager] Loaded skin audio").GetComponent<Text>().text = resourceFile;
	}

	public IEnumerator NEGNGJCGKPM()
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

	public void MIAIEKCLEAO(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FGMBDLNECAB();
	}

	public void Init(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
	}

	public void CFLMNNKKCPG(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void MJAGEKIDPIJ(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	private void KCANHOPLEDI()
	{
		ILACAJGMINP(resourceName);
		base.transform.Find("[MapsStats] Max score: ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Called GetNumberOfCurrentPlayers()").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_MainTex").GetComponent<Text>().text = resourceFile;
	}

	public void LHKONPDOJGI(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void BFMEBNFGCEA(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		GDAAJCJKHGB();
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

	public void OPKKBMCDOEM(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		BBMIEEFAMLI();
	}

	public void HHKILLPKCCE()
	{
		StartCoroutine(LLIIHFEFJJA());
	}

	public IEnumerator ANJKGPBBHMP()
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

	public void BKEFJPOHKDE(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		MADOFDPAIFH();
	}

	public IEnumerator EILNOMOAOHN()
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

	public void GDNGFFGPLLO(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void ILACAJGMINP(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void HBKEHHCMMBN(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FGMBDLNECAB();
	}

	public void NKLCNJEIAFB(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		BDKHAJPELCL();
	}

	public void FAMABONDNDB()
	{
		StartCoroutine(NEGNGJCGKPM());
	}

	private void IGNNPJBKBNM()
	{
		AAGEPOLONEJ(resourceName);
		base.transform.Find(" respawn: ").GetComponent<InputField>().text = resourceName;
		base.transform.Find("Player Disconnected").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("SpeedSlider").GetComponent<Text>().text = resourceFile;
	}

	private void KPAFHHNLNCO()
	{
		HKEFJGFEKHF(resourceName);
		base.transform.Find("CameraFilterPack/Lut_PlayWith").GetComponent<InputField>().text = resourceName;
		base.transform.Find("settings.gamemessagesduration").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("_Far").GetComponent<Text>().text = resourceFile;
	}

	private void HLCBCAHLIAI()
	{
		KBFIOEBICDG(resourceName);
		base.transform.Find("SpeedSlider").GetComponent<InputField>().text = resourceName;
		base.transform.Find("HiddenToggle").GetComponent<Image>().sprite = (Sprite)resource;
		base.transform.Find("ERROR: preview file name is empty in modName.workshop.json").GetComponent<Text>().text = resourceFile;
	}

	public void EKAAMBFENNM()
	{
		StartCoroutine(BNLAEGAHFPM());
	}

	public void CAPLMPPEHHF(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void NKLNGGOHLMO(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		FLMBJPODCOH();
	}

	public void UpdateID(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}

	public void LDKFAGOEDKF(string LKHGHBMAFEL, string KFCPKFBCONE, Object ACABBJEAMGG)
	{
		resourceName = LKHGHBMAFEL;
		resourceFile = KFCPKFBCONE;
		resource = ACABBJEAMGG;
		BDKHAJPELCL();
	}

	public void HKEFJGFEKHF(string LGHIPFAEONM)
	{
		resourceName = LGHIPFAEONM;
	}
}
