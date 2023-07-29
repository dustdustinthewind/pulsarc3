// hardInput
using HardShellStudios.InputManager;
using UnityEngine;

public class hardInput : MonoBehaviour
{
	public enum controllerType
	{
		PS3,
		PS4,
		XBOX1,
		XBOX360
	}

	public static string NFAMPNFLAEJ(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.HDELGDBGOCG(AKOENHBOCOD, BIDPCNEDFME);
	}

	public static float GetAxis(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	public static bool CHAJOGCCKDA(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKeyDown(AKOENHBOCOD);
	}

	public static controllerType GetControllerType()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		default:
			return controllerType.PS3;
		case 1:
			return controllerType.PS4;
		case 2:
			return controllerType.XBOX1;
		case 3:
			return controllerType.XBOX360;
		}
	}

	public static bool GKLCHNPAEAL(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKey(AKOENHBOCOD);
	}

	public static void OLHMLFIEIDO(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.BAIMLCIHANB(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	public static bool NGFFMGKPMNP(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GJPKJMNGJKG(AKOENHBOCOD);
	}

	public static int DMPGINIIIFJ()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	public static string EPIFCBNFKNO(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.MKCKJLLCMED(AKOENHBOCOD, BIDPCNEDFME);
	}

	public static void ForceRebind(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.HardStartRebind(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static float DAKLFCPPJDB(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.FALNNGMABKM(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	public static bool KFKHHOLEGOK(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.KDHDPECKBJC(AKOENHBOCOD);
	}

	public static KeyCode DOGMPIJBDAA(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.CLBENCAJDKH(AKOENHBOCOD, DFBNBCOFIFK);
	}

	public static void HardStartRebind(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.HardStartRebind(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	public static void OAIAELNMMKC(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.LJFEBNEOADJ(JOKLAPMFDGO);
	}

	public static bool AADFFLGEJPP(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.MOFCDBDBOOL(AKOENHBOCOD);
	}

	public static int MHGLJHAPGAH()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	public static controllerType PJLOEACMLHO()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		default:
			return controllerType.PS4;
		case 1:
			return controllerType.PS3;
		case 2:
			return (controllerType)4;
		case 3:
			return controllerType.PS3;
		}
	}

	public static int OKOPFPIEOLE()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	public static void ADDMOGHAPPA(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.LDCDBIBDNAN(HPLOOEJMLFD);
	}

	public static void JOJBOPLIEIF(controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MPIEAKCINJD(HMGBJCGOLMI);
	}

	public static bool GetKeyDown(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKeyDown(AKOENHBOCOD);
	}

	public static void SetControllerType(controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.setControllerType(HMGBJCGOLMI);
	}

	public static void ECIMNKJADCB(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.ECIEMPEMHPL(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static void CNHLFADKBOL(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.GPFKHMIPLEP(CGCEBPNHLIP);
	}

	public static void HBGCDCCFNDJ(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.ECIEMPEMHPL(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static bool GetKey(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKey(AKOENHBOCOD);
	}

	public static void JKCPGIDFPOF(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.GJKHADOOHAG(JOKLAPMFDGO);
	}

	public static int GetControllerTypeIndex()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	public static void BAHDOGHKOLG(controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MGHMFJAHGOC(HMGBJCGOLMI);
	}

	public static int KPJLKHBOGGI()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	public static controllerType ONBPEBFBKNH()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		default:
			return controllerType.PS4;
		case 1:
			return controllerType.PS3;
		case 2:
			return (controllerType)8;
		case 3:
			return controllerType.PS3;
		}
	}

	public static void MLBHACCKKDF(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.PFBDLOENJGP(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static void LDNIGNMHCOM(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.LDCDBIBDNAN(HPLOOEJMLFD);
	}

	public static void BDDFOBPPHMC(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.JBCPEEBCPKF(JOKLAPMFDGO);
	}

	public static controllerType MMOLCHLLCMM()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		default:
			return controllerType.PS4;
		case 0:
			return controllerType.PS4;
		case 1:
			return (controllerType)4;
		case 2:
			return controllerType.PS3;
		}
	}

	public static void ResetBinding(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.resetKey(HPLOOEJMLFD);
	}

	public static float PMJHMIKCPBI(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GFIOHABJNCG(AKOENHBOCOD, IKOENAGPJCG);
	}

	public static KeyCode MBEBKPNJGOP(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.FPNHCCEFMPJ(AKOENHBOCOD, DFBNBCOFIFK);
	}

	public static KeyCode GetKeyCode(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.GetKeyCode(AKOENHBOCOD, DFBNBCOFIFK);
	}

	public static string GetKeyName(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.GetKeyName(AKOENHBOCOD, BIDPCNEDFME);
	}

	public static void ResetAllBindings()
	{
		Singleton<hardManager>.Instance.resetSavedKeys();
	}

	public static void JONAFAINKKM()
	{
		Singleton<hardManager>.Instance.JDFLEIALCNP();
	}

	public static void KNFDDKEBKJC(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.HKMGFPGHALH(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	public static void MouseLock(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.MouseLock(JOKLAPMFDGO);
	}

	public static void CEEHKMILMFP(controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MPIEAKCINJD(HMGBJCGOLMI);
	}

	public static float GMNJKCNIPGD(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GCDMKFIGIPC(AKOENHBOCOD, IKOENAGPJCG);
	}

	public static void OLLPEIBAMOG(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.FGNFNHNPOHJ(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static void ALPEDOCMBGL(controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.HJMOHHOAEHL(HMGBJCGOLMI);
	}

	public static controllerType IGGONOJJBLD()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		default:
			return controllerType.PS3;
		case 1:
			return controllerType.PS3;
		case 2:
			return controllerType.PS3;
		case 3:
			return (controllerType)8;
		}
	}

	public static void GLPGDEKMIGI(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.LOAPPGBKBIE(CGCEBPNHLIP);
	}

	public static void HBJILCLJEDH(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.GJKHADOOHAG(JOKLAPMFDGO);
	}

	public static float JLPPEGBDNKA(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	public static float GetAxis(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, IKOENAGPJCG);
	}

	public static void HIOAICLAMNA(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.FGNFNHNPOHJ(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	public static void EAIKAGGFJNI(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.MouseLock(JOKLAPMFDGO);
	}

	public static void MouseVisible(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.MouseVisble(CGCEBPNHLIP);
	}
}
