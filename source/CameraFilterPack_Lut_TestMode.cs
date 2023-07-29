// CameraFilterPack_Lut_TestMode
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/TestMode")]
public class CameraFilterPack_Lut_TestMode : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public Texture2D LutTexture;

	private Texture3D PKINFPNDDAJ;

	[Range(0f, 1f)]
	public float Blend = 1f;

	[Range(0f, 3f)]
	public float OriginalIntensity = 1f;

	[Range(-1f, 1f)]
	public float ResultIntensity;

	[Range(-1f, 1f)]
	public float FinalIntensity;

	[Range(0f, 1f)]
	public float TestMode = 0.5f;

	private string CHMMPJKAMPM;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	public void GDBBIPKIDFE()
	{
		int num = 60;
		Color[] array = new Color[num * num * num];
		float num2 = 192f / (1170f * (float)num - 484f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1092f * num2, (float)j * 930f * num2, (float)k * 1663f * num2, 1905f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void FPBIGAKLKIG()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1035f)
			{
				HBJJOCHGOPH = 1804f;
			}
			if (PKINFPNDDAJ == null)
			{
				GIAANJAEABI(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			PGPEMMBJOOG().SetTexture("LevelEditor/icons", PKINFPNDDAJ);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Blend);
			NBPKMLMCHFN.SetFloat("settings.fps", OriginalIntensity);
			HKIMAANBGMJ().SetFloat("_VignetteTex", ResultIntensity);
			NBPKMLMCHFN.SetFloat("Use ticket: ", FinalIntensity);
			OKJOKHGJHGF().SetFloat("_Value5", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JGDCNDNCFNG()
	{
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	public bool HGHNFIPDINC(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return true;
		}
		return false;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 70f)
			{
				HBJJOCHGOPH = 797f;
			}
			if (PKINFPNDDAJ == null)
			{
				GMOFEELACOE(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			DBOLLHHMKKN().SetTexture("_TimeX", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat("_Value", Blend);
			NBPKMLMCHFN.SetFloat(".played", OriginalIntensity);
			NBPKMLMCHFN.SetFloat("SpawnObj", ResultIntensity);
			OKJOKHGJHGF().SetFloat("ZoomSpeed", FinalIntensity);
			LDNADDJMIPK().SetFloat("_TimeX", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("float,2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public void IEMGKGKEAPD(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("GenerationMenu" + MKEKCIPLJNC.name + "CameraFilterPack/Gradients_Therma");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IDHFCHEDFGF();
		}
	}

	public void MJKKNFKMNPF(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + MKEKCIPLJNC.name + "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	public void IGBAMFGIBBI()
	{
		int num = 51;
		Color[] array = new Color[num * num * num];
		float num2 = 1140f / (737f * (float)num - 442f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1885f * num2, (float)j * 1767f * num2, (float)k * 1852f * num2, 353f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void JIPEMDLKAGO()
	{
	}

	public void IEHMCDDOADL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("_PositionY" + MKEKCIPLJNC.name + "note.1");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CAIEGMIKBCN();
		}
	}

	private void CMBGFMAOEPG()
	{
	}

	public void PIBMFMFFCML(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Near" + MKEKCIPLJNC.name + "_Screen");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MGBOJGMOEGA();
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("No child content found, exiting..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("[DiscordController] Connected to {0}#{1}: {2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	public void OGPMOJMLBLL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Can't execute Disconnect() while not connected. Nothing changed. State: {0}" + MKEKCIPLJNC.name + "DPADVER");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public bool LFMAKDCJNDM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return false;
	}

	public void IOLCHIPNMCK(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("challenges." + MKEKCIPLJNC.name + "\t");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MFHOHBNFCDP();
		}
	}

	public void CDJFAFNLEDP()
	{
		int num = -88;
		Color[] array = new Color[num * num * num];
		float num2 = 1369f / (894f * (float)num - 1287f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 120f * num2, (float)j * 698f * num2, (float)k * 1733f * num2, 479f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void IBHACCEEFFI()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 370f)
			{
				HBJJOCHGOPH = 1360f;
			}
			if (PKINFPNDDAJ == null)
			{
				IEMGKGKEAPD(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			JCPDCGIJKJD().SetTexture("FullscreenToggle", PKINFPNDDAJ);
			LDNADDJMIPK().SetFloat("menutheme.letitbe", Blend);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_Screen", OriginalIntensity);
			PGPEMMBJOOG().SetFloat("0.00", ResultIntensity);
			INOBFNCKFGK().SetFloat("[Sound Manager] Audio clip is null, cannot play music", FinalIntensity);
			HCGJCMDJPGD().SetFloat("EventMenu", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public bool GDLNAHGPEPM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return false;
	}

	public bool BBECBFDCFGB(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return false;
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void EONOOEJDNEF()
	{
	}

	public void MFHOHBNFCDP()
	{
		int num = 12;
		Color[] array = new Color[num * num * num];
		float num2 = 975f / (1557f * (float)num - 111f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 532f * num2, (float)j * 806f * num2, (float)k * 1868f * num2, 76f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void OnValidate()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAAPMFBPJNH()
	{
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public void MGBOJGMOEGA()
	{
		int num = 104;
		Color[] array = new Color[num * num * num];
		float num2 = 272f / (145f * (float)num - 1600f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1433f * num2, (float)j * 383f * num2, (float)k * 292f * num2, 895f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void DCGFEIBKOBB()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	public void ADMLJFIGCJJ(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!FBBJMEBJKPI(MKEKCIPLJNC))
			{
				Debug.LogWarning("Cause: " + MKEKCIPLJNC.name + "_Extra");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			GHANEAKPIDG();
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1960f)
			{
				HBJJOCHGOPH = 962f;
			}
			if (PKINFPNDDAJ == null)
			{
				MLBEEEMAHPK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			OKJOKHGJHGF().SetTexture("CameraFilterPack/Glasses_On", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat("Data/Skins/", Blend);
			INOBFNCKFGK().SetFloat("_ScreenResolution", OriginalIntensity);
			OKJOKHGJHGF().SetFloat("_SunPosition", ResultIntensity);
			LDNADDJMIPK().SetFloat("_BlurPass", FinalIntensity);
			JCPDCGIJKJD().SetFloat("GlassDistortion", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void LIDOIDIAEJB()
	{
		int num = -50;
		Color[] array = new Color[num * num * num];
		float num2 = 1304f / (588f * (float)num - 980f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 635f * num2, (float)j * 21f * num2, (float)k * 1646f * num2, 1291f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1021f)
			{
				HBJJOCHGOPH = 228f;
			}
			if (PKINFPNDDAJ == null)
			{
				Convert(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HKIMAANBGMJ().SetTexture("You have added the SecondScrollRect to a scroll view that already has both directions selected", PKINFPNDDAJ);
			HCGJCMDJPGD().SetFloat("id", Blend);
			INOBFNCKFGK().SetFloat("_Parameter", OriginalIntensity);
			JCPDCGIJKJD().SetFloat("SetSatelliteRadius", ResultIntensity);
			JCPDCGIJKJD().SetFloat("--------------------------------", FinalIntensity);
			HCGJCMDJPGD().SetFloat("_TimeX", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 554f)
			{
				HBJJOCHGOPH = 24f;
			}
			if (PKINFPNDDAJ == null)
			{
				IEHMCDDOADL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			CIAFLBFJLEJ().SetTexture("[ERROR KEY {0}]", PKINFPNDDAJ);
			HFBJAOFLCJI().SetFloat("_Angle", Blend);
			CIAFLBFJLEJ().SetFloat("_Value7", OriginalIntensity);
			DBOLLHHMKKN().SetFloat("System.Int64", ResultIntensity);
			OKJOKHGJHGF().SetFloat("_Value", FinalIntensity);
			CBCNOEIALHB().SetFloat("_SizeX", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 114f)
			{
				HBJJOCHGOPH = 1708f;
			}
			if (PKINFPNDDAJ == null)
			{
				PGJAIMOPEJB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			LDNADDJMIPK().SetTexture("_EmissionColor", PKINFPNDDAJ);
			HCGJCMDJPGD().SetFloat("maps.", Blend);
			HCGJCMDJPGD().SetFloat("&page=", OriginalIntensity);
			CBCNOEIALHB().SetFloat("note.2", ResultIntensity);
			OKJOKHGJHGF().SetFloat("menu.playedpage", FinalIntensity);
			JLHLHKPHDFO().SetFloat("_Noise", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1521f)
			{
				HBJJOCHGOPH = 131f;
			}
			if (PKINFPNDDAJ == null)
			{
				HMGDPFBBFCC(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			EJDPNJAEAKJ().SetTexture("StartButton", PKINFPNDDAJ);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Vision_Psycho", Blend);
			JLHLHKPHDFO().SetFloat("_TimeX", OriginalIntensity);
			NBPKMLMCHFN.SetFloat("Items", ResultIntensity);
			EJDPNJAEAKJ().SetFloat("maps.", FinalIntensity);
			JLHLHKPHDFO().SetFloat("3;4;9;10;21x6", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void CEKLIKHBJFA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("#" + MKEKCIPLJNC.name + ",");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CDJFAFNLEDP();
		}
	}

	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return true;
	}

	private void ABKHEFGLAOJ()
	{
	}

	public void GHANEAKPIDG()
	{
		int num = -3;
		Color[] array = new Color[num * num * num];
		float num2 = 1975f / (1493f * (float)num - 1332f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 287f * num2, (float)j * 863f * num2, (float)k * 78f * num2, 1562f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	public void GIAANJAEABI(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("???" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	private void Update()
	{
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_FixDistance" + MKEKCIPLJNC.name + "SpawnObj");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MGBOJGMOEGA();
		}
	}

	public void HMGGOLFFLFB()
	{
		int num = 48;
		Color[] array = new Color[num * num * num];
		float num2 = 381f / (1173f * (float)num - 755f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1722f * num2, (float)j * 1724f * num2, (float)k * 821f * num2, 90f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public bool MIMOHBMBIOK(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return false;
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void MFMIODIAKNI()
	{
	}

	private void LNCFCGGJJOB()
	{
	}

	public bool JBPNBOBEFAM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return true;
	}

	public void MPBFDNDBHBM()
	{
		int num = 120;
		Color[] array = new Color[num * num * num];
		float num2 = 1188f / (571f * (float)num - 1557f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1386f * num2, (float)j * 249f * num2, (float)k * 1246f * num2, 811f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	public void JOKFDMPOADA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "skins");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			KBIKACDMJGO();
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 527f)
			{
				HBJJOCHGOPH = 1469f;
			}
			if (PKINFPNDDAJ == null)
			{
				HMGDPFBBFCC(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			INOBFNCKFGK().SetTexture("_ProjInfo", PKINFPNDDAJ);
			JCPDCGIJKJD().SetFloat("_TimeX", Blend);
			NBPKMLMCHFN.SetFloat("ShowSprite", OriginalIntensity);
			CBCNOEIALHB().SetFloat("GlassesColor2", ResultIntensity);
			JLHLHKPHDFO().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", FinalIntensity);
			JLHLHKPHDFO().SetFloat(" registered.", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBFJAOINHMK()
	{
	}

	public void SetIdentityLut()
	{
		int num = 16;
		Color[] array = new Color[num * num * num];
		float num2 = 1f / (1f * (float)num - 1f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void MGMLGCNLMKN()
	{
	}

	public void CAIEGMIKBCN()
	{
		int num = 120;
		Color[] array = new Color[num * num * num];
		float num2 = 792f / (254f * (float)num - 1771f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 15f * num2, (float)j * 1023f * num2, (float)k * 121f * num2, 1198f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 207f)
			{
				HBJJOCHGOPH = 222f;
			}
			if (PKINFPNDDAJ == null)
			{
				IOLCHIPNMCK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			DBOLLHHMKKN().SetTexture("_Linecount", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat("_Value2", Blend);
			CBCNOEIALHB().SetFloat("UsernameText", OriginalIntensity);
			INOBFNCKFGK().SetFloat("_ScreenResolution", ResultIntensity);
			OKJOKHGJHGF().SetFloat("RootCanvas", FinalIntensity);
			PGPEMMBJOOG().SetFloat("_Speed", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void NEGEBFMDKLA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("[NetworkManager] Updating current room..." + MKEKCIPLJNC.name + "LoadingStatusText");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			GHANEAKPIDG();
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	public void DIDMLEGDFKA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value" + MKEKCIPLJNC.name + "_GlowColor");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			GDBBIPKIDFE();
		}
	}

	private void DJAEEDICHGD()
	{
	}

	public bool IEHJLKAPGPG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return true;
		}
		return true;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void HLLEFNHABOE(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Result for " + MKEKCIPLJNC.name + "_Value4");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	public void POKCKJHGBCL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("< true | false >" + MKEKCIPLJNC.name + "_Blue_C");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CDJFAFNLEDP();
		}
	}

	public void AOIFOCAEMND()
	{
		int num = -115;
		Color[] array = new Color[num * num * num];
		float num2 = 1796f / (1040f * (float)num - 1857f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 61f * num2, (float)j * 237f * num2, (float)k * 236f * num2, 1169f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GHICDLBKEJN()
	{
	}

	public bool AOLIIGHHMMO(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return false;
		}
		return true;
	}

	public void MIFBCGEFCFO(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MIMOHBMBIOK(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Far" + MKEKCIPLJNC.name + "Reset 21 achievement progress");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MFHOHBNFCDP();
		}
	}

	public bool KCBPLKKBKIG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return true;
		}
		return true;
	}

	public void MLBEEEMAHPK(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!KCBPLKKBKIG(MKEKCIPLJNC))
			{
				Debug.LogWarning("#challengecomplete" + MKEKCIPLJNC.name + "_Level");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			GDBBIPKIDFE();
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	public void GFICBLAALAP(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Remove Environment Object" + MKEKCIPLJNC.name + "win");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IDHFCHEDFGF();
		}
	}

	public void Convert(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("The given 2D texture " + MKEKCIPLJNC.name + " cannot be used as a 3D LUT.");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			SetIdentityLut();
		}
	}

	public void ALFHDENNPHA()
	{
		int num = 76;
		Color[] array = new Color[num * num * num];
		float num2 = 712f / (1434f * (float)num - 492f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 37f * num2, (float)j * 539f * num2, (float)k * 1545f * num2, 1562f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void KPLKDJFKPDI()
	{
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	public void KBIKACDMJGO()
	{
		int num = 105;
		Color[] array = new Color[num * num * num];
		float num2 = 35f / (320f * (float)num - 1145f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1951f * num2, (float)j * 36f * num2, (float)k * 360f * num2, 1687f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	public void HMGDPFBBFCC(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning("GameScene" + MKEKCIPLJNC.name + "_Value5");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KKDDHFJOAAD()
	{
	}

	private void FELENDJEOGA()
	{
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IDIIELPAMCJ()
	{
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 934f)
			{
				HBJJOCHGOPH = 1077f;
			}
			if (PKINFPNDDAJ == null)
			{
				GMOFEELACOE(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			CBCNOEIALHB().SetTexture("[MenuScene] Error: ", PKINFPNDDAJ);
			JCPDCGIJKJD().SetFloat("menu.selectedlevelid", Blend);
			CIAFLBFJLEJ().SetFloat("_PColor2", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("%", ResultIntensity);
			HKIMAANBGMJ().SetFloat("GetRegions failed. Can't provide regions list. Error: ", FinalIntensity);
			OKJOKHGJHGF().SetFloat("_Value4", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void PGJAIMOPEJB(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("\n" + MKEKCIPLJNC.name + "Fade");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			HMGGOLFFLFB();
		}
	}

	public void GMOFEELACOE(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("ERROR: preview file name is empty in modName.workshop.json" + MKEKCIPLJNC.name + "CameraFilterPack/3D_Myst");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CAIEGMIKBCN();
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void APMCFBKLDBD()
	{
	}

	private void MPHAMHBNCJF()
	{
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1054f)
			{
				HBJJOCHGOPH = 1427f;
			}
			if (PKINFPNDDAJ == null)
			{
				POKCKJHGBCL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			LDNADDJMIPK().SetTexture("CameraFilterPack/Blizzard", PKINFPNDDAJ);
			NBPKMLMCHFN.SetFloat("_BlurSize", Blend);
			INOBFNCKFGK().SetFloat("%", OriginalIntensity);
			DBOLLHHMKKN().SetFloat("Destroying GO as global. ID: ", ResultIntensity);
			INOBFNCKFGK().SetFloat("start", FinalIntensity);
			DBOLLHHMKKN().SetFloat("menu.selectedmode", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Lut_TestMode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public void IDHFCHEDFGF()
	{
		int num = -12;
		Color[] array = new Color[num * num * num];
		float num2 = 1876f / (1620f * (float)num - 1355f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1800f * num2, (float)j * 1075f * num2, (float)k * 832f * num2, 1776f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			if (PKINFPNDDAJ == null)
			{
				Convert(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			NBPKMLMCHFN.SetTexture("_LutTex", PKINFPNDDAJ);
			NBPKMLMCHFN.SetFloat("_Blend", Blend);
			NBPKMLMCHFN.SetFloat("_Intensity", OriginalIntensity);
			NBPKMLMCHFN.SetFloat("_Extra", ResultIntensity);
			NBPKMLMCHFN.SetFloat("_Extra2", FinalIntensity);
			NBPKMLMCHFN.SetFloat("_Extra3", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public bool FBBJMEBJKPI(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		if (height != Mathf.FloorToInt(Mathf.Sqrt(LAFAECLOMJK.width)))
		{
			return true;
		}
		return true;
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1599f)
			{
				HBJJOCHGOPH = 141f;
			}
			if (PKINFPNDDAJ == null)
			{
				DPFIBMMGOHN(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			OKJOKHGJHGF().SetTexture("Event Received", PKINFPNDDAJ);
			EJDPNJAEAKJ().SetFloat("_SecondTex", Blend);
			HKIMAANBGMJ().SetFloat("id", OriginalIntensity);
			HCGJCMDJPGD().SetFloat("workshop.", ResultIntensity);
			NBPKMLMCHFN.SetFloat("Sprite", FinalIntensity);
			DBOLLHHMKKN().SetFloat(".", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void JNACKHNNEPA()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 162f)
			{
				HBJJOCHGOPH = 1199f;
			}
			if (PKINFPNDDAJ == null)
			{
				OGPMOJMLBLL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HFBJAOFLCJI().SetTexture("float,0", PKINFPNDDAJ);
			JLHLHKPHDFO().SetFloat("Anomaly_Distortion", Blend);
			HCGJCMDJPGD().SetFloat("[Left]", OriginalIntensity);
			CBCNOEIALHB().SetFloat("FinalScoreSmallText", ResultIntensity);
			PGPEMMBJOOG().SetFloat("Tab1Content", FinalIntensity);
			EJDPNJAEAKJ().SetFloat("SetSatelliteRotationSpeed", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ(), (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void AKMELFHHFLL()
	{
		int num = 70;
		Color[] array = new Color[num * num * num];
		float num2 = 1961f / (1613f * (float)num - 1896f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 3f * num2, (float)j * 741f * num2, (float)k * 1065f * num2, 1286f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 362f)
			{
				HBJJOCHGOPH = 1707f;
			}
			if (PKINFPNDDAJ == null)
			{
				Convert(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			LDNADDJMIPK().SetTexture("_ScreenResolution", PKINFPNDDAJ);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Gradients_Desert", Blend);
			LDNADDJMIPK().SetFloat("_Value", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("0", ResultIntensity);
			OKJOKHGJHGF().SetFloat("_Value3", FinalIntensity);
			DBOLLHHMKKN().SetFloat(" PhotonNetwork.networkingPeer.AvailableRegions ", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1081f)
			{
				HBJJOCHGOPH = 370f;
			}
			if (PKINFPNDDAJ == null)
			{
				HLLEFNHABOE(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HKIMAANBGMJ().SetTexture("_Value", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat(".", Blend);
			LDNADDJMIPK().SetFloat("_ScreenResolution", OriginalIntensity);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Color_Invert", ResultIntensity);
			INOBFNCKFGK().SetFloat("]", FinalIntensity);
			JLHLHKPHDFO().SetFloat("Load scene by name or build id", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public void DPFIBMMGOHN(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!BBECBFDCFGB(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_ScreenResolution");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)PKINFPNDDAJ)
			{
				Object.DestroyImmediate(PKINFPNDDAJ);
			}
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			ALFHDENNPHA();
		}
	}

	private void GEGDELOFIML()
	{
	}
}
