// SuperSampling_SSAA
using System.Collections.Generic;
using System.IO;
using SSAA;
using UnityEngine;

public class SuperSampling_SSAA : MonoBehaviour
{
	public float Scale;

	public bool unlocked;

	public SSAAFilter Filter;

	public RenderTextureFormat renderTextureFormat = RenderTextureFormat.ARGBHalf;

	public bool showScreenshot;

	public int screenshotWidth = 1920;

	public int screenshotHeight = 1080;

	public float screenshotScale = 2f;

	public int scalingSelector;

	public SSAAFilter screenshotFilter;

	public string relativeScreenshotPath = "/Assets/MyImage";

	public Texture2D CHOFLJOLHBM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -18);
		renderTexture.name = "[MapEditor] Created new map: ";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "mapselector.filter.subscribedonly")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(875f, 1966f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "CameraFilterPack/Blend2Camera_Exclusion")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void KLOLKEBAPFO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void LIFBFDKFMMH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("'{0}'{1}{2}");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-92);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D MGAAIBEFBMC(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("settings.shaders");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -76);
		renderTexture.name = "Set Sun Emission";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(467f, 1150f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "player.currentrank")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void JPPGIKCKFJL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("ResetButton");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)118;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D GetHighScaledScreenshot(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Screenshots only supported in PlayMode");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 24);
		renderTexture.name = "HighScaleShot";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "SSAARenderTargetCamera")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(0f, 0f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "HighScaleShot")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void OMHCFMDMNGC(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = BMAIMBGMFBB(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_PosX";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[2] = "SpawnObj";
				array[3] = num.ToString();
				array[2] = "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 8);
			string[] array2 = new string[7];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[4] = "[Left]";
			array2[0] = num.ToString();
			array2[4] = "Right Stick Click";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void CMIPACDBDKG(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = DFANEKNGDKE(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "[MapEditor] Prepairing map editor...";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[7];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = "CloseConnection: Only the masterclient can kick another player.";
				array[3] = num.ToString();
				array[3] = "_TimeX";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -32);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "settings.disablestoryboard";
			array2[6] = num.ToString();
			array2[4] = "_ScreenResolution";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void FLHBCHLMOFK()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("[PlayerController] ");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void PAEGLMEOKHP()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void KMOCDAOKGLI()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D OAMFALFGMAO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("sounds/hit_normal");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -107);
		renderTexture.name = "Scene";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "sprite")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1594f, 1156f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "CameraFilterPack/Blend2Camera_SplitScreen")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D ICKKMILLAMF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("DisableStoryboardToggle");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 68);
		renderTexture.name = " is set to dontSave = true, continuing loop.";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "quantity")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1682f, 151f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "0.00")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D JHLLOHINKHK(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("/");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -122);
		renderTexture.name = "_ScreenResolution";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[ResourcesManager] Load text error: not found")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(705f, 1535f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "path")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D HMNJGEHOGBH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Amount");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 78);
		renderTexture.name = "player.greenlifering";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Object ID")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(984f, 1834f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "event")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D KBCPECAGBHF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("SpawnObj");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -4);
		renderTexture.name = "received</b>\n#reason: ";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Status: ")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1721f, 1041f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "Added unlock condition")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void EMDCCBIOGHH(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = OAMFALFGMAO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ComboScoreText";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[2];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = "menu.enableselectormusic";
				array[6] = num.ToString();
				array[4] = "[Right]";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -157);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[2] = "#timeuntilend: ";
			array2[8] = num.ToString();
			array2[4] = "Object ID. Case-Sensitive";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void EFCLCPBNPOK(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = GHKOLEKHGIN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_ScreenResolution";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[4];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "EventData0DropDownList";
				array[6] = num.ToString();
				array[1] = "maps.";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -4);
			string[] array2 = new string[2];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "/../";
			array2[3] = num.ToString();
			array2[0] = "_MainTex2";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void HDHHMBEJIMB()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("\0\0");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)83;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void EAIPPDOABCG()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("?");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.HideInInspector;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void NJDLHECHNDN(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = BMAIMBGMFBB(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_Strength";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[6];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[7] = "MenuScene";
				array[6] = num.ToString();
				array[7] = "EnvironmentSlider";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -129);
			string[] array2 = new string[5];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[4] = "1087340967";
			array2[8] = num.ToString();
			array2[0] = "effector";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void FCKIJIKNMCF()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("maps.");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D LLKKHKGMGBF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value6");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -44);
		renderTexture.name = "_FixDistance";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "B")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(97f, 1304f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "offsets")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void MLLPGPANCHI()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning(".mp3");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-84);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-68);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void JAKCEFHOHIP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = ODOLMCANGJM(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_ScreenResolution";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[1];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[1] = "Right Stick Click";
				array[4] = num.ToString();
				array[3] = "PlayersScrollRectContent";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 161);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[7] = "DPADHOR";
			array2[4] = num.ToString();
			array2[3] = "editorVolume";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D ODOLMCANGJM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Intensity");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 91);
		renderTexture.name = "Set particles gravity";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Intensity")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1090f, 1380f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "/")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void HIFPDKKBDHJ()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_ColorRGB");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)122;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)79;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void OCAGANJDAKP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = IPDGGMEKEFK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "fade in duration";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[2] = "inventory.selected.";
				array[3] = num.ToString();
				array[7] = "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -69);
			string[] array2 = new string[5];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[7] = "_VignetteSettings";
			array2[1] = num.ToString();
			array2[5] = "mapselector.filter.favoriteonly";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D DFANEKNGDKE(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("on master");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 119);
		renderTexture.name = "Remove Environment Object";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_MainTex2")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1567f, 1969f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_copy")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void OnEnable()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("No Camera attached!");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void BJOHDLNDFAD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void CMIBEOJGAIL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void FCKMAOMOKNB()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("ExitButton");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-92);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D DLNHCDBLAPG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("maps.");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -128);
		renderTexture.name = "_Fade";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "New SaveGame")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(220f, 342f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == ".lastCheckpoint.lives")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void EFIECJGFGNN(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = GHKOLEKHGIN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Tab2Content";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[2];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[8] = "_Value";
				array[8] = num.ToString();
				array[5] = "note.3";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 157);
			string[] array2 = new string[1];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[4] = "_CameraClipInfo";
			array2[2] = num.ToString();
			array2[4] = "Joystick1Button11";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void BFEILOMHNPC()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D PEKPICNMIME(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("EnableRankedNotificationsToggle");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -93);
		renderTexture.name = "ResourcesConfig";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "settings.enableselectormusic")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(346f, 804f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "-")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D GHKOLEKHGIN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Bad parameters for getint! Use <key> <value>");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 122);
		renderTexture.name = "_Source";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "</color>")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(93f, 325f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_Value7")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void FKEJGBFDCAH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void BLNLHBNBKOH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("%");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-107);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void JNGMIAFLBDL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void IBFHEDHJDLH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_Value12");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)122;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-126);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void CHAKPOBHLOL(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = LLKKHKGMGBF(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + ". Check if the server is available.";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[6];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = " method: ";
				array[0] = num.ToString();
				array[0] = "_Visualize";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -123);
			string[] array2 = new string[1];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[4] = "GlassesColor";
			array2[3] = num.ToString();
			array2[0] = "_Bullet_5";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void PGGLDGKHPAM(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = LLKKHKGMGBF(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + ".";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[6];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[2] = "_Value2";
				array[2] = num.ToString();
				array[6] = "<b>Intralism Items Uploader</b> by Oxy949";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 25);
			string[] array2 = new string[8];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[3] = "_Value4";
			array2[6] = num.ToString();
			array2[6] = "float,0";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void EFMODJEDBCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = MGAAIBEFBMC(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "BitsData";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[1];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[2] = "ScoreText";
				array[2] = num.ToString();
				array[1] = "\"\"";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 92);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[3] = "traffic";
			array2[8] = num.ToString();
			array2[0] = ",";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D BMAIMBGMFBB(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("SpawnObj");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -58);
		renderTexture.name = "_ScreenResolution";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "settings.arcsnohitsoundtimedelay")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1870f, 806f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "tagElement")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void GJLKJAOBPJD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void GNMGIHFKJIJ()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void FDMAEPOHDMK()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D IPDGGMEKEFK(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Joystick1Button1");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -120);
		renderTexture.name = "ns.exitgames.com";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "tagElement")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1173f, 824f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "<color=#{0}>{1}</color>")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void LICOLMAOHKI()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("PLEASE WAIT");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D DCOAKBOJLNF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("isVisible");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 27);
		renderTexture.name = "_Value3";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "CameraFilterPack/AAA_Blood_Plus")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(195f, 139f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "Connecting")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void JKMLIADBEOB()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("CameraFilterPack/Gradients_Hue");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)106;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void HLLHJIDOOGA()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void KDBKBPCIHBL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_ScreenResolution");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)124;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-70);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void OFPPIKHNJOD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public void LNODAODPHLM(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_Offsets";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[7];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[6] = "SetBGColor";
				array[8] = num.ToString();
				array[5] = "_Size";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -68);
			string[] array2 = new string[3];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[3] = "12";
			array2[0] = num.ToString();
			array2[2] = "threshold";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void NAALCEPIHCH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void IFBPAGFGDGD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("pointBuffer");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void HPGKMAIPDEO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_PixelsPerMeterAtOneMeter");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)118;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void FJILANBCALA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = PEKPICNMIME(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "SubBass";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "_Value2";
				array[0] = num.ToString();
				array[4] = ".lastCheckpoint.comboScore";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 130);
			string[] array2 = new string[1];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "_Distortion";
			array2[6] = num.ToString();
			array2[2] = "VoteDownToggle";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void OOBIMFILNED()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_TimeX");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void TakeHighScaledShot(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D highScaledScreenshot = GetHighScaledScreenshot(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = highScaledScreenshot.EncodeToPNG();
		Object.DestroyImmediate(highScaledScreenshot);
		string path = Application.dataPath + BNJFKKGOACF + ".png";
		if (File.Exists(path))
		{
			int num = 1;
			while (File.Exists(Application.dataPath + BNJFKKGOACF + " (" + num + ").png"))
			{
				num++;
				if (num == int.MaxValue)
				{
					break;
				}
			}
			path = Application.dataPath + BNJFKKGOACF + " (" + num + ").png";
		}
		File.WriteAllBytes(path, bytes);
	}

	public void ALJHIFOGBOF(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ResourceFileSelector";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[0];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = "\\\"";
				array[6] = num.ToString();
				array[4] = "value";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -111);
			string[] array2 = new string[8];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[3] = "[MenuScene] Error: ";
			array2[2] = num.ToString();
			array2[1] = "_RotationMatrix";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void OnDisable()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D JLNHCFBELJH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("mapselector.filter.favoriteonly");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 13);
		renderTexture.name = "team";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == " - ")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1858f, 838f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_Value4")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void EKLIJCJOFAN(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = OAMFALFGMAO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_TimeX";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "SlidingArea";
				array[6] = num.ToString();
				array[6] = "#forever";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 192);
			string[] array2 = new string[6];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "_PrefilterOffs";
			array2[3] = num.ToString();
			array2[3] = "skin.";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void PLBPHIPBEAA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "<not connected>";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = "CameraFilterPack/Colors_HUE_Rotate";
				array[5] = num.ToString();
				array[1] = "CameraFilterPack/Gradients_Ansi";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -39);
			string[] array2 = new string[1];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[0] = "Image effects aren't supported on this device ({0})";
			array2[0] = num.ToString();
			array2[8] = "z";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D GMJJIJEBDMA(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("name");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -128);
		renderTexture.name = "Joystick";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[MapsData] Bad map: ")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(404f, 1027f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "Received RPC \"")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void EODOHEAKJFO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void FGOPJMGNHGO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D IJEHFLHANJO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("#ranks:");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -8);
		renderTexture.name = "LastHighScoreText";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Joystick1Button10")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.Alpha8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1063f, 1297f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "<b>#")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void PAHNKEGFGHB()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_EmissionGain");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)89;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-109);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void LPJGMGAEGED(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = OAMFALFGMAO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "PublishButton";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[3] = "Set satellite trail width";
				array[0] = num.ToString();
				array[5] = "BadgeText";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 172);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[4] = "\" for viewID ";
			array2[0] = num.ToString();
			array2[7] = "error";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D CMJOGKPCNPG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_ScreenResolution");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -32);
		renderTexture.name = "settings.enablerankingnotifications";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "maps.")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(482f, 1324f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "{0:0} hour{1}, ")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void MCKLKGMHGJB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = BMAIMBGMFBB(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "#updateoutdatedmap";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[7];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[4] = "ConfigVersionSlider";
				array[5] = num.ToString();
				array[4] = "NO";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -175);
			string[] array2 = new string[6];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[2] = ";";
			array2[0] = num.ToString();
			array2[0] = "Editor";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void JKLKJODEGCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = CHOFLJOLHBM(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Object ID. Case-Sensitive";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = "There are too many cells created by your subdivision options. Maximum allowed number of cells is ";
				array[4] = num.ToString();
				array[2] = "_TimeX";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -126);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[1] = "_Value";
			array2[3] = num.ToString();
			array2[0] = "_Near";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void JOJFHFHOCHO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void LOMDIOLNFHI()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void PKBENONAOOL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void EDBEHEKMGFH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public void KOPHAMMCLMD(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = MGAAIBEFBMC(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + ".completedMaps";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[8] = "%";
				array[0] = num.ToString();
				array[6] = " is muted";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 48);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[1] = "CameraFilterPack/Vision_Aura";
			array2[8] = num.ToString();
			array2[3] = "workshop.";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void HGDDCINLDAD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	public Texture2D LIJJINHCDMM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value7");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 85);
		renderTexture.name = "z";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Distance")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(940f, 1277f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "history")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void KFEKCJDEECK()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}

	private void DFENCIHAADO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				Object.Destroy(component2);
			}
			return;
		}
		SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
		if (component3 != null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy(component3);
			}
			else
			{
				Object.DestroyImmediate(component3);
			}
		}
	}
}
