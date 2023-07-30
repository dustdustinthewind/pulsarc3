// EditorHistoryTracker
using UnityEngine;

public class EditorHistoryTracker : MonoBehaviour
{
	private bool DBNKNDMOAAP;

	public void NMOFLOCELJJ()
	{
		if (DBNKNDMOAAP)
		{
			Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL("Joystick1Button1");
			DBNKNDMOAAP = false;
		}
	}

	private void CCLNNLCOPBL()
	{
	}

	private void IMCKJCHKMKB()
	{
	}

	public void EJEJHIDGEOF()
	{
		if (DBNKNDMOAAP)
		{
			Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN(" (inactive)", true);
			DBNKNDMOAAP = false;
		}
	}

	public void APMDOANGMMK(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.ICNMFKDPDBM(DAGALCAILLN);
		DBNKNDMOAAP = false;
	}

	public void PNIFHGLPIKL()
	{
		if (DBNKNDMOAAP)
		{
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("LoadMapCanvas");
			DBNKNDMOAAP = true;
		}
	}

	public void FocusLoss()
	{
		DBNKNDMOAAP = true;
	}

	public void EIBLEKMPMMP(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL(DAGALCAILLN, true);
		DBNKNDMOAAP = true;
	}

	public void MAJDKOGOLDK(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG(DAGALCAILLN);
		DBNKNDMOAAP = false;
	}

	public void OnChangeWithInfo(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.SaveState(DAGALCAILLN);
		DBNKNDMOAAP = false;
	}

	public void LDJLEEOFJNG()
	{
		if (DBNKNDMOAAP)
		{
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("_MainTex2", true);
			DBNKNDMOAAP = true;
		}
	}

	public void CFCFGBKGKNB()
	{
		DBNKNDMOAAP = true;
	}

	public void KELEGHMHDJC(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.SaveState(DAGALCAILLN);
		DBNKNDMOAAP = false;
	}

	private void Start()
	{
	}

	public void LCGPEMJJFMG()
	{
		DBNKNDMOAAP = false;
	}

	private void NNCCPEBIAKH()
	{
	}

	public void DKGOBDEMFHF(string DAGALCAILLN)
	{
		Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO(DAGALCAILLN);
		DBNKNDMOAAP = false;
	}

	public void OnChange()
	{
		if (DBNKNDMOAAP)
		{
			Singleton<EditorHistoryHandler>.Instance.SaveState("Changed config");
			DBNKNDMOAAP = false;
		}
	}
}
