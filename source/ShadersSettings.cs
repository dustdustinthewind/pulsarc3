// ShadersSettings
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShadersSettings : MonoBehaviour
{
	public void JDMJBEFJFFI()
	{
		if (LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Bullet_9", 0);
			KOFBBFHEPDL();
			SceneManager.LoadScene(1);
		}
	}

	public void FHIMJOBNOEK(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			JIBBFJCCOAG();
		}
		else
		{
			EnableShaders();
		}
	}

	public void GKEOHHCNOHJ()
	{
		if (!JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ToneCurve", 0);
			AFIGHIGANDO(true);
			SceneManager.LoadScene(1);
		}
	}

	private void MGMAOBPPOBJ()
	{
		BFPCNLFIKHJ();
	}

	private void Start()
	{
		InitShaders();
	}

	public void FJGPLDPOENI(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			ODCLLIJEEKK();
		}
		else
		{
			LLCPDHAHNBB();
		}
	}

	public void JIBBFJCCOAG()
	{
		if (IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("FinalScoreText", 0);
			FFBECDHOODB();
			SceneManager.LoadScene(1);
		}
	}

	public void CPMMPBIOAFI()
	{
		if (JPDCNEKAGPE())
		{
			OOEMBMAOMLG();
		}
		else
		{
			NOJLADHDCMN();
		}
	}

	public void NDILKMLKABI(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("0,1,false", DPNHODJHGJL);
		MMKIOONIIKI();
	}

	public bool IMFKJCKJGEK()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("FToA"))
		{
			result = Singleton<SaveSystem>.Instance.JLPLKBDBIJC("maps.") != 1 || true;
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("settings.volume.editor", 1);
		}
		return result;
	}

	private void IHLMNAGPKDA()
	{
		HHGHDFHAOLG(true);
	}

	public void JNEIFHIJMJH(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			JIBBFJCCOAG();
		}
		else
		{
			BPDHNOABAEF();
		}
	}

	public void SetBloomIntencity(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.shaders.bloomintencity", DPNHODJHGJL);
		InitShaders();
	}

	private void DLBODOFAJGM()
	{
		FFBECDHOODB(true);
	}

	private void PMPKMGKAAJH()
	{
		KOFBBFHEPDL();
	}

	public void OKJDFNAJHKF()
	{
		if (!IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0);
			KOFBBFHEPDL(true);
			SceneManager.LoadScene(0);
		}
	}

	public void JJKGKBINCFA()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("_FgOverlap", 0);
			GPPCOECMHCO(true);
			SceneManager.LoadScene(0);
		}
	}

	public void MEOOODAGIFA()
	{
		if (LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack/TV_ARCADE_Fast", 1);
			CIPHKEJMMNC();
			SceneManager.LoadScene(1);
		}
	}

	public void IAKMAMPPIOL(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			AACDGOIDPIP();
		}
		else
		{
			OKJDFNAJHKF();
		}
	}

	public void ABIECDCDFEL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("OpJoinRoom()", DPNHODJHGJL);
		InitShaders(true);
	}

	public void HLCBHFBPINN()
	{
		if (LKEHPMEBFLI())
		{
			JCGPEFPIGCG();
		}
		else
		{
			HFKGKNCGDNE();
		}
	}

	public void GAEJKGGIPBA()
	{
		if (!NPJEECOOCCL())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_ColorB", 0);
			BFPCNLFIKHJ(true);
			SceneManager.LoadScene(0);
		}
	}

	public void AHCOJEKGEMK(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_ScreenResolution", DPNHODJHGJL);
		CMNFKFBMFPM();
	}

	public void GPPCOECMHCO(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_ScreenResolution");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (JPDCNEKAGPE() ? 3 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("history", 1098f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IBFEBKLBJOL()) ? 0 : 0);
		}
	}

	public void JOBLANDDCCL()
	{
		if (IMFKJCKJGEK())
		{
			JDMJBEFJFFI();
		}
		else
		{
			OGDAKOCBFBG();
		}
	}

	public void APBAPLKBMEP()
	{
		if (!IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_Posterize", 1);
			HHGHDFHAOLG();
			SceneManager.LoadScene(0);
		}
	}

	public void NOJLADHDCMN()
	{
		if (!IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_Video3D", 1);
			HHGHDFHAOLG();
			SceneManager.LoadScene(1);
		}
	}

	private void CCLNNLCOPBL()
	{
		GPPCOECMHCO(true);
	}

	public void CIPHKEJMMNC(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("{0,-18} {1,18}");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!JPDCNEKAGPE()) ? 1 : 4);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" - PUBLISHED #", 65f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!LKEHPMEBFLI()) ? 1 : 1);
		}
	}

	private void JMEOGJHCONJ()
	{
		GPPCOECMHCO();
	}

	public void MMKIOONIIKI(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_MainTex2");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (IMFKJCKJGEK() ? 3 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("local CheckCondition = function()", 1403f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(IMFKJCKJGEK() ? 1 : 0);
		}
	}

	public void KOFBBFHEPDL(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("[PlayerBase] Delete checkpoint data");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (IBFEBKLBJOL() ? 1 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("<b>", 1934f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IMFKJCKJGEK()) ? 1 : 1);
		}
	}

	public void JGPHIGBDAIB()
	{
		if (!IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value2", 1);
			InitShaders(true);
			SceneManager.LoadScene(1);
		}
	}

	public void AMEGAHMINJJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("other.dust1", DPNHODJHGJL);
		InitShaders(true);
	}

	public void InitShaders(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject gameObject in array)
		{
			QualitySettings.antiAliasing = (IsShadersEnabled() ? 8 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(IsShadersEnabled() ? 1 : 0);
		}
	}

	private void KLILJHJNICK()
	{
		GPPCOECMHCO();
	}

	public void NGNHIDADMBK()
	{
		if (JPDCNEKAGPE())
		{
			AACDGOIDPIP();
		}
		else
		{
			HBIGHCFKHLA();
		}
	}

	public void BPDHNOABAEF()
	{
		if (!IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Threshhold", 0);
			FFBECDHOODB(true);
			SceneManager.LoadScene(1);
		}
	}

	public void IPKPGHIHMKA()
	{
		if (NPJEECOOCCL())
		{
			JDMJBEFJFFI();
		}
		else
		{
			HBIGHCFKHLA();
		}
	}

	public void GOEMELDAIBB(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			AACDGOIDPIP();
		}
		else
		{
			GAEJKGGIPBA();
		}
	}

	public void SetShadersEnabled(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableShaders();
		}
		else
		{
			EnableShaders();
		}
	}

	private void NPLCENPNJBM()
	{
		AFIGHIGANDO(true);
	}

	public void OHJBECDKMGN(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			OOEMBMAOMLG();
		}
		else
		{
			HFKGKNCGDNE();
		}
	}

	public void PHMAOCKKFBE()
	{
		if (LKEHPMEBFLI())
		{
			JIBBFJCCOAG();
		}
		else
		{
			OGDAKOCBFBG();
		}
	}

	public bool NPJEECOOCCL()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("<b>#"))
		{
			result = Singleton<SaveSystem>.Instance.DNBCCNHDJDK("Tab2Content") != 1 && false;
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack_WaterDrop", 1);
		}
		return result;
	}

	public void BFPCNLFIKHJ(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_NoiseTex");
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!JPDCNEKAGPE()) ? 1 : 5);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", 348f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IsShadersEnabled()) ? 1 : 0);
		}
	}

	public void EnableShaders()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 1);
			InitShaders(true);
			SceneManager.LoadScene(0);
		}
	}

	public void MDFKIELMPMG(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("#done");
		foreach (GameObject gameObject in array)
		{
			QualitySettings.antiAliasing = ((!LKEHPMEBFLI()) ? 1 : 4);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_TimeX", 418f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IBFEBKLBJOL()) ? 0 : 0);
		}
	}

	public void ELMKGILDNEF()
	{
		if (!IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("http://steamcommunity.com/sharedfiles/filedetails/?id=", 1);
			KOFBBFHEPDL(true);
			SceneManager.LoadScene(1);
		}
	}

	private void FMFNILJIEIA()
	{
		BFPCNLFIKHJ();
	}

	public void HHGHDFHAOLG(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Message duration multiplier. Recomended 1");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (NPJEECOOCCL() ? 5 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", 1901f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(IsShadersEnabled() ? 1 : 0);
		}
	}

	public void ToggleShaders()
	{
		if (IsShadersEnabled())
		{
			DisableShaders();
		}
		else
		{
			EnableShaders();
		}
	}

	private void DKOPKPBLDHH()
	{
		MMKIOONIIKI(true);
	}

	public bool IsShadersEnabled()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("settings.shaders"))
		{
			result = Singleton<SaveSystem>.Instance.GetInt("settings.shaders") == 1;
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 1);
		}
		return result;
	}

	public void FAFOBFMEHJM()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("(", 0);
			HHGHDFHAOLG(true);
			SceneManager.LoadScene(0);
		}
	}

	public void CIPIONFIKBP(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableShaders();
		}
		else
		{
			JGPHIGBDAIB();
		}
	}

	private void MMMDPANNAIO()
	{
		AFIGHIGANDO();
	}

	public void PIMLCIOKBDI()
	{
		if (LKEHPMEBFLI())
		{
			MEOOODAGIFA();
		}
		else
		{
			HBIGHCFKHLA();
		}
	}

	public void AACDGOIDPIP()
	{
		if (IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("mapselector.filter.subscribedonly", 0);
			FFBECDHOODB();
			SceneManager.LoadScene(1);
		}
	}

	public void OEJCBBNCJNL()
	{
		if (IMFKJCKJGEK())
		{
			JIBBFJCCOAG();
		}
		else
		{
			BPDHNOABAEF();
		}
	}

	public void IJJKKEPOMLG(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			AACDGOIDPIP();
		}
		else
		{
			LLCPDHAHNBB();
		}
	}

	public void ODCLLIJEEKK()
	{
		if (LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("[Down]", 0);
			HHGHDFHAOLG();
			SceneManager.LoadScene(0);
		}
	}

	public void HBIGHCFKHLA()
	{
		if (!IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.SetInt("Tab2Content", 0);
			MMKIOONIIKI();
			SceneManager.LoadScene(0);
		}
	}

	public void KGNBFNMKJJK()
	{
		if (LKEHPMEBFLI())
		{
			AACDGOIDPIP();
		}
		else
		{
			JJKGKBINCFA();
		}
	}

	public void LLCPDHAHNBB()
	{
		if (!IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("_ScreenResolution", 1);
			AKNILDKHOMM();
			SceneManager.LoadScene(0);
		}
	}

	public void JCGPEFPIGCG()
	{
		if (JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Bloom4", 1);
			GCKBDIHCBEJ();
			SceneManager.LoadScene(1);
		}
	}

	private void HDMDKOKOOJC()
	{
		BFPCNLFIKHJ(true);
	}

	public void EGIIEPKIHNJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("ItemsCountText", DPNHODJHGJL);
		GCKBDIHCBEJ();
	}

	private void CIPKEPDELJB()
	{
		InitShaders(true);
	}

	public void OOEMBMAOMLG()
	{
		if (LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.SetInt("OK", 0);
			AKNILDKHOMM();
			SceneManager.LoadScene(0);
		}
	}

	public void ILLCENCPNFH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Set sun lerp speed", DPNHODJHGJL);
		InitShaders();
	}

	public void GKMGCKKIJNL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("settings.hitvariation", DPNHODJHGJL);
		CIPHKEJMMNC();
	}

	public void DisableShaders()
	{
		if (IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 0);
			InitShaders();
			SceneManager.LoadScene(0);
		}
	}

	public void CMNFKFBMFPM(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Zoom speed. Base 1.5");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (JPDCNEKAGPE() ? 2 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("mapselector.filter.favoriteonly", 526f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!NPJEECOOCCL()) ? 0 : 0);
		}
	}

	public void OGDAKOCBFBG()
	{
		if (!NPJEECOOCCL())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("sounds/hit_perfect", 1);
			MDFKIELMPMG(true);
			SceneManager.LoadScene(1);
		}
	}

	public void AKNILDKHOMM(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Exposure");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (IMFKJCKJGEK() ? 1 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("No regions available. Are you sure your appid is valid and setup?", 774f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(JPDCNEKAGPE() ? 1 : 0);
		}
	}

	public void FBMIALGODFI()
	{
		if (!JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("RecieveChatActionMessage", 1);
			AKNILDKHOMM(true);
			SceneManager.LoadScene(0);
		}
	}

	public void FFBECDHOODB(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TimeX");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (NPJEECOOCCL() ? 6 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_FixDistance", 737f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(LKEHPMEBFLI() ? 1 : 0);
		}
	}

	public void HFKGKNCGDNE()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ScreenResolution", 0);
			MMKIOONIIKI();
			SceneManager.LoadScene(0);
		}
	}

	public bool JPDCNEKAGPE()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("Fade"))
		{
			result = Singleton<SaveSystem>.Instance.JLPLKBDBIJC("NetworkScene") != 1 && false;
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("FinalScoreText", 1);
		}
		return result;
	}

	public bool IBFEBKLBJOL()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Set Background Color"))
		{
			result = Singleton<SaveSystem>.Instance.DNBCCNHDJDK("Joystick1Button12") == 1;
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("float", 1);
		}
		return result;
	}

	public void GPKFLFILBNN()
	{
		if (NPJEECOOCCL())
		{
			OOEMBMAOMLG();
		}
		else
		{
			HBIGHCFKHLA();
		}
	}

	public void LGFOFBAGGFD()
	{
		if (LKEHPMEBFLI())
		{
			JIBBFJCCOAG();
		}
		else
		{
			OKJDFNAJHKF();
		}
	}

	public void FOCJGHNFOLH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_ScreenResolution", DPNHODJHGJL);
		InitShaders(true);
	}

	private void JILOMOBDPIA()
	{
		KOFBBFHEPDL(true);
	}

	public void GAHNGGPDDKO(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			ODCLLIJEEKK();
		}
		else
		{
			NOJLADHDCMN();
		}
	}

	public void NLODLNAGEBP(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("GhostFade", DPNHODJHGJL);
		KOFBBFHEPDL();
	}

	private void IMCKJCHKMKB()
	{
		BFPCNLFIKHJ(true);
	}

	public void OEDLDFJMEEF()
	{
		if (NPJEECOOCCL())
		{
			OOEMBMAOMLG();
		}
		else
		{
			JJKGKBINCFA();
		}
	}

	public void OHKEOCAILIA()
	{
		if (!IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("MaxLivesSlider", 0);
			HHGHDFHAOLG();
			SceneManager.LoadScene(0);
		}
	}

	public void GCKBDIHCBEJ(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Distortion");
		foreach (GameObject gameObject in array)
		{
			QualitySettings.antiAliasing = (IsShadersEnabled() ? 2 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("_DotSize", 456f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!NPJEECOOCCL()) ? 0 : 0);
		}
	}

	private void ANCKKLFPGDI()
	{
		CIPHKEJMMNC(true);
	}

	public bool LKEHPMEBFLI()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("#failed!"))
		{
			result = ((Singleton<SaveSystem>.Instance.PPBFNLHCKCP("action") != 0) ? true : false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("< true | false >", 0);
		}
		return result;
	}

	public void AFIGHIGANDO(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("ChangeSelectedLevel");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (IBFEBKLBJOL() ? 5 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.GetFloat("Search: ", 1701f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(IMFKJCKJGEK() ? 1 : 0);
		}
	}

	public void NPBGBPBBOGB(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("The given 2D texture ", DPNHODJHGJL);
		HHGHDFHAOLG();
	}
}
