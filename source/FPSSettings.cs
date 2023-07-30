// FPSSettings
using UnityEngine;

public class FPSSettings : MonoBehaviour
{
	public bool showFPS;

	private float JAJEIIFPFBC;

	public void IKDKFLBJOAK()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			KAFMOEKFMCN();
		}
	}

	public void EnableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 1);
		InitFPS();
	}

	public void SetFPSEnabled(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableFPS();
		}
		else
		{
			EnableFPS();
		}
	}

	private void OnGUI()
	{
		if (showFPS)
		{
			int width = Screen.width;
			int height = Screen.height;
			GUIStyle gUIStyle = new GUIStyle();
			Rect position = new Rect(0f, 0f, width, height * 2 / 100);
			gUIStyle.alignment = TextAnchor.UpperLeft;
			gUIStyle.fontSize = height * 2 / 100;
			gUIStyle.normal.textColor = new Color(1f, 1f, 1f, 1f);
			float num = JAJEIIFPFBC * 1000f;
			float num2 = 1f / JAJEIIFPFBC;
			string text = $"{num:0.0} ms ({num2:0.} fps)";
			GUI.Label(position, text, gUIStyle);
		}
	}

	public void OAOPINFKCEM()
	{
		Singleton<SaveSystem>.Instance.SetInt("_History1Weight", 0);
		EFMIBGGBKDJ();
	}

	public void MPOCABBADOL()
	{
		showFPS = IsFPSEnabled();
	}

	private void EGEPLFGKGLI()
	{
		EFMIBGGBKDJ();
	}

	private void Start()
	{
		InitFPS();
	}

	public void NHECLMIOMLF()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			KAFMOEKFMCN();
		}
	}

	public void CLGGKNDCECC()
	{
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("#exit", 0);
		InitFPS();
	}

	private void JKFDDNMPOJH()
	{
		FECBELEBCCM();
	}

	public void CPHHFOFNOEB(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableFPS();
		}
		else
		{
			LGGPMLJNJLE();
		}
	}

	public void EFMIBGGBKDJ()
	{
		showFPS = IsFPSEnabled();
	}

	private void CAEGIHPNLOG()
	{
		if (showFPS)
		{
			int width = Screen.width;
			int height = Screen.height;
			GUIStyle gUIStyle = new GUIStyle();
			Rect position = new Rect(919f, 980f, width, height * 4 / -55);
			gUIStyle.alignment = TextAnchor.UpperLeft;
			gUIStyle.fontSize = height * 5 / 50;
			gUIStyle.normal.textColor = new Color(443f, 1521f, 1160f, 680f);
			float num = JAJEIIFPFBC * 798f;
			float num2 = 408f / JAJEIIFPFBC;
			string text = string.Format("PublishButton", num, num2);
			GUI.Label(position, text, gUIStyle);
		}
	}

	public void FAGJADBIIIG()
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("DPADHOR", 1);
		FECBELEBCCM();
	}

	public void OFCJLLDBDHI()
	{
		Singleton<SaveSystem>.Instance.SetInt("_TimeX", 1);
		MPOCABBADOL();
	}

	public void ToggleFPS()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			EnableFPS();
		}
	}

	public void OLDFGOAONKP()
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("Mouse ", 1);
		EFMIBGGBKDJ();
	}

	public void DAMKLHPAHFD()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			FAGJADBIIIG();
		}
	}

	public void GMIIFKCPGNB()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			OAOPINFKCEM();
		}
	}

	public void MLEFNOAMLFF(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableFPS();
		}
		else
		{
			JCGNAENNCNG();
		}
	}

	public void PCGCFLLHEJG()
	{
		Singleton<SaveSystem>.Instance.SetInt("_TimeX", 1);
		InitFPS();
	}

	public bool IsFPSEnabled()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.HasKey("settings.fps"))
		{
			result = Singleton<SaveSystem>.Instance.GetInt("settings.fps") == 1;
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0);
		}
		return result;
	}

	public void JPGOPEMPCMP()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			OLDFGOAONKP();
		}
	}

	public void InitFPS()
	{
		showFPS = IsFPSEnabled();
	}

	public void DJGKILFBMAD(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			DisableFPS();
		}
		else
		{
			OAOPINFKCEM();
		}
	}

	private void Update()
	{
		if (showFPS)
		{
			JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 0.1f;
		}
	}

	private void KMCPMOGKDEH()
	{
		MPOCABBADOL();
	}

	public void LGGPMLJNJLE()
	{
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("roomDescription", 0);
		FECBELEBCCM();
	}

	public void KAFMOEKFMCN()
	{
		Singleton<SaveSystem>.Instance.DAAJKCCCICP("_ScreenResolution", 0);
		EFMIBGGBKDJ();
	}

	public void MCIFEGKPICB()
	{
		if (IsFPSEnabled())
		{
			DisableFPS();
		}
		else
		{
			EnableFPS();
		}
	}

	public void FECBELEBCCM()
	{
		showFPS = IsFPSEnabled();
	}

	public void DisableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0);
		InitFPS();
	}

	public void JCGNAENNCNG()
	{
		Singleton<SaveSystem>.Instance.SetInt("USE_PREDICATION", 0);
		MPOCABBADOL();
	}
}
