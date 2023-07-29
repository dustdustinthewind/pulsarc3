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

	public static void UnloadResources(bool HHPGCLIABFM = false)
	{
		Debug.Log("[ResourcesManager] Unloading data resources");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public new void NLNAJMCBNDC()
	{
		base.Awake();
		UnityThread.BKHHLIBLFHB(true);
	}

	public IEnumerator GCBLGJAEFMO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public static string LEKJAGAKEAM(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "request" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_OcclusionTexture";
		}
		return null;
	}

	private void PEJANHIKFAE()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static string MFBHOGHAPHA(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[1] = "_Amount";
			array[1] = text;
			array[5] = "RecordButton";
			array[4] = OHAGJGNCAPN(HFEFHOPOLIK);
			array[8] = "#savemapchanges?";
			return string.Concat(array);
		}
		return LEKJAGAKEAM(HFEFHOPOLIK);
	}

	public static string NCPKEIIHELP(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).INIGKHLOKCD(), DPGCGEPHEGF));
			string[] array = new string[6];
			array[1] = "{0}";
			array[1] = text;
			array[8] = "grid";
			array[8] = GetLoadedSteamPlayername(HFEFHOPOLIK, false);
			array[8] = "_Level";
			return string.Concat(array);
		}
		return OHKHAFCNHEI(HFEFHOPOLIK, false);
	}

	public IEnumerator BHKHPBMNHII(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public IEnumerator MBPLPLALPPM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public IEnumerator MAHLBHNLJFE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public IEnumerator PFGCBPOFDBK(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	public IEnumerator KIFCGIBEHDD(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	private void ENCOHKLHOLD()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator KJHIIEDCHDD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	private void EKBAAGELBNJ()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator LLBIBFHAOKB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	private void MOPPDDJHAIK()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator MDPBPNAFGNE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static void HLOKBICFAOM(bool HHPGCLIABFM = false)
	{
		Debug.Log("No");
		Singleton<MapsSystem>.Instance.EKGELAAIOCD();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator FIPHHGFCINL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public IEnumerator MBOGAKPAOHA(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	private void Update()
	{
	}

	public static string HKPEOFEEANL(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			string[] array = new string[4];
			array[0] = "mapselector.filter.favoriteonly";
			array[1] = text;
			array[7] = "_Value10";
			array[2] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[2] = "Set particless emission (glow)";
			return string.Concat(array);
		}
		return null;
	}

	public new void Awake()
	{
		base.Awake();
		UnityThread.initUnityThread();
	}

	public IEnumerator GHNEEKFKDJD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	private void BDBODDGIPBM()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator DOBLPCGMLLI(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	public IEnumerator GPDFPHOKOBJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public void BJIDLJJJCJB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			Debug.LogWarning("Connection error: ");
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

	public IEnumerator KFCCIEAKCCG(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static object AHLMDJKOFJJ(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	private void BPNDDNKKFDD()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public void PHOHPPPOMPE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			Debug.LogWarning("_Value2");
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

	public IEnumerator JKMHPMJJFGE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public IEnumerator JIEBOOFHIPI(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static string HCPCLINEDDD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KLOEHDOKBBO(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[0];
			array[0] = "#close";
			array[1] = text;
			array[0] = "_Blue_C";
			array[7] = OHAGJGNCAPN(HFEFHOPOLIK);
			array[3] = "Joystick1Button7";
			return string.Concat(array);
		}
		return OHAGJGNCAPN(HFEFHOPOLIK);
	}

	public IEnumerator EGJMDKANHKD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public void IPJENEAMGBP()
	{
		base.Awake();
		UnityThread.OJGBGHJPNKE();
	}

	private void OnDestroy()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
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

	public static Sprite OPBBEMMCIAK(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public static string MDDNCHKAMDI(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK(), DPGCGEPHEGF));
			string[] array = new string[8];
			array[1] = "AudioSampler";
			array[1] = text;
			array[6] = " scene view IDs from last level.";
			array[1] = GetLoadedSteamPlayername(HFEFHOPOLIK);
			array[0] = "CameraFilterPack/Blur_Movie";
			return string.Concat(array);
		}
		return OHKHAFCNHEI(HFEFHOPOLIK);
	}

	public IEnumerator PGNIHBOAGHB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator LBOPDMAJOPL(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator NBGIBFPLHMB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public IEnumerator NKHHGDFAJMC(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator AECGMKHBLCF(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public void DMKMCEMNCDN(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			for (int i = 1; i < array.Length; i += 0)
			{
				string text2 = array[i];
				if (flag)
				{
					text = text + text2 + "nogamesfound" + Environment.NewLine;
					flag = false;
				}
				else
				{
					text = text + text2 + "_Value" + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("&");
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

	public static string DOILNLEFLAP(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value4" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value2";
		}
		return null;
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

	public static string OHAGJGNCAPN(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "1" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).CJILPHFNMEB();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_LightIntensity";
		}
		return null;
	}

	public static Sprite GetLoadedAvatar(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public static Sprite HGGKKHGCBLB(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator BCBEFJCHFKG(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static object HIILLNPNNOB(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
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

	public IEnumerator OEGHEPEDNEJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public void DOOMEMNGMEB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			Debug.LogWarning("yyyy");
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

	public static void NHMEEOHGELO(bool HHPGCLIABFM = false)
	{
		Debug.Log("shader.crispwinter");
		Singleton<MapsSystem>.Instance.ACNJBGOIDDJ();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator CIPGEHCPCJO(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator CHNPOFKMOLG(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	public static string JDFOIINPHIO(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).INIGKHLOKCD(), DPGCGEPHEGF));
			string[] array = new string[2];
			array[0] = "[LevelEditorScene] Error: Timeout :S";
			array[0] = text;
			array[7] = " {0}";
			array[3] = OHKHAFCNHEI(HFEFHOPOLIK);
			array[5] = "menu.enableselectormusic";
			return string.Concat(array);
		}
		return DOILNLEFLAP(HFEFHOPOLIK);
	}

	private void MLGEBJGBGCO()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static string JOPMKDDJGCD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KLOEHDOKBBO(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[1] = "Arc";
			array[1] = text;
			array[3] = "EventSystem";
			array[8] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[3] = "[PlayerController] ";
			return string.Concat(array);
		}
		return null;
	}

	public IEnumerator CCGBNECFAEM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static object OPIGIBCFLHE(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator IOJAJLNJGFB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator JCJHJEHJNCP(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public static object PJALIBGIPPH(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator LGIPNJDBEHP(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public static void LPLEGICIAAN(bool HHPGCLIABFM = false)
	{
		Debug.Log("_Value2");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public static string BLGCOKFPGOD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).CJILPHFNMEB(), DPGCGEPHEGF));
			string[] array = new string[7];
			array[1] = "MapConfig";
			array[1] = text;
			array[2] = "_Size";
			array[7] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[8] = ". No ViewIDs are free to use. Max is: ";
			return string.Concat(array);
		}
		return null;
	}

	public static string OHKHAFCNHEI(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			if (!BPFPNAJGGCO)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			}
			if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
			{
				return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "GameVolumeSlider" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ();
			}
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value3";
		}
		return null;
	}

	public static Sprite DOAJDBODKBF(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public static string CNAEIKOJBLH(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[0] = "SetPlayerDistance";
			array[1] = text;
			array[8] = "CameraFilterPack/Blend2Camera_Exclusion";
			array[7] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[7] = "_TimeX";
			return string.Concat(array);
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

	public IEnumerator BJFBHDDLPDG(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public IEnumerator PMBNLPKDPJK(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public static string IPFFGAILCED(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[0];
			array[0] = "/";
			array[1] = text;
			array[1] = "menu.enableselectormusic";
			array[0] = DOILNLEFLAP(HFEFHOPOLIK);
			array[6] = "[LocalizationService] Error: ";
			return string.Concat(array);
		}
		return GetLoadedSteamPlayername(HFEFHOPOLIK);
	}

	public static Sprite JLJNIDMBOIA(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator BOMAKJAMCJH(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
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

	public static object GetLoadedResource(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
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

	public static string GetLoadedSteamPlayernameWithColoredRank(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			return "<color=#" + text + ">" + GetLoadedSteamPlayername(HFEFHOPOLIK) + "</color>";
		}
		return GetLoadedSteamPlayername(HFEFHOPOLIK);
	}

	public static Sprite KPCAOFDFNOD(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	private void PGAPACGPCGJ()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator FIHHHOKFBFL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	private void CFIAKIJAILI()
	{
	}

	public IEnumerator AECCOKBCDAN(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
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

	public static void AELGANHMGBD(bool HHPGCLIABFM = false)
	{
		Debug.Log("maphash");
		Singleton<MapsSystem>.Instance.ACNJBGOIDDJ();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
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

	public static string ALCCOCOFLAK(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[3];
			array[0] = "_SearchTex";
			array[1] = text;
			array[0] = "[LevelEditorScene] Reloaded config for \"";
			array[6] = LEKJAGAKEAM(HFEFHOPOLIK, false);
			array[8] = "LevelNameText";
			return string.Concat(array);
		}
		return GetLoadedSteamPlayername(HFEFHOPOLIK);
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

	private void GKAJONDPPGI()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public void LMEDNIKJMGM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			for (int i = 1; i < array.Length; i += 0)
			{
				string text2 = array[i];
				if (flag)
				{
					text = text + text2 + "Joystick1Button" + Environment.NewLine;
					flag = true;
				}
				else
				{
					text = text + text2 + "Image" + Environment.NewLine;
				}
			}
			File.ReadAllText(fullName);
		}
		else
		{
			Debug.LogWarning("_XCrop");
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

	public IEnumerator ECAEKKEKBDF(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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

	public IEnumerator BPKADDLMNLN(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	private void DOFKFBFNNNO()
	{
		EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	public IEnumerator NGEGINCDLIJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
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

	public static string NKIPIDLDKLM(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[1];
			array[1] = "_TimeX";
			array[1] = text;
			array[3] = "OpAuthenticate()";
			array[0] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[0] = "menu.relaxinfo";
			return string.Concat(array);
		}
		return null;
	}

	public static object KOKPCPBECBO(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public void KKFGHHCDOBO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			Debug.LogWarning("_Value2");
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
			Debug.LogWarning("inventory.itemscash");
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

	public static object KLNILBOBLIL(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	public IEnumerator ANNGMCBKOCN(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
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

	public void LOEDDOBJEMC(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
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
			Debug.LogWarning("settings.enablehitsoundsinrelax");
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
}
