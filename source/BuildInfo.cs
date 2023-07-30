// BuildInfo
// code taken from iqol: https://github.com/dustdustinthewind/IQoLDecompiled/blob/main/MainMenu/BuildInfo.cs

using System;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo : MonoBehaviour
{
	private string gameVersion;
	
	public BuildInfo()
	{
		gameVersion = string.Empty;
	}

	private void Update() {}

	private void Start()
	{
		// C KHB blah blah
		// dust blah blah
		// pulsarc3 alpha
		Text component = base.GetComponent<Text>();
		component.text = component.text.Replace("2019", "2020") + "\ndust 2020-2023\n" + this.gameVersion;
		this.gameVersion = "pulsarc3 alpha";//Helpers.GetGameVersion();
		
		// credit text when click on
		((GameObject)base.GetComponent<Button>().onClick.GetPersistentTarget(0)).GetComponentInChildren<Text>().text = "Code, design:\n• Oxy949 (Konstantin Kustov)\n• dust\n\nMaps difficulty algorithm:\n• Dekolator\n• Nikl\n\nSpecial thanks:\n• Dymchick1\n• Darina.Wolf\n• Digit Spirit\n\nThanks for playing!";
		
		// idk if needed heh
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
	}
}
