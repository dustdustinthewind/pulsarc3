// CameraFilterPack_Lut_PlayWith
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/PlayWith")]
public class CameraFilterPack_Lut_PlayWith : MonoBehaviour
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

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void EPELPAMHOHC(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("???" + MKEKCIPLJNC.name + "_Threshold");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MHFNPKBOHMN();
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("Received unknown status code: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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

	public void EACOKNDLPLE()
	{
		int num = -121;
		Color[] array = new Color[num * num * num];
		float num2 = 878f / (13f * (float)num - 776f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 919f * num2, (float)j * 225f * num2, (float)k * 1090f * num2, 469f);
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

	private void NFEDLAOPHML()
	{
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("ArcsHitsoundTimeDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
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

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Lut_PlayWith");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public void MHFNPKBOHMN()
	{
		int num = -30;
		Color[] array = new Color[num * num * num];
		float num2 = 1437f / (1180f * (float)num - 1574f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1787f * num2, (float)j * 961f * num2, (float)k * 114f * num2, 1645f);
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

	public void CMEIMLNOOOE()
	{
		int num = -75;
		Color[] array = new Color[num * num * num];
		float num2 = 1239f / (273f * (float)num - 989f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1484f * num2, (float)j * 738f * num2, (float)k * 417f * num2, 335f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	public void HNGICJBNPLH(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "/");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			DCJODJLMOCK();
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void NCHGIKOCEEC(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JDIFHOCBMGE(MKEKCIPLJNC))
			{
				Debug.LogWarning(">" + MKEKCIPLJNC.name + "Circle");
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
			BEAEKDIPGKL();
		}
	}

	public void LOGNBJDNJHG(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("OxOD.lastPath" + MKEKCIPLJNC.name + "score");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			PCDLENLKIJO();
		}
	}

	public void JHMBBBLCPMD(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/Drawing_Manga" + MKEKCIPLJNC.name + "player.currentrank");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AFADJOKGKAG();
		}
	}

	private void DCGFEIBKOBB()
	{
	}

	public void GLIGFAIOKLE(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("AudioSampler" + MKEKCIPLJNC.name + "B");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
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
			BEAEKDIPGKL();
		}
	}

	public void DCJODJLMOCK()
	{
		int num = 116;
		Color[] array = new Color[num * num * num];
		float num2 = 285f / (1870f * (float)num - 1169f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 549f * num2, (float)j * 154f * num2, (float)k * 1677f * num2, 948f);
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

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 494f)
			{
				HBJJOCHGOPH = 1295f;
			}
			if (PKINFPNDDAJ == null)
			{
				OGPMOJMLBLL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			ADGHJOHKEHG().SetTexture("_ScreenResolution", PKINFPNDDAJ);
			NDMPCDHADMJ().SetFloat(".played", Blend);
			KBOPGONOCNP().SetFloat("maps.", OriginalIntensity);
			ADBKPGFMNKO().SetFloat("#", ResultIntensity);
			DOHGBNPMBKG().SetFloat(" - GameWebCallback] - ", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace != 0) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_Gain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAPKKMKDOFO()
	{
	}

	public void IKBBLGEAGHK(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TapLowBackground" + MKEKCIPLJNC.name + "note.3");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			GGKMNAAAONA();
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 255f)
			{
				HBJJOCHGOPH = 1308f;
			}
			if (PKINFPNDDAJ == null)
			{
				MCPNFAGGOCA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			NDMPCDHADMJ().SetTexture("GroupNameText", PKINFPNDDAJ);
			NFKFAAHHLLM().SetFloat("a month ago", Blend);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/BlurTiltShift", OriginalIntensity);
			KGOLDDBHIFN().SetFloat("Anomaly_Far", ResultIntensity);
			KAFBNOBOIAJ().SetFloat("PointsScoreText", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void BJAKIBKPCJH(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("_V" + MKEKCIPLJNC.name + "/");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CMEIMLNOOOE();
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 94f)
			{
				HBJJOCHGOPH = 619f;
			}
			if (PKINFPNDDAJ == null)
			{
				CPNGHOJPOCB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			PDEAHJPOMEF().SetTexture("settings_bindings_controller_type", PKINFPNDDAJ);
			KGOLDDBHIFN().SetFloat("Object ID. Case-Sensitive", Blend);
			NFKFAAHHLLM().SetFloat(".lastCheckpoint.penaltyScore", OriginalIntensity);
			NDMPCDHADMJ().SetFloat("OnSerialize", ResultIntensity);
			ADBKPGFMNKO().SetFloat("offsets", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void AHCMJAFCLHA()
	{
		int num = -82;
		Color[] array = new Color[num * num * num];
		float num2 = 1156f / (1180f * (float)num - 841f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1956f * num2, (float)j * 129f * num2, (float)k * 1272f * num2, 198f);
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

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 101f)
			{
				HBJJOCHGOPH = 417f;
			}
			if (PKINFPNDDAJ == null)
			{
				NGAAKPPPOCG(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			KAFBNOBOIAJ().SetTexture("Start index must in an integer.", PKINFPNDDAJ);
			KAFBNOBOIAJ().SetFloat("id", Blend);
			KGOLDDBHIFN().SetFloat("_TimeX", OriginalIntensity);
			KBOPGONOCNP().SetFloat("SetSunInput", ResultIntensity);
			KAFBNOBOIAJ().SetFloat("#random #common #item", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void PCDLENLKIJO()
	{
		int num = 99;
		Color[] array = new Color[num * num * num];
		float num2 = 924f / (442f * (float)num - 1830f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 990f * num2, (float)j * 473f * num2, (float)k * 225f * num2, 1030f);
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

	private void FKDKJKCAHJC()
	{
	}

	private void Update()
	{
	}

	public void GGKMNAAAONA()
	{
		int num = 109;
		Color[] array = new Color[num * num * num];
		float num2 = 1425f / (150f * (float)num - 1358f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1894f * num2, (float)j * 520f * num2, (float)k * 699f * num2, 1524f);
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

	private void AEEGKLABFLN()
	{
	}

	public void CPNGHOJPOCB(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("OnRenderImage in Helper called ..." + MKEKCIPLJNC.name + "_ScreenResolution");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			PCDLENLKIJO();
		}
	}

	public bool JDIFHOCBMGE(Texture2D LAFAECLOMJK)
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

	private void OnValidate()
	{
	}

	public void BEAEKDIPGKL()
	{
		int num = 72;
		Color[] array = new Color[num * num * num];
		float num2 = 1591f / (316f * (float)num - 22f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1085f * num2, (float)j * 100f * num2, (float)k * 1416f * num2, 1337f);
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
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LMADKINICIN()
	{
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1259f)
			{
				HBJJOCHGOPH = 128f;
			}
			if (PKINFPNDDAJ == null)
			{
				CPNGHOJPOCB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			NFKFAAHHLLM().SetTexture("_Red_C", PKINFPNDDAJ);
			KAFBNOBOIAJ().SetFloat("Set Particle Size", Blend);
			KBOPGONOCNP().SetFloat("_Value", OriginalIntensity);
			KAFBNOBOIAJ().SetFloat("Mouse", ResultIntensity);
			ADGHJOHKEHG().SetFloat("_Contrast", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GLGGNBOBFKE()
	{
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("_Value2");
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
				Debug.LogWarning("Save" + MKEKCIPLJNC.name + "InfoText");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			SetIdentityLut();
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	public void CAIEGMIKBCN()
	{
		int num = -72;
		Color[] array = new Color[num * num * num];
		float num2 = 417f / (349f * (float)num - 1245f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1923f * num2, (float)j * 537f * num2, (float)k * 112f * num2, 547f);
				}
			}
		}
		if ((bool)PKINFPNDDAJ)
		{
			Object.DestroyImmediate(PKINFPNDDAJ);
		}
		PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
		PKINFPNDDAJ.SetPixels(array);
		PKINFPNDDAJ.Apply();
	}

	private void MMBPLGGLPDB()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 590f)
			{
				HBJJOCHGOPH = 1276f;
			}
			if (PKINFPNDDAJ == null)
			{
				CPNGHOJPOCB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			KAFBNOBOIAJ().SetTexture("CameraFilterPack/BlurHole", PKINFPNDDAJ);
			KAFBNOBOIAJ().SetFloat("https://vk.com/khb.soft", Blend);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Drawing_Paper2", OriginalIntensity);
			NDMPCDHADMJ().SetFloat("_MainTex2", ResultIntensity);
			ADBKPGFMNKO().SetFloat("win", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP(), (QualitySettings.activeColorSpace != 0) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("CheckpointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void HIDCBFFDMIG(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JDIFHOCBMGE(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Distortion" + MKEKCIPLJNC.name + "SaveGameName is null or empty!");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
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
			CMEIMLNOOOE();
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_BlurTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JNBPKNNBMDI()
	{
	}

	private void JNACKHNNEPA()
	{
	}

	public void MCPNFAGGOCA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("Back" + MKEKCIPLJNC.name + "http");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AHCMJAFCLHA();
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IIJAPKAADNH()
	{
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FELENDJEOGA()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void OGPMOJMLBLL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("Using Stopwatch as precision timer for PUN." + MKEKCIPLJNC.name + "#ok");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			DCJODJLMOCK();
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 659f)
			{
				HBJJOCHGOPH = 1592f;
			}
			if (PKINFPNDDAJ == null)
			{
				NCHGIKOCEEC(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			ADGHJOHKEHG().SetTexture("#exitmapeditor", PKINFPNDDAJ);
			ADGHJOHKEHG().SetFloat("_MatrixSpeed", Blend);
			KGOLDDBHIFN().SetFloat("_AreaTex", OriginalIntensity);
			DOHGBNPMBKG().SetFloat("NO", ResultIntensity);
			NFKFAAHHLLM().SetFloat("[SaveSystem] Init from ", FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNGDOKOAKLA()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
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

	public void JFDPEFDIHAM()
	{
		int num = -59;
		Color[] array = new Color[num * num * num];
		float num2 = 628f / (195f * (float)num - 1831f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 57f * num2, (float)j * 1977f * num2, (float)k * 646f * num2, 1542f);
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

	public void IDHFCHEDFGF()
	{
		int num = 77;
		Color[] array = new Color[num * num * num];
		float num2 = 634f / (1291f * (float)num - 1153f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1419f * num2, (float)j * 49f * num2, (float)k * 251f * num2, 1323f);
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

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JBCNIPJDPJB()
	{
	}

	public void POKCKJHGBCL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("player.xp" + MKEKCIPLJNC.name + "PLEASE WAIT");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			SetIdentityLut();
		}
	}

	public void FCFEJLOANCJ()
	{
		int num = -71;
		Color[] array = new Color[num * num * num];
		float num2 = 851f / (224f * (float)num - 1713f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1201f * num2, (float)j * 1890f * num2, (float)k * 99f * num2, 547f);
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

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("DPADVER" + MKEKCIPLJNC.name + "_Visualize");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AHCMJAFCLHA();
		}
	}

	public bool LBGADMACHNI(Texture2D LAFAECLOMJK)
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

	public void AFADJOKGKAG()
	{
		int num = 0;
		Color[] array = new Color[num * num * num];
		float num2 = 1788f / (1650f * (float)num - 1121f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 518f * num2, (float)j * 981f * num2, (float)k * 1347f * num2, 236f);
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

	private void MECJHOJPODB()
	{
	}

	public bool ODOAFOCHJBF(Texture2D LAFAECLOMJK)
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
}
