// ResourcesManager
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using NAudio.Wave;
using Steamworks;
using UnityEngine;

public class ResourcesManager : Singleton<ResourcesManager>
{
	public enum ResourceType
	{
		Image,
		Sound,
		Model,
		Text
	}

	private Dictionary<string, object> EPLOIIAGDDM = new Dictionary<string, object>();

	private Dictionary<CSteamID, Sprite> ANAALDPGPOA = new Dictionary<CSteamID, Sprite>();

	private Dictionary<CSteamID, string> NJFPKGJNKJE = new Dictionary<CSteamID, string>();

	public IEnumerator DJABNEFPPMO(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		Sprite sprite = null;
		WWW wWW = new WWW(NBEBMKFPBEP);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			Texture2D texture2D = new Texture2D(2, 2);
			wWW.LoadImageIntoTexture(texture2D);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
			yield return sprite;
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + wWW.error + " url: " + NBEBMKFPBEP);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
		}
	}

	public IEnumerator PreloadAudio(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	private void OnDestroy()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator LEPNFLHCLFD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	public static object OJOLHAGIGOL(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator LoadSpriteFromURL(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		Sprite sprite = null;
		WWW wWW = new WWW(NBEBMKFPBEP);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			Texture2D texture2D = new Texture2D(2, 2);
			wWW.LoadImageIntoTexture(texture2D);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
			yield return sprite;
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + wWW.error + " url: " + NBEBMKFPBEP);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
		}
	}

	public new void POHMFMNEPKK()
	{
		base.Awake();
		UnityThread.initUnityThread();
	}

	public void LoadTextWithLocalizationFix(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string text = string.Empty;
		if (File.Exists(fullName))
		{
			bool flag = true;
			string[] array = File.ReadAllLines(fullName);
			foreach (string text2 in array)
			{
				if (flag)
				{
					text = text + text2 + ",viewkeys" + Environment.NewLine;
					flag = false;
				}
				else
				{
					text = text + text2 + "," + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load text error: not found");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = text;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
		}
	}

	public static Sprite ILJDACNNBEM(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator ICKJFFAMCCF(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) && !AAGGLAGLINL)
		{
			yield break;
		}
		while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
		Texture2D steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
		steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
		steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
		Sprite value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, steamImageAsTexture2D.width, steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
		{
			if (AAGGLAGLINL)
			{
				ANAALDPGPOA[GDOHPDHLPBC] = value;
			}
		}
		else
		{
			ANAALDPGPOA.Add(GDOHPDHLPBC, value);
		}
	}

	public void NICFFHDMGKO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string text = string.Empty;
		if (File.Exists(fullName))
		{
			bool flag = false;
			string[] array = File.ReadAllLines(fullName);
			foreach (string text2 in array)
			{
				if (flag)
				{
					text = text + text2 + " " + Environment.NewLine;
					flag = false;
				}
				else
				{
					text = text + text2 + "settings.enablerankingnotifications" + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("Prints list of commands");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = text;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
		}
	}

	public IEnumerator HCCKAAFGAEO(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) && !AAGGLAGLINL)
		{
			yield break;
		}
		while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
		{
			yield return new WaitForSeconds(0.1f);
		}
		string friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
		if (NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
		{
			if (AAGGLAGLINL)
			{
				NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
			}
		}
		else
		{
			NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
		}
	}

	private void GKAJONDPPGI()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static string EGOAKNGHKIC(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.FJNEIAJPLDF(RanksSystem.GetLoadedRank(HFEFHOPOLIK).AKPPHHNEAHG(), DPGCGEPHEGF));
			string[] array = new string[5];
			array[1] = "_Value";
			array[0] = text;
			array[5] = "Screen Space Reflections";
			array[7] = MGDEMPDELMB(HFEFHOPOLIK);
			array[8] = "[MapEditor] Prepairing map editor...";
			return string.Concat(array);
		}
		return CPMPAGCCNDI(HFEFHOPOLIK);
	}

	public void NGEPNABHOAD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string text = string.Empty;
		if (File.Exists(fullName))
		{
			bool flag = true;
			string[] array = File.ReadAllLines(fullName);
			for (int i = 1; i < array.Length; i++)
			{
				string text2 = array[i];
				if (flag)
				{
					text = text + text2 + "Reconnect() disabled the offline mode. No longer offline." + Environment.NewLine;
					flag = true;
				}
				else
				{
					text = text + text2 + "[Right]" + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("inventory.selected.");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = text;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
		}
	}

	public static string GetLoadedSteamPlayername(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "#" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).place;
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "#TBD";
		}
		return null;
	}

	public static object EJAFPGNGGOC(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator KHDOGONJJMO(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		Sprite sprite = null;
		WWW wWW = new WWW(NBEBMKFPBEP);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			Texture2D texture2D = new Texture2D(2, 2);
			wWW.LoadImageIntoTexture(texture2D);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
			yield return sprite;
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + wWW.error + " url: " + NBEBMKFPBEP);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
		}
	}

	private void NDAAHMPLEBP()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator LoadAvatar(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) && !AAGGLAGLINL)
		{
			yield break;
		}
		while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
		Texture2D steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
		steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
		steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
		Sprite value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, steamImageAsTexture2D.width, steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
		{
			if (AAGGLAGLINL)
			{
				ANAALDPGPOA[GDOHPDHLPBC] = value;
			}
		}
		else
		{
			ANAALDPGPOA.Add(GDOHPDHLPBC, value);
		}
	}

	public IEnumerator NPPBJDHKOEH(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	public IEnumerator LoadSkinSound(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL));
		}
	}

	public void LoadText(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load text error: not found");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static string CNAEIKOJBLH(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.NCJKHNEFEBG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).OOJDGAKENIJ(), DPGCGEPHEGF));
			string[] array = new string[3];
			array[1] = "CameraFilterPack/Vision_Aura";
			array[0] = text;
			array[8] = "_TimeX";
			array[2] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[6] = "_Value";
			return string.Concat(array);
		}
		return null;
	}

	public static string CPMPAGCCNDI(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "LevelEditor/icons" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).GABCIGIFNCK();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.";
		}
		return null;
	}

	public void CGHLKOHLEEL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string text = string.Empty;
		if (File.Exists(fullName))
		{
			bool flag = true;
			string[] array = File.ReadAllLines(fullName);
			for (int i = 0; i < array.Length; i += 0)
			{
				string text2 = array[i];
				if (flag)
				{
					text = text + text2 + "plogs" + Environment.NewLine;
					flag = false;
				}
				else
				{
					text = text + text2 + "CheckpointsScoreText" + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("CameraFilterPack_eyes_vision_1");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = text;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
		}
	}

	public static Sprite CNDCEPAGAKD(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	private void KEBNPDKADDF()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static object BKKJBPILALK(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public void ODGICECFMAG(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("colorD");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static Sprite GetLoadedAvatar(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	private void BFFAPIPFKDN()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static string JOKAPLHKDGL(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.NCJKHNEFEBG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).BIOCCNINILO(), DPGCGEPHEGF));
			string[] array = new string[7];
			array[1] = "MenuScene";
			array[1] = text;
			array[3] = "_Value6";
			array[6] = MMEJMGBMJED(HFEFHOPOLIK);
			array[8] = "[EditorEvent] Exception: ";
			return string.Concat(array);
		}
		return PHGHNGJBNPI(HFEFHOPOLIK, false);
	}

	public void OFAELGIDIDE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("R:");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static string LCEFBFFFFLJ(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "maps." + RanksSystem.GetLoadedRank(HFEFHOPOLIK).GABCIGIFNCK();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "solo";
		}
		return null;
	}

	public IEnumerator KPOMGOOBHCO(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		Sprite sprite = null;
		WWW wWW = new WWW(NBEBMKFPBEP);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			Texture2D texture2D = new Texture2D(2, 2);
			wWW.LoadImageIntoTexture(texture2D);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
			yield return sprite;
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + wWW.error + " url: " + NBEBMKFPBEP);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
		}
	}

	public IEnumerator BBMNIOLLFGP(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	public IEnumerator MIDDHBHKKKN(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	public IEnumerator NHLDDBNIHOD(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
	}

	public IEnumerator ABDEGFBDIBO(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL));
		}
	}

	public IEnumerator HJMKIDOOLME(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		Sprite sprite = null;
		WWW wWW = new WWW(NBEBMKFPBEP);
		yield return wWW;
		if (string.IsNullOrEmpty(wWW.error))
		{
			Texture2D texture2D = new Texture2D(2, 2);
			wWW.LoadImageIntoTexture(texture2D);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
			yield return sprite;
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + wWW.error + " url: " + NBEBMKFPBEP);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
		}
	}

	public new void GCDNONIKKLI()
	{
		base.Awake();
		UnityThread.INEPKHCFFCJ();
	}

	public static Sprite OPBBEMMCIAK(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator CKBLKNJHNCE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	public void GFBOAHOPOLL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("CameraFilterPack/Drawing_Laplacian");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public new void Awake()
	{
		base.Awake();
		UnityThread.initUnityThread();
	}

	public static object LHIHFLJHGKJ(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator CGBLAFCGMJL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip LPEOPOBBFNB = null;
		if (new FileInfo(BNJFKKGOACF).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + BNJFKKGOACF);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
			}
			else
			{
				LPEOPOBBFNB = wWW.GetAudioClip(false, ONHDMKDAANN);
				yield return LPEOPOBBFNB;
			}
		}
		else
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				string HIJLDLAADEA = Path.GetFileNameWithoutExtension(BNJFKKGOACF);
				AudioFileReader JCFGBIIOJHO = new AudioFileReader(BNJFKKGOACF);
				float[] HMJGMFEOIBN = new float[JCFGBIIOJHO.Length / 8];
				JCFGBIIOJHO.Read(HMJGMFEOIBN, 0, (int)JCFGBIIOJHO.Length / 8);
				UnityThread.executeInUpdate(delegate
				{
					AudioClip audioClip = AudioClip.Create(HIJLDLAADEA, (int)JCFGBIIOJHO.Length / 8, JCFGBIIOJHO.WaveFormat.Channels, JCFGBIIOJHO.WaveFormat.SampleRate, false);
					audioClip.SetData(HMJGMFEOIBN, 0);
					if (audioClip.loadState == AudioDataLoadState.Loaded)
					{
						LPEOPOBBFNB = audioClip;
						ThreadPool.QueueUserWorkItem(delegate
						{
							JCFGBIIOJHO.Dispose();
						});
					}
				});
			});
			yield return new WaitUntil(() => LPEOPOBBFNB != null);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = LPEOPOBBFNB;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, LPEOPOBBFNB);
		}
	}

	public IEnumerator BNBOPAJCKNA(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip LPEOPOBBFNB = null;
		if (new FileInfo(BNJFKKGOACF).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + BNJFKKGOACF);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
			}
			else
			{
				LPEOPOBBFNB = wWW.GetAudioClip(false, ONHDMKDAANN);
				yield return LPEOPOBBFNB;
			}
		}
		else
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				string HIJLDLAADEA = Path.GetFileNameWithoutExtension(BNJFKKGOACF);
				AudioFileReader JCFGBIIOJHO = new AudioFileReader(BNJFKKGOACF);
				float[] HMJGMFEOIBN = new float[JCFGBIIOJHO.Length / 8];
				JCFGBIIOJHO.Read(HMJGMFEOIBN, 0, (int)JCFGBIIOJHO.Length / 8);
				UnityThread.executeInUpdate(delegate
				{
					AudioClip audioClip = AudioClip.Create(HIJLDLAADEA, (int)JCFGBIIOJHO.Length / 8, JCFGBIIOJHO.WaveFormat.Channels, JCFGBIIOJHO.WaveFormat.SampleRate, false);
					audioClip.SetData(HMJGMFEOIBN, 0);
					if (audioClip.loadState == AudioDataLoadState.Loaded)
					{
						LPEOPOBBFNB = audioClip;
						ThreadPool.QueueUserWorkItem(delegate
						{
							JCFGBIIOJHO.Dispose();
						});
					}
				});
			});
			yield return new WaitUntil(() => LPEOPOBBFNB != null);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = LPEOPOBBFNB;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, LPEOPOBBFNB);
		}
	}

	public static string NKIPIDLDKLM(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.FJNEIAJPLDF(RanksSystem.GetLoadedRank(HFEFHOPOLIK).GODOLFFCAIL(), DPGCGEPHEGF));
			string[] array = new string[2];
			array[0] = "_Bloom1";
			array[1] = text;
			array[8] = "Prints the number of logs currently held by DebugLogs";
			array[0] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[1] = "offsets";
			return string.Concat(array);
		}
		return null;
	}

	public IEnumerator LoadSprite(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		Texture2D texture2D = null;
		Sprite value = null;
		if (File.Exists(BNJFKKGOACF))
		{
			byte[] data = File.ReadAllBytes(BNJFKKGOACF);
			texture2D = new Texture2D(2, 2);
			texture2D.LoadImage(data);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
			yield return null;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static string CKONGMGNNMJ(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.FMECGHKFKBK(RanksSystem.GetLoadedRank(HFEFHOPOLIK).GODOLFFCAIL(), DPGCGEPHEGF));
			string[] array = new string[2];
			array[1] = ".sawoutdatedmessage";
			array[1] = text;
			array[2] = "selColor";
			array[1] = CPMPAGCCNDI(HFEFHOPOLIK, false);
			array[8] = "[LevelEditorScene] Creating new item...";
			return string.Concat(array);
		}
		return GetLoadedSteamPlayername(HFEFHOPOLIK, false);
	}

	public static object GetLoadedResource(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public static string GetLoadedSteamPlayernameWithColoredRank(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			return "<color=#" + text + ">" + GetLoadedSteamPlayername(HFEFHOPOLIK) + "</color>";
		}
		return GetLoadedSteamPlayername(HFEFHOPOLIK);
	}

	public static string DNBGAHOJMCN(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.NCJKHNEFEBG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).FDMODBMKMKG(), DPGCGEPHEGF));
			string[] array = new string[6];
			array[1] = "getint";
			array[0] = text;
			array[8] = "SelectorMusicToggle";
			array[3] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[7] = "Oct";
			return string.Concat(array);
		}
		return null;
	}

	public static void HLOKBICFAOM(bool HHPGCLIABFM = false)
	{
		Debug.Log("LevelConfigButton");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator PPDNIGMHFBE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		Texture2D texture2D = null;
		Sprite value = null;
		if (File.Exists(BNJFKKGOACF))
		{
			byte[] data = File.ReadAllBytes(BNJFKKGOACF);
			texture2D = new Texture2D(2, 2);
			texture2D.LoadImage(data);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
			yield return null;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static string CFJBGBIOCDD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.FMECGHKFKBK(RanksSystem.GetLoadedRank(HFEFHOPOLIK).GODOLFFCAIL(), DPGCGEPHEGF));
			string[] array = new string[3];
			array[1] = "Exit to menu?";
			array[0] = text;
			array[2] = "HandsCountSlider";
			array[1] = MMEJMGBMJED(HFEFHOPOLIK, false);
			array[4] = "[MapEditor] Loading events...";
			return string.Concat(array);
		}
		return CPMPAGCCNDI(HFEFHOPOLIK, false);
	}

	public void NKMCMMBEHGE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("EnvironmentSlider");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public IEnumerator EGFNDLJLMKH(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
	}

	public void FHNPMJHPOAO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("editorVolume");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public new void BFFHPJMMGHD()
	{
		base.Awake();
		UnityThread.INEPKHCFFCJ();
	}

	public static string LAFPJHBICMN(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.NCJKHNEFEBG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).AKPPHHNEAHG(), DPGCGEPHEGF));
			string[] array = new string[7];
			array[1] = " ";
			array[1] = text;
			array[6] = " ";
			array[8] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[2] = "[PlayerBase] Loaded environment: ";
			return string.Concat(array);
		}
		return null;
	}

	public IEnumerator EGKFENEHDAJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL));
		}
	}

	public IEnumerator OKFHHLPPHCB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip LPEOPOBBFNB = null;
		if (new FileInfo(BNJFKKGOACF).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + BNJFKKGOACF);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
			}
			else
			{
				LPEOPOBBFNB = wWW.GetAudioClip(false, ONHDMKDAANN);
				yield return LPEOPOBBFNB;
			}
		}
		else
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				string HIJLDLAADEA = Path.GetFileNameWithoutExtension(BNJFKKGOACF);
				AudioFileReader JCFGBIIOJHO = new AudioFileReader(BNJFKKGOACF);
				float[] HMJGMFEOIBN = new float[JCFGBIIOJHO.Length / 8];
				JCFGBIIOJHO.Read(HMJGMFEOIBN, 0, (int)JCFGBIIOJHO.Length / 8);
				UnityThread.executeInUpdate(delegate
				{
					AudioClip audioClip = AudioClip.Create(HIJLDLAADEA, (int)JCFGBIIOJHO.Length / 8, JCFGBIIOJHO.WaveFormat.Channels, JCFGBIIOJHO.WaveFormat.SampleRate, false);
					audioClip.SetData(HMJGMFEOIBN, 0);
					if (audioClip.loadState == AudioDataLoadState.Loaded)
					{
						LPEOPOBBFNB = audioClip;
						ThreadPool.QueueUserWorkItem(delegate
						{
							JCFGBIIOJHO.Dispose();
						});
					}
				});
			});
			yield return new WaitUntil(() => LPEOPOBBFNB != null);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = LPEOPOBBFNB;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, LPEOPOBBFNB);
		}
	}

	public static string PHGHNGJBNPI(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "offsets" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).GODOLFFCAIL();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + " region";
		}
		return null;
	}

	public static object POBCMIMPNBF(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public static string MFGIBDEJFMA(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.NCJKHNEFEBG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).FDMODBMKMKG(), DPGCGEPHEGF));
			string[] array = new string[6];
			array[1] = "_Offsets";
			array[1] = text;
			array[3] = "_ScreenResolution";
			array[0] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[2] = "MapperNameText";
			return string.Concat(array);
		}
		return null;
	}

	public static void UnloadResources(bool HHPGCLIABFM = false)
	{
		Debug.Log("[ResourcesManager] Unloading data resources");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator LoadAudio(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip LPEOPOBBFNB = null;
		if (new FileInfo(BNJFKKGOACF).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + BNJFKKGOACF);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
			}
			else
			{
				LPEOPOBBFNB = wWW.GetAudioClip(false, ONHDMKDAANN);
				yield return LPEOPOBBFNB;
			}
		}
		else
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				string HIJLDLAADEA = Path.GetFileNameWithoutExtension(BNJFKKGOACF);
				AudioFileReader JCFGBIIOJHO = new AudioFileReader(BNJFKKGOACF);
				float[] HMJGMFEOIBN = new float[JCFGBIIOJHO.Length / 8];
				JCFGBIIOJHO.Read(HMJGMFEOIBN, 0, (int)JCFGBIIOJHO.Length / 8);
				UnityThread.executeInUpdate(delegate
				{
					AudioClip audioClip = AudioClip.Create(HIJLDLAADEA, (int)JCFGBIIOJHO.Length / 8, JCFGBIIOJHO.WaveFormat.Channels, JCFGBIIOJHO.WaveFormat.SampleRate, false);
					audioClip.SetData(HMJGMFEOIBN, 0);
					if (audioClip.loadState == AudioDataLoadState.Loaded)
					{
						LPEOPOBBFNB = audioClip;
						ThreadPool.QueueUserWorkItem(delegate
						{
							JCFGBIIOJHO.Dispose();
						});
					}
				});
			});
			yield return new WaitUntil(() => LPEOPOBBFNB != null);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = LPEOPOBBFNB;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, LPEOPOBBFNB);
		}
	}

	public IEnumerator ONIGOHEKLGE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	public static string MGDEMPDELMB(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "yyyy-MM-dd HH:mm:ss" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).OOJDGAKENIJ();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "[MenuScene] Error: ";
		}
		return null;
	}

	public IEnumerator LoadSkinSprite(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return StartCoroutine(LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
	}

	public IEnumerator IPKJDEMMLHL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip audioClip = null;
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
		}
		else
		{
			audioClip = wWW.GetAudioClip(false, true);
			yield return audioClip;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
		}
	}

	private void PINGNFLJAGB()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator PJDEBENAPAH(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		AudioClip LPEOPOBBFNB = null;
		if (new FileInfo(BNJFKKGOACF).Extension.ToLower() != ".mp3")
		{
			WWW wWW = new WWW("file://" + BNJFKKGOACF);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + wWW.error);
			}
			else
			{
				LPEOPOBBFNB = wWW.GetAudioClip(false, ONHDMKDAANN);
				yield return LPEOPOBBFNB;
			}
		}
		else
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				string HIJLDLAADEA = Path.GetFileNameWithoutExtension(BNJFKKGOACF);
				AudioFileReader JCFGBIIOJHO = new AudioFileReader(BNJFKKGOACF);
				float[] HMJGMFEOIBN = new float[JCFGBIIOJHO.Length / 8];
				JCFGBIIOJHO.Read(HMJGMFEOIBN, 0, (int)JCFGBIIOJHO.Length / 8);
				UnityThread.executeInUpdate(delegate
				{
					AudioClip audioClip = AudioClip.Create(HIJLDLAADEA, (int)JCFGBIIOJHO.Length / 8, JCFGBIIOJHO.WaveFormat.Channels, JCFGBIIOJHO.WaveFormat.SampleRate, false);
					audioClip.SetData(HMJGMFEOIBN, 0);
					if (audioClip.loadState == AudioDataLoadState.Loaded)
					{
						LPEOPOBBFNB = audioClip;
						ThreadPool.QueueUserWorkItem(delegate
						{
							JCFGBIIOJHO.Dispose();
						});
					}
				});
			});
			yield return new WaitUntil(() => LPEOPOBBFNB != null);
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = LPEOPOBBFNB;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, LPEOPOBBFNB);
		}
	}

	public static string GetLoadedSteamPlayernameColored(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			return "<color=#" + text + ">" + Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "</color>";
		}
		return null;
	}

	private void Update()
	{
	}

	public void BJBCFBNIAMF(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("curScn");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public IEnumerator LoadSteamPlayername(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) && !AAGGLAGLINL)
		{
			yield break;
		}
		while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
		{
			yield return new WaitForSeconds(0.1f);
		}
		string friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
		if (NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
		{
			if (AAGGLAGLINL)
			{
				NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
			}
		}
		else
		{
			NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
		}
	}

	public new void GGHEPDCEHCK()
	{
		base.Awake();
		UnityThread.INEPKHCFFCJ();
	}

	public IEnumerator OCOBGIGKDBC(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default") + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return StartCoroutine(LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL));
		}
	}

	public static object BBDAJIDMBNJ(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator GLPHAEGKPNB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			yield break;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		Texture2D texture2D = null;
		Sprite value = null;
		if (File.Exists(BNJFKKGOACF))
		{
			byte[] data = File.ReadAllBytes(BNJFKKGOACF);
			texture2D = new Texture2D(2, 2);
			texture2D.LoadImage(data);
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		}
		else
		{
			Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
			yield return null;
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static string MMEJMGBMJED(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "PublishButton" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).AKPPHHNEAHG();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_TimeX";
		}
		return null;
	}

	public static object PDMEEIAKCJH(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	private void OBAEDJJDCPN()
	{
	}

	public IEnumerator DIELOLGBBIJ(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) && !AAGGLAGLINL)
		{
			yield break;
		}
		while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
		Texture2D steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
		steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
		steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
		Sprite value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, steamImageAsTexture2D.width, steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		if (ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
		{
			if (AAGGLAGLINL)
			{
				ANAALDPGPOA[GDOHPDHLPBC] = value;
			}
		}
		else
		{
			ANAALDPGPOA.Add(GDOHPDHLPBC, value);
		}
	}

	public static object MJGKEEAOAAD(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public void DBBMKJAEEAE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) && !AAGGLAGLINL)
		{
			return;
		}
		if (!NFJAJLPOOCA)
		{
			BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
		}
		string fullName = new FileInfo(BNJFKKGOACF).FullName;
		string value = string.Empty;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("value");
		}
		if (EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			if (AAGGLAGLINL)
			{
				EPLOIIAGDDM[HFEFHOPOLIK] = value;
			}
		}
		else
		{
			EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
		}
	}

	public static object MACOLLJOENJ(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}
}
