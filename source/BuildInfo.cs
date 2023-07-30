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

	private void CGBHOELMAOC()
	{
	}

	private void ONMGIPAILOH()
	{
	}

	private void MKIMDFLBFOM()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "_MainTex2";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "Set Sun Colors" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Scrollbar" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[3];
		array[0] = PKOAMLGGDDI;
		array[1] = "Set satellite trail width";
		array[8] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[5] = ((!flag) ? string.Empty : "Set arcs speed. Base value - 15");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MDDADJIHOJP());
	}

	private void LEAHIBJDMBI()
	{
	}

	private void JHANGPCOCIG()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "OnPlayerGameMessage";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "mapid" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("AudioSampler" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = PKOAMLGGDDI;
		array[0] = "maps.";
		array[3] = FONGIBAJEMO;
		array[5] = KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "_Value");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	private void JONGNKNLLND()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = ". The group number should be at least 1.";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_Value7" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("LeaderboardsButton" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[0];
		array[1] = PKOAMLGGDDI;
		array[1] = "CameraFilterPack/EXTRA_Rotation";
		array[7] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "EnableRankedNotificationsToggle");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ICFEFPIGPFC());
	}

	private void LPMINJJPDCH()
	{
	}

	private void PDHKMDBNGGN()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "Uploading preview image...";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = " PhotonNetwork.networkingPeer.AvailableRegions " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("PublishButton" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2] { PKOAMLGGDDI, "Connecting to server" };
		array[1] = FONGIBAJEMO;
		array[0] = KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "OneHand");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	private void FIKFJDFELIP()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "#ok";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "ready" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log(" Time: " + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2] { null, PKOAMLGGDDI };
		array[1] = "_Value2";
		array[2] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "gold");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().DPCDAONEBPK());
	}

	private void MNBPNHNAEBK()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_Value2";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_ScreenResolution" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Blurred" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = PKOAMLGGDDI;
		array[0] = "_Distortion";
		array[8] = FONGIBAJEMO;
		array[1] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "UpdateNewsTileStart");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MKGMGJJIELK());
	}

	private void JKBMKPDGCHG()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "tagElement";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "/" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("CameraFilterPack/Vision_Rainbow" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[5];
		array[1] = PKOAMLGGDDI;
		array[1] = "BestScoreText";
		array[1] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "\n");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().PPNKOMMDAPD());
	}

	private void CFIAKIJAILI()
	{
	}

	private void OHFOLGANOLC()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = ").";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "AudioSampler" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("event" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = PKOAMLGGDDI;
		array[0] = "InfoCanvas";
		array[4] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[5] = ((!flag) ? string.Empty : "CameraFilterPack/Distortion_Aspiration");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().FJJOIELAMOG());
	}

	private void EHCGBJDFMHG()
	{
	}

	private void PMPKMGKAAJH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "#";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "Connected to gameserver." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("mapid" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[1] { PKOAMLGGDDI };
		array[0] = "_Axis";
		array[4] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "value");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	private void DKOPKPBLDHH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "_TimeX";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "ScreenResolutionPanel" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("0.00" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[0];
		array[1] = PKOAMLGGDDI;
		array[0] = "Anomaly_Intensity";
		array[0] = FONGIBAJEMO;
		array[3] = KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "Anomaly_Near");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	private void CHOPDIGHJNH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "\\\\";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "NewMapHandsCountSlider" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("type" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[7];
		array[0] = PKOAMLGGDDI;
		array[1] = "CameraFilterPack_Paper4";
		array[4] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : "_Value4");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	private void KMKLDAJLCNM()
	{
	}

	private void DDBOODLPCAM()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void KMEONPMCNJG()
	{
	}

	private void AEEGKLABFLN()
	{
	}

	private void JNBPKNNBMDI()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void FANADGBGCPI()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "ShadersToggle";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "CameraFilterPack/Glow_Glow" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = PKOAMLGGDDI;
		array[0] = "1,30,true,0";
		array[5] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "_Value5");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().AHALHEPONLD());
	}

	private void KCCIEMBMOBA()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_Value";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "The number of players playing your game: " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("maps." + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = PKOAMLGGDDI;
		array[0] = "FreqVolume: ";
		array[4] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_WhiteBalance");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().JDCFAOHDFIN());
	}

	private void ECBILENEOOL()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "Set satellite clockwise rotattion speed";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "difficulty" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Value" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = PKOAMLGGDDI;
		array[1] = "TotalHitsScoreText";
		array[6] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "JoinRoom failed. In offline mode you still have to leave a room to enter another.");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IIBOBNHHGCK());
	}

	private void DIPDEHOOBPG()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "settings.cameramovements";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "HandsCountSlider" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Sat" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[3];
		array[1] = PKOAMLGGDDI;
		array[0] = "Observed type is not serializable: ";
		array[6] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "_ScreenResolution");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().BKGOINFBAMJ());
	}

	private void HMPGIFBJFIK()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "[MenuScene] Error: ";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("1" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = PKOAMLGGDDI;
		array[0] = "SetSpeed";
		array[4] = FONGIBAJEMO;
		array[3] = KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : ".sawoutdatedmessage");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MKGMGJJIELK());
	}

	private void DBLILJGKGHJ()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = ". Current number of cells is ";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_BlurredColor" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("settings.volume.sfx" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = PKOAMLGGDDI;
		array[1] = "Toggle {0} is not part of ToggleGroup {1}";
		array[4] = FONGIBAJEMO;
		array[8] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "_Value");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().INFHBGJLHBH());
	}

	private void OCMKCBBCEFG()
	{
	}

	private void NBGIMIDICKE()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "SupportLogger Info: PUN {0}: ";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "/music" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("ConfigVersionSlider" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2] { null, PKOAMLGGDDI };
		array[1] = "Texture2";
		array[7] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "GlassDistortion");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().COFOOEGOLFA());
	}

	private void DPIPGGDNGHN()
	{
	}

	private void DBEMDAJDDDA()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "/Assets/MyImage";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "CameraFilterPack/Special_Bubble" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("LevelEditor/icons" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = PKOAMLGGDDI;
		array[1] = "Texture2";
		array[4] = FONGIBAJEMO;
		array[8] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "float,50");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ELMCDLKBCKK());
	}

	private void MJNPIDGNJMK()
	{
	}

	private void JHPOIOELNCG()
	{
	}

	private void GPNAOAKCMHC()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "LastNewsButton";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "High" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Case-Sensitive" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[1] = PKOAMLGGDDI;
		array[1] = "[PlayerBase] ShowTitle error: ";
		array[7] = FONGIBAJEMO;
		array[5] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "_TimeX");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	private void ODBNMPGBCGO()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "Items/";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_Intensity" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("#random #common #item" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[7];
		array[1] = PKOAMLGGDDI;
		array[0] = " ";
		array[3] = FONGIBAJEMO;
		array[1] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "GhostFade2");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().NLOJOMGEGNG());
	}

	private void LBAJLLFMMMP()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "sounds/no_hit";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "Editor/" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("0,1,true,0" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[1];
		array[0] = PKOAMLGGDDI;
		array[1] = "Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ";
		array[8] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "Joystick1Button6");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	private void AEIJFLJEABG()
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

	private void HNDNDPECBPL()
	{
	}

	private void KMCPMOGKDEH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "_Value2";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "y" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("[MapsEditor] Creating new item..." + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = PKOAMLGGDDI;
		array[1] = "Item created: Id: ";
		array[5] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "offsets");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().PBIPCILMAOC());
	}

	private void AGEJKLMJGDO()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "failed";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "MenuScene" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[3];
		array[0] = PKOAMLGGDDI;
		array[0] = "input";
		array[7] = FONGIBAJEMO;
		array[1] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "UsernameText");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ABEOMIHEDLN());
	}

	private void LCHBFNIPBHB()
	{
	}

	private void KDMKDEKCELE()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "UseScanLineSize";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "duration" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Gameplay/particles" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2] { null, PKOAMLGGDDI };
		array[0] = "z";
		array[0] = FONGIBAJEMO;
		array[8] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : " user's map(s)");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	private void JECMJNFGBGC()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "colorD";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "speed" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("GhostPosY" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8] { PKOAMLGGDDI, "LoadPlayerEnvironment", null, null, null, null, null, FONGIBAJEMO };
		array[2] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "[PlayerController] ");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().OAKKDDEAIBN());
	}

	private void PNLKFANNOKO()
	{
	}

	private void ICILLMAKLMI()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "visible";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "Jan" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Scrollbar" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[0];
		array[0] = PKOAMLGGDDI;
		array[0] = "NEW_ACHIEVEMENT_1_";
		array[5] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "Save Game");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	private void JOPCCCCHNLI()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "The region arrays from Name Server are not ok. Must be non-null and same length. ";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "maps." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("CameraFilterPack/Drawing_Manga_FlashWhite" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = PKOAMLGGDDI;
		array[1] = "_Value4";
		array[4] = FONGIBAJEMO;
		array[5] = KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "1.87");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	private void Update()
	{
	}

	private void BEBNOKFLJPH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "EventMenu";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_Value5" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("caret" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = PKOAMLGGDDI;
		array[0] = "_TimeX";
		array[8] = FONGIBAJEMO;
		array[3] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_Value10");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ANKDOLLBGDD());
	}

	private void PAKPHKPDKGE()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "{\"items\":";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "\r" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("#turnoninternet" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = PKOAMLGGDDI;
		array[0] = " now: ";
		array[8] = FONGIBAJEMO;
		array[3] = KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "menu.selectedplaymode");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IDPBCFBOBJP());
	}

	private void FABKIGNFECE()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void PFNFPINPCMH()
	{
	}

	private void NCPAFCKGJEA()
	{
	}

	private void POIMNOBDBBN()
	{
	}

	private void HMNLHMLILKD()
	{
	}

	private void MMMDPANNAIO()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "CameraFilterPack/VHS_Tracking";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "Text" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("\\n" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = PKOAMLGGDDI;
		array[0] = "#tryagain";
		array[5] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "_TapHigh");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ENGDDMDBGFH());
	}

	private void PKLOBJHKFEO()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_Value2";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "Exit to Windows" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Playing " + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = PKOAMLGGDDI;
		array[1] = "<b>Speed</b>:";
		array[6] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "_CenterX");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	private void HDMDKOKOOJC()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "#";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "_SoftZDistance" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("EnableRankedNotificationsToggle" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = PKOAMLGGDDI;
		array[0] = "Waiting to start";
		array[7] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "CameraFilterPack/Atmosphere_Rain_Pro");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ANKDOLLBGDD());
	}

	private void IKIDIJLIGOH()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void IDJKNBDKHBD()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "CameraFilterPack/Blend2Camera_LighterColor";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "RPCs can only be sent in rooms. Call of \"" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Saturation" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[3];
		array[1] = PKOAMLGGDDI;
		array[0] = "maps.";
		array[7] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "Set satellite radius (offset)");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().NOBOCGLGFFD());
	}

	private void NKLIHNJCHOG()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void FEHCNJLLJMP()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = " left";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "[LevelEditorScene] Error: Timeout :S" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("itemdefid[0]" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[5];
		array[1] = PKOAMLGGDDI;
		array[0] = "_Value2";
		array[2] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : "LoadingStatusText");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().PBIPCILMAOC());
	}

	private void NEKCPLGFOFD()
	{
	}

	private void ANCKKLFPGDI()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_DistortionSize";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = " does not exist!" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = PKOAMLGGDDI;
		array[0] = "LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}";
		array[8] = FONGIBAJEMO;
		array[1] = KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "</i>");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	private void DLBODOFAJGM()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_Red_G";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "[Up-Down]" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("player.blackwhite" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = PKOAMLGGDDI;
		array[0] = "StartTime already set: ";
		array[3] = FONGIBAJEMO;
		array[5] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "Tab1Content");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().LCDKMHEGHJN());
	}

	private void IDIIELPAMCJ()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void PBEPCAPAKLG()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void EPEGAEGDJAM()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "event";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_TimeX" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Object ID. Case-Sensitive" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = PKOAMLGGDDI;
		array[0] = "z";
		array[1] = FONGIBAJEMO;
		array[2] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "StartTime already set: ");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().MDDADJIHOJP());
	}

	private void LCDJFJIBADI()
	{
	}

	private void FJHFOBHJEHL()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void KIEJKBNBHMD()
	{
	}

	private void HIPEHGNBJMN()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "maps.";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "Horizontal" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Value4" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = PKOAMLGGDDI;
		array[1] = "Add Environment Sprite";
		array[3] = FONGIBAJEMO;
		array[0] = KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "_Distortion");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().INFHBGJLHBH());
	}

	private void NPLCENPNJBM()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_EmissionColor";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "Could not execute RPC " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("FPSToggle" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[2] { null, PKOAMLGGDDI };
		array[0] = "_TimeX";
		array[1] = FONGIBAJEMO;
		array[4] = KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "x");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	private void FHGKIOOMMOH()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "BlockSize";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "_Value2" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Visualize" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = PKOAMLGGDDI;
		array[0] = "_Value2";
		array[5] = FONGIBAJEMO;
		array[7] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "selColor");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().DPCDAONEBPK());
	}

	private void AGMJDGHLBMN()
	{
	}

	private void CFFCLAHMBAA()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "CameraFilterPack/Vision_Plasma";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "," + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("UI Extensions/UIAdditive" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = PKOAMLGGDDI;
		array[0] = "StartButton";
		array[2] = FONGIBAJEMO;
		array[8] = KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "[ImageLoader] Loaded image from ");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().IDPBCFBOBJP());
	}

	private void CIPKEPDELJB()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = ".lastCheckpoint.perfectHits";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			KCJEFKBENKA = "MapEnd" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ColorRGB" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[1];
		array[0] = PKOAMLGGDDI;
		array[1] = "ACCEPT";
		array[1] = FONGIBAJEMO;
		array[0] = KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_DistortionSize");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().ENGDDMDBGFH());
	}

	private void FMFNILJIEIA()
	{
		EAFAMAMDNEG = GetComponent<Text>();
		PKOAMLGGDDI = EAFAMAMDNEG.text;
		FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string pchName = "_Value3";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = false;
			}
			KCJEFKBENKA = "[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Set particles start speed" + ex.ToString());
		}
		Text eAFAMAMDNEG = EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = PKOAMLGGDDI;
		array[0] = "_ScreenResolution";
		array[7] = FONGIBAJEMO;
		array[6] = KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "Joystick1Button4");
		eAFAMAMDNEG.text = string.Concat(array);
		StartCoroutine(GetComponent<ContentSizeFitterFx>().COFOOEGOLFA());
	}
}
