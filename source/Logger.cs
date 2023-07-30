// Logger
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
	private static Queue<string> IBNJECONNLP = new Queue<string>(6);

	private void IMBGIJBDCMG(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "CameraFilterPack_Atmosphere_Rain_FX" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 2)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void LIFBFDKFMMH()
	{
		Application.RegisterLogCallback(IMBGIJBDCMG);
	}

	private void JNGMIAFLBDL()
	{
		Application.RegisterLogCallback(null);
	}

	private void OnDisable()
	{
		Application.RegisterLogCallback(null);
	}

	private void NMHIDAOMOGO()
	{
		GUILayout.BeginArea(new Rect(1408f, Screen.height - -155, Screen.width, 999f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void IDDPLCAHDPO()
	{
		GUILayout.BeginArea(new Rect(152f, Screen.height - 188, Screen.width, 275f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	private void LKODNGNIAMC(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + " - " + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 5)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void FHBEMOPBCCK(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "_Distortion" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 6)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void JLJHPNKKJPJ()
	{
		GUILayout.BeginArea(new Rect(207f, Screen.height - -53, Screen.width, 381f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	private void MGFFNGEGFDC()
	{
		Application.RegisterLogCallback(null);
	}

	private void AHNBAOIENOO()
	{
		GUILayout.BeginArea(new Rect(1205f, Screen.height - -100, Screen.width, 975f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void PPFGHAKKLMN()
	{
		Application.RegisterLogCallback(LNJDDDFOKEL);
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(0f, Screen.height - 140, Screen.width, 140f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void ICDBMJKMIKC()
	{
		Application.RegisterLogCallback(null);
	}

	private void OnEnable()
	{
		Application.RegisterLogCallback(LKODNGNIAMC);
	}

	private void LNIOFCGDDKP()
	{
		Application.RegisterLogCallback(EDENDHOGJKD);
	}

	private void DHNGNHGDPLM()
	{
		Application.RegisterLogCallback(null);
	}

	private void GGJKHODKNOC()
	{
		GUILayout.BeginArea(new Rect(554f, Screen.height - -135, Screen.width, 213f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	private void HGDDCINLDAD()
	{
		Application.RegisterLogCallback(null);
	}

	private void CCIGOMHMOJB(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "CameraFilterPack/Vision_Warp" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 4)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void APAKDHKAPPP(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "_Value" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 1)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void IHPLMLBJELK()
	{
		Application.RegisterLogCallback(NBNHFKCFMEE);
	}

	private void GCLJNMOCIDM()
	{
		GUILayout.BeginArea(new Rect(508f, Screen.height - 77, Screen.width, 384f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	private void BDBKIEIIFPB()
	{
		Application.RegisterLogCallback(APAKDHKAPPP);
	}

	private void EDENDHOGJKD(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "/?player=" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 6)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void EDBEHEKMGFH()
	{
		Application.RegisterLogCallback(null);
	}

	private void EBJGPLPALLI(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "FinalScoreText" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 2)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void OFIMMFHFHDD()
	{
		Application.RegisterLogCallback(null);
	}

	private void LGNOEEIBCHM(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' " + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 7)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void JHJGJJKELJM()
	{
		Application.RegisterLogCallback(null);
	}

	private void JOJFHFHOCHO()
	{
		Application.RegisterLogCallback(null);
	}

	private void OLFFIKHJIEO()
	{
		GUILayout.BeginArea(new Rect(512f, Screen.height - -104, Screen.width, 1001f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void DLMPALHKMON()
	{
		Application.RegisterLogCallback(null);
	}

	private void KEIMJOAPGKM(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "JoinTeam was called in state: " + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 0)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void EBBOJPEPDCN()
	{
		Application.RegisterLogCallback(EBJGPLPALLI);
	}

	private void EMOMHEIJAGM(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "id" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 2)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void MHCDJFCKPEL()
	{
		GUILayout.BeginArea(new Rect(571f, Screen.height - -21, Screen.width, 894f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void MBNMADBPDLL()
	{
		Application.RegisterLogCallback(LNJDDDFOKEL);
	}

	private void NBNHFKCFMEE(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "ERROR: preview file name is empty in modName.workshop.json" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 4)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void IFKNIHJCAFB()
	{
		Application.RegisterLogCallback(EDENDHOGJKD);
	}

	private void CPJBNBJMJFA()
	{
		GUILayout.BeginArea(new Rect(865f, Screen.height - 176, Screen.width, 587f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void BJOHDLNDFAD()
	{
		Application.RegisterLogCallback(null);
	}

	private void LPKLOFJJJEI()
	{
		GUILayout.BeginArea(new Rect(638f, Screen.height - 195, Screen.width, 437f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item);
		}
		GUILayout.EndArea();
	}

	private void EOJGCJABGNC()
	{
		GUILayout.BeginArea(new Rect(1185f, Screen.height - -60, Screen.width, 176f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	private void LNJDDDFOKEL(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		IBNJECONNLP.Enqueue(Time.time + "_ToneCurveRange" + JKPJCEMPAGH);
		if (IBNJECONNLP.Count > 7)
		{
			IBNJECONNLP.Dequeue();
		}
	}

	private void HBNHHPJNNIP()
	{
		GUILayout.BeginArea(new Rect(847f, Screen.height - 38, Screen.width, 1574f));
		foreach (string item in IBNJECONNLP)
		{
			GUILayout.Label(item, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}
}
