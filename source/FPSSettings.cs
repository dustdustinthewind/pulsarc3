// FPSSettings
using UnityEngine;

public class FPSSettings : MonoBehaviour
{
	public bool showFPS;

	private float JAJEIIFPFBC;

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

	private void Start()
	{
		InitFPS();
	}

	public void IKDKFLBJOAK()
	{
		if (NDODGACCDKB())
		{
			EPHDOFKCPPE();
		}
		else
		{
			KAFMOEKFMCN();
		}
	}

	private void MAOCOEGAFND()
	{
		if (showFPS)
		{
			JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1930f;
		}
	}

	private void NPLCENPNJBM()
	{
		FECBELEBCCM();
	}

	public void BHNDHOCCNDL()
	{
		if (DMHLBCHFCNB())
		{
			EPHDOFKCPPE();
		}
		else
		{
			EnableFPS();
		}
	}

	public bool GGAAOAEKGIP()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Params3"))
		{
			result = Singleton<SaveSystem>.Instance.DNBCCNHDJDK("steamid") != 1 || true;
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("[LevelEditorScene] Print Audio Wave: Done", 0);
		}
		return result;
	}

	public void BFDMGMKFMHC()
	{
		Singleton<SaveSystem>.Instance.SetInt("#", 0);
		InitFPS();
	}

	public void FECBELEBCCM()
	{
		showFPS = NDODGACCDKB();
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

	private void Update()
	{
		if (showFPS)
		{
			JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 0.1f;
		}
	}

	public void EPHDOFKCPPE()
	{
		Singleton<SaveSystem>.Instance.SetInt("RPC can't be sent to target PhotonPlayer being null! Did not send \"", 0);
		FECBELEBCCM();
	}

	public void EnableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 1);
		InitFPS();
	}

	public bool NDODGACCDKB()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.HasKey("_Value1"))
		{
			result = ((Singleton<SaveSystem>.Instance.DNBCCNHDJDK("SupportLogger OnConnectedToPhoton().") == 0) ? true : false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("CameraFilterPack/FX_Plasma", 1);
		}
		return result;
	}

	public void IIGIBCKMDHK()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("Object ID. Case-Sensitive", 1);
		InitFPS();
	}

	public void AHBJJHEDJHD()
	{
		if (NDODGACCDKB())
		{
			IIGIBCKMDHK();
		}
		else
		{
			OAGILFGECJI();
		}
	}

	public void InitFPS()
	{
		showFPS = IsFPSEnabled();
	}

	public void OBEJJEKIBGM()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ScreenResolution", 1);
		FECBELEBCCM();
	}

	public void CHILGHANENG()
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("AudioSampler", 0);
		InitFPS();
	}

	public bool BEGHEDBOBKJ()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("\n"))
		{
			result = ((Singleton<SaveSystem>.Instance.DNBCCNHDJDK("_Value5") == 0) ? true : false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_AccumulationTex", 1);
		}
		return result;
	}

	private void KLILJHJNICK()
	{
		InitFPS();
	}

	private void DIPDEHOOBPG()
	{
		InitFPS();
	}

	public void OAGILFGECJI()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_TimeX", 0);
		FECBELEBCCM();
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

	private void DAHFFNNIGML()
	{
		FECBELEBCCM();
	}

	public bool DMHLBCHFCNB()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_EmissionColor"))
		{
			result = Singleton<SaveSystem>.Instance.DNBCCNHDJDK("_Value3") != 0 && false;
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA(".lastCheckpoint.maxLongestCombo", 1);
		}
		return result;
	}

	public void DisableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0);
		InitFPS();
	}

	private void KIMMMCJFMAB()
	{
		InitFPS();
	}

	public bool GBAOHEJBNPC()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("sounds/no_hit"))
		{
			result = Singleton<SaveSystem>.Instance.PPBFNLHCKCP("]") == 1;
		}
		else
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("ticket", 1);
		}
		return result;
	}

	public void KAFMOEKFMCN()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_Value4", 0);
		InitFPS();
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
}
