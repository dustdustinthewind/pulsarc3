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

	private void PLIKADJCEPO()
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

	private void GFBOBIBIOMC()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("Texture2");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-103);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void CPAJLKHMOJB()
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

	private void GAOOPEEBGJA()
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

	private void MLLPGPANCHI()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("SetSunMaxSize");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-75);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void ODGMCJILIHF()
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
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -107);
		renderTexture.name = "_Value4";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(528f, 308f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_LightIntensity")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void LNIOFCGDDKP()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("maps.");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-123);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-65);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void JHJGJJKELJM()
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

	public void MCKLKGMHGJB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Music End";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[0];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "_Green_R";
				array[3] = num.ToString();
				array[5] = "_TimeX";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -91);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[3] = "_FlipAlphaMask";
			array2[7] = num.ToString();
			array2[4] = "_MainTex2";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void EFIECJGFGNN(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_Value2";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[6] = " : ";
				array[4] = num.ToString();
				array[5] = "OpCreateRoom()";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -72);
			string[] array2 = new string[8];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "ScreenResolutionPanel";
			array2[4] = num.ToString();
			array2[1] = "[PlayerController] ";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void ALMGMOOHLMA()
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

	private void HLCMOFCEJLP()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_ScreenResolution");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)99;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void FGBDGGCBFLP()
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

	public void DIEPEDEBLCL(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = NKCGNACKBCO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "#ok";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
				array[2] = num.ToString();
				array[1] = "CameraFilterPack/Drawing_Paper2";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -69);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[8] = ".lastCheckpoint.playerdistance";
			array2[4] = num.ToString();
			array2[7] = "win";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void HIFPDKKBDHJ()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("StartButton");
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
			sSAARenderTarget.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void CCPEDDLAMIB()
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

	public void EJFGHDJBFOA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = MGAAIBEFBMC(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + ".status";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[7];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[3] = "PointsScoreText";
				array[3] = num.ToString();
				array[0] = "_Value3";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -63);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "bans.viewed.";
			array2[8] = num.ToString();
			array2[1] = "Finished";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void GGOFDJNNGJG(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = NKCGNACKBCO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Preparing configuration";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[0] = "\\n";
				array[1] = num.ToString();
				array[0] = "win";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -199);
			string[] array2 = new string[5];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[2] = "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
			array2[3] = num.ToString();
			array2[0] = "/";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void FBFJNCBLGFE(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = OACNGCEJIIF(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_FixDistance";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[1] = "_MatrixColor";
				array[8] = num.ToString();
				array[4] = "player.arrow";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -111);
			string[] array2 = new string[3];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[6] = ", ";
			array2[7] = num.ToString();
			array2[0] = "_VelTex";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void OFMNDBNFBDJ()
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
			Debug.LogWarning(",");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -110);
		renderTexture.name = "LevelNameText";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Value2")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1489f, 1996f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_Size")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D PEKPICNMIME(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Could not execute RPC ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -39);
		renderTexture.name = "blue";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "FinalScoreSmallText")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(579f, 1592f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "#{0}")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void BILILBEBLFL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("CheckCombo");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void KGHFKHBPHEH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning(": ");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)(-88);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D PCMNPNPIIBO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_ScreenResolution");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 117);
		renderTexture.name = "_ScreenResolution";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "CameraFilterPack/Distortion_Twist_Square")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1593f, 1092f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
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

	public Texture2D JIPMODJMCBA(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Preparing content...");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -32);
		renderTexture.name = "[PlayerBase] New highscore";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Testing, a toggle has toggled [")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(133f, 1673f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "#pleasewait")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void IMGGCJICLHK()
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

	private void HNNKIOHCDKG()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("mapselector.lastSearch");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D GADHJJAGIKL(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(" not exist");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -53);
		renderTexture.name = "score";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "notready")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(946f, 882f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "File not found: {0}")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D NJJBBNNOPEN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("yes");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 54);
		renderTexture.name = "OnSerialize";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(819f, 1377f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "PlayButton")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void EBBOJPEPDCN()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning(" : ");
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
			sSAARenderTarget.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
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

	private void FPHLDMMAOEF()
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

	public void ALJHIFOGBOF(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = CMJLMAPPKJN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "f";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[0];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[8] = "Scale environment object by the values";
				array[3] = num.ToString();
				array[6] = "_Offsets";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -87);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[8] = "[";
			array2[4] = num.ToString();
			array2[4] = "_MainTex2";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void LLAJPKFNDIG()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("[MapEditor] Loading map: ");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)66;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void BOLBPPHJBMI()
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

	public void EDEEACBFLLB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = BEPBCKNNOKI(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "inventory.selected.";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[6];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[4] = "Joystick1Button5";
				array[5] = num.ToString();
				array[2] = "skin.no_hit";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 102);
			string[] array2 = new string[2];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[5] = "_Speed";
			array2[6] = num.ToString();
			array2[1] = "_HexaColor";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D CMJLMAPPKJN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Bloom4");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 31);
		renderTexture.name = "pointBuffer";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(952f, 949f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "EventMenu")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
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

	public Texture2D JACDHDCAIGO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_EmissionColor");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -97);
		renderTexture.name = "No Name";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Drop_Near")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(487f, 594f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "y")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D POCDDNALBLE(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("settings.arcsnohitsoundtimedelay");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 64);
		renderTexture.name = "LevelConfigButton";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "No Dispatcher exists in the scene. Actions will not be invoked!")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(245f, 689f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "Tab1Content")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void CHIDAPAGIEP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = IPDGGMEKEFK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "SpawnObj";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[4];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[6] = "_ScreenResolution";
				array[7] = num.ToString();
				array[6] = "player.yellowarc";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -18);
			string[] array2 = new string[7];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[5] = "VIGNETTE_BLUR";
			array2[8] = num.ToString();
			array2[0] = "_Jitter";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D EOEBNKPBHBN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Set Object Position");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -100);
		renderTexture.name = "EnableRankingToggle";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "solo")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1681f, 1405f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "0,7,true,0")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void IABLKKAALGI()
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

	private void MLEAHDDGEMJ()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("BitsData");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)121;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
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

	public Texture2D DFANEKNGDKE(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 18);
		renderTexture.name = "Observed type is not serializable: ";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "UseScanLineSize")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(63f, 1089f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "CameraFilterPack/Gradients_Therma")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
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

	public Texture2D MCCLGPDABKG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("DPADHOR");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 117);
		renderTexture.name = "Scene";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[DiscordController] Responding yes to Ask to Join request")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1594f, 294f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == ".")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D AMLJDBBPBIM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Preparing content");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 43);
		renderTexture.name = ". Client should be in a room. Current connectionStateDetailed: ";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "note.4")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1047f, 901f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "skin.hit_perfect")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D CHOFLJOLHBM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_NeighborMaxTex");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 16);
		renderTexture.name = "_MainTex2";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "/?page=ranks")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1189f, 41f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "DPADVER")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void NGEGCLCPPCD()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
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

	public Texture2D IJEHFLHANJO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("file://");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 39);
		renderTexture.name = "float,0";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "GameMessagesDurationSlider")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1660f, 270f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_BlurRadius")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D BEPBCKNNOKI(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_TimeX");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -61);
		renderTexture.name = "_Color_G";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[Up-Right-Down-Left]")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1157f, 567f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_Red_G")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D BNCKICDHIHM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -119);
		renderTexture.name = "_MaxRadiusOrKInPaper";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == ". Using max value: 255.")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(863f, 1073f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_Bullet_11")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void HNILMGEKDEC()
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

	public void PLBPHIPBEAA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JIPMODJMCBA(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "[MapEditor] Reset";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[8] = "_Level";
				array[3] = num.ToString();
				array[6] = "_ScreenResolution";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -162);
			string[] array2 = new string[8];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[3] = "PLEASE WAIT";
			array2[5] = num.ToString();
			array2[2] = "[PlayerController] ";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
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

	private void DLMPALHKMON()
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

	public Texture2D OACNGCEJIIF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(".wav");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -41);
		renderTexture.name = "Search: ";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_ScreenResolution")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1844f, 135f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "player.greenlifering")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void IDIEBLNAEIF()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("itemid");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
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

	private void LLKKGGLNIDF()
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

	public void IIIJBFGDJGG(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = DLNHCDBLAPG(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ResetSpeed";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[2];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[6] = "_DistortionSize";
				array[2] = num.ToString();
				array[8] = "Set Sun Emission";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 143);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "SaveButton";
			array2[2] = num.ToString();
			array2[6] = "(\\[ *i *\\])";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D BMAIMBGMFBB(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 106);
		renderTexture.name = ".icon";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "settings.shaders")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(275f, 99f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "challenges.")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D AKJLMMOIOCD(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -20);
		renderTexture.name = "Please specify either t or f.";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Blend")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1200f, 763f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "GraphicsQualitySlider")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
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

	public void HHBEFOLGBGP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = CHOFLJOLHBM(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Other";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms";
				array[7] = num.ToString();
				array[1] = "No";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -25);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[2] = "/";
			array2[1] = num.ToString();
			array2[4] = "3d text";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void AONJNAGNLIH()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("DPADHOR");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)85;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = (HideFlags)98;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	private void GKNKIIEALCH()
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

	private void HONBLGFDMLL()
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

	public Texture2D MGAAIBEFBMC(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(".");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -128);
		renderTexture.name = "_MainTex2";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "1.87")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.Alpha8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(651f, 959f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_MainTex2")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D LNCHHJAKOMO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(" ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 95);
		renderTexture.name = "SlidingArea";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Already exist!")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1570f, 93f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "{0} seconds ago")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void LHFFAFIOADE(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = NJJBBNNOPEN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "settings.crosshairopacity";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[5];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[3] = "maps.";
				array[0] = num.ToString();
				array[4] = "CameraFilterPack_TV_Noise3";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 162);
			string[] array2 = new string[7];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[3] = "/icon";
			array2[6] = num.ToString();
			array2[0] = "_Blue_G";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	private void JOONHGHGKKF()
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

	public Texture2D GBPMKPOAGLH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value5");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -115);
		renderTexture.name = "Y";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Value3")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1568f, 311f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "/icon")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D GFAPADNBEMG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("settings.shaders");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 96);
		renderTexture.name = "Set Particles Emission";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "deletemap")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1045f, 998f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "_ScreenResolution")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void PPGEGFMNIKO()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_BlurArea");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-80);
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = ~HideFlags.HideInHierarchy;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public void EILMFGOCGFB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = JACDHDCAIGO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "<b>";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[4] = "_TimeX";
				array[3] = num.ToString();
				array[1] = "_Distance";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -184);
			string[] array2 = new string[3];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "_FarCamera";
			array2[4] = num.ToString();
			array2[5] = "player.bluelifering";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void HNDNIPLDDIC(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = CMJLMAPPKJN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "#availablechallenges";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[2];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[8] = "player.crystal";
				array[1] = num.ToString();
				array[6] = "_Value4";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 109);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[5] = "Set crosshair emission (glow)";
			array2[8] = num.ToString();
			array2[6] = "Fade";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D ICKKMILLAMF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 52);
		renderTexture.name = "offsets";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "maps.")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(769f, 482f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "CameraFilterPack/Oculus_NightVision5")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public Texture2D DLNHCDBLAPG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("CameraFilterPack/Blend2Camera_LighterColor");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 27);
		renderTexture.name = "CameraFilterPack/BlurTiltShift_V";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "\" to target: ")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1384f, 847f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "RarityImage")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void OMHCFMDMNGC(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = POCDDNALBLE(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ERROR";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[0];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "_EmissionColor";
				array[0] = num.ToString();
				array[7] = "_Parameter";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -165);
			string[] array2 = new string[6];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[7] = "_EdgeWeight";
			array2[4] = num.ToString();
			array2[0] = "_Value4";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void EFMODJEDBCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D highScaledScreenshot = GetHighScaledScreenshot(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = highScaledScreenshot.EncodeToPNG();
		Object.DestroyImmediate(highScaledScreenshot);
		string path = Application.dataPath + BNJFKKGOACF + "In Main Menu";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[1] = "[MapsData] Bad map: ";
				array[4] = num.ToString();
				array[7] = "mapselector.filter.subscribedonly";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -113);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[5] = "_Offsets";
			array2[0] = num.ToString();
			array2[0] = "Item invalid. Make sure your mod contains at leats one file.";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public void JKLKJODEGCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = EOEBNKPBHBN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ComboScoreText";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[2] = "_Offsets";
				array[1] = num.ToString();
				array[5] = "inventory.selected.";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -104);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[6] = "Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()";
			array2[5] = num.ToString();
			array2[8] = "https://twitch.tv/intralism";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D OKFFJKINMAH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Reset All");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 53);
		renderTexture.name = "settings.gamemessagesduration";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "GlassesColor2")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(702f, 1348f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "\n")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void BLIFPBNDNIJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = BEPBCKNNOKI(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "CameraFilterPack/Vision_AuraDistortion";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[4];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = ".sawoutdatedmessage";
				array[2] = num.ToString();
				array[3] = "[Right]";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 86);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[0] = "settings.shaders";
			array2[8] = num.ToString();
			array2[2] = "_TimeX";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	public Texture2D NKCGNACKBCO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("#EA4137");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -95);
		renderTexture.name = "_Value13";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "CameraFilterPack_Glasses_On3")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(258f, 1132f, CJDDBGPKDLP, PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "Start")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	private void FDIJLKIIMLL()
	{
		Camera component = GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("#TBD");
		}
		else if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = Filter;
			internal_SSAA.ChangeScale(Scale);
			internal_SSAA.Format = renderTextureFormat;
		}
		else
		{
			SSAARenderTarget sSAARenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			sSAARenderTarget.hideFlags = HideFlags.None;
			sSAARenderTarget.Scale = Scale;
			sSAARenderTarget.TargetTexture = component.targetTexture;
			sSAARenderTarget.Filter = Filter;
			sSAARenderTarget.Format = renderTextureFormat;
		}
	}

	public Texture2D JHLLOHINKHK(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 113);
		renderTexture.name = "_TimeX";
		List<Camera> list = new List<Camera>((Camera[])Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1254f, 1693f, CJDDBGPKDLP, PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera item in list)
		{
			if (item.targetTexture != null && item.targetTexture.name == "settings.enablehitsoundsinrelax")
			{
				item.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	public void GIKIMOHMMKD(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = PEKPICNMIME(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "BitsData";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[1];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "GameScene";
				array[2] = num.ToString();
				array[0] = "_ScreenResolution";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 109);
			string[] array2 = new string[1];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "_Max";
			array2[6] = num.ToString();
			array2[4] = "mapselector.filter.subscribedonly";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}
}
