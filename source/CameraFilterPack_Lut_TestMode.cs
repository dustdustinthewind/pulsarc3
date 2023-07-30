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
				IOLCHIPNMCK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HCGJCMDJPGD().SetTexture("_Color", PKINFPNDDAJ);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", Blend);
			HKIMAANBGMJ().SetFloat("settings.fps", OriginalIntensity);
			HKIMAANBGMJ().SetFloat("_Intensity", ResultIntensity);
			LDNADDJMIPK().SetFloat("?", FinalIntensity);
			NBPKMLMCHFN.SetFloat("_Value4", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
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
		SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
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
				CEKLIKHBJFA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HFBJAOFLCJI().SetTexture("_TimeX", PKINFPNDDAJ);
			OKJOKHGJHGF().SetFloat("_Value", Blend);
			JLHLHKPHDFO().SetFloat(".played", OriginalIntensity);
			OKJOKHGJHGF().SetFloat("SpawnObj", ResultIntensity);
			DBOLLHHMKKN().SetFloat("ZoomFade", FinalIntensity);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/BlurTiltShift", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
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
			if (!FBBJMEBJKPI(MKEKCIPLJNC))
			{
				Debug.LogWarning("GenerationMenu" + MKEKCIPLJNC.name + "_ScreenResolution");
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
			MPBFDNDBHBM();
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
				Debug.LogWarning("file://" + MKEKCIPLJNC.name + "ns");
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
			GHANEAKPIDG();
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
			if (!IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_PositionY" + MKEKCIPLJNC.name + "yyyy-MM-dd HH:mm:ss");
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
			ALFHDENNPHA();
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
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Near" + MKEKCIPLJNC.name + "pointBuffer");
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
			AKMELFHHFLL();
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("[DiscordController] Responding no to Ask to Join request");
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
			if (!IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning(" to: " + MKEKCIPLJNC.name + "DPADHOR");
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
			LIDOIDIAEJB();
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
			if (!KCBPLKKBKIG(MKEKCIPLJNC))
			{
				Debug.LogWarning("challenges" + MKEKCIPLJNC.name + "\t");
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
			CDJFAFNLEDP();
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
				Convert(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			INOBFNCKFGK().SetTexture("FullscreenToggle", PKINFPNDDAJ);
			HCGJCMDJPGD().SetFloat("menutheme.letitbe", Blend);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Blend2Camera_Screen", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("PossibleMapPointsText", ResultIntensity);
			INOBFNCKFGK().SetFloat("skin.hit_normal", FinalIntensity);
			CBCNOEIALHB().SetFloat("EventMenu", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
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
		SCShader = Shader.Find(" or player:");
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
			if (!KCBPLKKBKIG(MKEKCIPLJNC))
			{
				Debug.LogWarning("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();" + MKEKCIPLJNC.name + "_Blend");
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
			CAIEGMIKBCN();
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
				IOLCHIPNMCK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			LDNADDJMIPK().SetTexture("CameraFilterPack_Glasses_On2", PKINFPNDDAJ);
			JCPDCGIJKJD().SetFloat("/", Blend);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/TV_Videoflip", OriginalIntensity);
			PGPEMMBJOOG().SetFloat("_Skybox", ResultIntensity);
			JCPDCGIJKJD().SetFloat("UNDISTORT", FinalIntensity);
			EJDPNJAEAKJ().SetFloat("VisionBlur", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
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
				DPFIBMMGOHN(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			CIAFLBFJLEJ().SetTexture("PPI: ", PKINFPNDDAJ);
			EJDPNJAEAKJ().SetFloat("Set Particles Input", Blend);
			CBCNOEIALHB().SetFloat("_Parameter", OriginalIntensity);
			PGPEMMBJOOG().SetFloat("SetSatelliteRadius", ResultIntensity);
			CBCNOEIALHB().SetFloat("<b>Time</b>:", FinalIntensity);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Light_Rainbow", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
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
				CEKLIKHBJFA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			CBCNOEIALHB().SetTexture("Data/Localization", PKINFPNDDAJ);
			HKIMAANBGMJ().SetFloat("_CenterRadius", Blend);
			INOBFNCKFGK().SetFloat("_Value6", OriginalIntensity);
			JCPDCGIJKJD().SetFloat("System.Single", ResultIntensity);
			JCPDCGIJKJD().SetFloat("_Value", FinalIntensity);
			HCGJCMDJPGD().SetFloat("_SizeX", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
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
				DIDMLEGDFKA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			NBPKMLMCHFN.SetTexture("_EmissionColor", PKINFPNDDAJ);
			OKJOKHGJHGF().SetFloat(".lastCheckpoint.playerdistance", Blend);
			HCGJCMDJPGD().SetFloat("&map=", OriginalIntensity);
			INOBFNCKFGK().SetFloat("note.1", ResultIntensity);
			EJDPNJAEAKJ().SetFloat("menu.playedpage", FinalIntensity);
			OKJOKHGJHGF().SetFloat("_Noise", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
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
				IOLCHIPNMCK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			HKIMAANBGMJ().SetTexture("StartButton", PKINFPNDDAJ);
			HCGJCMDJPGD().SetFloat("_Value4", Blend);
			INOBFNCKFGK().SetFloat("_TimeX", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("Scrollbar", ResultIntensity);
			DBOLLHHMKKN().SetFloat("maps.", FinalIntensity);
			PGPEMMBJOOG().SetFloat(" in-game items", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
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
				Debug.LogWarning("0x" + MKEKCIPLJNC.name + ",");
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
			KBIKACDMJGO();
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
		SCShader = Shader.Find("LevelEditor/icons");
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
			if (!GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("#ranks:" + MKEKCIPLJNC.name + "CameraFilterPack_TV_BrokenGlass1");
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
			AKMELFHHFLL();
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
			if (!FBBJMEBJKPI(MKEKCIPLJNC))
			{
				Debug.LogWarning("_FixDistance" + MKEKCIPLJNC.name + "BitsData");
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
			MFHOHBNFCDP();
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
			if (!BBECBFDCFGB(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/Distortion_Lens" + MKEKCIPLJNC.name + "GroupNameText");
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
			ALFHDENNPHA();
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
				POKCKJHGBCL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			NBPKMLMCHFN.SetTexture("_ScreenSize", PKINFPNDDAJ);
			INOBFNCKFGK().SetFloat("_TimeX", Blend);
			JCPDCGIJKJD().SetFloat("SpawnObj", OriginalIntensity);
			HCGJCMDJPGD().SetFloat("GlassesColor", ResultIntensity);
			HFBJAOFLCJI().SetFloat("GameScene", FinalIntensity);
			OKJOKHGJHGF().SetFloat("There is already a virtual axis named ", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
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
				PGJAIMOPEJB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			HCGJCMDJPGD().SetTexture("_Vignette", PKINFPNDDAJ);
			OKJOKHGJHGF().SetFloat("_Value1", Blend);
			HCGJCMDJPGD().SetFloat("UsernameText", OriginalIntensity);
			JCPDCGIJKJD().SetFloat("_Value", ResultIntensity);
			OKJOKHGJHGF().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", FinalIntensity);
			JCPDCGIJKJD().SetFloat("_Value", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ(), (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
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
			if (!AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("[NetworkManager] Updating current room..." + MKEKCIPLJNC.name + "[MapsData] Caching ");
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
			MFHOHBNFCDP();
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("inventory.selected.");
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
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_Value3");
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
			ALFHDENNPHA();
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
			if (!MIMOHBMBIOK(MKEKCIPLJNC))
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
			GHANEAKPIDG();
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
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("Sets the boolean value of the Auto Focus Input Field property." + MKEKCIPLJNC.name + "_Green_C");
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
			GHANEAKPIDG();
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
			if (!GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Near" + MKEKCIPLJNC.name + "resetach21");
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
			KBIKACDMJGO();
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
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("challenges." + MKEKCIPLJNC.name + "_TimeX");
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
			SetIdentityLut();
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
			if (!KCBPLKKBKIG(MKEKCIPLJNC))
			{
				Debug.LogWarning("RemoveEnvironmentObject" + MKEKCIPLJNC.name + "win");
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
			if (!JBPNBOBEFAM(MKEKCIPLJNC))
			{
				Debug.LogWarning("[" + MKEKCIPLJNC.name + "_Value5");
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
			MGBOJGMOEGA();
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_FixDistance");
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
				MIFBCGEFCFO(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			JCPDCGIJKJD().SetTexture("[MenuScene] Error: ", PKINFPNDDAJ);
			HFBJAOFLCJI().SetFloat("menu.selectedlevelid", Blend);
			HKIMAANBGMJ().SetFloat("_Value7", OriginalIntensity);
			EJDPNJAEAKJ().SetFloat("0.00", ResultIntensity);
			CIAFLBFJLEJ().SetFloat("Received your NickName from server. Updating local value to: {0}", FinalIntensity);
			DBOLLHHMKKN().SetFloat("_Value4", TestMode);
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
			if (!MIMOHBMBIOK(MKEKCIPLJNC))
			{
				Debug.LogWarning("Is Clone ?: " + MKEKCIPLJNC.name + "_Value4");
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
			MGBOJGMOEGA();
		}
	}

	public void GMOFEELACOE(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JBPNBOBEFAM(MKEKCIPLJNC))
			{
				Debug.LogWarning("ERROR: Preview file must be <1MB!" + MKEKCIPLJNC.name + "CameraFilterPack/3D_Myst");
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
			LIDOIDIAEJB();
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
				GIAANJAEABI(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			HCGJCMDJPGD().SetTexture("CameraFilterPack/Blizzard", PKINFPNDDAJ);
			EJDPNJAEAKJ().SetFloat("_BloomIntensity", Blend);
			PGPEMMBJOOG().SetFloat("0.00", OriginalIntensity);
			CBCNOEIALHB().SetFloat(". Not Destroying GameObject or PhotonViews!", ResultIntensity);
			JLHLHKPHDFO().SetFloat("start", FinalIntensity);
			OKJOKHGJHGF().SetFloat("settings.enablerankingnotifications", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
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
				MLBEEEMAHPK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			PGPEMMBJOOG().SetTexture("RootCanvas", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat("_BlurCoe", Blend);
			EJDPNJAEAKJ().SetFloat("id", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("workshop.", ResultIntensity);
			CBCNOEIALHB().SetFloat("Sprite", FinalIntensity);
			PGPEMMBJOOG().SetFloat("Crosshair1", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
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
				GIAANJAEABI(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			JLHLHKPHDFO().SetTexture("float,0", PKINFPNDDAJ);
			PGPEMMBJOOG().SetFloat("Anomaly_Distortion", Blend);
			OKJOKHGJHGF().SetFloat("[Up]", OriginalIntensity);
			DBOLLHHMKKN().SetFloat("FinalScoreSmallText", ResultIntensity);
			INOBFNCKFGK().SetFloat("maps.", FinalIntensity);
			PGPEMMBJOOG().SetFloat("SetSatelliteRotationSpeed", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
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
				DPFIBMMGOHN(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			INOBFNCKFGK().SetTexture("_Value3", PKINFPNDDAJ);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", Blend);
			JLHLHKPHDFO().SetFloat("CameraFilterPack/TV_VHS", OriginalIntensity);
			JCPDCGIJKJD().SetFloat("#ok", ResultIntensity);
			NBPKMLMCHFN.SetFloat("_Value3", FinalIntensity);
			PGPEMMBJOOG().SetFloat("Call ConnectToNameServer to ping available regions.", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
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
				NEGEBFMDKLA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			CBCNOEIALHB().SetTexture("_TimeX", PKINFPNDDAJ);
			CIAFLBFJLEJ().SetFloat("maps.", Blend);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", OriginalIntensity);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Color_Invert", ResultIntensity);
			CIAFLBFJLEJ().SetFloat("]", FinalIntensity);
			NBPKMLMCHFN.SetFloat("Print the list of scenes, avalable in game.", TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO(), (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_TimeX");
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
			if (!LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/FX_Mirror" + MKEKCIPLJNC.name + "_ScreenResolution");
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
			MPBFDNDBHBM();
		}
	}

	private void GEGDELOFIML()
	{
	}
}
