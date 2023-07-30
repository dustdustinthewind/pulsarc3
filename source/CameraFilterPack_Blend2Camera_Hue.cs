// CameraFilterPack_Blend2Camera_Hue
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Hue")]
public class CameraFilterPack_Blend2Camera_Hue : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Hue";

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

	private void MFBCLNAHEFO()
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
	private Material MPENCEIGLEH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
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

	private void LHGFCBDACBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1297f)
			{
				HBJJOCHGOPH = 710f;
			}
			if (Camera2 != null)
			{
				NFMGLIKNOOC().SetTexture("win", JDMCFBKJHDD);
			}
			CFEDGDGBCHE().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_Parameter", BlendFX);
			CFEDGDGBCHE().SetFloat("Y", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BBKMHAFFIMD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KDMANOEMOCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void KCDAFGECAIH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -67);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JNACKHNNEPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -107);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KFEKCJDEECK()
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
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void ACBAHLCGNDD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FEHCNJLLJMP()
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

	private void OAKONCDEPPI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BMOFEBKGLFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 804f)
			{
				HBJJOCHGOPH = 298f;
			}
			if (Camera2 != null)
			{
				MPENCEIGLEH().SetTexture("_DotSize", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("Tab1Content", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("InfoCanvas", BlendFX);
			GJHPODJOBHL().SetFloat(":", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
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
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DLMPALHKMON()
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

	private void MEJPBKFMAIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void JCDPMLPNOOC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EBBMDDEFNKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -17);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IHPLMLBJELK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1475f)
			{
				HBJJOCHGOPH = 831f;
			}
			if (Camera2 != null)
			{
				KOHGPKOFEJO().SetTexture("_Red_C", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("inventory.selected.", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("[Right-Left]", BlendFX);
			ACHNOHCLGOO().SetFloat("Hex value #RRGGBB", SwitchCameraToCamera2);
			MICHFGAOPKM().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1530f, 1959f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1856f)
			{
				HBJJOCHGOPH = 24f;
			}
			if (Camera2 != null)
			{
				HILDKDFEBPF().SetTexture("_Distortion", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("_LrDepthTex", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("settings.enableranking", BlendFX);
			ELBMIEOIABA().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetVector("ChangeSelectedLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1626f, 1514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MIAMLFNACAI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LKPBGHGCPKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEIBFOHPOPD()
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

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 825f)
			{
				HBJJOCHGOPH = 14f;
			}
			if (Camera2 != null)
			{
				GJHPODJOBHL().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("#000000CC", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("red", BlendFX);
			NFMGLIKNOOC().SetFloat("SetParticlesCountPerBeat", SwitchCameraToCamera2);
			BAGICADFBAB().SetVector("_Radius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1036f, 51f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
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

	private void BGFJOEPFOPM()
	{
	}

	private void KDMKDEKCELE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAOKCECGKAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HLIAEEMGBHN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	private void PKNJBBDKJFK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void NNPBKKBFDHH()
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

	private void HNLPEJJPEGA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PMPKMGKAAJH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1416f)
			{
				HBJJOCHGOPH = 1763f;
			}
			if (Camera2 != null)
			{
				BAGICADFBAB().SetTexture("_Value2", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Light_Rainbow", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat(".lastCheckpoint.time", BlendFX);
			CFEDGDGBCHE().SetFloat("checkpoint", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("Added checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 446f, 1140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void FCGHOKACFHL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KKGMKGHFELO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MKIMDFLBFOM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICILLMAKLMI()
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

	private void JHPOIOELNCG()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1862f)
			{
				HBJJOCHGOPH = 173f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("\r\n", JDMCFBKJHDD);
			}
			BAGICADFBAB().SetFloat("_Value3", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("GroupNameText", BlendFX);
			OCMBHMLNCEK().SetFloat("Y", SwitchCameraToCamera2);
			PLBEJJIHFPB().SetVector("getbool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 805f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void ANKALNDLHEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -30);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void FINDGJLEHOL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 56f)
			{
				HBJJOCHGOPH = 1989f;
			}
			if (Camera2 != null)
			{
				DBOLLHHMKKN().SetTexture("Is Clone ?: ", JDMCFBKJHDD);
			}
			MICHFGAOPKM().SetFloat("inventory.itemscash", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Value7", BlendFX);
			MICHFGAOPKM().SetFloat("Server: {0}. Region: {1} ", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 102f, 973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 358f)
			{
				HBJJOCHGOPH = 1342f;
			}
			if (Camera2 != null)
			{
				GCDFNHMJMIP().SetTexture("CameraFilterPack/Blend2Camera_VividLight", JDMCFBKJHDD);
			}
			DBOLLHHMKKN().SetFloat(".played", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("attempted to spawn a GameObject from recycle bin (", BlendFX);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Color_Invert", SwitchCameraToCamera2);
			KHCLIAMBBNC().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1844f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
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

	private void PBEPCAPAKLG()
	{
	}

	private void DBIBFOINCKM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HMKJFPBFOFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JLNNHKPHMAB()
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
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 426f)
			{
				HBJJOCHGOPH = 459f;
			}
			if (Camera2 != null)
			{
				MPENCEIGLEH().SetTexture("ScoreText", JDMCFBKJHDD);
			}
			KBOPGONOCNP().SetFloat("_Val", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("907198288", BlendFX);
			OCMBHMLNCEK().SetFloat("_Radius", SwitchCameraToCamera2);
			MICHFGAOPKM().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1178f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 849f)
			{
				HBJJOCHGOPH = 269f;
			}
			if (Camera2 != null)
			{
				OCMBHMLNCEK().SetTexture("maps.", JDMCFBKJHDD);
			}
			NFMGLIKNOOC().SetFloat("_Value4", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", BlendFX);
			HNFFHCLNBDN().SetFloat("nd", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1086f, 751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LINKAMEPKGM()
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

	private void HPFIHLMKIPF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 66f)
			{
				HBJJOCHGOPH = 116f;
			}
			if (Camera2 != null)
			{
				KHCLIAMBBNC().SetTexture("Bad parameters for setbool! Use <key> <value>", JDMCFBKJHDD);
			}
			MICHFGAOPKM().SetFloat("_Value4", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("_Visualize", BlendFX);
			DBOLLHHMKKN().SetFloat("_Value3", SwitchCameraToCamera2);
			NFMGLIKNOOC().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIPEMDLKAGO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 1696f;
			}
			if (Camera2 != null)
			{
				CFEDGDGBCHE().SetTexture(" ", JDMCFBKJHDD);
			}
			KBOPGONOCNP().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("PopulateMapsList", BlendFX);
			GCDFNHMJMIP().SetFloat("ScreenResolutionPanel", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("settings.volume.menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void EDCMIPNCPLB()
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

	private void Update()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
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

	private void LOLHKNKBNPF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 517f)
			{
				HBJJOCHGOPH = 1983f;
			}
			if (Camera2 != null)
			{
				MPENCEIGLEH().SetTexture("_MainTex", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("Save level before uploading?", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Green_G", BlendFX);
			ELBMIEOIABA().SetFloat("_Value4", SwitchCameraToCamera2);
			KBOPGONOCNP().SetVector("time", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1436f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFIHBNJKEKD()
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
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
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

	private void MHHMIFHKEDH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 10);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void COCBPFHHLGI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -36);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKFDDNMPOJH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1825f)
			{
				HBJJOCHGOPH = 1128f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("Soundtrack", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("request", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_Threshhold", BlendFX);
			MPENCEIGLEH().SetFloat("player.xp", SwitchCameraToCamera2);
			KBOPGONOCNP().SetVector("#FFFFFF", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 607f, 1796f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BHBCNNIJECK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KMCPMOGKDEH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 424f)
			{
				HBJJOCHGOPH = 65f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_TimeX", JDMCFBKJHDD);
			}
			HNFFHCLNBDN().SetFloat("Messages (shift+tab)", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_TimeX", BlendFX);
			ELBMIEOIABA().SetFloat("_TimeX", SwitchCameraToCamera2);
			MPENCEIGLEH().SetVector("Joystick1Button8", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 409f, 1582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPBIGAKLKIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -16);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AOKOLPEGHDD()
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

	private void OOHJBHLKGDJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -83);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LMKMEJMGDFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ALNNIDLFILB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHODKHPIBLG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EAFFHHCMLCG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void NEGKFLLFLOK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GNPDGBNDCPL()
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

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1314f)
			{
				HBJJOCHGOPH = 1930f;
			}
			if (Camera2 != null)
			{
				DKNJGHFLAIF().SetTexture("PLAY [SPACE]", JDMCFBKJHDD);
			}
			GJHPODJOBHL().SetFloat("settings.fps", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("OpGetGameList not sent. Lobby cannot be null.", BlendFX);
			MPENCEIGLEH().SetFloat("]", SwitchCameraToCamera2);
			PLBEJJIHFPB().SetVector("CameraFilterPack/Blur_Blurry", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1842f, 738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 999f)
			{
				HBJJOCHGOPH = 1616f;
			}
			if (Camera2 != null)
			{
				DKNJGHFLAIF().SetTexture("] ", JDMCFBKJHDD);
			}
			MPENCEIGLEH().SetFloat("RT", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("HPText", BlendFX);
			NFMGLIKNOOC().SetFloat("_Value4", SwitchCameraToCamera2);
			NFMGLIKNOOC().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 744f, 1369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1509f)
			{
				HBJJOCHGOPH = 1583f;
			}
			if (Camera2 != null)
			{
				HNFFHCLNBDN().SetTexture("#or", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ColoredChange", BlendFX);
			OIBHFCLJKDB().SetFloat("GameModeText", SwitchCameraToCamera2);
			NFMGLIKNOOC().SetVector("InfoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1265f, 594f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEAGPJBGBMH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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

	private void FKEJGBFDCAH()
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

	private void AJENCHHLHKF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HOPAMNJIBHA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AMHEJBMLFNM()
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

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1013f)
			{
				HBJJOCHGOPH = 1525f;
			}
			if (Camera2 != null)
			{
				OIBHFCLJKDB().SetTexture("map.data", JDMCFBKJHDD);
			}
			KOHGPKOFEJO().SetFloat("scn", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("leave", BlendFX);
			MPENCEIGLEH().SetFloat("arcs", SwitchCameraToCamera2);
			KBOPGONOCNP().SetVector("_Val2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1460f, 542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void HIAICHPPGBP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void LJEDJDGPGFG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 1282f;
			}
			if (Camera2 != null)
			{
				HILDKDFEBPF().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("winter2020", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("&", BlendFX);
			NBPKMLMCHFN.SetFloat("Set the end of the map. Use this if you want to cut the long music.", SwitchCameraToCamera2);
			OCMBHMLNCEK().SetVector(". Set PhotonNetwork.OnEventCall.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1594f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFELOCODMPJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EKPLGFAEOBE()
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

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 114f)
			{
				HBJJOCHGOPH = 863f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("CameraFilterPack/3D_Binary", JDMCFBKJHDD);
			}
			HILDKDFEBPF().SetFloat("Keypad", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("#,0.00", BlendFX);
			GJHPODJOBHL().SetFloat("settings_bindings_sec_", SwitchCameraToCamera2);
			GCDFNHMJMIP().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1125f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 790f)
			{
				HBJJOCHGOPH = 613f;
			}
			if (Camera2 != null)
			{
				NFMGLIKNOOC().SetTexture("speed", JDMCFBKJHDD);
			}
			KHCLIAMBBNC().SetFloat("_Offsets", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("_ScreenResolution", BlendFX);
			KBOPGONOCNP().SetFloat("player.rgb", SwitchCameraToCamera2);
			GCDFNHMJMIP().SetVector("SettingsCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1929f, 1957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void DAHFFNNIGML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GBGAMCPNBCC()
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
}
