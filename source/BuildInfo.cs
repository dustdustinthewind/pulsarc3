// BuildInfo
// Deobfuscated

using System;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo : MonoBehaviour
{
	private string gameVersion;

	private Text copyrightText;

	private string copyrightString;

	private string buildNum;

	private void Update()
	{
	}

	private void Start()
	{
		copyrightText = GetComponent<Text>();
		copyrightString = copyrightText.text;
		gameVersion = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string pchName = "public";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out pchName, cchNameBufferSize))
			{
				flag = true;
			}
			buildNum = " b." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("[BuildInfo] Error: " + ex.ToString());
		}
		copyrightText.text = copyrightString + "\nv." + gameVersion + buildNum + ((!flag) ? string.Empty : " BETA");
		StartCoroutine(GetComponent<ContentSizeFitterFx>().RunFix());
	}

	public BuildInfo()
	{
		gameVersion = string.Empty;
	}
}
