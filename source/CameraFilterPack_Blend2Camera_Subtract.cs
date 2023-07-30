// CameraFilterPack_Blend2Camera_Subtract
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Subtract")]
public class CameraFilterPack_Blend2Camera_Subtract : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Subtract";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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

	private void OOBIMFILNED()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HDMDKOKOOJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BDBKIEIIFPB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MLAGEPNCCGM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void GNDNNEKPGCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -21);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HFLHDMPHOJA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DPFOEBCADNP()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOJFHFHOCHO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 571f)
			{
				HBJJOCHGOPH = 1691f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("\" gets executed locally only, if at all.", JDMCFBKJHDD);
			}
			NJDIODJNGGA().SetFloat("_Amount", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_Value", BlendFX);
			HCGJCMDJPGD().SetFloat("CameraFilterPack_Paper2", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetVector("cancel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1702f, 60f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIFBFDKFMMH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LONLHFLPEJD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -73);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ELANJOHIJME()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -78);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LJEDJDGPGFG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void HGIMCCHIPCP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OHFOLGANOLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBGBCCBHBBC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 77f)
			{
				HBJJOCHGOPH = 949f;
			}
			if (Camera2 != null)
			{
				IGKFMCPDNOI().SetTexture("BloomShaderValueSlider", JDMCFBKJHDD);
			}
			LPMLLJKMAMP().SetFloat("ArcsNoHitsoundTimeDelaySlider", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", BlendFX);
			EFDEIFCDAFG().SetFloat("ResourcesConfig", SwitchCameraToCamera2);
			NJDIODJNGGA().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1088f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	private void NNONKGKCKKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CBKHALIFIAN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EBBOJPEPDCN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -80);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MPADDMNGJNC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JOPCCCCHNLI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 94);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGEPPDJDBLN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 1);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void IBEAPBDAOCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KCCIEMBMOBA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void MEMKLOMFFJO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void OAKONCDEPPI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGDDCINLDAD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DIPDEHOOBPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -63);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAALCEPIHCH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGOPJMGNHGO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void MCKOAMFEDGL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OCHMKJKBAPI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FDPOFMCFBMF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -128);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDIEBLNAEIF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1104f)
			{
				HBJJOCHGOPH = 1954f;
			}
			if (Camera2 != null)
			{
				GKILCDHJFEG().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			CEKJODEAMGB().SetFloat("Electronic", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("PLEASE WAIT", BlendFX);
			NJDIODJNGGA().SetFloat("[PlayerController] ", SwitchCameraToCamera2);
			GKILCDHJFEG().SetVector("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1853f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPKKMKDOFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 25);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 865f)
			{
				HBJJOCHGOPH = 1920f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture(".completedMaps", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("Image_", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("player.quantum", BlendFX);
			NJDIODJNGGA().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("Submition failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 818f, 1333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENDDDMALLBK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 106);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CCPEDDLAMIB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLCOOJIONIL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -65);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EKCKJLFFAID()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 180f)
			{
				HBJJOCHGOPH = 895f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("Failed to InstantiateSceneObject prefab:", JDMCFBKJHDD);
			}
			CEKJODEAMGB().SetFloat("<b>Time</b>:", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_Value3", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value4", SwitchCameraToCamera2);
			NJDIODJNGGA().SetVector("menutheme.coldheat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 224f, 424f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1223f)
			{
				HBJJOCHGOPH = 151f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("RPC: 'OnAwakeRPC' PhotonView: ", JDMCFBKJHDD);
			}
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Glow_Glow", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("MultiplayerButton", BlendFX);
			HCGJCMDJPGD().SetFloat(".", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 786f, 533f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 27f)
			{
				HBJJOCHGOPH = 1436f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("_BlurPass", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("Set Sun Input", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("#,0.00", BlendFX);
			NBPKMLMCHFN.SetFloat("ConfigVersionSlider", SwitchCameraToCamera2);
			CEKJODEAMGB().SetVector("Created", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1534f, 200f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1754f)
			{
				HBJJOCHGOPH = 516f;
			}
			if (Camera2 != null)
			{
				IGKFMCPDNOI().SetTexture("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", JDMCFBKJHDD);
			}
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("music", BlendFX);
			IGKFMCPDNOI().SetFloat("FileLabel", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 79f, 1726f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void INGOODALACO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void OKLAJINHPAN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -67);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void EPEGAEGDJAM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void FINDGJLEHOL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JHBPINEKDPE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 104f)
			{
				HBJJOCHGOPH = 319f;
			}
			if (Camera2 != null)
			{
				IGKFMCPDNOI().SetTexture("JoinRandom failed: {0}.", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("#orderby:", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_TimeX", BlendFX);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.maxLongestCombo", SwitchCameraToCamera2);
			IGKFMCPDNOI().SetVector("rd", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1432f, 1932f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 177f)
			{
				HBJJOCHGOPH = 1915f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("LoadMapCanvas", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("#random #epic #item", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("#ok", BlendFX);
			CEKJODEAMGB().SetFloat("Anime", SwitchCameraToCamera2);
			IGKFMCPDNOI().SetVector("_Visualize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 750f, 1356f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDBKBPCIHBL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 106);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void MMBPLGGLPDB()
	{
	}
}
