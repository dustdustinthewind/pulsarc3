// BuildInfo
using System;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo : MonoBehaviour
{
	private string FONGIBAJEMO = string.Empty;

	private Text EAFAMAMDNEG;

	private string PKOAMLGGDDI;

	private string KCJEFKBENKA;

	private void CCLNNLCOPBL()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "_ScreenResolution";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "maps." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_MainTex2" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[5];
		array[1] = PKOAMLGGDDI;
		array[1] = "ItemNameBGImage";
		array[4] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[5] = ((!flag) ? string.Empty : "_Value6");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().HFOAJCFJFOE());
	}

	private void MFMIODIAKNI()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void BEBNOKFLJPH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_SpawnHeuristic" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("GlassColor" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[1];
		array[0] = PKOAMLGGDDI;
		array[1] = "_Value2";
		array[2] = FONGIBAJEMO;
		array[0] = KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "ScrollPanel");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().CLCOLEIKEJD());
	}

	private void NNCCPEBIAKH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "Tab2Content";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "]. Please verify you have this gameobject in a Resources folder." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("InfoCanvas" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[1];
		array[1] = PKOAMLGGDDI;
		array[1] = ".lastCheckpoint.playerdistance";
		array[5] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "Map id for");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().FBCMGMNNBLO());
	}

	private void CFIAKIJAILI()
	{
	}

	private void NCNPAKFAFOE()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "[MenuScene] Error: ";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_SecondTex" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Value2" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = PKOAMLGGDDI;
		array[0] = "checkpoint";
		array[1] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : " (now: ");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().FCOJEIDKDGJ());
	}

	private void DIPDEHOOBPG()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "#loopnumber ";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_Red_B" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("BitsData" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[1] = PKOAMLGGDDI;
		array[1] = ".lastCheckpoint.lives";
		array[8] = FONGIBAJEMO;
		array[1] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "<b>#");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().FBCMGMNNBLO());
	}

	private void Update()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void Start()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "public";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = " b." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("[BuildInfo] Error: " + ex.ToString());
		}
		EAFAMAMDNEG.text = PKOAMLGGDDI + "\nv." + FONGIBAJEMO + KCJEFKBENKA + ((!flag) ? string.Empty : " BETA");
		StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private void DNNFHBOOPIN()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "Tab1Content";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_TimeX" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("back" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[3];
		array[1] = PKOAMLGGDDI;
		array[1] = "CameraFilterPack/Pixelisation_OilPaint";
		array[3] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "settings.enablehitsoundsinrelax");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().LPICEEMBGJN());
	}

	private void FIKFJDFELIP()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = " ";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "settings.shaders" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("red" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[0];
		array[1] = PKOAMLGGDDI;
		array[1] = "No Name";
		array[2] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "_CenterX");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}
}
