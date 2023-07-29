// CameraFilterPack_Lut_Plus
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/Plus")]
public class CameraFilterPack_Lut_Plus : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public Texture2D LutTexture;

	private Texture3D PKINFPNDDAJ;

	[Range(0f, 1f)]
	public float Blend = 1f;

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

	public void DPFIBMMGOHN(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("SupportLogger OnFailedToConnectToPhoton(" + MKEKCIPLJNC.name + "_Value6");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			FHLMGECFEOJ();
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void PNLKFANNOKO()
	{
	}

	public void MCOFJFMKGDD(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HMPBGKKJLLP(MKEKCIPLJNC))
			{
				Debug.LogWarning("VisionBlur" + MKEKCIPLJNC.name + "Tab2Content");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			SetIdentityLut();
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1945f)
			{
				HBJJOCHGOPH = 1242f;
			}
			if (PKINFPNDDAJ == null)
			{
				MCOFJFMKGDD(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HNFFHCLNBDN().SetFloat("SetParticlesEmission", Blend);
			CECJJMKLEAK().SetTexture("_Value", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public bool EPLEBIIKBAG(Texture2D LAFAECLOMJK)
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
		return false;
	}

	private void GCHBGCGBMCK()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EKCKJLFFAID()
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
			if (!JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/TV_ARCADE" + MKEKCIPLJNC.name + "Day_");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AJECIBHAOAG();
		}
	}

	private void FELENDJEOGA()
	{
	}

	private void FEKECCBFGMI()
	{
	}

	public void IAEKMLJLONA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JNJHPIJJLCP(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			FHLMGECFEOJ();
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public bool EKNHDHDGEDM(Texture2D LAFAECLOMJK)
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

	private void FPBIGAKLKIG()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	public bool HMPBGKKJLLP(Texture2D LAFAECLOMJK)
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnValidate()
	{
	}

	public bool NGGDEJKBDEA(Texture2D LAFAECLOMJK)
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
		return false;
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1269f)
			{
				HBJJOCHGOPH = 1783f;
			}
			if (PKINFPNDDAJ == null)
			{
				KMEEJNBNAOK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			HNFFHCLNBDN().SetFloat("ItemNameText", Blend);
			NBPKMLMCHFN.SetTexture("checkpoint", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), (QualitySettings.activeColorSpace != 0) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 921f)
			{
				HBJJOCHGOPH = 110f;
			}
			if (PKINFPNDDAJ == null)
			{
				LGJBGIDDGKK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			HNFFHCLNBDN().SetFloat("_Intensity", Blend);
			HNFFHCLNBDN().SetTexture("BitsData", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKDDHFJOAAD()
	{
	}

	private void OLCOOJIONIL()
	{
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

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public bool CMJFPJJPBDC(Texture2D LAFAECLOMJK)
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
		return false;
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	public void FHLMGECFEOJ()
	{
		int num = 124;
		Color[] array = new Color[num * num * num];
		float num2 = 792f / (210f * (float)num - 272f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 123f * num2, (float)j * 142f * num2, (float)k * 1366f * num2, 264f);
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

	public void JFDPEFDIHAM()
	{
		int num = -73;
		Color[] array = new Color[num * num * num];
		float num2 = 153f / (1182f * (float)num - 623f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 399f * num2, (float)j * 1355f * num2, (float)k * 1431f * num2, 1517f);
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

	private void LLDHEJIEDHO()
	{
	}

	public void NEGEBFMDKLA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning(".progress" + MKEKCIPLJNC.name + "RoomPlayersCountText");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AJECIBHAOAG();
		}
	}

	public void FLLGMAPEKGA(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Visualize" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AJECIBHAOAG();
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1321f)
			{
				HBJJOCHGOPH = 1625f;
			}
			if (PKINFPNDDAJ == null)
			{
				NHPDNLKGOHL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			BBIMPFGLDCP().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", Blend);
			EFDEIFCDAFG().SetTexture("_Value", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void OFBLDOCCBBN()
	{
	}

	public bool APPLAEOFKIL(Texture2D LAFAECLOMJK)
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

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void BNLCPIKJJGL()
	{
		int num = -37;
		Color[] array = new Color[num * num * num];
		float num2 = 86f / (630f * (float)num - 761f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 239f * num2, (float)j * 1570f * num2, (float)k * 790f * num2, 789f);
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

	public bool MPGGIBFHGHP(Texture2D LAFAECLOMJK)
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

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1354f)
			{
				HBJJOCHGOPH = 1303f;
			}
			if (PKINFPNDDAJ == null)
			{
				EOCEOCBOFOO(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			GKILCDHJFEG().SetFloat("_Distortion", Blend);
			EFDEIFCDAFG().SetTexture("_TileTexDebug", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN(), (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	public void JHMBBBLCPMD(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JNJHPIJJLCP(MKEKCIPLJNC))
			{
				Debug.LogWarning("Waiting to start" + MKEKCIPLJNC.name + "Joystick1Button");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			CDJFAFNLEDP();
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 628f)
			{
				HBJJOCHGOPH = 700f;
			}
			if (PKINFPNDDAJ == null)
			{
				ILDGGEBDIDF(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			CECJJMKLEAK().SetFloat("ComboText", Blend);
			NBPKMLMCHFN.SetTexture("y", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN(), (QualitySettings.activeColorSpace != 0) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	public void LGJBGIDDGKK(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("EventSystem" + MKEKCIPLJNC.name + "blue");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			SetIdentityLut();
		}
	}

	private void JECMJNFGBGC()
	{
	}

	private void NNFMIAFHMJM()
	{
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 233f)
			{
				HBJJOCHGOPH = 1700f;
			}
			if (PKINFPNDDAJ == null)
			{
				EECJDBKEOII(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			FKEOGPDLBDD().SetFloat("TwoHands", Blend);
			HNFFHCLNBDN().SetTexture("Tab1Content", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PKNJBBDKJFK()
	{
	}

	private void GMELGGJOPBB()
	{
	}

	public bool JNJHPIJJLCP(Texture2D LAFAECLOMJK)
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

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 153f)
			{
				HBJJOCHGOPH = 1965f;
			}
			if (PKINFPNDDAJ == null)
			{
				KMEEJNBNAOK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HNFFHCLNBDN().SetFloat("_PosY", Blend);
			HNFFHCLNBDN().SetTexture("_Value4", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void BNLOEMBBDEJ()
	{
		int num = -44;
		Color[] array = new Color[num * num * num];
		float num2 = 1644f / (290f * (float)num - 1944f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1866f * num2, (float)j * 1159f * num2, (float)k * 908f * num2, 716f);
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

	private void HIPEHGNBJMN()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1705f)
			{
				HBJJOCHGOPH = 253f;
			}
			if (PKINFPNDDAJ == null)
			{
				FOANBFFFFLE(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Blend);
			HNFFHCLNBDN().SetTexture("Editor", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 1326f;
			}
			if (PKINFPNDDAJ == null)
			{
				LGJBGIDDGKK(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HNFFHCLNBDN().SetFloat("st", Blend);
			HNFFHCLNBDN().SetTexture("_Value5", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), (QualitySettings.activeColorSpace != 0) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public bool JLLFEBOHAIA(Texture2D LAFAECLOMJK)
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

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	public void IPFNHOJMIOD()
	{
		int num = -119;
		Color[] array = new Color[num * num * num];
		float num2 = 1635f / (1073f * (float)num - 1461f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 166f * num2, (float)j * 1573f * num2, (float)k * 1138f * num2, 215f);
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

	private void PHJJHFBLICM()
	{
	}

	public void ILDGGEBDIDF(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MGEILBOBBDO(MKEKCIPLJNC))
			{
				Debug.LogWarning("IconImage" + MKEKCIPLJNC.name + "#exitmapeditor");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IPFNHOJMIOD();
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

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1201f)
			{
				HBJJOCHGOPH = 595f;
			}
			if (PKINFPNDDAJ == null)
			{
				NEGEBFMDKLA(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			FKEOGPDLBDD().SetFloat("_Value", Blend);
			HNFFHCLNBDN().SetTexture("CameraFilterPack/Blend2Camera_ColorBurn", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALNNIDLFILB()
	{
	}

	private void PAKPHKPDKGE()
	{
	}

	public void MEHFAHKIKAB(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("RoomDescriptionText" + MKEKCIPLJNC.name + "_TimeX");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IPFNHOJMIOD();
		}
	}

	private void MLAGEPNCCGM()
	{
	}

	private void CGDMLHLJIDK()
	{
	}

	public void MGBOJGMOEGA()
	{
		int num = 88;
		Color[] array = new Color[num * num * num];
		float num2 = 1157f / (452f * (float)num - 1964f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1502f * num2, (float)j * 236f * num2, (float)k * 1455f * num2, 1163f);
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

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1923f)
			{
				HBJJOCHGOPH = 179f;
			}
			if (PKINFPNDDAJ == null)
			{
				EECJDBKEOII(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			NBPKMLMCHFN.SetFloat("isVisible", Blend);
			HNFFHCLNBDN().SetTexture("Joystick1Button8", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNACKHNNEPA()
	{
	}

	public void ENADEMNMLPO(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("true" + MKEKCIPLJNC.name + "CameraFilterPack/TV_ARCADE");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IGBAMFGIBBI();
		}
	}

	public bool MGEILBOBBDO(Texture2D LAFAECLOMJK)
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

	public void NHPDNLKGOHL(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!EPLEBIIKBAG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value2" + MKEKCIPLJNC.name + "Joystick1Button12");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			MGBOJGMOEGA();
		}
	}

	public void IGBAMFGIBBI()
	{
		int num = -28;
		Color[] array = new Color[num * num * num];
		float num2 = 963f / (1844f * (float)num - 1594f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1592f * num2, (float)j * 55f * num2, (float)k * 1309f * num2, 252f);
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

	private void KKLMPKLKAEM()
	{
	}

	public void FOANBFFFFLE(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("_LightIntensity" + MKEKCIPLJNC.name + "mapselector.filter.subscribedonly");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			BNLOEMBBDEJ();
		}
	}

	public bool GBHBEABICCD(Texture2D LAFAECLOMJK)
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
			NBPKMLMCHFN.SetFloat("_Blend", Blend);
			NBPKMLMCHFN.SetTexture("_LutTex", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public bool DGGIHMHCOKM(Texture2D LAFAECLOMJK)
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

	private void PDHKMDBNGGN()
	{
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGMAOBPPOBJ()
	{
	}

	public void EOCEOCBOFOO(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Speed" + MKEKCIPLJNC.name + "\" for viewID ");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IGBAMFGIBBI();
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void LCDJFJIBADI()
	{
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public void EECJDBKEOII(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_TimeX");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			MGBOJGMOEGA();
		}
	}

	private void POIMNOBDBBN()
	{
	}

	public void EMOOBOAJGOB(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!NGGDEJKBDEA(MKEKCIPLJNC))
			{
				Debug.LogWarning("<b>" + MKEKCIPLJNC.name + "_ScreenResolution");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			IPFNHOJMIOD();
		}
	}

	private void DKOPKPBLDHH()
	{
	}

	private void GCDLIKEDMCF()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 215f)
			{
				HBJJOCHGOPH = 1795f;
			}
			if (PKINFPNDDAJ == null)
			{
				NGAAKPPPOCG(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			HNFFHCLNBDN().SetFloat("action", Blend);
			HNFFHCLNBDN().SetTexture("Saved as: ", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK(), (QualitySettings.activeColorSpace != 0) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1017f)
			{
				HBJJOCHGOPH = 1902f;
			}
			if (PKINFPNDDAJ == null)
			{
				OGPMOJMLBLL(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			NBPKMLMCHFN.SetFloat("DontDestroy", Blend);
			BBIMPFGLDCP().SetTexture("1", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1254f)
			{
				HBJJOCHGOPH = 1164f;
			}
			if (PKINFPNDDAJ == null)
			{
				MEHFAHKIKAB(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			FKEOGPDLBDD().SetFloat("_Value", Blend);
			CECJJMKLEAK().SetTexture("turn: {0:0}", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), (QualitySettings.activeColorSpace != 0) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
	}

	public void BEAEKDIPGKL()
	{
		int num = 127;
		Color[] array = new Color[num * num * num];
		float num2 = 118f / (1535f * (float)num - 18f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 740f * num2, (float)j * 1033f * num2, (float)k * 1028f * num2, 853f);
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

	public void KMEEJNBNAOK(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Red_G" + MKEKCIPLJNC.name + "PublishButton");
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			JFDPEFDIHAM();
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void KIMMMCJFMAB()
	{
	}

	public void CDJFAFNLEDP()
	{
		int num = -27;
		Color[] array = new Color[num * num * num];
		float num2 = 1587f / (265f * (float)num - 349f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 364f * num2, (float)j * 157f * num2, (float)k * 1650f * num2, 38f);
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

	private void GEGDELOFIML()
	{
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null || !SystemInfo.supports3DTextures)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 195f)
			{
				HBJJOCHGOPH = 1555f;
			}
			if (PKINFPNDDAJ == null)
			{
				EECJDBKEOII(LutTexture);
			}
			PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			BBIMPFGLDCP().SetFloat("SlidingArea", Blend);
			BBIMPFGLDCP().SetTexture("Joystick1Button1", PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public void FADDJEGOAAI(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/Distortion_BlackHole" + MKEKCIPLJNC.name + "LoadMapCanvas");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			SetIdentityLut();
		}
	}

	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if ((bool)MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!HMPBGKKJLLP(MKEKCIPLJNC))
			{
				Debug.LogWarning("UI" + MKEKCIPLJNC.name + "NO");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
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
			PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			PKINFPNDDAJ.SetPixels(array);
			PKINFPNDDAJ.Apply();
		}
		else
		{
			AJECIBHAOAG();
		}
	}

	public void AJECIBHAOAG()
	{
		int num = 98;
		Color[] array = new Color[num * num * num];
		float num2 = 932f / (609f * (float)num - 563f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1349f * num2, (float)j * 769f * num2, (float)k * 449f * num2, 1506f);
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

	private void JOACBIEHHCE()
	{
	}

	private void HIAICHPPGBP()
	{
	}

	public bool LMCNGPGKOPM(Texture2D LAFAECLOMJK)
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

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGFGKIBHCBE()
	{
	}
}
