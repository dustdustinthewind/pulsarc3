// ShadersSettings
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShadersSettings : MonoBehaviour
{
	private void DNNFHBOOPIN()
	{
		LJJAKFGIHIP(true);
	}

	public void FAFOBFMEHJM()
	{
		if (!KONKGHCFKJF())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("_TapLowBackground", 0);
			DNOFHFPGCMI(true);
			SceneManager.LoadScene(1);
		}
	}

	public bool GMNOCOOLEDN()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.OHIBODCDDKB("#ok"))
		{
			result = ((Singleton<SaveSystem>.Instance.KOKJPDNJCAA("action") != 0) ? true : false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("setAF", 0);
		}
		return result;
	}

	public void JFMDDMFFAHO()
	{
		if (KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Bullet_8", 0);
			PJDJNOCNPMJ();
			SceneManager.LoadScene(1);
		}
	}

	public void ELMKGILDNEF()
	{
		if (!KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.DAAJKCCCICP("skin.hit_wrong", 1);
			LALOCJDHIOO(true);
			SceneManager.LoadScene(1);
		}
	}

	public void LALOCJDHIOO(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Zoom speed. Base 1.5");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (GMNOCOOLEDN() ? 2 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.HCNELAJLBPC("mapselector.filter.favoriteonly", 526f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IJPCDBBBAKH()) ? 0 : 0);
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

	public void DNOFHFPGCMI(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_ScreenResolution");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (GMNOCOOLEDN() ? 3 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Clears all text from the debug console", 1098f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!GMNOCOOLEDN()) ? 0 : 0);
		}
	}

	public void HDMPKMKNMND()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("tagElement", 0);
			PJDJNOCNPMJ();
			SceneManager.LoadScene(0);
		}
	}

	private void NCNPAKFAFOE()
	{
		LALOCJDHIOO(true);
	}

	private void BEBNOKFLJPH()
	{
		NCNDKBHCEKB(true);
	}

	public bool NPNIHFDOPHH()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.OHIBODCDDKB("UseFinalGlassColor"))
		{
			result = Singleton<SaveSystem>.Instance.JNLHMOEFMML("ItemsUploader") != 1 && false;
		}
		else
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("FinalScoreText", 1);
		}
		return result;
	}

	private void FIKFJDFELIP()
	{
		PJDJNOCNPMJ();
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

	public void LLABOHPIGPP()
	{
		if (KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("OK", 0);
			LALOCJDHIOO();
			SceneManager.LoadScene(0);
		}
	}

	public void KGNBFNMKJJK()
	{
		if (IsShadersEnabled())
		{
			DisableShaders();
		}
		else
		{
			ELMKGILDNEF();
		}
	}

	public void BPFLJMNJEKH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("OpLeaveLobby()", DPNHODJHGJL);
		InitShaders(true);
	}

	public void GFHDLNMLIDO()
	{
		if (!KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("_Value", 1);
			InitShaders(true);
			SceneManager.LoadScene(1);
		}
	}

	public void SetBloomIntencity(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.shaders.bloomintencity", DPNHODJHGJL);
		InitShaders();
	}

	public void GMBHNHBBLMC()
	{
		if (IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("restart", 0);
			LCBCIMHDLJE();
			SceneManager.LoadScene(1);
		}
	}

	public void IEJIOELJKDJ(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			JFMDDMFFAHO();
		}
		else
		{
			JJKGKBINCFA();
		}
	}

	public void JJKGKBINCFA()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.DAAJKCCCICP("ENABLE_EYE_ADAPTATION", 0);
			BAJILLOLGNP(true);
			SceneManager.LoadScene(1);
		}
	}

	public void LBNBKMOPCMO()
	{
		if (!IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("_ColorG", 0);
			InitShaders(true);
			SceneManager.LoadScene(0);
		}
	}

	public void LJJAKFGIHIP(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("maps.");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (NPNIHFDOPHH() ? 1 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.DPAGLGGNECO("<b>", 1934f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IsShadersEnabled()) ? 1 : 1);
		}
	}

	public bool IJPCDBBBAKH()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("<b>#"))
		{
			result = Singleton<SaveSystem>.Instance.GetInt("Tab2Content") != 1 && false;
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack_WaterDrop", 1);
		}
		return result;
	}

	public void BAJILLOLGNP(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TimeX");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (IJPCDBBBAKH() ? 6 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_FixDistance", 737f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(IsShadersEnabled() ? 1 : 0);
		}
	}

	public bool KCKHPNKCGJN()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Turn"))
		{
			result = Singleton<SaveSystem>.Instance.KOKJPDNJCAA("maps.") != 1 || true;
		}
		else
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("settings.volume.game", 1);
		}
		return result;
	}

	public void PJDJNOCNPMJ(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_MidGrey");
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!GMNOCOOLEDN()) ? 1 : 5);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.PGKJAIODCEF("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", 348f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!KCKHPNKCGJN()) ? 1 : 0);
		}
	}

	public void LCBCIMHDLJE(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Amount");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = (NPNIHFDOPHH() ? 3 : 0);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.HCNELAJLBPC("return CheckCondition()", 1403f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel(KONKGHCFKJF() ? 1 : 0);
		}
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

	public void DLKFELIANGI()
	{
		if (!KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Offsets", 0);
			LCBCIMHDLJE(true);
			SceneManager.LoadScene(0);
		}
	}

	public void NCNDKBHCEKB(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("#savemapbeforeuploading");
		foreach (GameObject gameObject in array)
		{
			QualitySettings.antiAliasing = ((!IsShadersEnabled()) ? 1 : 4);
			if ((bool)gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.PGKJAIODCEF("CameraFilterPack/Glitch_Mozaic", 418f);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!IJPCDBBBAKH()) ? 0 : 0);
		}
	}

	public void NHCBJKEGMKI()
	{
		if (NPNIHFDOPHH())
		{
			Singleton<SaveSystem>.Instance.SetInt("mapselector.filter.subscribedonly", 0);
			PJDJNOCNPMJ();
			SceneManager.LoadScene(1);
		}
	}

	public void IBMLIBKMNGM(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			LLABOHPIGPP();
		}
		else
		{
			LNPGFKOGJEK();
		}
	}

	public void DNOGFELNGEH()
	{
		if (KCKHPNKCGJN())
		{
			JFMDDMFFAHO();
		}
		else
		{
			EnableShaders();
		}
	}

	public void OKBCPLIADEL(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			JFMDDMFFAHO();
		}
		else
		{
			EnableShaders();
		}
	}

	public void KCPBEDNCCBL(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableShaders();
		}
		else
		{
			LBNBKMOPCMO();
		}
	}

	public void NDCCCNGCELN(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("other.dust0", DPNHODJHGJL);
		LJJAKFGIHIP(true);
	}

	public void LNNGJENPHAB()
	{
		if (KONKGHCFKJF())
		{
			Singleton<SaveSystem>.Instance.SetInt("[Down]", 0);
			LJJAKFGIHIP();
			SceneManager.LoadScene(0);
		}
	}

	public void DMMFLJOMONG(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("ItemsCountText", DPNHODJHGJL);
		InitShaders();
	}

	public void IDAGIHGKLBI()
	{
		if (NPNIHFDOPHH())
		{
			LNOFBFBAOIE();
		}
		else
		{
			EnableShaders();
		}
	}

	public void DBJNFBBFCEK()
	{
		if (IsShadersEnabled())
		{
			DisableShaders();
		}
		else
		{
			BJBABDDJNGN();
		}
	}

	public void KAEHOGBINPN(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("settings.cameramovements", DPNHODJHGJL);
		InitShaders();
	}

	public void EFINBDFHIJL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO("_ScreenResolution", DPNHODJHGJL);
		LALOCJDHIOO();
	}

	public void DIDLLJPOMIO(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			LNNGJENPHAB();
		}
		else
		{
			FAFOBFMEHJM();
		}
	}

	public void OLOOHDLPNHK(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK("float,1", DPNHODJHGJL);
		NCNDKBHCEKB();
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

	public void OAEFOILJKAI()
	{
		if (IJPCDBBBAKH())
		{
			NHCBJKEGMKI();
		}
		else
		{
			HDMPKMKNMND();
		}
	}

	public void HFKGKNCGDNE()
	{
		if (!KCKHPNKCGJN())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("RecieveChatMessage", 1);
			LALOCJDHIOO(true);
			SceneManager.LoadScene(0);
		}
	}

	private void GPNAOAKCMHC()
	{
		InitShaders();
	}

	private void CNGAJDBOCLJ()
	{
		DNOFHFPGCMI();
	}

	public void GFCMNDKCDBE(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF("0,1,false", DPNHODJHGJL);
		BAJILLOLGNP();
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

	public void DFAHOLGHGBP()
	{
		if (NPNIHFDOPHH())
		{
			LLABOHPIGPP();
		}
		else
		{
			DLKFELIANGI();
		}
	}

	private void Start()
	{
		InitShaders();
	}

	public void HFDCDDBHABN(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK("_Value3", DPNHODJHGJL);
		LALOCJDHIOO(true);
	}

	private void ANCKKLFPGDI()
	{
		NCNDKBHCEKB();
	}

	private void KCCIEMBMOBA()
	{
		PJDJNOCNPMJ(true);
	}

	public void LPDJGNMHBGJ()
	{
		if (IJPCDBBBAKH())
		{
			DisableShaders();
		}
		else
		{
			EnableShaders();
		}
	}

	private void PMPKMGKAAJH()
	{
		LJJAKFGIHIP(true);
	}

	private void AGEJKLMJGDO()
	{
		BAJILLOLGNP();
	}

	public void NPNCKKEPICO(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			GMBHNHBBLMC();
		}
		else
		{
			DLKFELIANGI();
		}
	}

	public void IGDEKNLAPPI(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("GhostFade", DPNHODJHGJL);
		InitShaders();
	}

	public void BJBABDDJNGN()
	{
		if (!KONKGHCFKJF())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("_Value4", 1);
			NCNDKBHCEKB();
			SceneManager.LoadScene(1);
		}
	}

	public void LFOHNNACIFD(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			LNOFBFBAOIE();
		}
		else
		{
			HFKGKNCGDNE();
		}
	}

	public bool KONKGHCFKJF()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("Set Background Color"))
		{
			result = Singleton<SaveSystem>.Instance.POJCOIEGLEF("Joystick1Button11") == 1;
		}
		else
		{
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI("element", 1);
		}
		return result;
	}

	public void NCIMJEJAFDN(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			GMBHNHBBLMC();
		}
		else
		{
			JJKGKBINCFA();
		}
	}

	public void LNOFBFBAOIE()
	{
		if (IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack_TV_Arcade1", 1);
			LJJAKFGIHIP();
			SceneManager.LoadScene(1);
		}
	}

	public void LNPGFKOGJEK()
	{
		if (!KONKGHCFKJF())
		{
			Singleton<SaveSystem>.Instance.GBFBKFACPBI("offsets", 0);
			LALOCJDHIOO(true);
			SceneManager.LoadScene(0);
		}
	}

	private void NNCCPEBIAKH()
	{
		PJDJNOCNPMJ(true);
	}
}
